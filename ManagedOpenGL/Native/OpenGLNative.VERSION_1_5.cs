using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_1_5Init()
		{
			_GenQueries = GetProcAdress< GenQueriesDelegate >( "glGenQueries" );
			_DeleteQueries = GetProcAdress< DeleteQueriesDelegate >( "glDeleteQueries" );
			_IsQuery = GetProcAdress< IsQueryDelegate >( "glIsQuery" );
			_BeginQuery = GetProcAdress< BeginQueryDelegate >( "glBeginQuery" );
			_EndQuery = GetProcAdress< EndQueryDelegate >( "glEndQuery" );
			_GetQueryiv = GetProcAdress< GetQueryivDelegate >( "glGetQueryiv" );
			_GetQueryObjectiv = GetProcAdress< GetQueryObjectivDelegate >( "glGetQueryObjectiv" );
			_GetQueryObjectuiv = GetProcAdress< GetQueryObjectuivDelegate >( "glGetQueryObjectuiv" );
			_BindBuffer = GetProcAdress< BindBufferDelegate >( "glBindBuffer" );
			_DeleteBuffers = GetProcAdress< DeleteBuffersDelegate >( "glDeleteBuffers" );
			_GenBuffers = GetProcAdress< GenBuffersDelegate >( "glGenBuffers" );
			_IsBuffer = GetProcAdress< IsBufferDelegate >( "glIsBuffer" );
			_BufferData = GetProcAdress< BufferDataDelegate >( "glBufferData" );
			_BufferSubData = GetProcAdress< BufferSubDataDelegate >( "glBufferSubData" );
			_GetBufferSubData = GetProcAdress< GetBufferSubDataDelegate >( "glGetBufferSubData" );
			_MapBuffer = GetProcAdress< MapBufferDelegate >( "glMapBuffer" );
			_UnmapBuffer = GetProcAdress< UnmapBufferDelegate >( "glUnmapBuffer" );
			_GetBufferParameteriv = GetProcAdress< GetBufferParameterivDelegate >( "glGetBufferParameteriv" );
			_GetBufferPointerv = GetProcAdress< GetBufferPointervDelegate >( "glGetBufferPointerv" );
		}


		public delegate void GenQueriesDelegate( int n, [Out]uint[] ids ); //  extension method

		private static GenQueriesDelegate _GenQueries;

		public static  void GenQueries( int n, [Out]uint[] ids )
		{
			if (_GenQueries == null) throw new Exception( "Extension method GenQueries not found" );
		 _GenQueries( n, ids );
		}
		public delegate void DeleteQueriesDelegate( int n, uint[] ids ); //  extension method

		private static DeleteQueriesDelegate _DeleteQueries;

		public static  void DeleteQueries( int n, uint[] ids )
		{
			if (_DeleteQueries == null) throw new Exception( "Extension method DeleteQueries not found" );
		 _DeleteQueries( n, ids );
		}
		public delegate bool IsQueryDelegate( uint id ); //  extension method

		private static IsQueryDelegate _IsQuery;

		public static  bool IsQuery( uint id )
		{
			if (_IsQuery == null) throw new Exception( "Extension method IsQuery not found" );
		return  _IsQuery( id );
		}
		public delegate void BeginQueryDelegate( uint target, uint id ); //  extension method

		private static BeginQueryDelegate _BeginQuery;

		public static  void BeginQuery( uint target, uint id )
		{
			if (_BeginQuery == null) throw new Exception( "Extension method BeginQuery not found" );
		 _BeginQuery( target, id );
		}
		public delegate void EndQueryDelegate( uint target ); //  extension method

		private static EndQueryDelegate _EndQuery;

		public static  void EndQuery( uint target )
		{
			if (_EndQuery == null) throw new Exception( "Extension method EndQuery not found" );
		 _EndQuery( target );
		}
		public delegate void GetQueryivDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetQueryivDelegate _GetQueryiv;

		public static  void GetQueryiv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetQueryiv == null) throw new Exception( "Extension method GetQueryiv not found" );
		 _GetQueryiv( target, pname, @params );
		}
		public delegate void GetQueryObjectivDelegate( uint id, uint pname, [Out]int[] @params ); //  extension method

		private static GetQueryObjectivDelegate _GetQueryObjectiv;

		public static  void GetQueryObjectiv( uint id, uint pname, [Out]int[] @params )
		{
			if (_GetQueryObjectiv == null) throw new Exception( "Extension method GetQueryObjectiv not found" );
		 _GetQueryObjectiv( id, pname, @params );
		}
		public delegate void GetQueryObjectuivDelegate( uint id, uint pname, [Out]uint[] @params ); //  extension method

		private static GetQueryObjectuivDelegate _GetQueryObjectuiv;

		public static  void GetQueryObjectuiv( uint id, uint pname, [Out]uint[] @params )
		{
			if (_GetQueryObjectuiv == null) throw new Exception( "Extension method GetQueryObjectuiv not found" );
		 _GetQueryObjectuiv( id, pname, @params );
		}
		public delegate void BindBufferDelegate( uint target, uint buffer ); //  extension method

		private static BindBufferDelegate _BindBuffer;

		public static  void BindBuffer( uint target, uint buffer )
		{
			if (_BindBuffer == null) throw new Exception( "Extension method BindBuffer not found" );
		 _BindBuffer( target, buffer );
		}
		public delegate void DeleteBuffersDelegate( int n, uint[] buffers ); //  extension method

		private static DeleteBuffersDelegate _DeleteBuffers;

		public static  void DeleteBuffers( int n, uint[] buffers )
		{
			if (_DeleteBuffers == null) throw new Exception( "Extension method DeleteBuffers not found" );
		 _DeleteBuffers( n, buffers );
		}
		public delegate void GenBuffersDelegate( int n, [Out]uint[] buffers ); //  extension method

		private static GenBuffersDelegate _GenBuffers;

		public static  void GenBuffers( int n, [Out]uint[] buffers )
		{
			if (_GenBuffers == null) throw new Exception( "Extension method GenBuffers not found" );
		 _GenBuffers( n, buffers );
		}
		public delegate bool IsBufferDelegate( uint buffer ); //  extension method

		private static IsBufferDelegate _IsBuffer;

		public static  bool IsBuffer( uint buffer )
		{
			if (_IsBuffer == null) throw new Exception( "Extension method IsBuffer not found" );
		return  _IsBuffer( buffer );
		}
		public unsafe delegate void BufferDataDelegate( uint target, int size, void* data, uint usage ); //  extension method

		private static BufferDataDelegate _BufferData;

		public static unsafe  void BufferData( uint target, int size, void* data, uint usage )
		{
			if (_BufferData == null) throw new Exception( "Extension method BufferData not found" );
		 _BufferData( target, size, data, usage );
		}
		public unsafe delegate void BufferSubDataDelegate( uint target, int offset, int size, void* data ); //  extension method

		private static BufferSubDataDelegate _BufferSubData;

		public static unsafe  void BufferSubData( uint target, int offset, int size, void* data )
		{
			if (_BufferSubData == null) throw new Exception( "Extension method BufferSubData not found" );
		 _BufferSubData( target, offset, size, data );
		}
		public unsafe delegate void GetBufferSubDataDelegate( uint target, int offset, int size, [Out]void* data ); //  extension method

		private static GetBufferSubDataDelegate _GetBufferSubData;

		public static unsafe  void GetBufferSubData( uint target, int offset, int size, [Out]void* data )
		{
			if (_GetBufferSubData == null) throw new Exception( "Extension method GetBufferSubData not found" );
		 _GetBufferSubData( target, offset, size, data );
		}
		public unsafe delegate void* MapBufferDelegate( uint target, uint access ); //  extension method

		private static MapBufferDelegate _MapBuffer;

		public static unsafe  void* MapBuffer( uint target, uint access )
		{
			if (_MapBuffer == null) throw new Exception( "Extension method MapBuffer not found" );
		return  _MapBuffer( target, access );
		}
		public delegate bool UnmapBufferDelegate( uint target ); //  extension method

		private static UnmapBufferDelegate _UnmapBuffer;

		public static  bool UnmapBuffer( uint target )
		{
			if (_UnmapBuffer == null) throw new Exception( "Extension method UnmapBuffer not found" );
		return  _UnmapBuffer( target );
		}
		public delegate void GetBufferParameterivDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetBufferParameterivDelegate _GetBufferParameteriv;

		public static  void GetBufferParameteriv( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetBufferParameteriv == null) throw new Exception( "Extension method GetBufferParameteriv not found" );
		 _GetBufferParameteriv( target, pname, @params );
		}
		public unsafe delegate void GetBufferPointervDelegate( uint target, uint pname, [Out]void** @params ); //  extension method

		private static GetBufferPointervDelegate _GetBufferPointerv;

		public static unsafe  void GetBufferPointerv( uint target, uint pname, [Out]void** @params )
		{
			if (_GetBufferPointerv == null) throw new Exception( "Extension method GetBufferPointerv not found" );
		 _GetBufferPointerv( target, pname, @params );
		}
	}
}
