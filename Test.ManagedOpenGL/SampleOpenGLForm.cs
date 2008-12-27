/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 11.06.2008 14:47
 *
 * File: SampleOpenGLForm.cs
 * Remarks:
 * 
 * History:
 *   11.06.2008 14:47 - Create Wireframe
 *
 *******************************************************/

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL
{
	public class SampleOpenGLForm : OpenGLForm
	{
		protected delegate void KeyPressedProcessDelegate( float elapsed );

		protected readonly TwoDirCamera camera = new TwoDirCamera
		                                         {
		                                         	VelocitySpeed = 20,
		                                         	StrafeSpeed = 20,
		                                         };

		private readonly Dictionary<Keys, KeyPressedProcessDelegate> keyPressedProcessor = new Dictionary<Keys, KeyPressedProcessDelegate>();
		private readonly Dictionary<Keys, KeyPressedProcessDelegate> keyUnpressedProcessor = new Dictionary<Keys, KeyPressedProcessDelegate>();

		protected readonly ItemsManager itemsManager = new ItemsManager();

		public SampleOpenGLForm()
		{
			this.WindowSize = new Size( 640, 480 );
			Renderer.Near = 1;
			Renderer.Far = 400;

			Cursor.Position = this.PointToScreen( new Point( this.ClientSize.Width / 2, this.ClientSize.Height / 2 ) );

			this.RegisterPressed( Keys.A, elapsed => camera.MoveLeft( elapsed ) );
			this.RegisterPressed( Keys.D, elapsed => camera.MoveRight( elapsed ) );
			this.RegisterPressed( Keys.W, elapsed => camera.MoveForward( elapsed ) );
			this.RegisterPressed( Keys.S, elapsed => camera.MoveBack( elapsed ) );

			this.RegisterPressed( Keys.Space, elapsed => camera.MoveUp( elapsed ) );
			this.RegisterPressed( Keys.ControlKey, elapsed => camera.MoveDown( elapsed ) );
			
			this.RegisterPressed( Keys.C, elapsed => camera.Position.Set( 0, 0, 0 ) );

			this.RegisterPressed( Keys.ShiftKey, elapsed =>
			                                     {
			                                     	camera.VelocitySpeed = 200;
			                                     	camera.StrafeSpeed = 200;
			                                     	camera.LiftSpeed = 200;
			                                     }
				);
			this.RegisterUnpressed( Keys.ShiftKey, elapsed =>
			                                       {
			                                       	camera.VelocitySpeed = 20;
			                                       	camera.StrafeSpeed = 20;
			                                     	camera.LiftSpeed = 20;
			                                       } );
		}

		protected void RegisterPressed( Keys key, KeyPressedProcessDelegate processDelegate )
		{
			this.keyPressedProcessor[key] = processDelegate;
		}

		protected void RegisterUnpressed( Keys key, KeyPressedProcessDelegate processDelegate )
		{
			this.keyUnpressedProcessor[key] = processDelegate;
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			itemsManager.Load();
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

			OpenGLNative.ClearColor( 0, 0, 0, 1 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadMatrixf( camera.Data );

			OpenGLNative.Enable( EnableCap.DepthTest );
			OpenGLNative.Enable( EnableCap.CullFace );
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			foreach (var keyValuePair in keyPressedProcessor)
			{
				if (Keyboard.GetValue( keyValuePair.Key )) keyValuePair.Value( elapsed );
			}

			foreach (var keyValuePair in keyUnpressedProcessor)
			{
				if (!Keyboard.GetValue( keyValuePair.Key )) keyValuePair.Value( elapsed );
			}
		}
	}
}