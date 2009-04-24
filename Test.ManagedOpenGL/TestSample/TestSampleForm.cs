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

			public float Zoom { get; set; }

			private int TopLocation { get; set; }

			private int ZoomLocation { get; set; }
			#endregion

			public TestShader()
			{
				this.Zoom = 1;
			}

			#region Methods
			protected override void AfterLink()
			{
				base.AfterLink();

				this.TopLocation = this.GetUniformLocation( "top" );
				this.ZoomLocation = this.GetUniformLocation( "zoom" );
			}

			public override void Use()
			{
				base.Use();

				gl.Uniform3fv( this.TopLocation, 3, this.Top.Data );
				gl.Uniform1f( this.ZoomLocation, this.Zoom );
			}
			#endregion
		}
		#endregion

		#region Constants
		private const float size = 25.0f;
		private const float TopMoveSpeed = 3;
		private const float TopMoveTurboSpeed = 9;
		#endregion

		#region Fields
		private readonly TestShader shader = ShaderProgram.Create<TestShader>( @"Data\Test\vert.vert",
		                                                                       @"Data\Test\frag.frag" );
		private readonly Font font = new Font( @"Data\Fonts\Verdana.jpg" );

		private readonly Vector3F[] quad = new[]
		                                   {
		                                   	new Vector3F( -size, -size, 0 ),
		                                   	new Vector3F( +size, -size, 0 ),
		                                   	new Vector3F( +size, +size, 0 ),
		                                   	new Vector3F( -size, +size, 0 ),
		                                   };

		private readonly Vector3F topVector;
		#endregion

		#region Constructors
		public TestSampleForm()
		{
			this.camera.Move( 0, 0, 50 );

			this.topVector = new Vector3F( 0, 0, 50 );
			this.shader.Top = this.topVector;

			this.shader.ApplyProgram( this.itemsManager );
			this.font.ApplyFont( this.itemsManager );

			this.RegisterPressed( Keys.Left, elapsed => shader.Top.X -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Right, elapsed => shader.Top.X += GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Down, elapsed => shader.Top.Y -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.Up, elapsed => shader.Top.Y += GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.PageUp, elapsed => shader.Top.Z -= GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.PageDown, elapsed => shader.Top.Z += GetSpeedFactor() * elapsed );
			this.RegisterPressed( Keys.O, elapsed => shader.Zoom -= elapsed );
			this.RegisterPressed( Keys.P, elapsed => shader.Zoom += elapsed );
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

			this.shader.Use();

			OpenGLNative.Begin( BeginMode.Quads );

			OpenGLNative.Color3f( 1, 1, 1 );
			foreach (var quadVertex in this.quad)
				OpenGLNative.Vertex3fv( quadVertex.Data );

			OpenGLNative.End();

			ShaderProgram.UnUse();

			OpenGLNative.Disable( EnableCap.Texture2d );
			OpenGLNative.Begin( BeginMode.Lines );

			foreach (var quadVertex in this.quad)
			{
				OpenGLNative.Vertex3fv( this.topVector.Data );
				OpenGLNative.Vertex3fv( quadVertex.Data );
			}

			OpenGLNative.End();

			Renderer.RenderMode = RenderMode.MODE_2D;

			font.ResetLocation();
			font.FontSize = 20;
			font.WriteLine( "Top = {0}", shader.Top );
			font.WriteLine( "Zoom = {0}", shader.Zoom );
		}
		#endregion
	}
}