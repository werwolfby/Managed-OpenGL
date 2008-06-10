using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNative1_1Init()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glArrayElement" )]
		public static extern void ArrayElement( int i ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorPointer" )]
		public static extern unsafe void ColorPointer( int size, ColorPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDisableClientState" )]
		public static extern void DisableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawArrays" )]
		public static extern void DrawArrays( BeginMode mode, int first, int count ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawElements" )]
		public static extern unsafe void DrawElements( BeginMode mode, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagPointer" )]
		public static extern unsafe void EdgeFlagPointer( int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEnableClientState" )]
		public static extern void EnableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPointerv" )]
		public static extern unsafe void GetPointerv( GetPointervPName pname, [Out]void** @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexPointer" )]
		public static extern unsafe void IndexPointer( IndexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glInterleavedArrays" )]
		public static extern unsafe void InterleavedArrays( InterleavedArrayFormat format, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointer" )]
		public static extern unsafe void NormalPointer( NormalPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointer" )]
		public static extern unsafe void TexCoordPointer( int size, TexCoordPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointer" )]
		public static extern unsafe void VertexPointer( int size, VertexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPolygonOffset" )]
		public static extern void PolygonOffset( float factor, float units ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexImage1D" )]
		public static extern void CopyTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexImage2D" )]
		public static extern void CopyTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexSubImage1D" )]
		public static extern void CopyTexSubImage1D( TextureTarget target, int level, int xoffset, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexSubImage2D" )]
		public static extern void CopyTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexSubImage1D" )]
		public static extern unsafe void TexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexSubImage2D" )]
		public static extern unsafe void TexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glAreTexturesResident" )]
		public static extern bool AreTexturesResident( int n, uint[] textures, [Out]bool[] residences ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBindTexture" )]
		public static extern void BindTexture( TextureTarget target, uint texture ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDeleteTextures" )]
		public static extern void DeleteTextures( int n, uint[] textures ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGenTextures" )]
		public static extern void GenTextures( int n, [Out]uint[] textures ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIsTexture" )]
		public static extern bool IsTexture( uint texture ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPrioritizeTextures" )]
		public static extern void PrioritizeTextures( int n, uint[] textures, float[] priorities ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexub" )]
		public static extern void Indexub( byte c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexubv" )]
		public static extern void Indexubv( byte[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopClientAttrib" )]
		public static extern void PopClientAttrib(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushClientAttrib" )]
		public static extern void PushClientAttrib( ClientAttribMask mask ); // 	
	}
}

