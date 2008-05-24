/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 01.05.2008 21:40
 *
 * File: PixelFormatDescriptor.cs
 * Remarks:
 * 
 * History:
 *   01.05.2008 21:40 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	[Flags]
	public enum PixelFormatDescriptorFlagsEnum : uint
	{
		PFD_DRAW_TO_WINDOW = PixelFormatDescriptor.PFD_DRAW_TO_WINDOW,
		PFD_DRAW_TO_BITMAP = PixelFormatDescriptor.PFD_DRAW_TO_BITMAP,
		PFD_SUPPORT_GDI = PixelFormatDescriptor.PFD_SUPPORT_GDI,
		PFD_SUPPORT_OPENGL = PixelFormatDescriptor.PFD_SUPPORT_OPENGL,
		PFD_GENERIC_ACCELERATED = PixelFormatDescriptor.PFD_GENERIC_ACCELERATED,
		PFD_GENERIC_FORMAT = PixelFormatDescriptor.PFD_GENERIC_FORMAT,
		PFD_NEED_PALETTE = PixelFormatDescriptor.PFD_NEED_PALETTE,
		PFD_NEED_SYSTEM_PALETTE = PixelFormatDescriptor.PFD_NEED_SYSTEM_PALETTE,
		PFD_DOUBLEBUFFER = PixelFormatDescriptor.PFD_DOUBLEBUFFER,
		PFD_STEREO = PixelFormatDescriptor.PFD_STEREO,
		PFD_SWAP_LAYER_BUFFERS = PixelFormatDescriptor.PFD_SWAP_LAYER_BUFFERS, 
	}

	[StructLayout( LayoutKind.Sequential )]
	public struct PixelFormatDescriptor
	{
		public const uint PFD_DEPTH_DONTCARE = 0x20000000;
		public const uint PFD_DOUBLEBUFFER = 0x00000001;
		public const uint PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;
		public const uint PFD_DRAW_TO_BITMAP = 0x00000008;
		public const uint PFD_DRAW_TO_WINDOW = 0x00000004;
		public const uint PFD_GENERIC_ACCELERATED = 0x00001000;
		public const uint PFD_GENERIC_FORMAT = 0x00000040;
		public const byte PFD_MAIN_PLANE = 0;
		public const uint PFD_NEED_PALETTE = 0x00000080,
			PFD_NEED_SYSTEM_PALETTE = 0x00000100;
		public const sbyte PFD_OVERLAY_PLANE = 1;
		public const uint PFD_STEREO = 0x00000002;
		public const uint PFD_STEREO_DONTCARE = 0x80000000;
		public const uint PFD_SUPPORT_DIRECTDRAW = 0x00002000;
		public const uint PFD_SUPPORT_GDI = 0x00000010,
			PFD_SUPPORT_OPENGL = 0x00000020;
		public const uint PFD_SWAP_COPY = 0x00000400;
		public const uint PFD_SWAP_EXCHANGE = 0x00000200;
		public const uint PFD_SWAP_LAYER_BUFFERS = 0x00000800;
		public const byte PFD_TYPE_COLORINDEX = 1;
		public const byte PFD_TYPE_RGBA = 0;
		public const sbyte PFD_UNDERLAY_PLANE = -1;

		public byte
			bReserved;
		public byte
			cAccumAlphaBits;
		public byte
			cAccumBits;
		public byte
			cAccumBlueBits;
		public byte
			cAccumGreenBits;
		public byte
			cAccumRedBits;
		public byte
			cAlphaBits, cAlphaShift;
		public byte
			cAuxBuffers;
		public byte
			cBlueBits, cBlueShift;
		public byte
			cColorBits;
		public byte
			cDepthBits;
		public byte
			cGreenBits, cGreenShift;
		public byte
			cRedBits, cRedShift;
		public byte
			cStencilBits;
		public uint dwDamageMask;
		public PixelFormatDescriptorFlagsEnum dwFlags;
		public uint dwLayerMask, dwVisibleMask;
		public byte
			iLayerType;
		public byte
			iPixelType;
		public ushort nSize, nVersion;

		/// <summary>
		/// Initializes a current instance of the PIXELFORMATDESCRIPTOR
		/// structure with default values.
		/// </summary>
		public void Initialize()
		{
			this.nSize = (ushort)Marshal.SizeOf( this );
			this.nVersion = 1;
			this.dwFlags = PixelFormatDescriptorFlagsEnum.PFD_DRAW_TO_WINDOW | PixelFormatDescriptorFlagsEnum.PFD_SUPPORT_OPENGL |
			               PixelFormatDescriptorFlagsEnum.PFD_DOUBLEBUFFER;
			this.iPixelType = PFD_TYPE_RGBA;
			this.cColorBits = 24;
			this.cRedBits = 24;
			this.cRedShift = 0;
			this.cGreenBits = 24;
			this.cGreenShift = 0;
			this.cBlueBits = 24;
			this.cBlueShift = 0;
			this.cAlphaBits = 0;
			this.cAlphaShift = 0;
			this.cAccumBits = this.cAccumRedBits = this.cAccumGreenBits = this.cAccumBlueBits = this.cAccumAlphaBits = 0;
			this.cDepthBits = 32;
			this.cStencilBits = 0;
			this.cAuxBuffers = 0;
			this.iLayerType = PFD_MAIN_PLANE;
			this.bReserved = 0;
			this.dwLayerMask = this.dwVisibleMask = this.dwDamageMask = 0;
		}
	}
}