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
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.NormalMapSample
{
	public class NormalMapSampleForm : SampleOpenGLForm
	{
		private class NormalMapShaderProgram : ShaderProgram
		{
			private int textureSamplerLocation;
			private int normalMapSamplerLocation;
			private int camPositionLocation;

			public int TextureUnit { get; set; }

			public int NormalMapUnit { get; set; }

			public Vector3F CamPosition { get; set; }

			protected override void AfterLink() 
			{
				base.AfterLink();

				this.textureSamplerLocation = GetUniformLocation( "texture" );
				this.normalMapSamplerLocation = GetUniformLocation( "normalMap" );
				this.camPositionLocation = GetUniformLocation( "camPosition" );
			}

			public override void Use() 
			{
				base.Use();

				OpenGLNative.Uniform1iARB( this.textureSamplerLocation, this.TextureUnit );
				OpenGLNative.Uniform1iARB( this.normalMapSamplerLocation, this.NormalMapUnit );
				OpenGLNative.Uniform3fARB( this.camPositionLocation, this.CamPosition.X, this.CamPosition.Y, this.CamPosition.Z );
			}
		}

		private const string vertexShaderFileName = "Data\\NormalMap\\shader.vert";
		private const string fragmentShaderFileName = "Data\\NormalMap\\shader.frag";

		private readonly Cube cube = new Cube( 20, 20, 20 );
		private readonly Texture2D texture = new Texture2D( "Data\\NormalMap\\Fieldstone.png" );
		private readonly Texture2D normalMapTexture = new Texture2D( "Data\\NormalMap\\FieldstoneBumpDOT3.png" );

		private readonly VertexShader vertexShader = VertexShader.Load( vertexShaderFileName );
		private readonly FragmentShader fragmentShader = FragmentShader.Load( fragmentShaderFileName );
		private readonly NormalMapShaderProgram shaderProgram = new NormalMapShaderProgram();

		public NormalMapSampleForm()
		{
			WindowSize = new Size( 640, 480 );

			Renderer.Far = 100;
			Renderer.Near = 1;

			camera.Position.Set( 0, 0, 50 );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			texture.Load();
			normalMapTexture.Load();

			this.vertexShader.Load();
			this.fragmentShader.Load();

			this.vertexShader.Compile();
			this.fragmentShader.Compile();

			if (!vertexShader.Compiled)
				throw new Exception( "Error in vertex shader: " + vertexShader.InfoLog );
			if (!fragmentShader.Compiled)
				throw new Exception( "Error in fragment shader: " + fragmentShader.InfoLog );

			shaderProgram.Load();

			shaderProgram.Attach( vertexShader );
			shaderProgram.Attach( fragmentShader );

			shaderProgram.Link();

			if (!shaderProgram.Linked)
				throw new Exception( "Error link program: " + shaderProgram.InfoLog );

			shaderProgram.TextureUnit = 0;
			shaderProgram.NormalMapUnit = 1;
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
			shaderProgram.CamPosition = camera.Position;
			shaderProgram.Use();
			cube.Draw();
		}
	}
}