/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 27.12.2008 15:36
 *
 * File: RenderTexture.cs
 * Remarks:
 * 
 * History:
 *   27.12.2008 15:36 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL.Engine.Windows;
using gl=ManagedOpenGL.OpenGLNative;

namespace ManagedOpenGL.Engine.Render
{
	public class RenderTexture : EmptyTexture2D
	{
		public RenderTexture( int width, int height ) : base( width, height, 4, PixelFormat.Rgb ) {}

		public void PrepareForRender()
		{
			gl.Viewport( 0, 0, this.Width, this.Height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PushMatrix();
			gl.LoadIdentity();
			gl.Frustum( -1, 1, -1, 1, 1, 1000 );
		}

		public void Copy()
		{
			this.Copy( this.Width, this.Height );
		}

		public void RestoreRenderToTexture()
		{
			gl.Viewport( 0, 0, Renderer.WindowSize.Width, Renderer.WindowSize.Height );
			gl.MatrixMode( MatrixMode.Projection );
			gl.PopMatrix();
		}
	}
}