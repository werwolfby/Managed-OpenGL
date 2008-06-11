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

using System.Drawing;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL
{
	public class SampleOpenGLForm : OpenGLForm
	{
		protected readonly TwoDirCamera camera = new TwoDirCamera
		                                         {
		                                         	VelocitySpeed = 20,
		                                         	StrafeSpeed = 20,
		                                         };

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

			if (Keyboard.GetValue( Keys.ShiftKey ))
			{
				camera.VelocitySpeed = 200;
				camera.StrafeSpeed = 200;
			}
			else
			{
				camera.VelocitySpeed = 20;
				camera.StrafeSpeed = 20;
			}
		}
	}
}