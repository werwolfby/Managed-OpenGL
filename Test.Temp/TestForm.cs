/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 12.06.2008 15:16
 *
 * File: TestForm.cs
 * Remarks:
 * 
 * History:
 *   12.06.2008 15:16 - Create Wireframe
 *   22.06.2008 19:13 - Test positive camera
 *
 *******************************************************/

using System;
using System.Drawing;
using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Windows;
using Test.ManagedOpenGL;

using gl=ManagedOpenGL.OpenGLNative;

namespace Test.Temp
{
	public class TestForm : SampleOpenGLForm
	{
		private const TextureWrapMode clamp = TextureWrapMode.Clamp;
		private const int size = 2400;

		private readonly Skybox skybox = new Skybox( size, size, size,
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\back.png" )   { WrapS = clamp, WrapT = clamp },
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\front.png" )  { WrapS = clamp, WrapT = clamp },
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\left.png" )   { WrapS = clamp, WrapT = clamp },
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\right.png" )  { WrapS = clamp, WrapT = clamp },
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\bottom.png" ) { WrapS = clamp, WrapT = clamp },
		                                             new Texture2D( @"Data\SkyBox\CubeMap2\top.png" )    { WrapS = clamp, WrapT = clamp } );

		private class PositiveCamera
		{
			private float cosPitch = 1, sinPitch;
			private float cosYaw   = 1, sinYaw;
			private float pitch, yaw;

			private readonly Matrix4F matrix = new Matrix4F();

			public float Pitch
			{
				get { return this.pitch; }
				set
				{
					if (this.pitch == value) return;
					this.pitch = value;
					this.cosPitch = (float)Math.Cos( this.pitch );
					this.sinPitch = (float)Math.Sin( this.pitch );

					UpdateMatrix();
				}
			}

			public float Yaw
			{
				get { return this.yaw; }
				set
				{
					if (value > +Math.PI / 2) value = (float)(+Math.PI / 2);
					if (value < -Math.PI / 2) value = (float)(-Math.PI / 2);
					if (this.yaw == value) return;
					this.yaw = value;
					this.cosYaw = (float)Math.Cos( this.yaw );
					this.sinYaw = (float)Math.Sin( this.yaw );

					UpdateMatrix();
				}
			}

			public float[] Data
			{
				get { return this.matrix.Data; }
			}

			private void UpdateMatrix()
			{
				matrix[0] = +cosPitch;          matrix[4] = 0;       matrix[08] = sinPitch;
				matrix[1] = -sinPitch * sinYaw; matrix[5] = +cosYaw; matrix[09] = cosPitch*sinYaw;
				matrix[2] = -sinPitch * cosYaw; matrix[6] = -sinYaw; matrix[10] = cosPitch*cosYaw;
			}
		}

		private readonly PositiveCamera positiveCamera = new PositiveCamera();

		public TestForm()
		{
			WindowSize = new Size( 640, 480 );

			camera.Position.Set( 0, 0, 50 );

			Renderer.Near = 1;
			Renderer.Far = 5000;
		}

		protected override void AfterInitGLOverride()
		{
			base.AfterInitGLOverride();

			skybox.Load();
		}

		protected override void Draw() 
		{
			camera.Pitch += 0.0001f;
			camera.Yaw   += 0.0001f;

			base.Draw();

			//positiveCamera.Pitch += 0.0001f;
			//positiveCamera.Yaw += 0.0001f;

			//gl.MatrixMode( MatrixMode.Modelview );
			//gl.LoadIdentity();
			//gl.LoadMatrixf( positiveCamera.Data );

			gl.Enable( EnableCap.Texture2d );
			skybox.Draw();
			gl.Disable( EnableCap.Texture2d );
		}
	}
}