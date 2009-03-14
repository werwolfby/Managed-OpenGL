/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 25.07.2001 21:51
 *
 * File: Console.cs
 * Remarks:
 * 
 * History:
 *   25.07.2001 21:51 - Create Wireframe
 *   25.07.2001 21:58 - Finish first implementation.
 *   25.07.2001 22:07 - Add `Update` method.
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using ManagedOpenGL.Engine.Render;

namespace ManagedOpenGL.Engine.Windows
{
    public class Console
    {
        private readonly Font font;
        private readonly List<string> lines = new List<string>();
        private bool visible;

        public Console( Font font )
        {
            if (font == null) throw new ArgumentNullException( "font" );
            this.font = font;
        }

        public float FontSize
        {
            get { return this.font.FontSize; }
            set { this.font.FontSize = value; }
        }

        public bool Visible
        {
            get { return this.visible; }
        }

        public void AddString( string text )
        {
            lines.Add( text );
        }

        public void Show()
        {
            visible = true;
        }

        public void Hide()
        {
            visible = false;
        }

        public void Draw()
        {
            if (!Visible) return;

            Renderer.RenderMode = RenderMode.MODE_2D;

            OpenGLNative.Disable( EnableCap.Texture2d );

            OpenGLNative.Begin( BeginMode.Quads );

            OpenGLNative.Color3f( 1, 1, 1 );

            OpenGLNative.Vertex2f( 0, Renderer.WindowSize.Height / 2.0f );
            OpenGLNative.Vertex2f( Renderer.WindowSize.Width, Renderer.WindowSize.Height / 2.0f );
            OpenGLNative.Vertex2f( Renderer.WindowSize.Width, 0 );
            OpenGLNative.Vertex2f( 0, 0 );

            OpenGLNative.End();
        }

        public void Update( float elapsed )
        {
        }
    }
}