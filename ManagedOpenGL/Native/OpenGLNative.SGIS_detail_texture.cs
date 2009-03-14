using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_detail_textureInit()
		{
			_DetailTexFuncSGIS = GetProcAdress< DetailTexFuncSGISDelegate >( "glDetailTexFuncSGIS" );
			_GetDetailTexFuncSGIS = GetProcAdress< GetDetailTexFuncSGISDelegate >( "glGetDetailTexFuncSGIS" );
		}


		public delegate void DetailTexFuncSGISDelegate( TextureTarget target, int n, float[] points ); //  extension method

		private static DetailTexFuncSGISDelegate _DetailTexFuncSGIS;

		public static  void DetailTexFuncSGIS( TextureTarget target, int n, float[] points )
		{
			if (_DetailTexFuncSGIS == null) throw new Exception( "Extension method DetailTexFuncSGIS not found" );
		 _DetailTexFuncSGIS( target, n, points );
		}
		public delegate void GetDetailTexFuncSGISDelegate( TextureTarget target, [Out]float[] points ); //  extension method

		private static GetDetailTexFuncSGISDelegate _GetDetailTexFuncSGIS;

		public static  void GetDetailTexFuncSGIS( TextureTarget target, [Out]float[] points )
		{
			if (_GetDetailTexFuncSGIS == null) throw new Exception( "Extension method GetDetailTexFuncSGIS not found" );
		 _GetDetailTexFuncSGIS( target, points );
		}
	}
}
