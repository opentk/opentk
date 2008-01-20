using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OpenTK.Math
{
    /// <summary>A 3-dimensional vector using double-precision floating point numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3d : IEquatable<Vector3d>, IComparer<Vector3d>, IComparable<Vector3d>
    {
        #region Fields & Access

        /// <summary>The X coordinate of the vector.</summary>
        public double X;

        /// <summary>The Y coordinate of the vector.</summary>
        public double Y;

        /// <summary>The Z coordinate of the vector.</summary>
        public double Z;

        /// <summary>The coordinate at the index of the vector.</summary>
        public double this[int index]
        {
            get
            {
                switch( index )
                {
                    case 0:
                        return X;

                    case 1:
                        return Y;

                    case 2:
                        return Z;
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                switch( index )
                {
                    case 0:
                        X = value;
                        return;

                    case 1:
                        Y = value;
                        return;

                    case 2:
                        Z = value;
                        return;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>Converts the vector into an array of double-precision floating point numbers.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An array of double-precision floating point numbers representing the vector coordinates.</returns>
        public static explicit operator double[](Vector3d vector)
        {
            return new double[3]{vector.X, vector.Y, vector.Z};
        }

        /// <summary>Converts the vector into left double-precision floating point number pointer.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>A double-precision floating point number pointer to the vector coordinates.</returns>
        //unsafe public static explicit operator double*(Vector3d vector)
        //{
        //    return &vector.X;
        //}

        /// <summary>Converts the vector into an IntPtr.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An IntPtr to the vector coordinates.</returns>
        //public static explicit operator IntPtr(Vector3d vector)
        //{
        //    unsafe
        //    {
        //        return (IntPtr)(&vector.X);
        //    }
        //}

        #endregion

        
        #region Constructors

        /// <summary>Constructs left vector with the given coordinates.</summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="z">The Z coordinate.</param>
        public Vector3d(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector3d(ref Vector2d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = 0;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector3d(ref Vector3d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = vector.Z;
        }

        /// <summary>Constructs left vector from the given array of double-precision floating point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the coordinates of the vector.</param>
        public Vector3d(double[] coordinateArray)
        {
            if( coordinateArray == null || coordinateArray.GetLength(0) < 3 ) throw new Exception("Invalid parameter.");

            this.X = coordinateArray[0];
            this.Y = coordinateArray[1];
            this.Z = coordinateArray[2];
        }

        #endregion


        #region Equality

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        [CLSCompliant(false)]
        public bool Equals(Vector3d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y &&
                Z == vector.Z;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(ref Vector3d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y &&
                Z == vector.Z;
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool Equals(ref Vector3d left, ref Vector3d right)
        {
            return
                left.X == right.X &&
                left.Y == right.Y &&
                left.Z == right.Z;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool EqualsApprox(ref Vector3d vector, double tolerance)
        {
            return
                System.Math.Abs(X - vector.X) <= tolerance &&
                System.Math.Abs(Y - vector.Y) <= tolerance &&
                System.Math.Abs(Z - vector.Z) <= tolerance;
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other within left given tolerance.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <param name="tolerance">The tolerance for the approximation.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool EqualsApprox(ref Vector3d left, ref Vector3d right, double tolerance)
        {
            return
                System.Math.Abs(left.X - right.X) <= tolerance &&
                System.Math.Abs(left.Y - right.Y) <= tolerance &&
                System.Math.Abs(left.Z - right.Z) <= tolerance;
        }

        #endregion


        #region IComparer

        /// <summary>Compares two vectors and returns left value indicating whether one is less than, equal to, or greater than the other.</summary>
        public int Compare(Vector3d left, Vector3d right)
        {
            if (left.X != right.X)
            {
                if (left.X < right.X) return -1;
                else return 1;
            }
            else if (left.Y != right.Y)
            {
                if (left.Y < right.Y) return -1;
                else return 1;
            }
            else if (left.Z != right.Z)
            {
                if (left.Z < right.Z) return -1;
                else return 1;
            }

            return 0;
        }

        #endregion


        #region IComparable

        /// <summary>Compares the vector with another vector and returns left value indicating whether it is less than, equal to, or greater than the other vector.</summary>
        public int CompareTo(Vector3d vector) { return Compare(this, vector); }

        #endregion


        #region Length

        /// <summary>Gets the length of the vector.</summary>
        public double Length
        {
            get
            {
                double lengthSquared = LengthSquared;

                if (lengthSquared == 1)
                {
                    return 1;
                }
                else
                {
                    return System.Math.Sqrt(lengthSquared);
                }
            }
        }

        /// <summary>Gets the squared length of the vector.</summary>
        public double LengthSquared
        {
            get
            {
                return X * X + Y * Y + Z * Z;
            }
        }

        /// <summary>Gets the approimate length of the vector.</summary>
        public double LengthApprox
        {
            get
            {
                return 1.0d / Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            }
        }

        #endregion


        #region Distance

        /// <summary>Gets the distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the distance.</param>
        /// <returns>The distance from this vector to the given vector.</returns>
        public double DistanceTo(ref Vector3d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            return System.Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        /// <summary>Gets the squared distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the squared distance.</param>
        /// <returns>The squared distance from this vector to the given vector.</returns>
        public double DistanceSquaredTo(ref Vector3d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            return deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;
        }

        /// <summary>Gets the approximate distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the approximate distance.</param>
        /// <returns>The approximate distance from this vector to the given vector.</returns>
        public double DistanceApproxTo(ref Vector3d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            return 1.0d / Functions.InverseSqrtFast(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        #endregion


        #region Normalize

        /// <summary>Normalize this vector.</summary>
        public void Normalize()
        {
            double lengthSquared = LengthSquared;

            if (lengthSquared != 1 && lengthSquared != 0)
            {
                double length = System.Math.Sqrt(lengthSquared);
                X = X / length;
                Y = Y / length;
                Z = Z / length;
            }
        }

        /// <summary>Get the normalized version of this vector.</summary>
        /// <param name="result">The resulting normalized vector.</param>
        public void Normalize(out Vector3d result)
        {
            double lengthSquared = LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = X / length;
                result.Y = Y / length;
                result.Z = Z / length;
            }
        }

        public static void Normalize(ref Vector3d vector, out Vector3d result)
        {
            double lengthSquared = vector.LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = vector.X / length;
                result.Y = vector.Y / length;
                result.Z = vector.Z / length;
            }
        }

        public void NormalizeApprox()
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            X = X * inverseSquare;
            Y = Y * inverseSquare;
            Z = Z * inverseSquare;
        }

        /// <summary>Gets left approximately normalized vector of the vector.</summary>
        public void NormalizedApprox(out Vector3d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            result.X = X * inverseSquare;
            result.Y = Y * inverseSquare;
            result.Z = Z * inverseSquare;
        }

        public static void NormalizeApprox(ref Vector3d vector, out Vector3d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z);
            result.X = vector.X * inverseSquare;
            result.Y = vector.Y * inverseSquare;
            result.Z = vector.Z * inverseSquare;
        }

        #endregion


        /// <summary>Gets the dot product of two vectors.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        public static double DotProduct(ref Vector3d left, ref Vector3d right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        /// <summary>Gets the cross product of two vectors.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The cross product of two vectors.</returns>
        public static void CrossProduct(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.Y * right.Z - left.Z * right.Y;
            result.Y = left.Z * right.X - left.X * right.Z;
            result.Z = left.X * right.Y - left.Y * right.X;
        }

        #region Abs

        public void Abs()
        {
            X = System.Math.Abs(X);
            Y = System.Math.Abs(Y);
            Z = System.Math.Abs(Z);
        }
        public void Abs(out Vector3d result)
        {
            result.X = System.Math.Abs(X);
            result.Y = System.Math.Abs(Y);
            result.Z = System.Math.Abs(Z);
        }
        public static void Abs(ref Vector3d vector, out Vector3d result)
        {
            result.X = System.Math.Abs(vector.X);
            result.Y = System.Math.Abs(vector.Y);
            result.Z = System.Math.Abs(vector.Z);
        }

        #endregion


        #region Inverse

        public void Inverse()
        {
            X = -X;
            Y = -Y;
            Z = -Z;
        }
        public void Inverse(out Vector3d result)
        {
            result.X = -X;
            result.Y = -Y;
            result.Z = -Z;
        }
        public static void Inverse(ref Vector3d vector, out Vector3d result)
        {
            result.X = -vector.X;
            result.Y = -vector.Y;
            result.Z = -vector.Z;
        }

        #endregion


        #region Arithmatic

        public void Add(ref Vector3d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
            Z = Z + vector.Z;
        }
        public void Add(ref Vector3d vector, out Vector3d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
            result.Z = Z + vector.Z;
        }
        public static void Add(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
        }

        public void Add(double x, double y, double z)
        {
            X = X + x;
            Y = Y + y;
            Z = Z + z;
        }
        public void Add(double x, double y, double z, out Vector3d result)
        {
            result.X = X + x;
            result.Y = Y + y;
            result.Z = Z + z;
        }
        public static void Add(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
            result.Z = vector.Z + z;
        }

        public void Subtract(ref Vector3d vector)
        {
            X = X - vector.X;
            Y = Y - vector.Y;
            Z = Z - vector.Z;
        }
        public void Subtract(ref Vector3d vector, out Vector3d result)
        {
            result.X = X - vector.X;
            result.Y = Y - vector.Y;
            result.Z = Z - vector.Z;
        }
        public static void Subtract(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X - right.X;
            result.Y = left.Y - right.Y;
            result.Z = left.Z - right.Z;
        }

        public void Subtract(double x, double y, double z)
        {
            X = X - x;
            Y = Y - y;
            Z = Z - z;
        }
        public void Subtract(double x, double y, double z, out Vector3d result)
        {
            result.X = X - x;
            result.Y = Y - y;
            result.Z = Z - z;
        }
        public static void Subtract(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X - x;
            result.Y = vector.Y - y;
            result.Z = vector.Z - z;
        }

        public void Multiply(double scalar)
        {
            X = X * scalar;
            Y = Y * scalar;
            Z = Z * scalar;
        }
        public void Multiply(double scalar, out Vector3d result)
        {
            result.X = X * scalar;
            result.Y = Y * scalar;
            result.Z = Z * scalar;
        }
        public static void Multiply(ref Vector3d vector, double scalar, out Vector3d result)
        {
            result.X = vector.X * scalar;
            result.Y = vector.Y * scalar;
            result.Z = vector.Z * scalar;
        }

        public void Multiply(ref Vector3d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
            Z = Z * vector.Z;
        }
        public void Multiply(ref Vector3d vector, out Vector3d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
            result.Z = Z * vector.Z;
        }
        public static void Multiply(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
            result.Z = left.Z * right.Z;
        }

        public void Multiply(double x, double y, double z)
        {
            X = X * x;
            Y = Y * y;
            Z = Z * z;
        }
        public void Multiply(double x, double y, double z, out Vector3d result)
        {
            result.X = X * x;
            result.Y = Y * y;
            result.Z = Z * z;
        }
        public static void Multiply(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
            result.Z = vector.Z * z;
        }

        public void Divide(double scalar)
        {
            X = X / scalar;
            Y = Y / scalar;
            Z = X / scalar;
        }
        public void Divide(double scalar, out Vector3d result)
        {
            result.X = X / scalar;
            result.Y = Y / scalar;
            result.Z = X / scalar;
        }
        public static void Divide(ref Vector3d vector, double scalar, out Vector3d result)
        {
            result.X = vector.X / scalar;
            result.Y = vector.Y / scalar;
            result.Z = vector.Z / scalar;
        }

        public void Divide(ref Vector3d vector)
        {
            X = X / vector.X;
            Y = Y / vector.Y;
            Z = Z / vector.Z;
        }
        public void Divide(ref Vector3d vector, out Vector3d result)
        {
            result.X = X / vector.X;
            result.Y = Y / vector.Y;
            result.Z = Z / vector.Z;
        }
        public static void Divide(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X / right.X;
            result.Y = left.Y / right.Y;
            result.Z = left.Z / right.Z;
        }

        public void Divide(double x, double y, double z)
        {
            X = X / x;
            Y = Y / y;
            Z = Z / z;
        }
        public void Divide(double x, double y, double z, out Vector3d result)
        {
            result.X = X / x;
            result.Y = Y / y;
            result.Z = Z / z;
        }
        public static void Divide(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X / x;
            result.Y = vector.Y / y;
            result.Z = vector.Z / z;
        }

        #endregion


        #region Transformations

        public void Transform(ref Matrix4d matrix)
        {
            double x = matrix.R0C0 * X + matrix.R0C1 * Y + matrix.R0C2 * Z;
            double y = matrix.R1C0 * X + matrix.R1C1 * Y + matrix.R1C2 * Z;
            Z = matrix.R2C0 * X + matrix.R2C1 * Y + matrix.R2C2 * Z;
            X = x;
            Y = y;
        }
        public void Transform(ref Matrix4d matrix, out Vector3d result)
        {
            result.X = matrix.R0C0 * X + matrix.R0C1 * Y + matrix.R0C2 * Z;
            result.Y = matrix.R1C0 * X + matrix.R1C1 * Y + matrix.R1C2 * Z;
            result.Z = matrix.R2C0 * X + matrix.R2C1 * Y + matrix.R2C2 * Z;
        }
        public static void Transform(ref Vector3d vector, ref Matrix4d matrix, out Vector3d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
            result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
        }

        public void Translate(ref Vector3d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
            Z = Z + vector.Z;
        }
        public void Translate(ref Vector3d vector, out Vector3d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
            result.Z = Z + vector.Z;
        }
        public static void Translate(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
        }

        public void Translate(double x, double y, double z)
        {
            X = X + x;
            Y = Y + y;
            Z = Z + z;
        }
        public void Translate(double x, double y, double z, out Vector3d result)
        {
            result.X = X + x;
            result.Y = Y + y;
            result.Z = Z + z;
        }
        public static void Translate(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
            result.Z = vector.Z + z;
        }

        public void Scale(ref Vector3d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
            Z = Z * vector.Z;
        }
        public void Scale(ref Vector3d vector, out Vector3d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
            result.Z = Z * vector.Z;
        }
        public static void Scale(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
            result.Z = left.Z * right.Z;
        }

        public void Scale(double x, double y, double z)
        {
            X = X * x;
            Y = Y * y;
            Z = Z * z;
        }
        public void Scale(double x, double y, double z, out Vector3d result)
        {
            result.X = X * x;
            result.Y = Y * y;
            result.Z = Z * z;
        }
        public static void Scale(ref Vector3d vector, double x, double y, double z, out Vector3d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
            result.Z = vector.Z * z;
        }

        public void RotateX(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double y = cos * Y + sin * Z;
            Z = cos * Z - sin * Y;
            Y = y;
        }
        public void RotateX(double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = X;
            result.Y = cos * Y + sin * Z;
            result.Z = cos * Z - sin * Y;
        }
        public static void RotateX(ref Vector3d vector, double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = vector.X;
            result.Y = cos * vector.Y + sin * vector.Z;
            result.Z = cos * vector.Z - sin * vector.Y;
        }

        public void RotateY(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double x = cos * X - sin * Z;
            Z = sin * X + cos * Z;
            X = x;
        }
        public void RotateY(double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * X - sin * Z;
            result.Y = Y;
            result.Z = sin * X + cos * Z;
        }
        public static void RotateY(ref Vector3d vector, double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * vector.X - sin * vector.Z;
            result.Y = vector.Y;
            result.Z = sin * vector.X + cos * vector.Z;
        }

        public void RotateZ(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double x = cos * X + sin * Y;
            Y = cos * Y - sin * X;
            X = x;
        }
        public void RotateZ(double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * X + sin * Y;
            result.Y = cos * Y - sin * X;
            result.Z = Z;
        }
        public static void RotateZ(ref Vector3d vector, double angle, out Vector3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * vector.X + sin * vector.Y;
            result.Y = cos * vector.Y - sin * vector.X;
            result.Z = vector.Z;
        }

        public void Rotate(ref Vector3d axis, double angle)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            double tx = (xxOneMinusCos + cos) * X + (xyOneMinusCos + zSin) * Y + (xzOneMinusCos - ySin) * Z;
            double ty = (xyOneMinusCos - zSin) * X + (yyOneMinusCos + cos) * Y + (yzOneMinusCos + xSin) * Z;
            Z = (xzOneMinusCos + ySin) * X + (yzOneMinusCos - xSin) * Y + (zzOneMinusCos + cos) * Z;
            X = tx;
            Y = ty;
        }
        public void Rotate(ref Vector3d axis, double angle, out Vector3d result)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            result.X = (xxOneMinusCos + cos) * X + (xyOneMinusCos + zSin) * Y + (xzOneMinusCos - ySin) * Z;
            result.Y = (xyOneMinusCos - zSin) * X + (yyOneMinusCos + cos) * Y + (yzOneMinusCos + xSin) * Z;
            result.Z = (xzOneMinusCos + ySin) * X + (yzOneMinusCos - xSin) * Y + (zzOneMinusCos + cos) * Z;
        }
        public static void Rotate(ref Vector3d vector, ref Vector3d axis, double angle, out Vector3d result)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            result.X = (xxOneMinusCos + cos) * vector.X + (xyOneMinusCos + zSin) * vector.Y + (xzOneMinusCos - ySin) * vector.Z;
            result.Y = (xyOneMinusCos - zSin) * vector.X + (yyOneMinusCos + cos) * vector.Y + (yzOneMinusCos + xSin) * vector.Z;
            result.Z = (xzOneMinusCos + ySin) * vector.X + (yzOneMinusCos - xSin) * vector.Y + (zzOneMinusCos + cos) * vector.Z;
        }

        #endregion


        #region Min & Max

        public void Min(ref Vector3d vector)
        {
            double lengthSquared = X * X + Y * Y + Z * Z;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;

            if (vectorLengthSquared < lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
                Z = vector.Z;
            }
        }
        public void Min(ref Vector3d vector, out Vector3d result)
        {
            double lengthSquared = X * X + Y * Y + Z * Z;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;

            if (vectorLengthSquared < lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
            }
            else
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
            }
        }
        public static void Min(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y + left.Z * left.Z;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y + right.Z * right.Z;

            if (rightLengthSquared < leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
                result.Z = right.Z;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
                result.Z = left.Z;
            }
        }

        public void Max(ref Vector3d vector)
        {
            double lengthSquared = X * X + Y * Y + Z * Z;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;

            if (vectorLengthSquared > lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
                Z = vector.Z;
            }
        }
        public void Max(ref Vector3d vector, out Vector3d result)
        {
            double lengthSquared = X * X + Y * Y + Z * Z;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;

            if (vectorLengthSquared > lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
            }
            else
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
            }
        }
        public static void Max(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y + left.Z * left.Z;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y + right.Z * right.Z;

            if (rightLengthSquared > leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
                result.Z = right.Z;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
                result.Z = left.Z;
            }
        }

        public void CoordinateMin(ref Vector3d vector)
        {
            X = System.Math.Min(X, vector.X);
            Y = System.Math.Min(Y, vector.Y);
            Z = System.Math.Min(Z, vector.Z);
        }
        public void CoordinateMin(ref Vector3d vector, out Vector3d result)
        {
            result.X = System.Math.Min(X, vector.X);
            result.Y = System.Math.Min(Y, vector.Y);
            result.Z = System.Math.Min(Z, vector.Z);
        }
        public static void CoordinateMin(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = System.Math.Min(left.X, right.X);
            result.Y = System.Math.Min(left.Y, right.Y);
            result.Z = System.Math.Min(left.Z, right.Z);
        }

        public void CoordinateMax(ref Vector3d vector)
        {
            X = System.Math.Max(X, vector.X);
            Y = System.Math.Max(Y, vector.Y);
            Z = System.Math.Max(Z, vector.Z);
        }
        public void CoordinateMax(ref Vector3d vector, out Vector3d result)
        {
            result.X = System.Math.Max(X, vector.X);
            result.Y = System.Math.Max(Y, vector.Y);
            result.Z = System.Math.Max(Z, vector.Z);
        }
        public static void CoordinateMax(ref Vector3d left, ref Vector3d right, out Vector3d result)
        {
            result.X = System.Math.Max(left.X, right.X);
            result.Y = System.Math.Max(left.Y, right.Y);
            result.Z = System.Math.Max(left.Z, right.Z);
        }

        public void Clamp(ref Vector3d min, ref Vector3d max)
        {
            X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
            Z = System.Math.Max(System.Math.Min(Z, min.Z), max.Z);
        }
        public void Clamp(ref Vector3d min, ref Vector3d max, out Vector3d result)
        {
            result.X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
            result.Z = System.Math.Max(System.Math.Min(Z, min.Z), max.Z);
        }
        public static void Clamp(ref Vector3d vector, ref Vector3d min, ref Vector3d max, out Vector3d result)
        {
            result.X = System.Math.Max(System.Math.Min(vector.X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(vector.Y, min.Y), max.Y);
            result.Z = System.Math.Max(System.Math.Min(vector.Z, min.Z), max.Z);
        }

        #endregion


        #region Interpolation

        public void Lerp(ref Vector3d end, double blend)
        {
            X = X + (end.X - X) * blend;
            Y = Y + (end.Y - Y) * blend;
            Z = Z + (end.Z - Z) * blend;
        }
        public void Lerp(ref Vector3d end, double blend, out Vector3d result)
        {
            result.X = X + (end.X - X) * blend;
            result.Y = Y + (end.Y - Y) * blend;
            result.Z = Z + (end.Z - Z) * blend;
        }
        public static void Lerp(ref Vector3d start, ref Vector3d end, double blend, out Vector3d result)
        {
            result.X = start.X + (end.X - start.X) * blend;
            result.Y = start.Y + (end.Y - start.Y) * blend;
            result.Z = start.Z + (end.Z - start.Z) * blend;
        }

        public void BaryCentric(ref Vector3d endU, ref Vector3d endV, double u, double v)
        {
            X = X + (endU.X - X) * u + (endV.X - X) * v;
            Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
            Z = Z + (endU.Z - Z) * u + (endV.Z - Z) * v;
        }
        public void BaryCentric(ref Vector3d endU, ref Vector3d endV, double u, double v, out Vector3d result)
        {
            result.X = X + (endU.X - X) * u + (endV.X - X) * v;
            result.Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
            result.Z = Z + (endU.Z - Z) * u + (endV.Z - Z) * v;
        }
        public static void BaryCentric(ref Vector3d start, ref Vector3d endU, ref Vector3d endV, double u, double v, out Vector3d result)
        {
            result.X = start.X + (endU.X - start.X) * u + (endV.X - start.X) * v;
            result.Y = start.Y + (endU.Y - start.Y) * u + (endV.Y - start.Y) * v;
            result.Z = start.Z + (endU.Z - start.Z) * u + (endV.Z - start.Z) * v;
        }

        #endregion


        #region String and Parse

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", X, Y, Z);
        }

        /// <summary>Parse left string to convert it to left vector.</summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The vector represented by the string.</returns>
        public static void Parse(string str, out Vector3d result)
        {
            Match match = new Regex(@"(?<x>.*) (?<y>.*) (?<z>.*)", RegexOptions.None).Match(str);
            if (!match.Success) throw new Exception("Parse failed!");
            result.X = double.Parse(match.Result("${x}"));
            result.Y = double.Parse(match.Result("${y}"));
            result.Z = double.Parse(match.Result("${z}"));
        }

        #endregion


        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        #endregion


        #region Constants

        /// <summary>A vector representing left zero vector.</summary>
        public static readonly Vector3d Zero = new Vector3d(0, 0, 0);

        /// <summary>A vector with all coordinates set to one.</summary>
        public static readonly Vector3d One = new Vector3d(1, 1, 1);

        /// <summary>A unit normal vector representing the positive X Axis.</summary>
        public static readonly Vector3d XAxis = new Vector3d(1, 0, 0);

        /// <summary>A unit normal vector representing the positive Y Axis.</summary>
        public static readonly Vector3d YAxis = new Vector3d(0, 1, 0);

        /// <summary>A unit normal vector representing the positive Z Axis.</summary>
        public static readonly Vector3d ZAxis = new Vector3d(0, 0, 1);

        #endregion
    }
}