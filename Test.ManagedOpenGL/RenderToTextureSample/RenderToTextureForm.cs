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
		private readonly Skybox skybox = Skybox.CreateFromFolder( 100, 100, 100, @"Data\SkyBox\CubeMap2", "png" );

		private readonly RenderTexture renderTexture = new RenderTexture( 256, 256 );

		private readonly Cube cube = new Cube( 20, 20, 20 );
		private float angle;
		private readonly Texture2D back  = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );

		public RenderToTextureForm()
		{
			camera.Position.Set( 0, 0, 50 );
			Renderer.Far = 1000;
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			this.skybox.Load();

			this.renderTexture.Load();

			back.Load();
		}

		protected override void Draw()
		{
			base.Draw();

			renderTexture.PrepareForRender();
			this.DrawCube();
			renderTexture.Copy();
			renderTexture.RestoreRenderToTexture();

			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.Enable( EnableCap.Texture2d );
			renderTexture.Use();
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
	}
}