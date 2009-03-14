using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_igloo_interfaceInit()
		{
			_IglooInterfaceSGIX = GetProcAdress< IglooInterfaceSGIXDelegate >( "glIglooInterfaceSGIX" );
		}


		public unsafe delegate void IglooInterfaceSGIXDelegate( uint pname, void* @params ); //  extension method

		private static IglooInterfaceSGIXDelegate _IglooInterfaceSGIX;

		public static unsafe  void IglooInterfaceSGIX( uint pname, void* @params )
		{
			if (_IglooInterfaceSGIX == null) throw new Exception( "Extension method IglooInterfaceSGIX not found" );
		 _IglooInterfaceSGIX( pname, @params );
		}
	}
}
