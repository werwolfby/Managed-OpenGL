using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeAPPLE_vertex_array_objectInit()
		{
			_BindVertexArrayAPPLE = GetProcAdress< BindVertexArrayAPPLEDelegate >( "glBindVertexArrayAPPLE" );
			_DeleteVertexArraysAPPLE = GetProcAdress< DeleteVertexArraysAPPLEDelegate >( "glDeleteVertexArraysAPPLE" );
			_GenVertexArraysAPPLE = GetProcAdress< GenVertexArraysAPPLEDelegate >( "glGenVertexArraysAPPLE" );
			_IsVertexArrayAPPLE = GetProcAdress< IsVertexArrayAPPLEDelegate >( "glIsVertexArrayAPPLE" );
		}


		public delegate void BindVertexArrayAPPLEDelegate( uint array ); //  extension method

		private static BindVertexArrayAPPLEDelegate _BindVertexArrayAPPLE;

		public static  void BindVertexArrayAPPLE( uint array )
		{
			if (_BindVertexArrayAPPLE == null) throw new Exception( "Extension method BindVertexArrayAPPLE not found" );
		 _BindVertexArrayAPPLE( array );
		}
		public delegate void DeleteVertexArraysAPPLEDelegate( int n, uint[] arrays ); //  extension method

		private static DeleteVertexArraysAPPLEDelegate _DeleteVertexArraysAPPLE;

		public static  void DeleteVertexArraysAPPLE( int n, uint[] arrays )
		{
			if (_DeleteVertexArraysAPPLE == null) throw new Exception( "Extension method DeleteVertexArraysAPPLE not found" );
		 _DeleteVertexArraysAPPLE( n, arrays );
		}
		public delegate void GenVertexArraysAPPLEDelegate( int n, [Out]uint[] arrays ); //  extension method

		private static GenVertexArraysAPPLEDelegate _GenVertexArraysAPPLE;

		public static  void GenVertexArraysAPPLE( int n, [Out]uint[] arrays )
		{
			if (_GenVertexArraysAPPLE == null) throw new Exception( "Extension method GenVertexArraysAPPLE not found" );
		 _GenVertexArraysAPPLE( n, arrays );
		}
		public delegate bool IsVertexArrayAPPLEDelegate( uint array ); //  extension method

		private static IsVertexArrayAPPLEDelegate _IsVertexArrayAPPLE;

		public static  bool IsVertexArrayAPPLE( uint array )
		{
			if (_IsVertexArrayAPPLE == null) throw new Exception( "Extension method IsVertexArrayAPPLE not found" );
		return  _IsVertexArrayAPPLE( array );
		}
	}
}
