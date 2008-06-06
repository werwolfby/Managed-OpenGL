/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 06.06.2008 11:55
 *
 * File: Skybox.cs
 * Remarks:
 * 
 * History:
 *   06.06.2008 11:55 - Create Wireframe
 *
 *******************************************************/

using System.Runtime.InteropServices;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.SkyBoxSample
{
	public class Skybox
	{
		[StructLayout(LayoutKind.Sequential)]
		private struct BoxVertex
		{
			public float x;
			public float y;
			public float z;

			public BoxVertex( float x, float y, float z )
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct SkyboxVertex
		{
			public float x;
			public float y;
			public float z;

			public float s;
			public float t;

			public SkyboxVertex( float x, float y, float z, float s, float t )
			{
				this.x = x;
				this.y = y;
				this.z = z;
				this.s = s;
				this.t = t;
			}

			public SkyboxVertex( BoxVertex boxVertex, float s, float t ) : this( boxVertex.x, boxVertex.y, boxVertex.z, s, t ) {}
		}

		private float x, y, z;
		private float width, height, length;
		private Texture2D back, front, left, right, bottom, top;
		private readonly BoxVertex[] boxVertexes = new BoxVertex[8];
		private readonly SkyboxVertex[] skyboxVertices = new SkyboxVertex[6*4];

		#region Constructors
		public Skybox( float x, float y, float z, float width, float height, float length, 
			Texture2D back, Texture2D front, Texture2D left, Texture2D right, Texture2D bottom, Texture2D top )
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.width = width;
			this.height = height;
			this.length = length;

			var w2 = width / 2;
			var h2 = height / 2;
			var l2 = length / 2;

			this.boxVertexes[0] = new BoxVertex( x - w2, y - h2, z + l2 );
			this.boxVertexes[1] = new BoxVertex( x + w2, y - h2, z + l2 );
			this.boxVertexes[2] = new BoxVertex( x - w2, y + h2, z + l2 );
			this.boxVertexes[3] = new BoxVertex( x + w2, y + h2, z + l2 );
			this.boxVertexes[4] = new BoxVertex( x - w2, y - h2, z - l2 );
			this.boxVertexes[5] = new BoxVertex( x + w2, y - h2, z - l2 );
			this.boxVertexes[6] = new BoxVertex( x - w2, y + h2, z - l2 );
			this.boxVertexes[7] = new BoxVertex( x + w2, y + h2, z - l2 );

			this.back   = back;
			this.front  = front;
			this.left   = left;
			this.right  = right;
			this.bottom = bottom;
			this.top    = top;

			
			Fill( 0, boxVertexes, skyboxVertices, 1, 0, 2, 3 ); // back
			Fill( 1, boxVertexes, skyboxVertices, 4, 5, 7, 6 ); // front
			Fill( 2, boxVertexes, skyboxVertices, 0, 4, 6, 2 ); // left
			Fill( 3, boxVertexes, skyboxVertices, 5, 1, 3, 7 ); // right
			Fill( 4, boxVertexes, skyboxVertices, 0, 1, 5, 4 ); // bottom
			Fill( 5, boxVertexes, skyboxVertices, 6, 7, 3, 2 ); // top
		}

		public Skybox( float width, float height, float length,
			Texture2D back, Texture2D front, Texture2D left, Texture2D right, Texture2D bottom, Texture2D top ) : 
			this( 0, 0, 0, width, height, length, back, front, left, right, bottom, top )
		{
		}
		#endregion

		private static void Fill( int faceNumber, BoxVertex[] boxVertices, SkyboxVertex[] vertices, int i0, int i1, int i2, int i3 )
		{
			vertices[faceNumber*4 + 0] = new SkyboxVertex( boxVertices[i0], 0, 1 );
			vertices[faceNumber*4 + 1] = new SkyboxVertex( boxVertices[i1], 1, 1 );
			vertices[faceNumber*4 + 2] = new SkyboxVertex( boxVertices[i2], 1, 0 );
			vertices[faceNumber*4 + 3] = new SkyboxVertex( boxVertices[i3], 0, 0 );
		}

		public void Draw()
		{
			OpenGLNative.Enable( EnableCap.CullFace );

			unsafe
			{
				fixed (void* vertices = &this.skyboxVertices[0].x)
				fixed (void* texVertices = &this.skyboxVertices[0].s)
				{
					OpenGLNative.EnableClientState( EnableCap.VertexArray );
					OpenGLNative.EnableClientState( EnableCap.TextureCoordArray );
					OpenGLNative.VertexPointer( 3, VertexPointerType.Float, Marshal.SizeOf( typeof(SkyboxVertex) ), vertices );
					OpenGLNative.TexCoordPointer( 2, TexCoordPointerType.Float, Marshal.SizeOf( typeof(SkyboxVertex) ), texVertices );

					back.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 00, 4 );
					front.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 04, 4 );
					left.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 08, 4 );
					right.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 12, 4 );
					bottom.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 16, 4 );
					top.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 20, 4 );
				}
			}
		}
	}
}