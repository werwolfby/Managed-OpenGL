using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeVERSION_2_0Init()
		{
			_BlendEquationSeparate = GetProcAdress< BlendEquationSeparateDelegate >( "glBlendEquationSeparate" );
			_DrawBuffers = GetProcAdress< DrawBuffersDelegate >( "glDrawBuffers" );
			_StencilOpSeparate = GetProcAdress< StencilOpSeparateDelegate >( "glStencilOpSeparate" );
			_StencilFuncSeparate = GetProcAdress< StencilFuncSeparateDelegate >( "glStencilFuncSeparate" );
			_StencilMaskSeparate = GetProcAdress< StencilMaskSeparateDelegate >( "glStencilMaskSeparate" );
			_AttachShader = GetProcAdress< AttachShaderDelegate >( "glAttachShader" );
			_BindAttribLocation = GetProcAdress< BindAttribLocationDelegate >( "glBindAttribLocation" );
			_CompileShader = GetProcAdress< CompileShaderDelegate >( "glCompileShader" );
			_CreateProgram = GetProcAdress< CreateProgramDelegate >( "glCreateProgram" );
			_CreateShader = GetProcAdress< CreateShaderDelegate >( "glCreateShader" );
			_DeleteProgram = GetProcAdress< DeleteProgramDelegate >( "glDeleteProgram" );
			_DeleteShader = GetProcAdress< DeleteShaderDelegate >( "glDeleteShader" );
			_DetachShader = GetProcAdress< DetachShaderDelegate >( "glDetachShader" );
			_DisableVertexAttribArray = GetProcAdress< DisableVertexAttribArrayDelegate >( "glDisableVertexAttribArray" );
			_EnableVertexAttribArray = GetProcAdress< EnableVertexAttribArrayDelegate >( "glEnableVertexAttribArray" );
			_GetActiveAttrib = GetProcAdress< GetActiveAttribDelegate >( "glGetActiveAttrib" );
			_GetActiveUniform = GetProcAdress< GetActiveUniformDelegate >( "glGetActiveUniform" );
			_GetAttachedShaders = GetProcAdress< GetAttachedShadersDelegate >( "glGetAttachedShaders" );
			_GetAttribLocation = GetProcAdress< GetAttribLocationDelegate >( "glGetAttribLocation" );
			_GetProgramiv = GetProcAdress< GetProgramivDelegate >( "glGetProgramiv" );
			_GetProgramInfoLog = GetProcAdress< GetProgramInfoLogDelegate >( "glGetProgramInfoLog" );
			_GetShaderiv = GetProcAdress< GetShaderivDelegate >( "glGetShaderiv" );
			_GetShaderInfoLog = GetProcAdress< GetShaderInfoLogDelegate >( "glGetShaderInfoLog" );
			_GetShaderSource = GetProcAdress< GetShaderSourceDelegate >( "glGetShaderSource" );
			_GetUniformLocation = GetProcAdress< GetUniformLocationDelegate >( "glGetUniformLocation" );
			_GetUniformfv = GetProcAdress< GetUniformfvDelegate >( "glGetUniformfv" );
			_GetUniformiv = GetProcAdress< GetUniformivDelegate >( "glGetUniformiv" );
			_GetVertexAttribdv = GetProcAdress< GetVertexAttribdvDelegate >( "glGetVertexAttribdv" );
			_GetVertexAttribfv = GetProcAdress< GetVertexAttribfvDelegate >( "glGetVertexAttribfv" );
			_GetVertexAttribiv = GetProcAdress< GetVertexAttribivDelegate >( "glGetVertexAttribiv" );
			_GetVertexAttribPointerv = GetProcAdress< GetVertexAttribPointervDelegate >( "glGetVertexAttribPointerv" );
			_IsProgram = GetProcAdress< IsProgramDelegate >( "glIsProgram" );
			_IsShader = GetProcAdress< IsShaderDelegate >( "glIsShader" );
			_LinkProgram = GetProcAdress< LinkProgramDelegate >( "glLinkProgram" );
			_ShaderSource = GetProcAdress< ShaderSourceDelegate >( "glShaderSource" );
			_UseProgram = GetProcAdress< UseProgramDelegate >( "glUseProgram" );
			_Uniform1f = GetProcAdress< Uniform1fDelegate >( "glUniform1f" );
			_Uniform2f = GetProcAdress< Uniform2fDelegate >( "glUniform2f" );
			_Uniform3f = GetProcAdress< Uniform3fDelegate >( "glUniform3f" );
			_Uniform4f = GetProcAdress< Uniform4fDelegate >( "glUniform4f" );
			_Uniform1i = GetProcAdress< Uniform1iDelegate >( "glUniform1i" );
			_Uniform2i = GetProcAdress< Uniform2iDelegate >( "glUniform2i" );
			_Uniform3i = GetProcAdress< Uniform3iDelegate >( "glUniform3i" );
			_Uniform4i = GetProcAdress< Uniform4iDelegate >( "glUniform4i" );
			_Uniform1fv = GetProcAdress< Uniform1fvDelegate >( "glUniform1fv" );
			_Uniform2fv = GetProcAdress< Uniform2fvDelegate >( "glUniform2fv" );
			_Uniform3fv = GetProcAdress< Uniform3fvDelegate >( "glUniform3fv" );
			_Uniform4fv = GetProcAdress< Uniform4fvDelegate >( "glUniform4fv" );
			_Uniform1iv = GetProcAdress< Uniform1ivDelegate >( "glUniform1iv" );
			_Uniform2iv = GetProcAdress< Uniform2ivDelegate >( "glUniform2iv" );
			_Uniform3iv = GetProcAdress< Uniform3ivDelegate >( "glUniform3iv" );
			_Uniform4iv = GetProcAdress< Uniform4ivDelegate >( "glUniform4iv" );
			_UniformMatrix2fv = GetProcAdress< UniformMatrix2fvDelegate >( "glUniformMatrix2fv" );
			_UniformMatrix3fv = GetProcAdress< UniformMatrix3fvDelegate >( "glUniformMatrix3fv" );
			_UniformMatrix4fv = GetProcAdress< UniformMatrix4fvDelegate >( "glUniformMatrix4fv" );
			_ValidateProgram = GetProcAdress< ValidateProgramDelegate >( "glValidateProgram" );
			_VertexAttrib1d = GetProcAdress< VertexAttrib1dDelegate >( "glVertexAttrib1d" );
			_VertexAttrib1dv = GetProcAdress< VertexAttrib1dvDelegate >( "glVertexAttrib1dv" );
			_VertexAttrib1f = GetProcAdress< VertexAttrib1fDelegate >( "glVertexAttrib1f" );
			_VertexAttrib1fv = GetProcAdress< VertexAttrib1fvDelegate >( "glVertexAttrib1fv" );
			_VertexAttrib1s = GetProcAdress< VertexAttrib1sDelegate >( "glVertexAttrib1s" );
			_VertexAttrib1sv = GetProcAdress< VertexAttrib1svDelegate >( "glVertexAttrib1sv" );
			_VertexAttrib2d = GetProcAdress< VertexAttrib2dDelegate >( "glVertexAttrib2d" );
			_VertexAttrib2dv = GetProcAdress< VertexAttrib2dvDelegate >( "glVertexAttrib2dv" );
			_VertexAttrib2f = GetProcAdress< VertexAttrib2fDelegate >( "glVertexAttrib2f" );
			_VertexAttrib2fv = GetProcAdress< VertexAttrib2fvDelegate >( "glVertexAttrib2fv" );
			_VertexAttrib2s = GetProcAdress< VertexAttrib2sDelegate >( "glVertexAttrib2s" );
			_VertexAttrib2sv = GetProcAdress< VertexAttrib2svDelegate >( "glVertexAttrib2sv" );
			_VertexAttrib3d = GetProcAdress< VertexAttrib3dDelegate >( "glVertexAttrib3d" );
			_VertexAttrib3dv = GetProcAdress< VertexAttrib3dvDelegate >( "glVertexAttrib3dv" );
			_VertexAttrib3f = GetProcAdress< VertexAttrib3fDelegate >( "glVertexAttrib3f" );
			_VertexAttrib3fv = GetProcAdress< VertexAttrib3fvDelegate >( "glVertexAttrib3fv" );
			_VertexAttrib3s = GetProcAdress< VertexAttrib3sDelegate >( "glVertexAttrib3s" );
			_VertexAttrib3sv = GetProcAdress< VertexAttrib3svDelegate >( "glVertexAttrib3sv" );
			_VertexAttrib4Nbv = GetProcAdress< VertexAttrib4NbvDelegate >( "glVertexAttrib4Nbv" );
			_VertexAttrib4Niv = GetProcAdress< VertexAttrib4NivDelegate >( "glVertexAttrib4Niv" );
			_VertexAttrib4Nsv = GetProcAdress< VertexAttrib4NsvDelegate >( "glVertexAttrib4Nsv" );
			_VertexAttrib4Nub = GetProcAdress< VertexAttrib4NubDelegate >( "glVertexAttrib4Nub" );
			_VertexAttrib4Nubv = GetProcAdress< VertexAttrib4NubvDelegate >( "glVertexAttrib4Nubv" );
			_VertexAttrib4Nuiv = GetProcAdress< VertexAttrib4NuivDelegate >( "glVertexAttrib4Nuiv" );
			_VertexAttrib4Nusv = GetProcAdress< VertexAttrib4NusvDelegate >( "glVertexAttrib4Nusv" );
			_VertexAttrib4bv = GetProcAdress< VertexAttrib4bvDelegate >( "glVertexAttrib4bv" );
			_VertexAttrib4d = GetProcAdress< VertexAttrib4dDelegate >( "glVertexAttrib4d" );
			_VertexAttrib4dv = GetProcAdress< VertexAttrib4dvDelegate >( "glVertexAttrib4dv" );
			_VertexAttrib4f = GetProcAdress< VertexAttrib4fDelegate >( "glVertexAttrib4f" );
			_VertexAttrib4fv = GetProcAdress< VertexAttrib4fvDelegate >( "glVertexAttrib4fv" );
			_VertexAttrib4iv = GetProcAdress< VertexAttrib4ivDelegate >( "glVertexAttrib4iv" );
			_VertexAttrib4s = GetProcAdress< VertexAttrib4sDelegate >( "glVertexAttrib4s" );
			_VertexAttrib4sv = GetProcAdress< VertexAttrib4svDelegate >( "glVertexAttrib4sv" );
			_VertexAttrib4ubv = GetProcAdress< VertexAttrib4ubvDelegate >( "glVertexAttrib4ubv" );
			_VertexAttrib4uiv = GetProcAdress< VertexAttrib4uivDelegate >( "glVertexAttrib4uiv" );
			_VertexAttrib4usv = GetProcAdress< VertexAttrib4usvDelegate >( "glVertexAttrib4usv" );
			_VertexAttribPointer = GetProcAdress< VertexAttribPointerDelegate >( "glVertexAttribPointer" );
		}


		public delegate void BlendEquationSeparateDelegate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha ); //  extension method

		private static BlendEquationSeparateDelegate _BlendEquationSeparate;

		public static  void BlendEquationSeparate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha )
		{
			if (_BlendEquationSeparate == null) throw new Exception( "Extension method BlendEquationSeparate not found" );
		 _BlendEquationSeparate( modeRGB, modeAlpha );
		}
		public delegate void DrawBuffersDelegate( int n, uint[] bufs ); //  extension method

		private static DrawBuffersDelegate _DrawBuffers;

		public static  void DrawBuffers( int n, uint[] bufs )
		{
			if (_DrawBuffers == null) throw new Exception( "Extension method DrawBuffers not found" );
		 _DrawBuffers( n, bufs );
		}
		public delegate void StencilOpSeparateDelegate( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass ); //  extension method

		private static StencilOpSeparateDelegate _StencilOpSeparate;

		public static  void StencilOpSeparate( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass )
		{
			if (_StencilOpSeparate == null) throw new Exception( "Extension method StencilOpSeparate not found" );
		 _StencilOpSeparate( face, sfail, dpfail, dppass );
		}
		public delegate void StencilFuncSeparateDelegate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask ); //  extension method

		private static StencilFuncSeparateDelegate _StencilFuncSeparate;

		public static  void StencilFuncSeparate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask )
		{
			if (_StencilFuncSeparate == null) throw new Exception( "Extension method StencilFuncSeparate not found" );
		 _StencilFuncSeparate( frontfunc, backfunc, @ref, mask );
		}
		public delegate void StencilMaskSeparateDelegate( uint face, uint mask ); //  extension method

		private static StencilMaskSeparateDelegate _StencilMaskSeparate;

		public static  void StencilMaskSeparate( uint face, uint mask )
		{
			if (_StencilMaskSeparate == null) throw new Exception( "Extension method StencilMaskSeparate not found" );
		 _StencilMaskSeparate( face, mask );
		}
		public delegate void AttachShaderDelegate( uint program, uint shader ); //  extension method

		private static AttachShaderDelegate _AttachShader;

		public static  void AttachShader( uint program, uint shader )
		{
			if (_AttachShader == null) throw new Exception( "Extension method AttachShader not found" );
		 _AttachShader( program, shader );
		}
		public delegate void BindAttribLocationDelegate( uint program, uint index, string name ); //  extension method

		private static BindAttribLocationDelegate _BindAttribLocation;

		public static  void BindAttribLocation( uint program, uint index, string name )
		{
			if (_BindAttribLocation == null) throw new Exception( "Extension method BindAttribLocation not found" );
		 _BindAttribLocation( program, index, name );
		}
		public delegate void CompileShaderDelegate( uint shader ); //  extension method

		private static CompileShaderDelegate _CompileShader;

		public static  void CompileShader( uint shader )
		{
			if (_CompileShader == null) throw new Exception( "Extension method CompileShader not found" );
		 _CompileShader( shader );
		}
		public delegate uint CreateProgramDelegate(  ); //  extension method

		private static CreateProgramDelegate _CreateProgram;

		public static  uint CreateProgram(  )
		{
			if (_CreateProgram == null) throw new Exception( "Extension method CreateProgram not found" );
		return  _CreateProgram(  );
		}
		public delegate uint CreateShaderDelegate( uint type ); //  extension method

		private static CreateShaderDelegate _CreateShader;

		public static  uint CreateShader( uint type )
		{
			if (_CreateShader == null) throw new Exception( "Extension method CreateShader not found" );
		return  _CreateShader( type );
		}
		public delegate void DeleteProgramDelegate( uint program ); //  extension method

		private static DeleteProgramDelegate _DeleteProgram;

		public static  void DeleteProgram( uint program )
		{
			if (_DeleteProgram == null) throw new Exception( "Extension method DeleteProgram not found" );
		 _DeleteProgram( program );
		}
		public delegate void DeleteShaderDelegate( uint shader ); //  extension method

		private static DeleteShaderDelegate _DeleteShader;

		public static  void DeleteShader( uint shader )
		{
			if (_DeleteShader == null) throw new Exception( "Extension method DeleteShader not found" );
		 _DeleteShader( shader );
		}
		public delegate void DetachShaderDelegate( uint program, uint shader ); //  extension method

		private static DetachShaderDelegate _DetachShader;

		public static  void DetachShader( uint program, uint shader )
		{
			if (_DetachShader == null) throw new Exception( "Extension method DetachShader not found" );
		 _DetachShader( program, shader );
		}
		public delegate void DisableVertexAttribArrayDelegate( uint index ); //  extension method

		private static DisableVertexAttribArrayDelegate _DisableVertexAttribArray;

		public static  void DisableVertexAttribArray( uint index )
		{
			if (_DisableVertexAttribArray == null) throw new Exception( "Extension method DisableVertexAttribArray not found" );
		 _DisableVertexAttribArray( index );
		}
		public delegate void EnableVertexAttribArrayDelegate( uint index ); //  extension method

		private static EnableVertexAttribArrayDelegate _EnableVertexAttribArray;

		public static  void EnableVertexAttribArray( uint index )
		{
			if (_EnableVertexAttribArray == null) throw new Exception( "Extension method EnableVertexAttribArray not found" );
		 _EnableVertexAttribArray( index );
		}
		public delegate void GetActiveAttribDelegate( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name ); //  extension method

		private static GetActiveAttribDelegate _GetActiveAttrib;

		public static  void GetActiveAttrib( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name )
		{
			if (_GetActiveAttrib == null) throw new Exception( "Extension method GetActiveAttrib not found" );
		 _GetActiveAttrib( program, index, bufSize, length, size, type, name );
		}
		public delegate void GetActiveUniformDelegate( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name ); //  extension method

		private static GetActiveUniformDelegate _GetActiveUniform;

		public static  void GetActiveUniform( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name )
		{
			if (_GetActiveUniform == null) throw new Exception( "Extension method GetActiveUniform not found" );
		 _GetActiveUniform( program, index, bufSize, length, size, type, name );
		}
		public delegate void GetAttachedShadersDelegate( uint program, int maxCount, [Out]int[] count, [Out]uint[] obj ); //  extension method

		private static GetAttachedShadersDelegate _GetAttachedShaders;

		public static  void GetAttachedShaders( uint program, int maxCount, [Out]int[] count, [Out]uint[] obj )
		{
			if (_GetAttachedShaders == null) throw new Exception( "Extension method GetAttachedShaders not found" );
		 _GetAttachedShaders( program, maxCount, count, obj );
		}
		public delegate int GetAttribLocationDelegate( uint program, string name ); //  extension method

		private static GetAttribLocationDelegate _GetAttribLocation;

		public static  int GetAttribLocation( uint program, string name )
		{
			if (_GetAttribLocation == null) throw new Exception( "Extension method GetAttribLocation not found" );
		return  _GetAttribLocation( program, name );
		}
		public delegate void GetProgramivDelegate( uint program, uint pname, [Out]int[] @params ); //  extension method

		private static GetProgramivDelegate _GetProgramiv;

		public static  void GetProgramiv( uint program, uint pname, [Out]int[] @params )
		{
			if (_GetProgramiv == null) throw new Exception( "Extension method GetProgramiv not found" );
		 _GetProgramiv( program, pname, @params );
		}
		public delegate void GetProgramInfoLogDelegate( uint program, int bufSize, [Out]int[] length, [Out]string infoLog ); //  extension method

		private static GetProgramInfoLogDelegate _GetProgramInfoLog;

		public static  void GetProgramInfoLog( uint program, int bufSize, [Out]int[] length, [Out]string infoLog )
		{
			if (_GetProgramInfoLog == null) throw new Exception( "Extension method GetProgramInfoLog not found" );
		 _GetProgramInfoLog( program, bufSize, length, infoLog );
		}
		public delegate void GetShaderivDelegate( uint shader, uint pname, [Out]int[] @params ); //  extension method

		private static GetShaderivDelegate _GetShaderiv;

		public static  void GetShaderiv( uint shader, uint pname, [Out]int[] @params )
		{
			if (_GetShaderiv == null) throw new Exception( "Extension method GetShaderiv not found" );
		 _GetShaderiv( shader, pname, @params );
		}
		public delegate void GetShaderInfoLogDelegate( uint shader, int bufSize, [Out]int[] length, [Out]string infoLog ); //  extension method

		private static GetShaderInfoLogDelegate _GetShaderInfoLog;

		public static  void GetShaderInfoLog( uint shader, int bufSize, [Out]int[] length, [Out]string infoLog )
		{
			if (_GetShaderInfoLog == null) throw new Exception( "Extension method GetShaderInfoLog not found" );
		 _GetShaderInfoLog( shader, bufSize, length, infoLog );
		}
		public delegate void GetShaderSourceDelegate( uint shader, int bufSize, [Out]int[] length, [Out]string source ); //  extension method

		private static GetShaderSourceDelegate _GetShaderSource;

		public static  void GetShaderSource( uint shader, int bufSize, [Out]int[] length, [Out]string source )
		{
			if (_GetShaderSource == null) throw new Exception( "Extension method GetShaderSource not found" );
		 _GetShaderSource( shader, bufSize, length, source );
		}
		public delegate int GetUniformLocationDelegate( uint program, string name ); //  extension method

		private static GetUniformLocationDelegate _GetUniformLocation;

		public static  int GetUniformLocation( uint program, string name )
		{
			if (_GetUniformLocation == null) throw new Exception( "Extension method GetUniformLocation not found" );
		return  _GetUniformLocation( program, name );
		}
		public delegate void GetUniformfvDelegate( uint program, int location, [Out]float[] @params ); //  extension method

		private static GetUniformfvDelegate _GetUniformfv;

		public static  void GetUniformfv( uint program, int location, [Out]float[] @params )
		{
			if (_GetUniformfv == null) throw new Exception( "Extension method GetUniformfv not found" );
		 _GetUniformfv( program, location, @params );
		}
		public delegate void GetUniformivDelegate( uint program, int location, [Out]int[] @params ); //  extension method

		private static GetUniformivDelegate _GetUniformiv;

		public static  void GetUniformiv( uint program, int location, [Out]int[] @params )
		{
			if (_GetUniformiv == null) throw new Exception( "Extension method GetUniformiv not found" );
		 _GetUniformiv( program, location, @params );
		}
		public delegate void GetVertexAttribdvDelegate( uint index, uint pname, [Out]double[] @params ); //  extension method

		private static GetVertexAttribdvDelegate _GetVertexAttribdv;

		public static  void GetVertexAttribdv( uint index, uint pname, [Out]double[] @params )
		{
			if (_GetVertexAttribdv == null) throw new Exception( "Extension method GetVertexAttribdv not found" );
		 _GetVertexAttribdv( index, pname, @params );
		}
		public delegate void GetVertexAttribfvDelegate( uint index, uint pname, [Out]float[] @params ); //  extension method

		private static GetVertexAttribfvDelegate _GetVertexAttribfv;

		public static  void GetVertexAttribfv( uint index, uint pname, [Out]float[] @params )
		{
			if (_GetVertexAttribfv == null) throw new Exception( "Extension method GetVertexAttribfv not found" );
		 _GetVertexAttribfv( index, pname, @params );
		}
		public delegate void GetVertexAttribivDelegate( uint index, uint pname, [Out]int[] @params ); //  extension method

		private static GetVertexAttribivDelegate _GetVertexAttribiv;

		public static  void GetVertexAttribiv( uint index, uint pname, [Out]int[] @params )
		{
			if (_GetVertexAttribiv == null) throw new Exception( "Extension method GetVertexAttribiv not found" );
		 _GetVertexAttribiv( index, pname, @params );
		}
		public unsafe delegate void GetVertexAttribPointervDelegate( uint index, uint pname, [Out]void** pointer ); //  extension method

		private static GetVertexAttribPointervDelegate _GetVertexAttribPointerv;

		public static unsafe  void GetVertexAttribPointerv( uint index, uint pname, [Out]void** pointer )
		{
			if (_GetVertexAttribPointerv == null) throw new Exception( "Extension method GetVertexAttribPointerv not found" );
		 _GetVertexAttribPointerv( index, pname, pointer );
		}
		public delegate bool IsProgramDelegate( uint program ); //  extension method

		private static IsProgramDelegate _IsProgram;

		public static  bool IsProgram( uint program )
		{
			if (_IsProgram == null) throw new Exception( "Extension method IsProgram not found" );
		return  _IsProgram( program );
		}
		public delegate bool IsShaderDelegate( uint shader ); //  extension method

		private static IsShaderDelegate _IsShader;

		public static  bool IsShader( uint shader )
		{
			if (_IsShader == null) throw new Exception( "Extension method IsShader not found" );
		return  _IsShader( shader );
		}
		public delegate void LinkProgramDelegate( uint program ); //  extension method

		private static LinkProgramDelegate _LinkProgram;

		public static  void LinkProgram( uint program )
		{
			if (_LinkProgram == null) throw new Exception( "Extension method LinkProgram not found" );
		 _LinkProgram( program );
		}
		public delegate void ShaderSourceDelegate( uint shader, int count, string @string, int[] length ); //  extension method

		private static ShaderSourceDelegate _ShaderSource;

		public static  void ShaderSource( uint shader, int count, string @string, int[] length )
		{
			if (_ShaderSource == null) throw new Exception( "Extension method ShaderSource not found" );
		 _ShaderSource( shader, count, @string, length );
		}
		public delegate void UseProgramDelegate( uint program ); //  extension method

		private static UseProgramDelegate _UseProgram;

		public static  void UseProgram( uint program )
		{
			if (_UseProgram == null) throw new Exception( "Extension method UseProgram not found" );
		 _UseProgram( program );
		}
		public delegate void Uniform1fDelegate( int location, float v0 ); //  extension method

		private static Uniform1fDelegate _Uniform1f;

		public static  void Uniform1f( int location, float v0 )
		{
			if (_Uniform1f == null) throw new Exception( "Extension method Uniform1f not found" );
		 _Uniform1f( location, v0 );
		}
		public delegate void Uniform2fDelegate( int location, float v0, float v1 ); //  extension method

		private static Uniform2fDelegate _Uniform2f;

		public static  void Uniform2f( int location, float v0, float v1 )
		{
			if (_Uniform2f == null) throw new Exception( "Extension method Uniform2f not found" );
		 _Uniform2f( location, v0, v1 );
		}
		public delegate void Uniform3fDelegate( int location, float v0, float v1, float v2 ); //  extension method

		private static Uniform3fDelegate _Uniform3f;

		public static  void Uniform3f( int location, float v0, float v1, float v2 )
		{
			if (_Uniform3f == null) throw new Exception( "Extension method Uniform3f not found" );
		 _Uniform3f( location, v0, v1, v2 );
		}
		public delegate void Uniform4fDelegate( int location, float v0, float v1, float v2, float v3 ); //  extension method

		private static Uniform4fDelegate _Uniform4f;

		public static  void Uniform4f( int location, float v0, float v1, float v2, float v3 )
		{
			if (_Uniform4f == null) throw new Exception( "Extension method Uniform4f not found" );
		 _Uniform4f( location, v0, v1, v2, v3 );
		}
		public delegate void Uniform1iDelegate( int location, int v0 ); //  extension method

		private static Uniform1iDelegate _Uniform1i;

		public static  void Uniform1i( int location, int v0 )
		{
			if (_Uniform1i == null) throw new Exception( "Extension method Uniform1i not found" );
		 _Uniform1i( location, v0 );
		}
		public delegate void Uniform2iDelegate( int location, int v0, int v1 ); //  extension method

		private static Uniform2iDelegate _Uniform2i;

		public static  void Uniform2i( int location, int v0, int v1 )
		{
			if (_Uniform2i == null) throw new Exception( "Extension method Uniform2i not found" );
		 _Uniform2i( location, v0, v1 );
		}
		public delegate void Uniform3iDelegate( int location, int v0, int v1, int v2 ); //  extension method

		private static Uniform3iDelegate _Uniform3i;

		public static  void Uniform3i( int location, int v0, int v1, int v2 )
		{
			if (_Uniform3i == null) throw new Exception( "Extension method Uniform3i not found" );
		 _Uniform3i( location, v0, v1, v2 );
		}
		public delegate void Uniform4iDelegate( int location, int v0, int v1, int v2, int v3 ); //  extension method

		private static Uniform4iDelegate _Uniform4i;

		public static  void Uniform4i( int location, int v0, int v1, int v2, int v3 )
		{
			if (_Uniform4i == null) throw new Exception( "Extension method Uniform4i not found" );
		 _Uniform4i( location, v0, v1, v2, v3 );
		}
		public delegate void Uniform1fvDelegate( int location, int count, float[] value ); //  extension method

		private static Uniform1fvDelegate _Uniform1fv;

		public static  void Uniform1fv( int location, int count, float[] value )
		{
			if (_Uniform1fv == null) throw new Exception( "Extension method Uniform1fv not found" );
		 _Uniform1fv( location, count, value );
		}
		public delegate void Uniform2fvDelegate( int location, int count, float[] value ); //  extension method

		private static Uniform2fvDelegate _Uniform2fv;

		public static  void Uniform2fv( int location, int count, float[] value )
		{
			if (_Uniform2fv == null) throw new Exception( "Extension method Uniform2fv not found" );
		 _Uniform2fv( location, count, value );
		}
		public delegate void Uniform3fvDelegate( int location, int count, float[] value ); //  extension method

		private static Uniform3fvDelegate _Uniform3fv;

		public static  void Uniform3fv( int location, int count, float[] value )
		{
			if (_Uniform3fv == null) throw new Exception( "Extension method Uniform3fv not found" );
		 _Uniform3fv( location, count, value );
		}
		public delegate void Uniform4fvDelegate( int location, int count, float[] value ); //  extension method

		private static Uniform4fvDelegate _Uniform4fv;

		public static  void Uniform4fv( int location, int count, float[] value )
		{
			if (_Uniform4fv == null) throw new Exception( "Extension method Uniform4fv not found" );
		 _Uniform4fv( location, count, value );
		}
		public delegate void Uniform1ivDelegate( int location, int count, int[] value ); //  extension method

		private static Uniform1ivDelegate _Uniform1iv;

		public static  void Uniform1iv( int location, int count, int[] value )
		{
			if (_Uniform1iv == null) throw new Exception( "Extension method Uniform1iv not found" );
		 _Uniform1iv( location, count, value );
		}
		public delegate void Uniform2ivDelegate( int location, int count, int[] value ); //  extension method

		private static Uniform2ivDelegate _Uniform2iv;

		public static  void Uniform2iv( int location, int count, int[] value )
		{
			if (_Uniform2iv == null) throw new Exception( "Extension method Uniform2iv not found" );
		 _Uniform2iv( location, count, value );
		}
		public delegate void Uniform3ivDelegate( int location, int count, int[] value ); //  extension method

		private static Uniform3ivDelegate _Uniform3iv;

		public static  void Uniform3iv( int location, int count, int[] value )
		{
			if (_Uniform3iv == null) throw new Exception( "Extension method Uniform3iv not found" );
		 _Uniform3iv( location, count, value );
		}
		public delegate void Uniform4ivDelegate( int location, int count, int[] value ); //  extension method

		private static Uniform4ivDelegate _Uniform4iv;

		public static  void Uniform4iv( int location, int count, int[] value )
		{
			if (_Uniform4iv == null) throw new Exception( "Extension method Uniform4iv not found" );
		 _Uniform4iv( location, count, value );
		}
		public delegate void UniformMatrix2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix2fvDelegate _UniformMatrix2fv;

		public static  void UniformMatrix2fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix2fv == null) throw new Exception( "Extension method UniformMatrix2fv not found" );
		 _UniformMatrix2fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix3fvDelegate _UniformMatrix3fv;

		public static  void UniformMatrix3fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix3fv == null) throw new Exception( "Extension method UniformMatrix3fv not found" );
		 _UniformMatrix3fv( location, count, transpose, value );
		}
		public delegate void UniformMatrix4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method

		private static UniformMatrix4fvDelegate _UniformMatrix4fv;

		public static  void UniformMatrix4fv( int location, int count, bool transpose, float[] value )
		{
			if (_UniformMatrix4fv == null) throw new Exception( "Extension method UniformMatrix4fv not found" );
		 _UniformMatrix4fv( location, count, transpose, value );
		}
		public delegate void ValidateProgramDelegate( uint program ); //  extension method

		private static ValidateProgramDelegate _ValidateProgram;

		public static  void ValidateProgram( uint program )
		{
			if (_ValidateProgram == null) throw new Exception( "Extension method ValidateProgram not found" );
		 _ValidateProgram( program );
		}
		public delegate void VertexAttrib1dDelegate( uint index, double x ); //  extension method

		private static VertexAttrib1dDelegate _VertexAttrib1d;

		public static  void VertexAttrib1d( uint index, double x )
		{
			if (_VertexAttrib1d == null) throw new Exception( "Extension method VertexAttrib1d not found" );
		 _VertexAttrib1d( index, x );
		}
		public delegate void VertexAttrib1dvDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib1dvDelegate _VertexAttrib1dv;

		public static  void VertexAttrib1dv( uint index, double[] v )
		{
			if (_VertexAttrib1dv == null) throw new Exception( "Extension method VertexAttrib1dv not found" );
		 _VertexAttrib1dv( index, v );
		}
		public delegate void VertexAttrib1fDelegate( uint index, float x ); //  extension method

		private static VertexAttrib1fDelegate _VertexAttrib1f;

		public static  void VertexAttrib1f( uint index, float x )
		{
			if (_VertexAttrib1f == null) throw new Exception( "Extension method VertexAttrib1f not found" );
		 _VertexAttrib1f( index, x );
		}
		public delegate void VertexAttrib1fvDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib1fvDelegate _VertexAttrib1fv;

		public static  void VertexAttrib1fv( uint index, float[] v )
		{
			if (_VertexAttrib1fv == null) throw new Exception( "Extension method VertexAttrib1fv not found" );
		 _VertexAttrib1fv( index, v );
		}
		public delegate void VertexAttrib1sDelegate( uint index, short x ); //  extension method

		private static VertexAttrib1sDelegate _VertexAttrib1s;

		public static  void VertexAttrib1s( uint index, short x )
		{
			if (_VertexAttrib1s == null) throw new Exception( "Extension method VertexAttrib1s not found" );
		 _VertexAttrib1s( index, x );
		}
		public delegate void VertexAttrib1svDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib1svDelegate _VertexAttrib1sv;

		public static  void VertexAttrib1sv( uint index, short[] v )
		{
			if (_VertexAttrib1sv == null) throw new Exception( "Extension method VertexAttrib1sv not found" );
		 _VertexAttrib1sv( index, v );
		}
		public delegate void VertexAttrib2dDelegate( uint index, double x, double y ); //  extension method

		private static VertexAttrib2dDelegate _VertexAttrib2d;

		public static  void VertexAttrib2d( uint index, double x, double y )
		{
			if (_VertexAttrib2d == null) throw new Exception( "Extension method VertexAttrib2d not found" );
		 _VertexAttrib2d( index, x, y );
		}
		public delegate void VertexAttrib2dvDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib2dvDelegate _VertexAttrib2dv;

		public static  void VertexAttrib2dv( uint index, double[] v )
		{
			if (_VertexAttrib2dv == null) throw new Exception( "Extension method VertexAttrib2dv not found" );
		 _VertexAttrib2dv( index, v );
		}
		public delegate void VertexAttrib2fDelegate( uint index, float x, float y ); //  extension method

		private static VertexAttrib2fDelegate _VertexAttrib2f;

		public static  void VertexAttrib2f( uint index, float x, float y )
		{
			if (_VertexAttrib2f == null) throw new Exception( "Extension method VertexAttrib2f not found" );
		 _VertexAttrib2f( index, x, y );
		}
		public delegate void VertexAttrib2fvDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib2fvDelegate _VertexAttrib2fv;

		public static  void VertexAttrib2fv( uint index, float[] v )
		{
			if (_VertexAttrib2fv == null) throw new Exception( "Extension method VertexAttrib2fv not found" );
		 _VertexAttrib2fv( index, v );
		}
		public delegate void VertexAttrib2sDelegate( uint index, short x, short y ); //  extension method

		private static VertexAttrib2sDelegate _VertexAttrib2s;

		public static  void VertexAttrib2s( uint index, short x, short y )
		{
			if (_VertexAttrib2s == null) throw new Exception( "Extension method VertexAttrib2s not found" );
		 _VertexAttrib2s( index, x, y );
		}
		public delegate void VertexAttrib2svDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib2svDelegate _VertexAttrib2sv;

		public static  void VertexAttrib2sv( uint index, short[] v )
		{
			if (_VertexAttrib2sv == null) throw new Exception( "Extension method VertexAttrib2sv not found" );
		 _VertexAttrib2sv( index, v );
		}
		public delegate void VertexAttrib3dDelegate( uint index, double x, double y, double z ); //  extension method

		private static VertexAttrib3dDelegate _VertexAttrib3d;

		public static  void VertexAttrib3d( uint index, double x, double y, double z )
		{
			if (_VertexAttrib3d == null) throw new Exception( "Extension method VertexAttrib3d not found" );
		 _VertexAttrib3d( index, x, y, z );
		}
		public delegate void VertexAttrib3dvDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib3dvDelegate _VertexAttrib3dv;

		public static  void VertexAttrib3dv( uint index, double[] v )
		{
			if (_VertexAttrib3dv == null) throw new Exception( "Extension method VertexAttrib3dv not found" );
		 _VertexAttrib3dv( index, v );
		}
		public delegate void VertexAttrib3fDelegate( uint index, float x, float y, float z ); //  extension method

		private static VertexAttrib3fDelegate _VertexAttrib3f;

		public static  void VertexAttrib3f( uint index, float x, float y, float z )
		{
			if (_VertexAttrib3f == null) throw new Exception( "Extension method VertexAttrib3f not found" );
		 _VertexAttrib3f( index, x, y, z );
		}
		public delegate void VertexAttrib3fvDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib3fvDelegate _VertexAttrib3fv;

		public static  void VertexAttrib3fv( uint index, float[] v )
		{
			if (_VertexAttrib3fv == null) throw new Exception( "Extension method VertexAttrib3fv not found" );
		 _VertexAttrib3fv( index, v );
		}
		public delegate void VertexAttrib3sDelegate( uint index, short x, short y, short z ); //  extension method

		private static VertexAttrib3sDelegate _VertexAttrib3s;

		public static  void VertexAttrib3s( uint index, short x, short y, short z )
		{
			if (_VertexAttrib3s == null) throw new Exception( "Extension method VertexAttrib3s not found" );
		 _VertexAttrib3s( index, x, y, z );
		}
		public delegate void VertexAttrib3svDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib3svDelegate _VertexAttrib3sv;

		public static  void VertexAttrib3sv( uint index, short[] v )
		{
			if (_VertexAttrib3sv == null) throw new Exception( "Extension method VertexAttrib3sv not found" );
		 _VertexAttrib3sv( index, v );
		}
		public delegate void VertexAttrib4NbvDelegate( uint index, sbyte[] v ); //  extension method

		private static VertexAttrib4NbvDelegate _VertexAttrib4Nbv;

		public static  void VertexAttrib4Nbv( uint index, sbyte[] v )
		{
			if (_VertexAttrib4Nbv == null) throw new Exception( "Extension method VertexAttrib4Nbv not found" );
		 _VertexAttrib4Nbv( index, v );
		}
		public delegate void VertexAttrib4NivDelegate( uint index, int[] v ); //  extension method

		private static VertexAttrib4NivDelegate _VertexAttrib4Niv;

		public static  void VertexAttrib4Niv( uint index, int[] v )
		{
			if (_VertexAttrib4Niv == null) throw new Exception( "Extension method VertexAttrib4Niv not found" );
		 _VertexAttrib4Niv( index, v );
		}
		public delegate void VertexAttrib4NsvDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib4NsvDelegate _VertexAttrib4Nsv;

		public static  void VertexAttrib4Nsv( uint index, short[] v )
		{
			if (_VertexAttrib4Nsv == null) throw new Exception( "Extension method VertexAttrib4Nsv not found" );
		 _VertexAttrib4Nsv( index, v );
		}
		public delegate void VertexAttrib4NubDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method

		private static VertexAttrib4NubDelegate _VertexAttrib4Nub;

		public static  void VertexAttrib4Nub( uint index, byte x, byte y, byte z, byte w )
		{
			if (_VertexAttrib4Nub == null) throw new Exception( "Extension method VertexAttrib4Nub not found" );
		 _VertexAttrib4Nub( index, x, y, z, w );
		}
		public delegate void VertexAttrib4NubvDelegate( uint index, byte[] v ); //  extension method

		private static VertexAttrib4NubvDelegate _VertexAttrib4Nubv;

		public static  void VertexAttrib4Nubv( uint index, byte[] v )
		{
			if (_VertexAttrib4Nubv == null) throw new Exception( "Extension method VertexAttrib4Nubv not found" );
		 _VertexAttrib4Nubv( index, v );
		}
		public delegate void VertexAttrib4NuivDelegate( uint index, uint[] v ); //  extension method

		private static VertexAttrib4NuivDelegate _VertexAttrib4Nuiv;

		public static  void VertexAttrib4Nuiv( uint index, uint[] v )
		{
			if (_VertexAttrib4Nuiv == null) throw new Exception( "Extension method VertexAttrib4Nuiv not found" );
		 _VertexAttrib4Nuiv( index, v );
		}
		public delegate void VertexAttrib4NusvDelegate( uint index, ushort[] v ); //  extension method

		private static VertexAttrib4NusvDelegate _VertexAttrib4Nusv;

		public static  void VertexAttrib4Nusv( uint index, ushort[] v )
		{
			if (_VertexAttrib4Nusv == null) throw new Exception( "Extension method VertexAttrib4Nusv not found" );
		 _VertexAttrib4Nusv( index, v );
		}
		public delegate void VertexAttrib4bvDelegate( uint index, sbyte[] v ); //  extension method

		private static VertexAttrib4bvDelegate _VertexAttrib4bv;

		public static  void VertexAttrib4bv( uint index, sbyte[] v )
		{
			if (_VertexAttrib4bv == null) throw new Exception( "Extension method VertexAttrib4bv not found" );
		 _VertexAttrib4bv( index, v );
		}
		public delegate void VertexAttrib4dDelegate( uint index, double x, double y, double z, double w ); //  extension method

		private static VertexAttrib4dDelegate _VertexAttrib4d;

		public static  void VertexAttrib4d( uint index, double x, double y, double z, double w )
		{
			if (_VertexAttrib4d == null) throw new Exception( "Extension method VertexAttrib4d not found" );
		 _VertexAttrib4d( index, x, y, z, w );
		}
		public delegate void VertexAttrib4dvDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib4dvDelegate _VertexAttrib4dv;

		public static  void VertexAttrib4dv( uint index, double[] v )
		{
			if (_VertexAttrib4dv == null) throw new Exception( "Extension method VertexAttrib4dv not found" );
		 _VertexAttrib4dv( index, v );
		}
		public delegate void VertexAttrib4fDelegate( uint index, float x, float y, float z, float w ); //  extension method

		private static VertexAttrib4fDelegate _VertexAttrib4f;

		public static  void VertexAttrib4f( uint index, float x, float y, float z, float w )
		{
			if (_VertexAttrib4f == null) throw new Exception( "Extension method VertexAttrib4f not found" );
		 _VertexAttrib4f( index, x, y, z, w );
		}
		public delegate void VertexAttrib4fvDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib4fvDelegate _VertexAttrib4fv;

		public static  void VertexAttrib4fv( uint index, float[] v )
		{
			if (_VertexAttrib4fv == null) throw new Exception( "Extension method VertexAttrib4fv not found" );
		 _VertexAttrib4fv( index, v );
		}
		public delegate void VertexAttrib4ivDelegate( uint index, int[] v ); //  extension method

		private static VertexAttrib4ivDelegate _VertexAttrib4iv;

		public static  void VertexAttrib4iv( uint index, int[] v )
		{
			if (_VertexAttrib4iv == null) throw new Exception( "Extension method VertexAttrib4iv not found" );
		 _VertexAttrib4iv( index, v );
		}
		public delegate void VertexAttrib4sDelegate( uint index, short x, short y, short z, short w ); //  extension method

		private static VertexAttrib4sDelegate _VertexAttrib4s;

		public static  void VertexAttrib4s( uint index, short x, short y, short z, short w )
		{
			if (_VertexAttrib4s == null) throw new Exception( "Extension method VertexAttrib4s not found" );
		 _VertexAttrib4s( index, x, y, z, w );
		}
		public delegate void VertexAttrib4svDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib4svDelegate _VertexAttrib4sv;

		public static  void VertexAttrib4sv( uint index, short[] v )
		{
			if (_VertexAttrib4sv == null) throw new Exception( "Extension method VertexAttrib4sv not found" );
		 _VertexAttrib4sv( index, v );
		}
		public delegate void VertexAttrib4ubvDelegate( uint index, byte[] v ); //  extension method

		private static VertexAttrib4ubvDelegate _VertexAttrib4ubv;

		public static  void VertexAttrib4ubv( uint index, byte[] v )
		{
			if (_VertexAttrib4ubv == null) throw new Exception( "Extension method VertexAttrib4ubv not found" );
		 _VertexAttrib4ubv( index, v );
		}
		public delegate void VertexAttrib4uivDelegate( uint index, uint[] v ); //  extension method

		private static VertexAttrib4uivDelegate _VertexAttrib4uiv;

		public static  void VertexAttrib4uiv( uint index, uint[] v )
		{
			if (_VertexAttrib4uiv == null) throw new Exception( "Extension method VertexAttrib4uiv not found" );
		 _VertexAttrib4uiv( index, v );
		}
		public delegate void VertexAttrib4usvDelegate( uint index, ushort[] v ); //  extension method

		private static VertexAttrib4usvDelegate _VertexAttrib4usv;

		public static  void VertexAttrib4usv( uint index, ushort[] v )
		{
			if (_VertexAttrib4usv == null) throw new Exception( "Extension method VertexAttrib4usv not found" );
		 _VertexAttrib4usv( index, v );
		}
		public unsafe delegate void VertexAttribPointerDelegate( uint index, int size, uint type, bool normalized, int stride, void* pointer ); //  extension method

		private static VertexAttribPointerDelegate _VertexAttribPointer;

		public static unsafe  void VertexAttribPointer( uint index, int size, uint type, bool normalized, int stride, void* pointer )
		{
			if (_VertexAttribPointer == null) throw new Exception( "Extension method VertexAttribPointer not found" );
		 _VertexAttribPointer( index, size, type, normalized, stride, pointer );
		}
	}
}
