using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeINGR_blend_func_separateInit()
		{
			_BlendFuncSeparateINGR = GetProcAdress< BlendFuncSeparateINGRDelegate >( "glBlendFuncSeparateINGR" );
		}


		public delegate void BlendFuncSeparateINGRDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method

		private static BlendFuncSeparateINGRDelegate _BlendFuncSeparateINGR;

		public static  void BlendFuncSeparateINGR( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha )
		{
			if (_BlendFuncSeparateINGR == null) throw new Exception( "Extension method BlendFuncSeparateINGR not found" );
		 _BlendFuncSeparateINGR( sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha );
		}
	}
}
