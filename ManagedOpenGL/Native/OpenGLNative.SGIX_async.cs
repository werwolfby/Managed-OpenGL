using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_asyncInit()
		{
			_AsyncMarkerSGIX = GetProcAdress< AsyncMarkerSGIXDelegate >( "glAsyncMarkerSGIX" );
			_FinishAsyncSGIX = GetProcAdress< FinishAsyncSGIXDelegate >( "glFinishAsyncSGIX" );
			_PollAsyncSGIX = GetProcAdress< PollAsyncSGIXDelegate >( "glPollAsyncSGIX" );
			_GenAsyncMarkersSGIX = GetProcAdress< GenAsyncMarkersSGIXDelegate >( "glGenAsyncMarkersSGIX" );
			_DeleteAsyncMarkersSGIX = GetProcAdress< DeleteAsyncMarkersSGIXDelegate >( "glDeleteAsyncMarkersSGIX" );
			_IsAsyncMarkerSGIX = GetProcAdress< IsAsyncMarkerSGIXDelegate >( "glIsAsyncMarkerSGIX" );
		}


		public delegate void AsyncMarkerSGIXDelegate( uint marker ); //  extension method

		private static AsyncMarkerSGIXDelegate _AsyncMarkerSGIX;

		public static  void AsyncMarkerSGIX( uint marker )
		{
			if (_AsyncMarkerSGIX == null) throw new Exception( "Extension method AsyncMarkerSGIX not found" );
		 _AsyncMarkerSGIX( marker );
		}
		public delegate int FinishAsyncSGIXDelegate( [Out]uint[] markerp ); //  extension method

		private static FinishAsyncSGIXDelegate _FinishAsyncSGIX;

		public static  int FinishAsyncSGIX( [Out]uint[] markerp )
		{
			if (_FinishAsyncSGIX == null) throw new Exception( "Extension method FinishAsyncSGIX not found" );
		return  _FinishAsyncSGIX( markerp );
		}
		public delegate int PollAsyncSGIXDelegate( [Out]uint[] markerp ); //  extension method

		private static PollAsyncSGIXDelegate _PollAsyncSGIX;

		public static  int PollAsyncSGIX( [Out]uint[] markerp )
		{
			if (_PollAsyncSGIX == null) throw new Exception( "Extension method PollAsyncSGIX not found" );
		return  _PollAsyncSGIX( markerp );
		}
		public delegate uint GenAsyncMarkersSGIXDelegate( int range ); //  extension method

		private static GenAsyncMarkersSGIXDelegate _GenAsyncMarkersSGIX;

		public static  uint GenAsyncMarkersSGIX( int range )
		{
			if (_GenAsyncMarkersSGIX == null) throw new Exception( "Extension method GenAsyncMarkersSGIX not found" );
		return  _GenAsyncMarkersSGIX( range );
		}
		public delegate void DeleteAsyncMarkersSGIXDelegate( uint marker, int range ); //  extension method

		private static DeleteAsyncMarkersSGIXDelegate _DeleteAsyncMarkersSGIX;

		public static  void DeleteAsyncMarkersSGIX( uint marker, int range )
		{
			if (_DeleteAsyncMarkersSGIX == null) throw new Exception( "Extension method DeleteAsyncMarkersSGIX not found" );
		 _DeleteAsyncMarkersSGIX( marker, range );
		}
		public delegate bool IsAsyncMarkerSGIXDelegate( uint marker ); //  extension method

		private static IsAsyncMarkerSGIXDelegate _IsAsyncMarkerSGIX;

		public static  bool IsAsyncMarkerSGIX( uint marker )
		{
			if (_IsAsyncMarkerSGIX == null) throw new Exception( "Extension method IsAsyncMarkerSGIX not found" );
		return  _IsAsyncMarkerSGIX( marker );
		}
	}
}
