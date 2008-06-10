using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_tag_sample_bufferInit()
		{
			_TagSampleBufferSGIX = GetProcAdress< TagSampleBufferSGIXDelegate >( "glTagSampleBufferSGIX" );
			
		}
		
	
		public delegate void TagSampleBufferSGIXDelegate(  ); //  extension method
		private static TagSampleBufferSGIXDelegate _TagSampleBufferSGIX;
		
		public static  void TagSampleBufferSGIX(  )
		{
			if (_TagSampleBufferSGIX == null) throw new Exception( "Extension method TagSampleBufferSGIX not found" );
			 _TagSampleBufferSGIX(  );
		}
	}
}

