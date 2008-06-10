using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_texture_buffer_objectInit()
		{
			_TexBufferEXT = GetProcAdress< TexBufferEXTDelegate >( "glTexBufferEXT" );
			
		}
		
	
		public delegate void TexBufferEXTDelegate( TextureTarget target, uint internalformat, uint buffer ); //  extension method
		private static TexBufferEXTDelegate _TexBufferEXT;
		
		public static  void TexBufferEXT( TextureTarget target, uint internalformat, uint buffer )
		{
			if (_TexBufferEXT == null) throw new Exception( "Extension method TexBufferEXT not found" );
			 _TexBufferEXT( target, internalformat, buffer );
		}
	}
}

