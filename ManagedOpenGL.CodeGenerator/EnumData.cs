/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 17:28
 *
 * File: EnumData.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 17:28 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator
{
	[DebuggerDisplay("{Name,nq} enum[{ItemList.Count}]")]
	public class EnumData
	{
		private static readonly Regex enumRegex = new Regex( @"^(?'name'[a-zA-Z0-9_]*)\s+enum:" );

		public string Name;
		public List<EnumItem> ItemList = new List<EnumItem>();

		public static bool IsEnumData( string line )
		{
			return enumRegex.IsMatch( line );
		}

		public static EnumData Parse( string line, int lineNumber )
		{
			var match = enumRegex.Match( line );
			if (!match.Success) throw new Exception( "Can't parse enum item name: `" + line + "` at line " + lineNumber );

			return new EnumData
			       {
			       	Name = match.Groups["name"].Value,
			       };
		}
	}
	
	[DebuggerDisplay("{Name,nq} = {Value,nq}{System.String.IsNullOrEmpty(Comment) ? \"\" : \"// \" + Comment,nq}")]
	public class EnumItem
	{
		private static readonly Regex itemRegex = new Regex( @"^(?'name'[a-zA-Z0-9_]+)\s*=\s*(?'value'.*?)\s*(\#\s*(?'comment'.*))?$",
		                                                     RegexOptions.Compiled | RegexOptions.Singleline );

		private static readonly Regex useItemRegex =
			new Regex( @"^use\s+(?'name'[a-zA-Z0-9_]+)\s+(?'value'.*?)\s*(\#\s*(?'comment'.*))?$",
			           RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline );

		public string Name;
		public string Value;
		public string Comment;

		public static bool IsEnumItem( string line )
		{
			return itemRegex.IsMatch( line ) || useItemRegex.IsMatch( line );
		}

		public static EnumItem Parse( string line, int lineNumber )
		{
			var match = itemRegex.Match( line );
			if (match.Success)
			{
				return new EnumItem
				       {
				       	Name = match.Groups["name"].Value,
				       	Value = match.Groups["value"].Value,
				       	Comment = match.Groups["comment"] != null ? match.Groups["comment"].Value : null
				       };
			}

			match = useItemRegex.Match( line );
			if (match.Success)
			{
				return new UseEnumItem
				       {
				       	Name = match.Groups["name"].Value,
				       	Value = match.Groups["value"].Value,
				       	Comment = match.Groups["comment"] != null ? match.Groups["comment"].Value : null
				       };
			}
			
			throw new Exception( "Can't parse enum item name: `" + line + "` at line " + lineNumber );
		}
	}

	[DebuggerDisplay("use {Name,nq} {Value,nq}")]
	public class UseEnumItem : EnumItem
	{
	}
}