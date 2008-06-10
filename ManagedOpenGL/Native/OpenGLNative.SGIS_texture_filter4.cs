using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_texture_filter4Init()
		{
			_GetTexFilterFuncSGIS = GetProcAdress< GetTexFilterFuncSGISDelegate >( "glGetTexFilterFuncSGIS" );
			_TexFilterFuncSGIS = GetProcAdress< TexFilterFuncSGISDelegate >( "glTexFilterFuncSGIS" );
			
		}
		
	
		public delegate void GetTexFilterFuncSGISDelegate( TextureTarget target, uint filter, [Out]float[] weights ); //  extension method
		private static GetTexFilterFuncSGISDelegate _GetTexFilterFuncSGIS;
		
		public static  void GetTexFilterFuncSGIS( TextureTarget target, uint filter, [Out]float[] weights )
		{
			if (_GetTexFilterFuncSGIS == null) throw new Exception( "Extension method GetTexFilterFuncSGIS not found" );
			 _GetTexFilterFuncSGIS( target, filter, weights );
		}
		public delegate void TexFilterFuncSGISDelegate( TextureTarget target, uint filter, int n, float[] weights ); //  extension method
		private static TexFilterFuncSGISDelegate _TexFilterFuncSGIS;
		
		public static  void TexFilterFuncSGIS( TextureTarget target, uint filter, int n, float[] weights )
		{
			if (_TexFilterFuncSGIS == null) throw new Exception( "Extension method TexFilterFuncSGIS not found" );
			 _TexFilterFuncSGIS( target, filter, n, weights );
		}
	}
}

