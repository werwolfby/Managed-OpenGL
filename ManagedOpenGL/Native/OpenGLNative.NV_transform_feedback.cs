using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_transform_feedbackInit()
		{
			_BeginTransformFeedbackNV = GetProcAdress< BeginTransformFeedbackNVDelegate >( "glBeginTransformFeedbackNV" );
			_EndTransformFeedbackNV = GetProcAdress< EndTransformFeedbackNVDelegate >( "glEndTransformFeedbackNV" );
			_TransformFeedbackAttribsNV = GetProcAdress< TransformFeedbackAttribsNVDelegate >( "glTransformFeedbackAttribsNV" );
			_BindBufferRangeNV = GetProcAdress< BindBufferRangeNVDelegate >( "glBindBufferRangeNV" );
			_BindBufferOffsetNV = GetProcAdress< BindBufferOffsetNVDelegate >( "glBindBufferOffsetNV" );
			_BindBufferBaseNV = GetProcAdress< BindBufferBaseNVDelegate >( "glBindBufferBaseNV" );
			_TransformFeedbackVaryingsNV = GetProcAdress< TransformFeedbackVaryingsNVDelegate >( "glTransformFeedbackVaryingsNV" );
			_ActiveVaryingNV = GetProcAdress< ActiveVaryingNVDelegate >( "glActiveVaryingNV" );
			_GetVaryingLocationNV = GetProcAdress< GetVaryingLocationNVDelegate >( "glGetVaryingLocationNV" );
			_GetActiveVaryingNV = GetProcAdress< GetActiveVaryingNVDelegate >( "glGetActiveVaryingNV" );
			_GetTransformFeedbackVaryingNV = GetProcAdress< GetTransformFeedbackVaryingNVDelegate >( "glGetTransformFeedbackVaryingNV" );
		}


		public delegate void BeginTransformFeedbackNVDelegate( uint primitiveMode ); //  extension method

		private static BeginTransformFeedbackNVDelegate _BeginTransformFeedbackNV;

		public static  void BeginTransformFeedbackNV( uint primitiveMode )
		{
			if (_BeginTransformFeedbackNV == null) throw new Exception( "Extension method BeginTransformFeedbackNV not found" );
		 _BeginTransformFeedbackNV( primitiveMode );
		}
		public delegate void EndTransformFeedbackNVDelegate(  ); //  extension method

		private static EndTransformFeedbackNVDelegate _EndTransformFeedbackNV;

		public static  void EndTransformFeedbackNV(  )
		{
			if (_EndTransformFeedbackNV == null) throw new Exception( "Extension method EndTransformFeedbackNV not found" );
		 _EndTransformFeedbackNV(  );
		}
		public delegate void TransformFeedbackAttribsNVDelegate( uint count, int[] attribs, uint bufferMode ); //  extension method

		private static TransformFeedbackAttribsNVDelegate _TransformFeedbackAttribsNV;

		public static  void TransformFeedbackAttribsNV( uint count, int[] attribs, uint bufferMode )
		{
			if (_TransformFeedbackAttribsNV == null) throw new Exception( "Extension method TransformFeedbackAttribsNV not found" );
		 _TransformFeedbackAttribsNV( count, attribs, bufferMode );
		}
		public delegate void BindBufferRangeNVDelegate( uint target, uint index, uint buffer, int offset, int size ); //  extension method

		private static BindBufferRangeNVDelegate _BindBufferRangeNV;

		public static  void BindBufferRangeNV( uint target, uint index, uint buffer, int offset, int size )
		{
			if (_BindBufferRangeNV == null) throw new Exception( "Extension method BindBufferRangeNV not found" );
		 _BindBufferRangeNV( target, index, buffer, offset, size );
		}
		public delegate void BindBufferOffsetNVDelegate( uint target, uint index, uint buffer, int offset ); //  extension method

		private static BindBufferOffsetNVDelegate _BindBufferOffsetNV;

		public static  void BindBufferOffsetNV( uint target, uint index, uint buffer, int offset )
		{
			if (_BindBufferOffsetNV == null) throw new Exception( "Extension method BindBufferOffsetNV not found" );
		 _BindBufferOffsetNV( target, index, buffer, offset );
		}
		public delegate void BindBufferBaseNVDelegate( uint target, uint index, uint buffer ); //  extension method

		private static BindBufferBaseNVDelegate _BindBufferBaseNV;

		public static  void BindBufferBaseNV( uint target, uint index, uint buffer )
		{
			if (_BindBufferBaseNV == null) throw new Exception( "Extension method BindBufferBaseNV not found" );
		 _BindBufferBaseNV( target, index, buffer );
		}
		public delegate void TransformFeedbackVaryingsNVDelegate( uint program, int count, int[] locations, uint bufferMode ); //  extension method

		private static TransformFeedbackVaryingsNVDelegate _TransformFeedbackVaryingsNV;

		public static  void TransformFeedbackVaryingsNV( uint program, int count, int[] locations, uint bufferMode )
		{
			if (_TransformFeedbackVaryingsNV == null) throw new Exception( "Extension method TransformFeedbackVaryingsNV not found" );
		 _TransformFeedbackVaryingsNV( program, count, locations, bufferMode );
		}
		public delegate void ActiveVaryingNVDelegate( uint program, string name ); //  extension method

		private static ActiveVaryingNVDelegate _ActiveVaryingNV;

		public static  void ActiveVaryingNV( uint program, string name )
		{
			if (_ActiveVaryingNV == null) throw new Exception( "Extension method ActiveVaryingNV not found" );
		 _ActiveVaryingNV( program, name );
		}
		public delegate int GetVaryingLocationNVDelegate( uint program, string name ); //  extension method

		private static GetVaryingLocationNVDelegate _GetVaryingLocationNV;

		public static  int GetVaryingLocationNV( uint program, string name )
		{
			if (_GetVaryingLocationNV == null) throw new Exception( "Extension method GetVaryingLocationNV not found" );
		return  _GetVaryingLocationNV( program, name );
		}
		public delegate void GetActiveVaryingNVDelegate( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name ); //  extension method

		private static GetActiveVaryingNVDelegate _GetActiveVaryingNV;

		public static  void GetActiveVaryingNV( uint program, uint index, int bufSize, [Out]int[] length, [Out]int[] size, [Out]uint[] type, [Out]string name )
		{
			if (_GetActiveVaryingNV == null) throw new Exception( "Extension method GetActiveVaryingNV not found" );
		 _GetActiveVaryingNV( program, index, bufSize, length, size, type, name );
		}
		public delegate void GetTransformFeedbackVaryingNVDelegate( uint program, uint index, [Out]int[] location ); //  extension method

		private static GetTransformFeedbackVaryingNVDelegate _GetTransformFeedbackVaryingNV;

		public static  void GetTransformFeedbackVaryingNV( uint program, uint index, [Out]int[] location )
		{
			if (_GetTransformFeedbackVaryingNV == null) throw new Exception( "Extension method GetTransformFeedbackVaryingNV not found" );
		 _GetTransformFeedbackVaryingNV( program, index, location );
		}
	}
}
