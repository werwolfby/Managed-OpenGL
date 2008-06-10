using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_framezoomInit()
		{
			_FrameZoomSGIX = GetProcAdress< FrameZoomSGIXDelegate >( "glFrameZoomSGIX" );
			
		}
		
	
		public delegate void FrameZoomSGIXDelegate( int factor ); //  extension method
		private static FrameZoomSGIXDelegate _FrameZoomSGIX;
		
		public static  void FrameZoomSGIX( int factor )
		{
			if (_FrameZoomSGIX == null) throw new Exception( "Extension method FrameZoomSGIX not found" );
			 _FrameZoomSGIX( factor );
		}
	}
}

