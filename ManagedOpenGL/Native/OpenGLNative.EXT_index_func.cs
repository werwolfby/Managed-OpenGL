using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_index_funcInit()
		{
			_IndexFuncEXT = GetProcAdress< IndexFuncEXTDelegate >( "glIndexFuncEXT" );
			
		}
		
	
		public delegate void IndexFuncEXTDelegate( uint func, float @ref ); //  extension method
		private static IndexFuncEXTDelegate _IndexFuncEXT;
		
		public static  void IndexFuncEXT( uint func, float @ref )
		{
			if (_IndexFuncEXT == null) throw new Exception( "Extension method IndexFuncEXT not found" );
			 _IndexFuncEXT( func, @ref );
		}
	}
}

