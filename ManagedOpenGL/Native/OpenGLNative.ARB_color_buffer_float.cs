using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_color_buffer_floatInit()
		{
			_ClampColorARB = GetProcAdress< ClampColorARBDelegate >( "glClampColorARB" );
		}


		public delegate void ClampColorARBDelegate( uint target, uint clamp ); //  extension method

		private static ClampColorARBDelegate _ClampColorARB;

		public static  void ClampColorARB( uint target, uint clamp )
		{
			if (_ClampColorARB == null) throw new Exception( "Extension method ClampColorARB not found" );
		 _ClampColorARB( target, clamp );
		}
	}
}
