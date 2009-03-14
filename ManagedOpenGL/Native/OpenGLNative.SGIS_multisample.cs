using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIS_multisampleInit()
		{
			_SampleMaskSGIS = GetProcAdress< SampleMaskSGISDelegate >( "glSampleMaskSGIS" );
			_SamplePatternSGIS = GetProcAdress< SamplePatternSGISDelegate >( "glSamplePatternSGIS" );
		}


		public delegate void SampleMaskSGISDelegate( float value, bool invert ); //  extension method

		private static SampleMaskSGISDelegate _SampleMaskSGIS;

		public static  void SampleMaskSGIS( float value, bool invert )
		{
			if (_SampleMaskSGIS == null) throw new Exception( "Extension method SampleMaskSGIS not found" );
		 _SampleMaskSGIS( value, invert );
		}
		public delegate void SamplePatternSGISDelegate( SamplePatternSGIS pattern ); //  extension method

		private static SamplePatternSGISDelegate _SamplePatternSGIS;

		public static  void SamplePatternSGIS( SamplePatternSGIS pattern )
		{
			if (_SamplePatternSGIS == null) throw new Exception( "Extension method SamplePatternSGIS not found" );
		 _SamplePatternSGIS( pattern );
		}
	}
}
