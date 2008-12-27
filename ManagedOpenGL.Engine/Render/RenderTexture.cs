/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 27.12.2008 15:36
 *
 * File: RenderTexture.cs
 * Remarks:
 * 
 * History:
 *   27.12.2008 15:36 - Create Wireframe
 *
 *******************************************************/

using System;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Windows;
using gl=ManagedOpenGL.OpenGLNative;

namespace ManagedOpenGL.Engine.Render
{
	public class RenderTexture : EmptyTexture2D
	{
		public RenderTexture( int width, int height ) : base( width, height, 4, PixelFormat.Rgb ) {}

		public virtual void PrepareForRender()
		{
			this.SetTextureViewport();
			gl.MatrixMode( MatrixMode.Projection );
			gl.PushMatrix();
			gl.LoadIdentity();
			var aspect = this.Height / this.Width;
			gl.Frustum( -1, 1, -aspect, aspect, Renderer.Near, Renderer.Far );
		}

		public void Copy()
		{
			this.Copy( this.Width, this.Height );
		}

		public virtual void RestoreRenderToTexture()
		{
			RestoreTextureViewort();
			gl.MatrixMode( MatrixMode.Projection );
			gl.PopMatrix();
		}

		protected void SetTextureViewport()
		{
			gl.Viewport( 0, 0, this.Width, this.Height );
		}

		protected static void RestoreTextureViewort()
		{
			gl.Viewport( 0, 0, Renderer.WindowSize.Width, Renderer.WindowSize.Height );
		}
	}

	public class MatrixRenderTexture : RenderTexture
	{
		private Matrix4F matrix;

		public MatrixRenderTexture( int width, int height, Matrix4F matrix ) : base( width, height )
		{
			this.matrix = matrix;
		}

		public MatrixRenderTexture( int width, int height ) : this( width, height, null ) {}

		public Matrix4F Matrix
		{
			get { return this.matrix; }
			set { this.matrix = value; }
		}

		public override void PrepareForRender()
		{
			Check();
			base.PrepareForRender();
			gl.MatrixMode( MatrixMode.Modelview );
			gl.PushMatrix();
			gl.LoadMatrixf( matrix.Data );
		}

		public override void RestoreRenderToTexture()
		{
			base.RestoreRenderToTexture();
			gl.MatrixMode( MatrixMode.Modelview );
			gl.PopMatrix();
		}

		private void Check()
		{
			if (this.matrix == null) throw new NullReferenceException( "Camera property not set" );
		}
	}

	public class CameraRenderTexture : RenderTexture
	{
		private Camera camera;

		public CameraRenderTexture( int width, int height, Camera camera ) : base( width, height )
		{
			this.camera = camera;
		}

		public CameraRenderTexture( int width, int height ) : this( width, height, null ) {}

		public Camera Camera
		{
			get { return this.camera; }
			set { this.camera = value; }
		}

		public override void PrepareForRender()
		{
			Check();
			base.PrepareForRender();
			gl.MatrixMode( MatrixMode.Modelview );
			gl.PushMatrix();
			gl.LoadMatrixf( camera.Data );
		}

		public override void RestoreRenderToTexture()
		{
			base.RestoreRenderToTexture();
			gl.MatrixMode( MatrixMode.Modelview );
			gl.PopMatrix();
		}

		private void Check()
		{
			if (this.camera == null) throw new NullReferenceException( "Camera property not set" );
		}
	}
}