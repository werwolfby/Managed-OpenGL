using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNative3DFX_tbufferInit()
		{
			_TbufferMask3DFX = GetProcAdress< TbufferMask3DFXDelegate >( "glTbufferMask3DFX" );
		}


		public delegate void TbufferMask3DFXDelegate( uint mask ); // 

		private static TbufferMask3DFXDelegate _TbufferMask3DFX;

		public static  void TbufferMask3DFX( uint mask )
		{
			if (_TbufferMask3DFX == null) throw new Exception( "Extension method TbufferMask3DFX not found" );
		 _TbufferMask3DFX( mask );
		}
	}
}
