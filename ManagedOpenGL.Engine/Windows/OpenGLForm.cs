using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Render;

namespace ManagedOpenGL.Engine.Windows
{
	public partial class OpenGLForm : Form
	{
		#region Fields
		private IntPtr hDC = IntPtr.Zero;
		private IntPtr hRC = IntPtr.Zero;
		private readonly HiResTimer hiResTimer = new HiResTimer();
		private bool internalSetWindowSize;
		#endregion

		#region Constructors
		public OpenGLForm()
		{
			this.SetStyle( ControlStyles.AllPaintingInWmPaint, true );
			this.SetStyle( ControlStyles.UserPaint, true );
			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, false );

			this.InitializeComponent();

			Renderer.WindowSize = this.WindowSize = new Size( 640, 480 );

			Renderer.WindowSizeChanged += delegate
			                              {
											  if (!internalSetWindowSize) this.ClientSize = Renderer.WindowSize;
			                              };
			Renderer.Near = 10;
			Renderer.Far = 1000;
			Renderer.FOV = 45;
		}
		#endregion

		public Size WindowSize { get; set; }

		#region Override Methods
		protected override void OnLoad( EventArgs e )
		{
			base.OnLoad( e );

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );

			this.Init();
			this.ClientSize = WindowSize;
			this.AfterInitGL();
			this.InitGL();
		}

		protected override void OnClosed( EventArgs e )
		{
			base.OnClosed( e );
		
			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );

			this.DeInit();
		}

		protected override void OnResize( EventArgs e ) 
		{
			base.OnResize( e );

			this.Invalidate();
		}

		protected override void OnResizeBegin( EventArgs e ) 
		{
			base.OnResizeBegin( e );

			hiResTimer.Paused = true;
		}

		protected override void OnResizeEnd( EventArgs e ) 
		{
			base.OnResizeEnd( e );

			hiResTimer.Paused = false;
		}

		protected override void OnSizeChanged( EventArgs e ) 
		{
			base.OnSizeChanged( e );

			internalSetWindowSize = true;
			Renderer.WindowSize = ClientSize;
			internalSetWindowSize = false;

			this.InitGL();
		}

		protected override void OnKeyDown( KeyEventArgs e ) 
		{
			base.OnKeyDown( e );

			Keyboard.OnKeyDown( e );
		}

		protected override void OnKeyUp( KeyEventArgs e ) 
		{
			base.OnKeyUp( e );

			Keyboard.OnKeyUp( e );
		}

		private void InitGL()
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this.hDC, this.hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			this.InitPerspective();

			this.Invalidate();

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		private void Init()
		{
			var pfd = new PixelFormatDescriptor();
			pfd.Initialize();

			this.InitializePixelFormatDescriptor( ref pfd );

			this.hDC = WindowsOpenGLNative.GetDC( this.Handle );
			if (this.hDC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var iPixelformat = WindowsOpenGLNative.ChoosePixelFormat( this.hDC, ref pfd );
			if (iPixelformat == 0)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Set the pixel format
			if (!WindowsOpenGLNative.SetPixelFormat( this.hDC, iPixelformat, ref pfd ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Create a new OpenGL rendering context
			this.hRC = WindowsOpenGLNative.wglCreateContext( this.hDC );
			if (this.hRC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );
		}

		private void DeInit()
		{
			if (this.hRC != IntPtr.Zero)
				WindowsOpenGLNative.wglDeleteContext( this.hRC );

			if (this.hDC != IntPtr.Zero)
				WindowsOpenGLNative.ReleaseDC( this.Handle, this.hDC );
		}

		private void AfterInitGL()
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this.hDC, this.hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			AfterInitGLOverride();

			Renderer.Initialized = true;

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		protected sealed override void OnPaint( PaintEventArgs e ) 
		{
			if (!WindowsOpenGLNative.wglMakeCurrent( this.hDC, this.hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			this.Draw();

			WindowsOpenGLNative.SwapBuffers( this.hDC );

			WindowsOpenGLNative.wglMakeCurrent( IntPtr.Zero, IntPtr.Zero );
		}

		protected sealed override void OnPaintBackground( PaintEventArgs e ) 
		{
		}

		internal void UpdateElapsed()
		{
			if (hiResTimer.Paused) return;
			hiResTimer.Update();
			Update( hiResTimer.Elapsed );
			Invalidate();
		}
		#endregion

		#region Virtual Methods
		protected virtual void InitializePixelFormatDescriptor( ref PixelFormatDescriptor pfd )
		{
		}

		protected virtual void AfterInitGLOverride()
		{
		}

		protected virtual void InitPerspective() 
		{
			Renderer.SetRenderMode();
		}

		protected virtual void Draw() 
		{
		}

		protected virtual void Update( float elapsed )
		{
		}
		#endregion
	}
}