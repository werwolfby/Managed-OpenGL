using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ManagedOpenGL.CodeGenerator
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

			var enumGenerator = new EnumGenerator();

			using (var writer = new StreamWriter( "Enums.cs" ))
			{
				writer.WriteLine( enumGenerator.Main( enumList ) );
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
