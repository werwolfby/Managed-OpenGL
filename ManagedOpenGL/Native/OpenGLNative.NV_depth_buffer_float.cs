using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_depth_buffer_floatInit()
		{
			_DepthRangedNV = GetProcAdress< DepthRangedNVDelegate >( "glDepthRangedNV" );
			_ClearDepthdNV = GetProcAdress< ClearDepthdNVDelegate >( "glClearDepthdNV" );
			_DepthBoundsdNV = GetProcAdress< DepthBoundsdNVDelegate >( "glDepthBoundsdNV" );
			
		}
		
	
		public delegate void DepthRangedNVDelegate( double zNear, double zFar ); //  extension method
		private static DepthRangedNVDelegate _DepthRangedNV;
		
		public static  void DepthRangedNV( double zNear, double zFar )
		{
			if (_DepthRangedNV == null) throw new Exception( "Extension method DepthRangedNV not found" );
			 _DepthRangedNV( zNear, zFar );
		}
		public delegate void ClearDepthdNVDelegate( double depth ); //  extension method
		private static ClearDepthdNVDelegate _ClearDepthdNV;
		
		public static  void ClearDepthdNV( double depth )
		{
			if (_ClearDepthdNV == null) throw new Exception( "Extension method ClearDepthdNV not found" );
			 _ClearDepthdNV( depth );
		}
		public delegate void DepthBoundsdNVDelegate( double zmin, double zmax ); //  extension method
		private static DepthBoundsdNVDelegate _DepthBoundsdNV;
		
		public static  void DepthBoundsdNV( double zmin, double zmax )
		{
			if (_DepthBoundsdNV == null) throw new Exception( "Extension method DepthBoundsdNV not found" );
			 _DepthBoundsdNV( zmin, zmax );
		}
	}
}

