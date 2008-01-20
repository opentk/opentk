using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OpenTK.Math
{
    /// <summary>A 4-dimensional vector using double-precision floating point numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4d : IEquatable<Vector4d>, IComparer<Vector4d>, IComparable<Vector4d>
    {
        #region Fields & Access

        /// <summary>The X coordinate of the vector.</summary>
        public double X;

        /// <summary>The Y coordinate of the vector.</summary>
        public double Y;

        /// <summary>The Z coordinate of the vector.</summary>
        public double Z;

        /// <summary>The W coordinate of the vector.</summary>
        public double W;

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

                    case 3:
                        return W;
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

                    case 3:
                        W = value;
                        return;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>Converts the vector into an array of double-precision floating point numbers.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An array of double-precision floating point numbers representing the vector coordinates.</returns>
        public static explicit operator double[](Vector4d vector)
        {
            return new double[4]{vector.X, vector.Y, vector.Z, vector.W};
        }

        /// <summary>Converts the vector into left double-precision floating point number pointer.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>A double-precision floating point number pointer to the vector coordinates.</returns>
        unsafe public static explicit operator double*(Vector4d vector)
        {
            return &vector.X;
        }

        /// <summary>Converts the vector into an IntPtr.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An IntPtr to the vector coordinates.</returns>
        public static explicit operator IntPtr(Vector4d vector)
        {
            unsafe
            {
                return (IntPtr)(&vector.X);
            }
        }

        #endregion

        
        #region Constructors

        /// <summary>Constructs left vector with the given coordinates.</summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="z">The Z coordinate.</param>
        /// <param name="w">The W coordinate.</param>
        public Vector4d(double x, double y, double z, double w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector4d(ref Vector2d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = 0;
            this.W = 0;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector4d(ref Vector3d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = vector.Z;
            this.W = 0;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector4d(ref Vector4d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = vector.Z;
            this.W = vector.W;
        }

        /// <summary>Constructs left vector from the given array of double-precision floating point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the coordinates of the vector.</param>
        public Vector4d(double[] coordinateArray)
        {
            if( coordinateArray == null || coordinateArray.GetLength(0) < 4 ) throw new Exception("Invalid parameter.");

            this.X = coordinateArray[0];
            this.Y = coordinateArray[1];
            this.Z = coordinateArray[2];
            this.W = coordinateArray[3];
        }

        #endregion


        #region Equality

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector4d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y &&
                Z == vector.Z &&
                W == vector.W;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(ref Vector4d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y &&
                Z == vector.Z &&
                W == vector.W;
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool Equals(ref Vector4d left, ref Vector4d right)
        {
            return
                left.X == right.X &&
                left.Y == right.Y &&
                left.Z == right.Z &&
                left.W == right.W;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool EqualsApprox(ref Vector4d vector, double tolerance)
        {
            return
                System.Math.Abs(X - vector.X) <= tolerance &&
                System.Math.Abs(Y - vector.Y) <= tolerance &&
                System.Math.Abs(Z - vector.Z) <= tolerance &&
                System.Math.Abs(W - vector.W) <= tolerance;        
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other within left given tolerance.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <param name="tolerance">The tolerance for the approximation.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool EqualsApprox(ref Vector4d left, ref Vector4d right, double tolerance)
        {
            return
                System.Math.Abs(left.X - right.X) <= tolerance &&
                System.Math.Abs(left.Y - right.Y) <= tolerance &&
                System.Math.Abs(left.Z - right.Z) <= tolerance &&
                System.Math.Abs(left.W - right.W) <= tolerance;
        }

        #endregion


        #region IComparer

        /// <summary>Compares two vectors and returns left value indicating whether one is less than, equal to, or greater than the other.</summary>
        public int Compare(Vector4d left, Vector4d right)
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
            else if (left.W != right.W)
            {
                if (left.W < right.W) return -1;
                else return 1;
            }

            return 0;
        }

        #endregion


        #region IComparable

        /// <summary>Compares the vector with another vector and returns left value indicating whether it is less than, equal to, or greater than the other vector.</summary>
        public int CompareTo(Vector4d vector) { return Compare(this, vector); }

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
                return X * X + Y * Y + Z * Z + W * W;
            }
        }

        /// <summary>Gets the approimate length of the vector.</summary>
        public double LengthApprox
        {
            get
            {
                return 1.0d / Functions.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
            }
        }

        #endregion


        #region Distance

        /// <summary>Gets the distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the distance.</param>
        /// <returns>The distance from this vector to the given vector.</returns>
        public double DistanceTo(ref Vector4d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            double deltaW = vector.W - W;
            return System.Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ + deltaW * deltaW);
        }

        /// <summary>Gets the squared distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the squared distance.</param>
        /// <returns>The squared distance from this vector to the given vector.</returns>
        public double DistanceSquaredTo(ref Vector4d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            double deltaW = vector.W - W;
            return deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ + deltaW * deltaW;
        }

        /// <summary>Gets the approximate distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the approximate distance.</param>
        /// <returns>The approximate distance from this vector to the given vector.</returns>
        public double DistanceApproxTo(ref Vector4d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            double deltaZ = vector.Z - Z;
            double deltaW = vector.W - W;
            return 1.0d / Functions.InverseSqrtFast(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ + deltaW * deltaW);
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
                W = W / length;
            }
        }

        /// <summary>Get the normalized version of this vector.</summary>
        /// <param name="result">The resulting normalized vector.</param>
        public void Normalize(out Vector4d result)
        {
            double lengthSquared = LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
                result.W = W;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
                result.W = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = X / length;
                result.Y = Y / length;
                result.Z = Z / length;
                result.W = W / length;
            }
        }

        public static void Normalize(ref Vector4d vector, out Vector4d result)
        {
            double lengthSquared = vector.LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
                result.W = vector.W;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
                result.W = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = vector.X / length;
                result.Y = vector.Y / length;
                result.Z = vector.Z / length;
                result.W = vector.W / length;
            }
        }

        public void NormalizeApprox()
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
            X = X * inverseSquare;
            Y = Y * inverseSquare;
            Z = Z * inverseSquare;
            W = W * inverseSquare;
        }

        /// <summary>Gets left approximately normalized vector of the vector.</summary>
        public void NormalizedApprox(out Vector4d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
            result.X = X * inverseSquare;
            result.Y = Y * inverseSquare;
            result.Z = Z * inverseSquare;
            result.W = W * inverseSquare;
        }

        public static void NormalizeApprox(ref Vector4d vector, out Vector4d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z + vector.W * vector.W);
            result.X = vector.X * inverseSquare;
            result.Y = vector.Y * inverseSquare;
            result.Z = vector.Z * inverseSquare;
            result.W = vector.W * inverseSquare;
        }

        #endregion


        /// <summary>Gets the dot product of two vectors.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        public static double DotProduct(ref Vector4d left, ref Vector4d right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
        }


        #region Abs

        public void Abs()
        {
            X = System.Math.Abs(X);
            Y = System.Math.Abs(Y);
            Z = System.Math.Abs(Z);
            W = System.Math.Abs(W);
        }
        public void Abs(out Vector4d result)
        {
            result.X = System.Math.Abs(X);
            result.Y = System.Math.Abs(Y);
            result.Z = System.Math.Abs(Z);
            result.W = System.Math.Abs(W);
        }
        public static void Abs(ref Vector4d vector, out Vector4d result)
        {
            result.X = System.Math.Abs(vector.X);
            result.Y = System.Math.Abs(vector.Y);
            result.Z = System.Math.Abs(vector.Z);
            result.W = System.Math.Abs(vector.W);
        }

        #endregion


        #region Inverse

        public void Inverse()
        {
            X = -X;
            Y = -Y;
            Z = -Z;
            W = -W;
        }
        public void Inverse(out Vector4d result)
        {
            result.X = -X;
            result.Y = -Y;
            result.Z = -Z;
            result.W = -W;
        }
        public static void Inverse(ref Vector4d vector, out Vector4d result)
        {
            result.X = -vector.X;
            result.Y = -vector.Y;
            result.Z = -vector.Z;
            result.W = -vector.W;
        }

        #endregion


        #region Arithmatic

        public void Add(ref Vector4d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
            Z = Z + vector.Z;
            W = W + vector.W;
        }
        public void Add(ref Vector4d vector, out Vector4d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
            result.Z = Z + vector.Z;
            result.W = W + vector.W;
        }
        public static void Add(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
            result.W = left.W + right.W;
        }

        public void Add(double x, double y, double z, double w)
        {
            X = X + x;
            Y = Y + y;
            Z = Z + z;
            W = W + w;
        }
        public void Add(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X + x;
            result.Y = Y + y;
            result.Z = Z + z;
            result.W = W + w;
        }
        public static void Add(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
            result.Z = vector.Z + z;
            result.W = vector.W + w;
        }

        public void Subtract(ref Vector4d vector)
        {
            X = X - vector.X;
            Y = Y - vector.Y;
            Z = Z - vector.Z;
            W = W - vector.W;
        }
        public void Subtract(ref Vector4d vector, out Vector4d result)
        {
            result.X = X - vector.X;
            result.Y = Y - vector.Y;
            result.Z = Z - vector.Z;
            result.W = W - vector.W;
        }
        public static void Subtract(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X - right.X;
            result.Y = left.Y - right.Y;
            result.Z = left.Z - right.Z;
            result.W = left.W - right.W;
        }

        public void Subtract(double x, double y, double z, double w)
        {
            X = X - x;
            Y = Y - y;
            Z = Z - z;
            W = W - w;
        }
        public void Subtract(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X - x;
            result.Y = Y - y;
            result.Z = Z - z;
            result.W = W - w;
        }
        public static void Subtract(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X - x;
            result.Y = vector.Y - y;
            result.Z = vector.Z - z;
            result.W = vector.W - w;
        }

        public void Multiply(double scalar)
        {
            X = X * scalar;
            Y = Y * scalar;
            Z = Z * scalar;
            W = W * scalar;
        }
        public void Multiply(double scalar, out Vector4d result)
        {
            result.X = X * scalar;
            result.Y = Y * scalar;
            result.Z = Z * scalar;
            result.W = W * scalar;
        }
        public static void Multiply(ref Vector4d vector, double scalar, out Vector4d result)
        {
            result.X = vector.X * scalar;
            result.Y = vector.Y * scalar;
            result.Z = vector.Z * scalar;
            result.W = vector.W * scalar;
        }

        public void Multiply(ref Vector4d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
            Z = Z * vector.Z;
            W = W * vector.W;
        }
        public void Multiply(ref Vector4d vector, out Vector4d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
            result.Z = Z * vector.Z;
            result.W = W * vector.W;
        }
        public static void Multiply(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
            result.Z = left.Z * right.Z;
            result.W = left.W * right.W;
        }

        public void Multiply(double x, double y, double z, double w)
        {
            X = X * x;
            Y = Y * y;
            Z = Z * z;
            W = W * w;
        }
        public void Multiply(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X * x;
            result.Y = Y * y;
            result.Z = Z * z;
            result.W = W * w;
        }
        public static void Multiply(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
            result.Z = vector.Z * z;
            result.W = vector.W * w;
        }

        public void Divide(double scalar)
        {
            X = X / scalar;
            Y = Y / scalar;
            Z = X / scalar;
            W = W / scalar;
        }
        public void Divide(double scalar, out Vector4d result)
        {
            result.X = X / scalar;
            result.Y = Y / scalar;
            result.Z = X / scalar;
            result.W = W / scalar;
        }
        public static void Divide(ref Vector4d vector, double scalar, out Vector4d result)
        {
            result.X = vector.X / scalar;
            result.Y = vector.Y / scalar;
            result.Z = vector.Z / scalar;
            result.W = vector.W / scalar;
        }

        public void Divide(ref Vector4d vector)
        {
            X = X / vector.X;
            Y = Y / vector.Y;
            Z = Z / vector.Z;
            W = W / vector.W;
        }
        public void Divide(ref Vector4d vector, out Vector4d result)
        {
            result.X = X / vector.X;
            result.Y = Y / vector.Y;
            result.Z = Z / vector.Z;
            result.W = W / vector.W;
        }
        public static void Divide(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X / right.X;
            result.Y = left.Y / right.Y;
            result.Z = left.Z / right.Z;
            result.W = left.W / right.W;
        }

        public void Divide(double x, double y, double z, double w)
        {
            X = X / x;
            Y = Y / y;
            Z = Z / z;
            W = W / w;
        }
        public void Divide(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X / x;
            result.Y = Y / y;
            result.Z = Z / z;
            result.W = W / w;
        }
        public static void Divide(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X / x;
            result.Y = vector.Y / y;
            result.Z = vector.Z / z;
            result.W = vector.W / w;
        }

        #endregion


        #region Transformations

        public void Transform(ref Matrix4d matrix)
        {
            double x = matrix.R0C0 * X + matrix.R0C1 * Y + matrix.R0C2 * Z + matrix.R0C3 * W;
            double y = matrix.R1C0 * X + matrix.R1C1 * Y + matrix.R1C2 * Z + matrix.R1C3 * W;
            double z = matrix.R2C0 * X + matrix.R2C1 * Y + matrix.R2C2 * Z + matrix.R2C3 * W;
            W = matrix.R3C0 * X + matrix.R3C1 * Y + matrix.R3C2 * Z + matrix.R3C3 * W;
            X = x;
            Y = y;
            Z = z;
        }
        public void Transform(ref Matrix4d matrix, out Vector4d result)
        {
            result.X = matrix.R0C0 * X + matrix.R0C1 * Y + matrix.R0C2 * Z + matrix.R0C3 * W;
            result.Y = matrix.R1C0 * X + matrix.R1C1 * Y + matrix.R1C2 * Z + matrix.R1C3 * W;
            result.Z = matrix.R2C0 * X + matrix.R2C1 * Y + matrix.R2C2 * Z + matrix.R2C3 * W;
            result.W = matrix.R3C0 * X + matrix.R3C1 * Y + matrix.R3C2 * Z + matrix.R3C3 * W;
        }
        public static void Transform(ref Vector4d vector, ref Matrix4d matrix, out Vector4d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z + matrix.R0C3 * vector.W;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z + matrix.R1C3 * vector.W;
            result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z + matrix.R2C3 * vector.W;
            result.W = matrix.R3C0 * vector.X + matrix.R3C1 * vector.Y + matrix.R3C2 * vector.Z + matrix.R3C3 * vector.W;
        }

        public void Translate(ref Vector4d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
            Z = Z + vector.Z;
            W = W + vector.W;
        }
        public void Translate(ref Vector4d vector, out Vector4d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
            result.Z = Z + vector.Z;
            result.W = W + vector.W;
        }
        public static void Translate(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
            result.W = left.W + right.W;
        }

        public void Translate(double x, double y, double z, double w)
        {
            X = X + x;
            Y = Y + y;
            Z = Z + z;
            W = W + w;
        }
        public void Translate(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X + x;
            result.Y = Y + y;
            result.Z = Z + z;
            result.W = W + w;
        }
        public static void Translate(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
            result.Z = vector.Z + z;
            result.W = vector.W + w;
        }

        public void Scale(ref Vector4d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
            Z = Z * vector.Z;
            W = W * vector.W;
        }
        public void Scale(ref Vector4d vector, out Vector4d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
            result.Z = Z * vector.Z;
            result.W = W * vector.W;
        }
        public static void Scale(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
            result.Z = left.Z * right.Z;
            result.W = left.W * right.W;
        }

        public void Scale(double x, double y, double z, double w)
        {
            X = X * x;
            Y = Y * y;
            Z = Z * z;
            W = W * w;
        }
        public void Scale(double x, double y, double z, double w, out Vector4d result)
        {
            result.X = X * x;
            result.Y = Y * y;
            result.Z = Z * z;
            result.W = W * w;
        }
        public static void Scale(ref Vector4d vector, double x, double y, double z, double w, out Vector4d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
            result.Z = vector.Z * z;
            result.W = vector.W * w;
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
        public void RotateX(double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = X;
            result.Y = cos * Y + sin * Z;
            result.Z = cos * Z - sin * Y;
            result.W = W;
        }
        public static void RotateX(ref Vector4d vector, double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = vector.X;
            result.Y = cos * vector.Y + sin * vector.Z;
            result.Z = cos * vector.Z - sin * vector.Y;
            result.W = vector.W;
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
        public void RotateY(double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * X - sin * Z;
            result.Y = Y;
            result.Z = sin * Y + cos * Z;
            result.W = W;
        }
        public static void RotateY(ref Vector4d vector, double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * vector.X - sin * vector.Z;
            result.Y = vector.Y;
            result.Z = sin * vector.Y + cos * vector.Z;
            result.W = vector.W;
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
        public void RotateZ(double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * X + sin * Y;
            result.Y = cos * Y - sin * X;
            result.Z = Z;
            result.W = W;
        }
        public static void RotateZ(ref Vector4d vector, double angle, out Vector4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * vector.X + sin * vector.Y;
            result.Y = cos * vector.Y - sin * vector.X;
            result.Z = vector.Z;
            result.W = vector.W;
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
        public void Rotate(ref Vector3d axis, double angle, out Vector4d result)
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
            result.W = W;
        }
        public static void Rotate(ref Vector4d vector, ref Vector3d axis, double angle, out Vector4d result)
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

            result.X = (xxOneMinusCos + cos ) * vector.X + (xyOneMinusCos + zSin) * vector.Y + (xzOneMinusCos - ySin) * vector.Z;
            result.Y = (xyOneMinusCos - zSin) * vector.X + (yyOneMinusCos +  cos) * vector.Y + (yzOneMinusCos + xSin) * vector.Z;
            result.Z = (xzOneMinusCos + ySin) * vector.X + (yzOneMinusCos - xSin) * vector.Y + (zzOneMinusCos + cos ) * vector.Z;
            result.W = vector.W;
        }

        #endregion


        #region Min & Max

        public void Min(ref Vector4d vector)
        {
            double lengthSquared = X * X + Y * Y + Z * Z + W * W;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z + vector.W * vector.W;

            if (vectorLengthSquared < lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
                Z = vector.Z;
                W = vector.W;
            }
        }
        public void Min(ref Vector4d vector, out Vector4d result)
        {
            double lengthSquared = X * X + Y * Y + Z * Z + W * W;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z + vector.W * vector.W;

            if (vectorLengthSquared < lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
                result.W = vector.W;
            }
            else
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
                result.W = W;
            }
        }
        public static void Min(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y + left.Z * left.Z + left.W * left.W;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y + right.Z * right.Z + right.W * right.W;

            if (rightLengthSquared < leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
                result.Z = right.Z;
                result.W = right.W;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
                result.Z = left.Z;
                result.W = left.W;
            }
        }

        public void Max(ref Vector4d vector)
        {
            double lengthSquared = X * X + Y * Y + Z * Z + W * W;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z + vector.W * vector.W;

            if (vectorLengthSquared > lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
                Z = vector.Z;
                W = vector.W;
            }
        }
        public void Max(ref Vector4d vector, out Vector4d result)
        {
            double lengthSquared = X * X + Y * Y + Z * Z + W * W;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z + vector.W * vector.W;

            if (vectorLengthSquared > lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
                result.Z = vector.Z;
                result.W = vector.W;
            }
            else
            {
                result.X = X;
                result.Y = Y;
                result.Z = Z;
                result.W = W;
            }
        }
        public static void Max(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y + left.Z * left.Z + left.W * left.W;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y + right.Z * right.Z + right.W * right.W;

            if (rightLengthSquared > leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
                result.Z = right.Z;
                result.W = right.W;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
                result.Z = left.Z;
                result.W = left.W;
            }
        }

        public void CoordinateMin(ref Vector4d vector)
        {
            X = System.Math.Min(X, vector.X);
            Y = System.Math.Min(Y, vector.Y);
            Z = System.Math.Min(Z, vector.Z);
            W = System.Math.Min(W, vector.W);
        }
        public void CoordinateMin(ref Vector4d vector, out Vector4d result)
        {
            result.X = System.Math.Min(X, vector.X);
            result.Y = System.Math.Min(Y, vector.Y);
            result.Z = System.Math.Min(Z, vector.Z);
            result.W = System.Math.Min(W, vector.W);
        }
        public static void CoordinateMin(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = System.Math.Min(left.X, right.X);
            result.Y = System.Math.Min(left.Y, right.Y);
            result.Z = System.Math.Min(left.Z, right.Z);
            result.W = System.Math.Min(left.W, right.W);
        }

        public void CoordinateMax(ref Vector4d vector)
        {
            X = System.Math.Max(X, vector.X);
            Y = System.Math.Max(Y, vector.Y);
            Z = System.Math.Max(Z, vector.Z);
            W = System.Math.Max(W, vector.W);
        }
        public void CoordinateMax(ref Vector4d vector, out Vector4d result)
        {
            result.X = System.Math.Max(X, vector.X);
            result.Y = System.Math.Max(Y, vector.Y);
            result.Z = System.Math.Max(Z, vector.Z);
            result.W = System.Math.Max(W, vector.W);
        }
        public static void CoordinateMax(ref Vector4d left, ref Vector4d right, out Vector4d result)
        {
            result.X = System.Math.Max(left.X, right.X);
            result.Y = System.Math.Max(left.Y, right.Y);
            result.Z = System.Math.Max(left.Z, right.Z);
            result.W = System.Math.Max(left.W, right.W);
        }

        public void Clamp(ref Vector4d min, ref Vector4d max)
        {
            X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
            Z = System.Math.Max(System.Math.Min(Z, min.Z), max.Z);
            W = System.Math.Max(System.Math.Min(W, min.W), max.W);
        }
        public void Clamp(ref Vector4d min, ref Vector4d max, out Vector4d result)
        {
            result.X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
            result.Z = System.Math.Max(System.Math.Min(Z, min.Z), max.Z);
            result.W = System.Math.Max(System.Math.Min(W, min.W), max.W);
        }
        public static void Clamp(ref Vector4d vector, ref Vector4d min, ref Vector4d max, out Vector4d result)
        {
            result.X = System.Math.Max(System.Math.Min(vector.X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(vector.Y, min.Y), max.Y);
            result.Z = System.Math.Max(System.Math.Min(vector.Z, min.Z), max.Z);
            result.W = System.Math.Max(System.Math.Min(vector.W, min.W), max.W);
        }

        #endregion


        #region Interpolation

        public void Lerp(ref Vector4d end, double blend)
        {
            X = X + (end.X - X) * blend;
            Y = Y + (end.Y - Y) * blend;
            Z = Z + (end.Z - Z) * blend;
            W = W + (end.W - W) * blend;
        }
        public void Lerp(ref Vector4d end, double blend, out Vector4d result)
        {
            result.X = X + (end.X - X) * blend;
            result.Y = Y + (end.Y - Y) * blend;
            result.Z = Z + (end.Z - Z) * blend;
            result.W = W + (end.W - W) * blend;
        }
        public static void Lerp(ref Vector4d start, ref Vector4d end, double blend, out Vector4d result)
        {
            result.X = start.X + (end.X - start.X) * blend;
            result.Y = start.Y + (end.Y - start.Y) * blend;
            result.Z = start.Z + (end.Z - start.Z) * blend;
            result.W = start.W + (end.W - start.W) * blend;
        }

        public void BaryCentric(ref Vector4d endU, ref Vector4d endV, double u, double v)
        {
            X = X + (endU.X - X) * u + (endV.X - X) * v;
            Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
            Z = Z + (endU.Z - Z) * u + (endV.Z - Z) * v;
            W = W + (endU.W - W) * u + (endV.W - W) * v;
        }
        public void BaryCentric(ref Vector4d endU, ref Vector4d endV, double u, double v, out Vector4d result)
        {
            result.X = X + (endU.X - X) * u + (endV.X - X) * v;
            result.Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
            result.Z = Z + (endU.Z - Z) * u + (endV.Z - Z) * v;
            result.W = W + (endU.W - W) * u + (endV.W - W) * v;
        }
        public static void BaryCentric(ref Vector4d start, ref Vector4d endU, ref Vector4d endV, double u, double v, out Vector4d result)
        {
            result.X = start.X + (endU.X - start.X) * u + (endV.X - start.X) * v;
            result.Y = start.Y + (endU.Y - start.Y) * u + (endV.Y - start.Y) * v;
            result.Z = start.Z + (endU.Z - start.Z) * u + (endV.Z - start.Z) * v;
            result.W = start.W + (endU.W - start.W) * u + (endV.W - start.W) * v;
        }

        #endregion


        #region String and Parse

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", X, Y, Z, W);
        }

        /// <summary>Parse left string to convert it to left vector.</summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The vector represented by the string.</returns>
        public static void Parse(string str, out Vector4d result)
        {
            Match match = new Regex(@"(?<x>.*) (?<y>.*) (?<z>.*) (?<w>.*)", RegexOptions.None).Match(str);
            if (!match.Success) throw new Exception("Parse failed!");
            result.X = double.Parse(match.Result("${x}"));
            result.Y = double.Parse(match.Result("${y}"));
            result.Z = double.Parse(match.Result("${z}"));
            result.W = double.Parse(match.Result("${w}"));
        }

        #endregion


        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }

        #endregion


        #region Constants

        /// <summary>A vector representing left zero vector.</summary>
        public static readonly Vector4d Zero = new Vector4d(0, 0, 0, 0);

        /// <summary>A vector with all coordinates set to one.</summary>
        public static readonly Vector4d One = new Vector4d(1, 1, 1, 1);

        /// <summary>A unit normal vector representing the positive X Axis.</summary>
        public static readonly Vector4d XAxis = new Vector4d(1, 0, 0, 0);

        /// <summary>A unit normal vector representing the positive Y Axis.</summary>
        public static readonly Vector4d YAxis = new Vector4d(0, 1, 0, 0);

        /// <summary>A unit normal vector representing the positive Z Axis.</summary>
        public static readonly Vector4d ZAxis = new Vector4d(0, 0, 1, 0);

        /// <summary>A unit normal vector representing the positive W Axis.</summary>
        public static readonly Vector4d WAxis = new Vector4d(0, 0, 0, 1);

        #endregion
    }
}