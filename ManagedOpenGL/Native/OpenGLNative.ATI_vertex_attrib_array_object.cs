using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_vertex_attrib_array_objectInit()
		{
			_VertexAttribArrayObjectATI = GetProcAdress< VertexAttribArrayObjectATIDelegate >( "glVertexAttribArrayObjectATI" );
			_GetVertexAttribArrayObjectfvATI = GetProcAdress< GetVertexAttribArrayObjectfvATIDelegate >( "glGetVertexAttribArrayObjectfvATI" );
			_GetVertexAttribArrayObjectivATI = GetProcAdress< GetVertexAttribArrayObjectivATIDelegate >( "glGetVertexAttribArrayObjectivATI" );
		}


		public delegate void VertexAttribArrayObjectATIDelegate( uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset ); //  extension method

		private static VertexAttribArrayObjectATIDelegate _VertexAttribArrayObjectATI;

		public static  void VertexAttribArrayObjectATI( uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset )
		{
			if (_VertexAttribArrayObjectATI == null) throw new Exception( "Extension method VertexAttribArrayObjectATI not found" );
		 _VertexAttribArrayObjectATI( index, size, type, normalized, stride, buffer, offset );
		}
		public delegate void GetVertexAttribArrayObjectfvATIDelegate( uint index, uint pname, [Out]float[] @params ); //  extension method

		private static GetVertexAttribArrayObjectfvATIDelegate _GetVertexAttribArrayObjectfvATI;

		public static  void GetVertexAttribArrayObjectfvATI( uint index, uint pname, [Out]float[] @params )
		{
			if (_GetVertexAttribArrayObjectfvATI == null) throw new Exception( "Extension method GetVertexAttribArrayObjectfvATI not found" );
		 _GetVertexAttribArrayObjectfvATI( index, pname, @params );
		}
		public delegate void GetVertexAttribArrayObjectivATIDelegate( uint index, uint pname, [Out]int[] @params ); //  extension method

		private static GetVertexAttribArrayObjectivATIDelegate _GetVertexAttribArrayObjectivATI;

		public static  void GetVertexAttribArrayObjectivATI( uint index, uint pname, [Out]int[] @params )
		{
			if (_GetVertexAttribArrayObjectivATI == null) throw new Exception( "Extension method GetVertexAttribArrayObjectivATI not found" );
		 _GetVertexAttribArrayObjectivATI( index, pname, @params );
		}
	}
}
