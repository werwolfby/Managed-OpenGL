/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 07.06.2008 11:32
 *
 * File: Cube.cs
 * Remarks:
 * 
 * History:
 *   07.06.2008 11:32 - Create Wireframe
 *
 *******************************************************/

using System.Runtime.InteropServices;
using ManagedOpenGL;

namespace Test.ManagedOpenGL.CubeMapSample
{
	public class Cube
	{
		[StructLayout(LayoutKind.Sequential)]
		private unsafe struct Vertex
		{
			public fixed float position [3];
			public fixed float normal [3];
			public fixed float texCoord [2];

			public Vertex( float x, float y, float z, float nx, float ny, float nz, float s, float t )
			{
				fixed (float* pos = position, norm = normal, tex = texCoord)
				{
					pos[0] = x;
					pos[1] = y;
					pos[2] = z;

					norm[0] = nx;
					norm[1] = ny;
					norm[2] = nz;

					tex[0] = s;
					tex[1] = t;
				}
			}
		}

		private float width, height, length;
		private readonly Vertex[] vertices = new Vertex[6*4];

		public Cube( float width, float height, float length )
		{
			this.width = width;
			this.height = height;
			this.length = length;

			var cornerPoints = new [,]
			                   {
			                   	{ - width / 2, - height / 2, + length / 2 },
			                   	{ + width / 2, - height / 2, + length / 2 },
			                   	{ - width / 2, + height / 2, + length / 2 },
			                   	{ + width / 2, + height / 2, + length / 2 },
			                   	{ - width / 2, - height / 2, - length / 2 },
			                   	{ + width / 2, - height / 2, - length / 2 },
			                   	{ - width / 2, + height / 2, - length / 2 },
			                   	{ + width / 2, + height / 2, - length / 2 },
			                   };

			Fill( 0, cornerPoints, 0, 1, 3, 2, 0, 0, +1 ); // back
			Fill( 1, cornerPoints, 5, 4, 6, 7, 0, 0, -1 ); // front
			Fill( 2, cornerPoints, 4, 0, 2, 6, -1, 0, 0 ); // left
			Fill( 3, cornerPoints, 1, 5, 7, 3, +1, 0, 0 ); // right
			Fill( 4, cornerPoints, 1, 0, 4, 5, 0, -1, 0 ); // bottom
			Fill( 5, cornerPoints, 7, 6, 2, 3, 0, +1, 0 ); // top
		}

		private void Fill( int number, float [,] cornerPoints, int i0, int i1, int i2, int i3, int nx, int ny, int nz )
		{
			vertices[number*4 + 0] = new Vertex( cornerPoints[i0, 0], cornerPoints[i0, 1], cornerPoints[i0, 2], nx, ny, nz, 0, 1 );
			vertices[number*4 + 1] = new Vertex( cornerPoints[i1, 0], cornerPoints[i1, 1], cornerPoints[i1, 2], nx, ny, nz, 1, 1 );
			vertices[number*4 + 2] = new Vertex( cornerPoints[i2, 0], cornerPoints[i2, 1], cornerPoints[i2, 2], nx, ny, nz, 1, 0 );
			vertices[number*4 + 3] = new Vertex( cornerPoints[i3, 0], cornerPoints[i3, 1], cornerPoints[i3, 2], nx, ny, nz, 0, 0 );
		}

		public void Draw()
		{
			unsafe
			{
				fixed (float* v = this.vertices[0].position, t = this.vertices[0].texCoord, n = this.vertices[0].normal)
				{
					OpenGLNative.EnableClientState( EnableCap.VertexArray );
					OpenGLNative.EnableClientState( EnableCap.TextureCoordArray );
					OpenGLNative.EnableClientState( EnableCap.NormalArray );
					OpenGLNative.VertexPointer( 3, VertexPointerType.Float, Marshal.SizeOf( typeof(Vertex) ), v );
					OpenGLNative.TexCoordPointer( 2, TexCoordPointerType.Float, Marshal.SizeOf( typeof(Vertex) ), t );
					OpenGLNative.NormalPointer( NormalPointerType.Float, Marshal.SizeOf( typeof(Vertex) ), n );

					OpenGLNative.DrawArrays( BeginMode.Quads, 0, 6*4 );
				}
			}
		}
	}
}