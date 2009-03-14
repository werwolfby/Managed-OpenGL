using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_pixel_transformInit()
		{




		}


		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameteriEXT" )]
		public static extern void PixelTransformParameteriEXT( uint target, uint pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterfEXT" )]
		public static extern void PixelTransformParameterfEXT( uint target, uint pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterivEXT" )]
		public static extern void PixelTransformParameterivEXT( uint target, uint pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterfvEXT" )]
		public static extern void PixelTransformParameterfvEXT( uint target, uint pname, float[] @params ); // 
	}
}
