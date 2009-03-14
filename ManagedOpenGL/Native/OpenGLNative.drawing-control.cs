using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativedrawing_controlInit()
		{












































		}


		[DllImport( "opengl32.dll", EntryPoint="glClipPlane" )]
		public static extern void ClipPlane( ClipPlaneName plane, double[] equation ); // 
		[DllImport( "opengl32.dll", EntryPoint="glColorMaterial" )]
		public static extern void ColorMaterial( MaterialFace face, ColorMaterialParameter mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glCullFace" )]
		public static extern void CullFace( CullFaceMode mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogf" )]
		public static extern void Fogf( FogParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogfv" )]
		public static extern void Fogfv( FogParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogi" )]
		public static extern void Fogi( FogParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFogiv" )]
		public static extern void Fogiv( FogParameter pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glFrontFace" )]
		public static extern void FrontFace( FrontFaceDirection mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glHint" )]
		public static extern void Hint( HintTarget target, HintMode mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightf" )]
		public static extern void Lightf( LightName light, LightParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightfv" )]
		public static extern void Lightfv( LightName light, LightParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLighti" )]
		public static extern void Lighti( LightName light, LightParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightiv" )]
		public static extern void Lightiv( LightName light, LightParameter pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightModelf" )]
		public static extern void LightModelf( LightModelParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightModelfv" )]
		public static extern void LightModelfv( LightModelParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightModeli" )]
		public static extern void LightModeli( LightModelParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLightModeliv" )]
		public static extern void LightModeliv( LightModelParameter pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLineStipple" )]
		public static extern void LineStipple( int factor, ushort pattern ); // 
		[DllImport( "opengl32.dll", EntryPoint="glLineWidth" )]
		public static extern void LineWidth( float width ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMaterialf" )]
		public static extern void Materialf( MaterialFace face, MaterialParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMaterialfv" )]
		public static extern void Materialfv( MaterialFace face, MaterialParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMateriali" )]
		public static extern void Materiali( MaterialFace face, MaterialParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMaterialiv" )]
		public static extern void Materialiv( MaterialFace face, MaterialParameter pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPointSize" )]
		public static extern void PointSize( float size ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPolygonMode" )]
		public static extern void PolygonMode( MaterialFace face, PolygonMode mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glPolygonStipple" )]
		public static extern void PolygonStipple( byte[] mask ); // 
		[DllImport( "opengl32.dll", EntryPoint="glScissor" )]
		public static extern void Scissor( int x, int y, int width, int height ); // 
		[DllImport( "opengl32.dll", EntryPoint="glShadeModel" )]
		public static extern void ShadeModel( ShadingModel mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexParameterf" )]
		public static extern void TexParameterf( TextureTarget target, TextureParameterName pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexParameterfv" )]
		public static extern void TexParameterfv( TextureTarget target, TextureParameterName pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexParameteri" )]
		public static extern void TexParameteri( TextureTarget target, TextureParameterName pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexParameteriv" )]
		public static extern void TexParameteriv( TextureTarget target, TextureParameterName pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexImage1D" )]
		public static extern unsafe void TexImage1D( TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexImage2D" )]
		public static extern unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvf" )]
		public static extern void TexEnvf( TextureEnvTarget target, TextureEnvParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvfv" )]
		public static extern void TexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvi" )]
		public static extern void TexEnvi( TextureEnvTarget target, TextureEnvParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexEnviv" )]
		public static extern void TexEnviv( TextureEnvTarget target, TextureEnvParameter pname, int[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGend" )]
		public static extern void TexGend( TextureCoordName coord, TextureGenParameter pname, double param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGendv" )]
		public static extern void TexGendv( TextureCoordName coord, TextureGenParameter pname, double[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGenf" )]
		public static extern void TexGenf( TextureCoordName coord, TextureGenParameter pname, float param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGenfv" )]
		public static extern void TexGenfv( TextureCoordName coord, TextureGenParameter pname, float[] @params ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGeni" )]
		public static extern void TexGeni( TextureCoordName coord, TextureGenParameter pname, int param ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTexGeniv" )]
		public static extern void TexGeniv( TextureCoordName coord, TextureGenParameter pname, int[] @params ); // 
	}
}
