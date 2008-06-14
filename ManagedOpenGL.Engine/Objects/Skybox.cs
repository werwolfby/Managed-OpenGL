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

namespace ManagedOpenGL.Engine.Objects
{
	public class Skybox
	{
		[StructLayout(LayoutKind.Sequential)]
		private unsafe struct BoxVertex
		{
			public fixed float position[3];

			public BoxVertex( float x, float y, float z )
			{
				fixed (float* pos = this.position)
				{
					pos[0] = x;
					pos[1] = y;
					pos[2] = z;
				}
			}

			public float X { get{ fixed (float* pos = this.position) { return pos[0]; } } }

			public float Y { get{ fixed (float* pos = this.position) { return pos[1]; } } }

			public float Z { get{ fixed (float* pos = this.position) { return pos[2]; } } }
		}

		[StructLayout(LayoutKind.Sequential)]
		private unsafe struct SkyboxVertex
		{
			public fixed float position[3];
			public fixed float texCoords[2];

			public SkyboxVertex( float x, float y, float z, float s, float t )
			{
				fixed (float* pos = this.position)
				{
					pos[0] = x;
					pos[1] = y;
					pos[2] = z;
				}
				fixed (float* tex = this.texCoords)
				{
					tex[0] = s;
					tex[1] = t;
				}
			}

			public SkyboxVertex( BoxVertex boxVertex, float s, float t ) : this( boxVertex.X, boxVertex.Y, boxVertex.Z, s, t ) {}
		}

		private readonly float x, y, z;
		private readonly float width, height, length;
		private readonly Texture2D back, front, left, right, bottom, top;
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

			foreach (var texture in new [] {back, front, left, right, bottom, top})
			{
				texture.WrapS = TextureWrapMode.ClampToEdgeSgis;
				texture.WrapT = TextureWrapMode.ClampToEdgeSgis;
			}
			
			Fill( 0, this.boxVertexes, this.skyboxVertices, 1, 0, 2, 3 ); // back
			Fill( 1, this.boxVertexes, this.skyboxVertices, 4, 5, 7, 6 ); // front
			Fill( 2, this.boxVertexes, this.skyboxVertices, 0, 4, 6, 2 ); // left
			Fill( 3, this.boxVertexes, this.skyboxVertices, 5, 1, 3, 7 ); // right
			Fill( 4, this.boxVertexes, this.skyboxVertices, 0, 1, 5, 4 ); // bottom
			Fill( 5, this.boxVertexes, this.skyboxVertices, 6, 7, 3, 2 ); // top
		}

		public Skybox( float width, float height, float length,
		               Texture2D back, Texture2D front, Texture2D left, Texture2D right, Texture2D bottom, Texture2D top ) : 
		               	this( 0, 0, 0, width, height, length, back, front, left, right, bottom, top )
		{
		}
		#endregion

		#region Properties
		public float X
		{
			get { return this.x; }
		}

		public float Y
		{
			get { return this.y; }
		}

		public float Z
		{
			get { return this.z; }
		}

		public float Width
		{
			get { return this.width; }
		}

		public float Height
		{
			get { return this.height; }
		}

		public float Length
		{
			get { return this.length; }
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
				fixed (float* vertices = this.skyboxVertices[0].position, texVertices = this.skyboxVertices[0].texCoords)
				{
					OpenGLNative.EnableClientState( EnableCap.VertexArray );
					OpenGLNative.EnableClientState( EnableCap.TextureCoordArray );
					OpenGLNative.VertexPointer( 3, VertexPointerType.Float, Marshal.SizeOf( typeof(SkyboxVertex) ), vertices );
					OpenGLNative.TexCoordPointer( 2, TexCoordPointerType.Float, Marshal.SizeOf( typeof(SkyboxVertex) ), texVertices );

					this.back.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 00, 4 );
					this.front.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 04, 4 );
					this.left.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 08, 4 );
					this.right.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 12, 4 );
					this.bottom.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 16, 4 );
					this.top.Use();
					OpenGLNative.DrawArrays( BeginMode.Quads, 20, 4 );
				}
			}
		}

		public void Load()
		{
			back.Load();
			front.Load();
			left.Load();
			right.Load();
			top.Load();
			bottom.Load();
		}
	}
}