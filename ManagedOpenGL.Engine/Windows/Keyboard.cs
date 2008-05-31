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

		public static bool GetValue( Keys key )
		{
			return keys[(int)key];
		}

		public static void SetValue( Keys key, bool value )
		{
			keys[(int)key] = value;
		}
	}
}