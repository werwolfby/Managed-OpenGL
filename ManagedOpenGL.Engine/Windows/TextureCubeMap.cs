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

using System;
using System.IO;

namespace ManagedOpenGL.Engine.Windows
{
	public abstract class TextureCubeMapBase : TextureBase 
	{
		protected TextureCubeMapBase()
		{
			this.WrapS = TextureWrapMode.ClampToEdgeSgis;
			this.WrapT = TextureWrapMode.ClampToEdgeSgis;
		}

		public override void Use() 
		{
			OpenGLNative.Enable( (EnableCap)VERSION_1_3.TextureCubeMap );

			OpenGLNative.BindTexture( (TextureTarget)VERSION_1_3.TextureCubeMap, this.Id );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)this.MinFilter );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)this.MagFilter );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureWrapS, (int)this.WrapS );
			OpenGLNative.TexParameteri( (TextureTarget)VERSION_1_3.TextureCubeMap, TextureParameterName.TextureWrapT, (int)this.WrapT );

			OpenGLNative.Enable( EnableCap.TextureGenS );
			OpenGLNative.Enable( EnableCap.TextureGenT );
			OpenGLNative.Enable( EnableCap.TextureGenR );

			OpenGLNative.TexGeni( TextureCoordName.S, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
			OpenGLNative.TexGeni( TextureCoordName.T, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
			OpenGLNative.TexGeni( TextureCoordName.R, TextureGenParameter.TextureGenMode, (int)VERSION_1_3.ReflectionMap );
		}

		public static void UnUse()
		{
			OpenGLNative.Disable( (EnableCap)VERSION_1_3.TextureCubeMap );

			OpenGLNative.Disable( EnableCap.TextureGenS );
			OpenGLNative.Disable( EnableCap.TextureGenT );
			OpenGLNative.Disable( EnableCap.TextureGenR );
		}

		public void CopyToLeft( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeX, x, y, w, h );
		}

		public void CopyToRight( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveX, x, y, w, h );
		}

		public void CopyToBottom( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeY, x, y, w, h );
		}

		public void CopyToTop( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveY, x, y, w, h );
		}

		public void CopyToBack( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapPositiveZ, x, y, w, h );
		}

		public void CopyToFront( int x, int y, int w, int h )
		{
			TextureHelper.CopySubImage( (TextureTarget)VERSION_1_3.TextureCubeMapNegativeZ, x, y, w, h );
		}

		public void CopyTo( int i, int x, int y, int w, int h )
		{
			switch (i)
			{
				case 0:
					this.CopyToLeft( x, y, w, h );
					break;
				case 1:
					this.CopyToRight( x, y, w, h );
					break;
				case 2:
					this.CopyToBottom( x, y, w, h );
					break;
				case 3:
					this.CopyToTop( x, y, w, h );
					break;
				case 4:
					this.CopyToBack( x, y, w, h );
					break;
				case 5:
					this.CopyToFront( x, y, w, h );
					break;
			}
		}
	}

	public class TextureCubeMap : TextureCubeMapBase
	{
		private readonly string[] fileNames;
		private readonly VERSION_1_3[] planes;

		public TextureCubeMap( string back, string front, string left, string right, string bottom, string top )
		{
			this.fileNames = new[]
			                 {
			                 	left, right,
			                 	bottom, top,
			                 	front, back
			                 };
			this.planes = new[]
			              {
			              	VERSION_1_3.TextureCubeMapNegativeX, VERSION_1_3.TextureCubeMapPositiveX,
			              	VERSION_1_3.TextureCubeMapNegativeY, VERSION_1_3.TextureCubeMapPositiveY,
			              	VERSION_1_3.TextureCubeMapNegativeZ, VERSION_1_3.TextureCubeMapPositiveZ
			              };
		}

		public override void LoadOverride()
		{
			OpenGLNative.PixelStorei( PixelStoreParameter.UnpackAlignment, 1 );
			this.Use();
			for (var i = 0; i < this.fileNames.Length; i++)
			{
				int stride;
				int width;
				int height;
				var imageData = TextureHelper.LoadImageData( this.fileNames[i],
				                                             System.Drawing.Imaging.PixelFormat.Format32bppArgb,
				                                             out stride, out width, out height, false );
				OpenGL.TexImage2D( (TextureTarget)planes[i], 0, 4, width, height, 0,
				                   (PixelFormat)EXT_bgra.BgraExt, PixelType.UnsignedByte, imageData );
			}
		}

		public static TextureCubeMap CreateFromFolder( string folderPath, string extension )
		{
			var fileNames = new []
			                {
			                	Path.Combine( folderPath, "front." + extension ),
			                	Path.Combine( folderPath, "back." + extension ),
			                	Path.Combine( folderPath, "left." + extension ),
			                	Path.Combine( folderPath, "right." + extension ),
			                	Path.Combine( folderPath, "bottom." + extension ),
			                	Path.Combine( folderPath, "top." + extension ),
			                };

			foreach (var fileName in fileNames)
			{
				if (!File.Exists( fileName )) throw new Exception( "File : `" + fileName + "` don't exists" );
			}

			return new TextureCubeMap( fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], fileNames[5] );
		}
	}
}