using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativemiscInit()
		{







		}


		[DllImport( "opengl32.dll", EntryPoint="glAccum" )]
		public static extern void Accum( AccumOp op, float value ); // 
		[DllImport( "opengl32.dll", EntryPoint="glDisable" )]
		public static extern void Disable( EnableCap cap ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEnable" )]
		public static extern void Enable( EnableCap cap ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFinish" )]
		public static extern void Finish(  ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFlush" )]
		public static extern void Flush(  ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPopAttrib" )]
		public static extern void PopAttrib(  ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPushAttrib" )]
		public static extern void PushAttrib( AttribMask mask ); // 
	}
}
