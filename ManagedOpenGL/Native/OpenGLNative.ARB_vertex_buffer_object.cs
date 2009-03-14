using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_vertex_buffer_objectInit()
		{
			_BindBufferARB = GetProcAdress< BindBufferARBDelegate >( "glBindBufferARB" );
			_DeleteBuffersARB = GetProcAdress< DeleteBuffersARBDelegate >( "glDeleteBuffersARB" );
			_GenBuffersARB = GetProcAdress< GenBuffersARBDelegate >( "glGenBuffersARB" );
			_IsBufferARB = GetProcAdress< IsBufferARBDelegate >( "glIsBufferARB" );
			_BufferDataARB = GetProcAdress< BufferDataARBDelegate >( "glBufferDataARB" );
			_BufferSubDataARB = GetProcAdress< BufferSubDataARBDelegate >( "glBufferSubDataARB" );
			_GetBufferSubDataARB = GetProcAdress< GetBufferSubDataARBDelegate >( "glGetBufferSubDataARB" );
			_MapBufferARB = GetProcAdress< MapBufferARBDelegate >( "glMapBufferARB" );
			_UnmapBufferARB = GetProcAdress< UnmapBufferARBDelegate >( "glUnmapBufferARB" );
			_GetBufferParameterivARB = GetProcAdress< GetBufferParameterivARBDelegate >( "glGetBufferParameterivARB" );
			_GetBufferPointervARB = GetProcAdress< GetBufferPointervARBDelegate >( "glGetBufferPointervARB" );
		}


		public delegate void BindBufferARBDelegate( uint target, uint buffer ); //  extension method

		private static BindBufferARBDelegate _BindBufferARB;

		public static  void BindBufferARB( uint target, uint buffer )
		{
			if (_BindBufferARB == null) throw new Exception( "Extension method BindBufferARB not found" );
		 _BindBufferARB( target, buffer );
		}
		public delegate void DeleteBuffersARBDelegate( int n, uint[] buffers ); //  extension method

		private static DeleteBuffersARBDelegate _DeleteBuffersARB;

		public static  void DeleteBuffersARB( int n, uint[] buffers )
		{
			if (_DeleteBuffersARB == null) throw new Exception( "Extension method DeleteBuffersARB not found" );
		 _DeleteBuffersARB( n, buffers );
		}
		public delegate void GenBuffersARBDelegate( int n, [Out]uint[] buffers ); //  extension method

		private static GenBuffersARBDelegate _GenBuffersARB;

		public static  void GenBuffersARB( int n, [Out]uint[] buffers )
		{
			if (_GenBuffersARB == null) throw new Exception( "Extension method GenBuffersARB not found" );
		 _GenBuffersARB( n, buffers );
		}
		public delegate bool IsBufferARBDelegate( uint buffer ); //  extension method

		private static IsBufferARBDelegate _IsBufferARB;

		public static  bool IsBufferARB( uint buffer )
		{
			if (_IsBufferARB == null) throw new Exception( "Extension method IsBufferARB not found" );
		return  _IsBufferARB( buffer );
		}
		public unsafe delegate void BufferDataARBDelegate( uint target, int size, void* data, uint usage ); //  extension method

		private static BufferDataARBDelegate _BufferDataARB;

		public static unsafe  void BufferDataARB( uint target, int size, void* data, uint usage )
		{
			if (_BufferDataARB == null) throw new Exception( "Extension method BufferDataARB not found" );
		 _BufferDataARB( target, size, data, usage );
		}
		public unsafe delegate void BufferSubDataARBDelegate( uint target, int offset, int size, void* data ); //  extension method

		private static BufferSubDataARBDelegate _BufferSubDataARB;

		public static unsafe  void BufferSubDataARB( uint target, int offset, int size, void* data )
		{
			if (_BufferSubDataARB == null) throw new Exception( "Extension method BufferSubDataARB not found" );
		 _BufferSubDataARB( target, offset, size, data );
		}
		public unsafe delegate void GetBufferSubDataARBDelegate( uint target, int offset, int size, [Out]void* data ); //  extension method

		private static GetBufferSubDataARBDelegate _GetBufferSubDataARB;

		public static unsafe  void GetBufferSubDataARB( uint target, int offset, int size, [Out]void* data )
		{
			if (_GetBufferSubDataARB == null) throw new Exception( "Extension method GetBufferSubDataARB not found" );
		 _GetBufferSubDataARB( target, offset, size, data );
		}
		public unsafe delegate void* MapBufferARBDelegate( uint target, uint access ); //  extension method

		private static MapBufferARBDelegate _MapBufferARB;

		public static unsafe  void* MapBufferARB( uint target, uint access )
		{
			if (_MapBufferARB == null) throw new Exception( "Extension method MapBufferARB not found" );
		return  _MapBufferARB( target, access );
		}
		public delegate bool UnmapBufferARBDelegate( uint target ); //  extension method

		private static UnmapBufferARBDelegate _UnmapBufferARB;

		public static  bool UnmapBufferARB( uint target )
		{
			if (_UnmapBufferARB == null) throw new Exception( "Extension method UnmapBufferARB not found" );
		return  _UnmapBufferARB( target );
		}
		public delegate void GetBufferParameterivARBDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetBufferParameterivARBDelegate _GetBufferParameterivARB;

		public static  void GetBufferParameterivARB( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetBufferParameterivARB == null) throw new Exception( "Extension method GetBufferParameterivARB not found" );
		 _GetBufferParameterivARB( target, pname, @params );
		}
		public unsafe delegate void GetBufferPointervARBDelegate( uint target, uint pname, [Out]void** @params ); //  extension method

		private static GetBufferPointervARBDelegate _GetBufferPointervARB;

		public static unsafe  void GetBufferPointervARB( uint target, uint pname, [Out]void** @params )
		{
			if (_GetBufferPointervARB == null) throw new Exception( "Extension method GetBufferPointervARB not found" );
		 _GetBufferPointervARB( target, pname, @params );
		}
	}
}
