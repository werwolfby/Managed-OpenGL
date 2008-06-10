using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeIBM_multimode_draw_arraysInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glMultiModeDrawArraysIBM" )]
		public static extern void MultiModeDrawArraysIBM( BeginMode mode, int[] first, int[] count, int primcount, int modestride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultiModeDrawElementsIBM" )]
		public static extern unsafe void MultiModeDrawElementsIBM( BeginMode mode, int[] count, uint type, void** indices, int primcount, int modestride ); // 	
	}
}

