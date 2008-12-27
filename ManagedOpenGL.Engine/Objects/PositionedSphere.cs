/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 15.06.2008 12:00
 *
 * File: PositionedSphere.cs
 * Remarks:
 * 
 * History:
 *   15.06.2008 12:00 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL.Engine.Math;

namespace ManagedOpenGL.Engine.Objects
{
	public class PositionedSphere : Sphere
	{
		private readonly Vector3F position = new Vector3F( 0, 0, 0 );

		public PositionedSphere( float radius, int slices, int stacks, float x, float y, float z ) : base( radius, slices, stacks )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public Vector3F Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position.Set( value );
			}
		}

		public float X
		{
			get { return this.position.X; }
			set { this.position.X = value; }
		}

		public float Y
		{
			get { return this.position.Y; }
			set { this.position.Y = value; }
		}

		public float Z
		{
			get { return this.position.Z; }
			set { this.position.Z = value; }
		}

		public override void Draw() 
		{
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.PushMatrix();
			OpenGLNative.Translatef( this.X, this.Y, this.Z );

			base.Draw();

			OpenGLNative.PopMatrix();
		}
	}
}