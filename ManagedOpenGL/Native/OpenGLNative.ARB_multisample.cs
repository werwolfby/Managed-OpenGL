using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_multisampleInit()
		{
			_SampleCoverageARB = GetProcAdress< SampleCoverageARBDelegate >( "glSampleCoverageARB" );
			
		}
		
	
		public delegate void SampleCoverageARBDelegate( float value, bool invert ); // 
		private static SampleCoverageARBDelegate _SampleCoverageARB;
		
		public static  void SampleCoverageARB( float value, bool invert )
		{
			if (_SampleCoverageARB == null) throw new Exception( "Extension method SampleCoverageARB not found" );
			 _SampleCoverageARB( value, invert );
		}
	}
}

