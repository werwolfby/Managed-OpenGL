/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 08.06.2008 16:06
 *
 * File: DrawObject.cs
 * Remarks:
 * 
 * History:
 *   08.06.2008 16:06 - Create Wireframe
 *
 *******************************************************/

using System;
using ManagedOpenGL.Engine.Math;

namespace ManagedOpenGL.Engine.Objects
{
	public abstract class DrawObject 
	{
		public abstract void Draw();
	}

	public abstract class PositionedObject : DrawObject
	{
		private Matrix4F position;

		public event EventHandler PositionChanged;

		protected PositionedObject()
		{
			this.Position = new Matrix4F();
		}

		public Matrix4F Position
		{
			get { return this.position; }
			set
			{
				if (this.position == value) return;
				this.position = value;
				this.RaisePositionChanged( EventArgs.Empty );
			}
		}

		public sealed override void Draw()
		{
			OpenGLNative.MatrixMode( MatrixMode.Modelview );

			OpenGLNative.PushMatrix();
			OpenGLNative.MultMatrixf( this.Position.Data );

			this.DrawOverride();

			OpenGLNative.PopMatrix();
		}

		public abstract void DrawOverride();

		private void RaisePositionChanged( EventArgs e )
		{
			if (PositionChanged != null) PositionChanged( this, e );
		}
	}
}