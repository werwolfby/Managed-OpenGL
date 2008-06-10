using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeSUN_vertexInit()
		{
						
		}
		
	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex2fSUN" )]
		public static extern void Color4ubVertex2fSUN( byte r, byte g, byte b, byte a, float x, float y ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex2fvSUN" )]
		public static extern void Color4ubVertex2fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex3fSUN" )]
		public static extern void Color4ubVertex3fSUN( byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4ubVertex3fvSUN" )]
		public static extern void Color4ubVertex3fvSUN( byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fVertex3fSUN" )]
		public static extern void Color3fVertex3fSUN( float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor3fVertex3fvSUN" )]
		public static extern void Color3fVertex3fvSUN( float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fVertex3fSUN" )]
		public static extern void Normal3fVertex3fSUN( float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glNormal3fVertex3fvSUN" )]
		public static extern void Normal3fVertex3fvSUN( float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fNormal3fVertex3fSUN" )]
		public static extern void Color4fNormal3fVertex3fSUN( float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glColor4fNormal3fVertex3fvSUN" )]
		public static extern void Color4fNormal3fVertex3fvSUN( float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fVertex3fSUN" )]
		public static extern void TexCoord2fVertex3fSUN( float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fVertex3fvSUN" )]
		public static extern void TexCoord2fVertex3fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fVertex4fSUN" )]
		public static extern void TexCoord4fVertex4fSUN( float s, float t, float p, float q, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fVertex4fvSUN" )]
		public static extern void TexCoord4fVertex4fvSUN( float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4ubVertex3fSUN" )]
		public static extern void TexCoord2fColor4ubVertex3fSUN( float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4ubVertex3fvSUN" )]
		public static extern void TexCoord2fColor4ubVertex3fvSUN( float[] tc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor3fVertex3fSUN" )]
		public static extern void TexCoord2fColor3fVertex3fSUN( float s, float t, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor3fVertex3fvSUN" )]
		public static extern void TexCoord2fColor3fVertex3fvSUN( float[] tc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fNormal3fVertex3fSUN" )]
		public static extern void TexCoord2fNormal3fVertex3fSUN( float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fNormal3fVertex3fvSUN" )]
		public static extern void TexCoord2fNormal3fVertex3fvSUN( float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4fNormal3fVertex3fSUN" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fSUN( float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord2fColor4fNormal3fVertex3fvSUN" )]
		public static extern void TexCoord2fColor4fNormal3fVertex3fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fColor4fNormal3fVertex4fSUN" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fSUN( float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glTexCoord4fColor4fNormal3fVertex4fvSUN" )]
		public static extern void TexCoord4fColor4fNormal3fVertex4fvSUN( float[] tc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiVertex3fSUN" )]
		public static extern void ReplacementCodeuiVertex3fSUN( uint rc, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiVertex3fvSUN" )]
		public static extern void ReplacementCodeuiVertex3fvSUN( uint[] rc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4ubVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fSUN( uint rc, byte r, byte g, byte b, byte a, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4ubVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor4ubVertex3fvSUN( uint[] rc, byte[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor3fVertex3fSUN( uint rc, float r, float g, float b, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor3fVertex3fvSUN( uint[] rc, float[] c, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fSUN( uint rc, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiNormal3fVertex3fvSUN( uint[] rc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fSUN( uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiColor4fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiColor4fNormal3fVertex3fvSUN( uint[] rc, float[] c, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fSUN( uint rc, float s, float t, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fVertex3fvSUN( uint[] rc, float[] tc, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN( uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] n, float[] v ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN( uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z ); // 	
		[DllImport( "opengl32.dll", EntryPoint="glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN" )]
		public static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN( uint[] rc, float[] tc, float[] c, float[] n, float[] v ); // 	
	}
}

