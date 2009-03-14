using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_cull_vertexInit()
		{
			_CullParameterdvEXT = GetProcAdress< CullParameterdvEXTDelegate >( "glCullParameterdvEXT" );
			_CullParameterfvEXT = GetProcAdress< CullParameterfvEXTDelegate >( "glCullParameterfvEXT" );
		}


		public delegate void CullParameterdvEXTDelegate( uint pname, [Out]double[] @params ); //  extension method

		private static CullParameterdvEXTDelegate _CullParameterdvEXT;

		public static  void CullParameterdvEXT( uint pname, [Out]double[] @params )
		{
			if (_CullParameterdvEXT == null) throw new Exception( "Extension method CullParameterdvEXT not found" );
		 _CullParameterdvEXT( pname, @params );
		}
		public delegate void CullParameterfvEXTDelegate( uint pname, [Out]float[] @params ); //  extension method

		private static CullParameterfvEXTDelegate _CullParameterfvEXT;

		public static  void CullParameterfvEXT( uint pname, [Out]float[] @params )
		{
			if (_CullParameterfvEXT == null) throw new Exception( "Extension method CullParameterfvEXT not found" );
		 _CullParameterfvEXT( pname, @params );
		}
	}
}
