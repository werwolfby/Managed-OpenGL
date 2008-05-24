using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static class OpenGLNative
	{
		[DllImport( "opengl32.dll" )]
		public static extern void NewList( uint list, ListMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void EndList(  );
		[DllImport( "opengl32.dll" )]
		public static extern void CallList( uint list );
		[DllImport( "opengl32.dll" )]
		public static extern void CallLists( int n, ListNameType type, void lists );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteLists( uint list, int range );
		[DllImport( "opengl32.dll" )]
		public static extern uint GenLists( int range );
		[DllImport( "opengl32.dll" )]
		public static extern void ListBase( uint @base );
		[DllImport( "opengl32.dll" )]
		public static extern void Begin( BeginMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void Bitmap( int width, int height, float xorig, float yorig, float xmove, float ymove, byte bitmap );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3b( sbyte red, sbyte green, sbyte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3bv( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3d( double red, double green, double blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3f( float red, float green, float blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3i( int red, int green, int blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3s( short red, short green, short blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ub( byte red, byte green, byte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ubv( byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ui( uint red, uint green, uint blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3uiv( uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3us( ushort red, ushort green, ushort blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3usv( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4b( sbyte red, sbyte green, sbyte blue, sbyte alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4bv( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4d( double red, double green, double blue, double alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4f( float red, float green, float blue, float alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4i( int red, int green, int blue, int alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4s( short red, short green, short blue, short alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ub( byte red, byte green, byte blue, byte alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubv( byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ui( uint red, uint green, uint blue, uint alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4uiv( uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4us( ushort red, ushort green, ushort blue, ushort alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4usv( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlag( bool flag );
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagv( bool flag );
		[DllImport( "opengl32.dll" )]
		public static extern void End(  );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexd( double c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexdv( double c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexf( float c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexfv( float c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexi( int c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexiv( int c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexs( short c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexsv( short c );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3b( sbyte nx, sbyte ny, sbyte nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3bv( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3d( double nx, double ny, double nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3f( float nx, float ny, float nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3i( int nx, int ny, int nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3s( short nx, short ny, short nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2d( double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2f( float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2i( int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2s( short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3d( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3f( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3i( int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3s( short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4d( double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4f( float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4i( int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4s( short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectd( double x1, double y1, double x2, double y2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectdv( double v1, double v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectf( float x1, float y1, float x2, float y2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectfv( float v1, float v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Recti( int x1, int y1, int x2, int y2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectiv( int v1, int v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rects( short x1, short y1, short x2, short y2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Rectsv( short v1, short v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1d( double s );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1f( float s );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1i( int s );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1s( short s );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2d( double s, double t );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2f( float s, float t );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2i( int s, int t );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2s( short s, short t );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3d( double s, double t, double r );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3f( float s, float t, float r );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3i( int s, int t, int r );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3s( short s, short t, short r );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4d( double s, double t, double r, double q );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4f( float s, float t, float r, float q );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4i( int s, int t, int r, int q );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4s( short s, short t, short r, short q );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2d( double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2f( float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2i( int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2s( short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3d( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3f( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3i( int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3s( short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4d( double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4f( float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4i( int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4s( short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void ClipPlane( ClipPlaneName plane, double equation );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorMaterial( MaterialFace face, ColorMaterialParameter mode );
		[DllImport( "opengl32.dll" )]
		public static extern void CullFace( CullFaceMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void Fogf( FogParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void Fogfv( FogParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void Fogi( FogParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void Fogiv( FogParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FrontFace( FrontFaceDirection mode );
		[DllImport( "opengl32.dll" )]
		public static extern void Hint( HintTarget target, HintMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void Lightf( LightName light, LightParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void Lightfv( LightName light, LightParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void Lighti( LightName light, LightParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void Lightiv( LightName light, LightParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void LightModelf( LightModelParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void LightModelfv( LightModelParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void LightModeli( LightModelParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void LightModeliv( LightModelParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void LineStipple( int factor, ushort pattern );
		[DllImport( "opengl32.dll" )]
		public static extern void LineWidth( float width );
		[DllImport( "opengl32.dll" )]
		public static extern void Materialf( MaterialFace face, MaterialParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void Materialfv( MaterialFace face, MaterialParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void Materiali( MaterialFace face, MaterialParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void Materialiv( MaterialFace face, MaterialParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PointSize( float size );
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonMode( MaterialFace face, PolygonMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonStipple( byte mask );
		[DllImport( "opengl32.dll" )]
		public static extern void Scissor( int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void ShadeModel( ShadingModel mode );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterf( TextureTarget target, TextureParameterName pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterfv( TextureTarget target, TextureParameterName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameteri( TextureTarget target, TextureParameterName pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameteriv( TextureTarget target, TextureParameterName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexImage1D( TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvf( TextureEnvTarget target, TextureEnvParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvi( TextureEnvTarget target, TextureEnvParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnviv( TextureEnvTarget target, TextureEnvParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGend( TextureCoordName coord, TextureGenParameter pname, double param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGendv( TextureCoordName coord, TextureGenParameter pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGenf( TextureCoordName coord, TextureGenParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGenfv( TextureCoordName coord, TextureGenParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGeni( TextureCoordName coord, TextureGenParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexGeniv( TextureCoordName coord, TextureGenParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FeedbackBuffer( int size, FeedbackType type, float buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void SelectBuffer( int size, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern int RenderMode( RenderingMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void InitNames(  );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadName( uint name );
		[DllImport( "opengl32.dll" )]
		public static extern void PassThrough( float token );
		[DllImport( "opengl32.dll" )]
		public static extern void PopName(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PushName( uint name );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffer( DrawBufferMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void Clear( ClearBufferMask mask );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearAccum( float red, float green, float blue, float alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearIndex( float c );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearColor( float red, float green, float blue, float alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearStencil( int s );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearDepth( double depth );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilMask( uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorMask( bool red, bool green, bool blue, bool alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthMask( bool flag );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexMask( uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void Accum( AccumOp op, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Disable( EnableCap cap );
		[DllImport( "opengl32.dll" )]
		public static extern void Enable( EnableCap cap );
		[DllImport( "opengl32.dll" )]
		public static extern void Finish(  );
		[DllImport( "opengl32.dll" )]
		public static extern void Flush(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PopAttrib(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PushAttrib( AttribMask mask );
		[DllImport( "opengl32.dll" )]
		public static extern void Map1d( MapTarget target, double u1, double u2, int stride, int order, double points );
		[DllImport( "opengl32.dll" )]
		public static extern void Map1f( MapTarget target, float u1, float u2, int stride, int order, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void Map2d( MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double points );
		[DllImport( "opengl32.dll" )]
		public static extern void Map2f( MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid1d( int un, double u1, double u2 );
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid1f( int un, float u1, float u2 );
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid2d( int un, double u1, double u2, int vn, double v1, double v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid2f( int un, float u1, float u2, int vn, float v1, float v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1d( double u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1dv( double u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1f( float u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1fv( float u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2d( double u, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2dv( double u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2f( float u, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2fv( float u );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMesh1( MeshMode1 mode, int i1, int i2 );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalPoint1( int i );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMesh2( MeshMode2 mode, int i1, int i2, int j1, int j2 );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalPoint2( int i, int j );
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFunc( AlphaFunction func, float @ref );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFunc( BlendingFactorSrc sfactor, BlendingFactorDest dfactor );
		[DllImport( "opengl32.dll" )]
		public static extern void LogicOp( LogicOp opcode );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilFunc( StencilFunction func, int @ref, uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilOp( StencilOp fail, StencilOp zfail, StencilOp zpass );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthFunc( DepthFunction func );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelZoom( float xfactor, float yfactor );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransferf( PixelTransferParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransferi( PixelTransferParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelSto@ref( PixelStoreParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelStorei( PixelStoreParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapfv( PixelMap map, int mapsize, float values );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapuiv( PixelMap map, int mapsize, uint values );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapusv( PixelMap map, int mapsize, ushort values );
		[DllImport( "opengl32.dll" )]
		public static extern void ReadBuffer( ReadBufferMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyPixels( int x, int y, int width, int height, PixelCopyType type );
		[DllImport( "opengl32.dll" )]
		public static extern void ReadPixels( int x, int y, int width, int height, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawPixels( int width, int height, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBooleanv( GetPName pname, bool @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetClipPlane( ClipPlaneName plane, double equation );
		[DllImport( "opengl32.dll" )]
		public static extern void GetDoublev( GetPName pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern ErrorCode GetError(  );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFloatv( GetPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetIntegerv( GetPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetLightfv( LightName light, LightParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetLightiv( LightName light, LightParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapdv( MapTarget target, GetMapQuery query, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapfv( MapTarget target, GetMapQuery query, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapiv( MapTarget target, GetMapQuery query, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMaterialfv( MaterialFace face, MaterialParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMaterialiv( MaterialFace face, MaterialParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapfv( PixelMap map, float values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapuiv( PixelMap map, uint values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapusv( PixelMap map, ushort values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPolygonStipple( byte mask );
		[DllImport( "opengl32.dll" )]
		public static extern string GetString( StringName name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexEnviv( TextureEnvTarget target, TextureEnvParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGendv( TextureCoordName coord, TextureGenParameter pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGenfv( TextureCoordName coord, TextureGenParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGeniv( TextureCoordName coord, TextureGenParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexImage( TextureTarget target, int level, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameterfv( TextureTarget target, GetTextureParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameteriv( TextureTarget target, GetTextureParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexLevelParameterfv( TextureTarget target, int level, GetTextureParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexLevelParameteriv( TextureTarget target, int level, GetTextureParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsEnabled( EnableCap cap );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsList( uint list );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthRange( double near, double far );
		[DllImport( "opengl32.dll" )]
		public static extern void Frustum( double left, double right, double bottom, double top, double zNear, double zFar );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadIdentity(  );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadMatrixf( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadMatrixd( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixMode( MatrixMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void MultMatrixf( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void MultMatrixd( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void Ortho( double left, double right, double bottom, double top, double zNear, double zFar );
		[DllImport( "opengl32.dll" )]
		public static extern void PopMatrix(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PushMatrix(  );
		[DllImport( "opengl32.dll" )]
		public static extern void Rotated( double angle, double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void Rotatef( float angle, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Scaled( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void Scalef( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Translated( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void Translatef( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Viewport( int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayElement( int i );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorPointer( int size, ColorPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void DisableClientState( EnableCap array );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawArrays( BeginMode mode, int first, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElements( BeginMode mode, int count, DrawElementsType type, void indices );
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagPointer( int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void EnableClientState( EnableCap array );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPointerv( GetPointervPName pname, void @params );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexPointer( IndexPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void InterleavedArrays( InterleavedArrayFormat format, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalPointer( NormalPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoordPointer( int size, TexCoordPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexPointer( int size, VertexPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonOffset( float factor, float units );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage1D( TextureTarget target, int level, int xoffset, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern bool AreTexturesResident( int n, uint textures, bool residences );
		[DllImport( "opengl32.dll" )]
		public static extern void BindTexture( TextureTarget target, uint texture );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteTextures( int n, uint textures );
		[DllImport( "opengl32.dll" )]
		public static extern void GenTextures( int n, uint textures );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsTexture( uint texture );
		[DllImport( "opengl32.dll" )]
		public static extern void PrioritizeTextures( int n, uint textures, float priorities );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexub( byte c );
		[DllImport( "opengl32.dll" )]
		public static extern void Indexubv( byte c );
		[DllImport( "opengl32.dll" )]
		public static extern void PopClientAttrib(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PushClientAttrib( ClientAttribMask mask );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendColor( float red, float green, float blue, float alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquation( BlendEquationMode mode );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElements( BeginMode mode, uint start, uint end, int count, DrawElementsType type, void indices );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTable( ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void table );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterfv( ColorTableTarget target, ColorTableParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameteriv( ColorTableTarget target, ColorTableParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorTable( ColorTableTarget target, PixelInternalFormat internalformat, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTable( ColorTableTarget target, PixelFormat format, PixelType type, void table );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfv( ColorTableTarget target, GetColorTableParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameteriv( ColorTableTarget target, GetColorTableParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorSubTable( ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorSubTable( ColorTableTarget target, int start, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionFilter1D( ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionFilter2D( ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterf( ConvolutionTarget target, ConvolutionParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfv( ConvolutionTarget target, ConvolutionParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteri( ConvolutionTarget target, ConvolutionParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteriv( ConvolutionTarget target, ConvolutionParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter1D( ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter2D( ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionFilter( ConvolutionTarget target, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterfv( ConvolutionTarget target, GetConvolutionParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameteriv( ConvolutionTarget target, GetConvolutionParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetSeparableFilter( SeparableTarget target, PixelFormat format, PixelType type, void row, void column, void span );
		[DllImport( "opengl32.dll" )]
		public static extern void SeparableFilter2D( SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void row, void column );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogram( HistogramTarget target, bool reset, PixelFormat format, PixelType type, void values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterfv( HistogramTarget target, GetHistogramParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameteriv( HistogramTarget target, GetHistogramParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmax( MinmaxTarget target, bool reset, PixelFormat format, PixelType type, void values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterfv( MinmaxTarget target, GetMinmaxParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameteriv( MinmaxTarget target, GetMinmaxParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void Histogram( HistogramTarget target, int width, PixelInternalFormat internalformat, bool sink );
		[DllImport( "opengl32.dll" )]
		public static extern void Minmax( MinmaxTarget target, PixelInternalFormat internalformat, bool sink );
		[DllImport( "opengl32.dll" )]
		public static extern void ResetHistogram( HistogramTarget target );
		[DllImport( "opengl32.dll" )]
		public static extern void ResetMinmax( MinmaxTarget target );
		[DllImport( "opengl32.dll" )]
		public static extern void TexImage3D( TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveTexture( TextureUnit texture );
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveTexture( TextureUnit texture );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1d( TextureUnit target, double s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dv( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1f( TextureUnit target, float s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fv( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1i( TextureUnit target, int s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1iv( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1s( TextureUnit target, short s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1sv( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2d( TextureUnit target, double s, double t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dv( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2f( TextureUnit target, float s, float t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fv( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2i( TextureUnit target, int s, int t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2iv( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2s( TextureUnit target, short s, short t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2sv( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3d( TextureUnit target, double s, double t, double r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dv( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3f( TextureUnit target, float s, float t, float r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fv( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3i( TextureUnit target, int s, int t, int r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3iv( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3s( TextureUnit target, short s, short t, short r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3sv( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4d( TextureUnit target, double s, double t, double r, double q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dv( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4f( TextureUnit target, float s, float t, float r, float q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fv( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4i( TextureUnit target, int s, int t, int r, int q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4iv( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4s( TextureUnit target, short s, short t, short r, short q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4sv( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixf( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixd( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixf( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixd( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void SampleCoverage( float value, bool invert );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage3D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCompressedTexImage( TextureTarget target, int level, void img );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparate( BlendFuncSeparateParameterEXT sfactorRGB, BlendFuncSeparateParameterEXT dfactorRGB, BlendFuncSeparateParameterEXT sfactorAlpha, BlendFuncSeparateParameterEXT dfactorAlpha );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordf( float coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfv( float coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordd( double coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddv( double coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordPointer( FogPointerTypeEXT type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawArrays( BeginMode mode, int first, int count, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawElements( BeginMode mode, int count, DrawElementsType type, void indices, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterf( PointParameterNameARB pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfv( PointParameterNameARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteri( PointParameterNameARB pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteriv( PointParameterNameARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3b( sbyte red, sbyte green, sbyte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bv( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3d( double red, double green, double blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3f( float red, float green, float blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3i( int red, int green, int blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3s( short red, short green, short blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ub( byte red, byte green, byte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubv( byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ui( uint red, uint green, uint blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uiv( uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3us( ushort red, ushort green, ushort blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usv( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColorPointer( int size, ColorPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2d( double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2f( float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2i( int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2s( short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3d( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dv( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3f( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fv( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3i( int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iv( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3s( short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sv( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void GenQueries( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteQueries( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsQuery( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginQuery( GLenum target, uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void EndQuery( GLenum target );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryiv( GLenum target, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectiv( uint id, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectuiv( uint id, GLenum pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void BindBuffer( BufferTargetARB target, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteBuffers( int n, uint buffers );
		[DllImport( "opengl32.dll" )]
		public static extern void GenBuffers( int n, uint buffers );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsBuffer( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void BufferData( BufferTargetARB target, int size, void data, BufferUsageARB usage );
		[DllImport( "opengl32.dll" )]
		public static extern void BufferSubData( BufferTargetARB target, int offset, int size, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferSubData( BufferTargetARB target, int offset, int size, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void MapBuffer( BufferTargetARB target, BufferAccessARB access );
		[DllImport( "opengl32.dll" )]
		public static extern bool UnmapBuffer( BufferTargetARB target );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferParameteriv( BufferTargetARB target, BufferPNameARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferPointerv( BufferTargetARB target, BufferPointerNameARB pname, void @params );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquationSeparate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffers( int n, DrawBufferModeATI bufs );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilOpSeparate( StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilFuncSeparate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilMaskSeparate( StencilFaceDirection face, uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void AttachShader( uint program, uint shader );
		[DllImport( "opengl32.dll" )]
		public static extern void BindAttribLocation( uint program, uint index, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void CompileShader( uint shader );
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateProgram(  );
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateShader( GLenum type );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteProgram( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteShader( uint shader );
		[DllImport( "opengl32.dll" )]
		public static extern void DetachShader( uint program, uint shader );
		[DllImport( "opengl32.dll" )]
		public static extern void DisableVertexAttribArray( uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void EnableVertexAttribArray( uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveAttrib( uint program, uint index, int bufSize, int length, int size, GLenum type, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveUniform( uint program, uint index, int bufSize, int length, int size, GLenum type, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetAttachedShaders( uint program, int maxCount, int count, uint obj );
		[DllImport( "opengl32.dll" )]
		public static extern int GetAttribLocation( uint program, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramiv( uint program, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramInfoLog( uint program, int bufSize, int length, char infoLog );
		[DllImport( "opengl32.dll" )]
		public static extern void GetShaderiv( uint shader, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetShaderInfoLog( uint shader, int bufSize, int length, char infoLog );
		[DllImport( "opengl32.dll" )]
		public static extern void GetShaderSource( uint shader, int bufSize, int length, char source );
		[DllImport( "opengl32.dll" )]
		public static extern int GetUniformLocation( uint program, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformfv( uint program, int location, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformiv( uint program, int location, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribdv( uint index, VertexAttribPropertyARB pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribfv( uint index, VertexAttribPropertyARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribiv( uint index, VertexAttribPropertyARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribPointerv( uint index, VertexAttribPointerPropertyARB pname, void* pointer );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsProgram( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsShader( uint shader );
		[DllImport( "opengl32.dll" )]
		public static extern void LinkProgram( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderSource( uint shader, int count, char @string, int length );
		[DllImport( "opengl32.dll" )]
		public static extern void UseProgram( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1f( int location, float v0 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2f( int location, float v0, float v1 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3f( int location, float v0, float v1, float v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4f( int location, float v0, float v1, float v2, float v3 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1i( int location, int v0 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2i( int location, int v0, int v1 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3i( int location, int v0, int v1, int v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4i( int location, int v0, int v1, int v2, int v3 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1fv( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2fv( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3fv( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4fv( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1iv( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2iv( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3iv( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4iv( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix2fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix3fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix4fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void ValidateProgram( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1d( uint index, double x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dv( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1f( uint index, float x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fv( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1s( uint index, short x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1sv( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2d( uint index, double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dv( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2f( uint index, float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fv( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2s( uint index, short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2sv( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3d( uint index, double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dv( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3f( uint index, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fv( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3s( uint index, short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3sv( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nbv( uint index, sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Niv( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nsv( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nub( uint index, byte x, byte y, byte z, byte w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nubv( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nuiv( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4Nusv( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4bv( uint index, sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4d( uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dv( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4f( uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fv( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4iv( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4s( uint index, short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4sv( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubv( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4uiv( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4usv( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribPointer( uint index, int size, VertexAttribPointerTypeARB type, bool normalized, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix2x3fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix3x2fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix2x4fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix4x2fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix3x4fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix4x3fv( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveTextureARB( TextureUnit texture );
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveTextureARB( TextureUnit texture );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dARB( TextureUnit target, double s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dvARB( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fARB( TextureUnit target, float s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fvARB( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1iARB( TextureUnit target, int s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1ivARB( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1sARB( TextureUnit target, short s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1svARB( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dARB( TextureUnit target, double s, double t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dvARB( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fARB( TextureUnit target, float s, float t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fvARB( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2iARB( TextureUnit target, int s, int t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2ivARB( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2sARB( TextureUnit target, short s, short t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2svARB( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dARB( TextureUnit target, double s, double t, double r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dvARB( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fARB( TextureUnit target, float s, float t, float r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fvARB( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3iARB( TextureUnit target, int s, int t, int r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3ivARB( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3sARB( TextureUnit target, short s, short t, short r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3svARB( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dARB( TextureUnit target, double s, double t, double r, double q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dvARB( TextureUnit target, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fARB( TextureUnit target, float s, float t, float r, float q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fvARB( TextureUnit target, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4iARB( TextureUnit target, int s, int t, int r, int q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4ivARB( TextureUnit target, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4sARB( TextureUnit target, short s, short t, short r, short q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4svARB( TextureUnit target, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixfARB( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixdARB( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixfARB( float m );
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixdARB( double m );
		[DllImport( "opengl32.dll" )]
		public static extern void SampleCoverageARB( float value, bool invert );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage3DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage2DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexImage1DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage3DARB( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage2DARB( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CompressedTexSubImage1DARB( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCompressedTexImageARB( TextureTarget target, int level, void img );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfARB( PointParameterNameARB pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvARB( PointParameterNameARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightbvARB( int size, sbyte weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightsvARB( int size, short weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightivARB( int size, int weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightfvARB( int size, float weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightdvARB( int size, double weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightubvARB( int size, byte weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightusvARB( int size, ushort weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightuivARB( int size, uint weights );
		[DllImport( "opengl32.dll" )]
		public static extern void WeightPointerARB( int size, WeightPointerTypeARB type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendARB( int count );
		[DllImport( "opengl32.dll" )]
		public static extern void CurrentPaletteMatrixARB( int index );
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexubvARB( int size, byte indices );
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexusvARB( int size, ushort indices );
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexuivARB( int size, uint indices );
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexPointerARB( int size, MatrixIndexPointerTypeARB type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dARB( double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dvARB( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fARB( float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fvARB( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iARB( int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2ivARB( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sARB( short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2svARB( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dARB( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dvARB( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fARB( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fvARB( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iARB( int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3ivARB( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sARB( short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3svARB( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dARB( uint index, double x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dvARB( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fARB( uint index, float x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fvARB( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1sARB( uint index, short x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1svARB( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dARB( uint index, double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dvARB( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fARB( uint index, float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fvARB( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2sARB( uint index, short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2svARB( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dARB( uint index, double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dvARB( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fARB( uint index, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fvARB( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3sARB( uint index, short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3svARB( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NbvARB( uint index, sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NivARB( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NsvARB( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NubARB( uint index, byte x, byte y, byte z, byte w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NubvARB( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NuivARB( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NusvARB( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4bvARB( uint index, sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dARB( uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dvARB( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fARB( uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fvARB( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ivARB( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4sARB( uint index, short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4svARB( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubvARB( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4uivARB( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4usvARB( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribPointerARB( uint index, int size, VertexAttribPointerTypeARB type, bool normalized, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void EnableVertexAttribArrayARB( uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void DisableVertexAttribArrayARB( uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramStringARB( ProgramTargetARB target, ProgramFormatARB format, int len, void string );
		[DllImport( "opengl32.dll" )]
		public static extern void BindProgramARB( ProgramTargetARB target, uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteProgramsARB( int n, uint programs );
		[DllImport( "opengl32.dll" )]
		public static extern void GenProgramsARB( int n, uint programs );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4dARB( ProgramTargetARB target, uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4dvARB( ProgramTargetARB target, uint index, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4fARB( ProgramTargetARB target, uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4fvARB( ProgramTargetARB target, uint index, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4dARB( ProgramTargetARB target, uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4dvARB( ProgramTargetARB target, uint index, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4fARB( ProgramTargetARB target, uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4fvARB( ProgramTargetARB target, uint index, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterdvARB( ProgramTargetARB target, uint index, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterfvARB( ProgramTargetARB target, uint index, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterdvARB( ProgramTargetARB target, uint index, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterfvARB( ProgramTargetARB target, uint index, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramivARB( ProgramTargetARB target, ProgramPropertyARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramStringARB( ProgramTargetARB target, ProgramStringPropertyARB pname, void string );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribdvARB( uint index, VertexAttribPropertyARB pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribfvARB( uint index, VertexAttribPropertyARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribivARB( uint index, VertexAttribPropertyARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribPointervARB( uint index, VertexAttribPointerPropertyARB pname, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsProgramARB( uint program );
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferARB( BufferTargetARB target, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteBuffersARB( int n, uint buffers );
		[DllImport( "opengl32.dll" )]
		public static extern void GenBuffersARB( int n, uint buffers );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsBufferARB( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void BufferDataARB( BufferTargetARB target, int size, void data, BufferUsageARB usage );
		[DllImport( "opengl32.dll" )]
		public static extern void BufferSubDataARB( BufferTargetARB target, int offset, int size, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferSubDataARB( BufferTargetARB target, int offset, int size, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void MapBufferARB( BufferTargetARB target, BufferAccessARB access );
		[DllImport( "opengl32.dll" )]
		public static extern bool UnmapBufferARB( BufferTargetARB target );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferParameterivARB( BufferTargetARB target, BufferPNameARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferPointervARB( BufferTargetARB target, BufferPointerNameARB pname, void @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GenQueriesARB( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteQueriesARB( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsQueryARB( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginQueryARB( GLenum target, uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void EndQueryARB( GLenum target );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryivARB( GLenum target, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectivARB( uint id, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectuivARB( uint id, GLenum pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteObjectARB( uint obj );
		[DllImport( "opengl32.dll" )]
		public static extern uint GetHandleARB( GLenum pname );
		[DllImport( "opengl32.dll" )]
		public static extern void DetachObjectARB( uint containerObj, uint attachedObj );
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateShaderObjectARB( GLenum shaderType );
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderSourceARB( uint shaderObj, int count, char string, int length );
		[DllImport( "opengl32.dll" )]
		public static extern void CompileShaderARB( uint shaderObj );
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateProgramObjectARB(  );
		[DllImport( "opengl32.dll" )]
		public static extern void AttachObjectARB( uint containerObj, uint obj );
		[DllImport( "opengl32.dll" )]
		public static extern void LinkProgramARB( uint programObj );
		[DllImport( "opengl32.dll" )]
		public static extern void UseProgramObjectARB( uint programObj );
		[DllImport( "opengl32.dll" )]
		public static extern void ValidateProgramARB( uint programObj );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1fARB( int location, float v0 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2fARB( int location, float v0, float v1 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3fARB( int location, float v0, float v1, float v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4fARB( int location, float v0, float v1, float v2, float v3 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1iARB( int location, int v0 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2iARB( int location, int v0, int v1 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3iARB( int location, int v0, int v1, int v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4iARB( int location, int v0, int v1, int v2, int v3 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1fvARB( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2fvARB( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3fvARB( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4fvARB( int location, int count, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1ivARB( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2ivARB( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3ivARB( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4ivARB( int location, int count, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix2fvARB( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix3fvARB( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix4fvARB( int location, int count, bool transpose, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectParameterfvARB( uint obj, GLenum pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectParameterivARB( uint obj, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetInfoLogARB( uint obj, int maxLength, int length, char infoLog );
		[DllImport( "opengl32.dll" )]
		public static extern void GetAttachedObjectsARB( uint containerObj, int maxCount, int count, uint obj );
		[DllImport( "opengl32.dll" )]
		public static extern int GetUniformLocationARB( uint programObj, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveUniformARB( uint programObj, uint index, int maxLength, int length, int size, GLenum type, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformfvARB( uint programObj, int location, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformivARB( uint programObj, int location, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetShaderSourceARB( uint obj, int maxLength, int length, char source );
		[DllImport( "opengl32.dll" )]
		public static extern void BindAttribLocationARB( uint programObj, uint index, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveAttribARB( uint programObj, uint index, int maxLength, int length, int size, GLenum type, char name );
		[DllImport( "opengl32.dll" )]
		public static extern int GetAttribLocationARB( uint programObj, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffersARB( int n, DrawBufferModeATI bufs );
		[DllImport( "opengl32.dll" )]
		public static extern void ClampColorARB( ClampColorTargetARB target, ClampColorModeARB clamp );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendColorEXT( float red, float green, float blue, float alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonOffsetEXT( float factor, float bias );
		[DllImport( "opengl32.dll" )]
		public static extern void TexImage3DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexFilterFuncSGIS( TextureTarget target, TextureFilterSGIS filter, float weights );
		[DllImport( "opengl32.dll" )]
		public static extern void TexFilterFuncSGIS( TextureTarget target, TextureFilterSGIS filter, int n, float weights );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage1DEXT( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage1DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage2DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage1DEXT( TextureTarget target, int level, int xoffset, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramEXT( HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterfvEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterivEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxEXT( MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void values );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterfvEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterivEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void HistogramEXT( HistogramTargetEXT target, int width, PixelInternalFormat internalformat, bool sink );
		[DllImport( "opengl32.dll" )]
		public static extern void MinmaxEXT( MinmaxTargetEXT target, PixelInternalFormat internalformat, bool sink );
		[DllImport( "opengl32.dll" )]
		public static extern void ResetHistogramEXT( HistogramTargetEXT target );
		[DllImport( "opengl32.dll" )]
		public static extern void ResetMinmaxEXT( MinmaxTargetEXT target );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteriEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionFilterEXT( ConvolutionTargetEXT target, PixelFormat format, PixelType type, void image );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetSeparableFilterEXT( SeparableTargetEXT target, PixelFormat format, PixelType type, void row, void column, void span );
		[DllImport( "opengl32.dll" )]
		public static extern void SeparableFilter2DEXT( SeparableTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void row, void column );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void table );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterfvSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterivSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableSGI( ColorTableTargetSGI target, PixelFormat format, PixelType type, void table );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfvSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterivSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenSGIX( PixelTexGenModeSGIX mode );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameteriSGIS( PixelTexGenParameterNameSGIS pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterfSGIS( PixelTexGenParameterNameSGIS pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexImage4DSGIS( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern void TexSubImage4DSGIS( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void pixels );
		[DllImport( "opengl32.dll" )]
		public static extern bool AreTexturesResidentEXT( int n, uint textures, bool residences );
		[DllImport( "opengl32.dll" )]
		public static extern void BindTextureEXT( TextureTarget target, uint texture );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteTexturesEXT( int n, uint textures );
		[DllImport( "opengl32.dll" )]
		public static extern void GenTexturesEXT( int n, uint textures );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsTextureEXT( uint texture );
		[DllImport( "opengl32.dll" )]
		public static extern void PrioritizeTexturesEXT( int n, uint textures, float priorities );
		[DllImport( "opengl32.dll" )]
		public static extern void DetailTexFuncSGIS( TextureTarget target, int n, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void GetDetailTexFuncSGIS( TextureTarget target, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void SharpenTexFuncSGIS( TextureTarget target, int n, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void GetSharpenTexFuncSGIS( TextureTarget target, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMaskSGIS( float value, bool invert );
		[DllImport( "opengl32.dll" )]
		public static extern void SamplePatternSGIS( SamplePatternSGIS pattern );
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayElementEXT( int i );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorPointerEXT( int size, ColorPointerType type, int stride, int count, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawArraysEXT( BeginMode mode, int first, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagPointerEXT( int stride, int count, bool pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void GetPointervEXT( GetPointervPName pname, void @params );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexPointerEXT( IndexPointerType type, int stride, int count, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalPointerEXT( NormalPointerType type, int stride, int count, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoordPointerEXT( int size, TexCoordPointerType type, int stride, int count, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexPointerEXT( int size, VertexPointerType type, int stride, int count, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquationEXT( BlendEquationModeEXT mode );
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterfSGIX( SpriteParameterNameSGIX pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterfvSGIX( SpriteParameterNameSGIX pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameteriSGIX( SpriteParameterNameSGIX pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterivSGIX( SpriteParameterNameSGIX pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfEXT( PointParameterNameARB pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvEXT( PointParameterNameARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfSGIS( PointParameterNameARB pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvSGIS( PointParameterNameARB pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern int GetInstrumentsSGIX(  );
		[DllImport( "opengl32.dll" )]
		public static extern void InstrumentsBufferSGIX( int size, int buffer );
		[DllImport( "opengl32.dll" )]
		public static extern int PollInstrumentsSGIX( int marker_p );
		[DllImport( "opengl32.dll" )]
		public static extern void ReadInstrumentsSGIX( int marker );
		[DllImport( "opengl32.dll" )]
		public static extern void StartInstrumentsSGIX(  );
		[DllImport( "opengl32.dll" )]
		public static extern void StopInstrumentsSGIX( int marker );
		[DllImport( "opengl32.dll" )]
		public static extern void FrameZoomSGIX( int factor );
		[DllImport( "opengl32.dll" )]
		public static extern void TagSampleBufferSGIX(  );
		[DllImport( "opengl32.dll" )]
		public static extern void DeformationMap3dSGIX( FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double points );
		[DllImport( "opengl32.dll" )]
		public static extern void DeformationMap3fSGIX( FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void DeformSGIX( FfdMaskSGIX mask );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadIdentityDeformationMapSGIX( FfdMaskSGIX mask );
		[DllImport( "opengl32.dll" )]
		public static extern void ReferencePlaneSGIX( double equation );
		[DllImport( "opengl32.dll" )]
		public static extern void FlushRasterSGIX(  );
		[DllImport( "opengl32.dll" )]
		public static extern void FogFuncSGIS( int n, float points );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFogFuncSGIS( float points );
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameteriHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterfHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterivHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterfvHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetImageTransformParameterivHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetImageTransformParameterfvHP( ImageTransformTargetHP target, ImageTransformPNameHP pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorSubTableEXT( ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorSubTableEXT( ColorTableTarget target, int start, int x, int y, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void HintPGI( HintTargetPGI target, int mode );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableEXT( ColorTableTarget target, PixelInternalFormat internalFormat, int width, PixelFormat format, PixelType type, void table );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableEXT( ColorTableTarget target, PixelFormat format, PixelType type, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterivEXT( ColorTableTarget target, GetColorTableParameterPName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfvEXT( ColorTableTarget target, GetColorTableParameterPName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetListParameterfvSGIX( uint list, ListParameterName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetListParameterivSGIX( uint list, ListParameterName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterfSGIX( uint list, ListParameterName pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterfvSGIX( uint list, ListParameterName pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameteriSGIX( uint list, ListParameterName pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterivSGIX( uint list, ListParameterName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexMaterialEXT( MaterialFace face, IndexMaterialParameterEXT mode );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexFuncEXT( IndexFunctionEXT func, float @ref );
		[DllImport( "opengl32.dll" )]
		public static extern void LockArraysEXT( int first, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void UnlockArraysEXT(  );
		[DllImport( "opengl32.dll" )]
		public static extern void CullParameterdvEXT( CullParameterEXT pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CullParameterfvEXT( CullParameterEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentColorMaterialSGIX( MaterialFace face, MaterialParameter mode );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightfSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightfvSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightiSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightivSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelfSGIX( FragmentLightModelParameterSGIX pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelfvSGIX( FragmentLightModelParameterSGIX pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModeliSGIX( FragmentLightModelParameterSGIX pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelivSGIX( FragmentLightModelParameterSGIX pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialfSGIX( MaterialFace face, MaterialParameter pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialiSGIX( MaterialFace face, MaterialParameter pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentLightfvSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentLightivSGIX( FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void LightEnviSGIX( LightEnvParameterSGIX pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElementsEXT( BeginMode mode, uint start, uint end, int count, DrawElementsType type, void indices );
		[DllImport( "opengl32.dll" )]
		public static extern void ApplyTextureEXT( LightTextureModeEXT mode );
		[DllImport( "opengl32.dll" )]
		public static extern void TextureLightEXT( LightTexturePNameEXT pname );
		[DllImport( "opengl32.dll" )]
		public static extern void TextureMaterialEXT( MaterialFace face, MaterialParameter mode );
		[DllImport( "opengl32.dll" )]
		public static extern void AsyncMarkerSGIX( uint marker );
		[DllImport( "opengl32.dll" )]
		public static extern int FinishAsyncSGIX( uint markerp );
		[DllImport( "opengl32.dll" )]
		public static extern int PollAsyncSGIX( uint markerp );
		[DllImport( "opengl32.dll" )]
		public static extern uint GenAsyncMarkersSGIX( int range );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteAsyncMarkersSGIX( uint marker, int range );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsAsyncMarkerSGIX( uint marker );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexPointervINTEL( int size, VertexPointerType type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalPointervINTEL( NormalPointerType type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorPointervINTEL( int size, VertexPointerType type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoordPointervINTEL( int size, VertexPointerType type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameteriEXT( PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterfEXT( PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterivEXT( PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterfvEXT( PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bEXT( sbyte red, sbyte green, sbyte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bvEXT( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dEXT( double red, double green, double blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dvEXT( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fEXT( float red, float green, float blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fvEXT( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3iEXT( int red, int green, int blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ivEXT( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3sEXT( short red, short green, short blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3svEXT( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubEXT( byte red, byte green, byte blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubvEXT( byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uiEXT( uint red, uint green, uint blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uivEXT( uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usEXT( ushort red, ushort green, ushort blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usvEXT( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColorPointerEXT( int size, ColorPointerType type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void TextureNormalEXT( TextureNormalModeEXT mode );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawArraysEXT( BeginMode mode, int first, int count, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawElementsEXT( BeginMode mode, int count, DrawElementsType type, void indices, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfEXT( float coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfvEXT( float coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddEXT( double coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddvEXT( double coord );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordPointerEXT( FogPointerTypeEXT type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3bEXT( sbyte tx, sbyte ty, sbyte tz );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3bvEXT( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3dEXT( double tx, double ty, double tz );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3dvEXT( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3fEXT( float tx, float ty, float tz );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3fvEXT( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3iEXT( int tx, int ty, int tz );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3ivEXT( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3sEXT( short tx, short ty, short tz );
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3svEXT( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3bEXT( sbyte bx, sbyte by, sbyte bz );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3bvEXT( sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3dEXT( double bx, double by, double bz );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3dvEXT( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3fEXT( float bx, float by, float bz );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3fvEXT( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3iEXT( int bx, int by, int bz );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3ivEXT( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3sEXT( short bx, short by, short bz );
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3svEXT( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void TangentPointerEXT( TangentPointerTypeEXT type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void BinormalPointerEXT( BinormalPointerTypeEXT type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void FinishTextureSUNX(  );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorbSUN( sbyte factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorsSUN( short factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactoriSUN( int factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorfSUN( float factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactordSUN( double factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorubSUN( byte factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorusSUN( ushort factor );
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactoruiSUN( uint factor );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiSUN( uint code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeusSUN( ushort code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeubSUN( byte code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuivSUN( uint code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeusvSUN( ushort code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeubvSUN( byte code );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodePointerSUN( ReplacementCodeTypeSUN type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex2fSUN( byte r, byte g, byte b, byte a, float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex2fvSUN( byte c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex3fSUN( byte r, byte g, byte b, byte a, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex3fvSUN( byte c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fVertex3fSUN( float r, float g, float b, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fVertex3fvSUN( float c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fVertex3fSUN( float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fVertex3fvSUN( float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fNormal3fVertex3fSUN( float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fNormal3fVertex3fvSUN( float c, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fVertex3fSUN( float s, float t, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fVertex3fvSUN( float tc, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fVertex4fSUN( float s, float t, float p, float q, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fVertex4fvSUN( float tc, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4ubVertex3fSUN( float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4ubVertex3fvSUN( float tc, byte c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor3fVertex3fSUN( float s, float t, float r, float g, float b, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor3fVertex3fvSUN( float tc, float c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fNormal3fVertex3fSUN( float s, float t, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fNormal3fVertex3fvSUN( float tc, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fSUN( float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fvSUN( float tc, float c, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fSUN( float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fvSUN( float tc, float c, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiVertex3fSUN( uint rc, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiVertex3fvSUN( uint rc, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fSUN( uint rc, byte r, byte g, byte b, byte a, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fvSUN( uint rc, byte c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor3fVertex3fSUN( uint rc, float r, float g, float b, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor3fVertex3fvSUN( uint rc, float c, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fSUN( uint rc, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fvSUN( uint rc, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fSUN( uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fvSUN( uint rc, float c, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fSUN( uint rc, float s, float t, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fvSUN( uint rc, float tc, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN( uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN( uint rc, float tc, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN( uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN( uint rc, float tc, float c, float n, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparateEXT( BlendFuncSeparateParameterEXT sfactorRGB, BlendFuncSeparateParameterEXT dfactorRGB, BlendFuncSeparateParameterEXT sfactorAlpha, BlendFuncSeparateParameterEXT dfactorAlpha );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparateINGR( BlendFuncSeparateParameterEXT sfactorRGB, BlendFuncSeparateParameterEXT dfactorRGB, BlendFuncSeparateParameterEXT sfactorAlpha, BlendFuncSeparateParameterEXT dfactorAlpha );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeightfEXT( float weight );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeightfvEXT( float weight );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeightPointerEXT( int size, VertexWeightPointerTypeEXT type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void FlushVertexArrayRangeNV(  );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexArrayRangeNV( int length, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterfvNV( CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterfNV( CombinerParameterNV pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterivNV( CombinerParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameteriNV( CombinerParameterNV pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerInputNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerOutputNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerRegisterNV abOutput, CombinerRegisterNV cdOutput, CombinerRegisterNV sumOutput, CombinerScaleNV scale, CombinerBiasNV bias, bool abDotProduct, bool cdDotProduct, bool muxSum );
		[DllImport( "opengl32.dll" )]
		public static extern void FinalCombinerInputNV( CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerInputParameterfvNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerInputParameterivNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerOutputParameterfvNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerOutputParameterivNV( CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFinalCombinerInputParameterfvNV( CombinerVariableNV variable, CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFinalCombinerInputParameterivNV( CombinerVariableNV variable, CombinerParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ResizeBuffersMESA(  );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dMESA( double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dvMESA( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fMESA( float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fvMESA( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iMESA( int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2ivMESA( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sMESA( short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2svMESA( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dMESA( double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dvMESA( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fMESA( float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fvMESA( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iMESA( int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3ivMESA( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sMESA( short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3svMESA( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4dMESA( double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4dvMESA( double v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4fMESA( float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4fvMESA( float v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4iMESA( int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4ivMESA( int v );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4sMESA( short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4svMESA( short v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiModeDrawArraysIBM( BeginMode mode, int first, int count, int primcount, int modestride );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiModeDrawElementsIBM( BeginMode mode, int count, DrawElementsType type, void indices, int primcount, int modestride );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorPointerListIBM( int size, ColorPointerType type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColorPointerListIBM( int size, SecondaryColorPointerTypeIBM type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagPointerListIBM( int stride, bool pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordPointerListIBM( FogPointerTypeIBM type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void IndexPointerListIBM( IndexPointerType type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalPointerListIBM( NormalPointerType type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoordPointerListIBM( int size, TexCoordPointerType type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexPointerListIBM( int size, VertexPointerType type, int stride, void pointer, int ptrstride );
		[DllImport( "opengl32.dll" )]
		public static extern void TbufferMask3DFX( uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMaskEXT( float value, bool invert );
		[DllImport( "opengl32.dll" )]
		public static extern void SamplePatternEXT( SamplePatternEXT pattern );
		[DllImport( "opengl32.dll" )]
		public static extern void TextureColorMaskSGIS( bool red, bool green, bool blue, bool alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void IglooInterfaceSGIX( IglooFunctionSelectSGIX pname, void @params );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFencesNV( int n, uint fences );
		[DllImport( "opengl32.dll" )]
		public static extern void GenFencesNV( int n, uint fences );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFenceNV( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern bool TestFenceNV( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFenceivNV( uint fence, FenceParameterNameNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FinishFenceNV( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern void SetFenceNV( uint fence, FenceConditionNV condition );
		[DllImport( "opengl32.dll" )]
		public static extern void MapControlPointsNV( EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, int uorder, int vorder, bool packed, void points );
		[DllImport( "opengl32.dll" )]
		public static extern void MapParameterivNV( EvalTargetNV target, MapParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void MapParameterfvNV( EvalTargetNV target, MapParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapControlPointsNV( EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, bool packed, void points );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapParameterivNV( EvalTargetNV target, MapParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapParameterfvNV( EvalTargetNV target, MapParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapAttribParameterivNV( EvalTargetNV target, uint index, MapAttribParameterNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapAttribParameterfvNV( EvalTargetNV target, uint index, MapAttribParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMapsNV( EvalTargetNV target, EvalMapsModeNV mode );
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerStageParameterfvNV( CombinerStageNV stage, CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerStageParameterfvNV( CombinerStageNV stage, CombinerParameterNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern bool AreProgramsResidentNV( int n, uint programs, bool residences );
		[DllImport( "opengl32.dll" )]
		public static extern void BindProgramNV( VertexAttribEnumNV target, uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteProgramsNV( int n, uint programs );
		[DllImport( "opengl32.dll" )]
		public static extern void ExecuteProgramNV( VertexAttribEnumNV target, uint id, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GenProgramsNV( int n, uint programs );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramParameterdvNV( VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramParameterfvNV( VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramivNV( uint id, VertexAttribEnumNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramStringNV( uint id, VertexAttribEnumNV pname, byte program );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTrackMatrixivNV( VertexAttribEnumNV target, uint address, VertexAttribEnumNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribdvNV( uint index, VertexAttribEnumNV pname, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribfvNV( uint index, VertexAttribEnumNV pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribivNV( uint index, VertexAttribEnumNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribPointervNV( uint index, VertexAttribEnumNV pname, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsProgramNV( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void LoadProgramNV( VertexAttribEnumNV target, uint id, int len, byte program );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4dNV( VertexAttribEnumNV target, uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4dvNV( VertexAttribEnumNV target, uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4fNV( VertexAttribEnumNV target, uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4fvNV( VertexAttribEnumNV target, uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameters4dvNV( VertexAttribEnumNV target, uint index, uint count, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameters4fvNV( VertexAttribEnumNV target, uint index, uint count, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void RequestResidentProgramsNV( int n, uint programs );
		[DllImport( "opengl32.dll" )]
		public static extern void TrackMatrixNV( VertexAttribEnumNV target, uint address, VertexAttribEnumNV matrix, VertexAttribEnumNV transform );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribPointerNV( uint index, int fsize, VertexAttribEnumNV type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dNV( uint index, double x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dvNV( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fNV( uint index, float x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fvNV( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1sNV( uint index, short x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1svNV( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dNV( uint index, double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dvNV( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fNV( uint index, float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fvNV( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2sNV( uint index, short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2svNV( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dNV( uint index, double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dvNV( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fNV( uint index, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fvNV( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3sNV( uint index, short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3svNV( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dNV( uint index, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dvNV( uint index, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fNV( uint index, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fvNV( uint index, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4sNV( uint index, short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4svNV( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubNV( uint index, byte x, byte y, byte z, byte w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubvNV( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1dvNV( uint index, int count, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1fvNV( uint index, int count, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1svNV( uint index, int count, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2dvNV( uint index, int count, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2fvNV( uint index, int count, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2svNV( uint index, int count, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3dvNV( uint index, int count, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3fvNV( uint index, int count, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3svNV( uint index, int count, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4dvNV( uint index, int count, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4fvNV( uint index, int count, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4svNV( uint index, int count, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4ubvNV( uint index, int count, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexBumpParameterivATI( TexBumpParameterATI pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void TexBumpParameterfvATI( TexBumpParameterATI pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexBumpParameterivATI( GetTexBumpParameterATI pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexBumpParameterfvATI( GetTexBumpParameterATI pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern uint GenFragmentShadersATI( uint range );
		[DllImport( "opengl32.dll" )]
		public static extern void BindFragmentShaderATI( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFragmentShaderATI( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginFragmentShaderATI(  );
		[DllImport( "opengl32.dll" )]
		public static extern void EndFragmentShaderATI(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PassTexCoordATI( uint dst, uint coord, SwizzleOpATI swizzle );
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMapATI( uint dst, uint interp, SwizzleOpATI swizzle );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp1ATI( FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp2ATI( FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp3ATI( FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp1ATI( FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp2ATI( FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp3ATI( FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod );
		[DllImport( "opengl32.dll" )]
		public static extern void SetFragmentShaderConstantATI( uint dst, float value );
		[DllImport( "opengl32.dll" )]
		public static extern void PNTrianglesiATI( PNTrianglesPNameATI pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PNTrianglesfATI( PNTrianglesPNameATI pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern uint NewObjectBufferATI( int size, void pointer, ArrayObjectUsageATI usage );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsObjectBufferATI( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void UpdateObjectBufferATI( uint buffer, uint offset, int size, void pointer, PreserveModeATI preserve );
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectBufferfvATI( uint buffer, ArrayObjectPNameATI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectBufferivATI( uint buffer, ArrayObjectPNameATI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void FreeObjectBufferATI( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayObjectATI( EnableCap array, int size, ScalarType type, int stride, uint buffer, uint offset );
		[DllImport( "opengl32.dll" )]
		public static extern void GetArrayObjectfvATI( EnableCap array, ArrayObjectPNameATI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetArrayObjectivATI( EnableCap array, ArrayObjectPNameATI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantArrayObjectATI( uint id, ScalarType type, int stride, uint buffer, uint offset );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantArrayObjectfvATI( uint id, ArrayObjectPNameATI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantArrayObjectivATI( uint id, ArrayObjectPNameATI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginVertexShaderEXT(  );
		[DllImport( "opengl32.dll" )]
		public static extern void EndVertexShaderEXT(  );
		[DllImport( "opengl32.dll" )]
		public static extern void BindVertexShaderEXT( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern uint GenVertexShadersEXT( uint range );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteVertexShaderEXT( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp1EXT( VertexShaderOpEXT op, uint res, uint arg1 );
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp2EXT( VertexShaderOpEXT op, uint res, uint arg1, uint arg2 );
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp3EXT( VertexShaderOpEXT op, uint res, uint arg1, uint arg2, uint arg3 );
		[DllImport( "opengl32.dll" )]
		public static extern void SwizzleEXT( uint res, uint in, VertexShaderCoordOutEXT outX, VertexShaderCoordOutEXT outY, VertexShaderCoordOutEXT outZ, VertexShaderCoordOutEXT outW );
		[DllImport( "opengl32.dll" )]
		public static extern void WriteMaskEXT( uint res, uint in, VertexShaderWriteMaskEXT outX, VertexShaderWriteMaskEXT outY, VertexShaderWriteMaskEXT outZ, VertexShaderWriteMaskEXT outW );
		[DllImport( "opengl32.dll" )]
		public static extern void InsertComponentEXT( uint res, uint src, uint num );
		[DllImport( "opengl32.dll" )]
		public static extern void ExtractComponentEXT( uint res, uint src, uint num );
		[DllImport( "opengl32.dll" )]
		public static extern uint GenSymbolsEXT( DataTypeEXT datatype, VertexShaderStorageTypeEXT storagetype, ParameterRangeEXT range, uint components );
		[DllImport( "opengl32.dll" )]
		public static extern void SetInvariantEXT( uint id, ScalarType type, void addr );
		[DllImport( "opengl32.dll" )]
		public static extern void SetLocalConstantEXT( uint id, ScalarType type, void addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantbvEXT( uint id, sbyte addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantsvEXT( uint id, short addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantivEXT( uint id, int addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantfvEXT( uint id, float addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantdvEXT( uint id, double addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantubvEXT( uint id, byte addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantusvEXT( uint id, ushort addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantuivEXT( uint id, uint addr );
		[DllImport( "opengl32.dll" )]
		public static extern void VariantPointerEXT( uint id, ScalarType type, uint stride, void addr );
		[DllImport( "opengl32.dll" )]
		public static extern void EnableVariantClientStateEXT( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void DisableVariantClientStateEXT( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern uint BindLightParameterEXT( LightName light, LightParameter value );
		[DllImport( "opengl32.dll" )]
		public static extern uint BindMaterialParameterEXT( MaterialFace face, MaterialParameter value );
		[DllImport( "opengl32.dll" )]
		public static extern uint BindTexGenParameterEXT( TextureUnit unit, TextureCoordName coord, TextureGenParameter value );
		[DllImport( "opengl32.dll" )]
		public static extern uint BindTextureUnitParameterEXT( TextureUnit unit, VertexShaderTextureUnitParameter value );
		[DllImport( "opengl32.dll" )]
		public static extern uint BindParameterEXT( VertexShaderParameterEXT value );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsVariantEnabledEXT( uint id, VariantCapEXT cap );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantBooleanvEXT( uint id, GetVariantValueEXT value, bool data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantIntegervEXT( uint id, GetVariantValueEXT value, int data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantFloatvEXT( uint id, GetVariantValueEXT value, float data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantPointervEXT( uint id, GetVariantValueEXT value, void data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantBooleanvEXT( uint id, GetVariantValueEXT value, bool data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantIntegervEXT( uint id, GetVariantValueEXT value, int data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantFloatvEXT( uint id, GetVariantValueEXT value, float data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantBooleanvEXT( uint id, GetVariantValueEXT value, bool data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantIntegervEXT( uint id, GetVariantValueEXT value, int data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantFloatvEXT( uint id, GetVariantValueEXT value, float data );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1sATI( VertexStreamATI stream, short x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1svATI( VertexStreamATI stream, short coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1iATI( VertexStreamATI stream, int x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1ivATI( VertexStreamATI stream, int coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1fATI( VertexStreamATI stream, float x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1fvATI( VertexStreamATI stream, float coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1dATI( VertexStreamATI stream, double x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1dvATI( VertexStreamATI stream, double coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2sATI( VertexStreamATI stream, short x, short y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2svATI( VertexStreamATI stream, short coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2iATI( VertexStreamATI stream, int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2ivATI( VertexStreamATI stream, int coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2fATI( VertexStreamATI stream, float x, float y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2fvATI( VertexStreamATI stream, float coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2dATI( VertexStreamATI stream, double x, double y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2dvATI( VertexStreamATI stream, double coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3sATI( VertexStreamATI stream, short x, short y, short z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3svATI( VertexStreamATI stream, short coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3iATI( VertexStreamATI stream, int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3ivATI( VertexStreamATI stream, int coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3fATI( VertexStreamATI stream, float x, float y, float z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3fvATI( VertexStreamATI stream, float coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3dATI( VertexStreamATI stream, double x, double y, double z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3dvATI( VertexStreamATI stream, double coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4sATI( VertexStreamATI stream, short x, short y, short z, short w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4svATI( VertexStreamATI stream, short coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4iATI( VertexStreamATI stream, int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4ivATI( VertexStreamATI stream, int coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4fATI( VertexStreamATI stream, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4fvATI( VertexStreamATI stream, float coords );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4dATI( VertexStreamATI stream, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4dvATI( VertexStreamATI stream, double coords );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3bATI( VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3bvATI( VertexStreamATI stream, sbyte coords );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3sATI( VertexStreamATI stream, short nx, short ny, short nz );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3svATI( VertexStreamATI stream, short coords );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3iATI( VertexStreamATI stream, int nx, int ny, int nz );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3ivATI( VertexStreamATI stream, int coords );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3fATI( VertexStreamATI stream, float nx, float ny, float nz );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3fvATI( VertexStreamATI stream, float coords );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3dATI( VertexStreamATI stream, double nx, double ny, double nz );
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3dvATI( VertexStreamATI stream, double coords );
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveVertexStreamATI( VertexStreamATI stream );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendEnviATI( VertexStreamATI pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendEnvfATI( VertexStreamATI pname, float param );
		[DllImport( "opengl32.dll" )]
		public static extern void ElementPointerATI( ElementPointerTypeATI type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElementArrayATI( BeginMode mode, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElementArrayATI( BeginMode mode, uint start, uint end, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawMeshArraysSUN( BeginMode mode, int first, int count, int width );
		[DllImport( "opengl32.dll" )]
		public static extern void GenOcclusionQueriesNV( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteOcclusionQueriesNV( int n, uint ids );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsOcclusionQueryNV( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginOcclusionQueryNV( uint id );
		[DllImport( "opengl32.dll" )]
		public static extern void EndOcclusionQueryNV(  );
		[DllImport( "opengl32.dll" )]
		public static extern void GetOcclusionQueryivNV( uint id, OcclusionQueryParameterNameNV pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetOcclusionQueryuivNV( uint id, OcclusionQueryParameterNameNV pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteriNV( PointParameterNameARB pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterivNV( PointParameterNameARB pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveStencilFaceEXT( StencilFaceDirection face );
		[DllImport( "opengl32.dll" )]
		public static extern void ElementPointerAPPLE( ElementPointerTypeATI type, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElementArrayAPPLE( BeginMode mode, int first, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int first, int count );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawElementArrayAPPLE( BeginMode mode, int first, int count, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int first, int count, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void GenFencesAPPLE( int n, uint fences );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFencesAPPLE( int n, uint fences );
		[DllImport( "opengl32.dll" )]
		public static extern void SetFenceAPPLE( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFenceAPPLE( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern bool TestFenceAPPLE( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern void FinishFenceAPPLE( uint fence );
		[DllImport( "opengl32.dll" )]
		public static extern bool TestObjectAPPLE( ObjectTypeAPPLE object, uint name );
		[DllImport( "opengl32.dll" )]
		public static extern void FinishObjectAPPLE( ObjectTypeAPPLE object, int name );
		[DllImport( "opengl32.dll" )]
		public static extern void BindVertexArrayAPPLE( uint array );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteVertexArraysAPPLE( int n, uint arrays );
		[DllImport( "opengl32.dll" )]
		public static extern void GenVertexArraysAPPLE( int n, uint arrays );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsVertexArrayAPPLE( uint array );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexArrayRangeAPPLE( int length, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void FlushVertexArrayRangeAPPLE( int length, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexArrayParameteriAPPLE( VertexArrayPNameAPPLE pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffersATI( int n, DrawBufferModeATI bufs );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4fNV( uint id, int len, byte name, float x, float y, float z, float w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4dNV( uint id, int len, byte name, double x, double y, double z, double w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4fvNV( uint id, int len, byte name, float v );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4dvNV( uint id, int len, byte name, double v );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramNamedParameterfvNV( uint id, int len, byte name, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramNamedParameterdvNV( uint id, int len, byte name, double @params );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2hNV( ushort x, ushort y );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3hNV( ushort x, ushort y, ushort z );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4hNV( ushort x, ushort y, ushort z, ushort w );
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3hNV( ushort nx, ushort ny, ushort nz );
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3hNV( ushort red, ushort green, ushort blue );
		[DllImport( "opengl32.dll" )]
		public static extern void Color3hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4hNV( ushort red, ushort green, ushort blue, ushort alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void Color4hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1hNV( ushort s );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2hNV( ushort s, ushort t );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3hNV( ushort s, ushort t, ushort r );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4hNV( ushort s, ushort t, ushort r, ushort q );
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1hNV( TextureUnit target, ushort s );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1hvNV( TextureUnit target, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2hNV( TextureUnit target, ushort s, ushort t );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2hvNV( TextureUnit target, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3hNV( TextureUnit target, ushort s, ushort t, ushort r );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3hvNV( TextureUnit target, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4hNV( TextureUnit target, ushort s, ushort t, ushort r, ushort q );
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4hvNV( TextureUnit target, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordhNV( ushort fog );
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordhvNV( ushort fog );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3hNV( ushort red, ushort green, ushort blue );
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3hvNV( ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeighthNV( ushort weight );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeighthvNV( ushort weight );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1hNV( uint index, ushort x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1hvNV( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2hNV( uint index, ushort x, ushort y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2hvNV( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3hNV( uint index, ushort x, ushort y, ushort z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3hvNV( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4hNV( uint index, ushort x, ushort y, ushort z, ushort w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4hvNV( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1hvNV( uint index, int n, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2hvNV( uint index, int n, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3hvNV( uint index, int n, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4hvNV( uint index, int n, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void PixelDataRangeNV( PixelDataRangeTargetNV target, int length, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void FlushPixelDataRangeNV( PixelDataRangeTargetNV target );
		[DllImport( "opengl32.dll" )]
		public static extern void PrimitiveRestartNV(  );
		[DllImport( "opengl32.dll" )]
		public static extern void PrimitiveRestartIndexNV( uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void MapObjectBufferATI( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void UnmapObjectBufferATI( uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilOpSeparateATI( StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilFuncSeparateATI( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribArrayObjectATI( uint index, int size, VertexAttribPointerTypeARB type, bool normalized, int stride, uint buffer, uint offset );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribArrayObjectfvATI( uint index, ArrayObjectPNameATI pname, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribArrayObjectivATI( uint index, ArrayObjectPNameATI pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthBoundsEXT( double zmin, double zmax );
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquationSeparateEXT( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsRenderbufferEXT( uint renderbuffer );
		[DllImport( "opengl32.dll" )]
		public static extern void BindRenderbufferEXT( RenderbufferTarget target, uint renderbuffer );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteRenderbuffersEXT( int n, uint renderbuffers );
		[DllImport( "opengl32.dll" )]
		public static extern void GenRenderbuffersEXT( int n, uint renderbuffers );
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageEXT( RenderbufferTarget target, GLenum internalformat, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void GetRenderbufferParameterivEXT( RenderbufferTarget target, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFramebufferEXT( uint framebuffer );
		[DllImport( "opengl32.dll" )]
		public static extern void BindFramebufferEXT( FramebufferTarget target, uint framebuffer );
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFramebuffersEXT( int n, uint framebuffers );
		[DllImport( "opengl32.dll" )]
		public static extern void GenFramebuffersEXT( int n, uint framebuffers );
		[DllImport( "opengl32.dll" )]
		public static extern GLenum CheckFramebufferStatusEXT( FramebufferTarget target );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture1DEXT( FramebufferTarget target, FramebufferAttachment attachment, GLenum textarget, uint texture, int level );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture2DEXT( FramebufferTarget target, FramebufferAttachment attachment, GLenum textarget, uint texture, int level );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture3DEXT( FramebufferTarget target, FramebufferAttachment attachment, GLenum textarget, uint texture, int level, int zoffset );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferRenderbufferEXT( FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer );
		[DllImport( "opengl32.dll" )]
		public static extern void GetFramebufferAttachmentParameterivEXT( FramebufferTarget target, FramebufferAttachment attachment, GLenum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GenerateMipmapEXT( GLenum target );
		[DllImport( "opengl32.dll" )]
		public static extern void StringMarkerGREMEDY( int len, void string );
		[DllImport( "opengl32.dll" )]
		public static extern void StencilClearTagEXT( int stencilTagBits, uint stencilClearTag );
		[DllImport( "opengl32.dll" )]
		public static extern void BlitFramebufferEXT( int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, GLenum filter );
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageMultisampleEXT( GLenum target, int samples, GLenum internalformat, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjecti64vEXT( uint id, GLenum pname, long @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectui64vEXT( uint id, GLenum pname, ulong @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameters4fvEXT( ProgramTargetARB target, uint index, int count, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameters4fvEXT( ProgramTargetARB target, uint index, int count, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void BufferParameteriAPPLE( GLenum target, GLenum pname, int param );
		[DllImport( "opengl32.dll" )]
		public static extern void FlushMappedBufferRangeAPPLE( GLenum target, int offset, int size );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4iNV( ProgramTarget target, uint index, int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4ivNV( ProgramTarget target, uint index, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParametersI4ivNV( ProgramTarget target, uint index, int count, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4uiNV( ProgramTarget target, uint index, uint x, uint y, uint z, uint w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4uivNV( ProgramTarget target, uint index, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParametersI4uivNV( ProgramTarget target, uint index, int count, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4iNV( ProgramTarget target, uint index, int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4ivNV( ProgramTarget target, uint index, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParametersI4ivNV( ProgramTarget target, uint index, int count, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4uiNV( ProgramTarget target, uint index, uint x, uint y, uint z, uint w );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4uivNV( ProgramTarget target, uint index, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParametersI4uivNV( ProgramTarget target, uint index, int count, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterIivNV( ProgramTarget target, uint index, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterIuivNV( ProgramTarget target, uint index, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterIivNV( ProgramTarget target, uint index, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterIuivNV( ProgramTarget target, uint index, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramVertexLimitNV( ProgramTarget target, int limit );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTextureEXT( FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTextureLayerEXT( FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer );
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTextureFaceEXT( FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameteriEXT( uint program, ProgramParameterPName pname, int value );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1iEXT( uint index, int x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2iEXT( uint index, int x, int y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3iEXT( uint index, int x, int y, int z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4iEXT( uint index, int x, int y, int z, int w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1uiEXT( uint index, uint x );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2uiEXT( uint index, uint x, uint y );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3uiEXT( uint index, uint x, uint y, uint z );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4uiEXT( uint index, uint x, uint y, uint z, uint w );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1ivEXT( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2ivEXT( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3ivEXT( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4ivEXT( uint index, int v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1uivEXT( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2uivEXT( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3uivEXT( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4uivEXT( uint index, uint v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4bvEXT( uint index, sbyte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4svEXT( uint index, short v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4ubvEXT( uint index, byte v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4usvEXT( uint index, ushort v );
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribIPointerEXT( uint index, int size, VertexAttribEnum type, int stride, void pointer );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribIivEXT( uint index, VertexAttribEnum pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribIuivEXT( uint index, VertexAttribEnum pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformuivEXT( uint program, int location, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void BindFragDataLocationEXT( uint program, uint color, char name );
		[DllImport( "opengl32.dll" )]
		public static extern int GetFragDataLocationEXT( uint program, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1uiEXT( int location, uint v0 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2uiEXT( int location, uint v0, uint v1 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3uiEXT( int location, uint v0, uint v1, uint v2 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4uiEXT( int location, uint v0, uint v1, uint v2, uint v3 );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1uivEXT( int location, int count, uint value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2uivEXT( int location, int count, uint value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3uivEXT( int location, int count, uint value );
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4uivEXT( int location, int count, uint value );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawArraysInstancedEXT( BeginMode mode, int start, int count, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElementsInstancedEXT( BeginMode mode, int count, DrawElementsType type, void indices, int primcount );
		[DllImport( "opengl32.dll" )]
		public static extern void TexBufferEXT( TextureTarget target, GLenum internalformat, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthRangedNV( double zNear, double zFar );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearDepthdNV( double depth );
		[DllImport( "opengl32.dll" )]
		public static extern void DepthBoundsdNV( double zmin, double zmax );
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageMultisampleCoverageNV( RenderbufferTarget target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersfvNV( ProgramTarget target, uint buffer, uint index, int count, float @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersIivNV( ProgramTarget target, uint buffer, uint index, int count, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersIuivNV( ProgramTarget target, uint buffer, uint index, int count, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ColorMaskIndexedEXT( uint index, bool r, bool g, bool b, bool a );
		[DllImport( "opengl32.dll" )]
		public static extern void GetBooleanIndexedvEXT( GLenum target, uint index, bool data );
		[DllImport( "opengl32.dll" )]
		public static extern void GetIntegerIndexedvEXT( GLenum target, uint index, int data );
		[DllImport( "opengl32.dll" )]
		public static extern void EnableIndexedEXT( GLenum target, uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void DisableIndexedEXT( GLenum target, uint index );
		[DllImport( "opengl32.dll" )]
		public static extern bool IsEnabledIndexedEXT( GLenum target, uint index );
		[DllImport( "opengl32.dll" )]
		public static extern void BeginTransformFeedbackNV( GLenum primitiveMode );
		[DllImport( "opengl32.dll" )]
		public static extern void EndTransformFeedbackNV(  );
		[DllImport( "opengl32.dll" )]
		public static extern void TransformFeedbackAttribsNV( uint count, int attribs, GLenum bufferMode );
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferRangeNV( GLenum target, uint index, uint buffer, int offset, int size );
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferOffsetNV( GLenum target, uint index, uint buffer, int offset );
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferBaseNV( GLenum target, uint index, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern void TransformFeedbackVaryingsNV( uint program, int count, int locations, GLenum bufferMode );
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveVaryingNV( uint program, char name );
		[DllImport( "opengl32.dll" )]
		public static extern int GetVaryingLocationNV( uint program, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveVaryingNV( uint program, uint index, int bufSize, int length, int size, GLenum type, char name );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTransformFeedbackVaryingNV( uint program, uint index, int location );
		[DllImport( "opengl32.dll" )]
		public static extern void UniformBufferEXT( uint program, int location, uint buffer );
		[DllImport( "opengl32.dll" )]
		public static extern int GetUniformBufferSizeEXT( uint program, int location );
		[DllImport( "opengl32.dll" )]
		public static extern int GetUniformOffsetEXT( uint program, int location );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterIivEXT( TextureTarget target, TextureParameterName pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterIuivEXT( TextureTarget target, TextureParameterName pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameterIivEXT( TextureTarget target, GetTextureParameter pname, int @params );
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameterIuivEXT( TextureTarget target, GetTextureParameter pname, uint @params );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearColorIiEXT( int red, int green, int blue, int alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void ClearColorIuiEXT( uint red, uint green, uint blue, uint alpha );
		[DllImport( "opengl32.dll" )]
		public static extern void FrameTerminatorGREMEDY(  );
	}
}

