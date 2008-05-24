/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 18:18
 *
 * File: CSTypeMap.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 18:18 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator2
{
	public class CSTypeMap
	{
		private static readonly Regex csTypeMapRegex =
			new Regex( @"typedef\s+(?'cs'[a-zA-Z][a-zA-Z0-9\.]*)\s+(\[(?'at'.*)\])?(?'gl'[a-zA-Z][a-zA-Z0-9]*)",
			           RegexOptions.Compiled );

		public string LanguageName;
		public string GLName;
		public string[] Attributes;

		public static CSTypeMap Parse( string line, int lineNumber )
		{
			var match = csTypeMapRegex.Match( line );
			if (!match.Success) throw new Exception( "Can't parse cs type mape : `" + line + "` at line " + lineNumber );

			return new CSTypeMap
			       {
			       	LanguageName = match.Groups["cs"].Value,
			       	GLName = match.Groups["gl"].Value,
			       	Attributes = Array.ConvertAll( match.Groups["at"].Value.Split( new []{ ',' }, StringSplitOptions.RemoveEmptyEntries ), input => input.Trim() )
			       };
		}
	}
}