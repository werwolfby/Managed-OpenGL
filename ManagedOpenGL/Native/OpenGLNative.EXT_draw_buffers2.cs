using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_draw_buffers2Init()
		{
			_ColorMaskIndexedEXT = GetProcAdress< ColorMaskIndexedEXTDelegate >( "glColorMaskIndexedEXT" );
			_GetBooleanIndexedvEXT = GetProcAdress< GetBooleanIndexedvEXTDelegate >( "glGetBooleanIndexedvEXT" );
			_GetIntegerIndexedvEXT = GetProcAdress< GetIntegerIndexedvEXTDelegate >( "glGetIntegerIndexedvEXT" );
			_EnableIndexedEXT = GetProcAdress< EnableIndexedEXTDelegate >( "glEnableIndexedEXT" );
			_DisableIndexedEXT = GetProcAdress< DisableIndexedEXTDelegate >( "glDisableIndexedEXT" );
			_IsEnabledIndexedEXT = GetProcAdress< IsEnabledIndexedEXTDelegate >( "glIsEnabledIndexedEXT" );
		}


		public delegate void ColorMaskIndexedEXTDelegate( uint index, bool r, bool g, bool b, bool a ); //  extension method

		private static ColorMaskIndexedEXTDelegate _ColorMaskIndexedEXT;

		public static  void ColorMaskIndexedEXT( uint index, bool r, bool g, bool b, bool a )
		{
			if (_ColorMaskIndexedEXT == null) throw new Exception( "Extension method ColorMaskIndexedEXT not found" );
		 _ColorMaskIndexedEXT( index, r, g, b, a );
		}
		public delegate void GetBooleanIndexedvEXTDelegate( uint target, uint index, [Out]bool[] data ); //  extension method

		private static GetBooleanIndexedvEXTDelegate _GetBooleanIndexedvEXT;

		public static  void GetBooleanIndexedvEXT( uint target, uint index, [Out]bool[] data )
		{
			if (_GetBooleanIndexedvEXT == null) throw new Exception( "Extension method GetBooleanIndexedvEXT not found" );
		 _GetBooleanIndexedvEXT( target, index, data );
		}
		public delegate void GetIntegerIndexedvEXTDelegate( uint target, uint index, [Out]int[] data ); //  extension method

		private static GetIntegerIndexedvEXTDelegate _GetIntegerIndexedvEXT;

		public static  void GetIntegerIndexedvEXT( uint target, uint index, [Out]int[] data )
		{
			if (_GetIntegerIndexedvEXT == null) throw new Exception( "Extension method GetIntegerIndexedvEXT not found" );
		 _GetIntegerIndexedvEXT( target, index, data );
		}
		public delegate void EnableIndexedEXTDelegate( uint target, uint index ); //  extension method

		private static EnableIndexedEXTDelegate _EnableIndexedEXT;

		public static  void EnableIndexedEXT( uint target, uint index )
		{
			if (_EnableIndexedEXT == null) throw new Exception( "Extension method EnableIndexedEXT not found" );
		 _EnableIndexedEXT( target, index );
		}
		public delegate void DisableIndexedEXTDelegate( uint target, uint index ); //  extension method

		private static DisableIndexedEXTDelegate _DisableIndexedEXT;

		public static  void DisableIndexedEXT( uint target, uint index )
		{
			if (_DisableIndexedEXT == null) throw new Exception( "Extension method DisableIndexedEXT not found" );
		 _DisableIndexedEXT( target, index );
		}
		public delegate bool IsEnabledIndexedEXTDelegate( uint target, uint index ); //  extension method

		private static IsEnabledIndexedEXTDelegate _IsEnabledIndexedEXT;

		public static  bool IsEnabledIndexedEXT( uint target, uint index )
		{
			if (_IsEnabledIndexedEXT == null) throw new Exception( "Extension method IsEnabledIndexedEXT not found" );
		return  _IsEnabledIndexedEXT( target, index );
		}
	}
}
