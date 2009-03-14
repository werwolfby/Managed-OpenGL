using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeAPPLE_flush_buffer_rangeInit()
		{
			_BufferParameteriAPPLE = GetProcAdress< BufferParameteriAPPLEDelegate >( "glBufferParameteriAPPLE" );
			_FlushMappedBufferRangeAPPLE = GetProcAdress< FlushMappedBufferRangeAPPLEDelegate >( "glFlushMappedBufferRangeAPPLE" );
		}


		public delegate void BufferParameteriAPPLEDelegate( uint target, uint pname, int param ); //  extension method

		private static BufferParameteriAPPLEDelegate _BufferParameteriAPPLE;

		public static  void BufferParameteriAPPLE( uint target, uint pname, int param )
		{
			if (_BufferParameteriAPPLE == null) throw new Exception( "Extension method BufferParameteriAPPLE not found" );
		 _BufferParameteriAPPLE( target, pname, param );
		}
		public delegate void FlushMappedBufferRangeAPPLEDelegate( uint target, int offset, int size ); //  extension method

		private static FlushMappedBufferRangeAPPLEDelegate _FlushMappedBufferRangeAPPLE;

		public static  void FlushMappedBufferRangeAPPLE( uint target, int offset, int size )
		{
			if (_FlushMappedBufferRangeAPPLE == null) throw new Exception( "Extension method FlushMappedBufferRangeAPPLE not found" );
		 _FlushMappedBufferRangeAPPLE( target, offset, size );
		}
	}
}
