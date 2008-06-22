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

namespace ManagedOpenGL.Engine.Windows
{
	public class Texture2D
	{
		private readonly string fileName;

		protected Texture2D()
		{
			this.MinFilter = TextureMinFilter.Linear;
			this.MagFilter = TextureMagFilter.Linear;
			this.WrapT = TextureWrapMode.Clamp;
			this.WrapS = TextureWrapMode.Clamp;
		}

		public Texture2D( string fileName ) : this()
		{
			this.fileName = fileName;
		}

		public TextureMinFilter MinFilter { get; set; }

		public TextureMagFilter MagFilter { get; set; }

		public TextureWrapMode WrapS { get; set; }

		public TextureWrapMode WrapT { get; set; }

		public bool Loaded { get; protected set; }

		public uint Id { get; protected set; }

		public virtual void Load()
		{
			if (Loaded) return;

			this.Id = TextureHelper.GetNextTextureId();

			int stride;
			int width;
			int height;
			var bytes = TextureHelper.LoadImageData( fileName, System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );

			this.Use();
			OpenGL.TexImage2D( TextureTarget.Texture2d, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, PixelType.UnsignedByte, bytes );

			Loaded = true;
		}

		public void Use() 
		{
			OpenGLNative.BindTexture( TextureTarget.Texture2d, this.Id );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)WrapS );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)WrapT );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)MinFilter );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)MagFilter );
		}
	}
}