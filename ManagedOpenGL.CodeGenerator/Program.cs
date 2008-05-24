using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ManagedOpenGL.CodeGenerator2
{
	class Program
	{
		static void Main( string[] args )
		{
			var typeMapList = ParseTypeMapList( "Data\\gl.tm" );
			
			var csTypeMapList = ParseCSTypeMapList( "Data\\cs.tm" );

			var functions = GlSpecParser.Parse( "Data\\gl.spec" );

			var enumDatas = EnumSpecParser.Parse( "Data\\enum.spec" );

			var extEnumDatas = EnumSpecParser.Parse( "Data\\enumext.spec" );

			var enumList = enumDatas.Concat( extEnumDatas ).ToList();

			var enumCsTypes = (from csType in csTypeMapList where csType.Attributes.Contains( "enum" ) select csType).ToList();

			foreach (var typeMap in typeMapList)
			{
				var typeMap1 = typeMap;
				var csTypeMap = enumCsTypes.FirstOrDefault(map => map.GLName == typeMap1.LanguageName);
				if (csTypeMap == null) continue;
				if (csTypeMap.Attributes.Contains( "flags" )) Console.WriteLine("[Flags]");
				Console.WriteLine( "public enum " + typeMap1.GLName + " : " + csTypeMap.LanguageName );
			}
		}

		static IList<TypeMap> ParseTypeMapList( string filename )
		{
			var mapList = new List<TypeMap>();

			using (var reader = new StreamReader( filename ))
			{
				var lineNumber = 1;
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					line = line.Trim();
					lineNumber++;
					if (line == "" || line.Trim()[0] == '#') continue;
					mapList.Add( TypeMap.Parse( line, lineNumber ) );
				}
			}

			return mapList;
		}

		static IList<CSTypeMap> ParseCSTypeMapList( string filename )
		{
			var mapList = new List<CSTypeMap>();

			using (var reader = new StreamReader( filename ))
			{
				var lineNumber = 1;
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					line = line.Trim();
					lineNumber++;
					if (line == "" || line.Trim()[0] == '#') continue;
					mapList.Add( CSTypeMap.Parse( line, lineNumber ) );
				}
			}

			return mapList;
		}
	}
}
