using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_separate_stencilInit()
		{
			_StencilOpSeparateATI = GetProcAdress< StencilOpSeparateATIDelegate >( "glStencilOpSeparateATI" );
			_StencilFuncSeparateATI = GetProcAdress< StencilFuncSeparateATIDelegate >( "glStencilFuncSeparateATI" );
		}


		public delegate void StencilOpSeparateATIDelegate( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass ); //  extension method

		private static StencilOpSeparateATIDelegate _StencilOpSeparateATI;

		public static  void StencilOpSeparateATI( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass )
		{
			if (_StencilOpSeparateATI == null) throw new Exception( "Extension method StencilOpSeparateATI not found" );
		 _StencilOpSeparateATI( face, sfail, dpfail, dppass );
		}
		public delegate void StencilFuncSeparateATIDelegate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask ); //  extension method

		private static StencilFuncSeparateATIDelegate _StencilFuncSeparateATI;

		public static  void StencilFuncSeparateATI( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask )
		{
			if (_StencilFuncSeparateATI == null) throw new Exception( "Extension method StencilFuncSeparateATI not found" );
		 _StencilFuncSeparateATI( frontfunc, backfunc, @ref, mask );
		}
	}
}
