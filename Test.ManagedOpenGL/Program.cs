using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ManagedOpenGL;

namespace Test.ManagedOpenGL
{
	public static class Test
	{
		[DllImport(@"..\..\..\Debug\Test.dll")]
		public static extern bool MySetPixelFormat( IntPtr hWnd, IntPtr hDC, int ipf, ref PixelFormatDescriptor pfd );
	}

	class Program
	{
		//[STAThread]
		static void Main()
		{
			var wndClassEx = WndClassEx.Create();
			wndClassEx.lpfnWndProc += LpfnWndProc;
			wndClassEx.lpszClassName = "TEST";
			wndClassEx.style = ClassStyle.CS_OWNDC | ClassStyle.CS_VREDRAW | ClassStyle.CS_HREDRAW;
			wndClassEx.hInstance = WindowDLL.hInstance;

			if (WndClassEx.RegisterClassExW( ref wndClassEx ) == 0)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var hWnd = WindowDLL.CreateWindowExW( WindowStyleEx.WS_EX_APPWINDOW, wndClassEx.lpszClassName, "Test Window",
			                                      WindowStyle.WS_OVERLAPPEDWINDOW,
			                                      0, 0, 640, 480, IntPtr.Zero, IntPtr.Zero, WindowDLL.hInstance, IntPtr.Zero );
			if (hWnd == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var pfd = new PixelFormatDescriptor();
			pfd.Initialize();

			var _hDC = WindowsOpenGLNative.GetDC( hWnd );
			var _hDC1 = WindowsOpenGLNative.GetDC( hWnd );
			if (_hDC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var iPixelformat = WindowsOpenGLNative.ChoosePixelFormat( _hDC, ref pfd );
			if (iPixelformat == 0)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			Test.MySetPixelFormat( hWnd, _hDC, iPixelformat, ref pfd );

			// Set the pixel format
			if (!WindowsOpenGLNative.SetPixelFormat( hWnd, iPixelformat, ref pfd ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			if (iPixelformat != WindowsOpenGLNative.GetPixelFormat( _hDC ))
				throw new Exception( "Suxxx!!!" );

			WindowDLL.ShowWindow( hWnd, ShowWindowEnum.SW_SHOW );

			// Create a new OpenGL rendering context
			var _hRC = WindowsOpenGLNative.wglCreateContext( _hDC );
			if (_hRC == IntPtr.Zero)
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			// Make _hRC rendering context as a current context
			if (!WindowsOpenGLNative.wglMakeCurrent( _hDC, _hRC ))
				throw new Win32Exception( Marshal.GetLastWin32Error() );

			var message = new Message();

			while (WindowDLL.GetMessage( ref message, hWnd, 0, 0 ))
			{
				WindowDLL.TranslateMessage( ref message );
				WindowDLL.DispatchMessage ( ref message );
			}
		}

		private static long LpfnWndProc( IntPtr hwnd, WindowMessage msg, int param, int lParam )
		{
			switch (msg)
			{
				case WindowMessage.WM_CLOSE:
					WindowDLL.PostMessage( hwnd, WindowMessage.WM_QUIT, 0, 0 );
					return 0;
				default:
					return WindowDLL.DefWindowProc( hwnd, msg, param, lParam );
			}
		}
	}
}
