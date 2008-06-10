using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_texture_objectInit()
		{
			_AreTexturesResidentEXT = GetProcAdress< AreTexturesResidentEXTDelegate >( "glAreTexturesResidentEXT" );
			_BindTextureEXT = GetProcAdress< BindTextureEXTDelegate >( "glBindTextureEXT" );
			_DeleteTexturesEXT = GetProcAdress< DeleteTexturesEXTDelegate >( "glDeleteTexturesEXT" );
			_GenTexturesEXT = GetProcAdress< GenTexturesEXTDelegate >( "glGenTexturesEXT" );
			_IsTextureEXT = GetProcAdress< IsTextureEXTDelegate >( "glIsTextureEXT" );
			_PrioritizeTexturesEXT = GetProcAdress< PrioritizeTexturesEXTDelegate >( "glPrioritizeTexturesEXT" );
			
		}
		
	
		public delegate bool AreTexturesResidentEXTDelegate( int n, uint[] textures, [Out]bool[] residences ); //  extension method
		private static AreTexturesResidentEXTDelegate _AreTexturesResidentEXT;
		
		public static  bool AreTexturesResidentEXT( int n, uint[] textures, [Out]bool[] residences )
		{
			if (_AreTexturesResidentEXT == null) throw new Exception( "Extension method AreTexturesResidentEXT not found" );
			return  _AreTexturesResidentEXT( n, textures, residences );
		}
		public delegate void BindTextureEXTDelegate( TextureTarget target, uint texture ); //  extension method
		private static BindTextureEXTDelegate _BindTextureEXT;
		
		public static  void BindTextureEXT( TextureTarget target, uint texture )
		{
			if (_BindTextureEXT == null) throw new Exception( "Extension method BindTextureEXT not found" );
			 _BindTextureEXT( target, texture );
		}
		public delegate void DeleteTexturesEXTDelegate( int n, uint[] textures ); //  extension method
		private static DeleteTexturesEXTDelegate _DeleteTexturesEXT;
		
		public static  void DeleteTexturesEXT( int n, uint[] textures )
		{
			if (_DeleteTexturesEXT == null) throw new Exception( "Extension method DeleteTexturesEXT not found" );
			 _DeleteTexturesEXT( n, textures );
		}
		public delegate void GenTexturesEXTDelegate( int n, [Out]uint[] textures ); //  extension method
		private static GenTexturesEXTDelegate _GenTexturesEXT;
		
		public static  void GenTexturesEXT( int n, [Out]uint[] textures )
		{
			if (_GenTexturesEXT == null) throw new Exception( "Extension method GenTexturesEXT not found" );
			 _GenTexturesEXT( n, textures );
		}
		public delegate bool IsTextureEXTDelegate( uint texture ); //  extension method
		private static IsTextureEXTDelegate _IsTextureEXT;
		
		public static  bool IsTextureEXT( uint texture )
		{
			if (_IsTextureEXT == null) throw new Exception( "Extension method IsTextureEXT not found" );
			return  _IsTextureEXT( texture );
		}
		public delegate void PrioritizeTexturesEXTDelegate( int n, uint[] textures, float[] priorities ); //  extension method
		private static PrioritizeTexturesEXTDelegate _PrioritizeTexturesEXT;
		
		public static  void PrioritizeTexturesEXT( int n, uint[] textures, float[] priorities )
		{
			if (_PrioritizeTexturesEXT == null) throw new Exception( "Extension method PrioritizeTexturesEXT not found" );
			 _PrioritizeTexturesEXT( n, textures, priorities );
		}
	}
}

