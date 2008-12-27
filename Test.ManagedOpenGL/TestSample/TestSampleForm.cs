/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.12.2008 22:33
 *
 * File: TestSampleForm.cs
 * Remarks:
 * 
 * History:
 *   26.12.2008 22:33 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.TestSample
{
	public class TestSampleForm : SampleOpenGLForm
	{
		private readonly Font font = new Font( @"Data\Fonts\Verdana.jpg" ) { FontSize = 20 };

		private readonly TextureCubeMap cubeMap = TextureCubeMap.CreateFromFolder( @"Data\SkyBox\CubeMapTest", "png" );

		private readonly Skybox skybox = Skybox.CreateFromFolder( 100, 100, 100, @"Data\SkyBox\CubeMapTest", "png" );
		private readonly Cube cube = new Cube( 10, 10, 10 );

		private readonly Texture2D logo = new Texture2D( @"Data\Test\Test.bmp" );

		public TestSampleForm()
		{
			this.camera.Move( 0, 0, 50 );
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			cubeMap.Load();

			skybox.Load();

			logo.Load();

			font.Load();
		}

		protected override void Draw()
		{
			base.Draw();

            Renderer.RenderMode = RenderMode.MODE_3D;

			TextureCubeMapBase.UnUse();

			gl.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Decal );

			gl.Enable( EnableCap.Texture2d );
			logo.Use();
			cube.Draw();

			//gl.Begin( BeginMode.Quads );

			//gl.TexCoord2i( 0, 1 );
			//gl.Vertex2f( -20, -20 );

			//gl.TexCoord2i( 1, 1 );
			//gl.Vertex2f( +20, -20 );

			//gl.TexCoord2i( 1, 0 );
			//gl.Vertex2f( +20, +20 );

			//gl.TexCoord2i( 0, 0 );
			//gl.Vertex2f( -20, +20 );

			//gl.End();

			Renderer.RenderMode = RenderMode.MODE_2D;

			gl.Color3f( 1, 0, 0 );

			font.FontSize = 20;
			font.WriteLine( "Just String" );
		}
	}
}