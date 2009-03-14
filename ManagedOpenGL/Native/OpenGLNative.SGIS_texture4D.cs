using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_texture4DInit()
		{
			_TexImage4DSGIS = GetProcAdress< TexImage4DSGISDelegate >( "glTexImage4DSGIS" );
			_TexSubImage4DSGIS = GetProcAdress< TexSubImage4DSGISDelegate >( "glTexSubImage4DSGIS" );
		}


		public unsafe delegate void TexImage4DSGISDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method

		private static TexImage4DSGISDelegate _TexImage4DSGIS;

		public static unsafe  void TexImage4DSGIS( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexImage4DSGIS == null) throw new Exception( "Extension method TexImage4DSGIS not found" );
		 _TexImage4DSGIS( target, level, internalformat, width, height, depth, size4d, border, format, type, pixels );
		}
		public unsafe delegate void TexSubImage4DSGISDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels ); //  extension method

		private static TexSubImage4DSGISDelegate _TexSubImage4DSGIS;

		public static unsafe  void TexSubImage4DSGIS( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexSubImage4DSGIS == null) throw new Exception( "Extension method TexSubImage4DSGIS not found" );
		 _TexSubImage4DSGIS( target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels );
		}
	}
}
