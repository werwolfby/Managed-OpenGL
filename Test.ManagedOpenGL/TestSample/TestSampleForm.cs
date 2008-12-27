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

		public TestSampleForm()
		{
			this.camera.Move( 0, 0, 50 );
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			cubeMap.Load();

			skybox.Load();

			font.Load();
		}

		protected override void Draw()
		{
			base.Draw();

            Renderer.RenderMode = RenderMode.MODE_3D;

			gl.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Decal );
            
			cubeMap.Use();
			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.PushMatrix();
			OpenGLNative.LoadIdentity();
			OpenGLNative.Scalef( 1, 1, -1 );
			OpenGLNative.MultMatrixf( camera.InvertData );
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			cube.Draw();
			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.PopMatrix();
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			TextureCubeMap.UnUse();

			gl.Enable( EnableCap.Texture2d );
			gl.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Modulate );
			gl.Color3f( 0.5f, 0.5f, 0.5f );
			skybox.Draw();
			gl.Disable( EnableCap.Texture2d );

			Renderer.RenderMode = RenderMode.MODE_2D;

			gl.Color3f( 1, 0, 0 );

			font.FontSize = 20;
			font.WriteLine( "Just String" );
		}
	}
}