using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeMESA_resize_buffersInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glResizeBuffersMESA" )]
		public static extern void ResizeBuffersMESA(  ); // 	
	}
}

