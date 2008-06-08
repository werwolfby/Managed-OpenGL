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
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.CubeMapSample
{
	public class CubeMapSampleForm : OpenGLForm
	{
		private readonly Texture2D back1   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front1  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left1   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right1  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom1 = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top1    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly TextureCubeMap textureCubeMap = new TextureCubeMap( @"Data\SkyBox\CubeMap2\back.png",
		                                                                     @"Data\SkyBox\CubeMap2\front.png",
		                                                                     @"Data\SkyBox\CubeMap2\left.png",
		                                                                     @"Data\SkyBox\CubeMap2\right.png",
		                                                                     @"Data\SkyBox\CubeMap2\bottom.png",
		                                                                     @"Data\SkyBox\CubeMap2\top.png" );

		private readonly TwoDirCamera camera = new TwoDirCamera
		                                       {
		                                       	VelocitySpeed = 20,
		                                       	StrafeSpeed = 20,
		                                       };
		private readonly Cube cube = new Cube( 20, 20, 20 );
		private readonly Skybox skybox;

		public CubeMapSampleForm()
		{
			this.skybox = new Skybox( 300, 300, 300, this.back1, front1, left1, right1, bottom1, top1 );
			WindowSize = new Size( 640, 480 );
			Renderer.Far = 1000;
			Renderer.Near = 1;
			camera.Position.Set( 0, 0, 50 );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			textureCubeMap.Load();

			var textures = new[]
			               {
			               	this.back1, this.front1, this.left1, this.right1, this.bottom1, this.top1,
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
			OpenGLNative.ClearColor( 0, 0, 0, 0 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadMatrixf( camera.Data );

			OpenGLNative.Enable( EnableCap.Texture2d );
			OpenGLNative.Enable( EnableCap.DepthTest );
			OpenGLNative.Enable( EnableCap.CullFace );

			skybox.Draw();

			OpenGLNative.Disable( EnableCap.Texture2d );
			OpenGLNative.Enable( (EnableCap)VERSION_1_3.TextureCubeMap );

			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.PushMatrix();
			OpenGLNative.LoadIdentity();
			OpenGLNative.Scalef( 1, 1, -1 );
			OpenGLNative.MultMatrixf( camera.InvertData );
			OpenGLNative.MatrixMode( MatrixMode.Modelview );

			textureCubeMap.Use();
			cube.Draw();
			textureCubeMap.UnUse();

			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.PopMatrix();
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
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

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.A )) camera.MoveLeft( elapsed );
			if (Keyboard.GetValue( Keys.D )) camera.MoveRight( elapsed );
			if (Keyboard.GetValue( Keys.W )) camera.MoveForward( elapsed );
			if (Keyboard.GetValue( Keys.S )) camera.MoveBack( elapsed );
			
			if (Keyboard.GetValue( Keys.C )) camera.Position.Set( 0, 0, 0 );
		}
	}
}