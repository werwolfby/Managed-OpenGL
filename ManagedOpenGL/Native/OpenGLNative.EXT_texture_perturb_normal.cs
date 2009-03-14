using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_texture_perturb_normalInit()
		{

		}


		[DllImport( "opengl32.dll", EntryPoint="glTextureNormalEXT" )]
		public static extern void TextureNormalEXT( uint mode ); // 
	}
}
