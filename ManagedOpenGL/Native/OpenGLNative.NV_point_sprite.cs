using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_point_spriteInit()
		{
			_PointParameteriNV = GetProcAdress< PointParameteriNVDelegate >( "glPointParameteriNV" );
			_PointParameterivNV = GetProcAdress< PointParameterivNVDelegate >( "glPointParameterivNV" );
			
		}
		
	
		public delegate void PointParameteriNVDelegate( uint pname, int param ); //  extension method
		private static PointParameteriNVDelegate _PointParameteriNV;
		
		public static  void PointParameteriNV( uint pname, int param )
		{
			if (_PointParameteriNV == null) throw new Exception( "Extension method PointParameteriNV not found" );
			 _PointParameteriNV( pname, param );
		}
		public delegate void PointParameterivNVDelegate( uint pname, int[] @params ); //  extension method
		private static PointParameterivNVDelegate _PointParameterivNV;
		
		public static  void PointParameterivNV( uint pname, int[] @params )
		{
			if (_PointParameterivNV == null) throw new Exception( "Extension method PointParameterivNV not found" );
			 _PointParameterivNV( pname, @params );
		}
	}
}

