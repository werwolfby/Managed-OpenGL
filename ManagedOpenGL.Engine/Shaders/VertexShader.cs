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
 *
 *******************************************************/

using System.IO;

namespace ManagedOpenGL.Engine.Shaders
{
	public class VertexShader : Shader
	{
		public VertexShader( string source ) : base( source ) {}

		public override void Load()
		{
			this.Load( VERSION_2_0.VertexShader );
		}

		public static VertexShader Load( string fileName )
		{
			using (var stream = new StreamReader( fileName )) return new VertexShader( stream.ReadToEnd() );
		}
	}
}