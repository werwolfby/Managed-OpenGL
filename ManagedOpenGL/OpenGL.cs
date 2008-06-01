/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 30.05.2008 19:28
 *
 * File: OpenGL.cs
 * Remarks:
 * 
 * History:
 *   30.05.2008 19:28 - Create Wireframe
 *
 *******************************************************/

using System;

namespace ManagedOpenGL
{
	public class OpenGL
	{
		public static unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels )
		{
			OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, type, (void*)pixels );
		}

		public static void CallLists( byte[] bytes )
		{
			CallLists( bytes, bytes.Length );
		}

		public static unsafe void CallLists( byte[] bytes, int length )
		{
			fixed (byte *point = &bytes[0])
			{
				OpenGLNative.CallLists( length, ListNameType.UnsignedByte, point );
			}
		}
	}
}