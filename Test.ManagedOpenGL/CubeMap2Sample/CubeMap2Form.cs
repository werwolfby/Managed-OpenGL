/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 22.06.2008 20:59
 *
 * File: CubeMap2Form.cs
 * Remarks:
 * 
 * History:
 *   22.06.2008 20:59 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.CubeMap2Sample
{
	public class CubeMap2Form : SampleOpenGLForm
	{
		private readonly Texture2D back   = new Texture2D( @"Data\SkyBox\CubeMap2\back.png" );
		private readonly Texture2D front  = new Texture2D( @"Data\SkyBox\CubeMap2\front.png" );
		private readonly Texture2D left   = new Texture2D( @"Data\SkyBox\CubeMap2\left.png" );
		private readonly Texture2D right  = new Texture2D( @"Data\SkyBox\CubeMap2\right.png" );
		private readonly Texture2D bottom = new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" );
		private readonly Texture2D top    = new Texture2D( @"Data\SkyBox\CubeMap2\top.png" );

		private readonly Texture2D[] textures;
		private readonly Skybox skybox;
		private readonly Cube cube = new Cube( 100, 100, 100 );

		private readonly float[,] rotates;

		public CubeMap2Form()
		{
			this.textures = new[]
			                {
			                	left, right, 
								bottom, top, 
								front, back
			                };
			this.rotates = new float[,]
			               {
			               	{ 0, +90, 0 }, { 0, -90, 0 },
			               	{ -90, 0, 0 }, { +90, 0, 0 },
			               	{ 0, 0, 0 },   { 0, 180, 0 },
			               };

			this.skybox = new Skybox( 1000, 1000, 1000, back, front, left, right, bottom, top );

			Renderer.Near = 1;
			Renderer.Far = 3000;

			camera.Position.Set( 0, 0, 200 );
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			foreach (var texture in textures)
			{
				texture.Load();
			}
		}

		protected override void Draw()
		{
			base.Draw();

			gl.Enable( EnableCap.Texture2d );

			this.skybox.Draw();

			back.Use();
			//cube.Draw();

			for (var i = 0; i < this.textures.Length; i++)
			{
				gl.PushMatrix();

				gl.Rotatef( rotates[i,0], 1, 0, 0 );
				gl.Rotatef( rotates[i,1], 0, 1, 0 );
				gl.Rotatef( rotates[i,2], 0, 0, 1 );
				
				gl.Translatef( 0, 0, -50 );

				var texture = this.textures[i];
				texture.Use();

				gl.MatrixMode( MatrixMode.Texture );
				gl.PushMatrix();
				gl.LoadIdentity();

				gl.Begin( BeginMode.Quads );
				
				gl.TexCoord2f( 0, 0 );
				gl.Vertex3f( -20, -20, 0 );
				
				gl.TexCoord2f( 1, 0 );
				gl.Vertex3f( +20, -20, 0 );
				
				gl.TexCoord2f( 1, 1 );
				gl.Vertex3f( +20, +20, 0 );
				
				gl.TexCoord2f( 0, 1 );
				gl.Vertex3f( -20, +20, 0 );

				gl.End();

				gl.PopMatrix();
				gl.MatrixMode( MatrixMode.Modelview );

				gl.PopMatrix();
			}
			gl.Disable( EnableCap.Texture2d );
		}
	}
}