using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_paletted_textureInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glColorTableEXT" )]
		public static extern unsafe void ColorTableEXT( uint target, PixelInternalFormat internalFormat, int width, PixelFormat format, PixelType type, void* table ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableEXT" )]
		public static extern unsafe void GetColorTableEXT( uint target, PixelFormat format, PixelType type, [Out]void* data ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableParameterivEXT" )]
		public static extern void GetColorTableParameterivEXT( uint target, uint pname, [Out]int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableParameterfvEXT" )]
		public static extern void GetColorTableParameterfvEXT( uint target, uint pname, [Out]float[] @params ); // 	
	}
}

