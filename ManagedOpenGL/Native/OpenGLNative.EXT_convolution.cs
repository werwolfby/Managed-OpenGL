using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_convolutionInit()
		{
			_ConvolutionFilter1DEXT = GetProcAdress< ConvolutionFilter1DEXTDelegate >( "glConvolutionFilter1DEXT" );
			_ConvolutionFilter2DEXT = GetProcAdress< ConvolutionFilter2DEXTDelegate >( "glConvolutionFilter2DEXT" );
			_ConvolutionParameterfEXT = GetProcAdress< ConvolutionParameterfEXTDelegate >( "glConvolutionParameterfEXT" );
			_ConvolutionParameterfvEXT = GetProcAdress< ConvolutionParameterfvEXTDelegate >( "glConvolutionParameterfvEXT" );
			_ConvolutionParameteriEXT = GetProcAdress< ConvolutionParameteriEXTDelegate >( "glConvolutionParameteriEXT" );
			_ConvolutionParameterivEXT = GetProcAdress< ConvolutionParameterivEXTDelegate >( "glConvolutionParameterivEXT" );
			_CopyConvolutionFilter1DEXT = GetProcAdress< CopyConvolutionFilter1DEXTDelegate >( "glCopyConvolutionFilter1DEXT" );
			_CopyConvolutionFilter2DEXT = GetProcAdress< CopyConvolutionFilter2DEXTDelegate >( "glCopyConvolutionFilter2DEXT" );
			_GetConvolutionFilterEXT = GetProcAdress< GetConvolutionFilterEXTDelegate >( "glGetConvolutionFilterEXT" );
			_GetConvolutionParameterfvEXT = GetProcAdress< GetConvolutionParameterfvEXTDelegate >( "glGetConvolutionParameterfvEXT" );
			_GetConvolutionParameterivEXT = GetProcAdress< GetConvolutionParameterivEXTDelegate >( "glGetConvolutionParameterivEXT" );
			_GetSeparableFilterEXT = GetProcAdress< GetSeparableFilterEXTDelegate >( "glGetSeparableFilterEXT" );
			_SeparableFilter2DEXT = GetProcAdress< SeparableFilter2DEXTDelegate >( "glSeparableFilter2DEXT" );
		}


		public unsafe delegate void ConvolutionFilter1DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); //  extension method

		private static ConvolutionFilter1DEXTDelegate _ConvolutionFilter1DEXT;

		public static unsafe  void ConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image )
		{
			if (_ConvolutionFilter1DEXT == null) throw new Exception( "Extension method ConvolutionFilter1DEXT not found" );
		 _ConvolutionFilter1DEXT( target, internalformat, width, format, type, image );
		}
		public unsafe delegate void ConvolutionFilter2DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); //  extension method

		private static ConvolutionFilter2DEXTDelegate _ConvolutionFilter2DEXT;

		public static unsafe  void ConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image )
		{
			if (_ConvolutionFilter2DEXT == null) throw new Exception( "Extension method ConvolutionFilter2DEXT not found" );
		 _ConvolutionFilter2DEXT( target, internalformat, width, height, format, type, image );
		}
		public delegate void ConvolutionParameterfEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params ); //  extension method

		private static ConvolutionParameterfEXTDelegate _ConvolutionParameterfEXT;

		public static  void ConvolutionParameterfEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params )
		{
			if (_ConvolutionParameterfEXT == null) throw new Exception( "Extension method ConvolutionParameterfEXT not found" );
		 _ConvolutionParameterfEXT( target, pname, @params );
		}
		public delegate void ConvolutionParameterfvEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params ); //  extension method

		private static ConvolutionParameterfvEXTDelegate _ConvolutionParameterfvEXT;

		public static  void ConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params )
		{
			if (_ConvolutionParameterfvEXT == null) throw new Exception( "Extension method ConvolutionParameterfvEXT not found" );
		 _ConvolutionParameterfvEXT( target, pname, @params );
		}
		public delegate void ConvolutionParameteriEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params ); //  extension method

		private static ConvolutionParameteriEXTDelegate _ConvolutionParameteriEXT;

		public static  void ConvolutionParameteriEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params )
		{
			if (_ConvolutionParameteriEXT == null) throw new Exception( "Extension method ConvolutionParameteriEXT not found" );
		 _ConvolutionParameteriEXT( target, pname, @params );
		}
		public delegate void ConvolutionParameterivEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int[] @params ); //  extension method

		private static ConvolutionParameterivEXTDelegate _ConvolutionParameterivEXT;

		public static  void ConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int[] @params )
		{
			if (_ConvolutionParameterivEXT == null) throw new Exception( "Extension method ConvolutionParameterivEXT not found" );
		 _ConvolutionParameterivEXT( target, pname, @params );
		}
		public delegate void CopyConvolutionFilter1DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method

		private static CopyConvolutionFilter1DEXTDelegate _CopyConvolutionFilter1DEXT;

		public static  void CopyConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width )
		{
			if (_CopyConvolutionFilter1DEXT == null) throw new Exception( "Extension method CopyConvolutionFilter1DEXT not found" );
		 _CopyConvolutionFilter1DEXT( target, internalformat, x, y, width );
		}
		public delegate void CopyConvolutionFilter2DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width, int height ); //  extension method

		private static CopyConvolutionFilter2DEXTDelegate _CopyConvolutionFilter2DEXT;

		public static  void CopyConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width, int height )
		{
			if (_CopyConvolutionFilter2DEXT == null) throw new Exception( "Extension method CopyConvolutionFilter2DEXT not found" );
		 _CopyConvolutionFilter2DEXT( target, internalformat, x, y, width, height );
		}
		public unsafe delegate void GetConvolutionFilterEXTDelegate( ConvolutionTargetEXT target, PixelFormat format, PixelType type, [Out]void* image ); //  extension method

		private static GetConvolutionFilterEXTDelegate _GetConvolutionFilterEXT;

		public static unsafe  void GetConvolutionFilterEXT( ConvolutionTargetEXT target, PixelFormat format, PixelType type, [Out]void* image )
		{
			if (_GetConvolutionFilterEXT == null) throw new Exception( "Extension method GetConvolutionFilterEXT not found" );
		 _GetConvolutionFilterEXT( target, format, type, image );
		}
		public delegate void GetConvolutionParameterfvEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out]float[] @params ); //  extension method

		private static GetConvolutionParameterfvEXTDelegate _GetConvolutionParameterfvEXT;

		public static  void GetConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out]float[] @params )
		{
			if (_GetConvolutionParameterfvEXT == null) throw new Exception( "Extension method GetConvolutionParameterfvEXT not found" );
		 _GetConvolutionParameterfvEXT( target, pname, @params );
		}
		public delegate void GetConvolutionParameterivEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out]int[] @params ); //  extension method

		private static GetConvolutionParameterivEXTDelegate _GetConvolutionParameterivEXT;

		public static  void GetConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out]int[] @params )
		{
			if (_GetConvolutionParameterivEXT == null) throw new Exception( "Extension method GetConvolutionParameterivEXT not found" );
		 _GetConvolutionParameterivEXT( target, pname, @params );
		}
		public unsafe delegate void GetSeparableFilterEXTDelegate( SeparableTargetEXT target, PixelFormat format, PixelType type, [Out]void* row, [Out]void* column, [Out]void* span ); //  extension method

		private static GetSeparableFilterEXTDelegate _GetSeparableFilterEXT;

		public static unsafe  void GetSeparableFilterEXT( SeparableTargetEXT target, PixelFormat format, PixelType type, [Out]void* row, [Out]void* column, [Out]void* span )
		{
			if (_GetSeparableFilterEXT == null) throw new Exception( "Extension method GetSeparableFilterEXT not found" );
		 _GetSeparableFilterEXT( target, format, type, row, column, span );
		}
		public unsafe delegate void SeparableFilter2DEXTDelegate( SeparableTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); //  extension method

		private static SeparableFilter2DEXTDelegate _SeparableFilter2DEXT;

		public static unsafe  void SeparableFilter2DEXT( SeparableTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column )
		{
			if (_SeparableFilter2DEXT == null) throw new Exception( "Extension method SeparableFilter2DEXT not found" );
		 _SeparableFilter2DEXT( target, internalformat, width, height, format, type, row, column );
		}
	}
}
