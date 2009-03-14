using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_primitive_restartInit()
		{
			_PrimitiveRestartNV = GetProcAdress< PrimitiveRestartNVDelegate >( "glPrimitiveRestartNV" );
			_PrimitiveRestartIndexNV = GetProcAdress< PrimitiveRestartIndexNVDelegate >( "glPrimitiveRestartIndexNV" );
		}


		public delegate void PrimitiveRestartNVDelegate(  ); //  extension method

		private static PrimitiveRestartNVDelegate _PrimitiveRestartNV;

		public static  void PrimitiveRestartNV(  )
		{
			if (_PrimitiveRestartNV == null) throw new Exception( "Extension method PrimitiveRestartNV not found" );
		 _PrimitiveRestartNV(  );
		}
		public delegate void PrimitiveRestartIndexNVDelegate( uint index ); //  extension method

		private static PrimitiveRestartIndexNVDelegate _PrimitiveRestartIndexNV;

		public static  void PrimitiveRestartIndexNV( uint index )
		{
			if (_PrimitiveRestartIndexNV == null) throw new Exception( "Extension method PrimitiveRestartIndexNV not found" );
		 _PrimitiveRestartIndexNV( index );
		}
	}
}
