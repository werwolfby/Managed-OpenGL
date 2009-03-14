using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_draw_buffersInit()
		{
			_DrawBuffersATI = GetProcAdress< DrawBuffersATIDelegate >( "glDrawBuffersATI" );
		}


		public delegate void DrawBuffersATIDelegate( int n, uint[] bufs ); //  extension method

		private static DrawBuffersATIDelegate _DrawBuffersATI;

		public static  void DrawBuffersATI( int n, uint[] bufs )
		{
			if (_DrawBuffersATI == null) throw new Exception( "Extension method DrawBuffersATI not found" );
		 _DrawBuffersATI( n, bufs );
		}
	}
}
