using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_gpu_shader4Init()
		{
			_GetUniformuivEXT = GetProcAdress< GetUniformuivEXTDelegate >( "glGetUniformuivEXT" );
			_BindFragDataLocationEXT = GetProcAdress< BindFragDataLocationEXTDelegate >( "glBindFragDataLocationEXT" );
			_GetFragDataLocationEXT = GetProcAdress< GetFragDataLocationEXTDelegate >( "glGetFragDataLocationEXT" );
			_Uniform1uiEXT = GetProcAdress< Uniform1uiEXTDelegate >( "glUniform1uiEXT" );
			_Uniform2uiEXT = GetProcAdress< Uniform2uiEXTDelegate >( "glUniform2uiEXT" );
			_Uniform3uiEXT = GetProcAdress< Uniform3uiEXTDelegate >( "glUniform3uiEXT" );
			_Uniform4uiEXT = GetProcAdress< Uniform4uiEXTDelegate >( "glUniform4uiEXT" );
			_Uniform1uivEXT = GetProcAdress< Uniform1uivEXTDelegate >( "glUniform1uivEXT" );
			_Uniform2uivEXT = GetProcAdress< Uniform2uivEXTDelegate >( "glUniform2uivEXT" );
			_Uniform3uivEXT = GetProcAdress< Uniform3uivEXTDelegate >( "glUniform3uivEXT" );
			_Uniform4uivEXT = GetProcAdress< Uniform4uivEXTDelegate >( "glUniform4uivEXT" );
		}


		public delegate void GetUniformuivEXTDelegate( uint program, int location, [Out]uint[] @params ); //  extension method

		private static GetUniformuivEXTDelegate _GetUniformuivEXT;

		public static  void GetUniformuivEXT( uint program, int location, [Out]uint[] @params )
		{
			if (_GetUniformuivEXT == null) throw new Exception( "Extension method GetUniformuivEXT not found" );
		 _GetUniformuivEXT( program, location, @params );
		}
		public delegate void BindFragDataLocationEXTDelegate( uint program, uint color, string name ); //  extension method

		private static BindFragDataLocationEXTDelegate _BindFragDataLocationEXT;

		public static  void BindFragDataLocationEXT( uint program, uint color, string name )
		{
			if (_BindFragDataLocationEXT == null) throw new Exception( "Extension method BindFragDataLocationEXT not found" );
		 _BindFragDataLocationEXT( program, color, name );
		}
		public delegate int GetFragDataLocationEXTDelegate( uint program, string name ); //  extension method

		private static GetFragDataLocationEXTDelegate _GetFragDataLocationEXT;

		public static  int GetFragDataLocationEXT( uint program, string name )
		{
			if (_GetFragDataLocationEXT == null) throw new Exception( "Extension method GetFragDataLocationEXT not found" );
		return  _GetFragDataLocationEXT( program, name );
		}
		public delegate void Uniform1uiEXTDelegate( int location, uint v0 ); //  extension method

		private static Uniform1uiEXTDelegate _Uniform1uiEXT;

		public static  void Uniform1uiEXT( int location, uint v0 )
		{
			if (_Uniform1uiEXT == null) throw new Exception( "Extension method Uniform1uiEXT not found" );
		 _Uniform1uiEXT( location, v0 );
		}
		public delegate void Uniform2uiEXTDelegate( int location, uint v0, uint v1 ); //  extension method

		private static Uniform2uiEXTDelegate _Uniform2uiEXT;

		public static  void Uniform2uiEXT( int location, uint v0, uint v1 )
		{
			if (_Uniform2uiEXT == null) throw new Exception( "Extension method Uniform2uiEXT not found" );
		 _Uniform2uiEXT( location, v0, v1 );
		}
		public delegate void Uniform3uiEXTDelegate( int location, uint v0, uint v1, uint v2 ); //  extension method

		private static Uniform3uiEXTDelegate _Uniform3uiEXT;

		public static  void Uniform3uiEXT( int location, uint v0, uint v1, uint v2 )
		{
			if (_Uniform3uiEXT == null) throw new Exception( "Extension method Uniform3uiEXT not found" );
		 _Uniform3uiEXT( location, v0, v1, v2 );
		}
		public delegate void Uniform4uiEXTDelegate( int location, uint v0, uint v1, uint v2, uint v3 ); //  extension method

		private static Uniform4uiEXTDelegate _Uniform4uiEXT;

		public static  void Uniform4uiEXT( int location, uint v0, uint v1, uint v2, uint v3 )
		{
			if (_Uniform4uiEXT == null) throw new Exception( "Extension method Uniform4uiEXT not found" );
		 _Uniform4uiEXT( location, v0, v1, v2, v3 );
		}
		public delegate void Uniform1uivEXTDelegate( int location, int count, uint[] value ); //  extension method

		private static Uniform1uivEXTDelegate _Uniform1uivEXT;

		public static  void Uniform1uivEXT( int location, int count, uint[] value )
		{
			if (_Uniform1uivEXT == null) throw new Exception( "Extension method Uniform1uivEXT not found" );
		 _Uniform1uivEXT( location, count, value );
		}
		public delegate void Uniform2uivEXTDelegate( int location, int count, uint[] value ); //  extension method

		private static Uniform2uivEXTDelegate _Uniform2uivEXT;

		public static  void Uniform2uivEXT( int location, int count, uint[] value )
		{
			if (_Uniform2uivEXT == null) throw new Exception( "Extension method Uniform2uivEXT not found" );
		 _Uniform2uivEXT( location, count, value );
		}
		public delegate void Uniform3uivEXTDelegate( int location, int count, uint[] value ); //  extension method

		private static Uniform3uivEXTDelegate _Uniform3uivEXT;

		public static  void Uniform3uivEXT( int location, int count, uint[] value )
		{
			if (_Uniform3uivEXT == null) throw new Exception( "Extension method Uniform3uivEXT not found" );
		 _Uniform3uivEXT( location, count, value );
		}
		public delegate void Uniform4uivEXTDelegate( int location, int count, uint[] value ); //  extension method

		private static Uniform4uivEXTDelegate _Uniform4uivEXT;

		public static  void Uniform4uivEXT( int location, int count, uint[] value )
		{
			if (_Uniform4uivEXT == null) throw new Exception( "Extension method Uniform4uivEXT not found" );
		 _Uniform4uivEXT( location, count, value );
		}
	}
}
