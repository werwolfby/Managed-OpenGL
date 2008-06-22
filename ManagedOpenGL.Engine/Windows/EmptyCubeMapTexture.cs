/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 14:27
 *
 * File: EmptyCubeMapTexture.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 14:27 - Create Wireframe
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Windows
{
	public class EmptyCubeMapTexture : TextureCubeMap
	{
		private readonly int width, height, channels;

		public EmptyCubeMapTexture( int width, int height, int channels )
		{
			this.width = width;
			this.height = height;
			this.channels = channels;
		}

		public int Width
		{
			get { return this.width; }
		}

		public int Height
		{
			get { return this.height; }
		}

		public override void Load()
		{
			this.id = TextureHelper.GetNextTextureId();

			this.Use();
			var imageData = new byte[width*height*channels];
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeX, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveX, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeY, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveY, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeZ, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveZ, 0, channels, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
		}
	}
}