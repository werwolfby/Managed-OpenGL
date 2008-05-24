using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedOpenGL;

namespace Test.ManagedOpenGL
{
	class Program
	{
		static void Main( string[] args )
		{
			OpenGLNative.BlendEquationSeparate( BlendEquationModeEXT.MinExt, BlendEquationModeEXT.AlphaMaxSgix );
		}
	}
}
