using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_stencil_clear_tagInit()
		{
			_StencilClearTagEXT = GetProcAdress< StencilClearTagEXTDelegate >( "glStencilClearTagEXT" );
		}


		public delegate void StencilClearTagEXTDelegate( int stencilTagBits, uint stencilClearTag ); //  extension method

		private static StencilClearTagEXTDelegate _StencilClearTagEXT;

		public static  void StencilClearTagEXT( int stencilTagBits, uint stencilClearTag )
		{
			if (_StencilClearTagEXT == null) throw new Exception( "Extension method StencilClearTagEXT not found" );
		 _StencilClearTagEXT( stencilTagBits, stencilClearTag );
		}
	}
}
