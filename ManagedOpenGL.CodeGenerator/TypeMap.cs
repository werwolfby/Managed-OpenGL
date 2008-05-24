/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.05.2008 15:21
 *
 * File: TypeMap.cs
 * Remarks:
 * 
 * History:
 *   24.05.2008 15:21 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Diagnostics;

namespace ManagedOpenGL.CodeGenerator2
{
	[DebuggerDisplay("{GLName,nq},{GLParam1,nq},{GLParam2,nq} -> {LanguageName,nq},{LanguageParam1,nq},{LanguageParam2,nq}")]
	public class TypeMap
	{
		public string GLName;
		public string LanguageName;
		public string GLParam1;
		public string GLParam2;
		public string LanguageParam1;
		public string LanguageParam2;

		public static TypeMap Parse( string line )
		{
			return Parse( line, -1 );
		}

		public static TypeMap Parse( string line, int lineNumber )
		{
			var typeMapItems = line.Split( new[] { ',' } );

			if (typeMapItems.Length != 6) throw new Exception( "Can't parse string: `" + line + "`. At line " + lineNumber );

			return new TypeMap
			       {
			       	GLName = typeMapItems[0].Trim(),
			       	GLParam1 = typeMapItems[1].Trim(),
			       	GLParam2 = typeMapItems[2].Trim(),
			       	LanguageName = typeMapItems[3].Trim(),
			       	LanguageParam1 = typeMapItems[4].Trim(),
			       	LanguageParam2 = typeMapItems[5].Trim(),
			       };
		}
	}
}