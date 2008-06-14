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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagedOpenGL;
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

			public int TangentAttribLocation { get; private set; }

			public int BinormalAttribLocation { get; private set; }

			protected override void AfterLink() 
			{
				base.AfterLink();

				this.textureSamplerLocation = GetUniformLocation( "texture" );
				this.normalMapSamplerLocation = GetUniformLocation( "normalMap" );
				this.camPositionLocation = GetUniformLocation( "camPosition" );

				this.TangentAttribLocation = GetAttribLocation( "tangent" );
				this.BinormalAttribLocation = GetAttribLocation( "binormal" );
			}

			public override void Use() 
			{
				base.Use();

				OpenGLNative.Uniform1iARB( this.textureSamplerLocation, this.TextureUnit );
				OpenGLNative.Uniform1iARB( this.normalMapSamplerLocation, this.NormalMapUnit );
				OpenGLNative.Uniform3fvARB( this.camPositionLocation, 1, this.CamPosition.Data );
			}
		}

		private const string vertexShaderFileName = "Data\\NormalMap\\shader.vert";
		private const string fragmentShaderFileName = "Data\\NormalMap\\shader.frag";

		private const float size = 20;
		private const int devide = 24;

		private readonly Cube cube = new Cube( size, size, size );
		private readonly Sphere sphere = new Sphere( (float)(size * Math.Sqrt( 3 ) / 2.0f), devide, devide );
		private DrawObject drawObject;

		private readonly Texture2D texture = new Texture2D( "Data\\NormalMap\\Fieldstone.png" )
		                                     {
		                                     	WrapS = TextureWrapMode.Repeat,
		                                     	WrapT = TextureWrapMode.Repeat
		                                     };

		private readonly Texture2D normalMapTexture = new Texture2D( "Data\\NormalMap\\FieldstoneBumpDOT3.png" )
		                                              {
		                                              	WrapS = TextureWrapMode.Repeat,
		                                              	WrapT = TextureWrapMode.Repeat
		                                              };

		private readonly VertexShader vertexShader = VertexShader.Load( vertexShaderFileName );
		private readonly FragmentShader fragmentShader = FragmentShader.Load( fragmentShaderFileName );
		private readonly NormalMapShaderProgram shaderProgram = new NormalMapShaderProgram();

		public NormalMapSampleForm()
		{
			WindowSize = new Size( 640, 480 );

			Renderer.Far = 100;
			Renderer.Near = 1;

			camera.Position.Set( 0, 0, 50 );

			drawObject = cube;
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
			shaderProgram.CamPosition = camera.Position;

			cube.TangentVectorAttributeIndex = shaderProgram.TangentAttribLocation;
			cube.BinormalVectorAttributeIndex = shaderProgram.BinormalAttribLocation;

			sphere.TangentVectorAttributeIndex = shaderProgram.TangentAttribLocation;
			sphere.BinormalVectorAttributeIndex = shaderProgram.BinormalAttribLocation;
		}

		private double alpha = 0.0;

		protected override void Draw() 
		{
			gl.ClearColor( 0, 0, 0, 0 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.Disable( EnableCap.CullFace );
			gl.Enable( EnableCap.DepthTest );

			gl.ActiveTextureARB( (uint)ARB_multitexture.Texture0Arb );
			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();
			gl.Scalef( 3, 3, 1 );
			texture.Use();
			gl.ActiveTextureARB( (uint)ARB_multitexture.Texture1Arb );
			normalMapTexture.Use();

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadMatrixf( camera.Data );
			gl.Rotated( alpha, 0, 1, 0 );

			gl.Color3f( 1, 1, 1 );
			shaderProgram.CamPosition = camera.Position;
			shaderProgram.Use();
			drawObject.Draw();
		}

		private bool pause = true;

		protected override void Update( float elapsed ) 
		{
			if (Keyboard.GetValue( Keys.Space )) pause ^= true;

			if (Keyboard.GetValue( Keys.D1 )) drawObject = cube;
			if (Keyboard.GetValue( Keys.D2 )) drawObject = sphere;

			if (!pause) alpha += 1 * 90 * elapsed;

			base.Update( elapsed );
		}
	}
}