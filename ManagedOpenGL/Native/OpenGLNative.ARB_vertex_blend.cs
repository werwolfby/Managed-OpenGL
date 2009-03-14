using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_vertex_blendInit()
		{
			_WeightbvARB = GetProcAdress< WeightbvARBDelegate >( "glWeightbvARB" );
			_WeightsvARB = GetProcAdress< WeightsvARBDelegate >( "glWeightsvARB" );
			_WeightivARB = GetProcAdress< WeightivARBDelegate >( "glWeightivARB" );
			_WeightfvARB = GetProcAdress< WeightfvARBDelegate >( "glWeightfvARB" );
			_WeightdvARB = GetProcAdress< WeightdvARBDelegate >( "glWeightdvARB" );
			_WeightubvARB = GetProcAdress< WeightubvARBDelegate >( "glWeightubvARB" );
			_WeightusvARB = GetProcAdress< WeightusvARBDelegate >( "glWeightusvARB" );
			_WeightuivARB = GetProcAdress< WeightuivARBDelegate >( "glWeightuivARB" );
			_WeightPointerARB = GetProcAdress< WeightPointerARBDelegate >( "glWeightPointerARB" );
			_VertexBlendARB = GetProcAdress< VertexBlendARBDelegate >( "glVertexBlendARB" );
		}


		public delegate void WeightbvARBDelegate( int size, sbyte[] weights ); //  extension method

		private static WeightbvARBDelegate _WeightbvARB;

		public static  void WeightbvARB( int size, sbyte[] weights )
		{
			if (_WeightbvARB == null) throw new Exception( "Extension method WeightbvARB not found" );
		 _WeightbvARB( size, weights );
		}
		public delegate void WeightsvARBDelegate( int size, short[] weights ); //  extension method

		private static WeightsvARBDelegate _WeightsvARB;

		public static  void WeightsvARB( int size, short[] weights )
		{
			if (_WeightsvARB == null) throw new Exception( "Extension method WeightsvARB not found" );
		 _WeightsvARB( size, weights );
		}
		public delegate void WeightivARBDelegate( int size, int[] weights ); //  extension method

		private static WeightivARBDelegate _WeightivARB;

		public static  void WeightivARB( int size, int[] weights )
		{
			if (_WeightivARB == null) throw new Exception( "Extension method WeightivARB not found" );
		 _WeightivARB( size, weights );
		}
		public delegate void WeightfvARBDelegate( int size, float[] weights ); //  extension method

		private static WeightfvARBDelegate _WeightfvARB;

		public static  void WeightfvARB( int size, float[] weights )
		{
			if (_WeightfvARB == null) throw new Exception( "Extension method WeightfvARB not found" );
		 _WeightfvARB( size, weights );
		}
		public delegate void WeightdvARBDelegate( int size, double[] weights ); //  extension method

		private static WeightdvARBDelegate _WeightdvARB;

		public static  void WeightdvARB( int size, double[] weights )
		{
			if (_WeightdvARB == null) throw new Exception( "Extension method WeightdvARB not found" );
		 _WeightdvARB( size, weights );
		}
		public delegate void WeightubvARBDelegate( int size, byte[] weights ); //  extension method

		private static WeightubvARBDelegate _WeightubvARB;

		public static  void WeightubvARB( int size, byte[] weights )
		{
			if (_WeightubvARB == null) throw new Exception( "Extension method WeightubvARB not found" );
		 _WeightubvARB( size, weights );
		}
		public delegate void WeightusvARBDelegate( int size, ushort[] weights ); //  extension method

		private static WeightusvARBDelegate _WeightusvARB;

		public static  void WeightusvARB( int size, ushort[] weights )
		{
			if (_WeightusvARB == null) throw new Exception( "Extension method WeightusvARB not found" );
		 _WeightusvARB( size, weights );
		}
		public delegate void WeightuivARBDelegate( int size, uint[] weights ); //  extension method

		private static WeightuivARBDelegate _WeightuivARB;

		public static  void WeightuivARB( int size, uint[] weights )
		{
			if (_WeightuivARB == null) throw new Exception( "Extension method WeightuivARB not found" );
		 _WeightuivARB( size, weights );
		}
		public unsafe delegate void WeightPointerARBDelegate( int size, uint type, int stride, void* pointer ); //  extension method

		private static WeightPointerARBDelegate _WeightPointerARB;

		public static unsafe  void WeightPointerARB( int size, uint type, int stride, void* pointer )
		{
			if (_WeightPointerARB == null) throw new Exception( "Extension method WeightPointerARB not found" );
		 _WeightPointerARB( size, type, stride, pointer );
		}
		public delegate void VertexBlendARBDelegate( int count ); //  extension method

		private static VertexBlendARBDelegate _VertexBlendARB;

		public static  void VertexBlendARB( int count )
		{
			if (_VertexBlendARB == null) throw new Exception( "Extension method VertexBlendARB not found" );
		 _VertexBlendARB( count );
		}
	}
}
