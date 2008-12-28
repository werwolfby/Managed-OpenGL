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

using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.DepthReflectionExample
{
	public class DepthReflectionForm : SampleOpenGLForm
	{
		private readonly Skybox skybox = Skybox.CreateFromFolder( 4000, 4000, 4000, @"Data\SkyBox\CubeMap2", "png" );

		private readonly TextureCubeMap cubeMap1 = TextureCubeMap.CreateFromFolder( @"Data\SkyBox\CubeMap2", "png" );
		private readonly TextureCubeMap cubeMap2 = TextureCubeMap.CreateFromFolder( @"Data\SkyBox\CubeMap2", "png" );

		private readonly Font font = new Font( @"Data\Fonts\LC_B.jpg" );

		private readonly PositionedSphere sphere1 = new PositionedSphere( 20, 32, 32, +30, 0, 0 );
		private readonly PositionedSphere sphere2 = new PositionedSphere( 20, 32, 32, -30, 0, 0 );

		private readonly MatrixRenderTexture leftRenderTexture;

		private readonly EmptyCubeMapTexture emptyCubeMapTexture = new EmptyCubeMapTexture( 256, 256, 4 );

		public DepthReflectionForm()
		{
			this.leftRenderTexture = new MatrixRenderTexture( 256, 256, Matrix4F.IdentityMatrix );

			this.camera.Position.Set( 0, 0, 100 );

			Renderer.Far = 10000;
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();
			
			this.skybox.Load();

			this.font.Load();

			this.cubeMap1.Load();
			this.cubeMap2.Load();

			this.leftRenderTexture.Load();

			this.emptyCubeMapTexture.Load();
		}

		protected override void Draw()
		{
			base.Draw();

			leftRenderTexture.PrepareForRender();
			this.DrawScene();
			leftRenderTexture.Copy();
			gl.PixelStorei( PixelStoreParameter.UnpackAlignment, 1 );
			emptyCubeMapTexture.Use();
			emptyCubeMapTexture.CopyToLeft( 0, 0, 256, 256 );
			emptyCubeMapTexture.CopyToRight( 0, 0, 256, 256 );
			emptyCubeMapTexture.CopyToBottom( 0, 0, 256, 256 );
			emptyCubeMapTexture.CopyToTop( 0, 0, 256, 256 );
			emptyCubeMapTexture.CopyToFront( 0, 0, 256, 256 );
			emptyCubeMapTexture.CopyToBack( 0, 0, 256, 256 );
			leftRenderTexture.RestoreRenderToTexture();

			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			TextureCubeMapBase.UnUse();
			gl.Enable( EnableCap.Texture2d );
			skybox.Draw();

			emptyCubeMapTexture.Use();

			gl.MatrixMode( MatrixMode.Texture );
			gl.PushMatrix();
			gl.LoadIdentity();
			gl.Scalef( 1, 1, -1 );
			gl.MultMatrixf( camera.InvertData );

            gl.MatrixMode( MatrixMode.Modelview );
            sphere1.Draw();
			TextureCubeMapBase.UnUse();
			gl.MatrixMode( MatrixMode.Texture );
			gl.PopMatrix();
			gl.MatrixMode( MatrixMode.Modelview );

			//gl.Enable( EnableCap.Texture2d );

			//leftRenderTexture.Use();

			//gl.Begin( BeginMode.Quads );

			//gl.TexCoord2f( 0, 0 );
			//gl.Vertex2f( -20, -20 );

			//gl.TexCoord2f( 1, 0 );
			//gl.Vertex2f( +20, -20 );

			//gl.TexCoord2f( 1, 1 );
			//gl.Vertex2f( +20, +20 );

			//gl.TexCoord2f( 0, 1 );
			//gl.Vertex2f( -20, +20 );

			//gl.End();
		}

		private void DrawScene() 
		{
			TextureCubeMapBase.UnUse();
			gl.Enable( EnableCap.Texture2d );
			this.skybox.Draw();

			gl.Disable( EnableCap.Texture2d );
			this.cubeMap1.Use();
			this.sphere1.Draw();
			this.sphere2.Draw();
			TextureCubeMapBase.UnUse();
		}
	}
}