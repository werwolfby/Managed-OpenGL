using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_list_priorityInit()
		{
			_GetListParameterfvSGIX = GetProcAdress< GetListParameterfvSGIXDelegate >( "glGetListParameterfvSGIX" );
			_GetListParameterivSGIX = GetProcAdress< GetListParameterivSGIXDelegate >( "glGetListParameterivSGIX" );
			_ListParameterfSGIX = GetProcAdress< ListParameterfSGIXDelegate >( "glListParameterfSGIX" );
			_ListParameterfvSGIX = GetProcAdress< ListParameterfvSGIXDelegate >( "glListParameterfvSGIX" );
			_ListParameteriSGIX = GetProcAdress< ListParameteriSGIXDelegate >( "glListParameteriSGIX" );
			_ListParameterivSGIX = GetProcAdress< ListParameterivSGIXDelegate >( "glListParameterivSGIX" );
		}


		public delegate void GetListParameterfvSGIXDelegate( uint list, ListParameterName pname, [Out]float[] @params ); //  extension method

		private static GetListParameterfvSGIXDelegate _GetListParameterfvSGIX;

		public static  void GetListParameterfvSGIX( uint list, ListParameterName pname, [Out]float[] @params )
		{
			if (_GetListParameterfvSGIX == null) throw new Exception( "Extension method GetListParameterfvSGIX not found" );
		 _GetListParameterfvSGIX( list, pname, @params );
		}
		public delegate void GetListParameterivSGIXDelegate( uint list, ListParameterName pname, [Out]int[] @params ); //  extension method

		private static GetListParameterivSGIXDelegate _GetListParameterivSGIX;

		public static  void GetListParameterivSGIX( uint list, ListParameterName pname, [Out]int[] @params )
		{
			if (_GetListParameterivSGIX == null) throw new Exception( "Extension method GetListParameterivSGIX not found" );
		 _GetListParameterivSGIX( list, pname, @params );
		}
		public delegate void ListParameterfSGIXDelegate( uint list, ListParameterName pname, float param ); //  extension method

		private static ListParameterfSGIXDelegate _ListParameterfSGIX;

		public static  void ListParameterfSGIX( uint list, ListParameterName pname, float param )
		{
			if (_ListParameterfSGIX == null) throw new Exception( "Extension method ListParameterfSGIX not found" );
		 _ListParameterfSGIX( list, pname, param );
		}
		public delegate void ListParameterfvSGIXDelegate( uint list, ListParameterName pname, float[] @params ); //  extension method

		private static ListParameterfvSGIXDelegate _ListParameterfvSGIX;

		public static  void ListParameterfvSGIX( uint list, ListParameterName pname, float[] @params )
		{
			if (_ListParameterfvSGIX == null) throw new Exception( "Extension method ListParameterfvSGIX not found" );
		 _ListParameterfvSGIX( list, pname, @params );
		}
		public delegate void ListParameteriSGIXDelegate( uint list, ListParameterName pname, int param ); //  extension method

		private static ListParameteriSGIXDelegate _ListParameteriSGIX;

		public static  void ListParameteriSGIX( uint list, ListParameterName pname, int param )
		{
			if (_ListParameteriSGIX == null) throw new Exception( "Extension method ListParameteriSGIX not found" );
		 _ListParameteriSGIX( list, pname, param );
		}
		public delegate void ListParameterivSGIXDelegate( uint list, ListParameterName pname, int[] @params ); //  extension method

		private static ListParameterivSGIXDelegate _ListParameterivSGIX;

		public static  void ListParameterivSGIX( uint list, ListParameterName pname, int[] @params )
		{
			if (_ListParameterivSGIX == null) throw new Exception( "Extension method ListParameterivSGIX not found" );
		 _ListParameterivSGIX( list, pname, @params );
		}
	}
}
