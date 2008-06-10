using System;
using System.Collections.Generic;
using ManagedOpenGL.CodeGenerator.Rules;
using WolfGenerator.Core;
using ManagedOpenGL.CodeGenerator;
using System.Reflection;
using System.Collections;

public partial class NativeGenerator
{
	public string Main( IEnumerable<Function> functionList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, bool first, string name, IEnumerable<string> names )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.AppendLine( "using System;" );
		codeWriter.AppendLine( "using System.Runtime.InteropServices;" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "namespace ManagedOpenGL" );
		codeWriter.AppendLine( "{" );
		codeWriter.AppendLine( "	public static partial class OpenGLNative" );
		codeWriter.AppendLine( "	{	" );
		codeWriter.Append( "		static void OpenGLNative" );
		codeWriter.Append( name.ToCSName() );
		codeWriter.AppendLine( "Init()" );
		codeWriter.AppendLine( "		{" );
		codeWriter.Append( "			" );
		{
			string value = string.Join( "", ApplyMethod0( typeMapList, csTypeMapList, enumDatas, functionList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "			" );
		codeWriter.AppendLine( "		}" );
		codeWriter.AppendLine( "		" );
		if (first) {
		codeWriter.AppendLine( "		" );
		codeWriter.AppendLine( "		static OpenGLNative()" );
		codeWriter.AppendLine( "		{" );
		codeWriter.Append( "			" );
		{
			string value = string.Join( "", ApplyMethod1( names ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "		}" );
		codeWriter.AppendLine();
		codeWriter.AppendLine( "		public static T GetProcAdress<T>( string functionName )" );
		codeWriter.AppendLine( "			where T : class" );
		codeWriter.AppendLine( "		{" );
		codeWriter.AppendLine( "			var ptr = WindowsOpenGLNative.wglGetProcAddress( functionName );" );
		codeWriter.AppendLine( "			if (ptr == IntPtr.Zero) return null;" );
		codeWriter.AppendLine( "			return Marshal.GetDelegateForFunctionPointer( ptr, typeof(T) ) as T;" );
		codeWriter.AppendLine( "		}" );
		}
		codeWriter.AppendLine( "	" );
		codeWriter.Append( "		" );
		{
			string value = string.Join( "", ApplyMethod2( typeMapList, csTypeMapList, enumDatas, functionList ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( "	}" );
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GenetateCallInit( string name )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( "OpenGLNative" );
		codeWriter.Append( name.ToCSName() );
		codeWriter.Append( "Init();" );
		return codeWriter.ToString();
	}
	public string GetFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		if ((function.Version == null || (function.Version.MajorVersion <= 1 && function.Version.MinorVersion <= 1)) && !function.Contains( "extension" )) 
			return "";
		codeWriter.Append( "_" );
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
		codeWriter.Append( "private static " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "Delegate _" );
		codeWriter.Append( function.Name );
		codeWriter.AppendLine( ";" );
		codeWriter.AppendLine();
		codeWriter.Append( "public static " );
		if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
		codeWriter.Append( "unsafe " );
		}
		codeWriter.Append( " " );
		codeWriter.Append( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
		codeWriter.Append( " " );
		codeWriter.Append( function.Name );
		codeWriter.Append( "( " );
		{
			string value = string.Join( ", ", JoinMethod2( typeMapList, csTypeMapList, enumDatas, function ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( " )" );
		codeWriter.AppendLine( "{" );
		codeWriter.Append( "	if (_" );
		codeWriter.Append( function.Name );
		codeWriter.Append( " == null) throw new Exception( \"Extension method " );
		codeWriter.Append( function.Name );
		codeWriter.AppendLine( " not found\" );" );
		codeWriter.Append( "	" );
		if (function.Return.ReturnType != "void"){
		codeWriter.Append( "return " );
		}
		codeWriter.Append( " _" );
		codeWriter.Append( function.Name );
		codeWriter.Append( "( " );
		{
			string value = string.Join( ", ", JoinMethod3( typeMapList, csTypeMapList, enumDatas, function ).ToArray() );
			if (value.EndsWith( "\r\n" )) codeWriter.AppendLine( value );
			else codeWriter.Append( value );
		}
		codeWriter.AppendLine( " );" );
		codeWriter.AppendLine( "}" );
		return codeWriter.ToString();
	}
	public string GenerateParamName( ValueParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		if (p.Direction == "out"){
		codeWriter.Append( "ref " );
		}
		codeWriter.Append( p.ParamName.GetCSName() );
		return codeWriter.ToString();
	}
	public string GenerateParamName( ArrayParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		codeWriter.Append( p.ParamName.GetCSName() );
		return codeWriter.ToString();
	}
	public string GenerateParam( ValueParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
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
	public string GenerateParam( ArrayParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
	{
		CodeWriter codeWriter = new CodeWriter();
		if (p.Direction == "out"){
		codeWriter.Append( "[Out]" );
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
	
	
	public List<string> ApplyMethod1( IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenetateCallInit",
			                             BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public,
			                             Type.DefaultBinder, this, new object[] {  item  } ).ToString();
			if (!string.IsNullOrEmpty( value )) strings.Add( value );
		}
		return strings;
	}
	
	
	public List<string> ApplyMethod2(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
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
	
	
	public List<string> ApplyMethod3(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
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
	
	
	public List<string> ApplyMethod4(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, IEnumerable enumList )
	{
		List<string> strings = new List<string>();
		foreach( object item in enumList )
		{
			string value = this.GetType().InvokeMember( "GenerateParamName",
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
		strings.AddRange( ApplyMethod3( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	
	
	public List<string> JoinMethod1(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod3( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	
	
	public List<string> JoinMethod2(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod3( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	
	
	public List<string> JoinMethod3(  IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, Function function )
	{
		List<string> strings = new List<string>();
		strings.AddRange( ApplyMethod4( typeMapList, csTypeMapList, enumDatas, function.ParamList ) );
		return strings;
	}
	#endregion 
}
