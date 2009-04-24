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
using System.Collections;
using System.Collections.Generic;

namespace ManagedOpenGL.Engine.Shaders
{
	public class ShaderProgram : IEnumerable<Shader>
	{
		private uint handle;
		private readonly List<Shader> shaders = new List<Shader>();

		public bool Linked { get; private set; }

		public string InfoLog
		{
			get
			{
				return OpenGL.GetInfoLog( handle );
			}
		}

		public void Add( Shader shader )
		{
			this.shaders.Add( shader );
		}

		public void Load()
		{
			this.handle = OpenGLNative.CreateProgramObjectARB();
			foreach (var shader in this)
			{
				shader.Load();
				Attach( shader );
			}
		}

		public void Attach( Shader shader )
		{
			OpenGLNative.AttachObjectARB( handle, shader.Handle );
		}

		public void Compile()
		{
			foreach (var shader in shaders)
			{
				shader.TryCompile();
			}
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
			var location = TryGetUniformLocation( name );
			if (location == -1) throw new Exception( "Can't find uniform variable: " + name );
			return location;
		}

		protected int TryGetUniformLocation( string name )
		{
			return OpenGLNative.GetUniformLocationARB( handle, name );
		}

		protected int GetAttribLocation( string name )
		{
			var location = TryGetAttribLocation( name );
			if (location == -1) throw new Exception( "Can't find attribute variable: " + name );
			return location;
		}

		protected int TryGetAttribLocation( string name )
		{
			return OpenGLNative.GetAttribLocationARB( handle, name );
		}

		public static void UnUse()
		{
			OpenGLNative.UseProgramObjectARB( 0 );
		}

		public IEnumerator<Shader> GetEnumerator()
		{
			return this.shaders.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public static T Create<T>( string vertFileName, string fragFileName )
			where T : ShaderProgram, new()
		{
			return new T { VertexShader.Load( vertFileName ), FragmentShader.Load( fragFileName ) };
		}
	}
}