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

			var enumList = new List<EnumData>();
			foreach (var enumData in enumDatas.Concat( extEnumDatas ))
			{
				var enumData1 = enumData;
				var find = enumList.Find( data => data.Name == enumData1.Name );
				if (find != null)
				{
					var notInList = from i in enumData1.ItemList
					                where find.ItemList.Find( item => item.Name == i.Name ) == null
					                select i;
					find.ItemList.AddRange( notInList );
					continue;
				}
				enumList.Add( enumData );
			}

			var enumGenerator = new EnumGenerator();

			using (var writer = new StreamWriter( @"..\..\..\ManagedOpenGL\Enums.cs" ))
			{
				writer.WriteLine( enumGenerator.Main( enumList, typeMapList, csTypeMapList ) );
			}

			var nativeGenerator = new NativeGenerator();

			using (var writer = new StreamWriter( @"..\..\..\ManagedOpenGL\OpenGLNative.cs" ))
			{
				writer.WriteLine( nativeGenerator.Main( functions, typeMapList, csTypeMapList, enumDatas ) );
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
