/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 13:21
 *
 * File: CubeMapCamera.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 13:21 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL.Engine.Math;

namespace ManagedOpenGL.Engine.Cameras
{
	public class CubeMapCamera
	{
		private readonly Vector3F position = new Vector3F( 0, 0, 0 );
		private readonly TwoDirCamera leftCamera = new TwoDirCamera { Pitch = -90, Yaw = 0 };
		private readonly TwoDirCamera rightCamera = new TwoDirCamera { Pitch = 90, Yaw = 0 };
		private readonly TwoDirCamera bottomCamera = new TwoDirCamera { Pitch = 0, Yaw = -90 };
		private readonly TwoDirCamera topCamera = new TwoDirCamera { Pitch = 0, Yaw = 90 };
		private readonly TwoDirCamera nearCamera = new TwoDirCamera { Pitch = 180, Yaw = 0 };
		private readonly TwoDirCamera farCamera = new TwoDirCamera { Pitch = 0, Yaw = 0 };

		public CubeMapCamera()
		{
			position.Changed += delegate
			                    {
			                    	leftCamera.Position.Set( position );
									rightCamera.Position.Set( position );
									bottomCamera.Position.Set( position );
									topCamera.Position.Set( position );
									nearCamera.Position.Set( position );
									farCamera.Position.Set( position );
			                    };
		}

		public Vector3F Position
		{
			get { return this.position; }
		}

		public Camera LeftCamera
		{
			get { return this.leftCamera; }
		}

		public Camera RightCamera
		{
			get { return this.rightCamera; }
		}

		public Camera BottomCamera
		{
			get { return this.bottomCamera; }
		}

		public Camera TopCamera
		{
			get { return this.topCamera; }
		}

		public Camera NearCamera
		{
			get { return this.nearCamera; }
		}

		public Camera FarCamera
		{
			get { return this.farCamera; }
		}
	}
}