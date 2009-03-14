using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativePGI_misc_hintsInit()
		{

		}


		[DllImport( "opengl32.dll", EntryPoint="glHintPGI" )]
		public static extern void HintPGI( uint target, int mode ); // 
	}
}
