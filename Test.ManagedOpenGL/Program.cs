using System;
using System.Windows.Forms;

namespace Test.ManagedOpenGL
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			Application.Run( new OpenGLForm() );
		}
	}
}
