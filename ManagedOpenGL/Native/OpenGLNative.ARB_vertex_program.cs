using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeARB_vertex_programInit()
		{
			_VertexAttrib1dARB = GetProcAdress< VertexAttrib1dARBDelegate >( "glVertexAttrib1dARB" );
			_VertexAttrib1dvARB = GetProcAdress< VertexAttrib1dvARBDelegate >( "glVertexAttrib1dvARB" );
			_VertexAttrib1fARB = GetProcAdress< VertexAttrib1fARBDelegate >( "glVertexAttrib1fARB" );
			_VertexAttrib1fvARB = GetProcAdress< VertexAttrib1fvARBDelegate >( "glVertexAttrib1fvARB" );
			_VertexAttrib1sARB = GetProcAdress< VertexAttrib1sARBDelegate >( "glVertexAttrib1sARB" );
			_VertexAttrib1svARB = GetProcAdress< VertexAttrib1svARBDelegate >( "glVertexAttrib1svARB" );
			_VertexAttrib2dARB = GetProcAdress< VertexAttrib2dARBDelegate >( "glVertexAttrib2dARB" );
			_VertexAttrib2dvARB = GetProcAdress< VertexAttrib2dvARBDelegate >( "glVertexAttrib2dvARB" );
			_VertexAttrib2fARB = GetProcAdress< VertexAttrib2fARBDelegate >( "glVertexAttrib2fARB" );
			_VertexAttrib2fvARB = GetProcAdress< VertexAttrib2fvARBDelegate >( "glVertexAttrib2fvARB" );
			_VertexAttrib2sARB = GetProcAdress< VertexAttrib2sARBDelegate >( "glVertexAttrib2sARB" );
			_VertexAttrib2svARB = GetProcAdress< VertexAttrib2svARBDelegate >( "glVertexAttrib2svARB" );
			_VertexAttrib3dARB = GetProcAdress< VertexAttrib3dARBDelegate >( "glVertexAttrib3dARB" );
			_VertexAttrib3dvARB = GetProcAdress< VertexAttrib3dvARBDelegate >( "glVertexAttrib3dvARB" );
			_VertexAttrib3fARB = GetProcAdress< VertexAttrib3fARBDelegate >( "glVertexAttrib3fARB" );
			_VertexAttrib3fvARB = GetProcAdress< VertexAttrib3fvARBDelegate >( "glVertexAttrib3fvARB" );
			_VertexAttrib3sARB = GetProcAdress< VertexAttrib3sARBDelegate >( "glVertexAttrib3sARB" );
			_VertexAttrib3svARB = GetProcAdress< VertexAttrib3svARBDelegate >( "glVertexAttrib3svARB" );
			_VertexAttrib4NbvARB = GetProcAdress< VertexAttrib4NbvARBDelegate >( "glVertexAttrib4NbvARB" );
			_VertexAttrib4NivARB = GetProcAdress< VertexAttrib4NivARBDelegate >( "glVertexAttrib4NivARB" );
			_VertexAttrib4NsvARB = GetProcAdress< VertexAttrib4NsvARBDelegate >( "glVertexAttrib4NsvARB" );
			_VertexAttrib4NubARB = GetProcAdress< VertexAttrib4NubARBDelegate >( "glVertexAttrib4NubARB" );
			_VertexAttrib4NubvARB = GetProcAdress< VertexAttrib4NubvARBDelegate >( "glVertexAttrib4NubvARB" );
			_VertexAttrib4NuivARB = GetProcAdress< VertexAttrib4NuivARBDelegate >( "glVertexAttrib4NuivARB" );
			_VertexAttrib4NusvARB = GetProcAdress< VertexAttrib4NusvARBDelegate >( "glVertexAttrib4NusvARB" );
			_VertexAttrib4bvARB = GetProcAdress< VertexAttrib4bvARBDelegate >( "glVertexAttrib4bvARB" );
			_VertexAttrib4dARB = GetProcAdress< VertexAttrib4dARBDelegate >( "glVertexAttrib4dARB" );
			_VertexAttrib4dvARB = GetProcAdress< VertexAttrib4dvARBDelegate >( "glVertexAttrib4dvARB" );
			_VertexAttrib4fARB = GetProcAdress< VertexAttrib4fARBDelegate >( "glVertexAttrib4fARB" );
			_VertexAttrib4fvARB = GetProcAdress< VertexAttrib4fvARBDelegate >( "glVertexAttrib4fvARB" );
			_VertexAttrib4ivARB = GetProcAdress< VertexAttrib4ivARBDelegate >( "glVertexAttrib4ivARB" );
			_VertexAttrib4sARB = GetProcAdress< VertexAttrib4sARBDelegate >( "glVertexAttrib4sARB" );
			_VertexAttrib4svARB = GetProcAdress< VertexAttrib4svARBDelegate >( "glVertexAttrib4svARB" );
			_VertexAttrib4ubvARB = GetProcAdress< VertexAttrib4ubvARBDelegate >( "glVertexAttrib4ubvARB" );
			_VertexAttrib4uivARB = GetProcAdress< VertexAttrib4uivARBDelegate >( "glVertexAttrib4uivARB" );
			_VertexAttrib4usvARB = GetProcAdress< VertexAttrib4usvARBDelegate >( "glVertexAttrib4usvARB" );
			_VertexAttribPointerARB = GetProcAdress< VertexAttribPointerARBDelegate >( "glVertexAttribPointerARB" );
			_EnableVertexAttribArrayARB = GetProcAdress< EnableVertexAttribArrayARBDelegate >( "glEnableVertexAttribArrayARB" );
			_DisableVertexAttribArrayARB = GetProcAdress< DisableVertexAttribArrayARBDelegate >( "glDisableVertexAttribArrayARB" );
			_ProgramStringARB = GetProcAdress< ProgramStringARBDelegate >( "glProgramStringARB" );
			_BindProgramARB = GetProcAdress< BindProgramARBDelegate >( "glBindProgramARB" );
			_DeleteProgramsARB = GetProcAdress< DeleteProgramsARBDelegate >( "glDeleteProgramsARB" );
			_GenProgramsARB = GetProcAdress< GenProgramsARBDelegate >( "glGenProgramsARB" );
			_ProgramEnvParameter4dARB = GetProcAdress< ProgramEnvParameter4dARBDelegate >( "glProgramEnvParameter4dARB" );
			_ProgramEnvParameter4dvARB = GetProcAdress< ProgramEnvParameter4dvARBDelegate >( "glProgramEnvParameter4dvARB" );
			_ProgramEnvParameter4fARB = GetProcAdress< ProgramEnvParameter4fARBDelegate >( "glProgramEnvParameter4fARB" );
			_ProgramEnvParameter4fvARB = GetProcAdress< ProgramEnvParameter4fvARBDelegate >( "glProgramEnvParameter4fvARB" );
			_ProgramLocalParameter4dARB = GetProcAdress< ProgramLocalParameter4dARBDelegate >( "glProgramLocalParameter4dARB" );
			_ProgramLocalParameter4dvARB = GetProcAdress< ProgramLocalParameter4dvARBDelegate >( "glProgramLocalParameter4dvARB" );
			_ProgramLocalParameter4fARB = GetProcAdress< ProgramLocalParameter4fARBDelegate >( "glProgramLocalParameter4fARB" );
			_ProgramLocalParameter4fvARB = GetProcAdress< ProgramLocalParameter4fvARBDelegate >( "glProgramLocalParameter4fvARB" );
			_GetProgramEnvParameterdvARB = GetProcAdress< GetProgramEnvParameterdvARBDelegate >( "glGetProgramEnvParameterdvARB" );
			_GetProgramEnvParameterfvARB = GetProcAdress< GetProgramEnvParameterfvARBDelegate >( "glGetProgramEnvParameterfvARB" );
			_GetProgramLocalParameterdvARB = GetProcAdress< GetProgramLocalParameterdvARBDelegate >( "glGetProgramLocalParameterdvARB" );
			_GetProgramLocalParameterfvARB = GetProcAdress< GetProgramLocalParameterfvARBDelegate >( "glGetProgramLocalParameterfvARB" );
			_GetProgramivARB = GetProcAdress< GetProgramivARBDelegate >( "glGetProgramivARB" );
			_GetProgramStringARB = GetProcAdress< GetProgramStringARBDelegate >( "glGetProgramStringARB" );
			_GetVertexAttribdvARB = GetProcAdress< GetVertexAttribdvARBDelegate >( "glGetVertexAttribdvARB" );
			_GetVertexAttribfvARB = GetProcAdress< GetVertexAttribfvARBDelegate >( "glGetVertexAttribfvARB" );
			_GetVertexAttribivARB = GetProcAdress< GetVertexAttribivARBDelegate >( "glGetVertexAttribivARB" );
			_GetVertexAttribPointervARB = GetProcAdress< GetVertexAttribPointervARBDelegate >( "glGetVertexAttribPointervARB" );
			_IsProgramARB = GetProcAdress< IsProgramARBDelegate >( "glIsProgramARB" );
		}


		public delegate void VertexAttrib1dARBDelegate( uint index, double x ); //  extension method

		private static VertexAttrib1dARBDelegate _VertexAttrib1dARB;

		public static  void VertexAttrib1dARB( uint index, double x )
		{
			if (_VertexAttrib1dARB == null) throw new Exception( "Extension method VertexAttrib1dARB not found" );
		 _VertexAttrib1dARB( index, x );
		}
		public delegate void VertexAttrib1dvARBDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib1dvARBDelegate _VertexAttrib1dvARB;

		public static  void VertexAttrib1dvARB( uint index, double[] v )
		{
			if (_VertexAttrib1dvARB == null) throw new Exception( "Extension method VertexAttrib1dvARB not found" );
		 _VertexAttrib1dvARB( index, v );
		}
		public delegate void VertexAttrib1fARBDelegate( uint index, float x ); //  extension method

		private static VertexAttrib1fARBDelegate _VertexAttrib1fARB;

		public static  void VertexAttrib1fARB( uint index, float x )
		{
			if (_VertexAttrib1fARB == null) throw new Exception( "Extension method VertexAttrib1fARB not found" );
		 _VertexAttrib1fARB( index, x );
		}
		public delegate void VertexAttrib1fvARBDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib1fvARBDelegate _VertexAttrib1fvARB;

		public static  void VertexAttrib1fvARB( uint index, float[] v )
		{
			if (_VertexAttrib1fvARB == null) throw new Exception( "Extension method VertexAttrib1fvARB not found" );
		 _VertexAttrib1fvARB( index, v );
		}
		public delegate void VertexAttrib1sARBDelegate( uint index, short x ); //  extension method

		private static VertexAttrib1sARBDelegate _VertexAttrib1sARB;

		public static  void VertexAttrib1sARB( uint index, short x )
		{
			if (_VertexAttrib1sARB == null) throw new Exception( "Extension method VertexAttrib1sARB not found" );
		 _VertexAttrib1sARB( index, x );
		}
		public delegate void VertexAttrib1svARBDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib1svARBDelegate _VertexAttrib1svARB;

		public static  void VertexAttrib1svARB( uint index, short[] v )
		{
			if (_VertexAttrib1svARB == null) throw new Exception( "Extension method VertexAttrib1svARB not found" );
		 _VertexAttrib1svARB( index, v );
		}
		public delegate void VertexAttrib2dARBDelegate( uint index, double x, double y ); //  extension method

		private static VertexAttrib2dARBDelegate _VertexAttrib2dARB;

		public static  void VertexAttrib2dARB( uint index, double x, double y )
		{
			if (_VertexAttrib2dARB == null) throw new Exception( "Extension method VertexAttrib2dARB not found" );
		 _VertexAttrib2dARB( index, x, y );
		}
		public delegate void VertexAttrib2dvARBDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib2dvARBDelegate _VertexAttrib2dvARB;

		public static  void VertexAttrib2dvARB( uint index, double[] v )
		{
			if (_VertexAttrib2dvARB == null) throw new Exception( "Extension method VertexAttrib2dvARB not found" );
		 _VertexAttrib2dvARB( index, v );
		}
		public delegate void VertexAttrib2fARBDelegate( uint index, float x, float y ); //  extension method

		private static VertexAttrib2fARBDelegate _VertexAttrib2fARB;

		public static  void VertexAttrib2fARB( uint index, float x, float y )
		{
			if (_VertexAttrib2fARB == null) throw new Exception( "Extension method VertexAttrib2fARB not found" );
		 _VertexAttrib2fARB( index, x, y );
		}
		public delegate void VertexAttrib2fvARBDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib2fvARBDelegate _VertexAttrib2fvARB;

		public static  void VertexAttrib2fvARB( uint index, float[] v )
		{
			if (_VertexAttrib2fvARB == null) throw new Exception( "Extension method VertexAttrib2fvARB not found" );
		 _VertexAttrib2fvARB( index, v );
		}
		public delegate void VertexAttrib2sARBDelegate( uint index, short x, short y ); //  extension method

		private static VertexAttrib2sARBDelegate _VertexAttrib2sARB;

		public static  void VertexAttrib2sARB( uint index, short x, short y )
		{
			if (_VertexAttrib2sARB == null) throw new Exception( "Extension method VertexAttrib2sARB not found" );
		 _VertexAttrib2sARB( index, x, y );
		}
		public delegate void VertexAttrib2svARBDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib2svARBDelegate _VertexAttrib2svARB;

		public static  void VertexAttrib2svARB( uint index, short[] v )
		{
			if (_VertexAttrib2svARB == null) throw new Exception( "Extension method VertexAttrib2svARB not found" );
		 _VertexAttrib2svARB( index, v );
		}
		public delegate void VertexAttrib3dARBDelegate( uint index, double x, double y, double z ); //  extension method

		private static VertexAttrib3dARBDelegate _VertexAttrib3dARB;

		public static  void VertexAttrib3dARB( uint index, double x, double y, double z )
		{
			if (_VertexAttrib3dARB == null) throw new Exception( "Extension method VertexAttrib3dARB not found" );
		 _VertexAttrib3dARB( index, x, y, z );
		}
		public delegate void VertexAttrib3dvARBDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib3dvARBDelegate _VertexAttrib3dvARB;

		public static  void VertexAttrib3dvARB( uint index, double[] v )
		{
			if (_VertexAttrib3dvARB == null) throw new Exception( "Extension method VertexAttrib3dvARB not found" );
		 _VertexAttrib3dvARB( index, v );
		}
		public delegate void VertexAttrib3fARBDelegate( uint index, float x, float y, float z ); //  extension method

		private static VertexAttrib3fARBDelegate _VertexAttrib3fARB;

		public static  void VertexAttrib3fARB( uint index, float x, float y, float z )
		{
			if (_VertexAttrib3fARB == null) throw new Exception( "Extension method VertexAttrib3fARB not found" );
		 _VertexAttrib3fARB( index, x, y, z );
		}
		public delegate void VertexAttrib3fvARBDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib3fvARBDelegate _VertexAttrib3fvARB;

		public static  void VertexAttrib3fvARB( uint index, float[] v )
		{
			if (_VertexAttrib3fvARB == null) throw new Exception( "Extension method VertexAttrib3fvARB not found" );
		 _VertexAttrib3fvARB( index, v );
		}
		public delegate void VertexAttrib3sARBDelegate( uint index, short x, short y, short z ); //  extension method

		private static VertexAttrib3sARBDelegate _VertexAttrib3sARB;

		public static  void VertexAttrib3sARB( uint index, short x, short y, short z )
		{
			if (_VertexAttrib3sARB == null) throw new Exception( "Extension method VertexAttrib3sARB not found" );
		 _VertexAttrib3sARB( index, x, y, z );
		}
		public delegate void VertexAttrib3svARBDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib3svARBDelegate _VertexAttrib3svARB;

		public static  void VertexAttrib3svARB( uint index, short[] v )
		{
			if (_VertexAttrib3svARB == null) throw new Exception( "Extension method VertexAttrib3svARB not found" );
		 _VertexAttrib3svARB( index, v );
		}
		public delegate void VertexAttrib4NbvARBDelegate( uint index, sbyte[] v ); //  extension method

		private static VertexAttrib4NbvARBDelegate _VertexAttrib4NbvARB;

		public static  void VertexAttrib4NbvARB( uint index, sbyte[] v )
		{
			if (_VertexAttrib4NbvARB == null) throw new Exception( "Extension method VertexAttrib4NbvARB not found" );
		 _VertexAttrib4NbvARB( index, v );
		}
		public delegate void VertexAttrib4NivARBDelegate( uint index, int[] v ); //  extension method

		private static VertexAttrib4NivARBDelegate _VertexAttrib4NivARB;

		public static  void VertexAttrib4NivARB( uint index, int[] v )
		{
			if (_VertexAttrib4NivARB == null) throw new Exception( "Extension method VertexAttrib4NivARB not found" );
		 _VertexAttrib4NivARB( index, v );
		}
		public delegate void VertexAttrib4NsvARBDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib4NsvARBDelegate _VertexAttrib4NsvARB;

		public static  void VertexAttrib4NsvARB( uint index, short[] v )
		{
			if (_VertexAttrib4NsvARB == null) throw new Exception( "Extension method VertexAttrib4NsvARB not found" );
		 _VertexAttrib4NsvARB( index, v );
		}
		public delegate void VertexAttrib4NubARBDelegate( uint index, byte x, byte y, byte z, byte w ); //  extension method

		private static VertexAttrib4NubARBDelegate _VertexAttrib4NubARB;

		public static  void VertexAttrib4NubARB( uint index, byte x, byte y, byte z, byte w )
		{
			if (_VertexAttrib4NubARB == null) throw new Exception( "Extension method VertexAttrib4NubARB not found" );
		 _VertexAttrib4NubARB( index, x, y, z, w );
		}
		public delegate void VertexAttrib4NubvARBDelegate( uint index, byte[] v ); //  extension method

		private static VertexAttrib4NubvARBDelegate _VertexAttrib4NubvARB;

		public static  void VertexAttrib4NubvARB( uint index, byte[] v )
		{
			if (_VertexAttrib4NubvARB == null) throw new Exception( "Extension method VertexAttrib4NubvARB not found" );
		 _VertexAttrib4NubvARB( index, v );
		}
		public delegate void VertexAttrib4NuivARBDelegate( uint index, uint[] v ); //  extension method

		private static VertexAttrib4NuivARBDelegate _VertexAttrib4NuivARB;

		public static  void VertexAttrib4NuivARB( uint index, uint[] v )
		{
			if (_VertexAttrib4NuivARB == null) throw new Exception( "Extension method VertexAttrib4NuivARB not found" );
		 _VertexAttrib4NuivARB( index, v );
		}
		public delegate void VertexAttrib4NusvARBDelegate( uint index, ushort[] v ); //  extension method

		private static VertexAttrib4NusvARBDelegate _VertexAttrib4NusvARB;

		public static  void VertexAttrib4NusvARB( uint index, ushort[] v )
		{
			if (_VertexAttrib4NusvARB == null) throw new Exception( "Extension method VertexAttrib4NusvARB not found" );
		 _VertexAttrib4NusvARB( index, v );
		}
		public delegate void VertexAttrib4bvARBDelegate( uint index, sbyte[] v ); //  extension method

		private static VertexAttrib4bvARBDelegate _VertexAttrib4bvARB;

		public static  void VertexAttrib4bvARB( uint index, sbyte[] v )
		{
			if (_VertexAttrib4bvARB == null) throw new Exception( "Extension method VertexAttrib4bvARB not found" );
		 _VertexAttrib4bvARB( index, v );
		}
		public delegate void VertexAttrib4dARBDelegate( uint index, double x, double y, double z, double w ); //  extension method

		private static VertexAttrib4dARBDelegate _VertexAttrib4dARB;

		public static  void VertexAttrib4dARB( uint index, double x, double y, double z, double w )
		{
			if (_VertexAttrib4dARB == null) throw new Exception( "Extension method VertexAttrib4dARB not found" );
		 _VertexAttrib4dARB( index, x, y, z, w );
		}
		public delegate void VertexAttrib4dvARBDelegate( uint index, double[] v ); //  extension method

		private static VertexAttrib4dvARBDelegate _VertexAttrib4dvARB;

		public static  void VertexAttrib4dvARB( uint index, double[] v )
		{
			if (_VertexAttrib4dvARB == null) throw new Exception( "Extension method VertexAttrib4dvARB not found" );
		 _VertexAttrib4dvARB( index, v );
		}
		public delegate void VertexAttrib4fARBDelegate( uint index, float x, float y, float z, float w ); //  extension method

		private static VertexAttrib4fARBDelegate _VertexAttrib4fARB;

		public static  void VertexAttrib4fARB( uint index, float x, float y, float z, float w )
		{
			if (_VertexAttrib4fARB == null) throw new Exception( "Extension method VertexAttrib4fARB not found" );
		 _VertexAttrib4fARB( index, x, y, z, w );
		}
		public delegate void VertexAttrib4fvARBDelegate( uint index, float[] v ); //  extension method

		private static VertexAttrib4fvARBDelegate _VertexAttrib4fvARB;

		public static  void VertexAttrib4fvARB( uint index, float[] v )
		{
			if (_VertexAttrib4fvARB == null) throw new Exception( "Extension method VertexAttrib4fvARB not found" );
		 _VertexAttrib4fvARB( index, v );
		}
		public delegate void VertexAttrib4ivARBDelegate( uint index, int[] v ); //  extension method

		private static VertexAttrib4ivARBDelegate _VertexAttrib4ivARB;

		public static  void VertexAttrib4ivARB( uint index, int[] v )
		{
			if (_VertexAttrib4ivARB == null) throw new Exception( "Extension method VertexAttrib4ivARB not found" );
		 _VertexAttrib4ivARB( index, v );
		}
		public delegate void VertexAttrib4sARBDelegate( uint index, short x, short y, short z, short w ); //  extension method

		private static VertexAttrib4sARBDelegate _VertexAttrib4sARB;

		public static  void VertexAttrib4sARB( uint index, short x, short y, short z, short w )
		{
			if (_VertexAttrib4sARB == null) throw new Exception( "Extension method VertexAttrib4sARB not found" );
		 _VertexAttrib4sARB( index, x, y, z, w );
		}
		public delegate void VertexAttrib4svARBDelegate( uint index, short[] v ); //  extension method

		private static VertexAttrib4svARBDelegate _VertexAttrib4svARB;

		public static  void VertexAttrib4svARB( uint index, short[] v )
		{
			if (_VertexAttrib4svARB == null) throw new Exception( "Extension method VertexAttrib4svARB not found" );
		 _VertexAttrib4svARB( index, v );
		}
		public delegate void VertexAttrib4ubvARBDelegate( uint index, byte[] v ); //  extension method

		private static VertexAttrib4ubvARBDelegate _VertexAttrib4ubvARB;

		public static  void VertexAttrib4ubvARB( uint index, byte[] v )
		{
			if (_VertexAttrib4ubvARB == null) throw new Exception( "Extension method VertexAttrib4ubvARB not found" );
		 _VertexAttrib4ubvARB( index, v );
		}
		public delegate void VertexAttrib4uivARBDelegate( uint index, uint[] v ); //  extension method

		private static VertexAttrib4uivARBDelegate _VertexAttrib4uivARB;

		public static  void VertexAttrib4uivARB( uint index, uint[] v )
		{
			if (_VertexAttrib4uivARB == null) throw new Exception( "Extension method VertexAttrib4uivARB not found" );
		 _VertexAttrib4uivARB( index, v );
		}
		public delegate void VertexAttrib4usvARBDelegate( uint index, ushort[] v ); //  extension method

		private static VertexAttrib4usvARBDelegate _VertexAttrib4usvARB;

		public static  void VertexAttrib4usvARB( uint index, ushort[] v )
		{
			if (_VertexAttrib4usvARB == null) throw new Exception( "Extension method VertexAttrib4usvARB not found" );
		 _VertexAttrib4usvARB( index, v );
		}
		public unsafe delegate void VertexAttribPointerARBDelegate( uint index, int size, uint type, bool normalized, int stride, void* pointer ); //  extension method

		private static VertexAttribPointerARBDelegate _VertexAttribPointerARB;

		public static unsafe  void VertexAttribPointerARB( uint index, int size, uint type, bool normalized, int stride, void* pointer )
		{
			if (_VertexAttribPointerARB == null) throw new Exception( "Extension method VertexAttribPointerARB not found" );
		 _VertexAttribPointerARB( index, size, type, normalized, stride, pointer );
		}
		public delegate void EnableVertexAttribArrayARBDelegate( uint index ); //  extension method

		private static EnableVertexAttribArrayARBDelegate _EnableVertexAttribArrayARB;

		public static  void EnableVertexAttribArrayARB( uint index )
		{
			if (_EnableVertexAttribArrayARB == null) throw new Exception( "Extension method EnableVertexAttribArrayARB not found" );
		 _EnableVertexAttribArrayARB( index );
		}
		public delegate void DisableVertexAttribArrayARBDelegate( uint index ); //  extension method

		private static DisableVertexAttribArrayARBDelegate _DisableVertexAttribArrayARB;

		public static  void DisableVertexAttribArrayARB( uint index )
		{
			if (_DisableVertexAttribArrayARB == null) throw new Exception( "Extension method DisableVertexAttribArrayARB not found" );
		 _DisableVertexAttribArrayARB( index );
		}
		public unsafe delegate void ProgramStringARBDelegate( uint target, uint format, int len, void* @string ); //  extension method

		private static ProgramStringARBDelegate _ProgramStringARB;

		public static unsafe  void ProgramStringARB( uint target, uint format, int len, void* @string )
		{
			if (_ProgramStringARB == null) throw new Exception( "Extension method ProgramStringARB not found" );
		 _ProgramStringARB( target, format, len, @string );
		}
		public delegate void BindProgramARBDelegate( uint target, uint program ); //  extension method

		private static BindProgramARBDelegate _BindProgramARB;

		public static  void BindProgramARB( uint target, uint program )
		{
			if (_BindProgramARB == null) throw new Exception( "Extension method BindProgramARB not found" );
		 _BindProgramARB( target, program );
		}
		public delegate void DeleteProgramsARBDelegate( int n, uint[] programs ); //  extension method

		private static DeleteProgramsARBDelegate _DeleteProgramsARB;

		public static  void DeleteProgramsARB( int n, uint[] programs )
		{
			if (_DeleteProgramsARB == null) throw new Exception( "Extension method DeleteProgramsARB not found" );
		 _DeleteProgramsARB( n, programs );
		}
		public delegate void GenProgramsARBDelegate( int n, [Out]uint[] programs ); //  extension method

		private static GenProgramsARBDelegate _GenProgramsARB;

		public static  void GenProgramsARB( int n, [Out]uint[] programs )
		{
			if (_GenProgramsARB == null) throw new Exception( "Extension method GenProgramsARB not found" );
		 _GenProgramsARB( n, programs );
		}
		public delegate void ProgramEnvParameter4dARBDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method

		private static ProgramEnvParameter4dARBDelegate _ProgramEnvParameter4dARB;

		public static  void ProgramEnvParameter4dARB( uint target, uint index, double x, double y, double z, double w )
		{
			if (_ProgramEnvParameter4dARB == null) throw new Exception( "Extension method ProgramEnvParameter4dARB not found" );
		 _ProgramEnvParameter4dARB( target, index, x, y, z, w );
		}
		public delegate void ProgramEnvParameter4dvARBDelegate( uint target, uint index, double[] @params ); //  extension method

		private static ProgramEnvParameter4dvARBDelegate _ProgramEnvParameter4dvARB;

		public static  void ProgramEnvParameter4dvARB( uint target, uint index, double[] @params )
		{
			if (_ProgramEnvParameter4dvARB == null) throw new Exception( "Extension method ProgramEnvParameter4dvARB not found" );
		 _ProgramEnvParameter4dvARB( target, index, @params );
		}
		public delegate void ProgramEnvParameter4fARBDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method

		private static ProgramEnvParameter4fARBDelegate _ProgramEnvParameter4fARB;

		public static  void ProgramEnvParameter4fARB( uint target, uint index, float x, float y, float z, float w )
		{
			if (_ProgramEnvParameter4fARB == null) throw new Exception( "Extension method ProgramEnvParameter4fARB not found" );
		 _ProgramEnvParameter4fARB( target, index, x, y, z, w );
		}
		public delegate void ProgramEnvParameter4fvARBDelegate( uint target, uint index, float[] @params ); //  extension method

		private static ProgramEnvParameter4fvARBDelegate _ProgramEnvParameter4fvARB;

		public static  void ProgramEnvParameter4fvARB( uint target, uint index, float[] @params )
		{
			if (_ProgramEnvParameter4fvARB == null) throw new Exception( "Extension method ProgramEnvParameter4fvARB not found" );
		 _ProgramEnvParameter4fvARB( target, index, @params );
		}
		public delegate void ProgramLocalParameter4dARBDelegate( uint target, uint index, double x, double y, double z, double w ); //  extension method

		private static ProgramLocalParameter4dARBDelegate _ProgramLocalParameter4dARB;

		public static  void ProgramLocalParameter4dARB( uint target, uint index, double x, double y, double z, double w )
		{
			if (_ProgramLocalParameter4dARB == null) throw new Exception( "Extension method ProgramLocalParameter4dARB not found" );
		 _ProgramLocalParameter4dARB( target, index, x, y, z, w );
		}
		public delegate void ProgramLocalParameter4dvARBDelegate( uint target, uint index, double[] @params ); //  extension method

		private static ProgramLocalParameter4dvARBDelegate _ProgramLocalParameter4dvARB;

		public static  void ProgramLocalParameter4dvARB( uint target, uint index, double[] @params )
		{
			if (_ProgramLocalParameter4dvARB == null) throw new Exception( "Extension method ProgramLocalParameter4dvARB not found" );
		 _ProgramLocalParameter4dvARB( target, index, @params );
		}
		public delegate void ProgramLocalParameter4fARBDelegate( uint target, uint index, float x, float y, float z, float w ); //  extension method

		private static ProgramLocalParameter4fARBDelegate _ProgramLocalParameter4fARB;

		public static  void ProgramLocalParameter4fARB( uint target, uint index, float x, float y, float z, float w )
		{
			if (_ProgramLocalParameter4fARB == null) throw new Exception( "Extension method ProgramLocalParameter4fARB not found" );
		 _ProgramLocalParameter4fARB( target, index, x, y, z, w );
		}
		public delegate void ProgramLocalParameter4fvARBDelegate( uint target, uint index, float[] @params ); //  extension method

		private static ProgramLocalParameter4fvARBDelegate _ProgramLocalParameter4fvARB;

		public static  void ProgramLocalParameter4fvARB( uint target, uint index, float[] @params )
		{
			if (_ProgramLocalParameter4fvARB == null) throw new Exception( "Extension method ProgramLocalParameter4fvARB not found" );
		 _ProgramLocalParameter4fvARB( target, index, @params );
		}
		public delegate void GetProgramEnvParameterdvARBDelegate( uint target, uint index, [Out]double[] @params ); //  extension method

		private static GetProgramEnvParameterdvARBDelegate _GetProgramEnvParameterdvARB;

		public static  void GetProgramEnvParameterdvARB( uint target, uint index, [Out]double[] @params )
		{
			if (_GetProgramEnvParameterdvARB == null) throw new Exception( "Extension method GetProgramEnvParameterdvARB not found" );
		 _GetProgramEnvParameterdvARB( target, index, @params );
		}
		public delegate void GetProgramEnvParameterfvARBDelegate( uint target, uint index, [Out]float[] @params ); //  extension method

		private static GetProgramEnvParameterfvARBDelegate _GetProgramEnvParameterfvARB;

		public static  void GetProgramEnvParameterfvARB( uint target, uint index, [Out]float[] @params )
		{
			if (_GetProgramEnvParameterfvARB == null) throw new Exception( "Extension method GetProgramEnvParameterfvARB not found" );
		 _GetProgramEnvParameterfvARB( target, index, @params );
		}
		public delegate void GetProgramLocalParameterdvARBDelegate( uint target, uint index, [Out]double[] @params ); //  extension method

		private static GetProgramLocalParameterdvARBDelegate _GetProgramLocalParameterdvARB;

		public static  void GetProgramLocalParameterdvARB( uint target, uint index, [Out]double[] @params )
		{
			if (_GetProgramLocalParameterdvARB == null) throw new Exception( "Extension method GetProgramLocalParameterdvARB not found" );
		 _GetProgramLocalParameterdvARB( target, index, @params );
		}
		public delegate void GetProgramLocalParameterfvARBDelegate( uint target, uint index, [Out]float[] @params ); //  extension method

		private static GetProgramLocalParameterfvARBDelegate _GetProgramLocalParameterfvARB;

		public static  void GetProgramLocalParameterfvARB( uint target, uint index, [Out]float[] @params )
		{
			if (_GetProgramLocalParameterfvARB == null) throw new Exception( "Extension method GetProgramLocalParameterfvARB not found" );
		 _GetProgramLocalParameterfvARB( target, index, @params );
		}
		public delegate void GetProgramivARBDelegate( uint target, uint pname, [Out]int[] @params ); //  extension method

		private static GetProgramivARBDelegate _GetProgramivARB;

		public static  void GetProgramivARB( uint target, uint pname, [Out]int[] @params )
		{
			if (_GetProgramivARB == null) throw new Exception( "Extension method GetProgramivARB not found" );
		 _GetProgramivARB( target, pname, @params );
		}
		public unsafe delegate void GetProgramStringARBDelegate( uint target, uint pname, [Out]void* @string ); //  extension method

		private static GetProgramStringARBDelegate _GetProgramStringARB;

		public static unsafe  void GetProgramStringARB( uint target, uint pname, [Out]void* @string )
		{
			if (_GetProgramStringARB == null) throw new Exception( "Extension method GetProgramStringARB not found" );
		 _GetProgramStringARB( target, pname, @string );
		}
		public delegate void GetVertexAttribdvARBDelegate( uint index, uint pname, [Out]double[] @params ); //  extension method

		private static GetVertexAttribdvARBDelegate _GetVertexAttribdvARB;

		public static  void GetVertexAttribdvARB( uint index, uint pname, [Out]double[] @params )
		{
			if (_GetVertexAttribdvARB == null) throw new Exception( "Extension method GetVertexAttribdvARB not found" );
		 _GetVertexAttribdvARB( index, pname, @params );
		}
		public delegate void GetVertexAttribfvARBDelegate( uint index, uint pname, [Out]float[] @params ); //  extension method

		private static GetVertexAttribfvARBDelegate _GetVertexAttribfvARB;

		public static  void GetVertexAttribfvARB( uint index, uint pname, [Out]float[] @params )
		{
			if (_GetVertexAttribfvARB == null) throw new Exception( "Extension method GetVertexAttribfvARB not found" );
		 _GetVertexAttribfvARB( index, pname, @params );
		}
		public delegate void GetVertexAttribivARBDelegate( uint index, uint pname, [Out]int[] @params ); //  extension method

		private static GetVertexAttribivARBDelegate _GetVertexAttribivARB;

		public static  void GetVertexAttribivARB( uint index, uint pname, [Out]int[] @params )
		{
			if (_GetVertexAttribivARB == null) throw new Exception( "Extension method GetVertexAttribivARB not found" );
		 _GetVertexAttribivARB( index, pname, @params );
		}
		public unsafe delegate void GetVertexAttribPointervARBDelegate( uint index, uint pname, [Out]void** pointer ); //  extension method

		private static GetVertexAttribPointervARBDelegate _GetVertexAttribPointervARB;

		public static unsafe  void GetVertexAttribPointervARB( uint index, uint pname, [Out]void** pointer )
		{
			if (_GetVertexAttribPointervARB == null) throw new Exception( "Extension method GetVertexAttribPointervARB not found" );
		 _GetVertexAttribPointervARB( index, pname, pointer );
		}
		public delegate bool IsProgramARBDelegate( uint program ); //  extension method

		private static IsProgramARBDelegate _IsProgramARB;

		public static  bool IsProgramARB( uint program )
		{
			if (_IsProgramARB == null) throw new Exception( "Extension method IsProgramARB not found" );
		return  _IsProgramARB( program );
		}
	}
}
