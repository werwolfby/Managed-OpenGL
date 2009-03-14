using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_matrix_paletteInit()
		{
			_CurrentPaletteMatrixARB = GetProcAdress< CurrentPaletteMatrixARBDelegate >( "glCurrentPaletteMatrixARB" );
			_MatrixIndexubvARB = GetProcAdress< MatrixIndexubvARBDelegate >( "glMatrixIndexubvARB" );
			_MatrixIndexusvARB = GetProcAdress< MatrixIndexusvARBDelegate >( "glMatrixIndexusvARB" );
			_MatrixIndexuivARB = GetProcAdress< MatrixIndexuivARBDelegate >( "glMatrixIndexuivARB" );
			_MatrixIndexPointerARB = GetProcAdress< MatrixIndexPointerARBDelegate >( "glMatrixIndexPointerARB" );
		}


		public delegate void CurrentPaletteMatrixARBDelegate( int index ); //  extension method

		private static CurrentPaletteMatrixARBDelegate _CurrentPaletteMatrixARB;

		public static  void CurrentPaletteMatrixARB( int index )
		{
			if (_CurrentPaletteMatrixARB == null) throw new Exception( "Extension method CurrentPaletteMatrixARB not found" );
		 _CurrentPaletteMatrixARB( index );
		}
		public delegate void MatrixIndexubvARBDelegate( int size, byte[] indices ); //  extension method

		private static MatrixIndexubvARBDelegate _MatrixIndexubvARB;

		public static  void MatrixIndexubvARB( int size, byte[] indices )
		{
			if (_MatrixIndexubvARB == null) throw new Exception( "Extension method MatrixIndexubvARB not found" );
		 _MatrixIndexubvARB( size, indices );
		}
		public delegate void MatrixIndexusvARBDelegate( int size, ushort[] indices ); //  extension method

		private static MatrixIndexusvARBDelegate _MatrixIndexusvARB;

		public static  void MatrixIndexusvARB( int size, ushort[] indices )
		{
			if (_MatrixIndexusvARB == null) throw new Exception( "Extension method MatrixIndexusvARB not found" );
		 _MatrixIndexusvARB( size, indices );
		}
		public delegate void MatrixIndexuivARBDelegate( int size, uint[] indices ); //  extension method

		private static MatrixIndexuivARBDelegate _MatrixIndexuivARB;

		public static  void MatrixIndexuivARB( int size, uint[] indices )
		{
			if (_MatrixIndexuivARB == null) throw new Exception( "Extension method MatrixIndexuivARB not found" );
		 _MatrixIndexuivARB( size, indices );
		}
		public unsafe delegate void MatrixIndexPointerARBDelegate( int size, uint type, int stride, void* pointer ); //  extension method

		private static MatrixIndexPointerARBDelegate _MatrixIndexPointerARB;

		public static unsafe  void MatrixIndexPointerARB( int size, uint type, int stride, void* pointer )
		{
			if (_MatrixIndexPointerARB == null) throw new Exception( "Extension method MatrixIndexPointerARB not found" );
		 _MatrixIndexPointerARB( size, type, stride, pointer );
		}
	}
}
