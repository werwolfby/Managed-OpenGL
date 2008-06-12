/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 12.06.2008 15:16
 *
 * File: TestForm.cs
 * Remarks:
 * 
 * History:
 *   12.06.2008 15:16 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using System.Runtime.InteropServices;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using Test.ManagedOpenGL;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.Temp
{
	public class TestForm : SampleOpenGLForm
	{
		private class SphereExt : Sphere
		{
			public SphereExt( float radius, int slices, int stacks ) : base( radius, slices, stacks ) {}

			public override void Draw()
			{
				gl.PointSize( 5.0f );
				gl.LineWidth( 3 );
				gl.Enable( EnableCap.PointSmooth );
				gl.Enable( EnableCap.LineSmooth );

				unsafe
				{
					fixed (Vertex* v = &this.vertices[0])
					fixed (int* ind = this.quadIndeces)
					{
						gl.EnableClientState( EnableCap.VertexArray );
						gl.DisableClientState( EnableCap.TextureCoordArray );
						gl.EnableClientState( EnableCap.NormalArray );
						gl.VertexPointer( 3, VertexPointerType.Float, Marshal.SizeOf( typeof(Vertex) ), v );
						gl.NormalPointer( NormalPointerType.Float, Marshal.SizeOf( typeof(Vertex) ), ((byte*)v) + 3 * sizeof(float) );

						gl.DrawElements( BeginMode.Quads, quadIndeces.Length, (uint)DataType.UnsignedInt, ind );

						gl.Begin( BeginMode.Lines );
						for (var i = 0; i < vertices.Length; i++)
						{
							var vertex = (v + i);
							gl.Color3f( 0, 0, 1 );
							gl.Vertex3f( vertex->position[0], vertex->position[1], vertex->position[2] );
							gl.Vertex3f( vertex->position[0] + vertex->normal[0],
							             vertex->position[1] + vertex->normal[1],
							             vertex->position[2] + vertex->normal[2] );

							gl.Color3f( 0, 1, 0 );
							gl.Vertex3f( vertex->position[0], vertex->position[1], vertex->position[2] );
							gl.Vertex3f( vertex->position[0] + vertex->tangent[0],
							             vertex->position[1] + vertex->tangent[1],
							             vertex->position[2] + vertex->tangent[2] );

							gl.Color3f( 1, 0, 0 );
							gl.Vertex3f( vertex->position[0], vertex->position[1], vertex->position[2] );
							gl.Vertex3f( vertex->position[0] + vertex->binormal[0],
							             vertex->position[1] + vertex->binormal[1],
							             vertex->position[2] + vertex->binormal[2] );
						}
						gl.End();
					}
				}
			}
		}

		private readonly SphereExt sphere = new SphereExt( 20, 24, 24 );

		public TestForm()
		{
			WindowSize = new Size( 640, 480 );

			camera.Position.Set( 0, 0, 50 );

			Renderer.Near = 1;
		}

		protected override void Draw() 
		{
			base.Draw();

			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.Enable( EnableCap.DepthTest );

			gl.MatrixMode( MatrixMode.Modelview );
			gl.LoadMatrixf( camera.Data );

			gl.Enable( EnableCap.CullFace );

			gl.PolygonMode( MaterialFace.Front, PolygonMode.Line );

			gl.Color3f( 1, 1, 1 );
			sphere.Draw();
		}
	}
}