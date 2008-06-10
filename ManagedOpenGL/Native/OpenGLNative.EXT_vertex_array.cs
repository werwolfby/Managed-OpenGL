using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_vertex_arrayInit()
		{
			_ArrayElementEXT = GetProcAdress< ArrayElementEXTDelegate >( "glArrayElementEXT" );
			_ColorPointerEXT = GetProcAdress< ColorPointerEXTDelegate >( "glColorPointerEXT" );
			_DrawArraysEXT = GetProcAdress< DrawArraysEXTDelegate >( "glDrawArraysEXT" );
			_EdgeFlagPointerEXT = GetProcAdress< EdgeFlagPointerEXTDelegate >( "glEdgeFlagPointerEXT" );
			_GetPointervEXT = GetProcAdress< GetPointervEXTDelegate >( "glGetPointervEXT" );
			_IndexPointerEXT = GetProcAdress< IndexPointerEXTDelegate >( "glIndexPointerEXT" );
			_NormalPointerEXT = GetProcAdress< NormalPointerEXTDelegate >( "glNormalPointerEXT" );
			_TexCoordPointerEXT = GetProcAdress< TexCoordPointerEXTDelegate >( "glTexCoordPointerEXT" );
			_VertexPointerEXT = GetProcAdress< VertexPointerEXTDelegate >( "glVertexPointerEXT" );
			
		}
		
	
		public delegate void ArrayElementEXTDelegate( int i ); //  extension method
		private static ArrayElementEXTDelegate _ArrayElementEXT;
		
		public static  void ArrayElementEXT( int i )
		{
			if (_ArrayElementEXT == null) throw new Exception( "Extension method ArrayElementEXT not found" );
			 _ArrayElementEXT( i );
		}
		public unsafe delegate void ColorPointerEXTDelegate( int size, ColorPointerType type, int stride, int count, void* pointer ); //  extension method
		private static ColorPointerEXTDelegate _ColorPointerEXT;
		
		public static unsafe  void ColorPointerEXT( int size, ColorPointerType type, int stride, int count, void* pointer )
		{
			if (_ColorPointerEXT == null) throw new Exception( "Extension method ColorPointerEXT not found" );
			 _ColorPointerEXT( size, type, stride, count, pointer );
		}
		public delegate void DrawArraysEXTDelegate( BeginMode mode, int first, int count ); //  extension method
		private static DrawArraysEXTDelegate _DrawArraysEXT;
		
		public static  void DrawArraysEXT( BeginMode mode, int first, int count )
		{
			if (_DrawArraysEXT == null) throw new Exception( "Extension method DrawArraysEXT not found" );
			 _DrawArraysEXT( mode, first, count );
		}
		public delegate void EdgeFlagPointerEXTDelegate( int stride, int count, bool[] pointer ); //  extension method
		private static EdgeFlagPointerEXTDelegate _EdgeFlagPointerEXT;
		
		public static  void EdgeFlagPointerEXT( int stride, int count, bool[] pointer )
		{
			if (_EdgeFlagPointerEXT == null) throw new Exception( "Extension method EdgeFlagPointerEXT not found" );
			 _EdgeFlagPointerEXT( stride, count, pointer );
		}
		public unsafe delegate void GetPointervEXTDelegate( GetPointervPName pname, [Out]void** @params ); //  extension method
		private static GetPointervEXTDelegate _GetPointervEXT;
		
		public static unsafe  void GetPointervEXT( GetPointervPName pname, [Out]void** @params )
		{
			if (_GetPointervEXT == null) throw new Exception( "Extension method GetPointervEXT not found" );
			 _GetPointervEXT( pname, @params );
		}
		public unsafe delegate void IndexPointerEXTDelegate( IndexPointerType type, int stride, int count, void* pointer ); //  extension method
		private static IndexPointerEXTDelegate _IndexPointerEXT;
		
		public static unsafe  void IndexPointerEXT( IndexPointerType type, int stride, int count, void* pointer )
		{
			if (_IndexPointerEXT == null) throw new Exception( "Extension method IndexPointerEXT not found" );
			 _IndexPointerEXT( type, stride, count, pointer );
		}
		public unsafe delegate void NormalPointerEXTDelegate( NormalPointerType type, int stride, int count, void* pointer ); //  extension method
		private static NormalPointerEXTDelegate _NormalPointerEXT;
		
		public static unsafe  void NormalPointerEXT( NormalPointerType type, int stride, int count, void* pointer )
		{
			if (_NormalPointerEXT == null) throw new Exception( "Extension method NormalPointerEXT not found" );
			 _NormalPointerEXT( type, stride, count, pointer );
		}
		public unsafe delegate void TexCoordPointerEXTDelegate( int size, TexCoordPointerType type, int stride, int count, void* pointer ); //  extension method
		private static TexCoordPointerEXTDelegate _TexCoordPointerEXT;
		
		public static unsafe  void TexCoordPointerEXT( int size, TexCoordPointerType type, int stride, int count, void* pointer )
		{
			if (_TexCoordPointerEXT == null) throw new Exception( "Extension method TexCoordPointerEXT not found" );
			 _TexCoordPointerEXT( size, type, stride, count, pointer );
		}
		public unsafe delegate void VertexPointerEXTDelegate( int size, VertexPointerType type, int stride, int count, void* pointer ); //  extension method
		private static VertexPointerEXTDelegate _VertexPointerEXT;
		
		public static unsafe  void VertexPointerEXT( int size, VertexPointerType type, int stride, int count, void* pointer )
		{
			if (_VertexPointerEXT == null) throw new Exception( "Extension method VertexPointerEXT not found" );
			 _VertexPointerEXT( size, type, stride, count, pointer );
		}
	}
}

