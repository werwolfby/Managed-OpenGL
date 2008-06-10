using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_register_combiners2Init()
		{
			_CombinerStageParameterfvNV = GetProcAdress< CombinerStageParameterfvNVDelegate >( "glCombinerStageParameterfvNV" );
			_GetCombinerStageParameterfvNV = GetProcAdress< GetCombinerStageParameterfvNVDelegate >( "glGetCombinerStageParameterfvNV" );
			
		}
		
	
		public delegate void CombinerStageParameterfvNVDelegate( uint stage, uint pname, float[] @params ); //  extension method
		private static CombinerStageParameterfvNVDelegate _CombinerStageParameterfvNV;
		
		public static  void CombinerStageParameterfvNV( uint stage, uint pname, float[] @params )
		{
			if (_CombinerStageParameterfvNV == null) throw new Exception( "Extension method CombinerStageParameterfvNV not found" );
			 _CombinerStageParameterfvNV( stage, pname, @params );
		}
		public delegate void GetCombinerStageParameterfvNVDelegate( uint stage, uint pname, [Out]float[] @params ); //  extension method
		private static GetCombinerStageParameterfvNVDelegate _GetCombinerStageParameterfvNV;
		
		public static  void GetCombinerStageParameterfvNV( uint stage, uint pname, [Out]float[] @params )
		{
			if (_GetCombinerStageParameterfvNV == null) throw new Exception( "Extension method GetCombinerStageParameterfvNV not found" );
			 _GetCombinerStageParameterfvNV( stage, pname, @params );
		}
	}
}

