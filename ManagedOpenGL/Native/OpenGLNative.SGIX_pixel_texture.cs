using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_pixel_textureInit()
		{
			_PixelTexGenSGIX = GetProcAdress< PixelTexGenSGIXDelegate >( "glPixelTexGenSGIX" );
		}


		public delegate void PixelTexGenSGIXDelegate( uint mode ); //  extension method

		private static PixelTexGenSGIXDelegate _PixelTexGenSGIX;

		public static  void PixelTexGenSGIX( uint mode )
		{
			if (_PixelTexGenSGIX == null) throw new Exception( "Extension method PixelTexGenSGIX not found" );
		 _PixelTexGenSGIX( mode );
		}
	}
}
