using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeframebufInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glDrawBuffer" )]
		public static extern void DrawBuffer( DrawBufferMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClear" )]
		public static extern void Clear( ClearBufferMask mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearAccum" )]
		public static extern void ClearAccum( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearIndex" )]
		public static extern void ClearIndex( float c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearColor" )]
		public static extern void ClearColor( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearStencil" )]
		public static extern void ClearStencil( int s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearDepth" )]
		public static extern void ClearDepth( double depth ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilMask" )]
		public static extern void StencilMask( uint mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorMask" )]
		public static extern void ColorMask( bool red, bool green, bool blue, bool alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDepthMask" )]
		public static extern void DepthMask( bool flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexMask" )]
		public static extern void IndexMask( uint mask ); // 	
	}
}

