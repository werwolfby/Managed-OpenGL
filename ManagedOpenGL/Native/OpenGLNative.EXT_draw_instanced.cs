using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_draw_instancedInit()
		{
			_DrawArraysInstancedEXT = GetProcAdress< DrawArraysInstancedEXTDelegate >( "glDrawArraysInstancedEXT" );
			_DrawElementsInstancedEXT = GetProcAdress< DrawElementsInstancedEXTDelegate >( "glDrawElementsInstancedEXT" );
		}


		public delegate void DrawArraysInstancedEXTDelegate( BeginMode mode, int start, int count, int primcount ); //  extension method

		private static DrawArraysInstancedEXTDelegate _DrawArraysInstancedEXT;

		public static  void DrawArraysInstancedEXT( BeginMode mode, int start, int count, int primcount )
		{
			if (_DrawArraysInstancedEXT == null) throw new Exception( "Extension method DrawArraysInstancedEXT not found" );
		 _DrawArraysInstancedEXT( mode, start, count, primcount );
		}
		public unsafe delegate void DrawElementsInstancedEXTDelegate( BeginMode mode, int count, uint type, void* indices, int primcount ); //  extension method

		private static DrawElementsInstancedEXTDelegate _DrawElementsInstancedEXT;

		public static unsafe  void DrawElementsInstancedEXT( BeginMode mode, int count, uint type, void* indices, int primcount )
		{
			if (_DrawElementsInstancedEXT == null) throw new Exception( "Extension method DrawElementsInstancedEXT not found" );
		 _DrawElementsInstancedEXT( mode, count, type, indices, primcount );
		}
	}
}
