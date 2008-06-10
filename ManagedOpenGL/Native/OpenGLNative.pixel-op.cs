using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativepixel_opInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glAlphaFunc" )]
		public static extern void AlphaFunc( AlphaFunction func, float @ref ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBlendFunc" )]
		public static extern void BlendFunc( BlendingFactorSrc sfactor, BlendingFactorDest dfactor ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLogicOp" )]
		public static extern void LogicOp( LogicOp opcode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilFunc" )]
		public static extern void StencilFunc( StencilFunction func, int @ref, uint mask ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glStencilOp" )]
		public static extern void StencilOp( StencilOp fail, StencilOp zfail, StencilOp zpass ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glDepthFunc" )]
		public static extern void DepthFunc( DepthFunction func ); // 	
	}
}

