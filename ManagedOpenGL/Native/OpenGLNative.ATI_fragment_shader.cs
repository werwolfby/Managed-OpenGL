using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_fragment_shaderInit()
		{
			_GenFragmentShadersATI = GetProcAdress< GenFragmentShadersATIDelegate >( "glGenFragmentShadersATI" );
			_BindFragmentShaderATI = GetProcAdress< BindFragmentShaderATIDelegate >( "glBindFragmentShaderATI" );
			_DeleteFragmentShaderATI = GetProcAdress< DeleteFragmentShaderATIDelegate >( "glDeleteFragmentShaderATI" );
			_BeginFragmentShaderATI = GetProcAdress< BeginFragmentShaderATIDelegate >( "glBeginFragmentShaderATI" );
			_EndFragmentShaderATI = GetProcAdress< EndFragmentShaderATIDelegate >( "glEndFragmentShaderATI" );
			_PassTexCoordATI = GetProcAdress< PassTexCoordATIDelegate >( "glPassTexCoordATI" );
			_SampleMapATI = GetProcAdress< SampleMapATIDelegate >( "glSampleMapATI" );
			_ColorFragmentOp1ATI = GetProcAdress< ColorFragmentOp1ATIDelegate >( "glColorFragmentOp1ATI" );
			_ColorFragmentOp2ATI = GetProcAdress< ColorFragmentOp2ATIDelegate >( "glColorFragmentOp2ATI" );
			_ColorFragmentOp3ATI = GetProcAdress< ColorFragmentOp3ATIDelegate >( "glColorFragmentOp3ATI" );
			_AlphaFragmentOp1ATI = GetProcAdress< AlphaFragmentOp1ATIDelegate >( "glAlphaFragmentOp1ATI" );
			_AlphaFragmentOp2ATI = GetProcAdress< AlphaFragmentOp2ATIDelegate >( "glAlphaFragmentOp2ATI" );
			_AlphaFragmentOp3ATI = GetProcAdress< AlphaFragmentOp3ATIDelegate >( "glAlphaFragmentOp3ATI" );
			_SetFragmentShaderConstantATI = GetProcAdress< SetFragmentShaderConstantATIDelegate >( "glSetFragmentShaderConstantATI" );
		}


		public delegate uint GenFragmentShadersATIDelegate( uint range ); //  extension method

		private static GenFragmentShadersATIDelegate _GenFragmentShadersATI;

		public static  uint GenFragmentShadersATI( uint range )
		{
			if (_GenFragmentShadersATI == null) throw new Exception( "Extension method GenFragmentShadersATI not found" );
		return  _GenFragmentShadersATI( range );
		}
		public delegate void BindFragmentShaderATIDelegate( uint id ); //  extension method

		private static BindFragmentShaderATIDelegate _BindFragmentShaderATI;

		public static  void BindFragmentShaderATI( uint id )
		{
			if (_BindFragmentShaderATI == null) throw new Exception( "Extension method BindFragmentShaderATI not found" );
		 _BindFragmentShaderATI( id );
		}
		public delegate void DeleteFragmentShaderATIDelegate( uint id ); //  extension method

		private static DeleteFragmentShaderATIDelegate _DeleteFragmentShaderATI;

		public static  void DeleteFragmentShaderATI( uint id )
		{
			if (_DeleteFragmentShaderATI == null) throw new Exception( "Extension method DeleteFragmentShaderATI not found" );
		 _DeleteFragmentShaderATI( id );
		}
		public delegate void BeginFragmentShaderATIDelegate(  ); //  extension method

		private static BeginFragmentShaderATIDelegate _BeginFragmentShaderATI;

		public static  void BeginFragmentShaderATI(  )
		{
			if (_BeginFragmentShaderATI == null) throw new Exception( "Extension method BeginFragmentShaderATI not found" );
		 _BeginFragmentShaderATI(  );
		}
		public delegate void EndFragmentShaderATIDelegate(  ); //  extension method

		private static EndFragmentShaderATIDelegate _EndFragmentShaderATI;

		public static  void EndFragmentShaderATI(  )
		{
			if (_EndFragmentShaderATI == null) throw new Exception( "Extension method EndFragmentShaderATI not found" );
		 _EndFragmentShaderATI(  );
		}
		public delegate void PassTexCoordATIDelegate( uint dst, uint coord, uint swizzle ); //  extension method

		private static PassTexCoordATIDelegate _PassTexCoordATI;

		public static  void PassTexCoordATI( uint dst, uint coord, uint swizzle )
		{
			if (_PassTexCoordATI == null) throw new Exception( "Extension method PassTexCoordATI not found" );
		 _PassTexCoordATI( dst, coord, swizzle );
		}
		public delegate void SampleMapATIDelegate( uint dst, uint interp, uint swizzle ); //  extension method

		private static SampleMapATIDelegate _SampleMapATI;

		public static  void SampleMapATI( uint dst, uint interp, uint swizzle )
		{
			if (_SampleMapATI == null) throw new Exception( "Extension method SampleMapATI not found" );
		 _SampleMapATI( dst, interp, swizzle );
		}
		public delegate void ColorFragmentOp1ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method

		private static ColorFragmentOp1ATIDelegate _ColorFragmentOp1ATI;

		public static  void ColorFragmentOp1ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod )
		{
			if (_ColorFragmentOp1ATI == null) throw new Exception( "Extension method ColorFragmentOp1ATI not found" );
		 _ColorFragmentOp1ATI( op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod );
		}
		public delegate void ColorFragmentOp2ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method

		private static ColorFragmentOp2ATIDelegate _ColorFragmentOp2ATI;

		public static  void ColorFragmentOp2ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod )
		{
			if (_ColorFragmentOp2ATI == null) throw new Exception( "Extension method ColorFragmentOp2ATI not found" );
		 _ColorFragmentOp2ATI( op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod );
		}
		public delegate void ColorFragmentOp3ATIDelegate( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method

		private static ColorFragmentOp3ATIDelegate _ColorFragmentOp3ATI;

		public static  void ColorFragmentOp3ATI( uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod )
		{
			if (_ColorFragmentOp3ATI == null) throw new Exception( "Extension method ColorFragmentOp3ATI not found" );
		 _ColorFragmentOp3ATI( op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod );
		}
		public delegate void AlphaFragmentOp1ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod ); //  extension method

		private static AlphaFragmentOp1ATIDelegate _AlphaFragmentOp1ATI;

		public static  void AlphaFragmentOp1ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod )
		{
			if (_AlphaFragmentOp1ATI == null) throw new Exception( "Extension method AlphaFragmentOp1ATI not found" );
		 _AlphaFragmentOp1ATI( op, dst, dstMod, arg1, arg1Rep, arg1Mod );
		}
		public delegate void AlphaFragmentOp2ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod ); //  extension method

		private static AlphaFragmentOp2ATIDelegate _AlphaFragmentOp2ATI;

		public static  void AlphaFragmentOp2ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod )
		{
			if (_AlphaFragmentOp2ATI == null) throw new Exception( "Extension method AlphaFragmentOp2ATI not found" );
		 _AlphaFragmentOp2ATI( op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod );
		}
		public delegate void AlphaFragmentOp3ATIDelegate( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod ); //  extension method

		private static AlphaFragmentOp3ATIDelegate _AlphaFragmentOp3ATI;

		public static  void AlphaFragmentOp3ATI( uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod )
		{
			if (_AlphaFragmentOp3ATI == null) throw new Exception( "Extension method AlphaFragmentOp3ATI not found" );
		 _AlphaFragmentOp3ATI( op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod );
		}
		public delegate void SetFragmentShaderConstantATIDelegate( uint dst, float[] value ); //  extension method

		private static SetFragmentShaderConstantATIDelegate _SetFragmentShaderConstantATI;

		public static  void SetFragmentShaderConstantATI( uint dst, float[] value )
		{
			if (_SetFragmentShaderConstantATI == null) throw new Exception( "Extension method SetFragmentShaderConstantATI not found" );
		 _SetFragmentShaderConstantATI( dst, value );
		}
	}
}
