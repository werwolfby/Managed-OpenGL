using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_vertex_array_objectInit()
		{
			_NewObjectBufferATI = GetProcAdress< NewObjectBufferATIDelegate >( "glNewObjectBufferATI" );
			_IsObjectBufferATI = GetProcAdress< IsObjectBufferATIDelegate >( "glIsObjectBufferATI" );
			_UpdateObjectBufferATI = GetProcAdress< UpdateObjectBufferATIDelegate >( "glUpdateObjectBufferATI" );
			_GetObjectBufferfvATI = GetProcAdress< GetObjectBufferfvATIDelegate >( "glGetObjectBufferfvATI" );
			_GetObjectBufferivATI = GetProcAdress< GetObjectBufferivATIDelegate >( "glGetObjectBufferivATI" );
			_FreeObjectBufferATI = GetProcAdress< FreeObjectBufferATIDelegate >( "glFreeObjectBufferATI" );
			_ArrayObjectATI = GetProcAdress< ArrayObjectATIDelegate >( "glArrayObjectATI" );
			_GetArrayObjectfvATI = GetProcAdress< GetArrayObjectfvATIDelegate >( "glGetArrayObjectfvATI" );
			_GetArrayObjectivATI = GetProcAdress< GetArrayObjectivATIDelegate >( "glGetArrayObjectivATI" );
			_VariantArrayObjectATI = GetProcAdress< VariantArrayObjectATIDelegate >( "glVariantArrayObjectATI" );
			_GetVariantArrayObjectfvATI = GetProcAdress< GetVariantArrayObjectfvATIDelegate >( "glGetVariantArrayObjectfvATI" );
			_GetVariantArrayObjectivATI = GetProcAdress< GetVariantArrayObjectivATIDelegate >( "glGetVariantArrayObjectivATI" );
			
		}
		
	
		public unsafe delegate uint NewObjectBufferATIDelegate( int size, void* pointer, uint usage ); //  extension method
		private static NewObjectBufferATIDelegate _NewObjectBufferATI;
		
		public static unsafe  uint NewObjectBufferATI( int size, void* pointer, uint usage )
		{
			if (_NewObjectBufferATI == null) throw new Exception( "Extension method NewObjectBufferATI not found" );
			return  _NewObjectBufferATI( size, pointer, usage );
		}
		public delegate bool IsObjectBufferATIDelegate( uint buffer ); //  extension method
		private static IsObjectBufferATIDelegate _IsObjectBufferATI;
		
		public static  bool IsObjectBufferATI( uint buffer )
		{
			if (_IsObjectBufferATI == null) throw new Exception( "Extension method IsObjectBufferATI not found" );
			return  _IsObjectBufferATI( buffer );
		}
		public unsafe delegate void UpdateObjectBufferATIDelegate( uint buffer, uint offset, int size, void* pointer, uint preserve ); //  extension method
		private static UpdateObjectBufferATIDelegate _UpdateObjectBufferATI;
		
		public static unsafe  void UpdateObjectBufferATI( uint buffer, uint offset, int size, void* pointer, uint preserve )
		{
			if (_UpdateObjectBufferATI == null) throw new Exception( "Extension method UpdateObjectBufferATI not found" );
			 _UpdateObjectBufferATI( buffer, offset, size, pointer, preserve );
		}
		public delegate void GetObjectBufferfvATIDelegate( uint buffer, uint pname, [Out]float[] @params ); //  extension method
		private static GetObjectBufferfvATIDelegate _GetObjectBufferfvATI;
		
		public static  void GetObjectBufferfvATI( uint buffer, uint pname, [Out]float[] @params )
		{
			if (_GetObjectBufferfvATI == null) throw new Exception( "Extension method GetObjectBufferfvATI not found" );
			 _GetObjectBufferfvATI( buffer, pname, @params );
		}
		public delegate void GetObjectBufferivATIDelegate( uint buffer, uint pname, [Out]int[] @params ); //  extension method
		private static GetObjectBufferivATIDelegate _GetObjectBufferivATI;
		
		public static  void GetObjectBufferivATI( uint buffer, uint pname, [Out]int[] @params )
		{
			if (_GetObjectBufferivATI == null) throw new Exception( "Extension method GetObjectBufferivATI not found" );
			 _GetObjectBufferivATI( buffer, pname, @params );
		}
		public delegate void FreeObjectBufferATIDelegate( uint buffer ); //  extension method
		private static FreeObjectBufferATIDelegate _FreeObjectBufferATI;
		
		public static  void FreeObjectBufferATI( uint buffer )
		{
			if (_FreeObjectBufferATI == null) throw new Exception( "Extension method FreeObjectBufferATI not found" );
			 _FreeObjectBufferATI( buffer );
		}
		public delegate void ArrayObjectATIDelegate( EnableCap array, int size, uint type, int stride, uint buffer, uint offset ); //  extension method
		private static ArrayObjectATIDelegate _ArrayObjectATI;
		
		public static  void ArrayObjectATI( EnableCap array, int size, uint type, int stride, uint buffer, uint offset )
		{
			if (_ArrayObjectATI == null) throw new Exception( "Extension method ArrayObjectATI not found" );
			 _ArrayObjectATI( array, size, type, stride, buffer, offset );
		}
		public delegate void GetArrayObjectfvATIDelegate( EnableCap array, uint pname, [Out]float[] @params ); //  extension method
		private static GetArrayObjectfvATIDelegate _GetArrayObjectfvATI;
		
		public static  void GetArrayObjectfvATI( EnableCap array, uint pname, [Out]float[] @params )
		{
			if (_GetArrayObjectfvATI == null) throw new Exception( "Extension method GetArrayObjectfvATI not found" );
			 _GetArrayObjectfvATI( array, pname, @params );
		}
		public delegate void GetArrayObjectivATIDelegate( EnableCap array, uint pname, [Out]int[] @params ); //  extension method
		private static GetArrayObjectivATIDelegate _GetArrayObjectivATI;
		
		public static  void GetArrayObjectivATI( EnableCap array, uint pname, [Out]int[] @params )
		{
			if (_GetArrayObjectivATI == null) throw new Exception( "Extension method GetArrayObjectivATI not found" );
			 _GetArrayObjectivATI( array, pname, @params );
		}
		public delegate void VariantArrayObjectATIDelegate( uint id, uint type, int stride, uint buffer, uint offset ); //  extension method
		private static VariantArrayObjectATIDelegate _VariantArrayObjectATI;
		
		public static  void VariantArrayObjectATI( uint id, uint type, int stride, uint buffer, uint offset )
		{
			if (_VariantArrayObjectATI == null) throw new Exception( "Extension method VariantArrayObjectATI not found" );
			 _VariantArrayObjectATI( id, type, stride, buffer, offset );
		}
		public delegate void GetVariantArrayObjectfvATIDelegate( uint id, uint pname, [Out]float[] @params ); //  extension method
		private static GetVariantArrayObjectfvATIDelegate _GetVariantArrayObjectfvATI;
		
		public static  void GetVariantArrayObjectfvATI( uint id, uint pname, [Out]float[] @params )
		{
			if (_GetVariantArrayObjectfvATI == null) throw new Exception( "Extension method GetVariantArrayObjectfvATI not found" );
			 _GetVariantArrayObjectfvATI( id, pname, @params );
		}
		public delegate void GetVariantArrayObjectivATIDelegate( uint id, uint pname, [Out]int[] @params ); //  extension method
		private static GetVariantArrayObjectivATIDelegate _GetVariantArrayObjectivATI;
		
		public static  void GetVariantArrayObjectivATI( uint id, uint pname, [Out]int[] @params )
		{
			if (_GetVariantArrayObjectivATI == null) throw new Exception( "Extension method GetVariantArrayObjectivATI not found" );
			 _GetVariantArrayObjectivATI( id, pname, @params );
		}
	}
}

