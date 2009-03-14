using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeGREMEDY_frame_terminatorInit()
		{
			_FrameTerminatorGREMEDY = GetProcAdress< FrameTerminatorGREMEDYDelegate >( "glFrameTerminatorGREMEDY" );
		}


		public delegate void FrameTerminatorGREMEDYDelegate(  ); //  extension method

		private static FrameTerminatorGREMEDYDelegate _FrameTerminatorGREMEDY;

		public static  void FrameTerminatorGREMEDY(  )
		{
			if (_FrameTerminatorGREMEDY == null) throw new Exception( "Extension method FrameTerminatorGREMEDY not found" );
		 _FrameTerminatorGREMEDY(  );
		}
	}
}
