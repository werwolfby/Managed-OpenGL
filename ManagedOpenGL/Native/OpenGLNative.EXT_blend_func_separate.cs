using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_blend_func_separateInit()
		{
			_BlendFuncSeparateEXT = GetProcAdress< BlendFuncSeparateEXTDelegate >( "glBlendFuncSeparateEXT" );
			
		}
		
	
		public delegate void BlendFuncSeparateEXTDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method
		private static BlendFuncSeparateEXTDelegate _BlendFuncSeparateEXT;
		
		public static  void BlendFuncSeparateEXT( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha )
		{
			if (_BlendFuncSeparateEXT == null) throw new Exception( "Extension method BlendFuncSeparateEXT not found" );
			 _BlendFuncSeparateEXT( sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha );
		}
	}
}

