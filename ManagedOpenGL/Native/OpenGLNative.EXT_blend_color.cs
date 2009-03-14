using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_blend_colorInit()
		{
			_BlendColorEXT = GetProcAdress< BlendColorEXTDelegate >( "glBlendColorEXT" );
		}


		public delegate void BlendColorEXTDelegate( float red, float green, float blue, float alpha ); //  extension method

		private static BlendColorEXTDelegate _BlendColorEXT;

		public static  void BlendColorEXT( float red, float green, float blue, float alpha )
		{
			if (_BlendColorEXT == null) throw new Exception( "Extension method BlendColorEXT not found" );
		 _BlendColorEXT( red, green, blue, alpha );
		}
	}
}
