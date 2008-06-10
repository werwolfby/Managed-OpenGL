using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_flush_rasterInit()
		{
			_FlushRasterSGIX = GetProcAdress< FlushRasterSGIXDelegate >( "glFlushRasterSGIX" );
			
		}
		
	
		public delegate void FlushRasterSGIXDelegate(  ); //  extension method
		private static FlushRasterSGIXDelegate _FlushRasterSGIX;
		
		public static  void FlushRasterSGIX(  )
		{
			if (_FlushRasterSGIX == null) throw new Exception( "Extension method FlushRasterSGIX not found" );
			 _FlushRasterSGIX(  );
		}
	}
}

