using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_vertex_weightingInit()
		{
			_VertexWeightfEXT = GetProcAdress< VertexWeightfEXTDelegate >( "glVertexWeightfEXT" );
			_VertexWeightfvEXT = GetProcAdress< VertexWeightfvEXTDelegate >( "glVertexWeightfvEXT" );
			_VertexWeightPointerEXT = GetProcAdress< VertexWeightPointerEXTDelegate >( "glVertexWeightPointerEXT" );
			
		}
		
	
		public delegate void VertexWeightfEXTDelegate( float weight ); //  extension method
		private static VertexWeightfEXTDelegate _VertexWeightfEXT;
		
		public static  void VertexWeightfEXT( float weight )
		{
			if (_VertexWeightfEXT == null) throw new Exception( "Extension method VertexWeightfEXT not found" );
			 _VertexWeightfEXT( weight );
		}
		public delegate void VertexWeightfvEXTDelegate( float[] weight ); //  extension method
		private static VertexWeightfvEXTDelegate _VertexWeightfvEXT;
		
		public static  void VertexWeightfvEXT( float[] weight )
		{
			if (_VertexWeightfvEXT == null) throw new Exception( "Extension method VertexWeightfvEXT not found" );
			 _VertexWeightfvEXT( weight );
		}
		public unsafe delegate void VertexWeightPointerEXTDelegate( int size, uint type, int stride, void* pointer ); //  extension method
		private static VertexWeightPointerEXTDelegate _VertexWeightPointerEXT;
		
		public static unsafe  void VertexWeightPointerEXT( int size, uint type, int stride, void* pointer )
		{
			if (_VertexWeightPointerEXT == null) throw new Exception( "Extension method VertexWeightPointerEXT not found" );
			 _VertexWeightPointerEXT( size, type, stride, pointer );
		}
	}
}

