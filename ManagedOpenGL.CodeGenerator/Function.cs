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
using System.Linq;

namespace ManagedOpenGL.CodeGenerator
{
	[DebuggerDisplay("{Name,nq}({System.String.Join(\", \", Params),nq})")]
	public class Function
	{
		private static readonly Regex functionName = new Regex( @"^(?'name'[a-zA-Z][a-zA-Z0-9]*)\b*\((?'params'.*)\)$",
		                                                        RegexOptions.Compiled | RegexOptions.Singleline );

		public string Name;
		public string[] Params;

		public readonly List<ParamFunctionOption> ParamList = new List<ParamFunctionOption>();
		public ReturnFunctionOption Return;
		public VersionFunctionOption Version;

		private readonly List<FunctionOption> options = new List<FunctionOption>();

		public bool IsUnsafeMethod( IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMaps )
		{
			foreach (var paramFunctionOption in this.ParamList)
			{
				CSTypeMap csTypeMap;
				TypeMap typeMap;
				paramFunctionOption.GetTypeMap( typeMapList, csTypeMaps, out csTypeMap, out typeMap );
				if ((csTypeMap != null && csTypeMap.LanguageName == "void") || typeMap.LanguageName.PointDeep > 0) return true;
			}

			return false;
		}

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

		public void Add( FunctionOption functionOption )
		{
			if (functionOption is ParamFunctionOption) ParamList.Add( (ParamFunctionOption)functionOption );
			if (functionOption is ReturnFunctionOption) Return = (ReturnFunctionOption)functionOption;
			if (functionOption is VersionFunctionOption) Version = (VersionFunctionOption)functionOption;

			options.Add( functionOption );
		}

		public bool Contains( string option )
		{
			return options.FirstOrDefault( functionOption => functionOption.Name == option ) != null;
		}
	}
}