using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeIBM_vertex_array_listsInit()
		{








		}


		[DllImport( "opengl32.dll", EntryPoint="glColorPointerListIBM" )]
		public static extern unsafe void ColorPointerListIBM( int size, ColorPointerType type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColorPointerListIBM" )]
		public static extern unsafe void SecondaryColorPointerListIBM( int size, uint type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagPointerListIBM" )]
		public static extern unsafe void EdgeFlagPointerListIBM( int stride, bool*[] pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordPointerListIBM" )]
		public static extern unsafe void FogCoordPointerListIBM( uint type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glIndexPointerListIBM" )]
		public static extern unsafe void IndexPointerListIBM( IndexPointerType type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointerListIBM" )]
		public static extern unsafe void NormalPointerListIBM( NormalPointerType type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointerListIBM" )]
		public static extern unsafe void TexCoordPointerListIBM( int size, TexCoordPointerType type, int stride, void** pointer, int ptrstride ); // 
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointerListIBM" )]
		public static extern unsafe void VertexPointerListIBM( int size, VertexPointerType type, int stride, void** pointer, int ptrstride ); // 
	}
}
