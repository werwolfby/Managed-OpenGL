using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_vertex_streamsInit()
		{
			_VertexStream1sATI = GetProcAdress< VertexStream1sATIDelegate >( "glVertexStream1sATI" );
			_VertexStream1svATI = GetProcAdress< VertexStream1svATIDelegate >( "glVertexStream1svATI" );
			_VertexStream1iATI = GetProcAdress< VertexStream1iATIDelegate >( "glVertexStream1iATI" );
			_VertexStream1ivATI = GetProcAdress< VertexStream1ivATIDelegate >( "glVertexStream1ivATI" );
			_VertexStream1fATI = GetProcAdress< VertexStream1fATIDelegate >( "glVertexStream1fATI" );
			_VertexStream1fvATI = GetProcAdress< VertexStream1fvATIDelegate >( "glVertexStream1fvATI" );
			_VertexStream1dATI = GetProcAdress< VertexStream1dATIDelegate >( "glVertexStream1dATI" );
			_VertexStream1dvATI = GetProcAdress< VertexStream1dvATIDelegate >( "glVertexStream1dvATI" );
			_VertexStream2sATI = GetProcAdress< VertexStream2sATIDelegate >( "glVertexStream2sATI" );
			_VertexStream2svATI = GetProcAdress< VertexStream2svATIDelegate >( "glVertexStream2svATI" );
			_VertexStream2iATI = GetProcAdress< VertexStream2iATIDelegate >( "glVertexStream2iATI" );
			_VertexStream2ivATI = GetProcAdress< VertexStream2ivATIDelegate >( "glVertexStream2ivATI" );
			_VertexStream2fATI = GetProcAdress< VertexStream2fATIDelegate >( "glVertexStream2fATI" );
			_VertexStream2fvATI = GetProcAdress< VertexStream2fvATIDelegate >( "glVertexStream2fvATI" );
			_VertexStream2dATI = GetProcAdress< VertexStream2dATIDelegate >( "glVertexStream2dATI" );
			_VertexStream2dvATI = GetProcAdress< VertexStream2dvATIDelegate >( "glVertexStream2dvATI" );
			_VertexStream3sATI = GetProcAdress< VertexStream3sATIDelegate >( "glVertexStream3sATI" );
			_VertexStream3svATI = GetProcAdress< VertexStream3svATIDelegate >( "glVertexStream3svATI" );
			_VertexStream3iATI = GetProcAdress< VertexStream3iATIDelegate >( "glVertexStream3iATI" );
			_VertexStream3ivATI = GetProcAdress< VertexStream3ivATIDelegate >( "glVertexStream3ivATI" );
			_VertexStream3fATI = GetProcAdress< VertexStream3fATIDelegate >( "glVertexStream3fATI" );
			_VertexStream3fvATI = GetProcAdress< VertexStream3fvATIDelegate >( "glVertexStream3fvATI" );
			_VertexStream3dATI = GetProcAdress< VertexStream3dATIDelegate >( "glVertexStream3dATI" );
			_VertexStream3dvATI = GetProcAdress< VertexStream3dvATIDelegate >( "glVertexStream3dvATI" );
			_VertexStream4sATI = GetProcAdress< VertexStream4sATIDelegate >( "glVertexStream4sATI" );
			_VertexStream4svATI = GetProcAdress< VertexStream4svATIDelegate >( "glVertexStream4svATI" );
			_VertexStream4iATI = GetProcAdress< VertexStream4iATIDelegate >( "glVertexStream4iATI" );
			_VertexStream4ivATI = GetProcAdress< VertexStream4ivATIDelegate >( "glVertexStream4ivATI" );
			_VertexStream4fATI = GetProcAdress< VertexStream4fATIDelegate >( "glVertexStream4fATI" );
			_VertexStream4fvATI = GetProcAdress< VertexStream4fvATIDelegate >( "glVertexStream4fvATI" );
			_VertexStream4dATI = GetProcAdress< VertexStream4dATIDelegate >( "glVertexStream4dATI" );
			_VertexStream4dvATI = GetProcAdress< VertexStream4dvATIDelegate >( "glVertexStream4dvATI" );
			_NormalStream3bATI = GetProcAdress< NormalStream3bATIDelegate >( "glNormalStream3bATI" );
			_NormalStream3bvATI = GetProcAdress< NormalStream3bvATIDelegate >( "glNormalStream3bvATI" );
			_NormalStream3sATI = GetProcAdress< NormalStream3sATIDelegate >( "glNormalStream3sATI" );
			_NormalStream3svATI = GetProcAdress< NormalStream3svATIDelegate >( "glNormalStream3svATI" );
			_NormalStream3iATI = GetProcAdress< NormalStream3iATIDelegate >( "glNormalStream3iATI" );
			_NormalStream3ivATI = GetProcAdress< NormalStream3ivATIDelegate >( "glNormalStream3ivATI" );
			_NormalStream3fATI = GetProcAdress< NormalStream3fATIDelegate >( "glNormalStream3fATI" );
			_NormalStream3fvATI = GetProcAdress< NormalStream3fvATIDelegate >( "glNormalStream3fvATI" );
			_NormalStream3dATI = GetProcAdress< NormalStream3dATIDelegate >( "glNormalStream3dATI" );
			_NormalStream3dvATI = GetProcAdress< NormalStream3dvATIDelegate >( "glNormalStream3dvATI" );
			_ClientActiveVertexStreamATI = GetProcAdress< ClientActiveVertexStreamATIDelegate >( "glClientActiveVertexStreamATI" );
			_VertexBlendEnviATI = GetProcAdress< VertexBlendEnviATIDelegate >( "glVertexBlendEnviATI" );
			_VertexBlendEnvfATI = GetProcAdress< VertexBlendEnvfATIDelegate >( "glVertexBlendEnvfATI" );
			
		}
		
	
		public delegate void VertexStream1sATIDelegate( uint stream, short x ); //  extension method
		private static VertexStream1sATIDelegate _VertexStream1sATI;
		
		public static  void VertexStream1sATI( uint stream, short x )
		{
			if (_VertexStream1sATI == null) throw new Exception( "Extension method VertexStream1sATI not found" );
			 _VertexStream1sATI( stream, x );
		}
		public delegate void VertexStream1svATIDelegate( uint stream, short[] coords ); //  extension method
		private static VertexStream1svATIDelegate _VertexStream1svATI;
		
		public static  void VertexStream1svATI( uint stream, short[] coords )
		{
			if (_VertexStream1svATI == null) throw new Exception( "Extension method VertexStream1svATI not found" );
			 _VertexStream1svATI( stream, coords );
		}
		public delegate void VertexStream1iATIDelegate( uint stream, int x ); //  extension method
		private static VertexStream1iATIDelegate _VertexStream1iATI;
		
		public static  void VertexStream1iATI( uint stream, int x )
		{
			if (_VertexStream1iATI == null) throw new Exception( "Extension method VertexStream1iATI not found" );
			 _VertexStream1iATI( stream, x );
		}
		public delegate void VertexStream1ivATIDelegate( uint stream, int[] coords ); //  extension method
		private static VertexStream1ivATIDelegate _VertexStream1ivATI;
		
		public static  void VertexStream1ivATI( uint stream, int[] coords )
		{
			if (_VertexStream1ivATI == null) throw new Exception( "Extension method VertexStream1ivATI not found" );
			 _VertexStream1ivATI( stream, coords );
		}
		public delegate void VertexStream1fATIDelegate( uint stream, float x ); //  extension method
		private static VertexStream1fATIDelegate _VertexStream1fATI;
		
		public static  void VertexStream1fATI( uint stream, float x )
		{
			if (_VertexStream1fATI == null) throw new Exception( "Extension method VertexStream1fATI not found" );
			 _VertexStream1fATI( stream, x );
		}
		public delegate void VertexStream1fvATIDelegate( uint stream, float[] coords ); //  extension method
		private static VertexStream1fvATIDelegate _VertexStream1fvATI;
		
		public static  void VertexStream1fvATI( uint stream, float[] coords )
		{
			if (_VertexStream1fvATI == null) throw new Exception( "Extension method VertexStream1fvATI not found" );
			 _VertexStream1fvATI( stream, coords );
		}
		public delegate void VertexStream1dATIDelegate( uint stream, double x ); //  extension method
		private static VertexStream1dATIDelegate _VertexStream1dATI;
		
		public static  void VertexStream1dATI( uint stream, double x )
		{
			if (_VertexStream1dATI == null) throw new Exception( "Extension method VertexStream1dATI not found" );
			 _VertexStream1dATI( stream, x );
		}
		public delegate void VertexStream1dvATIDelegate( uint stream, double[] coords ); //  extension method
		private static VertexStream1dvATIDelegate _VertexStream1dvATI;
		
		public static  void VertexStream1dvATI( uint stream, double[] coords )
		{
			if (_VertexStream1dvATI == null) throw new Exception( "Extension method VertexStream1dvATI not found" );
			 _VertexStream1dvATI( stream, coords );
		}
		public delegate void VertexStream2sATIDelegate( uint stream, short x, short y ); //  extension method
		private static VertexStream2sATIDelegate _VertexStream2sATI;
		
		public static  void VertexStream2sATI( uint stream, short x, short y )
		{
			if (_VertexStream2sATI == null) throw new Exception( "Extension method VertexStream2sATI not found" );
			 _VertexStream2sATI( stream, x, y );
		}
		public delegate void VertexStream2svATIDelegate( uint stream, short[] coords ); //  extension method
		private static VertexStream2svATIDelegate _VertexStream2svATI;
		
		public static  void VertexStream2svATI( uint stream, short[] coords )
		{
			if (_VertexStream2svATI == null) throw new Exception( "Extension method VertexStream2svATI not found" );
			 _VertexStream2svATI( stream, coords );
		}
		public delegate void VertexStream2iATIDelegate( uint stream, int x, int y ); //  extension method
		private static VertexStream2iATIDelegate _VertexStream2iATI;
		
		public static  void VertexStream2iATI( uint stream, int x, int y )
		{
			if (_VertexStream2iATI == null) throw new Exception( "Extension method VertexStream2iATI not found" );
			 _VertexStream2iATI( stream, x, y );
		}
		public delegate void VertexStream2ivATIDelegate( uint stream, int[] coords ); //  extension method
		private static VertexStream2ivATIDelegate _VertexStream2ivATI;
		
		public static  void VertexStream2ivATI( uint stream, int[] coords )
		{
			if (_VertexStream2ivATI == null) throw new Exception( "Extension method VertexStream2ivATI not found" );
			 _VertexStream2ivATI( stream, coords );
		}
		public delegate void VertexStream2fATIDelegate( uint stream, float x, float y ); //  extension method
		private static VertexStream2fATIDelegate _VertexStream2fATI;
		
		public static  void VertexStream2fATI( uint stream, float x, float y )
		{
			if (_VertexStream2fATI == null) throw new Exception( "Extension method VertexStream2fATI not found" );
			 _VertexStream2fATI( stream, x, y );
		}
		public delegate void VertexStream2fvATIDelegate( uint stream, float[] coords ); //  extension method
		private static VertexStream2fvATIDelegate _VertexStream2fvATI;
		
		public static  void VertexStream2fvATI( uint stream, float[] coords )
		{
			if (_VertexStream2fvATI == null) throw new Exception( "Extension method VertexStream2fvATI not found" );
			 _VertexStream2fvATI( stream, coords );
		}
		public delegate void VertexStream2dATIDelegate( uint stream, double x, double y ); //  extension method
		private static VertexStream2dATIDelegate _VertexStream2dATI;
		
		public static  void VertexStream2dATI( uint stream, double x, double y )
		{
			if (_VertexStream2dATI == null) throw new Exception( "Extension method VertexStream2dATI not found" );
			 _VertexStream2dATI( stream, x, y );
		}
		public delegate void VertexStream2dvATIDelegate( uint stream, double[] coords ); //  extension method
		private static VertexStream2dvATIDelegate _VertexStream2dvATI;
		
		public static  void VertexStream2dvATI( uint stream, double[] coords )
		{
			if (_VertexStream2dvATI == null) throw new Exception( "Extension method VertexStream2dvATI not found" );
			 _VertexStream2dvATI( stream, coords );
		}
		public delegate void VertexStream3sATIDelegate( uint stream, short x, short y, short z ); //  extension method
		private static VertexStream3sATIDelegate _VertexStream3sATI;
		
		public static  void VertexStream3sATI( uint stream, short x, short y, short z )
		{
			if (_VertexStream3sATI == null) throw new Exception( "Extension method VertexStream3sATI not found" );
			 _VertexStream3sATI( stream, x, y, z );
		}
		public delegate void VertexStream3svATIDelegate( uint stream, short[] coords ); //  extension method
		private static VertexStream3svATIDelegate _VertexStream3svATI;
		
		public static  void VertexStream3svATI( uint stream, short[] coords )
		{
			if (_VertexStream3svATI == null) throw new Exception( "Extension method VertexStream3svATI not found" );
			 _VertexStream3svATI( stream, coords );
		}
		public delegate void VertexStream3iATIDelegate( uint stream, int x, int y, int z ); //  extension method
		private static VertexStream3iATIDelegate _VertexStream3iATI;
		
		public static  void VertexStream3iATI( uint stream, int x, int y, int z )
		{
			if (_VertexStream3iATI == null) throw new Exception( "Extension method VertexStream3iATI not found" );
			 _VertexStream3iATI( stream, x, y, z );
		}
		public delegate void VertexStream3ivATIDelegate( uint stream, int[] coords ); //  extension method
		private static VertexStream3ivATIDelegate _VertexStream3ivATI;
		
		public static  void VertexStream3ivATI( uint stream, int[] coords )
		{
			if (_VertexStream3ivATI == null) throw new Exception( "Extension method VertexStream3ivATI not found" );
			 _VertexStream3ivATI( stream, coords );
		}
		public delegate void VertexStream3fATIDelegate( uint stream, float x, float y, float z ); //  extension method
		private static VertexStream3fATIDelegate _VertexStream3fATI;
		
		public static  void VertexStream3fATI( uint stream, float x, float y, float z )
		{
			if (_VertexStream3fATI == null) throw new Exception( "Extension method VertexStream3fATI not found" );
			 _VertexStream3fATI( stream, x, y, z );
		}
		public delegate void VertexStream3fvATIDelegate( uint stream, float[] coords ); //  extension method
		private static VertexStream3fvATIDelegate _VertexStream3fvATI;
		
		public static  void VertexStream3fvATI( uint stream, float[] coords )
		{
			if (_VertexStream3fvATI == null) throw new Exception( "Extension method VertexStream3fvATI not found" );
			 _VertexStream3fvATI( stream, coords );
		}
		public delegate void VertexStream3dATIDelegate( uint stream, double x, double y, double z ); //  extension method
		private static VertexStream3dATIDelegate _VertexStream3dATI;
		
		public static  void VertexStream3dATI( uint stream, double x, double y, double z )
		{
			if (_VertexStream3dATI == null) throw new Exception( "Extension method VertexStream3dATI not found" );
			 _VertexStream3dATI( stream, x, y, z );
		}
		public delegate void VertexStream3dvATIDelegate( uint stream, double[] coords ); //  extension method
		private static VertexStream3dvATIDelegate _VertexStream3dvATI;
		
		public static  void VertexStream3dvATI( uint stream, double[] coords )
		{
			if (_VertexStream3dvATI == null) throw new Exception( "Extension method VertexStream3dvATI not found" );
			 _VertexStream3dvATI( stream, coords );
		}
		public delegate void VertexStream4sATIDelegate( uint stream, short x, short y, short z, short w ); //  extension method
		private static VertexStream4sATIDelegate _VertexStream4sATI;
		
		public static  void VertexStream4sATI( uint stream, short x, short y, short z, short w )
		{
			if (_VertexStream4sATI == null) throw new Exception( "Extension method VertexStream4sATI not found" );
			 _VertexStream4sATI( stream, x, y, z, w );
		}
		public delegate void VertexStream4svATIDelegate( uint stream, short[] coords ); //  extension method
		private static VertexStream4svATIDelegate _VertexStream4svATI;
		
		public static  void VertexStream4svATI( uint stream, short[] coords )
		{
			if (_VertexStream4svATI == null) throw new Exception( "Extension method VertexStream4svATI not found" );
			 _VertexStream4svATI( stream, coords );
		}
		public delegate void VertexStream4iATIDelegate( uint stream, int x, int y, int z, int w ); //  extension method
		private static VertexStream4iATIDelegate _VertexStream4iATI;
		
		public static  void VertexStream4iATI( uint stream, int x, int y, int z, int w )
		{
			if (_VertexStream4iATI == null) throw new Exception( "Extension method VertexStream4iATI not found" );
			 _VertexStream4iATI( stream, x, y, z, w );
		}
		public delegate void VertexStream4ivATIDelegate( uint stream, int[] coords ); //  extension method
		private static VertexStream4ivATIDelegate _VertexStream4ivATI;
		
		public static  void VertexStream4ivATI( uint stream, int[] coords )
		{
			if (_VertexStream4ivATI == null) throw new Exception( "Extension method VertexStream4ivATI not found" );
			 _VertexStream4ivATI( stream, coords );
		}
		public delegate void VertexStream4fATIDelegate( uint stream, float x, float y, float z, float w ); //  extension method
		private static VertexStream4fATIDelegate _VertexStream4fATI;
		
		public static  void VertexStream4fATI( uint stream, float x, float y, float z, float w )
		{
			if (_VertexStream4fATI == null) throw new Exception( "Extension method VertexStream4fATI not found" );
			 _VertexStream4fATI( stream, x, y, z, w );
		}
		public delegate void VertexStream4fvATIDelegate( uint stream, float[] coords ); //  extension method
		private static VertexStream4fvATIDelegate _VertexStream4fvATI;
		
		public static  void VertexStream4fvATI( uint stream, float[] coords )
		{
			if (_VertexStream4fvATI == null) throw new Exception( "Extension method VertexStream4fvATI not found" );
			 _VertexStream4fvATI( stream, coords );
		}
		public delegate void VertexStream4dATIDelegate( uint stream, double x, double y, double z, double w ); //  extension method
		private static VertexStream4dATIDelegate _VertexStream4dATI;
		
		public static  void VertexStream4dATI( uint stream, double x, double y, double z, double w )
		{
			if (_VertexStream4dATI == null) throw new Exception( "Extension method VertexStream4dATI not found" );
			 _VertexStream4dATI( stream, x, y, z, w );
		}
		public delegate void VertexStream4dvATIDelegate( uint stream, double[] coords ); //  extension method
		private static VertexStream4dvATIDelegate _VertexStream4dvATI;
		
		public static  void VertexStream4dvATI( uint stream, double[] coords )
		{
			if (_VertexStream4dvATI == null) throw new Exception( "Extension method VertexStream4dvATI not found" );
			 _VertexStream4dvATI( stream, coords );
		}
		public delegate void NormalStream3bATIDelegate( uint stream, sbyte nx, sbyte ny, sbyte nz ); //  extension method
		private static NormalStream3bATIDelegate _NormalStream3bATI;
		
		public static  void NormalStream3bATI( uint stream, sbyte nx, sbyte ny, sbyte nz )
		{
			if (_NormalStream3bATI == null) throw new Exception( "Extension method NormalStream3bATI not found" );
			 _NormalStream3bATI( stream, nx, ny, nz );
		}
		public delegate void NormalStream3bvATIDelegate( uint stream, sbyte[] coords ); //  extension method
		private static NormalStream3bvATIDelegate _NormalStream3bvATI;
		
		public static  void NormalStream3bvATI( uint stream, sbyte[] coords )
		{
			if (_NormalStream3bvATI == null) throw new Exception( "Extension method NormalStream3bvATI not found" );
			 _NormalStream3bvATI( stream, coords );
		}
		public delegate void NormalStream3sATIDelegate( uint stream, short nx, short ny, short nz ); //  extension method
		private static NormalStream3sATIDelegate _NormalStream3sATI;
		
		public static  void NormalStream3sATI( uint stream, short nx, short ny, short nz )
		{
			if (_NormalStream3sATI == null) throw new Exception( "Extension method NormalStream3sATI not found" );
			 _NormalStream3sATI( stream, nx, ny, nz );
		}
		public delegate void NormalStream3svATIDelegate( uint stream, short[] coords ); //  extension method
		private static NormalStream3svATIDelegate _NormalStream3svATI;
		
		public static  void NormalStream3svATI( uint stream, short[] coords )
		{
			if (_NormalStream3svATI == null) throw new Exception( "Extension method NormalStream3svATI not found" );
			 _NormalStream3svATI( stream, coords );
		}
		public delegate void NormalStream3iATIDelegate( uint stream, int nx, int ny, int nz ); //  extension method
		private static NormalStream3iATIDelegate _NormalStream3iATI;
		
		public static  void NormalStream3iATI( uint stream, int nx, int ny, int nz )
		{
			if (_NormalStream3iATI == null) throw new Exception( "Extension method NormalStream3iATI not found" );
			 _NormalStream3iATI( stream, nx, ny, nz );
		}
		public delegate void NormalStream3ivATIDelegate( uint stream, int[] coords ); //  extension method
		private static NormalStream3ivATIDelegate _NormalStream3ivATI;
		
		public static  void NormalStream3ivATI( uint stream, int[] coords )
		{
			if (_NormalStream3ivATI == null) throw new Exception( "Extension method NormalStream3ivATI not found" );
			 _NormalStream3ivATI( stream, coords );
		}
		public delegate void NormalStream3fATIDelegate( uint stream, float nx, float ny, float nz ); //  extension method
		private static NormalStream3fATIDelegate _NormalStream3fATI;
		
		public static  void NormalStream3fATI( uint stream, float nx, float ny, float nz )
		{
			if (_NormalStream3fATI == null) throw new Exception( "Extension method NormalStream3fATI not found" );
			 _NormalStream3fATI( stream, nx, ny, nz );
		}
		public delegate void NormalStream3fvATIDelegate( uint stream, float[] coords ); //  extension method
		private static NormalStream3fvATIDelegate _NormalStream3fvATI;
		
		public static  void NormalStream3fvATI( uint stream, float[] coords )
		{
			if (_NormalStream3fvATI == null) throw new Exception( "Extension method NormalStream3fvATI not found" );
			 _NormalStream3fvATI( stream, coords );
		}
		public delegate void NormalStream3dATIDelegate( uint stream, double nx, double ny, double nz ); //  extension method
		private static NormalStream3dATIDelegate _NormalStream3dATI;
		
		public static  void NormalStream3dATI( uint stream, double nx, double ny, double nz )
		{
			if (_NormalStream3dATI == null) throw new Exception( "Extension method NormalStream3dATI not found" );
			 _NormalStream3dATI( stream, nx, ny, nz );
		}
		public delegate void NormalStream3dvATIDelegate( uint stream, double[] coords ); //  extension method
		private static NormalStream3dvATIDelegate _NormalStream3dvATI;
		
		public static  void NormalStream3dvATI( uint stream, double[] coords )
		{
			if (_NormalStream3dvATI == null) throw new Exception( "Extension method NormalStream3dvATI not found" );
			 _NormalStream3dvATI( stream, coords );
		}
		public delegate void ClientActiveVertexStreamATIDelegate( uint stream ); //  extension method
		private static ClientActiveVertexStreamATIDelegate _ClientActiveVertexStreamATI;
		
		public static  void ClientActiveVertexStreamATI( uint stream )
		{
			if (_ClientActiveVertexStreamATI == null) throw new Exception( "Extension method ClientActiveVertexStreamATI not found" );
			 _ClientActiveVertexStreamATI( stream );
		}
		public delegate void VertexBlendEnviATIDelegate( uint pname, int param ); //  extension method
		private static VertexBlendEnviATIDelegate _VertexBlendEnviATI;
		
		public static  void VertexBlendEnviATI( uint pname, int param )
		{
			if (_VertexBlendEnviATI == null) throw new Exception( "Extension method VertexBlendEnviATI not found" );
			 _VertexBlendEnviATI( pname, param );
		}
		public delegate void VertexBlendEnvfATIDelegate( uint pname, float param ); //  extension method
		private static VertexBlendEnvfATIDelegate _VertexBlendEnvfATI;
		
		public static  void VertexBlendEnvfATI( uint pname, float param )
		{
			if (_VertexBlendEnvfATI == null) throw new Exception( "Extension method VertexBlendEnvfATI not found" );
			 _VertexBlendEnvfATI( pname, param );
		}
	}
}

