using System;
using System.Collections.Generic;
using WolfGenerator.Core;
using ManagedOpenGL.CodeGenerator;
using System.Reflection;
using System.Collections;

public partial class NativeGenerator
{
	public string Main( IEnumerable<Function> functionList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "using System;" );
		codeWriter.AppendLine( "using System.Runtime.InteropServices;" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "namespace ManagedOpenGL" );
		codeWriter.AppendLine( "{" );
		codeWriter.AppendLine( "	public static class OpenGLNative" );
		codeWriter.AppendLine( "	{" );
		codeWriter.AppendLine( "		unsafe static OpenGLNative()" );
		codeWriter.AppendLine( "		{" );
		codeWriter.Append( "			" );
		{
			string value = string.Join( "", ApplyMethod0( typeMapList, csTypeMapList, enumDatas, functionList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "			" );
		codeWriter.AppendLine( "		}" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "		private static T GetProcAdress<T>( string functionName )" );
		codeWriter.AppendLine( "			where T : class" );
		codeWriter.AppendLine( "		{" );
		codeWriter.AppendLine( "			var ptr = WindowsOpenGLNative.wglGetProcAddress( functionName );" );
		codeWriter.AppendLine( "			if (ptr == IntPtr.Zero) return null;" );
		codeWriter.AppendLine( "			return Marshal.GetDelegateForFunctionPointer( ptr, typeof(T) ) as T;" );
		codeWriter.AppendLine( "		}" );
		codeWriter.AppendLine( "	" );
		codeWriter.Append( "		" );
		{
			string value = string.Join( "", ApplyMethod1( typeMapList, csTypeMapList, enumDatas, functionList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "	}" );
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GetFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		if ((function.Version == null || (function.Version.MajorVersion <= 1 && function.Version.MinorVersion <= 1)) && !function.Contains( "extension" )) 
			return "";
		codeWriter.Append( function.Name );
		codeWriter.Append( " = GetProcAdress< " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "Delegate >( \"gl" );
		codeWriter.Append( function.Name );
		codeWriter.AppendLine( "\" );" );
		return codeWriter.ToString();
	}
	public string GenerateOpenGLFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( "[DllImport( \"opengl32.dll\", EntryPoint=\"gl" );
		codeWriter.Append( function.Name );
		codeWriter.AppendLine( "\" )]" );
		codeWriter.Append( "public static extern " );
		if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
		codeWriter.Append( "unsafe " );
		}
		codeWriter.Append( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
		codeWriter.Append( " " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "( " );
		{
			string value = string.Join( ", ", JoinMethod0( typeMapList, csTypeMapList, enumDatas, function ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.Append( " ); // " );
		if (function.Contains( "extension" )){
		codeWriter.Append( " extension method" );
		}
		codeWriter.AppendLine( "	" );
		return codeWriter.ToString();
	}
	public string GenerateDelegateFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( "public " );
		if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
		codeWriter.Append( "unsafe " );
		}
		codeWriter.Append( "delegate " );
		codeWriter.Append( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
		codeWriter.Append( " " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "Delegate( " );
		{
			string value = string.Join( ", ", JoinMethod1( typeMapList, csTypeMapList, enumDatas, function ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.Append( " ); // " );
		if (function.Contains( "extension" )){
		codeWriter.Append( " extension method" );
		}
		codeWriter.AppendLine();
		codeWriter.Append( "public static readonly " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "Delegate " );
		codeWriter.Append( function.Name );
		codeWriter.AppendLine( ";" );
		return codeWriter.ToString();
	}
	public string GenerateParam( ParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		if (p.Direction == "out"){
		codeWriter.Append( "ref " );
		}
		codeWriter.Append( p.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
		codeWriter.Append( " " );
		codeWriter.Append( p.ParamName.GetCSName() );
		return codeWriter.ToString();
	}
	#region Apply Methods
	public List<string> ApplyMethod0(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GetFunction",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList, enumDatas  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	
	
	public List<string> ApplyMethod1(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateFunction",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList, enumDatas  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	
	
	public List<string> ApplyMethod2(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateParam",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item, typeMapList, csTypeMapList, enumDatas  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	#endregion 
	#region Method
	public string GenerateFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{if ((function.Version == null || (function.Version.MajorVersion <= 1 && function.Version.MinorVersion <= 1)) && !function.Contains( "extension" ))
		return GenerateOpenGLFunction( function, typeMapList, csTypeMapList, enumDatas );
	return GenerateDelegateFunction( function, typeMapList, csTypeMapList, enumDatas );
	}
	#endregion 
	#region Join Methods
	public List<string> JoinMethod0(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod2( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	
	
	public List<string> JoinMethod1(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod2( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	#endregion 
}
