/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 11:10
 *
 * File: SkyBoxSampleForm.cs
 * Remarks:
 * 
 * History:
 *   31.05.2008 11:10 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.SkyBoxSample
{
	public class SkyBoxSampleForm : SampleOpenGLForm
	{
		private readonly Texture2D back1   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front1  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left1   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right1  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom1 = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top1    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly Texture2D back2   = new Texture2D( @"Data\SkyBox\CubeMap1\back.jpg" );
		private readonly Texture2D front2  = new Texture2D( @"Data\SkyBox\CubeMap1\front.jpg" );
		private readonly Texture2D left2   = new Texture2D( @"Data\SkyBox\CubeMap1\left.jpg" );
		private readonly Texture2D right2  = new Texture2D( @"Data\SkyBox\CubeMap1\right.jpg" );
		private readonly Texture2D bottom2 = new Texture2D( @"Data\SkyBox\CubeMap1\bottom.jpg" );
		private readonly Texture2D top2    = new Texture2D( @"Data\SkyBox\CubeMap1\top.jpg" );

		private readonly Skybox skybox1;
		private readonly Skybox skybox2;

		private Skybox currentSkybox;

		public SkyBoxSampleForm()
		{
			this.skybox1 = new Skybox( 200, 200, 200, this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 );
			this.skybox2 = new Skybox( 200, 200, 200, this.back2, this.front2, this.left2, this.right2, this.bottom2, this.top2 );

			this.currentSkybox = this.skybox1;

			WindowSize = new Size( 640, 480 );

			this.RegisterPressed( Keys.D1, elapsed => currentSkybox = skybox1 );
			this.RegisterPressed( Keys.D2, elapsed => currentSkybox = skybox2 );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			var textures = new[]
			               {
			               	this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1,
			               	this.back2, this.front2, this.left2, this.right2, this.bottom2, this.top2,
			               };
			foreach (var texture in textures)
			{
				texture.Load();
				texture.WrapS = TextureWrapMode.ClampToEdgeSgis;
				texture.WrapT = TextureWrapMode.ClampToEdgeSgis;
			}
		}

		protected override void Draw() 
		{
			base.Draw();

			OpenGLNative.Enable( EnableCap.Texture2d );
			this.currentSkybox.Draw();
		}
	}
}