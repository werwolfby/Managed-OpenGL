#ifdef __SOURCE__
#define DLL __declspec(dllexport)
#else
#define DLL __declspec(dllimport)
#endif
//#define DLL

#include <windows.h>

extern "C"
{
	bool DLL MySetPixelFormat( HWND hWnd, HDC hDC, int ipf, const PIXELFORMATDESCRIPTOR* pfd );
}
