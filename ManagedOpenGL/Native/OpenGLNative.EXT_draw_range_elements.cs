using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_draw_range_elementsInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glDrawRangeElementsEXT" )]
		public static extern unsafe void DrawRangeElementsEXT( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 	
	}
}

