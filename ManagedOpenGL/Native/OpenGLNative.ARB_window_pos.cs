using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_window_posInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dARB" )]
		public static extern void WindowPos2dARB( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dvARB" )]
		public static extern void WindowPos2dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fARB" )]
		public static extern void WindowPos2fARB( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fvARB" )]
		public static extern void WindowPos2fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2iARB" )]
		public static extern void WindowPos2iARB( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2ivARB" )]
		public static extern void WindowPos2ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2sARB" )]
		public static extern void WindowPos2sARB( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2svARB" )]
		public static extern void WindowPos2svARB( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dARB" )]
		public static extern void WindowPos3dARB( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dvARB" )]
		public static extern void WindowPos3dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fARB" )]
		public static extern void WindowPos3fARB( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fvARB" )]
		public static extern void WindowPos3fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3iARB" )]
		public static extern void WindowPos3iARB( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3ivARB" )]
		public static extern void WindowPos3ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3sARB" )]
		public static extern void WindowPos3sARB( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3svARB" )]
		public static extern void WindowPos3svARB( short[] v ); // 	
	}
}

