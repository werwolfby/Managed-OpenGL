using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_fog_coordInit()
		{





		}


		[DllImport( "opengl32.dll", EntryPoint="glFogCoordfEXT" )]
		public static extern void FogCoordfEXT( float coord ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordfvEXT" )]
		public static extern void FogCoordfvEXT( float[] coord ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogCoorddEXT" )]
		public static extern void FogCoorddEXT( double coord ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogCoorddvEXT" )]
		public static extern void FogCoorddvEXT( double[] coord ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordPointerEXT" )]
		public static extern unsafe void FogCoordPointerEXT( uint type, int stride, void* pointer ); // 
	}
}
