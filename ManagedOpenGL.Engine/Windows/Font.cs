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
 *   13.03.2009 21:15 - Delete from Load method size variable.
 *   13.03.2009 21:21 - Instead of call CallLists use CallList to have ability
 *                      control location of printing symbols.
 *   13.03.2009 21:42 - Some temporary changes.
 *   13.03.2009 21:50 - Finish wrapped text.
 *
 *******************************************************/

using System.Text;
using ManagedOpenGL.Engine.Render;

namespace ManagedOpenGL.Engine.Windows
{
	public class Font
	{
		private readonly Texture2D texture;
		private uint startListId;
	    private float xLocation;
	    private float yLocation;

		public Font( string fileName )
		{
			texture = new Texture2D( fileName );
			FontSize = 10;
		}

		public float FontSize { get; set; }

		public void Load()
		{
			this.texture.Load();

			this.startListId = OpenGLNative.GenLists( 256 );

		    for (var y = 0; y < 16; y++)
			{
				for (var x = 0; x < 16; x++)
				{
					OpenGLNative.NewList( (uint)(this.startListId + y*16 + x), ListMode.Compile );

					OpenGLNative.Begin( BeginMode.Quads );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, 1 - (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( 0, 1 );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, 1 - (y + 1) / 16.0f );
					OpenGLNative.Vertex2i( 1, 1 );

					OpenGLNative.TexCoord2f( (x + 1) / 16.0f, 1 - (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( 1, 0 );

					OpenGLNative.TexCoord2f( (x + 0) / 16.0f, 1 - (y + 0) / 16.0f );
					OpenGLNative.Vertex2i( 0, 0 );
					OpenGLNative.End();

					OpenGLNative.EndList();
				}
			}
		}

		private readonly byte[] textBytes = new byte[256];
		private readonly char[] textChars = new char[256];
		private readonly StringBuilder builder = new StringBuilder();

        public void ResetLocation()
        {
            this.xLocation = 0;
            this.yLocation = 0;
        }

		public void WriteLine( string format, params object[] objs )
		{
            builder.Length = 0;
		    builder.AppendFormat( format, objs );
            WriteBuilder(true);
		}

        public void WriteLineWithoutWrap( string format, params object[] objs )
        {
            builder.Length = 0;
            builder.AppendFormat(format, objs);
            WriteBuilder(false);
        }

	    private void WriteBuilder( bool wrap )
		{
			var totalSymbols = builder.Length;
			var position = 0;
			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
            OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			OpenGLNative.Scalef( FontSize, FontSize, 1 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture.Use();
			while (position < totalSymbols)
			{
				var length = System.Math.Min( textChars.Length, totalSymbols - position );
				builder.CopyTo( position, textChars, 0, length );
				Encoding.GetEncoding( 1251 ).GetBytes( textChars, 0, length, textBytes, 0 );
			    for (var i = 0; i < length; i++)
			    {
			        var b = this.textBytes[i];
			        OpenGLNative.PushMatrix();
			        OpenGLNative.Translatef( xLocation, yLocation, 0 );
			        OpenGLNative.CallList( this.startListId + b );
			        OpenGLNative.PopMatrix();
			        position++;
			        xLocation += 1.0f;
                    if (xLocation >= Renderer.WindowSize.Width / FontSize)
                    {
                        xLocation = 0;
                        yLocation += 1.0f;
                        if (!wrap) return;
                    }
			    }
			}

	        xLocation = 0;
	        yLocation += 1.0f;
		}
	}
}