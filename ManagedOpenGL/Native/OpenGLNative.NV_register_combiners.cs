using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_register_combinersInit()
		{
			_CombinerParameterfvNV = GetProcAdress< CombinerParameterfvNVDelegate >( "glCombinerParameterfvNV" );
			_CombinerParameterfNV = GetProcAdress< CombinerParameterfNVDelegate >( "glCombinerParameterfNV" );
			_CombinerParameterivNV = GetProcAdress< CombinerParameterivNVDelegate >( "glCombinerParameterivNV" );
			_CombinerParameteriNV = GetProcAdress< CombinerParameteriNVDelegate >( "glCombinerParameteriNV" );
			_CombinerInputNV = GetProcAdress< CombinerInputNVDelegate >( "glCombinerInputNV" );
			_CombinerOutputNV = GetProcAdress< CombinerOutputNVDelegate >( "glCombinerOutputNV" );
			_FinalCombinerInputNV = GetProcAdress< FinalCombinerInputNVDelegate >( "glFinalCombinerInputNV" );
			_GetCombinerInputParameterfvNV = GetProcAdress< GetCombinerInputParameterfvNVDelegate >( "glGetCombinerInputParameterfvNV" );
			_GetCombinerInputParameterivNV = GetProcAdress< GetCombinerInputParameterivNVDelegate >( "glGetCombinerInputParameterivNV" );
			_GetCombinerOutputParameterfvNV = GetProcAdress< GetCombinerOutputParameterfvNVDelegate >( "glGetCombinerOutputParameterfvNV" );
			_GetCombinerOutputParameterivNV = GetProcAdress< GetCombinerOutputParameterivNVDelegate >( "glGetCombinerOutputParameterivNV" );
			_GetFinalCombinerInputParameterfvNV = GetProcAdress< GetFinalCombinerInputParameterfvNVDelegate >( "glGetFinalCombinerInputParameterfvNV" );
			_GetFinalCombinerInputParameterivNV = GetProcAdress< GetFinalCombinerInputParameterivNVDelegate >( "glGetFinalCombinerInputParameterivNV" );
		}


		public delegate void CombinerParameterfvNVDelegate( uint pname, float[] @params ); //  extension method

		private static CombinerParameterfvNVDelegate _CombinerParameterfvNV;

		public static  void CombinerParameterfvNV( uint pname, float[] @params )
		{
			if (_CombinerParameterfvNV == null) throw new Exception( "Extension method CombinerParameterfvNV not found" );
		 _CombinerParameterfvNV( pname, @params );
		}
		public delegate void CombinerParameterfNVDelegate( uint pname, float param ); //  extension method

		private static CombinerParameterfNVDelegate _CombinerParameterfNV;

		public static  void CombinerParameterfNV( uint pname, float param )
		{
			if (_CombinerParameterfNV == null) throw new Exception( "Extension method CombinerParameterfNV not found" );
		 _CombinerParameterfNV( pname, param );
		}
		public delegate void CombinerParameterivNVDelegate( uint pname, int[] @params ); //  extension method

		private static CombinerParameterivNVDelegate _CombinerParameterivNV;

		public static  void CombinerParameterivNV( uint pname, int[] @params )
		{
			if (_CombinerParameterivNV == null) throw new Exception( "Extension method CombinerParameterivNV not found" );
		 _CombinerParameterivNV( pname, @params );
		}
		public delegate void CombinerParameteriNVDelegate( uint pname, int param ); //  extension method

		private static CombinerParameteriNVDelegate _CombinerParameteriNV;

		public static  void CombinerParameteriNV( uint pname, int param )
		{
			if (_CombinerParameteriNV == null) throw new Exception( "Extension method CombinerParameteriNV not found" );
		 _CombinerParameteriNV( pname, param );
		}
		public delegate void CombinerInputNVDelegate( uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage ); //  extension method

		private static CombinerInputNVDelegate _CombinerInputNV;

		public static  void CombinerInputNV( uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage )
		{
			if (_CombinerInputNV == null) throw new Exception( "Extension method CombinerInputNV not found" );
		 _CombinerInputNV( stage, portion, variable, input, mapping, componentUsage );
		}
		public delegate void CombinerOutputNVDelegate( uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum ); //  extension method

		private static CombinerOutputNVDelegate _CombinerOutputNV;

		public static  void CombinerOutputNV( uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum )
		{
			if (_CombinerOutputNV == null) throw new Exception( "Extension method CombinerOutputNV not found" );
		 _CombinerOutputNV( stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum );
		}
		public delegate void FinalCombinerInputNVDelegate( uint variable, uint input, uint mapping, uint componentUsage ); //  extension method

		private static FinalCombinerInputNVDelegate _FinalCombinerInputNV;

		public static  void FinalCombinerInputNV( uint variable, uint input, uint mapping, uint componentUsage )
		{
			if (_FinalCombinerInputNV == null) throw new Exception( "Extension method FinalCombinerInputNV not found" );
		 _FinalCombinerInputNV( variable, input, mapping, componentUsage );
		}
		public delegate void GetCombinerInputParameterfvNVDelegate( uint stage, uint portion, uint variable, uint pname, [Out]float[] @params ); //  extension method

		private static GetCombinerInputParameterfvNVDelegate _GetCombinerInputParameterfvNV;

		public static  void GetCombinerInputParameterfvNV( uint stage, uint portion, uint variable, uint pname, [Out]float[] @params )
		{
			if (_GetCombinerInputParameterfvNV == null) throw new Exception( "Extension method GetCombinerInputParameterfvNV not found" );
		 _GetCombinerInputParameterfvNV( stage, portion, variable, pname, @params );
		}
		public delegate void GetCombinerInputParameterivNVDelegate( uint stage, uint portion, uint variable, uint pname, [Out]int[] @params ); //  extension method

		private static GetCombinerInputParameterivNVDelegate _GetCombinerInputParameterivNV;

		public static  void GetCombinerInputParameterivNV( uint stage, uint portion, uint variable, uint pname, [Out]int[] @params )
		{
			if (_GetCombinerInputParameterivNV == null) throw new Exception( "Extension method GetCombinerInputParameterivNV not found" );
		 _GetCombinerInputParameterivNV( stage, portion, variable, pname, @params );
		}
		public delegate void GetCombinerOutputParameterfvNVDelegate( uint stage, uint portion, uint pname, [Out]float[] @params ); //  extension method

		private static GetCombinerOutputParameterfvNVDelegate _GetCombinerOutputParameterfvNV;

		public static  void GetCombinerOutputParameterfvNV( uint stage, uint portion, uint pname, [Out]float[] @params )
		{
			if (_GetCombinerOutputParameterfvNV == null) throw new Exception( "Extension method GetCombinerOutputParameterfvNV not found" );
		 _GetCombinerOutputParameterfvNV( stage, portion, pname, @params );
		}
		public delegate void GetCombinerOutputParameterivNVDelegate( uint stage, uint portion, uint pname, [Out]int[] @params ); //  extension method

		private static GetCombinerOutputParameterivNVDelegate _GetCombinerOutputParameterivNV;

		public static  void GetCombinerOutputParameterivNV( uint stage, uint portion, uint pname, [Out]int[] @params )
		{
			if (_GetCombinerOutputParameterivNV == null) throw new Exception( "Extension method GetCombinerOutputParameterivNV not found" );
		 _GetCombinerOutputParameterivNV( stage, portion, pname, @params );
		}
		public delegate void GetFinalCombinerInputParameterfvNVDelegate( uint variable, uint pname, [Out]float[] @params ); //  extension method

		private static GetFinalCombinerInputParameterfvNVDelegate _GetFinalCombinerInputParameterfvNV;

		public static  void GetFinalCombinerInputParameterfvNV( uint variable, uint pname, [Out]float[] @params )
		{
			if (_GetFinalCombinerInputParameterfvNV == null) throw new Exception( "Extension method GetFinalCombinerInputParameterfvNV not found" );
		 _GetFinalCombinerInputParameterfvNV( variable, pname, @params );
		}
		public delegate void GetFinalCombinerInputParameterivNVDelegate( uint variable, uint pname, [Out]int[] @params ); //  extension method

		private static GetFinalCombinerInputParameterivNVDelegate _GetFinalCombinerInputParameterivNV;

		public static  void GetFinalCombinerInputParameterivNV( uint variable, uint pname, [Out]int[] @params )
		{
			if (_GetFinalCombinerInputParameterivNV == null) throw new Exception( "Extension method GetFinalCombinerInputParameterivNV not found" );
		 _GetFinalCombinerInputParameterivNV( variable, pname, @params );
		}
	}
}
