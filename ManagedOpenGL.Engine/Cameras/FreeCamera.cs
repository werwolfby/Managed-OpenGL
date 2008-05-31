/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:58
 *
 * File: FreeCamera.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 15:23 - Create Wireframe
 *   31.05.2008 10:58 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Cameras
{
	public abstract class FreeCamera : Camera
	{
		protected float velocitySpeed = 1;
		protected float streafeSpeed = 1;
		protected float liftSpeed = 1;

		public abstract void Move( float x, float y, float z );

		public abstract void MoveLeft( float delta );
		public abstract void MoveRight( float delta );

		public abstract void MoveForward( float delta );
		public abstract void MoveBack( float delta );

		public abstract void MoveUp( float delta );
		public abstract void MoveDown( float delta );

		public abstract void TurnLeft( float delta );
		public abstract void TurnRight( float delta );

		public abstract void LookUp( float delta );
		public abstract void LookDown( float delta );

		public float VelocitySpeed
		{
			get { return this.velocitySpeed; }
			set { this.velocitySpeed = value; }
		}

		public float StreafeSpeed
		{
			get { return this.streafeSpeed; }
			set { this.streafeSpeed = value; }
		}

		public float LiftSpeed
		{
			get { return this.liftSpeed; }
			set { this.liftSpeed = value; }
		}
	}
}