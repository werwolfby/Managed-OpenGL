/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 30.05.2008 17:44
 *
 * File: MultiTextureSampleForm.cs
 * Remarks:
 * 
 * History:
 *   30.05.2008 17:44 - Create Wireframe
 *
 *******************************************************/

using System.Drawing;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.MultiTextureSample
{
	public class MultiTextureSampleForm : OpenGLForm
	{
		private float angle;
		private readonly Texture2D texture1 = new Texture2D( @"Data\MultiTexture\bg.jpg" );
		private readonly Texture2D texture2 = new Texture2D( @"Data\MultiTexture\logo.gif" );

		public MultiTextureSampleForm()
		{
			WindowSize = new Size( 800, 600 );
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			texture1.Load();
			texture2.Load();

			texture2.WrapS = TextureWrapMode.ClampToEdgeSgis;
			texture2.WrapT = TextureWrapMode.ClampToEdgeSgis;
		}

		protected override void Draw() 
		{
			OpenGLNative.ClearColor( 0.1f, 0.1f, 0.1f, 0.0f );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( -5, 0, -25 );

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture1.Use();

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture1 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture2.Use();
			OpenGLNative.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Decal );
			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( 0.5f, 0.5f, 0 );
			OpenGLNative.Rotatef( angle, 0, 0, -1 );
			OpenGLNative.Translatef( -0.5f, -0.5f, 0 );
			
			DrawQuad();

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( 5, 0, -25 );

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture1.Use();

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture1 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			texture2.Use();
			OpenGLNative.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Modulate );
			OpenGLNative.MatrixMode( MatrixMode.Texture );
			OpenGLNative.LoadIdentity();
			OpenGLNative.Translatef( 0.5f, 0.5f, 0 );
			OpenGLNative.Rotatef( angle, 0, 0, -1 );
			OpenGLNative.Translatef( -0.5f, -0.5f, 0 );
			
			DrawQuad();
		}

		private static void DrawQuad() 
		{
			var size = 4;

			OpenGLNative.Begin( BeginMode.Quads );
			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture0, 0, 1 );
			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture1, -0.25f, 1.45f );
			OpenGLNative.Color3f( size, size, size );
			OpenGLNative.Vertex3f( -size, -size, 0 );

			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture0, 1, 1 );
			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture1, 1.25f, 1.45f );
			OpenGLNative.Color3f( size, size, size );
			OpenGLNative.Vertex3f(  size, -size, 0 );

			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture0, 1, 0 );
			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture1, 1.25f, -0.45f );
			OpenGLNative.Color3f( size, size, size );
			OpenGLNative.Vertex3f(  size,  size, 0 );

			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture0, 0, 0 );
			OpenGLNative.MultiTexCoord2f( (uint)VERSION_1_3.Texture1, -0.25f, -0.45f );
			OpenGLNative.Color3f( size, size, size );
			OpenGLNative.Vertex3f( -size,  size, 0 );
			OpenGLNative.End();
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			angle += 360 * elapsed / 3;
		}
	}
}