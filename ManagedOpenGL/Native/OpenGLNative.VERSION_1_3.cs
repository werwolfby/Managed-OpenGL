using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_1_3Init()
		{
			_ActiveTexture = GetProcAdress< ActiveTextureDelegate >( "glActiveTexture" );
			_ClientActiveTexture = GetProcAdress< ClientActiveTextureDelegate >( "glClientActiveTexture" );
			_MultiTexCoord1d = GetProcAdress< MultiTexCoord1dDelegate >( "glMultiTexCoord1d" );
			_MultiTexCoord1dv = GetProcAdress< MultiTexCoord1dvDelegate >( "glMultiTexCoord1dv" );
			_MultiTexCoord1f = GetProcAdress< MultiTexCoord1fDelegate >( "glMultiTexCoord1f" );
			_MultiTexCoord1fv = GetProcAdress< MultiTexCoord1fvDelegate >( "glMultiTexCoord1fv" );
			_MultiTexCoord1i = GetProcAdress< MultiTexCoord1iDelegate >( "glMultiTexCoord1i" );
			_MultiTexCoord1iv = GetProcAdress< MultiTexCoord1ivDelegate >( "glMultiTexCoord1iv" );
			_MultiTexCoord1s = GetProcAdress< MultiTexCoord1sDelegate >( "glMultiTexCoord1s" );
			_MultiTexCoord1sv = GetProcAdress< MultiTexCoord1svDelegate >( "glMultiTexCoord1sv" );
			_MultiTexCoord2d = GetProcAdress< MultiTexCoord2dDelegate >( "glMultiTexCoord2d" );
			_MultiTexCoord2dv = GetProcAdress< MultiTexCoord2dvDelegate >( "glMultiTexCoord2dv" );
			_MultiTexCoord2f = GetProcAdress< MultiTexCoord2fDelegate >( "glMultiTexCoord2f" );
			_MultiTexCoord2fv = GetProcAdress< MultiTexCoord2fvDelegate >( "glMultiTexCoord2fv" );
			_MultiTexCoord2i = GetProcAdress< MultiTexCoord2iDelegate >( "glMultiTexCoord2i" );
			_MultiTexCoord2iv = GetProcAdress< MultiTexCoord2ivDelegate >( "glMultiTexCoord2iv" );
			_MultiTexCoord2s = GetProcAdress< MultiTexCoord2sDelegate >( "glMultiTexCoord2s" );
			_MultiTexCoord2sv = GetProcAdress< MultiTexCoord2svDelegate >( "glMultiTexCoord2sv" );
			_MultiTexCoord3d = GetProcAdress< MultiTexCoord3dDelegate >( "glMultiTexCoord3d" );
			_MultiTexCoord3dv = GetProcAdress< MultiTexCoord3dvDelegate >( "glMultiTexCoord3dv" );
			_MultiTexCoord3f = GetProcAdress< MultiTexCoord3fDelegate >( "glMultiTexCoord3f" );
			_MultiTexCoord3fv = GetProcAdress< MultiTexCoord3fvDelegate >( "glMultiTexCoord3fv" );
			_MultiTexCoord3i = GetProcAdress< MultiTexCoord3iDelegate >( "glMultiTexCoord3i" );
			_MultiTexCoord3iv = GetProcAdress< MultiTexCoord3ivDelegate >( "glMultiTexCoord3iv" );
			_MultiTexCoord3s = GetProcAdress< MultiTexCoord3sDelegate >( "glMultiTexCoord3s" );
			_MultiTexCoord3sv = GetProcAdress< MultiTexCoord3svDelegate >( "glMultiTexCoord3sv" );
			_MultiTexCoord4d = GetProcAdress< MultiTexCoord4dDelegate >( "glMultiTexCoord4d" );
			_MultiTexCoord4dv = GetProcAdress< MultiTexCoord4dvDelegate >( "glMultiTexCoord4dv" );
			_MultiTexCoord4f = GetProcAdress< MultiTexCoord4fDelegate >( "glMultiTexCoord4f" );
			_MultiTexCoord4fv = GetProcAdress< MultiTexCoord4fvDelegate >( "glMultiTexCoord4fv" );
			_MultiTexCoord4i = GetProcAdress< MultiTexCoord4iDelegate >( "glMultiTexCoord4i" );
			_MultiTexCoord4iv = GetProcAdress< MultiTexCoord4ivDelegate >( "glMultiTexCoord4iv" );
			_MultiTexCoord4s = GetProcAdress< MultiTexCoord4sDelegate >( "glMultiTexCoord4s" );
			_MultiTexCoord4sv = GetProcAdress< MultiTexCoord4svDelegate >( "glMultiTexCoord4sv" );
			_LoadTransposeMatrixf = GetProcAdress< LoadTransposeMatrixfDelegate >( "glLoadTransposeMatrixf" );
			_LoadTransposeMatrixd = GetProcAdress< LoadTransposeMatrixdDelegate >( "glLoadTransposeMatrixd" );
			_MultTransposeMatrixf = GetProcAdress< MultTransposeMatrixfDelegate >( "glMultTransposeMatrixf" );
			_MultTransposeMatrixd = GetProcAdress< MultTransposeMatrixdDelegate >( "glMultTransposeMatrixd" );
			_SampleCoverage = GetProcAdress< SampleCoverageDelegate >( "glSampleCoverage" );
			_CompressedTexImage3D = GetProcAdress< CompressedTexImage3DDelegate >( "glCompressedTexImage3D" );
			_CompressedTexImage2D = GetProcAdress< CompressedTexImage2DDelegate >( "glCompressedTexImage2D" );
			_CompressedTexImage1D = GetProcAdress< CompressedTexImage1DDelegate >( "glCompressedTexImage1D" );
			_CompressedTexSubImage3D = GetProcAdress< CompressedTexSubImage3DDelegate >( "glCompressedTexSubImage3D" );
			_CompressedTexSubImage2D = GetProcAdress< CompressedTexSubImage2DDelegate >( "glCompressedTexSubImage2D" );
			_CompressedTexSubImage1D = GetProcAdress< CompressedTexSubImage1DDelegate >( "glCompressedTexSubImage1D" );
			_GetCompressedTexImage = GetProcAdress< GetCompressedTexImageDelegate >( "glGetCompressedTexImage" );
		}


		public delegate void ActiveTextureDelegate( uint texture ); // 

		private static ActiveTextureDelegate _ActiveTexture;

		public static  void ActiveTexture( uint texture )
		{
			if (_ActiveTexture == null) throw new Exception( "Extension method ActiveTexture not found" );
		 _ActiveTexture( texture );
		}
		public delegate void ClientActiveTextureDelegate( uint texture ); // 

		private static ClientActiveTextureDelegate _ClientActiveTexture;

		public static  void ClientActiveTexture( uint texture )
		{
			if (_ClientActiveTexture == null) throw new Exception( "Extension method ClientActiveTexture not found" );
		 _ClientActiveTexture( texture );
		}
		public delegate void MultiTexCoord1dDelegate( uint target, double s ); // 

		private static MultiTexCoord1dDelegate _MultiTexCoord1d;

		public static  void MultiTexCoord1d( uint target, double s )
		{
			if (_MultiTexCoord1d == null) throw new Exception( "Extension method MultiTexCoord1d not found" );
		 _MultiTexCoord1d( target, s );
		}
		public delegate void MultiTexCoord1dvDelegate( uint target, double[] v ); // 

		private static MultiTexCoord1dvDelegate _MultiTexCoord1dv;

		public static  void MultiTexCoord1dv( uint target, double[] v )
		{
			if (_MultiTexCoord1dv == null) throw new Exception( "Extension method MultiTexCoord1dv not found" );
		 _MultiTexCoord1dv( target, v );
		}
		public delegate void MultiTexCoord1fDelegate( uint target, float s ); // 

		private static MultiTexCoord1fDelegate _MultiTexCoord1f;

		public static  void MultiTexCoord1f( uint target, float s )
		{
			if (_MultiTexCoord1f == null) throw new Exception( "Extension method MultiTexCoord1f not found" );
		 _MultiTexCoord1f( target, s );
		}
		public delegate void MultiTexCoord1fvDelegate( uint target, float[] v ); // 

		private static MultiTexCoord1fvDelegate _MultiTexCoord1fv;

		public static  void MultiTexCoord1fv( uint target, float[] v )
		{
			if (_MultiTexCoord1fv == null) throw new Exception( "Extension method MultiTexCoord1fv not found" );
		 _MultiTexCoord1fv( target, v );
		}
		public delegate void MultiTexCoord1iDelegate( uint target, int s ); // 

		private static MultiTexCoord1iDelegate _MultiTexCoord1i;

		public static  void MultiTexCoord1i( uint target, int s )
		{
			if (_MultiTexCoord1i == null) throw new Exception( "Extension method MultiTexCoord1i not found" );
		 _MultiTexCoord1i( target, s );
		}
		public delegate void MultiTexCoord1ivDelegate( uint target, int[] v ); // 

		private static MultiTexCoord1ivDelegate _MultiTexCoord1iv;

		public static  void MultiTexCoord1iv( uint target, int[] v )
		{
			if (_MultiTexCoord1iv == null) throw new Exception( "Extension method MultiTexCoord1iv not found" );
		 _MultiTexCoord1iv( target, v );
		}
		public delegate void MultiTexCoord1sDelegate( uint target, short s ); // 

		private static MultiTexCoord1sDelegate _MultiTexCoord1s;

		public static  void MultiTexCoord1s( uint target, short s )
		{
			if (_MultiTexCoord1s == null) throw new Exception( "Extension method MultiTexCoord1s not found" );
		 _MultiTexCoord1s( target, s );
		}
		public delegate void MultiTexCoord1svDelegate( uint target, short[] v ); // 

		private static MultiTexCoord1svDelegate _MultiTexCoord1sv;

		public static  void MultiTexCoord1sv( uint target, short[] v )
		{
			if (_MultiTexCoord1sv == null) throw new Exception( "Extension method MultiTexCoord1sv not found" );
		 _MultiTexCoord1sv( target, v );
		}
		public delegate void MultiTexCoord2dDelegate( uint target, double s, double t ); // 

		private static MultiTexCoord2dDelegate _MultiTexCoord2d;

		public static  void MultiTexCoord2d( uint target, double s, double t )
		{
			if (_MultiTexCoord2d == null) throw new Exception( "Extension method MultiTexCoord2d not found" );
		 _MultiTexCoord2d( target, s, t );
		}
		public delegate void MultiTexCoord2dvDelegate( uint target, double[] v ); // 

		private static MultiTexCoord2dvDelegate _MultiTexCoord2dv;

		public static  void MultiTexCoord2dv( uint target, double[] v )
		{
			if (_MultiTexCoord2dv == null) throw new Exception( "Extension method MultiTexCoord2dv not found" );
		 _MultiTexCoord2dv( target, v );
		}
		public delegate void MultiTexCoord2fDelegate( uint target, float s, float t ); // 

		private static MultiTexCoord2fDelegate _MultiTexCoord2f;

		public static  void MultiTexCoord2f( uint target, float s, float t )
		{
			if (_MultiTexCoord2f == null) throw new Exception( "Extension method MultiTexCoord2f not found" );
		 _MultiTexCoord2f( target, s, t );
		}
		public delegate void MultiTexCoord2fvDelegate( uint target, float[] v ); // 

		private static MultiTexCoord2fvDelegate _MultiTexCoord2fv;

		public static  void MultiTexCoord2fv( uint target, float[] v )
		{
			if (_MultiTexCoord2fv == null) throw new Exception( "Extension method MultiTexCoord2fv not found" );
		 _MultiTexCoord2fv( target, v );
		}
		public delegate void MultiTexCoord2iDelegate( uint target, int s, int t ); // 

		private static MultiTexCoord2iDelegate _MultiTexCoord2i;

		public static  void MultiTexCoord2i( uint target, int s, int t )
		{
			if (_MultiTexCoord2i == null) throw new Exception( "Extension method MultiTexCoord2i not found" );
		 _MultiTexCoord2i( target, s, t );
		}
		public delegate void MultiTexCoord2ivDelegate( uint target, int[] v ); // 

		private static MultiTexCoord2ivDelegate _MultiTexCoord2iv;

		public static  void MultiTexCoord2iv( uint target, int[] v )
		{
			if (_MultiTexCoord2iv == null) throw new Exception( "Extension method MultiTexCoord2iv not found" );
		 _MultiTexCoord2iv( target, v );
		}
		public delegate void MultiTexCoord2sDelegate( uint target, short s, short t ); // 

		private static MultiTexCoord2sDelegate _MultiTexCoord2s;

		public static  void MultiTexCoord2s( uint target, short s, short t )
		{
			if (_MultiTexCoord2s == null) throw new Exception( "Extension method MultiTexCoord2s not found" );
		 _MultiTexCoord2s( target, s, t );
		}
		public delegate void MultiTexCoord2svDelegate( uint target, short[] v ); // 

		private static MultiTexCoord2svDelegate _MultiTexCoord2sv;

		public static  void MultiTexCoord2sv( uint target, short[] v )
		{
			if (_MultiTexCoord2sv == null) throw new Exception( "Extension method MultiTexCoord2sv not found" );
		 _MultiTexCoord2sv( target, v );
		}
		public delegate void MultiTexCoord3dDelegate( uint target, double s, double t, double r ); // 

		private static MultiTexCoord3dDelegate _MultiTexCoord3d;

		public static  void MultiTexCoord3d( uint target, double s, double t, double r )
		{
			if (_MultiTexCoord3d == null) throw new Exception( "Extension method MultiTexCoord3d not found" );
		 _MultiTexCoord3d( target, s, t, r );
		}
		public delegate void MultiTexCoord3dvDelegate( uint target, double[] v ); // 

		private static MultiTexCoord3dvDelegate _MultiTexCoord3dv;

		public static  void MultiTexCoord3dv( uint target, double[] v )
		{
			if (_MultiTexCoord3dv == null) throw new Exception( "Extension method MultiTexCoord3dv not found" );
		 _MultiTexCoord3dv( target, v );
		}
		public delegate void MultiTexCoord3fDelegate( uint target, float s, float t, float r ); // 

		private static MultiTexCoord3fDelegate _MultiTexCoord3f;

		public static  void MultiTexCoord3f( uint target, float s, float t, float r )
		{
			if (_MultiTexCoord3f == null) throw new Exception( "Extension method MultiTexCoord3f not found" );
		 _MultiTexCoord3f( target, s, t, r );
		}
		public delegate void MultiTexCoord3fvDelegate( uint target, float[] v ); // 

		private static MultiTexCoord3fvDelegate _MultiTexCoord3fv;

		public static  void MultiTexCoord3fv( uint target, float[] v )
		{
			if (_MultiTexCoord3fv == null) throw new Exception( "Extension method MultiTexCoord3fv not found" );
		 _MultiTexCoord3fv( target, v );
		}
		public delegate void MultiTexCoord3iDelegate( uint target, int s, int t, int r ); // 

		private static MultiTexCoord3iDelegate _MultiTexCoord3i;

		public static  void MultiTexCoord3i( uint target, int s, int t, int r )
		{
			if (_MultiTexCoord3i == null) throw new Exception( "Extension method MultiTexCoord3i not found" );
		 _MultiTexCoord3i( target, s, t, r );
		}
		public delegate void MultiTexCoord3ivDelegate( uint target, int[] v ); // 

		private static MultiTexCoord3ivDelegate _MultiTexCoord3iv;

		public static  void MultiTexCoord3iv( uint target, int[] v )
		{
			if (_MultiTexCoord3iv == null) throw new Exception( "Extension method MultiTexCoord3iv not found" );
		 _MultiTexCoord3iv( target, v );
		}
		public delegate void MultiTexCoord3sDelegate( uint target, short s, short t, short r ); // 

		private static MultiTexCoord3sDelegate _MultiTexCoord3s;

		public static  void MultiTexCoord3s( uint target, short s, short t, short r )
		{
			if (_MultiTexCoord3s == null) throw new Exception( "Extension method MultiTexCoord3s not found" );
		 _MultiTexCoord3s( target, s, t, r );
		}
		public delegate void MultiTexCoord3svDelegate( uint target, short[] v ); // 

		private static MultiTexCoord3svDelegate _MultiTexCoord3sv;

		public static  void MultiTexCoord3sv( uint target, short[] v )
		{
			if (_MultiTexCoord3sv == null) throw new Exception( "Extension method MultiTexCoord3sv not found" );
		 _MultiTexCoord3sv( target, v );
		}
		public delegate void MultiTexCoord4dDelegate( uint target, double s, double t, double r, double q ); // 

		private static MultiTexCoord4dDelegate _MultiTexCoord4d;

		public static  void MultiTexCoord4d( uint target, double s, double t, double r, double q )
		{
			if (_MultiTexCoord4d == null) throw new Exception( "Extension method MultiTexCoord4d not found" );
		 _MultiTexCoord4d( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4dvDelegate( uint target, double[] v ); // 

		private static MultiTexCoord4dvDelegate _MultiTexCoord4dv;

		public static  void MultiTexCoord4dv( uint target, double[] v )
		{
			if (_MultiTexCoord4dv == null) throw new Exception( "Extension method MultiTexCoord4dv not found" );
		 _MultiTexCoord4dv( target, v );
		}
		public delegate void MultiTexCoord4fDelegate( uint target, float s, float t, float r, float q ); // 

		private static MultiTexCoord4fDelegate _MultiTexCoord4f;

		public static  void MultiTexCoord4f( uint target, float s, float t, float r, float q )
		{
			if (_MultiTexCoord4f == null) throw new Exception( "Extension method MultiTexCoord4f not found" );
		 _MultiTexCoord4f( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4fvDelegate( uint target, float[] v ); // 

		private static MultiTexCoord4fvDelegate _MultiTexCoord4fv;

		public static  void MultiTexCoord4fv( uint target, float[] v )
		{
			if (_MultiTexCoord4fv == null) throw new Exception( "Extension method MultiTexCoord4fv not found" );
		 _MultiTexCoord4fv( target, v );
		}
		public delegate void MultiTexCoord4iDelegate( uint target, int s, int t, int r, int q ); // 

		private static MultiTexCoord4iDelegate _MultiTexCoord4i;

		public static  void MultiTexCoord4i( uint target, int s, int t, int r, int q )
		{
			if (_MultiTexCoord4i == null) throw new Exception( "Extension method MultiTexCoord4i not found" );
		 _MultiTexCoord4i( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4ivDelegate( uint target, int[] v ); // 

		private static MultiTexCoord4ivDelegate _MultiTexCoord4iv;

		public static  void MultiTexCoord4iv( uint target, int[] v )
		{
			if (_MultiTexCoord4iv == null) throw new Exception( "Extension method MultiTexCoord4iv not found" );
		 _MultiTexCoord4iv( target, v );
		}
		public delegate void MultiTexCoord4sDelegate( uint target, short s, short t, short r, short q ); // 

		private static MultiTexCoord4sDelegate _MultiTexCoord4s;

		public static  void MultiTexCoord4s( uint target, short s, short t, short r, short q )
		{
			if (_MultiTexCoord4s == null) throw new Exception( "Extension method MultiTexCoord4s not found" );
		 _MultiTexCoord4s( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4svDelegate( uint target, short[] v ); // 

		private static MultiTexCoord4svDelegate _MultiTexCoord4sv;

		public static  void MultiTexCoord4sv( uint target, short[] v )
		{
			if (_MultiTexCoord4sv == null) throw new Exception( "Extension method MultiTexCoord4sv not found" );
		 _MultiTexCoord4sv( target, v );
		}
		public delegate void LoadTransposeMatrixfDelegate( float[] m ); // 

		private static LoadTransposeMatrixfDelegate _LoadTransposeMatrixf;

		public static  void LoadTransposeMatrixf( float[] m )
		{
			if (_LoadTransposeMatrixf == null) throw new Exception( "Extension method LoadTransposeMatrixf not found" );
		 _LoadTransposeMatrixf( m );
		}
		public delegate void LoadTransposeMatrixdDelegate( double[] m ); // 

		private static LoadTransposeMatrixdDelegate _LoadTransposeMatrixd;

		public static  void LoadTransposeMatrixd( double[] m )
		{
			if (_LoadTransposeMatrixd == null) throw new Exception( "Extension method LoadTransposeMatrixd not found" );
		 _LoadTransposeMatrixd( m );
		}
		public delegate void MultTransposeMatrixfDelegate( float[] m ); // 

		private static MultTransposeMatrixfDelegate _MultTransposeMatrixf;

		public static  void MultTransposeMatrixf( float[] m )
		{
			if (_MultTransposeMatrixf == null) throw new Exception( "Extension method MultTransposeMatrixf not found" );
		 _MultTransposeMatrixf( m );
		}
		public delegate void MultTransposeMatrixdDelegate( double[] m ); // 

		private static MultTransposeMatrixdDelegate _MultTransposeMatrixd;

		public static  void MultTransposeMatrixd( double[] m )
		{
			if (_MultTransposeMatrixd == null) throw new Exception( "Extension method MultTransposeMatrixd not found" );
		 _MultTransposeMatrixd( m );
		}
		public delegate void SampleCoverageDelegate( float value, bool invert ); // 

		private static SampleCoverageDelegate _SampleCoverage;

		public static  void SampleCoverage( float value, bool invert )
		{
			if (_SampleCoverage == null) throw new Exception( "Extension method SampleCoverage not found" );
		 _SampleCoverage( value, invert );
		}
		public unsafe delegate void CompressedTexImage3DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 

		private static CompressedTexImage3DDelegate _CompressedTexImage3D;

		public static unsafe  void CompressedTexImage3D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage3D == null) throw new Exception( "Extension method CompressedTexImage3D not found" );
		 _CompressedTexImage3D( target, level, internalformat, width, height, depth, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexImage2DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 

		private static CompressedTexImage2DDelegate _CompressedTexImage2D;

		public static unsafe  void CompressedTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage2D == null) throw new Exception( "Extension method CompressedTexImage2D not found" );
		 _CompressedTexImage2D( target, level, internalformat, width, height, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexImage1DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 

		private static CompressedTexImage1DDelegate _CompressedTexImage1D;

		public static unsafe  void CompressedTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data )
		{
			if (_CompressedTexImage1D == null) throw new Exception( "Extension method CompressedTexImage1D not found" );
		 _CompressedTexImage1D( target, level, internalformat, width, border, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage3DDelegate _CompressedTexSubImage3D;

		public static unsafe  void CompressedTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage3D == null) throw new Exception( "Extension method CompressedTexSubImage3D not found" );
		 _CompressedTexSubImage3D( target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage2DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage2DDelegate _CompressedTexSubImage2D;

		public static unsafe  void CompressedTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage2D == null) throw new Exception( "Extension method CompressedTexSubImage2D not found" );
		 _CompressedTexSubImage2D( target, level, xoffset, yoffset, width, height, format, imageSize, data );
		}
		public unsafe delegate void CompressedTexSubImage1DDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 

		private static CompressedTexSubImage1DDelegate _CompressedTexSubImage1D;

		public static unsafe  void CompressedTexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data )
		{
			if (_CompressedTexSubImage1D == null) throw new Exception( "Extension method CompressedTexSubImage1D not found" );
		 _CompressedTexSubImage1D( target, level, xoffset, width, format, imageSize, data );
		}
		public unsafe delegate void GetCompressedTexImageDelegate( TextureTarget target, int level, [Out]void* img ); // 

		private static GetCompressedTexImageDelegate _GetCompressedTexImage;

		public static unsafe  void GetCompressedTexImage( TextureTarget target, int level, [Out]void* img )
		{
			if (_GetCompressedTexImage == null) throw new Exception( "Extension method GetCompressedTexImage not found" );
		 _GetCompressedTexImage( target, level, img );
		}
	}
}
