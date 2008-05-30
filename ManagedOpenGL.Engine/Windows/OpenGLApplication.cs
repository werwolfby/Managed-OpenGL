/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 30.05.2008 17:39
 *
 * File: OpenGLApplication.cs
 * Remarks:
 * 
 * History:
 *   30.05.2008 17:39 - Create Wireframe
 *
 *******************************************************/

using System.Windows.Forms;

namespace ManagedOpenGL.Engine.Windows
{
	public static class OpenGLApplication
	{
		public static void Run( OpenGLForm openGLForm )
		{
			var run = true;

			openGLForm.Closed += ( sender, e ) => run = false;

			while (run)
			{
				openGLForm.Update();
				Application.DoEvents();
			}
		}
	}
}