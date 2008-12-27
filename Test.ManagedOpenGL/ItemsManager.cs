/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.06.2008 11:55
 *
 * File: ItemsManager.cs
 * Remarks:
 * 
 * History:
 *   24.06.2008 11:55 - Create Wireframe
 *
 *******************************************************/

using System.Collections.Generic;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL
{
	public class ItemsManager
	{
		private readonly List<Texture2D> textures = new List<Texture2D>();
		private readonly List<Shader> shaders = new List<Shader>();
		private readonly List<ShaderProgram> programs = new List<ShaderProgram>();

		public void Add( Texture2D texture2D )
		{
			this.textures.Add( texture2D );
		}

		public void Add( Shader shader )
		{
			this.shaders.Add( shader );
		}

		public void Add( ShaderProgram program )
		{
			this.programs.Add( program );
		}

		public void Load()
		{
			foreach (var texture in textures)
			{
				texture.Load();
			}

			foreach (var shader in shaders)
			{
				shader.Load();
				shader.TryCompile();
			}

			foreach (var program in programs)
			{
				program.Load();
				program.Compile();
				program.TryLink();
			}
		}
	}

	public static class ItemsManagerExtension
	{
		public static Texture2D ApplyTexture( this Texture2D texture2D, ItemsManager manager )
		{
			manager.Add( texture2D );
			return texture2D;
		}

		public static T ApplyShader<T>( this T shader, ItemsManager manager )
			where T : Shader
		{
			manager.Add( shader );
			return shader;
		}

		public static T ApplyProgram<T>( this T program, ItemsManager manager )
			where T : ShaderProgram
		{
			manager.Add( program );
			return program;
		}
	}
}