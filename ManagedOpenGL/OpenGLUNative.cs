/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 08.06.2008 13:46
 *
 * File: OpenGLUNative.cs
 * Remarks:
 * 
 * History:
 *   08.06.2008 13:46 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public class OpenGLUNative
	{
		#region Functions from glu32.dll
		[DllImport( "glu32.dll" )]
		public static extern void gluOrtho2D( double left, double right, double bottom, double top );

		[DllImport( "glu32.dll" )]
		public static extern void gluPerspective( double fovy, double aspect, double zNear, double zFar );

		[DllImport( "glu32.dll" )]
		public static extern void gluLookAt( double eyex, double eyey, double eyez, double centerx, double centery,
		                                     double centerz, double upx, double upy, double upz );

		[DllImport( "glu32.dll" )]
		public static extern unsafe void gluProject( double objx, double objy, double objz, double* modelMatrix,
		                                             double* projMatrix, Int32* viewport, double* winx, double* winy,
		                                             double* winz );

		[DllImport( "glu32.dll" )]
		public static extern unsafe void gluUnProject( double winx, double winy, double winz, double* modelMatrix,
		                                               double* projMatrix, Int32* viewport, double* objx, double* objy,
		                                               double* objz );

		[DllImport( "glu32.dll" )]
		public static extern IntPtr gluNewQuadric();

		[DllImport( "glu32.dll" )]
		public static extern void gluDeleteQuadric( IntPtr quadric );

		[DllImport( "glu32.dll" )]
		public static extern void gluSphere( IntPtr qobj, double radius, int slices, int stacks );
		#endregion
	}
}