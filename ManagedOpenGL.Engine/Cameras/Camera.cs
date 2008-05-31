/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:56
 *
 * File: Camera.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 15:20 - Create Wireframe
 *   31.05.2008 10:56 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using System;
using ManagedOpenGL.Engine.Math;

namespace ManagedOpenGL.Engine.Cameras
{
	public class Camera
	{
		protected Matrix4F modelViewMatrix = new Matrix4F();
		protected Vector3F position = new Vector3F( 0, 0, 0 );

		public Camera()
		{
			position.Changed += Position_OnChanged;
		}

		public float[] Data
		{
			get { return this.modelViewMatrix.Data; }
		}

		public Matrix4F Matrix
		{
			get
			{
				return this.modelViewMatrix;
			}
		}

		public Vector3F Position
		{
			get { return this.position; }
		}

		public Vector3F XDirection
		{
			get
			{
				return new Vector3F( modelViewMatrix[0], modelViewMatrix[4], modelViewMatrix[08] );
			}
		}

		public Vector3F YDirection
		{
			get
			{
				return new Vector3F( modelViewMatrix[1], modelViewMatrix[5], modelViewMatrix[09] );
			}
		}

		public Vector3F ZDirection
		{
			get
			{
				return new Vector3F( -modelViewMatrix[2], -modelViewMatrix[6], -modelViewMatrix[10] );
			}
		}

		private void Position_OnChanged( object sender, EventArgs e )
		{
			this.SetPosition();
		}

		protected void SetPosition() 
		{
			this.modelViewMatrix.SetPosition( -this.position );
		}
	}
}