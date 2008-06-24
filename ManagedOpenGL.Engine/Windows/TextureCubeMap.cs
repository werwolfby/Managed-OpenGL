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
		private readonly string[] fileNames;
		private readonly VERSION_1_3[] planes;
		protected uint id;

		protected TextureCubeMap()
		{
			this.MinFilter = TextureMinFilter.Linear;
			this.MagFilter = TextureMagFilter.Linear;
			this.WrapT = TextureWrapMode.ClampToEdgeSgis;
			this.WrapS = TextureWrapMode.ClampToEdgeSgis;
		}

		public TextureCubeMap( string back, string front, string left, string right, string bottom, string top ) : this()
		{
			this.fileNames = new[]
			                 {
			                 	right, left,
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

		public TextureMinFilter MinFilter { get; set; }

		public TextureMagFilter MagFilter { get; set; }

		public TextureWrapMode WrapS { get; set; }

		public TextureWrapMode WrapT { get; set; }

		public virtual void Load()
		{
			this.id = TextureHelper.GetNextTextureId();

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
								   (PixelFormat)EXT_bgra.BgraExt, imageData );
			}
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
					CopyToLeft( x, y, w, h );
					break;
				case 1:
					CopyToRight( x, y, w, h );
					break;
				case 2:
					CopyToBottom( x, y, w, h );
					break;
				case 3:
					CopyToTop( x, y, w, h );
					break;
				case 4:
					CopyToBack( x, y, w, h );
					break;
				case 5:
					CopyToFront( x, y, w, h );
					break;
			}
		}
	}
}