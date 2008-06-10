using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_pixel_textureInit()
		{
			_PixelTexGenParameteriSGIS = GetProcAdress< PixelTexGenParameteriSGISDelegate >( "glPixelTexGenParameteriSGIS" );
			_PixelTexGenParameterivSGIS = GetProcAdress< PixelTexGenParameterivSGISDelegate >( "glPixelTexGenParameterivSGIS" );
			_PixelTexGenParameterfSGIS = GetProcAdress< PixelTexGenParameterfSGISDelegate >( "glPixelTexGenParameterfSGIS" );
			_PixelTexGenParameterfvSGIS = GetProcAdress< PixelTexGenParameterfvSGISDelegate >( "glPixelTexGenParameterfvSGIS" );
			_GetPixelTexGenParameterivSGIS = GetProcAdress< GetPixelTexGenParameterivSGISDelegate >( "glGetPixelTexGenParameterivSGIS" );
			_GetPixelTexGenParameterfvSGIS = GetProcAdress< GetPixelTexGenParameterfvSGISDelegate >( "glGetPixelTexGenParameterfvSGIS" );
			
		}
		
	
		public delegate void PixelTexGenParameteriSGISDelegate( PixelTexGenParameterNameSGIS pname, int param ); //  extension method
		private static PixelTexGenParameteriSGISDelegate _PixelTexGenParameteriSGIS;
		
		public static  void PixelTexGenParameteriSGIS( PixelTexGenParameterNameSGIS pname, int param )
		{
			if (_PixelTexGenParameteriSGIS == null) throw new Exception( "Extension method PixelTexGenParameteriSGIS not found" );
			 _PixelTexGenParameteriSGIS( pname, param );
		}
		public delegate void PixelTexGenParameterivSGISDelegate( PixelTexGenParameterNameSGIS pname, int[] @params ); //  extension method
		private static PixelTexGenParameterivSGISDelegate _PixelTexGenParameterivSGIS;
		
		public static  void PixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, int[] @params )
		{
			if (_PixelTexGenParameterivSGIS == null) throw new Exception( "Extension method PixelTexGenParameterivSGIS not found" );
			 _PixelTexGenParameterivSGIS( pname, @params );
		}
		public delegate void PixelTexGenParameterfSGISDelegate( PixelTexGenParameterNameSGIS pname, float param ); //  extension method
		private static PixelTexGenParameterfSGISDelegate _PixelTexGenParameterfSGIS;
		
		public static  void PixelTexGenParameterfSGIS( PixelTexGenParameterNameSGIS pname, float param )
		{
			if (_PixelTexGenParameterfSGIS == null) throw new Exception( "Extension method PixelTexGenParameterfSGIS not found" );
			 _PixelTexGenParameterfSGIS( pname, param );
		}
		public delegate void PixelTexGenParameterfvSGISDelegate( PixelTexGenParameterNameSGIS pname, float[] @params ); //  extension method
		private static PixelTexGenParameterfvSGISDelegate _PixelTexGenParameterfvSGIS;
		
		public static  void PixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, float[] @params )
		{
			if (_PixelTexGenParameterfvSGIS == null) throw new Exception( "Extension method PixelTexGenParameterfvSGIS not found" );
			 _PixelTexGenParameterfvSGIS( pname, @params );
		}
		public delegate void GetPixelTexGenParameterivSGISDelegate( PixelTexGenParameterNameSGIS pname, [Out]int[] @params ); //  extension method
		private static GetPixelTexGenParameterivSGISDelegate _GetPixelTexGenParameterivSGIS;
		
		public static  void GetPixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, [Out]int[] @params )
		{
			if (_GetPixelTexGenParameterivSGIS == null) throw new Exception( "Extension method GetPixelTexGenParameterivSGIS not found" );
			 _GetPixelTexGenParameterivSGIS( pname, @params );
		}
		public delegate void GetPixelTexGenParameterfvSGISDelegate( PixelTexGenParameterNameSGIS pname, [Out]float[] @params ); //  extension method
		private static GetPixelTexGenParameterfvSGISDelegate _GetPixelTexGenParameterfvSGIS;
		
		public static  void GetPixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, [Out]float[] @params )
		{
			if (_GetPixelTexGenParameterfvSGIS == null) throw new Exception( "Extension method GetPixelTexGenParameterfvSGIS not found" );
			 _GetPixelTexGenParameterfvSGIS( pname, @params );
		}
	}
}

