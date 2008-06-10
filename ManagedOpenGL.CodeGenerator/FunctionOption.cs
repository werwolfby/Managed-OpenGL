/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 16:38
 *
 * File: FunctionOption.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 16:38 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator
{
	[DebuggerDisplay("{Name,nq}")]
	public class FunctionOption
	{
		public string Name;

		public static FunctionOption Parse( string line, int lineNumber )
		{
			line = line.Trim();
			var firstDelimiter = line.IndexOfAny( new[] { ' ', '\t' } );

			if (firstDelimiter == -1) return new FunctionOption { Name = line };

			var name = line.Substring( 0, firstDelimiter ).Trim();
			var tail = line.Substring( firstDelimiter + 1 ).Trim();

			return TailFunctionOption.Parse( name, tail, lineNumber );
		}
	}

	public abstract class TailFunctionOption : FunctionOption
	{
		public static TailFunctionOption Parse( string name, string tail, int lineNumber )
		{
			switch (name)
			{
				case "param":
					return ParamFunctionOption.Parse( name, tail, lineNumber );
				case "return":
					return new ReturnFunctionOption { Name = name, ReturnType = tail.Trim() };
				case "version":
					return VersionFunctionOption.Parse( name, tail, lineNumber );
				default:
					return new OtherTailFunctionOption
					       {
					       	Name = name,
							Tail = tail
					       };
			}
		}
	}

	[DebuggerDisplay("version {MajorVersion}.{MinorVersion}")]
	public class VersionFunctionOption : TailFunctionOption
	{
		private static readonly Regex versionRegex = new Regex( @"^(?'major'[0-9]+)\.(?'minor'[0-9]+)$" );

		public int MajorVersion;
		public int MinorVersion;

		public new static VersionFunctionOption Parse( string name, string tail, int lineNumber )
		{
			var match = versionRegex.Match( tail.Trim() );
			if (!match.Success) throw new Exception( "Can't parse version: " + tail + "at line " + lineNumber );

			return new VersionFunctionOption
			       {
			       	Name = name,
			       	MajorVersion = Convert.ToInt32( match.Groups["major"].Value ),
			       	MinorVersion = Convert.ToInt32( match.Groups["minor"].Value ),
			       };
		}

		public bool LessOrEqual( int major, int minor )
		{
			return MajorVersion <= major && MinorVersion <= minor;
		}
	}

	[DebuggerDisplay("return {ReturnType,nq}")]
	public class ReturnFunctionOption : TailFunctionOption
	{
		public string ReturnType;
	}

	[DebuggerDisplay("{Name,nq} {Tail,nq}")]
	public class OtherTailFunctionOption : TailFunctionOption
	{
		public string Tail;
	}

	public abstract class ParamFunctionOption : TailFunctionOption
	{
		private static readonly Regex valueRegex =
			new Regex( @"^(?'name'[a-zA-Z][a-zA-Z0-9]*)\s+(?'direction'(in)|(out))\s+value(\s+(?'extInfo'.*))?$",
			           RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline );

		private static readonly Regex arrayRegex =
			new Regex( @"^(?'name'[a-zA-Z][a-zA-Z0-9]*)\s+(?'direction'(in)|(out))\s+array\s*\[\s*(?'size'.*)\s*\](\s+(?'extInfo'.*))?$",
			           RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline );

		public string ParamName;
		public string ParamType;
		public string Direction;
		public string ExtInfo;

		public new static ParamFunctionOption Parse( string name, string tail, int lineNumber )
		{
			tail = tail.Trim();
			var firstDelimiter = tail.IndexOfAny( new[] { ' ', '\t' } );

			if (firstDelimiter == -1) throw new Exception( "Can't parse param option: `" + tail + "` at line " + lineNumber );

			var paramName = tail.Substring( 0, firstDelimiter ).Trim();
			var paramType = tail.Substring( firstDelimiter + 1 ).Trim();

			var match = valueRegex.Match( paramType );
			if (match.Success)
				return new ValueParamFunctionOption
				       {
				       	Name = name,
				       	ParamName = paramName,
				       	ParamType = match.Groups["name"].Value,
						Direction = match.Groups["direction"].Value,
						ExtInfo = match.Groups["extInfo"] != null ? match.Groups["extInfo"].Value : null,
				       };
			match = arrayRegex.Match( paramType );
			if (match.Success)
				return new ArrayParamFunctionOption
				       {
				       	Name = name,
				       	ParamName = paramName,
				       	ParamType = match.Groups["name"].Value,
						Direction = match.Groups["direction"].Value,
						ExtInfo = match.Groups["extInfo"] != null ? match.Groups["extInfo"].Value : null,
				       	Length = match.Groups["size"].Value
				       };

			throw new Exception( "Can't parse param type: " + paramType + " at line " + lineNumber );
		}
	}

	[DebuggerDisplay("{Name,nq} {ParamName,nq} {ParamType,nq}")]
	public class ValueParamFunctionOption : ParamFunctionOption
	{
	}

	[DebuggerDisplay("{Name,nq} {ParamName,nq} {ParamType,nq}[{Length,nq}]")]
	public class ArrayParamFunctionOption : ParamFunctionOption
	{
		public string Length;
	}
}