using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_sharpen_textureInit()
		{
			_SharpenTexFuncSGIS = GetProcAdress< SharpenTexFuncSGISDelegate >( "glSharpenTexFuncSGIS" );
			_GetSharpenTexFuncSGIS = GetProcAdress< GetSharpenTexFuncSGISDelegate >( "glGetSharpenTexFuncSGIS" );
			
		}
		
	
		public delegate void SharpenTexFuncSGISDelegate( TextureTarget target, int n, float[] points ); //  extension method
		private static SharpenTexFuncSGISDelegate _SharpenTexFuncSGIS;
		
		public static  void SharpenTexFuncSGIS( TextureTarget target, int n, float[] points )
		{
			if (_SharpenTexFuncSGIS == null) throw new Exception( "Extension method SharpenTexFuncSGIS not found" );
			 _SharpenTexFuncSGIS( target, n, points );
		}
		public delegate void GetSharpenTexFuncSGISDelegate( TextureTarget target, [Out]float[] points ); //  extension method
		private static GetSharpenTexFuncSGISDelegate _GetSharpenTexFuncSGIS;
		
		public static  void GetSharpenTexFuncSGIS( TextureTarget target, [Out]float[] points )
		{
			if (_GetSharpenTexFuncSGIS == null) throw new Exception( "Extension method GetSharpenTexFuncSGIS not found" );
			 _GetSharpenTexFuncSGIS( target, points );
		}
	}
}

