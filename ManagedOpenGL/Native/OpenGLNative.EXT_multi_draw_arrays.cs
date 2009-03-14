using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_multi_draw_arraysInit()
		{


		}


		[DllImport( "opengl32.dll", EntryPoint="glMultiDrawArraysEXT" )]
		public static extern void MultiDrawArraysEXT( BeginMode mode, [Out]int[] first, [Out]int[] count, int primcount ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMultiDrawElementsEXT" )]
		public static extern unsafe void MultiDrawElementsEXT( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 
	}
}
