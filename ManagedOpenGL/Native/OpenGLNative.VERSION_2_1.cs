using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_2_1Init()
		{
			_UniformMatrix2x3fv = GetProcAdress< UniformMatrix2x3fvDelegate >( "glUniformMatrix2x3fv" );
			_UniformMatrix3x2fv = GetProcAdress< UniformMatrix3x2fvDelegate >( "glUniformMatrix3x2fv" );
			_UniformMatrix2x4fv = GetProcAdress< UniformMatrix2x4fvDelegate >( "glUniformMatrix2x4fv" );
			_UniformMatrix4x2fv = GetProcAdress< UniformMatrix4x2fvDelegate >( "glUniformMatrix4x2fv" );
			_UniformMatrix3x4fv = GetProcAdress< UniformMatrix3x4fvDelegate >( "glUniformMatrix3x4fv" );
			_UniformMatrix4x3fv = GetProcAdress< UniformMatrix4x3fvDelegate >( "glUniformMatrix4x3fv" );
		}


		public delegate void UniformMatrix2x3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix2x3fvDelegate _UniformMatrix2x3fv;

		public static  void UniformMatrix2x3fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix2x3fv == null) throw new Exception( "Extension method UniformMatrix2x3fv not found" );
		 _UniformMatrix2x3fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix3x2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix3x2fvDelegate _UniformMatrix3x2fv;

		public static  void UniformMatrix3x2fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix3x2fv == null) throw new Exception( "Extension method UniformMatrix3x2fv not found" );
		 _UniformMatrix3x2fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix2x4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix2x4fvDelegate _UniformMatrix2x4fv;

		public static  void UniformMatrix2x4fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix2x4fv == null) throw new Exception( "Extension method UniformMatrix2x4fv not found" );
		 _UniformMatrix2x4fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix4x2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix4x2fvDelegate _UniformMatrix4x2fv;

		public static  void UniformMatrix4x2fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix4x2fv == null) throw new Exception( "Extension method UniformMatrix4x2fv not found" );
		 _UniformMatrix4x2fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix3x4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix3x4fvDelegate _UniformMatrix3x4fv;

		public static  void UniformMatrix3x4fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix3x4fv == null) throw new Exception( "Extension method UniformMatrix3x4fv not found" );
		 _UniformMatrix3x4fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix4x3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix4x3fvDelegate _UniformMatrix4x3fv;

		public static  void UniformMatrix4x3fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix4x3fv == null) throw new Exception( "Extension method UniformMatrix4x3fv not found" );
		 _UniformMatrix4x3fv( location, count, transpose, value );
		}
	}
}
