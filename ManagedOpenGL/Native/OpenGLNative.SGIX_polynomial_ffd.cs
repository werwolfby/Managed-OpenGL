using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_polynomial_ffdInit()
		{
			_DeformationMap3dSGIX = GetProcAdress< DeformationMap3dSGIXDelegate >( "glDeformationMap3dSGIX" );
			_DeformationMap3fSGIX = GetProcAdress< DeformationMap3fSGIXDelegate >( "glDeformationMap3fSGIX" );
			_DeformSGIX = GetProcAdress< DeformSGIXDelegate >( "glDeformSGIX" );
			_LoadIdentityDeformationMapSGIX = GetProcAdress< LoadIdentityDeformationMapSGIXDelegate >( "glLoadIdentityDeformationMapSGIX" );
		}


		public delegate void DeformationMap3dSGIXDelegate( FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points ); //  extension method

		private static DeformationMap3dSGIXDelegate _DeformationMap3dSGIX;

		public static  void DeformationMap3dSGIX( FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points )
		{
			if (_DeformationMap3dSGIX == null) throw new Exception( "Extension method DeformationMap3dSGIX not found" );
		 _DeformationMap3dSGIX( target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points );
		}
		public delegate void DeformationMap3fSGIXDelegate( FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points ); //  extension method

		private static DeformationMap3fSGIXDelegate _DeformationMap3fSGIX;

		public static  void DeformationMap3fSGIX( FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points )
		{
			if (_DeformationMap3fSGIX == null) throw new Exception( "Extension method DeformationMap3fSGIX not found" );
		 _DeformationMap3fSGIX( target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points );
		}
		public delegate void DeformSGIXDelegate( FfdMaskSGIX mask ); //  extension method

		private static DeformSGIXDelegate _DeformSGIX;

		public static  void DeformSGIX( FfdMaskSGIX mask )
		{
			if (_DeformSGIX == null) throw new Exception( "Extension method DeformSGIX not found" );
		 _DeformSGIX( mask );
		}
		public delegate void LoadIdentityDeformationMapSGIXDelegate( FfdMaskSGIX mask ); //  extension method

		private static LoadIdentityDeformationMapSGIXDelegate _LoadIdentityDeformationMapSGIX;

		public static  void LoadIdentityDeformationMapSGIX( FfdMaskSGIX mask )
		{
			if (_LoadIdentityDeformationMapSGIX == null) throw new Exception( "Extension method LoadIdentityDeformationMapSGIX not found" );
		 _LoadIdentityDeformationMapSGIX( mask );
		}
	}
}
