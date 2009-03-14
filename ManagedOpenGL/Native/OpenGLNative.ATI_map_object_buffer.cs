using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_map_object_bufferInit()
		{
			_MapObjectBufferATI = GetProcAdress< MapObjectBufferATIDelegate >( "glMapObjectBufferATI" );
			_UnmapObjectBufferATI = GetProcAdress< UnmapObjectBufferATIDelegate >( "glUnmapObjectBufferATI" );
		}


		public unsafe delegate void* MapObjectBufferATIDelegate( uint buffer ); //  extension method

		private static MapObjectBufferATIDelegate _MapObjectBufferATI;

		public static unsafe  void* MapObjectBufferATI( uint buffer )
		{
			if (_MapObjectBufferATI == null) throw new Exception( "Extension method MapObjectBufferATI not found" );
		return  _MapObjectBufferATI( buffer );
		}
		public delegate void UnmapObjectBufferATIDelegate( uint buffer ); //  extension method

		private static UnmapObjectBufferATIDelegate _UnmapObjectBufferATI;

		public static  void UnmapObjectBufferATI( uint buffer )
		{
			if (_UnmapObjectBufferATI == null) throw new Exception( "Extension method UnmapObjectBufferATI not found" );
		 _UnmapObjectBufferATI( buffer );
		}
	}
}
