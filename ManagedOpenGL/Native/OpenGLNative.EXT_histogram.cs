using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_histogramInit()
		{
			_GetHistogramEXT = GetProcAdress< GetHistogramEXTDelegate >( "glGetHistogramEXT" );
			_GetHistogramParameterfvEXT = GetProcAdress< GetHistogramParameterfvEXTDelegate >( "glGetHistogramParameterfvEXT" );
			_GetHistogramParameterivEXT = GetProcAdress< GetHistogramParameterivEXTDelegate >( "glGetHistogramParameterivEXT" );
			_GetMinmaxEXT = GetProcAdress< GetMinmaxEXTDelegate >( "glGetMinmaxEXT" );
			_GetMinmaxParameterfvEXT = GetProcAdress< GetMinmaxParameterfvEXTDelegate >( "glGetMinmaxParameterfvEXT" );
			_GetMinmaxParameterivEXT = GetProcAdress< GetMinmaxParameterivEXTDelegate >( "glGetMinmaxParameterivEXT" );
			_HistogramEXT = GetProcAdress< HistogramEXTDelegate >( "glHistogramEXT" );
			_MinmaxEXT = GetProcAdress< MinmaxEXTDelegate >( "glMinmaxEXT" );
			_ResetHistogramEXT = GetProcAdress< ResetHistogramEXTDelegate >( "glResetHistogramEXT" );
			_ResetMinmaxEXT = GetProcAdress< ResetMinmaxEXTDelegate >( "glResetMinmaxEXT" );
		}


		public unsafe delegate void GetHistogramEXTDelegate( HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, [Out]void* values ); //  extension method

		private static GetHistogramEXTDelegate _GetHistogramEXT;

		public static unsafe  void GetHistogramEXT( HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, [Out]void* values )
		{
			if (_GetHistogramEXT == null) throw new Exception( "Extension method GetHistogramEXT not found" );
		 _GetHistogramEXT( target, reset, format, type, values );
		}
		public delegate void GetHistogramParameterfvEXTDelegate( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out]float[] @params ); //  extension method

		private static GetHistogramParameterfvEXTDelegate _GetHistogramParameterfvEXT;

		public static  void GetHistogramParameterfvEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out]float[] @params )
		{
			if (_GetHistogramParameterfvEXT == null) throw new Exception( "Extension method GetHistogramParameterfvEXT not found" );
		 _GetHistogramParameterfvEXT( target, pname, @params );
		}
		public delegate void GetHistogramParameterivEXTDelegate( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out]int[] @params ); //  extension method

		private static GetHistogramParameterivEXTDelegate _GetHistogramParameterivEXT;

		public static  void GetHistogramParameterivEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out]int[] @params )
		{
			if (_GetHistogramParameterivEXT == null) throw new Exception( "Extension method GetHistogramParameterivEXT not found" );
		 _GetHistogramParameterivEXT( target, pname, @params );
		}
		public unsafe delegate void GetMinmaxEXTDelegate( MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, [Out]void* values ); //  extension method

		private static GetMinmaxEXTDelegate _GetMinmaxEXT;

		public static unsafe  void GetMinmaxEXT( MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, [Out]void* values )
		{
			if (_GetMinmaxEXT == null) throw new Exception( "Extension method GetMinmaxEXT not found" );
		 _GetMinmaxEXT( target, reset, format, type, values );
		}
		public delegate void GetMinmaxParameterfvEXTDelegate( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out]float[] @params ); //  extension method

		private static GetMinmaxParameterfvEXTDelegate _GetMinmaxParameterfvEXT;

		public static  void GetMinmaxParameterfvEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out]float[] @params )
		{
			if (_GetMinmaxParameterfvEXT == null) throw new Exception( "Extension method GetMinmaxParameterfvEXT not found" );
		 _GetMinmaxParameterfvEXT( target, pname, @params );
		}
		public delegate void GetMinmaxParameterivEXTDelegate( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out]int[] @params ); //  extension method

		private static GetMinmaxParameterivEXTDelegate _GetMinmaxParameterivEXT;

		public static  void GetMinmaxParameterivEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out]int[] @params )
		{
			if (_GetMinmaxParameterivEXT == null) throw new Exception( "Extension method GetMinmaxParameterivEXT not found" );
		 _GetMinmaxParameterivEXT( target, pname, @params );
		}
		public delegate void HistogramEXTDelegate( HistogramTargetEXT target, int width, PixelInternalFormat internalformat, bool sink ); //  extension method

		private static HistogramEXTDelegate _HistogramEXT;

		public static  void HistogramEXT( HistogramTargetEXT target, int width, PixelInternalFormat internalformat, bool sink )
		{
			if (_HistogramEXT == null) throw new Exception( "Extension method HistogramEXT not found" );
		 _HistogramEXT( target, width, internalformat, sink );
		}
		public delegate void MinmaxEXTDelegate( MinmaxTargetEXT target, PixelInternalFormat internalformat, bool sink ); //  extension method

		private static MinmaxEXTDelegate _MinmaxEXT;

		public static  void MinmaxEXT( MinmaxTargetEXT target, PixelInternalFormat internalformat, bool sink )
		{
			if (_MinmaxEXT == null) throw new Exception( "Extension method MinmaxEXT not found" );
		 _MinmaxEXT( target, internalformat, sink );
		}
		public delegate void ResetHistogramEXTDelegate( HistogramTargetEXT target ); //  extension method

		private static ResetHistogramEXTDelegate _ResetHistogramEXT;

		public static  void ResetHistogramEXT( HistogramTargetEXT target )
		{
			if (_ResetHistogramEXT == null) throw new Exception( "Extension method ResetHistogramEXT not found" );
		 _ResetHistogramEXT( target );
		}
		public delegate void ResetMinmaxEXTDelegate( MinmaxTargetEXT target ); //  extension method

		private static ResetMinmaxEXTDelegate _ResetMinmaxEXT;

		public static  void ResetMinmaxEXT( MinmaxTargetEXT target )
		{
			if (_ResetMinmaxEXT == null) throw new Exception( "Extension method ResetMinmaxEXT not found" );
		 _ResetMinmaxEXT( target );
		}
	}
}
