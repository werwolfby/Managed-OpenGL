using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_half_floatInit()
		{
			_Vertex2hNV = GetProcAdress< Vertex2hNVDelegate >( "glVertex2hNV" );
			_Vertex2hvNV = GetProcAdress< Vertex2hvNVDelegate >( "glVertex2hvNV" );
			_Vertex3hNV = GetProcAdress< Vertex3hNVDelegate >( "glVertex3hNV" );
			_Vertex3hvNV = GetProcAdress< Vertex3hvNVDelegate >( "glVertex3hvNV" );
			_Vertex4hNV = GetProcAdress< Vertex4hNVDelegate >( "glVertex4hNV" );
			_Vertex4hvNV = GetProcAdress< Vertex4hvNVDelegate >( "glVertex4hvNV" );
			_Normal3hNV = GetProcAdress< Normal3hNVDelegate >( "glNormal3hNV" );
			_Normal3hvNV = GetProcAdress< Normal3hvNVDelegate >( "glNormal3hvNV" );
			_Color3hNV = GetProcAdress< Color3hNVDelegate >( "glColor3hNV" );
			_Color3hvNV = GetProcAdress< Color3hvNVDelegate >( "glColor3hvNV" );
			_Color4hNV = GetProcAdress< Color4hNVDelegate >( "glColor4hNV" );
			_Color4hvNV = GetProcAdress< Color4hvNVDelegate >( "glColor4hvNV" );
			_TexCoord1hNV = GetProcAdress< TexCoord1hNVDelegate >( "glTexCoord1hNV" );
			_TexCoord1hvNV = GetProcAdress< TexCoord1hvNVDelegate >( "glTexCoord1hvNV" );
			_TexCoord2hNV = GetProcAdress< TexCoord2hNVDelegate >( "glTexCoord2hNV" );
			_TexCoord2hvNV = GetProcAdress< TexCoord2hvNVDelegate >( "glTexCoord2hvNV" );
			_TexCoord3hNV = GetProcAdress< TexCoord3hNVDelegate >( "glTexCoord3hNV" );
			_TexCoord3hvNV = GetProcAdress< TexCoord3hvNVDelegate >( "glTexCoord3hvNV" );
			_TexCoord4hNV = GetProcAdress< TexCoord4hNVDelegate >( "glTexCoord4hNV" );
			_TexCoord4hvNV = GetProcAdress< TexCoord4hvNVDelegate >( "glTexCoord4hvNV" );
			_MultiTexCoord1hNV = GetProcAdress< MultiTexCoord1hNVDelegate >( "glMultiTexCoord1hNV" );
			_MultiTexCoord1hvNV = GetProcAdress< MultiTexCoord1hvNVDelegate >( "glMultiTexCoord1hvNV" );
			_MultiTexCoord2hNV = GetProcAdress< MultiTexCoord2hNVDelegate >( "glMultiTexCoord2hNV" );
			_MultiTexCoord2hvNV = GetProcAdress< MultiTexCoord2hvNVDelegate >( "glMultiTexCoord2hvNV" );
			_MultiTexCoord3hNV = GetProcAdress< MultiTexCoord3hNVDelegate >( "glMultiTexCoord3hNV" );
			_MultiTexCoord3hvNV = GetProcAdress< MultiTexCoord3hvNVDelegate >( "glMultiTexCoord3hvNV" );
			_MultiTexCoord4hNV = GetProcAdress< MultiTexCoord4hNVDelegate >( "glMultiTexCoord4hNV" );
			_MultiTexCoord4hvNV = GetProcAdress< MultiTexCoord4hvNVDelegate >( "glMultiTexCoord4hvNV" );
			_FogCoordhNV = GetProcAdress< FogCoordhNVDelegate >( "glFogCoordhNV" );
			_FogCoordhvNV = GetProcAdress< FogCoordhvNVDelegate >( "glFogCoordhvNV" );
			_SecondaryColor3hNV = GetProcAdress< SecondaryColor3hNVDelegate >( "glSecondaryColor3hNV" );
			_SecondaryColor3hvNV = GetProcAdress< SecondaryColor3hvNVDelegate >( "glSecondaryColor3hvNV" );
			_VertexWeighthNV = GetProcAdress< VertexWeighthNVDelegate >( "glVertexWeighthNV" );
			_VertexWeighthvNV = GetProcAdress< VertexWeighthvNVDelegate >( "glVertexWeighthvNV" );
			_VertexAttrib1hNV = GetProcAdress< VertexAttrib1hNVDelegate >( "glVertexAttrib1hNV" );
			_VertexAttrib1hvNV = GetProcAdress< VertexAttrib1hvNVDelegate >( "glVertexAttrib1hvNV" );
			_VertexAttrib2hNV = GetProcAdress< VertexAttrib2hNVDelegate >( "glVertexAttrib2hNV" );
			_VertexAttrib2hvNV = GetProcAdress< VertexAttrib2hvNVDelegate >( "glVertexAttrib2hvNV" );
			_VertexAttrib3hNV = GetProcAdress< VertexAttrib3hNVDelegate >( "glVertexAttrib3hNV" );
			_VertexAttrib3hvNV = GetProcAdress< VertexAttrib3hvNVDelegate >( "glVertexAttrib3hvNV" );
			_VertexAttrib4hNV = GetProcAdress< VertexAttrib4hNVDelegate >( "glVertexAttrib4hNV" );
			_VertexAttrib4hvNV = GetProcAdress< VertexAttrib4hvNVDelegate >( "glVertexAttrib4hvNV" );
			_VertexAttribs1hvNV = GetProcAdress< VertexAttribs1hvNVDelegate >( "glVertexAttribs1hvNV" );
			_VertexAttribs2hvNV = GetProcAdress< VertexAttribs2hvNVDelegate >( "glVertexAttribs2hvNV" );
			_VertexAttribs3hvNV = GetProcAdress< VertexAttribs3hvNVDelegate >( "glVertexAttribs3hvNV" );
			_VertexAttribs4hvNV = GetProcAdress< VertexAttribs4hvNVDelegate >( "glVertexAttribs4hvNV" );
			
		}
		
	
		public delegate void Vertex2hNVDelegate( ushort x, ushort y ); //  extension method
		private static Vertex2hNVDelegate _Vertex2hNV;
		
		public static  void Vertex2hNV( ushort x, ushort y )
		{
			if (_Vertex2hNV == null) throw new Exception( "Extension method Vertex2hNV not found" );
			 _Vertex2hNV( x, y );
		}
		public delegate void Vertex2hvNVDelegate( ushort[] v ); //  extension method
		private static Vertex2hvNVDelegate _Vertex2hvNV;
		
		public static  void Vertex2hvNV( ushort[] v )
		{
			if (_Vertex2hvNV == null) throw new Exception( "Extension method Vertex2hvNV not found" );
			 _Vertex2hvNV( v );
		}
		public delegate void Vertex3hNVDelegate( ushort x, ushort y, ushort z ); //  extension method
		private static Vertex3hNVDelegate _Vertex3hNV;
		
		public static  void Vertex3hNV( ushort x, ushort y, ushort z )
		{
			if (_Vertex3hNV == null) throw new Exception( "Extension method Vertex3hNV not found" );
			 _Vertex3hNV( x, y, z );
		}
		public delegate void Vertex3hvNVDelegate( ushort[] v ); //  extension method
		private static Vertex3hvNVDelegate _Vertex3hvNV;
		
		public static  void Vertex3hvNV( ushort[] v )
		{
			if (_Vertex3hvNV == null) throw new Exception( "Extension method Vertex3hvNV not found" );
			 _Vertex3hvNV( v );
		}
		public delegate void Vertex4hNVDelegate( ushort x, ushort y, ushort z, ushort w ); //  extension method
		private static Vertex4hNVDelegate _Vertex4hNV;
		
		public static  void Vertex4hNV( ushort x, ushort y, ushort z, ushort w )
		{
			if (_Vertex4hNV == null) throw new Exception( "Extension method Vertex4hNV not found" );
			 _Vertex4hNV( x, y, z, w );
		}
		public delegate void Vertex4hvNVDelegate( ushort[] v ); //  extension method
		private static Vertex4hvNVDelegate _Vertex4hvNV;
		
		public static  void Vertex4hvNV( ushort[] v )
		{
			if (_Vertex4hvNV == null) throw new Exception( "Extension method Vertex4hvNV not found" );
			 _Vertex4hvNV( v );
		}
		public delegate void Normal3hNVDelegate( ushort nx, ushort ny, ushort nz ); //  extension method
		private static Normal3hNVDelegate _Normal3hNV;
		
		public static  void Normal3hNV( ushort nx, ushort ny, ushort nz )
		{
			if (_Normal3hNV == null) throw new Exception( "Extension method Normal3hNV not found" );
			 _Normal3hNV( nx, ny, nz );
		}
		public delegate void Normal3hvNVDelegate( ushort[] v ); //  extension method
		private static Normal3hvNVDelegate _Normal3hvNV;
		
		public static  void Normal3hvNV( ushort[] v )
		{
			if (_Normal3hvNV == null) throw new Exception( "Extension method Normal3hvNV not found" );
			 _Normal3hvNV( v );
		}
		public delegate void Color3hNVDelegate( ushort red, ushort green, ushort blue ); //  extension method
		private static Color3hNVDelegate _Color3hNV;
		
		public static  void Color3hNV( ushort red, ushort green, ushort blue )
		{
			if (_Color3hNV == null) throw new Exception( "Extension method Color3hNV not found" );
			 _Color3hNV( red, green, blue );
		}
		public delegate void Color3hvNVDelegate( ushort[] v ); //  extension method
		private static Color3hvNVDelegate _Color3hvNV;
		
		public static  void Color3hvNV( ushort[] v )
		{
			if (_Color3hvNV == null) throw new Exception( "Extension method Color3hvNV not found" );
			 _Color3hvNV( v );
		}
		public delegate void Color4hNVDelegate( ushort red, ushort green, ushort blue, ushort alpha ); //  extension method
		private static Color4hNVDelegate _Color4hNV;
		
		public static  void Color4hNV( ushort red, ushort green, ushort blue, ushort alpha )
		{
			if (_Color4hNV == null) throw new Exception( "Extension method Color4hNV not found" );
			 _Color4hNV( red, green, blue, alpha );
		}
		public delegate void Color4hvNVDelegate( ushort[] v ); //  extension method
		private static Color4hvNVDelegate _Color4hvNV;
		
		public static  void Color4hvNV( ushort[] v )
		{
			if (_Color4hvNV == null) throw new Exception( "Extension method Color4hvNV not found" );
			 _Color4hvNV( v );
		}
		public delegate void TexCoord1hNVDelegate( ushort s ); //  extension method
		private static TexCoord1hNVDelegate _TexCoord1hNV;
		
		public static  void TexCoord1hNV( ushort s )
		{
			if (_TexCoord1hNV == null) throw new Exception( "Extension method TexCoord1hNV not found" );
			 _TexCoord1hNV( s );
		}
		public delegate void TexCoord1hvNVDelegate( ushort[] v ); //  extension method
		private static TexCoord1hvNVDelegate _TexCoord1hvNV;
		
		public static  void TexCoord1hvNV( ushort[] v )
		{
			if (_TexCoord1hvNV == null) throw new Exception( "Extension method TexCoord1hvNV not found" );
			 _TexCoord1hvNV( v );
		}
		public delegate void TexCoord2hNVDelegate( ushort s, ushort t ); //  extension method
		private static TexCoord2hNVDelegate _TexCoord2hNV;
		
		public static  void TexCoord2hNV( ushort s, ushort t )
		{
			if (_TexCoord2hNV == null) throw new Exception( "Extension method TexCoord2hNV not found" );
			 _TexCoord2hNV( s, t );
		}
		public delegate void TexCoord2hvNVDelegate( ushort[] v ); //  extension method
		private static TexCoord2hvNVDelegate _TexCoord2hvNV;
		
		public static  void TexCoord2hvNV( ushort[] v )
		{
			if (_TexCoord2hvNV == null) throw new Exception( "Extension method TexCoord2hvNV not found" );
			 _TexCoord2hvNV( v );
		}
		public delegate void TexCoord3hNVDelegate( ushort s, ushort t, ushort r ); //  extension method
		private static TexCoord3hNVDelegate _TexCoord3hNV;
		
		public static  void TexCoord3hNV( ushort s, ushort t, ushort r )
		{
			if (_TexCoord3hNV == null) throw new Exception( "Extension method TexCoord3hNV not found" );
			 _TexCoord3hNV( s, t, r );
		}
		public delegate void TexCoord3hvNVDelegate( ushort[] v ); //  extension method
		private static TexCoord3hvNVDelegate _TexCoord3hvNV;
		
		public static  void TexCoord3hvNV( ushort[] v )
		{
			if (_TexCoord3hvNV == null) throw new Exception( "Extension method TexCoord3hvNV not found" );
			 _TexCoord3hvNV( v );
		}
		public delegate void TexCoord4hNVDelegate( ushort s, ushort t, ushort r, ushort q ); //  extension method
		private static TexCoord4hNVDelegate _TexCoord4hNV;
		
		public static  void TexCoord4hNV( ushort s, ushort t, ushort r, ushort q )
		{
			if (_TexCoord4hNV == null) throw new Exception( "Extension method TexCoord4hNV not found" );
			 _TexCoord4hNV( s, t, r, q );
		}
		public delegate void TexCoord4hvNVDelegate( ushort[] v ); //  extension method
		private static TexCoord4hvNVDelegate _TexCoord4hvNV;
		
		public static  void TexCoord4hvNV( ushort[] v )
		{
			if (_TexCoord4hvNV == null) throw new Exception( "Extension method TexCoord4hvNV not found" );
			 _TexCoord4hvNV( v );
		}
		public delegate void MultiTexCoord1hNVDelegate( uint target, ushort s ); //  extension method
		private static MultiTexCoord1hNVDelegate _MultiTexCoord1hNV;
		
		public static  void MultiTexCoord1hNV( uint target, ushort s )
		{
			if (_MultiTexCoord1hNV == null) throw new Exception( "Extension method MultiTexCoord1hNV not found" );
			 _MultiTexCoord1hNV( target, s );
		}
		public delegate void MultiTexCoord1hvNVDelegate( uint target, ushort[] v ); //  extension method
		private static MultiTexCoord1hvNVDelegate _MultiTexCoord1hvNV;
		
		public static  void MultiTexCoord1hvNV( uint target, ushort[] v )
		{
			if (_MultiTexCoord1hvNV == null) throw new Exception( "Extension method MultiTexCoord1hvNV not found" );
			 _MultiTexCoord1hvNV( target, v );
		}
		public delegate void MultiTexCoord2hNVDelegate( uint target, ushort s, ushort t ); //  extension method
		private static MultiTexCoord2hNVDelegate _MultiTexCoord2hNV;
		
		public static  void MultiTexCoord2hNV( uint target, ushort s, ushort t )
		{
			if (_MultiTexCoord2hNV == null) throw new Exception( "Extension method MultiTexCoord2hNV not found" );
			 _MultiTexCoord2hNV( target, s, t );
		}
		public delegate void MultiTexCoord2hvNVDelegate( uint target, ushort[] v ); //  extension method
		private static MultiTexCoord2hvNVDelegate _MultiTexCoord2hvNV;
		
		public static  void MultiTexCoord2hvNV( uint target, ushort[] v )
		{
			if (_MultiTexCoord2hvNV == null) throw new Exception( "Extension method MultiTexCoord2hvNV not found" );
			 _MultiTexCoord2hvNV( target, v );
		}
		public delegate void MultiTexCoord3hNVDelegate( uint target, ushort s, ushort t, ushort r ); //  extension method
		private static MultiTexCoord3hNVDelegate _MultiTexCoord3hNV;
		
		public static  void MultiTexCoord3hNV( uint target, ushort s, ushort t, ushort r )
		{
			if (_MultiTexCoord3hNV == null) throw new Exception( "Extension method MultiTexCoord3hNV not found" );
			 _MultiTexCoord3hNV( target, s, t, r );
		}
		public delegate void MultiTexCoord3hvNVDelegate( uint target, ushort[] v ); //  extension method
		private static MultiTexCoord3hvNVDelegate _MultiTexCoord3hvNV;
		
		public static  void MultiTexCoord3hvNV( uint target, ushort[] v )
		{
			if (_MultiTexCoord3hvNV == null) throw new Exception( "Extension method MultiTexCoord3hvNV not found" );
			 _MultiTexCoord3hvNV( target, v );
		}
		public delegate void MultiTexCoord4hNVDelegate( uint target, ushort s, ushort t, ushort r, ushort q ); //  extension method
		private static MultiTexCoord4hNVDelegate _MultiTexCoord4hNV;
		
		public static  void MultiTexCoord4hNV( uint target, ushort s, ushort t, ushort r, ushort q )
		{
			if (_MultiTexCoord4hNV == null) throw new Exception( "Extension method MultiTexCoord4hNV not found" );
			 _MultiTexCoord4hNV( target, s, t, r, q );
		}
		public delegate void MultiTexCoord4hvNVDelegate( uint target, ushort[] v ); //  extension method
		private static MultiTexCoord4hvNVDelegate _MultiTexCoord4hvNV;
		
		public static  void MultiTexCoord4hvNV( uint target, ushort[] v )
		{
			if (_MultiTexCoord4hvNV == null) throw new Exception( "Extension method MultiTexCoord4hvNV not found" );
			 _MultiTexCoord4hvNV( target, v );
		}
		public delegate void FogCoordhNVDelegate( ushort fog ); //  extension method
		private static FogCoordhNVDelegate _FogCoordhNV;
		
		public static  void FogCoordhNV( ushort fog )
		{
			if (_FogCoordhNV == null) throw new Exception( "Extension method FogCoordhNV not found" );
			 _FogCoordhNV( fog );
		}
		public delegate void FogCoordhvNVDelegate( ushort[] fog ); //  extension method
		private static FogCoordhvNVDelegate _FogCoordhvNV;
		
		public static  void FogCoordhvNV( ushort[] fog )
		{
			if (_FogCoordhvNV == null) throw new Exception( "Extension method FogCoordhvNV not found" );
			 _FogCoordhvNV( fog );
		}
		public delegate void SecondaryColor3hNVDelegate( ushort red, ushort green, ushort blue ); //  extension method
		private static SecondaryColor3hNVDelegate _SecondaryColor3hNV;
		
		public static  void SecondaryColor3hNV( ushort red, ushort green, ushort blue )
		{
			if (_SecondaryColor3hNV == null) throw new Exception( "Extension method SecondaryColor3hNV not found" );
			 _SecondaryColor3hNV( red, green, blue );
		}
		public delegate void SecondaryColor3hvNVDelegate( ushort[] v ); //  extension method
		private static SecondaryColor3hvNVDelegate _SecondaryColor3hvNV;
		
		public static  void SecondaryColor3hvNV( ushort[] v )
		{
			if (_SecondaryColor3hvNV == null) throw new Exception( "Extension method SecondaryColor3hvNV not found" );
			 _SecondaryColor3hvNV( v );
		}
		public delegate void VertexWeighthNVDelegate( ushort weight ); //  extension method
		private static VertexWeighthNVDelegate _VertexWeighthNV;
		
		public static  void VertexWeighthNV( ushort weight )
		{
			if (_VertexWeighthNV == null) throw new Exception( "Extension method VertexWeighthNV not found" );
			 _VertexWeighthNV( weight );
		}
		public delegate void VertexWeighthvNVDelegate( ushort[] weight ); //  extension method
		private static VertexWeighthvNVDelegate _VertexWeighthvNV;
		
		public static  void VertexWeighthvNV( ushort[] weight )
		{
			if (_VertexWeighthvNV == null) throw new Exception( "Extension method VertexWeighthvNV not found" );
			 _VertexWeighthvNV( weight );
		}
		public delegate void VertexAttrib1hNVDelegate( uint index, ushort x ); //  extension method
		private static VertexAttrib1hNVDelegate _VertexAttrib1hNV;
		
		public static  void VertexAttrib1hNV( uint index, ushort x )
		{
			if (_VertexAttrib1hNV == null) throw new Exception( "Extension method VertexAttrib1hNV not found" );
			 _VertexAttrib1hNV( index, x );
		}
		public delegate void VertexAttrib1hvNVDelegate( uint index, ushort[] v ); //  extension method
		private static VertexAttrib1hvNVDelegate _VertexAttrib1hvNV;
		
		public static  void VertexAttrib1hvNV( uint index, ushort[] v )
		{
			if (_VertexAttrib1hvNV == null) throw new Exception( "Extension method VertexAttrib1hvNV not found" );
			 _VertexAttrib1hvNV( index, v );
		}
		public delegate void VertexAttrib2hNVDelegate( uint index, ushort x, ushort y ); //  extension method
		private static VertexAttrib2hNVDelegate _VertexAttrib2hNV;
		
		public static  void VertexAttrib2hNV( uint index, ushort x, ushort y )
		{
			if (_VertexAttrib2hNV == null) throw new Exception( "Extension method VertexAttrib2hNV not found" );
			 _VertexAttrib2hNV( index, x, y );
		}
		public delegate void VertexAttrib2hvNVDelegate( uint index, ushort[] v ); //  extension method
		private static VertexAttrib2hvNVDelegate _VertexAttrib2hvNV;
		
		public static  void VertexAttrib2hvNV( uint index, ushort[] v )
		{
			if (_VertexAttrib2hvNV == null) throw new Exception( "Extension method VertexAttrib2hvNV not found" );
			 _VertexAttrib2hvNV( index, v );
		}
		public delegate void VertexAttrib3hNVDelegate( uint index, ushort x, ushort y, ushort z ); //  extension method
		private static VertexAttrib3hNVDelegate _VertexAttrib3hNV;
		
		public static  void VertexAttrib3hNV( uint index, ushort x, ushort y, ushort z )
		{
			if (_VertexAttrib3hNV == null) throw new Exception( "Extension method VertexAttrib3hNV not found" );
			 _VertexAttrib3hNV( index, x, y, z );
		}
		public delegate void VertexAttrib3hvNVDelegate( uint index, ushort[] v ); //  extension method
		private static VertexAttrib3hvNVDelegate _VertexAttrib3hvNV;
		
		public static  void VertexAttrib3hvNV( uint index, ushort[] v )
		{
			if (_VertexAttrib3hvNV == null) throw new Exception( "Extension method VertexAttrib3hvNV not found" );
			 _VertexAttrib3hvNV( index, v );
		}
		public delegate void VertexAttrib4hNVDelegate( uint index, ushort x, ushort y, ushort z, ushort w ); //  extension method
		private static VertexAttrib4hNVDelegate _VertexAttrib4hNV;
		
		public static  void VertexAttrib4hNV( uint index, ushort x, ushort y, ushort z, ushort w )
		{
			if (_VertexAttrib4hNV == null) throw new Exception( "Extension method VertexAttrib4hNV not found" );
			 _VertexAttrib4hNV( index, x, y, z, w );
		}
		public delegate void VertexAttrib4hvNVDelegate( uint index, ushort[] v ); //  extension method
		private static VertexAttrib4hvNVDelegate _VertexAttrib4hvNV;
		
		public static  void VertexAttrib4hvNV( uint index, ushort[] v )
		{
			if (_VertexAttrib4hvNV == null) throw new Exception( "Extension method VertexAttrib4hvNV not found" );
			 _VertexAttrib4hvNV( index, v );
		}
		public delegate void VertexAttribs1hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		private static VertexAttribs1hvNVDelegate _VertexAttribs1hvNV;
		
		public static  void VertexAttribs1hvNV( uint index, int n, ushort[] v )
		{
			if (_VertexAttribs1hvNV == null) throw new Exception( "Extension method VertexAttribs1hvNV not found" );
			 _VertexAttribs1hvNV( index, n, v );
		}
		public delegate void VertexAttribs2hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		private static VertexAttribs2hvNVDelegate _VertexAttribs2hvNV;
		
		public static  void VertexAttribs2hvNV( uint index, int n, ushort[] v )
		{
			if (_VertexAttribs2hvNV == null) throw new Exception( "Extension method VertexAttribs2hvNV not found" );
			 _VertexAttribs2hvNV( index, n, v );
		}
		public delegate void VertexAttribs3hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		private static VertexAttribs3hvNVDelegate _VertexAttribs3hvNV;
		
		public static  void VertexAttribs3hvNV( uint index, int n, ushort[] v )
		{
			if (_VertexAttribs3hvNV == null) throw new Exception( "Extension method VertexAttribs3hvNV not found" );
			 _VertexAttribs3hvNV( index, n, v );
		}
		public delegate void VertexAttribs4hvNVDelegate( uint index, int n, ushort[] v ); //  extension method
		private static VertexAttribs4hvNVDelegate _VertexAttribs4hvNV;
		
		public static  void VertexAttribs4hvNV( uint index, int n, ushort[] v )
		{
			if (_VertexAttribs4hvNV == null) throw new Exception( "Extension method VertexAttribs4hvNV not found" );
			 _VertexAttribs4hvNV( index, n, v );
		}
	}
}

