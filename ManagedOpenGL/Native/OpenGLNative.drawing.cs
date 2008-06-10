using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativedrawingInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glBegin" )]
		public static extern void Begin( BeginMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBitmap" )]
		public static extern void Bitmap( int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3b" )]
		public static extern void Color3b( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3bv" )]
		public static extern void Color3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3d" )]
		public static extern void Color3d( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3dv" )]
		public static extern void Color3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3f" )]
		public static extern void Color3f( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fv" )]
		public static extern void Color3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3i" )]
		public static extern void Color3i( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3iv" )]
		public static extern void Color3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3s" )]
		public static extern void Color3s( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3sv" )]
		public static extern void Color3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ub" )]
		public static extern void Color3ub( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ubv" )]
		public static extern void Color3ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ui" )]
		public static extern void Color3ui( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3uiv" )]
		public static extern void Color3uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3us" )]
		public static extern void Color3us( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3usv" )]
		public static extern void Color3usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4b" )]
		public static extern void Color4b( sbyte red, sbyte green, sbyte blue, sbyte alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4bv" )]
		public static extern void Color4bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4d" )]
		public static extern void Color4d( double red, double green, double blue, double alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4dv" )]
		public static extern void Color4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4f" )]
		public static extern void Color4f( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fv" )]
		public static extern void Color4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4i" )]
		public static extern void Color4i( int red, int green, int blue, int alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4iv" )]
		public static extern void Color4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4s" )]
		public static extern void Color4s( short red, short green, short blue, short alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4sv" )]
		public static extern void Color4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ub" )]
		public static extern void Color4ub( byte red, byte green, byte blue, byte alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubv" )]
		public static extern void Color4ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ui" )]
		public static extern void Color4ui( uint red, uint green, uint blue, uint alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4uiv" )]
		public static extern void Color4uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4us" )]
		public static extern void Color4us( ushort red, ushort green, ushort blue, ushort alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4usv" )]
		public static extern void Color4usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlag" )]
		public static extern void EdgeFlag( bool flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagv" )]
		public static extern void EdgeFlagv( bool[] flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEnd" )]
		public static extern void End(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexd" )]
		public static extern void Indexd( double c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexdv" )]
		public static extern void Indexdv( double[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexf" )]
		public static extern void Indexf( float c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexfv" )]
		public static extern void Indexfv( float[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexi" )]
		public static extern void Indexi( int c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexiv" )]
		public static extern void Indexiv( int[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexs" )]
		public static extern void Indexs( short c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexsv" )]
		public static extern void Indexsv( short[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3b" )]
		public static extern void Normal3b( sbyte nx, sbyte ny, sbyte nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3bv" )]
		public static extern void Normal3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3d" )]
		public static extern void Normal3d( double nx, double ny, double nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3dv" )]
		public static extern void Normal3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3f" )]
		public static extern void Normal3f( float nx, float ny, float nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fv" )]
		public static extern void Normal3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3i" )]
		public static extern void Normal3i( int nx, int ny, int nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3iv" )]
		public static extern void Normal3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3s" )]
		public static extern void Normal3s( short nx, short ny, short nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3sv" )]
		public static extern void Normal3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2d" )]
		public static extern void RasterPos2d( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2dv" )]
		public static extern void RasterPos2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2f" )]
		public static extern void RasterPos2f( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2fv" )]
		public static extern void RasterPos2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2i" )]
		public static extern void RasterPos2i( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2iv" )]
		public static extern void RasterPos2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2s" )]
		public static extern void RasterPos2s( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2sv" )]
		public static extern void RasterPos2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3d" )]
		public static extern void RasterPos3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3dv" )]
		public static extern void RasterPos3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3f" )]
		public static extern void RasterPos3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3fv" )]
		public static extern void RasterPos3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3i" )]
		public static extern void RasterPos3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3iv" )]
		public static extern void RasterPos3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3s" )]
		public static extern void RasterPos3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3sv" )]
		public static extern void RasterPos3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4d" )]
		public static extern void RasterPos4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4dv" )]
		public static extern void RasterPos4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4f" )]
		public static extern void RasterPos4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4fv" )]
		public static extern void RasterPos4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4i" )]
		public static extern void RasterPos4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4iv" )]
		public static extern void RasterPos4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4s" )]
		public static extern void RasterPos4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4sv" )]
		public static extern void RasterPos4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectd" )]
		public static extern void Rectd( double x1, double y1, double x2, double y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectdv" )]
		public static extern void Rectdv( double[] v1, double[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectf" )]
		public static extern void Rectf( float x1, float y1, float x2, float y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectfv" )]
		public static extern void Rectfv( float[] v1, float[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRecti" )]
		public static extern void Recti( int x1, int y1, int x2, int y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectiv" )]
		public static extern void Rectiv( int[] v1, int[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRects" )]
		public static extern void Rects( short x1, short y1, short x2, short y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectsv" )]
		public static extern void Rectsv( short[] v1, short[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1d" )]
		public static extern void TexCoord1d( double s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1dv" )]
		public static extern void TexCoord1dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1f" )]
		public static extern void TexCoord1f( float s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1fv" )]
		public static extern void TexCoord1fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1i" )]
		public static extern void TexCoord1i( int s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1iv" )]
		public static extern void TexCoord1iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1s" )]
		public static extern void TexCoord1s( short s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1sv" )]
		public static extern void TexCoord1sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2d" )]
		public static extern void TexCoord2d( double s, double t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2dv" )]
		public static extern void TexCoord2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2f" )]
		public static extern void TexCoord2f( float s, float t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fv" )]
		public static extern void TexCoord2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2i" )]
		public static extern void TexCoord2i( int s, int t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2iv" )]
		public static extern void TexCoord2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2s" )]
		public static extern void TexCoord2s( short s, short t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2sv" )]
		public static extern void TexCoord2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3d" )]
		public static extern void TexCoord3d( double s, double t, double r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3dv" )]
		public static extern void TexCoord3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3f" )]
		public static extern void TexCoord3f( float s, float t, float r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3fv" )]
		public static extern void TexCoord3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3i" )]
		public static extern void TexCoord3i( int s, int t, int r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3iv" )]
		public static extern void TexCoord3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3s" )]
		public static extern void TexCoord3s( short s, short t, short r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3sv" )]
		public static extern void TexCoord3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4d" )]
		public static extern void TexCoord4d( double s, double t, double r, double q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4dv" )]
		public static extern void TexCoord4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4f" )]
		public static extern void TexCoord4f( float s, float t, float r, float q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fv" )]
		public static extern void TexCoord4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4i" )]
		public static extern void TexCoord4i( int s, int t, int r, int q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4iv" )]
		public static extern void TexCoord4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4s" )]
		public static extern void TexCoord4s( short s, short t, short r, short q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4sv" )]
		public static extern void TexCoord4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2d" )]
		public static extern void Vertex2d( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2dv" )]
		public static extern void Vertex2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2f" )]
		public static extern void Vertex2f( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2fv" )]
		public static extern void Vertex2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2i" )]
		public static extern void Vertex2i( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2iv" )]
		public static extern void Vertex2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2s" )]
		public static extern void Vertex2s( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2sv" )]
		public static extern void Vertex2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3d" )]
		public static extern void Vertex3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3dv" )]
		public static extern void Vertex3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3f" )]
		public static extern void Vertex3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3fv" )]
		public static extern void Vertex3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3i" )]
		public static extern void Vertex3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3iv" )]
		public static extern void Vertex3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3s" )]
		public static extern void Vertex3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3sv" )]
		public static extern void Vertex3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4d" )]
		public static extern void Vertex4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4dv" )]
		public static extern void Vertex4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4f" )]
		public static extern void Vertex4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4fv" )]
		public static extern void Vertex4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4i" )]
		public static extern void Vertex4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4iv" )]
		public static extern void Vertex4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4s" )]
		public static extern void Vertex4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4sv" )]
		public static extern void Vertex4sv( short[] v ); // 	
	}
}

