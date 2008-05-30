﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagedOpenGL;

namespace Test.ManagedOpenGL
{
	public partial class OpenGLForm : Form
	{
		#region Fields
		private IntPtr _hDC = IntPtr.Zero;
		private IntPtr _hRC = IntPtr.Zero;
		#endregion

		#region Constructors
		public OpenGLForm()
		{
			SetStyle( ControlStyles.AllPaintingInWmPaint, true );
			SetStyle( ControlStyles.UserPaint, true );
			SetStyle( ControlStyles.ResizeRedraw, true );
			SetStyle( ControlStyles.OptimizedDoubleBuffer, false );

			InitializeComponent();
		}
		#endregion

		#region Override Methods
		protected override void OnShown( EventArgs e ) 
		{
			base.OnShown( e );

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );

			Init();
			InitGL();
		}

		protected override void OnSizeChanged( EventArgs e ) 
		{
			base.OnSizeChanged( e );

			InitGL();
		}

		private void InitGL()
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this._hDC, _hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			this.InitPerspective();

			Invalidate();

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		private void Init()
		{
			var pfd = new PixelFormatDescriptor();
			pfd.Initialize();

			InitializePixelFormatDescriptor( ref pfd );

			this._hDC = WindowsOpenGLNative.GetDC( Handle );
			if (this._hDC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var iPixelformat = WindowsOpenGLNative.ChoosePixelFormat( this._hDC, ref pfd );
			if (iPixelformat == 0)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Set the pixel format
			if (!WindowsOpenGLNative.SetPixelFormat( _hDC, iPixelformat, ref pfd ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Create a new OpenGL rendering context
			this._hRC = WindowsOpenGLNative.wglCreateContext( this._hDC );
			if (_hRC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );
		}

		protected sealed override void OnPaint( PaintEventArgs e ) 
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this._hDC, _hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			this.Draw();

			WindowsOpenGLNative.SwapBuffers( _hDC );

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		protected sealed override void OnPaintBackground( PaintEventArgs e ) 
		{
		}
		#endregion

		#region Virtual Methods
		protected virtual void InitializePixelFormatDescriptor( ref PixelFormatDescriptor pfd )
		{
		}

		protected virtual void InitPerspective() 
		{
			OpenGLNative.MatrixMode( MatrixMode.Projection );
			OpenGLNative.LoadIdentity();
			WindowsOpenGLNative.gluPerspective( 45, (double)this.ClientSize.Width / this.ClientSize.Height, 10, 1000 );
			OpenGLNative.Viewport( 0, 0, this.ClientSize.Width, this.ClientSize.Height );
		}

		protected virtual void Draw() 
		{
			OpenGLNative.ClearColor( 0.3f, 0.3f, 0.3f, 0 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.CullFace( CullFaceMode.FrontAndBack );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( 0, 0, -16f );

			OpenGLNative.Disable( EnableCap.Lighting );

			OpenGLNative.Begin( BeginMode.Triangles );
			OpenGLNative.Color3f( 1, 1, 1 );
			OpenGLNative.Vertex3f( -5f, -2f, 0 );
			OpenGLNative.Color3f( 1, 1, 1 );
			OpenGLNative.Vertex3f( 5f, -2f, 0 );
			OpenGLNative.Color3f( 1, 1, 1 );
			OpenGLNative.Vertex3f( 0, 5f, 0 );
			OpenGLNative.End();
		}
		#endregion
	}
}
