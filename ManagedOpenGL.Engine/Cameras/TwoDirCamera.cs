/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:59
 *
 * File: TwoDirCamera.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 15:28 - Create Wireframe
 *   31.05.2008 10:59 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using ManagedOpenGL.Engine.Math;

namespace ManagedOpenGL.Engine.Cameras
{
	public class TwoDirCamera : FreeCamera
	{
		protected EulerAngle2F eyeDirection = new EulerAngle2F();
		protected Matrix3F rotInvert = new Matrix3F();

		protected float pitchSensitivity = 0.0022f;
		protected float yawSensitivity = 0.0022f;

		public float PitchSensitivity
		{
			get { return this.pitchSensitivity; }
			set { this.pitchSensitivity = value; }
		}

		public float YawSensitivity
		{
			get { return this.yawSensitivity; }
			set { this.yawSensitivity = value; }
		}

		public override void Move( float x, float y, float z )
		{
			throw new System.NotImplementedException();
		}

		public override void MoveLeft( float delta )
		{
			var moveSpeed = -delta * streafeSpeed;

			this.Position.X += rotInvert[0] * moveSpeed;
			this.Position.Y += rotInvert[1] * moveSpeed;
			this.Position.Z += rotInvert[2] * moveSpeed;
		}

		public override void MoveRight( float delta )
		{
			var moveSpeed = +delta * streafeSpeed;

			this.Position.X += rotInvert[0] * moveSpeed;
			this.Position.Y += rotInvert[1] * moveSpeed;
			this.Position.Z += rotInvert[2] * moveSpeed;
		}

		public override void MoveForward( float delta )
		{
			var moveSpeed = -delta * velocitySpeed;

			this.Position.X += rotInvert[6] * moveSpeed;
			this.Position.Y += rotInvert[7] * moveSpeed;
			this.Position.Z += rotInvert[8] * moveSpeed;
		}

		public override void MoveBack( float delta )
		{
			var moveSpeed = +delta * velocitySpeed;

			this.Position.X += rotInvert[6] * moveSpeed;
			this.Position.Y += rotInvert[7] * moveSpeed;
			this.Position.Z += rotInvert[8] * moveSpeed;
		}

		public override void MoveUp( float delta )
		{
			var moveSpeed = -delta * liftSpeed;

			this.Position.X += rotInvert[3] * moveSpeed;
			this.Position.Y += rotInvert[4] * moveSpeed;
			this.Position.Z += rotInvert[5] * moveSpeed;
		}

		public override void MoveDown( float delta )
		{
			var moveSpeed =  delta * velocitySpeed;

			this.Position.X += rotInvert[6] * moveSpeed;
			this.Position.Y += rotInvert[7] * moveSpeed;
			this.Position.Z += rotInvert[8] * moveSpeed;
		}

		public override void TurnLeft( float delta )
		{
			eyeDirection.Pitch += -delta * pitchSensitivity;
			eyeDirection.SetToMatrix( modelViewMatrix );
			eyeDirection.SetInvertToMatrix( rotInvert );

			SetPosition();
		}

		public override void TurnRight( float delta )
		{
			eyeDirection.Pitch += +delta * pitchSensitivity;
			eyeDirection.SetToMatrix( modelViewMatrix );
			eyeDirection.SetInvertToMatrix( rotInvert );

			SetPosition();
		}

		public override void LookDown( float delta )
		{
			eyeDirection.Yaw += -delta * yawSensitivity;
			eyeDirection.SetToMatrix( modelViewMatrix );
			eyeDirection.SetInvertToMatrix( rotInvert );

			SetPosition();
		}

		public override void LookUp( float delta )
		{
			eyeDirection.Yaw += +delta * yawSensitivity;
			eyeDirection.SetToMatrix( modelViewMatrix );
			eyeDirection.SetInvertToMatrix( rotInvert );

			SetPosition();
		}
	}
}