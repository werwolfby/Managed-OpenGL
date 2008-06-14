/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 14.06.2008 13:31
 *
 * File: EnviromentCubeMapForm.cs
 * Remarks:
 * 
 * History:
 *   14.06.2008 13:31 - Create Wireframe
 *   14.06.2008 18:26 - Copy from `NormalizeCubeMapForm.cs`
 *
 *******************************************************/

using System;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.EnviromentCubeMapSample
{
	public class EnviromentCubeMapForm : SampleOpenGLForm
	{
		private const string vertexShaderFileName = @"Data\EnviromentCubeMap\normalized_cube_map.vert";
		private const string fragmentShaderFileName = @"Data\EnviromentCubeMap\normalized_cube_map.frag";

		private readonly Texture2D back1   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front1  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left1   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right1  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom1 = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top1    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly Skybox skybox;
		private readonly TextureCubeMap textureCubeMap = new TextureCubeMap( @"Data\SkyBox\CubeMap2\back.png",
		                                                                     @"Data\SkyBox\CubeMap2\front.png",
		                                                                     @"Data\SkyBox\CubeMap2\left.png",
		                                                                     @"Data\SkyBox\CubeMap2\right.png",
		                                                                     @"Data\SkyBox\CubeMap2\bottom.png",
		                                                                     @"Data\SkyBox\CubeMap2\top.png" );

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

				this.cubeMapSamplerLocation = this.GetUniformLocation( "cubeMapTexture" );
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

		public EnviromentCubeMapForm()
		{
			this.skybox = new Skybox( 300, 300, 300, this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 );
			this.camera.Position.Set( 0, 0, 50 );

			this.currentDrawObject = this.cube;
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();
			this.skybox.Load();
			this.textureCubeMap.Load();

			this.vertexShader.Load();
			this.fragmentShader.Load();

			this.shader.Load();

			this.vertexShader.TryCompile();
			this.fragmentShader.TryCompile();

			this.shader.Attach( this.vertexShader );
			this.shader.Attach( this.fragmentShader );

			this.shader.TryLink();
		}

		protected override void Draw() 
		{
			base.Draw();

			gl.Enable( EnableCap.Texture2d );
			
			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			ShaderProgram.UnUse();

			this.skybox.Draw();

			gl.MatrixMode( MatrixMode.Texture );
			gl.Scalef( 1, 1, - 1 );
			gl.MultMatrixf( this.camera.InvertData );

			this.textureCubeMap.Use();

			this.shader.Use();
			this.currentDrawObject.Draw();
			this.textureCubeMap.UnUse();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.D1 )) this.currentDrawObject = this.cube;
			if (Keyboard.GetValue( Keys.D2 )) this.currentDrawObject = this.sphere;
		}
	}
}