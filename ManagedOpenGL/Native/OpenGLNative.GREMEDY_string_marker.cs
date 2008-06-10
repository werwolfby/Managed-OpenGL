using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeGREMEDY_string_markerInit()
		{
			_StringMarkerGREMEDY = GetProcAdress< StringMarkerGREMEDYDelegate >( "glStringMarkerGREMEDY" );
			
		}
		
	
		public unsafe delegate void StringMarkerGREMEDYDelegate( int len, void* @string ); //  extension method
		private static StringMarkerGREMEDYDelegate _StringMarkerGREMEDY;
		
		public static unsafe  void StringMarkerGREMEDY( int len, void* @string )
		{
			if (_StringMarkerGREMEDY == null) throw new Exception( "Extension method StringMarkerGREMEDY not found" );
			 _StringMarkerGREMEDY( len, @string );
		}
	}
}

