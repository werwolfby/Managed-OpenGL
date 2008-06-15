/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:47
 *
 * File: EulerAngle.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 15:06 - Create Wireframe
 *   31.05.2008 10:47 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using System;

namespace ManagedOpenGL.Engine.Math
{
	public class EulerAngle2F
	{
		private float sinPitch, cosPitch, sinYaw, cosYaw;
		private float pitch, yaw;

		public EulerAngle2F()
		{
			this.cosPitch = this.cosYaw = 1;
		}

		public event EventHandler PitchChanged;
		public event EventHandler YawChanged;
		public event EventHandler Changed;

		public float Pitch
		{
			get { return this.pitch; }
			set
			{
				this.pitch = value;
				this.sinPitch = (float)System.Math.Sin( this.pitch );
				this.cosPitch = (float)System.Math.Cos( this.pitch );

				RaisePitchChanged( EventArgs.Empty );
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Yaw
		{
			get { return this.yaw; }
			set
			{
				if (value < - System.Math.PI / 2) value = (float)(- System.Math.PI / 2);
				if (value > + System.Math.PI / 2) value = (float)(+ System.Math.PI / 2);

				this.yaw = value;

				this.sinYaw = (float)System.Math.Sin( this.yaw );
				this.cosYaw = (float)System.Math.Cos( this.yaw );

				RaiseYawChanged( EventArgs.Empty );
				RaiseChanged( EventArgs.Empty );
			}
		}

		public void SetToMatrix( Matrix3F matrix )
		{
			matrix[0] = cosPitch;           matrix[3] = 0;       matrix[6] = sinPitch;
			matrix[1] = -sinPitch * sinYaw; matrix[4] = cosYaw;  matrix[7] = sinYaw * cosPitch;
			matrix[2] = -sinPitch * cosYaw; matrix[5] = -sinYaw; matrix[8] = cosYaw * cosPitch;
		}

		public void SetToMatrix( Matrix4F matrix )
		{
			matrix[0] = cosPitch;           matrix[4] = 0;       matrix[08] = sinPitch;
			matrix[1] = -sinPitch * sinYaw; matrix[5] = cosYaw;  matrix[09] = sinYaw * cosPitch;
			matrix[2] = -sinPitch * cosYaw; matrix[6] = -sinYaw; matrix[10] = cosYaw * cosPitch;
		}

		public void SetInvertToMatrix( Matrix3F matrix )
		{
			matrix[0] = cosPitch;           matrix[1] = 0;       matrix[2] = sinPitch;
			matrix[3] = -sinPitch * sinYaw; matrix[4] = cosYaw;  matrix[5] = sinYaw * cosPitch;
			matrix[6] = -sinPitch * cosYaw; matrix[7] = -sinYaw; matrix[8] = cosYaw * cosPitch;
		}

		public void SetInvertToMatrix( Matrix4F matrix )
		{
			matrix[0] = cosPitch;           matrix[1] = 0;       matrix[02] = sinPitch;
			matrix[4] = -sinPitch * sinYaw; matrix[5] = cosYaw;  matrix[06] = sinYaw * cosPitch;
			matrix[8] = -sinPitch * cosYaw; matrix[9] = -sinYaw; matrix[10] = cosYaw * cosPitch;
		}

		private void RaisePitchChanged( EventArgs e )
		{
			if (PitchChanged != null) PitchChanged( this, e );
		}

		private void RaiseYawChanged( EventArgs e )
		{
			if (YawChanged != null) YawChanged( this, e );
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}
	}
}