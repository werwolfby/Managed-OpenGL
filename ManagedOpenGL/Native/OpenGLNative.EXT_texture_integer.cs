using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_texture_integerInit()
		{
			_TexParameterIivEXT = GetProcAdress< TexParameterIivEXTDelegate >( "glTexParameterIivEXT" );
			_TexParameterIuivEXT = GetProcAdress< TexParameterIuivEXTDelegate >( "glTexParameterIuivEXT" );
			_GetTexParameterIivEXT = GetProcAdress< GetTexParameterIivEXTDelegate >( "glGetTexParameterIivEXT" );
			_GetTexParameterIuivEXT = GetProcAdress< GetTexParameterIuivEXTDelegate >( "glGetTexParameterIuivEXT" );
			_ClearColorIiEXT = GetProcAdress< ClearColorIiEXTDelegate >( "glClearColorIiEXT" );
			_ClearColorIuiEXT = GetProcAdress< ClearColorIuiEXTDelegate >( "glClearColorIuiEXT" );
			
		}
		
	
		public delegate void TexParameterIivEXTDelegate( TextureTarget target, TextureParameterName pname, int[] @params ); //  extension method
		private static TexParameterIivEXTDelegate _TexParameterIivEXT;
		
		public static  void TexParameterIivEXT( TextureTarget target, TextureParameterName pname, int[] @params )
		{
			if (_TexParameterIivEXT == null) throw new Exception( "Extension method TexParameterIivEXT not found" );
			 _TexParameterIivEXT( target, pname, @params );
		}
		public delegate void TexParameterIuivEXTDelegate( TextureTarget target, TextureParameterName pname, uint[] @params ); //  extension method
		private static TexParameterIuivEXTDelegate _TexParameterIuivEXT;
		
		public static  void TexParameterIuivEXT( TextureTarget target, TextureParameterName pname, uint[] @params )
		{
			if (_TexParameterIuivEXT == null) throw new Exception( "Extension method TexParameterIuivEXT not found" );
			 _TexParameterIuivEXT( target, pname, @params );
		}
		public delegate void GetTexParameterIivEXTDelegate( TextureTarget target, GetTextureParameter pname, [Out]int[] @params ); //  extension method
		private static GetTexParameterIivEXTDelegate _GetTexParameterIivEXT;
		
		public static  void GetTexParameterIivEXT( TextureTarget target, GetTextureParameter pname, [Out]int[] @params )
		{
			if (_GetTexParameterIivEXT == null) throw new Exception( "Extension method GetTexParameterIivEXT not found" );
			 _GetTexParameterIivEXT( target, pname, @params );
		}
		public delegate void GetTexParameterIuivEXTDelegate( TextureTarget target, GetTextureParameter pname, [Out]uint[] @params ); //  extension method
		private static GetTexParameterIuivEXTDelegate _GetTexParameterIuivEXT;
		
		public static  void GetTexParameterIuivEXT( TextureTarget target, GetTextureParameter pname, [Out]uint[] @params )
		{
			if (_GetTexParameterIuivEXT == null) throw new Exception( "Extension method GetTexParameterIuivEXT not found" );
			 _GetTexParameterIuivEXT( target, pname, @params );
		}
		public delegate void ClearColorIiEXTDelegate( int red, int green, int blue, int alpha ); //  extension method
		private static ClearColorIiEXTDelegate _ClearColorIiEXT;
		
		public static  void ClearColorIiEXT( int red, int green, int blue, int alpha )
		{
			if (_ClearColorIiEXT == null) throw new Exception( "Extension method ClearColorIiEXT not found" );
			 _ClearColorIiEXT( red, green, blue, alpha );
		}
		public delegate void ClearColorIuiEXTDelegate( uint red, uint green, uint blue, uint alpha ); //  extension method
		private static ClearColorIuiEXTDelegate _ClearColorIuiEXT;
		
		public static  void ClearColorIuiEXT( uint red, uint green, uint blue, uint alpha )
		{
			if (_ClearColorIuiEXT == null) throw new Exception( "Extension method ClearColorIuiEXT not found" );
			 _ClearColorIuiEXT( red, green, blue, alpha );
		}
	}
}

