/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.12.2008 19:28
 *
 * File: PhysXBox.cs
 * Remarks:
 * 
 * History:
 *   26.12.2008 19:28 - Create Wireframe
 *
 *******************************************************/

using System;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Objects;
using Microsoft.DirectX;
using StillDesign.PhysX;

namespace Test.ManagedOpenGL.PhysXSample
{
	public class PhysXBox : Cube
	{
		private readonly Actor actor;

		public PhysXBox( float width, float height, float length, Scene scene ) : base( width, height, length )
		{
			if (scene == null) throw new ArgumentNullException( "scene" );

			this.actor = CreateBoxActor( scene, width, height, length );
		}

		public Actor Actor
		{
			get { return this.actor; }
		}

		private static Actor CreateBoxActor( Scene scene, float sizeX, float sizeY, float sizeZ )
		{
			var actorDesc = new ActorDescription();
			var bodyDesc = new BodyDescription();

			var boxDesc = new BoxShapeDescription( sizeX, sizeY, sizeZ );

			actorDesc.Shapes.Add( boxDesc );

			actorDesc.BodyDescription = bodyDesc;
			actorDesc.Density = 10;

			return scene.CreateActor( actorDesc );
		}

		public void SetPosition( Matrix4F position )
		{
			this.Position = position;
			this.actor.GlobalPose = (Matrix)position;
		}

		public override void DrawOverride()
		{
			this.Position.Set( actor.GlobalPose );
			base.DrawOverride();
		}
	}
}