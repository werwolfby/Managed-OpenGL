using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeHP_image_transformInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameteriHP" )]
		public static extern void ImageTransformParameteriHP( uint target, uint pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterfHP" )]
		public static extern void ImageTransformParameterfHP( uint target, uint pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterivHP" )]
		public static extern void ImageTransformParameterivHP( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterfvHP" )]
		public static extern void ImageTransformParameterfvHP( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetImageTransformParameterivHP" )]
		public static extern void GetImageTransformParameterivHP( uint target, uint pname, [Out]int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetImageTransformParameterfvHP" )]
		public static extern void GetImageTransformParameterfvHP( uint target, uint pname, [Out]float[] @params ); // 	
	}
}

