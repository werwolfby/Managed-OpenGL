using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_blend_minmaxInit()
		{
			_BlendEquationEXT = GetProcAdress< BlendEquationEXTDelegate >( "glBlendEquationEXT" );
			
		}
		
	
		public delegate void BlendEquationEXTDelegate( BlendEquationModeEXT mode ); //  extension method
		private static BlendEquationEXTDelegate _BlendEquationEXT;
		
		public static  void BlendEquationEXT( BlendEquationModeEXT mode )
		{
			if (_BlendEquationEXT == null) throw new Exception( "Extension method BlendEquationEXT not found" );
			 _BlendEquationEXT( mode );
		}
	}
}

