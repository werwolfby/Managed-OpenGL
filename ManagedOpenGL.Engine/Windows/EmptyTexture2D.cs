/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 12:27
 *
 * File: EmptyTexture2D.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 12:27 - Create Wireframe
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Windows
{
	public class EmptyTexture2D : TextureBase
	{
		public EmptyTexture2D( int width, int height, int channels, PixelFormat format )
		{
			this.Width = width;
			this.Height = height;
			this.Channels = channels;
			this.Format = format;
		}

		public int Width { get; private set; }

		public int Height { get; private set; }

		public int Channels { get; private set; }

		public PixelFormat Format { get; private set; }

		public override void LoadOverride() 
		{
			var bytes = new byte[this.Width*this.Height*this.Channels];

			this.Use();
			OpenGL.TexImage2D( TextureTarget.Texture2d, 0, this.Channels, this.Width, this.Height, 0,
			                   this.Format, PixelType.UnsignedByte, bytes );
		}

		public void Copy( int x, int y, int w, int h )
		{
			this.Use();
			TextureHelper.CopySubImage2( TextureTarget.Texture2d, x, y, w, h );
		}

		public void Copy( int w, int h )
		{
			Copy( 0, 0, w, h );
		}
	}
}