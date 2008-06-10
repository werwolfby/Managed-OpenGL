using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativepixel_rwInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glPixelZoom" )]
		public static extern void PixelZoom( float xfactor, float yfactor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransferf" )]
		public static extern void PixelTransferf( PixelTransferParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransferi" )]
		public static extern void PixelTransferi( PixelTransferParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelStoref" )]
		public static extern void PixelStoref( PixelStoreParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelStorei" )]
		public static extern void PixelStorei( PixelStoreParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapfv" )]
		public static extern void PixelMapfv( PixelMap map, int mapsize, float[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapuiv" )]
		public static extern void PixelMapuiv( PixelMap map, int mapsize, uint[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapusv" )]
		public static extern void PixelMapusv( PixelMap map, int mapsize, ushort[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReadBuffer" )]
		public static extern void ReadBuffer( ReadBufferMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyPixels" )]
		public static extern void CopyPixels( int x, int y, int width, int height, PixelCopyType type ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReadPixels" )]
		public static extern unsafe void ReadPixels( int x, int y, int width, int height, PixelFormat format, PixelType type, [Out]void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawPixels" )]
		public static extern unsafe void DrawPixels( int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
	}
}

