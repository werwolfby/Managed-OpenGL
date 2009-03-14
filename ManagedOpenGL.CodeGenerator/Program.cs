using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ManagedOpenGL.CodeGenerator.Rules;

namespace ManagedOpenGL.CodeGenerator
{
	static class Program
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

		    var enumCode = new EnumGenerator().Main(enumList, typeMapList, csTypeMapList);

			using (var writer = new StreamWriter( @"..\..\..\ManagedOpenGL\Enums.cs" ))
			{
			    writer.WriteLine( enumCode );
			}

		    var nativeGenerator = new NativeGenerator();

			var functionCategoryDictionary = new Dictionary<string, List<Function>>();

			foreach (var function in functions)
			{
				var category = function.GetValueOptions( "category" );
				if (string.IsNullOrEmpty( category )) category = "Native";
				functionCategoryDictionary.GetList( category ).Add( function );
			}

			var first = true;

			foreach (var keyValuePair in functionCategoryDictionary)
			{
				var directory = @"..\..\..\ManagedOpenGL\Native\";
				if (!Directory.Exists( directory )) Directory.CreateDirectory( directory );
                var generatedCode = nativeGenerator.Main(keyValuePair.Value, typeMapList, csTypeMapList, enumDatas, first,
                                                 keyValuePair.Key, functionCategoryDictionary.Keys);
                using (var writer = new StreamWriter(directory + @"OpenGLNative." + keyValuePair.Key + @".cs"))
				{
				    writer.WriteLine( generatedCode );
				}
			    first = false;
			}
		}

		static List<Function> GetList( this IDictionary<string, List<Function>> dictionary, string category )
		{
			List<Function> list;
			if (!dictionary.TryGetValue( category, out list ))
			{
				list = new List<Function>();
				dictionary.Add( category, list );
			}

			return list;
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
