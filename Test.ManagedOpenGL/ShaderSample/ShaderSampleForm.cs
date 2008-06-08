/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 08.06.2008 21:10
 *
 * File: ShaderSampleForm.cs
 * Remarks:
 * 
 * History:
 *   08.06.2008 21:10 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Cameras;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;

namespace Test.ManagedOpenGL.ShaderSample
{
	using gl=OpenGLNative;

	public class ShaderSampleForm : OpenGLForm
	{
		private uint program;
		private int lightPositionLocation;
		private int BrickColorLocation, MortalColorLocation;
		private int BrickSizeLocation;
		private int BrickPctLocation;
		private readonly TwoDirCamera camera = new TwoDirCamera
		                                       {
		                                       	VelocitySpeed = 20,
		                                       	StrafeSpeed = 20,
		                                       };
		private readonly Cube cube = new Cube( 20, 20, 20 );
		private const string vertexShaderFileName = @"Data\Shader\sample.vert";
		private const string fragmentShaderFileName = @"Data\Shader\sample.frag";

		private readonly string vertexShaderText;
		private readonly string fragmentShaderText;

		public ShaderSampleForm()
		{
			WindowSize = new Size( 640, 480 );
			Renderer.Near = 2;
			Renderer.Far = 200;

			using (var vertReader = new StreamReader( vertexShaderFileName )) vertexShaderText = vertReader.ReadToEnd();
			using (var fragReader = new StreamReader( fragmentShaderFileName )) fragmentShaderText = fragReader.ReadToEnd();
		}

		protected override void AfterInitGLOverride() 
		{
			base.AfterInitGLOverride();

			camera.Position.Set( 0, 0, 50 );

			var vertexShaderObject = gl.CreateShaderObjectARB( (uint)VERSION_2_0.VertexShader );
			var fragmentShaderObject = gl.CreateShaderObjectARB( (uint)VERSION_2_0.FragmentShader );

			gl.ShaderSourceARB( vertexShaderObject, 1, new[] { vertexShaderText }, null );
			gl.ShaderSourceARB( fragmentShaderObject, 1, new[] { fragmentShaderText }, null );

			var results = new int[1];
			gl.CompileShaderARB( vertexShaderObject );
			OpenGL.GetObjectParameterivARB( vertexShaderObject, ARB_shader_objects.ObjectCompileStatusArb, results );
			if (results[0] == 0) throw new Exception( "Vertex shader compile error\n" + OpenGL.GetInfoLog( vertexShaderObject ) );

			gl.CompileShaderARB( fragmentShaderObject );
			OpenGL.GetObjectParameterivARB( fragmentShaderObject, ARB_shader_objects.ObjectCompileStatusArb, results );
			if (results[0] == 0) throw new Exception( "Fragment shader compile error\n" + OpenGL.GetInfoLog( fragmentShaderObject ) );

			this.program = gl.CreateProgram();
			gl.AttachObjectARB( this.program, vertexShaderObject );
			gl.AttachObjectARB( this.program, fragmentShaderObject );
			gl.LinkProgramARB( this.program );

			OpenGL.GetObjectParameterivARB( this.program, ARB_shader_objects.ObjectLinkStatusArb, results );
			if (results[0] == 0) throw new Exception( "Shader link error\n" + OpenGL.GetInfoLog( program ) );

			this.lightPositionLocation = OpenGLNative.GetUniformLocationARB( program, "LightPosition" );
			this.BrickColorLocation = OpenGLNative.GetUniformLocationARB( program, "BrickColor" );
			this.MortalColorLocation = OpenGLNative.GetUniformLocationARB( program, "MortalColor" );
			this.BrickSizeLocation = OpenGLNative.GetUniformLocationARB( program, "BrickSize" );
			this.BrickPctLocation = OpenGLNative.GetUniformLocationARB( program, "BrickPct" );
		}

		protected override void Draw() 
		{
			OpenGLNative.ClearColor( 1, 1, 1, 1 );
			OpenGLNative.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			OpenGLNative.MatrixMode( MatrixMode.Modelview );
			OpenGLNative.LoadMatrixf( camera.Data );

			OpenGLNative.UseProgramObjectARB( program );
			OpenGLNative.Uniform3fARB( BrickColorLocation, 1, 0, 0 );
			OpenGLNative.Uniform3fARB( MortalColorLocation, 1, 1, 1 );
			OpenGLNative.Uniform2fARB( BrickSizeLocation, 0.35f*3, 0.15f*3 );
			OpenGLNative.Uniform2fARB( BrickPctLocation, 0.90f, 0.85f );

			gl.Enable( EnableCap.DepthTest );
			gl.Enable( EnableCap.CullFace );

			gl.Color3f( 0, 0, 0 );
			cube.Draw();
		}

		protected override void OnMouseMove( MouseEventArgs e ) 
		{
			base.OnMouseMove( e );

			var oldPosition = this.PointToClient( Cursor.Position );
			var centerPosition = new Point( ClientSize.Width / 2, ClientSize.Height / 2 );

			if (oldPosition == centerPosition) return;

			var deltaX = - oldPosition.X + centerPosition.X;
			var deltaY = - oldPosition.Y + centerPosition.Y;

			camera.TurnLeft( deltaX );
			camera.LookUp( deltaY );

			Cursor.Position = this.PointToScreen( centerPosition );
		}

		protected override void Update( float elapsed ) 
		{
			base.Update( elapsed );

			if (Keyboard.GetValue( Keys.A )) camera.MoveLeft( elapsed );
			if (Keyboard.GetValue( Keys.D )) camera.MoveRight( elapsed );
			if (Keyboard.GetValue( Keys.W )) camera.MoveForward( elapsed );
			if (Keyboard.GetValue( Keys.S )) camera.MoveBack( elapsed );
			
			if (Keyboard.GetValue( Keys.C )) camera.Position.Set( 0, 0, 0 );

			if (Keyboard.GetValue( Keys.ShiftKey ))
			{
				camera.VelocitySpeed = 200;
				camera.StrafeSpeed = 200;
			}
			else
			{
				camera.VelocitySpeed = 20;
				camera.StrafeSpeed = 20;
			}
		}
	}
}