/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 01.06.2008 11:51
 *
 * File: Renderer.cs
 * Remarks:
 * 
 * History:
 *   01.06.2008 11:51 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Drawing;

namespace ManagedOpenGL.Engine.Render
{
	public static class Renderer
	{
		private static RenderMode renderMode = RenderMode.MODE_3D;
		private static Size windowSize;

		private static bool initialized;
		private static bool needSetRenderMode = true;

		internal static event EventHandler WindowSizeChanged;

		static Renderer()
		{
			Near = 10;
			Far = 1000;
		}

		public static Size WindowSize
		{
			get { return windowSize; }
			set
			{
				if (windowSize == value) return;
				windowSize = value;
				WhenWindowSizeChanged();
			}
		}

		public static bool Initialized
		{
			get { return initialized; }
			internal set
			{
				if (initialized == value) return;
				initialized = value;
				if (value) Init();
			}
		}

		public static float FOV { get; set; }

		public static float Near { get; set; }

		public static float Far { get; set; }

		public static RenderMode RenderMode
		{
			get { return renderMode; }
			set
			{
				if (renderMode == value) return;
				renderMode = value;
				SetRenderMode();
			}
		}

		private static void Init()
		{
			if (needSetRenderMode) SetRenderMode();
		}

		public static void SetRenderMode()
		{
			if (!Initialized)
			{
				needSetRenderMode = true;
				return;
			}

			switch (RenderMode)
			{
				case RenderMode.MODE_2D:
					OpenGLNative.MatrixMode( MatrixMode.Projection );
					OpenGLNative.LoadIdentity();
					OpenGLNative.Ortho( 0, WindowSize.Width, WindowSize.Height, 0, -1, 1 );
					break;
				case RenderMode.MODE_3D:
					OpenGLNative.MatrixMode( MatrixMode.Projection );
					OpenGLNative.LoadIdentity();
					WindowsOpenGLNative.gluPerspective( FOV, (double)WindowSize.Width / WindowSize.Height, Near, Far );
					break;
			}
			OpenGLNative.Viewport( 0, 0, windowSize.Width, windowSize.Height );
		}

		private static void WhenWindowSizeChanged() 
		{
			SetRenderMode();
			RaiseWindowSizeChanged( EventArgs.Empty );
		}

		private static void RaiseWindowSizeChanged( EventArgs e )
		{
			if (WindowSizeChanged != null) WindowSizeChanged( null, e );
		}
	}
}