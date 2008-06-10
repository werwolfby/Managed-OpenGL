using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_secondary_colorInit()
		{
			_SecondaryColorPointerEXT = GetProcAdress< SecondaryColorPointerEXTDelegate >( "glSecondaryColorPointerEXT" );
			
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3bEXT" )]
		public static extern void SecondaryColor3bEXT( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3bvEXT" )]
		public static extern void SecondaryColor3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3dEXT" )]
		public static extern void SecondaryColor3dEXT( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3dvEXT" )]
		public static extern void SecondaryColor3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3fEXT" )]
		public static extern void SecondaryColor3fEXT( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3fvEXT" )]
		public static extern void SecondaryColor3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3iEXT" )]
		public static extern void SecondaryColor3iEXT( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ivEXT" )]
		public static extern void SecondaryColor3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3sEXT" )]
		public static extern void SecondaryColor3sEXT( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3svEXT" )]
		public static extern void SecondaryColor3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ubEXT" )]
		public static extern void SecondaryColor3ubEXT( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ubvEXT" )]
		public static extern void SecondaryColor3ubvEXT( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3uiEXT" )]
		public static extern void SecondaryColor3uiEXT( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3uivEXT" )]
		public static extern void SecondaryColor3uivEXT( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3usEXT" )]
		public static extern void SecondaryColor3usEXT( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3usvEXT" )]
		public static extern void SecondaryColor3usvEXT( ushort[] v ); // 	
		public unsafe delegate void SecondaryColorPointerEXTDelegate( int size, ColorPointerType type, int stride, void* pointer ); //  extension method
		private static SecondaryColorPointerEXTDelegate _SecondaryColorPointerEXT;
		
		public static unsafe  void SecondaryColorPointerEXT( int size, ColorPointerType type, int stride, void* pointer )
		{
			if (_SecondaryColorPointerEXT == null) throw new Exception( "Extension method SecondaryColorPointerEXT not found" );
			 _SecondaryColorPointerEXT( size, type, stride, pointer );
		}
	}
}

