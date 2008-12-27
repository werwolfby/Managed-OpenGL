/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 14.06.2008 13:31
 *
 * File: NormalizeCubeMapForm.cs
 * Remarks:
 * 
 * History:
 *   14.06.2008 13:31 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.NormalizeCubeMapSample
{
	public class NormalizeCubeMapForm : SampleOpenGLForm
	{
		private const string vertexShaderFileName = @"Data\NormalizeCubeMap\normalized_cube_map.vert";
		private const string fragmentShaderFileName = @"Data\NormalizeCubeMap\normalized_cube_map.frag";

		private readonly Texture2D back1   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front1  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left1   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right1  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom1 = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top1    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly Skybox skybox;
		private readonly TextureCubeMap textureCubeMap = TextureCubeMap.CreateFromFolder( @"Data\SkyBox\CubeMap2", "png" );

		private readonly VertexShader vertexShader = VertexShader.Load( vertexShaderFileName );
		private readonly FragmentShader fragmentShader = FragmentShader.Load( fragmentShaderFileName );

		private readonly NormalizedShader shader = new NormalizedShader
		                                           {
		                                           	CubeMapSamplerUnit = 0
		                                           };

		private class NormalizedShader : ShaderProgram
		{
			private int cubeMapSamplerLocation;

			public int CubeMapSamplerUnit { get; set; }

			protected override void AfterLink() 
			{
				base.AfterLink();

				this.cubeMapSamplerLocation = GetUniformLocation( "cubeMapTexture" );
			}

			public override void Use() 
			{
				base.Use();

				OpenGLNative.Uniform1iARB( this.cubeMapSamplerLocation, this.CubeMapSamplerUnit );
			}
		}

		private const float size = 20;
		private const int devide = 24;

		private readonly Cube cube = new Cube( size, size, size );
		private readonly Sphere sphere = new Sphere( (float)(size * Math.Sqrt( 3 ) / 2.0f), devide, devide );

		private DrawObject currentDrawObject;

		public NormalizeCubeMapForm()
		{
			this.skybox = new Skybox( 300, 300, 300, this.back1, front1, left1, right1, bottom1, top1 );
			camera.Position.Set( 0, 0, 50 );

			currentDrawObject = cube;
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();
			skybox.Load();
			textureCubeMap.Load();

			vertexShader.Load();
			fragmentShader.Load();

			shader.Load();

			vertexShader.TryCompile();
			fragmentShader.TryCompile();

			shader.Attach( vertexShader );
			shader.Attach( fragmentShader );

			shader.TryLink();
		}

		protected override void Draw() 
		{
			base.Draw();

			gl.Enable( EnableCap.Texture2d );
			
			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			ShaderProgram.UnUse();

			skybox.Draw();

			gl.MatrixMode( MatrixMode.Texture );
			gl.Scalef( 1, 1, - 1 );
			gl.MultMatrixf( camera.InvertData );

			textureCubeMap.Use();

			shader.Use();
			currentDrawObject.Draw();
			TextureCubeMap.UnUse();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.D1 )) currentDrawObject = cube;
			if (Keyboard.GetValue( Keys.D2 )) currentDrawObject = sphere;
		}
	}
}