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

namespace ManagedOpenGL.Engine.Objects
{
	public class Cube : DrawObject
	{
		[StructLayout(LayoutKind.Sequential)]
		protected unsafe struct Vertex
		{
			public fixed float position [3];
			public fixed float normal [3];
			public fixed float binormal [3];
			public fixed float tangent [3];
			public fixed float texCoord [2];

			public Vertex( float x, float y, float z, float nx, float ny, float nz, 
				float bnx, float bny, float bnz, 
				float tx, float ty, float tz,
				float s, float t )
			{
				fixed (float* pos = position, norm = normal, tex = texCoord, b = binormal, tn = tangent)
				{
					pos[0] = x;
					pos[1] = y;
					pos[2] = z;

					norm[0] = nx;
					norm[1] = ny;
					norm[2] = nz;

					tex[0] = s;
					tex[1] = t;

					b[0] = bnx;
					b[1] = bny;
					b[2] = bnz;

					tn[0] = tx;
					tn[1] = ty;
					tn[2] = tz;
				}
			}
		}

		protected readonly Vertex[] vertices = new Vertex[6*4];

		public Cube( float width, float height, float length )
		{
			this.Width = width;
			this.Height = height;
			this.Length = length;

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

			Fill( 0, cornerPoints, 0, 1, 3, 2, 0, 0, +1, 0, +1, 0, -1, 0, 0 ); // back
			Fill( 1, cornerPoints, 5, 4, 6, 7, 0, 0, -1, 0, +1, 0, +1, 0, 0 ); // front
			Fill( 2, cornerPoints, 4, 0, 2, 6, -1, 0, 0, 0, +1, 0, 0, 0, -1 ); // left
			Fill( 3, cornerPoints, 1, 5, 7, 3, +1, 0, 0, 0, +1, 0, 0, 0, +1 ); // right
			Fill( 4, cornerPoints, 1, 0, 4, 5, 0, -1, 0, 0, 0, -1, +1, 0, 0 ); // bottom
			Fill( 5, cornerPoints, 7, 6, 2, 3, 0, +1, 0, 0, 0, +1, +1, 0, 0 ); // top
		}

		public float Width { get; private set; }

		public float Height { get; private set; }

		public float Length { get; private set; }

		private void Fill( int number, float [,] cornerPoints, int i0, int i1, int i2, int i3, float nx, float ny, float nz, 
			float bnx, float bny, float bnz, float tx, float ty, float tz )
		{
			vertices[number * 4 + 0] = new Vertex( cornerPoints[i0, 0], cornerPoints[i0, 1], cornerPoints[i0, 2], nx, ny, nz,
			                                       bnx, bny, bnz, tx, ty, tz, 0, 1 );
			vertices[number * 4 + 1] = new Vertex( cornerPoints[i1, 0], cornerPoints[i1, 1], cornerPoints[i1, 2], nx, ny, nz,
			                                       bnx, bny, bnz, tx, ty, tz, 1, 1 );
			vertices[number * 4 + 2] = new Vertex( cornerPoints[i2, 0], cornerPoints[i2, 1], cornerPoints[i2, 2], nx, ny, nz,
			                                       bnx, bny, bnz, tx, ty, tz, 1, 0 );
			vertices[number * 4 + 3] = new Vertex( cornerPoints[i3, 0], cornerPoints[i3, 1], cornerPoints[i3, 2], nx, ny, nz,
			                                       bnx, bny, bnz, tx, ty, tz, 0, 0 );
		}

		public override void Draw()
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