using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static class OpenGLNative
	{
		unsafe static OpenGLNative()
		{
			BlendColor = GetProcAdress< BlendColorDelegate >( "glBlendColor" );
			BlendEquation = GetProcAdress< BlendEquationDelegate >( "glBlendEquation" );
			DrawRangeElements = GetProcAdress< DrawRangeElementsDelegate >( "glDrawRangeElements" );
			ColorTable = GetProcAdress< ColorTableDelegate >( "glColorTable" );
			ColorTableParameterfv = GetProcAdress< ColorTableParameterfvDelegate >( "glColorTableParameterfv" );
			ColorTableParameteriv = GetProcAdress< ColorTableParameterivDelegate >( "glColorTableParameteriv" );
			CopyColorTable = GetProcAdress< CopyColorTableDelegate >( "glCopyColorTable" );
			GetColorTable = GetProcAdress< GetColorTableDelegate >( "glGetColorTable" );
			GetColorTableParameterfv = GetProcAdress< GetColorTableParameterfvDelegate >( "glGetColorTableParameterfv" );
			GetColorTableParameteriv = GetProcAdress< GetColorTableParameterivDelegate >( "glGetColorTableParameteriv" );
			ColorSubTable = GetProcAdress< ColorSubTableDelegate >( "glColorSubTable" );
			CopyColorSubTable = GetProcAdress< CopyColorSubTableDelegate >( "glCopyColorSubTable" );
			ConvolutionFilter1D = GetProcAdress< ConvolutionFilter1DDelegate >( "glConvolutionFilter1D" );
			ConvolutionFilter2D = GetProcAdress< ConvolutionFilter2DDelegate >( "glConvolutionFilter2D" );
			ConvolutionParameterf = GetProcAdress< ConvolutionParameterfDelegate >( "glConvolutionParameterf" );
			ConvolutionParameterfv = GetProcAdress< ConvolutionParameterfvDelegate >( "glConvolutionParameterfv" );
			ConvolutionParameteri = GetProcAdress< ConvolutionParameteriDelegate >( "glConvolutionParameteri" );
			ConvolutionParameteriv = GetProcAdress< ConvolutionParameterivDelegate >( "glConvolutionParameteriv" );
			CopyConvolutionFilter1D = GetProcAdress< CopyConvolutionFilter1DDelegate >( "glCopyConvolutionFilter1D" );
			CopyConvolutionFilter2D = GetProcAdress< CopyConvolutionFilter2DDelegate >( "glCopyConvolutionFilter2D" );
			GetConvolutionFilter = GetProcAdress< GetConvolutionFilterDelegate >( "glGetConvolutionFilter" );
			GetConvolutionParameterfv = GetProcAdress< GetConvolutionParameterfvDelegate >( "glGetConvolutionParameterfv" );
			GetConvolutionParameteriv = GetProcAdress< GetConvolutionParameterivDelegate >( "glGetConvolutionParameteriv" );
			GetSeparableFilter = GetProcAdress< GetSeparableFilterDelegate >( "glGetSeparableFilter" );
			SeparableFilter2D = GetProcAdress< SeparableFilter2DDelegate >( "glSeparableFilter2D" );
			GetHistogram = GetProcAdress< GetHistogramDelegate >( "glGetHistogram" );
			GetHistogramParameterfv = GetProcAdress< GetHistogramParameterfvDelegate >( "glGetHistogramParameterfv" );
			GetHistogramParameteriv = GetProcAdress< GetHistogramParameterivDelegate >( "glGetHistogramParameteriv" );
			GetMinmax = GetProcAdress< GetMinmaxDelegate >( "glGetMinmax" );
			GetMinmaxParameterfv = GetProcAdress< GetMinmaxParameterfvDelegate >( "glGetMinmaxParameterfv" );
			GetMinmaxParameteriv = GetProcAdress< GetMinmaxParameterivDelegate >( "glGetMinmaxParameteriv" );
			Histogram = GetProcAdress< HistogramDelegate >( "glHistogram" );
			Minmax = GetProcAdress< MinmaxDelegate >( "glMinmax" );
			ResetHistogram = GetProcAdress< ResetHistogramDelegate >( "glResetHistogram" );
			ResetMinmax = GetProcAdress< ResetMinmaxDelegate >( "glResetMinmax" );
			TexImage3D = GetProcAdress< TexImage3DDelegate >( "glTexImage3D" );
			TexSubImage3D = GetProcAdress< TexSubImage3DDelegate >( "glTexSubImage3D" );
			CopyTexSubImage3D = GetProcAdress< CopyTexSubImage3DDelegate >( "glCopyTexSubImage3D" );
			ActiveTexture = GetProcAdress< ActiveTextureDelegate >( "glActiveTexture" );
			ClientActiveTexture = GetProcAdress< ClientActiveTextureDelegate >( "glClientActiveTexture" );
			MultiTexCoord1d = GetProcAdress< MultiTexCoord1dDelegate >( "glMultiTexCoord1d" );
			MultiTexCoord1dv = GetProcAdress< MultiTexCoord1dvDelegate >( "glMultiTexCoord1dv" );
			MultiTexCoord1f = GetProcAdress< MultiTexCoord1fDelegate >( "glMultiTexCoord1f" );
			MultiTexCoord1fv = GetProcAdress< MultiTexCoord1fvDelegate >( "glMultiTexCoord1fv" );
			MultiTexCoord1i = GetProcAdress< MultiTexCoord1iDelegate >( "glMultiTexCoord1i" );
			MultiTexCoord1iv = GetProcAdress< MultiTexCoord1ivDelegate >( "glMultiTexCoord1iv" );
			MultiTexCoord1s = GetProcAdress< MultiTexCoord1sDelegate >( "glMultiTexCoord1s" );
			MultiTexCoord1sv = GetProcAdress< MultiTexCoord1svDelegate >( "glMultiTexCoord1sv" );
			MultiTexCoord2d = GetProcAdress< MultiTexCoord2dDelegate >( "glMultiTexCoord2d" );
			MultiTexCoord2dv = GetProcAdress< MultiTexCoord2dvDelegate >( "glMultiTexCoord2dv" );
			MultiTexCoord2f = GetProcAdress< MultiTexCoord2fDelegate >( "glMultiTexCoord2f" );
			MultiTexCoord2fv = GetProcAdress< MultiTexCoord2fvDelegate >( "glMultiTexCoord2fv" );
			MultiTexCoord2i = GetProcAdress< MultiTexCoord2iDelegate >( "glMultiTexCoord2i" );
			MultiTexCoord2iv = GetProcAdress< MultiTexCoord2ivDelegate >( "glMultiTexCoord2iv" );
			MultiTexCoord2s = GetProcAdress< MultiTexCoord2sDelegate >( "glMultiTexCoord2s" );
			MultiTexCoord2sv = GetProcAdress< MultiTexCoord2svDelegate >( "glMultiTexCoord2sv" );
			MultiTexCoord3d = GetProcAdress< MultiTexCoord3dDelegate >( "glMultiTexCoord3d" );
			MultiTexCoord3dv = GetProcAdress< MultiTexCoord3dvDelegate >( "glMultiTexCoord3dv" );
			MultiTexCoord3f = GetProcAdress< MultiTexCoord3fDelegate >( "glMultiTexCoord3f" );
			MultiTexCoord3fv = GetProcAdress< MultiTexCoord3fvDelegate >( "glMultiTexCoord3fv" );
			MultiTexCoord3i = GetProcAdress< MultiTexCoord3iDelegate >( "glMultiTexCoord3i" );
			MultiTexCoord3iv = GetProcAdress< MultiTexCoord3ivDelegate >( "glMultiTexCoord3iv" );
			MultiTexCoord3s = GetProcAdress< MultiTexCoord3sDelegate >( "glMultiTexCoord3s" );
			MultiTexCoord3sv = GetProcAdress< MultiTexCoord3svDelegate >( "glMultiTexCoord3sv" );
			MultiTexCoord4d = GetProcAdress< MultiTexCoord4dDelegate >( "glMultiTexCoord4d" );
			MultiTexCoord4dv = GetProcAdress< MultiTexCoord4dvDelegate >( "glMultiTexCoord4dv" );
			MultiTexCoord4f = GetProcAdress< MultiTexCoord4fDelegate >( "glMultiTexCoord4f" );
			MultiTexCoord4fv = GetProcAdress< MultiTexCoord4fvDelegate >( "glMultiTexCoord4fv" );
			MultiTexCoord4i = GetProcAdress< MultiTexCoord4iDelegate >( "glMultiTexCoord4i" );
			MultiTexCoord4iv = GetProcAdress< MultiTexCoord4ivDelegate >( "glMultiTexCoord4iv" );
			MultiTexCoord4s = GetProcAdress< MultiTexCoord4sDelegate >( "glMultiTexCoord4s" );
			MultiTexCoord4sv = GetProcAdress< MultiTexCoord4svDelegate >( "glMultiTexCoord4sv" );
			LoadTransposeMatrixf = GetProcAdress< LoadTransposeMatrixfDelegate >( "glLoadTransposeMatrixf" );
			LoadTransposeMatrixd = GetProcAdress< LoadTransposeMatrixdDelegate >( "glLoadTransposeMatrixd" );
			MultTransposeMatrixf = GetProcAdress< MultTransposeMatrixfDelegate >( "glMultTransposeMatrixf" );
			MultTransposeMatrixd = GetProcAdress< MultTransposeMatrixdDelegate >( "glMultTransposeMatrixd" );
			SampleCoverage = GetProcAdress< SampleCoverageDelegate >( "glSampleCoverage" );
			CompressedTexImage3D = GetProcAdress< CompressedTexImage3DDelegate >( "glCompressedTexImage3D" );
			CompressedTexImage2D = GetProcAdress< CompressedTexImage2DDelegate >( "glCompressedTexImage2D" );
			CompressedTexImage1D = GetProcAdress< CompressedTexImage1DDelegate >( "glCompressedTexImage1D" );
			CompressedTexSubImage3D = GetProcAdress< CompressedTexSubImage3DDelegate >( "glCompressedTexSubImage3D" );
			CompressedTexSubImage2D = GetProcAdress< CompressedTexSubImage2DDelegate >( "glCompressedTexSubImage2D" );
			CompressedTexSubImage1D = GetProcAdress< CompressedTexSubImage1DDelegate >( "glCompressedTexSubImage1D" );
			GetCompressedTexImage = GetProcAdress< GetCompressedTexImageDelegate >( "glGetCompressedTexImage" );
			BlendFuncSeparate = GetProcAdress< BlendFuncSeparateDelegate >( "glBlendFuncSeparate" );
			FogCoordf = GetProcAdress< FogCoordfDelegate >( "glFogCoordf" );
			FogCoordfv = GetProcAdress< FogCoordfvDelegate >( "glFogCoordfv" );
			FogCoordd = GetProcAdress< FogCoorddDelegate >( "glFogCoordd" );
			FogCoorddv = GetProcAdress< FogCoorddvDelegate >( "glFogCoorddv" );
			FogCoordPointer = GetProcAdress< FogCoordPointerDelegate >( "glFogCoordPointer" );
			MultiDrawArrays = GetProcAdress< MultiDrawArraysDelegate >( "glMultiDrawArrays" );
			MultiDrawElements = GetProcAdress< MultiDrawElementsDelegate >( "glMultiDrawElements" );
			PointParameterf = GetProcAdress< PointParameterfDelegate >( "glPointParameterf" );
			PointParameterfv = GetProcAdress< PointParameterfvDelegate >( "glPointParameterfv" );
			PointParameteri = GetProcAdress< PointParameteriDelegate >( "glPointParameteri" );
			PointParameteriv = GetProcAdress< PointParameterivDelegate >( "glPointParameteriv" );
			SecondaryColor3b = GetProcAdress< SecondaryColor3bDelegate >( "glSecondaryColor3b" );
			SecondaryColor3bv = GetProcAdress< SecondaryColor3bvDelegate >( "glSecondaryColor3bv" );
			SecondaryColor3d = GetProcAdress< SecondaryColor3dDelegate >( "glSecondaryColor3d" );
			SecondaryColor3dv = GetProcAdress< SecondaryColor3dvDelegate >( "glSecondaryColor3dv" );
			SecondaryColor3f = GetProcAdress< SecondaryColor3fDelegate >( "glSecondaryColor3f" );
			SecondaryColor3fv = GetProcAdress< SecondaryColor3fvDelegate >( "glSecondaryColor3fv" );
			SecondaryColor3i = GetProcAdress< SecondaryColor3iDelegate >( "glSecondaryColor3i" );
			SecondaryColor3iv = GetProcAdress< SecondaryColor3ivDelegate >( "glSecondaryColor3iv" );
			SecondaryColor3s = GetProcAdress< SecondaryColor3sDelegate >( "glSecondaryColor3s" );
			SecondaryColor3sv = GetProcAdress< SecondaryColor3svDelegate >( "glSecondaryColor3sv" );
			SecondaryColor3ub = GetProcAdress< SecondaryColor3ubDelegate >( "glSecondaryColor3ub" );
			SecondaryColor3ubv = GetProcAdress< SecondaryColor3ubvDelegate >( "glSecondaryColor3ubv" );
			SecondaryColor3ui = GetProcAdress< SecondaryColor3uiDelegate >( "glSecondaryColor3ui" );
			SecondaryColor3uiv = GetProcAdress< SecondaryColor3uivDelegate >( "glSecondaryColor3uiv" );
			SecondaryColor3us = GetProcAdress< SecondaryColor3usDelegate >( "glSecondaryColor3us" );
			SecondaryColor3usv = GetProcAdress< SecondaryColor3usvDelegate >( "glSecondaryColor3usv" );
			SecondaryColorPointer = GetProcAdress< SecondaryColorPointerDelegate >( "glSecondaryColorPointer" );
			WindowPos2d = GetProcAdress< WindowPos2dDelegate >( "glWindowPos2d" );
			WindowPos2dv = GetProcAdress< WindowPos2dvDelegate >( "glWindowPos2dv" );
			WindowPos2f = GetProcAdress< WindowPos2fDelegate >( "glWindowPos2f" );
			WindowPos2fv = GetProcAdress< WindowPos2fvDelegate >( "glWindowPos2fv" );
			WindowPos2i = GetProcAdress< WindowPos2iDelegate >( "glWindowPos2i" );
			WindowPos2iv = GetProcAdress< WindowPos2ivDelegate >( "glWindowPos2iv" );
			WindowPos2s = GetProcAdress< WindowPos2sDelegate >( "glWindowPos2s" );
			WindowPos2sv = GetProcAdress< WindowPos2svDelegate >( "glWindowPos2sv" );
			WindowPos3d = GetProcAdress< WindowPos3dDelegate >( "glWindowPos3d" );
			WindowPos3dv = GetProcAdress< WindowPos3dvDelegate >( "glWindowPos3dv" );
			WindowPos3f = GetProcAdress< WindowPos3fDelegate >( "glWindowPos3f" );
			WindowPos3fv = GetProcAdress< WindowPos3fvDelegate >( "glWindowPos3fv" );
			WindowPos3i = GetProcAdress< WindowPos3iDelegate >( "glWindowPos3i" );
			WindowPos3iv = GetProcAdress< WindowPos3ivDelegate >( "glWindowPos3iv" );
			WindowPos3s = GetProcAdress< WindowPos3sDelegate >( "glWindowPos3s" );
			WindowPos3sv = GetProcAdress< WindowPos3svDelegate >( "glWindowPos3sv" );
			GenQueries = GetProcAdress< GenQueriesDelegate >( "glGenQueries" );
			DeleteQueries = GetProcAdress< DeleteQueriesDelegate >( "glDeleteQueries" );
			IsQuery = GetProcAdress< IsQueryDelegate >( "glIsQuery" );
			BeginQuery = GetProcAdress< BeginQueryDelegate >( "glBeginQuery" );
			EndQuery = GetProcAdress< EndQueryDelegate >( "glEndQuery" );
			GetQueryiv = GetProcAdress< GetQueryivDelegate >( "glGetQueryiv" );
			GetQueryObjectiv = GetProcAdress< GetQueryObjectivDelegate >( "glGetQueryObjectiv" );
			GetQueryObjectuiv = GetProcAdress< GetQueryObjectuivDelegate >( "glGetQueryObjectuiv" );
			BindBuffer = GetProcAdress< BindBufferDelegate >( "glBindBuffer" );
			DeleteBuffers = GetProcAdress< DeleteBuffersDelegate >( "glDeleteBuffers" );
			GenBuffers = GetProcAdress< GenBuffersDelegate >( "glGenBuffers" );
			IsBuffer = GetProcAdress< IsBufferDelegate >( "glIsBuffer" );
			BufferData = GetProcAdress< BufferDataDelegate >( "glBufferData" );
			BufferSubData = GetProcAdress< BufferSubDataDelegate >( "glBufferSubData" );
			GetBufferSubData = GetProcAdress< GetBufferSubDataDelegate >( "glGetBufferSubData" );
			MapBuffer = GetProcAdress< MapBufferDelegate >( "glMapBuffer" );
			UnmapBuffer = GetProcAdress< UnmapBufferDelegate >( "glUnmapBuffer" );
			GetBufferParameteriv = GetProcAdress< GetBufferParameterivDelegate >( "glGetBufferParameteriv" );
			GetBufferPointerv = GetProcAdress< GetBufferPointervDelegate >( "glGetBufferPointerv" );
			BlendEquationSeparate = GetProcAdress< BlendEquationSeparateDelegate >( "glBlendEquationSeparate" );
			DrawBuffers = GetProcAdress< DrawBuffersDelegate >( "glDrawBuffers" );
			StencilOpSeparate = GetProcAdress< StencilOpSeparateDelegate >( "glStencilOpSeparate" );
			StencilFuncSeparate = GetProcAdress< StencilFuncSeparateDelegate >( "glStencilFuncSeparate" );
			StencilMaskSeparate = GetProcAdress< StencilMaskSeparateDelegate >( "glStencilMaskSeparate" );
			AttachShader = GetProcAdress< AttachShaderDelegate >( "glAttachShader" );
			BindAttribLocation = GetProcAdress< BindAttribLocationDelegate >( "glBindAttribLocation" );
			CompileShader = GetProcAdress< CompileShaderDelegate >( "glCompileShader" );
			CreateProgram = GetProcAdress< CreateProgramDelegate >( "glCreateProgram" );
			CreateShader = GetProcAdress< CreateShaderDelegate >( "glCreateShader" );
			DeleteProgram = GetProcAdress< DeleteProgramDelegate >( "glDeleteProgram" );
			DeleteShader = GetProcAdress< DeleteShaderDelegate >( "glDeleteShader" );
			DetachShader = GetProcAdress< DetachShaderDelegate >( "glDetachShader" );
			DisableVertexAttribArray = GetProcAdress< DisableVertexAttribArrayDelegate >( "glDisableVertexAttribArray" );
			EnableVertexAttribArray = GetProcAdress< EnableVertexAttribArrayDelegate >( "glEnableVertexAttribArray" );
			GetActiveAttrib = GetProcAdress< GetActiveAttribDelegate >( "glGetActiveAttrib" );
			GetActiveUniform = GetProcAdress< GetActiveUniformDelegate >( "glGetActiveUniform" );
			GetAttachedShaders = GetProcAdress< GetAttachedShadersDelegate >( "glGetAttachedShaders" );
			GetAttribLocation = GetProcAdress< GetAttribLocationDelegate >( "glGetAttribLocation" );
			GetProgramiv = GetProcAdress< GetProgramivDelegate >( "glGetProgramiv" );
			GetProgramInfoLog = GetProcAdress< GetProgramInfoLogDelegate >( "glGetProgramInfoLog" );
			GetShaderiv = GetProcAdress< GetShaderivDelegate >( "glGetShaderiv" );
			GetShaderInfoLog = GetProcAdress< GetShaderInfoLogDelegate >( "glGetShaderInfoLog" );
			GetShaderSource = GetProcAdress< GetShaderSourceDelegate >( "glGetShaderSource" );
			GetUniformLocation = GetProcAdress< GetUniformLocationDelegate >( "glGetUniformLocation" );
			GetUniformfv = GetProcAdress< GetUniformfvDelegate >( "glGetUniformfv" );
			GetUniformiv = GetProcAdress< GetUniformivDelegate >( "glGetUniformiv" );
			GetVertexAttribdv = GetProcAdress< GetVertexAttribdvDelegate >( "glGetVertexAttribdv" );
			GetVertexAttribfv = GetProcAdress< GetVertexAttribfvDelegate >( "glGetVertexAttribfv" );
			GetVertexAttribiv = GetProcAdress< GetVertexAttribivDelegate >( "glGetVertexAttribiv" );
			GetVertexAttribPointerv = GetProcAdress< GetVertexAttribPointervDelegate >( "glGetVertexAttribPointerv" );
			IsProgram = GetProcAdress< IsProgramDelegate >( "glIsProgram" );
			IsShader = GetProcAdress< IsShaderDelegate >( "glIsShader" );
			LinkProgram = GetProcAdress< LinkProgramDelegate >( "glLinkProgram" );
			ShaderSource = GetProcAdress< ShaderSourceDelegate >( "glShaderSource" );
			UseProgram = GetProcAdress< UseProgramDelegate >( "glUseProgram" );
			Uniform1f = GetProcAdress< Uniform1fDelegate >( "glUniform1f" );
			Uniform2f = GetProcAdress< Uniform2fDelegate >( "glUniform2f" );
			Uniform3f = GetProcAdress< Uniform3fDelegate >( "glUniform3f" );
			Uniform4f = GetProcAdress< Uniform4fDelegate >( "glUniform4f" );
			Uniform1i = GetProcAdress< Uniform1iDelegate >( "glUniform1i" );
			Uniform2i = GetProcAdress< Uniform2iDelegate >( "glUniform2i" );
			Uniform3i = GetProcAdress< Uniform3iDelegate >( "glUniform3i" );
			Uniform4i = GetProcAdress< Uniform4iDelegate >( "glUniform4i" );
			Uniform1fv = GetProcAdress< Uniform1fvDelegate >( "glUniform1fv" );
			Uniform2fv = GetProcAdress< Uniform2fvDelegate >( "glUniform2fv" );
			Uniform3fv = GetProcAdress< Uniform3fvDelegate >( "glUniform3fv" );
			Uniform4fv = GetProcAdress< Uniform4fvDelegate >( "glUniform4fv" );
			Uniform1iv = GetProcAdress< Uniform1ivDelegate >( "glUniform1iv" );
			Uniform2iv = GetProcAdress< Uniform2ivDelegate >( "glUniform2iv" );
			Uniform3iv = GetProcAdress< Uniform3ivDelegate >( "glUniform3iv" );
			Uniform4iv = GetProcAdress< Uniform4ivDelegate >( "glUniform4iv" );
			UniformMatrix2fv = GetProcAdress< UniformMatrix2fvDelegate >( "glUniformMatrix2fv" );
			UniformMatrix3fv = GetProcAdress< UniformMatrix3fvDelegate >( "glUniformMatrix3fv" );
			UniformMatrix4fv = GetProcAdress< UniformMatrix4fvDelegate >( "glUniformMatrix4fv" );
			ValidateProgram = GetProcAdress< ValidateProgramDelegate >( "glValidateProgram" );
			VertexAttrib1d = GetProcAdress< VertexAttrib1dDelegate >( "glVertexAttrib1d" );
			VertexAttrib1dv = GetProcAdress< VertexAttrib1dvDelegate >( "glVertexAttrib1dv" );
			VertexAttrib1f = GetProcAdress< VertexAttrib1fDelegate >( "glVertexAttrib1f" );
			VertexAttrib1fv = GetProcAdress< VertexAttrib1fvDelegate >( "glVertexAttrib1fv" );
			VertexAttrib1s = GetProcAdress< VertexAttrib1sDelegate >( "glVertexAttrib1s" );
			VertexAttrib1sv = GetProcAdress< VertexAttrib1svDelegate >( "glVertexAttrib1sv" );
			VertexAttrib2d = GetProcAdress< VertexAttrib2dDelegate >( "glVertexAttrib2d" );
			VertexAttrib2dv = GetProcAdress< VertexAttrib2dvDelegate >( "glVertexAttrib2dv" );
			VertexAttrib2f = GetProcAdress< VertexAttrib2fDelegate >( "glVertexAttrib2f" );
			VertexAttrib2fv = GetProcAdress< VertexAttrib2fvDelegate >( "glVertexAttrib2fv" );
			VertexAttrib2s = GetProcAdress< VertexAttrib2sDelegate >( "glVertexAttrib2s" );
			VertexAttrib2sv = GetProcAdress< VertexAttrib2svDelegate >( "glVertexAttrib2sv" );
			VertexAttrib3d = GetProcAdress< VertexAttrib3dDelegate >( "glVertexAttrib3d" );
			VertexAttrib3dv = GetProcAdress< VertexAttrib3dvDelegate >( "glVertexAttrib3dv" );
			VertexAttrib3f = GetProcAdress< VertexAttrib3fDelegate >( "glVertexAttrib3f" );
			VertexAttrib3fv = GetProcAdress< VertexAttrib3fvDelegate >( "glVertexAttrib3fv" );
			VertexAttrib3s = GetProcAdress< VertexAttrib3sDelegate >( "glVertexAttrib3s" );
			VertexAttrib3sv = GetProcAdress< VertexAttrib3svDelegate >( "glVertexAttrib3sv" );
			VertexAttrib4Nbv = GetProcAdress< VertexAttrib4NbvDelegate >( "glVertexAttrib4Nbv" );
			VertexAttrib4Niv = GetProcAdress< VertexAttrib4NivDelegate >( "glVertexAttrib4Niv" );
			VertexAttrib4Nsv = GetProcAdress< VertexAttrib4NsvDelegate >( "glVertexAttrib4Nsv" );
			VertexAttrib4Nub = GetProcAdress< VertexAttrib4NubDelegate >( "glVertexAttrib4Nub" );
			VertexAttrib4Nubv = GetProcAdress< VertexAttrib4NubvDelegate >( "glVertexAttrib4Nubv" );
			VertexAttrib4Nuiv = GetProcAdress< VertexAttrib4NuivDelegate >( "glVertexAttrib4Nuiv" );
			VertexAttrib4Nusv = GetProcAdress< VertexAttrib4NusvDelegate >( "glVertexAttrib4Nusv" );
			VertexAttrib4bv = GetProcAdress< VertexAttrib4bvDelegate >( "glVertexAttrib4bv" );
			VertexAttrib4d = GetProcAdress< VertexAttrib4dDelegate >( "glVertexAttrib4d" );
			VertexAttrib4dv = GetProcAdress< VertexAttrib4dvDelegate >( "glVertexAttrib4dv" );
			VertexAttrib4f = GetProcAdress< VertexAttrib4fDelegate >( "glVertexAttrib4f" );
			VertexAttrib4fv = GetProcAdress< VertexAttrib4fvDelegate >( "glVertexAttrib4fv" );
			VertexAttrib4iv = GetProcAdress< VertexAttrib4ivDelegate >( "glVertexAttrib4iv" );
			VertexAttrib4s = GetProcAdress< VertexAttrib4sDelegate >( "glVertexAttrib4s" );
			VertexAttrib4sv = GetProcAdress< VertexAttrib4svDelegate >( "glVertexAttrib4sv" );
			VertexAttrib4ubv = GetProcAdress< VertexAttrib4ubvDelegate >( "glVertexAttrib4ubv" );
			VertexAttrib4uiv = GetProcAdress< VertexAttrib4uivDelegate >( "glVertexAttrib4uiv" );
			VertexAttrib4usv = GetProcAdress< VertexAttrib4usvDelegate >( "glVertexAttrib4usv" );
			VertexAttribPointer = GetProcAdress< VertexAttribPointerDelegate >( "glVertexAttribPointer" );
			UniformMatrix2x3fv = GetProcAdress< UniformMatrix2x3fvDelegate >( "glUniformMatrix2x3fv" );
			UniformMatrix3x2fv = GetProcAdress< UniformMatrix3x2fvDelegate >( "glUniformMatrix3x2fv" );
			UniformMatrix2x4fv = GetProcAdress< UniformMatrix2x4fvDelegate >( "glUniformMatrix2x4fv" );
			UniformMatrix4x2fv = GetProcAdress< UniformMatrix4x2fvDelegate >( "glUniformMatrix4x2fv" );
			UniformMatrix3x4fv = GetProcAdress< UniformMatrix3x4fvDelegate >( "glUniformMatrix3x4fv" );
			UniformMatrix4x3fv = GetProcAdress< UniformMatrix4x3fvDelegate >( "glUniformMatrix4x3fv" );
			ActiveTextureARB = GetProcAdress< ActiveTextureARBDelegate >( "glActiveTextureARB" );
			ClientActiveTextureARB = GetProcAdress< ClientActiveTextureARBDelegate >( "glClientActiveTextureARB" );
			MultiTexCoord1dARB = GetProcAdress< MultiTexCoord1dARBDelegate >( "glMultiTexCoord1dARB" );
			MultiTexCoord1dvARB = GetProcAdress< MultiTexCoord1dvARBDelegate >( "glMultiTexCoord1dvARB" );
			MultiTexCoord1fARB = GetProcAdress< MultiTexCoord1fARBDelegate >( "glMultiTexCoord1fARB" );
			MultiTexCoord1fvARB = GetProcAdress< MultiTexCoord1fvARBDelegate >( "glMultiTexCoord1fvARB" );
			MultiTexCoord1iARB = GetProcAdress< MultiTexCoord1iARBDelegate >( "glMultiTexCoord1iARB" );
			MultiTexCoord1ivARB = GetProcAdress< MultiTexCoord1ivARBDelegate >( "glMultiTexCoord1ivARB" );
			MultiTexCoord1sARB = GetProcAdress< MultiTexCoord1sARBDelegate >( "glMultiTexCoord1sARB" );
			MultiTexCoord1svARB = GetProcAdress< MultiTexCoord1svARBDelegate >( "glMultiTexCoord1svARB" );
			MultiTexCoord2dARB = GetProcAdress< MultiTexCoord2dARBDelegate >( "glMultiTexCoord2dARB" );
			MultiTexCoord2dvARB = GetProcAdress< MultiTexCoord2dvARBDelegate >( "glMultiTexCoord2dvARB" );
			MultiTexCoord2fARB = GetProcAdress< MultiTexCoord2fARBDelegate >( "glMultiTexCoord2fARB" );
			MultiTexCoord2fvARB = GetProcAdress< MultiTexCoord2fvARBDelegate >( "glMultiTexCoord2fvARB" );
			MultiTexCoord2iARB = GetProcAdress< MultiTexCoord2iARBDelegate >( "glMultiTexCoord2iARB" );
			MultiTexCoord2ivARB = GetProcAdress< MultiTexCoord2ivARBDelegate >( "glMultiTexCoord2ivARB" );
			MultiTexCoord2sARB = GetProcAdress< MultiTexCoord2sARBDelegate >( "glMultiTexCoord2sARB" );
			MultiTexCoord2svARB = GetProcAdress< MultiTexCoord2svARBDelegate >( "glMultiTexCoord2svARB" );
			MultiTexCoord3dARB = GetProcAdress< MultiTexCoord3dARBDelegate >( "glMultiTexCoord3dARB" );
			MultiTexCoord3dvARB = GetProcAdress< MultiTexCoord3dvARBDelegate >( "glMultiTexCoord3dvARB" );
			MultiTexCoord3fARB = GetProcAdress< MultiTexCoord3fARBDelegate >( "glMultiTexCoord3fARB" );
			MultiTexCoord3fvARB = GetProcAdress< MultiTexCoord3fvARBDelegate >( "glMultiTexCoord3fvARB" );
			MultiTexCoord3iARB = GetProcAdress< MultiTexCoord3iARBDelegate >( "glMultiTexCoord3iARB" );
			MultiTexCoord3ivARB = GetProcAdress< MultiTexCoord3ivARBDelegate >( "glMultiTexCoord3ivARB" );
			MultiTexCoord3sARB = GetProcAdress< MultiTexCoord3sARBDelegate >( "glMultiTexCoord3sARB" );
			MultiTexCoord3svARB = GetProcAdress< MultiTexCoord3svARBDelegate >( "glMultiTexCoord3svARB" );
			MultiTexCoord4dARB = GetProcAdress< MultiTexCoord4dARBDelegate >( "glMultiTexCoord4dARB" );
			MultiTexCoord4dvARB = GetProcAdress< MultiTexCoord4dvARBDelegate >( "glMultiTexCoord4dvARB" );
			MultiTexCoord4fARB = GetProcAdress< MultiTexCoord4fARBDelegate >( "glMultiTexCoord4fARB" );
			MultiTexCoord4fvARB = GetProcAdress< MultiTexCoord4fvARBDelegate >( "glMultiTexCoord4fvARB" );
			MultiTexCoord4iARB = GetProcAdress< MultiTexCoord4iARBDelegate >( "glMultiTexCoord4iARB" );
			MultiTexCoord4ivARB = GetProcAdress< MultiTexCoord4ivARBDelegate >( "glMultiTexCoord4ivARB" );
			MultiTexCoord4sARB = GetProcAdress< MultiTexCoord4sARBDelegate >( "glMultiTexCoord4sARB" );
			MultiTexCoord4svARB = GetProcAdress< MultiTexCoord4svARBDelegate >( "glMultiTexCoord4svARB" );
			LoadTransposeMatrixfARB = GetProcAdress< LoadTransposeMatrixfARBDelegate >( "glLoadTransposeMatrixfARB" );
			LoadTransposeMatrixdARB = GetProcAdress< LoadTransposeMatrixdARBDelegate >( "glLoadTransposeMatrixdARB" );
			MultTransposeMatrixfARB = GetProcAdress< MultTransposeMatrixfARBDelegate >( "glMultTransposeMatrixfARB" );
			MultTransposeMatrixdARB = GetProcAdress< MultTransposeMatrixdARBDelegate >( "glMultTransposeMatrixdARB" );
			SampleCoverageARB = GetProcAdress< SampleCoverageARBDelegate >( "glSampleCoverageARB" );
			CompressedTexImage3DARB = GetProcAdress< CompressedTexImage3DARBDelegate >( "glCompressedTexImage3DARB" );
			CompressedTexImage2DARB = GetProcAdress< CompressedTexImage2DARBDelegate >( "glCompressedTexImage2DARB" );
			CompressedTexImage1DARB = GetProcAdress< CompressedTexImage1DARBDelegate >( "glCompressedTexImage1DARB" );
			CompressedTexSubImage3DARB = GetProcAdress< CompressedTexSubImage3DARBDelegate >( "glCompressedTexSubImage3DARB" );
			CompressedTexSubImage2DARB = GetProcAdress< CompressedTexSubImage2DARBDelegate >( "glCompressedTexSubImage2DARB" );
			CompressedTexSubImage1DARB = GetProcAdress< CompressedTexSubImage1DARBDelegate >( "glCompressedTexSubImage1DARB" );
			GetCompressedTexImageARB = GetProcAdress< GetCompressedTexImageARBDelegate >( "glGetCompressedTexImageARB" );
			PointParameterfARB = GetProcAdress< PointParameterfARBDelegate >( "glPointParameterfARB" );
			PointParameterfvARB = GetProcAdress< PointParameterfvARBDelegate >( "glPointParameterfvARB" );
			WeightbvARB = GetProcAdress< WeightbvARBDelegate >( "glWeightbvARB" );
			WeightsvARB = GetProcAdress< WeightsvARBDelegate >( "glWeightsvARB" );
			WeightivARB = GetProcAdress< WeightivARBDelegate >( "glWeightivARB" );
			WeightfvARB = GetProcAdress< WeightfvARBDelegate >( "glWeightfvARB" );
			WeightdvARB = GetProcAdress< WeightdvARBDelegate >( "glWeightdvARB" );
			WeightubvARB = GetProcAdress< WeightubvARBDelegate >( "glWeightubvARB" );
			WeightusvARB = GetProcAdress< WeightusvARBDelegate >( "glWeightusvARB" );
			WeightuivARB = GetProcAdress< WeightuivARBDelegate >( "glWeightuivARB" );
			WeightPointerARB = GetProcAdress< WeightPointerARBDelegate >( "glWeightPointerARB" );
			VertexBlendARB = GetProcAdress< VertexBlendARBDelegate >( "glVertexBlendARB" );
			CurrentPaletteMatrixARB = GetProcAdress< CurrentPaletteMatrixARBDelegate >( "glCurrentPaletteMatrixARB" );
			MatrixIndexubvARB = GetProcAdress< MatrixIndexubvARBDelegate >( "glMatrixIndexubvARB" );
			MatrixIndexusvARB = GetProcAdress< MatrixIndexusvARBDelegate >( "glMatrixIndexusvARB" );
			MatrixIndexuivARB = GetProcAdress< MatrixIndexuivARBDelegate >( "glMatrixIndexuivARB" );
			MatrixIndexPointerARB = GetProcAdress< MatrixIndexPointerARBDelegate >( "glMatrixIndexPointerARB" );
			VertexAttrib1dARB = GetProcAdress< VertexAttrib1dARBDelegate >( "glVertexAttrib1dARB" );
			VertexAttrib1dvARB = GetProcAdress< VertexAttrib1dvARBDelegate >( "glVertexAttrib1dvARB" );
			VertexAttrib1fARB = GetProcAdress< VertexAttrib1fARBDelegate >( "glVertexAttrib1fARB" );
			VertexAttrib1fvARB = GetProcAdress< VertexAttrib1fvARBDelegate >( "glVertexAttrib1fvARB" );
			VertexAttrib1sARB = GetProcAdress< VertexAttrib1sARBDelegate >( "glVertexAttrib1sARB" );
			VertexAttrib1svARB = GetProcAdress< VertexAttrib1svARBDelegate >( "glVertexAttrib1svARB" );
			VertexAttrib2dARB = GetProcAdress< VertexAttrib2dARBDelegate >( "glVertexAttrib2dARB" );
			VertexAttrib2dvARB = GetProcAdress< VertexAttrib2dvARBDelegate >( "glVertexAttrib2dvARB" );
			VertexAttrib2fARB = GetProcAdress< VertexAttrib2fARBDelegate >( "glVertexAttrib2fARB" );
			VertexAttrib2fvARB = GetProcAdress< VertexAttrib2fvARBDelegate >( "glVertexAttrib2fvARB" );
			VertexAttrib2sARB = GetProcAdress< VertexAttrib2sARBDelegate >( "glVertexAttrib2sARB" );
			VertexAttrib2svARB = GetProcAdress< VertexAttrib2svARBDelegate >( "glVertexAttrib2svARB" );
			VertexAttrib3dARB = GetProcAdress< VertexAttrib3dARBDelegate >( "glVertexAttrib3dARB" );
			VertexAttrib3dvARB = GetProcAdress< VertexAttrib3dvARBDelegate >( "glVertexAttrib3dvARB" );
			VertexAttrib3fARB = GetProcAdress< VertexAttrib3fARBDelegate >( "glVertexAttrib3fARB" );
			VertexAttrib3fvARB = GetProcAdress< VertexAttrib3fvARBDelegate >( "glVertexAttrib3fvARB" );
			VertexAttrib3sARB = GetProcAdress< VertexAttrib3sARBDelegate >( "glVertexAttrib3sARB" );
			VertexAttrib3svARB = GetProcAdress< VertexAttrib3svARBDelegate >( "glVertexAttrib3svARB" );
			VertexAttrib4NbvARB = GetProcAdress< VertexAttrib4NbvARBDelegate >( "glVertexAttrib4NbvARB" );
			VertexAttrib4NivARB = GetProcAdress< VertexAttrib4NivARBDelegate >( "glVertexAttrib4NivARB" );
			VertexAttrib4NsvARB = GetProcAdress< VertexAttrib4NsvARBDelegate >( "glVertexAttrib4NsvARB" );
			VertexAttrib4NubARB = GetProcAdress< VertexAttrib4NubARBDelegate >( "glVertexAttrib4NubARB" );
			VertexAttrib4NubvARB = GetProcAdress< VertexAttrib4NubvARBDelegate >( "glVertexAttrib4NubvARB" );
			VertexAttrib4NuivARB = GetProcAdress< VertexAttrib4NuivARBDelegate >( "glVertexAttrib4NuivARB" );
			VertexAttrib4NusvARB = GetProcAdress< VertexAttrib4NusvARBDelegate >( "glVertexAttrib4NusvARB" );
			VertexAttrib4bvARB = GetProcAdress< VertexAttrib4bvARBDelegate >( "glVertexAttrib4bvARB" );
			VertexAttrib4dARB = GetProcAdress< VertexAttrib4dARBDelegate >( "glVertexAttrib4dARB" );
			VertexAttrib4dvARB = GetProcAdress< VertexAttrib4dvARBDelegate >( "glVertexAttrib4dvARB" );
			VertexAttrib4fARB = GetProcAdress< VertexAttrib4fARBDelegate >( "glVertexAttrib4fARB" );
			VertexAttrib4fvARB = GetProcAdress< VertexAttrib4fvARBDelegate >( "glVertexAttrib4fvARB" );
			VertexAttrib4ivARB = GetProcAdress< VertexAttrib4ivARBDelegate >( "glVertexAttrib4ivARB" );
			VertexAttrib4sARB = GetProcAdress< VertexAttrib4sARBDelegate >( "glVertexAttrib4sARB" );
			VertexAttrib4svARB = GetProcAdress< VertexAttrib4svARBDelegate >( "glVertexAttrib4svARB" );
			VertexAttrib4ubvARB = GetProcAdress< VertexAttrib4ubvARBDelegate >( "glVertexAttrib4ubvARB" );
			VertexAttrib4uivARB = GetProcAdress< VertexAttrib4uivARBDelegate >( "glVertexAttrib4uivARB" );
			VertexAttrib4usvARB = GetProcAdress< VertexAttrib4usvARBDelegate >( "glVertexAttrib4usvARB" );
			VertexAttribPointerARB = GetProcAdress< VertexAttribPointerARBDelegate >( "glVertexAttribPointerARB" );
			EnableVertexAttribArrayARB = GetProcAdress< EnableVertexAttribArrayARBDelegate >( "glEnableVertexAttribArrayARB" );
			DisableVertexAttribArrayARB = GetProcAdress< DisableVertexAttribArrayARBDelegate >( "glDisableVertexAttribArrayARB" );
			ProgramStringARB = GetProcAdress< ProgramStringARBDelegate >( "glProgramStringARB" );
			BindProgramARB = GetProcAdress< BindProgramARBDelegate >( "glBindProgramARB" );
			DeleteProgramsARB = GetProcAdress< DeleteProgramsARBDelegate >( "glDeleteProgramsARB" );
			GenProgramsARB = GetProcAdress< GenProgramsARBDelegate >( "glGenProgramsARB" );
			ProgramEnvParameter4dARB = GetProcAdress< ProgramEnvParameter4dARBDelegate >( "glProgramEnvParameter4dARB" );
			ProgramEnvParameter4dvARB = GetProcAdress< ProgramEnvParameter4dvARBDelegate >( "glProgramEnvParameter4dvARB" );
			ProgramEnvParameter4fARB = GetProcAdress< ProgramEnvParameter4fARBDelegate >( "glProgramEnvParameter4fARB" );
			ProgramEnvParameter4fvARB = GetProcAdress< ProgramEnvParameter4fvARBDelegate >( "glProgramEnvParameter4fvARB" );
			ProgramLocalParameter4dARB = GetProcAdress< ProgramLocalParameter4dARBDelegate >( "glProgramLocalParameter4dARB" );
			ProgramLocalParameter4dvARB = GetProcAdress< ProgramLocalParameter4dvARBDelegate >( "glProgramLocalParameter4dvARB" );
			ProgramLocalParameter4fARB = GetProcAdress< ProgramLocalParameter4fARBDelegate >( "glProgramLocalParameter4fARB" );
			ProgramLocalParameter4fvARB = GetProcAdress< ProgramLocalParameter4fvARBDelegate >( "glProgramLocalParameter4fvARB" );
			GetProgramEnvParameterdvARB = GetProcAdress< GetProgramEnvParameterdvARBDelegate >( "glGetProgramEnvParameterdvARB" );
			GetProgramEnvParameterfvARB = GetProcAdress< GetProgramEnvParameterfvARBDelegate >( "glGetProgramEnvParameterfvARB" );
			GetProgramLocalParameterdvARB = GetProcAdress< GetProgramLocalParameterdvARBDelegate >( "glGetProgramLocalParameterdvARB" );
			GetProgramLocalParameterfvARB = GetProcAdress< GetProgramLocalParameterfvARBDelegate >( "glGetProgramLocalParameterfvARB" );
			GetProgramivARB = GetProcAdress< GetProgramivARBDelegate >( "glGetProgramivARB" );
			GetProgramStringARB = GetProcAdress< GetProgramStringARBDelegate >( "glGetProgramStringARB" );
			GetVertexAttribdvARB = GetProcAdress< GetVertexAttribdvARBDelegate >( "glGetVertexAttribdvARB" );
			GetVertexAttribfvARB = GetProcAdress< GetVertexAttribfvARBDelegate >( "glGetVertexAttribfvARB" );
			GetVertexAttribivARB = GetProcAdress< GetVertexAttribivARBDelegate >( "glGetVertexAttribivARB" );
			GetVertexAttribPointervARB = GetProcAdress< GetVertexAttribPointervARBDelegate >( "glGetVertexAttribPointervARB" );
			IsProgramARB = GetProcAdress< IsProgramARBDelegate >( "glIsProgramARB" );
			BindBufferARB = GetProcAdress< BindBufferARBDelegate >( "glBindBufferARB" );
			DeleteBuffersARB = GetProcAdress< DeleteBuffersARBDelegate >( "glDeleteBuffersARB" );
			GenBuffersARB = GetProcAdress< GenBuffersARBDelegate >( "glGenBuffersARB" );
			IsBufferARB = GetProcAdress< IsBufferARBDelegate >( "glIsBufferARB" );
			BufferDataARB = GetProcAdress< BufferDataARBDelegate >( "glBufferDataARB" );
			BufferSubDataARB = GetProcAdress< BufferSubDataARBDelegate >( "glBufferSubDataARB" );
			GetBufferSubDataARB = GetProcAdress< GetBufferSubDataARBDelegate >( "glGetBufferSubDataARB" );
			MapBufferARB = GetProcAdress< MapBufferARBDelegate >( "glMapBufferARB" );
			UnmapBufferARB = GetProcAdress< UnmapBufferARBDelegate >( "glUnmapBufferARB" );
			GetBufferParameterivARB = GetProcAdress< GetBufferParameterivARBDelegate >( "glGetBufferParameterivARB" );
			GetBufferPointervARB = GetProcAdress< GetBufferPointervARBDelegate >( "glGetBufferPointervARB" );
			GenQueriesARB = GetProcAdress< GenQueriesARBDelegate >( "glGenQueriesARB" );
			DeleteQueriesARB = GetProcAdress< DeleteQueriesARBDelegate >( "glDeleteQueriesARB" );
			IsQueryARB = GetProcAdress< IsQueryARBDelegate >( "glIsQueryARB" );
			BeginQueryARB = GetProcAdress< BeginQueryARBDelegate >( "glBeginQueryARB" );
			EndQueryARB = GetProcAdress< EndQueryARBDelegate >( "glEndQueryARB" );
			GetQueryivARB = GetProcAdress< GetQueryivARBDelegate >( "glGetQueryivARB" );
			GetQueryObjectivARB = GetProcAdress< GetQueryObjectivARBDelegate >( "glGetQueryObjectivARB" );
			GetQueryObjectuivARB = GetProcAdress< GetQueryObjectuivARBDelegate >( "glGetQueryObjectuivARB" );
			DeleteObjectARB = GetProcAdress< DeleteObjectARBDelegate >( "glDeleteObjectARB" );
			GetHandleARB = GetProcAdress< GetHandleARBDelegate >( "glGetHandleARB" );
			DetachObjectARB = GetProcAdress< DetachObjectARBDelegate >( "glDetachObjectARB" );
			CreateShaderObjectARB = GetProcAdress< CreateShaderObjectARBDelegate >( "glCreateShaderObjectARB" );
			ShaderSourceARB = GetProcAdress< ShaderSourceARBDelegate >( "glShaderSourceARB" );
			CompileShaderARB = GetProcAdress< CompileShaderARBDelegate >( "glCompileShaderARB" );
			CreateProgramObjectARB = GetProcAdress< CreateProgramObjectARBDelegate >( "glCreateProgramObjectARB" );
			AttachObjectARB = GetProcAdress< AttachObjectARBDelegate >( "glAttachObjectARB" );
			LinkProgramARB = GetProcAdress< LinkProgramARBDelegate >( "glLinkProgramARB" );
			UseProgramObjectARB = GetProcAdress< UseProgramObjectARBDelegate >( "glUseProgramObjectARB" );
			ValidateProgramARB = GetProcAdress< ValidateProgramARBDelegate >( "glValidateProgramARB" );
			Uniform1fARB = GetProcAdress< Uniform1fARBDelegate >( "glUniform1fARB" );
			Uniform2fARB = GetProcAdress< Uniform2fARBDelegate >( "glUniform2fARB" );
			Uniform3fARB = GetProcAdress< Uniform3fARBDelegate >( "glUniform3fARB" );
			Uniform4fARB = GetProcAdress< Uniform4fARBDelegate >( "glUniform4fARB" );
			Uniform1iARB = GetProcAdress< Uniform1iARBDelegate >( "glUniform1iARB" );
			Uniform2iARB = GetProcAdress< Uniform2iARBDelegate >( "glUniform2iARB" );
			Uniform3iARB = GetProcAdress< Uniform3iARBDelegate >( "glUniform3iARB" );
			Uniform4iARB = GetProcAdress< Uniform4iARBDelegate >( "glUniform4iARB" );
			Uniform1fvARB = GetProcAdress< Uniform1fvARBDelegate >( "glUniform1fvARB" );
			Uniform2fvARB = GetProcAdress< Uniform2fvARBDelegate >( "glUniform2fvARB" );
			Uniform3fvARB = GetProcAdress< Uniform3fvARBDelegate >( "glUniform3fvARB" );
			Uniform4fvARB = GetProcAdress< Uniform4fvARBDelegate >( "glUniform4fvARB" );
			Uniform1ivARB = GetProcAdress< Uniform1ivARBDelegate >( "glUniform1ivARB" );
			Uniform2ivARB = GetProcAdress< Uniform2ivARBDelegate >( "glUniform2ivARB" );
			Uniform3ivARB = GetProcAdress< Uniform3ivARBDelegate >( "glUniform3ivARB" );
			Uniform4ivARB = GetProcAdress< Uniform4ivARBDelegate >( "glUniform4ivARB" );
			UniformMatrix2fvARB = GetProcAdress< UniformMatrix2fvARBDelegate >( "glUniformMatrix2fvARB" );
			UniformMatrix3fvARB = GetProcAdress< UniformMatrix3fvARBDelegate >( "glUniformMatrix3fvARB" );
			UniformMatrix4fvARB = GetProcAdress< UniformMatrix4fvARBDelegate >( "glUniformMatrix4fvARB" );
			GetObjectParameterfvARB = GetProcAdress< GetObjectParameterfvARBDelegate >( "glGetObjectParameterfvARB" );
			GetObjectParameterivARB = GetProcAdress< GetObjectParameterivARBDelegate >( "glGetObjectParameterivARB" );
			GetInfoLogARB = GetProcAdress< GetInfoLogARBDelegate >( "glGetInfoLogARB" );
			GetAttachedObjectsARB = GetProcAdress< GetAttachedObjectsARBDelegate >( "glGetAttachedObjectsARB" );
			GetUniformLocationARB = GetProcAdress< GetUniformLocationARBDelegate >( "glGetUniformLocationARB" );
			GetActiveUniformARB = GetProcAdress< GetActiveUniformARBDelegate >( "glGetActiveUniformARB" );
			GetUniformfvARB = GetProcAdress< GetUniformfvARBDelegate >( "glGetUniformfvARB" );
			GetUniformivARB = GetProcAdress< GetUniformivARBDelegate >( "glGetUniformivARB" );
			GetShaderSourceARB = GetProcAdress< GetShaderSourceARBDelegate >( "glGetShaderSourceARB" );
			BindAttribLocationARB = GetProcAdress< BindAttribLocationARBDelegate >( "glBindAttribLocationARB" );
			GetActiveAttribARB = GetProcAdress< GetActiveAttribARBDelegate >( "glGetActiveAttribARB" );
			GetAttribLocationARB = GetProcAdress< GetAttribLocationARBDelegate >( "glGetAttribLocationARB" );
			DrawBuffersARB = GetProcAdress< DrawBuffersARBDelegate >( "glDrawBuffersARB" );
			ClampColorARB = GetProcAdress< ClampColorARBDelegate >( "glClampColorARB" );
			BlendColorEXT = GetProcAdress< BlendColorEXTDelegate >( "glBlendColorEXT" );
			PolygonOffsetEXT = GetProcAdress< PolygonOffsetEXTDelegate >( "glPolygonOffsetEXT" );
			TexImage3DEXT = GetProcAdress< TexImage3DEXTDelegate >( "glTexImage3DEXT" );
			TexSubImage3DEXT = GetProcAdress< TexSubImage3DEXTDelegate >( "glTexSubImage3DEXT" );
			GetTexFilterFuncSGIS = GetProcAdress< GetTexFilterFuncSGISDelegate >( "glGetTexFilterFuncSGIS" );
			TexFilterFuncSGIS = GetProcAdress< TexFilterFuncSGISDelegate >( "glTexFilterFuncSGIS" );
			TexSubImage1DEXT = GetProcAdress< TexSubImage1DEXTDelegate >( "glTexSubImage1DEXT" );
			TexSubImage2DEXT = GetProcAdress< TexSubImage2DEXTDelegate >( "glTexSubImage2DEXT" );
			CopyTexImage1DEXT = GetProcAdress< CopyTexImage1DEXTDelegate >( "glCopyTexImage1DEXT" );
			CopyTexImage2DEXT = GetProcAdress< CopyTexImage2DEXTDelegate >( "glCopyTexImage2DEXT" );
			CopyTexSubImage1DEXT = GetProcAdress< CopyTexSubImage1DEXTDelegate >( "glCopyTexSubImage1DEXT" );
			CopyTexSubImage2DEXT = GetProcAdress< CopyTexSubImage2DEXTDelegate >( "glCopyTexSubImage2DEXT" );
			CopyTexSubImage3DEXT = GetProcAdress< CopyTexSubImage3DEXTDelegate >( "glCopyTexSubImage3DEXT" );
			GetHistogramEXT = GetProcAdress< GetHistogramEXTDelegate >( "glGetHistogramEXT" );
			GetHistogramParameterfvEXT = GetProcAdress< GetHistogramParameterfvEXTDelegate >( "glGetHistogramParameterfvEXT" );
			GetHistogramParameterivEXT = GetProcAdress< GetHistogramParameterivEXTDelegate >( "glGetHistogramParameterivEXT" );
			GetMinmaxEXT = GetProcAdress< GetMinmaxEXTDelegate >( "glGetMinmaxEXT" );
			GetMinmaxParameterfvEXT = GetProcAdress< GetMinmaxParameterfvEXTDelegate >( "glGetMinmaxParameterfvEXT" );
			GetMinmaxParameterivEXT = GetProcAdress< GetMinmaxParameterivEXTDelegate >( "glGetMinmaxParameterivEXT" );
			HistogramEXT = GetProcAdress< HistogramEXTDelegate >( "glHistogramEXT" );
			MinmaxEXT = GetProcAdress< MinmaxEXTDelegate >( "glMinmaxEXT" );
			ResetHistogramEXT = GetProcAdress< ResetHistogramEXTDelegate >( "glResetHistogramEXT" );
			ResetMinmaxEXT = GetProcAdress< ResetMinmaxEXTDelegate >( "glResetMinmaxEXT" );
			ConvolutionFilter1DEXT = GetProcAdress< ConvolutionFilter1DEXTDelegate >( "glConvolutionFilter1DEXT" );
			ConvolutionFilter2DEXT = GetProcAdress< ConvolutionFilter2DEXTDelegate >( "glConvolutionFilter2DEXT" );
			ConvolutionParameterfEXT = GetProcAdress< ConvolutionParameterfEXTDelegate >( "glConvolutionParameterfEXT" );
			ConvolutionParameterfvEXT = GetProcAdress< ConvolutionParameterfvEXTDelegate >( "glConvolutionParameterfvEXT" );
			ConvolutionParameteriEXT = GetProcAdress< ConvolutionParameteriEXTDelegate >( "glConvolutionParameteriEXT" );
			ConvolutionParameterivEXT = GetProcAdress< ConvolutionParameterivEXTDelegate >( "glConvolutionParameterivEXT" );
			CopyConvolutionFilter1DEXT = GetProcAdress< CopyConvolutionFilter1DEXTDelegate >( "glCopyConvolutionFilter1DEXT" );
			CopyConvolutionFilter2DEXT = GetProcAdress< CopyConvolutionFilter2DEXTDelegate >( "glCopyConvolutionFilter2DEXT" );
			GetConvolutionFilterEXT = GetProcAdress< GetConvolutionFilterEXTDelegate >( "glGetConvolutionFilterEXT" );
			GetConvolutionParameterfvEXT = GetProcAdress< GetConvolutionParameterfvEXTDelegate >( "glGetConvolutionParameterfvEXT" );
			GetConvolutionParameterivEXT = GetProcAdress< GetConvolutionParameterivEXTDelegate >( "glGetConvolutionParameterivEXT" );
			GetSeparableFilterEXT = GetProcAdress< GetSeparableFilterEXTDelegate >( "glGetSeparableFilterEXT" );
			SeparableFilter2DEXT = GetProcAdress< SeparableFilter2DEXTDelegate >( "glSeparableFilter2DEXT" );
			ColorTableSGI = GetProcAdress< ColorTableSGIDelegate >( "glColorTableSGI" );
			ColorTableParameterfvSGI = GetProcAdress< ColorTableParameterfvSGIDelegate >( "glColorTableParameterfvSGI" );
			ColorTableParameterivSGI = GetProcAdress< ColorTableParameterivSGIDelegate >( "glColorTableParameterivSGI" );
			CopyColorTableSGI = GetProcAdress< CopyColorTableSGIDelegate >( "glCopyColorTableSGI" );
			GetColorTableSGI = GetProcAdress< GetColorTableSGIDelegate >( "glGetColorTableSGI" );
			GetColorTableParameterfvSGI = GetProcAdress< GetColorTableParameterfvSGIDelegate >( "glGetColorTableParameterfvSGI" );
			GetColorTableParameterivSGI = GetProcAdress< GetColorTableParameterivSGIDelegate >( "glGetColorTableParameterivSGI" );
			PixelTexGenSGIX = GetProcAdress< PixelTexGenSGIXDelegate >( "glPixelTexGenSGIX" );
			PixelTexGenParameteriSGIS = GetProcAdress< PixelTexGenParameteriSGISDelegate >( "glPixelTexGenParameteriSGIS" );
			PixelTexGenParameterivSGIS = GetProcAdress< PixelTexGenParameterivSGISDelegate >( "glPixelTexGenParameterivSGIS" );
			PixelTexGenParameterfSGIS = GetProcAdress< PixelTexGenParameterfSGISDelegate >( "glPixelTexGenParameterfSGIS" );
			PixelTexGenParameterfvSGIS = GetProcAdress< PixelTexGenParameterfvSGISDelegate >( "glPixelTexGenParameterfvSGIS" );
			GetPixelTexGenParameterivSGIS = GetProcAdress< GetPixelTexGenParameterivSGISDelegate >( "glGetPixelTexGenParameterivSGIS" );
			GetPixelTexGenParameterfvSGIS = GetProcAdress< GetPixelTexGenParameterfvSGISDelegate >( "glGetPixelTexGenParameterfvSGIS" );
			TexImage4DSGIS = GetProcAdress< TexImage4DSGISDelegate >( "glTexImage4DSGIS" );
			TexSubImage4DSGIS = GetProcAdress< TexSubImage4DSGISDelegate >( "glTexSubImage4DSGIS" );
			AreTexturesResidentEXT = GetProcAdress< AreTexturesResidentEXTDelegate >( "glAreTexturesResidentEXT" );
			BindTextureEXT = GetProcAdress< BindTextureEXTDelegate >( "glBindTextureEXT" );
			DeleteTexturesEXT = GetProcAdress< DeleteTexturesEXTDelegate >( "glDeleteTexturesEXT" );
			GenTexturesEXT = GetProcAdress< GenTexturesEXTDelegate >( "glGenTexturesEXT" );
			IsTextureEXT = GetProcAdress< IsTextureEXTDelegate >( "glIsTextureEXT" );
			PrioritizeTexturesEXT = GetProcAdress< PrioritizeTexturesEXTDelegate >( "glPrioritizeTexturesEXT" );
			DetailTexFuncSGIS = GetProcAdress< DetailTexFuncSGISDelegate >( "glDetailTexFuncSGIS" );
			GetDetailTexFuncSGIS = GetProcAdress< GetDetailTexFuncSGISDelegate >( "glGetDetailTexFuncSGIS" );
			SharpenTexFuncSGIS = GetProcAdress< SharpenTexFuncSGISDelegate >( "glSharpenTexFuncSGIS" );
			GetSharpenTexFuncSGIS = GetProcAdress< GetSharpenTexFuncSGISDelegate >( "glGetSharpenTexFuncSGIS" );
			SampleMaskSGIS = GetProcAdress< SampleMaskSGISDelegate >( "glSampleMaskSGIS" );
			SamplePatternSGIS = GetProcAdress< SamplePatternSGISDelegate >( "glSamplePatternSGIS" );
			ArrayElementEXT = GetProcAdress< ArrayElementEXTDelegate >( "glArrayElementEXT" );
			ColorPointerEXT = GetProcAdress< ColorPointerEXTDelegate >( "glColorPointerEXT" );
			DrawArraysEXT = GetProcAdress< DrawArraysEXTDelegate >( "glDrawArraysEXT" );
			EdgeFlagPointerEXT = GetProcAdress< EdgeFlagPointerEXTDelegate >( "glEdgeFlagPointerEXT" );
			GetPointervEXT = GetProcAdress< GetPointervEXTDelegate >( "glGetPointervEXT" );
			IndexPointerEXT = GetProcAdress< IndexPointerEXTDelegate >( "glIndexPointerEXT" );
			NormalPointerEXT = GetProcAdress< NormalPointerEXTDelegate >( "glNormalPointerEXT" );
			TexCoordPointerEXT = GetProcAdress< TexCoordPointerEXTDelegate >( "glTexCoordPointerEXT" );
			VertexPointerEXT = GetProcAdress< VertexPointerEXTDelegate >( "glVertexPointerEXT" );
			BlendEquationEXT = GetProcAdress< BlendEquationEXTDelegate >( "glBlendEquationEXT" );
			SpriteParameterfSGIX = GetProcAdress< SpriteParameterfSGIXDelegate >( "glSpriteParameterfSGIX" );
			SpriteParameterfvSGIX = GetProcAdress< SpriteParameterfvSGIXDelegate >( "glSpriteParameterfvSGIX" );
			SpriteParameteriSGIX = GetProcAdress< SpriteParameteriSGIXDelegate >( "glSpriteParameteriSGIX" );
			SpriteParameterivSGIX = GetProcAdress< SpriteParameterivSGIXDelegate >( "glSpriteParameterivSGIX" );
			PointParameterfEXT = GetProcAdress< PointParameterfEXTDelegate >( "glPointParameterfEXT" );
			PointParameterfvEXT = GetProcAdress< PointParameterfvEXTDelegate >( "glPointParameterfvEXT" );
			PointParameterfSGIS = GetProcAdress< PointParameterfSGISDelegate >( "glPointParameterfSGIS" );
			PointParameterfvSGIS = GetProcAdress< PointParameterfvSGISDelegate >( "glPointParameterfvSGIS" );
			GetInstrumentsSGIX = GetProcAdress< GetInstrumentsSGIXDelegate >( "glGetInstrumentsSGIX" );
			InstrumentsBufferSGIX = GetProcAdress< InstrumentsBufferSGIXDelegate >( "glInstrumentsBufferSGIX" );
			PollInstrumentsSGIX = GetProcAdress< PollInstrumentsSGIXDelegate >( "glPollInstrumentsSGIX" );
			ReadInstrumentsSGIX = GetProcAdress< ReadInstrumentsSGIXDelegate >( "glReadInstrumentsSGIX" );
			StartInstrumentsSGIX = GetProcAdress< StartInstrumentsSGIXDelegate >( "glStartInstrumentsSGIX" );
			StopInstrumentsSGIX = GetProcAdress< StopInstrumentsSGIXDelegate >( "glStopInstrumentsSGIX" );
			FrameZoomSGIX = GetProcAdress< FrameZoomSGIXDelegate >( "glFrameZoomSGIX" );
			TagSampleBufferSGIX = GetProcAdress< TagSampleBufferSGIXDelegate >( "glTagSampleBufferSGIX" );
			DeformationMap3dSGIX = GetProcAdress< DeformationMap3dSGIXDelegate >( "glDeformationMap3dSGIX" );
			DeformationMap3fSGIX = GetProcAdress< DeformationMap3fSGIXDelegate >( "glDeformationMap3fSGIX" );
			DeformSGIX = GetProcAdress< DeformSGIXDelegate >( "glDeformSGIX" );
			LoadIdentityDeformationMapSGIX = GetProcAdress< LoadIdentityDeformationMapSGIXDelegate >( "glLoadIdentityDeformationMapSGIX" );
			ReferencePlaneSGIX = GetProcAdress< ReferencePlaneSGIXDelegate >( "glReferencePlaneSGIX" );
			FlushRasterSGIX = GetProcAdress< FlushRasterSGIXDelegate >( "glFlushRasterSGIX" );
			FogFuncSGIS = GetProcAdress< FogFuncSGISDelegate >( "glFogFuncSGIS" );
			GetFogFuncSGIS = GetProcAdress< GetFogFuncSGISDelegate >( "glGetFogFuncSGIS" );
			ColorSubTableEXT = GetProcAdress< ColorSubTableEXTDelegate >( "glColorSubTableEXT" );
			CopyColorSubTableEXT = GetProcAdress< CopyColorSubTableEXTDelegate >( "glCopyColorSubTableEXT" );
			GetListParameterfvSGIX = GetProcAdress< GetListParameterfvSGIXDelegate >( "glGetListParameterfvSGIX" );
			GetListParameterivSGIX = GetProcAdress< GetListParameterivSGIXDelegate >( "glGetListParameterivSGIX" );
			ListParameterfSGIX = GetProcAdress< ListParameterfSGIXDelegate >( "glListParameterfSGIX" );
			ListParameterfvSGIX = GetProcAdress< ListParameterfvSGIXDelegate >( "glListParameterfvSGIX" );
			ListParameteriSGIX = GetProcAdress< ListParameteriSGIXDelegate >( "glListParameteriSGIX" );
			ListParameterivSGIX = GetProcAdress< ListParameterivSGIXDelegate >( "glListParameterivSGIX" );
			IndexMaterialEXT = GetProcAdress< IndexMaterialEXTDelegate >( "glIndexMaterialEXT" );
			IndexFuncEXT = GetProcAdress< IndexFuncEXTDelegate >( "glIndexFuncEXT" );
			LockArraysEXT = GetProcAdress< LockArraysEXTDelegate >( "glLockArraysEXT" );
			UnlockArraysEXT = GetProcAdress< UnlockArraysEXTDelegate >( "glUnlockArraysEXT" );
			CullParameterdvEXT = GetProcAdress< CullParameterdvEXTDelegate >( "glCullParameterdvEXT" );
			CullParameterfvEXT = GetProcAdress< CullParameterfvEXTDelegate >( "glCullParameterfvEXT" );
			FragmentColorMaterialSGIX = GetProcAdress< FragmentColorMaterialSGIXDelegate >( "glFragmentColorMaterialSGIX" );
			FragmentLightfSGIX = GetProcAdress< FragmentLightfSGIXDelegate >( "glFragmentLightfSGIX" );
			FragmentLightfvSGIX = GetProcAdress< FragmentLightfvSGIXDelegate >( "glFragmentLightfvSGIX" );
			FragmentLightiSGIX = GetProcAdress< FragmentLightiSGIXDelegate >( "glFragmentLightiSGIX" );
			FragmentLightivSGIX = GetProcAdress< FragmentLightivSGIXDelegate >( "glFragmentLightivSGIX" );
			FragmentLightModelfSGIX = GetProcAdress< FragmentLightModelfSGIXDelegate >( "glFragmentLightModelfSGIX" );
			FragmentLightModelfvSGIX = GetProcAdress< FragmentLightModelfvSGIXDelegate >( "glFragmentLightModelfvSGIX" );
			FragmentLightModeliSGIX = GetProcAdress< FragmentLightModeliSGIXDelegate >( "glFragmentLightModeliSGIX" );
			FragmentLightModelivSGIX = GetProcAdress< FragmentLightModelivSGIXDelegate >( "glFragmentLightModelivSGIX" );
			FragmentMaterialfSGIX = GetProcAdress< FragmentMaterialfSGIXDelegate >( "glFragmentMaterialfSGIX" );
			FragmentMaterialfvSGIX = GetProcAdress< FragmentMaterialfvSGIXDelegate >( "glFragmentMaterialfvSGIX" );
			FragmentMaterialiSGIX = GetProcAdress< FragmentMaterialiSGIXDelegate >( "glFragmentMaterialiSGIX" );
			FragmentMaterialivSGIX = GetProcAdress< FragmentMaterialivSGIXDelegate >( "glFragmentMaterialivSGIX" );
			GetFragmentLightfvSGIX = GetProcAdress< GetFragmentLightfvSGIXDelegate >( "glGetFragmentLightfvSGIX" );
			GetFragmentLightivSGIX = GetProcAdress< GetFragmentLightivSGIXDelegate >( "glGetFragmentLightivSGIX" );
			GetFragmentMaterialfvSGIX = GetProcAdress< GetFragmentMaterialfvSGIXDelegate >( "glGetFragmentMaterialfvSGIX" );
			GetFragmentMaterialivSGIX = GetProcAdress< GetFragmentMaterialivSGIXDelegate >( "glGetFragmentMaterialivSGIX" );
			LightEnviSGIX = GetProcAdress< LightEnviSGIXDelegate >( "glLightEnviSGIX" );
			AsyncMarkerSGIX = GetProcAdress< AsyncMarkerSGIXDelegate >( "glAsyncMarkerSGIX" );
			FinishAsyncSGIX = GetProcAdress< FinishAsyncSGIXDelegate >( "glFinishAsyncSGIX" );
			PollAsyncSGIX = GetProcAdress< PollAsyncSGIXDelegate >( "glPollAsyncSGIX" );
			GenAsyncMarkersSGIX = GetProcAdress< GenAsyncMarkersSGIXDelegate >( "glGenAsyncMarkersSGIX" );
			DeleteAsyncMarkersSGIX = GetProcAdress< DeleteAsyncMarkersSGIXDelegate >( "glDeleteAsyncMarkersSGIX" );
			IsAsyncMarkerSGIX = GetProcAdress< IsAsyncMarkerSGIXDelegate >( "glIsAsyncMarkerSGIX" );
			SecondaryColorPointerEXT = GetProcAdress< SecondaryColorPointerEXTDelegate >( "glSecondaryColorPointerEXT" );
			BlendFuncSeparateEXT = GetProcAdress< BlendFuncSeparateEXTDelegate >( "glBlendFuncSeparateEXT" );
			BlendFuncSeparateINGR = GetProcAdress< BlendFuncSeparateINGRDelegate >( "glBlendFuncSeparateINGR" );
			VertexWeightfEXT = GetProcAdress< VertexWeightfEXTDelegate >( "glVertexWeightfEXT" );
			VertexWeightfvEXT = GetProcAdress< VertexWeightfvEXTDelegate >( "glVertexWeightfvEXT" );
			VertexWeightPointerEXT = GetProcAdress< VertexWeightPointerEXTDelegate >( "glVertexWeightPointerEXT" );
			FlushVertexArrayRangeNV = GetProcAdress< FlushVertexArrayRangeNVDelegate >( "glFlushVertexArrayRangeNV" );
			VertexArrayRangeNV = GetProcAdress< VertexArrayRangeNVDelegate >( "glVertexArrayRangeNV" );
			CombinerParameterfvNV = GetProcAdress< CombinerParameterfvNVDelegate >( "glCombinerParameterfvNV" );
			CombinerParameterfNV = GetProcAdress< CombinerParameterfNVDelegate >( "glCombinerParameterfNV" );
			CombinerParameterivNV = GetProcAdress< CombinerParameterivNVDelegate >( "glCombinerParameterivNV" );
			CombinerParameteriNV = GetProcAdress< CombinerParameteriNVDelegate >( "glCombinerParameteriNV" );
			CombinerInputNV = GetProcAdress< CombinerInputNVDelegate >( "glCombinerInputNV" );
			CombinerOutputNV = GetProcAdress< CombinerOutputNVDelegate >( "glCombinerOutputNV" );
			FinalCombinerInputNV = GetProcAdress< FinalCombinerInputNVDelegate >( "glFinalCombinerInputNV" );
			GetCombinerInputParameterfvNV = GetProcAdress< GetCombinerInputParameterfvNVDelegate >( "glGetCombinerInputParameterfvNV" );
			GetCombinerInputParameterivNV = GetProcAdress< GetCombinerInputParameterivNVDelegate >( "glGetCombinerInputParameterivNV" );
			GetCombinerOutputParameterfvNV = GetProcAdress< GetCombinerOutputParameterfvNVDelegate >( "glGetCombinerOutputParameterfvNV" );
			GetCombinerOutputParameterivNV = GetProcAdress< GetCombinerOutputParameterivNVDelegate >( "glGetCombinerOutputParameterivNV" );
			GetFinalCombinerInputParameterfvNV = GetProcAdress< GetFinalCombinerInputParameterfvNVDelegate >( "glGetFinalCombinerInputParameterfvNV" );
			GetFinalCombinerInputParameterivNV = GetProcAdress< GetFinalCombinerInputParameterivNVDelegate >( "glGetFinalCombinerInputParameterivNV" );
			TbufferMask3DFX = GetProcAdress< TbufferMask3DFXDelegate >( "glTbufferMask3DFX" );
			SampleMaskEXT = GetProcAdress< SampleMaskEXTDelegate >( "glSampleMaskEXT" );
			SamplePatternEXT = GetProcAdress< SamplePatternEXTDelegate >( "glSamplePatternEXT" );
			TextureColorMaskSGIS = GetProcAdress< TextureColorMaskSGISDelegate >( "glTextureColorMaskSGIS" );
			IglooInterfaceSGIX = GetProcAdress< IglooInterfaceSGIXDelegate >( "glIglooInterfaceSGIX" );
			DeleteFencesNV = GetProcAdress< DeleteFencesNVDelegate >( "glDeleteFencesNV" );
			GenFencesNV = GetProcAdress< GenFencesNVDelegate >( "glGenFencesNV" );
			IsFenceNV = GetProcAdress< IsFenceNVDelegate >( "glIsFenceNV" );
			TestFenceNV = GetProcAdress< TestFenceNVDelegate >( "glTestFenceNV" );
			GetFenceivNV = GetProcAdress< GetFenceivNVDelegate >( "glGetFenceivNV" );
			FinishFenceNV = GetProcAdress< FinishFenceNVDelegate >( "glFinishFenceNV" );
			SetFenceNV = GetProcAdress< SetFenceNVDelegate >( "glSetFenceNV" );
			MapControlPointsNV = GetProcAdress< MapControlPointsNVDelegate >( "glMapControlPointsNV" );
			MapParameterivNV = GetProcAdress< MapParameterivNVDelegate >( "glMapParameterivNV" );
			MapParameterfvNV = GetProcAdress< MapParameterfvNVDelegate >( "glMapParameterfvNV" );
			GetMapControlPointsNV = GetProcAdress< GetMapControlPointsNVDelegate >( "glGetMapControlPointsNV" );
			GetMapParameterivNV = GetProcAdress< GetMapParameterivNVDelegate >( "glGetMapParameterivNV" );
			GetMapParameterfvNV = GetProcAdress< GetMapParameterfvNVDelegate >( "glGetMapParameterfvNV" );
			GetMapAttribParameterivNV = GetProcAdress< GetMapAttribParameterivNVDelegate >( "glGetMapAttribParameterivNV" );
			GetMapAttribParameterfvNV = GetProcAdress< GetMapAttribParameterfvNVDelegate >( "glGetMapAttribParameterfvNV" );
			EvalMapsNV = GetProcAdress< EvalMapsNVDelegate >( "glEvalMapsNV" );
			CombinerStageParameterfvNV = GetProcAdress< CombinerStageParameterfvNVDelegate >( "glCombinerStageParameterfvNV" );
			GetCombinerStageParameterfvNV = GetProcAdress< GetCombinerStageParameterfvNVDelegate >( "glGetCombinerStageParameterfvNV" );
			AreProgramsResidentNV = GetProcAdress< AreProgramsResidentNVDelegate >( "glAreProgramsResidentNV" );
			BindProgramNV = GetProcAdress< BindProgramNVDelegate >( "glBindProgramNV" );
			DeleteProgramsNV = GetProcAdress< DeleteProgramsNVDelegate >( "glDeleteProgramsNV" );
			ExecuteProgramNV = GetProcAdress< ExecuteProgramNVDelegate >( "glExecuteProgramNV" );
			GenProgramsNV = GetProcAdress< GenProgramsNVDelegate >( "glGenProgramsNV" );
			GetProgramParameterdvNV = GetProcAdress< GetProgramParameterdvNVDelegate >( "glGetProgramParameterdvNV" );
			GetProgramParameterfvNV = GetProcAdress< GetProgramParameterfvNVDelegate >( "glGetProgramParameterfvNV" );
			GetProgramivNV = GetProcAdress< GetProgramivNVDelegate >( "glGetProgramivNV" );
			GetProgramStringNV = GetProcAdress< GetProgramStringNVDelegate >( "glGetProgramStringNV" );
			GetTrackMatrixivNV = GetProcAdress< GetTrackMatrixivNVDelegate >( "glGetTrackMatrixivNV" );
			GetVertexAttribdvNV = GetProcAdress< GetVertexAttribdvNVDelegate >( "glGetVertexAttribdvNV" );
			GetVertexAttribfvNV = GetProcAdress< GetVertexAttribfvNVDelegate >( "glGetVertexAttribfvNV" );
			GetVertexAttribivNV = GetProcAdress< GetVertexAttribivNVDelegate >( "glGetVertexAttribivNV" );
			GetVertexAttribPointervNV = GetProcAdress< GetVertexAttribPointervNVDelegate >( "glGetVertexAttribPointervNV" );
			IsProgramNV = GetProcAdress< IsProgramNVDelegate >( "glIsProgramNV" );
			LoadProgramNV = GetProcAdress< LoadProgramNVDelegate >( "glLoadProgramNV" );
			ProgramParameter4dNV = GetProcAdress< ProgramParameter4dNVDelegate >( "glProgramParameter4dNV" );
			ProgramParameter4dvNV = GetProcAdress< ProgramParameter4dvNVDelegate >( "glProgramParameter4dvNV" );
			ProgramParameter4fNV = GetProcAdress< ProgramParameter4fNVDelegate >( "glProgramParameter4fNV" );
			ProgramParameter4fvNV = GetProcAdress< ProgramParameter4fvNVDelegate >( "glProgramParameter4fvNV" );
			ProgramParameters4dvNV = GetProcAdress< ProgramParameters4dvNVDelegate >( "glProgramParameters4dvNV" );
			ProgramParameters4fvNV = GetProcAdress< ProgramParameters4fvNVDelegate >( "glProgramParameters4fvNV" );
			RequestResidentProgramsNV = GetProcAdress< RequestResidentProgramsNVDelegate >( "glRequestResidentProgramsNV" );
			TrackMatrixNV = GetProcAdress< TrackMatrixNVDelegate >( "glTrackMatrixNV" );
			VertexAttribPointerNV = GetProcAdress< VertexAttribPointerNVDelegate >( "glVertexAttribPointerNV" );
			VertexAttrib1dNV = GetProcAdress< VertexAttrib1dNVDelegate >( "glVertexAttrib1dNV" );
			VertexAttrib1dvNV = GetProcAdress< VertexAttrib1dvNVDelegate >( "glVertexAttrib1dvNV" );
			VertexAttrib1fNV = GetProcAdress< VertexAttrib1fNVDelegate >( "glVertexAttrib1fNV" );
			VertexAttrib1fvNV = GetProcAdress< VertexAttrib1fvNVDelegate >( "glVertexAttrib1fvNV" );
			VertexAttrib1sNV = GetProcAdress< VertexAttrib1sNVDelegate >( "glVertexAttrib1sNV" );
			VertexAttrib1svNV = GetProcAdress< VertexAttrib1svNVDelegate >( "glVertexAttrib1svNV" );
			VertexAttrib2dNV = GetProcAdress< VertexAttrib2dNVDelegate >( "glVertexAttrib2dNV" );
			VertexAttrib2dvNV = GetProcAdress< VertexAttrib2dvNVDelegate >( "glVertexAttrib2dvNV" );
			VertexAttrib2fNV = GetProcAdress< VertexAttrib2fNVDelegate >( "glVertexAttrib2fNV" );
			VertexAttrib2fvNV = GetProcAdress< VertexAttrib2fvNVDelegate >( "glVertexAttrib2fvNV" );
			VertexAttrib2sNV = GetProcAdress< VertexAttrib2sNVDelegate >( "glVertexAttrib2sNV" );
			VertexAttrib2svNV = GetProcAdress< VertexAttrib2svNVDelegate >( "glVertexAttrib2svNV" );
			VertexAttrib3dNV = GetProcAdress< VertexAttrib3dNVDelegate >( "glVertexAttrib3dNV" );
			VertexAttrib3dvNV = GetProcAdress< VertexAttrib3dvNVDelegate >( "glVertexAttrib3dvNV" );
			VertexAttrib3fNV = GetProcAdress< VertexAttrib3fNVDelegate >( "glVertexAttrib3fNV" );
			VertexAttrib3fvNV = GetProcAdress< VertexAttrib3fvNVDelegate >( "glVertexAttrib3fvNV" );
			VertexAttrib3sNV = GetProcAdress< VertexAttrib3sNVDelegate >( "glVertexAttrib3sNV" );
			VertexAttrib3svNV = GetProcAdress< VertexAttrib3svNVDelegate >( "glVertexAttrib3svNV" );
			VertexAttrib4dNV = GetProcAdress< VertexAttrib4dNVDelegate >( "glVertexAttrib4dNV" );
			VertexAttrib4dvNV = GetProcAdress< VertexAttrib4dvNVDelegate >( "glVertexAttrib4dvNV" );
			VertexAttrib4fNV = GetProcAdress< VertexAttrib4fNVDelegate >( "glVertexAttrib4fNV" );
			VertexAttrib4fvNV = GetProcAdress< VertexAttrib4fvNVDelegate >( "glVertexAttrib4fvNV" );
			VertexAttrib4sNV = GetProcAdress< VertexAttrib4sNVDelegate >( "glVertexAttrib4sNV" );
			VertexAttrib4svNV = GetProcAdress< VertexAttrib4svNVDelegate >( "glVertexAttrib4svNV" );
			VertexAttrib4ubNV = GetProcAdress< VertexAttrib4ubNVDelegate >( "glVertexAttrib4ubNV" );
			VertexAttrib4ubvNV = GetProcAdress< VertexAttrib4ubvNVDelegate >( "glVertexAttrib4ubvNV" );
			VertexAttribs1dvNV = GetProcAdress< VertexAttribs1dvNVDelegate >( "glVertexAttribs1dvNV" );
			VertexAttribs1fvNV = GetProcAdress< VertexAttribs1fvNVDelegate >( "glVertexAttribs1fvNV" );
			VertexAttribs1svNV = GetProcAdress< VertexAttribs1svNVDelegate >( "glVertexAttribs1svNV" );
			VertexAttribs2dvNV = GetProcAdress< VertexAttribs2dvNVDelegate >( "glVertexAttribs2dvNV" );
			VertexAttribs2fvNV = GetProcAdress< VertexAttribs2fvNVDelegate >( "glVertexAttribs2fvNV" );
			VertexAttribs2svNV = GetProcAdress< VertexAttribs2svNVDelegate >( "glVertexAttribs2svNV" );
			VertexAttribs3dvNV = GetProcAdress< VertexAttribs3dvNVDelegate >( "glVertexAttribs3dvNV" );
			VertexAttribs3fvNV = GetProcAdress< VertexAttribs3fvNVDelegate >( "glVertexAttribs3fvNV" );
			VertexAttribs3svNV = GetProcAdress< VertexAttribs3svNVDelegate >( "glVertexAttribs3svNV" );
			VertexAttribs4dvNV = GetProcAdress< VertexAttribs4dvNVDelegate >( "glVertexAttribs4dvNV" );
			VertexAttribs4fvNV = GetProcAdress< VertexAttribs4fvNVDelegate >( "glVertexAttribs4fvNV" );
			VertexAttribs4svNV = GetProcAdress< VertexAttribs4svNVDelegate >( "glVertexAttribs4svNV" );
			VertexAttribs4ubvNV = GetProcAdress< VertexAttribs4ubvNVDelegate >( "glVertexAttribs4ubvNV" );
			TexBumpParameterivATI = GetProcAdress< TexBumpParameterivATIDelegate >( "glTexBumpParameterivATI" );
			TexBumpParameterfvATI = GetProcAdress< TexBumpParameterfvATIDelegate >( "glTexBumpParameterfvATI" );
			GetTexBumpParameterivATI = GetProcAdress< GetTexBumpParameterivATIDelegate >( "glGetTexBumpParameterivATI" );
			GetTexBumpParameterfvATI = GetProcAdress< GetTexBumpParameterfvATIDelegate >( "glGetTexBumpParameterfvATI" );
			GenFragmentShadersATI = GetProcAdress< GenFragmentShadersATIDelegate >( "glGenFragmentShadersATI" );
			BindFragmentShaderATI = GetProcAdress< BindFragmentShaderATIDelegate >( "glBindFragmentShaderATI" );
			DeleteFragmentShaderATI = GetProcAdress< DeleteFragmentShaderATIDelegate >( "glDeleteFragmentShaderATI" );
			BeginFragmentShaderATI = GetProcAdress< BeginFragmentShaderATIDelegate >( "glBeginFragmentShaderATI" );
			EndFragmentShaderATI = GetProcAdress< EndFragmentShaderATIDelegate >( "glEndFragmentShaderATI" );
			PassTexCoordATI = GetProcAdress< PassTexCoordATIDelegate >( "glPassTexCoordATI" );
			SampleMapATI = GetProcAdress< SampleMapATIDelegate >( "glSampleMapATI" );
			ColorFragmentOp1ATI = GetProcAdress< ColorFragmentOp1ATIDelegate >( "glColorFragmentOp1ATI" );
			ColorFragmentOp2ATI = GetProcAdress< ColorFragmentOp2ATIDelegate >( "glColorFragmentOp2ATI" );
			ColorFragmentOp3ATI = GetProcAdress< ColorFragmentOp3ATIDelegate >( "glColorFragmentOp3ATI" );
			AlphaFragmentOp1ATI = GetProcAdress< AlphaFragmentOp1ATIDelegate >( "glAlphaFragmentOp1ATI" );
			AlphaFragmentOp2ATI = GetProcAdress< AlphaFragmentOp2ATIDelegate >( "glAlphaFragmentOp2ATI" );
			AlphaFragmentOp3ATI = GetProcAdress< AlphaFragmentOp3ATIDelegate >( "glAlphaFragmentOp3ATI" );
			SetFragmentShaderConstantATI = GetProcAdress< SetFragmentShaderConstantATIDelegate >( "glSetFragmentShaderConstantATI" );
			PNTrianglesiATI = GetProcAdress< PNTrianglesiATIDelegate >( "glPNTrianglesiATI" );
			PNTrianglesfATI = GetProcAdress< PNTrianglesfATIDelegate >( "glPNTrianglesfATI" );
			NewObjectBufferATI = GetProcAdress< NewObjectBufferATIDelegate >( "glNewObjectBufferATI" );
			IsObjectBufferATI = GetProcAdress< IsObjectBufferATIDelegate >( "glIsObjectBufferATI" );
			UpdateObjectBufferATI = GetProcAdress< UpdateObjectBufferATIDelegate >( "glUpdateObjectBufferATI" );
			GetObjectBufferfvATI = GetProcAdress< GetObjectBufferfvATIDelegate >( "glGetObjectBufferfvATI" );
			GetObjectBufferivATI = GetProcAdress< GetObjectBufferivATIDelegate >( "glGetObjectBufferivATI" );
			FreeObjectBufferATI = GetProcAdress< FreeObjectBufferATIDelegate >( "glFreeObjectBufferATI" );
			ArrayObjectATI = GetProcAdress< ArrayObjectATIDelegate >( "glArrayObjectATI" );
			GetArrayObjectfvATI = GetProcAdress< GetArrayObjectfvATIDelegate >( "glGetArrayObjectfvATI" );
			GetArrayObjectivATI = GetProcAdress< GetArrayObjectivATIDelegate >( "glGetArrayObjectivATI" );
			VariantArrayObjectATI = GetProcAdress< VariantArrayObjectATIDelegate >( "glVariantArrayObjectATI" );
			GetVariantArrayObjectfvATI = GetProcAdress< GetVariantArrayObjectfvATIDelegate >( "glGetVariantArrayObjectfvATI" );
			GetVariantArrayObjectivATI = GetProcAdress< GetVariantArrayObjectivATIDelegate >( "glGetVariantArrayObjectivATI" );
			BeginVertexShaderEXT = GetProcAdress< BeginVertexShaderEXTDelegate >( "glBeginVertexShaderEXT" );
			EndVertexShaderEXT = GetProcAdress< EndVertexShaderEXTDelegate >( "glEndVertexShaderEXT" );
			BindVertexShaderEXT = GetProcAdress< BindVertexShaderEXTDelegate >( "glBindVertexShaderEXT" );
			GenVertexShadersEXT = GetProcAdress< GenVertexShadersEXTDelegate >( "glGenVertexShadersEXT" );
			DeleteVertexShaderEXT = GetProcAdress< DeleteVertexShaderEXTDelegate >( "glDeleteVertexShaderEXT" );
			ShaderOp1EXT = GetProcAdress< ShaderOp1EXTDelegate >( "glShaderOp1EXT" );
			ShaderOp2EXT = GetProcAdress< ShaderOp2EXTDelegate >( "glShaderOp2EXT" );
			ShaderOp3EXT = GetProcAdress< ShaderOp3EXTDelegate >( "glShaderOp3EXT" );
			SwizzleEXT = GetProcAdress< SwizzleEXTDelegate >( "glSwizzleEXT" );
			WriteMaskEXT = GetProcAdress< WriteMaskEXTDelegate >( "glWriteMaskEXT" );
			InsertComponentEXT = GetProcAdress< InsertComponentEXTDelegate >( "glInsertComponentEXT" );
			ExtractComponentEXT = GetProcAdress< ExtractComponentEXTDelegate >( "glExtractComponentEXT" );
			GenSymbolsEXT = GetProcAdress< GenSymbolsEXTDelegate >( "glGenSymbolsEXT" );
			SetInvariantEXT = GetProcAdress< SetInvariantEXTDelegate >( "glSetInvariantEXT" );
			SetLocalConstantEXT = GetProcAdress< SetLocalConstantEXTDelegate >( "glSetLocalConstantEXT" );
			VariantbvEXT = GetProcAdress< VariantbvEXTDelegate >( "glVariantbvEXT" );
			VariantsvEXT = GetProcAdress< VariantsvEXTDelegate >( "glVariantsvEXT" );
			VariantivEXT = GetProcAdress< VariantivEXTDelegate >( "glVariantivEXT" );
			VariantfvEXT = GetProcAdress< VariantfvEXTDelegate >( "glVariantfvEXT" );
			VariantdvEXT = GetProcAdress< VariantdvEXTDelegate >( "glVariantdvEXT" );
			VariantubvEXT = GetProcAdress< VariantubvEXTDelegate >( "glVariantubvEXT" );
			VariantusvEXT = GetProcAdress< VariantusvEXTDelegate >( "glVariantusvEXT" );
			VariantuivEXT = GetProcAdress< VariantuivEXTDelegate >( "glVariantuivEXT" );
			VariantPointerEXT = GetProcAdress< VariantPointerEXTDelegate >( "glVariantPointerEXT" );
			EnableVariantClientStateEXT = GetProcAdress< EnableVariantClientStateEXTDelegate >( "glEnableVariantClientStateEXT" );
			DisableVariantClientStateEXT = GetProcAdress< DisableVariantClientStateEXTDelegate >( "glDisableVariantClientStateEXT" );
			BindLightParameterEXT = GetProcAdress< BindLightParameterEXTDelegate >( "glBindLightParameterEXT" );
			BindMaterialParameterEXT = GetProcAdress< BindMaterialParameterEXTDelegate >( "glBindMaterialParameterEXT" );
			BindTexGenParameterEXT = GetProcAdress< BindTexGenParameterEXTDelegate >( "glBindTexGenParameterEXT" );
			BindTextureUnitParameterEXT = GetProcAdress< BindTextureUnitParameterEXTDelegate >( "glBindTextureUnitParameterEXT" );
			BindParameterEXT = GetProcAdress< BindParameterEXTDelegate >( "glBindParameterEXT" );
			IsVariantEnabledEXT = GetProcAdress< IsVariantEnabledEXTDelegate >( "glIsVariantEnabledEXT" );
			GetVariantBooleanvEXT = GetProcAdress< GetVariantBooleanvEXTDelegate >( "glGetVariantBooleanvEXT" );
			GetVariantIntegervEXT = GetProcAdress< GetVariantIntegervEXTDelegate >( "glGetVariantIntegervEXT" );
			GetVariantFloatvEXT = GetProcAdress< GetVariantFloatvEXTDelegate >( "glGetVariantFloatvEXT" );
			GetVariantPointervEXT = GetProcAdress< GetVariantPointervEXTDelegate >( "glGetVariantPointervEXT" );
			GetInvariantBooleanvEXT = GetProcAdress< GetInvariantBooleanvEXTDelegate >( "glGetInvariantBooleanvEXT" );
			GetInvariantIntegervEXT = GetProcAdress< GetInvariantIntegervEXTDelegate >( "glGetInvariantIntegervEXT" );
			GetInvariantFloatvEXT = GetProcAdress< GetInvariantFloatvEXTDelegate >( "glGetInvariantFloatvEXT" );
			GetLocalConstantBooleanvEXT = GetProcAdress< GetLocalConstantBooleanvEXTDelegate >( "glGetLocalConstantBooleanvEXT" );
			GetLocalConstantIntegervEXT = GetProcAdress< GetLocalConstantIntegervEXTDelegate >( "glGetLocalConstantIntegervEXT" );
			GetLocalConstantFloatvEXT = GetProcAdress< GetLocalConstantFloatvEXTDelegate >( "glGetLocalConstantFloatvEXT" );
			VertexStream1sATI = GetProcAdress< VertexStream1sATIDelegate >( "glVertexStream1sATI" );
			VertexStream1svATI = GetProcAdress< VertexStream1svATIDelegate >( "glVertexStream1svATI" );
			VertexStream1iATI = GetProcAdress< VertexStream1iATIDelegate >( "glVertexStream1iATI" );
			VertexStream1ivATI = GetProcAdress< VertexStream1ivATIDelegate >( "glVertexStream1ivATI" );
			VertexStream1fATI = GetProcAdress< VertexStream1fATIDelegate >( "glVertexStream1fATI" );
			VertexStream1fvATI = GetProcAdress< VertexStream1fvATIDelegate >( "glVertexStream1fvATI" );
			VertexStream1dATI = GetProcAdress< VertexStream1dATIDelegate >( "glVertexStream1dATI" );
			VertexStream1dvATI = GetProcAdress< VertexStream1dvATIDelegate >( "glVertexStream1dvATI" );
			VertexStream2sATI = GetProcAdress< VertexStream2sATIDelegate >( "glVertexStream2sATI" );
			VertexStream2svATI = GetProcAdress< VertexStream2svATIDelegate >( "glVertexStream2svATI" );
			VertexStream2iATI = GetProcAdress< VertexStream2iATIDelegate >( "glVertexStream2iATI" );
			VertexStream2ivATI = GetProcAdress< VertexStream2ivATIDelegate >( "glVertexStream2ivATI" );
			VertexStream2fATI = GetProcAdress< VertexStream2fATIDelegate >( "glVertexStream2fATI" );
			VertexStream2fvATI = GetProcAdress< VertexStream2fvATIDelegate >( "glVertexStream2fvATI" );
			VertexStream2dATI = GetProcAdress< VertexStream2dATIDelegate >( "glVertexStream2dATI" );
			VertexStream2dvATI = GetProcAdress< VertexStream2dvATIDelegate >( "glVertexStream2dvATI" );
			VertexStream3sATI = GetProcAdress< VertexStream3sATIDelegate >( "glVertexStream3sATI" );
			VertexStream3svATI = GetProcAdress< VertexStream3svATIDelegate >( "glVertexStream3svATI" );
			VertexStream3iATI = GetProcAdress< VertexStream3iATIDelegate >( "glVertexStream3iATI" );
			VertexStream3ivATI = GetProcAdress< VertexStream3ivATIDelegate >( "glVertexStream3ivATI" );
			VertexStream3fATI = GetProcAdress< VertexStream3fATIDelegate >( "glVertexStream3fATI" );
			VertexStream3fvATI = GetProcAdress< VertexStream3fvATIDelegate >( "glVertexStream3fvATI" );
			VertexStream3dATI = GetProcAdress< VertexStream3dATIDelegate >( "glVertexStream3dATI" );
			VertexStream3dvATI = GetProcAdress< VertexStream3dvATIDelegate >( "glVertexStream3dvATI" );
			VertexStream4sATI = GetProcAdress< VertexStream4sATIDelegate >( "glVertexStream4sATI" );
			VertexStream4svATI = GetProcAdress< VertexStream4svATIDelegate >( "glVertexStream4svATI" );
			VertexStream4iATI = GetProcAdress< VertexStream4iATIDelegate >( "glVertexStream4iATI" );
			VertexStream4ivATI = GetProcAdress< VertexStream4ivATIDelegate >( "glVertexStream4ivATI" );
			VertexStream4fATI = GetProcAdress< VertexStream4fATIDelegate >( "glVertexStream4fATI" );
			VertexStream4fvATI = GetProcAdress< VertexStream4fvATIDelegate >( "glVertexStream4fvATI" );
			VertexStream4dATI = GetProcAdress< VertexStream4dATIDelegate >( "glVertexStream4dATI" );
			VertexStream4dvATI = GetProcAdress< VertexStream4dvATIDelegate >( "glVertexStream4dvATI" );
			NormalStream3bATI = GetProcAdress< NormalStream3bATIDelegate >( "glNormalStream3bATI" );
			NormalStream3bvATI = GetProcAdress< NormalStream3bvATIDelegate >( "glNormalStream3bvATI" );
			NormalStream3sATI = GetProcAdress< NormalStream3sATIDelegate >( "glNormalStream3sATI" );
			NormalStream3svATI = GetProcAdress< NormalStream3svATIDelegate >( "glNormalStream3svATI" );
			NormalStream3iATI = GetProcAdress< NormalStream3iATIDelegate >( "glNormalStream3iATI" );
			NormalStream3ivATI = GetProcAdress< NormalStream3ivATIDelegate >( "glNormalStream3ivATI" );
			NormalStream3fATI = GetProcAdress< NormalStream3fATIDelegate >( "glNormalStream3fATI" );
			NormalStream3fvATI = GetProcAdress< NormalStream3fvATIDelegate >( "glNormalStream3fvATI" );
			NormalStream3dATI = GetProcAdress< NormalStream3dATIDelegate >( "glNormalStream3dATI" );
			NormalStream3dvATI = GetProcAdress< NormalStream3dvATIDelegate >( "glNormalStream3dvATI" );
			ClientActiveVertexStreamATI = GetProcAdress< ClientActiveVertexStreamATIDelegate >( "glClientActiveVertexStreamATI" );
			VertexBlendEnviATI = GetProcAdress< VertexBlendEnviATIDelegate >( "glVertexBlendEnviATI" );
			VertexBlendEnvfATI = GetProcAdress< VertexBlendEnvfATIDelegate >( "glVertexBlendEnvfATI" );
			ElementPointerATI = GetProcAdress< ElementPointerATIDelegate >( "glElementPointerATI" );
			DrawElementArrayATI = GetProcAdress< DrawElementArrayATIDelegate >( "glDrawElementArrayATI" );
			DrawRangeElementArrayATI = GetProcAdress< DrawRangeElementArrayATIDelegate >( "glDrawRangeElementArrayATI" );
			GenOcclusionQueriesNV = GetProcAdress< GenOcclusionQueriesNVDelegate >( "glGenOcclusionQueriesNV" );
			DeleteOcclusionQueriesNV = GetProcAdress< DeleteOcclusionQueriesNVDelegate >( "glDeleteOcclusionQueriesNV" );
			IsOcclusionQueryNV = GetProcAdress< IsOcclusionQueryNVDelegate >( "glIsOcclusionQueryNV" );
			BeginOcclusionQueryNV = GetProcAdress< BeginOcclusionQueryNVDelegate >( "glBeginOcclusionQueryNV" );
			EndOcclusionQueryNV = GetProcAdress< EndOcclusionQueryNVDelegate >( "glEndOcclusionQueryNV" );
			GetOcclusionQueryivNV = GetProcAdress< GetOcclusionQueryivNVDelegate >( "glGetOcclusionQueryivNV" );
			GetOcclusionQueryuivNV = GetProcAdress< GetOcclusionQueryuivNVDelegate >( "glGetOcclusionQueryuivNV" );
			PointParameteriNV = GetProcAdress< PointParameteriNVDelegate >( "glPointParameteriNV" );
			PointParameterivNV = GetProcAdress< PointParameterivNVDelegate >( "glPointParameterivNV" );
			ActiveStencilFaceEXT = GetProcAdress< ActiveStencilFaceEXTDelegate >( "glActiveStencilFaceEXT" );
			ElementPointerAPPLE = GetProcAdress< ElementPointerAPPLEDelegate >( "glElementPointerAPPLE" );
			DrawElementArrayAPPLE = GetProcAdress< DrawElementArrayAPPLEDelegate >( "glDrawElementArrayAPPLE" );
			DrawRangeElementArrayAPPLE = GetProcAdress< DrawRangeElementArrayAPPLEDelegate >( "glDrawRangeElementArrayAPPLE" );
			MultiDrawElementArrayAPPLE = GetProcAdress< MultiDrawElementArrayAPPLEDelegate >( "glMultiDrawElementArrayAPPLE" );
			MultiDrawRangeElementArrayAPPLE = GetProcAdress< MultiDrawRangeElementArrayAPPLEDelegate >( "glMultiDrawRangeElementArrayAPPLE" );
			GenFencesAPPLE = GetProcAdress< GenFencesAPPLEDelegate >( "glGenFencesAPPLE" );
			DeleteFencesAPPLE = GetProcAdress< DeleteFencesAPPLEDelegate >( "glDeleteFencesAPPLE" );
			SetFenceAPPLE = GetProcAdress< SetFenceAPPLEDelegate >( "glSetFenceAPPLE" );
			IsFenceAPPLE = GetProcAdress< IsFenceAPPLEDelegate >( "glIsFenceAPPLE" );
			TestFenceAPPLE = GetProcAdress< TestFenceAPPLEDelegate >( "glTestFenceAPPLE" );
			FinishFenceAPPLE = GetProcAdress< FinishFenceAPPLEDelegate >( "glFinishFenceAPPLE" );
			TestObjectAPPLE = GetProcAdress< TestObjectAPPLEDelegate >( "glTestObjectAPPLE" );
			FinishObjectAPPLE = GetProcAdress< FinishObjectAPPLEDelegate >( "glFinishObjectAPPLE" );
			BindVertexArrayAPPLE = GetProcAdress< BindVertexArrayAPPLEDelegate >( "glBindVertexArrayAPPLE" );
			DeleteVertexArraysAPPLE = GetProcAdress< DeleteVertexArraysAPPLEDelegate >( "glDeleteVertexArraysAPPLE" );
			GenVertexArraysAPPLE = GetProcAdress< GenVertexArraysAPPLEDelegate >( "glGenVertexArraysAPPLE" );
			IsVertexArrayAPPLE = GetProcAdress< IsVertexArrayAPPLEDelegate >( "glIsVertexArrayAPPLE" );
			VertexArrayRangeAPPLE = GetProcAdress< VertexArrayRangeAPPLEDelegate >( "glVertexArrayRangeAPPLE" );
			FlushVertexArrayRangeAPPLE = GetProcAdress< FlushVertexArrayRangeAPPLEDelegate >( "glFlushVertexArrayRangeAPPLE" );
			VertexArrayParameteriAPPLE = GetProcAdress< VertexArrayParameteriAPPLEDelegate >( "glVertexArrayParameteriAPPLE" );
			DrawBuffersATI = GetProcAdress< DrawBuffersATIDelegate >( "glDrawBuffersATI" );
			ProgramNamedParameter4fNV = GetProcAdress< ProgramNamedParameter4fNVDelegate >( "glProgramNamedParameter4fNV" );
			ProgramNamedParameter4dNV = GetProcAdress< ProgramNamedParameter4dNVDelegate >( "glProgramNamedParameter4dNV" );
			ProgramNamedParameter4fvNV = GetProcAdress< ProgramNamedParameter4fvNVDelegate >( "glProgramNamedParameter4fvNV" );
			ProgramNamedParameter4dvNV = GetProcAdress< ProgramNamedParameter4dvNVDelegate >( "glProgramNamedParameter4dvNV" );
			GetProgramNamedParameterfvNV = GetProcAdress< GetProgramNamedParameterfvNVDelegate >( "glGetProgramNamedParameterfvNV" );
			GetProgramNamedParameterdvNV = GetProcAdress< GetProgramNamedParameterdvNVDelegate >( "glGetProgramNamedParameterdvNV" );
			Vertex2hNV = GetProcAdress< Vertex2hNVDelegate >( "glVertex2hNV" );
			Vertex2hvNV = GetProcAdress< Vertex2hvNVDelegate >( "glVertex2hvNV" );
			Vertex3hNV = GetProcAdress< Vertex3hNVDelegate >( "glVertex3hNV" );
			Vertex3hvNV = GetProcAdress< Vertex3hvNVDelegate >( "glVertex3hvNV" );
			Vertex4hNV = GetProcAdress< Vertex4hNVDelegate >( "glVertex4hNV" );
			Vertex4hvNV = GetProcAdress< Vertex4hvNVDelegate >( "glVertex4hvNV" );
			Normal3hNV = GetProcAdress< Normal3hNVDelegate >( "glNormal3hNV" );
			Normal3hvNV = GetProcAdress< Normal3hvNVDelegate >( "glNormal3hvNV" );
			Color3hNV = GetProcAdress< Color3hNVDelegate >( "glColor3hNV" );
			Color3hvNV = GetProcAdress< Color3hvNVDelegate >( "glColor3hvNV" );
			Color4hNV = GetProcAdress< Color4hNVDelegate >( "glColor4hNV" );
			Color4hvNV = GetProcAdress< Color4hvNVDelegate >( "glColor4hvNV" );
			TexCoord1hNV = GetProcAdress< TexCoord1hNVDelegate >( "glTexCoord1hNV" );
			TexCoord1hvNV = GetProcAdress< TexCoord1hvNVDelegate >( "glTexCoord1hvNV" );
			TexCoord2hNV = GetProcAdress< TexCoord2hNVDelegate >( "glTexCoord2hNV" );
			TexCoord2hvNV = GetProcAdress< TexCoord2hvNVDelegate >( "glTexCoord2hvNV" );
			TexCoord3hNV = GetProcAdress< TexCoord3hNVDelegate >( "glTexCoord3hNV" );
			TexCoord3hvNV = GetProcAdress< TexCoord3hvNVDelegate >( "glTexCoord3hvNV" );
			TexCoord4hNV = GetProcAdress< TexCoord4hNVDelegate >( "glTexCoord4hNV" );
			TexCoord4hvNV = GetProcAdress< TexCoord4hvNVDelegate >( "glTexCoord4hvNV" );
			MultiTexCoord1hNV = GetProcAdress< MultiTexCoord1hNVDelegate >( "glMultiTexCoord1hNV" );
			MultiTexCoord1hvNV = GetProcAdress< MultiTexCoord1hvNVDelegate >( "glMultiTexCoord1hvNV" );
			MultiTexCoord2hNV = GetProcAdress< MultiTexCoord2hNVDelegate >( "glMultiTexCoord2hNV" );
			MultiTexCoord2hvNV = GetProcAdress< MultiTexCoord2hvNVDelegate >( "glMultiTexCoord2hvNV" );
			MultiTexCoord3hNV = GetProcAdress< MultiTexCoord3hNVDelegate >( "glMultiTexCoord3hNV" );
			MultiTexCoord3hvNV = GetProcAdress< MultiTexCoord3hvNVDelegate >( "glMultiTexCoord3hvNV" );
			MultiTexCoord4hNV = GetProcAdress< MultiTexCoord4hNVDelegate >( "glMultiTexCoord4hNV" );
			MultiTexCoord4hvNV = GetProcAdress< MultiTexCoord4hvNVDelegate >( "glMultiTexCoord4hvNV" );
			FogCoordhNV = GetProcAdress< FogCoordhNVDelegate >( "glFogCoordhNV" );
			FogCoordhvNV = GetProcAdress< FogCoordhvNVDelegate >( "glFogCoordhvNV" );
			SecondaryColor3hNV = GetProcAdress< SecondaryColor3hNVDelegate >( "glSecondaryColor3hNV" );
			SecondaryColor3hvNV = GetProcAdress< SecondaryColor3hvNVDelegate >( "glSecondaryColor3hvNV" );
			VertexWeighthNV = GetProcAdress< VertexWeighthNVDelegate >( "glVertexWeighthNV" );
			VertexWeighthvNV = GetProcAdress< VertexWeighthvNVDelegate >( "glVertexWeighthvNV" );
			VertexAttrib1hNV = GetProcAdress< VertexAttrib1hNVDelegate >( "glVertexAttrib1hNV" );
			VertexAttrib1hvNV = GetProcAdress< VertexAttrib1hvNVDelegate >( "glVertexAttrib1hvNV" );
			VertexAttrib2hNV = GetProcAdress< VertexAttrib2hNVDelegate >( "glVertexAttrib2hNV" );
			VertexAttrib2hvNV = GetProcAdress< VertexAttrib2hvNVDelegate >( "glVertexAttrib2hvNV" );
			VertexAttrib3hNV = GetProcAdress< VertexAttrib3hNVDelegate >( "glVertexAttrib3hNV" );
			VertexAttrib3hvNV = GetProcAdress< VertexAttrib3hvNVDelegate >( "glVertexAttrib3hvNV" );
			VertexAttrib4hNV = GetProcAdress< VertexAttrib4hNVDelegate >( "glVertexAttrib4hNV" );
			VertexAttrib4hvNV = GetProcAdress< VertexAttrib4hvNVDelegate >( "glVertexAttrib4hvNV" );
			VertexAttribs1hvNV = GetProcAdress< VertexAttribs1hvNVDelegate >( "glVertexAttribs1hvNV" );
			VertexAttribs2hvNV = GetProcAdress< VertexAttribs2hvNVDelegate >( "glVertexAttribs2hvNV" );
			VertexAttribs3hvNV = GetProcAdress< VertexAttribs3hvNVDelegate >( "glVertexAttribs3hvNV" );
			VertexAttribs4hvNV = GetProcAdress< VertexAttribs4hvNVDelegate >( "glVertexAttribs4hvNV" );
			PixelDataRangeNV = GetProcAdress< PixelDataRangeNVDelegate >( "glPixelDataRangeNV" );
			FlushPixelDataRangeNV = GetProcAdress< FlushPixelDataRangeNVDelegate >( "glFlushPixelDataRangeNV" );
			PrimitiveRestartNV = GetProcAdress< PrimitiveRestartNVDelegate >( "glPrimitiveRestartNV" );
			PrimitiveRestartIndexNV = GetProcAdress< PrimitiveRestartIndexNVDelegate >( "glPrimitiveRestartIndexNV" );
			MapObjectBufferATI = GetProcAdress< MapObjectBufferATIDelegate >( "glMapObjectBufferATI" );
			UnmapObjectBufferATI = GetProcAdress< UnmapObjectBufferATIDelegate >( "glUnmapObjectBufferATI" );
			StencilOpSeparateATI = GetProcAdress< StencilOpSeparateATIDelegate >( "glStencilOpSeparateATI" );
			StencilFuncSeparateATI = GetProcAdress< StencilFuncSeparateATIDelegate >( "glStencilFuncSeparateATI" );
			VertexAttribArrayObjectATI = GetProcAdress< VertexAttribArrayObjectATIDelegate >( "glVertexAttribArrayObjectATI" );
			GetVertexAttribArrayObjectfvATI = GetProcAdress< GetVertexAttribArrayObjectfvATIDelegate >( "glGetVertexAttribArrayObjectfvATI" );
			GetVertexAttribArrayObjectivATI = GetProcAdress< GetVertexAttribArrayObjectivATIDelegate >( "glGetVertexAttribArrayObjectivATI" );
			DepthBoundsEXT = GetProcAdress< DepthBoundsEXTDelegate >( "glDepthBoundsEXT" );
			BlendEquationSeparateEXT = GetProcAdress< BlendEquationSeparateEXTDelegate >( "glBlendEquationSeparateEXT" );
			IsRenderbufferEXT = GetProcAdress< IsRenderbufferEXTDelegate >( "glIsRenderbufferEXT" );
			BindRenderbufferEXT = GetProcAdress< BindRenderbufferEXTDelegate >( "glBindRenderbufferEXT" );
			DeleteRenderbuffersEXT = GetProcAdress< DeleteRenderbuffersEXTDelegate >( "glDeleteRenderbuffersEXT" );
			GenRenderbuffersEXT = GetProcAdress< GenRenderbuffersEXTDelegate >( "glGenRenderbuffersEXT" );
			RenderbufferStorageEXT = GetProcAdress< RenderbufferStorageEXTDelegate >( "glRenderbufferStorageEXT" );
			GetRenderbufferParameterivEXT = GetProcAdress< GetRenderbufferParameterivEXTDelegate >( "glGetRenderbufferParameterivEXT" );
			IsFramebufferEXT = GetProcAdress< IsFramebufferEXTDelegate >( "glIsFramebufferEXT" );
			BindFramebufferEXT = GetProcAdress< BindFramebufferEXTDelegate >( "glBindFramebufferEXT" );
			DeleteFramebuffersEXT = GetProcAdress< DeleteFramebuffersEXTDelegate >( "glDeleteFramebuffersEXT" );
			GenFramebuffersEXT = GetProcAdress< GenFramebuffersEXTDelegate >( "glGenFramebuffersEXT" );
			CheckFramebufferStatusEXT = GetProcAdress< CheckFramebufferStatusEXTDelegate >( "glCheckFramebufferStatusEXT" );
			FramebufferTexture1DEXT = GetProcAdress< FramebufferTexture1DEXTDelegate >( "glFramebufferTexture1DEXT" );
			FramebufferTexture2DEXT = GetProcAdress< FramebufferTexture2DEXTDelegate >( "glFramebufferTexture2DEXT" );
			FramebufferTexture3DEXT = GetProcAdress< FramebufferTexture3DEXTDelegate >( "glFramebufferTexture3DEXT" );
			FramebufferRenderbufferEXT = GetProcAdress< FramebufferRenderbufferEXTDelegate >( "glFramebufferRenderbufferEXT" );
			GetFramebufferAttachmentParameterivEXT = GetProcAdress< GetFramebufferAttachmentParameterivEXTDelegate >( "glGetFramebufferAttachmentParameterivEXT" );
			GenerateMipmapEXT = GetProcAdress< GenerateMipmapEXTDelegate >( "glGenerateMipmapEXT" );
			StringMarkerGREMEDY = GetProcAdress< StringMarkerGREMEDYDelegate >( "glStringMarkerGREMEDY" );
			StencilClearTagEXT = GetProcAdress< StencilClearTagEXTDelegate >( "glStencilClearTagEXT" );
			BlitFramebufferEXT = GetProcAdress< BlitFramebufferEXTDelegate >( "glBlitFramebufferEXT" );
			RenderbufferStorageMultisampleEXT = GetProcAdress< RenderbufferStorageMultisampleEXTDelegate >( "glRenderbufferStorageMultisampleEXT" );
			GetQueryObjecti64vEXT = GetProcAdress< GetQueryObjecti64vEXTDelegate >( "glGetQueryObjecti64vEXT" );
			GetQueryObjectui64vEXT = GetProcAdress< GetQueryObjectui64vEXTDelegate >( "glGetQueryObjectui64vEXT" );
			ProgramEnvParameters4fvEXT = GetProcAdress< ProgramEnvParameters4fvEXTDelegate >( "glProgramEnvParameters4fvEXT" );
			ProgramLocalParameters4fvEXT = GetProcAdress< ProgramLocalParameters4fvEXTDelegate >( "glProgramLocalParameters4fvEXT" );
			BufferParameteriAPPLE = GetProcAdress< BufferParameteriAPPLEDelegate >( "glBufferParameteriAPPLE" );
			FlushMappedBufferRangeAPPLE = GetProcAdress< FlushMappedBufferRangeAPPLEDelegate >( "glFlushMappedBufferRangeAPPLE" );
			ProgramLocalParameterI4iNV = GetProcAdress< ProgramLocalParameterI4iNVDelegate >( "glProgramLocalParameterI4iNV" );
			ProgramLocalParameterI4ivNV = GetProcAdress< ProgramLocalParameterI4ivNVDelegate >( "glProgramLocalParameterI4ivNV" );
			ProgramLocalParametersI4ivNV = GetProcAdress< ProgramLocalParametersI4ivNVDelegate >( "glProgramLocalParametersI4ivNV" );
			ProgramLocalParameterI4uiNV = GetProcAdress< ProgramLocalParameterI4uiNVDelegate >( "glProgramLocalParameterI4uiNV" );
			ProgramLocalParameterI4uivNV = GetProcAdress< ProgramLocalParameterI4uivNVDelegate >( "glProgramLocalParameterI4uivNV" );
			ProgramLocalParametersI4uivNV = GetProcAdress< ProgramLocalParametersI4uivNVDelegate >( "glProgramLocalParametersI4uivNV" );
			ProgramEnvParameterI4iNV = GetProcAdress< ProgramEnvParameterI4iNVDelegate >( "glProgramEnvParameterI4iNV" );
			ProgramEnvParameterI4ivNV = GetProcAdress< ProgramEnvParameterI4ivNVDelegate >( "glProgramEnvParameterI4ivNV" );
			ProgramEnvParametersI4ivNV = GetProcAdress< ProgramEnvParametersI4ivNVDelegate >( "glProgramEnvParametersI4ivNV" );
			ProgramEnvParameterI4uiNV = GetProcAdress< ProgramEnvParameterI4uiNVDelegate >( "glProgramEnvParameterI4uiNV" );
			ProgramEnvParameterI4uivNV = GetProcAdress< ProgramEnvParameterI4uivNVDelegate >( "glProgramEnvParameterI4uivNV" );
			ProgramEnvParametersI4uivNV = GetProcAdress< ProgramEnvParametersI4uivNVDelegate >( "glProgramEnvParametersI4uivNV" );
			GetProgramLocalParameterIivNV = GetProcAdress< GetProgramLocalParameterIivNVDelegate >( "glGetProgramLocalParameterIivNV" );
			GetProgramLocalParameterIuivNV = GetProcAdress< GetProgramLocalParameterIuivNVDelegate >( "glGetProgramLocalParameterIuivNV" );
			GetProgramEnvParameterIivNV = GetProcAdress< GetProgramEnvParameterIivNVDelegate >( "glGetProgramEnvParameterIivNV" );
			GetProgramEnvParameterIuivNV = GetProcAdress< GetProgramEnvParameterIuivNVDelegate >( "glGetProgramEnvParameterIuivNV" );
			ProgramVertexLimitNV = GetProcAdress< ProgramVertexLimitNVDelegate >( "glProgramVertexLimitNV" );
			FramebufferTextureEXT = GetProcAdress< FramebufferTextureEXTDelegate >( "glFramebufferTextureEXT" );
			FramebufferTextureLayerEXT = GetProcAdress< FramebufferTextureLayerEXTDelegate >( "glFramebufferTextureLayerEXT" );
			FramebufferTextureFaceEXT = GetProcAdress< FramebufferTextureFaceEXTDelegate >( "glFramebufferTextureFaceEXT" );
			ProgramParameteriEXT = GetProcAdress< ProgramParameteriEXTDelegate >( "glProgramParameteriEXT" );
			VertexAttribI1iEXT = GetProcAdress< VertexAttribI1iEXTDelegate >( "glVertexAttribI1iEXT" );
			VertexAttribI2iEXT = GetProcAdress< VertexAttribI2iEXTDelegate >( "glVertexAttribI2iEXT" );
			VertexAttribI3iEXT = GetProcAdress< VertexAttribI3iEXTDelegate >( "glVertexAttribI3iEXT" );
			VertexAttribI4iEXT = GetProcAdress< VertexAttribI4iEXTDelegate >( "glVertexAttribI4iEXT" );
			VertexAttribI1uiEXT = GetProcAdress< VertexAttribI1uiEXTDelegate >( "glVertexAttribI1uiEXT" );
			VertexAttribI2uiEXT = GetProcAdress< VertexAttribI2uiEXTDelegate >( "glVertexAttribI2uiEXT" );
			VertexAttribI3uiEXT = GetProcAdress< VertexAttribI3uiEXTDelegate >( "glVertexAttribI3uiEXT" );
			VertexAttribI4uiEXT = GetProcAdress< VertexAttribI4uiEXTDelegate >( "glVertexAttribI4uiEXT" );
			VertexAttribI1ivEXT = GetProcAdress< VertexAttribI1ivEXTDelegate >( "glVertexAttribI1ivEXT" );
			VertexAttribI2ivEXT = GetProcAdress< VertexAttribI2ivEXTDelegate >( "glVertexAttribI2ivEXT" );
			VertexAttribI3ivEXT = GetProcAdress< VertexAttribI3ivEXTDelegate >( "glVertexAttribI3ivEXT" );
			VertexAttribI4ivEXT = GetProcAdress< VertexAttribI4ivEXTDelegate >( "glVertexAttribI4ivEXT" );
			VertexAttribI1uivEXT = GetProcAdress< VertexAttribI1uivEXTDelegate >( "glVertexAttribI1uivEXT" );
			VertexAttribI2uivEXT = GetProcAdress< VertexAttribI2uivEXTDelegate >( "glVertexAttribI2uivEXT" );
			VertexAttribI3uivEXT = GetProcAdress< VertexAttribI3uivEXTDelegate >( "glVertexAttribI3uivEXT" );
			VertexAttribI4uivEXT = GetProcAdress< VertexAttribI4uivEXTDelegate >( "glVertexAttribI4uivEXT" );
			VertexAttribI4bvEXT = GetProcAdress< VertexAttribI4bvEXTDelegate >( "glVertexAttribI4bvEXT" );
			VertexAttribI4svEXT = GetProcAdress< VertexAttribI4svEXTDelegate >( "glVertexAttribI4svEXT" );
			VertexAttribI4ubvEXT = GetProcAdress< VertexAttribI4ubvEXTDelegate >( "glVertexAttribI4ubvEXT" );
			VertexAttribI4usvEXT = GetProcAdress< VertexAttribI4usvEXTDelegate >( "glVertexAttribI4usvEXT" );
			VertexAttribIPointerEXT = GetProcAdress< VertexAttribIPointerEXTDelegate >( "glVertexAttribIPointerEXT" );
			GetVertexAttribIivEXT = GetProcAdress< GetVertexAttribIivEXTDelegate >( "glGetVertexAttribIivEXT" );
			GetVertexAttribIuivEXT = GetProcAdress< GetVertexAttribIuivEXTDelegate >( "glGetVertexAttribIuivEXT" );
			GetUniformuivEXT = GetProcAdress< GetUniformuivEXTDelegate >( "glGetUniformuivEXT" );
			BindFragDataLocationEXT = GetProcAdress< BindFragDataLocationEXTDelegate >( "glBindFragDataLocationEXT" );
			GetFragDataLocationEXT = GetProcAdress< GetFragDataLocationEXTDelegate >( "glGetFragDataLocationEXT" );
			Uniform1uiEXT = GetProcAdress< Uniform1uiEXTDelegate >( "glUniform1uiEXT" );
			Uniform2uiEXT = GetProcAdress< Uniform2uiEXTDelegate >( "glUniform2uiEXT" );
			Uniform3uiEXT = GetProcAdress< Uniform3uiEXTDelegate >( "glUniform3uiEXT" );
			Uniform4uiEXT = GetProcAdress< Uniform4uiEXTDelegate >( "glUniform4uiEXT" );
			Uniform1uivEXT = GetProcAdress< Uniform1uivEXTDelegate >( "glUniform1uivEXT" );
			Uniform2uivEXT = GetProcAdress< Uniform2uivEXTDelegate >( "glUniform2uivEXT" );
			Uniform3uivEXT = GetProcAdress< Uniform3uivEXTDelegate >( "glUniform3uivEXT" );
			Uniform4uivEXT = GetProcAdress< Uniform4uivEXTDelegate >( "glUniform4uivEXT" );
			DrawArraysInstancedEXT = GetProcAdress< DrawArraysInstancedEXTDelegate >( "glDrawArraysInstancedEXT" );
			DrawElementsInstancedEXT = GetProcAdress< DrawElementsInstancedEXTDelegate >( "glDrawElementsInstancedEXT" );
			TexBufferEXT = GetProcAdress< TexBufferEXTDelegate >( "glTexBufferEXT" );
			DepthRangedNV = GetProcAdress< DepthRangedNVDelegate >( "glDepthRangedNV" );
			ClearDepthdNV = GetProcAdress< ClearDepthdNVDelegate >( "glClearDepthdNV" );
			DepthBoundsdNV = GetProcAdress< DepthBoundsdNVDelegate >( "glDepthBoundsdNV" );
			RenderbufferStorageMultisampleCoverageNV = GetProcAdress< RenderbufferStorageMultisampleCoverageNVDelegate >( "glRenderbufferStorageMultisampleCoverageNV" );
			ProgramBufferParametersfvNV = GetProcAdress< ProgramBufferParametersfvNVDelegate >( "glProgramBufferParametersfvNV" );
			ProgramBufferParametersIivNV = GetProcAdress< ProgramBufferParametersIivNVDelegate >( "glProgramBufferParametersIivNV" );
			ProgramBufferParametersIuivNV = GetProcAdress< ProgramBufferParametersIuivNVDelegate >( "glProgramBufferParametersIuivNV" );
			ColorMaskIndexedEXT = GetProcAdress< ColorMaskIndexedEXTDelegate >( "glColorMaskIndexedEXT" );
			GetBooleanIndexedvEXT = GetProcAdress< GetBooleanIndexedvEXTDelegate >( "glGetBooleanIndexedvEXT" );
			GetIntegerIndexedvEXT = GetProcAdress< GetIntegerIndexedvEXTDelegate >( "glGetIntegerIndexedvEXT" );
			EnableIndexedEXT = GetProcAdress< EnableIndexedEXTDelegate >( "glEnableIndexedEXT" );
			DisableIndexedEXT = GetProcAdress< DisableIndexedEXTDelegate >( "glDisableIndexedEXT" );
			IsEnabledIndexedEXT = GetProcAdress< IsEnabledIndexedEXTDelegate >( "glIsEnabledIndexedEXT" );
			BeginTransformFeedbackNV = GetProcAdress< BeginTransformFeedbackNVDelegate >( "glBeginTransformFeedbackNV" );
			EndTransformFeedbackNV = GetProcAdress< EndTransformFeedbackNVDelegate >( "glEndTransformFeedbackNV" );
			TransformFeedbackAttribsNV = GetProcAdress< TransformFeedbackAttribsNVDelegate >( "glTransformFeedbackAttribsNV" );
			BindBufferRangeNV = GetProcAdress< BindBufferRangeNVDelegate >( "glBindBufferRangeNV" );
			BindBufferOffsetNV = GetProcAdress< BindBufferOffsetNVDelegate >( "glBindBufferOffsetNV" );
			BindBufferBaseNV = GetProcAdress< BindBufferBaseNVDelegate >( "glBindBufferBaseNV" );
			TransformFeedbackVaryingsNV = GetProcAdress< TransformFeedbackVaryingsNVDelegate >( "glTransformFeedbackVaryingsNV" );
			ActiveVaryingNV = GetProcAdress< ActiveVaryingNVDelegate >( "glActiveVaryingNV" );
			GetVaryingLocationNV = GetProcAdress< GetVaryingLocationNVDelegate >( "glGetVaryingLocationNV" );
			GetActiveVaryingNV = GetProcAdress< GetActiveVaryingNVDelegate >( "glGetActiveVaryingNV" );
			GetTransformFeedbackVaryingNV = GetProcAdress< GetTransformFeedbackVaryingNVDelegate >( "glGetTransformFeedbackVaryingNV" );
			UniformBufferEXT = GetProcAdress< UniformBufferEXTDelegate >( "glUniformBufferEXT" );
			GetUniformBufferSizeEXT = GetProcAdress< GetUniformBufferSizeEXTDelegate >( "glGetUniformBufferSizeEXT" );
			GetUniformOffsetEXT = GetProcAdress< GetUniformOffsetEXTDelegate >( "glGetUniformOffsetEXT" );
			TexParameterIivEXT = GetProcAdress< TexParameterIivEXTDelegate >( "glTexParameterIivEXT" );
			TexParameterIuivEXT = GetProcAdress< TexParameterIuivEXTDelegate >( "glTexParameterIuivEXT" );
			GetTexParameterIivEXT = GetProcAdress< GetTexParameterIivEXTDelegate >( "glGetTexParameterIivEXT" );
			GetTexParameterIuivEXT = GetProcAdress< GetTexParameterIuivEXTDelegate >( "glGetTexParameterIuivEXT" );
			ClearColorIiEXT = GetProcAdress< ClearColorIiEXTDelegate >( "glClearColorIiEXT" );
			ClearColorIuiEXT = GetProcAdress< ClearColorIuiEXTDelegate >( "glClearColorIuiEXT" );
			FrameTerminatorGREMEDY = GetProcAdress< FrameTerminatorGREMEDYDelegate >( "glFrameTerminatorGREMEDY" );
			
		}

		public static T GetProcAdress<T>( string functionName )
			where T : class
		{
			var ptr = WindowsOpenGLNative.wglGetProcAddress( functionName );
			if (ptr == IntPtr.Zero) return null;
			return Marshal.GetDelegateForFunctionPointer( ptr, typeof(T) ) as T;
		}
	
		[DllImport( "opengl32.dll", EntryPoint="glNewList" )]
		public static extern void NewList( uint list, ListMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEndList" )]
		public static extern void EndList(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCallList" )]
		public static extern void CallList( uint list ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCallLists" )]
		public static extern unsafe void CallLists( int n, ListNameType type, void* lists ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDeleteLists" )]
		public static extern void DeleteLists( uint list, int range ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGenLists" )]
		public static extern uint GenLists( int range ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glListBase" )]
		public static extern void ListBase( uint @base ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBegin" )]
		public static extern void Begin( BeginMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBitmap" )]
		public static extern void Bitmap( int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3b" )]
		public static extern void Color3b( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3bv" )]
		public static extern void Color3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3d" )]
		public static extern void Color3d( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3dv" )]
		public static extern void Color3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3f" )]
		public static extern void Color3f( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fv" )]
		public static extern void Color3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3i" )]
		public static extern void Color3i( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3iv" )]
		public static extern void Color3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3s" )]
		public static extern void Color3s( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3sv" )]
		public static extern void Color3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ub" )]
		public static extern void Color3ub( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ubv" )]
		public static extern void Color3ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3ui" )]
		public static extern void Color3ui( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3uiv" )]
		public static extern void Color3uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3us" )]
		public static extern void Color3us( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3usv" )]
		public static extern void Color3usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4b" )]
		public static extern void Color4b( sbyte red, sbyte green, sbyte blue, sbyte alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4bv" )]
		public static extern void Color4bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4d" )]
		public static extern void Color4d( double red, double green, double blue, double alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4dv" )]
		public static extern void Color4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4f" )]
		public static extern void Color4f( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fv" )]
		public static extern void Color4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4i" )]
		public static extern void Color4i( int red, int green, int blue, int alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4iv" )]
		public static extern void Color4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4s" )]
		public static extern void Color4s( short red, short green, short blue, short alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4sv" )]
		public static extern void Color4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ub" )]
		public static extern void Color4ub( byte red, byte green, byte blue, byte alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubv" )]
		public static extern void Color4ubv( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ui" )]
		public static extern void Color4ui( uint red, uint green, uint blue, uint alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4uiv" )]
		public static extern void Color4uiv( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4us" )]
		public static extern void Color4us( ushort red, ushort green, ushort blue, ushort alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4usv" )]
		public static extern void Color4usv( ushort[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlag" )]
		public static extern void EdgeFlag( bool flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagv" )]
		public static extern void EdgeFlagv( bool[] flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEnd" )]
		public static extern void End(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexd" )]
		public static extern void Indexd( double c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexdv" )]
		public static extern void Indexdv( double[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexf" )]
		public static extern void Indexf( float c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexfv" )]
		public static extern void Indexfv( float[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexi" )]
		public static extern void Indexi( int c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexiv" )]
		public static extern void Indexiv( int[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexs" )]
		public static extern void Indexs( short c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexsv" )]
		public static extern void Indexsv( short[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3b" )]
		public static extern void Normal3b( sbyte nx, sbyte ny, sbyte nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3bv" )]
		public static extern void Normal3bv( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3d" )]
		public static extern void Normal3d( double nx, double ny, double nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3dv" )]
		public static extern void Normal3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3f" )]
		public static extern void Normal3f( float nx, float ny, float nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fv" )]
		public static extern void Normal3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3i" )]
		public static extern void Normal3i( int nx, int ny, int nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3iv" )]
		public static extern void Normal3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3s" )]
		public static extern void Normal3s( short nx, short ny, short nz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3sv" )]
		public static extern void Normal3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2d" )]
		public static extern void RasterPos2d( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2dv" )]
		public static extern void RasterPos2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2f" )]
		public static extern void RasterPos2f( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2fv" )]
		public static extern void RasterPos2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2i" )]
		public static extern void RasterPos2i( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2iv" )]
		public static extern void RasterPos2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2s" )]
		public static extern void RasterPos2s( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos2sv" )]
		public static extern void RasterPos2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3d" )]
		public static extern void RasterPos3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3dv" )]
		public static extern void RasterPos3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3f" )]
		public static extern void RasterPos3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3fv" )]
		public static extern void RasterPos3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3i" )]
		public static extern void RasterPos3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3iv" )]
		public static extern void RasterPos3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3s" )]
		public static extern void RasterPos3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos3sv" )]
		public static extern void RasterPos3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4d" )]
		public static extern void RasterPos4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4dv" )]
		public static extern void RasterPos4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4f" )]
		public static extern void RasterPos4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4fv" )]
		public static extern void RasterPos4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4i" )]
		public static extern void RasterPos4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4iv" )]
		public static extern void RasterPos4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4s" )]
		public static extern void RasterPos4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRasterPos4sv" )]
		public static extern void RasterPos4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectd" )]
		public static extern void Rectd( double x1, double y1, double x2, double y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectdv" )]
		public static extern void Rectdv( double[] v1, double[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectf" )]
		public static extern void Rectf( float x1, float y1, float x2, float y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectfv" )]
		public static extern void Rectfv( float[] v1, float[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRecti" )]
		public static extern void Recti( int x1, int y1, int x2, int y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectiv" )]
		public static extern void Rectiv( int[] v1, int[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRects" )]
		public static extern void Rects( short x1, short y1, short x2, short y2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRectsv" )]
		public static extern void Rectsv( short[] v1, short[] v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1d" )]
		public static extern void TexCoord1d( double s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1dv" )]
		public static extern void TexCoord1dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1f" )]
		public static extern void TexCoord1f( float s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1fv" )]
		public static extern void TexCoord1fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1i" )]
		public static extern void TexCoord1i( int s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1iv" )]
		public static extern void TexCoord1iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1s" )]
		public static extern void TexCoord1s( short s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord1sv" )]
		public static extern void TexCoord1sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2d" )]
		public static extern void TexCoord2d( double s, double t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2dv" )]
		public static extern void TexCoord2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2f" )]
		public static extern void TexCoord2f( float s, float t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fv" )]
		public static extern void TexCoord2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2i" )]
		public static extern void TexCoord2i( int s, int t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2iv" )]
		public static extern void TexCoord2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2s" )]
		public static extern void TexCoord2s( short s, short t ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2sv" )]
		public static extern void TexCoord2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3d" )]
		public static extern void TexCoord3d( double s, double t, double r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3dv" )]
		public static extern void TexCoord3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3f" )]
		public static extern void TexCoord3f( float s, float t, float r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3fv" )]
		public static extern void TexCoord3fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3i" )]
		public static extern void TexCoord3i( int s, int t, int r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3iv" )]
		public static extern void TexCoord3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3s" )]
		public static extern void TexCoord3s( short s, short t, short r ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord3sv" )]
		public static extern void TexCoord3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4d" )]
		public static extern void TexCoord4d( double s, double t, double r, double q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4dv" )]
		public static extern void TexCoord4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4f" )]
		public static extern void TexCoord4f( float s, float t, float r, float q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fv" )]
		public static extern void TexCoord4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4i" )]
		public static extern void TexCoord4i( int s, int t, int r, int q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4iv" )]
		public static extern void TexCoord4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4s" )]
		public static extern void TexCoord4s( short s, short t, short r, short q ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4sv" )]
		public static extern void TexCoord4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2d" )]
		public static extern void Vertex2d( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2dv" )]
		public static extern void Vertex2dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2f" )]
		public static extern void Vertex2f( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2fv" )]
		public static extern void Vertex2fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2i" )]
		public static extern void Vertex2i( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2iv" )]
		public static extern void Vertex2iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2s" )]
		public static extern void Vertex2s( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex2sv" )]
		public static extern void Vertex2sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3d" )]
		public static extern void Vertex3d( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3dv" )]
		public static extern void Vertex3dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3f" )]
		public static extern void Vertex3f( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3fv" )]
		public static extern unsafe void Vertex3fv( float* v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3i" )]
		public static extern void Vertex3i( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3iv" )]
		public static extern void Vertex3iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3s" )]
		public static extern void Vertex3s( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex3sv" )]
		public static extern void Vertex3sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4d" )]
		public static extern void Vertex4d( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4dv" )]
		public static extern void Vertex4dv( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4f" )]
		public static extern void Vertex4f( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4fv" )]
		public static extern void Vertex4fv( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4i" )]
		public static extern void Vertex4i( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4iv" )]
		public static extern void Vertex4iv( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4s" )]
		public static extern void Vertex4s( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertex4sv" )]
		public static extern void Vertex4sv( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClipPlane" )]
		public static extern void ClipPlane( ClipPlaneName plane, double[] equation ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorMaterial" )]
		public static extern void ColorMaterial( MaterialFace face, ColorMaterialParameter mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCullFace" )]
		public static extern void CullFace( CullFaceMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogf" )]
		public static extern void Fogf( FogParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogfv" )]
		public static extern void Fogfv( FogParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogi" )]
		public static extern void Fogi( FogParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogiv" )]
		public static extern void Fogiv( FogParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFrontFace" )]
		public static extern void FrontFace( FrontFaceDirection mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glHint" )]
		public static extern void Hint( HintTarget target, HintMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightf" )]
		public static extern void Lightf( LightName light, LightParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightfv" )]
		public static extern void Lightfv( LightName light, LightParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLighti" )]
		public static extern void Lighti( LightName light, LightParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightiv" )]
		public static extern void Lightiv( LightName light, LightParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightModelf" )]
		public static extern void LightModelf( LightModelParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightModelfv" )]
		public static extern void LightModelfv( LightModelParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightModeli" )]
		public static extern void LightModeli( LightModelParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLightModeliv" )]
		public static extern void LightModeliv( LightModelParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLineStipple" )]
		public static extern void LineStipple( int factor, ushort pattern ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLineWidth" )]
		public static extern void LineWidth( float width ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMaterialf" )]
		public static extern void Materialf( MaterialFace face, MaterialParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMaterialfv" )]
		public static extern void Materialfv( MaterialFace face, MaterialParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMateriali" )]
		public static extern void Materiali( MaterialFace face, MaterialParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMaterialiv" )]
		public static extern void Materialiv( MaterialFace face, MaterialParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPointSize" )]
		public static extern void PointSize( float size ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPolygonMode" )]
		public static extern void PolygonMode( MaterialFace face, PolygonMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPolygonStipple" )]
		public static extern void PolygonStipple( byte[] mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glScissor" )]
		public static extern void Scissor( int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glShadeModel" )]
		public static extern void ShadeModel( ShadingModel mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexParameterf" )]
		public static extern void TexParameterf( TextureTarget target, TextureParameterName pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexParameterfv" )]
		public static extern void TexParameterfv( TextureTarget target, TextureParameterName pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexParameteri" )]
		public static extern void TexParameteri( TextureTarget target, TextureParameterName pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexParameteriv" )]
		public static extern void TexParameteriv( TextureTarget target, TextureParameterName pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexImage1D" )]
		public static extern unsafe void TexImage1D( TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexImage2D" )]
		public static extern unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvf" )]
		public static extern void TexEnvf( TextureEnvTarget target, TextureEnvParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvfv" )]
		public static extern void TexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexEnvi" )]
		public static extern void TexEnvi( TextureEnvTarget target, TextureEnvParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexEnviv" )]
		public static extern void TexEnviv( TextureEnvTarget target, TextureEnvParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGend" )]
		public static extern void TexGend( TextureCoordName coord, TextureGenParameter pname, double param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGendv" )]
		public static extern void TexGendv( TextureCoordName coord, TextureGenParameter pname, double[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGenf" )]
		public static extern void TexGenf( TextureCoordName coord, TextureGenParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGenfv" )]
		public static extern void TexGenfv( TextureCoordName coord, TextureGenParameter pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGeni" )]
		public static extern void TexGeni( TextureCoordName coord, TextureGenParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexGeniv" )]
		public static extern void TexGeniv( TextureCoordName coord, TextureGenParameter pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFeedbackBuffer" )]
		public static extern void FeedbackBuffer( int size, FeedbackType type, ref float[] buffer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSelectBuffer" )]
		public static extern void SelectBuffer( int size, ref uint[] buffer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRenderMode" )]
		public static extern int RenderMode( RenderingMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glInitNames" )]
		public static extern void InitNames(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadName" )]
		public static extern void LoadName( uint name ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPassThrough" )]
		public static extern void PassThrough( float token ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopName" )]
		public static extern void PopName(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushName" )]
		public static extern void PushName( uint name ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawBuffer" )]
		public static extern void DrawBuffer( DrawBufferMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClear" )]
		public static extern void Clear( ClearBufferMask mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearAccum" )]
		public static extern void ClearAccum( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearIndex" )]
		public static extern void ClearIndex( float c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearColor" )]
		public static extern void ClearColor( float red, float green, float blue, float alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearStencil" )]
		public static extern void ClearStencil( int s ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glClearDepth" )]
		public static extern void ClearDepth( double depth ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilMask" )]
		public static extern void StencilMask( uint mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorMask" )]
		public static extern void ColorMask( bool red, bool green, bool blue, bool alpha ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDepthMask" )]
		public static extern void DepthMask( bool flag ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexMask" )]
		public static extern void IndexMask( uint mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glAccum" )]
		public static extern void Accum( AccumOp op, float value ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDisable" )]
		public static extern void Disable( EnableCap cap ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEnable" )]
		public static extern void Enable( EnableCap cap ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFinish" )]
		public static extern void Finish(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFlush" )]
		public static extern void Flush(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopAttrib" )]
		public static extern void PopAttrib(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushAttrib" )]
		public static extern void PushAttrib( AttribMask mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMap1d" )]
		public static extern void Map1d( MapTarget target, double u1, double u2, int stride, int order, double[] points ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMap1f" )]
		public static extern void Map1f( MapTarget target, float u1, float u2, int stride, int order, float[] points ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMap2d" )]
		public static extern void Map2d( MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMap2f" )]
		public static extern void Map2f( MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid1d" )]
		public static extern void MapGrid1d( int un, double u1, double u2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid1f" )]
		public static extern void MapGrid1f( int un, float u1, float u2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid2d" )]
		public static extern void MapGrid2d( int un, double u1, double u2, int vn, double v1, double v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMapGrid2f" )]
		public static extern void MapGrid2f( int un, float u1, float u2, int vn, float v1, float v2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1d" )]
		public static extern void EvalCoord1d( double u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1dv" )]
		public static extern void EvalCoord1dv( double[] u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1f" )]
		public static extern void EvalCoord1f( float u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord1fv" )]
		public static extern void EvalCoord1fv( float[] u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2d" )]
		public static extern void EvalCoord2d( double u, double v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2dv" )]
		public static extern void EvalCoord2dv( double[] u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2f" )]
		public static extern void EvalCoord2f( float u, float v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalCoord2fv" )]
		public static extern void EvalCoord2fv( float[] u ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalMesh1" )]
		public static extern void EvalMesh1( MeshMode1 mode, int i1, int i2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalPoint1" )]
		public static extern void EvalPoint1( int i ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalMesh2" )]
		public static extern void EvalMesh2( MeshMode2 mode, int i1, int i2, int j1, int j2 ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEvalPoint2" )]
		public static extern void EvalPoint2( int i, int j ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glAlphaFunc" )]
		public static extern void AlphaFunc( AlphaFunction func, float @ref ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBlendFunc" )]
		public static extern void BlendFunc( BlendingFactorSrc sfactor, BlendingFactorDest dfactor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLogicOp" )]
		public static extern void LogicOp( LogicOp opcode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilFunc" )]
		public static extern void StencilFunc( StencilFunction func, int @ref, uint mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilOp" )]
		public static extern void StencilOp( StencilOp fail, StencilOp zfail, StencilOp zpass ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDepthFunc" )]
		public static extern void DepthFunc( DepthFunction func ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelZoom" )]
		public static extern void PixelZoom( float xfactor, float yfactor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransferf" )]
		public static extern void PixelTransferf( PixelTransferParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransferi" )]
		public static extern void PixelTransferi( PixelTransferParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelStoref" )]
		public static extern void PixelStoref( PixelStoreParameter pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelStorei" )]
		public static extern void PixelStorei( PixelStoreParameter pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapfv" )]
		public static extern void PixelMapfv( PixelMap map, int mapsize, float[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapuiv" )]
		public static extern void PixelMapuiv( PixelMap map, int mapsize, uint[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelMapusv" )]
		public static extern void PixelMapusv( PixelMap map, int mapsize, ushort[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReadBuffer" )]
		public static extern void ReadBuffer( ReadBufferMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyPixels" )]
		public static extern void CopyPixels( int x, int y, int width, int height, PixelCopyType type ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReadPixels" )]
		public static extern unsafe void ReadPixels( int x, int y, int width, int height, PixelFormat format, PixelType type, ref void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawPixels" )]
		public static extern unsafe void DrawPixels( int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetBooleanv" )]
		public static extern void GetBooleanv( GetPName pname, ref bool[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetClipPlane" )]
		public static extern void GetClipPlane( ClipPlaneName plane, ref double[] equation ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetDoublev" )]
		public static extern void GetDoublev( GetPName pname, ref double[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetError" )]
		public static extern ErrorCode GetError(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetFloatv" )]
		public static extern void GetFloatv( GetPName pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetIntegerv" )]
		public static extern void GetIntegerv( GetPName pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetLightfv" )]
		public static extern void GetLightfv( LightName light, LightParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetLightiv" )]
		public static extern void GetLightiv( LightName light, LightParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetMapdv" )]
		public static extern void GetMapdv( MapTarget target, GetMapQuery query, ref double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetMapfv" )]
		public static extern void GetMapfv( MapTarget target, GetMapQuery query, ref float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetMapiv" )]
		public static extern void GetMapiv( MapTarget target, GetMapQuery query, ref int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetMaterialfv" )]
		public static extern void GetMaterialfv( MaterialFace face, MaterialParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetMaterialiv" )]
		public static extern void GetMaterialiv( MaterialFace face, MaterialParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapfv" )]
		public static extern void GetPixelMapfv( PixelMap map, ref float[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapuiv" )]
		public static extern void GetPixelMapuiv( PixelMap map, ref uint[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPixelMapusv" )]
		public static extern void GetPixelMapusv( PixelMap map, ref ushort[] values ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPolygonStipple" )]
		public static extern void GetPolygonStipple( ref byte[] mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetString" )]
		public static extern string GetString( StringName name ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexEnvfv" )]
		public static extern void GetTexEnvfv( TextureEnvTarget target, TextureEnvParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexEnviv" )]
		public static extern void GetTexEnviv( TextureEnvTarget target, TextureEnvParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGendv" )]
		public static extern void GetTexGendv( TextureCoordName coord, TextureGenParameter pname, ref double[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGenfv" )]
		public static extern void GetTexGenfv( TextureCoordName coord, TextureGenParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexGeniv" )]
		public static extern void GetTexGeniv( TextureCoordName coord, TextureGenParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexImage" )]
		public static extern unsafe void GetTexImage( TextureTarget target, int level, PixelFormat format, PixelType type, ref void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexParameterfv" )]
		public static extern void GetTexParameterfv( TextureTarget target, GetTextureParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexParameteriv" )]
		public static extern void GetTexParameteriv( TextureTarget target, GetTextureParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexLevelParameterfv" )]
		public static extern void GetTexLevelParameterfv( TextureTarget target, int level, GetTextureParameter pname, ref float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetTexLevelParameteriv" )]
		public static extern void GetTexLevelParameteriv( TextureTarget target, int level, GetTextureParameter pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIsEnabled" )]
		public static extern bool IsEnabled( EnableCap cap ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIsList" )]
		public static extern bool IsList( uint list ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDepthRange" )]
		public static extern void DepthRange( double near, double far ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFrustum" )]
		public static extern void Frustum( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadIdentity" )]
		public static extern void LoadIdentity(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadMatrixf" )]
		public static extern void LoadMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadMatrixd" )]
		public static extern void LoadMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMatrixMode" )]
		public static extern void MatrixMode( MatrixMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultMatrixf" )]
		public static extern void MultMatrixf( float[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultMatrixd" )]
		public static extern void MultMatrixd( double[] m ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glOrtho" )]
		public static extern void Ortho( double left, double right, double bottom, double top, double zNear, double zFar ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopMatrix" )]
		public static extern void PopMatrix(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushMatrix" )]
		public static extern void PushMatrix(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRotated" )]
		public static extern void Rotated( double angle, double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRotatef" )]
		public static extern void Rotatef( float angle, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glScaled" )]
		public static extern void Scaled( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glScalef" )]
		public static extern void Scalef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTranslated" )]
		public static extern void Translated( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTranslatef" )]
		public static extern void Translatef( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glViewport" )]
		public static extern void Viewport( int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glArrayElement" )]
		public static extern void ArrayElement( int i ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorPointer" )]
		public static extern unsafe void ColorPointer( int size, ColorPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDisableClientState" )]
		public static extern void DisableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawArrays" )]
		public static extern void DrawArrays( BeginMode mode, int first, int count ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDrawElements" )]
		public static extern unsafe void DrawElements( BeginMode mode, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagPointer" )]
		public static extern unsafe void EdgeFlagPointer( int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEnableClientState" )]
		public static extern void EnableClientState( EnableCap array ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetPointerv" )]
		public static extern unsafe void GetPointerv( GetPointervPName pname, ref void** @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexPointer" )]
		public static extern unsafe void IndexPointer( IndexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glInterleavedArrays" )]
		public static extern unsafe void InterleavedArrays( InterleavedArrayFormat format, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointer" )]
		public static extern unsafe void NormalPointer( NormalPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointer" )]
		public static extern unsafe void TexCoordPointer( int size, TexCoordPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointer" )]
		public static extern unsafe void VertexPointer( int size, VertexPointerType type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPolygonOffset" )]
		public static extern void PolygonOffset( float factor, float units ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexImage1D" )]
		public static extern void CopyTexImage1D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexImage2D" )]
		public static extern void CopyTexImage2D( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexSubImage1D" )]
		public static extern void CopyTexSubImage1D( TextureTarget target, int level, int xoffset, int x, int y, int width ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glCopyTexSubImage2D" )]
		public static extern void CopyTexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexSubImage1D" )]
		public static extern unsafe void TexSubImage1D( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexSubImage2D" )]
		public static extern unsafe void TexSubImage2D( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glAreTexturesResident" )]
		public static extern bool AreTexturesResident( int n, uint[] textures, ref bool[] residences ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBindTexture" )]
		public static extern void BindTexture( TextureTarget target, uint texture ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDeleteTextures" )]
		public static extern void DeleteTextures( int n, uint[] textures ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGenTextures" )]
		public static extern void GenTextures( int n, uint[] textures ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIsTexture" )]
		public static extern bool IsTexture( uint texture ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPrioritizeTextures" )]
		public static extern void PrioritizeTextures( int n, uint[] textures, float[] priorities ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexub" )]
		public static extern void Indexub( byte c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexubv" )]
		public static extern void Indexubv( byte[] c ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopClientAttrib" )]
		public static extern void PopClientAttrib(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushClientAttrib" )]
		public static extern void PushClientAttrib( ClientAttribMask mask ); // 	
		public delegate void BlendColorDelegate( float red, float green, float blue, float alpha ); // 
		public static readonly BlendColorDelegate BlendColor;
		public delegate void BlendEquationDelegate( uint mode ); // 
		public static readonly BlendEquationDelegate BlendEquation;
		public unsafe delegate void DrawRangeElementsDelegate( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 
		public static readonly DrawRangeElementsDelegate DrawRangeElements;
		public unsafe delegate void ColorTableDelegate( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); // 
		public static readonly ColorTableDelegate ColorTable;
		public delegate void ColorTableParameterfvDelegate( uint target, uint pname, float[] @params ); // 
		public static readonly ColorTableParameterfvDelegate ColorTableParameterfv;
		public delegate void ColorTableParameterivDelegate( uint target, uint pname, int[] @params ); // 
		public static readonly ColorTableParameterivDelegate ColorTableParameteriv;
		public delegate void CopyColorTableDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 
		public static readonly CopyColorTableDelegate CopyColorTable;
		public unsafe delegate void GetColorTableDelegate( uint target, PixelFormat format, PixelType type, ref void* table ); // 
		public static readonly GetColorTableDelegate GetColorTable;
		public delegate void GetColorTableParameterfvDelegate( uint target, uint pname, ref float[] @params ); // 
		public static readonly GetColorTableParameterfvDelegate GetColorTableParameterfv;
		public delegate void GetColorTableParameterivDelegate( uint target, uint pname, ref int[] @params ); // 
		public static readonly GetColorTableParameterivDelegate GetColorTableParameteriv;
		public unsafe delegate void ColorSubTableDelegate( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 
		public static readonly ColorSubTableDelegate ColorSubTable;
		public delegate void CopyColorSubTableDelegate( uint target, int start, int x, int y, int width ); // 
		public static readonly CopyColorSubTableDelegate CopyColorSubTable;
		public unsafe delegate void ConvolutionFilter1DDelegate( uint target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); // 
		public static readonly ConvolutionFilter1DDelegate ConvolutionFilter1D;
		public unsafe delegate void ConvolutionFilter2DDelegate( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); // 
		public static readonly ConvolutionFilter2DDelegate ConvolutionFilter2D;
		public delegate void ConvolutionParameterfDelegate( uint target, uint pname, float @params ); // 
		public static readonly ConvolutionParameterfDelegate ConvolutionParameterf;
		public delegate void ConvolutionParameterfvDelegate( uint target, uint pname, float[] @params ); // 
		public static readonly ConvolutionParameterfvDelegate ConvolutionParameterfv;
		public delegate void ConvolutionParameteriDelegate( uint target, uint pname, int @params ); // 
		public static readonly ConvolutionParameteriDelegate ConvolutionParameteri;
		public delegate void ConvolutionParameterivDelegate( uint target, uint pname, int[] @params ); // 
		public static readonly ConvolutionParameterivDelegate ConvolutionParameteriv;
		public delegate void CopyConvolutionFilter1DDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width ); // 
		public static readonly CopyConvolutionFilter1DDelegate CopyConvolutionFilter1D;
		public delegate void CopyConvolutionFilter2DDelegate( uint target, PixelInternalFormat internalformat, int x, int y, int width, int height ); // 
		public static readonly CopyConvolutionFilter2DDelegate CopyConvolutionFilter2D;
		public unsafe delegate void GetConvolutionFilterDelegate( uint target, PixelFormat format, PixelType type, ref void* image ); // 
		public static readonly GetConvolutionFilterDelegate GetConvolutionFilter;
		public delegate void GetConvolutionParameterfvDelegate( uint target, uint pname, ref float[] @params ); // 
		public static readonly GetConvolutionParameterfvDelegate GetConvolutionParameterfv;
		public delegate void GetConvolutionParameterivDelegate( uint target, uint pname, ref int[] @params ); // 
		public static readonly GetConvolutionParameterivDelegate GetConvolutionParameteriv;
		public unsafe delegate void GetSeparableFilterDelegate( uint target, PixelFormat format, PixelType type, ref void* row, ref void* column, ref void* span ); // 
		public static readonly GetSeparableFilterDelegate GetSeparableFilter;
		public unsafe delegate void SeparableFilter2DDelegate( uint target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); // 
		public static readonly SeparableFilter2DDelegate SeparableFilter2D;
		public unsafe delegate void GetHistogramDelegate( uint target, bool reset, PixelFormat format, PixelType type, ref void* values ); // 
		public static readonly GetHistogramDelegate GetHistogram;
		public delegate void GetHistogramParameterfvDelegate( uint target, uint pname, ref float[] @params ); // 
		public static readonly GetHistogramParameterfvDelegate GetHistogramParameterfv;
		public delegate void GetHistogramParameterivDelegate( uint target, uint pname, ref int[] @params ); // 
		public static readonly GetHistogramParameterivDelegate GetHistogramParameteriv;
		public unsafe delegate void GetMinmaxDelegate( uint target, bool reset, PixelFormat format, PixelType type, ref void* values ); // 
		public static readonly GetMinmaxDelegate GetMinmax;
		public delegate void GetMinmaxParameterfvDelegate( uint target, uint pname, ref float[] @params ); // 
		public static readonly GetMinmaxParameterfvDelegate GetMinmaxParameterfv;
		public delegate void GetMinmaxParameterivDelegate( uint target, uint pname, ref int[] @params ); // 
		public static readonly GetMinmaxParameterivDelegate GetMinmaxParameteriv;
		public delegate void HistogramDelegate( uint target, int width, PixelInternalFormat internalformat, bool sink ); // 
		public static readonly HistogramDelegate Histogram;
		public delegate void MinmaxDelegate( uint target, PixelInternalFormat internalformat, bool sink ); // 
		public static readonly MinmaxDelegate Minmax;
		public delegate void ResetHistogramDelegate( uint target ); // 
		public static readonly ResetHistogramDelegate ResetHistogram;
		public delegate void ResetMinmaxDelegate( uint target ); // 
		public static readonly ResetMinmaxDelegate ResetMinmax;
		public unsafe delegate void TexImage3DDelegate( TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); // 
		public static readonly TexImage3DDelegate TexImage3D;
		public unsafe delegate void TexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); // 
		public static readonly TexSubImage3DDelegate TexSubImage3D;
		public delegate void CopyTexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); // 
		public static readonly CopyTexSubImage3DDelegate CopyTexSubImage3D;
		public delegate void ActiveTextureDelegate( uint texture ); // 
		public static readonly ActiveTextureDelegate ActiveTexture;
		public delegate void ClientActiveTextureDelegate( uint texture ); // 
		public static readonly ClientActiveTextureDelegate ClientActiveTexture;
		public delegate void MultiTexCoord1dDelegate( uint target, double s ); // 
		public static readonly MultiTexCoord1dDelegate MultiTexCoord1d;
		public delegate void MultiTexCoord1dvDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord1dvDelegate MultiTexCoord1dv;
		public delegate void MultiTexCoord1fDelegate( uint target, float s ); // 
		public static readonly MultiTexCoord1fDelegate MultiTexCoord1f;
		public delegate void MultiTexCoord1fvDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord1fvDelegate MultiTexCoord1fv;
		public delegate void MultiTexCoord1iDelegate( uint target, int s ); // 
		public static readonly MultiTexCoord1iDelegate MultiTexCoord1i;
		public delegate void MultiTexCoord1ivDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord1ivDelegate MultiTexCoord1iv;
		public delegate void MultiTexCoord1sDelegate( uint target, short s ); // 
		public static readonly MultiTexCoord1sDelegate MultiTexCoord1s;
		public delegate void MultiTexCoord1svDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord1svDelegate MultiTexCoord1sv;
		public delegate void MultiTexCoord2dDelegate( uint target, double s, double t ); // 
		public static readonly MultiTexCoord2dDelegate MultiTexCoord2d;
		public delegate void MultiTexCoord2dvDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord2dvDelegate MultiTexCoord2dv;
		public delegate void MultiTexCoord2fDelegate( uint target, float s, float t ); // 
		public static readonly MultiTexCoord2fDelegate MultiTexCoord2f;
		public delegate void MultiTexCoord2fvDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord2fvDelegate MultiTexCoord2fv;
		public delegate void MultiTexCoord2iDelegate( uint target, int s, int t ); // 
		public static readonly MultiTexCoord2iDelegate MultiTexCoord2i;
		public delegate void MultiTexCoord2ivDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord2ivDelegate MultiTexCoord2iv;
		public delegate void MultiTexCoord2sDelegate( uint target, short s, short t ); // 
		public static readonly MultiTexCoord2sDelegate MultiTexCoord2s;
		public delegate void MultiTexCoord2svDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord2svDelegate MultiTexCoord2sv;
		public delegate void MultiTexCoord3dDelegate( uint target, double s, double t, double r ); // 
		public static readonly MultiTexCoord3dDelegate MultiTexCoord3d;
		public delegate void MultiTexCoord3dvDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord3dvDelegate MultiTexCoord3dv;
		public delegate void MultiTexCoord3fDelegate( uint target, float s, float t, float r ); // 
		public static readonly MultiTexCoord3fDelegate MultiTexCoord3f;
		public delegate void MultiTexCoord3fvDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord3fvDelegate MultiTexCoord3fv;
		public delegate void MultiTexCoord3iDelegate( uint target, int s, int t, int r ); // 
		public static readonly MultiTexCoord3iDelegate MultiTexCoord3i;
		public delegate void MultiTexCoord3ivDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord3ivDelegate MultiTexCoord3iv;
		public delegate void MultiTexCoord3sDelegate( uint target, short s, short t, short r ); // 
		public static readonly MultiTexCoord3sDelegate MultiTexCoord3s;
		public delegate void MultiTexCoord3svDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord3svDelegate MultiTexCoord3sv;
		public delegate void MultiTexCoord4dDelegate( uint target, double s, double t, double r, double q ); // 
		public static readonly MultiTexCoord4dDelegate MultiTexCoord4d;
		public delegate void MultiTexCoord4dvDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord4dvDelegate MultiTexCoord4dv;
		public delegate void MultiTexCoord4fDelegate( uint target, float s, float t, float r, float q ); // 
		public static readonly MultiTexCoord4fDelegate MultiTexCoord4f;
		public delegate void MultiTexCoord4fvDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord4fvDelegate MultiTexCoord4fv;
		public delegate void MultiTexCoord4iDelegate( uint target, int s, int t, int r, int q ); // 
		public static readonly MultiTexCoord4iDelegate MultiTexCoord4i;
		public delegate void MultiTexCoord4ivDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord4ivDelegate MultiTexCoord4iv;
		public delegate void MultiTexCoord4sDelegate( uint target, short s, short t, short r, short q ); // 
		public static readonly MultiTexCoord4sDelegate MultiTexCoord4s;
		public delegate void MultiTexCoord4svDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord4svDelegate MultiTexCoord4sv;
		public delegate void LoadTransposeMatrixfDelegate( float[] m ); // 
		public static readonly LoadTransposeMatrixfDelegate LoadTransposeMatrixf;
		public delegate void LoadTransposeMatrixdDelegate( double[] m ); // 
		public static readonly LoadTransposeMatrixdDelegate LoadTransposeMatrixd;
		public delegate void MultTransposeMatrixfDelegate( float[] m ); // 
		public static readonly MultTransposeMatrixfDelegate MultTransposeMatrixf;
		public delegate void MultTransposeMatrixdDelegate( double[] m ); // 
		public static readonly MultTransposeMatrixdDelegate MultTransposeMatrixd;
		public delegate void SampleCoverageDelegate( float value, bool invert ); // 
		public static readonly SampleCoverageDelegate SampleCoverage;
		public unsafe delegate void CompressedTexImage3DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage3DDelegate CompressedTexImage3D;
		public unsafe delegate void CompressedTexImage2DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage2DDelegate CompressedTexImage2D;
		public unsafe delegate void CompressedTexImage1DDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage1DDelegate CompressedTexImage1D;
		public unsafe delegate void CompressedTexSubImage3DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage3DDelegate CompressedTexSubImage3D;
		public unsafe delegate void CompressedTexSubImage2DDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage2DDelegate CompressedTexSubImage2D;
		public unsafe delegate void CompressedTexSubImage1DDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage1DDelegate CompressedTexSubImage1D;
		public unsafe delegate void GetCompressedTexImageDelegate( TextureTarget target, int level, ref void* img ); // 
		public static readonly GetCompressedTexImageDelegate GetCompressedTexImage;
		public delegate void BlendFuncSeparateDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method
		public static readonly BlendFuncSeparateDelegate BlendFuncSeparate;
		public delegate void FogCoordfDelegate( float coord ); // 
		public static readonly FogCoordfDelegate FogCoordf;
		public delegate void FogCoordfvDelegate( float[] coord ); // 
		public static readonly FogCoordfvDelegate FogCoordfv;
		public delegate void FogCoorddDelegate( double coord ); // 
		public static readonly FogCoorddDelegate FogCoordd;
		public delegate void FogCoorddvDelegate( double[] coord ); // 
		public static readonly FogCoorddvDelegate FogCoorddv;
		public unsafe delegate void FogCoordPointerDelegate( uint type, int stride, void* pointer ); // 
		public static readonly FogCoordPointerDelegate FogCoordPointer;
		public delegate void MultiDrawArraysDelegate( BeginMode mode, ref int[] first, ref int[] count, int primcount ); // 
		public static readonly MultiDrawArraysDelegate MultiDrawArrays;
		public unsafe delegate void MultiDrawElementsDelegate( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 
		public static readonly MultiDrawElementsDelegate MultiDrawElements;
		public delegate void PointParameterfDelegate( uint pname, float param ); //  extension method
		public static readonly PointParameterfDelegate PointParameterf;
		public delegate void PointParameterfvDelegate( uint pname, float[] @params ); //  extension method
		public static readonly PointParameterfvDelegate PointParameterfv;
		public delegate void PointParameteriDelegate( uint pname, int param ); //  extension method
		public static readonly PointParameteriDelegate PointParameteri;
		public delegate void PointParameterivDelegate( uint pname, int[] @params ); //  extension method
		public static readonly PointParameterivDelegate PointParameteriv;
		public delegate void SecondaryColor3bDelegate( sbyte red, sbyte green, sbyte blue ); // 
		public static readonly SecondaryColor3bDelegate SecondaryColor3b;
		public delegate void SecondaryColor3bvDelegate( sbyte[] v ); // 
		public static readonly SecondaryColor3bvDelegate SecondaryColor3bv;
		public delegate void SecondaryColor3dDelegate( double red, double green, double blue ); // 
		public static readonly SecondaryColor3dDelegate SecondaryColor3d;
		public delegate void SecondaryColor3dvDelegate( double[] v ); // 
		public static readonly SecondaryColor3dvDelegate SecondaryColor3dv;
		public delegate void SecondaryColor3fDelegate( float red, float green, float blue ); // 
		public static readonly SecondaryColor3fDelegate SecondaryColor3f;
		public delegate void SecondaryColor3fvDelegate( float[] v ); // 
		public static readonly SecondaryColor3fvDelegate SecondaryColor3fv;
		public delegate void SecondaryColor3iDelegate( int red, int green, int blue ); // 
		public static readonly SecondaryColor3iDelegate SecondaryColor3i;
		public delegate void SecondaryColor3ivDelegate( int[] v ); // 
		public static readonly SecondaryColor3ivDelegate SecondaryColor3iv;
		public delegate void SecondaryColor3sDelegate( short red, short green, short blue ); // 
		public static readonly SecondaryColor3sDelegate SecondaryColor3s;
		public delegate void SecondaryColor3svDelegate( short[] v ); // 
		public static readonly SecondaryColor3svDelegate SecondaryColor3sv;
		public delegate void SecondaryColor3ubDelegate( byte red, byte green, byte blue ); // 
		public static readonly SecondaryColor3ubDelegate SecondaryColor3ub;
		public delegate void SecondaryColor3ubvDelegate( byte[] v ); // 
		public static readonly SecondaryColor3ubvDelegate SecondaryColor3ubv;
		public delegate void SecondaryColor3uiDelegate( uint red, uint green, uint blue ); // 
		public static readonly SecondaryColor3uiDelegate SecondaryColor3ui;
		public delegate void SecondaryColor3uivDelegate( uint[] v ); // 
		public static readonly SecondaryColor3uivDelegate SecondaryColor3uiv;
		public delegate void SecondaryColor3usDelegate( ushort red, ushort green, ushort blue ); // 
		public static readonly SecondaryColor3usDelegate SecondaryColor3us;
		public delegate void SecondaryColor3usvDelegate( ushort[] v ); // 
		public static readonly SecondaryColor3usvDelegate SecondaryColor3usv;
		public unsafe delegate void SecondaryColorPointerDelegate( int size, ColorPointerType type, int stride, void* pointer ); //  extension method
		public static readonly SecondaryColorPointerDelegate SecondaryColorPointer;
		public delegate void WindowPos2dDelegate( double x, double y ); // 
		public static readonly WindowPos2dDelegate WindowPos2d;
		public delegate void WindowPos2dvDelegate( double[] v ); // 
		public static readonly WindowPos2dvDelegate WindowPos2dv;
		public delegate void WindowPos2fDelegate( float x, float y ); // 
		public static readonly WindowPos2fDelegate WindowPos2f;
		public delegate void WindowPos2fvDelegate( float[] v ); // 
		public static readonly WindowPos2fvDelegate WindowPos2fv;
		public delegate void WindowPos2iDelegate( int x, int y ); // 
		public static readonly WindowPos2iDelegate WindowPos2i;
		public delegate void WindowPos2ivDelegate( int[] v ); // 
		public static readonly WindowPos2ivDelegate WindowPos2iv;
		public delegate void WindowPos2sDelegate( short x, short y ); // 
		public static readonly WindowPos2sDelegate WindowPos2s;
		public delegate void WindowPos2svDelegate( short[] v ); // 
		public static readonly WindowPos2svDelegate WindowPos2sv;
		public delegate void WindowPos3dDelegate( double x, double y, double z ); // 
		public static readonly WindowPos3dDelegate WindowPos3d;
		public delegate void WindowPos3dvDelegate( double[] v ); // 
		public static readonly WindowPos3dvDelegate WindowPos3dv;
		public delegate void WindowPos3fDelegate( float x, float y, float z ); // 
		public static readonly WindowPos3fDelegate WindowPos3f;
		public delegate void WindowPos3fvDelegate( float[] v ); // 
		public static readonly WindowPos3fvDelegate WindowPos3fv;
		public delegate void WindowPos3iDelegate( int x, int y, int z ); // 
		public static readonly WindowPos3iDelegate WindowPos3i;
		public delegate void WindowPos3ivDelegate( int[] v ); // 
		public static readonly WindowPos3ivDelegate WindowPos3iv;
		public delegate void WindowPos3sDelegate( short x, short y, short z ); // 
		public static readonly WindowPos3sDelegate WindowPos3s;
		public delegate void WindowPos3svDelegate( short[] v ); // 
		public static readonly WindowPos3svDelegate WindowPos3sv;
		public delegate void GenQueriesDelegate( int n, ref uint[] ids ); //  extension method
		public static readonly GenQueriesDelegate GenQueries;
		public delegate void DeleteQueriesDelegate( int n, uint[] ids ); //  extension method
		public static readonly DeleteQueriesDelegate DeleteQueries;
		public delegate bool IsQueryDelegate( uint id ); //  extension method
		public static readonly IsQueryDelegate IsQuery;
		public delegate void BeginQueryDelegate( uint target, uint id ); //  extension method
		public static readonly BeginQueryDelegate BeginQuery;
		public delegate void EndQueryDelegate( uint target ); //  extension method
		public static readonly EndQueryDelegate EndQuery;
		public delegate void GetQueryivDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetQueryivDelegate GetQueryiv;
		public delegate void GetQueryObjectivDelegate( uint id, uint pname, ref int[] @params ); //  extension method
		public static readonly GetQueryObjectivDelegate GetQueryObjectiv;
		public delegate void GetQueryObjectuivDelegate( uint id, uint pname, ref uint[] @params ); //  extension method
		public static readonly GetQueryObjectuivDelegate GetQueryObjectuiv;
		public delegate void BindBufferDelegate( uint target, uint buffer ); //  extension method
		public static readonly BindBufferDelegate BindBuffer;
		public delegate void DeleteBuffersDelegate( int n, uint[] buffers ); //  extension method
		public static readonly DeleteBuffersDelegate DeleteBuffers;
		public delegate void GenBuffersDelegate( int n, ref uint[] buffers ); //  extension method
		public static readonly GenBuffersDelegate GenBuffers;
		public delegate bool IsBufferDelegate( uint buffer ); //  extension method
		public static readonly IsBufferDelegate IsBuffer;
		public unsafe delegate void BufferDataDelegate( uint target, int size, void* data, uint usage ); //  extension method
		public static readonly BufferDataDelegate BufferData;
		public unsafe delegate void BufferSubDataDelegate( uint target, int offset, int size, void* data ); //  extension method
		public static readonly BufferSubDataDelegate BufferSubData;
		public unsafe delegate void GetBufferSubDataDelegate( uint target, int offset, int size, ref void* data ); //  extension method
		public static readonly GetBufferSubDataDelegate GetBufferSubData;
		public delegate void MapBufferDelegate( uint target, uint access ); //  extension method
		public static readonly MapBufferDelegate MapBuffer;
		public delegate bool UnmapBufferDelegate( uint target ); //  extension method
		public static readonly UnmapBufferDelegate UnmapBuffer;
		public delegate void GetBufferParameterivDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetBufferParameterivDelegate GetBufferParameteriv;
		public unsafe delegate void GetBufferPointervDelegate( uint target, uint pname, ref void** @params ); //  extension method
		public static readonly GetBufferPointervDelegate GetBufferPointerv;
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
		public delegate void ActiveTextureARBDelegate( uint texture ); // 
		public static readonly ActiveTextureARBDelegate ActiveTextureARB;
		public delegate void ClientActiveTextureARBDelegate( uint texture ); // 
		public static readonly ClientActiveTextureARBDelegate ClientActiveTextureARB;
		public delegate void MultiTexCoord1dARBDelegate( uint target, double s ); // 
		public static readonly MultiTexCoord1dARBDelegate MultiTexCoord1dARB;
		public delegate void MultiTexCoord1dvARBDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord1dvARBDelegate MultiTexCoord1dvARB;
		public delegate void MultiTexCoord1fARBDelegate( uint target, float s ); // 
		public static readonly MultiTexCoord1fARBDelegate MultiTexCoord1fARB;
		public delegate void MultiTexCoord1fvARBDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord1fvARBDelegate MultiTexCoord1fvARB;
		public delegate void MultiTexCoord1iARBDelegate( uint target, int s ); // 
		public static readonly MultiTexCoord1iARBDelegate MultiTexCoord1iARB;
		public delegate void MultiTexCoord1ivARBDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord1ivARBDelegate MultiTexCoord1ivARB;
		public delegate void MultiTexCoord1sARBDelegate( uint target, short s ); // 
		public static readonly MultiTexCoord1sARBDelegate MultiTexCoord1sARB;
		public delegate void MultiTexCoord1svARBDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord1svARBDelegate MultiTexCoord1svARB;
		public delegate void MultiTexCoord2dARBDelegate( uint target, double s, double t ); // 
		public static readonly MultiTexCoord2dARBDelegate MultiTexCoord2dARB;
		public delegate void MultiTexCoord2dvARBDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord2dvARBDelegate MultiTexCoord2dvARB;
		public delegate void MultiTexCoord2fARBDelegate( uint target, float s, float t ); // 
		public static readonly MultiTexCoord2fARBDelegate MultiTexCoord2fARB;
		public delegate void MultiTexCoord2fvARBDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord2fvARBDelegate MultiTexCoord2fvARB;
		public delegate void MultiTexCoord2iARBDelegate( uint target, int s, int t ); // 
		public static readonly MultiTexCoord2iARBDelegate MultiTexCoord2iARB;
		public delegate void MultiTexCoord2ivARBDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord2ivARBDelegate MultiTexCoord2ivARB;
		public delegate void MultiTexCoord2sARBDelegate( uint target, short s, short t ); // 
		public static readonly MultiTexCoord2sARBDelegate MultiTexCoord2sARB;
		public delegate void MultiTexCoord2svARBDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord2svARBDelegate MultiTexCoord2svARB;
		public delegate void MultiTexCoord3dARBDelegate( uint target, double s, double t, double r ); // 
		public static readonly MultiTexCoord3dARBDelegate MultiTexCoord3dARB;
		public delegate void MultiTexCoord3dvARBDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord3dvARBDelegate MultiTexCoord3dvARB;
		public delegate void MultiTexCoord3fARBDelegate( uint target, float s, float t, float r ); // 
		public static readonly MultiTexCoord3fARBDelegate MultiTexCoord3fARB;
		public delegate void MultiTexCoord3fvARBDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord3fvARBDelegate MultiTexCoord3fvARB;
		public delegate void MultiTexCoord3iARBDelegate( uint target, int s, int t, int r ); // 
		public static readonly MultiTexCoord3iARBDelegate MultiTexCoord3iARB;
		public delegate void MultiTexCoord3ivARBDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord3ivARBDelegate MultiTexCoord3ivARB;
		public delegate void MultiTexCoord3sARBDelegate( uint target, short s, short t, short r ); // 
		public static readonly MultiTexCoord3sARBDelegate MultiTexCoord3sARB;
		public delegate void MultiTexCoord3svARBDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord3svARBDelegate MultiTexCoord3svARB;
		public delegate void MultiTexCoord4dARBDelegate( uint target, double s, double t, double r, double q ); // 
		public static readonly MultiTexCoord4dARBDelegate MultiTexCoord4dARB;
		public delegate void MultiTexCoord4dvARBDelegate( uint target, double[] v ); // 
		public static readonly MultiTexCoord4dvARBDelegate MultiTexCoord4dvARB;
		public delegate void MultiTexCoord4fARBDelegate( uint target, float s, float t, float r, float q ); // 
		public static readonly MultiTexCoord4fARBDelegate MultiTexCoord4fARB;
		public delegate void MultiTexCoord4fvARBDelegate( uint target, float[] v ); // 
		public static readonly MultiTexCoord4fvARBDelegate MultiTexCoord4fvARB;
		public delegate void MultiTexCoord4iARBDelegate( uint target, int s, int t, int r, int q ); // 
		public static readonly MultiTexCoord4iARBDelegate MultiTexCoord4iARB;
		public delegate void MultiTexCoord4ivARBDelegate( uint target, int[] v ); // 
		public static readonly MultiTexCoord4ivARBDelegate MultiTexCoord4ivARB;
		public delegate void MultiTexCoord4sARBDelegate( uint target, short s, short t, short r, short q ); // 
		public static readonly MultiTexCoord4sARBDelegate MultiTexCoord4sARB;
		public delegate void MultiTexCoord4svARBDelegate( uint target, short[] v ); // 
		public static readonly MultiTexCoord4svARBDelegate MultiTexCoord4svARB;
		public delegate void LoadTransposeMatrixfARBDelegate( float[] m ); // 
		public static readonly LoadTransposeMatrixfARBDelegate LoadTransposeMatrixfARB;
		public delegate void LoadTransposeMatrixdARBDelegate( double[] m ); // 
		public static readonly LoadTransposeMatrixdARBDelegate LoadTransposeMatrixdARB;
		public delegate void MultTransposeMatrixfARBDelegate( float[] m ); // 
		public static readonly MultTransposeMatrixfARBDelegate MultTransposeMatrixfARB;
		public delegate void MultTransposeMatrixdARBDelegate( double[] m ); // 
		public static readonly MultTransposeMatrixdARBDelegate MultTransposeMatrixdARB;
		public delegate void SampleCoverageARBDelegate( float value, bool invert ); // 
		public static readonly SampleCoverageARBDelegate SampleCoverageARB;
		public unsafe delegate void CompressedTexImage3DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage3DARBDelegate CompressedTexImage3DARB;
		public unsafe delegate void CompressedTexImage2DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage2DARBDelegate CompressedTexImage2DARB;
		public unsafe delegate void CompressedTexImage1DARBDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, void* data ); // 
		public static readonly CompressedTexImage1DARBDelegate CompressedTexImage1DARB;
		public unsafe delegate void CompressedTexSubImage3DARBDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage3DARBDelegate CompressedTexSubImage3DARB;
		public unsafe delegate void CompressedTexSubImage2DARBDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage2DARBDelegate CompressedTexSubImage2DARB;
		public unsafe delegate void CompressedTexSubImage1DARBDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, void* data ); // 
		public static readonly CompressedTexSubImage1DARBDelegate CompressedTexSubImage1DARB;
		public unsafe delegate void GetCompressedTexImageARBDelegate( TextureTarget target, int level, ref void* img ); // 
		public static readonly GetCompressedTexImageARBDelegate GetCompressedTexImageARB;
		public delegate void PointParameterfARBDelegate( uint pname, float param ); //  extension method
		public static readonly PointParameterfARBDelegate PointParameterfARB;
		public delegate void PointParameterfvARBDelegate( uint pname, float[] @params ); //  extension method
		public static readonly PointParameterfvARBDelegate PointParameterfvARB;
		public delegate void WeightbvARBDelegate( int size, sbyte[] weights ); //  extension method
		public static readonly WeightbvARBDelegate WeightbvARB;
		public delegate void WeightsvARBDelegate( int size, short[] weights ); //  extension method
		public static readonly WeightsvARBDelegate WeightsvARB;
		public delegate void WeightivARBDelegate( int size, int[] weights ); //  extension method
		public static readonly WeightivARBDelegate WeightivARB;
		public delegate void WeightfvARBDelegate( int size, float[] weights ); //  extension method
		public static readonly WeightfvARBDelegate WeightfvARB;
		public delegate void WeightdvARBDelegate( int size, double[] weights ); //  extension method
		public static readonly WeightdvARBDelegate WeightdvARB;
		public delegate void WeightubvARBDelegate( int size, byte[] weights ); //  extension method
		public static readonly WeightubvARBDelegate WeightubvARB;
		public delegate void WeightusvARBDelegate( int size, ushort[] weights ); //  extension method
		public static readonly WeightusvARBDelegate WeightusvARB;
		public delegate void WeightuivARBDelegate( int size, uint[] weights ); //  extension method
		public static readonly WeightuivARBDelegate WeightuivARB;
		public unsafe delegate void WeightPointerARBDelegate( int size, uint type, int stride, void* pointer ); //  extension method
		public static readonly WeightPointerARBDelegate WeightPointerARB;
		public delegate void VertexBlendARBDelegate( int count ); //  extension method
		public static readonly VertexBlendARBDelegate VertexBlendARB;
		public delegate void CurrentPaletteMatrixARBDelegate( int index ); //  extension method
		public static readonly CurrentPaletteMatrixARBDelegate CurrentPaletteMatrixARB;
		public delegate void MatrixIndexubvARBDelegate( int size, byte[] indices ); //  extension method
		public static readonly MatrixIndexubvARBDelegate MatrixIndexubvARB;
		public delegate void MatrixIndexusvARBDelegate( int size, ushort[] indices ); //  extension method
		public static readonly MatrixIndexusvARBDelegate MatrixIndexusvARB;
		public delegate void MatrixIndexuivARBDelegate( int size, uint[] indices ); //  extension method
		public static readonly MatrixIndexuivARBDelegate MatrixIndexuivARB;
		public unsafe delegate void MatrixIndexPointerARBDelegate( int size, uint type, int stride, void* pointer ); //  extension method
		public static readonly MatrixIndexPointerARBDelegate MatrixIndexPointerARB;
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dARB" )]
		public static extern void WindowPos2dARB( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dvARB" )]
		public static extern void WindowPos2dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fARB" )]
		public static extern void WindowPos2fARB( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fvARB" )]
		public static extern void WindowPos2fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2iARB" )]
		public static extern void WindowPos2iARB( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2ivARB" )]
		public static extern void WindowPos2ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2sARB" )]
		public static extern void WindowPos2sARB( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2svARB" )]
		public static extern void WindowPos2svARB( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dARB" )]
		public static extern void WindowPos3dARB( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dvARB" )]
		public static extern void WindowPos3dvARB( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fARB" )]
		public static extern void WindowPos3fARB( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fvARB" )]
		public static extern void WindowPos3fvARB( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3iARB" )]
		public static extern void WindowPos3iARB( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3ivARB" )]
		public static extern void WindowPos3ivARB( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3sARB" )]
		public static extern void WindowPos3sARB( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3svARB" )]
		public static extern void WindowPos3svARB( short[] v ); // 	
		public delegate void VertexAttrib1dARBDelegate( uint index, double x ); //  extension method
		public static readonly VertexAttrib1dARBDelegate VertexAttrib1dARB;
		public delegate void VertexAttrib1dvARBDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib1dvARBDelegate VertexAttrib1dvARB;
		public delegate void VertexAttrib1fARBDelegate( uint index, float x ); //  extension method
		public static readonly VertexAttrib1fARBDelegate VertexAttrib1fARB;
		public delegate void VertexAttrib1fvARBDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib1fvARBDelegate VertexAttrib1fvARB;
		public delegate void VertexAttrib1sARBDelegate( uint index, short x ); //  extension method
		public static readonly VertexAttrib1sARBDelegate VertexAttrib1sARB;
		public delegate void VertexAttrib1svARBDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib1svARBDelegate VertexAttrib1svARB;
		public delegate void VertexAttrib2dARBDelegate( uint index, double x, double y ); //  extension method
		public static readonly VertexAttrib2dARBDelegate VertexAttrib2dARB;
		public delegate void VertexAttrib2dvARBDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib2dvARBDelegate VertexAttrib2dvARB;
		public delegate void VertexAttrib2fARBDelegate( uint index, float x, float y ); //  extension method
		public static readonly VertexAttrib2fARBDelegate VertexAttrib2fARB;
		public delegate void VertexAttrib2fvARBDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib2fvARBDelegate VertexAttrib2fvARB;
		public delegate void VertexAttrib2sARBDelegate( uint index, short x, short y ); //  extension method
		public static readonly VertexAttrib2sARBDelegate VertexAttrib2sARB;
		public delegate void VertexAttrib2svARBDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib2svARBDelegate VertexAttrib2svARB;
		public delegate void VertexAttrib3dARBDelegate( uint index, double x, double y, double z ); //  extension method
		public static readonly VertexAttrib3dARBDelegate VertexAttrib3dARB;
		public delegate void VertexAttrib3dvARBDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib3dvARBDelegate VertexAttrib3dvARB;
		public delegate void VertexAttrib3fARBDelegate( uint index, float x, float y, float z ); //  extension method
		public static readonly VertexAttrib3fARBDelegate VertexAttrib3fARB;
		public delegate void VertexAttrib3fvARBDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib3fvARBDelegate VertexAttrib3fvARB;
		public delegate void VertexAttrib3sARBDelegate( uint index, short x, short y, short z ); //  extension method
		public static readonly VertexAttrib3sARBDelegate VertexAttrib3sARB;
		public delegate void VertexAttrib3svARBDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib3svARBDelegate VertexAttrib3svARB;
		public delegate void VertexAttrib4NbvARBDelegate( uint index, sbyte[] v ); //  extension method
		public static readonly VertexAttrib4NbvARBDelegate VertexAttrib4NbvARB;
		public delegate void VertexAttrib4NivARBDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttrib4NivARBDelegate VertexAttrib4NivARB;
		public delegate void VertexAttrib4NsvARBDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib4NsvARBDelegate VertexAttrib4NsvARB;
		public delegate void VertexAttrib4NubARBDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method
		public static readonly VertexAttrib4NubARBDelegate VertexAttrib4NubARB;
		public delegate void VertexAttrib4NubvARBDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttrib4NubvARBDelegate VertexAttrib4NubvARB;
		public delegate void VertexAttrib4NuivARBDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttrib4NuivARBDelegate VertexAttrib4NuivARB;
		public delegate void VertexAttrib4NusvARBDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib4NusvARBDelegate VertexAttrib4NusvARB;
		public delegate void VertexAttrib4bvARBDelegate( uint index, sbyte[] v ); //  extension method
		public static readonly VertexAttrib4bvARBDelegate VertexAttrib4bvARB;
		public delegate void VertexAttrib4dARBDelegate( uint index, double x, double y, double z, double w ); //  extension method
		public static readonly VertexAttrib4dARBDelegate VertexAttrib4dARB;
		public delegate void VertexAttrib4dvARBDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib4dvARBDelegate VertexAttrib4dvARB;
		public delegate void VertexAttrib4fARBDelegate( uint index, float x, float y, float z, float w ); //  extension method
		public static readonly VertexAttrib4fARBDelegate VertexAttrib4fARB;
		public delegate void VertexAttrib4fvARBDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib4fvARBDelegate VertexAttrib4fvARB;
		public delegate void VertexAttrib4ivARBDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttrib4ivARBDelegate VertexAttrib4ivARB;
		public delegate void VertexAttrib4sARBDelegate( uint index, short x, short y, short z, short w ); //  extension method
		public static readonly VertexAttrib4sARBDelegate VertexAttrib4sARB;
		public delegate void VertexAttrib4svARBDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib4svARBDelegate VertexAttrib4svARB;
		public delegate void VertexAttrib4ubvARBDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttrib4ubvARBDelegate VertexAttrib4ubvARB;
		public delegate void VertexAttrib4uivARBDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttrib4uivARBDelegate VertexAttrib4uivARB;
		public delegate void VertexAttrib4usvARBDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib4usvARBDelegate VertexAttrib4usvARB;
		public unsafe delegate void VertexAttribPointerARBDelegate( uint index, int size, uint type, bool normalized, int stride, void* pointer ); //  extension method
		public static readonly VertexAttribPointerARBDelegate VertexAttribPointerARB;
		public delegate void EnableVertexAttribArrayARBDelegate( uint index ); //  extension method
		public static readonly EnableVertexAttribArrayARBDelegate EnableVertexAttribArrayARB;
		public delegate void DisableVertexAttribArrayARBDelegate( uint index ); //  extension method
		public static readonly DisableVertexAttribArrayARBDelegate DisableVertexAttribArrayARB;
		public unsafe delegate void ProgramStringARBDelegate( uint target, uint format, int len, void* @string ); //  extension method
		public static readonly ProgramStringARBDelegate ProgramStringARB;
		public delegate void BindProgramARBDelegate( uint target, uint program ); //  extension method
		public static readonly BindProgramARBDelegate BindProgramARB;
		public delegate void DeleteProgramsARBDelegate( int n, uint[] programs ); //  extension method
		public static readonly DeleteProgramsARBDelegate DeleteProgramsARB;
		public delegate void GenProgramsARBDelegate( int n, ref uint[] programs ); //  extension method
		public static readonly GenProgramsARBDelegate GenProgramsARB;
		public delegate void ProgramEnvParameter4dARBDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method
		public static readonly ProgramEnvParameter4dARBDelegate ProgramEnvParameter4dARB;
		public delegate void ProgramEnvParameter4dvARBDelegate( uint target, uint index, double[] @params ); //  extension method
		public static readonly ProgramEnvParameter4dvARBDelegate ProgramEnvParameter4dvARB;
		public delegate void ProgramEnvParameter4fARBDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method
		public static readonly ProgramEnvParameter4fARBDelegate ProgramEnvParameter4fARB;
		public delegate void ProgramEnvParameter4fvARBDelegate( uint target, uint index, float[] @params ); //  extension method
		public static readonly ProgramEnvParameter4fvARBDelegate ProgramEnvParameter4fvARB;
		public delegate void ProgramLocalParameter4dARBDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method
		public static readonly ProgramLocalParameter4dARBDelegate ProgramLocalParameter4dARB;
		public delegate void ProgramLocalParameter4dvARBDelegate( uint target, uint index, double[] @params ); //  extension method
		public static readonly ProgramLocalParameter4dvARBDelegate ProgramLocalParameter4dvARB;
		public delegate void ProgramLocalParameter4fARBDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method
		public static readonly ProgramLocalParameter4fARBDelegate ProgramLocalParameter4fARB;
		public delegate void ProgramLocalParameter4fvARBDelegate( uint target, uint index, float[] @params ); //  extension method
		public static readonly ProgramLocalParameter4fvARBDelegate ProgramLocalParameter4fvARB;
		public delegate void GetProgramEnvParameterdvARBDelegate( uint target, uint index, ref double[] @params ); //  extension method
		public static readonly GetProgramEnvParameterdvARBDelegate GetProgramEnvParameterdvARB;
		public delegate void GetProgramEnvParameterfvARBDelegate( uint target, uint index, ref float[] @params ); //  extension method
		public static readonly GetProgramEnvParameterfvARBDelegate GetProgramEnvParameterfvARB;
		public delegate void GetProgramLocalParameterdvARBDelegate( uint target, uint index, ref double[] @params ); //  extension method
		public static readonly GetProgramLocalParameterdvARBDelegate GetProgramLocalParameterdvARB;
		public delegate void GetProgramLocalParameterfvARBDelegate( uint target, uint index, ref float[] @params ); //  extension method
		public static readonly GetProgramLocalParameterfvARBDelegate GetProgramLocalParameterfvARB;
		public delegate void GetProgramivARBDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetProgramivARBDelegate GetProgramivARB;
		public unsafe delegate void GetProgramStringARBDelegate( uint target, uint pname, ref void* @string ); //  extension method
		public static readonly GetProgramStringARBDelegate GetProgramStringARB;
		public delegate void GetVertexAttribdvARBDelegate( uint index, uint pname, ref double[] @params ); //  extension method
		public static readonly GetVertexAttribdvARBDelegate GetVertexAttribdvARB;
		public delegate void GetVertexAttribfvARBDelegate( uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetVertexAttribfvARBDelegate GetVertexAttribfvARB;
		public delegate void GetVertexAttribivARBDelegate( uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVertexAttribivARBDelegate GetVertexAttribivARB;
		public unsafe delegate void GetVertexAttribPointervARBDelegate( uint index, uint pname, ref void** pointer ); //  extension method
		public static readonly GetVertexAttribPointervARBDelegate GetVertexAttribPointervARB;
		public delegate bool IsProgramARBDelegate( uint program ); //  extension method
		public static readonly IsProgramARBDelegate IsProgramARB;
		public delegate void BindBufferARBDelegate( uint target, uint buffer ); //  extension method
		public static readonly BindBufferARBDelegate BindBufferARB;
		public delegate void DeleteBuffersARBDelegate( int n, uint[] buffers ); //  extension method
		public static readonly DeleteBuffersARBDelegate DeleteBuffersARB;
		public delegate void GenBuffersARBDelegate( int n, ref uint[] buffers ); //  extension method
		public static readonly GenBuffersARBDelegate GenBuffersARB;
		public delegate bool IsBufferARBDelegate( uint buffer ); //  extension method
		public static readonly IsBufferARBDelegate IsBufferARB;
		public unsafe delegate void BufferDataARBDelegate( uint target, int size, void* data, uint usage ); //  extension method
		public static readonly BufferDataARBDelegate BufferDataARB;
		public unsafe delegate void BufferSubDataARBDelegate( uint target, int offset, int size, void* data ); //  extension method
		public static readonly BufferSubDataARBDelegate BufferSubDataARB;
		public unsafe delegate void GetBufferSubDataARBDelegate( uint target, int offset, int size, ref void* data ); //  extension method
		public static readonly GetBufferSubDataARBDelegate GetBufferSubDataARB;
		public delegate void MapBufferARBDelegate( uint target, uint access ); //  extension method
		public static readonly MapBufferARBDelegate MapBufferARB;
		public delegate bool UnmapBufferARBDelegate( uint target ); //  extension method
		public static readonly UnmapBufferARBDelegate UnmapBufferARB;
		public delegate void GetBufferParameterivARBDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetBufferParameterivARBDelegate GetBufferParameterivARB;
		public unsafe delegate void GetBufferPointervARBDelegate( uint target, uint pname, ref void** @params ); //  extension method
		public static readonly GetBufferPointervARBDelegate GetBufferPointervARB;
		public delegate void GenQueriesARBDelegate( int n, ref uint[] ids ); //  extension method
		public static readonly GenQueriesARBDelegate GenQueriesARB;
		public delegate void DeleteQueriesARBDelegate( int n, uint[] ids ); //  extension method
		public static readonly DeleteQueriesARBDelegate DeleteQueriesARB;
		public delegate bool IsQueryARBDelegate( uint id ); //  extension method
		public static readonly IsQueryARBDelegate IsQueryARB;
		public delegate void BeginQueryARBDelegate( uint target, uint id ); //  extension method
		public static readonly BeginQueryARBDelegate BeginQueryARB;
		public delegate void EndQueryARBDelegate( uint target ); //  extension method
		public static readonly EndQueryARBDelegate EndQueryARB;
		public delegate void GetQueryivARBDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetQueryivARBDelegate GetQueryivARB;
		public delegate void GetQueryObjectivARBDelegate( uint id, uint pname, ref int[] @params ); //  extension method
		public static readonly GetQueryObjectivARBDelegate GetQueryObjectivARB;
		public delegate void GetQueryObjectuivARBDelegate( uint id, uint pname, ref uint[] @params ); //  extension method
		public static readonly GetQueryObjectuivARBDelegate GetQueryObjectuivARB;
		public delegate void DeleteObjectARBDelegate( uint obj ); //  extension method
		public static readonly DeleteObjectARBDelegate DeleteObjectARB;
		public delegate uint GetHandleARBDelegate( uint pname ); //  extension method
		public static readonly GetHandleARBDelegate GetHandleARB;
		public delegate void DetachObjectARBDelegate( uint containerObj, uint attachedObj ); //  extension method
		public static readonly DetachObjectARBDelegate DetachObjectARB;
		public delegate uint CreateShaderObjectARBDelegate( uint shaderType ); //  extension method
		public static readonly CreateShaderObjectARBDelegate CreateShaderObjectARB;
		public delegate void ShaderSourceARBDelegate( uint shaderObj, int count, string[] @string, int[] length ); //  extension method
		public static readonly ShaderSourceARBDelegate ShaderSourceARB;
		public delegate void CompileShaderARBDelegate( uint shaderObj ); //  extension method
		public static readonly CompileShaderARBDelegate CompileShaderARB;
		public delegate uint CreateProgramObjectARBDelegate(  ); //  extension method
		public static readonly CreateProgramObjectARBDelegate CreateProgramObjectARB;
		public delegate void AttachObjectARBDelegate( uint containerObj, uint obj ); //  extension method
		public static readonly AttachObjectARBDelegate AttachObjectARB;
		public delegate void LinkProgramARBDelegate( uint programObj ); //  extension method
		public static readonly LinkProgramARBDelegate LinkProgramARB;
		public delegate void UseProgramObjectARBDelegate( uint programObj ); //  extension method
		public static readonly UseProgramObjectARBDelegate UseProgramObjectARB;
		public delegate void ValidateProgramARBDelegate( uint programObj ); //  extension method
		public static readonly ValidateProgramARBDelegate ValidateProgramARB;
		public delegate void Uniform1fARBDelegate( int location, float v0 ); //  extension method
		public static readonly Uniform1fARBDelegate Uniform1fARB;
		public delegate void Uniform2fARBDelegate( int location, float v0, float v1 ); //  extension method
		public static readonly Uniform2fARBDelegate Uniform2fARB;
		public delegate void Uniform3fARBDelegate( int location, float v0, float v1, float v2 ); //  extension method
		public static readonly Uniform3fARBDelegate Uniform3fARB;
		public delegate void Uniform4fARBDelegate( int location, float v0, float v1, float v2, float v3 ); //  extension method
		public static readonly Uniform4fARBDelegate Uniform4fARB;
		public delegate void Uniform1iARBDelegate( int location, int v0 ); //  extension method
		public static readonly Uniform1iARBDelegate Uniform1iARB;
		public delegate void Uniform2iARBDelegate( int location, int v0, int v1 ); //  extension method
		public static readonly Uniform2iARBDelegate Uniform2iARB;
		public delegate void Uniform3iARBDelegate( int location, int v0, int v1, int v2 ); //  extension method
		public static readonly Uniform3iARBDelegate Uniform3iARB;
		public delegate void Uniform4iARBDelegate( int location, int v0, int v1, int v2, int v3 ); //  extension method
		public static readonly Uniform4iARBDelegate Uniform4iARB;
		public delegate void Uniform1fvARBDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform1fvARBDelegate Uniform1fvARB;
		public delegate void Uniform2fvARBDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform2fvARBDelegate Uniform2fvARB;
		public delegate void Uniform3fvARBDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform3fvARBDelegate Uniform3fvARB;
		public delegate void Uniform4fvARBDelegate( int location, int count, float[] value ); //  extension method
		public static readonly Uniform4fvARBDelegate Uniform4fvARB;
		public delegate void Uniform1ivARBDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform1ivARBDelegate Uniform1ivARB;
		public delegate void Uniform2ivARBDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform2ivARBDelegate Uniform2ivARB;
		public delegate void Uniform3ivARBDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform3ivARBDelegate Uniform3ivARB;
		public delegate void Uniform4ivARBDelegate( int location, int count, int[] value ); //  extension method
		public static readonly Uniform4ivARBDelegate Uniform4ivARB;
		public delegate void UniformMatrix2fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix2fvARBDelegate UniformMatrix2fvARB;
		public delegate void UniformMatrix3fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix3fvARBDelegate UniformMatrix3fvARB;
		public delegate void UniformMatrix4fvARBDelegate( int location, int count, bool transpose, float[] value ); //  extension method
		public static readonly UniformMatrix4fvARBDelegate UniformMatrix4fvARB;
		public delegate void GetObjectParameterfvARBDelegate( uint obj, uint pname, ref float[] @params ); //  extension method
		public static readonly GetObjectParameterfvARBDelegate GetObjectParameterfvARB;
		public delegate void GetObjectParameterivARBDelegate( uint obj, uint pname, [MarshalAs(UnmanagedType.LPArray)]ref int[] @params ); //  extension method
		public static readonly GetObjectParameterivARBDelegate GetObjectParameterivARB;
		public delegate void GetInfoLogARBDelegate( uint obj, int maxLength, ref int[] length, ref string[] infoLog ); //  extension method
		public static readonly GetInfoLogARBDelegate GetInfoLogARB;
		public delegate void GetAttachedObjectsARBDelegate( uint containerObj, int maxCount, ref int[] count, ref uint[] obj ); //  extension method
		public static readonly GetAttachedObjectsARBDelegate GetAttachedObjectsARB;
		public delegate int GetUniformLocationARBDelegate( uint programObj, string[] name ); //  extension method
		public static readonly GetUniformLocationARBDelegate GetUniformLocationARB;
		public delegate void GetActiveUniformARBDelegate( uint programObj, uint index, int maxLength, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method
		public static readonly GetActiveUniformARBDelegate GetActiveUniformARB;
		public delegate void GetUniformfvARBDelegate( uint programObj, int location, ref float[] @params ); //  extension method
		public static readonly GetUniformfvARBDelegate GetUniformfvARB;
		public delegate void GetUniformivARBDelegate( uint programObj, int location, ref int[] @params ); //  extension method
		public static readonly GetUniformivARBDelegate GetUniformivARB;
		public delegate void GetShaderSourceARBDelegate( uint obj, int maxLength, ref int[] length, ref string[] source ); //  extension method
		public static readonly GetShaderSourceARBDelegate GetShaderSourceARB;
		public delegate void BindAttribLocationARBDelegate( uint programObj, uint index, string[] name ); //  extension method
		public static readonly BindAttribLocationARBDelegate BindAttribLocationARB;
		public delegate void GetActiveAttribARBDelegate( uint programObj, uint index, int maxLength, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method
		public static readonly GetActiveAttribARBDelegate GetActiveAttribARB;
		public delegate int GetAttribLocationARBDelegate( uint programObj, string[] name ); //  extension method
		public static readonly GetAttribLocationARBDelegate GetAttribLocationARB;
		public delegate void DrawBuffersARBDelegate( int n, uint[] bufs ); //  extension method
		public static readonly DrawBuffersARBDelegate DrawBuffersARB;
		public delegate void ClampColorARBDelegate( uint target, uint clamp ); //  extension method
		public static readonly ClampColorARBDelegate ClampColorARB;
		public delegate void BlendColorEXTDelegate( float red, float green, float blue, float alpha ); //  extension method
		public static readonly BlendColorEXTDelegate BlendColorEXT;
		public delegate void PolygonOffsetEXTDelegate( float factor, float bias ); //  extension method
		public static readonly PolygonOffsetEXTDelegate PolygonOffsetEXT;
		public unsafe delegate void TexImage3DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexImage3DEXTDelegate TexImage3DEXT;
		public unsafe delegate void TexSubImage3DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexSubImage3DEXTDelegate TexSubImage3DEXT;
		public delegate void GetTexFilterFuncSGISDelegate( TextureTarget target, uint filter, ref float[] weights ); //  extension method
		public static readonly GetTexFilterFuncSGISDelegate GetTexFilterFuncSGIS;
		public delegate void TexFilterFuncSGISDelegate( TextureTarget target, uint filter, int n, float[] weights ); //  extension method
		public static readonly TexFilterFuncSGISDelegate TexFilterFuncSGIS;
		public unsafe delegate void TexSubImage1DEXTDelegate( TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexSubImage1DEXTDelegate TexSubImage1DEXT;
		public unsafe delegate void TexSubImage2DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexSubImage2DEXTDelegate TexSubImage2DEXT;
		public delegate void CopyTexImage1DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border ); //  extension method
		public static readonly CopyTexImage1DEXTDelegate CopyTexImage1DEXT;
		public delegate void CopyTexImage2DEXTDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border ); //  extension method
		public static readonly CopyTexImage2DEXTDelegate CopyTexImage2DEXT;
		public delegate void CopyTexSubImage1DEXTDelegate( TextureTarget target, int level, int xoffset, int x, int y, int width ); //  extension method
		public static readonly CopyTexSubImage1DEXTDelegate CopyTexSubImage1DEXT;
		public delegate void CopyTexSubImage2DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height ); //  extension method
		public static readonly CopyTexSubImage2DEXTDelegate CopyTexSubImage2DEXT;
		public delegate void CopyTexSubImage3DEXTDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height ); //  extension method
		public static readonly CopyTexSubImage3DEXTDelegate CopyTexSubImage3DEXT;
		public unsafe delegate void GetHistogramEXTDelegate( HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, ref void* values ); //  extension method
		public static readonly GetHistogramEXTDelegate GetHistogramEXT;
		public delegate void GetHistogramParameterfvEXTDelegate( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref float[] @params ); //  extension method
		public static readonly GetHistogramParameterfvEXTDelegate GetHistogramParameterfvEXT;
		public delegate void GetHistogramParameterivEXTDelegate( HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref int[] @params ); //  extension method
		public static readonly GetHistogramParameterivEXTDelegate GetHistogramParameterivEXT;
		public unsafe delegate void GetMinmaxEXTDelegate( MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, ref void* values ); //  extension method
		public static readonly GetMinmaxEXTDelegate GetMinmaxEXT;
		public delegate void GetMinmaxParameterfvEXTDelegate( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, ref float[] @params ); //  extension method
		public static readonly GetMinmaxParameterfvEXTDelegate GetMinmaxParameterfvEXT;
		public delegate void GetMinmaxParameterivEXTDelegate( MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, ref int[] @params ); //  extension method
		public static readonly GetMinmaxParameterivEXTDelegate GetMinmaxParameterivEXT;
		public delegate void HistogramEXTDelegate( HistogramTargetEXT target, int width, PixelInternalFormat internalformat, bool sink ); //  extension method
		public static readonly HistogramEXTDelegate HistogramEXT;
		public delegate void MinmaxEXTDelegate( MinmaxTargetEXT target, PixelInternalFormat internalformat, bool sink ); //  extension method
		public static readonly MinmaxEXTDelegate MinmaxEXT;
		public delegate void ResetHistogramEXTDelegate( HistogramTargetEXT target ); //  extension method
		public static readonly ResetHistogramEXTDelegate ResetHistogramEXT;
		public delegate void ResetMinmaxEXTDelegate( MinmaxTargetEXT target ); //  extension method
		public static readonly ResetMinmaxEXTDelegate ResetMinmaxEXT;
		public unsafe delegate void ConvolutionFilter1DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image ); //  extension method
		public static readonly ConvolutionFilter1DEXTDelegate ConvolutionFilter1DEXT;
		public unsafe delegate void ConvolutionFilter2DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image ); //  extension method
		public static readonly ConvolutionFilter2DEXTDelegate ConvolutionFilter2DEXT;
		public delegate void ConvolutionParameterfEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params ); //  extension method
		public static readonly ConvolutionParameterfEXTDelegate ConvolutionParameterfEXT;
		public delegate void ConvolutionParameterfvEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params ); //  extension method
		public static readonly ConvolutionParameterfvEXTDelegate ConvolutionParameterfvEXT;
		public delegate void ConvolutionParameteriEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int @params ); //  extension method
		public static readonly ConvolutionParameteriEXTDelegate ConvolutionParameteriEXT;
		public delegate void ConvolutionParameterivEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int[] @params ); //  extension method
		public static readonly ConvolutionParameterivEXTDelegate ConvolutionParameterivEXT;
		public delegate void CopyConvolutionFilter1DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method
		public static readonly CopyConvolutionFilter1DEXTDelegate CopyConvolutionFilter1DEXT;
		public delegate void CopyConvolutionFilter2DEXTDelegate( ConvolutionTargetEXT target, PixelInternalFormat internalformat, int x, int y, int width, int height ); //  extension method
		public static readonly CopyConvolutionFilter2DEXTDelegate CopyConvolutionFilter2DEXT;
		public unsafe delegate void GetConvolutionFilterEXTDelegate( ConvolutionTargetEXT target, PixelFormat format, PixelType type, ref void* image ); //  extension method
		public static readonly GetConvolutionFilterEXTDelegate GetConvolutionFilterEXT;
		public delegate void GetConvolutionParameterfvEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, ref float[] @params ); //  extension method
		public static readonly GetConvolutionParameterfvEXTDelegate GetConvolutionParameterfvEXT;
		public delegate void GetConvolutionParameterivEXTDelegate( ConvolutionTargetEXT target, ConvolutionParameterEXT pname, ref int[] @params ); //  extension method
		public static readonly GetConvolutionParameterivEXTDelegate GetConvolutionParameterivEXT;
		public unsafe delegate void GetSeparableFilterEXTDelegate( SeparableTargetEXT target, PixelFormat format, PixelType type, ref void* row, ref void* column, ref void* span ); //  extension method
		public static readonly GetSeparableFilterEXTDelegate GetSeparableFilterEXT;
		public unsafe delegate void SeparableFilter2DEXTDelegate( SeparableTargetEXT target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column ); //  extension method
		public static readonly SeparableFilter2DEXTDelegate SeparableFilter2DEXT;
		public unsafe delegate void ColorTableSGIDelegate( ColorTableTargetSGI target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table ); //  extension method
		public static readonly ColorTableSGIDelegate ColorTableSGI;
		public delegate void ColorTableParameterfvSGIDelegate( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float[] @params ); //  extension method
		public static readonly ColorTableParameterfvSGIDelegate ColorTableParameterfvSGI;
		public delegate void ColorTableParameterivSGIDelegate( ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int[] @params ); //  extension method
		public static readonly ColorTableParameterivSGIDelegate ColorTableParameterivSGI;
		public delegate void CopyColorTableSGIDelegate( ColorTableTargetSGI target, PixelInternalFormat internalformat, int x, int y, int width ); //  extension method
		public static readonly CopyColorTableSGIDelegate CopyColorTableSGI;
		public unsafe delegate void GetColorTableSGIDelegate( ColorTableTargetSGI target, PixelFormat format, PixelType type, ref void* table ); //  extension method
		public static readonly GetColorTableSGIDelegate GetColorTableSGI;
		public delegate void GetColorTableParameterfvSGIDelegate( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, ref float[] @params ); //  extension method
		public static readonly GetColorTableParameterfvSGIDelegate GetColorTableParameterfvSGI;
		public delegate void GetColorTableParameterivSGIDelegate( ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, ref int[] @params ); //  extension method
		public static readonly GetColorTableParameterivSGIDelegate GetColorTableParameterivSGI;
		public delegate void PixelTexGenSGIXDelegate( uint mode ); //  extension method
		public static readonly PixelTexGenSGIXDelegate PixelTexGenSGIX;
		public delegate void PixelTexGenParameteriSGISDelegate( PixelTexGenParameterNameSGIS pname, int param ); //  extension method
		public static readonly PixelTexGenParameteriSGISDelegate PixelTexGenParameteriSGIS;
		public delegate void PixelTexGenParameterivSGISDelegate( PixelTexGenParameterNameSGIS pname, int[] @params ); //  extension method
		public static readonly PixelTexGenParameterivSGISDelegate PixelTexGenParameterivSGIS;
		public delegate void PixelTexGenParameterfSGISDelegate( PixelTexGenParameterNameSGIS pname, float param ); //  extension method
		public static readonly PixelTexGenParameterfSGISDelegate PixelTexGenParameterfSGIS;
		public delegate void PixelTexGenParameterfvSGISDelegate( PixelTexGenParameterNameSGIS pname, float[] @params ); //  extension method
		public static readonly PixelTexGenParameterfvSGISDelegate PixelTexGenParameterfvSGIS;
		public delegate void GetPixelTexGenParameterivSGISDelegate( PixelTexGenParameterNameSGIS pname, ref int[] @params ); //  extension method
		public static readonly GetPixelTexGenParameterivSGISDelegate GetPixelTexGenParameterivSGIS;
		public delegate void GetPixelTexGenParameterfvSGISDelegate( PixelTexGenParameterNameSGIS pname, ref float[] @params ); //  extension method
		public static readonly GetPixelTexGenParameterfvSGISDelegate GetPixelTexGenParameterfvSGIS;
		public unsafe delegate void TexImage4DSGISDelegate( TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexImage4DSGISDelegate TexImage4DSGIS;
		public unsafe delegate void TexSubImage4DSGISDelegate( TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels ); //  extension method
		public static readonly TexSubImage4DSGISDelegate TexSubImage4DSGIS;
		public delegate bool AreTexturesResidentEXTDelegate( int n, uint[] textures, ref bool[] residences ); //  extension method
		public static readonly AreTexturesResidentEXTDelegate AreTexturesResidentEXT;
		public delegate void BindTextureEXTDelegate( TextureTarget target, uint texture ); //  extension method
		public static readonly BindTextureEXTDelegate BindTextureEXT;
		public delegate void DeleteTexturesEXTDelegate( int n, uint[] textures ); //  extension method
		public static readonly DeleteTexturesEXTDelegate DeleteTexturesEXT;
		public delegate void GenTexturesEXTDelegate( int n, ref uint[] textures ); //  extension method
		public static readonly GenTexturesEXTDelegate GenTexturesEXT;
		public delegate bool IsTextureEXTDelegate( uint texture ); //  extension method
		public static readonly IsTextureEXTDelegate IsTextureEXT;
		public delegate void PrioritizeTexturesEXTDelegate( int n, uint[] textures, float[] priorities ); //  extension method
		public static readonly PrioritizeTexturesEXTDelegate PrioritizeTexturesEXT;
		public delegate void DetailTexFuncSGISDelegate( TextureTarget target, int n, float[] points ); //  extension method
		public static readonly DetailTexFuncSGISDelegate DetailTexFuncSGIS;
		public delegate void GetDetailTexFuncSGISDelegate( TextureTarget target, ref float[] points ); //  extension method
		public static readonly GetDetailTexFuncSGISDelegate GetDetailTexFuncSGIS;
		public delegate void SharpenTexFuncSGISDelegate( TextureTarget target, int n, float[] points ); //  extension method
		public static readonly SharpenTexFuncSGISDelegate SharpenTexFuncSGIS;
		public delegate void GetSharpenTexFuncSGISDelegate( TextureTarget target, ref float[] points ); //  extension method
		public static readonly GetSharpenTexFuncSGISDelegate GetSharpenTexFuncSGIS;
		public delegate void SampleMaskSGISDelegate( float value, bool invert ); //  extension method
		public static readonly SampleMaskSGISDelegate SampleMaskSGIS;
		public delegate void SamplePatternSGISDelegate( SamplePatternSGIS pattern ); //  extension method
		public static readonly SamplePatternSGISDelegate SamplePatternSGIS;
		public delegate void ArrayElementEXTDelegate( int i ); //  extension method
		public static readonly ArrayElementEXTDelegate ArrayElementEXT;
		public unsafe delegate void ColorPointerEXTDelegate( int size, ColorPointerType type, int stride, int count, void* pointer ); //  extension method
		public static readonly ColorPointerEXTDelegate ColorPointerEXT;
		public delegate void DrawArraysEXTDelegate( BeginMode mode, int first, int count ); //  extension method
		public static readonly DrawArraysEXTDelegate DrawArraysEXT;
		public delegate void EdgeFlagPointerEXTDelegate( int stride, int count, bool[] pointer ); //  extension method
		public static readonly EdgeFlagPointerEXTDelegate EdgeFlagPointerEXT;
		public unsafe delegate void GetPointervEXTDelegate( GetPointervPName pname, ref void** @params ); //  extension method
		public static readonly GetPointervEXTDelegate GetPointervEXT;
		public unsafe delegate void IndexPointerEXTDelegate( IndexPointerType type, int stride, int count, void* pointer ); //  extension method
		public static readonly IndexPointerEXTDelegate IndexPointerEXT;
		public unsafe delegate void NormalPointerEXTDelegate( NormalPointerType type, int stride, int count, void* pointer ); //  extension method
		public static readonly NormalPointerEXTDelegate NormalPointerEXT;
		public unsafe delegate void TexCoordPointerEXTDelegate( int size, TexCoordPointerType type, int stride, int count, void* pointer ); //  extension method
		public static readonly TexCoordPointerEXTDelegate TexCoordPointerEXT;
		public unsafe delegate void VertexPointerEXTDelegate( int size, VertexPointerType type, int stride, int count, void* pointer ); //  extension method
		public static readonly VertexPointerEXTDelegate VertexPointerEXT;
		public delegate void BlendEquationEXTDelegate( BlendEquationModeEXT mode ); //  extension method
		public static readonly BlendEquationEXTDelegate BlendEquationEXT;
		public delegate void SpriteParameterfSGIXDelegate( uint pname, float param ); //  extension method
		public static readonly SpriteParameterfSGIXDelegate SpriteParameterfSGIX;
		public delegate void SpriteParameterfvSGIXDelegate( uint pname, float[] @params ); //  extension method
		public static readonly SpriteParameterfvSGIXDelegate SpriteParameterfvSGIX;
		public delegate void SpriteParameteriSGIXDelegate( uint pname, int param ); //  extension method
		public static readonly SpriteParameteriSGIXDelegate SpriteParameteriSGIX;
		public delegate void SpriteParameterivSGIXDelegate( uint pname, int[] @params ); //  extension method
		public static readonly SpriteParameterivSGIXDelegate SpriteParameterivSGIX;
		public delegate void PointParameterfEXTDelegate( uint pname, float param ); //  extension method
		public static readonly PointParameterfEXTDelegate PointParameterfEXT;
		public delegate void PointParameterfvEXTDelegate( uint pname, float[] @params ); //  extension method
		public static readonly PointParameterfvEXTDelegate PointParameterfvEXT;
		public delegate void PointParameterfSGISDelegate( uint pname, float param ); //  extension method
		public static readonly PointParameterfSGISDelegate PointParameterfSGIS;
		public delegate void PointParameterfvSGISDelegate( uint pname, float[] @params ); //  extension method
		public static readonly PointParameterfvSGISDelegate PointParameterfvSGIS;
		public delegate int GetInstrumentsSGIXDelegate(  ); //  extension method
		public static readonly GetInstrumentsSGIXDelegate GetInstrumentsSGIX;
		public delegate void InstrumentsBufferSGIXDelegate( int size, ref int[] buffer ); //  extension method
		public static readonly InstrumentsBufferSGIXDelegate InstrumentsBufferSGIX;
		public delegate int PollInstrumentsSGIXDelegate( ref int[] marker_p ); //  extension method
		public static readonly PollInstrumentsSGIXDelegate PollInstrumentsSGIX;
		public delegate void ReadInstrumentsSGIXDelegate( int marker ); //  extension method
		public static readonly ReadInstrumentsSGIXDelegate ReadInstrumentsSGIX;
		public delegate void StartInstrumentsSGIXDelegate(  ); //  extension method
		public static readonly StartInstrumentsSGIXDelegate StartInstrumentsSGIX;
		public delegate void StopInstrumentsSGIXDelegate( int marker ); //  extension method
		public static readonly StopInstrumentsSGIXDelegate StopInstrumentsSGIX;
		public delegate void FrameZoomSGIXDelegate( int factor ); //  extension method
		public static readonly FrameZoomSGIXDelegate FrameZoomSGIX;
		public delegate void TagSampleBufferSGIXDelegate(  ); //  extension method
		public static readonly TagSampleBufferSGIXDelegate TagSampleBufferSGIX;
		public delegate void DeformationMap3dSGIXDelegate( FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points ); //  extension method
		public static readonly DeformationMap3dSGIXDelegate DeformationMap3dSGIX;
		public delegate void DeformationMap3fSGIXDelegate( FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points ); //  extension method
		public static readonly DeformationMap3fSGIXDelegate DeformationMap3fSGIX;
		public delegate void DeformSGIXDelegate( FfdMaskSGIX mask ); //  extension method
		public static readonly DeformSGIXDelegate DeformSGIX;
		public delegate void LoadIdentityDeformationMapSGIXDelegate( FfdMaskSGIX mask ); //  extension method
		public static readonly LoadIdentityDeformationMapSGIXDelegate LoadIdentityDeformationMapSGIX;
		public delegate void ReferencePlaneSGIXDelegate( double[] equation ); //  extension method
		public static readonly ReferencePlaneSGIXDelegate ReferencePlaneSGIX;
		public delegate void FlushRasterSGIXDelegate(  ); //  extension method
		public static readonly FlushRasterSGIXDelegate FlushRasterSGIX;
		public delegate void FogFuncSGISDelegate( int n, float[] points ); //  extension method
		public static readonly FogFuncSGISDelegate FogFuncSGIS;
		public delegate void GetFogFuncSGISDelegate( ref float[] points ); //  extension method
		public static readonly GetFogFuncSGISDelegate GetFogFuncSGIS;
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameteriHP" )]
		public static extern void ImageTransformParameteriHP( uint target, uint pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterfHP" )]
		public static extern void ImageTransformParameterfHP( uint target, uint pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterivHP" )]
		public static extern void ImageTransformParameterivHP( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glImageTransformParameterfvHP" )]
		public static extern void ImageTransformParameterfvHP( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetImageTransformParameterivHP" )]
		public static extern void GetImageTransformParameterivHP( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetImageTransformParameterfvHP" )]
		public static extern void GetImageTransformParameterfvHP( uint target, uint pname, ref float[] @params ); // 	
		public unsafe delegate void ColorSubTableEXTDelegate( uint target, int start, int count, PixelFormat format, PixelType type, void* data ); // 
		public static readonly ColorSubTableEXTDelegate ColorSubTableEXT;
		public delegate void CopyColorSubTableEXTDelegate( uint target, int start, int x, int y, int width ); // 
		public static readonly CopyColorSubTableEXTDelegate CopyColorSubTableEXT;
		[DllImport( "opengl32.dll", EntryPoint="glHintPGI" )]
		public static extern void HintPGI( uint target, int mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorTableEXT" )]
		public static extern unsafe void ColorTableEXT( uint target, PixelInternalFormat internalFormat, int width, PixelFormat format, PixelType type, void* table ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableEXT" )]
		public static extern unsafe void GetColorTableEXT( uint target, PixelFormat format, PixelType type, ref void* data ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableParameterivEXT" )]
		public static extern void GetColorTableParameterivEXT( uint target, uint pname, ref int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGetColorTableParameterfvEXT" )]
		public static extern void GetColorTableParameterfvEXT( uint target, uint pname, ref float[] @params ); // 	
		public delegate void GetListParameterfvSGIXDelegate( uint list, ListParameterName pname, ref float[] @params ); //  extension method
		public static readonly GetListParameterfvSGIXDelegate GetListParameterfvSGIX;
		public delegate void GetListParameterivSGIXDelegate( uint list, ListParameterName pname, ref int[] @params ); //  extension method
		public static readonly GetListParameterivSGIXDelegate GetListParameterivSGIX;
		public delegate void ListParameterfSGIXDelegate( uint list, ListParameterName pname, float param ); //  extension method
		public static readonly ListParameterfSGIXDelegate ListParameterfSGIX;
		public delegate void ListParameterfvSGIXDelegate( uint list, ListParameterName pname, float[] @params ); //  extension method
		public static readonly ListParameterfvSGIXDelegate ListParameterfvSGIX;
		public delegate void ListParameteriSGIXDelegate( uint list, ListParameterName pname, int param ); //  extension method
		public static readonly ListParameteriSGIXDelegate ListParameteriSGIX;
		public delegate void ListParameterivSGIXDelegate( uint list, ListParameterName pname, int[] @params ); //  extension method
		public static readonly ListParameterivSGIXDelegate ListParameterivSGIX;
		public delegate void IndexMaterialEXTDelegate( MaterialFace face, uint mode ); //  extension method
		public static readonly IndexMaterialEXTDelegate IndexMaterialEXT;
		public delegate void IndexFuncEXTDelegate( uint func, float @ref ); //  extension method
		public static readonly IndexFuncEXTDelegate IndexFuncEXT;
		public delegate void LockArraysEXTDelegate( int first, int count ); //  extension method
		public static readonly LockArraysEXTDelegate LockArraysEXT;
		public delegate void UnlockArraysEXTDelegate(  ); //  extension method
		public static readonly UnlockArraysEXTDelegate UnlockArraysEXT;
		public delegate void CullParameterdvEXTDelegate( uint pname, ref double[] @params ); //  extension method
		public static readonly CullParameterdvEXTDelegate CullParameterdvEXT;
		public delegate void CullParameterfvEXTDelegate( uint pname, ref float[] @params ); //  extension method
		public static readonly CullParameterfvEXTDelegate CullParameterfvEXT;
		public delegate void FragmentColorMaterialSGIXDelegate( MaterialFace face, MaterialParameter mode ); //  extension method
		public static readonly FragmentColorMaterialSGIXDelegate FragmentColorMaterialSGIX;
		public delegate void FragmentLightfSGIXDelegate( uint light, uint pname, float param ); //  extension method
		public static readonly FragmentLightfSGIXDelegate FragmentLightfSGIX;
		public delegate void FragmentLightfvSGIXDelegate( uint light, uint pname, float[] @params ); //  extension method
		public static readonly FragmentLightfvSGIXDelegate FragmentLightfvSGIX;
		public delegate void FragmentLightiSGIXDelegate( uint light, uint pname, int param ); //  extension method
		public static readonly FragmentLightiSGIXDelegate FragmentLightiSGIX;
		public delegate void FragmentLightivSGIXDelegate( uint light, uint pname, int[] @params ); //  extension method
		public static readonly FragmentLightivSGIXDelegate FragmentLightivSGIX;
		public delegate void FragmentLightModelfSGIXDelegate( FragmentLightModelParameterSGIX pname, float param ); //  extension method
		public static readonly FragmentLightModelfSGIXDelegate FragmentLightModelfSGIX;
		public delegate void FragmentLightModelfvSGIXDelegate( FragmentLightModelParameterSGIX pname, float[] @params ); //  extension method
		public static readonly FragmentLightModelfvSGIXDelegate FragmentLightModelfvSGIX;
		public delegate void FragmentLightModeliSGIXDelegate( FragmentLightModelParameterSGIX pname, int param ); //  extension method
		public static readonly FragmentLightModeliSGIXDelegate FragmentLightModeliSGIX;
		public delegate void FragmentLightModelivSGIXDelegate( FragmentLightModelParameterSGIX pname, int[] @params ); //  extension method
		public static readonly FragmentLightModelivSGIXDelegate FragmentLightModelivSGIX;
		public delegate void FragmentMaterialfSGIXDelegate( MaterialFace face, MaterialParameter pname, float param ); //  extension method
		public static readonly FragmentMaterialfSGIXDelegate FragmentMaterialfSGIX;
		public delegate void FragmentMaterialfvSGIXDelegate( MaterialFace face, MaterialParameter pname, float[] @params ); //  extension method
		public static readonly FragmentMaterialfvSGIXDelegate FragmentMaterialfvSGIX;
		public delegate void FragmentMaterialiSGIXDelegate( MaterialFace face, MaterialParameter pname, int param ); //  extension method
		public static readonly FragmentMaterialiSGIXDelegate FragmentMaterialiSGIX;
		public delegate void FragmentMaterialivSGIXDelegate( MaterialFace face, MaterialParameter pname, int[] @params ); //  extension method
		public static readonly FragmentMaterialivSGIXDelegate FragmentMaterialivSGIX;
		public delegate void GetFragmentLightfvSGIXDelegate( uint light, uint pname, ref float[] @params ); //  extension method
		public static readonly GetFragmentLightfvSGIXDelegate GetFragmentLightfvSGIX;
		public delegate void GetFragmentLightivSGIXDelegate( uint light, uint pname, ref int[] @params ); //  extension method
		public static readonly GetFragmentLightivSGIXDelegate GetFragmentLightivSGIX;
		public delegate void GetFragmentMaterialfvSGIXDelegate( MaterialFace face, MaterialParameter pname, ref float[] @params ); //  extension method
		public static readonly GetFragmentMaterialfvSGIXDelegate GetFragmentMaterialfvSGIX;
		public delegate void GetFragmentMaterialivSGIXDelegate( MaterialFace face, MaterialParameter pname, ref int[] @params ); //  extension method
		public static readonly GetFragmentMaterialivSGIXDelegate GetFragmentMaterialivSGIX;
		public delegate void LightEnviSGIXDelegate( LightEnvParameterSGIX pname, int param ); //  extension method
		public static readonly LightEnviSGIXDelegate LightEnviSGIX;
		[DllImport( "opengl32.dll", EntryPoint="glDrawRangeElementsEXT" )]
		public static extern unsafe void DrawRangeElementsEXT( BeginMode mode, uint start, uint end, int count, uint type, void* indices ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glApplyTextureEXT" )]
		public static extern void ApplyTextureEXT( uint mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTextureLightEXT" )]
		public static extern void TextureLightEXT( uint pname ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTextureMaterialEXT" )]
		public static extern void TextureMaterialEXT( MaterialFace face, MaterialParameter mode ); // 	
		public delegate void AsyncMarkerSGIXDelegate( uint marker ); //  extension method
		public static readonly AsyncMarkerSGIXDelegate AsyncMarkerSGIX;
		public delegate int FinishAsyncSGIXDelegate( ref uint[] markerp ); //  extension method
		public static readonly FinishAsyncSGIXDelegate FinishAsyncSGIX;
		public delegate int PollAsyncSGIXDelegate( ref uint[] markerp ); //  extension method
		public static readonly PollAsyncSGIXDelegate PollAsyncSGIX;
		public delegate uint GenAsyncMarkersSGIXDelegate( int range ); //  extension method
		public static readonly GenAsyncMarkersSGIXDelegate GenAsyncMarkersSGIX;
		public delegate void DeleteAsyncMarkersSGIXDelegate( uint marker, int range ); //  extension method
		public static readonly DeleteAsyncMarkersSGIXDelegate DeleteAsyncMarkersSGIX;
		public delegate bool IsAsyncMarkerSGIXDelegate( uint marker ); //  extension method
		public static readonly IsAsyncMarkerSGIXDelegate IsAsyncMarkerSGIX;
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointervINTEL" )]
		public static extern unsafe void VertexPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointervINTEL" )]
		public static extern unsafe void NormalPointervINTEL( NormalPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorPointervINTEL" )]
		public static extern unsafe void ColorPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointervINTEL" )]
		public static extern unsafe void TexCoordPointervINTEL( int size, VertexPointerType type, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameteriEXT" )]
		public static extern void PixelTransformParameteriEXT( uint target, uint pname, int param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterfEXT" )]
		public static extern void PixelTransformParameterfEXT( uint target, uint pname, float param ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterivEXT" )]
		public static extern void PixelTransformParameterivEXT( uint target, uint pname, int[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPixelTransformParameterfvEXT" )]
		public static extern void PixelTransformParameterfvEXT( uint target, uint pname, float[] @params ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3bEXT" )]
		public static extern void SecondaryColor3bEXT( sbyte red, sbyte green, sbyte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3bvEXT" )]
		public static extern void SecondaryColor3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3dEXT" )]
		public static extern void SecondaryColor3dEXT( double red, double green, double blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3dvEXT" )]
		public static extern void SecondaryColor3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3fEXT" )]
		public static extern void SecondaryColor3fEXT( float red, float green, float blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3fvEXT" )]
		public static extern void SecondaryColor3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3iEXT" )]
		public static extern void SecondaryColor3iEXT( int red, int green, int blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ivEXT" )]
		public static extern void SecondaryColor3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3sEXT" )]
		public static extern void SecondaryColor3sEXT( short red, short green, short blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3svEXT" )]
		public static extern void SecondaryColor3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ubEXT" )]
		public static extern void SecondaryColor3ubEXT( byte red, byte green, byte blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3ubvEXT" )]
		public static extern void SecondaryColor3ubvEXT( byte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3uiEXT" )]
		public static extern void SecondaryColor3uiEXT( uint red, uint green, uint blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3uivEXT" )]
		public static extern void SecondaryColor3uivEXT( uint[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3usEXT" )]
		public static extern void SecondaryColor3usEXT( ushort red, ushort green, ushort blue ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColor3usvEXT" )]
		public static extern void SecondaryColor3usvEXT( ushort[] v ); // 	
		public unsafe delegate void SecondaryColorPointerEXTDelegate( int size, ColorPointerType type, int stride, void* pointer ); //  extension method
		public static readonly SecondaryColorPointerEXTDelegate SecondaryColorPointerEXT;
		[DllImport( "opengl32.dll", EntryPoint="glTextureNormalEXT" )]
		public static extern void TextureNormalEXT( uint mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultiDrawArraysEXT" )]
		public static extern void MultiDrawArraysEXT( BeginMode mode, ref int[] first, ref int[] count, int primcount ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultiDrawElementsEXT" )]
		public static extern unsafe void MultiDrawElementsEXT( BeginMode mode, int[] count, uint type, void** indices, int primcount ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordfEXT" )]
		public static extern void FogCoordfEXT( float coord ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordfvEXT" )]
		public static extern void FogCoordfvEXT( float[] coord ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoorddEXT" )]
		public static extern void FogCoorddEXT( double coord ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoorddvEXT" )]
		public static extern void FogCoorddvEXT( double[] coord ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordPointerEXT" )]
		public static extern unsafe void FogCoordPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3bEXT" )]
		public static extern void Tangent3bEXT( sbyte tx, sbyte ty, sbyte tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3bvEXT" )]
		public static extern void Tangent3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3dEXT" )]
		public static extern void Tangent3dEXT( double tx, double ty, double tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3dvEXT" )]
		public static extern void Tangent3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3fEXT" )]
		public static extern void Tangent3fEXT( float tx, float ty, float tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3fvEXT" )]
		public static extern void Tangent3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3iEXT" )]
		public static extern void Tangent3iEXT( int tx, int ty, int tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3ivEXT" )]
		public static extern void Tangent3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3sEXT" )]
		public static extern void Tangent3sEXT( short tx, short ty, short tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3svEXT" )]
		public static extern void Tangent3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3bEXT" )]
		public static extern void Binormal3bEXT( sbyte bx, sbyte by, sbyte bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3bvEXT" )]
		public static extern void Binormal3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3dEXT" )]
		public static extern void Binormal3dEXT( double bx, double by, double bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3dvEXT" )]
		public static extern void Binormal3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3fEXT" )]
		public static extern void Binormal3fEXT( float bx, float by, float bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3fvEXT" )]
		public static extern void Binormal3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3iEXT" )]
		public static extern void Binormal3iEXT( int bx, int by, int bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3ivEXT" )]
		public static extern void Binormal3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3sEXT" )]
		public static extern void Binormal3sEXT( short bx, short by, short bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3svEXT" )]
		public static extern void Binormal3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangentPointerEXT" )]
		public static extern unsafe void TangentPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormalPointerEXT" )]
		public static extern unsafe void BinormalPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFinishTextureSUNX" )]
		public static extern void FinishTextureSUNX(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorbSUN" )]
		public static extern void GlobalAlphaFactorbSUN( sbyte factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorsSUN" )]
		public static extern void GlobalAlphaFactorsSUN( short factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactoriSUN" )]
		public static extern void GlobalAlphaFactoriSUN( int factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorfSUN" )]
		public static extern void GlobalAlphaFactorfSUN( float factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactordSUN" )]
		public static extern void GlobalAlphaFactordSUN( double factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorubSUN" )]
		public static extern void GlobalAlphaFactorubSUN( byte factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorusSUN" )]
		public static extern void GlobalAlphaFactorusSUN( ushort factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactoruiSUN" )]
		public static extern void GlobalAlphaFactoruiSUN( uint factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiSUN" )]
		public static extern void ReplacementCodeuiSUN( uint code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeusSUN" )]
		public static extern void ReplacementCodeusSUN( ushort code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeubSUN" )]
		public static extern void ReplacementCodeubSUN( byte code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuivSUN" )]
		public static extern void ReplacementCodeuivSUN( uint[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeusvSUN" )]
		public static extern void ReplacementCodeusvSUN( ushort[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeubvSUN" )]
		public static extern void ReplacementCodeubvSUN( byte[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodePointerSUN" )]
		public static extern unsafe void ReplacementCodePointerSUN( uint type, int stride, void** pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex2fSUN" )]
		public static extern void Color4ubVertex2fSUN( byte r, byte g, byte b, byte a, float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex2fvSUN" )]
		public static extern void Color4ubVertex2fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex3fSUN" )]
		public static extern void Color4ubVertex3fSUN( byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex3fvSUN" )]
		public static extern void Color4ubVertex3fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fVertex3fSUN" )]
		public static extern void Color3fVertex3fSUN( float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fVertex3fvSUN" )]
		public static extern void Color3fVertex3fvSUN( float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fVertex3fSUN" )]
		public static extern void Normal3fVertex3fSUN( float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fVertex3fvSUN" )]
		public static extern void Normal3fVertex3fvSUN( float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fNormal3fVertex3fSUN" )]
		public static extern void Color4fNormal3fVertex3fSUN( float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fNormal3fVertex3fvSUN" )]
		public static extern void Color4fNormal3fVertex3fvSUN( float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fVertex3fSUN" )]
		public static extern void TexCoord2fVertex3fSUN( float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fVertex3fvSUN" )]
		public static extern void TexCoord2fVertex3fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fVertex4fSUN" )]
		public static extern void TexCoord4fVertex4fSUN( float s, float t, float p, float q, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fVertex4fvSUN" )]
		public static extern void TexCoord4fVertex4fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4ubVertex3fSUN" )]
		public static extern void TexCoord2fColor4ubVertex3fSUN( float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4ubVertex3fvSUN" )]
		public static extern void TexCoord2fColor4ubVertex3fvSUN( float[] tc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor3fVertex3fSUN" )]
		public static extern void TexCoord2fColor3fVertex3fSUN( float s, float t, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor3fVertex3fvSUN" )]
		public static extern void TexCoord2fColor3fVertex3fvSUN( float[] tc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fNormal3fVertex3fSUN" )]
		public static extern void TexCoord2fNormal3fVertex3fSUN( float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fNormal3fVertex3fvSUN" )]
		public static extern void TexCoord2fNormal3fVertex3fvSUN( float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4fNormal3fVertex3fSUN" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fSUN( float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4fNormal3fVertex3fvSUN" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fColor4fNormal3fVertex4fSUN" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fSUN( float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fColor4fNormal3fVertex4fvSUN" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiVertex3fSUN" )]
		public static extern void ReplacementCodeuiVertex3fSUN( uint rc, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiVertex3fvSUN" )]
		public static extern void ReplacementCodeuiVertex3fvSUN( uint[] rc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4ubVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fSUN( uint rc, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4ubVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fvSUN( uint[] rc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor3fVertex3fSUN( uint rc, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor3fVertex3fvSUN( uint[] rc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fSUN( uint rc, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fvSUN( uint[] rc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fSUN( uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fvSUN( uint[] rc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fSUN( uint rc, float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fvSUN( uint[] rc, float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN( uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN( uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] c, float[] n, float[] v ); // 	
		public delegate void BlendFuncSeparateEXTDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method
		public static readonly BlendFuncSeparateEXTDelegate BlendFuncSeparateEXT;
		public delegate void BlendFuncSeparateINGRDelegate( uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha ); //  extension method
		public static readonly BlendFuncSeparateINGRDelegate BlendFuncSeparateINGR;
		public delegate void VertexWeightfEXTDelegate( float weight ); //  extension method
		public static readonly VertexWeightfEXTDelegate VertexWeightfEXT;
		public delegate void VertexWeightfvEXTDelegate( float[] weight ); //  extension method
		public static readonly VertexWeightfvEXTDelegate VertexWeightfvEXT;
		public unsafe delegate void VertexWeightPointerEXTDelegate( int size, uint type, int stride, void* pointer ); //  extension method
		public static readonly VertexWeightPointerEXTDelegate VertexWeightPointerEXT;
		public delegate void FlushVertexArrayRangeNVDelegate(  ); //  extension method
		public static readonly FlushVertexArrayRangeNVDelegate FlushVertexArrayRangeNV;
		public unsafe delegate void VertexArrayRangeNVDelegate( int length, void* pointer ); //  extension method
		public static readonly VertexArrayRangeNVDelegate VertexArrayRangeNV;
		public delegate void CombinerParameterfvNVDelegate( uint pname, float[] @params ); //  extension method
		public static readonly CombinerParameterfvNVDelegate CombinerParameterfvNV;
		public delegate void CombinerParameterfNVDelegate( uint pname, float param ); //  extension method
		public static readonly CombinerParameterfNVDelegate CombinerParameterfNV;
		public delegate void CombinerParameterivNVDelegate( uint pname, int[] @params ); //  extension method
		public static readonly CombinerParameterivNVDelegate CombinerParameterivNV;
		public delegate void CombinerParameteriNVDelegate( uint pname, int param ); //  extension method
		public static readonly CombinerParameteriNVDelegate CombinerParameteriNV;
		public delegate void CombinerInputNVDelegate( uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage ); //  extension method
		public static readonly CombinerInputNVDelegate CombinerInputNV;
		public delegate void CombinerOutputNVDelegate( uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum ); //  extension method
		public static readonly CombinerOutputNVDelegate CombinerOutputNV;
		public delegate void FinalCombinerInputNVDelegate( uint variable, uint input, uint mapping, uint componentUsage ); //  extension method
		public static readonly FinalCombinerInputNVDelegate FinalCombinerInputNV;
		public delegate void GetCombinerInputParameterfvNVDelegate( uint stage, uint portion, uint variable, uint pname, ref float[] @params ); //  extension method
		public static readonly GetCombinerInputParameterfvNVDelegate GetCombinerInputParameterfvNV;
		public delegate void GetCombinerInputParameterivNVDelegate( uint stage, uint portion, uint variable, uint pname, ref int[] @params ); //  extension method
		public static readonly GetCombinerInputParameterivNVDelegate GetCombinerInputParameterivNV;
		public delegate void GetCombinerOutputParameterfvNVDelegate( uint stage, uint portion, uint pname, ref float[] @params ); //  extension method
		public static readonly GetCombinerOutputParameterfvNVDelegate GetCombinerOutputParameterfvNV;
		public delegate void GetCombinerOutputParameterivNVDelegate( uint stage, uint portion, uint pname, ref int[] @params ); //  extension method
		public static readonly GetCombinerOutputParameterivNVDelegate GetCombinerOutputParameterivNV;
		public delegate void GetFinalCombinerInputParameterfvNVDelegate( uint variable, uint pname, ref float[] @params ); //  extension method
		public static readonly GetFinalCombinerInputParameterfvNVDelegate GetFinalCombinerInputParameterfvNV;
		public delegate void GetFinalCombinerInputParameterivNVDelegate( uint variable, uint pname, ref int[] @params ); //  extension method
		public static readonly GetFinalCombinerInputParameterivNVDelegate GetFinalCombinerInputParameterivNV;
		[DllImport( "opengl32.dll", EntryPoint="glResizeBuffersMESA" )]
		public static extern void ResizeBuffersMESA(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dMESA" )]
		public static extern void WindowPos2dMESA( double x, double y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2dvMESA" )]
		public static extern void WindowPos2dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fMESA" )]
		public static extern void WindowPos2fMESA( float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2fvMESA" )]
		public static extern void WindowPos2fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2iMESA" )]
		public static extern void WindowPos2iMESA( int x, int y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2ivMESA" )]
		public static extern void WindowPos2ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2sMESA" )]
		public static extern void WindowPos2sMESA( short x, short y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos2svMESA" )]
		public static extern void WindowPos2svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dMESA" )]
		public static extern void WindowPos3dMESA( double x, double y, double z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3dvMESA" )]
		public static extern void WindowPos3dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fMESA" )]
		public static extern void WindowPos3fMESA( float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3fvMESA" )]
		public static extern void WindowPos3fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3iMESA" )]
		public static extern void WindowPos3iMESA( int x, int y, int z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3ivMESA" )]
		public static extern void WindowPos3ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3sMESA" )]
		public static extern void WindowPos3sMESA( short x, short y, short z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos3svMESA" )]
		public static extern void WindowPos3svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4dMESA" )]
		public static extern void WindowPos4dMESA( double x, double y, double z, double w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4dvMESA" )]
		public static extern void WindowPos4dvMESA( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4fMESA" )]
		public static extern void WindowPos4fMESA( float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4fvMESA" )]
		public static extern void WindowPos4fvMESA( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4iMESA" )]
		public static extern void WindowPos4iMESA( int x, int y, int z, int w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4ivMESA" )]
		public static extern void WindowPos4ivMESA( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4sMESA" )]
		public static extern void WindowPos4sMESA( short x, short y, short z, short w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glWindowPos4svMESA" )]
		public static extern void WindowPos4svMESA( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultiModeDrawArraysIBM" )]
		public static extern void MultiModeDrawArraysIBM( BeginMode mode, int[] first, int[] count, int primcount, int modestride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glMultiModeDrawElementsIBM" )]
		public static extern unsafe void MultiModeDrawElementsIBM( BeginMode mode, int[] count, uint type, void** indices, int primcount, int modestride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColorPointerListIBM" )]
		public static extern unsafe void ColorPointerListIBM( int size, ColorPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSecondaryColorPointerListIBM" )]
		public static extern unsafe void SecondaryColorPointerListIBM( int size, uint type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glEdgeFlagPointerListIBM" )]
		public static extern unsafe void EdgeFlagPointerListIBM( int stride, bool*[] pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glFogCoordPointerListIBM" )]
		public static extern unsafe void FogCoordPointerListIBM( uint type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glIndexPointerListIBM" )]
		public static extern unsafe void IndexPointerListIBM( IndexPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormalPointerListIBM" )]
		public static extern unsafe void NormalPointerListIBM( NormalPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoordPointerListIBM" )]
		public static extern unsafe void TexCoordPointerListIBM( int size, TexCoordPointerType type, int stride, void** pointer, int ptrstride ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glVertexPointerListIBM" )]
		public static extern unsafe void VertexPointerListIBM( int size, VertexPointerType type, int stride, void** pointer, int ptrstride ); // 	
		public delegate void TbufferMask3DFXDelegate( uint mask ); // 
		public static readonly TbufferMask3DFXDelegate TbufferMask3DFX;
		public delegate void SampleMaskEXTDelegate( float value, bool invert ); //  extension method
		public static readonly SampleMaskEXTDelegate SampleMaskEXT;
		public delegate void SamplePatternEXTDelegate( uint pattern ); //  extension method
		public static readonly SamplePatternEXTDelegate SamplePatternEXT;
		public delegate void TextureColorMaskSGISDelegate( bool red, bool green, bool blue, bool alpha ); //  extension method
		public static readonly TextureColorMaskSGISDelegate TextureColorMaskSGIS;
		public unsafe delegate void IglooInterfaceSGIXDelegate( uint pname, void* @params ); //  extension method
		public static readonly IglooInterfaceSGIXDelegate IglooInterfaceSGIX;
		public delegate void DeleteFencesNVDelegate( int n, uint[] fences ); //  extension method
		public static readonly DeleteFencesNVDelegate DeleteFencesNV;
		public delegate void GenFencesNVDelegate( int n, ref uint[] fences ); //  extension method
		public static readonly GenFencesNVDelegate GenFencesNV;
		public delegate bool IsFenceNVDelegate( uint fence ); //  extension method
		public static readonly IsFenceNVDelegate IsFenceNV;
		public delegate bool TestFenceNVDelegate( uint fence ); //  extension method
		public static readonly TestFenceNVDelegate TestFenceNV;
		public delegate void GetFenceivNVDelegate( uint fence, uint pname, ref int[] @params ); //  extension method
		public static readonly GetFenceivNVDelegate GetFenceivNV;
		public delegate void FinishFenceNVDelegate( uint fence ); //  extension method
		public static readonly FinishFenceNVDelegate FinishFenceNV;
		public delegate void SetFenceNVDelegate( uint fence, uint condition ); //  extension method
		public static readonly SetFenceNVDelegate SetFenceNV;
		public unsafe delegate void MapControlPointsNVDelegate( uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points ); //  extension method
		public static readonly MapControlPointsNVDelegate MapControlPointsNV;
		public delegate void MapParameterivNVDelegate( uint target, uint pname, int[] @params ); //  extension method
		public static readonly MapParameterivNVDelegate MapParameterivNV;
		public delegate void MapParameterfvNVDelegate( uint target, uint pname, float[] @params ); //  extension method
		public static readonly MapParameterfvNVDelegate MapParameterfvNV;
		public unsafe delegate void GetMapControlPointsNVDelegate( uint target, uint index, uint type, int ustride, int vstride, bool packed, ref void* points ); //  extension method
		public static readonly GetMapControlPointsNVDelegate GetMapControlPointsNV;
		public delegate void GetMapParameterivNVDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetMapParameterivNVDelegate GetMapParameterivNV;
		public delegate void GetMapParameterfvNVDelegate( uint target, uint pname, ref float[] @params ); //  extension method
		public static readonly GetMapParameterfvNVDelegate GetMapParameterfvNV;
		public delegate void GetMapAttribParameterivNVDelegate( uint target, uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetMapAttribParameterivNVDelegate GetMapAttribParameterivNV;
		public delegate void GetMapAttribParameterfvNVDelegate( uint target, uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetMapAttribParameterfvNVDelegate GetMapAttribParameterfvNV;
		public delegate void EvalMapsNVDelegate( uint target, uint mode ); //  extension method
		public static readonly EvalMapsNVDelegate EvalMapsNV;
		public delegate void CombinerStageParameterfvNVDelegate( uint stage, uint pname, float[] @params ); //  extension method
		public static readonly CombinerStageParameterfvNVDelegate CombinerStageParameterfvNV;
		public delegate void GetCombinerStageParameterfvNVDelegate( uint stage, uint pname, ref float[] @params ); //  extension method
		public static readonly GetCombinerStageParameterfvNVDelegate GetCombinerStageParameterfvNV;
		public delegate bool AreProgramsResidentNVDelegate( int n, uint[] programs, ref bool[] residences ); //  extension method
		public static readonly AreProgramsResidentNVDelegate AreProgramsResidentNV;
		public delegate void BindProgramNVDelegate( uint target, uint id ); //  extension method
		public static readonly BindProgramNVDelegate BindProgramNV;
		public delegate void DeleteProgramsNVDelegate( int n, uint[] programs ); //  extension method
		public static readonly DeleteProgramsNVDelegate DeleteProgramsNV;
		public delegate void ExecuteProgramNVDelegate( uint target, uint id, float[] @params ); //  extension method
		public static readonly ExecuteProgramNVDelegate ExecuteProgramNV;
		public delegate void GenProgramsNVDelegate( int n, ref uint[] programs ); //  extension method
		public static readonly GenProgramsNVDelegate GenProgramsNV;
		public delegate void GetProgramParameterdvNVDelegate( uint target, uint index, uint pname, ref double[] @params ); //  extension method
		public static readonly GetProgramParameterdvNVDelegate GetProgramParameterdvNV;
		public delegate void GetProgramParameterfvNVDelegate( uint target, uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetProgramParameterfvNVDelegate GetProgramParameterfvNV;
		public delegate void GetProgramivNVDelegate( uint id, uint pname, ref int[] @params ); //  extension method
		public static readonly GetProgramivNVDelegate GetProgramivNV;
		public delegate void GetProgramStringNVDelegate( uint id, uint pname, ref byte[] program ); //  extension method
		public static readonly GetProgramStringNVDelegate GetProgramStringNV;
		public delegate void GetTrackMatrixivNVDelegate( uint target, uint address, uint pname, ref int[] @params ); //  extension method
		public static readonly GetTrackMatrixivNVDelegate GetTrackMatrixivNV;
		public delegate void GetVertexAttribdvNVDelegate( uint index, uint pname, ref double[] @params ); //  extension method
		public static readonly GetVertexAttribdvNVDelegate GetVertexAttribdvNV;
		public delegate void GetVertexAttribfvNVDelegate( uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetVertexAttribfvNVDelegate GetVertexAttribfvNV;
		public delegate void GetVertexAttribivNVDelegate( uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVertexAttribivNVDelegate GetVertexAttribivNV;
		public unsafe delegate void GetVertexAttribPointervNVDelegate( uint index, uint pname, ref void** pointer ); //  extension method
		public static readonly GetVertexAttribPointervNVDelegate GetVertexAttribPointervNV;
		public delegate bool IsProgramNVDelegate( uint id ); //  extension method
		public static readonly IsProgramNVDelegate IsProgramNV;
		public delegate void LoadProgramNVDelegate( uint target, uint id, int len, byte[] program ); //  extension method
		public static readonly LoadProgramNVDelegate LoadProgramNV;
		public delegate void ProgramParameter4dNVDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method
		public static readonly ProgramParameter4dNVDelegate ProgramParameter4dNV;
		public delegate void ProgramParameter4dvNVDelegate( uint target, uint index, double[] v ); //  extension method
		public static readonly ProgramParameter4dvNVDelegate ProgramParameter4dvNV;
		public delegate void ProgramParameter4fNVDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method
		public static readonly ProgramParameter4fNVDelegate ProgramParameter4fNV;
		public delegate void ProgramParameter4fvNVDelegate( uint target, uint index, float[] v ); //  extension method
		public static readonly ProgramParameter4fvNVDelegate ProgramParameter4fvNV;
		public delegate void ProgramParameters4dvNVDelegate( uint target, uint index, uint count, double[] v ); //  extension method
		public static readonly ProgramParameters4dvNVDelegate ProgramParameters4dvNV;
		public delegate void ProgramParameters4fvNVDelegate( uint target, uint index, uint count, float[] v ); //  extension method
		public static readonly ProgramParameters4fvNVDelegate ProgramParameters4fvNV;
		public delegate void RequestResidentProgramsNVDelegate( int n, uint[] programs ); //  extension method
		public static readonly RequestResidentProgramsNVDelegate RequestResidentProgramsNV;
		public delegate void TrackMatrixNVDelegate( uint target, uint address, uint matrix, uint transform ); //  extension method
		public static readonly TrackMatrixNVDelegate TrackMatrixNV;
		public unsafe delegate void VertexAttribPointerNVDelegate( uint index, int fsize, uint type, int stride, void* pointer ); //  extension method
		public static readonly VertexAttribPointerNVDelegate VertexAttribPointerNV;
		public delegate void VertexAttrib1dNVDelegate( uint index, double x ); //  extension method
		public static readonly VertexAttrib1dNVDelegate VertexAttrib1dNV;
		public delegate void VertexAttrib1dvNVDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib1dvNVDelegate VertexAttrib1dvNV;
		public delegate void VertexAttrib1fNVDelegate( uint index, float x ); //  extension method
		public static readonly VertexAttrib1fNVDelegate VertexAttrib1fNV;
		public delegate void VertexAttrib1fvNVDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib1fvNVDelegate VertexAttrib1fvNV;
		public delegate void VertexAttrib1sNVDelegate( uint index, short x ); //  extension method
		public static readonly VertexAttrib1sNVDelegate VertexAttrib1sNV;
		public delegate void VertexAttrib1svNVDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib1svNVDelegate VertexAttrib1svNV;
		public delegate void VertexAttrib2dNVDelegate( uint index, double x, double y ); //  extension method
		public static readonly VertexAttrib2dNVDelegate VertexAttrib2dNV;
		public delegate void VertexAttrib2dvNVDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib2dvNVDelegate VertexAttrib2dvNV;
		public delegate void VertexAttrib2fNVDelegate( uint index, float x, float y ); //  extension method
		public static readonly VertexAttrib2fNVDelegate VertexAttrib2fNV;
		public delegate void VertexAttrib2fvNVDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib2fvNVDelegate VertexAttrib2fvNV;
		public delegate void VertexAttrib2sNVDelegate( uint index, short x, short y ); //  extension method
		public static readonly VertexAttrib2sNVDelegate VertexAttrib2sNV;
		public delegate void VertexAttrib2svNVDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib2svNVDelegate VertexAttrib2svNV;
		public delegate void VertexAttrib3dNVDelegate( uint index, double x, double y, double z ); //  extension method
		public static readonly VertexAttrib3dNVDelegate VertexAttrib3dNV;
		public delegate void VertexAttrib3dvNVDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib3dvNVDelegate VertexAttrib3dvNV;
		public delegate void VertexAttrib3fNVDelegate( uint index, float x, float y, float z ); //  extension method
		public static readonly VertexAttrib3fNVDelegate VertexAttrib3fNV;
		public delegate void VertexAttrib3fvNVDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib3fvNVDelegate VertexAttrib3fvNV;
		public delegate void VertexAttrib3sNVDelegate( uint index, short x, short y, short z ); //  extension method
		public static readonly VertexAttrib3sNVDelegate VertexAttrib3sNV;
		public delegate void VertexAttrib3svNVDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib3svNVDelegate VertexAttrib3svNV;
		public delegate void VertexAttrib4dNVDelegate( uint index, double x, double y, double z, double w ); //  extension method
		public static readonly VertexAttrib4dNVDelegate VertexAttrib4dNV;
		public delegate void VertexAttrib4dvNVDelegate( uint index, double[] v ); //  extension method
		public static readonly VertexAttrib4dvNVDelegate VertexAttrib4dvNV;
		public delegate void VertexAttrib4fNVDelegate( uint index, float x, float y, float z, float w ); //  extension method
		public static readonly VertexAttrib4fNVDelegate VertexAttrib4fNV;
		public delegate void VertexAttrib4fvNVDelegate( uint index, float[] v ); //  extension method
		public static readonly VertexAttrib4fvNVDelegate VertexAttrib4fvNV;
		public delegate void VertexAttrib4sNVDelegate( uint index, short x, short y, short z, short w ); //  extension method
		public static readonly VertexAttrib4sNVDelegate VertexAttrib4sNV;
		public delegate void VertexAttrib4svNVDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttrib4svNVDelegate VertexAttrib4svNV;
		public delegate void VertexAttrib4ubNVDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method
		public static readonly VertexAttrib4ubNVDelegate VertexAttrib4ubNV;
		public delegate void VertexAttrib4ubvNVDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttrib4ubvNVDelegate VertexAttrib4ubvNV;
		public delegate void VertexAttribs1dvNVDelegate( uint index, int count, double[] v ); //  extension method
		public static readonly VertexAttribs1dvNVDelegate VertexAttribs1dvNV;
		public delegate void VertexAttribs1fvNVDelegate( uint index, int count, float[] v ); //  extension method
		public static readonly VertexAttribs1fvNVDelegate VertexAttribs1fvNV;
		public delegate void VertexAttribs1svNVDelegate( uint index, int count, short[] v ); //  extension method
		public static readonly VertexAttribs1svNVDelegate VertexAttribs1svNV;
		public delegate void VertexAttribs2dvNVDelegate( uint index, int count, double[] v ); //  extension method
		public static readonly VertexAttribs2dvNVDelegate VertexAttribs2dvNV;
		public delegate void VertexAttribs2fvNVDelegate( uint index, int count, float[] v ); //  extension method
		public static readonly VertexAttribs2fvNVDelegate VertexAttribs2fvNV;
		public delegate void VertexAttribs2svNVDelegate( uint index, int count, short[] v ); //  extension method
		public static readonly VertexAttribs2svNVDelegate VertexAttribs2svNV;
		public delegate void VertexAttribs3dvNVDelegate( uint index, int count, double[] v ); //  extension method
		public static readonly VertexAttribs3dvNVDelegate VertexAttribs3dvNV;
		public delegate void VertexAttribs3fvNVDelegate( uint index, int count, float[] v ); //  extension method
		public static readonly VertexAttribs3fvNVDelegate VertexAttribs3fvNV;
		public delegate void VertexAttribs3svNVDelegate( uint index, int count, short[] v ); //  extension method
		public static readonly VertexAttribs3svNVDelegate VertexAttribs3svNV;
		public delegate void VertexAttribs4dvNVDelegate( uint index, int count, double[] v ); //  extension method
		public static readonly VertexAttribs4dvNVDelegate VertexAttribs4dvNV;
		public delegate void VertexAttribs4fvNVDelegate( uint index, int count, float[] v ); //  extension method
		public static readonly VertexAttribs4fvNVDelegate VertexAttribs4fvNV;
		public delegate void VertexAttribs4svNVDelegate( uint index, int count, short[] v ); //  extension method
		public static readonly VertexAttribs4svNVDelegate VertexAttribs4svNV;
		public delegate void VertexAttribs4ubvNVDelegate( uint index, int count, byte[] v ); //  extension method
		public static readonly VertexAttribs4ubvNVDelegate VertexAttribs4ubvNV;
		public delegate void TexBumpParameterivATIDelegate( uint pname, int[] param ); //  extension method
		public static readonly TexBumpParameterivATIDelegate TexBumpParameterivATI;
		public delegate void TexBumpParameterfvATIDelegate( uint pname, float[] param ); //  extension method
		public static readonly TexBumpParameterfvATIDelegate TexBumpParameterfvATI;
		public delegate void GetTexBumpParameterivATIDelegate( uint pname, ref int[] param ); //  extension method
		public static readonly GetTexBumpParameterivATIDelegate GetTexBumpParameterivATI;
		public delegate void GetTexBumpParameterfvATIDelegate( uint pname, ref float[] param ); //  extension method
		public static readonly GetTexBumpParameterfvATIDelegate GetTexBumpParameterfvATI;
		public delegate uint GenFragmentShadersATIDelegate( uint range ); //  extension method
		public static readonly GenFragmentShadersATIDelegate GenFragmentShadersATI;
		public delegate void BindFragmentShaderATIDelegate( uint id ); //  extension method
		public static readonly BindFragmentShaderATIDelegate BindFragmentShaderATI;
		public delegate void DeleteFragmentShaderATIDelegate( uint id ); //  extension method
		public static readonly DeleteFragmentShaderATIDelegate DeleteFragmentShaderATI;
		public delegate void BeginFragmentShaderATIDelegate(  ); //  extension method
		public static readonly BeginFragmentShaderATIDelegate BeginFragmentShaderATI;
		public delegate void EndFragmentShaderATIDelegate(  ); //  extension method
		public static readonly EndFragmentShaderATIDelegate EndFragmentShaderATI;
		public delegate void PassTexCoordATIDelegate( uint dst, uint coord, uint swizzle ); //  extension method
		public static readonly PassTexCoordATIDelegate PassTexCoordATI;
		public delegate void SampleMapATIDelegate( uint dst, uint interp, uint swizzle ); //  extension method
		public static readonly SampleMapATIDelegate SampleMapATI;
		public delegate void ColorFragmentOp1ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method
		public static readonly ColorFragmentOp1ATIDelegate ColorFragmentOp1ATI;
		public delegate void ColorFragmentOp2ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method
		public static readonly ColorFragmentOp2ATIDelegate ColorFragmentOp2ATI;
		public delegate void ColorFragmentOp3ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method
		public static readonly ColorFragmentOp3ATIDelegate ColorFragmentOp3ATI;
		public delegate void AlphaFragmentOp1ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method
		public static readonly AlphaFragmentOp1ATIDelegate AlphaFragmentOp1ATI;
		public delegate void AlphaFragmentOp2ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method
		public static readonly AlphaFragmentOp2ATIDelegate AlphaFragmentOp2ATI;
		public delegate void AlphaFragmentOp3ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method
		public static readonly AlphaFragmentOp3ATIDelegate AlphaFragmentOp3ATI;
		public delegate void SetFragmentShaderConstantATIDelegate( uint dst, float[] value ); //  extension method
		public static readonly SetFragmentShaderConstantATIDelegate SetFragmentShaderConstantATI;
		public delegate void PNTrianglesiATIDelegate( uint pname, int param ); //  extension method
		public static readonly PNTrianglesiATIDelegate PNTrianglesiATI;
		public delegate void PNTrianglesfATIDelegate( uint pname, float param ); //  extension method
		public static readonly PNTrianglesfATIDelegate PNTrianglesfATI;
		public unsafe delegate uint NewObjectBufferATIDelegate( int size, void* pointer, uint usage ); //  extension method
		public static readonly NewObjectBufferATIDelegate NewObjectBufferATI;
		public delegate bool IsObjectBufferATIDelegate( uint buffer ); //  extension method
		public static readonly IsObjectBufferATIDelegate IsObjectBufferATI;
		public unsafe delegate void UpdateObjectBufferATIDelegate( uint buffer, uint offset, int size, void* pointer, uint preserve ); //  extension method
		public static readonly UpdateObjectBufferATIDelegate UpdateObjectBufferATI;
		public delegate void GetObjectBufferfvATIDelegate( uint buffer, uint pname, ref float[] @params ); //  extension method
		public static readonly GetObjectBufferfvATIDelegate GetObjectBufferfvATI;
		public delegate void GetObjectBufferivATIDelegate( uint buffer, uint pname, ref int[] @params ); //  extension method
		public static readonly GetObjectBufferivATIDelegate GetObjectBufferivATI;
		public delegate void FreeObjectBufferATIDelegate( uint buffer ); //  extension method
		public static readonly FreeObjectBufferATIDelegate FreeObjectBufferATI;
		public delegate void ArrayObjectATIDelegate( EnableCap array, int size, uint type, int stride, uint buffer, uint offset ); //  extension method
		public static readonly ArrayObjectATIDelegate ArrayObjectATI;
		public delegate void GetArrayObjectfvATIDelegate( EnableCap array, uint pname, ref float[] @params ); //  extension method
		public static readonly GetArrayObjectfvATIDelegate GetArrayObjectfvATI;
		public delegate void GetArrayObjectivATIDelegate( EnableCap array, uint pname, ref int[] @params ); //  extension method
		public static readonly GetArrayObjectivATIDelegate GetArrayObjectivATI;
		public delegate void VariantArrayObjectATIDelegate( uint id, uint type, int stride, uint buffer, uint offset ); //  extension method
		public static readonly VariantArrayObjectATIDelegate VariantArrayObjectATI;
		public delegate void GetVariantArrayObjectfvATIDelegate( uint id, uint pname, ref float[] @params ); //  extension method
		public static readonly GetVariantArrayObjectfvATIDelegate GetVariantArrayObjectfvATI;
		public delegate void GetVariantArrayObjectivATIDelegate( uint id, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVariantArrayObjectivATIDelegate GetVariantArrayObjectivATI;
		public delegate void BeginVertexShaderEXTDelegate(  ); //  extension method
		public static readonly BeginVertexShaderEXTDelegate BeginVertexShaderEXT;
		public delegate void EndVertexShaderEXTDelegate(  ); //  extension method
		public static readonly EndVertexShaderEXTDelegate EndVertexShaderEXT;
		public delegate void BindVertexShaderEXTDelegate( uint id ); //  extension method
		public static readonly BindVertexShaderEXTDelegate BindVertexShaderEXT;
		public delegate uint GenVertexShadersEXTDelegate( uint range ); //  extension method
		public static readonly GenVertexShadersEXTDelegate GenVertexShadersEXT;
		public delegate void DeleteVertexShaderEXTDelegate( uint id ); //  extension method
		public static readonly DeleteVertexShaderEXTDelegate DeleteVertexShaderEXT;
		public delegate void ShaderOp1EXTDelegate( uint op, uint res, uint arg1 ); //  extension method
		public static readonly ShaderOp1EXTDelegate ShaderOp1EXT;
		public delegate void ShaderOp2EXTDelegate( uint op, uint res, uint arg1, uint arg2 ); //  extension method
		public static readonly ShaderOp2EXTDelegate ShaderOp2EXT;
		public delegate void ShaderOp3EXTDelegate( uint op, uint res, uint arg1, uint arg2, uint arg3 ); //  extension method
		public static readonly ShaderOp3EXTDelegate ShaderOp3EXT;
		public delegate void SwizzleEXTDelegate( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method
		public static readonly SwizzleEXTDelegate SwizzleEXT;
		public delegate void WriteMaskEXTDelegate( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method
		public static readonly WriteMaskEXTDelegate WriteMaskEXT;
		public delegate void InsertComponentEXTDelegate( uint res, uint src, uint num ); //  extension method
		public static readonly InsertComponentEXTDelegate InsertComponentEXT;
		public delegate void ExtractComponentEXTDelegate( uint res, uint src, uint num ); //  extension method
		public static readonly ExtractComponentEXTDelegate ExtractComponentEXT;
		public delegate uint GenSymbolsEXTDelegate( uint datatype, uint storagetype, uint range, uint components ); //  extension method
		public static readonly GenSymbolsEXTDelegate GenSymbolsEXT;
		public unsafe delegate void SetInvariantEXTDelegate( uint id, uint type, void* addr ); //  extension method
		public static readonly SetInvariantEXTDelegate SetInvariantEXT;
		public unsafe delegate void SetLocalConstantEXTDelegate( uint id, uint type, void* addr ); //  extension method
		public static readonly SetLocalConstantEXTDelegate SetLocalConstantEXT;
		public delegate void VariantbvEXTDelegate( uint id, sbyte[] addr ); //  extension method
		public static readonly VariantbvEXTDelegate VariantbvEXT;
		public delegate void VariantsvEXTDelegate( uint id, short[] addr ); //  extension method
		public static readonly VariantsvEXTDelegate VariantsvEXT;
		public delegate void VariantivEXTDelegate( uint id, int[] addr ); //  extension method
		public static readonly VariantivEXTDelegate VariantivEXT;
		public delegate void VariantfvEXTDelegate( uint id, float[] addr ); //  extension method
		public static readonly VariantfvEXTDelegate VariantfvEXT;
		public delegate void VariantdvEXTDelegate( uint id, double[] addr ); //  extension method
		public static readonly VariantdvEXTDelegate VariantdvEXT;
		public delegate void VariantubvEXTDelegate( uint id, byte[] addr ); //  extension method
		public static readonly VariantubvEXTDelegate VariantubvEXT;
		public delegate void VariantusvEXTDelegate( uint id, ushort[] addr ); //  extension method
		public static readonly VariantusvEXTDelegate VariantusvEXT;
		public delegate void VariantuivEXTDelegate( uint id, uint[] addr ); //  extension method
		public static readonly VariantuivEXTDelegate VariantuivEXT;
		public unsafe delegate void VariantPointerEXTDelegate( uint id, uint type, uint stride, void* addr ); //  extension method
		public static readonly VariantPointerEXTDelegate VariantPointerEXT;
		public delegate void EnableVariantClientStateEXTDelegate( uint id ); //  extension method
		public static readonly EnableVariantClientStateEXTDelegate EnableVariantClientStateEXT;
		public delegate void DisableVariantClientStateEXTDelegate( uint id ); //  extension method
		public static readonly DisableVariantClientStateEXTDelegate DisableVariantClientStateEXT;
		public delegate uint BindLightParameterEXTDelegate( LightName light, LightParameter value ); //  extension method
		public static readonly BindLightParameterEXTDelegate BindLightParameterEXT;
		public delegate uint BindMaterialParameterEXTDelegate( MaterialFace face, MaterialParameter value ); //  extension method
		public static readonly BindMaterialParameterEXTDelegate BindMaterialParameterEXT;
		public delegate uint BindTexGenParameterEXTDelegate( uint unit, TextureCoordName coord, TextureGenParameter value ); //  extension method
		public static readonly BindTexGenParameterEXTDelegate BindTexGenParameterEXT;
		public delegate uint BindTextureUnitParameterEXTDelegate( uint unit, uint value ); //  extension method
		public static readonly BindTextureUnitParameterEXTDelegate BindTextureUnitParameterEXT;
		public delegate uint BindParameterEXTDelegate( uint value ); //  extension method
		public static readonly BindParameterEXTDelegate BindParameterEXT;
		public delegate bool IsVariantEnabledEXTDelegate( uint id, uint cap ); //  extension method
		public static readonly IsVariantEnabledEXTDelegate IsVariantEnabledEXT;
		public delegate void GetVariantBooleanvEXTDelegate( uint id, uint value, ref bool[] data ); //  extension method
		public static readonly GetVariantBooleanvEXTDelegate GetVariantBooleanvEXT;
		public delegate void GetVariantIntegervEXTDelegate( uint id, uint value, ref int[] data ); //  extension method
		public static readonly GetVariantIntegervEXTDelegate GetVariantIntegervEXT;
		public delegate void GetVariantFloatvEXTDelegate( uint id, uint value, ref float[] data ); //  extension method
		public static readonly GetVariantFloatvEXTDelegate GetVariantFloatvEXT;
		public unsafe delegate void GetVariantPointervEXTDelegate( uint id, uint value, ref void** data ); //  extension method
		public static readonly GetVariantPointervEXTDelegate GetVariantPointervEXT;
		public delegate void GetInvariantBooleanvEXTDelegate( uint id, uint value, ref bool[] data ); //  extension method
		public static readonly GetInvariantBooleanvEXTDelegate GetInvariantBooleanvEXT;
		public delegate void GetInvariantIntegervEXTDelegate( uint id, uint value, ref int[] data ); //  extension method
		public static readonly GetInvariantIntegervEXTDelegate GetInvariantIntegervEXT;
		public delegate void GetInvariantFloatvEXTDelegate( uint id, uint value, ref float[] data ); //  extension method
		public static readonly GetInvariantFloatvEXTDelegate GetInvariantFloatvEXT;
		public delegate void GetLocalConstantBooleanvEXTDelegate( uint id, uint value, ref bool[] data ); //  extension method
		public static readonly GetLocalConstantBooleanvEXTDelegate GetLocalConstantBooleanvEXT;
		public delegate void GetLocalConstantIntegervEXTDelegate( uint id, uint value, ref int[] data ); //  extension method
		public static readonly GetLocalConstantIntegervEXTDelegate GetLocalConstantIntegervEXT;
		public delegate void GetLocalConstantFloatvEXTDelegate( uint id, uint value, ref float[] data ); //  extension method
		public static readonly GetLocalConstantFloatvEXTDelegate GetLocalConstantFloatvEXT;
		public delegate void VertexStream1sATIDelegate( uint stream, short x ); //  extension method
		public static readonly VertexStream1sATIDelegate VertexStream1sATI;
		public delegate void VertexStream1svATIDelegate( uint stream, short[] coords ); //  extension method
		public static readonly VertexStream1svATIDelegate VertexStream1svATI;
		public delegate void VertexStream1iATIDelegate( uint stream, int x ); //  extension method
		public static readonly VertexStream1iATIDelegate VertexStream1iATI;
		public delegate void VertexStream1ivATIDelegate( uint stream, int[] coords ); //  extension method
		public static readonly VertexStream1ivATIDelegate VertexStream1ivATI;
		public delegate void VertexStream1fATIDelegate( uint stream, float x ); //  extension method
		public static readonly VertexStream1fATIDelegate VertexStream1fATI;
		public delegate void VertexStream1fvATIDelegate( uint stream, float[] coords ); //  extension method
		public static readonly VertexStream1fvATIDelegate VertexStream1fvATI;
		public delegate void VertexStream1dATIDelegate( uint stream, double x ); //  extension method
		public static readonly VertexStream1dATIDelegate VertexStream1dATI;
		public delegate void VertexStream1dvATIDelegate( uint stream, double[] coords ); //  extension method
		public static readonly VertexStream1dvATIDelegate VertexStream1dvATI;
		public delegate void VertexStream2sATIDelegate( uint stream, short x, short y ); //  extension method
		public static readonly VertexStream2sATIDelegate VertexStream2sATI;
		public delegate void VertexStream2svATIDelegate( uint stream, short[] coords ); //  extension method
		public static readonly VertexStream2svATIDelegate VertexStream2svATI;
		public delegate void VertexStream2iATIDelegate( uint stream, int x, int y ); //  extension method
		public static readonly VertexStream2iATIDelegate VertexStream2iATI;
		public delegate void VertexStream2ivATIDelegate( uint stream, int[] coords ); //  extension method
		public static readonly VertexStream2ivATIDelegate VertexStream2ivATI;
		public delegate void VertexStream2fATIDelegate( uint stream, float x, float y ); //  extension method
		public static readonly VertexStream2fATIDelegate VertexStream2fATI;
		public delegate void VertexStream2fvATIDelegate( uint stream, float[] coords ); //  extension method
		public static readonly VertexStream2fvATIDelegate VertexStream2fvATI;
		public delegate void VertexStream2dATIDelegate( uint stream, double x, double y ); //  extension method
		public static readonly VertexStream2dATIDelegate VertexStream2dATI;
		public delegate void VertexStream2dvATIDelegate( uint stream, double[] coords ); //  extension method
		public static readonly VertexStream2dvATIDelegate VertexStream2dvATI;
		public delegate void VertexStream3sATIDelegate( uint stream, short x, short y, short z ); //  extension method
		public static readonly VertexStream3sATIDelegate VertexStream3sATI;
		public delegate void VertexStream3svATIDelegate( uint stream, short[] coords ); //  extension method
		public static readonly VertexStream3svATIDelegate VertexStream3svATI;
		public delegate void VertexStream3iATIDelegate( uint stream, int x, int y, int z ); //  extension method
		public static readonly VertexStream3iATIDelegate VertexStream3iATI;
		public delegate void VertexStream3ivATIDelegate( uint stream, int[] coords ); //  extension method
		public static readonly VertexStream3ivATIDelegate VertexStream3ivATI;
		public delegate void VertexStream3fATIDelegate( uint stream, float x, float y, float z ); //  extension method
		public static readonly VertexStream3fATIDelegate VertexStream3fATI;
		public delegate void VertexStream3fvATIDelegate( uint stream, float[] coords ); //  extension method
		public static readonly VertexStream3fvATIDelegate VertexStream3fvATI;
		public delegate void VertexStream3dATIDelegate( uint stream, double x, double y, double z ); //  extension method
		public static readonly VertexStream3dATIDelegate VertexStream3dATI;
		public delegate void VertexStream3dvATIDelegate( uint stream, double[] coords ); //  extension method
		public static readonly VertexStream3dvATIDelegate VertexStream3dvATI;
		public delegate void VertexStream4sATIDelegate( uint stream, short x, short y, short z, short w ); //  extension method
		public static readonly VertexStream4sATIDelegate VertexStream4sATI;
		public delegate void VertexStream4svATIDelegate( uint stream, short[] coords ); //  extension method
		public static readonly VertexStream4svATIDelegate VertexStream4svATI;
		public delegate void VertexStream4iATIDelegate( uint stream, int x, int y, int z, int w ); //  extension method
		public static readonly VertexStream4iATIDelegate VertexStream4iATI;
		public delegate void VertexStream4ivATIDelegate( uint stream, int[] coords ); //  extension method
		public static readonly VertexStream4ivATIDelegate VertexStream4ivATI;
		public delegate void VertexStream4fATIDelegate( uint stream, float x, float y, float z, float w ); //  extension method
		public static readonly VertexStream4fATIDelegate VertexStream4fATI;
		public delegate void VertexStream4fvATIDelegate( uint stream, float[] coords ); //  extension method
		public static readonly VertexStream4fvATIDelegate VertexStream4fvATI;
		public delegate void VertexStream4dATIDelegate( uint stream, double x, double y, double z, double w ); //  extension method
		public static readonly VertexStream4dATIDelegate VertexStream4dATI;
		public delegate void VertexStream4dvATIDelegate( uint stream, double[] coords ); //  extension method
		public static readonly VertexStream4dvATIDelegate VertexStream4dvATI;
		public delegate void NormalStream3bATIDelegate( uint stream, sbyte nx, sbyte ny, sbyte nz ); //  extension method
		public static readonly NormalStream3bATIDelegate NormalStream3bATI;
		public delegate void NormalStream3bvATIDelegate( uint stream, sbyte[] coords ); //  extension method
		public static readonly NormalStream3bvATIDelegate NormalStream3bvATI;
		public delegate void NormalStream3sATIDelegate( uint stream, short nx, short ny, short nz ); //  extension method
		public static readonly NormalStream3sATIDelegate NormalStream3sATI;
		public delegate void NormalStream3svATIDelegate( uint stream, short[] coords ); //  extension method
		public static readonly NormalStream3svATIDelegate NormalStream3svATI;
		public delegate void NormalStream3iATIDelegate( uint stream, int nx, int ny, int nz ); //  extension method
		public static readonly NormalStream3iATIDelegate NormalStream3iATI;
		public delegate void NormalStream3ivATIDelegate( uint stream, int[] coords ); //  extension method
		public static readonly NormalStream3ivATIDelegate NormalStream3ivATI;
		public delegate void NormalStream3fATIDelegate( uint stream, float nx, float ny, float nz ); //  extension method
		public static readonly NormalStream3fATIDelegate NormalStream3fATI;
		public delegate void NormalStream3fvATIDelegate( uint stream, float[] coords ); //  extension method
		public static readonly NormalStream3fvATIDelegate NormalStream3fvATI;
		public delegate void NormalStream3dATIDelegate( uint stream, double nx, double ny, double nz ); //  extension method
		public static readonly NormalStream3dATIDelegate NormalStream3dATI;
		public delegate void NormalStream3dvATIDelegate( uint stream, double[] coords ); //  extension method
		public static readonly NormalStream3dvATIDelegate NormalStream3dvATI;
		public delegate void ClientActiveVertexStreamATIDelegate( uint stream ); //  extension method
		public static readonly ClientActiveVertexStreamATIDelegate ClientActiveVertexStreamATI;
		public delegate void VertexBlendEnviATIDelegate( uint pname, int param ); //  extension method
		public static readonly VertexBlendEnviATIDelegate VertexBlendEnviATI;
		public delegate void VertexBlendEnvfATIDelegate( uint pname, float param ); //  extension method
		public static readonly VertexBlendEnvfATIDelegate VertexBlendEnvfATI;
		public unsafe delegate void ElementPointerATIDelegate( uint type, void* pointer ); // 
		public static readonly ElementPointerATIDelegate ElementPointerATI;
		public delegate void DrawElementArrayATIDelegate( BeginMode mode, int count ); // 
		public static readonly DrawElementArrayATIDelegate DrawElementArrayATI;
		public delegate void DrawRangeElementArrayATIDelegate( BeginMode mode, uint start, uint end, int count ); // 
		public static readonly DrawRangeElementArrayATIDelegate DrawRangeElementArrayATI;
		[DllImport( "opengl32.dll", EntryPoint="glDrawMeshArraysSUN" )]
		public static extern void DrawMeshArraysSUN( BeginMode mode, int first, int count, int width ); // 	
		public delegate void GenOcclusionQueriesNVDelegate( int n, ref uint[] ids ); //  extension method
		public static readonly GenOcclusionQueriesNVDelegate GenOcclusionQueriesNV;
		public delegate void DeleteOcclusionQueriesNVDelegate( int n, uint[] ids ); //  extension method
		public static readonly DeleteOcclusionQueriesNVDelegate DeleteOcclusionQueriesNV;
		public delegate bool IsOcclusionQueryNVDelegate( uint id ); //  extension method
		public static readonly IsOcclusionQueryNVDelegate IsOcclusionQueryNV;
		public delegate void BeginOcclusionQueryNVDelegate( uint id ); //  extension method
		public static readonly BeginOcclusionQueryNVDelegate BeginOcclusionQueryNV;
		public delegate void EndOcclusionQueryNVDelegate(  ); //  extension method
		public static readonly EndOcclusionQueryNVDelegate EndOcclusionQueryNV;
		public delegate void GetOcclusionQueryivNVDelegate( uint id, uint pname, ref int[] @params ); //  extension method
		public static readonly GetOcclusionQueryivNVDelegate GetOcclusionQueryivNV;
		public delegate void GetOcclusionQueryuivNVDelegate( uint id, uint pname, ref uint[] @params ); //  extension method
		public static readonly GetOcclusionQueryuivNVDelegate GetOcclusionQueryuivNV;
		public delegate void PointParameteriNVDelegate( uint pname, int param ); //  extension method
		public static readonly PointParameteriNVDelegate PointParameteriNV;
		public delegate void PointParameterivNVDelegate( uint pname, int[] @params ); //  extension method
		public static readonly PointParameterivNVDelegate PointParameterivNV;
		public delegate void ActiveStencilFaceEXTDelegate( uint face ); // 
		public static readonly ActiveStencilFaceEXTDelegate ActiveStencilFaceEXT;
		public unsafe delegate void ElementPointerAPPLEDelegate( uint type, void* pointer ); //  extension method
		public static readonly ElementPointerAPPLEDelegate ElementPointerAPPLE;
		public delegate void DrawElementArrayAPPLEDelegate( BeginMode mode, int first, int count ); //  extension method
		public static readonly DrawElementArrayAPPLEDelegate DrawElementArrayAPPLE;
		public delegate void DrawRangeElementArrayAPPLEDelegate( BeginMode mode, uint start, uint end, int first, int count ); //  extension method
		public static readonly DrawRangeElementArrayAPPLEDelegate DrawRangeElementArrayAPPLE;
		public delegate void MultiDrawElementArrayAPPLEDelegate( BeginMode mode, int[] first, int[] count, int primcount ); //  extension method
		public static readonly MultiDrawElementArrayAPPLEDelegate MultiDrawElementArrayAPPLE;
		public delegate void MultiDrawRangeElementArrayAPPLEDelegate( BeginMode mode, uint start, uint end, int[] first, int[] count, int primcount ); //  extension method
		public static readonly MultiDrawRangeElementArrayAPPLEDelegate MultiDrawRangeElementArrayAPPLE;
		public delegate void GenFencesAPPLEDelegate( int n, ref uint[] fences ); //  extension method
		public static readonly GenFencesAPPLEDelegate GenFencesAPPLE;
		public delegate void DeleteFencesAPPLEDelegate( int n, uint[] fences ); //  extension method
		public static readonly DeleteFencesAPPLEDelegate DeleteFencesAPPLE;
		public delegate void SetFenceAPPLEDelegate( uint fence ); //  extension method
		public static readonly SetFenceAPPLEDelegate SetFenceAPPLE;
		public delegate bool IsFenceAPPLEDelegate( uint fence ); //  extension method
		public static readonly IsFenceAPPLEDelegate IsFenceAPPLE;
		public delegate bool TestFenceAPPLEDelegate( uint fence ); //  extension method
		public static readonly TestFenceAPPLEDelegate TestFenceAPPLE;
		public delegate void FinishFenceAPPLEDelegate( uint fence ); //  extension method
		public static readonly FinishFenceAPPLEDelegate FinishFenceAPPLE;
		public delegate bool TestObjectAPPLEDelegate( uint @object, uint name ); //  extension method
		public static readonly TestObjectAPPLEDelegate TestObjectAPPLE;
		public delegate void FinishObjectAPPLEDelegate( uint @object, int name ); //  extension method
		public static readonly FinishObjectAPPLEDelegate FinishObjectAPPLE;
		public delegate void BindVertexArrayAPPLEDelegate( uint array ); //  extension method
		public static readonly BindVertexArrayAPPLEDelegate BindVertexArrayAPPLE;
		public delegate void DeleteVertexArraysAPPLEDelegate( int n, uint[] arrays ); //  extension method
		public static readonly DeleteVertexArraysAPPLEDelegate DeleteVertexArraysAPPLE;
		public delegate void GenVertexArraysAPPLEDelegate( int n, ref uint[] arrays ); //  extension method
		public static readonly GenVertexArraysAPPLEDelegate GenVertexArraysAPPLE;
		public delegate bool IsVertexArrayAPPLEDelegate( uint array ); //  extension method
		public static readonly IsVertexArrayAPPLEDelegate IsVertexArrayAPPLE;
		public unsafe delegate void VertexArrayRangeAPPLEDelegate( int length, ref void* pointer ); //  extension method
		public static readonly VertexArrayRangeAPPLEDelegate VertexArrayRangeAPPLE;
		public unsafe delegate void FlushVertexArrayRangeAPPLEDelegate( int length, ref void* pointer ); //  extension method
		public static readonly FlushVertexArrayRangeAPPLEDelegate FlushVertexArrayRangeAPPLE;
		public delegate void VertexArrayParameteriAPPLEDelegate( uint pname, int param ); //  extension method
		public static readonly VertexArrayParameteriAPPLEDelegate VertexArrayParameteriAPPLE;
		public delegate void DrawBuffersATIDelegate( int n, uint[] bufs ); //  extension method
		public static readonly DrawBuffersATIDelegate DrawBuffersATI;
		public delegate void ProgramNamedParameter4fNVDelegate( uint id, int len, byte[] name, float x, float y, float z, float w ); //  extension method
		public static readonly ProgramNamedParameter4fNVDelegate ProgramNamedParameter4fNV;
		public delegate void ProgramNamedParameter4dNVDelegate( uint id, int len, byte[] name, double x, double y, double z, double w ); //  extension method
		public static readonly ProgramNamedParameter4dNVDelegate ProgramNamedParameter4dNV;
		public delegate void ProgramNamedParameter4fvNVDelegate( uint id, int len, byte[] name, float[] v ); //  extension method
		public static readonly ProgramNamedParameter4fvNVDelegate ProgramNamedParameter4fvNV;
		public delegate void ProgramNamedParameter4dvNVDelegate( uint id, int len, byte[] name, double[] v ); //  extension method
		public static readonly ProgramNamedParameter4dvNVDelegate ProgramNamedParameter4dvNV;
		public delegate void GetProgramNamedParameterfvNVDelegate( uint id, int len, byte[] name, ref float[] @params ); //  extension method
		public static readonly GetProgramNamedParameterfvNVDelegate GetProgramNamedParameterfvNV;
		public delegate void GetProgramNamedParameterdvNVDelegate( uint id, int len, byte[] name, ref double[] @params ); //  extension method
		public static readonly GetProgramNamedParameterdvNVDelegate GetProgramNamedParameterdvNV;
		public delegate void Vertex2hNVDelegate( ushort x, ushort y ); //  extension method
		public static readonly Vertex2hNVDelegate Vertex2hNV;
		public delegate void Vertex2hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Vertex2hvNVDelegate Vertex2hvNV;
		public delegate void Vertex3hNVDelegate( ushort x, ushort y, ushort z ); //  extension method
		public static readonly Vertex3hNVDelegate Vertex3hNV;
		public delegate void Vertex3hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Vertex3hvNVDelegate Vertex3hvNV;
		public delegate void Vertex4hNVDelegate( ushort x, ushort y, ushort z, ushort w ); //  extension method
		public static readonly Vertex4hNVDelegate Vertex4hNV;
		public delegate void Vertex4hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Vertex4hvNVDelegate Vertex4hvNV;
		public delegate void Normal3hNVDelegate( ushort nx, ushort ny, ushort nz ); //  extension method
		public static readonly Normal3hNVDelegate Normal3hNV;
		public delegate void Normal3hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Normal3hvNVDelegate Normal3hvNV;
		public delegate void Color3hNVDelegate( ushort red, ushort green, ushort blue ); //  extension method
		public static readonly Color3hNVDelegate Color3hNV;
		public delegate void Color3hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Color3hvNVDelegate Color3hvNV;
		public delegate void Color4hNVDelegate( ushort red, ushort green, ushort blue, ushort alpha ); //  extension method
		public static readonly Color4hNVDelegate Color4hNV;
		public delegate void Color4hvNVDelegate( ushort[] v ); //  extension method
		public static readonly Color4hvNVDelegate Color4hvNV;
		public delegate void TexCoord1hNVDelegate( ushort s ); //  extension method
		public static readonly TexCoord1hNVDelegate TexCoord1hNV;
		public delegate void TexCoord1hvNVDelegate( ushort[] v ); //  extension method
		public static readonly TexCoord1hvNVDelegate TexCoord1hvNV;
		public delegate void TexCoord2hNVDelegate( ushort s, ushort t ); //  extension method
		public static readonly TexCoord2hNVDelegate TexCoord2hNV;
		public delegate void TexCoord2hvNVDelegate( ushort[] v ); //  extension method
		public static readonly TexCoord2hvNVDelegate TexCoord2hvNV;
		public delegate void TexCoord3hNVDelegate( ushort s, ushort t, ushort r ); //  extension method
		public static readonly TexCoord3hNVDelegate TexCoord3hNV;
		public delegate void TexCoord3hvNVDelegate( ushort[] v ); //  extension method
		public static readonly TexCoord3hvNVDelegate TexCoord3hvNV;
		public delegate void TexCoord4hNVDelegate( ushort s, ushort t, ushort r, ushort q ); //  extension method
		public static readonly TexCoord4hNVDelegate TexCoord4hNV;
		public delegate void TexCoord4hvNVDelegate( ushort[] v ); //  extension method
		public static readonly TexCoord4hvNVDelegate TexCoord4hvNV;
		public delegate void MultiTexCoord1hNVDelegate( uint target, ushort s ); //  extension method
		public static readonly MultiTexCoord1hNVDelegate MultiTexCoord1hNV;
		public delegate void MultiTexCoord1hvNVDelegate( uint target, ushort[] v ); //  extension method
		public static readonly MultiTexCoord1hvNVDelegate MultiTexCoord1hvNV;
		public delegate void MultiTexCoord2hNVDelegate( uint target, ushort s, ushort t ); //  extension method
		public static readonly MultiTexCoord2hNVDelegate MultiTexCoord2hNV;
		public delegate void MultiTexCoord2hvNVDelegate( uint target, ushort[] v ); //  extension method
		public static readonly MultiTexCoord2hvNVDelegate MultiTexCoord2hvNV;
		public delegate void MultiTexCoord3hNVDelegate( uint target, ushort s, ushort t, ushort r ); //  extension method
		public static readonly MultiTexCoord3hNVDelegate MultiTexCoord3hNV;
		public delegate void MultiTexCoord3hvNVDelegate( uint target, ushort[] v ); //  extension method
		public static readonly MultiTexCoord3hvNVDelegate MultiTexCoord3hvNV;
		public delegate void MultiTexCoord4hNVDelegate( uint target, ushort s, ushort t, ushort r, ushort q ); //  extension method
		public static readonly MultiTexCoord4hNVDelegate MultiTexCoord4hNV;
		public delegate void MultiTexCoord4hvNVDelegate( uint target, ushort[] v ); //  extension method
		public static readonly MultiTexCoord4hvNVDelegate MultiTexCoord4hvNV;
		public delegate void FogCoordhNVDelegate( ushort fog ); //  extension method
		public static readonly FogCoordhNVDelegate FogCoordhNV;
		public delegate void FogCoordhvNVDelegate( ushort[] fog ); //  extension method
		public static readonly FogCoordhvNVDelegate FogCoordhvNV;
		public delegate void SecondaryColor3hNVDelegate( ushort red, ushort green, ushort blue ); //  extension method
		public static readonly SecondaryColor3hNVDelegate SecondaryColor3hNV;
		public delegate void SecondaryColor3hvNVDelegate( ushort[] v ); //  extension method
		public static readonly SecondaryColor3hvNVDelegate SecondaryColor3hvNV;
		public delegate void VertexWeighthNVDelegate( ushort weight ); //  extension method
		public static readonly VertexWeighthNVDelegate VertexWeighthNV;
		public delegate void VertexWeighthvNVDelegate( ushort[] weight ); //  extension method
		public static readonly VertexWeighthvNVDelegate VertexWeighthvNV;
		public delegate void VertexAttrib1hNVDelegate( uint index, ushort x ); //  extension method
		public static readonly VertexAttrib1hNVDelegate VertexAttrib1hNV;
		public delegate void VertexAttrib1hvNVDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib1hvNVDelegate VertexAttrib1hvNV;
		public delegate void VertexAttrib2hNVDelegate( uint index, ushort x, ushort y ); //  extension method
		public static readonly VertexAttrib2hNVDelegate VertexAttrib2hNV;
		public delegate void VertexAttrib2hvNVDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib2hvNVDelegate VertexAttrib2hvNV;
		public delegate void VertexAttrib3hNVDelegate( uint index, ushort x, ushort y, ushort z ); //  extension method
		public static readonly VertexAttrib3hNVDelegate VertexAttrib3hNV;
		public delegate void VertexAttrib3hvNVDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib3hvNVDelegate VertexAttrib3hvNV;
		public delegate void VertexAttrib4hNVDelegate( uint index, ushort x, ushort y, ushort z, ushort w ); //  extension method
		public static readonly VertexAttrib4hNVDelegate VertexAttrib4hNV;
		public delegate void VertexAttrib4hvNVDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttrib4hvNVDelegate VertexAttrib4hvNV;
		public delegate void VertexAttribs1hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		public static readonly VertexAttribs1hvNVDelegate VertexAttribs1hvNV;
		public delegate void VertexAttribs2hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		public static readonly VertexAttribs2hvNVDelegate VertexAttribs2hvNV;
		public delegate void VertexAttribs3hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		public static readonly VertexAttribs3hvNVDelegate VertexAttribs3hvNV;
		public delegate void VertexAttribs4hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		public static readonly VertexAttribs4hvNVDelegate VertexAttribs4hvNV;
		public unsafe delegate void PixelDataRangeNVDelegate( uint target, int length, ref void* pointer ); //  extension method
		public static readonly PixelDataRangeNVDelegate PixelDataRangeNV;
		public delegate void FlushPixelDataRangeNVDelegate( uint target ); //  extension method
		public static readonly FlushPixelDataRangeNVDelegate FlushPixelDataRangeNV;
		public delegate void PrimitiveRestartNVDelegate(  ); //  extension method
		public static readonly PrimitiveRestartNVDelegate PrimitiveRestartNV;
		public delegate void PrimitiveRestartIndexNVDelegate( uint index ); //  extension method
		public static readonly PrimitiveRestartIndexNVDelegate PrimitiveRestartIndexNV;
		public delegate void MapObjectBufferATIDelegate( uint buffer ); //  extension method
		public static readonly MapObjectBufferATIDelegate MapObjectBufferATI;
		public delegate void UnmapObjectBufferATIDelegate( uint buffer ); //  extension method
		public static readonly UnmapObjectBufferATIDelegate UnmapObjectBufferATI;
		public delegate void StencilOpSeparateATIDelegate( uint face, StencilOp sfail, StencilOp dpfail, StencilOp dppass ); //  extension method
		public static readonly StencilOpSeparateATIDelegate StencilOpSeparateATI;
		public delegate void StencilFuncSeparateATIDelegate( StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask ); //  extension method
		public static readonly StencilFuncSeparateATIDelegate StencilFuncSeparateATI;
		public delegate void VertexAttribArrayObjectATIDelegate( uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset ); //  extension method
		public static readonly VertexAttribArrayObjectATIDelegate VertexAttribArrayObjectATI;
		public delegate void GetVertexAttribArrayObjectfvATIDelegate( uint index, uint pname, ref float[] @params ); //  extension method
		public static readonly GetVertexAttribArrayObjectfvATIDelegate GetVertexAttribArrayObjectfvATI;
		public delegate void GetVertexAttribArrayObjectivATIDelegate( uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVertexAttribArrayObjectivATIDelegate GetVertexAttribArrayObjectivATI;
		public delegate void DepthBoundsEXTDelegate( double zmin, double zmax ); //  extension method
		public static readonly DepthBoundsEXTDelegate DepthBoundsEXT;
		public delegate void BlendEquationSeparateEXTDelegate( BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha ); //  extension method
		public static readonly BlendEquationSeparateEXTDelegate BlendEquationSeparateEXT;
		public delegate bool IsRenderbufferEXTDelegate( uint renderbuffer ); //  extension method
		public static readonly IsRenderbufferEXTDelegate IsRenderbufferEXT;
		public delegate void BindRenderbufferEXTDelegate( uint target, uint renderbuffer ); //  extension method
		public static readonly BindRenderbufferEXTDelegate BindRenderbufferEXT;
		public delegate void DeleteRenderbuffersEXTDelegate( int n, uint[] renderbuffers ); //  extension method
		public static readonly DeleteRenderbuffersEXTDelegate DeleteRenderbuffersEXT;
		public delegate void GenRenderbuffersEXTDelegate( int n, ref uint[] renderbuffers ); //  extension method
		public static readonly GenRenderbuffersEXTDelegate GenRenderbuffersEXT;
		public delegate void RenderbufferStorageEXTDelegate( uint target, uint internalformat, int width, int height ); //  extension method
		public static readonly RenderbufferStorageEXTDelegate RenderbufferStorageEXT;
		public delegate void GetRenderbufferParameterivEXTDelegate( uint target, uint pname, ref int[] @params ); //  extension method
		public static readonly GetRenderbufferParameterivEXTDelegate GetRenderbufferParameterivEXT;
		public delegate bool IsFramebufferEXTDelegate( uint framebuffer ); //  extension method
		public static readonly IsFramebufferEXTDelegate IsFramebufferEXT;
		public delegate void BindFramebufferEXTDelegate( uint target, uint framebuffer ); //  extension method
		public static readonly BindFramebufferEXTDelegate BindFramebufferEXT;
		public delegate void DeleteFramebuffersEXTDelegate( int n, uint[] framebuffers ); //  extension method
		public static readonly DeleteFramebuffersEXTDelegate DeleteFramebuffersEXT;
		public delegate void GenFramebuffersEXTDelegate( int n, ref uint[] framebuffers ); //  extension method
		public static readonly GenFramebuffersEXTDelegate GenFramebuffersEXT;
		public delegate uint CheckFramebufferStatusEXTDelegate( uint target ); //  extension method
		public static readonly CheckFramebufferStatusEXTDelegate CheckFramebufferStatusEXT;
		public delegate void FramebufferTexture1DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method
		public static readonly FramebufferTexture1DEXTDelegate FramebufferTexture1DEXT;
		public delegate void FramebufferTexture2DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method
		public static readonly FramebufferTexture2DEXTDelegate FramebufferTexture2DEXT;
		public delegate void FramebufferTexture3DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level, int zoffset ); //  extension method
		public static readonly FramebufferTexture3DEXTDelegate FramebufferTexture3DEXT;
		public delegate void FramebufferRenderbufferEXTDelegate( uint target, uint attachment, uint renderbuffertarget, uint renderbuffer ); //  extension method
		public static readonly FramebufferRenderbufferEXTDelegate FramebufferRenderbufferEXT;
		public delegate void GetFramebufferAttachmentParameterivEXTDelegate( uint target, uint attachment, uint pname, ref int[] @params ); //  extension method
		public static readonly GetFramebufferAttachmentParameterivEXTDelegate GetFramebufferAttachmentParameterivEXT;
		public delegate void GenerateMipmapEXTDelegate( uint target ); //  extension method
		public static readonly GenerateMipmapEXTDelegate GenerateMipmapEXT;
		public unsafe delegate void StringMarkerGREMEDYDelegate( int len, void* @string ); //  extension method
		public static readonly StringMarkerGREMEDYDelegate StringMarkerGREMEDY;
		public delegate void StencilClearTagEXTDelegate( int stencilTagBits, uint stencilClearTag ); //  extension method
		public static readonly StencilClearTagEXTDelegate StencilClearTagEXT;
		public delegate void BlitFramebufferEXTDelegate( int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter ); // 
		public static readonly BlitFramebufferEXTDelegate BlitFramebufferEXT;
		public delegate void RenderbufferStorageMultisampleEXTDelegate( uint target, int samples, uint internalformat, int width, int height ); // 
		public static readonly RenderbufferStorageMultisampleEXTDelegate RenderbufferStorageMultisampleEXT;
		public delegate void GetQueryObjecti64vEXTDelegate( uint id, uint pname, ref long[] @params ); // 
		public static readonly GetQueryObjecti64vEXTDelegate GetQueryObjecti64vEXT;
		public delegate void GetQueryObjectui64vEXTDelegate( uint id, uint pname, ref ulong[] @params ); // 
		public static readonly GetQueryObjectui64vEXTDelegate GetQueryObjectui64vEXT;
		public delegate void ProgramEnvParameters4fvEXTDelegate( uint target, uint index, int count, float[] @params ); // 
		public static readonly ProgramEnvParameters4fvEXTDelegate ProgramEnvParameters4fvEXT;
		public delegate void ProgramLocalParameters4fvEXTDelegate( uint target, uint index, int count, float[] @params ); // 
		public static readonly ProgramLocalParameters4fvEXTDelegate ProgramLocalParameters4fvEXT;
		public delegate void BufferParameteriAPPLEDelegate( uint target, uint pname, int param ); //  extension method
		public static readonly BufferParameteriAPPLEDelegate BufferParameteriAPPLE;
		public delegate void FlushMappedBufferRangeAPPLEDelegate( uint target, int offset, int size ); //  extension method
		public static readonly FlushMappedBufferRangeAPPLEDelegate FlushMappedBufferRangeAPPLE;
		public delegate void ProgramLocalParameterI4iNVDelegate( uint target, uint index, int x, int y, int z, int w ); //  extension method
		public static readonly ProgramLocalParameterI4iNVDelegate ProgramLocalParameterI4iNV;
		public delegate void ProgramLocalParameterI4ivNVDelegate( uint target, uint index, int[] @params ); //  extension method
		public static readonly ProgramLocalParameterI4ivNVDelegate ProgramLocalParameterI4ivNV;
		public delegate void ProgramLocalParametersI4ivNVDelegate( uint target, uint index, int count, int[] @params ); //  extension method
		public static readonly ProgramLocalParametersI4ivNVDelegate ProgramLocalParametersI4ivNV;
		public delegate void ProgramLocalParameterI4uiNVDelegate( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method
		public static readonly ProgramLocalParameterI4uiNVDelegate ProgramLocalParameterI4uiNV;
		public delegate void ProgramLocalParameterI4uivNVDelegate( uint target, uint index, uint[] @params ); //  extension method
		public static readonly ProgramLocalParameterI4uivNVDelegate ProgramLocalParameterI4uivNV;
		public delegate void ProgramLocalParametersI4uivNVDelegate( uint target, uint index, int count, uint[] @params ); //  extension method
		public static readonly ProgramLocalParametersI4uivNVDelegate ProgramLocalParametersI4uivNV;
		public delegate void ProgramEnvParameterI4iNVDelegate( uint target, uint index, int x, int y, int z, int w ); //  extension method
		public static readonly ProgramEnvParameterI4iNVDelegate ProgramEnvParameterI4iNV;
		public delegate void ProgramEnvParameterI4ivNVDelegate( uint target, uint index, int[] @params ); //  extension method
		public static readonly ProgramEnvParameterI4ivNVDelegate ProgramEnvParameterI4ivNV;
		public delegate void ProgramEnvParametersI4ivNVDelegate( uint target, uint index, int count, int[] @params ); //  extension method
		public static readonly ProgramEnvParametersI4ivNVDelegate ProgramEnvParametersI4ivNV;
		public delegate void ProgramEnvParameterI4uiNVDelegate( uint target, uint index, uint x, uint y, uint z, uint w ); //  extension method
		public static readonly ProgramEnvParameterI4uiNVDelegate ProgramEnvParameterI4uiNV;
		public delegate void ProgramEnvParameterI4uivNVDelegate( uint target, uint index, uint[] @params ); //  extension method
		public static readonly ProgramEnvParameterI4uivNVDelegate ProgramEnvParameterI4uivNV;
		public delegate void ProgramEnvParametersI4uivNVDelegate( uint target, uint index, int count, uint[] @params ); //  extension method
		public static readonly ProgramEnvParametersI4uivNVDelegate ProgramEnvParametersI4uivNV;
		public delegate void GetProgramLocalParameterIivNVDelegate( uint target, uint index, ref int[] @params ); //  extension method
		public static readonly GetProgramLocalParameterIivNVDelegate GetProgramLocalParameterIivNV;
		public delegate void GetProgramLocalParameterIuivNVDelegate( uint target, uint index, ref uint[] @params ); //  extension method
		public static readonly GetProgramLocalParameterIuivNVDelegate GetProgramLocalParameterIuivNV;
		public delegate void GetProgramEnvParameterIivNVDelegate( uint target, uint index, ref int[] @params ); //  extension method
		public static readonly GetProgramEnvParameterIivNVDelegate GetProgramEnvParameterIivNV;
		public delegate void GetProgramEnvParameterIuivNVDelegate( uint target, uint index, ref uint[] @params ); //  extension method
		public static readonly GetProgramEnvParameterIuivNVDelegate GetProgramEnvParameterIuivNV;
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
		public delegate void VertexAttribI1iEXTDelegate( uint index, int x ); //  extension method
		public static readonly VertexAttribI1iEXTDelegate VertexAttribI1iEXT;
		public delegate void VertexAttribI2iEXTDelegate( uint index, int x, int y ); //  extension method
		public static readonly VertexAttribI2iEXTDelegate VertexAttribI2iEXT;
		public delegate void VertexAttribI3iEXTDelegate( uint index, int x, int y, int z ); //  extension method
		public static readonly VertexAttribI3iEXTDelegate VertexAttribI3iEXT;
		public delegate void VertexAttribI4iEXTDelegate( uint index, int x, int y, int z, int w ); //  extension method
		public static readonly VertexAttribI4iEXTDelegate VertexAttribI4iEXT;
		public delegate void VertexAttribI1uiEXTDelegate( uint index, uint x ); //  extension method
		public static readonly VertexAttribI1uiEXTDelegate VertexAttribI1uiEXT;
		public delegate void VertexAttribI2uiEXTDelegate( uint index, uint x, uint y ); //  extension method
		public static readonly VertexAttribI2uiEXTDelegate VertexAttribI2uiEXT;
		public delegate void VertexAttribI3uiEXTDelegate( uint index, uint x, uint y, uint z ); //  extension method
		public static readonly VertexAttribI3uiEXTDelegate VertexAttribI3uiEXT;
		public delegate void VertexAttribI4uiEXTDelegate( uint index, uint x, uint y, uint z, uint w ); //  extension method
		public static readonly VertexAttribI4uiEXTDelegate VertexAttribI4uiEXT;
		public delegate void VertexAttribI1ivEXTDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttribI1ivEXTDelegate VertexAttribI1ivEXT;
		public delegate void VertexAttribI2ivEXTDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttribI2ivEXTDelegate VertexAttribI2ivEXT;
		public delegate void VertexAttribI3ivEXTDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttribI3ivEXTDelegate VertexAttribI3ivEXT;
		public delegate void VertexAttribI4ivEXTDelegate( uint index, int[] v ); //  extension method
		public static readonly VertexAttribI4ivEXTDelegate VertexAttribI4ivEXT;
		public delegate void VertexAttribI1uivEXTDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttribI1uivEXTDelegate VertexAttribI1uivEXT;
		public delegate void VertexAttribI2uivEXTDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttribI2uivEXTDelegate VertexAttribI2uivEXT;
		public delegate void VertexAttribI3uivEXTDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttribI3uivEXTDelegate VertexAttribI3uivEXT;
		public delegate void VertexAttribI4uivEXTDelegate( uint index, uint[] v ); //  extension method
		public static readonly VertexAttribI4uivEXTDelegate VertexAttribI4uivEXT;
		public delegate void VertexAttribI4bvEXTDelegate( uint index, sbyte[] v ); //  extension method
		public static readonly VertexAttribI4bvEXTDelegate VertexAttribI4bvEXT;
		public delegate void VertexAttribI4svEXTDelegate( uint index, short[] v ); //  extension method
		public static readonly VertexAttribI4svEXTDelegate VertexAttribI4svEXT;
		public delegate void VertexAttribI4ubvEXTDelegate( uint index, byte[] v ); //  extension method
		public static readonly VertexAttribI4ubvEXTDelegate VertexAttribI4ubvEXT;
		public delegate void VertexAttribI4usvEXTDelegate( uint index, ushort[] v ); //  extension method
		public static readonly VertexAttribI4usvEXTDelegate VertexAttribI4usvEXT;
		public unsafe delegate void VertexAttribIPointerEXTDelegate( uint index, int size, uint type, int stride, void* pointer ); //  extension method
		public static readonly VertexAttribIPointerEXTDelegate VertexAttribIPointerEXT;
		public delegate void GetVertexAttribIivEXTDelegate( uint index, uint pname, ref int[] @params ); //  extension method
		public static readonly GetVertexAttribIivEXTDelegate GetVertexAttribIivEXT;
		public delegate void GetVertexAttribIuivEXTDelegate( uint index, uint pname, ref uint[] @params ); //  extension method
		public static readonly GetVertexAttribIuivEXTDelegate GetVertexAttribIuivEXT;
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
		public delegate void RenderbufferStorageMultisampleCoverageNVDelegate( uint target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height ); //  extension method
		public static readonly RenderbufferStorageMultisampleCoverageNVDelegate RenderbufferStorageMultisampleCoverageNV;
		public delegate void ProgramBufferParametersfvNVDelegate( uint target, uint buffer, uint index, int count, float[] @params ); //  extension method
		public static readonly ProgramBufferParametersfvNVDelegate ProgramBufferParametersfvNV;
		public delegate void ProgramBufferParametersIivNVDelegate( uint target, uint buffer, uint index, int count, int[] @params ); //  extension method
		public static readonly ProgramBufferParametersIivNVDelegate ProgramBufferParametersIivNV;
		public delegate void ProgramBufferParametersIuivNVDelegate( uint target, uint buffer, uint index, int count, uint[] @params ); //  extension method
		public static readonly ProgramBufferParametersIuivNVDelegate ProgramBufferParametersIuivNV;
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
		public delegate void BeginTransformFeedbackNVDelegate( uint primitiveMode ); //  extension method
		public static readonly BeginTransformFeedbackNVDelegate BeginTransformFeedbackNV;
		public delegate void EndTransformFeedbackNVDelegate(  ); //  extension method
		public static readonly EndTransformFeedbackNVDelegate EndTransformFeedbackNV;
		public delegate void TransformFeedbackAttribsNVDelegate( uint count, int[] attribs, uint bufferMode ); //  extension method
		public static readonly TransformFeedbackAttribsNVDelegate TransformFeedbackAttribsNV;
		public delegate void BindBufferRangeNVDelegate( uint target, uint index, uint buffer, int offset, int size ); //  extension method
		public static readonly BindBufferRangeNVDelegate BindBufferRangeNV;
		public delegate void BindBufferOffsetNVDelegate( uint target, uint index, uint buffer, int offset ); //  extension method
		public static readonly BindBufferOffsetNVDelegate BindBufferOffsetNV;
		public delegate void BindBufferBaseNVDelegate( uint target, uint index, uint buffer ); //  extension method
		public static readonly BindBufferBaseNVDelegate BindBufferBaseNV;
		public delegate void TransformFeedbackVaryingsNVDelegate( uint program, int count, int[] locations, uint bufferMode ); //  extension method
		public static readonly TransformFeedbackVaryingsNVDelegate TransformFeedbackVaryingsNV;
		public delegate void ActiveVaryingNVDelegate( uint program, string[] name ); //  extension method
		public static readonly ActiveVaryingNVDelegate ActiveVaryingNV;
		public delegate int GetVaryingLocationNVDelegate( uint program, string[] name ); //  extension method
		public static readonly GetVaryingLocationNVDelegate GetVaryingLocationNV;
		public delegate void GetActiveVaryingNVDelegate( uint program, uint index, int bufSize, ref int[] length, ref int[] size, ref uint[] type, ref string[] name ); //  extension method
		public static readonly GetActiveVaryingNVDelegate GetActiveVaryingNV;
		public delegate void GetTransformFeedbackVaryingNVDelegate( uint program, uint index, ref int[] location ); //  extension method
		public static readonly GetTransformFeedbackVaryingNVDelegate GetTransformFeedbackVaryingNV;
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
		public delegate void FrameTerminatorGREMEDYDelegate(  ); //  extension method
		public static readonly FrameTerminatorGREMEDYDelegate FrameTerminatorGREMEDY;
	}
}

