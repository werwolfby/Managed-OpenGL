using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_multitextureInit()
		{
			_ActiveTextureARB = GetProcAdress< ActiveTextureARBDelegate >( "glActiveTextureARB" );
			_ClientActiveTextureARB = GetProcAdress< ClientActiveTextureARBDelegate >( "glClientActiveTextureARB" );
			_MultiTexCoord1dARB = GetProcAdress< MultiTexCoord1dARBDelegate >( "glMultiTexCoord1dARB" );
			_MultiTexCoord1dvARB = GetProcAdress< MultiTexCoord1dvARBDelegate >( "glMultiTexCoord1dvARB" );
			_MultiTexCoord1fARB = GetProcAdress< MultiTexCoord1fARBDelegate >( "glMultiTexCoord1fARB" );
			_MultiTexCoord1fvARB = GetProcAdress< MultiTexCoord1fvARBDelegate >( "glMultiTexCoord1fvARB" );
			_MultiTexCoord1iARB = GetProcAdress< MultiTexCoord1iARBDelegate >( "glMultiTexCoord1iARB" );
			_MultiTexCoord1ivARB = GetProcAdress< MultiTexCoord1ivARBDelegate >( "glMultiTexCoord1ivARB" );
			_MultiTexCoord1sARB = GetProcAdress< MultiTexCoord1sARBDelegate >( "glMultiTexCoord1sARB" );
			_MultiTexCoord1svARB = GetProcAdress< MultiTexCoord1svARBDelegate >( "glMultiTexCoord1svARB" );
			_MultiTexCoord2dARB = GetProcAdress< MultiTexCoord2dARBDelegate >( "glMultiTexCoord2dARB" );
			_MultiTexCoord2dvARB = GetProcAdress< MultiTexCoord2dvARBDelegate >( "glMultiTexCoord2dvARB" );
			_MultiTexCoord2fARB = GetProcAdress< MultiTexCoord2fARBDelegate >( "glMultiTexCoord2fARB" );
			_MultiTexCoord2fvARB = GetProcAdress< MultiTexCoord2fvARBDelegate >( "glMultiTexCoord2fvARB" );
			_MultiTexCoord2iARB = GetProcAdress< MultiTexCoord2iARBDelegate >( "glMultiTexCoord2iARB" );
			_MultiTexCoord2ivARB = GetProcAdress< MultiTexCoord2ivARBDelegate >( "glMultiTexCoord2ivARB" );
			_MultiTexCoord2sARB = GetProcAdress< MultiTexCoord2sARBDelegate >( "glMultiTexCoord2sARB" );
			_MultiTexCoord2svARB = GetProcAdress< MultiTexCoord2svARBDelegate >( "glMultiTexCoord2svARB" );
			_MultiTexCoord3dARB = GetProcAdress< MultiTexCoord3dARBDelegate >( "glMultiTexCoord3dARB" );
			_MultiTexCoord3dvARB = GetProcAdress< MultiTexCoord3dvARBDelegate >( "glMultiTexCoord3dvARB" );
			_MultiTexCoord3fARB = GetProcAdress< MultiTexCoord3fARBDelegate >( "glMultiTexCoord3fARB" );
			_MultiTexCoord3fvARB = GetProcAdress< MultiTexCoord3fvARBDelegate >( "glMultiTexCoord3fvARB" );
			_MultiTexCoord3iARB = GetProcAdress< MultiTexCoord3iARBDelegate >( "glMultiTexCoord3iARB" );
			_MultiTexCoord3ivARB = GetProcAdress< MultiTexCoord3ivARBDelegate >( "glMultiTexCoord3ivARB" );
			_MultiTexCoord3sARB = GetProcAdress< MultiTexCoord3sARBDelegate >( "glMultiTexCoord3sARB" );
			_MultiTexCoord3svARB = GetProcAdress< MultiTexCoord3svARBDelegate >( "glMultiTexCoord3svARB" );
			_MultiTexCoord4dARB = GetProcAdress< MultiTexCoord4dARBDelegate >( "glMultiTexCoord4dARB" );
			_MultiTexCoord4dvARB = GetProcAdress< MultiTexCoord4dvARBDelegate >( "glMultiTexCoord4dvARB" );
			_MultiTexCoord4fARB = GetProcAdress< MultiTexCoord4fARBDelegate >( "glMultiTexCoord4fARB" );
			_MultiTexCoord4fvARB = GetProcAdress< MultiTexCoord4fvARBDelegate >( "glMultiTexCoord4fvARB" );
			_MultiTexCoord4iARB = GetProcAdress< MultiTexCoord4iARBDelegate >( "glMultiTexCoord4iARB" );
			_MultiTexCoord4ivARB = GetProcAdress< MultiTexCoord4ivARBDelegate >( "glMultiTexCoord4ivARB" );
			_MultiTexCoord4sARB = GetProcAdress< MultiTexCoord4sARBDelegate >( "glMultiTexCoord4sARB" );
			_MultiTexCoord4svARB = GetProcAdress< MultiTexCoord4svARBDelegate >( "glMultiTexCoord4svARB" );
		}


		public delegate void ActiveTextureARBDelegate( uint texture ); // 

		private static ActiveTextureARBDelegate _ActiveTextureARB;

		public static  void ActiveTextureARB( uint texture )
		{
			if (_ActiveTextureARB == null) throw new Exception( "Extension method ActiveTextureARB not found" );
		 _ActiveTextureARB( texture );
		}
		public delegate void ClientActiveTextureARBDelegate( uint texture ); // 

		private static ClientActiveTextureARBDelegate _ClientActiveTextureARB;

		public static  void ClientActiveTextureARB( uint texture )
		{
			if (_ClientActiveTextureARB == null) throw new Exception( "Extension method ClientActiveTextureARB not found" );
		 _ClientActiveTextureARB( texture );
		}
		public delegate void MultiTexCoord1dARBDelegate( uint target, double s ); // 

		private static MultiTexCoord1dARBDelegate _MultiTexCoord1dARB;

		public static  void MultiTexCoord1dARB( uint target, double s )
		{
			if (_MultiTexCoord1dARB == null) throw new Exception( "Extension method MultiTexCoord1dARB not found" );
		 _MultiTexCoord1dARB( target, s );
		}
		public delegate void MultiTexCoord1dvARBDelegate( uint target, double[] v ); // 

		private static MultiTexCoord1dvARBDelegate _MultiTexCoord1dvARB;

		public static  void MultiTexCoord1dvARB( uint target, double[] v )
		{
			if (_MultiTexCoord1dvARB == null) throw new Exception( "Extension method MultiTexCoord1dvARB not found" );
		 _MultiTexCoord1dvARB( target, v );
		}
		public delegate void MultiTexCoord1fARBDelegate( uint target, float s ); // 

		private static MultiTexCoord1fARBDelegate _MultiTexCoord1fARB;

		public static  void MultiTexCoord1fARB( uint target, float s )
		{
			if (_MultiTexCoord1fARB == null) throw new Exception( "Extension method MultiTexCoord1fARB not found" );
		 _MultiTexCoord1fARB( target, s );
		}
		public delegate void MultiTexCoord1fvARBDelegate( uint target, float[] v ); // 

		private static MultiTexCoord1fvARBDelegate _MultiTexCoord1fvARB;

		public static  void MultiTexCoord1fvARB( uint target, float[] v )
		{
			if (_MultiTexCoord1fvARB == null) throw new Exception( "Extension method MultiTexCoord1fvARB not found" );
		 _MultiTexCoord1fvARB( target, v );
		}
		public delegate void MultiTexCoord1iARBDelegate( uint target, int s ); // 

		private static MultiTexCoord1iARBDelegate _MultiTexCoord1iARB;

		public static  void MultiTexCoord1iARB( uint target, int s )
		{
			if (_MultiTexCoord1iARB == null) throw new Exception( "Extension method MultiTexCoord1iARB not found" );
		 _MultiTexCoord1iARB( target, s );
		}
		public delegate void MultiTexCoord1ivARBDelegate( uint target, int[] v ); // 

		private static MultiTexCoord1ivARBDelegate _MultiTexCoord1ivARB;

		public static  void MultiTexCoord1ivARB( uint target, int[] v )
		{
			if (_MultiTexCoord1ivARB == null) throw new Exception( "Extension method MultiTexCoord1ivARB not found" );
		 _MultiTexCoord1ivARB( target, v );
		}
		public delegate void MultiTexCoord1sARBDelegate( uint target, short s ); // 

		private static MultiTexCoord1sARBDelegate _MultiTexCoord1sARB;

		public static  void MultiTexCoord1sARB( uint target, short s )
		{
			if (_MultiTexCoord1sARB == null) throw new Exception( "Extension method MultiTexCoord1sARB not found" );
		 _MultiTexCoord1sARB( target, s );
		}
		public delegate void MultiTexCoord1svARBDelegate( uint target, short[] v ); // 

		private static MultiTexCoord1svARBDelegate _MultiTexCoord1svARB;

		public static  void MultiTexCoord1svARB( uint target, short[] v )
		{
			if (_MultiTexCoord1svARB == null) throw new Exception( "Extension method MultiTexCoord1svARB not found" );
		 _MultiTexCoord1svARB( target, v );
		}
		public delegate void MultiTexCoord2dARBDelegate( uint target, double s, double t ); // 

		private static MultiTexCoord2dARBDelegate _MultiTexCoord2dARB;

		public static  void MultiTexCoord2dARB( uint target, double s, double t )
		{
			if (_MultiTexCoord2dARB == null) throw new Exception( "Extension method MultiTexCoord2dARB not found" );
		 _MultiTexCoord2dARB( target, s, t );
		}
		public delegate void MultiTexCoord2dvARBDelegate( uint target, double[] v ); // 

		private static MultiTexCoord2dvARBDelegate _MultiTexCoord2dvARB;

		public static  void MultiTexCoord2dvARB( uint target, double[] v )
		{
			if (_MultiTexCoord2dvARB == null) throw new Exception( "Extension method MultiTexCoord2dvARB not found" );
		 _MultiTexCoord2dvARB( target, v );
		}
		public delegate void MultiTexCoord2fARBDelegate( uint target, float s, float t ); // 

		private static MultiTexCoord2fARBDelegate _MultiTexCoord2fARB;

		public static  void MultiTexCoord2fARB( uint target, float s, float t )
		{
			if (_MultiTexCoord2fARB == null) throw new Exception( "Extension method MultiTexCoord2fARB not found" );
		 _MultiTexCoord2fARB( target, s, t );
		}
		public delegate void MultiTexCoord2fvARBDelegate( uint target, float[] v ); // 

		private static MultiTexCoord2fvARBDelegate _MultiTexCoord2fvARB;

		public static  void MultiTexCoord2fvARB( uint target, float[] v )
		{
			if (_MultiTexCoord2fvARB == null) throw new Exception( "Extension method MultiTexCoord2fvARB not found" );
		 _MultiTexCoord2fvARB( target, v );
		}
		public delegate void MultiTexCoord2iARBDelegate( uint target, int s, int t ); // 

		private static MultiTexCoord2iARBDelegate _MultiTexCoord2iARB;

		public static  void MultiTexCoord2iARB( uint target, int s, int t )
		{
			if (_MultiTexCoord2iARB == null) throw new Exception( "Extension method MultiTexCoord2iARB not found" );
		 _MultiTexCoord2iARB( target, s, t );
		}
		public delegate void MultiTexCoord2ivARBDelegate( uint target, int[] v ); // 

		private static MultiTexCoord2ivARBDelegate _MultiTexCoord2ivARB;

		public static  void MultiTexCoord2ivARB( uint target, int[] v )
		{
			if (_MultiTexCoord2ivARB == null) throw new Exception( "Extension method MultiTexCoord2ivARB not found" );
		 _MultiTexCoord2ivARB( target, v );
		}
		public delegate void MultiTexCoord2sARBDelegate( uint target, short s, short t ); // 

		private static MultiTexCoord2sARBDelegate _MultiTexCoord2sARB;

		public static  void MultiTexCoord2sARB( uint target, short s, short t )
		{
			if (_MultiTexCoord2sARB == null) throw new Exception( "Extension method MultiTexCoord2sARB not found" );
		 _MultiTexCoord2sARB( target, s, t );
		}
		public delegate void MultiTexCoord2svARBDelegate( uint target, short[] v ); // 

		private static MultiTexCoord2svARBDelegate _MultiTexCoord2svARB;

		public static  void MultiTexCoord2svARB( uint target, short[] v )
		{
			if (_MultiTexCoord2svARB == null) throw new Exception( "Extension method MultiTexCoord2svARB not found" );
		 _MultiTexCoord2svARB( target, v );
		}
		public delegate void MultiTexCoord3dARBDelegate( uint target, double s, double t, double r ); // 

		private static MultiTexCoord3dARBDelegate _MultiTexCoord3dARB;

		public static  void MultiTexCoord3dARB( uint target, double s, double t, double r )
		{
			if (_MultiTexCoord3dARB == null) throw new Exception( "Extension method MultiTexCoord3dARB not found" );
		 _MultiTexCoord3dARB( target, s, t, r );
		}
		public delegate void MultiTexCoord3dvARBDelegate( uint target, double[] v ); // 

		private static MultiTexCoord3dvARBDelegate _MultiTexCoord3dvARB;

		public static  void MultiTexCoord3dvARB( uint target, double[] v )
		{
			if (_MultiTexCoord3dvARB == null) throw new Exception( "Extension method MultiTexCoord3dvARB not found" );
		 _MultiTexCoord3dvARB( target, v );
		}
		public delegate void MultiTexCoord3fARBDelegate( uint target, float s, float t, float r ); // 

		private static MultiTexCoord3fARBDelegate _MultiTexCoord3fARB;

		public static  void MultiTexCoord3fARB( uint target, float s, float t, float r )
		{
			if (_MultiTexCoord3fARB == null) throw new Exception( "Extension method MultiTexCoord3fARB not found" );
		 _MultiTexCoord3fARB( target, s, t, r );
		}
		public delegate void MultiTexCoord3fvARBDelegate( uint target, float[] v ); // 

		private static MultiTexCoord3fvARBDelegate _MultiTexCoord3fvARB;

		public static  void MultiTexCoord3fvARB( uint target, float[] v )
		{
			if (_MultiTexCoord3fvARB == null) throw new Exception( "Extension method MultiTexCoord3fvARB not found" );
		 _MultiTexCoord3fvARB( target, v );
		}
		public delegate void MultiTexCoord3iARBDelegate( uint target, int s, int t, int r ); // 

		private static MultiTexCoord3iARBDelegate _MultiTexCoord3iARB;

		public static  void MultiTexCoord3iARB( uint target, int s, int t, int r )
		{
			if (_MultiTexCoord3iARB == null) throw new Exception( "Extension method MultiTexCoord3iARB not found" );
		 _MultiTexCoord3iARB( target, s, t, r );
		}
		public delegate void MultiTexCoord3ivARBDelegate( uint target, int[] v ); // 

		private static MultiTexCoord3ivARBDelegate _MultiTexCoord3ivARB;

		public static  void MultiTexCoord3ivARB( uint target, int[] v )
		{
			if (_MultiTexCoord3ivARB == null) throw new Exception( "Extension method MultiTexCoord3ivARB not found" );
		 _MultiTexCoord3ivARB( target, v );
		}
		public delegate void MultiTexCoord3sARBDelegate( uint target, short s, short t, short r ); // 

		private static MultiTexCoord3sARBDelegate _MultiTexCoord3sARB;

		public static  void MultiTexCoord3sARB( uint target, short s, short t, short r )
		{
			if (_MultiTexCoord3sARB == null) throw new Exception( "Extension method MultiTexCoord3sARB not found" );
		 _MultiTexCoord3sARB( target, s, t, r );
		}
		public delegate void MultiTexCoord3svARBDelegate( uint target, short[] v ); // 

		private static MultiTexCoord3svARBDelegate _MultiTexCoord3svARB;

		public static  void MultiTexCoord3svARB( uint target, short[] v )
		{
			if (_MultiTexCoord3svARB == null) throw new Exception( "Extension method MultiTexCoord3svARB not found" );
		 _MultiTexCoord3svARB( target, v );
		}
		public delegate void MultiTexCoord4dARBDelegate( uint target, double s, double t, double r, double q ); // 

		private static MultiTexCoord4dARBDelegate _MultiTexCoord4dARB;

		public static  void MultiTexCoord4dARB( uint target, double s, double t, double r, double q )
		{
			if (_MultiTexCoord4dARB == null) throw new Exception( "Extension method MultiTexCoord4dARB not found" );
		 _MultiTexCoord4dARB( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4dvARBDelegate( uint target, double[] v ); // 

		private static MultiTexCoord4dvARBDelegate _MultiTexCoord4dvARB;

		public static  void MultiTexCoord4dvARB( uint target, double[] v )
		{
			if (_MultiTexCoord4dvARB == null) throw new Exception( "Extension method MultiTexCoord4dvARB not found" );
		 _MultiTexCoord4dvARB( target, v );
		}
		public delegate void MultiTexCoord4fARBDelegate( uint target, float s, float t, float r, float q ); // 

		private static MultiTexCoord4fARBDelegate _MultiTexCoord4fARB;

		public static  void MultiTexCoord4fARB( uint target, float s, float t, float r, float q )
		{
			if (_MultiTexCoord4fARB == null) throw new Exception( "Extension method MultiTexCoord4fARB not found" );
		 _MultiTexCoord4fARB( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4fvARBDelegate( uint target, float[] v ); // 

		private static MultiTexCoord4fvARBDelegate _MultiTexCoord4fvARB;

		public static  void MultiTexCoord4fvARB( uint target, float[] v )
		{
			if (_MultiTexCoord4fvARB == null) throw new Exception( "Extension method MultiTexCoord4fvARB not found" );
		 _MultiTexCoord4fvARB( target, v );
		}
		public delegate void MultiTexCoord4iARBDelegate( uint target, int s, int t, int r, int q ); // 

		private static MultiTexCoord4iARBDelegate _MultiTexCoord4iARB;

		public static  void MultiTexCoord4iARB( uint target, int s, int t, int r, int q )
		{
			if (_MultiTexCoord4iARB == null) throw new Exception( "Extension method MultiTexCoord4iARB not found" );
		 _MultiTexCoord4iARB( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4ivARBDelegate( uint target, int[] v ); // 

		private static MultiTexCoord4ivARBDelegate _MultiTexCoord4ivARB;

		public static  void MultiTexCoord4ivARB( uint target, int[] v )
		{
			if (_MultiTexCoord4ivARB == null) throw new Exception( "Extension method MultiTexCoord4ivARB not found" );
		 _MultiTexCoord4ivARB( target, v );
		}
		public delegate void MultiTexCoord4sARBDelegate( uint target, short s, short t, short r, short q ); // 

		private static MultiTexCoord4sARBDelegate _MultiTexCoord4sARB;

		public static  void MultiTexCoord4sARB( uint target, short s, short t, short r, short q )
		{
			if (_MultiTexCoord4sARB == null) throw new Exception( "Extension method MultiTexCoord4sARB not found" );
		 _MultiTexCoord4sARB( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4svARBDelegate( uint target, short[] v ); // 

		private static MultiTexCoord4svARBDelegate _MultiTexCoord4svARB;

		public static  void MultiTexCoord4svARB( uint target, short[] v )
		{
			if (_MultiTexCoord4svARB == null) throw new Exception( "Extension method MultiTexCoord4svARB not found" );
		 _MultiTexCoord4svARB( target, v );
		}
	}
}
