using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static class OpenGLNative
	{
		unsafe static OpenGLNative()
		{
			BlendEquationSeparate = GetProcAdress< BlendEquationSeparateDelegate >( "BlendEquationSeparate" );
			DrawBuffers = GetProcAdress< DrawBuffersDelegate >( "DrawBuffers" );
			StencilOpSeparate = GetProcAdress< StencilOpSeparateDelegate >( "StencilOpSeparate" );
			StencilFuncSeparate = GetProcAdress< StencilFuncSeparateDelegate >( "StencilFuncSeparate" );
			StencilMaskSeparate = GetProcAdress< StencilMaskSeparateDelegate >( "StencilMaskSeparate" );
			AttachShader = GetProcAdress< AttachShaderDelegate >( "AttachShader" );
			BindAttribLocation = GetProcAdress< BindAttribLocationDelegate >( "BindAttribLocation" );
			CompileShader = GetProcAdress< CompileShaderDelegate >( "CompileShader" );
			CreateProgram = GetProcAdress< CreateProgramDelegate >( "CreateProgram" );
			CreateShader = GetProcAdress< CreateShaderDelegate >( "CreateShader" );
			DeleteProgram = GetProcAdress< DeleteProgramDelegate >( "DeleteProgram" );
			DeleteShader = GetProcAdress< DeleteShaderDelegate >( "DeleteShader" );
			DetachShader = GetProcAdress< DetachShaderDelegate >( "DetachShader" );
			DisableVertexAttribArray = GetProcAdress< DisableVertexAttribArrayDelegate >( "DisableVertexAttribArray" );
			EnableVertexAttribArray = GetProcAdress< EnableVertexAttribArrayDelegate >( "EnableVertexAttribArray" );
			GetActiveAttrib = GetProcAdress< GetActiveAttribDelegate >( "GetActiveAttrib" );
			GetActiveUniform = GetProcAdress< GetActiveUniformDelegate >( "GetActiveUniform" );
			GetAttachedShaders = GetProcAdress< GetAttachedShadersDelegate >( "GetAttachedShaders" );
			GetAttribLocation = GetProcAdress< GetAttribLocationDelegate >( "GetAttribLocation" );
			GetProgramiv = GetProcAdress< GetProgramivDelegate >( "GetProgramiv" );
			GetProgramInfoLog = GetProcAdress< GetProgramInfoLogDelegate >( "GetProgramInfoLog" );
			GetShaderiv = GetProcAdress< GetShaderivDelegate >( "GetShaderiv" );
			GetShaderInfoLog = GetProcAdress< GetShaderInfoLogDelegate >( "GetShaderInfoLog" );
			GetShaderSource = GetProcAdress< GetShaderSourceDelegate >( "GetShaderSource" );
			GetUniformLocation = GetProcAdress< GetUniformLocationDelegate >( "GetUniformLocation" );
			GetUniformfv = GetProcAdress< GetUniformfvDelegate >( "GetUniformfv" );
			GetUniformiv = GetProcAdress< GetUniformivDelegate >( "GetUniformiv" );
			GetVertexAttribdv = GetProcAdress< GetVertexAttribdvDelegate >( "GetVertexAttribdv" );
			GetVertexAttribfv = GetProcAdress< GetVertexAttribfvDelegate >( "GetVertexAttribfv" );
			GetVertexAttribiv = GetProcAdress< GetVertexAttribivDelegate >( "GetVertexAttribiv" );
			GetVertexAttribPointerv = GetProcAdress< GetVertexAttribPointervDelegate >( "GetVertexAttribPointerv" );
			IsProgram = GetProcAdress< IsProgramDelegate >( "IsProgram" );
			IsShader = GetProcAdress< IsShaderDelegate >( "IsShader" );
			LinkProgram = GetProcAdress< LinkProgramDelegate >( "LinkProgram" );
			ShaderSource = GetProcAdress< ShaderSourceDelegate >( "ShaderSource" );
			UseProgram = GetProcAdress< UseProgramDelegate >( "UseProgram" );
			Uniform1f = GetProcAdress< Uniform1fDelegate >( "Uniform1f" );
			Uniform2f = GetProcAdress< Uniform2fDelegate >( "Uniform2f" );
			Uniform3f = GetProcAdress< Uniform3fDelegate >( "Uniform3f" );
			Uniform4f = GetProcAdress< Uniform4fDelegate >( "Uniform4f" );
			Uniform1i = GetProcAdress< Uniform1iDelegate >( "Uniform1i" );
			Uniform2i = GetProcAdress< Uniform2iDelegate >( "Uniform2i" );
			Uniform3i = GetProcAdress< Uniform3iDelegate >( "Uniform3i" );
			Uniform4i = GetProcAdress< Uniform4iDelegate >( "Uniform4i" );
			Uniform1fv = GetProcAdress< Uniform1fvDelegate >( "Uniform1fv" );
			Uniform2fv = GetProcAdress< Uniform2fvDelegate >( "Uniform2fv" );
			Uniform3fv = GetProcAdress< Uniform3fvDelegate >( "Uniform3fv" );
			Uniform4fv = GetProcAdress< Uniform4fvDelegate >( "Uniform4fv" );
			Uniform1iv = GetProcAdress< Uniform1ivDelegate >( "Uniform1iv" );
			Uniform2iv = GetProcAdress< Uniform2ivDelegate >( "Uniform2iv" );
			Uniform3iv = GetProcAdress< Uniform3ivDelegate >( "Uniform3iv" );
			Uniform4iv = GetProcAdress< Uniform4ivDelegate >( "Uniform4iv" );
			UniformMatrix2fv = GetProcAdress< UniformMatrix2fvDelegate >( "UniformMatrix2fv" );
			UniformMatrix3fv = GetProcAdress< UniformMatrix3fvDelegate >( "UniformMatrix3fv" );
			UniformMatrix4fv = GetProcAdress< UniformMatrix4fvDelegate >( "UniformMatrix4fv" );
			ValidateProgram = GetProcAdress< ValidateProgramDelegate >( "ValidateProgram" );
			VertexAttrib1d = GetProcAdress< VertexAttrib1dDelegate >( "VertexAttrib1d" );
			VertexAttrib1dv = GetProcAdress< VertexAttrib1dvDelegate >( "VertexAttrib1dv" );
			VertexAttrib1f = GetProcAdress< VertexAttrib1fDelegate >( "VertexAttrib1f" );
			VertexAttrib1fv = GetProcAdress< VertexAttrib1fvDelegate >( "VertexAttrib1fv" );
			VertexAttrib1s = GetProcAdress< VertexAttrib1sDelegate >( "VertexAttrib1s" );
			VertexAttrib1sv = GetProcAdress< VertexAttrib1svDelegate >( "VertexAttrib1sv" );
			VertexAttrib2d = GetProcAdress< VertexAttrib2dDelegate >( "VertexAttrib2d" );
			VertexAttrib2dv = GetProcAdress< VertexAttrib2dvDelegate >( "VertexAttrib2dv" );
			VertexAttrib2f = GetProcAdress< VertexAttrib2fDelegate >( "VertexAttrib2f" );
			VertexAttrib2fv = GetProcAdress< VertexAttrib2fvDelegate >( "VertexAttrib2fv" );
			VertexAttrib2s = GetProcAdress< VertexAttrib2sDelegate >( "VertexAttrib2s" );
			VertexAttrib2sv = GetProcAdress< VertexAttrib2svDelegate >( "VertexAttrib2sv" );
			VertexAttrib3d = GetProcAdress< VertexAttrib3dDelegate >( "VertexAttrib3d" );
			VertexAttrib3dv = GetProcAdress< VertexAttrib3dvDelegate >( "VertexAttrib3dv" );
			VertexAttrib3f = GetProcAdress< VertexAttrib3fDelegate >( "VertexAttrib3f" );
			VertexAttrib3fv = GetProcAdress< VertexAttrib3fvDelegate >( "VertexAttrib3fv" );
			VertexAttrib3s = GetProcAdress< VertexAttrib3sDelegate >( "VertexAttrib3s" );
			VertexAttrib3sv = GetProcAdress< VertexAttrib3svDelegate >( "VertexAttrib3sv" );
			VertexAttrib4Nbv = GetProcAdress< VertexAttrib4NbvDelegate >( "VertexAttrib4Nbv" );
			VertexAttrib4Niv = GetProcAdress< VertexAttrib4NivDelegate >( "VertexAttrib4Niv" );
			VertexAttrib4Nsv = GetProcAdress< VertexAttrib4NsvDelegate >( "VertexAttrib4Nsv" );
			VertexAttrib4Nub = GetProcAdress< VertexAttrib4NubDelegate >( "VertexAttrib4Nub" );
			VertexAttrib4Nubv = GetProcAdress< VertexAttrib4NubvDelegate >( "VertexAttrib4Nubv" );
			VertexAttrib4Nuiv = GetProcAdress< VertexAttrib4NuivDelegate >( "VertexAttrib4Nuiv" );
			VertexAttrib4Nusv = GetProcAdress< VertexAttrib4NusvDelegate >( "VertexAttrib4Nusv" );
			VertexAttrib4bv = GetProcAdress< VertexAttrib4bvDelegate >( "VertexAttrib4bv" );
			VertexAttrib4d = GetProcAdress< VertexAttrib4dDelegate >( "VertexAttrib4d" );
			VertexAttrib4dv = GetProcAdress< VertexAttrib4dvDelegate >( "VertexAttrib4dv" );
			VertexAttrib4f = GetProcAdress< VertexAttrib4fDelegate >( "VertexAttrib4f" );
			VertexAttrib4fv = GetProcAdress< VertexAttrib4fvDelegate >( "VertexAttrib4fv" );
			VertexAttrib4iv = GetProcAdress< VertexAttrib4ivDelegate >( "VertexAttrib4iv" );
			VertexAttrib4s = GetProcAdress< VertexAttrib4sDelegate >( "VertexAttrib4s" );
			VertexAttrib4sv = GetProcAdress< VertexAttrib4svDelegate >( "VertexAttrib4sv" );
			VertexAttrib4ubv = GetProcAdress< VertexAttrib4ubvDelegate >( "VertexAttrib4ubv" );
			VertexAttrib4uiv = GetProcAdress< VertexAttrib4uivDelegate >( "VertexAttrib4uiv" );
			VertexAttrib4usv = GetProcAdress< VertexAttrib4usvDelegate >( "VertexAttrib4usv" );
			VertexAttribPointer = GetProcAdress< VertexAttribPointerDelegate >( "VertexAttribPointer" );
			UniformMatrix2x3fv = GetProcAdress< UniformMatrix2x3fvDelegate >( "UniformMatrix2x3fv" );
			UniformMatrix3x2fv = GetProcAdress< UniformMatrix3x2fvDelegate >( "UniformMatrix3x2fv" );
			UniformMatrix2x4fv = GetProcAdress< UniformMatrix2x4fvDelegate >( "UniformMatrix2x4fv" );
			UniformMatrix4x2fv = GetProcAdress< UniformMatrix4x2fvDelegate >( "UniformMatrix4x2fv" );
			UniformMatrix3x4fv = GetProcAdress< UniformMatrix3x4fvDelegate >( "UniformMatrix3x4fv" );
			UniformMatrix4x3fv = GetProcAdress< UniformMatrix4x3fvDelegate >( "UniformMatrix4x3fv" );
			ProgramVertexLimitNV = GetProcAdress< ProgramVertexLimitNVDelegate >( "ProgramVertexLimitNV" );
			FramebufferTextureEXT = GetProcAdress< FramebufferTextureEXTDelegate >( "FramebufferTextureEXT" );
			FramebufferTextureLayerEXT = GetProcAdress< FramebufferTextureLayerEXTDelegate >( "FramebufferTextureLayerEXT" );
			FramebufferTextureFaceEXT = GetProcAdress< FramebufferTextureFaceEXTDelegate >( "FramebufferTextureFaceEXT" );
			ProgramParameteriEXT = GetProcAdress< ProgramParameteriEXTDelegate >( "ProgramParameteriEXT" );
			GetUniformuivEXT = GetProcAdress< GetUniformuivEXTDelegate >( "GetUniformuivEXT" );
			BindFragDataLocationEXT = GetProcAdress< BindFragDataLocationEXTDelegate >( "BindFragDataLocationEXT" );
			GetFragDataLocationEXT = GetProcAdress< GetFragDataLocationEXTDelegate >( "GetFragDataLocationEXT" );
			Uniform1uiEXT = GetProcAdress< Uniform1uiEXTDelegate >( "Uniform1uiEXT" );
			Uniform2uiEXT = GetProcAdress< Uniform2uiEXTDelegate >( "Uniform2uiEXT" );
			Uniform3uiEXT = GetProcAdress< Uniform3uiEXTDelegate >( "Uniform3uiEXT" );
			Uniform4uiEXT = GetProcAdress< Uniform4uiEXTDelegate >( "Uniform4uiEXT" );
			Uniform1uivEXT = GetProcAdress< Uniform1uivEXTDelegate >( "Uniform1uivEXT" );
			Uniform2uivEXT = GetProcAdress< Uniform2uivEXTDelegate >( "Uniform2uivEXT" );
			Uniform3uivEXT = GetProcAdress< Uniform3uivEXTDelegate >( "Uniform3uivEXT" );
			Uniform4uivEXT = GetProcAdress< Uniform4uivEXTDelegate >( "Uniform4uivEXT" );
			DrawArraysInstancedEXT = GetProcAdress< DrawArraysInstancedEXTDelegate >( "DrawArraysInstancedEXT" );
			DrawElementsInstancedEXT = GetProcAdress< DrawElementsInstancedEXTDelegate >( "DrawElementsInstancedEXT" );
			TexBufferEXT = GetProcAdress< TexBufferEXTDelegate >( "TexBufferEXT" );
			DepthRangedNV = GetProcAdress< DepthRangedNVDelegate >( "DepthRangedNV" );
			ClearDepthdNV = GetProcAdress< ClearDepthdNVDelegate >( "ClearDepthdNV" );
			DepthBoundsdNV = GetProcAdress< DepthBoundsdNVDelegate >( "DepthBoundsdNV" );
			ColorMaskIndexedEXT = GetProcAdress< ColorMaskIndexedEXTDelegate >( "ColorMaskIndexedEXT" );
			GetBooleanIndexedvEXT = GetProcAdress< GetBooleanIndexedvEXTDelegate >( "GetBooleanIndexedvEXT" );
			GetIntegerIndexedvEXT = GetProcAdress< GetIntegerIndexedvEXTDelegate >( "GetIntegerIndexedvEXT" );
			EnableIndexedEXT = GetProcAdress< EnableIndexedEXTDelegate >( "EnableIndexedEXT" );
			DisableIndexedEXT = GetProcAdress< DisableIndexedEXTDelegate >( "DisableIndexedEXT" );
			IsEnabledIndexedEXT = GetProcAdress< IsEnabledIndexedEXTDelegate >( "IsEnabledIndexedEXT" );
			UniformBufferEXT = GetProcAdress< UniformBufferEXTDelegate >( "UniformBufferEXT" );
			GetUniformBufferSizeEXT = GetProcAdress< GetUniformBufferSizeEXTDelegate >( "GetUniformBufferSizeEXT" );
			GetUniformOffsetEXT = GetProcAdress< GetUniformOffsetEXTDelegate >( "GetUniformOffsetEXT" );
			TexParameterIivEXT = GetProcAdress< TexParameterIivEXTDelegate >( "TexParameterIivEXT" );
			TexParameterIuivEXT = GetProcAdress< TexParameterIuivEXTDelegate >( "TexParameterIuivEXT" );
			GetTexParameterIivEXT = GetProcAdress< GetTexParameterIivEXTDelegate >( "GetTexParameterIivEXT" );
			GetTexParameterIuivEXT = GetProcAdress< GetTexParameterIuivEXTDelegate >( "GetTexParameterIuivEXT" );
			ClearColorIiEXT = GetProcAdress< ClearColorIiEXTDelegate >( "ClearColorIiEXT" );
			ClearColorIuiEXT = GetProcAdress< ClearColorIuiEXTDelegate >( "ClearColorIuiEXT" );
			
		}

		private static T GetProcAdress<T>( string functionName )
			where T : class
		{
			var ptr = WindowsOpenGLNative.wglGetProcAddress( "gl" + functionName );
			if (ptr == IntPtr.Zero) return null;
			return Marshal.GetDelegateForFunctionPointer( ptr, typeof(T) ) as T;
		}
	
		[DllImport( "opengl32.dll" )]
		public static extern void NewList( uint list, ListMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EndList(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CallList( uint list ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CallLists( int n, ListNameType type, void* lists ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteLists( uint list, int range ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern uint GenLists( int range ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ListBase( uint @base ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Begin( BeginMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Bitmap( int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3b( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3d( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3f( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3i( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3s( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ub( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3ui( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3us( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4b( sbyte red, sbyte green, sbyte blue, sbyte alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4d( double red, double green, double blue, double alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4f( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4i( int red, int green, int blue, int alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4s( short red, short green, short blue, short alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ub( byte red, byte green, byte blue, byte alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ui( uint red, uint green, uint blue, uint alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4us( ushort red, ushort green, ushort blue, ushort alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlag( bool flag ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagv( bool[] flag ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void End(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexd( double c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexdv( double[] c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexf( float c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexfv( float[] c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexi( int c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexiv( int[] c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexs( short c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexsv( short[] c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3b( sbyte nx, sbyte ny, sbyte nz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3d( double nx, double ny, double nz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3f( float nx, float ny, float nz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3i( int nx, int ny, int nz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3s( short nx, short ny, short nz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2d( double x, double y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2f( float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2i( int x, int y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2s( short x, short y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos2sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RasterPos4sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectd( double x1, double y1, double x2, double y2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectdv( double[] v1, double[] v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectf( float x1, float y1, float x2, float y2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectfv( float[] v1, float[] v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Recti( int x1, int y1, int x2, int y2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectiv( int[] v1, int[] v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rects( short x1, short y1, short x2, short y2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rectsv( short[] v1, short[] v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1d( double s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1f( float s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1i( int s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1s( short s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2d( double s, double t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2f( float s, float t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2i( int s, int t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2s( short s, short t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3d( double s, double t, double r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3f( float s, float t, float r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3i( int s, int t, int r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3s( short s, short t, short r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4d( double s, double t, double r, double q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4f( float s, float t, float r, float q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4i( int s, int t, int r, int q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4s( short s, short t, short r, short q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2d( double x, double y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2f( float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2i( int x, int y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2s( short x, short y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClipPlane( ClipPlaneName plane, double[] equation ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorMaterial( MaterialFace face, ColorMaterialParameter mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CullFace( CullFaceMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Fogf( FogParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Fogfv( FogParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Fogi( FogParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Fogiv( FogParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FrontFace( FrontFaceDirection mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Hint( HintTarget target, HintMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Lightf( LightName light, LightParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Lightfv( LightName light, LightParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Lighti( LightName light, LightParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Lightiv( LightName light, LightParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LightModelf( LightModelParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LightModelfv( LightModelParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LightModeli( LightModelParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LightModeliv( LightModelParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LineStipple( int factor, ushort pattern ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LineWidth( float width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Materialf( MaterialFace face, MaterialParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Materialfv( MaterialFace face, MaterialParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Materiali( MaterialFace face, MaterialParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Materialiv( MaterialFace face, MaterialParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PointSize( float size ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonMode( MaterialFace face, PolygonMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonStipple( byte[] mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Scissor( int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ShadeModel( ShadingModel mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterf( TextureTarget target, TextureParameterName pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameterfv( TextureTarget target, TextureParameterName pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameteri( TextureTarget target, TextureParameterName pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexParameteriv( TextureTarget target, TextureParameterName pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexImage1D( TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvf( TextureEnvTarget target, TextureEnvParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnvi( TextureEnvTarget target, TextureEnvParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexEnviv( TextureEnvTarget target, TextureEnvParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGend( TextureCoordName coord, TextureGenParameter pname, double param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGendv( TextureCoordName coord, TextureGenParameter pname, double[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGenf( TextureCoordName coord, TextureGenParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGenfv( TextureCoordName coord, TextureGenParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGeni( TextureCoordName coord, TextureGenParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexGeniv( TextureCoordName coord, TextureGenParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FeedbackBuffer( int size, FeedbackType type, ref float[] buffer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SelectBuffer( int size, ref uint[] buffer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern int RenderMode( RenderingMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void InitNames(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadName( uint name ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PassThrough( float token ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PopName(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PushName( uint name ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffer( DrawBufferMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Clear( ClearBufferMask mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClearAccum( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClearIndex( float c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClearColor( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClearStencil( int s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClearDepth( double depth ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilMask( uint mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorMask( bool red, bool green, bool blue, bool alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DepthMask( bool flag ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void IndexMask( uint mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Accum( AccumOp op, float value ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Disable( EnableCap cap ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Enable( EnableCap cap ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Finish(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Flush(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PopAttrib(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PushAttrib( AttribMask mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Map1d( MapTarget target, double u1, double u2, int stride, int order, double[] points ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Map1f( MapTarget target, float u1, float u2, int stride, int order, float[] points ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Map2d( MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Map2f( MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid1d( int un, double u1, double u2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid1f( int un, float u1, float u2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid2d( int un, double u1, double u2, int vn, double v1, double v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MapGrid2f( int un, float u1, float u2, int vn, float v1, float v2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1d( double u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1dv( double[] u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1f( float u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord1fv( float[] u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2d( double u, double v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2dv( double[] u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2f( float u, float v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalCoord2fv( float[] u ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMesh1( MeshMode1 mode, int i1, int i2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalPoint1( int i ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMesh2( MeshMode2 mode, int i1, int i2, int j1, int j2 ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalPoint2( int i, int j ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFunc( AlphaFunction func, float @ref ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFunc( BlendingFactorSrc sfactor, BlendingFactorDest dfactor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LogicOp( LogicOp opcode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilFunc( StencilFunction func, int @ref, uint mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilOp( StencilOp fail, StencilOp zfail, StencilOp zpass ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DepthFunc( DepthFunction func ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelZoom( float xfactor, float yfactor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransferf( PixelTransferParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransferi( PixelTransferParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelStoref( PixelStoreParameter pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelStorei( PixelStoreParameter pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapfv( PixelMap map, int mapsize, float[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapuiv( PixelMap map, int mapsize, uint[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelMapusv( PixelMap map, int mapsize, ushort[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReadBuffer( ReadBufferMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyPixels( int x, int y, int width, int height, PixelCopyType type ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ReadPixels( int x, int y, int width, int height, PixelFormat format, PixelType type, ref void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void DrawPixels( int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetBooleanv( GetPName pname, ref bool[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetClipPlane( ClipPlaneName plane, ref double[] equation ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetDoublev( GetPName pname, ref double[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern ErrorCode GetError(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFloatv( GetPName pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetIntegerv( GetPName pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetLightfv( LightName light, LightParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetLightiv( LightName light, LightParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapdv( MapTarget target, GetMapQuery query, ref double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapfv( MapTarget target, GetMapQuery query, ref float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapiv( MapTarget target, GetMapQuery query, ref int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMaterialfv( MaterialFace face, MaterialParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMaterialiv( MaterialFace face, MaterialParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapfv( PixelMap map, ref float[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapuiv( PixelMap map, ref uint[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelMapusv( PixelMap map, ref ushort[] values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPolygonStipple( ref byte[] mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern string GetString( StringName name ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexEnviv( TextureEnvTarget target, TextureEnvParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGendv( TextureCoordName coord, TextureGenParameter pname, ref double[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGenfv( TextureCoordName coord, TextureGenParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexGeniv( TextureCoordName coord, TextureGenParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetTexImage( TextureTarget target, int level, PixelFormat format, PixelType type, ref void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameterfv( TextureTarget target, GetTextureParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexParameteriv( TextureTarget target, GetTextureParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexLevelParameterfv( TextureTarget target, int level, GetTextureParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexLevelParameteriv( TextureTarget target, int level, GetTextureParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsEnabled( EnableCap cap ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsList( uint list ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DepthRange( double near, double far ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Frustum( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadIdentity(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixMode( MatrixMode mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Ortho( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PopMatrix(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PushMatrix(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rotated( double angle, double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Rotatef( float angle, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Scaled( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Scalef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Translated( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Translatef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Viewport( int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayElement( int i ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorPointer( int size, ColorPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DisableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawArrays( BeginMode mode, int first, int count ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void DrawElements( BeginMode mode, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void EdgeFlagPointer( int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void EnableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetPointerv( GetPointervPName pname, ref void** @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void IndexPointer( IndexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void InterleavedArrays( InterleavedArrayFormat format, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void NormalPointer( NormalPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexCoordPointer( int size, TexCoordPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexPointer( int size, VertexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonOffset( float factor, float units ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage1D( TextureTarget target, int level, int xoffset, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern bool AreTexturesResident( int n, uint[] textures, ref bool[] residences ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BindTexture( TextureTarget target, uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteTextures( int n, uint[] textures ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GenTextures( int n, ref uint[] textures ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsTexture( uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PrioritizeTextures( int n, uint[] textures, float[] priorities ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexub( byte c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Indexubv( byte[] c ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PopClientAttrib(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PushClientAttrib( ClientAttribMask mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendColor( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquation( uint mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void DrawRangeElements( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorTable( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterfv( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameteriv( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorTable( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetColorTable( uint target, PixelFormat format, PixelType type, ref void* table ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfv( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameteriv( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorSubTable( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorSubTable( uint target, int start, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ConvolutionFilter1D( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ConvolutionFilter2D( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterf( uint target, uint pname, float @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfv( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteri( uint target, uint pname, int @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteriv( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter1D( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter2D( uint target, PixelInternalFormat internalformat, int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetConvolutionFilter( uint target, PixelFormat format, PixelType type, ref void* image ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterfv( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameteriv( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetSeparableFilter( uint target, PixelFormat format, PixelType type, ref void* row, ref void* column, ref void* span ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SeparableFilter2D( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetHistogram( uint target, bool reset, PixelFormat format, PixelType type, ref void* values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterfv( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameteriv( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetMinmax( uint target, bool reset, PixelFormat format, PixelType type, ref void* values ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterfv( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameteriv( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Histogram( uint target, int width, PixelInternalFormat internalformat, bool sink ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Minmax( uint target, PixelInternalFormat internalformat, bool sink ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ResetHistogram( uint target ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ResetMinmax( uint target ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexImage3D( TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveTexture( uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveTexture( uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1d( uint target, double s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dv( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1f( uint target, float s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fv( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1i( uint target, int s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1iv( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1s( uint target, short s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1sv( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2d( uint target, double s, double t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dv( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2f( uint target, float s, float t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fv( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2i( uint target, int s, int t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2iv( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2s( uint target, short s, short t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2sv( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3d( uint target, double s, double t, double r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dv( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3f( uint target, float s, float t, float r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fv( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3i( uint target, int s, int t, int r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3iv( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3s( uint target, short s, short t, short r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3sv( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4d( uint target, double s, double t, double r, double q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dv( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4f( uint target, float s, float t, float r, float q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fv( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4i( uint target, int s, int t, int r, int q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4iv( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4s( uint target, short s, short t, short r, short q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4sv( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SampleCoverage( float value, bool invert ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage3D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage3D( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetCompressedTexImage( TextureTarget target, int level, ref void* img ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordf( float coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfv( float[] coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordd( double coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddv( double[] coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void FogCoordPointer( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawArrays( BeginMode mode, ref int[] first, ref int[] count, int primcount ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void MultiDrawElements( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterf( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfv( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteri( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteriv( uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3b( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3d( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3f( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3i( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3s( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ub( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ui( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3us( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SecondaryColorPointer( int size, ColorPointerType type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2d( double x, double y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2f( float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2i( int x, int y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2s( short x, short y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dv( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fv( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iv( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sv( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GenQueries( int n, ref uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteQueries( int n, uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsQuery( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BeginQuery( uint target, uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndQuery( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryiv( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectiv( uint id, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectuiv( uint id, uint pname, ref uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindBuffer( uint target, uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteBuffers( int n, uint[] buffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenBuffers( int n, ref uint[] buffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsBuffer( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void BufferData( uint target, int size, void* data, uint usage ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void BufferSubData( uint target, int offset, int size, void* data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetBufferSubData( uint target, int offset, int size, ref void* data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MapBuffer( uint target, uint access ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool UnmapBuffer( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferParameteriv( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetBufferPointerv( uint target, uint pname, ref void** @params ); //  extension method	
		public delegate void BlendEquationSeparateDelegate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha ); //  extension method
		public static readonly BlendEquationSeparateDelegate BlendEquationSeparate;
		public delegate void DrawBuffersDelegate( int n, uint[] bufs ); //  extension method
		public static readonly DrawBuffersDelegate DrawBuffers;
		public delegate void StencilOpSeparateDelegate( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass ); //  extension method
		public static readonly StencilOpSeparateDelegate StencilOpSeparate;
		public delegate void StencilFuncSeparateDelegate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask ); //  extension method
		public static readonly StencilFuncSeparateDelegate StencilFuncSeparate;
		public delegate void StencilMaskSeparateDelegate( uint face, uint mask ); //  extension method
		public static readonly StencilMaskSeparateDelegate StencilMaskSeparate;
		public delegate void AttachShaderDelegate( uint program, uint shader ); //  extension method
		public static readonly AttachShaderDelegate AttachShader;
		public delegate void BindAttribLocationDelegate( uint program, uint index, string[] name ); //  extension method
		public static readonly BindAttribLocationDelegate BindAttribLocation;
		public delegate void CompileShaderDelegate( uint shader ); //  extension method
		public static readonly CompileShaderDelegate CompileShader;
		public delegate uint CreateProgramDelegate(  ); //  extension method
		public static readonly CreateProgramDelegate CreateProgram;
		public delegate uint CreateShaderDelegate( uint type ); //  extension method
		public static readonly CreateShaderDelegate CreateShader;
		public delegate void DeleteProgramDelegate( uint program ); //  extension method
		public static readonly DeleteProgramDelegate DeleteProgram;
		public delegate void DeleteShaderDelegate( uint shader ); //  extension method
		public static readonly DeleteShaderDelegate DeleteShader;
		public delegate void DetachShaderDelegate( uint program, uint shader ); //  extension method
		public static readonly DetachShaderDelegate DetachShader;
		public delegate void DisableVertexAttribArrayDelegate( uint index ); //  extension method
		public static readonly DisableVertexAttribArrayDelegate DisableVertexAttribArray;
		public delegate void EnableVertexAttribArrayDelegate( uint index ); //  extension method
		public static readonly EnableVertexAttribArrayDelegate EnableVertexAttribArray;
		public delegate void GetActiveAttribDelegate( uint program, uint index, int bufSize, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method
		public static readonly GetActiveAttribDelegate GetActiveAttrib;
		public delegate void GetActiveUniformDelegate( uint program, uint index, int bufSize, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method
		public static readonly GetActiveUniformDelegate GetActiveUniform;
		public delegate void GetAttachedShadersDelegate( uint program, int maxCount, ref int[] count, ref uint[] obj ); //  extension method
		public static readonly GetAttachedShadersDelegate GetAttachedShaders;
		public delegate int GetAttribLocationDelegate( uint program, string[] name ); //  extension method
		public static readonly GetAttribLocationDelegate GetAttribLocation;
		public delegate void GetProgramivDelegate( uint program, uint pname, ref int[] @params ); //  extension method
		public static readonly GetProgramivDelegate GetProgramiv;
		public delegate void GetProgramInfoLogDelegate( uint program, int bufSize, ref int[] length, ref string[] infoLog ); //  extension method
		public static readonly GetProgramInfoLogDelegate GetProgramInfoLog;
		public delegate void GetShaderivDelegate( uint shader, uint pname, ref int[] @params ); //  extension method
		public static readonly GetShaderivDelegate GetShaderiv;
		public delegate void GetShaderInfoLogDelegate( uint shader, int bufSize, ref int[] length, ref string[] infoLog ); //  extension method
		public static readonly GetShaderInfoLogDelegate GetShaderInfoLog;
		public delegate void GetShaderSourceDelegate( uint shader, int bufSize, ref int[] length, ref string[] source ); //  extension method
		public static readonly GetShaderSourceDelegate GetShaderSource;
		public delegate int GetUniformLocationDelegate( uint program, string[] name ); //  extension method
		public static readonly GetUniformLocationDelegate GetUniformLocation;
		public delegate void GetUniformfvDelegate( uint program, int location, ref float[] @params ); //  extension method
		public static readonly GetUniformfvDelegate GetUniformfv;
		public delegate void GetUniformivDelegate( uint program, int location, ref int[] @params ); //  extension method
		public static readonly GetUniformivDelegate GetUniformiv;
		public delegate void GetVertexAttribdvDelegate( uint index, uint pname, ref double[] @params ); //  extension method
		public static readonly GetVertexAttribdvDelegate GetVertexAttribdv;
		public delegate void GetVertexAttribfvDelegate( uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetVertexAttribfvDelegate GetVertexAttribfv;
		public delegate void GetVertexAttribivDelegate( uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVertexAttribivDelegate GetVertexAttribiv;
		public unsafe delegate void GetVertexAttribPointervDelegate( uint index, uint pname, ref void** pointer ); //  extension method
		public static readonly GetVertexAttribPointervDelegate GetVertexAttribPointerv;
		public delegate bool IsProgramDelegate( uint program ); //  extension method
		public static readonly IsProgramDelegate IsProgram;
		public delegate bool IsShaderDelegate( uint shader ); //  extension method
		public static readonly IsShaderDelegate IsShader;
		public delegate void LinkProgramDelegate( uint program ); //  extension method
		public static readonly LinkProgramDelegate LinkProgram;
		public delegate void ShaderSourceDelegate( uint shader, int count, string[] @string, int[] length ); //  extension method
		public static readonly ShaderSourceDelegate ShaderSource;
		public delegate void UseProgramDelegate( uint program ); //  extension method
		public static readonly UseProgramDelegate UseProgram;
		public delegate void Uniform1fDelegate( int location, float v0 ); //  extension method
		public static readonly Uniform1fDelegate Uniform1f;
		public delegate void Uniform2fDelegate( int location, float v0, float v1 ); //  extension method
		public static readonly Uniform2fDelegate Uniform2f;
		public delegate void Uniform3fDelegate( int location, float v0, float v1, float v2 ); //  extension method
		public static readonly Uniform3fDelegate Uniform3f;
		public delegate void Uniform4fDelegate( int location, float v0, float v1, float v2, float v3 ); //  extension method
		public static readonly Uniform4fDelegate Uniform4f;
		public delegate void Uniform1iDelegate( int location, int v0 ); //  extension method
		public static readonly Uniform1iDelegate Uniform1i;
		public delegate void Uniform2iDelegate( int location, int v0, int v1 ); //  extension method
		public static readonly Uniform2iDelegate Uniform2i;
		public delegate void Uniform3iDelegate( int location, int v0, int v1, int v2 ); //  extension method
		public static readonly Uniform3iDelegate Uniform3i;
		public delegate void Uniform4iDelegate( int location, int v0, int v1, int v2, int v3 ); //  extension method
		public static readonly Uniform4iDelegate Uniform4i;
		public delegate void Uniform1fvDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform1fvDelegate Uniform1fv;
		public delegate void Uniform2fvDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform2fvDelegate Uniform2fv;
		public delegate void Uniform3fvDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform3fvDelegate Uniform3fv;
		public delegate void Uniform4fvDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform4fvDelegate Uniform4fv;
		public delegate void Uniform1ivDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform1ivDelegate Uniform1iv;
		public delegate void Uniform2ivDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform2ivDelegate Uniform2iv;
		public delegate void Uniform3ivDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform3ivDelegate Uniform3iv;
		public delegate void Uniform4ivDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform4ivDelegate Uniform4iv;
		public delegate void UniformMatrix2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix2fvDelegate UniformMatrix2fv;
		public delegate void UniformMatrix3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix3fvDelegate UniformMatrix3fv;
		public delegate void UniformMatrix4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix4fvDelegate UniformMatrix4fv;
		public delegate void ValidateProgramDelegate( uint program ); //  extension method
		public static readonly ValidateProgramDelegate ValidateProgram;
		public delegate void VertexAttrib1dDelegate( uint index, double x ); //  extension method
		public static readonly VertexAttrib1dDelegate VertexAttrib1d;
		public delegate void VertexAttrib1dvDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib1dvDelegate VertexAttrib1dv;
		public delegate void VertexAttrib1fDelegate( uint index, float x ); //  extension method
		public static readonly VertexAttrib1fDelegate VertexAttrib1f;
		public delegate void VertexAttrib1fvDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib1fvDelegate VertexAttrib1fv;
		public delegate void VertexAttrib1sDelegate( uint index, short x ); //  extension method
		public static readonly VertexAttrib1sDelegate VertexAttrib1s;
		public delegate void VertexAttrib1svDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib1svDelegate VertexAttrib1sv;
		public delegate void VertexAttrib2dDelegate( uint index, double x, double y ); //  extension method
		public static readonly VertexAttrib2dDelegate VertexAttrib2d;
		public delegate void VertexAttrib2dvDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib2dvDelegate VertexAttrib2dv;
		public delegate void VertexAttrib2fDelegate( uint index, float x, float y ); //  extension method
		public static readonly VertexAttrib2fDelegate VertexAttrib2f;
		public delegate void VertexAttrib2fvDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib2fvDelegate VertexAttrib2fv;
		public delegate void VertexAttrib2sDelegate( uint index, short x, short y ); //  extension method
		public static readonly VertexAttrib2sDelegate VertexAttrib2s;
		public delegate void VertexAttrib2svDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib2svDelegate VertexAttrib2sv;
		public delegate void VertexAttrib3dDelegate( uint index, double x, double y, double z ); //  extension method
		public static readonly VertexAttrib3dDelegate VertexAttrib3d;
		public delegate void VertexAttrib3dvDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib3dvDelegate VertexAttrib3dv;
		public delegate void VertexAttrib3fDelegate( uint index, float x, float y, float z ); //  extension method
		public static readonly VertexAttrib3fDelegate VertexAttrib3f;
		public delegate void VertexAttrib3fvDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib3fvDelegate VertexAttrib3fv;
		public delegate void VertexAttrib3sDelegate( uint index, short x, short y, short z ); //  extension method
		public static readonly VertexAttrib3sDelegate VertexAttrib3s;
		public delegate void VertexAttrib3svDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib3svDelegate VertexAttrib3sv;
		public delegate void VertexAttrib4NbvDelegate( uint index, sbyte[] v ); //  extension method
		public static readonly VertexAttrib4NbvDelegate VertexAttrib4Nbv;
		public delegate void VertexAttrib4NivDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttrib4NivDelegate VertexAttrib4Niv;
		public delegate void VertexAttrib4NsvDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib4NsvDelegate VertexAttrib4Nsv;
		public delegate void VertexAttrib4NubDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method
		public static readonly VertexAttrib4NubDelegate VertexAttrib4Nub;
		public delegate void VertexAttrib4NubvDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttrib4NubvDelegate VertexAttrib4Nubv;
		public delegate void VertexAttrib4NuivDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttrib4NuivDelegate VertexAttrib4Nuiv;
		public delegate void VertexAttrib4NusvDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib4NusvDelegate VertexAttrib4Nusv;
		public delegate void VertexAttrib4bvDelegate( uint index, sbyte[] v ); //  extension method
		public static readonly VertexAttrib4bvDelegate VertexAttrib4bv;
		public delegate void VertexAttrib4dDelegate( uint index, double x, double y, double z, double w ); //  extension method
		public static readonly VertexAttrib4dDelegate VertexAttrib4d;
		public delegate void VertexAttrib4dvDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib4dvDelegate VertexAttrib4dv;
		public delegate void VertexAttrib4fDelegate( uint index, float x, float y, float z, float w ); //  extension method
		public static readonly VertexAttrib4fDelegate VertexAttrib4f;
		public delegate void VertexAttrib4fvDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib4fvDelegate VertexAttrib4fv;
		public delegate void VertexAttrib4ivDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttrib4ivDelegate VertexAttrib4iv;
		public delegate void VertexAttrib4sDelegate( uint index, short x, short y, short z, short w ); //  extension method
		public static readonly VertexAttrib4sDelegate VertexAttrib4s;
		public delegate void VertexAttrib4svDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib4svDelegate VertexAttrib4sv;
		public delegate void VertexAttrib4ubvDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttrib4ubvDelegate VertexAttrib4ubv;
		public delegate void VertexAttrib4uivDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttrib4uivDelegate VertexAttrib4uiv;
		public delegate void VertexAttrib4usvDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib4usvDelegate VertexAttrib4usv;
		public unsafe delegate void VertexAttribPointerDelegate( uint index, int size, uint type, bool normalized, int stride, void* pointer ); //  extension method
		public static readonly VertexAttribPointerDelegate VertexAttribPointer;
		public delegate void UniformMatrix2x3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix2x3fvDelegate UniformMatrix2x3fv;
		public delegate void UniformMatrix3x2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix3x2fvDelegate UniformMatrix3x2fv;
		public delegate void UniformMatrix2x4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix2x4fvDelegate UniformMatrix2x4fv;
		public delegate void UniformMatrix4x2fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix4x2fvDelegate UniformMatrix4x2fv;
		public delegate void UniformMatrix3x4fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix3x4fvDelegate UniformMatrix3x4fv;
		public delegate void UniformMatrix4x3fvDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix4x3fvDelegate UniformMatrix4x3fv;
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveTextureARB( uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveTextureARB( uint texture ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dARB( uint target, double s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1dvARB( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fARB( uint target, float s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1fvARB( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1iARB( uint target, int s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1ivARB( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1sARB( uint target, short s ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1svARB( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dARB( uint target, double s, double t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2dvARB( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fARB( uint target, float s, float t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2fvARB( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2iARB( uint target, int s, int t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2ivARB( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2sARB( uint target, short s, short t ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2svARB( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dARB( uint target, double s, double t, double r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3dvARB( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fARB( uint target, float s, float t, float r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3fvARB( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3iARB( uint target, int s, int t, int r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3ivARB( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3sARB( uint target, short s, short t, short r ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3svARB( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dARB( uint target, double s, double t, double r, double q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4dvARB( uint target, double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fARB( uint target, float s, float t, float r, float q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4fvARB( uint target, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4iARB( uint target, int s, int t, int r, int q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4ivARB( uint target, int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4sARB( uint target, short s, short t, short r, short q ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4svARB( uint target, short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixfARB( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadTransposeMatrixdARB( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixfARB( float[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultTransposeMatrixdARB( double[] m ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SampleCoverageARB( float value, bool invert ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage3DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage2DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexImage1DARB( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage3DARB( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage2DARB( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void CompressedTexSubImage1DARB( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetCompressedTexImageARB( TextureTarget target, int level, ref void* img ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfARB( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvARB( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightbvARB( int size, sbyte[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightsvARB( int size, short[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightivARB( int size, int[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightfvARB( int size, float[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightdvARB( int size, double[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightubvARB( int size, byte[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightusvARB( int size, ushort[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WeightuivARB( int size, uint[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void WeightPointerARB( int size, uint type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendARB( int count ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CurrentPaletteMatrixARB( int index ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexubvARB( int size, byte[] indices ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexusvARB( int size, ushort[] indices ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MatrixIndexuivARB( int size, uint[] indices ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void MatrixIndexPointerARB( int size, uint type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dARB( double x, double y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fARB( float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iARB( int x, int y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sARB( short x, short y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2svARB( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dARB( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fARB( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iARB( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sARB( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3svARB( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dARB( uint index, double x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dvARB( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fARB( uint index, float x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fvARB( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1sARB( uint index, short x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1svARB( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dARB( uint index, double x, double y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dvARB( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fARB( uint index, float x, float y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fvARB( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2sARB( uint index, short x, short y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2svARB( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dARB( uint index, double x, double y, double z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dvARB( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fARB( uint index, float x, float y, float z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fvARB( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3sARB( uint index, short x, short y, short z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3svARB( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NbvARB( uint index, sbyte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NivARB( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NsvARB( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NubARB( uint index, byte x, byte y, byte z, byte w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NubvARB( uint index, byte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NuivARB( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4NusvARB( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4bvARB( uint index, sbyte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dARB( uint index, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dvARB( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fARB( uint index, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fvARB( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ivARB( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4sARB( uint index, short x, short y, short z, short w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4svARB( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubvARB( uint index, byte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4uivARB( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4usvARB( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexAttribPointerARB( uint index, int size, uint type, bool normalized, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EnableVertexAttribArrayARB( uint index ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DisableVertexAttribArrayARB( uint index ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ProgramStringARB( uint target, uint format, int len, void* @string ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindProgramARB( uint target, uint program ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteProgramsARB( int n, uint[] programs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenProgramsARB( int n, ref uint[] programs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4dARB( uint target, uint index, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4dvARB( uint target, uint index, double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4fARB( uint target, uint index, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameter4fvARB( uint target, uint index, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4dARB( uint target, uint index, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4dvARB( uint target, uint index, double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4fARB( uint target, uint index, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameter4fvARB( uint target, uint index, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterdvARB( uint target, uint index, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterfvARB( uint target, uint index, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterdvARB( uint target, uint index, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterfvARB( uint target, uint index, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramivARB( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetProgramStringARB( uint target, uint pname, ref void* @string ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribdvARB( uint index, uint pname, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribfvARB( uint index, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribivARB( uint index, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetVertexAttribPointervARB( uint index, uint pname, ref void** pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsProgramARB( uint program ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferARB( uint target, uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteBuffersARB( int n, uint[] buffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenBuffersARB( int n, ref uint[] buffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsBufferARB( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void BufferDataARB( uint target, int size, void* data, uint usage ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void BufferSubDataARB( uint target, int offset, int size, void* data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetBufferSubDataARB( uint target, int offset, int size, ref void* data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MapBufferARB( uint target, uint access ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool UnmapBufferARB( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetBufferParameterivARB( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetBufferPointervARB( uint target, uint pname, ref void** @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenQueriesARB( int n, ref uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteQueriesARB( int n, uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsQueryARB( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BeginQueryARB( uint target, uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndQueryARB( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryivARB( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectivARB( uint id, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectuivARB( uint id, uint pname, ref uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteObjectARB( uint obj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint GetHandleARB( uint pname ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DetachObjectARB( uint containerObj, uint attachedObj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateShaderObjectARB( uint shaderType ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderSourceARB( uint shaderObj, int count, string[] @string, int[] length ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CompileShaderARB( uint shaderObj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint CreateProgramObjectARB(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void AttachObjectARB( uint containerObj, uint obj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void LinkProgramARB( uint programObj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UseProgramObjectARB( uint programObj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ValidateProgramARB( uint programObj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1fARB( int location, float v0 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2fARB( int location, float v0, float v1 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3fARB( int location, float v0, float v1, float v2 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4fARB( int location, float v0, float v1, float v2, float v3 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1iARB( int location, int v0 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2iARB( int location, int v0, int v1 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3iARB( int location, int v0, int v1, int v2 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4iARB( int location, int v0, int v1, int v2, int v3 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1fvARB( int location, int count, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2fvARB( int location, int count, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3fvARB( int location, int count, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4fvARB( int location, int count, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform1ivARB( int location, int count, int[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform2ivARB( int location, int count, int[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform3ivARB( int location, int count, int[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Uniform4ivARB( int location, int count, int[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix2fvARB( int location, int count, bool transpose, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix3fvARB( int location, int count, bool transpose, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UniformMatrix4fvARB( int location, int count, bool transpose, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectParameterfvARB( uint obj, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectParameterivARB( uint obj, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetInfoLogARB( uint obj, int maxLength, ref int[] length, ref string[] infoLog ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetAttachedObjectsARB( uint containerObj, int maxCount, ref int[] count, ref uint[] obj ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int GetUniformLocationARB( uint programObj, string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveUniformARB( uint programObj, uint index, int maxLength, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformfvARB( uint programObj, int location, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetUniformivARB( uint programObj, int location, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetShaderSourceARB( uint obj, int maxLength, ref int[] length, ref string[] source ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindAttribLocationARB( uint programObj, uint index, string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveAttribARB( uint programObj, uint index, int maxLength, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int GetAttribLocationARB( uint programObj, string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffersARB( int n, uint[] bufs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ClampColorARB( uint target, uint clamp ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendColorEXT( float red, float green, float blue, float alpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PolygonOffsetEXT( float factor, float bias ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexImage3DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexFilterFuncSGIS( TextureTarget target, uint filter, ref float[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexFilterFuncSGIS( TextureTarget target, uint filter, int n, float[] weights ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage1DEXT( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage1DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexImage2DEXT( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage1DEXT( TextureTarget target, int level, int xoffset, int x, int y, int width ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage2DEXT( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyTexSubImage3DEXT( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetHistogramEXT( HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, ref void* values ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterfvEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetHistogramParameterivEXT( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetMinmaxEXT( MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, ref void* values ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterfvEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMinmaxParameterivEXT( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void HistogramEXT( HistogramTargetEXT target, int width, PixelInternalFormat internalformat, bool sink ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MinmaxEXT( MinmaxTargetEXT target, PixelInternalFormat internalformat, bool sink ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ResetHistogramEXT( HistogramTargetEXT target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ResetMinmaxEXT( MinmaxTargetEXT target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameteriEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter1DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyConvolutionFilter2DEXT( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width, int height ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetConvolutionFilterEXT( ConvolutionTargetEXT target, PixelFormat format, PixelType type, ref void* image ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterfvEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetConvolutionParameterivEXT( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetSeparableFilterEXT( SeparableTargetEXT target, PixelFormat format, PixelType type, ref void* row, ref void* column, ref void* span ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SeparableFilter2DEXT( SeparableTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterfvSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorTableParameterivSGI( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorTableSGI( ColorTableTargetSGI target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetColorTableSGI( ColorTableTargetSGI target, PixelFormat format, PixelType type, ref void* table ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfvSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterivSGI( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenSGIX( uint mode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameteriSGIS( PixelTexGenParameterNameSGIS pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterfSGIS( PixelTexGenParameterNameSGIS pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelTexGenParameterivSGIS( PixelTexGenParameterNameSGIS pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetPixelTexGenParameterfvSGIS( PixelTexGenParameterNameSGIS pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexImage4DSGIS( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexSubImage4DSGIS( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool AreTexturesResidentEXT( int n, uint[] textures, ref bool[] residences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindTextureEXT( TextureTarget target, uint texture ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteTexturesEXT( int n, uint[] textures ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenTexturesEXT( int n, ref uint[] textures ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsTextureEXT( uint texture ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PrioritizeTexturesEXT( int n, uint[] textures, float[] priorities ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DetailTexFuncSGIS( TextureTarget target, int n, float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetDetailTexFuncSGIS( TextureTarget target, ref float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SharpenTexFuncSGIS( TextureTarget target, int n, float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetSharpenTexFuncSGIS( TextureTarget target, ref float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMaskSGIS( float value, bool invert ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SamplePatternSGIS( SamplePatternSGIS pattern ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayElementEXT( int i ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorPointerEXT( int size, ColorPointerType type, int stride, int count, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawArraysEXT( BeginMode mode, int first, int count ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EdgeFlagPointerEXT( int stride, int count, bool[] pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetPointervEXT( GetPointervPName pname, ref void** @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void IndexPointerEXT( IndexPointerType type, int stride, int count, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void NormalPointerEXT( NormalPointerType type, int stride, int count, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexCoordPointerEXT( int size, TexCoordPointerType type, int stride, int count, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexPointerEXT( int size, VertexPointerType type, int stride, int count, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquationEXT( BlendEquationModeEXT mode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterfSGIX( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterfvSGIX( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameteriSGIX( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SpriteParameterivSGIX( uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfEXT( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvEXT( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfSGIS( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterfvSGIS( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int GetInstrumentsSGIX(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void InstrumentsBufferSGIX( int size, ref int[] buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int PollInstrumentsSGIX( ref int[] marker_p ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ReadInstrumentsSGIX( int marker ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void StartInstrumentsSGIX(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void StopInstrumentsSGIX( int marker ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FrameZoomSGIX( int factor ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TagSampleBufferSGIX(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeformationMap3dSGIX( FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeformationMap3fSGIX( FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeformSGIX( FfdMaskSGIX mask ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadIdentityDeformationMapSGIX( FfdMaskSGIX mask ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ReferencePlaneSGIX( double[] equation ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FlushRasterSGIX(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FogFuncSGIS( int n, float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFogFuncSGIS( ref float[] points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameteriHP( uint target, uint pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterfHP( uint target, uint pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterivHP( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ImageTransformParameterfvHP( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetImageTransformParameterivHP( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetImageTransformParameterfvHP( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorSubTableEXT( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void CopyColorSubTableEXT( uint target, int start, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void HintPGI( uint target, int mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorTableEXT( uint target, PixelInternalFormat internalFormat, int width, PixelFormat format, PixelType type, void* table ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetColorTableEXT( uint target, PixelFormat format, PixelType type, ref void* data ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterivEXT( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetColorTableParameterfvEXT( uint target, uint pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetListParameterfvSGIX( uint list, ListParameterName pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetListParameterivSGIX( uint list, ListParameterName pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterfSGIX( uint list, ListParameterName pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterfvSGIX( uint list, ListParameterName pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameteriSGIX( uint list, ListParameterName pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ListParameterivSGIX( uint list, ListParameterName pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void IndexMaterialEXT( MaterialFace face, uint mode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void IndexFuncEXT( uint func, float @ref ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void LockArraysEXT( int first, int count ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UnlockArraysEXT(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CullParameterdvEXT( uint pname, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CullParameterfvEXT( uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentColorMaterialSGIX( MaterialFace face, MaterialParameter mode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightfSGIX( uint light, uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightfvSGIX( uint light, uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightiSGIX( uint light, uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightivSGIX( uint light, uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelfSGIX( FragmentLightModelParameterSGIX pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelfvSGIX( FragmentLightModelParameterSGIX pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModeliSGIX( FragmentLightModelParameterSGIX pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentLightModelivSGIX( FragmentLightModelParameterSGIX pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialfSGIX( MaterialFace face, MaterialParameter pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialiSGIX( MaterialFace face, MaterialParameter pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentLightfvSGIX( uint light, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentLightivSGIX( uint light, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void LightEnviSGIX( LightEnvParameterSGIX pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void DrawRangeElementsEXT( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ApplyTextureEXT( uint mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TextureLightEXT( uint pname ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TextureMaterialEXT( MaterialFace face, MaterialParameter mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void AsyncMarkerSGIX( uint marker ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int FinishAsyncSGIX( ref uint[] markerp ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int PollAsyncSGIX( ref uint[] markerp ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint GenAsyncMarkersSGIX( int range ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteAsyncMarkersSGIX( uint marker, int range ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsAsyncMarkerSGIX( uint marker ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void NormalPointervINTEL( NormalPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexCoordPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameteriEXT( uint target, uint pname, int param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterfEXT( uint target, uint pname, float param ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterivEXT( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void PixelTransformParameterfvEXT( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bEXT( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dEXT( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fEXT( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3iEXT( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3sEXT( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubEXT( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3ubvEXT( byte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uiEXT( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3uivEXT( uint[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usEXT( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3usvEXT( ushort[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SecondaryColorPointerEXT( int size, ColorPointerType type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TextureNormalEXT( uint mode ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawArraysEXT( BeginMode mode, ref int[] first, ref int[] count, int primcount ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void MultiDrawElementsEXT( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfEXT( float coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordfvEXT( float[] coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddEXT( double coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoorddvEXT( double[] coord ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void FogCoordPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3bEXT( sbyte tx, sbyte ty, sbyte tz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3dEXT( double tx, double ty, double tz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3fEXT( float tx, float ty, float tz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3iEXT( int tx, int ty, int tz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3sEXT( short tx, short ty, short tz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Tangent3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3bEXT( sbyte bx, sbyte by, sbyte bz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3dEXT( double bx, double by, double bz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3fEXT( float bx, float by, float bz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3iEXT( int bx, int by, int bz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3sEXT( short bx, short by, short bz ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Binormal3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TangentPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void BinormalPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void FinishTextureSUNX(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorbSUN( sbyte factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorsSUN( short factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactoriSUN( int factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorfSUN( float factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactordSUN( double factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorubSUN( byte factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactorusSUN( ushort factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GlobalAlphaFactoruiSUN( uint factor ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiSUN( uint code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeusSUN( ushort code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeubSUN( byte code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuivSUN( uint[] code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeusvSUN( ushort[] code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeubvSUN( byte[] code ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ReplacementCodePointerSUN( uint type, int stride, void** pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex2fSUN( byte r, byte g, byte b, byte a, float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex2fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex3fSUN( byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4ubVertex3fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fVertex3fSUN( float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3fVertex3fvSUN( float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fVertex3fSUN( float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3fVertex3fvSUN( float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fNormal3fVertex3fSUN( float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4fNormal3fVertex3fvSUN( float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fVertex3fSUN( float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fVertex3fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fVertex4fSUN( float s, float t, float p, float q, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fVertex4fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4ubVertex3fSUN( float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4ubVertex3fvSUN( float[] tc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor3fVertex3fSUN( float s, float t, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor3fVertex3fvSUN( float[] tc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fNormal3fVertex3fSUN( float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fNormal3fVertex3fvSUN( float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fSUN( float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fSUN( float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiVertex3fSUN( uint rc, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiVertex3fvSUN( uint[] rc, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fSUN( uint rc, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fvSUN( uint[] rc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor3fVertex3fSUN( uint rc, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor3fVertex3fvSUN( uint[] rc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fSUN( uint rc, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fvSUN( uint[] rc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fSUN( uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fvSUN( uint[] rc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fSUN( uint rc, float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fvSUN( uint[] rc, float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN( uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN( uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparateEXT( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendFuncSeparateINGR( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeightfEXT( float weight ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeightfvEXT( float[] weight ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexWeightPointerEXT( int size, uint type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FlushVertexArrayRangeNV(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexArrayRangeNV( int length, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterfvNV( uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterfNV( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameterivNV( uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerParameteriNV( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerInputNV( uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerOutputNV( uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FinalCombinerInputNV( uint variable, uint input, uint mapping, uint componentUsage ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerInputParameterfvNV( uint stage, uint portion, uint variable, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerInputParameterivNV( uint stage, uint portion, uint variable, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerOutputParameterfvNV( uint stage, uint portion, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerOutputParameterivNV( uint stage, uint portion, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFinalCombinerInputParameterfvNV( uint variable, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFinalCombinerInputParameterivNV( uint variable, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ResizeBuffersMESA(  ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dMESA( double x, double y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fMESA( float x, float y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2iMESA( int x, int y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2sMESA( short x, short y ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos2svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dMESA( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fMESA( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3iMESA( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3sMESA( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos3svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4dMESA( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4fMESA( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4iMESA( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4sMESA( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void WindowPos4svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiModeDrawArraysIBM( BeginMode mode, int[] first, int[] count, int primcount, int modestride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void MultiModeDrawElementsIBM( BeginMode mode, int[] count, uint type, void** indices, int primcount, int modestride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ColorPointerListIBM( int size, ColorPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SecondaryColorPointerListIBM( int size, uint type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void EdgeFlagPointerListIBM( int stride, bool*[] pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void FogCoordPointerListIBM( uint type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void IndexPointerListIBM( IndexPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void NormalPointerListIBM( NormalPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void TexCoordPointerListIBM( int size, TexCoordPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexPointerListIBM( int size, VertexPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void TbufferMask3DFX( uint mask ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMaskEXT( float value, bool invert ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SamplePatternEXT( uint pattern ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TextureColorMaskSGIS( bool red, bool green, bool blue, bool alpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void IglooInterfaceSGIX( uint pname, void* @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFencesNV( int n, uint[] fences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenFencesNV( int n, ref uint[] fences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFenceNV( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool TestFenceNV( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFenceivNV( uint fence, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FinishFenceNV( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SetFenceNV( uint fence, uint condition ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void MapControlPointsNV( uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MapParameterivNV( uint target, uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MapParameterfvNV( uint target, uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetMapControlPointsNV( uint target, uint index, uint type, int ustride, int vstride, bool packed, ref void* points ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapParameterivNV( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapParameterfvNV( uint target, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapAttribParameterivNV( uint target, uint index, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetMapAttribParameterfvNV( uint target, uint index, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EvalMapsNV( uint target, uint mode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void CombinerStageParameterfvNV( uint stage, uint pname, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetCombinerStageParameterfvNV( uint stage, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool AreProgramsResidentNV( int n, uint[] programs, ref bool[] residences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindProgramNV( uint target, uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteProgramsNV( int n, uint[] programs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ExecuteProgramNV( uint target, uint id, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenProgramsNV( int n, ref uint[] programs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramParameterdvNV( uint target, uint index, uint pname, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramParameterfvNV( uint target, uint index, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramivNV( uint id, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramStringNV( uint id, uint pname, ref byte[] program ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTrackMatrixivNV( uint target, uint address, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribdvNV( uint index, uint pname, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribfvNV( uint index, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribivNV( uint index, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetVertexAttribPointervNV( uint index, uint pname, ref void** pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsProgramNV( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void LoadProgramNV( uint target, uint id, int len, byte[] program ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4dNV( uint target, uint index, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4dvNV( uint target, uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4fNV( uint target, uint index, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameter4fvNV( uint target, uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameters4dvNV( uint target, uint index, uint count, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramParameters4fvNV( uint target, uint index, uint count, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void RequestResidentProgramsNV( int n, uint[] programs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TrackMatrixNV( uint target, uint address, uint matrix, uint transform ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexAttribPointerNV( uint index, int fsize, uint type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dNV( uint index, double x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1dvNV( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fNV( uint index, float x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1fvNV( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1sNV( uint index, short x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1svNV( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dNV( uint index, double x, double y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2dvNV( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fNV( uint index, float x, float y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2fvNV( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2sNV( uint index, short x, short y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2svNV( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dNV( uint index, double x, double y, double z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3dvNV( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fNV( uint index, float x, float y, float z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3fvNV( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3sNV( uint index, short x, short y, short z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3svNV( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dNV( uint index, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4dvNV( uint index, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fNV( uint index, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4fvNV( uint index, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4sNV( uint index, short x, short y, short z, short w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4svNV( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubNV( uint index, byte x, byte y, byte z, byte w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4ubvNV( uint index, byte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1dvNV( uint index, int count, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1fvNV( uint index, int count, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1svNV( uint index, int count, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2dvNV( uint index, int count, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2fvNV( uint index, int count, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2svNV( uint index, int count, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3dvNV( uint index, int count, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3fvNV( uint index, int count, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3svNV( uint index, int count, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4dvNV( uint index, int count, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4fvNV( uint index, int count, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4svNV( uint index, int count, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4ubvNV( uint index, int count, byte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexBumpParameterivATI( uint pname, int[] param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexBumpParameterfvATI( uint pname, float[] param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexBumpParameterivATI( uint pname, ref int[] param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTexBumpParameterfvATI( uint pname, ref float[] param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint GenFragmentShadersATI( uint range ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindFragmentShaderATI( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFragmentShaderATI( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BeginFragmentShaderATI(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndFragmentShaderATI(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PassTexCoordATI( uint dst, uint coord, uint swizzle ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SampleMapATI( uint dst, uint interp, uint swizzle ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp1ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp2ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ColorFragmentOp3ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp1ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp2ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void AlphaFragmentOp3ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SetFragmentShaderConstantATI( uint dst, float[] value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PNTrianglesiATI( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PNTrianglesfATI( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe uint NewObjectBufferATI( int size, void* pointer, uint usage ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsObjectBufferATI( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void UpdateObjectBufferATI( uint buffer, uint offset, int size, void* pointer, uint preserve ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectBufferfvATI( uint buffer, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetObjectBufferivATI( uint buffer, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FreeObjectBufferATI( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ArrayObjectATI( EnableCap array, int size, uint type, int stride, uint buffer, uint offset ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetArrayObjectfvATI( EnableCap array, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetArrayObjectivATI( EnableCap array, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantArrayObjectATI( uint id, uint type, int stride, uint buffer, uint offset ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantArrayObjectfvATI( uint id, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantArrayObjectivATI( uint id, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BeginVertexShaderEXT(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndVertexShaderEXT(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindVertexShaderEXT( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint GenVertexShadersEXT( uint range ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteVertexShaderEXT( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp1EXT( uint op, uint res, uint arg1 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp2EXT( uint op, uint res, uint arg1, uint arg2 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ShaderOp3EXT( uint op, uint res, uint arg1, uint arg2, uint arg3 ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SwizzleEXT( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void WriteMaskEXT( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void InsertComponentEXT( uint res, uint src, uint num ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ExtractComponentEXT( uint res, uint src, uint num ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint GenSymbolsEXT( uint datatype, uint storagetype, uint range, uint components ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SetInvariantEXT( uint id, uint type, void* addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void SetLocalConstantEXT( uint id, uint type, void* addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantbvEXT( uint id, sbyte[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantsvEXT( uint id, short[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantivEXT( uint id, int[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantfvEXT( uint id, float[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantdvEXT( uint id, double[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantubvEXT( uint id, byte[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantusvEXT( uint id, ushort[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VariantuivEXT( uint id, uint[] addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VariantPointerEXT( uint id, uint type, uint stride, void* addr ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EnableVariantClientStateEXT( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DisableVariantClientStateEXT( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint BindLightParameterEXT( LightName light, LightParameter value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint BindMaterialParameterEXT( MaterialFace face, MaterialParameter value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint BindTexGenParameterEXT( uint unit, TextureCoordName coord, TextureGenParameter value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint BindTextureUnitParameterEXT( uint unit, uint value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint BindParameterEXT( uint value ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsVariantEnabledEXT( uint id, uint cap ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantBooleanvEXT( uint id, uint value, ref bool[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantIntegervEXT( uint id, uint value, ref int[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVariantFloatvEXT( uint id, uint value, ref float[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void GetVariantPointervEXT( uint id, uint value, ref void** data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantBooleanvEXT( uint id, uint value, ref bool[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantIntegervEXT( uint id, uint value, ref int[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetInvariantFloatvEXT( uint id, uint value, ref float[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantBooleanvEXT( uint id, uint value, ref bool[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantIntegervEXT( uint id, uint value, ref int[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetLocalConstantFloatvEXT( uint id, uint value, ref float[] data ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1sATI( uint stream, short x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1svATI( uint stream, short[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1iATI( uint stream, int x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1ivATI( uint stream, int[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1fATI( uint stream, float x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1fvATI( uint stream, float[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1dATI( uint stream, double x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream1dvATI( uint stream, double[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2sATI( uint stream, short x, short y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2svATI( uint stream, short[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2iATI( uint stream, int x, int y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2ivATI( uint stream, int[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2fATI( uint stream, float x, float y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2fvATI( uint stream, float[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2dATI( uint stream, double x, double y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream2dvATI( uint stream, double[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3sATI( uint stream, short x, short y, short z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3svATI( uint stream, short[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3iATI( uint stream, int x, int y, int z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3ivATI( uint stream, int[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3fATI( uint stream, float x, float y, float z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3fvATI( uint stream, float[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3dATI( uint stream, double x, double y, double z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream3dvATI( uint stream, double[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4sATI( uint stream, short x, short y, short z, short w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4svATI( uint stream, short[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4iATI( uint stream, int x, int y, int z, int w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4ivATI( uint stream, int[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4fATI( uint stream, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4fvATI( uint stream, float[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4dATI( uint stream, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexStream4dvATI( uint stream, double[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3bATI( uint stream, sbyte nx, sbyte ny, sbyte nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3bvATI( uint stream, sbyte[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3sATI( uint stream, short nx, short ny, short nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3svATI( uint stream, short[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3iATI( uint stream, int nx, int ny, int nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3ivATI( uint stream, int[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3fATI( uint stream, float nx, float ny, float nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3fvATI( uint stream, float[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3dATI( uint stream, double nx, double ny, double nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void NormalStream3dvATI( uint stream, double[] coords ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ClientActiveVertexStreamATI( uint stream ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendEnviATI( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexBlendEnvfATI( uint pname, float param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ElementPointerATI( uint type, void* pointer ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElementArrayATI( BeginMode mode, int count ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElementArrayATI( BeginMode mode, uint start, uint end, int count ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawMeshArraysSUN( BeginMode mode, int first, int count, int width ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GenOcclusionQueriesNV( int n, ref uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteOcclusionQueriesNV( int n, uint[] ids ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsOcclusionQueryNV( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BeginOcclusionQueryNV( uint id ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndOcclusionQueryNV(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetOcclusionQueryivNV( uint id, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetOcclusionQueryuivNV( uint id, uint pname, ref uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameteriNV( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PointParameterivNV( uint pname, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveStencilFaceEXT( uint face ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void ElementPointerAPPLE( uint type, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawElementArrayAPPLE( BeginMode mode, int first, int count ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int first, int count ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawElementArrayAPPLE( BeginMode mode, int[] first, int[] count, int primcount ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiDrawRangeElementArrayAPPLE( BeginMode mode, uint start, uint end, int[] first, int[] count, int primcount ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenFencesAPPLE( int n, ref uint[] fences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFencesAPPLE( int n, uint[] fences ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SetFenceAPPLE( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFenceAPPLE( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool TestFenceAPPLE( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FinishFenceAPPLE( uint fence ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool TestObjectAPPLE( uint @object, uint name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FinishObjectAPPLE( uint @object, int name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindVertexArrayAPPLE( uint array ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteVertexArraysAPPLE( int n, uint[] arrays ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenVertexArraysAPPLE( int n, ref uint[] arrays ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsVertexArrayAPPLE( uint array ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexArrayRangeAPPLE( int length, ref void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void FlushVertexArrayRangeAPPLE( int length, ref void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexArrayParameteriAPPLE( uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DrawBuffersATI( int n, uint[] bufs ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4fNV( uint id, int len, byte[] name, float x, float y, float z, float w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4dNV( uint id, int len, byte[] name, double x, double y, double z, double w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4fvNV( uint id, int len, byte[] name, float[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramNamedParameter4dvNV( uint id, int len, byte[] name, double[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramNamedParameterfvNV( uint id, int len, byte[] name, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramNamedParameterdvNV( uint id, int len, byte[] name, ref double[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2hNV( ushort x, ushort y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex2hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3hNV( ushort x, ushort y, ushort z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex3hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4hNV( ushort x, ushort y, ushort z, ushort w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Vertex4hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3hNV( ushort nx, ushort ny, ushort nz ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Normal3hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3hNV( ushort red, ushort green, ushort blue ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Color3hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4hNV( ushort red, ushort green, ushort blue, ushort alpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void Color4hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1hNV( ushort s ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord1hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2hNV( ushort s, ushort t ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord2hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3hNV( ushort s, ushort t, ushort r ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord3hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4hNV( ushort s, ushort t, ushort r, ushort q ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TexCoord4hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1hNV( uint target, ushort s ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord1hvNV( uint target, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2hNV( uint target, ushort s, ushort t ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord2hvNV( uint target, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3hNV( uint target, ushort s, ushort t, ushort r ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord3hvNV( uint target, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4hNV( uint target, ushort s, ushort t, ushort r, ushort q ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MultiTexCoord4hvNV( uint target, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordhNV( ushort fog ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FogCoordhvNV( ushort[] fog ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3hNV( ushort red, ushort green, ushort blue ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void SecondaryColor3hvNV( ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeighthNV( ushort weight ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexWeighthvNV( ushort[] weight ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1hNV( uint index, ushort x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib1hvNV( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2hNV( uint index, ushort x, ushort y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib2hvNV( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3hNV( uint index, ushort x, ushort y, ushort z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib3hvNV( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4hNV( uint index, ushort x, ushort y, ushort z, ushort w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttrib4hvNV( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs1hvNV( uint index, int n, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs2hvNV( uint index, int n, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs3hvNV( uint index, int n, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribs4hvNV( uint index, int n, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void PixelDataRangeNV( uint target, int length, ref void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FlushPixelDataRangeNV( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PrimitiveRestartNV(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void PrimitiveRestartIndexNV( uint index ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void MapObjectBufferATI( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void UnmapObjectBufferATI( uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilOpSeparateATI( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilFuncSeparateATI( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribArrayObjectATI( uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribArrayObjectfvATI( uint index, uint pname, ref float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribArrayObjectivATI( uint index, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DepthBoundsEXT( double zmin, double zmax ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BlendEquationSeparateEXT( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsRenderbufferEXT( uint renderbuffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindRenderbufferEXT( uint target, uint renderbuffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteRenderbuffersEXT( int n, uint[] renderbuffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenRenderbuffersEXT( int n, ref uint[] renderbuffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageEXT( uint target, uint internalformat, int width, int height ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetRenderbufferParameterivEXT( uint target, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern bool IsFramebufferEXT( uint framebuffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindFramebufferEXT( uint target, uint framebuffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void DeleteFramebuffersEXT( int n, uint[] framebuffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenFramebuffersEXT( int n, ref uint[] framebuffers ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern uint CheckFramebufferStatusEXT( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture1DEXT( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture2DEXT( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferTexture3DEXT( uint target, uint attachment, uint textarget, uint texture, int level, int zoffset ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FramebufferRenderbufferEXT( uint target, uint attachment, uint renderbuffertarget, uint renderbuffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetFramebufferAttachmentParameterivEXT( uint target, uint attachment, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GenerateMipmapEXT( uint target ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void StringMarkerGREMEDY( int len, void* @string ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void StencilClearTagEXT( int stencilTagBits, uint stencilClearTag ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BlitFramebufferEXT( int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageMultisampleEXT( uint target, int samples, uint internalformat, int width, int height ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjecti64vEXT( uint id, uint pname, ref long[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void GetQueryObjectui64vEXT( uint id, uint pname, ref ulong[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameters4fvEXT( uint target, uint index, int count, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameters4fvEXT( uint target, uint index, int count, float[] @params ); // 	
		[DllImport( "opengl32.dll" )]
		public static extern void BufferParameteriAPPLE( uint target, uint pname, int param ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void FlushMappedBufferRangeAPPLE( uint target, int offset, int size ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4iNV( uint target, uint index, int x, int y, int z, int w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4ivNV( uint target, uint index, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParametersI4ivNV( uint target, uint index, int count, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4uiNV( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParameterI4uivNV( uint target, uint index, uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramLocalParametersI4uivNV( uint target, uint index, int count, uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4iNV( uint target, uint index, int x, int y, int z, int w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4ivNV( uint target, uint index, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParametersI4ivNV( uint target, uint index, int count, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4uiNV( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParameterI4uivNV( uint target, uint index, uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramEnvParametersI4uivNV( uint target, uint index, int count, uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterIivNV( uint target, uint index, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramLocalParameterIuivNV( uint target, uint index, ref uint[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterIivNV( uint target, uint index, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetProgramEnvParameterIuivNV( uint target, uint index, ref uint[] @params ); //  extension method	
		public delegate void ProgramVertexLimitNVDelegate( uint target, int limit ); //  extension method
		public static readonly ProgramVertexLimitNVDelegate ProgramVertexLimitNV;
		public delegate void FramebufferTextureEXTDelegate( uint target, uint attachment, uint texture, int level ); //  extension method
		public static readonly FramebufferTextureEXTDelegate FramebufferTextureEXT;
		public delegate void FramebufferTextureLayerEXTDelegate( uint target, uint attachment, uint texture, int level, int layer ); //  extension method
		public static readonly FramebufferTextureLayerEXTDelegate FramebufferTextureLayerEXT;
		public delegate void FramebufferTextureFaceEXTDelegate( uint target, uint attachment, uint texture, int level, TextureTarget face ); //  extension method
		public static readonly FramebufferTextureFaceEXTDelegate FramebufferTextureFaceEXT;
		public delegate void ProgramParameteriEXTDelegate( uint program, uint pname, int value ); //  extension method
		public static readonly ProgramParameteriEXTDelegate ProgramParameteriEXT;
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1iEXT( uint index, int x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2iEXT( uint index, int x, int y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3iEXT( uint index, int x, int y, int z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4iEXT( uint index, int x, int y, int z, int w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1uiEXT( uint index, uint x ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2uiEXT( uint index, uint x, uint y ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3uiEXT( uint index, uint x, uint y, uint z ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4uiEXT( uint index, uint x, uint y, uint z, uint w ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1ivEXT( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2ivEXT( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3ivEXT( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4ivEXT( uint index, int[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI1uivEXT( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI2uivEXT( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI3uivEXT( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4uivEXT( uint index, uint[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4bvEXT( uint index, sbyte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4svEXT( uint index, short[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4ubvEXT( uint index, byte[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void VertexAttribI4usvEXT( uint index, ushort[] v ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern unsafe void VertexAttribIPointerEXT( uint index, int size, uint type, int stride, void* pointer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribIivEXT( uint index, uint pname, ref int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetVertexAttribIuivEXT( uint index, uint pname, ref uint[] @params ); //  extension method	
		public delegate void GetUniformuivEXTDelegate( uint program, int location, ref uint[] @params ); //  extension method
		public static readonly GetUniformuivEXTDelegate GetUniformuivEXT;
		public delegate void BindFragDataLocationEXTDelegate( uint program, uint color, string[] name ); //  extension method
		public static readonly BindFragDataLocationEXTDelegate BindFragDataLocationEXT;
		public delegate int GetFragDataLocationEXTDelegate( uint program, string[] name ); //  extension method
		public static readonly GetFragDataLocationEXTDelegate GetFragDataLocationEXT;
		public delegate void Uniform1uiEXTDelegate( int location, uint v0 ); //  extension method
		public static readonly Uniform1uiEXTDelegate Uniform1uiEXT;
		public delegate void Uniform2uiEXTDelegate( int location, uint v0, uint v1 ); //  extension method
		public static readonly Uniform2uiEXTDelegate Uniform2uiEXT;
		public delegate void Uniform3uiEXTDelegate( int location, uint v0, uint v1, uint v2 ); //  extension method
		public static readonly Uniform3uiEXTDelegate Uniform3uiEXT;
		public delegate void Uniform4uiEXTDelegate( int location, uint v0, uint v1, uint v2, uint v3 ); //  extension method
		public static readonly Uniform4uiEXTDelegate Uniform4uiEXT;
		public delegate void Uniform1uivEXTDelegate( int location, int count, uint[] value ); //  extension method
		public static readonly Uniform1uivEXTDelegate Uniform1uivEXT;
		public delegate void Uniform2uivEXTDelegate( int location, int count, uint[] value ); //  extension method
		public static readonly Uniform2uivEXTDelegate Uniform2uivEXT;
		public delegate void Uniform3uivEXTDelegate( int location, int count, uint[] value ); //  extension method
		public static readonly Uniform3uivEXTDelegate Uniform3uivEXT;
		public delegate void Uniform4uivEXTDelegate( int location, int count, uint[] value ); //  extension method
		public static readonly Uniform4uivEXTDelegate Uniform4uivEXT;
		public delegate void DrawArraysInstancedEXTDelegate( BeginMode mode, int start, int count, int primcount ); //  extension method
		public static readonly DrawArraysInstancedEXTDelegate DrawArraysInstancedEXT;
		public unsafe delegate void DrawElementsInstancedEXTDelegate( BeginMode mode, int count, uint type, void* indices, int primcount ); //  extension method
		public static readonly DrawElementsInstancedEXTDelegate DrawElementsInstancedEXT;
		public delegate void TexBufferEXTDelegate( TextureTarget target, uint internalformat, uint buffer ); //  extension method
		public static readonly TexBufferEXTDelegate TexBufferEXT;
		public delegate void DepthRangedNVDelegate( double zNear, double zFar ); //  extension method
		public static readonly DepthRangedNVDelegate DepthRangedNV;
		public delegate void ClearDepthdNVDelegate( double depth ); //  extension method
		public static readonly ClearDepthdNVDelegate ClearDepthdNV;
		public delegate void DepthBoundsdNVDelegate( double zmin, double zmax ); //  extension method
		public static readonly DepthBoundsdNVDelegate DepthBoundsdNV;
		[DllImport( "opengl32.dll" )]
		public static extern void RenderbufferStorageMultisampleCoverageNV( uint target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersfvNV( uint target, uint buffer, uint index, int count, float[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersIivNV( uint target, uint buffer, uint index, int count, int[] @params ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ProgramBufferParametersIuivNV( uint target, uint buffer, uint index, int count, uint[] @params ); //  extension method	
		public delegate void ColorMaskIndexedEXTDelegate( uint index, bool r, bool g, bool b, bool a ); //  extension method
		public static readonly ColorMaskIndexedEXTDelegate ColorMaskIndexedEXT;
		public delegate void GetBooleanIndexedvEXTDelegate( uint target, uint index, ref bool[] data ); //  extension method
		public static readonly GetBooleanIndexedvEXTDelegate GetBooleanIndexedvEXT;
		public delegate void GetIntegerIndexedvEXTDelegate( uint target, uint index, ref int[] data ); //  extension method
		public static readonly GetIntegerIndexedvEXTDelegate GetIntegerIndexedvEXT;
		public delegate void EnableIndexedEXTDelegate( uint target, uint index ); //  extension method
		public static readonly EnableIndexedEXTDelegate EnableIndexedEXT;
		public delegate void DisableIndexedEXTDelegate( uint target, uint index ); //  extension method
		public static readonly DisableIndexedEXTDelegate DisableIndexedEXT;
		public delegate bool IsEnabledIndexedEXTDelegate( uint target, uint index ); //  extension method
		public static readonly IsEnabledIndexedEXTDelegate IsEnabledIndexedEXT;
		[DllImport( "opengl32.dll" )]
		public static extern void BeginTransformFeedbackNV( uint primitiveMode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void EndTransformFeedbackNV(  ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TransformFeedbackAttribsNV( uint count, int[] attribs, uint bufferMode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferRangeNV( uint target, uint index, uint buffer, int offset, int size ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferOffsetNV( uint target, uint index, uint buffer, int offset ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void BindBufferBaseNV( uint target, uint index, uint buffer ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void TransformFeedbackVaryingsNV( uint program, int count, int[] locations, uint bufferMode ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void ActiveVaryingNV( uint program, string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern int GetVaryingLocationNV( uint program, string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetActiveVaryingNV( uint program, uint index, int bufSize, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method	
		[DllImport( "opengl32.dll" )]
		public static extern void GetTransformFeedbackVaryingNV( uint program, uint index, ref int[] location ); //  extension method	
		public delegate void UniformBufferEXTDelegate( uint program, int location, uint buffer ); //  extension method
		public static readonly UniformBufferEXTDelegate UniformBufferEXT;
		public delegate int GetUniformBufferSizeEXTDelegate( uint program, int location ); //  extension method
		public static readonly GetUniformBufferSizeEXTDelegate GetUniformBufferSizeEXT;
		public delegate int GetUniformOffsetEXTDelegate( uint program, int location ); //  extension method
		public static readonly GetUniformOffsetEXTDelegate GetUniformOffsetEXT;
		public delegate void TexParameterIivEXTDelegate( TextureTarget target, TextureParameterName pname, int[] @params ); //  extension method
		public static readonly TexParameterIivEXTDelegate TexParameterIivEXT;
		public delegate void TexParameterIuivEXTDelegate( TextureTarget target, TextureParameterName pname, uint[] @params ); //  extension method
		public static readonly TexParameterIuivEXTDelegate TexParameterIuivEXT;
		public delegate void GetTexParameterIivEXTDelegate( TextureTarget target, GetTextureParameter pname, ref int[] @params ); //  extension method
		public static readonly GetTexParameterIivEXTDelegate GetTexParameterIivEXT;
		public delegate void GetTexParameterIuivEXTDelegate( TextureTarget target, GetTextureParameter pname, ref uint[] @params ); //  extension method
		public static readonly GetTexParameterIuivEXTDelegate GetTexParameterIuivEXT;
		public delegate void ClearColorIiEXTDelegate( int red, int green, int blue, int alpha ); //  extension method
		public static readonly ClearColorIiEXTDelegate ClearColorIiEXT;
		public delegate void ClearColorIuiEXTDelegate( uint red, uint green, uint blue, uint alpha ); //  extension method
		public static readonly ClearColorIuiEXTDelegate ClearColorIuiEXT;
		[DllImport( "opengl32.dll" )]
		public static extern void FrameTerminatorGREMEDY(  ); //  extension method	
	}
}

