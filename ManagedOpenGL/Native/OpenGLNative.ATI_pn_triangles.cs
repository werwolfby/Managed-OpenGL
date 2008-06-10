using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeATI_pn_trianglesInit()
		{
			_PNTrianglesiATI = GetProcAdress< PNTrianglesiATIDelegate >( "glPNTrianglesiATI" );
			_PNTrianglesfATI = GetProcAdress< PNTrianglesfATIDelegate >( "glPNTrianglesfATI" );
			
		}
		
	
		public delegate void PNTrianglesiATIDelegate( uint pname, int param ); //  extension method
		private static PNTrianglesiATIDelegate _PNTrianglesiATI;
		
		public static  void PNTrianglesiATI( uint pname, int param )
		{
			if (_PNTrianglesiATI == null) throw new Exception( "Extension method PNTrianglesiATI not found" );
			 _PNTrianglesiATI( pname, param );
		}
		public delegate void PNTrianglesfATIDelegate( uint pname, float param ); //  extension method
		private static PNTrianglesfATIDelegate _PNTrianglesfATI;
		
		public static  void PNTrianglesfATI( uint pname, float param )
		{
			if (_PNTrianglesfATI == null) throw new Exception( "Extension method PNTrianglesfATI not found" );
			 _PNTrianglesfATI( pname, param );
		}
	}
}

