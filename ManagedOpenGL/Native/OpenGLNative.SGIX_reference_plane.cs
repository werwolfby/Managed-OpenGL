using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_reference_planeInit()
		{
			_ReferencePlaneSGIX = GetProcAdress< ReferencePlaneSGIXDelegate >( "glReferencePlaneSGIX" );
		}


		public delegate void ReferencePlaneSGIXDelegate( double[] equation ); //  extension method

		private static ReferencePlaneSGIXDelegate _ReferencePlaneSGIX;

		public static  void ReferencePlaneSGIX( double[] equation )
		{
			if (_ReferencePlaneSGIX == null) throw new Exception( "Extension method ReferencePlaneSGIX not found" );
		 _ReferencePlaneSGIX( equation );
		}
	}
}
