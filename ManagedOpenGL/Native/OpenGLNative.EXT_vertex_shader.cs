using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_vertex_shaderInit()
		{
			_BeginVertexShaderEXT = GetProcAdress< BeginVertexShaderEXTDelegate >( "glBeginVertexShaderEXT" );
			_EndVertexShaderEXT = GetProcAdress< EndVertexShaderEXTDelegate >( "glEndVertexShaderEXT" );
			_BindVertexShaderEXT = GetProcAdress< BindVertexShaderEXTDelegate >( "glBindVertexShaderEXT" );
			_GenVertexShadersEXT = GetProcAdress< GenVertexShadersEXTDelegate >( "glGenVertexShadersEXT" );
			_DeleteVertexShaderEXT = GetProcAdress< DeleteVertexShaderEXTDelegate >( "glDeleteVertexShaderEXT" );
			_ShaderOp1EXT = GetProcAdress< ShaderOp1EXTDelegate >( "glShaderOp1EXT" );
			_ShaderOp2EXT = GetProcAdress< ShaderOp2EXTDelegate >( "glShaderOp2EXT" );
			_ShaderOp3EXT = GetProcAdress< ShaderOp3EXTDelegate >( "glShaderOp3EXT" );
			_SwizzleEXT = GetProcAdress< SwizzleEXTDelegate >( "glSwizzleEXT" );
			_WriteMaskEXT = GetProcAdress< WriteMaskEXTDelegate >( "glWriteMaskEXT" );
			_InsertComponentEXT = GetProcAdress< InsertComponentEXTDelegate >( "glInsertComponentEXT" );
			_ExtractComponentEXT = GetProcAdress< ExtractComponentEXTDelegate >( "glExtractComponentEXT" );
			_GenSymbolsEXT = GetProcAdress< GenSymbolsEXTDelegate >( "glGenSymbolsEXT" );
			_SetInvariantEXT = GetProcAdress< SetInvariantEXTDelegate >( "glSetInvariantEXT" );
			_SetLocalConstantEXT = GetProcAdress< SetLocalConstantEXTDelegate >( "glSetLocalConstantEXT" );
			_VariantbvEXT = GetProcAdress< VariantbvEXTDelegate >( "glVariantbvEXT" );
			_VariantsvEXT = GetProcAdress< VariantsvEXTDelegate >( "glVariantsvEXT" );
			_VariantivEXT = GetProcAdress< VariantivEXTDelegate >( "glVariantivEXT" );
			_VariantfvEXT = GetProcAdress< VariantfvEXTDelegate >( "glVariantfvEXT" );
			_VariantdvEXT = GetProcAdress< VariantdvEXTDelegate >( "glVariantdvEXT" );
			_VariantubvEXT = GetProcAdress< VariantubvEXTDelegate >( "glVariantubvEXT" );
			_VariantusvEXT = GetProcAdress< VariantusvEXTDelegate >( "glVariantusvEXT" );
			_VariantuivEXT = GetProcAdress< VariantuivEXTDelegate >( "glVariantuivEXT" );
			_VariantPointerEXT = GetProcAdress< VariantPointerEXTDelegate >( "glVariantPointerEXT" );
			_EnableVariantClientStateEXT = GetProcAdress< EnableVariantClientStateEXTDelegate >( "glEnableVariantClientStateEXT" );
			_DisableVariantClientStateEXT = GetProcAdress< DisableVariantClientStateEXTDelegate >( "glDisableVariantClientStateEXT" );
			_BindLightParameterEXT = GetProcAdress< BindLightParameterEXTDelegate >( "glBindLightParameterEXT" );
			_BindMaterialParameterEXT = GetProcAdress< BindMaterialParameterEXTDelegate >( "glBindMaterialParameterEXT" );
			_BindTexGenParameterEXT = GetProcAdress< BindTexGenParameterEXTDelegate >( "glBindTexGenParameterEXT" );
			_BindTextureUnitParameterEXT = GetProcAdress< BindTextureUnitParameterEXTDelegate >( "glBindTextureUnitParameterEXT" );
			_BindParameterEXT = GetProcAdress< BindParameterEXTDelegate >( "glBindParameterEXT" );
			_IsVariantEnabledEXT = GetProcAdress< IsVariantEnabledEXTDelegate >( "glIsVariantEnabledEXT" );
			_GetVariantBooleanvEXT = GetProcAdress< GetVariantBooleanvEXTDelegate >( "glGetVariantBooleanvEXT" );
			_GetVariantIntegervEXT = GetProcAdress< GetVariantIntegervEXTDelegate >( "glGetVariantIntegervEXT" );
			_GetVariantFloatvEXT = GetProcAdress< GetVariantFloatvEXTDelegate >( "glGetVariantFloatvEXT" );
			_GetVariantPointervEXT = GetProcAdress< GetVariantPointervEXTDelegate >( "glGetVariantPointervEXT" );
			_GetInvariantBooleanvEXT = GetProcAdress< GetInvariantBooleanvEXTDelegate >( "glGetInvariantBooleanvEXT" );
			_GetInvariantIntegervEXT = GetProcAdress< GetInvariantIntegervEXTDelegate >( "glGetInvariantIntegervEXT" );
			_GetInvariantFloatvEXT = GetProcAdress< GetInvariantFloatvEXTDelegate >( "glGetInvariantFloatvEXT" );
			_GetLocalConstantBooleanvEXT = GetProcAdress< GetLocalConstantBooleanvEXTDelegate >( "glGetLocalConstantBooleanvEXT" );
			_GetLocalConstantIntegervEXT = GetProcAdress< GetLocalConstantIntegervEXTDelegate >( "glGetLocalConstantIntegervEXT" );
			_GetLocalConstantFloatvEXT = GetProcAdress< GetLocalConstantFloatvEXTDelegate >( "glGetLocalConstantFloatvEXT" );
		}


		public delegate void BeginVertexShaderEXTDelegate(  ); //  extension method

		private static BeginVertexShaderEXTDelegate _BeginVertexShaderEXT;

		public static  void BeginVertexShaderEXT(  )
		{
			if (_BeginVertexShaderEXT == null) throw new Exception( "Extension method BeginVertexShaderEXT not found" );
		 _BeginVertexShaderEXT(  );
		}
		public delegate void EndVertexShaderEXTDelegate(  ); //  extension method

		private static EndVertexShaderEXTDelegate _EndVertexShaderEXT;

		public static  void EndVertexShaderEXT(  )
		{
			if (_EndVertexShaderEXT == null) throw new Exception( "Extension method EndVertexShaderEXT not found" );
		 _EndVertexShaderEXT(  );
		}
		public delegate void BindVertexShaderEXTDelegate( uint id ); //  extension method

		private static BindVertexShaderEXTDelegate _BindVertexShaderEXT;

		public static  void BindVertexShaderEXT( uint id )
		{
			if (_BindVertexShaderEXT == null) throw new Exception( "Extension method BindVertexShaderEXT not found" );
		 _BindVertexShaderEXT( id );
		}
		public delegate uint GenVertexShadersEXTDelegate( uint range ); //  extension method

		private static GenVertexShadersEXTDelegate _GenVertexShadersEXT;

		public static  uint GenVertexShadersEXT( uint range )
		{
			if (_GenVertexShadersEXT == null) throw new Exception( "Extension method GenVertexShadersEXT not found" );
		return  _GenVertexShadersEXT( range );
		}
		public delegate void DeleteVertexShaderEXTDelegate( uint id ); //  extension method

		private static DeleteVertexShaderEXTDelegate _DeleteVertexShaderEXT;

		public static  void DeleteVertexShaderEXT( uint id )
		{
			if (_DeleteVertexShaderEXT == null) throw new Exception( "Extension method DeleteVertexShaderEXT not found" );
		 _DeleteVertexShaderEXT( id );
		}
		public delegate void ShaderOp1EXTDelegate( uint op, uint res, uint arg1 ); //  extension method

		private static ShaderOp1EXTDelegate _ShaderOp1EXT;

		public static  void ShaderOp1EXT( uint op, uint res, uint arg1 )
		{
			if (_ShaderOp1EXT == null) throw new Exception( "Extension method ShaderOp1EXT not found" );
		 _ShaderOp1EXT( op, res, arg1 );
		}
		public delegate void ShaderOp2EXTDelegate( uint op, uint res, uint arg1, uint arg2 ); //  extension method

		private static ShaderOp2EXTDelegate _ShaderOp2EXT;

		public static  void ShaderOp2EXT( uint op, uint res, uint arg1, uint arg2 )
		{
			if (_ShaderOp2EXT == null) throw new Exception( "Extension method ShaderOp2EXT not found" );
		 _ShaderOp2EXT( op, res, arg1, arg2 );
		}
		public delegate void ShaderOp3EXTDelegate( uint op, uint res, uint arg1, uint arg2, uint arg3 ); //  extension method

		private static ShaderOp3EXTDelegate _ShaderOp3EXT;

		public static  void ShaderOp3EXT( uint op, uint res, uint arg1, uint arg2, uint arg3 )
		{
			if (_ShaderOp3EXT == null) throw new Exception( "Extension method ShaderOp3EXT not found" );
		 _ShaderOp3EXT( op, res, arg1, arg2, arg3 );
		}
		public delegate void SwizzleEXTDelegate( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method

		private static SwizzleEXTDelegate _SwizzleEXT;

		public static  void SwizzleEXT( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW )
		{
			if (_SwizzleEXT == null) throw new Exception( "Extension method SwizzleEXT not found" );
		 _SwizzleEXT( res, @in, outX, outY, outZ, outW );
		}
		public delegate void WriteMaskEXTDelegate( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW ); //  extension method

		private static WriteMaskEXTDelegate _WriteMaskEXT;

		public static  void WriteMaskEXT( uint res, uint @in, uint outX, uint outY, uint outZ, uint outW )
		{
			if (_WriteMaskEXT == null) throw new Exception( "Extension method WriteMaskEXT not found" );
		 _WriteMaskEXT( res, @in, outX, outY, outZ, outW );
		}
		public delegate void InsertComponentEXTDelegate( uint res, uint src, uint num ); //  extension method

		private static InsertComponentEXTDelegate _InsertComponentEXT;

		public static  void InsertComponentEXT( uint res, uint src, uint num )
		{
			if (_InsertComponentEXT == null) throw new Exception( "Extension method InsertComponentEXT not found" );
		 _InsertComponentEXT( res, src, num );
		}
		public delegate void ExtractComponentEXTDelegate( uint res, uint src, uint num ); //  extension method

		private static ExtractComponentEXTDelegate _ExtractComponentEXT;

		public static  void ExtractComponentEXT( uint res, uint src, uint num )
		{
			if (_ExtractComponentEXT == null) throw new Exception( "Extension method ExtractComponentEXT not found" );
		 _ExtractComponentEXT( res, src, num );
		}
		public delegate uint GenSymbolsEXTDelegate( uint datatype, uint storagetype, uint range, uint components ); //  extension method

		private static GenSymbolsEXTDelegate _GenSymbolsEXT;

		public static  uint GenSymbolsEXT( uint datatype, uint storagetype, uint range, uint components )
		{
			if (_GenSymbolsEXT == null) throw new Exception( "Extension method GenSymbolsEXT not found" );
		return  _GenSymbolsEXT( datatype, storagetype, range, components );
		}
		public unsafe delegate void SetInvariantEXTDelegate( uint id, uint type, void* addr ); //  extension method

		private static SetInvariantEXTDelegate _SetInvariantEXT;

		public static unsafe  void SetInvariantEXT( uint id, uint type, void* addr )
		{
			if (_SetInvariantEXT == null) throw new Exception( "Extension method SetInvariantEXT not found" );
		 _SetInvariantEXT( id, type, addr );
		}
		public unsafe delegate void SetLocalConstantEXTDelegate( uint id, uint type, void* addr ); //  extension method

		private static SetLocalConstantEXTDelegate _SetLocalConstantEXT;

		public static unsafe  void SetLocalConstantEXT( uint id, uint type, void* addr )
		{
			if (_SetLocalConstantEXT == null) throw new Exception( "Extension method SetLocalConstantEXT not found" );
		 _SetLocalConstantEXT( id, type, addr );
		}
		public delegate void VariantbvEXTDelegate( uint id, sbyte[] addr ); //  extension method

		private static VariantbvEXTDelegate _VariantbvEXT;

		public static  void VariantbvEXT( uint id, sbyte[] addr )
		{
			if (_VariantbvEXT == null) throw new Exception( "Extension method VariantbvEXT not found" );
		 _VariantbvEXT( id, addr );
		}
		public delegate void VariantsvEXTDelegate( uint id, short[] addr ); //  extension method

		private static VariantsvEXTDelegate _VariantsvEXT;

		public static  void VariantsvEXT( uint id, short[] addr )
		{
			if (_VariantsvEXT == null) throw new Exception( "Extension method VariantsvEXT not found" );
		 _VariantsvEXT( id, addr );
		}
		public delegate void VariantivEXTDelegate( uint id, int[] addr ); //  extension method

		private static VariantivEXTDelegate _VariantivEXT;

		public static  void VariantivEXT( uint id, int[] addr )
		{
			if (_VariantivEXT == null) throw new Exception( "Extension method VariantivEXT not found" );
		 _VariantivEXT( id, addr );
		}
		public delegate void VariantfvEXTDelegate( uint id, float[] addr ); //  extension method

		private static VariantfvEXTDelegate _VariantfvEXT;

		public static  void VariantfvEXT( uint id, float[] addr )
		{
			if (_VariantfvEXT == null) throw new Exception( "Extension method VariantfvEXT not found" );
		 _VariantfvEXT( id, addr );
		}
		public delegate void VariantdvEXTDelegate( uint id, double[] addr ); //  extension method

		private static VariantdvEXTDelegate _VariantdvEXT;

		public static  void VariantdvEXT( uint id, double[] addr )
		{
			if (_VariantdvEXT == null) throw new Exception( "Extension method VariantdvEXT not found" );
		 _VariantdvEXT( id, addr );
		}
		public delegate void VariantubvEXTDelegate( uint id, byte[] addr ); //  extension method

		private static VariantubvEXTDelegate _VariantubvEXT;

		public static  void VariantubvEXT( uint id, byte[] addr )
		{
			if (_VariantubvEXT == null) throw new Exception( "Extension method VariantubvEXT not found" );
		 _VariantubvEXT( id, addr );
		}
		public delegate void VariantusvEXTDelegate( uint id, ushort[] addr ); //  extension method

		private static VariantusvEXTDelegate _VariantusvEXT;

		public static  void VariantusvEXT( uint id, ushort[] addr )
		{
			if (_VariantusvEXT == null) throw new Exception( "Extension method VariantusvEXT not found" );
		 _VariantusvEXT( id, addr );
		}
		public delegate void VariantuivEXTDelegate( uint id, uint[] addr ); //  extension method

		private static VariantuivEXTDelegate _VariantuivEXT;

		public static  void VariantuivEXT( uint id, uint[] addr )
		{
			if (_VariantuivEXT == null) throw new Exception( "Extension method VariantuivEXT not found" );
		 _VariantuivEXT( id, addr );
		}
		public unsafe delegate void VariantPointerEXTDelegate( uint id, uint type, uint stride, void* addr ); //  extension method

		private static VariantPointerEXTDelegate _VariantPointerEXT;

		public static unsafe  void VariantPointerEXT( uint id, uint type, uint stride, void* addr )
		{
			if (_VariantPointerEXT == null) throw new Exception( "Extension method VariantPointerEXT not found" );
		 _VariantPointerEXT( id, type, stride, addr );
		}
		public delegate void EnableVariantClientStateEXTDelegate( uint id ); //  extension method

		private static EnableVariantClientStateEXTDelegate _EnableVariantClientStateEXT;

		public static  void EnableVariantClientStateEXT( uint id )
		{
			if (_EnableVariantClientStateEXT == null) throw new Exception( "Extension method EnableVariantClientStateEXT not found" );
		 _EnableVariantClientStateEXT( id );
		}
		public delegate void DisableVariantClientStateEXTDelegate( uint id ); //  extension method

		private static DisableVariantClientStateEXTDelegate _DisableVariantClientStateEXT;

		public static  void DisableVariantClientStateEXT( uint id )
		{
			if (_DisableVariantClientStateEXT == null) throw new Exception( "Extension method DisableVariantClientStateEXT not found" );
		 _DisableVariantClientStateEXT( id );
		}
		public delegate uint BindLightParameterEXTDelegate( LightName light, LightParameter value ); //  extension method

		private static BindLightParameterEXTDelegate _BindLightParameterEXT;

		public static  uint BindLightParameterEXT( LightName light, LightParameter value )
		{
			if (_BindLightParameterEXT == null) throw new Exception( "Extension method BindLightParameterEXT not found" );
		return  _BindLightParameterEXT( light, value );
		}
		public delegate uint BindMaterialParameterEXTDelegate( MaterialFace face, MaterialParameter value ); //  extension method

		private static BindMaterialParameterEXTDelegate _BindMaterialParameterEXT;

		public static  uint BindMaterialParameterEXT( MaterialFace face, MaterialParameter value )
		{
			if (_BindMaterialParameterEXT == null) throw new Exception( "Extension method BindMaterialParameterEXT not found" );
		return  _BindMaterialParameterEXT( face, value );
		}
		public delegate uint BindTexGenParameterEXTDelegate( uint unit, TextureCoordName coord, TextureGenParameter value ); //  extension method

		private static BindTexGenParameterEXTDelegate _BindTexGenParameterEXT;

		public static  uint BindTexGenParameterEXT( uint unit, TextureCoordName coord, TextureGenParameter value )
		{
			if (_BindTexGenParameterEXT == null) throw new Exception( "Extension method BindTexGenParameterEXT not found" );
		return  _BindTexGenParameterEXT( unit, coord, value );
		}
		public delegate uint BindTextureUnitParameterEXTDelegate( uint unit, uint value ); //  extension method

		private static BindTextureUnitParameterEXTDelegate _BindTextureUnitParameterEXT;

		public static  uint BindTextureUnitParameterEXT( uint unit, uint value )
		{
			if (_BindTextureUnitParameterEXT == null) throw new Exception( "Extension method BindTextureUnitParameterEXT not found" );
		return  _BindTextureUnitParameterEXT( unit, value );
		}
		public delegate uint BindParameterEXTDelegate( uint value ); //  extension method

		private static BindParameterEXTDelegate _BindParameterEXT;

		public static  uint BindParameterEXT( uint value )
		{
			if (_BindParameterEXT == null) throw new Exception( "Extension method BindParameterEXT not found" );
		return  _BindParameterEXT( value );
		}
		public delegate bool IsVariantEnabledEXTDelegate( uint id, uint cap ); //  extension method

		private static IsVariantEnabledEXTDelegate _IsVariantEnabledEXT;

		public static  bool IsVariantEnabledEXT( uint id, uint cap )
		{
			if (_IsVariantEnabledEXT == null) throw new Exception( "Extension method IsVariantEnabledEXT not found" );
		return  _IsVariantEnabledEXT( id, cap );
		}
		public delegate void GetVariantBooleanvEXTDelegate( uint id, uint value, [Out]bool[] data ); //  extension method

		private static GetVariantBooleanvEXTDelegate _GetVariantBooleanvEXT;

		public static  void GetVariantBooleanvEXT( uint id, uint value, [Out]bool[] data )
		{
			if (_GetVariantBooleanvEXT == null) throw new Exception( "Extension method GetVariantBooleanvEXT not found" );
		 _GetVariantBooleanvEXT( id, value, data );
		}
		public delegate void GetVariantIntegervEXTDelegate( uint id, uint value, [Out]int[] data ); //  extension method

		private static GetVariantIntegervEXTDelegate _GetVariantIntegervEXT;

		public static  void GetVariantIntegervEXT( uint id, uint value, [Out]int[] data )
		{
			if (_GetVariantIntegervEXT == null) throw new Exception( "Extension method GetVariantIntegervEXT not found" );
		 _GetVariantIntegervEXT( id, value, data );
		}
		public delegate void GetVariantFloatvEXTDelegate( uint id, uint value, [Out]float[] data ); //  extension method

		private static GetVariantFloatvEXTDelegate _GetVariantFloatvEXT;

		public static  void GetVariantFloatvEXT( uint id, uint value, [Out]float[] data )
		{
			if (_GetVariantFloatvEXT == null) throw new Exception( "Extension method GetVariantFloatvEXT not found" );
		 _GetVariantFloatvEXT( id, value, data );
		}
		public unsafe delegate void GetVariantPointervEXTDelegate( uint id, uint value, [Out]void** data ); //  extension method

		private static GetVariantPointervEXTDelegate _GetVariantPointervEXT;

		public static unsafe  void GetVariantPointervEXT( uint id, uint value, [Out]void** data )
		{
			if (_GetVariantPointervEXT == null) throw new Exception( "Extension method GetVariantPointervEXT not found" );
		 _GetVariantPointervEXT( id, value, data );
		}
		public delegate void GetInvariantBooleanvEXTDelegate( uint id, uint value, [Out]bool[] data ); //  extension method

		private static GetInvariantBooleanvEXTDelegate _GetInvariantBooleanvEXT;

		public static  void GetInvariantBooleanvEXT( uint id, uint value, [Out]bool[] data )
		{
			if (_GetInvariantBooleanvEXT == null) throw new Exception( "Extension method GetInvariantBooleanvEXT not found" );
		 _GetInvariantBooleanvEXT( id, value, data );
		}
		public delegate void GetInvariantIntegervEXTDelegate( uint id, uint value, [Out]int[] data ); //  extension method

		private static GetInvariantIntegervEXTDelegate _GetInvariantIntegervEXT;

		public static  void GetInvariantIntegervEXT( uint id, uint value, [Out]int[] data )
		{
			if (_GetInvariantIntegervEXT == null) throw new Exception( "Extension method GetInvariantIntegervEXT not found" );
		 _GetInvariantIntegervEXT( id, value, data );
		}
		public delegate void GetInvariantFloatvEXTDelegate( uint id, uint value, [Out]float[] data ); //  extension method

		private static GetInvariantFloatvEXTDelegate _GetInvariantFloatvEXT;

		public static  void GetInvariantFloatvEXT( uint id, uint value, [Out]float[] data )
		{
			if (_GetInvariantFloatvEXT == null) throw new Exception( "Extension method GetInvariantFloatvEXT not found" );
		 _GetInvariantFloatvEXT( id, value, data );
		}
		public delegate void GetLocalConstantBooleanvEXTDelegate( uint id, uint value, [Out]bool[] data ); //  extension method

		private static GetLocalConstantBooleanvEXTDelegate _GetLocalConstantBooleanvEXT;

		public static  void GetLocalConstantBooleanvEXT( uint id, uint value, [Out]bool[] data )
		{
			if (_GetLocalConstantBooleanvEXT == null) throw new Exception( "Extension method GetLocalConstantBooleanvEXT not found" );
		 _GetLocalConstantBooleanvEXT( id, value, data );
		}
		public delegate void GetLocalConstantIntegervEXTDelegate( uint id, uint value, [Out]int[] data ); //  extension method

		private static GetLocalConstantIntegervEXTDelegate _GetLocalConstantIntegervEXT;

		public static  void GetLocalConstantIntegervEXT( uint id, uint value, [Out]int[] data )
		{
			if (_GetLocalConstantIntegervEXT == null) throw new Exception( "Extension method GetLocalConstantIntegervEXT not found" );
		 _GetLocalConstantIntegervEXT( id, value, data );
		}
		public delegate void GetLocalConstantFloatvEXTDelegate( uint id, uint value, [Out]float[] data ); //  extension method

		private static GetLocalConstantFloatvEXTDelegate _GetLocalConstantFloatvEXT;

		public static  void GetLocalConstantFloatvEXT( uint id, uint value, [Out]float[] data )
		{
			if (_GetLocalConstantFloatvEXT == null) throw new Exception( "Extension method GetLocalConstantFloatvEXT not found" );
		 _GetLocalConstantFloatvEXT( id, value, data );
		}
	}
}
