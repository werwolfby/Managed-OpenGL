using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_framebuffer_objectInit()
		{
			_IsRenderbufferEXT = GetProcAdress< IsRenderbufferEXTDelegate >( "glIsRenderbufferEXT" );
			_BindRenderbufferEXT = GetProcAdress< BindRenderbufferEXTDelegate >( "glBindRenderbufferEXT" );
			_DeleteRenderbuffersEXT = GetProcAdress< DeleteRenderbuffersEXTDelegate >( "glDeleteRenderbuffersEXT" );
			_GenRenderbuffersEXT = GetProcAdress< GenRenderbuffersEXTDelegate >( "glGenRenderbuffersEXT" );
			_RenderbufferStorageEXT = GetProcAdress< RenderbufferStorageEXTDelegate >( "glRenderbufferStorageEXT" );
			_GetRenderbufferParameterivEXT = GetProcAdress< GetRenderbufferParameterivEXTDelegate >( "glGetRenderbufferParameterivEXT" );
			_IsFramebufferEXT = GetProcAdress< IsFramebufferEXTDelegate >( "glIsFramebufferEXT" );
			_BindFramebufferEXT = GetProcAdress< BindFramebufferEXTDelegate >( "glBindFramebufferEXT" );
			_DeleteFramebuffersEXT = GetProcAdress< DeleteFramebuffersEXTDelegate >( "glDeleteFramebuffersEXT" );
			_GenFramebuffersEXT = GetProcAdress< GenFramebuffersEXTDelegate >( "glGenFramebuffersEXT" );
			_CheckFramebufferStatusEXT = GetProcAdress< CheckFramebufferStatusEXTDelegate >( "glCheckFramebufferStatusEXT" );
			_FramebufferTexture1DEXT = GetProcAdress< FramebufferTexture1DEXTDelegate >( "glFramebufferTexture1DEXT" );
			_FramebufferTexture2DEXT = GetProcAdress< FramebufferTexture2DEXTDelegate >( "glFramebufferTexture2DEXT" );
			_FramebufferTexture3DEXT = GetProcAdress< FramebufferTexture3DEXTDelegate >( "glFramebufferTexture3DEXT" );
			_FramebufferRenderbufferEXT = GetProcAdress< FramebufferRenderbufferEXTDelegate >( "glFramebufferRenderbufferEXT" );
			_GetFramebufferAttachmentParameterivEXT = GetProcAdress< GetFramebufferAttachmentParameterivEXTDelegate >( "glGetFramebufferAttachmentParameterivEXT" );
			_GenerateMipmapEXT = GetProcAdress< GenerateMipmapEXTDelegate >( "glGenerateMipmapEXT" );
		}


		public delegate bool IsRenderbufferEXTDelegate( uint renderbuffer ); //  extension method

		private static IsRenderbufferEXTDelegate _IsRenderbufferEXT;

		public static  bool IsRenderbufferEXT( uint renderbuffer )
		{
			if (_IsRenderbufferEXT == null) throw new Exception( "Extension method IsRenderbufferEXT not found" );
		return  _IsRenderbufferEXT( renderbuffer );
		}
		public delegate void BindRenderbufferEXTDelegate( uint target, uint renderbuffer ); //  extension method

		private static BindRenderbufferEXTDelegate _BindRenderbufferEXT;

		public static  void BindRenderbufferEXT( uint target, uint renderbuffer )
		{
			if (_BindRenderbufferEXT == null) throw new Exception( "Extension method BindRenderbufferEXT not found" );
		 _BindRenderbufferEXT( target, renderbuffer );
		}
		public delegate void DeleteRenderbuffersEXTDelegate( int n, uint[] renderbuffers ); //  extension method

		private static DeleteRenderbuffersEXTDelegate _DeleteRenderbuffersEXT;

		public static  void DeleteRenderbuffersEXT( int n, uint[] renderbuffers )
		{
			if (_DeleteRenderbuffersEXT == null) throw new Exception( "Extension method DeleteRenderbuffersEXT not found" );
		 _DeleteRenderbuffersEXT( n, renderbuffers );
		}
		public delegate void GenRenderbuffersEXTDelegate( int n, [Out]uint[] renderbuffers ); //  extension method

		private static GenRenderbuffersEXTDelegate _GenRenderbuffersEXT;

		public static  void GenRenderbuffersEXT( int n, [Out]uint[] renderbuffers )
		{
			if (_GenRenderbuffersEXT == null) throw new Exception( "Extension method GenRenderbuffersEXT not found" );
		 _GenRenderbuffersEXT( n, renderbuffers );
		}
		public delegate void RenderbufferStorageEXTDelegate( uint target, uint internalformat, int width, int height ); //  extension method

		private static RenderbufferStorageEXTDelegate _RenderbufferStorageEXT;

		public static  void RenderbufferStorageEXT( uint target, uint internalformat, int width, int height )
		{
			if (_RenderbufferStorageEXT == null) throw new Exception( "Extension method RenderbufferStorageEXT not found" );
		 _RenderbufferStorageEXT( target, internalformat, width, height );
		}
		public delegate void GetRenderbufferParameterivEXTDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetRenderbufferParameterivEXTDelegate _GetRenderbufferParameterivEXT;

		public static  void GetRenderbufferParameterivEXT( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetRenderbufferParameterivEXT == null) throw new Exception( "Extension method GetRenderbufferParameterivEXT not found" );
		 _GetRenderbufferParameterivEXT( target, pname, @params );
		}
		public delegate bool IsFramebufferEXTDelegate( uint framebuffer ); //  extension method

		private static IsFramebufferEXTDelegate _IsFramebufferEXT;

		public static  bool IsFramebufferEXT( uint framebuffer )
		{
			if (_IsFramebufferEXT == null) throw new Exception( "Extension method IsFramebufferEXT not found" );
		return  _IsFramebufferEXT( framebuffer );
		}
		public delegate void BindFramebufferEXTDelegate( uint target, uint framebuffer ); //  extension method

		private static BindFramebufferEXTDelegate _BindFramebufferEXT;

		public static  void BindFramebufferEXT( uint target, uint framebuffer )
		{
			if (_BindFramebufferEXT == null) throw new Exception( "Extension method BindFramebufferEXT not found" );
		 _BindFramebufferEXT( target, framebuffer );
		}
		public delegate void DeleteFramebuffersEXTDelegate( int n, uint[] framebuffers ); //  extension method

		private static DeleteFramebuffersEXTDelegate _DeleteFramebuffersEXT;

		public static  void DeleteFramebuffersEXT( int n, uint[] framebuffers )
		{
			if (_DeleteFramebuffersEXT == null) throw new Exception( "Extension method DeleteFramebuffersEXT not found" );
		 _DeleteFramebuffersEXT( n, framebuffers );
		}
		public delegate void GenFramebuffersEXTDelegate( int n, [Out]uint[] framebuffers ); //  extension method

		private static GenFramebuffersEXTDelegate _GenFramebuffersEXT;

		public static  void GenFramebuffersEXT( int n, [Out]uint[] framebuffers )
		{
			if (_GenFramebuffersEXT == null) throw new Exception( "Extension method GenFramebuffersEXT not found" );
		 _GenFramebuffersEXT( n, framebuffers );
		}
		public delegate uint CheckFramebufferStatusEXTDelegate( uint target ); //  extension method

		private static CheckFramebufferStatusEXTDelegate _CheckFramebufferStatusEXT;

		public static  uint CheckFramebufferStatusEXT( uint target )
		{
			if (_CheckFramebufferStatusEXT == null) throw new Exception( "Extension method CheckFramebufferStatusEXT not found" );
		return  _CheckFramebufferStatusEXT( target );
		}
		public delegate void FramebufferTexture1DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method

		private static FramebufferTexture1DEXTDelegate _FramebufferTexture1DEXT;

		public static  void FramebufferTexture1DEXT( uint target, uint attachment, uint textarget, uint texture, int level )
		{
			if (_FramebufferTexture1DEXT == null) throw new Exception( "Extension method FramebufferTexture1DEXT not found" );
		 _FramebufferTexture1DEXT( target, attachment, textarget, texture, level );
		}
		public delegate void FramebufferTexture2DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level ); //  extension method

		private static FramebufferTexture2DEXTDelegate _FramebufferTexture2DEXT;

		public static  void FramebufferTexture2DEXT( uint target, uint attachment, uint textarget, uint texture, int level )
		{
			if (_FramebufferTexture2DEXT == null) throw new Exception( "Extension method FramebufferTexture2DEXT not found" );
		 _FramebufferTexture2DEXT( target, attachment, textarget, texture, level );
		}
		public delegate void FramebufferTexture3DEXTDelegate( uint target, uint attachment, uint textarget, uint texture, int level, int zoffset ); //  extension method

		private static FramebufferTexture3DEXTDelegate _FramebufferTexture3DEXT;

		public static  void FramebufferTexture3DEXT( uint target, uint attachment, uint textarget, uint texture, int level, int zoffset )
		{
			if (_FramebufferTexture3DEXT == null) throw new Exception( "Extension method FramebufferTexture3DEXT not found" );
		 _FramebufferTexture3DEXT( target, attachment, textarget, texture, level, zoffset );
		}
		public delegate void FramebufferRenderbufferEXTDelegate( uint target, uint attachment, uint renderbuffertarget, uint renderbuffer ); //  extension method

		private static FramebufferRenderbufferEXTDelegate _FramebufferRenderbufferEXT;

		public static  void FramebufferRenderbufferEXT( uint target, uint attachment, uint renderbuffertarget, uint renderbuffer )
		{
			if (_FramebufferRenderbufferEXT == null) throw new Exception( "Extension method FramebufferRenderbufferEXT not found" );
		 _FramebufferRenderbufferEXT( target, attachment, renderbuffertarget, renderbuffer );
		}
		public delegate void GetFramebufferAttachmentParameterivEXTDelegate( uint target, uint attachment, uint pname, [Out]int[] @params ); //  extension method

		private static GetFramebufferAttachmentParameterivEXTDelegate _GetFramebufferAttachmentParameterivEXT;

		public static  void GetFramebufferAttachmentParameterivEXT( uint target, uint attachment, uint pname, [Out]int[] @params )
		{
			if (_GetFramebufferAttachmentParameterivEXT == null) throw new Exception( "Extension method GetFramebufferAttachmentParameterivEXT not found" );
		 _GetFramebufferAttachmentParameterivEXT( target, attachment, pname, @params );
		}
		public delegate void GenerateMipmapEXTDelegate( uint target ); //  extension method

		private static GenerateMipmapEXTDelegate _GenerateMipmapEXT;

		public static  void GenerateMipmapEXT( uint target )
		{
			if (_GenerateMipmapEXT == null) throw new Exception( "Extension method GenerateMipmapEXT not found" );
		 _GenerateMipmapEXT( target );
		}
	}
}
