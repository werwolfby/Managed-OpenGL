using System;
using System.Collections.Generic;
using WolfGenerator.Core;
using ManagedOpenGL.CodeGenerator;
using System.Reflection;
using System.Collections;

public partial class EnumGenerator
{
	public string Main( IEnumerable<EnumData> enumList )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "namespace ManagedOpenGL" );
		codeWriter.AppendLine( "{" );
		codeWriter.Append( "	" );
		{
			string value = string.Join( "", EntityConstructorsApplyMethod0( enumList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GenerateEnum( EnumData enumData )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( "public enum " );
		codeWriter.Append( enumData.Name );
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
		codeWriter.Append( item.Name );
		codeWriter.Append( " = " );
		codeWriter.Append( item.Value );
		codeWriter.AppendLine( "," );
		return codeWriter.ToString();
	}
	public string GetValue( UseEnumItem item )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( item.Value );
		codeWriter.Append( " = " );
		codeWriter.Append( item.Name );
		codeWriter.Append( "." );
		codeWriter.Append( item.Value );
		codeWriter.AppendLine( "," );
		return codeWriter.ToString();
	}
	#region Apply Methods
	public List<string> EntityConstructorsApplyMethod0( IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateEnum",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item  } ).ToString();
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
