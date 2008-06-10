using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_multisampleInit()
		{
			_SampleMaskEXT = GetProcAdress< SampleMaskEXTDelegate >( "glSampleMaskEXT" );
			_SamplePatternEXT = GetProcAdress< SamplePatternEXTDelegate >( "glSamplePatternEXT" );
			
		}
		
	
		public delegate void SampleMaskEXTDelegate( float value, bool invert ); //  extension method
		private static SampleMaskEXTDelegate _SampleMaskEXT;
		
		public static  void SampleMaskEXT( float value, bool invert )
		{
			if (_SampleMaskEXT == null) throw new Exception( "Extension method SampleMaskEXT not found" );
			 _SampleMaskEXT( value, invert );
		}
		public delegate void SamplePatternEXTDelegate( uint pattern ); //  extension method
		private static SamplePatternEXTDelegate _SamplePatternEXT;
		
		public static  void SamplePatternEXT( uint pattern )
		{
			if (_SamplePatternEXT == null) throw new Exception( "Extension method SamplePatternEXT not found" );
			 _SamplePatternEXT( pattern );
		}
	}
}

