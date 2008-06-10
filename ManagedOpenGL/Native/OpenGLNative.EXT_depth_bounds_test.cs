using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_depth_bounds_testInit()
		{
			_DepthBoundsEXT = GetProcAdress< DepthBoundsEXTDelegate >( "glDepthBoundsEXT" );
			
		}
		
	
		public delegate void DepthBoundsEXTDelegate( double zmin, double zmax ); //  extension method
		private static DepthBoundsEXTDelegate _DepthBoundsEXT;
		
		public static  void DepthBoundsEXT( double zmin, double zmax )
		{
			if (_DepthBoundsEXT == null) throw new Exception( "Extension method DepthBoundsEXT not found" );
			 _DepthBoundsEXT( zmin, zmax );
		}
	}
}

