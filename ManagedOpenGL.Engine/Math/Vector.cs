/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:27
 *
 * File: Vector.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 13:36 - Create Wireframe
 *   31.05.2008 10:27 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using System;
using System.Diagnostics;

namespace ManagedOpenGL.Engine.Math
{

	#region Float Vectors
	[DebuggerDisplay("({X.ToString(\"F2\"),nq},{Y.ToString(\"F2\"),nq})")]
	public class Vector2F
	{
		private readonly float[] data = new float[2];

		public event EventHandler Changed;

		public Vector2F( float x, float y )
		{
			this.X = x;
			this.Y = y;
		}

		public float X
		{
			get { return this.data[0]; }
			set
			{
				if (this.data[0] == value) return;
				this.data[0] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Y
		{
			get { return this.data[1]; }
			set
			{
				if (this.data[1] == value) return;
				this.data[1] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float[] Data
		{
			get { return this.data; }
		}

		public float Length
		{
			get
			{
				return (float)System.Math.Sqrt( this * this );
			}
		}

		public void Normalize()
		{
			this.X /= Length;
			this.Y /= Length;
		}

		public static float operator * (Vector2F a, Vector2F b)
		{
			return a.X * b.X + a.Y * b.Y;
		}

		public static Vector2F operator * (Vector2F v, float a)
		{
			return new Vector2F( v.X * a, v.Y * a );
		}

		public static Vector2F operator + (Vector2F a, Vector2F b)
		{
			return new Vector2F( a.X + b.X, a.Y + b.Y );
		}

		public static Vector2F operator - (Vector2F a, Vector2F b)
		{
			return new Vector2F( a.X - b.X, a.Y - b.Y );
		}

		public static Vector2F operator -(Vector2F a)
		{
			return new Vector2F( -a.X, -a.Y );
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}

		public static implicit operator Vector2F( float[] array )
		{
			if (array.Length != 2) throw new ArgumentException( "array" );

			return new Vector2F( array[0], array[1] );
		}
	}
	
	[DebuggerDisplay("({X.ToString(\"F2\"),nq},{Y.ToString(\"F2\"),nq},{Z.ToString(\"F2\"),nq})")]
	public class Vector3F
	{
		private readonly float[] data = new float[3];

		public event EventHandler Changed;

		public Vector3F( float x, float y, float z )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public float X
		{
			get { return this.data[0]; }
			set
			{
				if (this.data[0] == value) return;
				this.data[0] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Y
		{
			get { return this.data[1]; }
			set
			{
				if (this.data[1] == value) return;
				this.data[1] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Z
		{
			get { return this.data[2]; }
			set
			{
				if (this.data[2] == value) return;
				this.data[2] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float[] Data
		{
			get { return this.data; }
		}

		public float Length
		{
			get
			{
				return (float)System.Math.Sqrt( this * this );
			}
		}

		public void Normalize()
		{
			this.X /= Length;
			this.Y /= Length;
			this.Z /= Length;
		}

		public static float operator * (Vector3F a, Vector3F b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}

		public static Vector3F operator * (Vector3F v, float a)
		{
			return new Vector3F( v.X * a, v.Y * a, v.Z * a );
		}

		public static Vector3F operator ^ (Vector3F a, Vector3F b)
		{
			return new Vector3F( a.Y * b.Z - b.Y * a.Z,
			                     a.Z * b.X - b.Z * a.X,
			                     a.X * b.Y - b.X * a.Y );
		}

		public static Vector3F operator + (Vector3F a, Vector3F b)
		{
			return new Vector3F( a.X + b.X, a.Y + b.Y, a.Z + b.Z );
		}

		public static Vector3F operator - (Vector3F a, Vector3F b)
		{
			return new Vector3F( a.X - b.X, a.Y - b.Y, a.Z - b.Z );
		}

		public static Vector3F operator -(Vector3F a)
		{
			return new Vector3F( -a.X, -a.Y, -a.Z );
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}

		public static implicit operator Vector3F( float[] array )
		{
			if (array.Length != 3) throw new ArgumentException( "array" );

			return new Vector3F( array[0], array[1], array[2] );
		}

		public Vector4F ToVector4()
		{
			return new Vector4F( X, Y, Z );
		}

		public void MultiplyOn( float value )
		{
			this.X *= value;
			this.Y *= value;
			this.Z *= value;
		}

		public void Set( Vector3F pos )
		{
			Set( pos.X, pos.Y, pos.Z );
		}

		public void Set( float x, float y, float z )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;

			RaiseChanged( EventArgs.Empty );
		}
	}
	
	[DebuggerDisplay("({X.ToString(\"F2\"),nq};{Y.ToString(\"F2\"),nq};{Z.ToString(\"F2\"),nq};{W.ToString(\"F2\"),nq})")]
	public class Vector4F
	{
		private readonly float[] data = new float[4];
		private float inverseW;

		public event EventHandler Changed;

		public Vector4F( float x, float y, float z ) : this(x, y, z, 1) {}

		public Vector4F( float x, float y, float z, float w )
		{
			this.Set( x, y, z, w );
		}

		public float X
		{
			get { return this.data[0]; }
			set
			{
				if (this.data[0] == value) return;
				this.data[0] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Y
		{
			get { return this.data[1]; }
			set
			{
				if (this.data[1] == value) return;
				this.data[1] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float Z
		{
			get { return this.data[2]; }
			set
			{
				if (this.data[2] == value) return;
				this.data[2] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float W
		{
			get { return this.data[3]; }
			set
			{
				if (this.data[3] == value) return;
				this.data[3] = value;
				this.inverseW = 1.0f / this.data[3];
				RaiseChanged( EventArgs.Empty );
			}
		}

		public float[] Data
		{
			get { return this.data; }
		}

		public float Length
		{
			get
			{
				return (float)System.Math.Sqrt( this * this );
			}
		}

		public void Normalize()
		{
			this.X /= Length;
			this.Y /= Length;
			this.Z /= Length;
		}

		public void NormolizeW()
		{
			this.X *= inverseW;
			this.Y *= inverseW;
			this.Z *= inverseW;
			this.W = 1;
		}

		public static float operator * (Vector4F a, Vector4F b)
		{
			return (a.X * b.X + a.Y * b.Y + a.Z * b.Z) * a.inverseW * b.inverseW;
		}

		public static Vector4F operator * (Vector4F v, float a)
		{
			return new Vector4F( v.X, v.Y, v.Z, v.W / a );
		}

		public static Vector4F operator ^ (Vector4F a, Vector4F b)
		{
			return new Vector4F( a.Y * b.Z - b.Y * a.Z,
			                     a.Z * b.X - b.Z * a.X,
			                     a.X * b.Y - b.X * a.Y,
			                     a.inverseW * b.inverseW );
		}

		public static Vector4F operator + (Vector4F a, Vector4F b)
		{
			return new Vector4F( a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.inverseW * b.inverseW );
		}

		public static Vector4F operator - (Vector4F a, Vector4F b)
		{
			return new Vector4F( a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.inverseW * b.inverseW );
		}

		public static Vector4F operator -(Vector4F a)
		{
			return new Vector4F( -a.X, -a.Y, -a.Z, a.W );
		}

		public void Set( float x, float y, float z, float w ) 
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}

		public void MultiplyOn( Matrix4F matrix )
		{
			var x = matrix[0] * this.X + matrix[4] * this.Y + matrix[08] * this.Z + matrix[12] * this.W;
			var y = matrix[1] * this.X + matrix[5] * this.Y + matrix[09] * this.Z + matrix[13] * this.W;
			var z = matrix[2] * this.X + matrix[6] * this.Y + matrix[10] * this.Z + matrix[14] * this.W;
			var w = matrix[3] * this.X + matrix[7] * this.Y + matrix[11] * this.Z + matrix[15] * this.W;

			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		public Vector3F ToVector3()
		{
			return new Vector3F( X*inverseW, Y*inverseW, Z*inverseW );
		}
	}
	#endregion

	#region Byte Vectors
	[DebuggerDisplay("({X},{Y},{Z})")]
	public class Vector3B
	{
		private readonly byte[] data = new byte[3];

		public event EventHandler Changed;

		public Vector3B( byte x, byte y, byte z )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public byte X
		{
			get { return this.data[0]; }
			set
			{
				if (this.data[0] == value) return;
				this.data[0] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte Y
		{
			get { return this.data[1]; }
			set
			{
				if (this.data[1] == value) return;
				this.data[1] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte Z
		{
			get { return this.data[2]; }
			set
			{
				if (this.data[2] == value) return;
				this.data[2] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte[] Data
		{
			get { return this.data; }
		}

		public byte Length
		{
			get
			{
				return (byte)System.Math.Sqrt( this * this );
			}
		}

		public void Normalize()
		{
			this.X /= Length;
			this.Y /= Length;
		}

		public static int operator * (Vector3B a, Vector3B b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}

		public static Vector3B operator * (Vector3B v, byte a)
		{
			return new Vector3B( (byte)(v.X * a), (byte)(v.Y * a), (byte)(v.Z * a) );
		}

		public static Vector3B operator ^ (Vector3B a, Vector3B b)
		{
			return new Vector3B( (byte)(a.Y * b.Z - b.Y * a.Z),
			                     (byte)(a.Z * b.X - b.Z * a.X),
			                     (byte)(a.X * b.Y - b.X * a.Y) );
		}

		public static Vector3B operator + (Vector3B a, Vector3B b)
		{
			return new Vector3B( (byte)(a.X + b.X), (byte)(a.Y + b.Y), (byte)(a.Z + b.Z) );
		}

		public static Vector3B operator - (Vector3B a, Vector3B b)
		{
			return new Vector3B( (byte)(a.X - b.X), (byte)(a.Y - b.Y), (byte)(a.Z - b.Z) );
		}

		public static Vector3B operator -(Vector3B a)
		{
			return new Vector3B( (byte)(-a.X), (byte)(-a.Y), (byte)(-a.Z) );
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}

		public static implicit operator Vector3B( byte[] array )
		{
			if (array.Length != 3) throw new ArgumentException( "array" );

			return new Vector3B( array[0], array[1], array[2] );
		}
	}
	
	[DebuggerDisplay("({X},{Y},{Z},{W})")]
	public class Vector4B
	{
		private readonly byte[] data = new byte[4];

		public event EventHandler Changed;

		public Vector4B( byte x, byte y, byte z, byte w )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		public byte X
		{
			get { return this.data[0]; }
			set
			{
				if (this.data[0] == value) return;
				this.data[0] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte Y
		{
			get { return this.data[1]; }
			set
			{
				if (this.data[1] == value) return;
				this.data[1] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte Z
		{
			get { return this.data[2]; }
			set
			{
				if (this.data[2] == value) return;
				this.data[2] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte W
		{
			get { return this.data[3]; }
			set
			{
				if (this.data[3] == value) return;
				this.data[3] = value;
				RaiseChanged( EventArgs.Empty );
			}
		}

		public byte[] Data
		{
			get { return this.data; }
		}

		public byte Length
		{
			get
			{
				return (byte)System.Math.Sqrt( this * this );
			}
		}

		public void Normalize()
		{
			this.X /= Length;
			this.Y /= Length;
			this.Z /= Length;
		}

		public static int operator * (Vector4B a, Vector4B b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}

		private void RaiseChanged( EventArgs e )
		{
			if (Changed != null) Changed( this, e );
		}

		public static implicit operator Vector4B( byte[] array )
		{
			if (array.Length != 4) throw new ArgumentException( "array" );

			return new Vector4B( array[0], array[1], array[2], array[3] );
		}
	}
	#endregion
}