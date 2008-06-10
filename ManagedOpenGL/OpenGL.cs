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
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static class OpenGL
	{
		static OpenGL()
		{
			//GetObjectParameterivARB = OpenGLNative.GetProcAdress<GetObjectParameterivARBDelegate>( "glGetObjectParameterivARB" );
			//GetInfoLogARB = OpenGLNative.GetProcAdress<GetInfoLogARBDelegate>( "glGetInfoLogARB" );
		}

		public static unsafe void TexImage2D( TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels )
		{
			OpenGLNative.TexImage2D( target, level, internalformat, width, height, border, format, type, (void*)pixels );
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

		//public delegate void GetObjectParameterivARBDelegate( uint obj, ARB_shader_objects pname, [Out]int[] @params ); //  extension method
		//public static readonly GetObjectParameterivARBDelegate GetObjectParameterivARB;

		//public delegate void GetInfoLogARBDelegate( uint obj, int maxLength, out int length, [Out]char[] infoLog ); //  extension method
		//public static readonly GetInfoLogARBDelegate GetInfoLogARB;
	}
}