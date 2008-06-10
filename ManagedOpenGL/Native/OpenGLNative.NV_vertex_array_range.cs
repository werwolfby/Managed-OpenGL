using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_vertex_array_rangeInit()
		{
			_FlushVertexArrayRangeNV = GetProcAdress< FlushVertexArrayRangeNVDelegate >( "glFlushVertexArrayRangeNV" );
			_VertexArrayRangeNV = GetProcAdress< VertexArrayRangeNVDelegate >( "glVertexArrayRangeNV" );
			
		}
		
	
		public delegate void FlushVertexArrayRangeNVDelegate(  ); //  extension method
		private static FlushVertexArrayRangeNVDelegate _FlushVertexArrayRangeNV;
		
		public static  void FlushVertexArrayRangeNV(  )
		{
			if (_FlushVertexArrayRangeNV == null) throw new Exception( "Extension method FlushVertexArrayRangeNV not found" );
			 _FlushVertexArrayRangeNV(  );
		}
		public unsafe delegate void VertexArrayRangeNVDelegate( int length, void* pointer ); //  extension method
		private static VertexArrayRangeNVDelegate _VertexArrayRangeNV;
		
		public static unsafe  void VertexArrayRangeNV( int length, void* pointer )
		{
			if (_VertexArrayRangeNV == null) throw new Exception( "Extension method VertexArrayRangeNV not found" );
			 _VertexArrayRangeNV( length, pointer );
		}
	}
}

