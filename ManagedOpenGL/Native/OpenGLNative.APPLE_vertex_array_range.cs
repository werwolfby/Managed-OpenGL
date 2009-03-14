using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeAPPLE_vertex_array_rangeInit()
		{
			_VertexArrayRangeAPPLE = GetProcAdress< VertexArrayRangeAPPLEDelegate >( "glVertexArrayRangeAPPLE" );
			_FlushVertexArrayRangeAPPLE = GetProcAdress< FlushVertexArrayRangeAPPLEDelegate >( "glFlushVertexArrayRangeAPPLE" );
			_VertexArrayParameteriAPPLE = GetProcAdress< VertexArrayParameteriAPPLEDelegate >( "glVertexArrayParameteriAPPLE" );
		}


		public unsafe delegate void VertexArrayRangeAPPLEDelegate( int length, [Out]void* pointer ); //  extension method

		private static VertexArrayRangeAPPLEDelegate _VertexArrayRangeAPPLE;

		public static unsafe  void VertexArrayRangeAPPLE( int length, [Out]void* pointer )
		{
			if (_VertexArrayRangeAPPLE == null) throw new Exception( "Extension method VertexArrayRangeAPPLE not found" );
		 _VertexArrayRangeAPPLE( length, pointer );
		}
		public unsafe delegate void FlushVertexArrayRangeAPPLEDelegate( int length, [Out]void* pointer ); //  extension method

		private static FlushVertexArrayRangeAPPLEDelegate _FlushVertexArrayRangeAPPLE;

		public static unsafe  void FlushVertexArrayRangeAPPLE( int length, [Out]void* pointer )
		{
			if (_FlushVertexArrayRangeAPPLE == null) throw new Exception( "Extension method FlushVertexArrayRangeAPPLE not found" );
		 _FlushVertexArrayRangeAPPLE( length, pointer );
		}
		public delegate void VertexArrayParameteriAPPLEDelegate( uint pname, int param ); //  extension method

		private static VertexArrayParameteriAPPLEDelegate _VertexArrayParameteriAPPLE;

		public static  void VertexArrayParameteriAPPLE( uint pname, int param )
		{
			if (_VertexArrayParameteriAPPLE == null) throw new Exception( "Extension method VertexArrayParameteriAPPLE not found" );
		 _VertexArrayParameteriAPPLE( pname, param );
		}
	}
}
