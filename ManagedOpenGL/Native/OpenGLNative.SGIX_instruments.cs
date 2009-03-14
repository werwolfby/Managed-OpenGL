using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_instrumentsInit()
		{
			_GetInstrumentsSGIX = GetProcAdress< GetInstrumentsSGIXDelegate >( "glGetInstrumentsSGIX" );
			_InstrumentsBufferSGIX = GetProcAdress< InstrumentsBufferSGIXDelegate >( "glInstrumentsBufferSGIX" );
			_PollInstrumentsSGIX = GetProcAdress< PollInstrumentsSGIXDelegate >( "glPollInstrumentsSGIX" );
			_ReadInstrumentsSGIX = GetProcAdress< ReadInstrumentsSGIXDelegate >( "glReadInstrumentsSGIX" );
			_StartInstrumentsSGIX = GetProcAdress< StartInstrumentsSGIXDelegate >( "glStartInstrumentsSGIX" );
			_StopInstrumentsSGIX = GetProcAdress< StopInstrumentsSGIXDelegate >( "glStopInstrumentsSGIX" );
		}


		public delegate int GetInstrumentsSGIXDelegate(  ); //  extension method

		private static GetInstrumentsSGIXDelegate _GetInstrumentsSGIX;

		public static  int GetInstrumentsSGIX(  )
		{
			if (_GetInstrumentsSGIX == null) throw new Exception( "Extension method GetInstrumentsSGIX not found" );
		return  _GetInstrumentsSGIX(  );
		}
		public delegate void InstrumentsBufferSGIXDelegate( int size, [Out]int[] buffer ); //  extension method

		private static InstrumentsBufferSGIXDelegate _InstrumentsBufferSGIX;

		public static  void InstrumentsBufferSGIX( int size, [Out]int[] buffer )
		{
			if (_InstrumentsBufferSGIX == null) throw new Exception( "Extension method InstrumentsBufferSGIX not found" );
		 _InstrumentsBufferSGIX( size, buffer );
		}
		public delegate int PollInstrumentsSGIXDelegate( [Out]int[] marker_p ); //  extension method

		private static PollInstrumentsSGIXDelegate _PollInstrumentsSGIX;

		public static  int PollInstrumentsSGIX( [Out]int[] marker_p )
		{
			if (_PollInstrumentsSGIX == null) throw new Exception( "Extension method PollInstrumentsSGIX not found" );
		return  _PollInstrumentsSGIX( marker_p );
		}
		public delegate void ReadInstrumentsSGIXDelegate( int marker ); //  extension method

		private static ReadInstrumentsSGIXDelegate _ReadInstrumentsSGIX;

		public static  void ReadInstrumentsSGIX( int marker )
		{
			if (_ReadInstrumentsSGIX == null) throw new Exception( "Extension method ReadInstrumentsSGIX not found" );
		 _ReadInstrumentsSGIX( marker );
		}
		public delegate void StartInstrumentsSGIXDelegate(  ); //  extension method

		private static StartInstrumentsSGIXDelegate _StartInstrumentsSGIX;

		public static  void StartInstrumentsSGIX(  )
		{
			if (_StartInstrumentsSGIX == null) throw new Exception( "Extension method StartInstrumentsSGIX not found" );
		 _StartInstrumentsSGIX(  );
		}
		public delegate void StopInstrumentsSGIXDelegate( int marker ); //  extension method

		private static StopInstrumentsSGIXDelegate _StopInstrumentsSGIX;

		public static  void StopInstrumentsSGIX( int marker )
		{
			if (_StopInstrumentsSGIX == null) throw new Exception( "Extension method StopInstrumentsSGIX not found" );
		 _StopInstrumentsSGIX( marker );
		}
	}
}
