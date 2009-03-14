using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_stencil_two_sideInit()
		{
			_ActiveStencilFaceEXT = GetProcAdress< ActiveStencilFaceEXTDelegate >( "glActiveStencilFaceEXT" );
		}


		public delegate void ActiveStencilFaceEXTDelegate( uint face ); // 

		private static ActiveStencilFaceEXTDelegate _ActiveStencilFaceEXT;

		public static  void ActiveStencilFaceEXT( uint face )
		{
			if (_ActiveStencilFaceEXT == null) throw new Exception( "Extension method ActiveStencilFaceEXT not found" );
		 _ActiveStencilFaceEXT( face );
		}
	}
}
