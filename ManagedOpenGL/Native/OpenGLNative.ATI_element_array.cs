using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_element_arrayInit()
		{
			_ElementPointerATI = GetProcAdress< ElementPointerATIDelegate >( "glElementPointerATI" );
			_DrawElementArrayATI = GetProcAdress< DrawElementArrayATIDelegate >( "glDrawElementArrayATI" );
			_DrawRangeElementArrayATI = GetProcAdress< DrawRangeElementArrayATIDelegate >( "glDrawRangeElementArrayATI" );
		}


		public unsafe delegate void ElementPointerATIDelegate( uint type, void* pointer ); // 

		private static ElementPointerATIDelegate _ElementPointerATI;

		public static unsafe  void ElementPointerATI( uint type, void* pointer )
		{
			if (_ElementPointerATI == null) throw new Exception( "Extension method ElementPointerATI not found" );
		 _ElementPointerATI( type, pointer );
		}
		public delegate void DrawElementArrayATIDelegate( BeginMode mode, int count ); // 

		private static DrawElementArrayATIDelegate _DrawElementArrayATI;

		public static  void DrawElementArrayATI( BeginMode mode, int count )
		{
			if (_DrawElementArrayATI == null) throw new Exception( "Extension method DrawElementArrayATI not found" );
		 _DrawElementArrayATI( mode, count );
		}
		public delegate void DrawRangeElementArrayATIDelegate( BeginMode mode, uint start, uint end, int count ); // 

		private static DrawRangeElementArrayATIDelegate _DrawRangeElementArrayATI;

		public static  void DrawRangeElementArrayATI( BeginMode mode, uint start, uint end, int count )
		{
			if (_DrawRangeElementArrayATI == null) throw new Exception( "Extension method DrawRangeElementArrayATI not found" );
		 _DrawRangeElementArrayATI( mode, start, end, count );
		}
	}
}
