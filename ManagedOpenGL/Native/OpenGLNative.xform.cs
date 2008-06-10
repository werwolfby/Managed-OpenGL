using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativexformInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glDepthRange" )]
		public static extern void DepthRange( double near, double far ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFrustum" )]
		public static extern void Frustum( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadIdentity" )]
		public static extern void LoadIdentity(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadMatrixf" )]
		public static extern void LoadMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadMatrixd" )]
		public static extern void LoadMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMatrixMode" )]
		public static extern void MatrixMode( MatrixMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultMatrixf" )]
		public static extern void MultMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultMatrixd" )]
		public static extern void MultMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glOrtho" )]
		public static extern void Ortho( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopMatrix" )]
		public static extern void PopMatrix(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushMatrix" )]
		public static extern void PushMatrix(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRotated" )]
		public static extern void Rotated( double angle, double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRotatef" )]
		public static extern void Rotatef( float angle, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glScaled" )]
		public static extern void Scaled( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glScalef" )]
		public static extern void Scalef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTranslated" )]
		public static extern void Translated( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTranslatef" )]
		public static extern void Translatef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glViewport" )]
		public static extern void Viewport( int x, int y, int width, int height ); // 	
	}
}

