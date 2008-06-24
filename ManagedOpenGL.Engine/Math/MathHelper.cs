/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 23.06.2008 14:32
 *
 * File: MathHelper.cs
 * Remarks:
 * 
 * History:
 *   23.06.2008 14:32 - Create Wireframe
 *
 *******************************************************/

namespace ManagedOpenGL.Engine.Math
{
	public static class MathHelper
	{
		public static float ToRadian( this float angle )
		{
			return (float)(angle * System.Math.PI / 180);
		}

		public static float ToDegree( this float radians )
		{
			return (float)(radians * 180 / System.Math.PI);
		}

		public static float CosR( float radians )
		{
			return (float)System.Math.Cos( radians );
		}

		public static float SinR( float radians )
		{
			return (float)System.Math.Sin( radians );
		}

		public static float Cos( float angle )
		{
			return CosR( angle.ToRadian() );
		}

		public static float Sin( float angle )
		{
			return SinR( angle.ToRadian() );
		}
	}
}