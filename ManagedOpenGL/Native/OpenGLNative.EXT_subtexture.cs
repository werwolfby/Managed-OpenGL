using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_subtextureInit()
		{
			_TexSubImage1DEXT = GetProcAdress< TexSubImage1DEXTDelegate >( "glTexSubImage1DEXT" );
			_TexSubImage2DEXT = GetProcAdress< TexSubImage2DEXTDelegate >( "glTexSubImage2DEXT" );
		}


		public unsafe delegate void TexSubImage1DEXTDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); //  extension method

		private static TexSubImage1DEXTDelegate _TexSubImage1DEXT;

		public static unsafe  void TexSubImage1DEXT( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexSubImage1DEXT == null) throw new Exception( "Extension method TexSubImage1DEXT not found" );
		 _TexSubImage1DEXT( target, level, xoffset, width, format, type, pixels );
		}
		public unsafe delegate void TexSubImage2DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); //  extension method

		private static TexSubImage2DEXTDelegate _TexSubImage2DEXT;

		public static unsafe  void TexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexSubImage2DEXT == null) throw new Exception( "Extension method TexSubImage2DEXT not found" );
		 _TexSubImage2DEXT( target, level, xoffset, yoffset, width, height, format, type, pixels );
		}
	}
}
