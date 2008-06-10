using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeEXT_coordinate_frameInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3bEXT" )]
		public static extern void Tangent3bEXT( sbyte tx, sbyte ty, sbyte tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3bvEXT" )]
		public static extern void Tangent3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3dEXT" )]
		public static extern void Tangent3dEXT( double tx, double ty, double tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3dvEXT" )]
		public static extern void Tangent3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3fEXT" )]
		public static extern void Tangent3fEXT( float tx, float ty, float tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3fvEXT" )]
		public static extern void Tangent3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3iEXT" )]
		public static extern void Tangent3iEXT( int tx, int ty, int tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3ivEXT" )]
		public static extern void Tangent3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3sEXT" )]
		public static extern void Tangent3sEXT( short tx, short ty, short tz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangent3svEXT" )]
		public static extern void Tangent3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3bEXT" )]
		public static extern void Binormal3bEXT( sbyte bx, sbyte by, sbyte bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3bvEXT" )]
		public static extern void Binormal3bvEXT( sbyte[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3dEXT" )]
		public static extern void Binormal3dEXT( double bx, double by, double bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3dvEXT" )]
		public static extern void Binormal3dvEXT( double[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3fEXT" )]
		public static extern void Binormal3fEXT( float bx, float by, float bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3fvEXT" )]
		public static extern void Binormal3fvEXT( float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3iEXT" )]
		public static extern void Binormal3iEXT( int bx, int by, int bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3ivEXT" )]
		public static extern void Binormal3ivEXT( int[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3sEXT" )]
		public static extern void Binormal3sEXT( short bx, short by, short bz ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormal3svEXT" )]
		public static extern void Binormal3svEXT( short[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTangentPointerEXT" )]
		public static extern unsafe void TangentPointerEXT( uint type, int stride, void* pointer ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glBinormalPointerEXT" )]
		public static extern unsafe void BinormalPointerEXT( uint type, int stride, void* pointer ); // 	
	}
}

