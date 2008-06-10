using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeMESA_window_posInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dMESA" )]
		public static extern void WindowPos2dMESA( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dvMESA" )]
		public static extern void WindowPos2dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fMESA" )]
		public static extern void WindowPos2fMESA( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fvMESA" )]
		public static extern void WindowPos2fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2iMESA" )]
		public static extern void WindowPos2iMESA( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2ivMESA" )]
		public static extern void WindowPos2ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2sMESA" )]
		public static extern void WindowPos2sMESA( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2svMESA" )]
		public static extern void WindowPos2svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dMESA" )]
		public static extern void WindowPos3dMESA( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dvMESA" )]
		public static extern void WindowPos3dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fMESA" )]
		public static extern void WindowPos3fMESA( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fvMESA" )]
		public static extern void WindowPos3fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3iMESA" )]
		public static extern void WindowPos3iMESA( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3ivMESA" )]
		public static extern void WindowPos3ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3sMESA" )]
		public static extern void WindowPos3sMESA( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3svMESA" )]
		public static extern void WindowPos3svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4dMESA" )]
		public static extern void WindowPos4dMESA( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4dvMESA" )]
		public static extern void WindowPos4dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4fMESA" )]
		public static extern void WindowPos4fMESA( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4fvMESA" )]
		public static extern void WindowPos4fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4iMESA" )]
		public static extern void WindowPos4iMESA( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4ivMESA" )]
		public static extern void WindowPos4ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4sMESA" )]
		public static extern void WindowPos4sMESA( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4svMESA" )]
		public static extern void WindowPos4svMESA( short[] v ); // 	
	}
}

