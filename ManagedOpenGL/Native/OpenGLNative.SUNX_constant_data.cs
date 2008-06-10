using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSUNX_constant_dataInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glFinishTextureSUNX" )]
		public static extern void FinishTextureSUNX(  ); // 	
	}
}

