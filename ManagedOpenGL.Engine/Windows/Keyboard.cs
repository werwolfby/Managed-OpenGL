/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 11:43
 *
 * File: Keyboard.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 16:04 - Create Wireframe
 *   31.05.2008 11:43 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using System;
using System.Windows.Forms;

namespace ManagedOpenGL.Engine.Windows
{
	public static class Keyboard
	{
		private static readonly bool[] keys = new bool[Enum.GetValues( typeof(Keys) ).Length];

		public static event KeyEventHandler KeyDown;
		public static event KeyEventHandler KeyUp;

		public static bool GetValue( Keys key )
		{
			return keys[(int)key];
		}

		public static void SetValue( Keys key, bool value )
		{
			keys[(int)key] = value;
		}

		public static void OnKeyDown( KeyEventArgs e )
		{
			SetValue( e.KeyCode, true );
			RaiseKeyDown( e );
		}

		public static void OnKeyUp( KeyEventArgs e )
		{
			SetValue( e.KeyCode, false );
			RaiseKeyUp( e );
		}

		private static void RaiseKeyDown( KeyEventArgs e )
		{
			if (KeyDown != null) KeyDown( null, e );
		}

		private static void RaiseKeyUp( KeyEventArgs e )
		{
			if (KeyUp != null) KeyUp( null, e );
		}
	}
}