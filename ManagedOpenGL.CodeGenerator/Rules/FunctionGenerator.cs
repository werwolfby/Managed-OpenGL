using System;
using System.Collections.Generic;
using WolfGenerator.Core.Writer;
using WolfGenerator.Core;

namespace ManagedOpenGL.CodeGenerator.Rules
{
	public partial class NativeGenerator : GeneratorBase
	{
		public CodeWriter GenerateFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			if ((function.Version == null || (function.Version.MajorVersion <= 1 && function.Version.MinorVersion <= 1)) && !function.Contains( "extension" ))
				return GenerateOpenGLFunction( function, typeMapList, csTypeMapList, enumDatas );
			return GenerateDelegateFunction( function, typeMapList, csTypeMapList, enumDatas );

		}

		public CodeWriter Main( IEnumerable<Function> functionList, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas, bool first, string name, IEnumerable<string> names )
		{
			var writer = new CodeWriter();

			writer.Indent = 0;
			writer.AppendLine( "using System;" );
			writer.AppendLine( "using System.Runtime.InteropServices;" );
			writer.AppendLine();
			writer.AppendLine( "namespace ManagedOpenGL" );
			writer.AppendLine( "{" );
			writer.Indent = 1;
			writer.AppendLine( "public static partial class OpenGLNative" );
			writer.AppendLine( "{	" );
			writer.Indent = 2;
			writer.Append( "static void OpenGLNative" );
			writer.AppendText( name.ToCSName() );
			writer.Indent = 0;
			writer.AppendLine( "Init()" );
			writer.Indent = 2;
			writer.AppendLine( "{" );
			writer.Indent = 3;
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in functionList)
				{
					temp = this.Invoke( "GetFunction", item, typeMapList, csTypeMapList, enumDatas );
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
			writer.Indent = 2;
			writer.AppendLine( "}" );
			if (first) {
			writer.Indent = 0;
			writer.AppendLine();
			writer.Indent = 2;
			writer.AppendLine( "static OpenGLNative()" );
			writer.AppendLine( "{" );
			writer.Indent = 3;
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in names)
				{
					temp = this.Invoke( "GenetateCallInit", item );
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
			writer.Indent = 2;
			writer.AppendLine( "}" );
			writer.Indent = 0;
			writer.AppendLine();
			writer.Indent = 2;
			writer.AppendLine( "public static T GetProcAdress<T>( string functionName )" );
			writer.Indent = 3;
			writer.AppendLine( "where T : class" );
			writer.Indent = 2;
			writer.AppendLine( "{" );
			writer.Indent = 3;
			writer.AppendLine( "var ptr = WindowsOpenGLNative.wglGetProcAddress( functionName );" );
			writer.AppendLine( "if (ptr == IntPtr.Zero) return null;" );
			writer.AppendLine( "return Marshal.GetDelegateForFunctionPointer( ptr, typeof(T) ) as T;" );
			writer.Indent = 2;
			writer.AppendLine( "}" );
			}
			writer.Indent = 1;
			writer.AppendLine();
			writer.Indent = 2;
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in functionList)
				{
					temp = this.Invoke( "GenerateFunction", item, typeMapList, csTypeMapList, enumDatas );
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
			writer.Indent = 1;
			writer.AppendLine( "}" );
			writer.Indent = 0;
			writer.Append( "}" );

			return writer;
		}

		public CodeWriter GenetateCallInit( string name )
		{
			var writer = new CodeWriter();

			writer.Indent = 0;
			writer.Append( "OpenGLNative" );
			writer.AppendText( name.ToCSName() );
			writer.Indent = 0;
			writer.Append( "Init();" );

			return writer;
		}

		public CodeWriter GetFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			if ((function.Version == null || (function.Version.MajorVersion <= 1 && function.Version.MinorVersion <= 1)) && !function.Contains( "extension" )) 
				return writer;
			writer.Indent = 0;
			writer.Append( "_" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( " = GetProcAdress< " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "Delegate >( \"gl" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "\" );" );

			return writer;
		}

		public CodeWriter GenerateOpenGLFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			writer.Indent = 0;
			writer.Append( "[DllImport( \"opengl32.dll\", EntryPoint=\"gl" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.AppendLine( "\" )]" );
			writer.Append( "public static extern " );
			if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
			writer.Indent = 0;
			writer.Append( "unsafe " );
			}
			writer.AppendText( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "( " );
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in function.ParamList)
				{
					temp = this.Invoke( "GenerateParam", item, typeMapList, csTypeMapList, enumDatas );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( ", " );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.Append( " ); // " );
			if (function.Contains( "extension" )){
			writer.Indent = 0;
			writer.Append( " extension method" );
			}
			writer.Indent = 0;
			writer.AppendLine();
			writer.Indent = 1;

			return writer;
		}

		public CodeWriter GenerateDelegateFunction( Function function, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			writer.Indent = 0;
			writer.Append( "public " );
			if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
			writer.Indent = 0;
			writer.Append( "unsafe " );
			}
			writer.Indent = 0;
			writer.Append( "delegate " );
			writer.AppendText( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "Delegate( " );
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in function.ParamList)
				{
					temp = this.Invoke( "GenerateParam", item, typeMapList, csTypeMapList, enumDatas );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( ", " );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.Append( " ); // " );
			if (function.Contains( "extension" )){
			writer.Indent = 0;
			writer.Append( " extension method" );
			}
			writer.Indent = 0;
			writer.AppendLine();
			writer.AppendLine();
			writer.Append( "private static " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "Delegate _" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.AppendLine( ";" );
			writer.AppendLine();
			writer.Append( "public static " );
			if (function.IsUnsafeMethod(typeMapList, csTypeMapList)){
			writer.Indent = 0;
			writer.Append( "unsafe " );
			}
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( function.Return.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "( " );
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in function.ParamList)
				{
					temp = this.Invoke( "GenerateParam", item, typeMapList, csTypeMapList, enumDatas );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( ", " );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.AppendLine( " )" );
			writer.AppendLine( "{" );
			writer.Indent = 1;
			writer.Append( "if (_" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( " == null) throw new Exception( \"Extension method " );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.AppendLine( " not found\" );" );
			writer.Indent = 1;
			if (function.Return.ReturnType != "void"){
			writer.Indent = 0;
			writer.Append( "return " );
			}
			writer.Indent = 0;
			writer.Append( " _" );
			writer.AppendText( function.Name );
			writer.Indent = 0;
			writer.Append( "( " );
			{
				var list = new List<CodeWriter>();
				CodeWriter temp;

				foreach (var item in function.ParamList)
				{
					temp = this.Invoke( "GenerateParamName", item, typeMapList, csTypeMapList, enumDatas );
					list.Add( temp );
				}

				writer.AppendType = AppendType.EmptyLastLine;
				for (var listI = 0; listI < list.Count; listI++)
				{
					var codeWriter = list[listI];
					writer.Append( codeWriter );
					if (listI < list.Count - 1)
						writer.AppendText( ", " );
				}
				writer.AppendType = AppendType.EmptyLastLine;
			}
			writer.Indent = 0;
			writer.AppendLine( " );" );
			writer.Append( "}" );

			return writer;
		}

		public CodeWriter GenerateParamName( ValueParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			if (p.Direction == "out"){
			writer.Indent = 0;
			writer.Append( "ref " );
			}
			writer.AppendText( p.ParamName.GetCSName() );

			return writer;
		}

		public CodeWriter GenerateParamName( ArrayParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			writer.AppendText( p.ParamName.GetCSName() );

			return writer;
		}

		public CodeWriter GenerateParam( ValueParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			if (p.Direction == "out"){
			writer.Indent = 0;
			writer.Append( "ref " );
			}
			writer.AppendText( p.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( p.ParamName.GetCSName() );

			return writer;
		}

		public CodeWriter GenerateParam( ArrayParamFunctionOption p, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList, IList<EnumData> enumDatas )
		{
			var writer = new CodeWriter();

			if (p.Direction == "out"){
			writer.Indent = 0;
			writer.Append( "[Out]" );
			}
			writer.AppendText( p.GetCSName( typeMapList, csTypeMapList, enumDatas ) );
			writer.Indent = 0;
			writer.Append( " " );
			writer.AppendText( p.ParamName.GetCSName() );

			return writer;
		}
	}
}