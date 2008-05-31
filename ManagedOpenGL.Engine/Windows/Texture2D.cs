/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 30.05.2008 19:08
 *
 * File: Texture2D.cs
 * Remarks:
 * 
 * History:
 *   30.05.2008 19:08 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ManagedOpenGL.Engine.Windows
{
	public class Texture2D
	{
		private readonly string fileName;
		private uint id;
		private static uint[] genTextures = new uint[1] { 0 };

		public Texture2D( string fileName ) 
		{
			this.fileName = fileName;
		}

		public bool Loaded { get; private set; }

		public void Load()
		{
			using (var bitmap = new Bitmap( fileName ))
			{
				var bitmapData = bitmap.LockBits( new Rectangle( 0, 0, bitmap.Width, bitmap.Height ), ImageLockMode.ReadOnly,
				                                  System.Drawing.Imaging.PixelFormat.Format32bppArgb );

				OpenGLNative.GenTextures( 1, genTextures );
				this.id = genTextures[0];

				this.Use();
				OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear );
				OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear );
				OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdgeSgis );
				OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdgeSgis );
				OpenGL.TexImage2D( TextureTarget.Texture2d, 0, 4, bitmapData.Width, bitmapData.Height, 0,
				                   (PixelFormat)(int)EXT_bgra.BgraExt, PixelType.UnsignedByte, bitmapData.Scan0 );
				bitmap.UnlockBits( bitmapData );
			}

			Loaded = true;
		}

		public void Use() 
		{
			OpenGLNative.BindTexture( TextureTarget.Texture2d, this.id );
		}
	}
}