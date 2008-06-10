using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_envmap_bumpmapInit()
		{
			_TexBumpParameterivATI = GetProcAdress< TexBumpParameterivATIDelegate >( "glTexBumpParameterivATI" );
			_TexBumpParameterfvATI = GetProcAdress< TexBumpParameterfvATIDelegate >( "glTexBumpParameterfvATI" );
			_GetTexBumpParameterivATI = GetProcAdress< GetTexBumpParameterivATIDelegate >( "glGetTexBumpParameterivATI" );
			_GetTexBumpParameterfvATI = GetProcAdress< GetTexBumpParameterfvATIDelegate >( "glGetTexBumpParameterfvATI" );
			
		}
		
	
		public delegate void TexBumpParameterivATIDelegate( uint pname, int[] param ); //  extension method
		private static TexBumpParameterivATIDelegate _TexBumpParameterivATI;
		
		public static  void TexBumpParameterivATI( uint pname, int[] param )
		{
			if (_TexBumpParameterivATI == null) throw new Exception( "Extension method TexBumpParameterivATI not found" );
			 _TexBumpParameterivATI( pname, param );
		}
		public delegate void TexBumpParameterfvATIDelegate( uint pname, float[] param ); //  extension method
		private static TexBumpParameterfvATIDelegate _TexBumpParameterfvATI;
		
		public static  void TexBumpParameterfvATI( uint pname, float[] param )
		{
			if (_TexBumpParameterfvATI == null) throw new Exception( "Extension method TexBumpParameterfvATI not found" );
			 _TexBumpParameterfvATI( pname, param );
		}
		public delegate void GetTexBumpParameterivATIDelegate( uint pname, [Out]int[] param ); //  extension method
		private static GetTexBumpParameterivATIDelegate _GetTexBumpParameterivATI;
		
		public static  void GetTexBumpParameterivATI( uint pname, [Out]int[] param )
		{
			if (_GetTexBumpParameterivATI == null) throw new Exception( "Extension method GetTexBumpParameterivATI not found" );
			 _GetTexBumpParameterivATI( pname, param );
		}
		public delegate void GetTexBumpParameterfvATIDelegate( uint pname, [Out]float[] param ); //  extension method
		private static GetTexBumpParameterfvATIDelegate _GetTexBumpParameterfvATI;
		
		public static  void GetTexBumpParameterfvATI( uint pname, [Out]float[] param )
		{
			if (_GetTexBumpParameterfvATI == null) throw new Exception( "Extension method GetTexBumpParameterfvATI not found" );
			 _GetTexBumpParameterfvATI( pname, param );
		}
	}
}

