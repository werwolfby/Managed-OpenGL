/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 12.06.2008 11:05
 *
 * File: FragmentShader.cs
 * Remarks:
 * 
 * History:
 *   12.06.2008 11:05 - Create Wireframe
 *
 *******************************************************/

using System.IO;

namespace ManagedOpenGL.Engine.Shaders
{
	public class FragmentShader : Shader
	{
		public FragmentShader( string source ) : base( source ) {}

		public override void Load() 
		{
			Load( VERSION_2_0.FragmentShader );
		}

		public static FragmentShader Load( string fileName )
		{
			using (var stream = new StreamReader( fileName )) return new FragmentShader( stream.ReadToEnd() );
		}
	}
}