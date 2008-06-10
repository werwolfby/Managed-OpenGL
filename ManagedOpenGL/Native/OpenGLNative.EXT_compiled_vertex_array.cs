using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_compiled_vertex_arrayInit()
		{
			_LockArraysEXT = GetProcAdress< LockArraysEXTDelegate >( "glLockArraysEXT" );
			_UnlockArraysEXT = GetProcAdress< UnlockArraysEXTDelegate >( "glUnlockArraysEXT" );
			
		}
		
	
		public delegate void LockArraysEXTDelegate( int first, int count ); //  extension method
		private static LockArraysEXTDelegate _LockArraysEXT;
		
		public static  void LockArraysEXT( int first, int count )
		{
			if (_LockArraysEXT == null) throw new Exception( "Extension method LockArraysEXT not found" );
			 _LockArraysEXT( first, count );
		}
		public delegate void UnlockArraysEXTDelegate(  ); //  extension method
		private static UnlockArraysEXTDelegate _UnlockArraysEXT;
		
		public static  void UnlockArraysEXT(  )
		{
			if (_UnlockArraysEXT == null) throw new Exception( "Extension method UnlockArraysEXT not found" );
			 _UnlockArraysEXT(  );
		}
	}
}

