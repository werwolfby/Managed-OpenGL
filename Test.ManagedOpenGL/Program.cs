using System;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL.TestSample;

namespace Test.ManagedOpenGL
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			//Application.Run( new TestForm() );
			OpenGLApplication.Run( new TestSampleForm() );
		}
	}
}
