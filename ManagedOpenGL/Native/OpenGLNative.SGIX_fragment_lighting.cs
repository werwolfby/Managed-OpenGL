using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSGIX_fragment_lightingInit()
		{
			_FragmentColorMaterialSGIX = GetProcAdress< FragmentColorMaterialSGIXDelegate >( "glFragmentColorMaterialSGIX" );
			_FragmentLightfSGIX = GetProcAdress< FragmentLightfSGIXDelegate >( "glFragmentLightfSGIX" );
			_FragmentLightfvSGIX = GetProcAdress< FragmentLightfvSGIXDelegate >( "glFragmentLightfvSGIX" );
			_FragmentLightiSGIX = GetProcAdress< FragmentLightiSGIXDelegate >( "glFragmentLightiSGIX" );
			_FragmentLightivSGIX = GetProcAdress< FragmentLightivSGIXDelegate >( "glFragmentLightivSGIX" );
			_FragmentLightModelfSGIX = GetProcAdress< FragmentLightModelfSGIXDelegate >( "glFragmentLightModelfSGIX" );
			_FragmentLightModelfvSGIX = GetProcAdress< FragmentLightModelfvSGIXDelegate >( "glFragmentLightModelfvSGIX" );
			_FragmentLightModeliSGIX = GetProcAdress< FragmentLightModeliSGIXDelegate >( "glFragmentLightModeliSGIX" );
			_FragmentLightModelivSGIX = GetProcAdress< FragmentLightModelivSGIXDelegate >( "glFragmentLightModelivSGIX" );
			_FragmentMaterialfSGIX = GetProcAdress< FragmentMaterialfSGIXDelegate >( "glFragmentMaterialfSGIX" );
			_FragmentMaterialfvSGIX = GetProcAdress< FragmentMaterialfvSGIXDelegate >( "glFragmentMaterialfvSGIX" );
			_FragmentMaterialiSGIX = GetProcAdress< FragmentMaterialiSGIXDelegate >( "glFragmentMaterialiSGIX" );
			_FragmentMaterialivSGIX = GetProcAdress< FragmentMaterialivSGIXDelegate >( "glFragmentMaterialivSGIX" );
			_GetFragmentLightfvSGIX = GetProcAdress< GetFragmentLightfvSGIXDelegate >( "glGetFragmentLightfvSGIX" );
			_GetFragmentLightivSGIX = GetProcAdress< GetFragmentLightivSGIXDelegate >( "glGetFragmentLightivSGIX" );
			_GetFragmentMaterialfvSGIX = GetProcAdress< GetFragmentMaterialfvSGIXDelegate >( "glGetFragmentMaterialfvSGIX" );
			_GetFragmentMaterialivSGIX = GetProcAdress< GetFragmentMaterialivSGIXDelegate >( "glGetFragmentMaterialivSGIX" );
			_LightEnviSGIX = GetProcAdress< LightEnviSGIXDelegate >( "glLightEnviSGIX" );
			
		}
		
	
		public delegate void FragmentColorMaterialSGIXDelegate( MaterialFace face, MaterialParameter mode ); //  extension method
		private static FragmentColorMaterialSGIXDelegate _FragmentColorMaterialSGIX;
		
		public static  void FragmentColorMaterialSGIX( MaterialFace face, MaterialParameter mode )
		{
			if (_FragmentColorMaterialSGIX == null) throw new Exception( "Extension method FragmentColorMaterialSGIX not found" );
			 _FragmentColorMaterialSGIX( face, mode );
		}
		public delegate void FragmentLightfSGIXDelegate( uint light, uint pname, float param ); //  extension method
		private static FragmentLightfSGIXDelegate _FragmentLightfSGIX;
		
		public static  void FragmentLightfSGIX( uint light, uint pname, float param )
		{
			if (_FragmentLightfSGIX == null) throw new Exception( "Extension method FragmentLightfSGIX not found" );
			 _FragmentLightfSGIX( light, pname, param );
		}
		public delegate void FragmentLightfvSGIXDelegate( uint light, uint pname, float[] @params ); //  extension method
		private static FragmentLightfvSGIXDelegate _FragmentLightfvSGIX;
		
		public static  void FragmentLightfvSGIX( uint light, uint pname, float[] @params )
		{
			if (_FragmentLightfvSGIX == null) throw new Exception( "Extension method FragmentLightfvSGIX not found" );
			 _FragmentLightfvSGIX( light, pname, @params );
		}
		public delegate void FragmentLightiSGIXDelegate( uint light, uint pname, int param ); //  extension method
		private static FragmentLightiSGIXDelegate _FragmentLightiSGIX;
		
		public static  void FragmentLightiSGIX( uint light, uint pname, int param )
		{
			if (_FragmentLightiSGIX == null) throw new Exception( "Extension method FragmentLightiSGIX not found" );
			 _FragmentLightiSGIX( light, pname, param );
		}
		public delegate void FragmentLightivSGIXDelegate( uint light, uint pname, int[] @params ); //  extension method
		private static FragmentLightivSGIXDelegate _FragmentLightivSGIX;
		
		public static  void FragmentLightivSGIX( uint light, uint pname, int[] @params )
		{
			if (_FragmentLightivSGIX == null) throw new Exception( "Extension method FragmentLightivSGIX not found" );
			 _FragmentLightivSGIX( light, pname, @params );
		}
		public delegate void FragmentLightModelfSGIXDelegate( FragmentLightModelParameterSGIX pname, float param ); //  extension method
		private static FragmentLightModelfSGIXDelegate _FragmentLightModelfSGIX;
		
		public static  void FragmentLightModelfSGIX( FragmentLightModelParameterSGIX pname, float param )
		{
			if (_FragmentLightModelfSGIX == null) throw new Exception( "Extension method FragmentLightModelfSGIX not found" );
			 _FragmentLightModelfSGIX( pname, param );
		}
		public delegate void FragmentLightModelfvSGIXDelegate( FragmentLightModelParameterSGIX pname, float[] @params ); //  extension method
		private static FragmentLightModelfvSGIXDelegate _FragmentLightModelfvSGIX;
		
		public static  void FragmentLightModelfvSGIX( FragmentLightModelParameterSGIX pname, float[] @params )
		{
			if (_FragmentLightModelfvSGIX == null) throw new Exception( "Extension method FragmentLightModelfvSGIX not found" );
			 _FragmentLightModelfvSGIX( pname, @params );
		}
		public delegate void FragmentLightModeliSGIXDelegate( FragmentLightModelParameterSGIX pname, int param ); //  extension method
		private static FragmentLightModeliSGIXDelegate _FragmentLightModeliSGIX;
		
		public static  void FragmentLightModeliSGIX( FragmentLightModelParameterSGIX pname, int param )
		{
			if (_FragmentLightModeliSGIX == null) throw new Exception( "Extension method FragmentLightModeliSGIX not found" );
			 _FragmentLightModeliSGIX( pname, param );
		}
		public delegate void FragmentLightModelivSGIXDelegate( FragmentLightModelParameterSGIX pname, int[] @params ); //  extension method
		private static FragmentLightModelivSGIXDelegate _FragmentLightModelivSGIX;
		
		public static  void FragmentLightModelivSGIX( FragmentLightModelParameterSGIX pname, int[] @params )
		{
			if (_FragmentLightModelivSGIX == null) throw new Exception( "Extension method FragmentLightModelivSGIX not found" );
			 _FragmentLightModelivSGIX( pname, @params );
		}
		public delegate void FragmentMaterialfSGIXDelegate( MaterialFace face, MaterialParameter pname, float param ); //  extension method
		private static FragmentMaterialfSGIXDelegate _FragmentMaterialfSGIX;
		
		public static  void FragmentMaterialfSGIX( MaterialFace face, MaterialParameter pname, float param )
		{
			if (_FragmentMaterialfSGIX == null) throw new Exception( "Extension method FragmentMaterialfSGIX not found" );
			 _FragmentMaterialfSGIX( face, pname, param );
		}
		public delegate void FragmentMaterialfvSGIXDelegate( MaterialFace face, MaterialParameter pname, float[] @params ); //  extension method
		private static FragmentMaterialfvSGIXDelegate _FragmentMaterialfvSGIX;
		
		public static  void FragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, float[] @params )
		{
			if (_FragmentMaterialfvSGIX == null) throw new Exception( "Extension method FragmentMaterialfvSGIX not found" );
			 _FragmentMaterialfvSGIX( face, pname, @params );
		}
		public delegate void FragmentMaterialiSGIXDelegate( MaterialFace face, MaterialParameter pname, int param ); //  extension method
		private static FragmentMaterialiSGIXDelegate _FragmentMaterialiSGIX;
		
		public static  void FragmentMaterialiSGIX( MaterialFace face, MaterialParameter pname, int param )
		{
			if (_FragmentMaterialiSGIX == null) throw new Exception( "Extension method FragmentMaterialiSGIX not found" );
			 _FragmentMaterialiSGIX( face, pname, param );
		}
		public delegate void FragmentMaterialivSGIXDelegate( MaterialFace face, MaterialParameter pname, int[] @params ); //  extension method
		private static FragmentMaterialivSGIXDelegate _FragmentMaterialivSGIX;
		
		public static  void FragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, int[] @params )
		{
			if (_FragmentMaterialivSGIX == null) throw new Exception( "Extension method FragmentMaterialivSGIX not found" );
			 _FragmentMaterialivSGIX( face, pname, @params );
		}
		public delegate void GetFragmentLightfvSGIXDelegate( uint light, uint pname, [Out]float[] @params ); //  extension method
		private static GetFragmentLightfvSGIXDelegate _GetFragmentLightfvSGIX;
		
		public static  void GetFragmentLightfvSGIX( uint light, uint pname, [Out]float[] @params )
		{
			if (_GetFragmentLightfvSGIX == null) throw new Exception( "Extension method GetFragmentLightfvSGIX not found" );
			 _GetFragmentLightfvSGIX( light, pname, @params );
		}
		public delegate void GetFragmentLightivSGIXDelegate( uint light, uint pname, [Out]int[] @params ); //  extension method
		private static GetFragmentLightivSGIXDelegate _GetFragmentLightivSGIX;
		
		public static  void GetFragmentLightivSGIX( uint light, uint pname, [Out]int[] @params )
		{
			if (_GetFragmentLightivSGIX == null) throw new Exception( "Extension method GetFragmentLightivSGIX not found" );
			 _GetFragmentLightivSGIX( light, pname, @params );
		}
		public delegate void GetFragmentMaterialfvSGIXDelegate( MaterialFace face, MaterialParameter pname, [Out]float[] @params ); //  extension method
		private static GetFragmentMaterialfvSGIXDelegate _GetFragmentMaterialfvSGIX;
		
		public static  void GetFragmentMaterialfvSGIX( MaterialFace face, MaterialParameter pname, [Out]float[] @params )
		{
			if (_GetFragmentMaterialfvSGIX == null) throw new Exception( "Extension method GetFragmentMaterialfvSGIX not found" );
			 _GetFragmentMaterialfvSGIX( face, pname, @params );
		}
		public delegate void GetFragmentMaterialivSGIXDelegate( MaterialFace face, MaterialParameter pname, [Out]int[] @params ); //  extension method
		private static GetFragmentMaterialivSGIXDelegate _GetFragmentMaterialivSGIX;
		
		public static  void GetFragmentMaterialivSGIX( MaterialFace face, MaterialParameter pname, [Out]int[] @params )
		{
			if (_GetFragmentMaterialivSGIX == null) throw new Exception( "Extension method GetFragmentMaterialivSGIX not found" );
			 _GetFragmentMaterialivSGIX( face, pname, @params );
		}
		public delegate void LightEnviSGIXDelegate( LightEnvParameterSGIX pname, int param ); //  extension method
		private static LightEnviSGIXDelegate _LightEnviSGIX;
		
		public static  void LightEnviSGIX( LightEnvParameterSGIX pname, int param )
		{
			if (_LightEnviSGIX == null) throw new Exception( "Extension method LightEnviSGIX not found" );
			 _LightEnviSGIX( pname, param );
		}
	}
}

