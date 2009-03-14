using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_framebuffer_multisampleInit()
		{
			_RenderbufferStorageMultisampleEXT = GetProcAdress< RenderbufferStorageMultisampleEXTDelegate >( "glRenderbufferStorageMultisampleEXT" );
		}


		public delegate void RenderbufferStorageMultisampleEXTDelegate( uint target, int samples, uint internalformat, int width, int height ); // 

		private static RenderbufferStorageMultisampleEXTDelegate _RenderbufferStorageMultisampleEXT;

		public static  void RenderbufferStorageMultisampleEXT( uint target, int samples, uint internalformat, int width, int height )
		{
			if (_RenderbufferStorageMultisampleEXT == null) throw new Exception( "Extension method RenderbufferStorageMultisampleEXT not found" );
		 _RenderbufferStorageMultisampleEXT( target, samples, internalformat, width, height );
		}
	}
}
