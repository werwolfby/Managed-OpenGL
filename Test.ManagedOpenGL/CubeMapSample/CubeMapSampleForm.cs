/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 07.06.2008 11:22
 *
 * File: CubeMapSampleForm.cs
 * Remarks:
 * 
 * History:
 *   07.06.2008 11:22 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.CubeMapSample
{
	public class CubeMapSampleForm : SampleOpenGLForm
	{
		private const float SphereRadius = 10;
		private const int SphereSlices = 32;
		private const int SphereStacks = 32;

		private readonly Texture2D back1   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front1  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left1   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right1  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom1 = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top1    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly TextureCubeMap cubeMap = TextureCubeMap.CreateFromFolder( @"Data\SkyBox\CubeMap2", "png" );
		private readonly Cube cube = new Cube( SphereRadius*2, SphereRadius*2, SphereRadius*2 );
		private readonly Sphere sphere = new Sphere( SphereRadius, SphereSlices, SphereStacks );
		private DrawObject currentObject;
		private readonly Skybox skybox;

		public CubeMapSampleForm()
		{
			this.skybox = new Skybox( 300, 300, 300, this.back1, front1, left1, right1, bottom1, top1 );
			WindowSize = new Size( 640, 480 );
			Renderer.Far = 1000;
			Renderer.Near = 1;
			camera.Position.Set( 0, 0, 50 );

			this.currentObject = sphere;

			this.RegisterPressed( Keys.D1, elapsed => currentObject = cube );
			this.RegisterPressed( Keys.D2, elapsed => currentObject = sphere );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			this.cubeMap.Load();

			foreach (var texture in new[] { this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 })
			{
				texture.Load();
				texture.WrapS = TextureWrapMode.ClampToEdgeSgis;
				texture.WrapT = TextureWrapMode.ClampToEdgeSgis;
			}
		}

		protected override void Draw() 
		{
			base.Draw();

			gl.Enable( EnableCap.Texture2d );
            skybox.Draw();
            gl.Disable( EnableCap.Texture2d );

			gl.MatrixMode( MatrixMode.Texture );
			gl.PushMatrix();
			gl.LoadIdentity();
			gl.Scalef( 1, 1, -1 );
			gl.MultMatrixf( camera.InvertData );

			gl.MatrixMode( MatrixMode.Modelview );
			
			this.cubeMap.Use();
			currentObject.Draw();
			TextureCubeMap.UnUse();

			gl.MatrixMode( MatrixMode.Texture );
			gl.PopMatrix();
			gl.MatrixMode( MatrixMode.Modelview );
		}
	}
}