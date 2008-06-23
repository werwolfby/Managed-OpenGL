/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 08.06.2008 14:17
 *
 * File: Sphere.cs
 * Remarks:
 * 
 * History:
 *   08.06.2008 14:17 - Create Wireframe
 *
 *******************************************************/

using System.Runtime.InteropServices;
using ManagedOpenGL.Engine.Math;
using gl = ManagedOpenGL.OpenGLNative;

namespace ManagedOpenGL.Engine.Objects
{
	public class Sphere : DrawObject
	{
		protected readonly float radius;
		protected readonly int slices, stacks;

		[StructLayout(LayoutKind.Sequential)]
		protected unsafe struct Vertex
		{
			public const int PositionByteOffset = 0;
			public const int NormalByteOffset = PositionByteOffset + 3*sizeof(float);
			public const int BinormalByteOffset = NormalByteOffset + 3*sizeof(float);
			public const int TangentByteOffset = BinormalByteOffset + 3*sizeof(float);
			public const int TexCoordByteOffset = TangentByteOffset + 3*sizeof(float);

			public fixed float position [3];
			public fixed float normal [3];
			public fixed float binormal [3];
			public fixed float tangent [3];
			public fixed float texCoord [2];

			public Vertex( float x, float y, float z, float nx, float ny, float nz, float bnx, float bny, float bnz, 
				float tx, float ty, float tz, float s, float t )
			{
				fixed (float* pos = this.position, tex = texCoord, norm = this.normal, b = binormal, tn = tangent)
				{
					pos[0] = x;
					pos[1] = y;
					pos[2] = z;

					tex[0] = s;
					tex[1] = t;

					norm[0] = nx;
					norm[1] = ny;
					norm[2] = nz;

					b[0] = bnx;
					b[1] = bny;
					b[2] = bnz;

					tn[0] = tx;
					tn[1] = ty;
					tn[2] = tz;
				}
			}
		}

		protected readonly Vertex[] vertices;
		protected readonly int[] quadIndeces;

		public Sphere( float radius, int slices, int stacks )
		{
			this.radius = radius;
			this.slices = slices;
			this.stacks = stacks;

			this.vertices = new Vertex[(slices + 1) * (stacks + 1)];

			for (var slice = 0; slice <= slices; slice++)
			{
				var sliceAngle =  - slice * System.Math.PI / slices + System.Math.PI / 2;
				var x = (float)(radius * System.Math.Cos( sliceAngle ));
				var y = (float)(radius * System.Math.Sin( sliceAngle ));

				var sliceNormalX = -y / radius;
				var sliceNormalY = x / radius;

				for (var stack = 0; stack <= stacks; stack++)
				{
					var stackAngle = 2 * stack * System.Math.PI / stacks;
					var sx = (float)(x * System.Math.Cos( stackAngle ));
					var sz = (float)(x * System.Math.Sin( stackAngle ));

					var rotSliceNormalX = (float)(sliceNormalX * System.Math.Cos( stackAngle ));
					var rotSliceNormalY = sliceNormalY;
					var rotSliceNormalZ = (float)(sliceNormalX * System.Math.Sin( stackAngle ));

					var nx = sx / radius;
					var ny =  y / radius;
					var nz = sz / radius;

					var binormal = new Vector3F( rotSliceNormalX, rotSliceNormalY, rotSliceNormalZ );
					var normal = new Vector3F( nx, ny, nz );
					var tangent = normal ^ binormal;

					this.vertices[this.GetIndex( slice, stack )] =
						new Vertex( sx, y, sz, nx, ny, nz,
						            rotSliceNormalX, rotSliceNormalY, rotSliceNormalZ,
						            -tangent.X, -tangent.Y, -tangent.Z, 1.0f -(float)stack / stacks, (float)slice / slices );
				}
			}

			this.quadIndeces = new int[slices * (stacks + 1) * 4];

			for (var slice = 0; slice < slices; slice++)
			{
				for (var stack = 0; stack < stacks; stack++)
				{
					this.quadIndeces[(this.GetIndex( slice, stack )) * 4 + 0] = this.GetIndex( slice + 0, stack + 0 );
					this.quadIndeces[(this.GetIndex( slice, stack )) * 4 + 1] = this.GetIndex( slice + 0, stack + 1 );
					this.quadIndeces[(this.GetIndex( slice, stack )) * 4 + 2] = this.GetIndex( slice + 1, stack + 1 );
					this.quadIndeces[(this.GetIndex( slice, stack )) * 4 + 3] = this.GetIndex( slice + 1, stack + 0 );
				}
			}

			TangentVectorAttributeIndex = -1;
			BinormalVectorAttributeIndex = -1;
		}

		public int TangentVectorAttributeIndex { get; set; }

		public int BinormalVectorAttributeIndex { get; set; }

		private int GetIndex( int slice, int stack )
		{
			return slice * (stacks + 1) + stack;
		}

		public override void Draw()
		{
			gl.PointSize( 5.0f );
			gl.LineWidth( 3 );
			gl.Enable( EnableCap.PointSmooth );
			gl.Enable( EnableCap.LineSmooth );

			var stride = Marshal.SizeOf( typeof(Vertex) );

			unsafe
			{
				fixed (Vertex* v = &this.vertices[0])
				fixed (int* ind = this.quadIndeces)
				{
					var b = (byte*)v;

					gl.EnableClientState( EnableCap.VertexArray );
					gl.EnableClientState( EnableCap.TextureCoordArray );
					gl.EnableClientState( EnableCap.NormalArray );

					if (TangentVectorAttributeIndex >= 0)
					{
						OpenGLNative.EnableVertexAttribArray( (uint)this.TangentVectorAttributeIndex );
						OpenGLNative.VertexAttribPointerARB( (uint)this.TangentVectorAttributeIndex, 3, (uint)DataType.Float, false,
						                                     stride, b + Vertex.TangentByteOffset );
					}

					if ( BinormalVectorAttributeIndex >= 0)
					{
						OpenGLNative.EnableVertexAttribArray( (uint)this.BinormalVectorAttributeIndex );
						OpenGLNative.VertexAttribPointerARB( (uint)this.BinormalVectorAttributeIndex, 3, (uint)DataType.Float, false,
						                                     stride, b + Vertex.BinormalByteOffset );
					}

					gl.VertexPointer( 3, VertexPointerType.Float, stride, b + Vertex.PositionByteOffset );
					gl.NormalPointer( NormalPointerType.Float, stride, b + Vertex.NormalByteOffset );
					gl.TexCoordPointer( 3, TexCoordPointerType.Float, stride, b + Vertex.TexCoordByteOffset );

					gl.DrawElements( BeginMode.Quads, quadIndeces.Length, (uint)DataType.UnsignedInt, ind );
				}
			}
		}
	}
}