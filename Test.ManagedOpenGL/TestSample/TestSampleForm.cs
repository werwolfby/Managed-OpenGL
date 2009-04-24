/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.12.2008 22:33
 *
 * File: TestSampleForm.cs
 * Remarks:
 * 
 * History:
 *   26.12.2008 22:33 - Create Wireframe
 *
 *******************************************************/

using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;
using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.TestSample
{
	public class TestSampleForm : SampleOpenGLForm
	{
		#region Nested type: TestShader
		private class TestShader : ShaderProgram
		{
			#region Properties
			public Vector3F Top { get; set; }

			private int TopLocation { get; set; }

			public int TextureUnit { get; set; }

			public int HeightMapUnit { get; set; }

			public float Bias { get; set; }
			
			public float Scale { get; set; }

			private int TextureLocation { get; set; }

			private int HeightMapLocation { get; set; }

			private int BiasLocation { get; set; }
			
			private int ScaleLocation { get; set; }
			#endregion

			#region Methods
			protected override void AfterLink()
			{
				base.AfterLink();

				this.TopLocation = this.TryGetUniformLocation( "top" );
				this.TextureLocation = this.TryGetUniformLocation( "texure" );
				this.HeightMapLocation = this.TryGetUniformLocation( "heightMap" );
				this.BiasLocation = this.TryGetUniformLocation( "bias" );
				this.ScaleLocation = this.TryGetUniformLocation( "scale" );
			}

			public override void Use()
			{
				base.Use();

				gl.Uniform1i( this.TextureLocation, this.TextureUnit );
				gl.Uniform1i( this.HeightMapLocation, this.HeightMapUnit );

				gl.Uniform1f( this.BiasLocation, this.Bias );
				gl.Uniform1f( this.ScaleLocation, this.Scale );

				gl.Uniform3fv( this.TopLocation, 3, this.Top.Data );
			}
			#endregion
		}
		#endregion

		#region Nested type: Vertext
		private class Vertext
		{
			#region Constructors
			public Vertext( Vector3F position, Vector2F texCoord )
			{
				this.Position = position;
				this.TexCoord = texCoord;
			}
			#endregion

			#region Properties
			public Vector3F Position { get; private set; }

			public Vector2F TexCoord { get; private set; }
			#endregion
		}
		#endregion

		#region Constants
		private const float size = 25.0f;
		private const float TopMoveSpeed = 3;
		private const float TopMoveTurboSpeed = 9;
		private const float ScaleFactor = 0.01f;
		#endregion

		#region Fields
		private readonly TestShader shader = ShaderProgram.Create<TestShader>( @"Data\Test\vert.vert",
		                                                                       @"Data\Test\frag.frag" );

		private readonly Font font = new Font( @"Data\Fonts\Verdana.jpg" );
		private readonly Texture2D texture = new Texture2D( @"Data\ParallaxMapping\Maps\rockwall.jpg" );
		private readonly Texture2D heightMap = new Texture2D( @"Data\ParallaxMapping\Maps\rockwall_height.png" );

		private readonly Vertext[] quad = new[]
		                                  {
		                                  	new Vertext( new Vector3F( -size, -size, 0 ), new Vector2F( 0, 0 ) ),
		                                  	new Vertext( new Vector3F( +size, -size, 0 ), new Vector2F( 1, 0 ) ),
		                                  	new Vertext( new Vector3F( +size, +size, 0 ), new Vector2F( 1, 1 ) ),
		                                  	new Vertext( new Vector3F( -size, +size, 0 ), new Vector2F( 0, 1 ) ),
		                                  };

		private readonly Vector3F topVector;
		private int quadIndexRotation;
		#endregion

		#region Constructors
		public TestSampleForm()
		{
			this.camera.Move( 0, 0, 50 );

			this.topVector = new Vector3F( 0, 0, 50 );
			//this.shader.Top = this.topVector;
			this.shader.Top = this.camera.Position;
			this.shader.Scale = 0.02f;

			this.shader.ApplyProgram( this.itemsManager );
			this.font.ApplyFont( this.itemsManager );
			this.texture.ApplyTexture( this.itemsManager );
			this.heightMap.ApplyTexture( this.itemsManager );

			this.RegisterPressed( Keys.Left, elapsed => this.shader.Top.X -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Right, elapsed => this.shader.Top.X += GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Down, elapsed => this.shader.Top.Y -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Up, elapsed => this.shader.Top.Y += GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.PageUp, elapsed => this.shader.Top.Z -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.PageDown, elapsed => this.shader.Top.Z += GetSpeedFactor() * elapsed );

			this.RegisterKeyDown( Keys.D1, () => this.quadIndexRotation = 0 );
			this.RegisterKeyDown( Keys.D2, () => this.quadIndexRotation = 1 );
			this.RegisterKeyDown( Keys.D3, () => this.quadIndexRotation = 2 );
			this.RegisterKeyDown( Keys.D4, () => this.quadIndexRotation = 3 );

			this.RegisterPressed( Keys.O, elapsed => this.shader.Bias -= elapsed * ScaleFactor );
			this.RegisterPressed( Keys.P, elapsed => this.shader.Bias += elapsed * ScaleFactor );

			this.RegisterPressed( Keys.K, elapsed => this.shader.Scale -= elapsed * ScaleFactor );
			this.RegisterPressed( Keys.L, elapsed => this.shader.Scale += elapsed * ScaleFactor );

			this.shader.TextureUnit = 0;
			this.shader.HeightMapUnit = 1;
		}
		#endregion

		#region Methods
		private static float GetSpeedFactor()
		{
			return (Keyboard.GetValue( Keys.ShiftKey ) ? TopMoveTurboSpeed : TopMoveSpeed);
		}

		protected override void Draw()
		{
			base.Draw();

			Renderer.RenderMode = RenderMode.MODE_3D;

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			this.texture.Use();

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture1 );
			OpenGLNative.Enable( EnableCap.Texture2d );
			this.heightMap.Use();

			this.shader.Use();

			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.Color3f( 1, 1, 1 );
			for (var i = 0; i < this.quad.Length; i++)
			{
				var quadVertex = this.quad[(i + this.quadIndexRotation) % 4];
				OpenGLNative.TexCoord2f( quadVertex.TexCoord.X, quadVertex.TexCoord.Y );
				OpenGLNative.Vertex3fv( quadVertex.Position.Data );
			}

			OpenGLNative.End();

			ShaderProgram.UnUse();

			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			OpenGLNative.Disable( EnableCap.Texture2d );
			OpenGLNative.ActiveTexture( (uint)VERSION_1_3.Texture1 );
			OpenGLNative.Disable( EnableCap.Texture2d );

			OpenGLNative.Begin( BeginMode.Lines );

			foreach (var quadVertex in this.quad)
			{
				OpenGLNative.Vertex3fv( this.topVector.Data );
				OpenGLNative.Vertex3fv( quadVertex.Position.Data );
			}

			OpenGLNative.End();

			Renderer.RenderMode = RenderMode.MODE_2D;

			this.font.ResetLocation();
			this.font.FontSize = 20;
			this.font.WriteLine( "Top = {0}", this.shader.Top );
			this.font.WriteLine( "Bias = {0}", this.shader.Bias );
			this.font.WriteLine( "Scale = {0}", this.shader.Scale );
		}
		#endregion
	}
}