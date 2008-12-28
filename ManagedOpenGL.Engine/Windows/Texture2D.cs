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
	public abstract class TextureBase 
	{
		protected TextureBase()
		{
			this.MinFilter = TextureMinFilter.Linear;
			this.MagFilter = TextureMagFilter.Linear;
			this.WrapT = TextureWrapMode.ClampToEdgeSgis;
			this.WrapS = TextureWrapMode.ClampToEdgeSgis;
		}

		public TextureMinFilter MinFilter { get; set; }

		public TextureMagFilter MagFilter { get; set; }

		public TextureWrapMode WrapS { get; set; }

		public TextureWrapMode WrapT { get; set; }

		public uint Id { get; protected set; }

		public bool Loaded { get; private set; }

		public void Load()
		{
			if (Loaded) return;

            this.Id = TextureHelper.GetNextTextureId();
			this.LoadOverride();
			Loaded = true;
		}

		public abstract void LoadOverride();

		public virtual void Use() 
		{
			OpenGLNative.BindTexture( TextureTarget.Texture2d, this.Id );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)this.WrapS );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)this.WrapT );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)this.MinFilter );
			OpenGLNative.TexParameteri( TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)this.MagFilter );
		}
	}

	public class Texture2D : TextureBase
	{
		private readonly string fileName;

		public Texture2D( string fileName )
		{
			this.fileName = fileName;
		}

		public override void LoadOverride()
		{
			int stride;
			int width;
			int height;
			var bytes = TextureHelper.LoadImageData( fileName, System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );

			this.Use();
			OpenGL.TexImage2D( TextureTarget.Texture2d, 0, 4, width, height, 0,
			                   (PixelFormat)EXT_bgra.BgraExt, PixelType.UnsignedByte, bytes );
		}
	}
}