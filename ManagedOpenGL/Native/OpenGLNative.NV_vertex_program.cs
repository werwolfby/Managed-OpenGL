using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_vertex_programInit()
		{
			_AreProgramsResidentNV = GetProcAdress< AreProgramsResidentNVDelegate >( "glAreProgramsResidentNV" );
			_BindProgramNV = GetProcAdress< BindProgramNVDelegate >( "glBindProgramNV" );
			_DeleteProgramsNV = GetProcAdress< DeleteProgramsNVDelegate >( "glDeleteProgramsNV" );
			_ExecuteProgramNV = GetProcAdress< ExecuteProgramNVDelegate >( "glExecuteProgramNV" );
			_GenProgramsNV = GetProcAdress< GenProgramsNVDelegate >( "glGenProgramsNV" );
			_GetProgramParameterdvNV = GetProcAdress< GetProgramParameterdvNVDelegate >( "glGetProgramParameterdvNV" );
			_GetProgramParameterfvNV = GetProcAdress< GetProgramParameterfvNVDelegate >( "glGetProgramParameterfvNV" );
			_GetProgramivNV = GetProcAdress< GetProgramivNVDelegate >( "glGetProgramivNV" );
			_GetProgramStringNV = GetProcAdress< GetProgramStringNVDelegate >( "glGetProgramStringNV" );
			_GetTrackMatrixivNV = GetProcAdress< GetTrackMatrixivNVDelegate >( "glGetTrackMatrixivNV" );
			_GetVertexAttribdvNV = GetProcAdress< GetVertexAttribdvNVDelegate >( "glGetVertexAttribdvNV" );
			_GetVertexAttribfvNV = GetProcAdress< GetVertexAttribfvNVDelegate >( "glGetVertexAttribfvNV" );
			_GetVertexAttribivNV = GetProcAdress< GetVertexAttribivNVDelegate >( "glGetVertexAttribivNV" );
			_GetVertexAttribPointervNV = GetProcAdress< GetVertexAttribPointervNVDelegate >( "glGetVertexAttribPointervNV" );
			_IsProgramNV = GetProcAdress< IsProgramNVDelegate >( "glIsProgramNV" );
			_LoadProgramNV = GetProcAdress< LoadProgramNVDelegate >( "glLoadProgramNV" );
			_ProgramParameter4dNV = GetProcAdress< ProgramParameter4dNVDelegate >( "glProgramParameter4dNV" );
			_ProgramParameter4dvNV = GetProcAdress< ProgramParameter4dvNVDelegate >( "glProgramParameter4dvNV" );
			_ProgramParameter4fNV = GetProcAdress< ProgramParameter4fNVDelegate >( "glProgramParameter4fNV" );
			_ProgramParameter4fvNV = GetProcAdress< ProgramParameter4fvNVDelegate >( "glProgramParameter4fvNV" );
			_ProgramParameters4dvNV = GetProcAdress< ProgramParameters4dvNVDelegate >( "glProgramParameters4dvNV" );
			_ProgramParameters4fvNV = GetProcAdress< ProgramParameters4fvNVDelegate >( "glProgramParameters4fvNV" );
			_RequestResidentProgramsNV = GetProcAdress< RequestResidentProgramsNVDelegate >( "glRequestResidentProgramsNV" );
			_TrackMatrixNV = GetProcAdress< TrackMatrixNVDelegate >( "glTrackMatrixNV" );
			_VertexAttribPointerNV = GetProcAdress< VertexAttribPointerNVDelegate >( "glVertexAttribPointerNV" );
			_VertexAttrib1dNV = GetProcAdress< VertexAttrib1dNVDelegate >( "glVertexAttrib1dNV" );
			_VertexAttrib1dvNV = GetProcAdress< VertexAttrib1dvNVDelegate >( "glVertexAttrib1dvNV" );
			_VertexAttrib1fNV = GetProcAdress< VertexAttrib1fNVDelegate >( "glVertexAttrib1fNV" );
			_VertexAttrib1fvNV = GetProcAdress< VertexAttrib1fvNVDelegate >( "glVertexAttrib1fvNV" );
			_VertexAttrib1sNV = GetProcAdress< VertexAttrib1sNVDelegate >( "glVertexAttrib1sNV" );
			_VertexAttrib1svNV = GetProcAdress< VertexAttrib1svNVDelegate >( "glVertexAttrib1svNV" );
			_VertexAttrib2dNV = GetProcAdress< VertexAttrib2dNVDelegate >( "glVertexAttrib2dNV" );
			_VertexAttrib2dvNV = GetProcAdress< VertexAttrib2dvNVDelegate >( "glVertexAttrib2dvNV" );
			_VertexAttrib2fNV = GetProcAdress< VertexAttrib2fNVDelegate >( "glVertexAttrib2fNV" );
			_VertexAttrib2fvNV = GetProcAdress< VertexAttrib2fvNVDelegate >( "glVertexAttrib2fvNV" );
			_VertexAttrib2sNV = GetProcAdress< VertexAttrib2sNVDelegate >( "glVertexAttrib2sNV" );
			_VertexAttrib2svNV = GetProcAdress< VertexAttrib2svNVDelegate >( "glVertexAttrib2svNV" );
			_VertexAttrib3dNV = GetProcAdress< VertexAttrib3dNVDelegate >( "glVertexAttrib3dNV" );
			_VertexAttrib3dvNV = GetProcAdress< VertexAttrib3dvNVDelegate >( "glVertexAttrib3dvNV" );
			_VertexAttrib3fNV = GetProcAdress< VertexAttrib3fNVDelegate >( "glVertexAttrib3fNV" );
			_VertexAttrib3fvNV = GetProcAdress< VertexAttrib3fvNVDelegate >( "glVertexAttrib3fvNV" );
			_VertexAttrib3sNV = GetProcAdress< VertexAttrib3sNVDelegate >( "glVertexAttrib3sNV" );
			_VertexAttrib3svNV = GetProcAdress< VertexAttrib3svNVDelegate >( "glVertexAttrib3svNV" );
			_VertexAttrib4dNV = GetProcAdress< VertexAttrib4dNVDelegate >( "glVertexAttrib4dNV" );
			_VertexAttrib4dvNV = GetProcAdress< VertexAttrib4dvNVDelegate >( "glVertexAttrib4dvNV" );
			_VertexAttrib4fNV = GetProcAdress< VertexAttrib4fNVDelegate >( "glVertexAttrib4fNV" );
			_VertexAttrib4fvNV = GetProcAdress< VertexAttrib4fvNVDelegate >( "glVertexAttrib4fvNV" );
			_VertexAttrib4sNV = GetProcAdress< VertexAttrib4sNVDelegate >( "glVertexAttrib4sNV" );
			_VertexAttrib4svNV = GetProcAdress< VertexAttrib4svNVDelegate >( "glVertexAttrib4svNV" );
			_VertexAttrib4ubNV = GetProcAdress< VertexAttrib4ubNVDelegate >( "glVertexAttrib4ubNV" );
			_VertexAttrib4ubvNV = GetProcAdress< VertexAttrib4ubvNVDelegate >( "glVertexAttrib4ubvNV" );
			_VertexAttribs1dvNV = GetProcAdress< VertexAttribs1dvNVDelegate >( "glVertexAttribs1dvNV" );
			_VertexAttribs1fvNV = GetProcAdress< VertexAttribs1fvNVDelegate >( "glVertexAttribs1fvNV" );
			_VertexAttribs1svNV = GetProcAdress< VertexAttribs1svNVDelegate >( "glVertexAttribs1svNV" );
			_VertexAttribs2dvNV = GetProcAdress< VertexAttribs2dvNVDelegate >( "glVertexAttribs2dvNV" );
			_VertexAttribs2fvNV = GetProcAdress< VertexAttribs2fvNVDelegate >( "glVertexAttribs2fvNV" );
			_VertexAttribs2svNV = GetProcAdress< VertexAttribs2svNVDelegate >( "glVertexAttribs2svNV" );
			_VertexAttribs3dvNV = GetProcAdress< VertexAttribs3dvNVDelegate >( "glVertexAttribs3dvNV" );
			_VertexAttribs3fvNV = GetProcAdress< VertexAttribs3fvNVDelegate >( "glVertexAttribs3fvNV" );
			_VertexAttribs3svNV = GetProcAdress< VertexAttribs3svNVDelegate >( "glVertexAttribs3svNV" );
			_VertexAttribs4dvNV = GetProcAdress< VertexAttribs4dvNVDelegate >( "glVertexAttribs4dvNV" );
			_VertexAttribs4fvNV = GetProcAdress< VertexAttribs4fvNVDelegate >( "glVertexAttribs4fvNV" );
			_VertexAttribs4svNV = GetProcAdress< VertexAttribs4svNVDelegate >( "glVertexAttribs4svNV" );
			_VertexAttribs4ubvNV = GetProcAdress< VertexAttribs4ubvNVDelegate >( "glVertexAttribs4ubvNV" );
			
		}
		
	
		public delegate bool AreProgramsResidentNVDelegate( int n, uint[] programs, [Out]bool[] residences ); //  extension method
		private static AreProgramsResidentNVDelegate _AreProgramsResidentNV;
		
		public static  bool AreProgramsResidentNV( int n, uint[] programs, [Out]bool[] residences )
		{
			if (_AreProgramsResidentNV == null) throw new Exception( "Extension method AreProgramsResidentNV not found" );
			return  _AreProgramsResidentNV( n, programs, residences );
		}
		public delegate void BindProgramNVDelegate( uint target, uint id ); //  extension method
		private static BindProgramNVDelegate _BindProgramNV;
		
		public static  void BindProgramNV( uint target, uint id )
		{
			if (_BindProgramNV == null) throw new Exception( "Extension method BindProgramNV not found" );
			 _BindProgramNV( target, id );
		}
		public delegate void DeleteProgramsNVDelegate( int n, uint[] programs ); //  extension method
		private static DeleteProgramsNVDelegate _DeleteProgramsNV;
		
		public static  void DeleteProgramsNV( int n, uint[] programs )
		{
			if (_DeleteProgramsNV == null) throw new Exception( "Extension method DeleteProgramsNV not found" );
			 _DeleteProgramsNV( n, programs );
		}
		public delegate void ExecuteProgramNVDelegate( uint target, uint id, float[] @params ); //  extension method
		private static ExecuteProgramNVDelegate _ExecuteProgramNV;
		
		public static  void ExecuteProgramNV( uint target, uint id, float[] @params )
		{
			if (_ExecuteProgramNV == null) throw new Exception( "Extension method ExecuteProgramNV not found" );
			 _ExecuteProgramNV( target, id, @params );
		}
		public delegate void GenProgramsNVDelegate( int n, [Out]uint[] programs ); //  extension method
		private static GenProgramsNVDelegate _GenProgramsNV;
		
		public static  void GenProgramsNV( int n, [Out]uint[] programs )
		{
			if (_GenProgramsNV == null) throw new Exception( "Extension method GenProgramsNV not found" );
			 _GenProgramsNV( n, programs );
		}
		public delegate void GetProgramParameterdvNVDelegate( uint target, uint index, uint pname, [Out]double[] @params ); //  extension method
		private static GetProgramParameterdvNVDelegate _GetProgramParameterdvNV;
		
		public static  void GetProgramParameterdvNV( uint target, uint index, uint pname, [Out]double[] @params )
		{
			if (_GetProgramParameterdvNV == null) throw new Exception( "Extension method GetProgramParameterdvNV not found" );
			 _GetProgramParameterdvNV( target, index, pname, @params );
		}
		public delegate void GetProgramParameterfvNVDelegate( uint target, uint index, uint pname, [Out]float[] @params ); //  extension method
		private static GetProgramParameterfvNVDelegate _GetProgramParameterfvNV;
		
		public static  void GetProgramParameterfvNV( uint target, uint index, uint pname, [Out]float[] @params )
		{
			if (_GetProgramParameterfvNV == null) throw new Exception( "Extension method GetProgramParameterfvNV not found" );
			 _GetProgramParameterfvNV( target, index, pname, @params );
		}
		public delegate void GetProgramivNVDelegate( uint id, uint pname, [Out]int[] @params ); //  extension method
		private static GetProgramivNVDelegate _GetProgramivNV;
		
		public static  void GetProgramivNV( uint id, uint pname, [Out]int[] @params )
		{
			if (_GetProgramivNV == null) throw new Exception( "Extension method GetProgramivNV not found" );
			 _GetProgramivNV( id, pname, @params );
		}
		public delegate void GetProgramStringNVDelegate( uint id, uint pname, [Out]byte[] program ); //  extension method
		private static GetProgramStringNVDelegate _GetProgramStringNV;
		
		public static  void GetProgramStringNV( uint id, uint pname, [Out]byte[] program )
		{
			if (_GetProgramStringNV == null) throw new Exception( "Extension method GetProgramStringNV not found" );
			 _GetProgramStringNV( id, pname, program );
		}
		public delegate void GetTrackMatrixivNVDelegate( uint target, uint address, uint pname, [Out]int[] @params ); //  extension method
		private static GetTrackMatrixivNVDelegate _GetTrackMatrixivNV;
		
		public static  void GetTrackMatrixivNV( uint target, uint address, uint pname, [Out]int[] @params )
		{
			if (_GetTrackMatrixivNV == null) throw new Exception( "Extension method GetTrackMatrixivNV not found" );
			 _GetTrackMatrixivNV( target, address, pname, @params );
		}
		public delegate void GetVertexAttribdvNVDelegate( uint index, uint pname, [Out]double[] @params ); //  extension method
		private static GetVertexAttribdvNVDelegate _GetVertexAttribdvNV;
		
		public static  void GetVertexAttribdvNV( uint index, uint pname, [Out]double[] @params )
		{
			if (_GetVertexAttribdvNV == null) throw new Exception( "Extension method GetVertexAttribdvNV not found" );
			 _GetVertexAttribdvNV( index, pname, @params );
		}
		public delegate void GetVertexAttribfvNVDelegate( uint index, uint pname, [Out]float[] @params ); //  extension method
		private static GetVertexAttribfvNVDelegate _GetVertexAttribfvNV;
		
		public static  void GetVertexAttribfvNV( uint index, uint pname, [Out]float[] @params )
		{
			if (_GetVertexAttribfvNV == null) throw new Exception( "Extension method GetVertexAttribfvNV not found" );
			 _GetVertexAttribfvNV( index, pname, @params );
		}
		public delegate void GetVertexAttribivNVDelegate( uint index, uint pname, [Out]int[] @params ); //  extension method
		private static GetVertexAttribivNVDelegate _GetVertexAttribivNV;
		
		public static  void GetVertexAttribivNV( uint index, uint pname, [Out]int[] @params )
		{
			if (_GetVertexAttribivNV == null) throw new Exception( "Extension method GetVertexAttribivNV not found" );
			 _GetVertexAttribivNV( index, pname, @params );
		}
		public unsafe delegate void GetVertexAttribPointervNVDelegate( uint index, uint pname, [Out]void** pointer ); //  extension method
		private static GetVertexAttribPointervNVDelegate _GetVertexAttribPointervNV;
		
		public static unsafe  void GetVertexAttribPointervNV( uint index, uint pname, [Out]void** pointer )
		{
			if (_GetVertexAttribPointervNV == null) throw new Exception( "Extension method GetVertexAttribPointervNV not found" );
			 _GetVertexAttribPointervNV( index, pname, pointer );
		}
		public delegate bool IsProgramNVDelegate( uint id ); //  extension method
		private static IsProgramNVDelegate _IsProgramNV;
		
		public static  bool IsProgramNV( uint id )
		{
			if (_IsProgramNV == null) throw new Exception( "Extension method IsProgramNV not found" );
			return  _IsProgramNV( id );
		}
		public delegate void LoadProgramNVDelegate( uint target, uint id, int len, byte[] program ); //  extension method
		private static LoadProgramNVDelegate _LoadProgramNV;
		
		public static  void LoadProgramNV( uint target, uint id, int len, byte[] program )
		{
			if (_LoadProgramNV == null) throw new Exception( "Extension method LoadProgramNV not found" );
			 _LoadProgramNV( target, id, len, program );
		}
		public delegate void ProgramParameter4dNVDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method
		private static ProgramParameter4dNVDelegate _ProgramParameter4dNV;
		
		public static  void ProgramParameter4dNV( uint target, uint index, double x, double y, double z, double w )
		{
			if (_ProgramParameter4dNV == null) throw new Exception( "Extension method ProgramParameter4dNV not found" );
			 _ProgramParameter4dNV( target, index, x, y, z, w );
		}
		public delegate void ProgramParameter4dvNVDelegate( uint target, uint index, double[] v ); //  extension method
		private static ProgramParameter4dvNVDelegate _ProgramParameter4dvNV;
		
		public static  void ProgramParameter4dvNV( uint target, uint index, double[] v )
		{
			if (_ProgramParameter4dvNV == null) throw new Exception( "Extension method ProgramParameter4dvNV not found" );
			 _ProgramParameter4dvNV( target, index, v );
		}
		public delegate void ProgramParameter4fNVDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method
		private static ProgramParameter4fNVDelegate _ProgramParameter4fNV;
		
		public static  void ProgramParameter4fNV( uint target, uint index, float x, float y, float z, float w )
		{
			if (_ProgramParameter4fNV == null) throw new Exception( "Extension method ProgramParameter4fNV not found" );
			 _ProgramParameter4fNV( target, index, x, y, z, w );
		}
		public delegate void ProgramParameter4fvNVDelegate( uint target, uint index, float[] v ); //  extension method
		private static ProgramParameter4fvNVDelegate _ProgramParameter4fvNV;
		
		public static  void ProgramParameter4fvNV( uint target, uint index, float[] v )
		{
			if (_ProgramParameter4fvNV == null) throw new Exception( "Extension method ProgramParameter4fvNV not found" );
			 _ProgramParameter4fvNV( target, index, v );
		}
		public delegate void ProgramParameters4dvNVDelegate( uint target, uint index, uint count, double[] v ); //  extension method
		private static ProgramParameters4dvNVDelegate _ProgramParameters4dvNV;
		
		public static  void ProgramParameters4dvNV( uint target, uint index, uint count, double[] v )
		{
			if (_ProgramParameters4dvNV == null) throw new Exception( "Extension method ProgramParameters4dvNV not found" );
			 _ProgramParameters4dvNV( target, index, count, v );
		}
		public delegate void ProgramParameters4fvNVDelegate( uint target, uint index, uint count, float[] v ); //  extension method
		private static ProgramParameters4fvNVDelegate _ProgramParameters4fvNV;
		
		public static  void ProgramParameters4fvNV( uint target, uint index, uint count, float[] v )
		{
			if (_ProgramParameters4fvNV == null) throw new Exception( "Extension method ProgramParameters4fvNV not found" );
			 _ProgramParameters4fvNV( target, index, count, v );
		}
		public delegate void RequestResidentProgramsNVDelegate( int n, uint[] programs ); //  extension method
		private static RequestResidentProgramsNVDelegate _RequestResidentProgramsNV;
		
		public static  void RequestResidentProgramsNV( int n, uint[] programs )
		{
			if (_RequestResidentProgramsNV == null) throw new Exception( "Extension method RequestResidentProgramsNV not found" );
			 _RequestResidentProgramsNV( n, programs );
		}
		public delegate void TrackMatrixNVDelegate( uint target, uint address, uint matrix, uint transform ); //  extension method
		private static TrackMatrixNVDelegate _TrackMatrixNV;
		
		public static  void TrackMatrixNV( uint target, uint address, uint matrix, uint transform )
		{
			if (_TrackMatrixNV == null) throw new Exception( "Extension method TrackMatrixNV not found" );
			 _TrackMatrixNV( target, address, matrix, transform );
		}
		public unsafe delegate void VertexAttribPointerNVDelegate( uint index, int fsize, uint type, int stride, void* pointer ); //  extension method
		private static VertexAttribPointerNVDelegate _VertexAttribPointerNV;
		
		public static unsafe  void VertexAttribPointerNV( uint index, int fsize, uint type, int stride, void* pointer )
		{
			if (_VertexAttribPointerNV == null) throw new Exception( "Extension method VertexAttribPointerNV not found" );
			 _VertexAttribPointerNV( index, fsize, type, stride, pointer );
		}
		public delegate void VertexAttrib1dNVDelegate( uint index, double x ); //  extension method
		private static VertexAttrib1dNVDelegate _VertexAttrib1dNV;
		
		public static  void VertexAttrib1dNV( uint index, double x )
		{
			if (_VertexAttrib1dNV == null) throw new Exception( "Extension method VertexAttrib1dNV not found" );
			 _VertexAttrib1dNV( index, x );
		}
		public delegate void VertexAttrib1dvNVDelegate( uint index, double[] v ); //  extension method
		private static VertexAttrib1dvNVDelegate _VertexAttrib1dvNV;
		
		public static  void VertexAttrib1dvNV( uint index, double[] v )
		{
			if (_VertexAttrib1dvNV == null) throw new Exception( "Extension method VertexAttrib1dvNV not found" );
			 _VertexAttrib1dvNV( index, v );
		}
		public delegate void VertexAttrib1fNVDelegate( uint index, float x ); //  extension method
		private static VertexAttrib1fNVDelegate _VertexAttrib1fNV;
		
		public static  void VertexAttrib1fNV( uint index, float x )
		{
			if (_VertexAttrib1fNV == null) throw new Exception( "Extension method VertexAttrib1fNV not found" );
			 _VertexAttrib1fNV( index, x );
		}
		public delegate void VertexAttrib1fvNVDelegate( uint index, float[] v ); //  extension method
		private static VertexAttrib1fvNVDelegate _VertexAttrib1fvNV;
		
		public static  void VertexAttrib1fvNV( uint index, float[] v )
		{
			if (_VertexAttrib1fvNV == null) throw new Exception( "Extension method VertexAttrib1fvNV not found" );
			 _VertexAttrib1fvNV( index, v );
		}
		public delegate void VertexAttrib1sNVDelegate( uint index, short x ); //  extension method
		private static VertexAttrib1sNVDelegate _VertexAttrib1sNV;
		
		public static  void VertexAttrib1sNV( uint index, short x )
		{
			if (_VertexAttrib1sNV == null) throw new Exception( "Extension method VertexAttrib1sNV not found" );
			 _VertexAttrib1sNV( index, x );
		}
		public delegate void VertexAttrib1svNVDelegate( uint index, short[] v ); //  extension method
		private static VertexAttrib1svNVDelegate _VertexAttrib1svNV;
		
		public static  void VertexAttrib1svNV( uint index, short[] v )
		{
			if (_VertexAttrib1svNV == null) throw new Exception( "Extension method VertexAttrib1svNV not found" );
			 _VertexAttrib1svNV( index, v );
		}
		public delegate void VertexAttrib2dNVDelegate( uint index, double x, double y ); //  extension method
		private static VertexAttrib2dNVDelegate _VertexAttrib2dNV;
		
		public static  void VertexAttrib2dNV( uint index, double x, double y )
		{
			if (_VertexAttrib2dNV == null) throw new Exception( "Extension method VertexAttrib2dNV not found" );
			 _VertexAttrib2dNV( index, x, y );
		}
		public delegate void VertexAttrib2dvNVDelegate( uint index, double[] v ); //  extension method
		private static VertexAttrib2dvNVDelegate _VertexAttrib2dvNV;
		
		public static  void VertexAttrib2dvNV( uint index, double[] v )
		{
			if (_VertexAttrib2dvNV == null) throw new Exception( "Extension method VertexAttrib2dvNV not found" );
			 _VertexAttrib2dvNV( index, v );
		}
		public delegate void VertexAttrib2fNVDelegate( uint index, float x, float y ); //  extension method
		private static VertexAttrib2fNVDelegate _VertexAttrib2fNV;
		
		public static  void VertexAttrib2fNV( uint index, float x, float y )
		{
			if (_VertexAttrib2fNV == null) throw new Exception( "Extension method VertexAttrib2fNV not found" );
			 _VertexAttrib2fNV( index, x, y );
		}
		public delegate void VertexAttrib2fvNVDelegate( uint index, float[] v ); //  extension method
		private static VertexAttrib2fvNVDelegate _VertexAttrib2fvNV;
		
		public static  void VertexAttrib2fvNV( uint index, float[] v )
		{
			if (_VertexAttrib2fvNV == null) throw new Exception( "Extension method VertexAttrib2fvNV not found" );
			 _VertexAttrib2fvNV( index, v );
		}
		public delegate void VertexAttrib2sNVDelegate( uint index, short x, short y ); //  extension method
		private static VertexAttrib2sNVDelegate _VertexAttrib2sNV;
		
		public static  void VertexAttrib2sNV( uint index, short x, short y )
		{
			if (_VertexAttrib2sNV == null) throw new Exception( "Extension method VertexAttrib2sNV not found" );
			 _VertexAttrib2sNV( index, x, y );
		}
		public delegate void VertexAttrib2svNVDelegate( uint index, short[] v ); //  extension method
		private static VertexAttrib2svNVDelegate _VertexAttrib2svNV;
		
		public static  void VertexAttrib2svNV( uint index, short[] v )
		{
			if (_VertexAttrib2svNV == null) throw new Exception( "Extension method VertexAttrib2svNV not found" );
			 _VertexAttrib2svNV( index, v );
		}
		public delegate void VertexAttrib3dNVDelegate( uint index, double x, double y, double z ); //  extension method
		private static VertexAttrib3dNVDelegate _VertexAttrib3dNV;
		
		public static  void VertexAttrib3dNV( uint index, double x, double y, double z )
		{
			if (_VertexAttrib3dNV == null) throw new Exception( "Extension method VertexAttrib3dNV not found" );
			 _VertexAttrib3dNV( index, x, y, z );
		}
		public delegate void VertexAttrib3dvNVDelegate( uint index, double[] v ); //  extension method
		private static VertexAttrib3dvNVDelegate _VertexAttrib3dvNV;
		
		public static  void VertexAttrib3dvNV( uint index, double[] v )
		{
			if (_VertexAttrib3dvNV == null) throw new Exception( "Extension method VertexAttrib3dvNV not found" );
			 _VertexAttrib3dvNV( index, v );
		}
		public delegate void VertexAttrib3fNVDelegate( uint index, float x, float y, float z ); //  extension method
		private static VertexAttrib3fNVDelegate _VertexAttrib3fNV;
		
		public static  void VertexAttrib3fNV( uint index, float x, float y, float z )
		{
			if (_VertexAttrib3fNV == null) throw new Exception( "Extension method VertexAttrib3fNV not found" );
			 _VertexAttrib3fNV( index, x, y, z );
		}
		public delegate void VertexAttrib3fvNVDelegate( uint index, float[] v ); //  extension method
		private static VertexAttrib3fvNVDelegate _VertexAttrib3fvNV;
		
		public static  void VertexAttrib3fvNV( uint index, float[] v )
		{
			if (_VertexAttrib3fvNV == null) throw new Exception( "Extension method VertexAttrib3fvNV not found" );
			 _VertexAttrib3fvNV( index, v );
		}
		public delegate void VertexAttrib3sNVDelegate( uint index, short x, short y, short z ); //  extension method
		private static VertexAttrib3sNVDelegate _VertexAttrib3sNV;
		
		public static  void VertexAttrib3sNV( uint index, short x, short y, short z )
		{
			if (_VertexAttrib3sNV == null) throw new Exception( "Extension method VertexAttrib3sNV not found" );
			 _VertexAttrib3sNV( index, x, y, z );
		}
		public delegate void VertexAttrib3svNVDelegate( uint index, short[] v ); //  extension method
		private static VertexAttrib3svNVDelegate _VertexAttrib3svNV;
		
		public static  void VertexAttrib3svNV( uint index, short[] v )
		{
			if (_VertexAttrib3svNV == null) throw new Exception( "Extension method VertexAttrib3svNV not found" );
			 _VertexAttrib3svNV( index, v );
		}
		public delegate void VertexAttrib4dNVDelegate( uint index, double x, double y, double z, double w ); //  extension method
		private static VertexAttrib4dNVDelegate _VertexAttrib4dNV;
		
		public static  void VertexAttrib4dNV( uint index, double x, double y, double z, double w )
		{
			if (_VertexAttrib4dNV == null) throw new Exception( "Extension method VertexAttrib4dNV not found" );
			 _VertexAttrib4dNV( index, x, y, z, w );
		}
		public delegate void VertexAttrib4dvNVDelegate( uint index, double[] v ); //  extension method
		private static VertexAttrib4dvNVDelegate _VertexAttrib4dvNV;
		
		public static  void VertexAttrib4dvNV( uint index, double[] v )
		{
			if (_VertexAttrib4dvNV == null) throw new Exception( "Extension method VertexAttrib4dvNV not found" );
			 _VertexAttrib4dvNV( index, v );
		}
		public delegate void VertexAttrib4fNVDelegate( uint index, float x, float y, float z, float w ); //  extension method
		private static VertexAttrib4fNVDelegate _VertexAttrib4fNV;
		
		public static  void VertexAttrib4fNV( uint index, float x, float y, float z, float w )
		{
			if (_VertexAttrib4fNV == null) throw new Exception( "Extension method VertexAttrib4fNV not found" );
			 _VertexAttrib4fNV( index, x, y, z, w );
		}
		public delegate void VertexAttrib4fvNVDelegate( uint index, float[] v ); //  extension method
		private static VertexAttrib4fvNVDelegate _VertexAttrib4fvNV;
		
		public static  void VertexAttrib4fvNV( uint index, float[] v )
		{
			if (_VertexAttrib4fvNV == null) throw new Exception( "Extension method VertexAttrib4fvNV not found" );
			 _VertexAttrib4fvNV( index, v );
		}
		public delegate void VertexAttrib4sNVDelegate( uint index, short x, short y, short z, short w ); //  extension method
		private static VertexAttrib4sNVDelegate _VertexAttrib4sNV;
		
		public static  void VertexAttrib4sNV( uint index, short x, short y, short z, short w )
		{
			if (_VertexAttrib4sNV == null) throw new Exception( "Extension method VertexAttrib4sNV not found" );
			 _VertexAttrib4sNV( index, x, y, z, w );
		}
		public delegate void VertexAttrib4svNVDelegate( uint index, short[] v ); //  extension method
		private static VertexAttrib4svNVDelegate _VertexAttrib4svNV;
		
		public static  void VertexAttrib4svNV( uint index, short[] v )
		{
			if (_VertexAttrib4svNV == null) throw new Exception( "Extension method VertexAttrib4svNV not found" );
			 _VertexAttrib4svNV( index, v );
		}
		public delegate void VertexAttrib4ubNVDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method
		private static VertexAttrib4ubNVDelegate _VertexAttrib4ubNV;
		
		public static  void VertexAttrib4ubNV( uint index, byte x, byte y, byte z, byte w )
		{
			if (_VertexAttrib4ubNV == null) throw new Exception( "Extension method VertexAttrib4ubNV not found" );
			 _VertexAttrib4ubNV( index, x, y, z, w );
		}
		public delegate void VertexAttrib4ubvNVDelegate( uint index, byte[] v ); //  extension method
		private static VertexAttrib4ubvNVDelegate _VertexAttrib4ubvNV;
		
		public static  void VertexAttrib4ubvNV( uint index, byte[] v )
		{
			if (_VertexAttrib4ubvNV == null) throw new Exception( "Extension method VertexAttrib4ubvNV not found" );
			 _VertexAttrib4ubvNV( index, v );
		}
		public delegate void VertexAttribs1dvNVDelegate( uint index, int count, double[] v ); //  extension method
		private static VertexAttribs1dvNVDelegate _VertexAttribs1dvNV;
		
		public static  void VertexAttribs1dvNV( uint index, int count, double[] v )
		{
			if (_VertexAttribs1dvNV == null) throw new Exception( "Extension method VertexAttribs1dvNV not found" );
			 _VertexAttribs1dvNV( index, count, v );
		}
		public delegate void VertexAttribs1fvNVDelegate( uint index, int count, float[] v ); //  extension method
		private static VertexAttribs1fvNVDelegate _VertexAttribs1fvNV;
		
		public static  void VertexAttribs1fvNV( uint index, int count, float[] v )
		{
			if (_VertexAttribs1fvNV == null) throw new Exception( "Extension method VertexAttribs1fvNV not found" );
			 _VertexAttribs1fvNV( index, count, v );
		}
		public delegate void VertexAttribs1svNVDelegate( uint index, int count, short[] v ); //  extension method
		private static VertexAttribs1svNVDelegate _VertexAttribs1svNV;
		
		public static  void VertexAttribs1svNV( uint index, int count, short[] v )
		{
			if (_VertexAttribs1svNV == null) throw new Exception( "Extension method VertexAttribs1svNV not found" );
			 _VertexAttribs1svNV( index, count, v );
		}
		public delegate void VertexAttribs2dvNVDelegate( uint index, int count, double[] v ); //  extension method
		private static VertexAttribs2dvNVDelegate _VertexAttribs2dvNV;
		
		public static  void VertexAttribs2dvNV( uint index, int count, double[] v )
		{
			if (_VertexAttribs2dvNV == null) throw new Exception( "Extension method VertexAttribs2dvNV not found" );
			 _VertexAttribs2dvNV( index, count, v );
		}
		public delegate void VertexAttribs2fvNVDelegate( uint index, int count, float[] v ); //  extension method
		private static VertexAttribs2fvNVDelegate _VertexAttribs2fvNV;
		
		public static  void VertexAttribs2fvNV( uint index, int count, float[] v )
		{
			if (_VertexAttribs2fvNV == null) throw new Exception( "Extension method VertexAttribs2fvNV not found" );
			 _VertexAttribs2fvNV( index, count, v );
		}
		public delegate void VertexAttribs2svNVDelegate( uint index, int count, short[] v ); //  extension method
		private static VertexAttribs2svNVDelegate _VertexAttribs2svNV;
		
		public static  void VertexAttribs2svNV( uint index, int count, short[] v )
		{
			if (_VertexAttribs2svNV == null) throw new Exception( "Extension method VertexAttribs2svNV not found" );
			 _VertexAttribs2svNV( index, count, v );
		}
		public delegate void VertexAttribs3dvNVDelegate( uint index, int count, double[] v ); //  extension method
		private static VertexAttribs3dvNVDelegate _VertexAttribs3dvNV;
		
		public static  void VertexAttribs3dvNV( uint index, int count, double[] v )
		{
			if (_VertexAttribs3dvNV == null) throw new Exception( "Extension method VertexAttribs3dvNV not found" );
			 _VertexAttribs3dvNV( index, count, v );
		}
		public delegate void VertexAttribs3fvNVDelegate( uint index, int count, float[] v ); //  extension method
		private static VertexAttribs3fvNVDelegate _VertexAttribs3fvNV;
		
		public static  void VertexAttribs3fvNV( uint index, int count, float[] v )
		{
			if (_VertexAttribs3fvNV == null) throw new Exception( "Extension method VertexAttribs3fvNV not found" );
			 _VertexAttribs3fvNV( index, count, v );
		}
		public delegate void VertexAttribs3svNVDelegate( uint index, int count, short[] v ); //  extension method
		private static VertexAttribs3svNVDelegate _VertexAttribs3svNV;
		
		public static  void VertexAttribs3svNV( uint index, int count, short[] v )
		{
			if (_VertexAttribs3svNV == null) throw new Exception( "Extension method VertexAttribs3svNV not found" );
			 _VertexAttribs3svNV( index, count, v );
		}
		public delegate void VertexAttribs4dvNVDelegate( uint index, int count, double[] v ); //  extension method
		private static VertexAttribs4dvNVDelegate _VertexAttribs4dvNV;
		
		public static  void VertexAttribs4dvNV( uint index, int count, double[] v )
		{
			if (_VertexAttribs4dvNV == null) throw new Exception( "Extension method VertexAttribs4dvNV not found" );
			 _VertexAttribs4dvNV( index, count, v );
		}
		public delegate void VertexAttribs4fvNVDelegate( uint index, int count, float[] v ); //  extension method
		private static VertexAttribs4fvNVDelegate _VertexAttribs4fvNV;
		
		public static  void VertexAttribs4fvNV( uint index, int count, float[] v )
		{
			if (_VertexAttribs4fvNV == null) throw new Exception( "Extension method VertexAttribs4fvNV not found" );
			 _VertexAttribs4fvNV( index, count, v );
		}
		public delegate void VertexAttribs4svNVDelegate( uint index, int count, short[] v ); //  extension method
		private static VertexAttribs4svNVDelegate _VertexAttribs4svNV;
		
		public static  void VertexAttribs4svNV( uint index, int count, short[] v )
		{
			if (_VertexAttribs4svNV == null) throw new Exception( "Extension method VertexAttribs4svNV not found" );
			 _VertexAttribs4svNV( index, count, v );
		}
		public delegate void VertexAttribs4ubvNVDelegate( uint index, int count, byte[] v ); //  extension method
		private static VertexAttribs4ubvNVDelegate _VertexAttribs4ubvNV;
		
		public static  void VertexAttribs4ubvNV( uint index, int count, byte[] v )
		{
			if (_VertexAttribs4ubvNV == null) throw new Exception( "Extension method VertexAttribs4ubvNV not found" );
			 _VertexAttribs4ubvNV( index, count, v );
		}
	}
}

