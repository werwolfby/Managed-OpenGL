using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_color_subtableInit()
		{
			_ColorSubTableEXT = GetProcAdress< ColorSubTableEXTDelegate >( "glColorSubTableEXT" );
			_CopyColorSubTableEXT = GetProcAdress< CopyColorSubTableEXTDelegate >( "glCopyColorSubTableEXT" );
		}


		public unsafe delegate void ColorSubTableEXTDelegate( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 

		private static ColorSubTableEXTDelegate _ColorSubTableEXT;

		public static unsafe  void ColorSubTableEXT( uint target, int start, int count, PixelFormat format, PixelType type, void* data )
		{
			if (_ColorSubTableEXT == null) throw new Exception( "Extension method ColorSubTableEXT not found" );
		 _ColorSubTableEXT( target, start, count, format, type, data );
		}
		public delegate void CopyColorSubTableEXTDelegate( uint target, int start, int x, int y, int width ); // 

		private static CopyColorSubTableEXTDelegate _CopyColorSubTableEXT;

		public static  void CopyColorSubTableEXT( uint target, int start, int x, int y, int width )
		{
			if (_CopyColorSubTableEXT == null) throw new Exception( "Extension method CopyColorSubTableEXT not found" );
		 _CopyColorSubTableEXT( target, start, x, y, width );
		}
	}
}
