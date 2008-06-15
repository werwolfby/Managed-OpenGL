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

using System.Text;

namespace ManagedOpenGL.Engine.Windows
{
	public class Font
	{
		private readonly Texture2D texture;
		private uint startListId;

		public Font( string fileName )
		{
			texture = new Texture2D( fileName );
			FontSize = 10;
		}

		public int FontSize { get; set; }

		public void Load()
		{
			texture.Load();

			this.startListId = OpenGLNative.GenLists( 256 );

			var size = 1;
			for (var y = 0; y < 16; y++)
			{
				for (var x = 0; x < 16; x++)
				{
					OpenGLNative.NewList( (uint)(startListId + y*16 + x), ListMode.Compile );

					OpenGLNative.Begin( BeginMode.Quads );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( 0, size );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( size, size );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( size, 0 );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( 0, 0 );
					OpenGLNative.End();

					OpenGLNative.Translatef( size, 0, 0 );

					OpenGLNative.EndList();
				}
			}
		}

		private readonly byte[] textBytes = new byte[256];
		private readonly char[] textChars = new char[256];
		private readonly StringBuilder builder = new StringBuilder();

		public void WriteLine( string format, params object[] objs )
		{
			WriteLine( 0, 0, format, objs );
		}

		public void WriteLine( float x, float y, string format, params object[] objs )
		{
			builder.Length = 0;
			builder.AppendFormat( format, objs );
			var totalSymbols = builder.Length;
			var position = 0;
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Scalef( FontSize, FontSize, 1 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture.Use();
			while (position < totalSymbols)
			{
				var length = System.Math.Min( textChars.Length, totalSymbols - position );
				builder.CopyTo( position, textChars, 0, length );
				Encoding.GetEncoding( 1251 ).GetBytes( textChars, 0, length, textBytes, 0 );
				OpenGLNative.ListBase( startListId );
				OpenGL.CallLists( textBytes, length );
				position += length;
			}
		}

		//public static void SetFontRenderMode()
		//{
		//    OpenGLNative.MatrixMode( MatrixMode.Projection );
		//    OpenGLNative.PushMatrix();

		//    OpenGLNative.LoadIdentity();
		//    OpenGLNative.Ortho( 0, 320, 240, 0, -1, 1 );

		//    OpenGLNative.PushAttrib( AttribMask.EnableBit | AttribMask.DepthBufferBit );

		//    OpenGLNative.Enable( EnableCap.Blend );
		//    OpenGLNative.BlendFunc( BlendingFactorSrc.One, BlendingFactorDest.One );
		//    OpenGLNative.DepthMask( false );
		//    OpenGLNative.Disable( EnableCap.Lighting );
		//}

		//public static void ReleaseFontRenderMode()
		//{
		//    OpenGLNative.MatrixMode( MatrixMode.Projection );
		//    OpenGLNative.PopMatrix();

		//    OpenGLNative.PopAttrib();
		//}
	}
}