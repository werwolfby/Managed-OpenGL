using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_gpu_program_parametersInit()
		{
			_ProgramEnvParameters4fvEXT = GetProcAdress< ProgramEnvParameters4fvEXTDelegate >( "glProgramEnvParameters4fvEXT" );
			_ProgramLocalParameters4fvEXT = GetProcAdress< ProgramLocalParameters4fvEXTDelegate >( "glProgramLocalParameters4fvEXT" );
		}


		public delegate void ProgramEnvParameters4fvEXTDelegate( uint target, uint index, int count, float[] @params ); // 

		private static ProgramEnvParameters4fvEXTDelegate _ProgramEnvParameters4fvEXT;

		public static  void ProgramEnvParameters4fvEXT( uint target, uint index, int count, float[] @params )
		{
			if (_ProgramEnvParameters4fvEXT == null) throw new Exception( "Extension method ProgramEnvParameters4fvEXT not found" );
		 _ProgramEnvParameters4fvEXT( target, index, count, @params );
		}
		public delegate void ProgramLocalParameters4fvEXTDelegate( uint target, uint index, int count, float[] @params ); // 

		private static ProgramLocalParameters4fvEXTDelegate _ProgramLocalParameters4fvEXT;

		public static  void ProgramLocalParameters4fvEXT( uint target, uint index, int count, float[] @params )
		{
			if (_ProgramLocalParameters4fvEXT == null) throw new Exception( "Extension method ProgramLocalParameters4fvEXT not found" );
		 _ProgramLocalParameters4fvEXT( target, index, count, @params );
		}
	}
}
