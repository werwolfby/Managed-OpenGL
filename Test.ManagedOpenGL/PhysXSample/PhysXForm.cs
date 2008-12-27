/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.12.2008 10:22
 *
 * File: PhysXForm.cs
 * Remarks:
 * 
 * History:
 *   26.12.2008 10:22 - Create Wireframe
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;
using Microsoft.DirectX;
using StillDesign.PhysX;
using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.PhysXSample
{
	public class PhysXForm : SampleOpenGLForm
	{
		private readonly Skybox skybox = new Skybox( 100, 100, 100,
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\back.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\front.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\left.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\right.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" ),
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\top.png" ) );

		private readonly Core core = new Core();

		private readonly PhysXBox box;

		private readonly Scene scene;
		private readonly Material material1;

		private readonly Vector3F lightPosition = new Vector3F( 10, 30, 10 );

		private readonly List<PhysXBox> boxes = new List<PhysXBox>();

		private readonly Font font = new Font( @"Data\Fonts\Verdana.jpg" );

		public PhysXForm()
		{
			this.scene = this.core.CreateScene( new SceneDescription
			                                    {
			                                    	Gravity = new Vector3( 0, -9.8f, 0 ),
			                                    	SimulationType = SimulationType.Software,
			                                    } );

			this.material1 = this.scene.Materials[0];
			this.material1.Restitution = 1;
			this.material1.StaticFriction = 0.5f;
			this.material1.DynamicFriction = 0.5f;

			this.box = new PhysXBox( 10f, 10f, 10f, scene );
			this.box.SetPosition( Matrix4F.RotateX( 30 ) * Matrix4F.Translate( 0, 10, 0 ) );

			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( 0, 1, 0, - skybox.Height / 2 ) ) );
			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( 0, -1, 0, - skybox.Height / 2 ) ) );
			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( 1, 0, 0, - skybox.Width / 2 ) ) );
			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( -1, 0, 0, - skybox.Width / 2 ) ) );
			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( 0, 0, 1, - skybox.Length / 2 ) ) );
			this.scene.CreateActor( new ActorDescription( new PlaneShapeDescription( 0, 0, -1, - skybox.Length / 2 ) ) );

			this.camera.Position.Z = 10;
			this.camera.Position.Y = 10;

			this.RegisterPressed( Keys.Up,
			                      elapsed =>
			                      {
			                      	var forseDirection = new Vector3( 0, 40000, 0 );
			                      	box.Actor.AddForce( forseDirection, ForceMode.Force );
			                      } );

			Keyboard.KeyDown += ( sender, e ) =>
			                    {
			                    	if (e.KeyCode == Keys.Space)
			                    	{
			                    		var xBox = new PhysXBox( 5, 5, 5, this.scene );

										xBox.SetPosition( Matrix4F.Translate( camera.Position ) );
                                        xBox.Actor.AddForce(
			                    			new Vector3( camera.ZDirection.X, camera.ZDirection.Y, camera.ZDirection.Z ) * xBox.Actor.Mass *
			                    			20000, ForceMode.Force );

			                    		boxes.Add( xBox );
			                    	}
			                    };
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			this.skybox.Load();

			this.font.Load();

			gl.Enable( EnableCap.Light0 );

			gl.Lightfv( LightName.Light0, LightParameter.Position, lightPosition.Data );
		}

		protected override void Draw()
		{
			base.Draw();

			Renderer.RenderMode = RenderMode.MODE_3D;

			gl.ClearColor( 0, 0, 0, 1 );
			gl.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

			gl.TexEnvi( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Decal );

			gl.Enable( EnableCap.Texture2d );
			this.skybox.Draw();
			gl.Disable( EnableCap.Texture2d );

			gl.Color3f( 1, 0, 0 );

			gl.Enable( EnableCap.Lighting );
			gl.Lightfv( LightName.Light0, LightParameter.Position, lightPosition.Data );

			gl.Materialfv( MaterialFace.Front, MaterialParameter.Diffuse, new float[] { 1, 0, 0, 0 } );
			gl.Materialfv( MaterialFace.Front, MaterialParameter.Ambient, new float[] { 1, 0, 0, 0 } );

			this.box.Draw();

			foreach (var xBox in boxes)
			{
				xBox.Draw();
			}

			gl.Disable( EnableCap.Lighting );

			Renderer.RenderMode = RenderMode.MODE_2D;

			gl.Enable( EnableCap.Texture2d );
			font.FontSize = 20;
			font.WriteLine( "Test String = {0}", this.box.Actor.Mass );

			var renderable = this.scene.GetDebugRenderable();

			gl.Begin( BeginMode.Points );
			var points = renderable.GetDebugPoints();
			foreach (var point in points)
			{
				gl.Color3i( (point.Color & 0x00ff0000) >> 16, (point.Color & 0x0000ff00) >> 8, point.Color & 0x000000ff );
				gl.Vertex3f( point.Point.X, point.Point.Y, point.Point.Z );
			}
			gl.End();

			gl.Begin( BeginMode.Lines );
			var lines = renderable.GetDebugLines();
			foreach (var line in lines)
			{
				gl.Color3i( (line.Color & 0x00ff0000) >> 16, (line.Color & 0x0000ff00) >> 8, line.Color & 0x000000ff );

				gl.Vertex3f( line.Point0.X, line.Point0.Y, line.Point0.Z );
				gl.Vertex3f( line.Point1.X, line.Point1.Y, line.Point1.Z );
			}
			gl.End();
		}

		protected override void Update( float elapsed )
		{
			base.Update( elapsed );

			scene.Simulate( elapsed );
			scene.FlushStream();

			scene.FetchResults( SimulationStatus.RigidBodyFinished, true );
		}

		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
			if (!disposing)
			{
				scene.Dispose();
				core.Dispose();
			}
		}
	}
}