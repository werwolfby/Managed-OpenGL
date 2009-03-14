using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_timer_queryInit()
		{
			_GetQueryObjecti64vEXT = GetProcAdress< GetQueryObjecti64vEXTDelegate >( "glGetQueryObjecti64vEXT" );
			_GetQueryObjectui64vEXT = GetProcAdress< GetQueryObjectui64vEXTDelegate >( "glGetQueryObjectui64vEXT" );
		}


		public delegate void GetQueryObjecti64vEXTDelegate( uint id, uint pname, [Out]long[] @params ); // 

		private static GetQueryObjecti64vEXTDelegate _GetQueryObjecti64vEXT;

		public static  void GetQueryObjecti64vEXT( uint id, uint pname, [Out]long[] @params )
		{
			if (_GetQueryObjecti64vEXT == null) throw new Exception( "Extension method GetQueryObjecti64vEXT not found" );
		 _GetQueryObjecti64vEXT( id, pname, @params );
		}
		public delegate void GetQueryObjectui64vEXTDelegate( uint id, uint pname, [Out]ulong[] @params ); // 

		private static GetQueryObjectui64vEXTDelegate _GetQueryObjectui64vEXT;

		public static  void GetQueryObjectui64vEXT( uint id, uint pname, [Out]ulong[] @params )
		{
			if (_GetQueryObjectui64vEXT == null) throw new Exception( "Extension method GetQueryObjectui64vEXT not found" );
		 _GetQueryObjectui64vEXT( id, pname, @params );
		}
	}
}
