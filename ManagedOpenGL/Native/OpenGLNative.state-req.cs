using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativestate_reqInit()
		{






























		}


		[DllImport( "opengl32.dll", EntryPoint="glGetBooleanv" )]
		public static extern void GetBooleanv( GetPName pname, [Out]bool[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetClipPlane" )]
		public static extern void GetClipPlane( ClipPlaneName plane, [Out]double[] equation ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetDoublev" )]
		public static extern void GetDoublev( GetPName pname, [Out]double[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetError" )]
		public static extern ErrorCode GetError(  ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetFloatv" )]
		public static extern void GetFloatv( GetPName pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetIntegerv" )]
		public static extern void GetIntegerv( GetPName pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetLightfv" )]
		public static extern void GetLightfv( LightName light, LightParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetLightiv" )]
		public static extern void GetLightiv( LightName light, LightParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetMapdv" )]
		public static extern void GetMapdv( MapTarget target, GetMapQuery query, [Out]double[] v ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetMapfv" )]
		public static extern void GetMapfv( MapTarget target, GetMapQuery query, [Out]float[] v ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetMapiv" )]
		public static extern void GetMapiv( MapTarget target, GetMapQuery query, [Out]int[] v ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetMaterialfv" )]
		public static extern void GetMaterialfv( MaterialFace face, MaterialParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetMaterialiv" )]
		public static extern void GetMaterialiv( MaterialFace face, MaterialParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapfv" )]
		public static extern void GetPixelMapfv( PixelMap map, [Out]float[] values ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapuiv" )]
		public static extern void GetPixelMapuiv( PixelMap map, [Out]uint[] values ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapusv" )]
		public static extern void GetPixelMapusv( PixelMap map, [Out]ushort[] values ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetPolygonStipple" )]
		public static extern void GetPolygonStipple( [Out]byte[] mask ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetString" )]
		public static extern string GetString( StringName name ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexEnvfv" )]
		public static extern void GetTexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexEnviv" )]
		public static extern void GetTexEnviv( TextureEnvTarget target, TextureEnvParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGendv" )]
		public static extern void GetTexGendv( TextureCoordName coord, TextureGenParameter pname, [Out]double[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGenfv" )]
		public static extern void GetTexGenfv( TextureCoordName coord, TextureGenParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGeniv" )]
		public static extern void GetTexGeniv( TextureCoordName coord, TextureGenParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexImage" )]
		public static extern unsafe void GetTexImage( TextureTarget target, int level, PixelFormat format, PixelType type, [Out]void* pixels ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexParameterfv" )]
		public static extern void GetTexParameterfv( TextureTarget target, GetTextureParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexParameteriv" )]
		public static extern void GetTexParameteriv( TextureTarget target, GetTextureParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexLevelParameterfv" )]
		public static extern void GetTexLevelParameterfv( TextureTarget target, int level, GetTextureParameter pname, [Out]float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glGetTexLevelParameteriv" )]
		public static extern void GetTexLevelParameteriv( TextureTarget target, int level, GetTextureParameter pname, [Out]int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glIsEnabled" )]
		public static extern bool IsEnabled( EnableCap cap ); // 
		[DllImport( "opengl32.dll", EntryPoint="glIsList" )]
		public static extern bool IsList( uint list ); // 
	}
}
