using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_occlusion_queryInit()
		{
			_GenOcclusionQueriesNV = GetProcAdress< GenOcclusionQueriesNVDelegate >( "glGenOcclusionQueriesNV" );
			_DeleteOcclusionQueriesNV = GetProcAdress< DeleteOcclusionQueriesNVDelegate >( "glDeleteOcclusionQueriesNV" );
			_IsOcclusionQueryNV = GetProcAdress< IsOcclusionQueryNVDelegate >( "glIsOcclusionQueryNV" );
			_BeginOcclusionQueryNV = GetProcAdress< BeginOcclusionQueryNVDelegate >( "glBeginOcclusionQueryNV" );
			_EndOcclusionQueryNV = GetProcAdress< EndOcclusionQueryNVDelegate >( "glEndOcclusionQueryNV" );
			_GetOcclusionQueryivNV = GetProcAdress< GetOcclusionQueryivNVDelegate >( "glGetOcclusionQueryivNV" );
			_GetOcclusionQueryuivNV = GetProcAdress< GetOcclusionQueryuivNVDelegate >( "glGetOcclusionQueryuivNV" );
		}


		public delegate void GenOcclusionQueriesNVDelegate( int n, [Out]uint[] ids ); //  extension method

		private static GenOcclusionQueriesNVDelegate _GenOcclusionQueriesNV;

		public static  void GenOcclusionQueriesNV( int n, [Out]uint[] ids )
		{
			if (_GenOcclusionQueriesNV == null) throw new Exception( "Extension method GenOcclusionQueriesNV not found" );
		 _GenOcclusionQueriesNV( n, ids );
		}
		public delegate void DeleteOcclusionQueriesNVDelegate( int n, uint[] ids ); //  extension method

		private static DeleteOcclusionQueriesNVDelegate _DeleteOcclusionQueriesNV;

		public static  void DeleteOcclusionQueriesNV( int n, uint[] ids )
		{
			if (_DeleteOcclusionQueriesNV == null) throw new Exception( "Extension method DeleteOcclusionQueriesNV not found" );
		 _DeleteOcclusionQueriesNV( n, ids );
		}
		public delegate bool IsOcclusionQueryNVDelegate( uint id ); //  extension method

		private static IsOcclusionQueryNVDelegate _IsOcclusionQueryNV;

		public static  bool IsOcclusionQueryNV( uint id )
		{
			if (_IsOcclusionQueryNV == null) throw new Exception( "Extension method IsOcclusionQueryNV not found" );
		return  _IsOcclusionQueryNV( id );
		}
		public delegate void BeginOcclusionQueryNVDelegate( uint id ); //  extension method

		private static BeginOcclusionQueryNVDelegate _BeginOcclusionQueryNV;

		public static  void BeginOcclusionQueryNV( uint id )
		{
			if (_BeginOcclusionQueryNV == null) throw new Exception( "Extension method BeginOcclusionQueryNV not found" );
		 _BeginOcclusionQueryNV( id );
		}
		public delegate void EndOcclusionQueryNVDelegate(  ); //  extension method

		private static EndOcclusionQueryNVDelegate _EndOcclusionQueryNV;

		public static  void EndOcclusionQueryNV(  )
		{
			if (_EndOcclusionQueryNV == null) throw new Exception( "Extension method EndOcclusionQueryNV not found" );
		 _EndOcclusionQueryNV(  );
		}
		public delegate void GetOcclusionQueryivNVDelegate( uint id, uint pname, [Out]int[] @params ); //  extension method

		private static GetOcclusionQueryivNVDelegate _GetOcclusionQueryivNV;

		public static  void GetOcclusionQueryivNV( uint id, uint pname, [Out]int[] @params )
		{
			if (_GetOcclusionQueryivNV == null) throw new Exception( "Extension method GetOcclusionQueryivNV not found" );
		 _GetOcclusionQueryivNV( id, pname, @params );
		}
		public delegate void GetOcclusionQueryuivNVDelegate( uint id, uint pname, [Out]uint[] @params ); //  extension method

		private static GetOcclusionQueryuivNVDelegate _GetOcclusionQueryuivNV;

		public static  void GetOcclusionQueryuivNV( uint id, uint pname, [Out]uint[] @params )
		{
			if (_GetOcclusionQueryuivNV == null) throw new Exception( "Extension method GetOcclusionQueryuivNV not found" );
		 _GetOcclusionQueryuivNV( id, pname, @params );
		}
	}
}
