using System;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL.CubeMap2Sample;
using Test.ManagedOpenGL.CubeMapSample;
using Test.ManagedOpenGL.DepthReflectionExample;
using Test.ManagedOpenGL.EnviromentCubeMapSample;
using Test.ManagedOpenGL.FontsSample;
using Test.ManagedOpenGL.MultiTextureSample;
using Test.ManagedOpenGL.NormalizeCubeMapSample;
using Test.ManagedOpenGL.NormalMapSample;
using Test.ManagedOpenGL.ParallaxMappingSample;
using Test.ManagedOpenGL.PhysXSample;
using Test.ManagedOpenGL.RenderToTextureSample;
using Test.ManagedOpenGL.ShaderSample;
using Test.ManagedOpenGL.SkyBoxSample;
using Test.ManagedOpenGL.TestSample;

namespace Test.ManagedOpenGL
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			RunSample<MultiTextureSampleForm>();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			RunSample<SkyBoxSampleForm>();
		}

		private void button3_Click( object sender, EventArgs e )
		{
			RunSample<FontsSampleForm>();
		}

		private void button4_Click( object sender, EventArgs e )
		{
			RunSample<CubeMapSampleForm>();
		}

		private void button5_Click( object sender, EventArgs e )
		{
			RunSample<ShaderSampleForm>();
		}

		private void button6_Click( object sender, EventArgs e )
		{
			RunSample<NormalMapSampleForm>();
		}

		private void button7_Click( object sender, EventArgs e )
		{
			RunSample<NormalizeCubeMapForm>();
		}

		private void button8_Click( object sender, EventArgs e )
		{
			RunSample<EnviromentCubeMapForm>();
		}

		private void button9_Click( object sender, EventArgs e )
		{
			this.RunSample<RenderToTextureForm>();
		}

		private void button10_Click( object sender, EventArgs e )
		{
			this.RunSample<DepthReflectionForm>();
		}

		private void button11_Click( object sender, EventArgs e )
		{
			this.RunSample<CubeMap2Form>();
		}

		private void button12_Click( object sender, EventArgs e )
		{
			this.RunSample<ParallaxMappingForm>();
		}

		private void button13_Click( object sender, EventArgs e )
		{
			this.RunSample<PhysXForm>();
		}

		private void button14_Click( object sender, EventArgs e )
		{
			this.RunSample<TestSampleForm>();
		}

		private void RunSample<T>()
			where T : OpenGLForm, new()
		{
			try
			{
				var form = new T();
				this.Visible = false;
				OpenGLApplication.Run( form );
				this.Visible = true;
			}
			catch (Exception e)
			{
				throw e.InnerException;
			}
		}
	}
}
