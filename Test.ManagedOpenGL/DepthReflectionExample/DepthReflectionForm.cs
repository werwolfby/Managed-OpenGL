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
		private readonly TextureCubeMap textureCubeMap = new TextureCubeMap( @"Data\SkyBox\CubeMap1\back.jpg",
		                                                                     @"Data\SkyBox\CubeMap1\front.jpg",
		                                                                     @"Data\SkyBox\CubeMap1\left.jpg",
		                                                                     @"Data\SkyBox\CubeMap1\right.jpg",
		                                                                     @"Data\SkyBox\CubeMap1\bottom.jpg",
		                                                                     @"Data\SkyBox\CubeMap1\top.jpg" );

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
		
		private readonly EmptyTexture2D emptyTexture2DLeft = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );
		private readonly EmptyTexture2D emptyTexture2DRight = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );
		private readonly EmptyTexture2D emptyTexture2DBottom = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );
		private readonly EmptyTexture2D emptyTexture2DTop = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );
		private readonly EmptyTexture2D emptyTexture2DFar = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );
		private readonly EmptyTexture2D emptyTexture2DNear = new EmptyTexture2D( 256, 256, 4, PixelFormat.Rgb );

		private readonly EmptyTexture2D[] drawTextures;

		public DepthReflectionForm()
		{
			this.skybox = new Skybox( 4000, 4000, 4000, this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 );
			this.camera.Position.Set( 0, 0, 100 );

			Renderer.Far = 10000;

			this.drawTextures = new[]
			                    {
			                    	emptyTexture2DLeft, emptyTexture2DRight,
			                    	emptyTexture2DBottom, emptyTexture2DTop,
			                    	emptyTexture2DFar, emptyTexture2DNear,
			                    };
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();
			
			this.textureCubeMap.Load();
			this.skybox.Load();

			this.font.Load();

			this.cubeMap1.Load();
			this.cubeMap2.Load();
			TextureCubeMap.UnUse();

			this.emptyTexture2D.Load();

			this.emptyTexture2DLeft.Load();
			this.emptyTexture2DRight.Load();
			this.emptyTexture2DBottom.Load();
			this.emptyTexture2DTop.Load();
			this.emptyTexture2DFar.Load();
			this.emptyTexture2DNear.Load();

			this.TempRender();
		}

		protected override void Draw() 
		{
			TextureCubeMap.UnUse();
			base.Draw();

			gl.Enable( EnableCap.Texture2d );
			skybox.Draw();
			gl.Disable( EnableCap.Texture2d );

			this.textureCubeMap.Use();
			gl.MatrixMode( MatrixMode.Texture );
			gl.PushMatrix();
			gl.Scalef( 1, -1, -1 );
			gl.MultMatrixf( camera.InvertData );
			tempSphere.Draw();
			gl.PopMatrix();
			TextureCubeMap.UnUse();

			//gl.MatrixMode( MatrixMode.Modelview );
			//gl.Enable( EnableCap.Texture2d );
			//for (var i = 0; i < 6; i++)
			//{
			//    gl.PushMatrix();
			//    gl.MultMatrixf( cubeMapCamera.Cameras[i].InvertData );
			//    gl.Translatef( 0, 0, -50 );

			//    this.drawTextures[i].Use();

			//    gl.Begin( BeginMode.Quads );

			//    gl.TexCoord2f( 0, 0 );
			//    gl.Vertex3f( -20, -20, 0 );
				
			//    gl.TexCoord2f( 1, 0 );
			//    gl.Vertex3f(  20, -20, 0 );
				
			//    gl.TexCoord2f( 1, 1 );
			//    gl.Vertex3f(  20,  20, 0 );
				
			//    gl.TexCoord2f( 0, 1 );
			//    gl.Vertex3f( -20,  20, 0 );

			//    gl.End();

			//    gl.PopMatrix();
			//}
			//gl.Disable( EnableCap.Texture2d );
		}

		private void TempRender()
		{
			this.cubeMapCamera.Position.Set( 0, 0, 0 );

			var width = 256;
			var height = 256;
			this.PrepareRenderToTexture( width, height );

			for (var i = 0; i < 6; i++)
			{
				gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );
				this.RenderScene( this.cubeMapCamera.Cameras[i].InvertData );
				this.textureCubeMap.Use();
				this.textureCubeMap.CopyTo( i, 0, 0, width, height );
				TextureCubeMap.UnUse();
			}

			this.RestoreRenderToTexture();
		}

		private Sphere tempSphere = new Sphere( 50, 32, 32 );

		private void RenderScene( float[] data )
		{
			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadIdentity();
			gl.LoadMatrixf( data );

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();

			gl.Enable( EnableCap.Texture2d );
			this.skybox.Draw();
			gl.Disable( EnableCap.Texture2d );

			gl.MatrixMode( MatrixMode.Texture );
			gl.LoadIdentity();
			gl.Scalef( 1, 1, -1 );
			//gl.MultMatrixf( renderCamera.InvertData );

			//gl.Enable( (EnableCap)VERSION_1_3.TextureCubeMap );

			//cubeMap1.Use();
			//sphere1.Draw();

			//cubeMap2.Use();
			//sphere2.Draw();

			//gl.Disable( (EnableCap)VERSION_1_3.TextureCubeMap );
			//TextureCubeMap.UnUse();
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