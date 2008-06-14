/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 12.06.2008 11:06
 *
 * File: ShaderProgram.cs
 * Remarks:
 * 
 * History:
 *   12.06.2008 11:06 - Create Wireframe
 *
 *******************************************************/

using System;

namespace ManagedOpenGL.Engine.Shaders
{
	public class ShaderProgram
	{
		private uint handle;

		//~ShaderProgram()
		//{
		//    OpenGLNative.DeleteProgramsARB( 1, new[] { handle } );
		//}

		public bool Linked { get; private set; }

		public string InfoLog
		{
			get
			{
				return OpenGL.GetInfoLog( handle );
			}
		}

		public void Load()
		{
			this.handle = OpenGLNative.CreateProgramObjectARB();
		}

		public void Attach( Shader shader )
		{
			OpenGLNative.AttachObjectARB( handle, shader.Handle );
		}

		public void Link()
		{
			OpenGLNative.LinkProgram( handle );
			var result = new int[1];
			OpenGLNative.GetObjectParameterivARB( handle, (uint)VERSION_2_0.LinkStatus, result );
			Linked = result[0] != 0;
			if (Linked) AfterLink();
		}

		public void TryLink()
		{
			Link();
			if (!Linked) throw new Exception( "Error link progrma: " + InfoLog );
		}

		protected virtual void AfterLink()
		{
		}

		public virtual void Use()
		{
			OpenGLNative.UseProgramObjectARB( handle );
		}

		protected int GetUniformLocation( string name )
		{
			return OpenGLNative.GetUniformLocationARB( handle, name );
		}

		protected int GetAttribLocation( string name )
		{
			return OpenGLNative.GetAttribLocationARB( handle, name );
		}

		public static void UnUse()
		{
			OpenGLNative.UseProgramObjectARB( 0 );
		}
	}
}