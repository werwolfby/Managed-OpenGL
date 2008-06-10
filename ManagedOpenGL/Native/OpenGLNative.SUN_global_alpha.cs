using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSUN_global_alphaInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorbSUN" )]
		public static extern void GlobalAlphaFactorbSUN( sbyte factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorsSUN" )]
		public static extern void GlobalAlphaFactorsSUN( short factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactoriSUN" )]
		public static extern void GlobalAlphaFactoriSUN( int factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorfSUN" )]
		public static extern void GlobalAlphaFactorfSUN( float factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactordSUN" )]
		public static extern void GlobalAlphaFactordSUN( double factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorubSUN" )]
		public static extern void GlobalAlphaFactorubSUN( byte factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactorusSUN" )]
		public static extern void GlobalAlphaFactorusSUN( ushort factor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glGlobalAlphaFactoruiSUN" )]
		public static extern void GlobalAlphaFactoruiSUN( uint factor ); // 	
	}
}

