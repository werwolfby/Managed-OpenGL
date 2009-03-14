using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_1_4Init()
		{
			_BlendFuncSeparate = GetProcAdress< BlendFuncSeparateDelegate >( "glBlendFuncSeparate" );
			_FogCoordf = GetProcAdress< FogCoordfDelegate >( "glFogCoordf" );
			_FogCoordfv = GetProcAdress< FogCoordfvDelegate >( "glFogCoordfv" );
			_FogCoordd = GetProcAdress< FogCoorddDelegate >( "glFogCoordd" );
			_FogCoorddv = GetProcAdress< FogCoorddvDelegate >( "glFogCoorddv" );
			_FogCoordPointer = GetProcAdress< FogCoordPointerDelegate >( "glFogCoordPointer" );
			_MultiDrawArrays = GetProcAdress< MultiDrawArraysDelegate >( "glMultiDrawArrays" );
			_MultiDrawElements = GetProcAdress< MultiDrawElementsDelegate >( "glMultiDrawElements" );
			_PointParameterf = GetProcAdress< PointParameterfDelegate >( "glPointParameterf" );
			_PointParameterfv = GetProcAdress< PointParameterfvDelegate >( "glPointParameterfv" );
			_PointParameteri = GetProcAdress< PointParameteriDelegate >( "glPointParameteri" );
			_PointParameteriv = GetProcAdress< PointParameterivDelegate >( "glPointParameteriv" );
			_SecondaryColor3b = GetProcAdress< SecondaryColor3bDelegate >( "glSecondaryColor3b" );
			_SecondaryColor3bv = GetProcAdress< SecondaryColor3bvDelegate >( "glSecondaryColor3bv" );
			_SecondaryColor3d = GetProcAdress< SecondaryColor3dDelegate >( "glSecondaryColor3d" );
			_SecondaryColor3dv = GetProcAdress< SecondaryColor3dvDelegate >( "glSecondaryColor3dv" );
			_SecondaryColor3f = GetProcAdress< SecondaryColor3fDelegate >( "glSecondaryColor3f" );
			_SecondaryColor3fv = GetProcAdress< SecondaryColor3fvDelegate >( "glSecondaryColor3fv" );
			_SecondaryColor3i = GetProcAdress< SecondaryColor3iDelegate >( "glSecondaryColor3i" );
			_SecondaryColor3iv = GetProcAdress< SecondaryColor3ivDelegate >( "glSecondaryColor3iv" );
			_SecondaryColor3s = GetProcAdress< SecondaryColor3sDelegate >( "glSecondaryColor3s" );
			_SecondaryColor3sv = GetProcAdress< SecondaryColor3svDelegate >( "glSecondaryColor3sv" );
			_SecondaryColor3ub = GetProcAdress< SecondaryColor3ubDelegate >( "glSecondaryColor3ub" );
			_SecondaryColor3ubv = GetProcAdress< SecondaryColor3ubvDelegate >( "glSecondaryColor3ubv" );
			_SecondaryColor3ui = GetProcAdress< SecondaryColor3uiDelegate >( "glSecondaryColor3ui" );
			_SecondaryColor3uiv = GetProcAdress< SecondaryColor3uivDelegate >( "glSecondaryColor3uiv" );
			_SecondaryColor3us = GetProcAdress< SecondaryColor3usDelegate >( "glSecondaryColor3us" );
			_SecondaryColor3usv = GetProcAdress< SecondaryColor3usvDelegate >( "glSecondaryColor3usv" );
			_SecondaryColorPointer = GetProcAdress< SecondaryColorPointerDelegate >( "glSecondaryColorPointer" );
			_WindowPos2d = GetProcAdress< WindowPos2dDelegate >( "glWindowPos2d" );
			_WindowPos2dv = GetProcAdress< WindowPos2dvDelegate >( "glWindowPos2dv" );
			_WindowPos2f = GetProcAdress< WindowPos2fDelegate >( "glWindowPos2f" );
			_WindowPos2fv = GetProcAdress< WindowPos2fvDelegate >( "glWindowPos2fv" );
			_WindowPos2i = GetProcAdress< WindowPos2iDelegate >( "glWindowPos2i" );
			_WindowPos2iv = GetProcAdress< WindowPos2ivDelegate >( "glWindowPos2iv" );
			_WindowPos2s = GetProcAdress< WindowPos2sDelegate >( "glWindowPos2s" );
			_WindowPos2sv = GetProcAdress< WindowPos2svDelegate >( "glWindowPos2sv" );
			_WindowPos3d = GetProcAdress< WindowPos3dDelegate >( "glWindowPos3d" );
			_WindowPos3dv = GetProcAdress< WindowPos3dvDelegate >( "glWindowPos3dv" );
			_WindowPos3f = GetProcAdress< WindowPos3fDelegate >( "glWindowPos3f" );
			_WindowPos3fv = GetProcAdress< WindowPos3fvDelegate >( "glWindowPos3fv" );
			_WindowPos3i = GetProcAdress< WindowPos3iDelegate >( "glWindowPos3i" );
			_WindowPos3iv = GetProcAdress< WindowPos3ivDelegate >( "glWindowPos3iv" );
			_WindowPos3s = GetProcAdress< WindowPos3sDelegate >( "glWindowPos3s" );
			_WindowPos3sv = GetProcAdress< WindowPos3svDelegate >( "glWindowPos3sv" );
		}


		public delegate void BlendFuncSeparateDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method

		private static BlendFuncSeparateDelegate _BlendFuncSeparate;

		public static  void BlendFuncSeparate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha )
		{
			if (_BlendFuncSeparate == null) throw new Exception( "Extension method BlendFuncSeparate not found" );
		 _BlendFuncSeparate( sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha );
		}
		public delegate void FogCoordfDelegate( float coord ); // 

		private static FogCoordfDelegate _FogCoordf;

		public static  void FogCoordf( float coord )
		{
			if (_FogCoordf == null) throw new Exception( "Extension method FogCoordf not found" );
		 _FogCoordf( coord );
		}
		public delegate void FogCoordfvDelegate( float[] coord ); // 

		private static FogCoordfvDelegate _FogCoordfv;

		public static  void FogCoordfv( float[] coord )
		{
			if (_FogCoordfv == null) throw new Exception( "Extension method FogCoordfv not found" );
		 _FogCoordfv( coord );
		}
		public delegate void FogCoorddDelegate( double coord ); // 

		private static FogCoorddDelegate _FogCoordd;

		public static  void FogCoordd( double coord )
		{
			if (_FogCoordd == null) throw new Exception( "Extension method FogCoordd not found" );
		 _FogCoordd( coord );
		}
		public delegate void FogCoorddvDelegate( double[] coord ); // 

		private static FogCoorddvDelegate _FogCoorddv;

		public static  void FogCoorddv( double[] coord )
		{
			if (_FogCoorddv == null) throw new Exception( "Extension method FogCoorddv not found" );
		 _FogCoorddv( coord );
		}
		public unsafe delegate void FogCoordPointerDelegate( uint type, int stride, void* pointer ); // 

		private static FogCoordPointerDelegate _FogCoordPointer;

		public static unsafe  void FogCoordPointer( uint type, int stride, void* pointer )
		{
			if (_FogCoordPointer == null) throw new Exception( "Extension method FogCoordPointer not found" );
		 _FogCoordPointer( type, stride, pointer );
		}
		public delegate void MultiDrawArraysDelegate( BeginMode mode, [Out]int[] first, [Out]int[] count, int primcount ); // 

		private static MultiDrawArraysDelegate _MultiDrawArrays;

		public static  void MultiDrawArrays( BeginMode mode, [Out]int[] first, [Out]int[] count, int primcount )
		{
			if (_MultiDrawArrays == null) throw new Exception( "Extension method MultiDrawArrays not found" );
		 _MultiDrawArrays( mode, first, count, primcount );
		}
		public unsafe delegate void MultiDrawElementsDelegate( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 

		private static MultiDrawElementsDelegate _MultiDrawElements;

		public static unsafe  void MultiDrawElements( BeginMode mode, int[] count, uint type, void** indices, int primcount )
		{
			if (_MultiDrawElements == null) throw new Exception( "Extension method MultiDrawElements not found" );
		 _MultiDrawElements( mode, count, type, indices, primcount );
		}
		public delegate void PointParameterfDelegate( uint pname, float param ); //  extension method

		private static PointParameterfDelegate _PointParameterf;

		public static  void PointParameterf( uint pname, float param )
		{
			if (_PointParameterf == null) throw new Exception( "Extension method PointParameterf not found" );
		 _PointParameterf( pname, param );
		}
		public delegate void PointParameterfvDelegate( uint pname, float[] @params ); //  extension method

		private static PointParameterfvDelegate _PointParameterfv;

		public static  void PointParameterfv( uint pname, float[] @params )
		{
			if (_PointParameterfv == null) throw new Exception( "Extension method PointParameterfv not found" );
		 _PointParameterfv( pname, @params );
		}
		public delegate void PointParameteriDelegate( uint pname, int param ); //  extension method

		private static PointParameteriDelegate _PointParameteri;

		public static  void PointParameteri( uint pname, int param )
		{
			if (_PointParameteri == null) throw new Exception( "Extension method PointParameteri not found" );
		 _PointParameteri( pname, param );
		}
		public delegate void PointParameterivDelegate( uint pname, int[] @params ); //  extension method

		private static PointParameterivDelegate _PointParameteriv;

		public static  void PointParameteriv( uint pname, int[] @params )
		{
			if (_PointParameteriv == null) throw new Exception( "Extension method PointParameteriv not found" );
		 _PointParameteriv( pname, @params );
		}
		public delegate void SecondaryColor3bDelegate( sbyte red, sbyte green, sbyte blue ); // 

		private static SecondaryColor3bDelegate _SecondaryColor3b;

		public static  void SecondaryColor3b( sbyte red, sbyte green, sbyte blue )
		{
			if (_SecondaryColor3b == null) throw new Exception( "Extension method SecondaryColor3b not found" );
		 _SecondaryColor3b( red, green, blue );
		}
		public delegate void SecondaryColor3bvDelegate( sbyte[] v ); // 

		private static SecondaryColor3bvDelegate _SecondaryColor3bv;

		public static  void SecondaryColor3bv( sbyte[] v )
		{
			if (_SecondaryColor3bv == null) throw new Exception( "Extension method SecondaryColor3bv not found" );
		 _SecondaryColor3bv( v );
		}
		public delegate void SecondaryColor3dDelegate( double red, double green, double blue ); // 

		private static SecondaryColor3dDelegate _SecondaryColor3d;

		public static  void SecondaryColor3d( double red, double green, double blue )
		{
			if (_SecondaryColor3d == null) throw new Exception( "Extension method SecondaryColor3d not found" );
		 _SecondaryColor3d( red, green, blue );
		}
		public delegate void SecondaryColor3dvDelegate( double[] v ); // 

		private static SecondaryColor3dvDelegate _SecondaryColor3dv;

		public static  void SecondaryColor3dv( double[] v )
		{
			if (_SecondaryColor3dv == null) throw new Exception( "Extension method SecondaryColor3dv not found" );
		 _SecondaryColor3dv( v );
		}
		public delegate void SecondaryColor3fDelegate( float red, float green, float blue ); // 

		private static SecondaryColor3fDelegate _SecondaryColor3f;

		public static  void SecondaryColor3f( float red, float green, float blue )
		{
			if (_SecondaryColor3f == null) throw new Exception( "Extension method SecondaryColor3f not found" );
		 _SecondaryColor3f( red, green, blue );
		}
		public delegate void SecondaryColor3fvDelegate( float[] v ); // 

		private static SecondaryColor3fvDelegate _SecondaryColor3fv;

		public static  void SecondaryColor3fv( float[] v )
		{
			if (_SecondaryColor3fv == null) throw new Exception( "Extension method SecondaryColor3fv not found" );
		 _SecondaryColor3fv( v );
		}
		public delegate void SecondaryColor3iDelegate( int red, int green, int blue ); // 

		private static SecondaryColor3iDelegate _SecondaryColor3i;

		public static  void SecondaryColor3i( int red, int green, int blue )
		{
			if (_SecondaryColor3i == null) throw new Exception( "Extension method SecondaryColor3i not found" );
		 _SecondaryColor3i( red, green, blue );
		}
		public delegate void SecondaryColor3ivDelegate( int[] v ); // 

		private static SecondaryColor3ivDelegate _SecondaryColor3iv;

		public static  void SecondaryColor3iv( int[] v )
		{
			if (_SecondaryColor3iv == null) throw new Exception( "Extension method SecondaryColor3iv not found" );
		 _SecondaryColor3iv( v );
		}
		public delegate void SecondaryColor3sDelegate( short red, short green, short blue ); // 

		private static SecondaryColor3sDelegate _SecondaryColor3s;

		public static  void SecondaryColor3s( short red, short green, short blue )
		{
			if (_SecondaryColor3s == null) throw new Exception( "Extension method SecondaryColor3s not found" );
		 _SecondaryColor3s( red, green, blue );
		}
		public delegate void SecondaryColor3svDelegate( short[] v ); // 

		private static SecondaryColor3svDelegate _SecondaryColor3sv;

		public static  void SecondaryColor3sv( short[] v )
		{
			if (_SecondaryColor3sv == null) throw new Exception( "Extension method SecondaryColor3sv not found" );
		 _SecondaryColor3sv( v );
		}
		public delegate void SecondaryColor3ubDelegate( byte red, byte green, byte blue ); // 

		private static SecondaryColor3ubDelegate _SecondaryColor3ub;

		public static  void SecondaryColor3ub( byte red, byte green, byte blue )
		{
			if (_SecondaryColor3ub == null) throw new Exception( "Extension method SecondaryColor3ub not found" );
		 _SecondaryColor3ub( red, green, blue );
		}
		public delegate void SecondaryColor3ubvDelegate( byte[] v ); // 

		private static SecondaryColor3ubvDelegate _SecondaryColor3ubv;

		public static  void SecondaryColor3ubv( byte[] v )
		{
			if (_SecondaryColor3ubv == null) throw new Exception( "Extension method SecondaryColor3ubv not found" );
		 _SecondaryColor3ubv( v );
		}
		public delegate void SecondaryColor3uiDelegate( uint red, uint green, uint blue ); // 

		private static SecondaryColor3uiDelegate _SecondaryColor3ui;

		public static  void SecondaryColor3ui( uint red, uint green, uint blue )
		{
			if (_SecondaryColor3ui == null) throw new Exception( "Extension method SecondaryColor3ui not found" );
		 _SecondaryColor3ui( red, green, blue );
		}
		public delegate void SecondaryColor3uivDelegate( uint[] v ); // 

		private static SecondaryColor3uivDelegate _SecondaryColor3uiv;

		public static  void SecondaryColor3uiv( uint[] v )
		{
			if (_SecondaryColor3uiv == null) throw new Exception( "Extension method SecondaryColor3uiv not found" );
		 _SecondaryColor3uiv( v );
		}
		public delegate void SecondaryColor3usDelegate( ushort red, ushort green, ushort blue ); // 

		private static SecondaryColor3usDelegate _SecondaryColor3us;

		public static  void SecondaryColor3us( ushort red, ushort green, ushort blue )
		{
			if (_SecondaryColor3us == null) throw new Exception( "Extension method SecondaryColor3us not found" );
		 _SecondaryColor3us( red, green, blue );
		}
		public delegate void SecondaryColor3usvDelegate( ushort[] v ); // 

		private static SecondaryColor3usvDelegate _SecondaryColor3usv;

		public static  void SecondaryColor3usv( ushort[] v )
		{
			if (_SecondaryColor3usv == null) throw new Exception( "Extension method SecondaryColor3usv not found" );
		 _SecondaryColor3usv( v );
		}
		public unsafe delegate void SecondaryColorPointerDelegate( int size, ColorPointerType type, int stride, void* pointer ); //  extension method

		private static SecondaryColorPointerDelegate _SecondaryColorPointer;

		public static unsafe  void SecondaryColorPointer( int size, ColorPointerType type, int stride, void* pointer )
		{
			if (_SecondaryColorPointer == null) throw new Exception( "Extension method SecondaryColorPointer not found" );
		 _SecondaryColorPointer( size, type, stride, pointer );
		}
		public delegate void WindowPos2dDelegate( double x, double y ); // 

		private static WindowPos2dDelegate _WindowPos2d;

		public static  void WindowPos2d( double x, double y )
		{
			if (_WindowPos2d == null) throw new Exception( "Extension method WindowPos2d not found" );
		 _WindowPos2d( x, y );
		}
		public delegate void WindowPos2dvDelegate( double[] v ); // 

		private static WindowPos2dvDelegate _WindowPos2dv;

		public static  void WindowPos2dv( double[] v )
		{
			if (_WindowPos2dv == null) throw new Exception( "Extension method WindowPos2dv not found" );
		 _WindowPos2dv( v );
		}
		public delegate void WindowPos2fDelegate( float x, float y ); // 

		private static WindowPos2fDelegate _WindowPos2f;

		public static  void WindowPos2f( float x, float y )
		{
			if (_WindowPos2f == null) throw new Exception( "Extension method WindowPos2f not found" );
		 _WindowPos2f( x, y );
		}
		public delegate void WindowPos2fvDelegate( float[] v ); // 

		private static WindowPos2fvDelegate _WindowPos2fv;

		public static  void WindowPos2fv( float[] v )
		{
			if (_WindowPos2fv == null) throw new Exception( "Extension method WindowPos2fv not found" );
		 _WindowPos2fv( v );
		}
		public delegate void WindowPos2iDelegate( int x, int y ); // 

		private static WindowPos2iDelegate _WindowPos2i;

		public static  void WindowPos2i( int x, int y )
		{
			if (_WindowPos2i == null) throw new Exception( "Extension method WindowPos2i not found" );
		 _WindowPos2i( x, y );
		}
		public delegate void WindowPos2ivDelegate( int[] v ); // 

		private static WindowPos2ivDelegate _WindowPos2iv;

		public static  void WindowPos2iv( int[] v )
		{
			if (_WindowPos2iv == null) throw new Exception( "Extension method WindowPos2iv not found" );
		 _WindowPos2iv( v );
		}
		public delegate void WindowPos2sDelegate( short x, short y ); // 

		private static WindowPos2sDelegate _WindowPos2s;

		public static  void WindowPos2s( short x, short y )
		{
			if (_WindowPos2s == null) throw new Exception( "Extension method WindowPos2s not found" );
		 _WindowPos2s( x, y );
		}
		public delegate void WindowPos2svDelegate( short[] v ); // 

		private static WindowPos2svDelegate _WindowPos2sv;

		public static  void WindowPos2sv( short[] v )
		{
			if (_WindowPos2sv == null) throw new Exception( "Extension method WindowPos2sv not found" );
		 _WindowPos2sv( v );
		}
		public delegate void WindowPos3dDelegate( double x, double y, double z ); // 

		private static WindowPos3dDelegate _WindowPos3d;

		public static  void WindowPos3d( double x, double y, double z )
		{
			if (_WindowPos3d == null) throw new Exception( "Extension method WindowPos3d not found" );
		 _WindowPos3d( x, y, z );
		}
		public delegate void WindowPos3dvDelegate( double[] v ); // 

		private static WindowPos3dvDelegate _WindowPos3dv;

		public static  void WindowPos3dv( double[] v )
		{
			if (_WindowPos3dv == null) throw new Exception( "Extension method WindowPos3dv not found" );
		 _WindowPos3dv( v );
		}
		public delegate void WindowPos3fDelegate( float x, float y, float z ); // 

		private static WindowPos3fDelegate _WindowPos3f;

		public static  void WindowPos3f( float x, float y, float z )
		{
			if (_WindowPos3f == null) throw new Exception( "Extension method WindowPos3f not found" );
		 _WindowPos3f( x, y, z );
		}
		public delegate void WindowPos3fvDelegate( float[] v ); // 

		private static WindowPos3fvDelegate _WindowPos3fv;

		public static  void WindowPos3fv( float[] v )
		{
			if (_WindowPos3fv == null) throw new Exception( "Extension method WindowPos3fv not found" );
		 _WindowPos3fv( v );
		}
		public delegate void WindowPos3iDelegate( int x, int y, int z ); // 

		private static WindowPos3iDelegate _WindowPos3i;

		public static  void WindowPos3i( int x, int y, int z )
		{
			if (_WindowPos3i == null) throw new Exception( "Extension method WindowPos3i not found" );
		 _WindowPos3i( x, y, z );
		}
		public delegate void WindowPos3ivDelegate( int[] v ); // 

		private static WindowPos3ivDelegate _WindowPos3iv;

		public static  void WindowPos3iv( int[] v )
		{
			if (_WindowPos3iv == null) throw new Exception( "Extension method WindowPos3iv not found" );
		 _WindowPos3iv( v );
		}
		public delegate void WindowPos3sDelegate( short x, short y, short z ); // 

		private static WindowPos3sDelegate _WindowPos3s;

		public static  void WindowPos3s( short x, short y, short z )
		{
			if (_WindowPos3s == null) throw new Exception( "Extension method WindowPos3s not found" );
		 _WindowPos3s( x, y, z );
		}
		public delegate void WindowPos3svDelegate( short[] v ); // 

		private static WindowPos3svDelegate _WindowPos3sv;

		public static  void WindowPos3sv( short[] v )
		{
			if (_WindowPos3sv == null) throw new Exception( "Extension method WindowPos3sv not found" );
		 _WindowPos3sv( v );
		}
	}
}
