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
	public class EmptyTexture2D : Texture2D
	{
		private readonly int width;
		private readonly int height;
		private readonly int channels;
		private readonly PixelFormat format;

		public EmptyTexture2D( int width, int height, int channels, PixelFormat format )
		{
			this.width = width;
			this.height = height;
			this.channels = channels;
			this.format = format;
		}

		public override void Load() 
		{
			if (Loaded) return;

			this.Id = TextureHelper.GetNextTextureId();

			var bytes = new byte[width*height*channels];

			this.Use();
			OpenGL.TexImage2D( TextureTarget.Texture2d, 0, channels, width, height, 0,
			                   format, PixelType.UnsignedByte, bytes );

			Loaded = true;
		}

		public void Copy( int x, int y, int w, int h )
		{
			Use();
			TextureHelper.CopySubImage2( TextureTarget.Texture2d, x, y, w, h );
		}

		public void Copy( int w, int h )
		{
			Copy( 0, 0, w, h );
		}
	}
}