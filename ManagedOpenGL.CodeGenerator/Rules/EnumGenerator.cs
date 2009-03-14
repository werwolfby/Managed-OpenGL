using System;
using System.Linq;
using System.Collections.Generic;
using WolfGenerator.Core;
using WolfGenerator.Core.Writer;

namespace ManagedOpenGL.CodeGenerator.Rules
{
	public partial class EnumGenerator : GeneratorBase
	{
		public CodeWriter Main( IEnumerable<EnumData> enumList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
		{
			var writer = new CodeWriter();

			writer.Indent = 0;
			writer.AppendLine( "using System;" );
			writer.AppendLine();
			writer.AppendLine( "namespace ManagedOpenGL" );
			writer.AppendLine( "{" );
			writer.Indent = 1;
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in enumList)
				{
					temp = this.Invoke( "GenerateEnum", item, typeMapList, csTypeMapList );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( "\r\n" );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.AppendLine();
			writer.Append( "}" );

			return writer;
		}

		public CodeWriter GenerateEnum( EnumData enumData, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
		{
			var writer = new CodeWriter();

			var glTypeMap = typeMapList.FirstOrDefault(map => map.GLName == enumData.Name);
					if (glTypeMap != null)
					{
						var csTypeMap = csTypeMapList.FirstOrDefault( map => map.GLName == glTypeMap.LanguageName.Name );
						if (csTypeMap != null && csTypeMap.Attributes.Contains( "flags" ))
						{
			writer.Indent = 0;
			writer.Append( "[Flags]" );
			}
					}
			writer.Indent = 0;
			writer.AppendLine();
			writer.Append( "public enum " );
			writer.AppendText( GetCSName( enumData.Name ) );
			writer.Indent = 0;
			writer.AppendLine( " : uint" );
			writer.AppendLine( "{" );
			writer.Indent = 1;
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in enumData.ItemList)
				{
					temp = this.Invoke( "GetValue", item );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( "\r\n" );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.AppendLine();
			writer.Append( "}" );

			return writer;
		}

		public CodeWriter GetValue( EnumItem item )
		{
			var writer = new CodeWriter();

			writer.AppendText( ConvertName( item.Name ) );
			writer.Indent = 0;
			writer.Append( " = " );
			writer.AppendText( item.Value );
			writer.Indent = 0;
			writer.Append( "," );

			return writer;
		}

		public CodeWriter GetValue( UseEnumItem item )
		{
			var writer = new CodeWriter();

			writer.AppendText( ConvertName( item.Value ) );
			writer.Indent = 0;
			writer.Append( " = " );
			writer.AppendText( GetCSName( item.Name ) );
			writer.Indent = 0;
			writer.Append( "." );
			writer.AppendText( ConvertName( item.Value ) );
			writer.Indent = 0;
			writer.Append( "," );

			return writer;
		}
	}
}