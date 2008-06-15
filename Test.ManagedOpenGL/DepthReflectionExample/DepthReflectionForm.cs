/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 11:59
 *
 * File: DepthReflectionForm.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 11:59 - Create Wireframe
 *
 *******************************************************/

using System;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.DepthReflectionExample
{
	public class DepthReflectionForm : SampleOpenGLForm
	{
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

		private readonly Font font = new Font( @"Data\Fonts\LC_B.jpg" );

		private readonly PositionedSphere sphere1 = new PositionedSphere( 20, 32, 32, +100, 0, 0 );
		private readonly PositionedSphere sphere2 = new PositionedSphere( 20, 32, 32, -100, 0, 0 );

		private readonly CubeMapCamera cubeMapCamera = new CubeMapCamera();

		public DepthReflectionForm()
		{
			this.skybox = new Skybox( 4000, 4000, 4000, this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 );
			this.camera.Position.Set( 0, 0, 100 );

			Renderer.Far = 10000;
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();
			
			this.textureCubeMap.Load();
			this.skybox.Load();

			this.font.Load();
		}

		protected override void Draw() 
		{
			base.Draw();

			Renderer.RenderMode = RenderMode.MODE_3D;

			gl.Enable( EnableCap.Texture2d );

			gl.Enable( EnableCap.DepthTest );
			gl.Disable( EnableCap.CullFace );

			//this.PrepareRenderToTexture( 256, 256 );
			//this.RestoreRenderToTexture();

			//cubeMapCamera.Position.Set( sphere1.X, sphere1.Y, sphere1.Z );
			RenderScene( camera );

			Renderer.RenderMode = RenderMode.MODE_2D;

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			font.WriteLine( 0, 10, "Pitch: {0}, Yaw: {0}", camera.Pitch, camera.Yaw );
		}

		public void RenderScene( Camera renderCamera )
		{
			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadMatrixf( renderCamera.Data );

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			this.skybox.Draw();

			textureCubeMap.Use();

			gl.MatrixMode( MatrixMode.Texture );
			gl.Scalef( 1, 1, -1 );
			gl.MultMatrixf( renderCamera.InvertData );

			sphere1.Draw();

			sphere2.Draw();

			textureCubeMap.UnUse();
		}

		public void PrepareRenderToTexture( int width, int height )
		{
			gl.Viewport( 0, 0, width, height );
			gl.MatrixMode( MatrixMode.Projection );
			//gl.PushMatrix();
			gl.Frustum( -1, 1, -1, 1, 1, Renderer.Far );
		}

		public void RestoreRenderToTexture()
		{
			gl.Viewport( 0, 0, WindowSize.Width, WindowSize.Height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PopMatrix();
		}
	}
}