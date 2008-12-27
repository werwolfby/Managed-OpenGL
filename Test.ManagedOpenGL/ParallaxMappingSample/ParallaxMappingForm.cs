/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 24.06.2008 11:50
 *
 * File: ParallaxMappingForm.cs
 * Remarks:
 * 
 * History:
 *   24.06.2008 11:50 - Create Wireframe
 *
 *******************************************************/

using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Shaders;
using ManagedOpenGL.Engine.Windows;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.ParallaxMappingSample
{
	public class ParallaxMappingForm : SampleOpenGLForm
	{
		private class ParallaxShaderProgram : ShaderProgram
		{
			private int textureUniformLocation;
			private int heightMapUniformLocation;
			private int normalMapUniformLocation;

			private int eyeUniformLocation;

			public int TextureUnit { get; set; }

			public int HeightMapUnit { get; set; }

			public int NormalMapUnit { get; set; }

			public uint TangentAttribLocation { get; private set; }

			public uint BinormalAttribLocation { get; private set; }

			public Vector3F Eye { get; set;  }

			public ParallaxShaderProgram()
			{
				TextureUnit = 0;
				HeightMapUnit = 1;
				NormalMapUnit = 2;

				this.Eye = new Vector3F( 0, 0, 0 );
			}

			protected override void AfterLink()
			{
				base.AfterLink();

				this.textureUniformLocation = GetUniformLocation( "texture" );
				this.heightMapUniformLocation = GetUniformLocation( "heightMap" );
				this.normalMapUniformLocation = GetUniformLocation( "normalMap" );

				this.eyeUniformLocation = GetUniformLocation( "eye" );

				this.TangentAttribLocation = (uint)this.GetAttribLocation( "tangent" );
				this.BinormalAttribLocation = (uint)this.GetAttribLocation( "binormal" );
			}

			public override void Use()
			{
				base.Use();

				gl.Uniform1i( textureUniformLocation, TextureUnit );
				gl.Uniform1i( heightMapUniformLocation, HeightMapUnit );
				gl.Uniform1i( normalMapUniformLocation, NormalMapUnit );

				gl.Uniform3f( eyeUniformLocation, Eye.X, Eye.Y, Eye.Z );
			}
		}

		private readonly ParallaxShaderProgram[] programs;
		private int programIndex;

		private readonly Texture2D texture;
		private readonly Texture2D textureHeight;
		private readonly Texture2D textureNormal;

		public ParallaxMappingForm()
		{
			this.texture = new Texture2D( @"Data\ParallaxMapping\Maps\rockwall.jpg" ).ApplyTexture( this.itemsManager );
			this.textureHeight = new Texture2D( @"Data\ParallaxMapping\Maps\rockwall_height.png" )
			                     {
			                     	WrapS = TextureWrapMode.ClampToEdgeSgis,
			                     	WrapT = TextureWrapMode.ClampToEdgeSgis
			                     }.ApplyTexture( this.itemsManager );
			this.textureNormal = new Texture2D( @"Data\ParallaxMapping\Maps\rockwall_normal.png" )
			                     {
			                     	WrapS = TextureWrapMode.ClampToEdgeSgis,
			                     	WrapT = TextureWrapMode.ClampToEdgeSgis
			                     }.ApplyTexture( this.itemsManager );
			
			this.programs = new[]
			                {
			                	ShaderProgram.Create<ParallaxShaderProgram>( @"Data\ParallaxMapping\parallax.vert",
			                	                                             @"Data\ParallaxMapping\parallax.frag" ).
			                		ApplyProgram( itemsManager ),
			                	ShaderProgram.Create<ParallaxShaderProgram>( @"Data\ParallaxMapping\parallax.vert",
			                	                                             @"Data\ParallaxMapping\parallax1.frag" ).
			                		ApplyProgram( itemsManager ),
			                	ShaderProgram.Create<ParallaxShaderProgram>( @"Data\ParallaxMapping\parallax.vert",
			                	                                             @"Data\ParallaxMapping\relief1.frag" ).
			                		ApplyProgram( itemsManager ),
			                };

			camera.Position.Z = 50;
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			foreach (var program in programs)
			{
				program.TextureUnit = 0;
				program.HeightMapUnit = 1;
				program.NormalMapUnit = 2;

				program.Eye = camera.Position;
			}

			gl.Hint( HintTarget.PerspectiveCorrectionHint, HintMode.Nicest );
		}

		protected override void Draw()
		{
			base.Draw();

			gl.Enable( EnableCap.Texture2d );
			gl.ActiveTexture( (uint)VERSION_1_3.Texture0 );
			this.texture.Use();
			
			gl.ActiveTexture( (uint)VERSION_1_3.Texture1 );
			this.textureHeight.Use();
			
			gl.ActiveTexture( (uint)VERSION_1_3.Texture2 );
			this.textureNormal.Use();

			this.programs[programIndex].Use();
			
			gl.Begin( BeginMode.Quads );

			gl.VertexAttrib3f( programs[programIndex].TangentAttribLocation, 1, 0, 0 );
			gl.VertexAttrib3f( programs[programIndex].BinormalAttribLocation, 0, 1, 0 );
			gl.Normal3f( 0, 0, 1 );

			gl.TexCoord2f( 0, 0 );
			gl.Vertex3f( -10, -10, 0 );

			gl.TexCoord2f( 1, 0 );
			gl.Vertex3f( +10, -10, 0 );

			gl.TexCoord2f( 1, 1 );
			gl.Vertex3f( +10, +10, 0 );

			gl.TexCoord2f( 0, 1 );
			gl.Vertex3f( -10, +10, 0 );

			gl.End();
			gl.Disable( EnableCap.Texture2d );
		}

		protected override void OnKeyDown( KeyEventArgs e )
		{
			base.OnKeyDown( e );

			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) return;

			var item = e.KeyCode - Keys.D0;
			if (item < this.programs.Length) this.programIndex = item;
		}
	}
}