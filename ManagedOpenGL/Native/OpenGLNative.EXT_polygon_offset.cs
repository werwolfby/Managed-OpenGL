using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_polygon_offsetInit()
		{
			_PolygonOffsetEXT = GetProcAdress< PolygonOffsetEXTDelegate >( "glPolygonOffsetEXT" );
		}


		public delegate void PolygonOffsetEXTDelegate( float factor, float bias ); //  extension method

		private static PolygonOffsetEXTDelegate _PolygonOffsetEXT;

		public static  void PolygonOffsetEXT( float factor, float bias )
		{
			if (_PolygonOffsetEXT == null) throw new Exception( "Extension method PolygonOffsetEXT not found" );
		 _PolygonOffsetEXT( factor, bias );
		}
	}
}
