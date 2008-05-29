/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.05.2008 20:43
 *
 * File: WndClassEx.cs
 * Remarks:
 * 
 * History:
 *   26.05.2008 20:43 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Runtime.InteropServices;

namespace Test.ManagedOpenGL
{
	public delegate long WindowProc( IntPtr hwnd, WindowMessage uMsg, int wParam, int lParam );

	[Flags]
	public enum ClassStyle : uint
	{
		CS_VREDRAW =          0x0001,
		CS_HREDRAW =          0x0002,
		CS_DBLCLKS =          0x0008,
		CS_OWNDC =            0x0020,
		CS_CLASSDC =          0x0040,
		CS_PARENTDC =         0x0080,
		CS_NOCLOSE =          0x0200,
		CS_SAVEBITS =         0x0800,
		CS_BYTEALIGNCLIENT =  0x1000,
		CS_BYTEALIGNWINDOW =  0x2000,
		CS_GLOBALCLASS =      0x4000,
	}

	public enum WindowStyle : uint
	{
		WS_OVERLAPPED =       0x00000000,
		WS_POPUP =            0x80000000,
		WS_CHILD =            0x40000000,
		WS_MINIMIZE =         0x20000000,
		WS_VISIBLE =          0x10000000,
		WS_DISABLED =         0x08000000,
		WS_CLIPSIBLINGS =     0x04000000,
		WS_CLIPCHILDREN =     0x02000000,
		WS_MAXIMIZE =         0x01000000,
		WS_CAPTION =          0x00C00000,
		WS_BORDER =           0x00800000,
		WS_DLGFRAME =         0x00400000,
		WS_VSCROLL =          0x00200000,
		WS_HSCROLL =          0x00100000,
		WS_SYSMENU =          0x00080000,
		WS_THICKFRAME =       0x00040000,
		WS_GROUP =            0x00020000,
		WS_TABSTOP =          0x00010000,

		WS_MINIMIZEBOX =      0x00020000,
		WS_MAXIMIZEBOX =      0x00010000,


		WS_TILED =            WS_OVERLAPPED,
		WS_ICONIC =           WS_MINIMIZE,
		WS_SIZEBOX =          WS_THICKFRAME,
		WS_TILEDWINDOW =      WS_OVERLAPPEDWINDOW,
		WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
		WS_POPUPWINDOW      = WS_POPUP | WS_BORDER | WS_SYSMENU,
		WS_CHILDWINDOW      = WS_CHILD
	}

	public enum WindowStyleEx : uint
	{
		WS_EX_DLGMODALFRAME =     0x00000001,
		WS_EX_NOPARENTNOTIFY =    0x00000004,
		WS_EX_TOPMOST =           0x00000008,
		WS_EX_ACCEPTFILES =       0x00000010,
		WS_EX_TRANSPARENT =       0x00000020,
		WS_EX_MDICHILD =          0x00000040,
		WS_EX_TOOLWINDOW =        0x00000080,
		WS_EX_WINDOWEDGE =        0x00000100,
		WS_EX_CLIENTEDGE =        0x00000200,
		WS_EX_CONTEXTHELP =       0x00000400,
		WS_EX_RIGHT =             0x00001000,
		WS_EX_LEFT =              0x00000000,
		WS_EX_RTLREADING =        0x00002000,
		WS_EX_LTRREADING =        0x00000000,
		WS_EX_LEFTSCROLLBAR =     0x00004000,
		WS_EX_RIGHTSCROLLBAR =    0x00000000,

		WS_EX_CONTROLPARENT =     0x00010000,
		WS_EX_STATICEDGE =        0x00020000,
		WS_EX_APPWINDOW =         0x00040000,

		WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,
		WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,
		WS_EX_LAYERED =           0x00080000,
		WS_EX_NOINHERITLAYOUT =   0x00100000,
		WS_EX_LAYOUTRTL =         0x00400000,
		WS_EX_COMPOSITED =        0x02000000,
		WS_EX_NOACTIVATE =        0x08000000,
	}

	public enum WindowMessage : uint
	{
		WM_NULL =                         0x0000,
		WM_CREATE =                       0x0001,
		WM_DESTROY =                      0x0002,
		WM_MOVE =                         0x0003,
		WM_SIZE =                         0x0005,
		WM_ACTIVATE =                     0x0006,
		WM_SETFOCUS =                     0x0007,
		WM_KILLFOCUS =                    0x0008,
		WM_ENABLE =                       0x000A,
		WM_SETREDRAW =                    0x000B,
		WM_SETTEXT =                      0x000C,
		WM_GETTEXT =                      0x000D,
		WM_GETTEXTLENGTH =                0x000E,
		WM_PAINT =                        0x000F,
		WM_CLOSE =                        0x0010,
		WM_QUIT =                         0x0012,
		WM_ERASEBKGND =                   0x0014,
		WM_SYSCOLORCHANGE =               0x0015,
		WM_SHOWWINDOW =                   0x0018,
		WM_WININICHANGE =                 0x001A,
		WM_DEVMODECHANGE =                0x001B,
		WM_ACTIVATEAPP =                  0x001C,
		WM_FONTCHANGE =                   0x001D,
		WM_TIMECHANGE =                   0x001E,
		WM_CANCELMODE =                   0x001F,
		WM_SETCURSOR =                    0x0020,
		WM_MOUSEACTIVATE =                0x0021,
		WM_CHILDACTIVATE =                0x0022,
		WM_QUEUESYNC =                    0x0023,

		WM_GETMINMAXINFO =                0x0024,
		WM_PAINTICON =                    0x0026,
		WM_ICONERASEBKGND =               0x0027,
		WM_NEXTDLGCTL =                   0x0028,
		WM_SPOOLERSTATUS =                0x002A,
		WM_DRAWITEM =                     0x002B,
		WM_MEASUREITEM =                  0x002C,
		WM_DELETEITEM =                   0x002D,
		WM_VKEYTOITEM =                   0x002E,
		WM_CHARTOITEM =                   0x002F,
		WM_SETFONT =                      0x0030,
		WM_GETFONT =                      0x0031,
		WM_SETHOTKEY =                    0x0032,
		WM_GETHOTKEY =                    0x0033,
		WM_QUERYDRAGICON =                0x0037,
		WM_COMPAREITEM =                  0x0039,
		WM_GETOBJECT =                    0x003D,
		WM_COMPACTING =                   0x0041,
		WM_COMMNOTIFY =                   0x0044,
		WM_WINDOWPOSCHANGING =            0x0046,
		WM_WINDOWPOSCHANGED =             0x0047,

		WM_POWER =                        0x0048,
		WM_COPYDATA =                     0x004A,
		WM_CANCELJOURNAL =                0x004B,
		WM_NOTIFY =                       0x004E,
		WM_INPUTLANGCHANGEREQUEST =       0x0050,
		WM_INPUTLANGCHANGE =              0x0051,
		WM_TCARD =                        0x0052,
		WM_HELP =                         0x0053,
		WM_USERCHANGED =                  0x0054,
		WM_NOTIFYFORMAT =                 0x0055,
		WM_CONTEXTMENU =                  0x007B,
		WM_STYLECHANGING =                0x007C,
		WM_STYLECHANGED =                 0x007D,
		WM_DISPLAYCHANGE =                0x007E,
		WM_GETICON =                      0x007F,
		WM_SETICON =                      0x0080,
		WM_NCCREATE =                     0x0081,
		WM_NCDESTROY =                    0x0082,
		WM_NCCALCSIZE =                   0x0083,
		WM_NCHITTEST =                    0x0084,
		WM_NCPAINT =                      0x0085,
		WM_NCACTIVATE =                   0x0086,
		WM_GETDLGCODE =                   0x0087,
		WM_SYNCPAINT =                    0x0088,
		WM_NCMOUSEMOVE =                  0x00A0,
		WM_NCLBUTTONDOWN =                0x00A1,
		WM_NCLBUTTONUP =                  0x00A2,
		WM_NCLBUTTONDBLCLK =              0x00A3,
		WM_NCRBUTTONDOWN =                0x00A4,
		WM_NCRBUTTONUP =                  0x00A5,
		WM_NCRBUTTONDBLCLK =              0x00A6,
		WM_NCMBUTTONDOWN =                0x00A7,
		WM_NCMBUTTONUP =                  0x00A8,
		WM_NCMBUTTONDBLCLK =              0x00A9,
		WM_NCXBUTTONDOWN =                0x00AB,
		WM_NCXBUTTONUP =                  0x00AC,
		WM_NCXBUTTONDBLCLK =              0x00AD,
		WM_INPUT_DEVICE_CHANGE =          0x00FE,
		WM_INPUT =                        0x00FF,
		WM_KEYFIRST =                     0x0100,
		WM_KEYDOWN =                      0x0100,
		WM_KEYUP =                        0x0101,
		WM_CHAR =                         0x0102,
		WM_DEADCHAR =                     0x0103,
		WM_SYSKEYDOWN =                   0x0104,
		WM_SYSKEYUP =                     0x0105,
		WM_SYSCHAR =                      0x0106,
		WM_SYSDEADCHAR =                  0x0107,
		WM_UNICHAR =                      0x0109,
		WM_KEYLAST =                      0x0108,
		WM_INITDIALOG =                   0x0110,
		WM_COMMAND =                      0x0111,
		WM_SYSCOMMAND =                   0x0112,
		WM_TIMER =                        0x0113,
		WM_HSCROLL =                      0x0114,
		WM_VSCROLL =                      0x0115,
		WM_INITMENU =                     0x0116,
		WM_INITMENUPOPUP =                0x0117,
		WM_MENUSELECT =                   0x011F,
		WM_MENUCHAR =                     0x0120,
		WM_ENTERIDLE =                    0x0121,
		WM_MENURBUTTONUP =                0x0122,
		WM_MENUDRAG =                     0x0123,
		WM_MENUGETOBJECT =                0x0124,
		WM_UNINITMENUPOPUP =              0x0125,
		WM_MENUCOMMAND =                  0x0126,
		WM_CHANGEUISTATE =                0x0127,
		WM_UPDATEUISTATE =                0x0128,
		WM_QUERYUISTATE =                 0x0129,
		WM_CTLCOLORMSGBOX =               0x0132,
		WM_CTLCOLOREDIT =                 0x0133,
		WM_CTLCOLORLISTBOX =              0x0134,
		WM_CTLCOLORBTN =                  0x0135,
		WM_CTLCOLORDLG =                  0x0136,
		WM_CTLCOLORSCROLLBAR =            0x0137,
		WM_CTLCOLORSTATIC =               0x0138,
		MN_GETHMENU =                     0x01E1,

		WM_MOUSEFIRST =                   0x0200,
		WM_MOUSEMOVE =                    0x0200,
		WM_LBUTTONDOWN =                  0x0201,
		WM_LBUTTONUP =                    0x0202,
		WM_LBUTTONDBLCLK =                0x0203,
		WM_RBUTTONDOWN =                  0x0204,
		WM_RBUTTONUP =                    0x0205,
		WM_RBUTTONDBLCLK =                0x0206,
		WM_MBUTTONDOWN =                  0x0207,
		WM_MBUTTONUP =                    0x0208,
		WM_MBUTTONDBLCLK =                0x0209,
		WM_XBUTTONDOWN =                  0x020B,
		WM_XBUTTONUP =                    0x020C,
		WM_XBUTTONDBLCLK =                0x020D,
		WM_MOUSEWHEEL =                   0x020A,
		WM_MOUSEHWHEEL =                  0x020E,
		WM_MOUSELAST =                    0x020E,
		WM_PARENTNOTIFY =                 0x0210,
		WM_ENTERMENULOOP =                0x0211,
		WM_EXITMENULOOP =                 0x0212,
		WM_NEXTMENU =                     0x0213,
		WM_SIZING =                       0x0214,
		WM_CAPTURECHANGED =               0x0215,
		WM_MOVING =                       0x0216,
		WM_DEVICECHANGE =                 0x0219,
		WM_MDICREATE =                    0x0220,
		WM_MDIDESTROY =                   0x0221,
		WM_MDIACTIVATE =                  0x0222,
		WM_MDIRESTORE =                   0x0223,
		WM_MDINEXT =                      0x0224,
		WM_MDIMAXIMIZE =                  0x0225,
		WM_MDITILE =                      0x0226,
		WM_MDICASCADE =                   0x0227,
		WM_MDIICONARRANGE =               0x0228,
		WM_MDIGETACTIVE =                 0x0229,


		WM_MDISETMENU =                   0x0230,
		WM_ENTERSIZEMOVE =                0x0231,
		WM_EXITSIZEMOVE =                 0x0232,
		WM_DROPFILES =                    0x0233,
		WM_MDIREFRESHMENU =               0x0234,
		WM_MOUSEHOVER =                   0x02A1,
		WM_MOUSELEAVE =                   0x02A3,
		WM_NCMOUSEHOVER =                 0x02A0,
		WM_NCMOUSELEAVE =                 0x02A2,
		WM_CUT =                          0x0300,
		WM_COPY =                         0x0301,
		WM_PASTE =                        0x0302,
		WM_CLEAR =                        0x0303,
		WM_UNDO =                         0x0304,
		WM_RENDERFORMAT =                 0x0305,
		WM_RENDERALLFORMATS =             0x0306,
		WM_DESTROYCLIPBOARD =             0x0307,
		WM_DRAWCLIPBOARD =                0x0308,
		WM_PAINTCLIPBOARD =               0x0309,
		WM_VSCROLLCLIPBOARD =             0x030A,
		WM_SIZECLIPBOARD =                0x030B,
		WM_ASKCBFORMATNAME =              0x030C,
		WM_CHANGECBCHAIN =                0x030D,
		WM_HSCROLLCLIPBOARD =             0x030E,
		WM_QUERYNEWPALETTE =              0x030F,
		WM_PALETTEISCHANGING =            0x0310,
		WM_PALETTECHANGED =               0x0311,
		WM_HOTKEY =                       0x0312,
		WM_PRINT =                        0x0317,
		WM_PRINTCLIENT =                  0x0318,
		WM_APPCOMMAND =                   0x0319,
		WM_THEMECHANGED =                 0x031A,
		WM_CLIPBOARDUPDATE =              0x031D,
		WM_USER =                         0x0400,
	}

	public enum ShowWindowEnum
	{
		SW_HIDE =             0,
		SW_SHOWNORMAL =       1,
		SW_NORMAL =           1,
		SW_SHOWMINIMIZED =    2,
		SW_SHOWMAXIMIZED =    3,
		SW_MAXIMIZE =         3,
		SW_SHOWNOACTIVATE =   4,
		SW_SHOW =             5,
		SW_MINIMIZE =         6,
		SW_SHOWMINNOACTIVE =  7,
		SW_SHOWNA =           8,
		SW_RESTORE =          9,
		SW_SHOWDEFAULT =      10,
		SW_FORCEMINIMIZE =    11,
		SW_MAX =              11,
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Message
	{
		public IntPtr hwnd;
		public WindowMessage message;
		public int wParam;
		public int lParam;
		public long time;
		public int x;
		public int y;
	} ;

	public class WindowDLL
	{
		public static readonly IntPtr hInstance = GetModuleHandleW( null );

		[DllImport( "user32.dll", CharSet = CharSet.Unicode )]
		public static extern IntPtr CreateWindowExW( WindowStyleEx dwExStyle, string lpClassName, string lpWindowName,
		                                             WindowStyle dwStyle,
		                                             int x, int y, int nWidth, int nHeight,
		                                             IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam );

		[DllImport( "user32.dll", CharSet = CharSet.Unicode )]
		public static extern long DefWindowProc( IntPtr hwnd, WindowMessage msg, int param, int lParam );

		[DllImport( "user32.dll", CharSet = CharSet.Unicode )]
		public static extern bool PostMessage( IntPtr hwnd, WindowMessage msg, int param, int lParam );

		[DllImport( "Kernel32.dll", CharSet = CharSet.Unicode )]
		public static extern IntPtr GetModuleHandleW( string name );

		[DllImport( "user32.dll" )]
		public static extern bool ShowWindow( IntPtr hWnd, ShowWindowEnum nCmdShow );

		[DllImport( "user32.dll" )]
		public static extern bool GetMessage( ref Message message, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax );

		[DllImport( "user32.dll" )]
		public static extern bool TranslateMessage( ref Message message );

		[DllImport( "user32.dll" )]
		public static extern int DispatchMessage( ref Message message );
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WndClassEx
	{
		public uint cbSize;
		public ClassStyle style;
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public WindowProc lpfnWndProc;
		public int cbClsExtra;
		public int cbWndExtra;
		public IntPtr hInstance;
		public IntPtr hIcon;
		public IntPtr hCursor;
		public IntPtr hbrBackground;
		public IntPtr lpszMenuName;
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszClassName;
		public IntPtr hIconSm;

		public static WndClassEx Create()
		{
			return new WndClassEx
			       {
			       	cbSize = (uint)Marshal.SizeOf( typeof(WndClassEx) )
			       };
		}

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern ushort RegisterClassExW( ref WndClassEx wndClassEx );
	}
}