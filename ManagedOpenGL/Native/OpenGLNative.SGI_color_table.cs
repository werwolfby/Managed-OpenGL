using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGI_color_tableInit()
		{
			_ColorTableSGI = GetProcAdress< ColorTableSGIDelegate >( "glColorTableSGI" );
			_ColorTableParameterfvSGI = GetProcAdress< ColorTableParameterfvSGIDelegate >( "glColorTableParameterfvSGI" );
			_ColorTableParameterivSGI = GetProcAdress< ColorTableParameterivSGIDelegate >( "glColorTableParameterivSGI" );
			_CopyColorTableSGI = GetProcAdress< CopyColorTableSGIDelegate >( "glCopyColorTableSGI" );
			_GetColorTableSGI = GetProcAdress< GetColorTableSGIDelegate >( "glGetColorTableSGI" );
			_GetColorTableParameterfvSGI = GetProcAdress< GetColorTableParameterfvSGIDelegate >( "glGetColorTableParameterfvSGI" );
			_GetColorTableParameterivSGI = GetProcAdress< GetColorTableParameterivSGIDelegate >( "glGetColorTableParameterivSGI" );
			
		}
		
	
		public unsafe delegate void ColorTableSGIDelegate( ColorTableTargetSGI target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); //  extension method
		private static ColorTableSGIDelegate _ColorTableSGI;
		
		public static unsafe  void ColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table )
		{
			if (_ColorTableSGI == null) throw new Exception( "Extension method ColorTableSGI not found" );
			 _ColorTableSGI( target, internalformat, width, format, type, table );
		}
		public delegate void ColorTableParameterfvSGIDelegate( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float[] @params ); //  extension method
		private static ColorTableParameterfvSGIDelegate _ColorTableParameterfvSGI;
		
		public static  void ColorTableParameterfvSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float[] @params )
		{
			if (_ColorTableParameterfvSGI == null) throw new Exception( "Extension method ColorTableParameterfvSGI not found" );
			 _ColorTableParameterfvSGI( target, pname, @params );
		}
		public delegate void ColorTableParameterivSGIDelegate( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int[] @params ); //  extension method
		private static ColorTableParameterivSGIDelegate _ColorTableParameterivSGI;
		
		public static  void ColorTableParameterivSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int[] @params )
		{
			if (_ColorTableParameterivSGI == null) throw new Exception( "Extension method ColorTableParameterivSGI not found" );
			 _ColorTableParameterivSGI( target, pname, @params );
		}
		public delegate void CopyColorTableSGIDelegate( ColorTableTargetSGI target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method
		private static CopyColorTableSGIDelegate _CopyColorTableSGI;
		
		public static  void CopyColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int x, int y, int width )
		{
			if (_CopyColorTableSGI == null) throw new Exception( "Extension method CopyColorTableSGI not found" );
			 _CopyColorTableSGI( target, internalformat, x, y, width );
		}
		public unsafe delegate void GetColorTableSGIDelegate( ColorTableTargetSGI target, PixelFormat format, PixelType type, [Out]void* table ); //  extension method
		private static GetColorTableSGIDelegate _GetColorTableSGI;
		
		public static unsafe  void GetColorTableSGI( ColorTableTargetSGI target, PixelFormat format, PixelType type, [Out]void* table )
		{
			if (_GetColorTableSGI == null) throw new Exception( "Extension method GetColorTableSGI not found" );
			 _GetColorTableSGI( target, format, type, table );
		}
		public delegate void GetColorTableParameterfvSGIDelegate( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out]float[] @params ); //  extension method
		private static GetColorTableParameterfvSGIDelegate _GetColorTableParameterfvSGI;
		
		public static  void GetColorTableParameterfvSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out]float[] @params )
		{
			if (_GetColorTableParameterfvSGI == null) throw new Exception( "Extension method GetColorTableParameterfvSGI not found" );
			 _GetColorTableParameterfvSGI( target, pname, @params );
		}
		public delegate void GetColorTableParameterivSGIDelegate( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out]int[] @params ); //  extension method
		private static GetColorTableParameterivSGIDelegate _GetColorTableParameterivSGI;
		
		public static  void GetColorTableParameterivSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out]int[] @params )
		{
			if (_GetColorTableParameterivSGI == null) throw new Exception( "Extension method GetColorTableParameterivSGI not found" );
			 _GetColorTableParameterivSGI( target, pname, @params );
		}
	}
}

