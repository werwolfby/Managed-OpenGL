using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_shader_objectsInit()
		{
			_DeleteObjectARB = GetProcAdress< DeleteObjectARBDelegate >( "glDeleteObjectARB" );
			_GetHandleARB = GetProcAdress< GetHandleARBDelegate >( "glGetHandleARB" );
			_DetachObjectARB = GetProcAdress< DetachObjectARBDelegate >( "glDetachObjectARB" );
			_CreateShaderObjectARB = GetProcAdress< CreateShaderObjectARBDelegate >( "glCreateShaderObjectARB" );
			_ShaderSourceARB = GetProcAdress< ShaderSourceARBDelegate >( "glShaderSourceARB" );
			_CompileShaderARB = GetProcAdress< CompileShaderARBDelegate >( "glCompileShaderARB" );
			_CreateProgramObjectARB = GetProcAdress< CreateProgramObjectARBDelegate >( "glCreateProgramObjectARB" );
			_AttachObjectARB = GetProcAdress< AttachObjectARBDelegate >( "glAttachObjectARB" );
			_LinkProgramARB = GetProcAdress< LinkProgramARBDelegate >( "glLinkProgramARB" );
			_UseProgramObjectARB = GetProcAdress< UseProgramObjectARBDelegate >( "glUseProgramObjectARB" );
			_ValidateProgramARB = GetProcAdress< ValidateProgramARBDelegate >( "glValidateProgramARB" );
			_Uniform1fARB = GetProcAdress< Uniform1fARBDelegate >( "glUniform1fARB" );
			_Uniform2fARB = GetProcAdress< Uniform2fARBDelegate >( "glUniform2fARB" );
			_Uniform3fARB = GetProcAdress< Uniform3fARBDelegate >( "glUniform3fARB" );
			_Uniform4fARB = GetProcAdress< Uniform4fARBDelegate >( "glUniform4fARB" );
			_Uniform1iARB = GetProcAdress< Uniform1iARBDelegate >( "glUniform1iARB" );
			_Uniform2iARB = GetProcAdress< Uniform2iARBDelegate >( "glUniform2iARB" );
			_Uniform3iARB = GetProcAdress< Uniform3iARBDelegate >( "glUniform3iARB" );
			_Uniform4iARB = GetProcAdress< Uniform4iARBDelegate >( "glUniform4iARB" );
			_Uniform1fvARB = GetProcAdress< Uniform1fvARBDelegate >( "glUniform1fvARB" );
			_Uniform2fvARB = GetProcAdress< Uniform2fvARBDelegate >( "glUniform2fvARB" );
			_Uniform3fvARB = GetProcAdress< Uniform3fvARBDelegate >( "glUniform3fvARB" );
			_Uniform4fvARB = GetProcAdress< Uniform4fvARBDelegate >( "glUniform4fvARB" );
			_Uniform1ivARB = GetProcAdress< Uniform1ivARBDelegate >( "glUniform1ivARB" );
			_Uniform2ivARB = GetProcAdress< Uniform2ivARBDelegate >( "glUniform2ivARB" );
			_Uniform3ivARB = GetProcAdress< Uniform3ivARBDelegate >( "glUniform3ivARB" );
			_Uniform4ivARB = GetProcAdress< Uniform4ivARBDelegate >( "glUniform4ivARB" );
			_UniformMatrix2fvARB = GetProcAdress< UniformMatrix2fvARBDelegate >( "glUniformMatrix2fvARB" );
			_UniformMatrix3fvARB = GetProcAdress< UniformMatrix3fvARBDelegate >( "glUniformMatrix3fvARB" );
			_UniformMatrix4fvARB = GetProcAdress< UniformMatrix4fvARBDelegate >( "glUniformMatrix4fvARB" );
			_GetObjectParameterfvARB = GetProcAdress< GetObjectParameterfvARBDelegate >( "glGetObjectParameterfvARB" );
			_GetObjectParameterivARB = GetProcAdress< GetObjectParameterivARBDelegate >( "glGetObjectParameterivARB" );
			_GetInfoLogARB = GetProcAdress< GetInfoLogARBDelegate >( "glGetInfoLogARB" );
			_GetAttachedObjectsARB = GetProcAdress< GetAttachedObjectsARBDelegate >( "glGetAttachedObjectsARB" );
			_GetUniformLocationARB = GetProcAdress< GetUniformLocationARBDelegate >( "glGetUniformLocationARB" );
			_GetActiveUniformARB = GetProcAdress< GetActiveUniformARBDelegate >( "glGetActiveUniformARB" );
			_GetUniformfvARB = GetProcAdress< GetUniformfvARBDelegate >( "glGetUniformfvARB" );
			_GetUniformivARB = GetProcAdress< GetUniformivARBDelegate >( "glGetUniformivARB" );
			_GetShaderSourceARB = GetProcAdress< GetShaderSourceARBDelegate >( "glGetShaderSourceARB" );
			
		}
		
	
		public delegate void DeleteObjectARBDelegate( uint obj ); //  extension method
		private static DeleteObjectARBDelegate _DeleteObjectARB;
		
		public static  void DeleteObjectARB( uint obj )
		{
			if (_DeleteObjectARB == null) throw new Exception( "Extension method DeleteObjectARB not found" );
			 _DeleteObjectARB( obj );
		}
		public delegate uint GetHandleARBDelegate( uint pname ); //  extension method
		private static GetHandleARBDelegate _GetHandleARB;
		
		public static  uint GetHandleARB( uint pname )
		{
			if (_GetHandleARB == null) throw new Exception( "Extension method GetHandleARB not found" );
			return  _GetHandleARB( pname );
		}
		public delegate void DetachObjectARBDelegate( uint containerObj, uint attachedObj ); //  extension method
		private static DetachObjectARBDelegate _DetachObjectARB;
		
		public static  void DetachObjectARB( uint containerObj, uint attachedObj )
		{
			if (_DetachObjectARB == null) throw new Exception( "Extension method DetachObjectARB not found" );
			 _DetachObjectARB( containerObj, attachedObj );
		}
		public delegate uint CreateShaderObjectARBDelegate( uint shaderType ); //  extension method
		private static CreateShaderObjectARBDelegate _CreateShaderObjectARB;
		
		public static  uint CreateShaderObjectARB( uint shaderType )
		{
			if (_CreateShaderObjectARB == null) throw new Exception( "Extension method CreateShaderObjectARB not found" );
			return  _CreateShaderObjectARB( shaderType );
		}
		public delegate void ShaderSourceARBDelegate( uint shaderObj, int count, string[] @string, int[] length ); //  extension method
		private static ShaderSourceARBDelegate _ShaderSourceARB;
		
		public static  void ShaderSourceARB( uint shaderObj, int count, string[] @string, int[] length )
		{
			if (_ShaderSourceARB == null) throw new Exception( "Extension method ShaderSourceARB not found" );
			 _ShaderSourceARB( shaderObj, count, @string, length );
		}
		public delegate void CompileShaderARBDelegate( uint shaderObj ); //  extension method
		private static CompileShaderARBDelegate _CompileShaderARB;
		
		public static  void CompileShaderARB( uint shaderObj )
		{
			if (_CompileShaderARB == null) throw new Exception( "Extension method CompileShaderARB not found" );
			 _CompileShaderARB( shaderObj );
		}
		public delegate uint CreateProgramObjectARBDelegate(  ); //  extension method
		private static CreateProgramObjectARBDelegate _CreateProgramObjectARB;
		
		public static  uint CreateProgramObjectARB(  )
		{
			if (_CreateProgramObjectARB == null) throw new Exception( "Extension method CreateProgramObjectARB not found" );
			return  _CreateProgramObjectARB(  );
		}
		public delegate void AttachObjectARBDelegate( uint containerObj, uint obj ); //  extension method
		private static AttachObjectARBDelegate _AttachObjectARB;
		
		public static  void AttachObjectARB( uint containerObj, uint obj )
		{
			if (_AttachObjectARB == null) throw new Exception( "Extension method AttachObjectARB not found" );
			 _AttachObjectARB( containerObj, obj );
		}
		public delegate void LinkProgramARBDelegate( uint programObj ); //  extension method
		private static LinkProgramARBDelegate _LinkProgramARB;
		
		public static  void LinkProgramARB( uint programObj )
		{
			if (_LinkProgramARB == null) throw new Exception( "Extension method LinkProgramARB not found" );
			 _LinkProgramARB( programObj );
		}
		public delegate void UseProgramObjectARBDelegate( uint programObj ); //  extension method
		private static UseProgramObjectARBDelegate _UseProgramObjectARB;
		
		public static  void UseProgramObjectARB( uint programObj )
		{
			if (_UseProgramObjectARB == null) throw new Exception( "Extension method UseProgramObjectARB not found" );
			 _UseProgramObjectARB( programObj );
		}
		public delegate void ValidateProgramARBDelegate( uint programObj ); //  extension method
		private static ValidateProgramARBDelegate _ValidateProgramARB;
		
		public static  void ValidateProgramARB( uint programObj )
		{
			if (_ValidateProgramARB == null) throw new Exception( "Extension method ValidateProgramARB not found" );
			 _ValidateProgramARB( programObj );
		}
		public delegate void Uniform1fARBDelegate( int location, float v0 ); //  extension method
		private static Uniform1fARBDelegate _Uniform1fARB;
		
		public static  void Uniform1fARB( int location, float v0 )
		{
			if (_Uniform1fARB == null) throw new Exception( "Extension method Uniform1fARB not found" );
			 _Uniform1fARB( location, v0 );
		}
		public delegate void Uniform2fARBDelegate( int location, float v0, float v1 ); //  extension method
		private static Uniform2fARBDelegate _Uniform2fARB;
		
		public static  void Uniform2fARB( int location, float v0, float v1 )
		{
			if (_Uniform2fARB == null) throw new Exception( "Extension method Uniform2fARB not found" );
			 _Uniform2fARB( location, v0, v1 );
		}
		public delegate void Uniform3fARBDelegate( int location, float v0, float v1, float v2 ); //  extension method
		private static Uniform3fARBDelegate _Uniform3fARB;
		
		public static  void Uniform3fARB( int location, float v0, float v1, float v2 )
		{
			if (_Uniform3fARB == null) throw new Exception( "Extension method Uniform3fARB not found" );
			 _Uniform3fARB( location, v0, v1, v2 );
		}
		public delegate void Uniform4fARBDelegate( int location, float v0, float v1, float v2, float v3 ); //  extension method
		private static Uniform4fARBDelegate _Uniform4fARB;
		
		public static  void Uniform4fARB( int location, float v0, float v1, float v2, float v3 )
		{
			if (_Uniform4fARB == null) throw new Exception( "Extension method Uniform4fARB not found" );
			 _Uniform4fARB( location, v0, v1, v2, v3 );
		}
		public delegate void Uniform1iARBDelegate( int location, int v0 ); //  extension method
		private static Uniform1iARBDelegate _Uniform1iARB;
		
		public static  void Uniform1iARB( int location, int v0 )
		{
			if (_Uniform1iARB == null) throw new Exception( "Extension method Uniform1iARB not found" );
			 _Uniform1iARB( location, v0 );
		}
		public delegate void Uniform2iARBDelegate( int location, int v0, int v1 ); //  extension method
		private static Uniform2iARBDelegate _Uniform2iARB;
		
		public static  void Uniform2iARB( int location, int v0, int v1 )
		{
			if (_Uniform2iARB == null) throw new Exception( "Extension method Uniform2iARB not found" );
			 _Uniform2iARB( location, v0, v1 );
		}
		public delegate void Uniform3iARBDelegate( int location, int v0, int v1, int v2 ); //  extension method
		private static Uniform3iARBDelegate _Uniform3iARB;
		
		public static  void Uniform3iARB( int location, int v0, int v1, int v2 )
		{
			if (_Uniform3iARB == null) throw new Exception( "Extension method Uniform3iARB not found" );
			 _Uniform3iARB( location, v0, v1, v2 );
		}
		public delegate void Uniform4iARBDelegate( int location, int v0, int v1, int v2, int v3 ); //  extension method
		private static Uniform4iARBDelegate _Uniform4iARB;
		
		public static  void Uniform4iARB( int location, int v0, int v1, int v2, int v3 )
		{
			if (_Uniform4iARB == null) throw new Exception( "Extension method Uniform4iARB not found" );
			 _Uniform4iARB( location, v0, v1, v2, v3 );
		}
		public delegate void Uniform1fvARBDelegate( int location, int count, float[] value ); //  extension method
		private static Uniform1fvARBDelegate _Uniform1fvARB;
		
		public static  void Uniform1fvARB( int location, int count, float[] value )
		{
			if (_Uniform1fvARB == null) throw new Exception( "Extension method Uniform1fvARB not found" );
			 _Uniform1fvARB( location, count, value );
		}
		public delegate void Uniform2fvARBDelegate( int location, int count, float[] value ); //  extension method
		private static Uniform2fvARBDelegate _Uniform2fvARB;
		
		public static  void Uniform2fvARB( int location, int count, float[] value )
		{
			if (_Uniform2fvARB == null) throw new Exception( "Extension method Uniform2fvARB not found" );
			 _Uniform2fvARB( location, count, value );
		}
		public delegate void Uniform3fvARBDelegate( int location, int count, float[] value ); //  extension method
		private static Uniform3fvARBDelegate _Uniform3fvARB;
		
		public static  void Uniform3fvARB( int location, int count, float[] value )
		{
			if (_Uniform3fvARB == null) throw new Exception( "Extension method Uniform3fvARB not found" );
			 _Uniform3fvARB( location, count, value );
		}
		public delegate void Uniform4fvARBDelegate( int location, int count, float[] value ); //  extension method
		private static Uniform4fvARBDelegate _Uniform4fvARB;
		
		public static  void Uniform4fvARB( int location, int count, float[] value )
		{
			if (_Uniform4fvARB == null) throw new Exception( "Extension method Uniform4fvARB not found" );
			 _Uniform4fvARB( location, count, value );
		}
		public delegate void Uniform1ivARBDelegate( int location, int count, int[] value ); //  extension method
		private static Uniform1ivARBDelegate _Uniform1ivARB;
		
		public static  void Uniform1ivARB( int location, int count, int[] value )
		{
			if (_Uniform1ivARB == null) throw new Exception( "Extension method Uniform1ivARB not found" );
			 _Uniform1ivARB( location, count, value );
		}
		public delegate void Uniform2ivARBDelegate( int location, int count, int[] value ); //  extension method
		private static Uniform2ivARBDelegate _Uniform2ivARB;
		
		public static  void Uniform2ivARB( int location, int count, int[] value )
		{
			if (_Uniform2ivARB == null) throw new Exception( "Extension method Uniform2ivARB not found" );
			 _Uniform2ivARB( location, count, value );
		}
		public delegate void Uniform3ivARBDelegate( int location, int count, int[] value ); //  extension method
		private static Uniform3ivARBDelegate _Uniform3ivARB;
		
		public static  void Uniform3ivARB( int location, int count, int[] value )
		{
			if (_Uniform3ivARB == null) throw new Exception( "Extension method Uniform3ivARB not found" );
			 _Uniform3ivARB( location, count, value );
		}
		public delegate void Uniform4ivARBDelegate( int location, int count, int[] value ); //  extension method
		private static Uniform4ivARBDelegate _Uniform4ivARB;
		
		public static  void Uniform4ivARB( int location, int count, int[] value )
		{
			if (_Uniform4ivARB == null) throw new Exception( "Extension method Uniform4ivARB not found" );
			 _Uniform4ivARB( location, count, value );
		}
		public delegate void UniformMatrix2fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		private static UniformMatrix2fvARBDelegate _UniformMatrix2fvARB;
		
		public static  void UniformMatrix2fvARB( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix2fvARB == null) throw new Exception( "Extension method UniformMatrix2fvARB not found" );
			 _UniformMatrix2fvARB( location, count, transpose, value );
		}
		public delegate void UniformMatrix3fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		private static UniformMatrix3fvARBDelegate _UniformMatrix3fvARB;
		
		public static  void UniformMatrix3fvARB( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix3fvARB == null) throw new Exception( "Extension method UniformMatrix3fvARB not found" );
			 _UniformMatrix3fvARB( location, count, transpose, value );
		}
		public delegate void UniformMatrix4fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		private static UniformMatrix4fvARBDelegate _UniformMatrix4fvARB;
		
		public static  void UniformMatrix4fvARB( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix4fvARB == null) throw new Exception( "Extension method UniformMatrix4fvARB not found" );
			 _UniformMatrix4fvARB( location, count, transpose, value );
		}
		public delegate void GetObjectParameterfvARBDelegate( uint obj, uint pname, [Out]float[] @params ); //  extension method
		private static GetObjectParameterfvARBDelegate _GetObjectParameterfvARB;
		
		public static  void GetObjectParameterfvARB( uint obj, uint pname, [Out]float[] @params )
		{
			if (_GetObjectParameterfvARB == null) throw new Exception( "Extension method GetObjectParameterfvARB not found" );
			 _GetObjectParameterfvARB( obj, pname, @params );
		}
		public delegate void GetObjectParameterivARBDelegate( uint obj, uint pname, [Out]int[] @params ); //  extension method
		private static GetObjectParameterivARBDelegate _GetObjectParameterivARB;
		
		public static  void GetObjectParameterivARB( uint obj, uint pname, [Out]int[] @params )
		{
			if (_GetObjectParameterivARB == null) throw new Exception( "Extension method GetObjectParameterivARB not found" );
			 _GetObjectParameterivARB( obj, pname, @params );
		}
		public delegate void GetInfoLogARBDelegate( uint obj, int maxLength, [Out]int[] length, [Out]char[] infoLog ); //  extension method
		private static GetInfoLogARBDelegate _GetInfoLogARB;
		
		public static  void GetInfoLogARB( uint obj, int maxLength, [Out]int[] length, [Out]char[] infoLog )
		{
			if (_GetInfoLogARB == null) throw new Exception( "Extension method GetInfoLogARB not found" );
			 _GetInfoLogARB( obj, maxLength, length, infoLog );
		}
		public delegate void GetAttachedObjectsARBDelegate( uint containerObj, int maxCount, [Out]int[] count, [Out]uint[] obj ); //  extension method
		private static GetAttachedObjectsARBDelegate _GetAttachedObjectsARB;
		
		public static  void GetAttachedObjectsARB( uint containerObj, int maxCount, [Out]int[] count, [Out]uint[] obj )
		{
			if (_GetAttachedObjectsARB == null) throw new Exception( "Extension method GetAttachedObjectsARB not found" );
			 _GetAttachedObjectsARB( containerObj, maxCount, count, obj );
		}
		public delegate int GetUniformLocationARBDelegate( uint programObj, string name ); //  extension method
		private static GetUniformLocationARBDelegate _GetUniformLocationARB;
		
		public static  int GetUniformLocationARB( uint programObj, string name )
		{
			if (_GetUniformLocationARB == null) throw new Exception( "Extension method GetUniformLocationARB not found" );
			return  _GetUniformLocationARB( programObj, name );
		}
		public delegate void GetActiveUniformARBDelegate( uint programObj, uint index, int maxLength, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]char[] name ); //  extension method
		private static GetActiveUniformARBDelegate _GetActiveUniformARB;
		
		public static  void GetActiveUniformARB( uint programObj, uint index, int maxLength, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]char[] name )
		{
			if (_GetActiveUniformARB == null) throw new Exception( "Extension method GetActiveUniformARB not found" );
			 _GetActiveUniformARB( programObj, index, maxLength, length, size, type, name );
		}
		public delegate void GetUniformfvARBDelegate( uint programObj, int location, [Out]float[] @params ); //  extension method
		private static GetUniformfvARBDelegate _GetUniformfvARB;
		
		public static  void GetUniformfvARB( uint programObj, int location, [Out]float[] @params )
		{
			if (_GetUniformfvARB == null) throw new Exception( "Extension method GetUniformfvARB not found" );
			 _GetUniformfvARB( programObj, location, @params );
		}
		public delegate void GetUniformivARBDelegate( uint programObj, int location, [Out]int[] @params ); //  extension method
		private static GetUniformivARBDelegate _GetUniformivARB;
		
		public static  void GetUniformivARB( uint programObj, int location, [Out]int[] @params )
		{
			if (_GetUniformivARB == null) throw new Exception( "Extension method GetUniformivARB not found" );
			 _GetUniformivARB( programObj, location, @params );
		}
		public delegate void GetShaderSourceARBDelegate( uint obj, int maxLength, [Out]int[] length, [Out]char[] source ); //  extension method
		private static GetShaderSourceARBDelegate _GetShaderSourceARB;
		
		public static  void GetShaderSourceARB( uint obj, int maxLength, [Out]int[] length, [Out]char[] source )
		{
			if (_GetShaderSourceARB == null) throw new Exception( "Extension method GetShaderSourceARB not found" );
			 _GetShaderSourceARB( obj, maxLength, length, source );
		}
	}
}

