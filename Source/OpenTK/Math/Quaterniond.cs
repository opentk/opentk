using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OpenTK.Math
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Quaterniond
    {
        #region Fields

        /// <summary>The W component of the quaternion.</summary>
        public double W;

        /// <summary>The X component of the quaternion.</summary>
        public double X;

        /// <summary>The Y component of the quaternion.</summary>
        public double Y;

        /// <summary>The Z component of the quaternion.</summary>
        public double Z;

        #endregion


        #region Constructors

        /// <summary>Constructs left quaternion that is left copy of the given quaternion.</summary>
        /// <param name="quaterniond">The quaternion to copy.</param>
        public Quaterniond(ref Quaterniond quaternion) : this(quaternion.W, quaternion.X, quaternion.Y, quaternion.Z) { }

        /// <summary>Constructs left quaternion from the given components.</summary>
        /// <param name="w">The W component for the quaternion.</param>
        /// <param name="vector3d">A Vector representing the X, Y, and Z componets for the quaterion.</param>
        public Quaterniond(double w, ref Vector3d vector3d) : this(w, vector3d.X, vector3d.Y, vector3d.Z) { }

        /// <summary>Constructs left quaternion from the given axis and angle.</summary>
        /// <param name="axis">The axis for the quaternion.</param>
        /// <param name="angle">The angle for the quaternione.</param>
        public Quaterniond(ref Vector3d axis, double angle)
        {
            double halfAngle = Functions.DTOR * angle / 2;

            this.W = System.Math.Cos(halfAngle);

            double sin = System.Math.Sin(halfAngle);
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            this.X = axisNormalized.X * sin;
            this.Y = axisNormalized.Y * sin;
            this.Z = axisNormalized.Z * sin;
        }

        /// <summary>Constructs left quaternion from the given components.</summary>
        /// <param name="w">The W component for the quaternion.</param>
        /// <param name="x">The X component for the quaternion.</param>
        /// <param name="y">The Y component for the quaternion.</param>
        /// <param name="z">The Z component for the quaternion.</param>
        public Quaterniond(double w, double x, double y, double z)
        {
            this.W = w;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>Constructs left quaternion from the given array of double-precision floating point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the components of the quaternion.</param>
        public Quaterniond(double[] doubleArray)
		{
            if (doubleArray == null || doubleArray.GetLength(0) < 4) throw new MissingFieldException();

            this.W = doubleArray[0];
            this.X = doubleArray[1];
            this.Y = doubleArray[2];
            this.Z = doubleArray[3];
		}

        /// <summary>Constructs left quaternion from the given matrix.  Only contains rotation information.</summary>
        /// <param name="matrix">The matrix for the components of the quaternion.</param>
        public Quaterniond(ref Matrix4d matrix)
        {
            double scale = System.Math.Pow(matrix.Determinant, 1.0d/3.0d);
 
            W = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] + matrix[1, 1] + matrix[2, 2])) / 2;
            X = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] - matrix[1, 1] - matrix[2, 2])) / 2;
            Y = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] + matrix[1, 1] - matrix[2, 2])) / 2;
            Z = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] - matrix[1, 1] + matrix[2, 2])) / 2; 
            if( matrix[2,1] - matrix[1,2] < 0 ) X = -X;
            if( matrix[0,2] - matrix[2,0] < 0 ) Y = -Y;
            if( matrix[1,0] - matrix[0,1] < 0 ) Z = -Z;
        }

        public Quaterniond(ref Matrix3d matrix)
        {
            double scale = System.Math.Pow(matrix.Determinant, 1.0d / 3.0d);

            W = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] + matrix[1, 1] + matrix[2, 2])) / 2;
            X = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] - matrix[1, 1] - matrix[2, 2])) / 2;
            Y = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] + matrix[1, 1] - matrix[2, 2])) / 2;
            Z = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] - matrix[1, 1] + matrix[2, 2])) / 2;
            if (matrix[2, 1] - matrix[1, 2] < 0) X = -X;
            if (matrix[0, 2] - matrix[2, 0] < 0) Y = -Y;
            if (matrix[1, 0] - matrix[0, 1] < 0) Z = -Z;
        }

        #endregion


        #region Arithmetic Operators

        public void Add(ref Quaterniond quaternion)
        {
            W = W + quaternion.W;
            X = X + quaternion.X;
            Y = Y + quaternion.Y;
            Z = Z + quaternion.Z;
        }
        public void Add(ref Quaterniond quaternion, out Quaterniond result)
        {
            result.W = W + quaternion.W;
            result.X = X + quaternion.X;
            result.Y = Y + quaternion.Y;
            result.Z = Z + quaternion.Z;
        }
        public static void Add(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
        {
            result.W = left.W + right.W;
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
        }

        public void Subtract(ref Quaterniond quaternion)
        {
            W = W - quaternion.W;
            X = X - quaternion.X;
            Y = Y - quaternion.Y;
            Z = Z - quaternion.Z;
        }
        public void Subtract(ref Quaterniond quaternion, out Quaterniond result)
        {
            result.W = W - quaternion.W;
            result.X = X - quaternion.X;
            result.Y = Y - quaternion.Y;
            result.Z = Z - quaternion.Z;
        }
        public static void Subtract(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
        {
            result.W = left.W - right.W;
            result.X = left.X - right.X;
            result.Y = left.Y - right.Y;
            result.Z = left.Z - right.Z;
        }

        public void Multiply(ref Quaterniond quaternion)
        {
            double w = W * quaternion.W - X * quaternion.X - Y * quaternion.Y - Z * quaternion.Z;
            double x = W * quaternion.X + X * quaternion.W + Y * quaternion.Z - Z * quaternion.Y;
            double y = W * quaternion.Y + Y * quaternion.W + Z * quaternion.X - X * quaternion.Z;
            Z = W * quaternion.Z + Z * quaternion.W + X * quaternion.Y - Y * quaternion.X;
            W = w;
            X = x;
            Y = y;
        }
        public void Multiply(ref Quaterniond quaternion, out Quaterniond result)
        {
            result.W = W * quaternion.W - X * quaternion.X - Y * quaternion.Y - Z * quaternion.Z;
            result.X = W * quaternion.X + X * quaternion.W + Y * quaternion.Z - Z * quaternion.Y;
            result.Y = W * quaternion.Y + Y * quaternion.W + Z * quaternion.X - X * quaternion.Z;
            result.Z = W * quaternion.Z + Z * quaternion.W + X * quaternion.Y - Y * quaternion.X;
        }
        public static void Multiply(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
        {
            result.W = left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z;
            result.X = left.W * right.X + left.X * right.W + left.Y * right.Z - left.Z * right.Y;
            result.Y = left.W * right.Y + left.Y * right.W + left.Z * right.X - left.X * right.Z;
            result.Z = left.W * right.Z + left.Z * right.W + left.X * right.Y - left.Y * right.X;
        }

        public void Multiply(double scalar)
        {
            W = W * scalar;
            X = X * scalar;
            Y = Y * scalar;
            Z = Z * scalar;
        }
        public void Multiply(double scalar, out Quaterniond result)
        {
            result.W = W * scalar;
            result.X = X * scalar;
            result.Y = Y * scalar;
            result.Z = Z * scalar;
        }
        public static void Multiply(ref Quaterniond quaternion, double scalar, out Quaterniond result)
        {
            result.W = quaternion.W * scalar;
            result.X = quaternion.X * scalar;
            result.Y = quaternion.Y * scalar;
            result.Z = quaternion.Z * scalar;
        }

        public void Divide(double scalar)
        {
            if (scalar == 0) throw new DivideByZeroException();
            W = W / scalar;
            X = X / scalar;
            Y = Y / scalar;
            Z = Z / scalar;
        }
        public void Divide(double scalar, out Quaterniond result)
        {
            if (scalar == 0) throw new DivideByZeroException();
            result.W = W / scalar;
            result.X = X / scalar;
            result.Y = Y / scalar;
            result.Z = Z / scalar;
        }
        public static void Divide(ref Quaterniond quaternion, double scalar, out Quaterniond result)
        {
            if (scalar == 0) throw new DivideByZeroException();
            result.W = quaternion.W / scalar;
            result.X = quaternion.X / scalar;
            result.Y = quaternion.Y / scalar;
            result.Z = quaternion.Z / scalar;
        }

        #endregion


        #region Functions

        public double Modulus
        {
            get
            {
                return System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            }
        }
        public double ModulusSquared
        {
            get
            {
                return W * W + X * X + Y * Y + Z * Z;
            }
        }

		public static double DotProduct(Quaterniond left, Quaterniond right)
		{
			return left.W * right.W + left.X * right.X + left.Y * right.Y + left.Z * right.Z;
		}

        public void Normalize()
        {
            double modulus = System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            if (modulus == 0) throw new DivideByZeroException();
            W = W / modulus;
            X = X / modulus;
            Y = Y / modulus;
            Z = Z / modulus;
        }
        public void Normalize( out Quaterniond result )
        {
            double modulus = System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            if (modulus == 0) throw new DivideByZeroException();
            result.W = W / modulus;
            result.X = X / modulus;
            result.Y = Y / modulus;
            result.Z = Z / modulus;
        }
        public static void Normalize(ref Quaterniond quaternion, out Quaterniond result)
        {
            double modulus = System.Math.Sqrt(quaternion.W * quaternion.W + quaternion.X * quaternion.X + quaternion.Y * quaternion.Y + quaternion.Z * quaternion.Z);
            if (modulus == 0) throw new DivideByZeroException();
            result.W = quaternion.W / modulus;
            result.X = quaternion.X / modulus;
            result.Y = quaternion.Y / modulus;
            result.Z = quaternion.Z / modulus;
        }

        public void Conjugate()
        {
            X = -X;
            Y = -Y;
            Z = -Z;
        }
        public void Conjugate( out Quaterniond result )
        {
            result.W = W;
            result.X = -X;
            result.Y = -Y;
            result.Z = -Z;
        }
        public static void Conjugate(ref Quaterniond quaternion, out Quaterniond result)
        {
            result.W = quaternion.W;
            result.X = -quaternion.X;
            result.Y = -quaternion.Y;
            result.Z = -quaternion.Z;
        }

        public void Inverse()
        {
            double modulusSquared = W * W + X * X + Y * Y + Z * Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            double inverseModulusSquared = 1.0 / modulusSquared;
            W = W * inverseModulusSquared;
            X = X * -inverseModulusSquared;
            Y = Y * -inverseModulusSquared;
            Z = Z * -inverseModulusSquared;
        }
        public void Inverse( out Quaterniond result )
        {
            double modulusSquared = W * W + X * X + Y * Y + Z * Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            double inverseModulusSquared = 1.0 / modulusSquared;
            result.W = W * inverseModulusSquared;
            result.X = X * -inverseModulusSquared;
            result.Y = Y * -inverseModulusSquared;
            result.Z = Z * -inverseModulusSquared;
        }
        public static void Inverse(ref Quaterniond quaternion, out Quaterniond result)
        {
            double modulusSquared = quaternion.W * quaternion.W + quaternion.X * quaternion.X + quaternion.Y * quaternion.Y + quaternion.Z * quaternion.Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            double inverseModulusSquared = 1.0 / modulusSquared;
            result.W = quaternion.W * inverseModulusSquared;
            result.X = quaternion.X * -inverseModulusSquared;
            result.Y = quaternion.Y * -inverseModulusSquared;
            result.Z = quaternion.Z * -inverseModulusSquared;
        }

        public void Log()
        {
            if (System.Math.Abs(W) < 1.0)
            {
                double angle = System.Math.Acos(W);
                double sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    double coefficient = angle / sin;
                    X = X * coefficient;
                    Y = Y * coefficient;
                    Z = Z * coefficient;
                }
            }
            else
            {
                X = 0;
                Y = 0;
                Z = 0;
            }

            W = 0;
        }
        public void Log( out Quaterniond result )
        {
            if (System.Math.Abs(W) < 1.0)
            {
                double angle = System.Math.Acos(W);
                double sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    double coefficient = angle / sin;
                    result.X = X * coefficient;
                    result.Y = Y * coefficient;
                    result.Z = Z * coefficient;
                }
                else
                {
                    result.X = X;
                    result.Y = Y;
                    result.Z = Z;
                }
            }
            else
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }

            result.W = 0;
        }
        public static void Log(ref Quaterniond quaternion, out Quaterniond result)
        {
            if (System.Math.Abs(quaternion.W) < 1.0)
            {
                double angle = System.Math.Acos(quaternion.W);
                double sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    double coefficient = angle / sin;
                    result.X = quaternion.X * coefficient;
                    result.Y = quaternion.Y * coefficient;
                    result.Z = quaternion.Z * coefficient;
                }
                else
                {
                    result.X = quaternion.X;
                    result.Y = quaternion.Y;
                    result.Z = quaternion.Z;
                }
            }
            else
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }

            result.W = 0;
        }

        public void Exp()
        {
            double angle = System.Math.Sqrt(X * X + Y * Y + Z * Z);
            double sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                double coefficient = angle / sin;
                W = 0;
                X = X * coefficient;
                Y = Y * coefficient;
                Z = Z * coefficient;
            }
            else
            {
                W = 0;
            }
        }
        public void Exp(out Quaterniond result)
        {
            double angle = System.Math.Sqrt(X * X + Y * Y + Z * Z);
            double sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                double coefficient = angle / sin;
                result.W = 0;
                result.X = X * coefficient;
                result.Y = Y * coefficient;
                result.Z = Z * coefficient;
            }
            else
            {
                result.W = 0;
                result.X = X;
                result.Y = Y;
                result.Z = Z;
            }
        }
        public static void Exp(ref Quaterniond quaternion, out Quaterniond result)
        {
            double angle = System.Math.Sqrt(quaternion.X * quaternion.X + quaternion.Y * quaternion.Y + quaternion.Z * quaternion.Z);
            double sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                double coefficient = angle / sin;
                result.W = 0;
                result.X = quaternion.X * coefficient;
                result.Y = quaternion.Y * coefficient;
                result.Z = quaternion.Z * coefficient;
            }
            else
            {
                result.W = 0;
                result.X = quaternion.X;
                result.Y = quaternion.Y;
                result.Z = quaternion.Z;
            }
        }

        /// <summary>Returns left matrix for this quaternion.</summary>
        public void Matrix4(out Matrix4d result)
        {
            // TODO Expand
            result = new Matrix4d(ref this);
        }

        public void GetAxisAndAngle(out Vector3d axis, out double angle)
        {
            Quaterniond quaternion;
            Normalize(out quaternion);
            double cos = quaternion.W;
            angle = System.Math.Acos(cos) * 2 * Functions.RTOD;
            double sin = System.Math.Sqrt( 1.0d - cos * cos );
            if ( System.Math.Abs( sin ) < 0.0001 ) sin = 1;
            axis = new Vector3d(X / sin, Y / sin, Z / sin);
        }

        public static void Slerp(ref Quaterniond start, ref Quaterniond end, double blend, out Quaterniond result)
		{
            if (start.W == 0 && start.X == 0 && start.Y == 0 && start.Z == 0)
            {
                if (end.W == 0 && end.X == 0 && end.Y == 0 && end.Z == 0)
                {
                    result.W = 1;
                    result.X = 0;
                    result.Y = 0;
                    result.Z = 0;
                }
                else
                {
                    result = end;
                }
            }
            else if (end.W == 0 && end.X == 0 && end.Y == 0 && end.Z == 0)
            {
                result = start;
            }

            Vector3d startVector = new Vector3d(start.X, start.Y, start.Z);
            Vector3d endVector = new Vector3d(end.X, end.Y, end.Z);
            double cosHalfAngle = start.W * end.W + Vector3d.DotProduct(ref startVector, ref endVector);

			if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
			{
				// angle = 0.0f, so just return one input.
                result = start;
			}
			else if (cosHalfAngle < 0.0f)
			{
                end.W = -end.W;
                end.X = -end.X;
                end.Y = -end.Y;
                end.Z = -end.Z;
                cosHalfAngle = -cosHalfAngle;
			}

			double blendA;
            double blendB;
			if (cosHalfAngle < 0.99f)
			{
				// do proper slerp for big angles
                double halfAngle = (double)System.Math.Acos(cosHalfAngle);
                double sinHalfAngle = (double)System.Math.Sin(halfAngle);
                double oneOverSinHalfAngle = 1.0f / sinHalfAngle;
                blendA = (double)System.Math.Sin(halfAngle * (1.0f - blend)) * oneOverSinHalfAngle;
                blendB = (double)System.Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
			}
			else
			{
				// do lerp if angle is really small.
				blendA = 1.0f - blend;
				blendB = blend;
			}

            result.W = blendA * start.W + blendB * end.W;
            result.X = blendA * start.X + blendB * end.X;
            result.Y = blendA * start.Y + blendB * end.Y;
            result.Z = blendA * start.Z + blendB * end.Z;

            if (result.W != 0 || result.X != 0 || result.Y != 0 || result.Z != 0)
            {
                result.Normalize();
            }
            else
            {
                result.W = 1;
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }
		}

        #endregion


        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            base.GetHashCode();
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        #endregion


        #region String and Parse

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", W, X, Y, Z);
        }

        /// <summary>Parses left string, converting it to left quaternion.</summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The quaternion represented by the string.</returns>
        public static void Parse(string str, out Quaterniond result)
        {
            Match match = new Regex(@"\((?<w>.*),(?<x>.*),(?<y>.*),(?<z>.*)\)", RegexOptions.None).Match(str);
            if (!match.Success) throw new Exception("Parse failed!");

            result.W = double.Parse(match.Result("${w}"));
            result.X = double.Parse(match.Result("${x}"));
            result.Y = double.Parse(match.Result("${y}"));
            result.Z = double.Parse(match.Result("${z}"));
        }

        #endregion


        #region Constants

        /// <summary>A quaterion with all zero components.</summary>
        public static readonly Quaterniond Zero = new Quaterniond(0, 0, 0, 0);

        /// <summary>A quaterion representing an identity.</summary>
        public static readonly Quaterniond Identity = new Quaterniond(1, 0, 0, 0);

        /// <summary>A quaterion representing the W axis.</summary>
        public static readonly Quaterniond WAxis = new Quaterniond(1, 0, 0, 0);

        /// <summary>A quaterion representing the X axis.</summary>
        public static readonly Quaterniond XAxis = new Quaterniond(0, 1, 0, 0);

        /// <summary>A quaterion representing the Y axis.</summary>
        public static readonly Quaterniond YAxis = new Quaterniond(0, 0, 1, 0);

        /// <summary>A quaterion representing the Z axis.</summary>
        public static readonly Quaterniond ZAxis = new Quaterniond(0, 0, 0, 1);

        #endregion
    }
}
