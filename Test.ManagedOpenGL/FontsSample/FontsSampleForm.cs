/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 17:24
 *
 * File: FontsSampleForm.cs
 * Remarks:
 * 
 * History:
 *   31.05.2008 17:24 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.FontsSample
{
	public class FontsSampleForm : OpenGLForm
	{
		private float[] positions = new float[]
		                            {
		                            	-1, -1, +1,
		                            	+1, -1, +1,
		                            	-1, +1, +1,
		                            	+1, +1, +1,
		                            	-1, -1, -1,
		                            	+1, -1, -1,
		                            	-1, +1, -1,
		                            	+1, +1, -1,
		                            };

		private int[] indices = new[]
		                        {
		                        	0, 1, 3, 2,
		                        	5, 4, 6, 7,
									4, 0, 2, 6,
									1, 5, 7, 3,
									1, 0, 4, 5,
									2, 3, 7, 6,
		                        };

		private int[] texCoords = new[]
		                          {
		                          	0, 1,
		                          	1, 1,
		                          	1, 0,
		                          	0, 0,
		                          };
		private readonly Texture2D texture2D = new Texture2D( @"Data\Fonts\Simple.jpg" );

		private readonly Font font = new Font( @"Data\Fonts\LC_B.jpg" );

		private float angle;

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			this.texture2D.Load();
			this.font.Load();
		}

		protected override void InitPerspective() 
		{
			OpenGLNative.MatrixMode( MatrixMode.Projection );
			OpenGLNative.LoadIdentity();
			WindowsOpenGLNative.gluPerspective( 45, (double)this.ClientSize.Width / this.ClientSize.Height, 1, 1000 );
			OpenGLNative.Viewport( 0, 0, this.ClientSize.Width, this.ClientSize.Height );
		}

		protected override void Draw() 
		{
			base.Draw();

			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( 0, 0, -10 );
			OpenGLNative.Rotatef( angle, 1, 2, 3 );
			OpenGLNative.Scalef( 2.3f, 2.3f, 2.3f );

			OpenGLNative.Enable( EnableCap.DepthTest );

			OpenGLNative.Enable( EnableCap.Texture2d );
			texture2D.Use();

			OpenGLNative.Enable( EnableCap.Blend );
			OpenGLNative.BlendFunc( BlendingFactorSrc.One, BlendingFactorDest.One );

			OpenGLNative.Enable( EnableCap.CullFace );

			OpenGLNative.CullFace( CullFaceMode.Front );
			this.DrawCube();

			OpenGLNative.CullFace( CullFaceMode.Back );
			this.DrawCube();

			global::ManagedOpenGL.Engine.Windows.Font.SetFontRenderMode();
			font.WriteLine( "Test String. Русский текст." );
			global::ManagedOpenGL.Engine.Windows.Font.ReleaseFontRenderMode();
		}

		private void DrawCube() {
			OpenGLNative.Begin( BeginMode.Quads );
			for (var i = 0; i < this.indices.Length / 4; i++)
			{
				var index0 = this.indices[i * 4 + 0];
				var index1 = this.indices[i * 4 + 1];
				var index2 = this.indices[i * 4 + 2];
				var index3 = this.indices[i * 4 + 3];

				OpenGLNative.TexCoord2i( this.texCoords[0 * 2 + 0], this.texCoords[0 * 2 + 1] );
				OpenGLNative.Color3f( this.positions[index0 * 3 + 0], this.positions[index0 * 3 + 1], this.positions[index0 * 3 + 2] );
				OpenGLNative.Vertex3f( this.positions[index0 * 3 + 0], this.positions[index0 * 3 + 1], this.positions[index0 * 3 + 2] );

				OpenGLNative.TexCoord2i( this.texCoords[1 * 2 + 0], this.texCoords[1 * 2 + 1] );
				OpenGLNative.Color3f( this.positions[index1 * 3 + 0], this.positions[index1 * 3 + 1], this.positions[index1 * 3 + 2] );
				OpenGLNative.Vertex3f( this.positions[index1 * 3 + 0], this.positions[index1 * 3 + 1], this.positions[index1 * 3 + 2] );

				OpenGLNative.TexCoord2i( this.texCoords[2 * 2 + 0], this.texCoords[2 * 2 + 1] );
				OpenGLNative.Color3f( this.positions[index2 * 3 + 0], this.positions[index2 * 3 + 1], this.positions[index2 * 3 + 2] );
				OpenGLNative.Vertex3f( this.positions[index2 * 3 + 0], this.positions[index2 * 3 + 1], this.positions[index2 * 3 + 2] );

				OpenGLNative.TexCoord2i( this.texCoords[3 * 2 + 0], this.texCoords[3 * 2 + 1] );
				OpenGLNative.Color3f( this.positions[index3 * 3 + 0], this.positions[index3 * 3 + 1], this.positions[index3 * 3 + 2] );
				OpenGLNative.Vertex3f( this.positions[index3 * 3 + 0], this.positions[index3 * 3 + 1], this.positions[index3 * 3 + 2] );
			}
			OpenGLNative.End();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			angle += 360 * elapsed / 3;
		}
	}
}