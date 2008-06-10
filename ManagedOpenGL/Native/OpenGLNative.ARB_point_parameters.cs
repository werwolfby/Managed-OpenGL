using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_point_parametersInit()
		{
			_PointParameterfARB = GetProcAdress< PointParameterfARBDelegate >( "glPointParameterfARB" );
			_PointParameterfvARB = GetProcAdress< PointParameterfvARBDelegate >( "glPointParameterfvARB" );
			
		}
		
	
		public delegate void PointParameterfARBDelegate( uint pname, float param ); //  extension method
		private static PointParameterfARBDelegate _PointParameterfARB;
		
		public static  void PointParameterfARB( uint pname, float param )
		{
			if (_PointParameterfARB == null) throw new Exception( "Extension method PointParameterfARB not found" );
			 _PointParameterfARB( pname, param );
		}
		public delegate void PointParameterfvARBDelegate( uint pname, float[] @params ); //  extension method
		private static PointParameterfvARBDelegate _PointParameterfvARB;
		
		public static  void PointParameterfvARB( uint pname, float[] @params )
		{
			if (_PointParameterfvARB == null) throw new Exception( "Extension method PointParameterfvARB not found" );
			 _PointParameterfvARB( pname, @params );
		}
	}
}

