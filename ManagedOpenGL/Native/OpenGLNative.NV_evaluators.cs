using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_evaluatorsInit()
		{
			_MapControlPointsNV = GetProcAdress< MapControlPointsNVDelegate >( "glMapControlPointsNV" );
			_MapParameterivNV = GetProcAdress< MapParameterivNVDelegate >( "glMapParameterivNV" );
			_MapParameterfvNV = GetProcAdress< MapParameterfvNVDelegate >( "glMapParameterfvNV" );
			_GetMapControlPointsNV = GetProcAdress< GetMapControlPointsNVDelegate >( "glGetMapControlPointsNV" );
			_GetMapParameterivNV = GetProcAdress< GetMapParameterivNVDelegate >( "glGetMapParameterivNV" );
			_GetMapParameterfvNV = GetProcAdress< GetMapParameterfvNVDelegate >( "glGetMapParameterfvNV" );
			_GetMapAttribParameterivNV = GetProcAdress< GetMapAttribParameterivNVDelegate >( "glGetMapAttribParameterivNV" );
			_GetMapAttribParameterfvNV = GetProcAdress< GetMapAttribParameterfvNVDelegate >( "glGetMapAttribParameterfvNV" );
			_EvalMapsNV = GetProcAdress< EvalMapsNVDelegate >( "glEvalMapsNV" );
		}


		public unsafe delegate void MapControlPointsNVDelegate( uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points ); //  extension method

		private static MapControlPointsNVDelegate _MapControlPointsNV;

		public static unsafe  void MapControlPointsNV( uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points )
		{
			if (_MapControlPointsNV == null) throw new Exception( "Extension method MapControlPointsNV not found" );
		 _MapControlPointsNV( target, index, type, ustride, vstride, uorder, vorder, packed, points );
		}
		public delegate void MapParameterivNVDelegate( uint target, uint pname, int[] @params ); //  extension method

		private static MapParameterivNVDelegate _MapParameterivNV;

		public static  void MapParameterivNV( uint target, uint pname, int[] @params )
		{
			if (_MapParameterivNV == null) throw new Exception( "Extension method MapParameterivNV not found" );
		 _MapParameterivNV( target, pname, @params );
		}
		public delegate void MapParameterfvNVDelegate( uint target, uint pname, float[] @params ); //  extension method

		private static MapParameterfvNVDelegate _MapParameterfvNV;

		public static  void MapParameterfvNV( uint target, uint pname, float[] @params )
		{
			if (_MapParameterfvNV == null) throw new Exception( "Extension method MapParameterfvNV not found" );
		 _MapParameterfvNV( target, pname, @params );
		}
		public unsafe delegate void GetMapControlPointsNVDelegate( uint target, uint index, uint type, int ustride, int vstride, bool packed, [Out]void* points ); //  extension method

		private static GetMapControlPointsNVDelegate _GetMapControlPointsNV;

		public static unsafe  void GetMapControlPointsNV( uint target, uint index, uint type, int ustride, int vstride, bool packed, [Out]void* points )
		{
			if (_GetMapControlPointsNV == null) throw new Exception( "Extension method GetMapControlPointsNV not found" );
		 _GetMapControlPointsNV( target, index, type, ustride, vstride, packed, points );
		}
		public delegate void GetMapParameterivNVDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetMapParameterivNVDelegate _GetMapParameterivNV;

		public static  void GetMapParameterivNV( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetMapParameterivNV == null) throw new Exception( "Extension method GetMapParameterivNV not found" );
		 _GetMapParameterivNV( target, pname, @params );
		}
		public delegate void GetMapParameterfvNVDelegate( uint target, uint pname, [Out]float[] @params ); //  extension method

		private static GetMapParameterfvNVDelegate _GetMapParameterfvNV;

		public static  void GetMapParameterfvNV( uint target, uint pname, [Out]float[] @params )
		{
			if (_GetMapParameterfvNV == null) throw new Exception( "Extension method GetMapParameterfvNV not found" );
		 _GetMapParameterfvNV( target, pname, @params );
		}
		public delegate void GetMapAttribParameterivNVDelegate( uint target, uint index, uint pname, [Out]int[] @params ); //  extension method

		private static GetMapAttribParameterivNVDelegate _GetMapAttribParameterivNV;

		public static  void GetMapAttribParameterivNV( uint target, uint index, uint pname, [Out]int[] @params )
		{
			if (_GetMapAttribParameterivNV == null) throw new Exception( "Extension method GetMapAttribParameterivNV not found" );
		 _GetMapAttribParameterivNV( target, index, pname, @params );
		}
		public delegate void GetMapAttribParameterfvNVDelegate( uint target, uint index, uint pname, [Out]float[] @params ); //  extension method

		private static GetMapAttribParameterfvNVDelegate _GetMapAttribParameterfvNV;

		public static  void GetMapAttribParameterfvNV( uint target, uint index, uint pname, [Out]float[] @params )
		{
			if (_GetMapAttribParameterfvNV == null) throw new Exception( "Extension method GetMapAttribParameterfvNV not found" );
		 _GetMapAttribParameterfvNV( target, index, pname, @params );
		}
		public delegate void EvalMapsNVDelegate( uint target, uint mode ); //  extension method

		private static EvalMapsNVDelegate _EvalMapsNV;

		public static  void EvalMapsNV( uint target, uint mode )
		{
			if (_EvalMapsNV == null) throw new Exception( "Extension method EvalMapsNV not found" );
		 _EvalMapsNV( target, mode );
		}
	}
}
