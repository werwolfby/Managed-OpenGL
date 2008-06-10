using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeAPPLE_element_arrayInit()
		{
			_ElementPointerAPPLE = GetProcAdress< ElementPointerAPPLEDelegate >( "glElementPointerAPPLE" );
			_DrawElementArrayAPPLE = GetProcAdress< DrawElementArrayAPPLEDelegate >( "glDrawElementArrayAPPLE" );
			_DrawRangeElementArrayAPPLE = GetProcAdress< DrawRangeElementArrayAPPLEDelegate >( "glDrawRangeElementArrayAPPLE" );
			_MultiDrawElementArrayAPPLE = GetProcAdress< MultiDrawElementArrayAPPLEDelegate >( "glMultiDrawElementArrayAPPLE" );
			_MultiDrawRangeElementArrayAPPLE = GetProcAdress< MultiDrawRangeElementArrayAPPLEDelegate >( "glMultiDrawRangeElementArrayAPPLE" );
			
		}
		
	
		public unsafe delegate void ElementPointerAPPLEDelegate( uint type, void* pointer ); //  extension method
		private static ElementPointerAPPLEDelegate _ElementPointerAPPLE;
		
		public static unsafe  void ElementPointerAPPLE( uint type, void* pointer )
		{
			if (_ElementPointerAPPLE == null) throw new Exception( "Extension method ElementPointerAPPLE not found" );
			 _ElementPointerAPPLE( type, pointer );
		}
		public delegate void DrawElementArrayAPPLEDelegate( BeginMode mode, int first, int count ); //  extension method
		private static DrawElementArrayAPPLEDelegate _DrawElementArrayAPPLE;
		
		public static  void DrawElementArrayAPPLE( BeginMode mode, int first, int count )
		{
			if (_DrawElementArrayAPPLE == null) throw new Exception( "Extension method DrawElementArrayAPPLE not found" );
			 _DrawElementArrayAPPLE( mode, first, count );
		}
		public delegate void DrawRangeElementArrayAPPLEDelegate( BeginMode mode, uint start, uint end, int first, int count ); //  extension method
		private static DrawRangeElementArrayAPPLEDelegate _DrawRangeElementArrayAPPLE;
		
		public static  void DrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int first, int count )
		{
			if (_DrawRangeElementArrayAPPLE == null) throw new Exception( "Extension method DrawRangeElementArrayAPPLE not found" );
			 _DrawRangeElementArrayAPPLE( mode, start, end, first, count );
		}
		public delegate void MultiDrawElementArrayAPPLEDelegate( BeginMode mode, int[] first, int[] count, int primcount ); //  extension method
		private static MultiDrawElementArrayAPPLEDelegate _MultiDrawElementArrayAPPLE;
		
		public static  void MultiDrawElementArrayAPPLE( BeginMode mode, int[] first, int[] count, int primcount )
		{
			if (_MultiDrawElementArrayAPPLE == null) throw new Exception( "Extension method MultiDrawElementArrayAPPLE not found" );
			 _MultiDrawElementArrayAPPLE( mode, first, count, primcount );
		}
		public delegate void MultiDrawRangeElementArrayAPPLEDelegate( BeginMode mode, uint start, uint end, int[] first, int[] count, int primcount ); //  extension method
		private static MultiDrawRangeElementArrayAPPLEDelegate _MultiDrawRangeElementArrayAPPLE;
		
		public static  void MultiDrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int[] first, int[] count, int primcount )
		{
			if (_MultiDrawRangeElementArrayAPPLE == null) throw new Exception( "Extension method MultiDrawRangeElementArrayAPPLE not found" );
			 _MultiDrawRangeElementArrayAPPLE( mode, start, end, first, count, primcount );
		}
	}
}

