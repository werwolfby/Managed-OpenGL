using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_texture_compressionInit()
		{
			_CompressedTexImage3DARB = GetProcAdress< CompressedTexImage3DARBDelegate >( "glCompressedTexImage3DARB" );
			_CompressedTexImage2DARB = GetProcAdress< CompressedTexImage2DARBDelegate >( "glCompressedTexImage2DARB" );
			_CompressedTexImage1DARB = GetProcAdress< CompressedTexImage1DARBDelegate >( "glCompressedTexImage1DARB" );
			_CompressedTexSubImage3DARB = GetProcAdress< CompressedTexSubImage3DARBDelegate >( "glCompressedTexSubImage3DARB" );
			_CompressedTexSubImage2DARB = GetProcAdress< CompressedTexSubImage2DARBDelegate >( "glCompressedTexSubImage2DARB" );
			_CompressedTexSubImage1DARB = GetProcAdress< CompressedTexSubImage1DARBDelegate >( "glCompressedTexSubImage1DARB" );
			_GetCompressedTexImageARB = GetProcAdress< GetCompressedTexImageARBDelegate >( "glGetCompressedTexImageARB" );
		}


		public unsafe delegate void CompressedTexImage3DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 

		private static CompressedTexImage3DARBDelegate _CompressedTexImage3DARB;

		public static unsafe  void CompressedTexImage3DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage3DARB == null) throw new Exception( "Extension method CompressedTexImage3DARB not found" );
		 _CompressedTexImage3DARB( target, level, internalformat, width, height, depth, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexImage2DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 

		private static CompressedTexImage2DARBDelegate _CompressedTexImage2DARB;

		public static unsafe  void CompressedTexImage2DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage2DARB == null) throw new Exception( "Extension method CompressedTexImage2DARB not found" );
		 _CompressedTexImage2DARB( target, level, internalformat, width, height, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexImage1DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 

		private static CompressedTexImage1DARBDelegate _CompressedTexImage1DARB;

		public static unsafe  void CompressedTexImage1DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage1DARB == null) throw new Exception( "Extension method CompressedTexImage1DARB not found" );
		 _CompressedTexImage1DARB( target, level, internalformat, width, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage3DARBDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage3DARBDelegate _CompressedTexSubImage3DARB;

		public static unsafe  void CompressedTexSubImage3DARB( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage3DARB == null) throw new Exception( "Extension method CompressedTexSubImage3DARB not found" );
		 _CompressedTexSubImage3DARB( target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage2DARBDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage2DARBDelegate _CompressedTexSubImage2DARB;

		public static unsafe  void CompressedTexSubImage2DARB( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage2DARB == null) throw new Exception( "Extension method CompressedTexSubImage2DARB not found" );
		 _CompressedTexSubImage2DARB( target, level, xoffset, yoffset, width, height, format, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage1DARBDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage1DARBDelegate _CompressedTexSubImage1DARB;

		public static unsafe  void CompressedTexSubImage1DARB( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage1DARB == null) throw new Exception( "Extension method CompressedTexSubImage1DARB not found" );
		 _CompressedTexSubImage1DARB( target, level, xoffset, width, format, imageSize, data );
		}
		public unsafe delegate void GetCompressedTexImageARBDelegate( TextureTarget target, int level, [Out]void* img ); // 

		private static GetCompressedTexImageARBDelegate _GetCompressedTexImageARB;

		public static unsafe  void GetCompressedTexImageARB( TextureTarget target, int level, [Out]void* img )
		{
			if (_GetCompressedTexImageARB == null) throw new Exception( "Extension method GetCompressedTexImageARB not found" );
		 _GetCompressedTexImageARB( target, level, img );
		}
	}
}
