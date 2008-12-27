/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 17:50
 *
 * File: RenderToTextureForm.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 17:50 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.RenderToTextureSample
{
	public class RenderToTextureForm : SampleOpenGLForm
	{
		private readonly Skybox skybox = new Skybox( 100, 100, 100,
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\back.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\front.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\left.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\right.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\top.png" ) );

		private readonly EmptyTexture2D emptyTexture2D = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );

		private readonly Texture2D texture2D = new Texture2D( @"Data\Fonts\Simple.jpg" );

		private readonly Cube cube = new Cube( 20, 20, 20 );
		private float angle;
		private readonly Texture2D back;

		public RenderToTextureForm()
		{
			camera.Position.Set( 0, 0, 50 );
			Renderer.Far = 10000;
			this.back = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			this.texture2D.Load();
			this.skybox.Load();

			this.emptyTexture2D.Load();

			back.Load();
		}

		protected override void Draw()
		{
			base.Draw();

			PrepareRenderToTexture( 0, 0, 256, 256 );
			this.DrawCube();
			emptyTexture2D.Copy( 0, 0, 256, 256 );
			RestoreRenderToTexture();

			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.Enable( EnableCap.Texture2d );
			emptyTexture2D.Use();
			cube.Draw();
			gl.Disable( EnableCap.Texture2d );
		}

		private void DrawCube() 
		{
			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.PushMatrix();
			gl.LoadIdentity();

			gl.Enable( EnableCap.Texture2d );
			gl.Rotatef( this.angle, 0, 1, 0 );
			this.skybox.Draw();
			gl.Rotatef( -this.angle, 0, 1, 0 );

			back.Use();

			gl.Translatef( 0, 0, -50 );
			gl.Rotatef( this.angle, 1, 0, 0 );
			this.cube.Draw();
			gl.PopMatrix();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			angle += 30 * elapsed;
		}

		private static void PrepareRenderToTexture( int x, int y, int w, int h )
		{
			gl.Viewport( x, y, w, h );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PushMatrix();
			gl.LoadIdentity();
			gl.Frustum( -1, 1, -1, 1, 1, 1000 );
		}

		private static void RestoreRenderToTexture()
		{
			gl.Viewport( 0, 0, Renderer.WindowSize.Width, Renderer.WindowSize.Height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PopMatrix();
		}
	}
}