/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 11.06.2008 14:43
 *
 * File: NormalMapSampleForm.cs
 * Remarks:
 * 
 * History:
 *   11.06.2008 14:43 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Drawing;
using System.IO;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.NormalMapSample
{
	public class NormalMapSampleForm : SampleOpenGLForm
	{
		private const string vertexShaderFileName = "Data\\NormalMap\\shader.vert";
		private const string fragmentShaderFileName = "Data\\NormalMap\\shader.frag";

		private readonly Cube cube = new Cube( 20, 20, 20 );
		private readonly Texture2D texture = new Texture2D( "Data\\NormalMap\\Fieldstone.png" );
		private readonly Texture2D normalMapTexture = new Texture2D( "Data\\NormalMap\\FieldstoneBumpDOT3.png" );

		private readonly string vertexShaderSource;
		private readonly string fragmentShaderSource;

		private uint program;
		private uint vertexShaderObject;
		private uint fragmentShaderObject;
		private int textureSamplerLocation;
		private int normalMapSamplerLocation;
		private int camPositionLocation;

		public NormalMapSampleForm()
		{
			WindowSize = new Size( 640, 480 );

			Renderer.Far = 100;
			Renderer.Near = 1;

			camera.Position.Set( 0, 0, 50 );

			this.vertexShaderSource   = this.ReadShaderSource( vertexShaderFileName );
			this.fragmentShaderSource = this.ReadShaderSource( fragmentShaderFileName );

		}

		public string ReadShaderSource( string fileName ) 
		{
			if (!File.Exists( fileName )) throw new Exception( "Can't find file: " + fileName );
			using (var shaderReader = new StreamReader( fileName )) return shaderReader.ReadToEnd();
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			texture.Load();
			normalMapTexture.Load();

			this.vertexShaderObject = gl.CreateShaderObjectARB( (uint)VERSION_2_0.VertexShader );
			this.fragmentShaderObject = gl.CreateShaderObjectARB( (uint)VERSION_2_0.FragmentShader );
			this.program = gl.CreateProgram();

			gl.AttachObjectARB( program, vertexShaderObject );
			gl.AttachObjectARB( program, fragmentShaderObject );

			gl.ShaderSourceARB( vertexShaderObject, 1, new[] { vertexShaderSource }, null );
			gl.ShaderSourceARB( fragmentShaderObject, 1, new[] { fragmentShaderSource }, null );

			gl.CompileShaderARB( vertexShaderObject );
			gl.CompileShaderARB( fragmentShaderObject );

			var vertexCompileResult = new int[1];
			var fragmentCompileResult = new int[1];

			gl.GetObjectParameterivARB( vertexShaderObject, (uint)ARB_shader_objects.ObjectCompileStatusArb, vertexCompileResult );
			gl.GetObjectParameterivARB( fragmentShaderObject, (uint)ARB_shader_objects.ObjectCompileStatusArb, fragmentCompileResult );

			if (vertexCompileResult[0] == 0)
				throw new Exception( "Error in vertex shader: " + OpenGL.GetInfoLog( vertexShaderObject ) );
			if (fragmentCompileResult[0] == 0)
				throw new Exception( "Error in fragment shader: " + OpenGL.GetInfoLog( fragmentShaderObject ) );

			gl.LinkProgramARB( program );

			var programLinkResult = new int[1];

			gl.GetObjectParameterivARB( program, (uint)ARB_shader_objects.ObjectLinkStatusArb, programLinkResult );

			if (programLinkResult[0] == 0)
				throw new Exception( "Error link program: " + OpenGL.GetInfoLog( program ) );

			this.textureSamplerLocation = gl.GetUniformLocation( program, "texture" );
			this.normalMapSamplerLocation = gl.GetUniformLocation( program, "normalMap" );
			this.camPositionLocation = gl.GetUniformLocation( program, "camPosition" );

			if (this.textureSamplerLocation < 0) throw new Exception( "Can't find uniform `texture`" );
			if (this.normalMapSamplerLocation < 0) throw new Exception( "Can't find uniform `normalMap`" );
			if (this.camPositionLocation < 0) throw new Exception( "Can't find uniform `camPosition`" );

			gl.UseProgramObjectARB( program );
			gl.Uniform1iARB( textureSamplerLocation, 0 );
			gl.Uniform1iARB( normalMapSamplerLocation, 1 );
		}

		protected override void Draw() 
		{
			gl.ClearColor( 0, 0, 0, 0 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadMatrixf( camera.Data );

			gl.Enable( EnableCap.CullFace );
			gl.Enable( EnableCap.DepthTest );

			gl.ActiveTextureARB( (uint)ARB_multitexture.Texture0Arb );
			texture.Use();
			gl.ActiveTextureARB( (uint)ARB_multitexture.Texture1Arb );
			normalMapTexture.Use();

			gl.Color3f( 1, 1, 1 );
			gl.UseProgramObjectARB( program );
			gl.Uniform3fARB( camPositionLocation, camera.Position.X, camera.Position.Y, camera.Position.Z );
			cube.Draw();
		}
	}
}