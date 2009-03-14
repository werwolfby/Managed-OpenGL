using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativemodelingInit()
		{




















		}


		[DllImport( "opengl32.dll", EntryPoint="glMap1d" )]
		public static extern void Map1d( MapTarget target, double u1, double u2, int stride, int order, double[] points ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMap1f" )]
		public static extern void Map1f( MapTarget target, float u1, float u2, int stride, int order, float[] points ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMap2d" )]
		public static extern void Map2d( MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMap2f" )]
		public static extern void Map2f( MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid1d" )]
		public static extern void MapGrid1d( int un, double u1, double u2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid1f" )]
		public static extern void MapGrid1f( int un, float u1, float u2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid2d" )]
		public static extern void MapGrid2d( int un, double u1, double u2, int vn, double v1, double v2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid2f" )]
		public static extern void MapGrid2f( int un, float u1, float u2, int vn, float v1, float v2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1d" )]
		public static extern void EvalCoord1d( double u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1dv" )]
		public static extern void EvalCoord1dv( double[] u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1f" )]
		public static extern void EvalCoord1f( float u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1fv" )]
		public static extern void EvalCoord1fv( float[] u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2d" )]
		public static extern void EvalCoord2d( double u, double v ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2dv" )]
		public static extern void EvalCoord2dv( double[] u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2f" )]
		public static extern void EvalCoord2f( float u, float v ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2fv" )]
		public static extern void EvalCoord2fv( float[] u ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalMesh1" )]
		public static extern void EvalMesh1( MeshMode1 mode, int i1, int i2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalPoint1" )]
		public static extern void EvalPoint1( int i ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalMesh2" )]
		public static extern void EvalMesh2( MeshMode2 mode, int i1, int i2, int j1, int j2 ); // 
		[DllImport( "opengl32.dll", EntryPoint="glEvalPoint2" )]
		public static extern void EvalPoint2( int i, int j ); // 
	}
}
