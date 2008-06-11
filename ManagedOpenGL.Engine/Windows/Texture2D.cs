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

namespace ManagedOpenGL.Engine.Windows
{
	public class Texture2D
	{
		private readonly string fileName;
		private uint id;
		private static readonly uint[] genTextures = new uint[1] { 0 };

		public Texture2D( string fileName ) 
		{
			this.fileName = fileName;

			this.MinFilter = TextureMinFilter.Linear;
			this.MagFilter = TextureMagFilter.Linear;
			this.WrapT = TextureWrapMode.Clamp;
			this.WrapS = TextureWrapMode.Clamp;
		}

		public TextureMinFilter MinFilter { get; set; }

		public TextureMagFilter MagFilter { get; set; }

		public TextureWrapMode WrapS { get; set; }

		public TextureWrapMode WrapT { get; set; }

		public bool Loaded { get; private set; }

		public uint Id
		{
			get { return this.id; }
		}

		public void Load()
		{
			using (var bitmap = new Bitmap( fileName ))
			{
				var bitmapData = bitmap.LockBits( new Rectangle( 0, 0, bitmap.Width, bitmap.Height ), ImageLockMode.ReadOnly,
				                                  System.Drawing.Imaging.PixelFormat.Format32bppArgb );

				OpenGLNative.GenTextures( 1, genTextures );
				this.id = genTextures[0];

				this.Use();
				OpenGL.TexImage2D( TextureTarget.Texture2d, 0, 4, bitmapData.Width, bitmapData.Height, 0,
				                   (PixelFormat)(int)EXT_bgra.BgraExt, PixelType.UnsignedByte, bitmapData.Scan0 );
				bitmap.UnlockBits( bitmapData );
			}

			Loaded = true;
		}

		public void Use() 
		{
			OpenGLNative.BindTexture( TextureTarget.Texture2d, this.id );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)MinFilter );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)MagFilter );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)WrapS );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)WrapT );
		}
	}
}