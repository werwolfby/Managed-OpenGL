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
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.SkyBoxSample
{
	public class SkyBoxSampleForm : OpenGLForm
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

		private readonly TwoDirCamera camera = new TwoDirCamera
		                                       {
		                                       	VelocitySpeed = 20,
		                                       	StrafeSpeed = 20
		                                       };

		private readonly Skybox skybox1;
		private readonly Skybox skybox2;

		private Skybox currentSkybox;

		public SkyBoxSampleForm()
		{
			this.skybox1 = new Skybox( 200, 200, 200, this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1 );
			this.skybox2 = new Skybox( 200, 200, 200, this.back2, this.front2, this.left2, this.right2, this.bottom2, this.top2 );

			this.currentSkybox = this.skybox1;

			WindowSize = new Size( 640, 480 );
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

		protected override void InitPerspective() 
		{
			OpenGLNative.MatrixMode( MatrixMode.Projection );
			OpenGLNative.LoadIdentity();
			WindowsOpenGLNative.gluPerspective( 45, (double)this.ClientSize.Width / this.ClientSize.Height, 1, 250 );
			OpenGLNative.Viewport( 0, 0, this.ClientSize.Width, this.ClientSize.Height );
		}

		protected override void OnMouseMove( MouseEventArgs e ) 
		{
			base.OnMouseMove( e );

			var oldPosition = this.PointToClient( Cursor.Position );
			var centerPosition = new Point( ClientSize.Width / 2, ClientSize.Height / 2 );

			if (oldPosition == centerPosition) return;

			var deltaX = - oldPosition.X + centerPosition.X;
			var deltaY = - oldPosition.Y + centerPosition.Y;

			camera.TurnLeft( deltaX );
			camera.LookUp( deltaY );

			Cursor.Position = this.PointToScreen( centerPosition );
		}

		protected override void Draw() 
		{
			base.Draw();

			OpenGLNative.ClearColor( 0, 0, 0, 0 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadMatrixf( camera.Data );

			OpenGLNative.Enable( EnableCap.Texture2d );
			this.currentSkybox.Draw();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.D1 )) currentSkybox = skybox1;
			if (Keyboard.GetValue( Keys.D2 )) currentSkybox = skybox2;

			if (Keyboard.GetValue( Keys.A )) camera.MoveLeft( elapsed );
			if (Keyboard.GetValue( Keys.D )) camera.MoveRight( elapsed );
			if (Keyboard.GetValue( Keys.W )) camera.MoveForward( elapsed );
			if (Keyboard.GetValue( Keys.S )) camera.MoveBack( elapsed );
			
			if (Keyboard.GetValue( Keys.C ))
			{
				camera.Position.Set( 0, 0, 0 );
				camera.Pitch = 0;
				camera.Yaw = 0;
			}
		}
	}
}