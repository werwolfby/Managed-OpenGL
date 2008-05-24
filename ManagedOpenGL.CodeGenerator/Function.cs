/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 16:21
 *
 * File: Function.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 16:21 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator2
{
	[DebuggerDisplay("{Name,nq}({System.String.Join(\", \", Params),nq})")]
	public class Function
	{
		private static readonly Regex functionName = new Regex( @"^(?'name'[a-zA-Z][a-zA-Z0-9]*)\b*\((?'params'.*)\)$",
		                                                        RegexOptions.Compiled | RegexOptions.Singleline );

		public string Name;
		public string[] Params;

		public List<FunctionOption> options = new List<FunctionOption>();

		public static bool IsFunctionLine( string line )
		{
			return functionName.IsMatch( line );
		}

		public static Function Parse( string line, int lineNumber )
		{
			var match = functionName.Match( line );
			if (!match.Success) throw new Exception( "Can't parse function name: `" + line + "` at line " + lineNumber );

			return new Function
			       {
			       	Name = match.Groups["name"].Value,
			       	Params = Array.ConvertAll( match.Groups["params"].Value.Split( ',' ), input => input.Trim() )
			       };
		}
	}
}