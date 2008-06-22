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
	public static class OpenGL
	{
		public static unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels )
		{
			OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, type, (void*)pixels );
		}

		public static unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, byte[] pixels )
		{
			if (pixels == null) OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, type, null );
			else fixed (byte* bytes = &pixels[0])
			{
				OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, type, bytes );
			}
		}

		public static unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, byte[] pixels )
		{
			fixed (byte *pix = &pixels[0])
			{
				OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, PixelType.UnsignedByte,
				                         pix );
			}
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

		public static string GetInfoLog( uint obj )
		{
			var results = new int[1];
			OpenGLNative.GetObjectParameterivARB( obj, (uint)ARB_shader_objects.ObjectInfoLogLengthArb, results );
			var infoLog = new char[results[0]];
			int[] length = new int[1];
			OpenGLNative.GetInfoLogARB( obj, infoLog.Length, length, infoLog );
			return new string( infoLog, 0, Array.FindIndex( infoLog, c => c == char.MinValue ) );
			//return infoLog;
		}

		public static void Assert()
		{
			var errorCode = OpenGLNative.GetError();
			if (errorCode != ErrorCode.NoError) throw new Exception( errorCode.ToString() );
		}
	}
}