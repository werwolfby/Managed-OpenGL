/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 12.06.2008 10:56
 *
 * File: VertexShader.cs
 * Remarks:
 * 
 * History:
 *   12.06.2008 10:56 - Create Wireframe
 *   12.06.2008 11:04 - Extracted as base class from `VertexShader`
 *
 *******************************************************/

using System;

namespace ManagedOpenGL.Engine.Shaders
{
	public abstract class Shader 
	{
		protected Shader( string source ) 
		{
			this.Source = source;
		}

		//~Shader()
		//{
		//    OpenGLNative.DeleteObjectARB( Handle );
		//}

		public string Source { get; private set; }
		public bool Compiled { get; private set; }

		public string InfoLog
		{
			get
			{
				return OpenGL.GetInfoLog( this.Handle );
			}
		}

		internal uint Handle { get; private set; }

		public abstract void Load();

		protected void Load( VERSION_2_0 shaderType ) 
		{
			this.Handle = OpenGLNative.CreateShaderObjectARB( (uint)shaderType );
			OpenGLNative.ShaderSourceARB( this.Handle, 1, new[] { this.Source }, null );
		}

		public void Compile()
		{
			OpenGLNative.CompileShaderARB( this.Handle );
			var result = new int[1];
			OpenGLNative.GetObjectParameterivARB( this.Handle, (uint)ARB_shader_objects.ObjectCompileStatusArb, result );
			this.Compiled = result[0] != 0;
		}

		public void TryCompile()
		{
			Compile();
			if (!Compiled) throw new Exception( "Error compile shader: " + InfoLog );
		}
	}
}