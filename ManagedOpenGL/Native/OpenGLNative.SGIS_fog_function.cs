using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_fog_functionInit()
		{
			_FogFuncSGIS = GetProcAdress< FogFuncSGISDelegate >( "glFogFuncSGIS" );
			_GetFogFuncSGIS = GetProcAdress< GetFogFuncSGISDelegate >( "glGetFogFuncSGIS" );
			
		}
		
	
		public delegate void FogFuncSGISDelegate( int n, float[] points ); //  extension method
		private static FogFuncSGISDelegate _FogFuncSGIS;
		
		public static  void FogFuncSGIS( int n, float[] points )
		{
			if (_FogFuncSGIS == null) throw new Exception( "Extension method FogFuncSGIS not found" );
			 _FogFuncSGIS( n, points );
		}
		public delegate void GetFogFuncSGISDelegate( [Out]float[] points ); //  extension method
		private static GetFogFuncSGISDelegate _GetFogFuncSGIS;
		
		public static  void GetFogFuncSGIS( [Out]float[] points )
		{
			if (_GetFogFuncSGIS == null) throw new Exception( "Extension method GetFogFuncSGIS not found" );
			 _GetFogFuncSGIS( points );
		}
	}
}

