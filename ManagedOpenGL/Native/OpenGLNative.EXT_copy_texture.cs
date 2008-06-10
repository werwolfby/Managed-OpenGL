using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_copy_textureInit()
		{
			_CopyTexImage1DEXT = GetProcAdress< CopyTexImage1DEXTDelegate >( "glCopyTexImage1DEXT" );
			_CopyTexImage2DEXT = GetProcAdress< CopyTexImage2DEXTDelegate >( "glCopyTexImage2DEXT" );
			_CopyTexSubImage1DEXT = GetProcAdress< CopyTexSubImage1DEXTDelegate >( "glCopyTexSubImage1DEXT" );
			_CopyTexSubImage2DEXT = GetProcAdress< CopyTexSubImage2DEXTDelegate >( "glCopyTexSubImage2DEXT" );
			_CopyTexSubImage3DEXT = GetProcAdress< CopyTexSubImage3DEXTDelegate >( "glCopyTexSubImage3DEXT" );
			
		}
		
	
		public delegate void CopyTexImage1DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); //  extension method
		private static CopyTexImage1DEXTDelegate _CopyTexImage1DEXT;
		
		public static  void CopyTexImage1DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border )
		{
			if (_CopyTexImage1DEXT == null) throw new Exception( "Extension method CopyTexImage1DEXT not found" );
			 _CopyTexImage1DEXT( target, level, internalformat, x, y, width, border );
		}
		public delegate void CopyTexImage2DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); //  extension method
		private static CopyTexImage2DEXTDelegate _CopyTexImage2DEXT;
		
		public static  void CopyTexImage2DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border )
		{
			if (_CopyTexImage2DEXT == null) throw new Exception( "Extension method CopyTexImage2DEXT not found" );
			 _CopyTexImage2DEXT( target, level, internalformat, x, y, width, height, border );
		}
		public delegate void CopyTexSubImage1DEXTDelegate( TextureTarget target, int level, int xoffset, int x, int y, int width ); //  extension method
		private static CopyTexSubImage1DEXTDelegate _CopyTexSubImage1DEXT;
		
		public static  void CopyTexSubImage1DEXT( TextureTarget target, int level, int xoffset, int x, int y, int width )
		{
			if (_CopyTexSubImage1DEXT == null) throw new Exception( "Extension method CopyTexSubImage1DEXT not found" );
			 _CopyTexSubImage1DEXT( target, level, xoffset, x, y, width );
		}
		public delegate void CopyTexSubImage2DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); //  extension method
		private static CopyTexSubImage2DEXTDelegate _CopyTexSubImage2DEXT;
		
		public static  void CopyTexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height )
		{
			if (_CopyTexSubImage2DEXT == null) throw new Exception( "Extension method CopyTexSubImage2DEXT not found" );
			 _CopyTexSubImage2DEXT( target, level, xoffset, yoffset, x, y, width, height );
		}
		public delegate void CopyTexSubImage3DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); //  extension method
		private static CopyTexSubImage3DEXTDelegate _CopyTexSubImage3DEXT;
		
		public static  void CopyTexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height )
		{
			if (_CopyTexSubImage3DEXT == null) throw new Exception( "Extension method CopyTexSubImage3DEXT not found" );
			 _CopyTexSubImage3DEXT( target, level, xoffset, yoffset, zoffset, x, y, width, height );
		}
	}
}

