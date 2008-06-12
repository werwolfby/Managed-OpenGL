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
			AfterLink();
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
	}
}