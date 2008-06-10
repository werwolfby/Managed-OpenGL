using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_occlusion_queryInit()
		{
			_GenQueriesARB = GetProcAdress< GenQueriesARBDelegate >( "glGenQueriesARB" );
			_DeleteQueriesARB = GetProcAdress< DeleteQueriesARBDelegate >( "glDeleteQueriesARB" );
			_IsQueryARB = GetProcAdress< IsQueryARBDelegate >( "glIsQueryARB" );
			_BeginQueryARB = GetProcAdress< BeginQueryARBDelegate >( "glBeginQueryARB" );
			_EndQueryARB = GetProcAdress< EndQueryARBDelegate >( "glEndQueryARB" );
			_GetQueryivARB = GetProcAdress< GetQueryivARBDelegate >( "glGetQueryivARB" );
			_GetQueryObjectivARB = GetProcAdress< GetQueryObjectivARBDelegate >( "glGetQueryObjectivARB" );
			_GetQueryObjectuivARB = GetProcAdress< GetQueryObjectuivARBDelegate >( "glGetQueryObjectuivARB" );
			
		}
		
	
		public delegate void GenQueriesARBDelegate( int n, [Out]uint[] ids ); //  extension method
		private static GenQueriesARBDelegate _GenQueriesARB;
		
		public static  void GenQueriesARB( int n, [Out]uint[] ids )
		{
			if (_GenQueriesARB == null) throw new Exception( "Extension method GenQueriesARB not found" );
			 _GenQueriesARB( n, ids );
		}
		public delegate void DeleteQueriesARBDelegate( int n, uint[] ids ); //  extension method
		private static DeleteQueriesARBDelegate _DeleteQueriesARB;
		
		public static  void DeleteQueriesARB( int n, uint[] ids )
		{
			if (_DeleteQueriesARB == null) throw new Exception( "Extension method DeleteQueriesARB not found" );
			 _DeleteQueriesARB( n, ids );
		}
		public delegate bool IsQueryARBDelegate( uint id ); //  extension method
		private static IsQueryARBDelegate _IsQueryARB;
		
		public static  bool IsQueryARB( uint id )
		{
			if (_IsQueryARB == null) throw new Exception( "Extension method IsQueryARB not found" );
			return  _IsQueryARB( id );
		}
		public delegate void BeginQueryARBDelegate( uint target, uint id ); //  extension method
		private static BeginQueryARBDelegate _BeginQueryARB;
		
		public static  void BeginQueryARB( uint target, uint id )
		{
			if (_BeginQueryARB == null) throw new Exception( "Extension method BeginQueryARB not found" );
			 _BeginQueryARB( target, id );
		}
		public delegate void EndQueryARBDelegate( uint target ); //  extension method
		private static EndQueryARBDelegate _EndQueryARB;
		
		public static  void EndQueryARB( uint target )
		{
			if (_EndQueryARB == null) throw new Exception( "Extension method EndQueryARB not found" );
			 _EndQueryARB( target );
		}
		public delegate void GetQueryivARBDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method
		private static GetQueryivARBDelegate _GetQueryivARB;
		
		public static  void GetQueryivARB( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetQueryivARB == null) throw new Exception( "Extension method GetQueryivARB not found" );
			 _GetQueryivARB( target, pname, @params );
		}
		public delegate void GetQueryObjectivARBDelegate( uint id, uint pname, [Out]int[] @params ); //  extension method
		private static GetQueryObjectivARBDelegate _GetQueryObjectivARB;
		
		public static  void GetQueryObjectivARB( uint id, uint pname, [Out]int[] @params )
		{
			if (_GetQueryObjectivARB == null) throw new Exception( "Extension method GetQueryObjectivARB not found" );
			 _GetQueryObjectivARB( id, pname, @params );
		}
		public delegate void GetQueryObjectuivARBDelegate( uint id, uint pname, [Out]uint[] @params ); //  extension method
		private static GetQueryObjectuivARBDelegate _GetQueryObjectuivARB;
		
		public static  void GetQueryObjectuivARB( uint id, uint pname, [Out]uint[] @params )
		{
			if (_GetQueryObjectuivARB == null) throw new Exception( "Extension method GetQueryObjectuivARB not found" );
			 _GetQueryObjectuivARB( id, pname, @params );
		}
	}
}

