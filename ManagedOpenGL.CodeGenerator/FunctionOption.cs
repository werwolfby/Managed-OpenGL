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
using System.CodeDom.Compiler;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.CSharp;

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

	public static class FunctionOptionExtension
	{
		public static readonly CodeDomProvider codeDomProvider = new CSharpCodeProvider();

		public static string GetCSName( this ReturnFunctionOption returnFunctionOption, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList,
			IList<EnumData> enumDatas )
		{
			CSTypeMap csTypeMap;
			TypeMap typeMap;
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, returnFunctionOption.ReturnType, false );
			if (typeMap.LanguageName.Name == "*") return "void";
			if (csTypeMap.Attributes.Contains( "enum" ))
			{
				if (enumDatas.FirstOrDefault(data => data.Name == returnFunctionOption.ReturnType) != null) 
					return returnFunctionOption.ReturnType;
			}
			return csTypeMap.LanguageName;
		}

		public static string GetCSName( this ParamFunctionOption paramFunctionOption, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList,
			IList<EnumData> enumDatas )
		{
			CSTypeMap csTypeMap;
			TypeMap typeMap;
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, paramFunctionOption.ParamType,
			            paramFunctionOption is ArrayParamFunctionOption );
			if (csTypeMap.Attributes.Contains( "enum" ))
			{
				if (enumDatas.FirstOrDefault(data => data.Name == paramFunctionOption.ParamType) != null) 
					return paramFunctionOption.ParamType;
			}
			if (csTypeMap.LanguageName == "void")
			{
				return "void" + new string( '*', typeMap.LanguageName.PointDeep +
				                                 (paramFunctionOption is ArrayParamFunctionOption ? 1 : 0) );
			}
			return csTypeMap.LanguageName + new string( '*', typeMap.LanguageName.PointDeep > 0 ? typeMap.LanguageName.PointDeep : 0 ) +
			       (paramFunctionOption is ArrayParamFunctionOption ? "[]" : "");
		}

		public static void GetTypeMap( this ReturnFunctionOption returnFunctionOption, 
			IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
			out TypeMap typeMap )
		{
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, returnFunctionOption.ReturnType, false );
		}

		public static void GetTypeMap( this ParamFunctionOption paramFunctionOption, 
			IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
			out TypeMap typeMap )
		{
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, paramFunctionOption.ParamType, 
				paramFunctionOption is ArrayParamFunctionOption );
		}

		public static void GetTypeMap( IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
			out TypeMap typeMap, string type, bool isArray )
		{
			var _typeMap = typeMapList.FirstOrDefault( map => map.GLName == type );
			typeMap = _typeMap;
			if (_typeMap == null) throw new Exception( "Unknow return type: " + type );
			if (_typeMap.LanguageName.Name == "*")
			{
				csTypeMap = null;
				return;
			}
			csTypeMap = csTypeMapList.FirstOrDefault( map1 => map1.GLName == _typeMap.LanguageName.Name );
			if (csTypeMap.LanguageName == "char" && (_typeMap.LanguageName.PointDeep == 1 || isArray))
			{
				csTypeMap = new CSTypeMap { GLName = "GLchar", LanguageName = "string", Attributes = new string[0] };
				if (_typeMap.LanguageName.PointDeep == 1) _typeMap.LanguageName.PointDeep--;
			}
			if (csTypeMap == null) throw new Exception( "Unknow CS type: " + _typeMap.LanguageName.Name );
		}

		public static string GetCSName( this string name )
		{
			return codeDomProvider.CreateEscapedIdentifier( name );
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