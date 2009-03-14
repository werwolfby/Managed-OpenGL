using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_parameter_buffer_objectInit()
		{
			_ProgramBufferParametersfvNV = GetProcAdress< ProgramBufferParametersfvNVDelegate >( "glProgramBufferParametersfvNV" );
			_ProgramBufferParametersIivNV = GetProcAdress< ProgramBufferParametersIivNVDelegate >( "glProgramBufferParametersIivNV" );
			_ProgramBufferParametersIuivNV = GetProcAdress< ProgramBufferParametersIuivNVDelegate >( "glProgramBufferParametersIuivNV" );
		}


		public delegate void ProgramBufferParametersfvNVDelegate( uint target, uint buffer, uint index, int count, float[] @params ); //  extension method

		private static ProgramBufferParametersfvNVDelegate _ProgramBufferParametersfvNV;

		public static  void ProgramBufferParametersfvNV( uint target, uint buffer, uint index, int count, float[] @params )
		{
			if (_ProgramBufferParametersfvNV == null) throw new Exception( "Extension method ProgramBufferParametersfvNV not found" );
		 _ProgramBufferParametersfvNV( target, buffer, index, count, @params );
		}
		public delegate void ProgramBufferParametersIivNVDelegate( uint target, uint buffer, uint index, int count, int[] @params ); //  extension method

		private static ProgramBufferParametersIivNVDelegate _ProgramBufferParametersIivNV;

		public static  void ProgramBufferParametersIivNV( uint target, uint buffer, uint index, int count, int[] @params )
		{
			if (_ProgramBufferParametersIivNV == null) throw new Exception( "Extension method ProgramBufferParametersIivNV not found" );
		 _ProgramBufferParametersIivNV( target, buffer, index, count, @params );
		}
		public delegate void ProgramBufferParametersIuivNVDelegate( uint target, uint buffer, uint index, int count, uint[] @params ); //  extension method

		private static ProgramBufferParametersIuivNVDelegate _ProgramBufferParametersIuivNV;

		public static  void ProgramBufferParametersIuivNV( uint target, uint buffer, uint index, int count, uint[] @params )
		{
			if (_ProgramBufferParametersIuivNV == null) throw new Exception( "Extension method ProgramBufferParametersIuivNV not found" );
		 _ProgramBufferParametersIuivNV( target, buffer, index, count, @params );
		}
	}
}
