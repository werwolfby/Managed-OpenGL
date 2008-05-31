using System;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL.FontsSample;
using Test.ManagedOpenGL.MultiTextureSample;
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
			var multiTextureSampleForm = new MultiTextureSampleForm();
			this.Visible = false;
			OpenGLApplication.Run( multiTextureSampleForm );
			this.Visible = true;
		}

		private void button2_Click( object sender, EventArgs e )
		{
			var skyBoxSampleForm = new SkyBoxSampleForm();
			this.Visible = false;
			OpenGLApplication.Run( skyBoxSampleForm );
			this.Visible = true;
		}

		private void button3_Click( object sender, EventArgs e )
		{
			var fontsSampleForm = new FontsSampleForm();
			this.Visible = false;
			OpenGLApplication.Run( fontsSampleForm );
			this.Visible = true;
		}
	}
}
