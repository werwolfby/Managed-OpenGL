using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_point_parametersInit()
		{
			_PointParameterfEXT = GetProcAdress< PointParameterfEXTDelegate >( "glPointParameterfEXT" );
			_PointParameterfvEXT = GetProcAdress< PointParameterfvEXTDelegate >( "glPointParameterfvEXT" );
		}


		public delegate void PointParameterfEXTDelegate( uint pname, float param ); //  extension method

		private static PointParameterfEXTDelegate _PointParameterfEXT;

		public static  void PointParameterfEXT( uint pname, float param )
		{
			if (_PointParameterfEXT == null) throw new Exception( "Extension method PointParameterfEXT not found" );
		 _PointParameterfEXT( pname, param );
		}
		public delegate void PointParameterfvEXTDelegate( uint pname, float[] @params ); //  extension method

		private static PointParameterfvEXTDelegate _PointParameterfvEXT;

		public static  void PointParameterfvEXT( uint pname, float[] @params )
		{
			if (_PointParameterfvEXT == null) throw new Exception( "Extension method PointParameterfvEXT not found" );
		 _PointParameterfvEXT( pname, @params );
		}
	}
}
