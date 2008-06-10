using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeAPPLE_fenceInit()
		{
			_GenFencesAPPLE = GetProcAdress< GenFencesAPPLEDelegate >( "glGenFencesAPPLE" );
			_DeleteFencesAPPLE = GetProcAdress< DeleteFencesAPPLEDelegate >( "glDeleteFencesAPPLE" );
			_SetFenceAPPLE = GetProcAdress< SetFenceAPPLEDelegate >( "glSetFenceAPPLE" );
			_IsFenceAPPLE = GetProcAdress< IsFenceAPPLEDelegate >( "glIsFenceAPPLE" );
			_TestFenceAPPLE = GetProcAdress< TestFenceAPPLEDelegate >( "glTestFenceAPPLE" );
			_FinishFenceAPPLE = GetProcAdress< FinishFenceAPPLEDelegate >( "glFinishFenceAPPLE" );
			_TestObjectAPPLE = GetProcAdress< TestObjectAPPLEDelegate >( "glTestObjectAPPLE" );
			_FinishObjectAPPLE = GetProcAdress< FinishObjectAPPLEDelegate >( "glFinishObjectAPPLE" );
			
		}
		
	
		public delegate void GenFencesAPPLEDelegate( int n, [Out]uint[] fences ); //  extension method
		private static GenFencesAPPLEDelegate _GenFencesAPPLE;
		
		public static  void GenFencesAPPLE( int n, [Out]uint[] fences )
		{
			if (_GenFencesAPPLE == null) throw new Exception( "Extension method GenFencesAPPLE not found" );
			 _GenFencesAPPLE( n, fences );
		}
		public delegate void DeleteFencesAPPLEDelegate( int n, uint[] fences ); //  extension method
		private static DeleteFencesAPPLEDelegate _DeleteFencesAPPLE;
		
		public static  void DeleteFencesAPPLE( int n, uint[] fences )
		{
			if (_DeleteFencesAPPLE == null) throw new Exception( "Extension method DeleteFencesAPPLE not found" );
			 _DeleteFencesAPPLE( n, fences );
		}
		public delegate void SetFenceAPPLEDelegate( uint fence ); //  extension method
		private static SetFenceAPPLEDelegate _SetFenceAPPLE;
		
		public static  void SetFenceAPPLE( uint fence )
		{
			if (_SetFenceAPPLE == null) throw new Exception( "Extension method SetFenceAPPLE not found" );
			 _SetFenceAPPLE( fence );
		}
		public delegate bool IsFenceAPPLEDelegate( uint fence ); //  extension method
		private static IsFenceAPPLEDelegate _IsFenceAPPLE;
		
		public static  bool IsFenceAPPLE( uint fence )
		{
			if (_IsFenceAPPLE == null) throw new Exception( "Extension method IsFenceAPPLE not found" );
			return  _IsFenceAPPLE( fence );
		}
		public delegate bool TestFenceAPPLEDelegate( uint fence ); //  extension method
		private static TestFenceAPPLEDelegate _TestFenceAPPLE;
		
		public static  bool TestFenceAPPLE( uint fence )
		{
			if (_TestFenceAPPLE == null) throw new Exception( "Extension method TestFenceAPPLE not found" );
			return  _TestFenceAPPLE( fence );
		}
		public delegate void FinishFenceAPPLEDelegate( uint fence ); //  extension method
		private static FinishFenceAPPLEDelegate _FinishFenceAPPLE;
		
		public static  void FinishFenceAPPLE( uint fence )
		{
			if (_FinishFenceAPPLE == null) throw new Exception( "Extension method FinishFenceAPPLE not found" );
			 _FinishFenceAPPLE( fence );
		}
		public delegate bool TestObjectAPPLEDelegate( uint @object, uint name ); //  extension method
		private static TestObjectAPPLEDelegate _TestObjectAPPLE;
		
		public static  bool TestObjectAPPLE( uint @object, uint name )
		{
			if (_TestObjectAPPLE == null) throw new Exception( "Extension method TestObjectAPPLE not found" );
			return  _TestObjectAPPLE( @object, name );
		}
		public delegate void FinishObjectAPPLEDelegate( uint @object, int name ); //  extension method
		private static FinishObjectAPPLEDelegate _FinishObjectAPPLE;
		
		public static  void FinishObjectAPPLE( uint @object, int name )
		{
			if (_FinishObjectAPPLE == null) throw new Exception( "Extension method FinishObjectAPPLE not found" );
			 _FinishObjectAPPLE( @object, name );
		}
	}
}

