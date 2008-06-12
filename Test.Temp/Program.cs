using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManagedOpenGL.Engine.Windows;

namespace Test.Temp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			OpenGLApplication.Run( new TestForm() );
		}
	}
}
