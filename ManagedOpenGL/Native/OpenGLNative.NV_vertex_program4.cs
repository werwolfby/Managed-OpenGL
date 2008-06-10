using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_vertex_program4Init()
		{
			_VertexAttribI1iEXT = GetProcAdress< VertexAttribI1iEXTDelegate >( "glVertexAttribI1iEXT" );
			_VertexAttribI2iEXT = GetProcAdress< VertexAttribI2iEXTDelegate >( "glVertexAttribI2iEXT" );
			_VertexAttribI3iEXT = GetProcAdress< VertexAttribI3iEXTDelegate >( "glVertexAttribI3iEXT" );
			_VertexAttribI4iEXT = GetProcAdress< VertexAttribI4iEXTDelegate >( "glVertexAttribI4iEXT" );
			_VertexAttribI1uiEXT = GetProcAdress< VertexAttribI1uiEXTDelegate >( "glVertexAttribI1uiEXT" );
			_VertexAttribI2uiEXT = GetProcAdress< VertexAttribI2uiEXTDelegate >( "glVertexAttribI2uiEXT" );
			_VertexAttribI3uiEXT = GetProcAdress< VertexAttribI3uiEXTDelegate >( "glVertexAttribI3uiEXT" );
			_VertexAttribI4uiEXT = GetProcAdress< VertexAttribI4uiEXTDelegate >( "glVertexAttribI4uiEXT" );
			_VertexAttribI1ivEXT = GetProcAdress< VertexAttribI1ivEXTDelegate >( "glVertexAttribI1ivEXT" );
			_VertexAttribI2ivEXT = GetProcAdress< VertexAttribI2ivEXTDelegate >( "glVertexAttribI2ivEXT" );
			_VertexAttribI3ivEXT = GetProcAdress< VertexAttribI3ivEXTDelegate >( "glVertexAttribI3ivEXT" );
			_VertexAttribI4ivEXT = GetProcAdress< VertexAttribI4ivEXTDelegate >( "glVertexAttribI4ivEXT" );
			_VertexAttribI1uivEXT = GetProcAdress< VertexAttribI1uivEXTDelegate >( "glVertexAttribI1uivEXT" );
			_VertexAttribI2uivEXT = GetProcAdress< VertexAttribI2uivEXTDelegate >( "glVertexAttribI2uivEXT" );
			_VertexAttribI3uivEXT = GetProcAdress< VertexAttribI3uivEXTDelegate >( "glVertexAttribI3uivEXT" );
			_VertexAttribI4uivEXT = GetProcAdress< VertexAttribI4uivEXTDelegate >( "glVertexAttribI4uivEXT" );
			_VertexAttribI4bvEXT = GetProcAdress< VertexAttribI4bvEXTDelegate >( "glVertexAttribI4bvEXT" );
			_VertexAttribI4svEXT = GetProcAdress< VertexAttribI4svEXTDelegate >( "glVertexAttribI4svEXT" );
			_VertexAttribI4ubvEXT = GetProcAdress< VertexAttribI4ubvEXTDelegate >( "glVertexAttribI4ubvEXT" );
			_VertexAttribI4usvEXT = GetProcAdress< VertexAttribI4usvEXTDelegate >( "glVertexAttribI4usvEXT" );
			_VertexAttribIPointerEXT = GetProcAdress< VertexAttribIPointerEXTDelegate >( "glVertexAttribIPointerEXT" );
			_GetVertexAttribIivEXT = GetProcAdress< GetVertexAttribIivEXTDelegate >( "glGetVertexAttribIivEXT" );
			_GetVertexAttribIuivEXT = GetProcAdress< GetVertexAttribIuivEXTDelegate >( "glGetVertexAttribIuivEXT" );
			
		}
		
	
		public delegate void VertexAttribI1iEXTDelegate( uint index, int x ); //  extension method
		private static VertexAttribI1iEXTDelegate _VertexAttribI1iEXT;
		
		public static  void VertexAttribI1iEXT( uint index, int x )
		{
			if (_VertexAttribI1iEXT == null) throw new Exception( "Extension method VertexAttribI1iEXT not found" );
			 _VertexAttribI1iEXT( index, x );
		}
		public delegate void VertexAttribI2iEXTDelegate( uint index, int x, int y ); //  extension method
		private static VertexAttribI2iEXTDelegate _VertexAttribI2iEXT;
		
		public static  void VertexAttribI2iEXT( uint index, int x, int y )
		{
			if (_VertexAttribI2iEXT == null) throw new Exception( "Extension method VertexAttribI2iEXT not found" );
			 _VertexAttribI2iEXT( index, x, y );
		}
		public delegate void VertexAttribI3iEXTDelegate( uint index, int x, int y, int z ); //  extension method
		private static VertexAttribI3iEXTDelegate _VertexAttribI3iEXT;
		
		public static  void VertexAttribI3iEXT( uint index, int x, int y, int z )
		{
			if (_VertexAttribI3iEXT == null) throw new Exception( "Extension method VertexAttribI3iEXT not found" );
			 _VertexAttribI3iEXT( index, x, y, z );
		}
		public delegate void VertexAttribI4iEXTDelegate( uint index, int x, int y, int z, int w ); //  extension method
		private static VertexAttribI4iEXTDelegate _VertexAttribI4iEXT;
		
		public static  void VertexAttribI4iEXT( uint index, int x, int y, int z, int w )
		{
			if (_VertexAttribI4iEXT == null) throw new Exception( "Extension method VertexAttribI4iEXT not found" );
			 _VertexAttribI4iEXT( index, x, y, z, w );
		}
		public delegate void VertexAttribI1uiEXTDelegate( uint index, uint x ); //  extension method
		private static VertexAttribI1uiEXTDelegate _VertexAttribI1uiEXT;
		
		public static  void VertexAttribI1uiEXT( uint index, uint x )
		{
			if (_VertexAttribI1uiEXT == null) throw new Exception( "Extension method VertexAttribI1uiEXT not found" );
			 _VertexAttribI1uiEXT( index, x );
		}
		public delegate void VertexAttribI2uiEXTDelegate( uint index, uint x, uint y ); //  extension method
		private static VertexAttribI2uiEXTDelegate _VertexAttribI2uiEXT;
		
		public static  void VertexAttribI2uiEXT( uint index, uint x, uint y )
		{
			if (_VertexAttribI2uiEXT == null) throw new Exception( "Extension method VertexAttribI2uiEXT not found" );
			 _VertexAttribI2uiEXT( index, x, y );
		}
		public delegate void VertexAttribI3uiEXTDelegate( uint index, uint x, uint y, uint z ); //  extension method
		private static VertexAttribI3uiEXTDelegate _VertexAttribI3uiEXT;
		
		public static  void VertexAttribI3uiEXT( uint index, uint x, uint y, uint z )
		{
			if (_VertexAttribI3uiEXT == null) throw new Exception( "Extension method VertexAttribI3uiEXT not found" );
			 _VertexAttribI3uiEXT( index, x, y, z );
		}
		public delegate void VertexAttribI4uiEXTDelegate( uint index, uint x, uint y, uint z, uint w ); //  extension method
		private static VertexAttribI4uiEXTDelegate _VertexAttribI4uiEXT;
		
		public static  void VertexAttribI4uiEXT( uint index, uint x, uint y, uint z, uint w )
		{
			if (_VertexAttribI4uiEXT == null) throw new Exception( "Extension method VertexAttribI4uiEXT not found" );
			 _VertexAttribI4uiEXT( index, x, y, z, w );
		}
		public delegate void VertexAttribI1ivEXTDelegate( uint index, int[] v ); //  extension method
		private static VertexAttribI1ivEXTDelegate _VertexAttribI1ivEXT;
		
		public static  void VertexAttribI1ivEXT( uint index, int[] v )
		{
			if (_VertexAttribI1ivEXT == null) throw new Exception( "Extension method VertexAttribI1ivEXT not found" );
			 _VertexAttribI1ivEXT( index, v );
		}
		public delegate void VertexAttribI2ivEXTDelegate( uint index, int[] v ); //  extension method
		private static VertexAttribI2ivEXTDelegate _VertexAttribI2ivEXT;
		
		public static  void VertexAttribI2ivEXT( uint index, int[] v )
		{
			if (_VertexAttribI2ivEXT == null) throw new Exception( "Extension method VertexAttribI2ivEXT not found" );
			 _VertexAttribI2ivEXT( index, v );
		}
		public delegate void VertexAttribI3ivEXTDelegate( uint index, int[] v ); //  extension method
		private static VertexAttribI3ivEXTDelegate _VertexAttribI3ivEXT;
		
		public static  void VertexAttribI3ivEXT( uint index, int[] v )
		{
			if (_VertexAttribI3ivEXT == null) throw new Exception( "Extension method VertexAttribI3ivEXT not found" );
			 _VertexAttribI3ivEXT( index, v );
		}
		public delegate void VertexAttribI4ivEXTDelegate( uint index, int[] v ); //  extension method
		private static VertexAttribI4ivEXTDelegate _VertexAttribI4ivEXT;
		
		public static  void VertexAttribI4ivEXT( uint index, int[] v )
		{
			if (_VertexAttribI4ivEXT == null) throw new Exception( "Extension method VertexAttribI4ivEXT not found" );
			 _VertexAttribI4ivEXT( index, v );
		}
		public delegate void VertexAttribI1uivEXTDelegate( uint index, uint[] v ); //  extension method
		private static VertexAttribI1uivEXTDelegate _VertexAttribI1uivEXT;
		
		public static  void VertexAttribI1uivEXT( uint index, uint[] v )
		{
			if (_VertexAttribI1uivEXT == null) throw new Exception( "Extension method VertexAttribI1uivEXT not found" );
			 _VertexAttribI1uivEXT( index, v );
		}
		public delegate void VertexAttribI2uivEXTDelegate( uint index, uint[] v ); //  extension method
		private static VertexAttribI2uivEXTDelegate _VertexAttribI2uivEXT;
		
		public static  void VertexAttribI2uivEXT( uint index, uint[] v )
		{
			if (_VertexAttribI2uivEXT == null) throw new Exception( "Extension method VertexAttribI2uivEXT not found" );
			 _VertexAttribI2uivEXT( index, v );
		}
		public delegate void VertexAttribI3uivEXTDelegate( uint index, uint[] v ); //  extension method
		private static VertexAttribI3uivEXTDelegate _VertexAttribI3uivEXT;
		
		public static  void VertexAttribI3uivEXT( uint index, uint[] v )
		{
			if (_VertexAttribI3uivEXT == null) throw new Exception( "Extension method VertexAttribI3uivEXT not found" );
			 _VertexAttribI3uivEXT( index, v );
		}
		public delegate void VertexAttribI4uivEXTDelegate( uint index, uint[] v ); //  extension method
		private static VertexAttribI4uivEXTDelegate _VertexAttribI4uivEXT;
		
		public static  void VertexAttribI4uivEXT( uint index, uint[] v )
		{
			if (_VertexAttribI4uivEXT == null) throw new Exception( "Extension method VertexAttribI4uivEXT not found" );
			 _VertexAttribI4uivEXT( index, v );
		}
		public delegate void VertexAttribI4bvEXTDelegate( uint index, sbyte[] v ); //  extension method
		private static VertexAttribI4bvEXTDelegate _VertexAttribI4bvEXT;
		
		public static  void VertexAttribI4bvEXT( uint index, sbyte[] v )
		{
			if (_VertexAttribI4bvEXT == null) throw new Exception( "Extension method VertexAttribI4bvEXT not found" );
			 _VertexAttribI4bvEXT( index, v );
		}
		public delegate void VertexAttribI4svEXTDelegate( uint index, short[] v ); //  extension method
		private static VertexAttribI4svEXTDelegate _VertexAttribI4svEXT;
		
		public static  void VertexAttribI4svEXT( uint index, short[] v )
		{
			if (_VertexAttribI4svEXT == null) throw new Exception( "Extension method VertexAttribI4svEXT not found" );
			 _VertexAttribI4svEXT( index, v );
		}
		public delegate void VertexAttribI4ubvEXTDelegate( uint index, byte[] v ); //  extension method
		private static VertexAttribI4ubvEXTDelegate _VertexAttribI4ubvEXT;
		
		public static  void VertexAttribI4ubvEXT( uint index, byte[] v )
		{
			if (_VertexAttribI4ubvEXT == null) throw new Exception( "Extension method VertexAttribI4ubvEXT not found" );
			 _VertexAttribI4ubvEXT( index, v );
		}
		public delegate void VertexAttribI4usvEXTDelegate( uint index, ushort[] v ); //  extension method
		private static VertexAttribI4usvEXTDelegate _VertexAttribI4usvEXT;
		
		public static  void VertexAttribI4usvEXT( uint index, ushort[] v )
		{
			if (_VertexAttribI4usvEXT == null) throw new Exception( "Extension method VertexAttribI4usvEXT not found" );
			 _VertexAttribI4usvEXT( index, v );
		}
		public unsafe delegate void VertexAttribIPointerEXTDelegate( uint index, int size, uint type, int stride, void* pointer ); //  extension method
		private static VertexAttribIPointerEXTDelegate _VertexAttribIPointerEXT;
		
		public static unsafe  void VertexAttribIPointerEXT( uint index, int size, uint type, int stride, void* pointer )
		{
			if (_VertexAttribIPointerEXT == null) throw new Exception( "Extension method VertexAttribIPointerEXT not found" );
			 _VertexAttribIPointerEXT( index, size, type, stride, pointer );
		}
		public delegate void GetVertexAttribIivEXTDelegate( uint index, uint pname, [Out]int[] @params ); //  extension method
		private static GetVertexAttribIivEXTDelegate _GetVertexAttribIivEXT;
		
		public static  void GetVertexAttribIivEXT( uint index, uint pname, [Out]int[] @params )
		{
			if (_GetVertexAttribIivEXT == null) throw new Exception( "Extension method GetVertexAttribIivEXT not found" );
			 _GetVertexAttribIivEXT( index, pname, @params );
		}
		public delegate void GetVertexAttribIuivEXTDelegate( uint index, uint pname, [Out]uint[] @params ); //  extension method
		private static GetVertexAttribIuivEXTDelegate _GetVertexAttribIuivEXT;
		
		public static  void GetVertexAttribIuivEXT( uint index, uint pname, [Out]uint[] @params )
		{
			if (_GetVertexAttribIuivEXT == null) throw new Exception( "Extension method GetVertexAttribIuivEXT not found" );
			 _GetVertexAttribIuivEXT( index, pname, @params );
		}
	}
}

