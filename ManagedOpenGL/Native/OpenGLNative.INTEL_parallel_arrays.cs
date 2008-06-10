using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeINTEL_parallel_arraysInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointervINTEL" )]
		public static extern unsafe void VertexPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointervINTEL" )]
		public static extern unsafe void NormalPointervINTEL( NormalPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorPointervINTEL" )]
		public static extern unsafe void ColorPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointervINTEL" )]
		public static extern unsafe void TexCoordPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
	}
}

