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

		private readonly TextureCubeMap cubeMap1 = new TextureCubeMap( @"Data\SkyBox\CubeMap2\back.png",
		                                                               @"Data\SkyBox\CubeMap2\front.png",
		                                                               @"Data\SkyBox\CubeMap2\left.png",
		                                                               @"Data\SkyBox\CubeMap2\right.png",
		                                                               @"Data\SkyBox\CubeMap2\bottom.png",
		                                                               @"Data\SkyBox\CubeMap2\top.png" );

		private readonly TextureCubeMap cubeMap2 = new TextureCubeMap( @"Data\SkyBox\CubeMap2\back.png",
		                                                               @"Data\SkyBox\CubeMap2\front.png",
		                                                               @"Data\SkyBox\CubeMap2\left.png",
		                                                               @"Data\SkyBox\CubeMap2\right.png",
		                                                               @"Data\SkyBox\CubeMap2\bottom.png",
		                                                               @"Data\SkyBox\CubeMap2\top.png" );

		private readonly Font font = new Font( @"Data\Fonts\LC_B.jpg" );

		private readonly PositionedSphere sphere1 = new PositionedSphere( 20, 32, 32, +30, 0, 0 );
		private readonly PositionedSphere sphere2 = new PositionedSphere( 20, 32, 32, -30, 0, 0 );

		private readonly CubeMapCamera cubeMapCamera = new CubeMapCamera();

		private readonly EmptyTexture2D emptyTexture2D = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );

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

			this.cubeMap1.Load();
			this.cubeMap2.Load();

			this.LoadSphere2CubeMap();

			emptyTexture2D.Load();
		}

		private void LoadSphere2CubeMap() 
		{
			var width = 256;
			var height = 256;
			this.PrepareRenderToTexture( width, height );

			this.cubeMapCamera.Position.Set( this.sphere2.X, this.sphere2.Y, this.sphere2.Z );

			gl.ClearColor( 0, 0, 0, 1 );

			this.RenderScene( this.cubeMapCamera.LeftCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToLeft( 0, 0, width, height );

			this.RenderScene( this.cubeMapCamera.RightCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToRight( 0, 0, width, height );

			this.RenderScene( this.cubeMapCamera.BottomCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToBottom( 0, 0, width, height );

			this.RenderScene( this.cubeMapCamera.TopCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToTop( 0, 0, width, height );

			this.RenderScene( this.cubeMapCamera.FarCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToFront( 0, 0, width, height );

			this.RenderScene( this.cubeMapCamera.NearCamera, true );
			this.cubeMap2.Use();
			this.cubeMap2.CopyToBack( 0, 0, width, height );

			this.RestoreRenderToTexture();
		}

		protected override void Draw() 
		{
			base.Draw();

			//cubeMapCamera.Position.Set( sphere2.X, sphere2.Y, sphere2.Z );

			//LoadSphere2CubeMap();
			//PrepareRenderToTexture( 256, 256 );
			//cubeMap1.Use();
			//RenderScene( cubeMapCamera.RightCamera, true );
			//RestoreRenderToTexture();

			//return;

			Renderer.RenderMode = RenderMode.MODE_3D;

			gl.Enable( EnableCap.Texture2d );

			gl.Enable( EnableCap.DepthTest );
			gl.Disable( EnableCap.CullFace );

			cubeMapCamera.Position.Set( sphere2.X, sphere2.Y, sphere2.Z );

			PrepareRenderToTexture( 256, 256 );
			RenderScene( cubeMapCamera.LeftCamera, true );
			RestoreRenderToTexture();

			gl.Viewport( 0, 0, WindowSize.Width, WindowSize.Height );
			//RenderScene( camera, false );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadIdentity();
			gl.Translatef( 0, 0, -50 );

			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			RenderScene( camera, false );

			//PrepareRenderToTexture( 256, 256 );
			//RenderScene( camera, false );
			//emptyTexture2D.Copy( 0, 0, 256, 256 );
			//RestoreRenderToTexture();


			//gl.Begin( BeginMode.Quads );

			//gl.TexCoord2f( 0, 0 );
			//gl.Vertex3f( -10, -10, 0 );

			//gl.TexCoord2f( 1, 0 );
			//gl.Vertex3f( +10, -10, 0 );

			//gl.TexCoord2f( 1, 1 );
			//gl.Vertex3f( +10, +10, 0 );

			//gl.TexCoord2f( 0, 1 );
			//gl.Vertex3f( -10, +10, 0 );

			//gl.End();
		}

		public void RenderScene( Camera renderCamera, bool invert )
		{
			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadIdentity();
			gl.MultMatrixf( renderCamera.Data );
			//if (invert) gl.Scalef( -1, -1, 1 );

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			gl.Enable( EnableCap.Texture2d );
			gl.Disable( (EnableCap)VERSION_1_3.TextureCubeMap );
			TextureCubeMap.UnUse();
			this.skybox.Draw();

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();
			gl.Scalef( 1, 1, -1 );
			gl.MultMatrixf( renderCamera.InvertData );

			gl.Disable( EnableCap.Texture2d );
			gl.Enable( (EnableCap)VERSION_1_3.TextureCubeMap );

			cubeMap1.Use();
			sphere1.Draw();

			cubeMap2.Use();
			sphere2.Draw();

			TextureCubeMap.UnUse();
		}

		public void PrepareRenderToTexture( int width, int height )
		{
			gl.Viewport( 0, 0, width, height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PushMatrix();
			gl.LoadIdentity();
			gl.Frustum( -1, 1, -1, 1, 1, 10000 );
			//gl.Scalef( -1, -1, -1 );
		}

		public void RestoreRenderToTexture()
		{
			gl.Viewport( 0, 0, WindowSize.Width, WindowSize.Height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PopMatrix();
		}
	}
}