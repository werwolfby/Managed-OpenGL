using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_draw_buffersInit()
		{
			_DrawBuffersARB = GetProcAdress< DrawBuffersARBDelegate >( "glDrawBuffersARB" );
			
		}
		
	
		public delegate void DrawBuffersARBDelegate( int n, uint[] bufs ); //  extension method
		private static DrawBuffersARBDelegate _DrawBuffersARB;
		
		public static  void DrawBuffersARB( int n, uint[] bufs )
		{
			if (_DrawBuffersARB == null) throw new Exception( "Extension method DrawBuffersARB not found" );
			 _DrawBuffersARB( n, bufs );
		}
	}
}

