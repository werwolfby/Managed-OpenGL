/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 17:24
 *
 * File: Font.cs
 * Remarks:
 * 
 * History:
 *   31.05.2008 17:24 - Create Wireframe
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Windows
{
	public class Font
	{
		private readonly Texture2D texture;
		private uint startListId;

		public Font( string fileName )
		{
			texture = new Texture2D( fileName );
		}

		public void Load()
		{
			texture.Load();

			this.startListId = OpenGLNative.GenLists( 256 );

			for (var y = 0; y < 16; y++)
			{
				for (var x = 0; x < 16; x++)
				{
					OpenGLNative.NewList( (uint)(startListId + y*16 + x), ListMode.Compile );

					OpenGLNative.Begin( BeginMode.Quads );
					OpenGLNative.Color3f( 1, 1, 1 );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( 0, 10 );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( 10, 10 );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( 10, 0 );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( 0, 0 );
					OpenGLNative.End();

					OpenGLNative.Translatef( 10, 0, 0 );

					OpenGLNative.EndList();
				}
			}
		}

		public void WriteLine( string format, params object[] objs )
		{
			var s = string.Format( format, objs );
			var bytes = System.Text.Encoding.GetEncoding( 1251 ).GetBytes( s );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture.Use();
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.ListBase( startListId );
			OpenGL.CallLists( bytes );
		}

		public static void SetFontRenderMode()
		{
			OpenGLNative.MatrixMode( MatrixMode.Projection );
			OpenGLNative.PushMatrix();

			OpenGLNative.LoadIdentity();
			OpenGLNative.Ortho( 0, 320, 240, 0, -1, 1 );

			OpenGLNative.PushAttrib( AttribMask.EnableBit | AttribMask.DepthBufferBit );

			OpenGLNative.Enable( EnableCap.Blend );
			OpenGLNative.BlendFunc( BlendingFactorSrc.One, BlendingFactorDest.One );
			OpenGLNative.DepthMask( false );
			OpenGLNative.Disable( EnableCap.Lighting );
		}

		public static void ReleaseFontRenderMode()
		{
			OpenGLNative.MatrixMode( MatrixMode.Projection );
			OpenGLNative.PopMatrix();

			OpenGLNative.PopAttrib();
		}
	}
}