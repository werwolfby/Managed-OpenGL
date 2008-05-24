using System;
using System.Linq;
using System.Collections.Generic;
using WolfGenerator.Core;
using ManagedOpenGL.CodeGenerator;
using System.Reflection;
using System.Collections;

public partial class EnumGenerator
{
	public string Main( IEnumerable<EnumData> enumList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "using System;" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "namespace ManagedOpenGL" );
		codeWriter.AppendLine( "{" );
		codeWriter.Append( "	" );
		{
			string value = string.Join( "", EntityConstructorsApplyMethod0( typeMapList, csTypeMapList, enumList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GenerateEnum( EnumData enumData, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
	{
		CodeWriter codeWriter = new CodeWriter();
		var glTypeMap = typeMapList.FirstOrDefault(map => map.GLName == enumData.Name);
				if (glTypeMap != null)
				{
					var csTypeMap = csTypeMapList.FirstOrDefault( map => map.GLName == glTypeMap.LanguageName );
					if (csTypeMap != null && csTypeMap.Attributes.Contains( "flags" ))
					{
		codeWriter.AppendLine( "[Flags]" );
		}
				}
		codeWriter.Append( "public enum " );
		codeWriter.Append( GetCSName( enumData.Name ) );
		codeWriter.AppendLine( " : uint" );
		codeWriter.AppendLine( "{" );
		codeWriter.Append( "	" );
		{
			string value = string.Join( "", EntityConstructorsApplyMethod1( enumData.ItemList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GetValue( EnumItem item )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( ConvertName( item.Name ) );
		codeWriter.Append( " = " );
		codeWriter.Append( item.Value );
		codeWriter.AppendLine( "," );
		return codeWriter.ToString();
	}
	public string GetValue( UseEnumItem item )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( ConvertName( item.Value ) );
		codeWriter.Append( " = " );
		codeWriter.Append( GetCSName( item.Name ) );
		codeWriter.Append( "." );
		codeWriter.Append( ConvertName( item.Value ) );
		codeWriter.AppendLine( "," );
		return codeWriter.ToString();
	}
	#region Apply Methods
	public List<string> EntityConstructorsApplyMethod0(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateEnum",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	
	
	public List<string> EntityConstructorsApplyMethod1( IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GetValue",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	#endregion 
}
