/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 07.06.2008 12:08
 *
 * File: TextureCubeMap.cs
 * Remarks:
 * 
 * History:
 *   07.06.2008 12:08 - Create Wireframe
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Windows
{
	public class TextureCubeMap
	{
		private const int NegativeZ = 0;
		private const int PositiveZ = 1;
		private const int NegativeX = 2;
		private const int PositiveX = 3;
		private const int NegativeY = 4;
		private const int PositiveY = 5;

		private readonly string[] fileNames;
		private uint id;
		private static readonly uint[] genTextures = new uint[1] { 0 };

		public TextureCubeMap( string back, string front, string left, string right, string bottom, string top ) 
		{
			this.fileNames = new[] { back, front, left, right, bottom, top };

			this.MinFilter = TextureMinFilter.Linear;
			this.MagFilter = TextureMagFilter.Linear;
			this.WrapT = TextureWrapMode.ClampToEdgeSgis;
			this.WrapS = TextureWrapMode.ClampToEdgeSgis;
		}

		public TextureMinFilter MinFilter { get; set; }

		public TextureMagFilter MagFilter { get; set; }

		public TextureWrapMode WrapS { get; set; }

		public TextureWrapMode WrapT { get; set; }

		public void Load()
		{
			OpenGLNative.GenTextures( 1, genTextures );
			this.id = genTextures[0];

			this.Use();
			int stride;
			int width;
			int height;
			byte[] imageData;
			// NegativeZ
			imageData = TextureHelper.LoadImageData( this.fileNames[NegativeZ],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeZ, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			// PositiveZ
			imageData = TextureHelper.LoadImageData( this.fileNames[PositiveZ],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveZ, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			// NegativeX
			imageData = TextureHelper.LoadImageData( this.fileNames[NegativeX],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeX, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			// PositiveX
			imageData = TextureHelper.LoadImageData( this.fileNames[PositiveX],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveX, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			// NegativeY
			imageData = TextureHelper.LoadImageData( this.fileNames[NegativeY],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeY, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
			// PositiveY
			imageData = TextureHelper.LoadImageData( this.fileNames[PositiveY],
			                                         System.Drawing.Imaging.PixelFormat.Format32bppArgb,
			                                         out stride, out width, out height );
			OpenGL.TexImage2D( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveY, 0, 4, width, height, 0,
			                   (PixelFormat)(int)EXT_bgra.BgraExt, imageData );
		}

		public void Use() 
		{
			OpenGLNative.Enable( (EnableCap)VERSION_1_3.TextureCubeMap );

			OpenGLNative.BindTexture( (TextureTarget)VERSION_1_3.TextureCubeMap, this.id );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)MinFilter );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)MagFilter );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureWrapS, (int)WrapS );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureWrapT, (int)WrapT );

			OpenGLNative.Enable( EnableCap.TextureGenS );
			OpenGLNative.Enable( EnableCap.TextureGenT );
			OpenGLNative.Enable( EnableCap.TextureGenR );

			OpenGLNative.TexGeni( TextureCoordName.S, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
			OpenGLNative.TexGeni( TextureCoordName.T, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
			OpenGLNative.TexGeni( TextureCoordName.R, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
		}

		public void UnUse()
		{
			OpenGLNative.Disable( (EnableCap)VERSION_1_3.TextureCubeMap );

			OpenGLNative.Disable( EnableCap.TextureGenS );
			OpenGLNative.Disable( EnableCap.TextureGenT );
			OpenGLNative.Disable( EnableCap.TextureGenR );
		}
	}
}