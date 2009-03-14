using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_geometry_shader4Init()
		{
			_ProgramParameteriEXT = GetProcAdress< ProgramParameteriEXTDelegate >( "glProgramParameteriEXT" );
		}


		public delegate void ProgramParameteriEXTDelegate( uint program, uint pname, int value ); //  extension method

		private static ProgramParameteriEXTDelegate _ProgramParameteriEXT;

		public static  void ProgramParameteriEXT( uint program, uint pname, int value )
		{
			if (_ProgramParameteriEXT == null) throw new Exception( "Extension method ProgramParameteriEXT not found" );
		 _ProgramParameteriEXT( program, pname, value );
		}
	}
}
