using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_blend_equation_separateInit()
		{
			_BlendEquationSeparateEXT = GetProcAdress< BlendEquationSeparateEXTDelegate >( "glBlendEquationSeparateEXT" );
			
		}
		
	
		public delegate void BlendEquationSeparateEXTDelegate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha ); //  extension method
		private static BlendEquationSeparateEXTDelegate _BlendEquationSeparateEXT;
		
		public static  void BlendEquationSeparateEXT( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha )
		{
			if (_BlendEquationSeparateEXT == null) throw new Exception( "Extension method BlendEquationSeparateEXT not found" );
			 _BlendEquationSeparateEXT( modeRGB, modeAlpha );
		}
	}
}

