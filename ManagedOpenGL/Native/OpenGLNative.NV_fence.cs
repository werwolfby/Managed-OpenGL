using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_fenceInit()
		{
			_DeleteFencesNV = GetProcAdress< DeleteFencesNVDelegate >( "glDeleteFencesNV" );
			_GenFencesNV = GetProcAdress< GenFencesNVDelegate >( "glGenFencesNV" );
			_IsFenceNV = GetProcAdress< IsFenceNVDelegate >( "glIsFenceNV" );
			_TestFenceNV = GetProcAdress< TestFenceNVDelegate >( "glTestFenceNV" );
			_GetFenceivNV = GetProcAdress< GetFenceivNVDelegate >( "glGetFenceivNV" );
			_FinishFenceNV = GetProcAdress< FinishFenceNVDelegate >( "glFinishFenceNV" );
			_SetFenceNV = GetProcAdress< SetFenceNVDelegate >( "glSetFenceNV" );
		}


		public delegate void DeleteFencesNVDelegate( int n, uint[] fences ); //  extension method

		private static DeleteFencesNVDelegate _DeleteFencesNV;

		public static  void DeleteFencesNV( int n, uint[] fences )
		{
			if (_DeleteFencesNV == null) throw new Exception( "Extension method DeleteFencesNV not found" );
		 _DeleteFencesNV( n, fences );
		}
		public delegate void GenFencesNVDelegate( int n, [Out]uint[] fences ); //  extension method

		private static GenFencesNVDelegate _GenFencesNV;

		public static  void GenFencesNV( int n, [Out]uint[] fences )
		{
			if (_GenFencesNV == null) throw new Exception( "Extension method GenFencesNV not found" );
		 _GenFencesNV( n, fences );
		}
		public delegate bool IsFenceNVDelegate( uint fence ); //  extension method

		private static IsFenceNVDelegate _IsFenceNV;

		public static  bool IsFenceNV( uint fence )
		{
			if (_IsFenceNV == null) throw new Exception( "Extension method IsFenceNV not found" );
		return  _IsFenceNV( fence );
		}
		public delegate bool TestFenceNVDelegate( uint fence ); //  extension method

		private static TestFenceNVDelegate _TestFenceNV;

		public static  bool TestFenceNV( uint fence )
		{
			if (_TestFenceNV == null) throw new Exception( "Extension method TestFenceNV not found" );
		return  _TestFenceNV( fence );
		}
		public delegate void GetFenceivNVDelegate( uint fence, uint pname, [Out]int[] @params ); //  extension method

		private static GetFenceivNVDelegate _GetFenceivNV;

		public static  void GetFenceivNV( uint fence, uint pname, [Out]int[] @params )
		{
			if (_GetFenceivNV == null) throw new Exception( "Extension method GetFenceivNV not found" );
		 _GetFenceivNV( fence, pname, @params );
		}
		public delegate void FinishFenceNVDelegate( uint fence ); //  extension method

		private static FinishFenceNVDelegate _FinishFenceNV;

		public static  void FinishFenceNV( uint fence )
		{
			if (_FinishFenceNV == null) throw new Exception( "Extension method FinishFenceNV not found" );
		 _FinishFenceNV( fence );
		}
		public delegate void SetFenceNVDelegate( uint fence, uint condition ); //  extension method

		private static SetFenceNVDelegate _SetFenceNV;

		public static  void SetFenceNV( uint fence, uint condition )
		{
			if (_SetFenceNV == null) throw new Exception( "Extension method SetFenceNV not found" );
		 _SetFenceNV( fence, condition );
		}
	}
}
