using System;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL.CubeMapSample;
using Test.ManagedOpenGL.FontsSample;
using Test.ManagedOpenGL.MultiTextureSample;
using Test.ManagedOpenGL.ShaderSample;
using Test.ManagedOpenGL.SkyBoxSample;

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

		private void RunSample<T>()
			where T : OpenGLForm, new()
		{
			var form = new T();
			this.Visible = false;
			OpenGLApplication.Run( form );
			this.Visible = true;
		}
	}
}
