/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 31.05.2008 10:36
 *
 * File: Matrix.cs
 * Remarks:
 * 
 * History:
 *   02.05.2008 14:09 - Create Wireframe
 *   31.05.2008 10:36 - Move to `Unit.ManagedOpenGL`
 *
 *******************************************************/

using System;
using System.Diagnostics;
using Microsoft.DirectX;

namespace ManagedOpenGL.Engine.Math
{
	public static class MatrixHelper
	{
		public static float Determinant2F( float a00, float a01,
										   float a10, float a11 )
		{
			return a00 * a11 - a10 * a01;
		}

		public static float Determinant3F( float a00, float a01, float a02,
										   float a10, float a11, float a12,
										   float a20, float a21, float a22 )
		{
			return a00 * Determinant2F( a11, a12, a21, a22 ) +
			       a01 * Determinant2F( a10, a12, a20, a22 ) -
			       a02 * Determinant2F( a10, a11, a20, a21 );
		}

		public static float Determinant4F( float a00, float a01, float a02, float a03,
										   float a10, float a11, float a12, float a13,
										   float a20, float a21, float a22, float a23,
										   float a30, float a31, float a32, float a33 )
		{
			return a00 * Determinant3F( a11, a12, a13,
										a21, a22, a23,
										a31, a32, a33 ) -
			       a01 * Determinant3F( a10, a12, a13,
										a20, a22, a23,
										a30, a32, a33 ) +
			       a02 * Determinant3F( a10, a11, a13,
										a20, a21, a23,
										a30, a31, a33 ) -
			       a03 * Determinant3F( a10, a12, a12,
										a20, a22, a22,
										a30, a32, a32 );
		}
	}

	[DebuggerDisplay( "(({data[0].ToString(\"F2\"),nq};{data[3].ToString(\"F2\"),nq};{data[6].ToString(\"F2\"),nq});" +
	                  " ({data[1].ToString(\"F2\"),nq};{data[4].ToString(\"F2\"),nq};{data[7].ToString(\"F2\"),nq});" +
	                  " ({data[2].ToString(\"F2\"),nq};{data[5].ToString(\"F2\"),nq};{data[8].ToString(\"F2\"),nq});" )]
	public class Matrix3F
	{
		private readonly float[] data = new float[9];

		public Matrix3F()
		{
			Identity();
		}

		#region Properties

		#region Element Properties

		#region First Row
		public float A00
		{
			get { return this[0, 0]; }
			set { this[0, 0] = value; }
		}

		public float A01
		{
			get { return this[0, 1]; }
			set { this[0, 1] = value; }
		}

		public float A02
		{
			get { return this[0, 2]; }
			set { this[0, 2] = value; }
		}
		#endregion

		#region Second Row
		public float A10
		{
			get { return this[1, 0]; }
			set { this[1, 0] = value; }
		}

		public float A11
		{
			get { return this[1, 1]; }
			set { this[1, 1] = value; }
		}

		public float A12
		{
			get { return this[1, 2]; }
			set { this[1, 2] = value; }
		}
		#endregion

		#region Third Row
		public float A20
		{
			get { return this[2, 0]; }
			set { this[2, 0] = value; }
		}

		public float A21
		{
			get { return this[2, 1]; }
			set { this[2, 1] = value; }
		}

		public float A22
		{
			get { return this[2, 2]; }
			set { this[2, 2] = value; }
		}
		#endregion

		#endregion

		#region Indexers
		public float this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}

		public float this[int row, int column]
		{
			get
			{
				CheckIndex( row, column );
				return data[row * 3 + column];
			}
			set
			{
				CheckIndex( row, column );
				data[row * 3 + column] = value;
			}
		}

		private static void CheckIndex( int row, int column )
		{
			if (row    < 0 || row    > 3) throw new ArgumentOutOfRangeException( "row" );
			if (column < 0 || column > 3) throw new ArgumentOutOfRangeException( "column" );
		}
		#endregion

		#endregion

		public void Identity()
		{
			data[1] = data[2] = data[3] = data[5] = data[6] = data[7] = 0;
			data[0] = data[4] = data[8] = 1;
		}

		public void Transpose()
		{
			var tmp = this.data[1]; data[1] = data[3]; data[3] = tmp;
			tmp = data[2]; data[2] = data[6]; data[6] = tmp;
			tmp = data[5]; data[5] = data[7]; data[7] = tmp;
		}

		public static Matrix3F operator+( Matrix3F a, Matrix3F b )
		{
			var sumMatrix = new Matrix3F
							{
								A00 = (a.A00 + b.A00),
								A01 = (a.A01 + b.A01),
								A02 = (a.A02 + b.A02),
								A10 = (a.A10 + b.A10),
								A11 = (a.A11 + b.A11),
								A12 = (a.A12 + b.A12),
								A20 = (a.A20 + b.A20),
								A21 = (a.A21 + b.A21),
								A22 = (a.A22 + b.A22)
							};

			return sumMatrix;
		}

		public static Matrix3F operator-( Matrix3F a, Matrix3F b )
		{
			var sumMatrix = new Matrix3F
							{
								A00 = (a.A00 - b.A00),
								A01 = (a.A01 - b.A01),
								A02 = (a.A02 - b.A02),
								A10 = (a.A10 - b.A10),
								A11 = (a.A11 - b.A11),
								A12 = (a.A12 - b.A12),
								A20 = (a.A20 - b.A20),
								A21 = (a.A21 - b.A21),
								A22 = (a.A22 - b.A22)
							};

			return sumMatrix;
		}

		public static Matrix3F operator*( Matrix3F a, float value )
		{
			var mulMatrix = new Matrix3F();

			for (var i = 0; i < mulMatrix.data.Length; i++)
				mulMatrix.data[i] = a.data[i] * value;

			return mulMatrix;
		}

		public static Matrix3F operator*( Matrix3F a, Matrix3F b )
		{
			var sumMatrix = new Matrix3F
							{
								A00 = (a[0, 0]*b[0, 0] + a[0, 1]*b[1, 0] + a[0, 2]*b[2, 0]),
								A01 = (a[0, 0]*b[0, 1] + a[0, 1]*b[1, 1] + a[0, 2]*b[2, 1]),
								A02 = (a[0, 0]*b[0, 2] + a[0, 1]*b[1, 2] + a[0, 2]*b[2, 2]),
								A10 = (a[1, 0]*b[0, 0] + a[1, 1]*b[1, 0] + a[1, 2]*b[2, 0]),
								A11 = (a[1, 0]*b[0, 1] + a[1, 1]*b[1, 1] + a[1, 2]*b[2, 1]),
								A12 = (a[1, 0]*b[0, 2] + a[1, 1]*b[1, 2] + a[1, 2]*b[2, 2]),
								A20 = (a[2, 0]*b[0, 0] + a[2, 1]*b[1, 0] + a[2, 2]*b[2, 0]),
								A21 = (a[2, 0]*b[0, 1] + a[2, 1]*b[1, 1] + a[2, 2]*b[2, 1]),
								A22 = (a[2, 0]*b[0, 2] + a[2, 1]*b[1, 2] + a[2, 2]*b[2, 2]),
							};

			return sumMatrix;
		}
	}

	[DebuggerDisplay( "(({data[0].ToString(\"F2\"),nq};{data[4].ToString(\"F2\"),nq};{data[08].ToString(\"F2\"),nq};{data[12].ToString(\"F2\"),nq});" +
	                  " ({data[1].ToString(\"F2\"),nq};{data[5].ToString(\"F2\"),nq};{data[09].ToString(\"F2\"),nq};{data[13].ToString(\"F2\"),nq});" +
	                  " ({data[2].ToString(\"F2\"),nq};{data[6].ToString(\"F2\"),nq};{data[10].ToString(\"F2\"),nq};{data[14].ToString(\"F2\"),nq});" +
	                  " ({data[3].ToString(\"F2\"),nq};{data[7].ToString(\"F2\"),nq};{data[11].ToString(\"F2\"),nq};{data[15].ToString(\"F2\"),nq}))" )]
	public class Matrix4F
	{
		public static readonly Matrix4F IdentityMatrix = new Matrix4F();

		private readonly float[] data = new float[4*4];
        
		public Matrix4F()
		{
			Identity();
		}

		public Matrix4F( float[] data )
		{
			this.Set( data );
		}

		public Matrix4F( float a00, float a10, float a20, float a30,
		                 float a01, float a11, float a21, float a31,
		                 float a02, float a12, float a22, float a32,
		                 float a03, float a13, float a23, float a33 ) :
			this (new [] { a00,  a01,  a02,  a03,
		                   a10,  a11,  a12,  a13,
		                   a20,  a21,  a22,  a23,
		                   a30,  a31,  a32,  a33 }) {}

		#region Properties

		#region Position
		public float X
		{
			get { return this.A03; }
			set { this.A03 = value; }
		}

		public float Y
		{
			get { return this.A13; }
			set { this.A13 = value; }
		}

		public float Z
		{
			get { return this.A23; }
			set { this.A23 = value; }
		}
		#endregion

		#region Element Properties

		#region First Row
		public float A00
		{
			get { return this[0, 0]; }
			set { this[0, 0] = value; }
		}

		public float A01
		{
			get { return this[0, 1]; }
			set { this[0, 1] = value; }
		}

		public float A02
		{
			get { return this[0, 2]; }
			set { this[0, 2] = value; }
		}

		public float A03
		{
			get { return this[0, 3]; }
			set { this[0, 3] = value; }
		}
		#endregion

		#region Second Row
		public float A10
		{
			get { return this[1, 0]; }
			set { this[1, 0] = value; }
		}

		public float A11
		{
			get { return this[1, 1]; }
			set { this[1, 1] = value; }
		}

		public float A12
		{
			get { return this[1, 2]; }
			set { this[1, 2] = value; }
		}

		public float A13
		{
			get { return this[1, 3]; }
			set { this[1, 3] = value; }
		}
		#endregion

		#region Third Row
		public float A20
		{
			get { return this[2, 0]; }
			set { this[2, 0] = value; }
		}

		public float A21
		{
			get { return this[2, 1]; }
			set { this[2, 1] = value; }
		}

		public float A22
		{
			get { return this[2, 2]; }
			set { this[2, 2] = value; }
		}

		public float A23
		{
			get { return this[2, 3]; }
			set { this[2, 3] = value; }
		}
		#endregion

		#region Fouth Row
		public float A30
		{
			get { return this[3, 0]; }
			set { this[3, 0] = value; }
		}

		public float A31
		{
			get { return this[3, 1]; }
			set { this[3, 1] = value; }
		}

		public float A32
		{
			get { return this[3, 2]; }
			set { this[3, 2] = value; }
		}

		public float A33
		{
			get { return this[3, 3]; }
			set { this[3, 3] = value; }
		}
		#endregion

		#endregion

		#region Indexers
		public float this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}

		public float this[int row, int column]
		{
			get
			{
				CheckIndex( row, column );
				return data[column * 4 + row];
			}
			set
			{
				CheckIndex( row, column );
				data[column * 4 + row] = value;
			}
		}

		private static void CheckIndex( int row, int column )
		{
			if (row    < 0 || row    > 4) throw new ArgumentOutOfRangeException( "row" );
			if (column < 0 || column > 4) throw new ArgumentOutOfRangeException( "column" );
		}
		#endregion

		public float[] Data
		{
			get { return this.data; }
		}
		#endregion

		public void Identity()
		{
			data[01] = data[02] = data[03] = 
			data[04] = data[06] = data[07] = 
			data[08] = data[10] = data[11] =
			data[12] = data[13] = data[14] = 0;
			data[00] = data[05] = data[10] = data[15] = 1;
		}

		public void Set( float[] value )
		{
			CheckArray( value );

			Array.Copy( value, this.data, this.data.Length );
		}

		public void Set( Matrix matrix )
		{
			this.A00 = matrix.M11;
			this.A01 = matrix.M21;
			this.A02 = matrix.M31;
			this.A03 = matrix.M41;

			this.A10 = matrix.M12;
			this.A11 = matrix.M22;
			this.A12 = matrix.M32;
			this.A13 = matrix.M42;

			this.A20 = matrix.M13;
			this.A21 = matrix.M23;
			this.A22 = matrix.M33;
			this.A23 = matrix.M43;

			this.A30 = matrix.M14;
			this.A31 = matrix.M24;
			this.A32 = matrix.M34;
			this.A33 = matrix.M44;
		}

		// ReSharper disable SuggestBaseTypeForParameter
		private static void CheckArray( float[] value )
		{
			if (value == null) throw new ArgumentNullException( "value" );
			if (value.Length != 16) throw new ArgumentOutOfRangeException( "value", "must be 16 elements" );
		}
		// ReSharper restore SuggestBaseTypeForParameter

		public void MultiplyOn( Matrix4F m )
		{
			Multiply( this.data, m.data, this.data );
		}

		public void MultiplyOn( float[] m )
		{
			CheckArray( m );
			Multiply( this.data, m, this.data );
		}

		public void SetPosition( float x, float y, float z )
		{
			this.X = data[0]*x + data[4]*y + data[08]*z;
			this.Y = data[1]*x + data[5]*y + data[09]*z;
			this.Z = data[2]*x + data[6]*y + data[10]*z;
		}

		public void SetPosition( Vector3F position )
		{
			SetPosition( position.X, position.Y, position.Z );
		}

		#region Operators
		public static Matrix4F operator+( Matrix4F a, Matrix4F b )
		{
			var sumMatrix = new Matrix4F
			                {
			                	A00 = (a.A00 + b.A00),
			                	A01 = (a.A01 + b.A01),
			                	A02 = (a.A02 + b.A02),
			                	A03 = (a.A03 + b.A03),

			                	A10 = (a.A10 + b.A10),
			                	A11 = (a.A11 + b.A11),
			                	A12 = (a.A12 + b.A12),
			                	A13 = (a.A13 + b.A13),

			                	A20 = (a.A20 + b.A20),
			                	A21 = (a.A21 + b.A21),
			                	A22 = (a.A22 + b.A22),
			                	A23 = (a.A23 + b.A23),

			                	A30 = (a.A30 + b.A30),
			                	A31 = (a.A31 + b.A31),
			                	A32 = (a.A32 + b.A32),
			                	A33 = (a.A33 + b.A33),
			                };

			return sumMatrix;
		}

		public static Matrix4F operator-( Matrix4F a, Matrix4F b )
		{
			var sumMatrix = new Matrix4F
			                {
			                	A00 = (a.A00 - b.A00),
			                	A01 = (a.A01 - b.A01),
			                	A02 = (a.A02 - b.A02),
			                	A03 = (a.A03 - b.A03),

			                	A10 = (a.A10 - b.A10),
			                	A11 = (a.A11 - b.A11),
			                	A12 = (a.A12 - b.A12),
			                	A13 = (a.A13 - b.A13),

			                	A20 = (a.A20 - b.A20),
			                	A21 = (a.A21 - b.A21),
			                	A22 = (a.A22 - b.A22),
			                	A23 = (a.A23 - b.A23),

			                	A30 = (a.A30 - b.A30),
			                	A31 = (a.A31 - b.A31),
			                	A32 = (a.A32 - b.A32),
			                	A33 = (a.A33 - b.A33),
			                };

			return sumMatrix;
		}

		public static Matrix4F operator*( Matrix4F a, float value )
		{
			var mulMatrix = new Matrix4F();

			for (var i = 0; i < mulMatrix.data.Length; i++)
				mulMatrix.data[i] = a.data[i] * value;

			return mulMatrix;
		}

		public static Matrix4F operator*( Matrix4F a, Matrix4F b )
		{
			var sumMatrix = new Matrix4F();

			Multiply( a.data, b.data, sumMatrix.data );

			return sumMatrix;
		}

		public static Vector4F operator*( Matrix4F a, Vector4F v )
		{
			return new Vector4F( a[0] * v.X + a[4] * v.Y + a[08] * v.Z + a[12] * v.W,
			                     a[1] * v.X + a[5] * v.Y + a[09] * v.Z + a[13] * v.W,
			                     a[2] * v.X + a[6] * v.Y + a[10] * v.Z + a[14] * v.W,
			                     a[3] * v.X + a[7] * v.Y + a[11] * v.Z + a[15] * v.W );
		}

		public static Vector3F operator*( Matrix4F a, Vector3F v )
		{
			return new Vector3F( a[0] * v.X + a[4] * v.Y + a[08] * v.Z + a[12],
			                     a[1] * v.X + a[5] * v.Y + a[09] * v.Z + a[13],
			                     a[2] * v.X + a[6] * v.Y + a[10] * v.Z + a[14] );
		}
		#endregion

		public static explicit operator Matrix ( Matrix4F value )
		{
			return new Matrix
			       {
			       	M11 = value.A00,
					M12 = value.A10,
					M13 = value.A20,
					M14 = value.A30,

			       	M21 = value.A01,
					M22 = value.A11,
					M23 = value.A21,
					M24 = value.A31,

			       	M31 = value.A02,
					M32 = value.A12,
					M33 = value.A22,
					M34 = value.A32,

			       	M41 = value.A03,
					M42 = value.A13,
					M43 = value.A23,
					M44 = value.A33,
			       };
		}

		#region Create Methods

		#region Rotate Methods
		public static Matrix4F RotateX( float angle )
		{
			var radians = angle.ToRadian();
			var cosA = MathHelper.CosR( radians );
			var sinA = MathHelper.SinR( radians );

			return new Matrix4F( 1,     0,     0, 0,
			                     0, +cosA, -sinA, 0,
			                     0, +sinA, +cosA, 0,
			                     0,     0,     0, 1 );
		}

		public static Matrix4F RotateY( float angle )
		{
			var radians = angle.ToRadian();
			var cosA = MathHelper.CosR( radians );
			var sinA = MathHelper.SinR( radians );

			return new Matrix4F( +cosA, 0, -sinA, 0,
			                     0,     1,     0, 0,
			                     +sinA, 0, +cosA, 0,
			                     0,     0,     0, 1 );
		}

		public static Matrix4F RotateZ( float angle )
		{
			var radians = angle.ToRadian();
			var cosA = MathHelper.CosR( radians );
			var sinA = MathHelper.SinR( radians );

			return new Matrix4F( +cosA, -sinA, 0, 0,
			                     +sinA, +cosA, 0, 0,
			                     0,     0,     1, 0,
			                     0,     0,     0, 1 );
		}
		#endregion

		#region Translate Methods
		public static Matrix4F Translate( float x, float y, float z )
		{
			return new Matrix4F( 1, 0, 0, x,
			                     0, 1, 0, y,
			                     0, 0, 1, z,
			                     0, 0, 0, 1 );
		}

		public static Matrix4F Translate( Vector3F position )
		{
			return Translate( position.X, position.Y, position.Z );
		}
		#endregion

		#endregion

        #region Helper Methods
		public static void Multiply( float[] a, float[] b, float[] o )
		{
			for (var i = 0; i < 4; i++)
			{
				var a0 = a[0 * 4 + i] * b[0 * 4 + 0] + a[1 * 4 + i] * b[0 * 4 + 1] + a[2 * 4 + i] * b[0 * 4 + 2] +
				         a[3 * 4 + i] * b[0 * 4 + 3];
				var a1 = a[0 * 4 + i] * b[1 * 4 + 0] + a[1 * 4 + i] * b[1 * 4 + 1] + a[2 * 4 + i] * b[1 * 4 + 2] +
				         a[3 * 4 + i] * b[1 * 4 + 3];
				var a2 = a[0 * 4 + i] * b[2 * 4 + 0] + a[1 * 4 + i] * b[2 * 4 + 1] + a[2 * 4 + i] * b[2 * 4 + 2] +
				         a[3 * 4 + i] * b[2 * 4 + 3];
				var a3 = a[0 * 4 + i] * b[3 * 4 + 0] + a[1 * 4 + i] * b[3 * 4 + 1] + a[2 * 4 + i] * b[3 * 4 + 2] +
				         a[3 * 4 + i] * b[3 * 4 + 3];

				o[0 * 4 + i] = a0;
				o[1 * 4 + i] = a1;
				o[2 * 4 + i] = a2;
				o[3 * 4 + i] = a3;
			}
		}
		#endregion
	}
}