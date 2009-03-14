using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_framebuffer_multisample_coverageInit()
		{
			_RenderbufferStorageMultisampleCoverageNV = GetProcAdress< RenderbufferStorageMultisampleCoverageNVDelegate >( "glRenderbufferStorageMultisampleCoverageNV" );
		}


		public delegate void RenderbufferStorageMultisampleCoverageNVDelegate( uint target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height ); //  extension method

		private static RenderbufferStorageMultisampleCoverageNVDelegate _RenderbufferStorageMultisampleCoverageNV;

		public static  void RenderbufferStorageMultisampleCoverageNV( uint target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height )
		{
			if (_RenderbufferStorageMultisampleCoverageNV == null) throw new Exception( "Extension method RenderbufferStorageMultisampleCoverageNV not found" );
		 _RenderbufferStorageMultisampleCoverageNV( target, coverageSamples, colorSamples, internalformat, width, height );
		}
	}
}
