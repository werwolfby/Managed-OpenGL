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
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.SkyBoxSample
{
	public class SkyBoxSampleForm : OpenGLForm
	{
		private readonly Texture2D backTexture   = new Texture2D( @"Data\SkyBox\back.jpg" );
		private readonly Texture2D frontTexture  = new Texture2D( @"Data\SkyBox\front.jpg" );
		private readonly Texture2D leftTexture   = new Texture2D( @"Data\SkyBox\left.jpg" );
		private readonly Texture2D rightTexture  = new Texture2D( @"Data\SkyBox\right.jpg" );
		private readonly Texture2D topTexture    = new Texture2D( @"Data\SkyBox\top.jpg" );
		private readonly Texture2D bottomTexture = new Texture2D( @"Data\SkyBox\bottom.jpg" );

		private readonly TwoDirCamera camera = new TwoDirCamera
		                                       {
		                                       	VelocitySpeed = 20,
		                                       	StreafeSpeed = 20
		                                       };

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			backTexture.Load();
			frontTexture.Load();
			leftTexture.Load();
			rightTexture.Load();
			topTexture.Load();
			bottomTexture.Load();

			var textures = new[] { backTexture, frontTexture, leftTexture, rightTexture, topTexture, bottomTexture };
			foreach (var texture in textures)
			{
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

			var width = 100;
			var height = 100;
			var length = 100;

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadMatrixf( camera.Data );

			OpenGLNative.Enable( EnableCap.Texture2d );
			OpenGLNative.Enable( EnableCap.CullFace );

			// Back Plane
			backTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.End();

			// Front Plane
			frontTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.End();

			// Left Plane
			leftTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.End();

			// Right Plane
			rightTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.End();

			// Top Plane
			topTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, + height / 2.0f, + length / 2.0f );

			OpenGLNative.End();

			// Bottom Plane
			bottomTexture.Use();
			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.TexCoord2f( 1, 0 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 0 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, + length / 2.0f );

			OpenGLNative.TexCoord2f( 0, 1 );
			OpenGLNative.Vertex3f( + width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.TexCoord2f( 1, 1 );
			OpenGLNative.Vertex3f( - width / 2.0f, - height / 2.0f, - length / 2.0f );

			OpenGLNative.End();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.A )) camera.MoveLeft( elapsed );
			if (Keyboard.GetValue( Keys.D )) camera.MoveRight( elapsed );
			if (Keyboard.GetValue( Keys.W )) camera.MoveForward( elapsed );
			if (Keyboard.GetValue( Keys.S )) camera.MoveBack( elapsed );
		}
	}
}