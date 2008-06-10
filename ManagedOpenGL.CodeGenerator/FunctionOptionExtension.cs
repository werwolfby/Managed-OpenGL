/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 16:38
 *
 * File: FunctionOption.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 16:38 - Create Wireframe
 *   10.06.2008 23:17 - Moved from FunctionOption.cs file
 *
 *******************************************************/

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CSharp;

namespace ManagedOpenGL.CodeGenerator
{
	public static class FunctionOptionExtension
	{
		public static readonly CodeDomProvider codeDomProvider = new CSharpCodeProvider();

		public static string GetCSName( this ReturnFunctionOption returnFunctionOption, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList,
		                                IList<EnumData> enumDatas )
		{
			if (returnFunctionOption.ReturnType == "VoidPointer") return "void*";

			CSTypeMap csTypeMap;
			TypeMap typeMap;
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, returnFunctionOption.ReturnType, false );
			if (typeMap.LanguageName.Name == "*") return "void";
			if (csTypeMap.Attributes.Contains( "enum" ))
			{
				if (enumDatas.FirstOrDefault(data => data.Name == returnFunctionOption.ReturnType) != null) 
					return returnFunctionOption.ReturnType;
			}
			return csTypeMap.LanguageName;
		}

		public static string GetCSName( this ParamFunctionOption paramFunctionOption, IList<TypeMap> typeMapList, IList<CSTypeMap> csTypeMapList,
		                                IList<EnumData> enumDatas )
		{
			CSTypeMap csTypeMap;
			TypeMap typeMap;
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, paramFunctionOption.ParamType,
			            paramFunctionOption is ArrayParamFunctionOption );
			if (csTypeMap.Attributes.Contains( "enum" ))
			{
				if (enumDatas.FirstOrDefault(data => data.Name == paramFunctionOption.ParamType) != null) 
					return paramFunctionOption.ParamType;
			}
			if (csTypeMap.LanguageName == "void")
			{
				return "void" + new string( '*', typeMap.LanguageName.PointDeep +
				                                 (paramFunctionOption is ArrayParamFunctionOption ? 1 : 0) );
			}

			if (paramFunctionOption is ArrayParamFunctionOption && 
				(paramFunctionOption.ParamType == "charARB" || paramFunctionOption.ParamType == "char") &&
				paramFunctionOption.Direction == "out")
			{
				return "char[]";
			}

			if (paramFunctionOption is ArrayParamFunctionOption && csTypeMap.LanguageName == "string" && paramFunctionOption.ParamType != "charPointerARB")
			{
				return "string";
			}

			return csTypeMap.LanguageName + new string( '*', typeMap.LanguageName.PointDeep > 0 ? typeMap.LanguageName.PointDeep : 0 ) +
			       (paramFunctionOption is ArrayParamFunctionOption ? "[]" : "");
		}

		public static void GetTypeMap( this ReturnFunctionOption returnFunctionOption, 
		                               IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
		                               out TypeMap typeMap )
		{
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, returnFunctionOption.ReturnType, false );
		}

		public static void GetTypeMap( this ParamFunctionOption paramFunctionOption, 
		                               IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
		                               out TypeMap typeMap )
		{
			GetTypeMap( typeMapList, csTypeMapList, out csTypeMap, out typeMap, paramFunctionOption.ParamType, 
			            paramFunctionOption is ArrayParamFunctionOption );
		}

		public static void GetTypeMap( IEnumerable<TypeMap> typeMapList, IEnumerable<CSTypeMap> csTypeMapList, out CSTypeMap csTypeMap, 
		                               out TypeMap typeMap, string type, bool isArray )
		{
			var _typeMap = typeMapList.FirstOrDefault( map => map.GLName == type );
			typeMap = _typeMap;
			if (_typeMap == null) throw new Exception( "Unknow return type: " + type );
			if (_typeMap.LanguageName.Name == "*")
			{
				csTypeMap = null;
				return;
			}
			csTypeMap = csTypeMapList.FirstOrDefault( map1 => map1.GLName == _typeMap.LanguageName.Name );
			if (csTypeMap.LanguageName == "char" && (_typeMap.LanguageName.PointDeep == 1 || isArray))
			{
				csTypeMap = new CSTypeMap { GLName = "GLchar", LanguageName = "string", Attributes = new string[0] };
				if (_typeMap.LanguageName.PointDeep == 1) _typeMap.LanguageName.PointDeep--;
			}
			if (csTypeMap == null) throw new Exception( "Unknow CS type: " + _typeMap.LanguageName.Name );
		}

		public static string GetCSName( this string name )
		{
			return codeDomProvider.CreateEscapedIdentifier( name );
		}
	}
}