using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_transpose_matrixInit()
		{
			_LoadTransposeMatrixfARB = GetProcAdress< LoadTransposeMatrixfARBDelegate >( "glLoadTransposeMatrixfARB" );
			_LoadTransposeMatrixdARB = GetProcAdress< LoadTransposeMatrixdARBDelegate >( "glLoadTransposeMatrixdARB" );
			_MultTransposeMatrixfARB = GetProcAdress< MultTransposeMatrixfARBDelegate >( "glMultTransposeMatrixfARB" );
			_MultTransposeMatrixdARB = GetProcAdress< MultTransposeMatrixdARBDelegate >( "glMultTransposeMatrixdARB" );
		}


		public delegate void LoadTransposeMatrixfARBDelegate( float[] m ); // 

		private static LoadTransposeMatrixfARBDelegate _LoadTransposeMatrixfARB;

		public static  void LoadTransposeMatrixfARB( float[] m )
		{
			if (_LoadTransposeMatrixfARB == null) throw new Exception( "Extension method LoadTransposeMatrixfARB not found" );
		 _LoadTransposeMatrixfARB( m );
		}
		public delegate void LoadTransposeMatrixdARBDelegate( double[] m ); // 

		private static LoadTransposeMatrixdARBDelegate _LoadTransposeMatrixdARB;

		public static  void LoadTransposeMatrixdARB( double[] m )
		{
			if (_LoadTransposeMatrixdARB == null) throw new Exception( "Extension method LoadTransposeMatrixdARB not found" );
		 _LoadTransposeMatrixdARB( m );
		}
		public delegate void MultTransposeMatrixfARBDelegate( float[] m ); // 

		private static MultTransposeMatrixfARBDelegate _MultTransposeMatrixfARB;

		public static  void MultTransposeMatrixfARB( float[] m )
		{
			if (_MultTransposeMatrixfARB == null) throw new Exception( "Extension method MultTransposeMatrixfARB not found" );
		 _MultTransposeMatrixfARB( m );
		}
		public delegate void MultTransposeMatrixdARBDelegate( double[] m ); // 

		private static MultTransposeMatrixdARBDelegate _MultTransposeMatrixdARB;

		public static  void MultTransposeMatrixdARB( double[] m )
		{
			if (_MultTransposeMatrixdARB == null) throw new Exception( "Extension method MultTransposeMatrixdARB not found" );
		 _MultTransposeMatrixdARB( m );
		}
	}
}
