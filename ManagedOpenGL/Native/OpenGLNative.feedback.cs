using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativefeedbackInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glFeedbackBuffer" )]
		public static extern void FeedbackBuffer( int size, FeedbackType type, [Out]float[] buffer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glSelectBuffer" )]
		public static extern void SelectBuffer( int size, [Out]uint[] buffer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glRenderMode" )]
		public static extern int RenderMode( RenderingMode mode ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glInitNames" )]
		public static extern void InitNames(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glLoadName" )]
		public static extern void LoadName( uint name ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPassThrough" )]
		public static extern void PassThrough( float token ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPopName" )]
		public static extern void PopName(  ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glPushName" )]
		public static extern void PushName( uint name ); // 	
	}
}

