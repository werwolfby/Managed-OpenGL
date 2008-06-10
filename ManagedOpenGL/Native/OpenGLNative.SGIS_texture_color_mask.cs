using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_texture_color_maskInit()
		{
			_TextureColorMaskSGIS = GetProcAdress< TextureColorMaskSGISDelegate >( "glTextureColorMaskSGIS" );
			
		}
		
	
		public delegate void TextureColorMaskSGISDelegate( bool red, bool green, bool blue, bool alpha ); //  extension method
		private static TextureColorMaskSGISDelegate _TextureColorMaskSGIS;
		
		public static  void TextureColorMaskSGIS( bool red, bool green, bool blue, bool alpha )
		{
			if (_TextureColorMaskSGIS == null) throw new Exception( "Extension method TextureColorMaskSGIS not found" );
			 _TextureColorMaskSGIS( red, green, blue, alpha );
		}
	}
}

