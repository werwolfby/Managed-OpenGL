/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 19:17
 *
 * File: EnumGeneratorExt.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 19:17 - Create Wireframe
 *
 *******************************************************/

using System;
using ManagedOpenGL.CodeGenerator.Rules;

public partial class EnumGenerator
{
	public static string GetCSName( string name )
	{
		if (!char.IsDigit( name[0] )) return name;
		return "Gl" + name;
	}

	public static string ConvertName( string name )
	{
		var defineParts = name.Split( '_' );

		defineParts = Array.ConvertAll( defineParts, s => s.FirstSymbolToUpper() );

		var newDefine = string.Join( "", defineParts );
		if (Char.IsDigit( newDefine[0] )) newDefine = "gl" + newDefine;
		return newDefine;
	}
}
