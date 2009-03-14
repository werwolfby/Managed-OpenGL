using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_spriteInit()
		{
			_SpriteParameterfSGIX = GetProcAdress< SpriteParameterfSGIXDelegate >( "glSpriteParameterfSGIX" );
			_SpriteParameterfvSGIX = GetProcAdress< SpriteParameterfvSGIXDelegate >( "glSpriteParameterfvSGIX" );
			_SpriteParameteriSGIX = GetProcAdress< SpriteParameteriSGIXDelegate >( "glSpriteParameteriSGIX" );
			_SpriteParameterivSGIX = GetProcAdress< SpriteParameterivSGIXDelegate >( "glSpriteParameterivSGIX" );
		}


		public delegate void SpriteParameterfSGIXDelegate( uint pname, float param ); //  extension method

		private static SpriteParameterfSGIXDelegate _SpriteParameterfSGIX;

		public static  void SpriteParameterfSGIX( uint pname, float param )
		{
			if (_SpriteParameterfSGIX == null) throw new Exception( "Extension method SpriteParameterfSGIX not found" );
		 _SpriteParameterfSGIX( pname, param );
		}
		public delegate void SpriteParameterfvSGIXDelegate( uint pname, float[] @params ); //  extension method

		private static SpriteParameterfvSGIXDelegate _SpriteParameterfvSGIX;

		public static  void SpriteParameterfvSGIX( uint pname, float[] @params )
		{
			if (_SpriteParameterfvSGIX == null) throw new Exception( "Extension method SpriteParameterfvSGIX not found" );
		 _SpriteParameterfvSGIX( pname, @params );
		}
		public delegate void SpriteParameteriSGIXDelegate( uint pname, int param ); //  extension method

		private static SpriteParameteriSGIXDelegate _SpriteParameteriSGIX;

		public static  void SpriteParameteriSGIX( uint pname, int param )
		{
			if (_SpriteParameteriSGIX == null) throw new Exception( "Extension method SpriteParameteriSGIX not found" );
		 _SpriteParameteriSGIX( pname, param );
		}
		public delegate void SpriteParameterivSGIXDelegate( uint pname, int[] @params ); //  extension method

		private static SpriteParameterivSGIXDelegate _SpriteParameterivSGIX;

		public static  void SpriteParameterivSGIX( uint pname, int[] @params )
		{
			if (_SpriteParameterivSGIX == null) throw new Exception( "Extension method SpriteParameterivSGIX not found" );
		 _SpriteParameterivSGIX( pname, @params );
		}
	}
}
