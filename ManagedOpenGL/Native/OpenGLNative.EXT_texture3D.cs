using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_texture3DInit()
		{
			_TexImage3DEXT = GetProcAdress< TexImage3DEXTDelegate >( "glTexImage3DEXT" );
			_TexSubImage3DEXT = GetProcAdress< TexSubImage3DEXTDelegate >( "glTexSubImage3DEXT" );
			
		}
		
	
		public unsafe delegate void TexImage3DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method
		private static TexImage3DEXTDelegate _TexImage3DEXT;
		
		public static unsafe  void TexImage3DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexImage3DEXT == null) throw new Exception( "Extension method TexImage3DEXT not found" );
			 _TexImage3DEXT( target, level, internalformat, width, height, depth, border, format, type, pixels );
		}
		public unsafe delegate void TexSubImage3DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); //  extension method
		private static TexSubImage3DEXTDelegate _TexSubImage3DEXT;
		
		public static unsafe  void TexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexSubImage3DEXT == null) throw new Exception( "Extension method TexSubImage3DEXT not found" );
			 _TexSubImage3DEXT( target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels );
		}
	}
}

