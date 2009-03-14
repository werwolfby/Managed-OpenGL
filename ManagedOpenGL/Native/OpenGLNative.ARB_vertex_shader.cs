using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_vertex_shaderInit()
		{
			_BindAttribLocationARB = GetProcAdress< BindAttribLocationARBDelegate >( "glBindAttribLocationARB" );
			_GetActiveAttribARB = GetProcAdress< GetActiveAttribARBDelegate >( "glGetActiveAttribARB" );
			_GetAttribLocationARB = GetProcAdress< GetAttribLocationARBDelegate >( "glGetAttribLocationARB" );
		}


		public delegate void BindAttribLocationARBDelegate( uint programObj, uint index, string name ); //  extension method

		private static BindAttribLocationARBDelegate _BindAttribLocationARB;

		public static  void BindAttribLocationARB( uint programObj, uint index, string name )
		{
			if (_BindAttribLocationARB == null) throw new Exception( "Extension method BindAttribLocationARB not found" );
		 _BindAttribLocationARB( programObj, index, name );
		}
		public delegate void GetActiveAttribARBDelegate( uint programObj, uint index, int maxLength, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]char[] name ); //  extension method

		private static GetActiveAttribARBDelegate _GetActiveAttribARB;

		public static  void GetActiveAttribARB( uint programObj, uint index, int maxLength, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]char[] name )
		{
			if (_GetActiveAttribARB == null) throw new Exception( "Extension method GetActiveAttribARB not found" );
		 _GetActiveAttribARB( programObj, index, maxLength, length, size, type, name );
		}
		public delegate int GetAttribLocationARBDelegate( uint programObj, string name ); //  extension method

		private static GetAttribLocationARBDelegate _GetAttribLocationARB;

		public static  int GetAttribLocationARB( uint programObj, string name )
		{
			if (_GetAttribLocationARB == null) throw new Exception( "Extension method GetAttribLocationARB not found" );
		return  _GetAttribLocationARB( programObj, name );
		}
	}
}
