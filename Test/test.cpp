#define __SOURCE__
#include "test.h"
#include <windows.h>
#include <stdio.h>

extern "C"
{
	LRESULT CALLBACK WndProc( HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam );
	
	bool MySetPixelFormat( HWND hWnd, HDC hDC, int ipf, const PIXELFORMATDESCRIPTOR* pfd )
	{
		WNDCLASSEX Wnd;
		HWND aze_hWnd;
		HDC aze_hDC;
		HGLRC aze_hRC;

		ZeroMemory( &Wnd, sizeof(WNDCLASSEX) );
		
		Wnd.cbSize        = sizeof(WNDCLASSEX);

		Wnd.hbrBackground = 0;
		Wnd.lpszClassName = L"TEST1";
		Wnd.lpfnWndProc   = WndProc;
		Wnd.hCursor       = LoadCursor( 0, IDC_ARROW );
		Wnd.hIcon         = LoadIcon  ( 0, IDI_APPLICATION );
		Wnd.style         = CS_OWNDC | CS_VREDRAW | CS_HREDRAW;

		RegisterClassEx( &Wnd );

		DWORD dwExStyle = WS_EX_APPWINDOW, dwStyle = WS_OVERLAPPEDWINDOW;

		RECT mainRC = {0, 0, 640, 480};

		//AdjustWindowRectEx( &mainRC, dwStyle, 0, dwExStyle );

		aze_hWnd = CreateWindowEx( dwExStyle, 
			L"TEST1", L"Test window", dwStyle,
			0, 0, mainRC.right - mainRC.left, mainRC.bottom - mainRC.top,
			0, 0, GetModuleHandle( 0 ), 0 );

		ShowWindow( aze_hWnd, SW_SHOW );

		aze_hDC = GetDC( aze_hWnd );

		PIXELFORMATDESCRIPTOR pfd1 =
		{
			sizeof(PIXELFORMATDESCRIPTOR), 1, 
			PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER,
			PFD_TYPE_RGBA,
			24, 0, 0, 0, 0, 0, 0, 
			0, 0,
			0, 0, 0, 0, 0,
			16, 
			0,
			0,
			PFD_MAIN_PLANE,
			0,
			0,
			0,
			0
		};

		int PixelFormat = ChoosePixelFormat( aze_hDC, &pfd1 );
		int oldPixelFormat = GetPixelFormat( aze_hDC );
		bool res = SetPixelFormat( aze_hDC, PixelFormat, &pfd1 );
		int newPixelFormat = GetPixelFormat( aze_hDC );

		wchar_t txt[1024];
		swprintf( txt, 
			      L"PixelFormat: %d\n"
			      L"OldPixelFormat: %d\n"
			      L"NewPixelFormat: %d\n"
			      L"size: %d\n"
			      L"Version: %d", 
				  PixelFormat, oldPixelFormat, newPixelFormat,
			      pfd->nSize, pfd->nVersion );

		MessageBox( 0, txt, 0, 0 );

		return true;
	}

	LRESULT CALLBACK WndProc( HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam )
	{
		return DefWindowProc( hWnd, uMsg, wParam, lParam );
	}
}
