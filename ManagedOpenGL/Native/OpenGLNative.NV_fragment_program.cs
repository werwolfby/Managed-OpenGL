using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_fragment_programInit()
		{
			_ProgramNamedParameter4fNV = GetProcAdress< ProgramNamedParameter4fNVDelegate >( "glProgramNamedParameter4fNV" );
			_ProgramNamedParameter4dNV = GetProcAdress< ProgramNamedParameter4dNVDelegate >( "glProgramNamedParameter4dNV" );
			_ProgramNamedParameter4fvNV = GetProcAdress< ProgramNamedParameter4fvNVDelegate >( "glProgramNamedParameter4fvNV" );
			_ProgramNamedParameter4dvNV = GetProcAdress< ProgramNamedParameter4dvNVDelegate >( "glProgramNamedParameter4dvNV" );
			_GetProgramNamedParameterfvNV = GetProcAdress< GetProgramNamedParameterfvNVDelegate >( "glGetProgramNamedParameterfvNV" );
			_GetProgramNamedParameterdvNV = GetProcAdress< GetProgramNamedParameterdvNVDelegate >( "glGetProgramNamedParameterdvNV" );
			
		}
		
	
		public delegate void ProgramNamedParameter4fNVDelegate( uint id, int len, byte[] name, float x, float y, float z, float w ); //  extension method
		private static ProgramNamedParameter4fNVDelegate _ProgramNamedParameter4fNV;
		
		public static  void ProgramNamedParameter4fNV( uint id, int len, byte[] name, float x, float y, float z, float w )
		{
			if (_ProgramNamedParameter4fNV == null) throw new Exception( "Extension method ProgramNamedParameter4fNV not found" );
			 _ProgramNamedParameter4fNV( id, len, name, x, y, z, w );
		}
		public delegate void ProgramNamedParameter4dNVDelegate( uint id, int len, byte[] name, double x, double y, double z, double w ); //  extension method
		private static ProgramNamedParameter4dNVDelegate _ProgramNamedParameter4dNV;
		
		public static  void ProgramNamedParameter4dNV( uint id, int len, byte[] name, double x, double y, double z, double w )
		{
			if (_ProgramNamedParameter4dNV == null) throw new Exception( "Extension method ProgramNamedParameter4dNV not found" );
			 _ProgramNamedParameter4dNV( id, len, name, x, y, z, w );
		}
		public delegate void ProgramNamedParameter4fvNVDelegate( uint id, int len, byte[] name, float[] v ); //  extension method
		private static ProgramNamedParameter4fvNVDelegate _ProgramNamedParameter4fvNV;
		
		public static  void ProgramNamedParameter4fvNV( uint id, int len, byte[] name, float[] v )
		{
			if (_ProgramNamedParameter4fvNV == null) throw new Exception( "Extension method ProgramNamedParameter4fvNV not found" );
			 _ProgramNamedParameter4fvNV( id, len, name, v );
		}
		public delegate void ProgramNamedParameter4dvNVDelegate( uint id, int len, byte[] name, double[] v ); //  extension method
		private static ProgramNamedParameter4dvNVDelegate _ProgramNamedParameter4dvNV;
		
		public static  void ProgramNamedParameter4dvNV( uint id, int len, byte[] name, double[] v )
		{
			if (_ProgramNamedParameter4dvNV == null) throw new Exception( "Extension method ProgramNamedParameter4dvNV not found" );
			 _ProgramNamedParameter4dvNV( id, len, name, v );
		}
		public delegate void GetProgramNamedParameterfvNVDelegate( uint id, int len, byte[] name, [Out]float[] @params ); //  extension method
		private static GetProgramNamedParameterfvNVDelegate _GetProgramNamedParameterfvNV;
		
		public static  void GetProgramNamedParameterfvNV( uint id, int len, byte[] name, [Out]float[] @params )
		{
			if (_GetProgramNamedParameterfvNV == null) throw new Exception( "Extension method GetProgramNamedParameterfvNV not found" );
			 _GetProgramNamedParameterfvNV( id, len, name, @params );
		}
		public delegate void GetProgramNamedParameterdvNVDelegate( uint id, int len, byte[] name, [Out]double[] @params ); //  extension method
		private static GetProgramNamedParameterdvNVDelegate _GetProgramNamedParameterdvNV;
		
		public static  void GetProgramNamedParameterdvNV( uint id, int len, byte[] name, [Out]double[] @params )
		{
			if (_GetProgramNamedParameterdvNV == null) throw new Exception( "Extension method GetProgramNamedParameterdvNV not found" );
			 _GetProgramNamedParameterdvNV( id, len, name, @params );
		}
	}
}

