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
		public static byte[] LoadImageData( string fileName, System.Drawing.Imaging.PixelFormat pixelFormat, out int stride, out int width, out int height )
		{
			byte[] imageData;

			using (var bmp = new Bitmap( fileName ))
			{
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
	}
}