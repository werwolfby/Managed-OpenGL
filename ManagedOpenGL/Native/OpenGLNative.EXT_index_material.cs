using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_index_materialInit()
		{
			_IndexMaterialEXT = GetProcAdress< IndexMaterialEXTDelegate >( "glIndexMaterialEXT" );
			
		}
		
	
		public delegate void IndexMaterialEXTDelegate( MaterialFace face, uint mode ); //  extension method
		private static IndexMaterialEXTDelegate _IndexMaterialEXT;
		
		public static  void IndexMaterialEXT( MaterialFace face, uint mode )
		{
			if (_IndexMaterialEXT == null) throw new Exception( "Extension method IndexMaterialEXT not found" );
			 _IndexMaterialEXT( face, mode );
		}
	}
}

