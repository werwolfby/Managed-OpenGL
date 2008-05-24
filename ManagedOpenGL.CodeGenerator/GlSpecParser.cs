/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 16:30
 *
 * File: GlSpecParser.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 16:30 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator
{
	public static class GlSpecParser
	{
		private static readonly Regex settingRegex = new Regex( @"^(?'name'[a-zA-Z-]+)\b*:\b*(?'value'.*)\b*$" );

		public static bool IsSetting( string line )
		{
			return settingRegex.IsMatch( line );
		}

		public static IList<Function> Parse( string filename )
		{
			var functionList = new List<Function>();
			
			using (var reader = new StreamReader( filename ))
			{
				var lineNumber = 1;
				string line;
				Function currentFunction = null;
				while ((line = reader.ReadLine()) != null)
				{
					if (line == "" || line.Trim()[0] == '#') continue;
					var match = settingRegex.Match( line );
					if (match.Success) continue;
					if (Function.IsFunctionLine( line ))
					{
						currentFunction = Function.Parse( line, lineNumber );
						functionList.Add( currentFunction );
						continue;
					}
					if (currentFunction == null) throw new Exception( "Can't parse line: `" + line + "` at line " + lineNumber );
					currentFunction.Add( FunctionOption.Parse( line.Trim(), lineNumber ) );
					lineNumber++;
				}
			}

			return functionList;
		}
	}
}