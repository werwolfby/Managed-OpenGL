/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 19:18
 *
 * File: Helper.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 19:18 - Create Wireframe
 *
 *******************************************************/

using System;

namespace ManagedOpenGL.CodeGenerator.Rules
{
	public static class Helper
	{
		public static string FirstSymbolToUpper( this string text )
		{
			if (text.Length == 0) return text;
			return Char.ToUpper( text[0] ) + text.Substring( 1 ).ToLower();
		}
	}
}