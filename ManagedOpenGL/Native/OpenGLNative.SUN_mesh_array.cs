using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSUN_mesh_arrayInit()
		{

		}


		[DllImport( "opengl32.dll", EntryPoint="glDrawMeshArraysSUN" )]
		public static extern void DrawMeshArraysSUN( BeginMode mode, int first, int count, int width ); // 
	}
}
