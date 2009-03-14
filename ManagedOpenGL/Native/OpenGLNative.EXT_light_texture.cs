using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_light_textureInit()
		{



		}


		[DllImport( "opengl32.dll", EntryPoint="glApplyTextureEXT" )]
		public static extern void ApplyTextureEXT( uint mode ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTextureLightEXT" )]
		public static extern void TextureLightEXT( uint pname ); // 
		[DllImport( "opengl32.dll", EntryPoint="glTextureMaterialEXT" )]
		public static extern void TextureMaterialEXT( MaterialFace face, MaterialParameter mode ); // 
	}
}
