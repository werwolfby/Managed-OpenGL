using System;
using System.Collections.Generic;
using WolfGenerator.Core;
using ManagedOpenGL.CodeGenerator;
using System.Reflection;
using System.Collections;

public partial class NativeGenerator
{
	public string Main( IList<Function> functionList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "using System.Runtime.InteropServices;" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "namespace ManagedOpenGL" );
		codeWriter.AppendLine( "{" );
		codeWriter.AppendLine( "	public static class OpenGLNative" );
		codeWriter.AppendLine( "	{" );
		codeWriter.Append( "		" );
		{
			string value = string.Join( "", ApplyMethod0( typeMapList, csTypeMapList, functionList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "	}" );
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GenerateFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "[DllImport( \"opengl32.dll\" )]" );
		codeWriter.Append( "public static extern " );
		codeWriter.Append( function.Return.GetCSName( typeMapList, csTypeMapList ) );
		codeWriter.Append( " " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "( " );
		{
			string value = string.Join( ", ", JoinMethod0( typeMapList, csTypeMapList, function ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( " );" );
		return codeWriter.ToString();
	}
	public string GenerateParam( ParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( p.GetCSName( typeMapList, csTypeMapList ) );
		codeWriter.Append( " " );
		codeWriter.Append( p.ParamName );
		return codeWriter.ToString();
	}
	#region Apply Methods
	public List<string> ApplyMethod0(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateFunction",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	
	
	public List<string> ApplyMethod1(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateParam",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	#endregion 
	#region Join Methods
	public List<string> JoinMethod0(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod1( typeMapList, csTypeMapList, function.ParamList ) );
		return strings;
	}
	#endregion 
}
