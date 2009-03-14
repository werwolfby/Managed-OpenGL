using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_1_2Init()
		{
			_BlendColor = GetProcAdress< BlendColorDelegate >( "glBlendColor" );
			_BlendEquation = GetProcAdress< BlendEquationDelegate >( "glBlendEquation" );
			_DrawRangeElements = GetProcAdress< DrawRangeElementsDelegate >( "glDrawRangeElements" );
			_ColorTable = GetProcAdress< ColorTableDelegate >( "glColorTable" );
			_ColorTableParameterfv = GetProcAdress< ColorTableParameterfvDelegate >( "glColorTableParameterfv" );
			_ColorTableParameteriv = GetProcAdress< ColorTableParameterivDelegate >( "glColorTableParameteriv" );
			_CopyColorTable = GetProcAdress< CopyColorTableDelegate >( "glCopyColorTable" );
			_GetColorTable = GetProcAdress< GetColorTableDelegate >( "glGetColorTable" );
			_GetColorTableParameterfv = GetProcAdress< GetColorTableParameterfvDelegate >( "glGetColorTableParameterfv" );
			_GetColorTableParameteriv = GetProcAdress< GetColorTableParameterivDelegate >( "glGetColorTableParameteriv" );
			_ColorSubTable = GetProcAdress< ColorSubTableDelegate >( "glColorSubTable" );
			_CopyColorSubTable = GetProcAdress< CopyColorSubTableDelegate >( "glCopyColorSubTable" );
			_ConvolutionFilter1D = GetProcAdress< ConvolutionFilter1DDelegate >( "glConvolutionFilter1D" );
			_ConvolutionFilter2D = GetProcAdress< ConvolutionFilter2DDelegate >( "glConvolutionFilter2D" );
			_ConvolutionParameterf = GetProcAdress< ConvolutionParameterfDelegate >( "glConvolutionParameterf" );
			_ConvolutionParameterfv = GetProcAdress< ConvolutionParameterfvDelegate >( "glConvolutionParameterfv" );
			_ConvolutionParameteri = GetProcAdress< ConvolutionParameteriDelegate >( "glConvolutionParameteri" );
			_ConvolutionParameteriv = GetProcAdress< ConvolutionParameterivDelegate >( "glConvolutionParameteriv" );
			_CopyConvolutionFilter1D = GetProcAdress< CopyConvolutionFilter1DDelegate >( "glCopyConvolutionFilter1D" );
			_CopyConvolutionFilter2D = GetProcAdress< CopyConvolutionFilter2DDelegate >( "glCopyConvolutionFilter2D" );
			_GetConvolutionFilter = GetProcAdress< GetConvolutionFilterDelegate >( "glGetConvolutionFilter" );
			_GetConvolutionParameterfv = GetProcAdress< GetConvolutionParameterfvDelegate >( "glGetConvolutionParameterfv" );
			_GetConvolutionParameteriv = GetProcAdress< GetConvolutionParameterivDelegate >( "glGetConvolutionParameteriv" );
			_GetSeparableFilter = GetProcAdress< GetSeparableFilterDelegate >( "glGetSeparableFilter" );
			_SeparableFilter2D = GetProcAdress< SeparableFilter2DDelegate >( "glSeparableFilter2D" );
			_GetHistogram = GetProcAdress< GetHistogramDelegate >( "glGetHistogram" );
			_GetHistogramParameterfv = GetProcAdress< GetHistogramParameterfvDelegate >( "glGetHistogramParameterfv" );
			_GetHistogramParameteriv = GetProcAdress< GetHistogramParameterivDelegate >( "glGetHistogramParameteriv" );
			_GetMinmax = GetProcAdress< GetMinmaxDelegate >( "glGetMinmax" );
			_GetMinmaxParameterfv = GetProcAdress< GetMinmaxParameterfvDelegate >( "glGetMinmaxParameterfv" );
			_GetMinmaxParameteriv = GetProcAdress< GetMinmaxParameterivDelegate >( "glGetMinmaxParameteriv" );
			_Histogram = GetProcAdress< HistogramDelegate >( "glHistogram" );
			_Minmax = GetProcAdress< MinmaxDelegate >( "glMinmax" );
			_ResetHistogram = GetProcAdress< ResetHistogramDelegate >( "glResetHistogram" );
			_ResetMinmax = GetProcAdress< ResetMinmaxDelegate >( "glResetMinmax" );
			_TexImage3D = GetProcAdress< TexImage3DDelegate >( "glTexImage3D" );
			_TexSubImage3D = GetProcAdress< TexSubImage3DDelegate >( "glTexSubImage3D" );
			_CopyTexSubImage3D = GetProcAdress< CopyTexSubImage3DDelegate >( "glCopyTexSubImage3D" );
		}


		public delegate void BlendColorDelegate( float red, float green, float blue, float alpha ); // 

		private static BlendColorDelegate _BlendColor;

		public static  void BlendColor( float red, float green, float blue, float alpha )
		{
			if (_BlendColor == null) throw new Exception( "Extension method BlendColor not found" );
		 _BlendColor( red, green, blue, alpha );
		}
		public delegate void BlendEquationDelegate( uint mode ); // 

		private static BlendEquationDelegate _BlendEquation;

		public static  void BlendEquation( uint mode )
		{
			if (_BlendEquation == null) throw new Exception( "Extension method BlendEquation not found" );
		 _BlendEquation( mode );
		}
		public unsafe delegate void DrawRangeElementsDelegate( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 

		private static DrawRangeElementsDelegate _DrawRangeElements;

		public static unsafe  void DrawRangeElements( BeginMode mode, uint start, uint end, int count, uint type, void* indices )
		{
			if (_DrawRangeElements == null) throw new Exception( "Extension method DrawRangeElements not found" );
		 _DrawRangeElements( mode, start, end, count, type, indices );
		}
		public unsafe delegate void ColorTableDelegate( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); // 

		private static ColorTableDelegate _ColorTable;

		public static unsafe  void ColorTable( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table )
		{
			if (_ColorTable == null) throw new Exception( "Extension method ColorTable not found" );
		 _ColorTable( target, internalformat, width, format, type, table );
		}
		public delegate void ColorTableParameterfvDelegate( uint target, uint pname, float[] @params ); // 

		private static ColorTableParameterfvDelegate _ColorTableParameterfv;

		public static  void ColorTableParameterfv( uint target, uint pname, float[] @params )
		{
			if (_ColorTableParameterfv == null) throw new Exception( "Extension method ColorTableParameterfv not found" );
		 _ColorTableParameterfv( target, pname, @params );
		}
		public delegate void ColorTableParameterivDelegate( uint target, uint pname, int[] @params ); // 

		private static ColorTableParameterivDelegate _ColorTableParameteriv;

		public static  void ColorTableParameteriv( uint target, uint pname, int[] @params )
		{
			if (_ColorTableParameteriv == null) throw new Exception( "Extension method ColorTableParameteriv not found" );
		 _ColorTableParameteriv( target, pname, @params );
		}
		public delegate void CopyColorTableDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 

		private static CopyColorTableDelegate _CopyColorTable;

		public static  void CopyColorTable( uint target, PixelInternalFormat internalformat, int x, int y, int width )
		{
			if (_CopyColorTable == null) throw new Exception( "Extension method CopyColorTable not found" );
		 _CopyColorTable( target, internalformat, x, y, width );
		}
		public unsafe delegate void GetColorTableDelegate( uint target, PixelFormat format, PixelType type, [Out]void* table ); // 

		private static GetColorTableDelegate _GetColorTable;

		public static unsafe  void GetColorTable( uint target, PixelFormat format, PixelType type, [Out]void* table )
		{
			if (_GetColorTable == null) throw new Exception( "Extension method GetColorTable not found" );
		 _GetColorTable( target, format, type, table );
		}
		public delegate void GetColorTableParameterfvDelegate( uint target, uint pname, [Out]float[] @params ); // 

		private static GetColorTableParameterfvDelegate _GetColorTableParameterfv;

		public static  void GetColorTableParameterfv( uint target, uint pname, [Out]float[] @params )
		{
			if (_GetColorTableParameterfv == null) throw new Exception( "Extension method GetColorTableParameterfv not found" );
		 _GetColorTableParameterfv( target, pname, @params );
		}
		public delegate void GetColorTableParameterivDelegate( uint target, uint pname, [Out]int[] @params ); // 

		private static GetColorTableParameterivDelegate _GetColorTableParameteriv;

		public static  void GetColorTableParameteriv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetColorTableParameteriv == null) throw new Exception( "Extension method GetColorTableParameteriv not found" );
		 _GetColorTableParameteriv( target, pname, @params );
		}
		public unsafe delegate void ColorSubTableDelegate( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 

		private static ColorSubTableDelegate _ColorSubTable;

		public static unsafe  void ColorSubTable( uint target, int start, int count, PixelFormat format, PixelType type, void* data )
		{
			if (_ColorSubTable == null) throw new Exception( "Extension method ColorSubTable not found" );
		 _ColorSubTable( target, start, count, format, type, data );
		}
		public delegate void CopyColorSubTableDelegate( uint target, int start, int x, int y, int width ); // 

		private static CopyColorSubTableDelegate _CopyColorSubTable;

		public static  void CopyColorSubTable( uint target, int start, int x, int y, int width )
		{
			if (_CopyColorSubTable == null) throw new Exception( "Extension method CopyColorSubTable not found" );
		 _CopyColorSubTable( target, start, x, y, width );
		}
		public unsafe delegate void ConvolutionFilter1DDelegate( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); // 

		private static ConvolutionFilter1DDelegate _ConvolutionFilter1D;

		public static unsafe  void ConvolutionFilter1D( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image )
		{
			if (_ConvolutionFilter1D == null) throw new Exception( "Extension method ConvolutionFilter1D not found" );
		 _ConvolutionFilter1D( target, internalformat, width, format, type, image );
		}
		public unsafe delegate void ConvolutionFilter2DDelegate( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); // 

		private static ConvolutionFilter2DDelegate _ConvolutionFilter2D;

		public static unsafe  void ConvolutionFilter2D( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image )
		{
			if (_ConvolutionFilter2D == null) throw new Exception( "Extension method ConvolutionFilter2D not found" );
		 _ConvolutionFilter2D( target, internalformat, width, height, format, type, image );
		}
		public delegate void ConvolutionParameterfDelegate( uint target, uint pname, float @params ); // 

		private static ConvolutionParameterfDelegate _ConvolutionParameterf;

		public static  void ConvolutionParameterf( uint target, uint pname, float @params )
		{
			if (_ConvolutionParameterf == null) throw new Exception( "Extension method ConvolutionParameterf not found" );
		 _ConvolutionParameterf( target, pname, @params );
		}
		public delegate void ConvolutionParameterfvDelegate( uint target, uint pname, float[] @params ); // 

		private static ConvolutionParameterfvDelegate _ConvolutionParameterfv;

		public static  void ConvolutionParameterfv( uint target, uint pname, float[] @params )
		{
			if (_ConvolutionParameterfv == null) throw new Exception( "Extension method ConvolutionParameterfv not found" );
		 _ConvolutionParameterfv( target, pname, @params );
		}
		public delegate void ConvolutionParameteriDelegate( uint target, uint pname, int @params ); // 

		private static ConvolutionParameteriDelegate _ConvolutionParameteri;

		public static  void ConvolutionParameteri( uint target, uint pname, int @params )
		{
			if (_ConvolutionParameteri == null) throw new Exception( "Extension method ConvolutionParameteri not found" );
		 _ConvolutionParameteri( target, pname, @params );
		}
		public delegate void ConvolutionParameterivDelegate( uint target, uint pname, int[] @params ); // 

		private static ConvolutionParameterivDelegate _ConvolutionParameteriv;

		public static  void ConvolutionParameteriv( uint target, uint pname, int[] @params )
		{
			if (_ConvolutionParameteriv == null) throw new Exception( "Extension method ConvolutionParameteriv not found" );
		 _ConvolutionParameteriv( target, pname, @params );
		}
		public delegate void CopyConvolutionFilter1DDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 

		private static CopyConvolutionFilter1DDelegate _CopyConvolutionFilter1D;

		public static  void CopyConvolutionFilter1D( uint target, PixelInternalFormat internalformat, int x, int y, int width )
		{
			if (_CopyConvolutionFilter1D == null) throw new Exception( "Extension method CopyConvolutionFilter1D not found" );
		 _CopyConvolutionFilter1D( target, internalformat, x, y, width );
		}
		public delegate void CopyConvolutionFilter2DDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width, int height ); // 

		private static CopyConvolutionFilter2DDelegate _CopyConvolutionFilter2D;

		public static  void CopyConvolutionFilter2D( uint target, PixelInternalFormat internalformat, int x, int y, int width, int height )
		{
			if (_CopyConvolutionFilter2D == null) throw new Exception( "Extension method CopyConvolutionFilter2D not found" );
		 _CopyConvolutionFilter2D( target, internalformat, x, y, width, height );
		}
		public unsafe delegate void GetConvolutionFilterDelegate( uint target, PixelFormat format, PixelType type, [Out]void* image ); // 

		private static GetConvolutionFilterDelegate _GetConvolutionFilter;

		public static unsafe  void GetConvolutionFilter( uint target, PixelFormat format, PixelType type, [Out]void* image )
		{
			if (_GetConvolutionFilter == null) throw new Exception( "Extension method GetConvolutionFilter not found" );
		 _GetConvolutionFilter( target, format, type, image );
		}
		public delegate void GetConvolutionParameterfvDelegate( uint target, uint pname, [Out]float[] @params ); // 

		private static GetConvolutionParameterfvDelegate _GetConvolutionParameterfv;

		public static  void GetConvolutionParameterfv( uint target, uint pname, [Out]float[] @params )
		{
			if (_GetConvolutionParameterfv == null) throw new Exception( "Extension method GetConvolutionParameterfv not found" );
		 _GetConvolutionParameterfv( target, pname, @params );
		}
		public delegate void GetConvolutionParameterivDelegate( uint target, uint pname, [Out]int[] @params ); // 

		private static GetConvolutionParameterivDelegate _GetConvolutionParameteriv;

		public static  void GetConvolutionParameteriv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetConvolutionParameteriv == null) throw new Exception( "Extension method GetConvolutionParameteriv not found" );
		 _GetConvolutionParameteriv( target, pname, @params );
		}
		public unsafe delegate void GetSeparableFilterDelegate( uint target, PixelFormat format, PixelType type, [Out]void* row, [Out]void* column, [Out]void* span ); // 

		private static GetSeparableFilterDelegate _GetSeparableFilter;

		public static unsafe  void GetSeparableFilter( uint target, PixelFormat format, PixelType type, [Out]void* row, [Out]void* column, [Out]void* span )
		{
			if (_GetSeparableFilter == null) throw new Exception( "Extension method GetSeparableFilter not found" );
		 _GetSeparableFilter( target, format, type, row, column, span );
		}
		public unsafe delegate void SeparableFilter2DDelegate( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); // 

		private static SeparableFilter2DDelegate _SeparableFilter2D;

		public static unsafe  void SeparableFilter2D( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column )
		{
			if (_SeparableFilter2D == null) throw new Exception( "Extension method SeparableFilter2D not found" );
		 _SeparableFilter2D( target, internalformat, width, height, format, type, row, column );
		}
		public unsafe delegate void GetHistogramDelegate( uint target, bool reset, PixelFormat format, PixelType type, [Out]void* values ); // 

		private static GetHistogramDelegate _GetHistogram;

		public static unsafe  void GetHistogram( uint target, bool reset, PixelFormat format, PixelType type, [Out]void* values )
		{
			if (_GetHistogram == null) throw new Exception( "Extension method GetHistogram not found" );
		 _GetHistogram( target, reset, format, type, values );
		}
		public delegate void GetHistogramParameterfvDelegate( uint target, uint pname, [Out]float[] @params ); // 

		private static GetHistogramParameterfvDelegate _GetHistogramParameterfv;

		public static  void GetHistogramParameterfv( uint target, uint pname, [Out]float[] @params )
		{
			if (_GetHistogramParameterfv == null) throw new Exception( "Extension method GetHistogramParameterfv not found" );
		 _GetHistogramParameterfv( target, pname, @params );
		}
		public delegate void GetHistogramParameterivDelegate( uint target, uint pname, [Out]int[] @params ); // 

		private static GetHistogramParameterivDelegate _GetHistogramParameteriv;

		public static  void GetHistogramParameteriv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetHistogramParameteriv == null) throw new Exception( "Extension method GetHistogramParameteriv not found" );
		 _GetHistogramParameteriv( target, pname, @params );
		}
		public unsafe delegate void GetMinmaxDelegate( uint target, bool reset, PixelFormat format, PixelType type, [Out]void* values ); // 

		private static GetMinmaxDelegate _GetMinmax;

		public static unsafe  void GetMinmax( uint target, bool reset, PixelFormat format, PixelType type, [Out]void* values )
		{
			if (_GetMinmax == null) throw new Exception( "Extension method GetMinmax not found" );
		 _GetMinmax( target, reset, format, type, values );
		}
		public delegate void GetMinmaxParameterfvDelegate( uint target, uint pname, [Out]float[] @params ); // 

		private static GetMinmaxParameterfvDelegate _GetMinmaxParameterfv;

		public static  void GetMinmaxParameterfv( uint target, uint pname, [Out]float[] @params )
		{
			if (_GetMinmaxParameterfv == null) throw new Exception( "Extension method GetMinmaxParameterfv not found" );
		 _GetMinmaxParameterfv( target, pname, @params );
		}
		public delegate void GetMinmaxParameterivDelegate( uint target, uint pname, [Out]int[] @params ); // 

		private static GetMinmaxParameterivDelegate _GetMinmaxParameteriv;

		public static  void GetMinmaxParameteriv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetMinmaxParameteriv == null) throw new Exception( "Extension method GetMinmaxParameteriv not found" );
		 _GetMinmaxParameteriv( target, pname, @params );
		}
		public delegate void HistogramDelegate( uint target, int width, PixelInternalFormat internalformat, bool sink ); // 

		private static HistogramDelegate _Histogram;

		public static  void Histogram( uint target, int width, PixelInternalFormat internalformat, bool sink )
		{
			if (_Histogram == null) throw new Exception( "Extension method Histogram not found" );
		 _Histogram( target, width, internalformat, sink );
		}
		public delegate void MinmaxDelegate( uint target, PixelInternalFormat internalformat, bool sink ); // 

		private static MinmaxDelegate _Minmax;

		public static  void Minmax( uint target, PixelInternalFormat internalformat, bool sink )
		{
			if (_Minmax == null) throw new Exception( "Extension method Minmax not found" );
		 _Minmax( target, internalformat, sink );
		}
		public delegate void ResetHistogramDelegate( uint target ); // 

		private static ResetHistogramDelegate _ResetHistogram;

		public static  void ResetHistogram( uint target )
		{
			if (_ResetHistogram == null) throw new Exception( "Extension method ResetHistogram not found" );
		 _ResetHistogram( target );
		}
		public delegate void ResetMinmaxDelegate( uint target ); // 

		private static ResetMinmaxDelegate _ResetMinmax;

		public static  void ResetMinmax( uint target )
		{
			if (_ResetMinmax == null) throw new Exception( "Extension method ResetMinmax not found" );
		 _ResetMinmax( target );
		}
		public unsafe delegate void TexImage3DDelegate( TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); // 

		private static TexImage3DDelegate _TexImage3D;

		public static unsafe  void TexImage3D( TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexImage3D == null) throw new Exception( "Extension method TexImage3D not found" );
		 _TexImage3D( target, level, internalformat, width, height, depth, border, format, type, pixels );
		}
		public unsafe delegate void TexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); // 

		private static TexSubImage3DDelegate _TexSubImage3D;

		public static unsafe  void TexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels )
		{
			if (_TexSubImage3D == null) throw new Exception( "Extension method TexSubImage3D not found" );
		 _TexSubImage3D( target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels );
		}
		public delegate void CopyTexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); // 

		private static CopyTexSubImage3DDelegate _CopyTexSubImage3D;

		public static  void CopyTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height )
		{
			if (_CopyTexSubImage3D == null) throw new Exception( "Extension method CopyTexSubImage3D not found" );
		 _CopyTexSubImage3D( target, level, xoffset, yoffset, zoffset, x, y, width, height );
		}
	}
}
