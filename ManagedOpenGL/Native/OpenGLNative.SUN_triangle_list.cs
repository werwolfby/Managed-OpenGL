using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSUN_triangle_listInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiSUN" )]
		public static extern void ReplacementCodeuiSUN( uint code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeusSUN" )]
		public static extern void ReplacementCodeusSUN( ushort code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeubSUN" )]
		public static extern void ReplacementCodeubSUN( byte code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuivSUN" )]
		public static extern void ReplacementCodeuivSUN( uint[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeusvSUN" )]
		public static extern void ReplacementCodeusvSUN( ushort[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeubvSUN" )]
		public static extern void ReplacementCodeubvSUN( byte[] code ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodePointerSUN" )]
		public static extern unsafe void ReplacementCodePointerSUN( uint type, int stride, void** pointer ); // 	
	}
}

