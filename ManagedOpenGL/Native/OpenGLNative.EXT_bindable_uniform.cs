using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_bindable_uniformInit()
		{
			_UniformBufferEXT = GetProcAdress< UniformBufferEXTDelegate >( "glUniformBufferEXT" );
			_GetUniformBufferSizeEXT = GetProcAdress< GetUniformBufferSizeEXTDelegate >( "glGetUniformBufferSizeEXT" );
			_GetUniformOffsetEXT = GetProcAdress< GetUniformOffsetEXTDelegate >( "glGetUniformOffsetEXT" );
			
		}
		
	
		public delegate void UniformBufferEXTDelegate( uint program, int location, uint buffer ); //  extension method
		private static UniformBufferEXTDelegate _UniformBufferEXT;
		
		public static  void UniformBufferEXT( uint program, int location, uint buffer )
		{
			if (_UniformBufferEXT == null) throw new Exception( "Extension method UniformBufferEXT not found" );
			 _UniformBufferEXT( program, location, buffer );
		}
		public delegate int GetUniformBufferSizeEXTDelegate( uint program, int location ); //  extension method
		private static GetUniformBufferSizeEXTDelegate _GetUniformBufferSizeEXT;
		
		public static  int GetUniformBufferSizeEXT( uint program, int location )
		{
			if (_GetUniformBufferSizeEXT == null) throw new Exception( "Extension method GetUniformBufferSizeEXT not found" );
			return  _GetUniformBufferSizeEXT( program, location );
		}
		public delegate int GetUniformOffsetEXTDelegate( uint program, int location ); //  extension method
		private static GetUniformOffsetEXTDelegate _GetUniformOffsetEXT;
		
		public static  int GetUniformOffsetEXT( uint program, int location )
		{
			if (_GetUniformOffsetEXT == null) throw new Exception( "Extension method GetUniformOffsetEXT not found" );
			return  _GetUniformOffsetEXT( program, location );
		}
	}
}

