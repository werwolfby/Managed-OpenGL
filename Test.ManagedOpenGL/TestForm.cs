using System;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL.MultiTextureSample;

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
	}
}
