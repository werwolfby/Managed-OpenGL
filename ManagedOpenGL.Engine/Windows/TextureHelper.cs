/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 07.06.2008 12:15
 *
 * File: TextureHelper.cs
 * Remarks:
 * 
 * History:
 *   07.06.2008 12:15 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ManagedOpenGL.Engine.Windows
{
	public static class TextureHelper
	{
		private static readonly uint[] genTextures = new uint[1] { 0 };
		
		public static byte[] LoadImageData( string fileName, System.Drawing.Imaging.PixelFormat pixelFormat, out int stride, out int width, out int height )
		{
			byte[] imageData;

			using (var bmp = new Bitmap( fileName ))
			{
				bmp.RotateFlip( RotateFlipType.RotateNoneFlipY );
				var bmpData = bmp.LockBits( new Rectangle( 0, 0, bmp.Width, bmp.Height ), ImageLockMode.ReadOnly, pixelFormat );

				stride = bmpData.Stride;
				width = bmpData.Width;
				height = bmpData.Height;

				var bytes = bmpData.Stride * bmp.Height;
				imageData = new byte[bytes];

				Marshal.Copy( bmpData.Scan0, imageData, 0, bytes );
			}

			return imageData;
		}

		public static uint GetNextTextureId()
		{
			OpenGLNative.GenTextures( 1, genTextures );
			return genTextures[0];
		}

		public static void CopySubImage( TextureTarget target, int x, int y, int w, int h )
		{
			OpenGLNative.CopyTexImage2D( target, 0, PixelInternalFormat.Rgb8, x, y, w, h, 0 );
			OpenGL.Assert();
		}

		public static void CopySubImage2( TextureTarget target, int x, int y, int w, int h )
		{
			OpenGLNative.CopyTexSubImage2D( target, 0, 0, 0, x, y, w, h );
			OpenGL.Assert();
		}
	}
}