using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_gpu_program4Init()
		{
			_ProgramLocalParameterI4iNV = GetProcAdress< ProgramLocalParameterI4iNVDelegate >( "glProgramLocalParameterI4iNV" );
			_ProgramLocalParameterI4ivNV = GetProcAdress< ProgramLocalParameterI4ivNVDelegate >( "glProgramLocalParameterI4ivNV" );
			_ProgramLocalParametersI4ivNV = GetProcAdress< ProgramLocalParametersI4ivNVDelegate >( "glProgramLocalParametersI4ivNV" );
			_ProgramLocalParameterI4uiNV = GetProcAdress< ProgramLocalParameterI4uiNVDelegate >( "glProgramLocalParameterI4uiNV" );
			_ProgramLocalParameterI4uivNV = GetProcAdress< ProgramLocalParameterI4uivNVDelegate >( "glProgramLocalParameterI4uivNV" );
			_ProgramLocalParametersI4uivNV = GetProcAdress< ProgramLocalParametersI4uivNVDelegate >( "glProgramLocalParametersI4uivNV" );
			_ProgramEnvParameterI4iNV = GetProcAdress< ProgramEnvParameterI4iNVDelegate >( "glProgramEnvParameterI4iNV" );
			_ProgramEnvParameterI4ivNV = GetProcAdress< ProgramEnvParameterI4ivNVDelegate >( "glProgramEnvParameterI4ivNV" );
			_ProgramEnvParametersI4ivNV = GetProcAdress< ProgramEnvParametersI4ivNVDelegate >( "glProgramEnvParametersI4ivNV" );
			_ProgramEnvParameterI4uiNV = GetProcAdress< ProgramEnvParameterI4uiNVDelegate >( "glProgramEnvParameterI4uiNV" );
			_ProgramEnvParameterI4uivNV = GetProcAdress< ProgramEnvParameterI4uivNVDelegate >( "glProgramEnvParameterI4uivNV" );
			_ProgramEnvParametersI4uivNV = GetProcAdress< ProgramEnvParametersI4uivNVDelegate >( "glProgramEnvParametersI4uivNV" );
			_GetProgramLocalParameterIivNV = GetProcAdress< GetProgramLocalParameterIivNVDelegate >( "glGetProgramLocalParameterIivNV" );
			_GetProgramLocalParameterIuivNV = GetProcAdress< GetProgramLocalParameterIuivNVDelegate >( "glGetProgramLocalParameterIuivNV" );
			_GetProgramEnvParameterIivNV = GetProcAdress< GetProgramEnvParameterIivNVDelegate >( "glGetProgramEnvParameterIivNV" );
			_GetProgramEnvParameterIuivNV = GetProcAdress< GetProgramEnvParameterIuivNVDelegate >( "glGetProgramEnvParameterIuivNV" );
		}


		public delegate void ProgramLocalParameterI4iNVDelegate( uint target, uint index, int x, int y, int z, int w ); //  extension method

		private static ProgramLocalParameterI4iNVDelegate _ProgramLocalParameterI4iNV;

		public static  void ProgramLocalParameterI4iNV( uint target, uint index, int x, int y, int z, int w )
		{
			if (_ProgramLocalParameterI4iNV == null) throw new Exception( "Extension method ProgramLocalParameterI4iNV not found" );
		 _ProgramLocalParameterI4iNV( target, index, x, y, z, w );
		}
		public delegate void ProgramLocalParameterI4ivNVDelegate( uint target, uint index, int[] @params ); //  extension method

		private static ProgramLocalParameterI4ivNVDelegate _ProgramLocalParameterI4ivNV;

		public static  void ProgramLocalParameterI4ivNV( uint target, uint index, int[] @params )
		{
			if (_ProgramLocalParameterI4ivNV == null) throw new Exception( "Extension method ProgramLocalParameterI4ivNV not found" );
		 _ProgramLocalParameterI4ivNV( target, index, @params );
		}
		public delegate void ProgramLocalParametersI4ivNVDelegate( uint target, uint index, int count, int[] @params ); //  extension method

		private static ProgramLocalParametersI4ivNVDelegate _ProgramLocalParametersI4ivNV;

		public static  void ProgramLocalParametersI4ivNV( uint target, uint index, int count, int[] @params )
		{
			if (_ProgramLocalParametersI4ivNV == null) throw new Exception( "Extension method ProgramLocalParametersI4ivNV not found" );
		 _ProgramLocalParametersI4ivNV( target, index, count, @params );
		}
		public delegate void ProgramLocalParameterI4uiNVDelegate( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method

		private static ProgramLocalParameterI4uiNVDelegate _ProgramLocalParameterI4uiNV;

		public static  void ProgramLocalParameterI4uiNV( uint target, uint index, uint x, uint y, uint z, uint w )
		{
			if (_ProgramLocalParameterI4uiNV == null) throw new Exception( "Extension method ProgramLocalParameterI4uiNV not found" );
		 _ProgramLocalParameterI4uiNV( target, index, x, y, z, w );
		}
		public delegate void ProgramLocalParameterI4uivNVDelegate( uint target, uint index, uint[] @params ); //  extension method

		private static ProgramLocalParameterI4uivNVDelegate _ProgramLocalParameterI4uivNV;

		public static  void ProgramLocalParameterI4uivNV( uint target, uint index, uint[] @params )
		{
			if (_ProgramLocalParameterI4uivNV == null) throw new Exception( "Extension method ProgramLocalParameterI4uivNV not found" );
		 _ProgramLocalParameterI4uivNV( target, index, @params );
		}
		public delegate void ProgramLocalParametersI4uivNVDelegate( uint target, uint index, int count, uint[] @params ); //  extension method

		private static ProgramLocalParametersI4uivNVDelegate _ProgramLocalParametersI4uivNV;

		public static  void ProgramLocalParametersI4uivNV( uint target, uint index, int count, uint[] @params )
		{
			if (_ProgramLocalParametersI4uivNV == null) throw new Exception( "Extension method ProgramLocalParametersI4uivNV not found" );
		 _ProgramLocalParametersI4uivNV( target, index, count, @params );
		}
		public delegate void ProgramEnvParameterI4iNVDelegate( uint target, uint index, int x, int y, int z, int w ); //  extension method

		private static ProgramEnvParameterI4iNVDelegate _ProgramEnvParameterI4iNV;

		public static  void ProgramEnvParameterI4iNV( uint target, uint index, int x, int y, int z, int w )
		{
			if (_ProgramEnvParameterI4iNV == null) throw new Exception( "Extension method ProgramEnvParameterI4iNV not found" );
		 _ProgramEnvParameterI4iNV( target, index, x, y, z, w );
		}
		public delegate void ProgramEnvParameterI4ivNVDelegate( uint target, uint index, int[] @params ); //  extension method

		private static ProgramEnvParameterI4ivNVDelegate _ProgramEnvParameterI4ivNV;

		public static  void ProgramEnvParameterI4ivNV( uint target, uint index, int[] @params )
		{
			if (_ProgramEnvParameterI4ivNV == null) throw new Exception( "Extension method ProgramEnvParameterI4ivNV not found" );
		 _ProgramEnvParameterI4ivNV( target, index, @params );
		}
		public delegate void ProgramEnvParametersI4ivNVDelegate( uint target, uint index, int count, int[] @params ); //  extension method

		private static ProgramEnvParametersI4ivNVDelegate _ProgramEnvParametersI4ivNV;

		public static  void ProgramEnvParametersI4ivNV( uint target, uint index, int count, int[] @params )
		{
			if (_ProgramEnvParametersI4ivNV == null) throw new Exception( "Extension method ProgramEnvParametersI4ivNV not found" );
		 _ProgramEnvParametersI4ivNV( target, index, count, @params );
		}
		public delegate void ProgramEnvParameterI4uiNVDelegate( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method

		private static ProgramEnvParameterI4uiNVDelegate _ProgramEnvParameterI4uiNV;

		public static  void ProgramEnvParameterI4uiNV( uint target, uint index, uint x, uint y, uint z, uint w )
		{
			if (_ProgramEnvParameterI4uiNV == null) throw new Exception( "Extension method ProgramEnvParameterI4uiNV not found" );
		 _ProgramEnvParameterI4uiNV( target, index, x, y, z, w );
		}
		public delegate void ProgramEnvParameterI4uivNVDelegate( uint target, uint index, uint[] @params ); //  extension method

		private static ProgramEnvParameterI4uivNVDelegate _ProgramEnvParameterI4uivNV;

		public static  void ProgramEnvParameterI4uivNV( uint target, uint index, uint[] @params )
		{
			if (_ProgramEnvParameterI4uivNV == null) throw new Exception( "Extension method ProgramEnvParameterI4uivNV not found" );
		 _ProgramEnvParameterI4uivNV( target, index, @params );
		}
		public delegate void ProgramEnvParametersI4uivNVDelegate( uint target, uint index, int count, uint[] @params ); //  extension method

		private static ProgramEnvParametersI4uivNVDelegate _ProgramEnvParametersI4uivNV;

		public static  void ProgramEnvParametersI4uivNV( uint target, uint index, int count, uint[] @params )
		{
			if (_ProgramEnvParametersI4uivNV == null) throw new Exception( "Extension method ProgramEnvParametersI4uivNV not found" );
		 _ProgramEnvParametersI4uivNV( target, index, count, @params );
		}
		public delegate void GetProgramLocalParameterIivNVDelegate( uint target, uint index, [Out]int[] @params ); //  extension method

		private static GetProgramLocalParameterIivNVDelegate _GetProgramLocalParameterIivNV;

		public static  void GetProgramLocalParameterIivNV( uint target, uint index, [Out]int[] @params )
		{
			if (_GetProgramLocalParameterIivNV == null) throw new Exception( "Extension method GetProgramLocalParameterIivNV not found" );
		 _GetProgramLocalParameterIivNV( target, index, @params );
		}
		public delegate void GetProgramLocalParameterIuivNVDelegate( uint target, uint index, [Out]uint[] @params ); //  extension method

		private static GetProgramLocalParameterIuivNVDelegate _GetProgramLocalParameterIuivNV;

		public static  void GetProgramLocalParameterIuivNV( uint target, uint index, [Out]uint[] @params )
		{
			if (_GetProgramLocalParameterIuivNV == null) throw new Exception( "Extension method GetProgramLocalParameterIuivNV not found" );
		 _GetProgramLocalParameterIuivNV( target, index, @params );
		}
		public delegate void GetProgramEnvParameterIivNVDelegate( uint target, uint index, [Out]int[] @params ); //  extension method

		private static GetProgramEnvParameterIivNVDelegate _GetProgramEnvParameterIivNV;

		public static  void GetProgramEnvParameterIivNV( uint target, uint index, [Out]int[] @params )
		{
			if (_GetProgramEnvParameterIivNV == null) throw new Exception( "Extension method GetProgramEnvParameterIivNV not found" );
		 _GetProgramEnvParameterIivNV( target, index, @params );
		}
		public delegate void GetProgramEnvParameterIuivNVDelegate( uint target, uint index, [Out]uint[] @params ); //  extension method

		private static GetProgramEnvParameterIuivNVDelegate _GetProgramEnvParameterIuivNV;

		public static  void GetProgramEnvParameterIuivNV( uint target, uint index, [Out]uint[] @params )
		{
			if (_GetProgramEnvParameterIuivNV == null) throw new Exception( "Extension method GetProgramEnvParameterIuivNV not found" );
		 _GetProgramEnvParameterIuivNV( target, index, @params );
		}
	}
}
