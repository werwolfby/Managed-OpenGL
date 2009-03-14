using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_pixel_data_rangeInit()
		{
			_PixelDataRangeNV = GetProcAdress< PixelDataRangeNVDelegate >( "glPixelDataRangeNV" );
			_FlushPixelDataRangeNV = GetProcAdress< FlushPixelDataRangeNVDelegate >( "glFlushPixelDataRangeNV" );
		}


		public unsafe delegate void PixelDataRangeNVDelegate( uint target, int length, [Out]void* pointer ); //  extension method

		private static PixelDataRangeNVDelegate _PixelDataRangeNV;

		public static unsafe  void PixelDataRangeNV( uint target, int length, [Out]void* pointer )
		{
			if (_PixelDataRangeNV == null) throw new Exception( "Extension method PixelDataRangeNV not found" );
		 _PixelDataRangeNV( target, length, pointer );
		}
		public delegate void FlushPixelDataRangeNVDelegate( uint target ); //  extension method

		private static FlushPixelDataRangeNVDelegate _FlushPixelDataRangeNV;

		public static  void FlushPixelDataRangeNV( uint target )
		{
			if (_FlushPixelDataRangeNV == null) throw new Exception( "Extension method FlushPixelDataRangeNV not found" );
		 _FlushPixelDataRangeNV( target );
		}
	}
}
