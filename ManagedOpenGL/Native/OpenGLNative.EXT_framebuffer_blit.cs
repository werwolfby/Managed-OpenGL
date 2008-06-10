using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_framebuffer_blitInit()
		{
			_BlitFramebufferEXT = GetProcAdress< BlitFramebufferEXTDelegate >( "glBlitFramebufferEXT" );
			
		}
		
	
		public delegate void BlitFramebufferEXTDelegate( int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter ); // 
		private static BlitFramebufferEXTDelegate _BlitFramebufferEXT;
		
		public static  void BlitFramebufferEXT( int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter )
		{
			if (_BlitFramebufferEXT == null) throw new Exception( "Extension method BlitFramebufferEXT not found" );
			 _BlitFramebufferEXT( srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter );
		}
	}
}

