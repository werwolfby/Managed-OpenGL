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

namespace ManagedOpenGL.Engine.Objects
{
	public class PositionedSphere : Sphere
	{
		public PositionedSphere( float radius, int slices, int stacks, float x, float y, float z ) : base( radius, slices, stacks )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public float X { get; set; }

		public float Y { get; set; }

		public float Z { get; set; }

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