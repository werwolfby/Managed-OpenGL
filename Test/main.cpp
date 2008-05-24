#include <windows.h>
#include <gl/gl.h>

LRESULT CALLBACK WndProc( HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam );

HWND aze_hWnd;
HDC aze_hDC;
HGLRC aze_hRC;

int WINAPI WinMain(          HINSTANCE hInstance,
    HINSTANCE hPrevInstance,
    LPSTR lpCmdLine,
    int nCmdShow
)
{
	WNDCLASSEX Wnd;

	ZeroMemory( &Wnd, sizeof(WNDCLASSEX) );
	
	Wnd.cbSize        = sizeof(WNDCLASSEX);

	Wnd.hbrBackground = 0;
	Wnd.lpszClassName = L"TEST";
	Wnd.lpfnWndProc   = WndProc;
	Wnd.hCursor       = LoadCursor( 0, IDC_ARROW );
	Wnd.hIcon         = LoadIcon  ( 0, IDI_APPLICATION );
	Wnd.style         = CS_OWNDC | CS_VREDRAW | CS_HREDRAW;

	RegisterClassEx( &Wnd );

	DWORD dwExStyle = WS_EX_APPWINDOW, dwStyle = WS_OVERLAPPEDWINDOW;

	RECT mainRC = {0, 0, 640, 480};

	AdjustWindowRectEx( &mainRC, dwStyle, 0, dwExStyle );

	aze_hWnd = CreateWindowEx( dwExStyle, 
		L"TEST", L"Test window", dwStyle,
		0, 0, mainRC.right - mainRC.left, mainRC.bottom - mainRC.top,
		0, 0, hInstance, 0 );

	ShowWindow( aze_hWnd, SW_SHOW );

	aze_hDC = GetDC( aze_hWnd );

	PIXELFORMATDESCRIPTOR pfd =
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

	GLuint PixelFormat = ChoosePixelFormat( aze_hDC, &pfd );
	SetPixelFormat( aze_hDC, PixelFormat, &pfd );

	aze_hRC = wglCreateContext( aze_hDC );

	wglMakeCurrent( aze_hDC, aze_hRC );

	glClearColor( 1, 0, 0, 0 );
	glClear( GL_COLOR_BUFFER_BIT );

	SwapBuffers( aze_hDC );

	void* ptr = wglGetProcAddress( "glActiveTexture" );

	MSG msg;

	while (GetMessage(&msg, 0, 0, 0))
	{
		TranslateMessage( &msg );
		DispatchMessage ( &msg );
	}
}

LRESULT CALLBACK WndProc( HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam )
{
	switch (uMsg)
	{
	case WM_CLOSE:
		PostMessage( hWnd, WM_QUIT, 0, 0 );
		return 0;
	case WM_SIZE:
		//ResizeWindow( LOWORD(lParam), HIWORD(lParam) );
		return 0;
	default:
		return DefWindowProc( hWnd, uMsg, wParam, lParam );
	}

	return DefWindowProc( hWnd, uMsg, wParam, lParam );
}