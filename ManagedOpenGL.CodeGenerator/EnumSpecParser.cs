/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 17:26
 *
 * File: EnumSpecParser.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 17:26 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ManagedOpenGL.CodeGenerator2
{
	public static class EnumSpecParser
	{
		private static readonly Regex definesRegex = new Regex( @"^(?'name'.*)\b+define:" );

		public static IList<EnumData> Parse( string filename )
		{
			var enumDataList = new List<EnumData>();
			
			using (var reader = new StreamReader( filename ))
			{
				var lineNumber = 0;
				string line;
				EnumData currentEnum = null;
				while ((line = reader.ReadLine()) != null)
				{
					lineNumber++;
					line = line.Trim();
					if (line == "" || line.Trim()[0] == '#') continue;
					var match = definesRegex.Match( line );
					if (match.Success) continue;
					if (GlSpecParser.IsSetting( line )) continue;
					if (EnumData.IsEnumData( line ))
					{
						currentEnum = EnumData.Parse( line, lineNumber );
						enumDataList.Add( currentEnum );
						continue;
					}
					if (!EnumItem.IsEnumItem( line )) throw new Exception( "Can't parse line `" + line + "` at line " + lineNumber );
					var enumItem = EnumItem.Parse( line.Trim(), lineNumber );
					if (currentEnum == null) continue;
					currentEnum.itemList.Add( enumItem );
				}
			}

			return enumDataList;
		}
	}
}