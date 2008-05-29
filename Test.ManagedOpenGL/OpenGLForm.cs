using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagedOpenGL;

namespace Test.ManagedOpenGL
{
	public partial class OpenGLForm : Form
	{
		private IntPtr _hDC = IntPtr.Zero;
		private IntPtr _hRC = IntPtr.Zero;

		public OpenGLForm()
		{
			SetStyle( ControlStyles.AllPaintingInWmPaint, true );
			SetStyle( ControlStyles.UserPaint, true );
			SetStyle( ControlStyles.ResizeRedraw, true );
			SetStyle( ControlStyles.OptimizedDoubleBuffer, false );

			InitializeComponent();
		}

		protected override void OnShown( EventArgs e ) 
		{
			base.OnShown( e );

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );

			Init();
		}

		protected override void OnSizeChanged( EventArgs e ) 
		{
			base.OnSizeChanged( e );

			InitGL();
		}

		private void InitGL()
		{
			OpenGLNative.Viewport( 0, 0, ClientSize.Width, ClientSize.Height );
			WindowsOpenGLNative.gluPerspective( 45, (Double)ClientSize.Width / ClientSize.Height, 10, 1000 );
		}

		private void Init()
		{
			var pfd = new PixelFormatDescriptor();
			pfd.Initialize();

			this._hDC = WindowsOpenGLNative.GetDC( Handle );
			if (this._hDC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var iPixelformat = WindowsOpenGLNative.ChoosePixelFormat( this._hDC, ref pfd );
			if (iPixelformat == 0)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Set the pixel format
			if (WindowsOpenGLNative.SetPixelFormat( _hDC, iPixelformat, ref pfd ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Create a new OpenGL rendering context
			this._hRC = WindowsOpenGLNative.wglCreateContext( this._hDC );
			if (_hRC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Make _hRC rendering context as a current context
			if (!WindowsOpenGLNative.wglMakeCurrent( this._hDC, _hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );
		}

		protected override void OnPaint( PaintEventArgs e ) 
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this._hDC, _hRC ))
			    throw new Win32Exception( Marshal.GetLastWin32Error() );

			OpenGLNative.ClearColor( 1.0f, 1, 1, 0 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit );

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );

			//if (!WindowsOpenGLNative.SwapBuffers( this._hDC )) throw new Win32Exception( Marshal.GetLastWin32Error() );

			//Invalidate();

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		protected override void OnPaintBackground( PaintEventArgs e ) 
		{
		}
	}
}
