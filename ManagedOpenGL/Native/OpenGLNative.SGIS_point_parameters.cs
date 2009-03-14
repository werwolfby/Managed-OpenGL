using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_point_parametersInit()
		{
			_PointParameterfSGIS = GetProcAdress< PointParameterfSGISDelegate >( "glPointParameterfSGIS" );
			_PointParameterfvSGIS = GetProcAdress< PointParameterfvSGISDelegate >( "glPointParameterfvSGIS" );
		}


		public delegate void PointParameterfSGISDelegate( uint pname, float param ); //  extension method

		private static PointParameterfSGISDelegate _PointParameterfSGIS;

		public static  void PointParameterfSGIS( uint pname, float param )
		{
			if (_PointParameterfSGIS == null) throw new Exception( "Extension method PointParameterfSGIS not found" );
		 _PointParameterfSGIS( pname, param );
		}
		public delegate void PointParameterfvSGISDelegate( uint pname, float[] @params ); //  extension method

		private static PointParameterfvSGISDelegate _PointParameterfvSGIS;

		public static  void PointParameterfvSGIS( uint pname, float[] @params )
		{
			if (_PointParameterfvSGIS == null) throw new Exception( "Extension method PointParameterfvSGIS not found" );
		 _PointParameterfvSGIS( pname, @params );
		}
	}
}
