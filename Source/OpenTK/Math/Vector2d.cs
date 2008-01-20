using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OpenTK.Math
{
    /// <summary>A 2-dimensional vector using double-precision floating point numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2d : IEquatable<Vector2d>, IComparer<Vector2d>, IComparable<Vector2d>
    {
        #region Fields & Access

        /// <summary>The X coordinate of the vector.</summary>
        public double X;

        /// <summary>The Y coordinate of the vector.</summary>
        public double Y;

        /// <summary>The coordinate at the index of the vector.</summary>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;

                    case 1:
                        return Y;
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        return;

                    case 1:
                        Y = value;
                        return;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>Converts the vector into an array of double-precision floating point numbers.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An array of double-precision floating point numbers representing the vector coordinates.</returns>
        public static explicit operator double[](Vector2d vector)
        {
            return new double[2] { vector.X, vector.Y };
        }

        /// <summary>Converts the vector into left double-precision floating point number pointer.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>A double-precision floating point number pointer to the vector coordinates.</returns>
        //unsafe public static explicit operator double*(Vector2d vector)
        //{
        //    return &vector.X;
        //}

        /// <summary>Converts the vector into an IntPtr.</summary>
        /// <param name="vector">The vector being converted.</param>
        /// <returns>An IntPtr to the vector coordinates.</returns>
        //public static explicit operator IntPtr(Vector2d vector)
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
        public Vector2d(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>Constructs left vector with the same coordinates as the given vector.</summary>
        /// <param name="vector">The vector whose coordinates to copy.</param>
        public Vector2d(ref Vector2d vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
        }

        /// <summary>Constructs left vector from the given array of double-precision floating point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the coordinates of the vector.</param>
        public Vector2d(double[] coordinateArray)
        {
            if (coordinateArray == null || coordinateArray.GetLength(0) < 2) throw new Exception("Invalid parameter.");

            this.X = coordinateArray[0];
            this.Y = coordinateArray[1];
        }

        #endregion


        #region Equality

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        [CLSCompliant(false)]
        public bool Equals(Vector2d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(ref Vector2d vector)
        {
            return
                X == vector.X &&
                Y == vector.Y;
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool Equals(ref Vector2d left, ref Vector2d right)
        {
            return
                left.X == right.X &&
                left.Y == right.Y;
        }

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="vector">An vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool EqualsApprox(ref Vector2d vector, double tolerance)
        {
            return
                System.Math.Abs(X - vector.X) <= tolerance &&
                System.Math.Abs(Y - vector.Y) <= tolerance;
        }

        /// <summary>Indicates whether two vectors are approximately equal to each other within left given tolerance.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <param name="tolerance">The tolerance for the approximation.</param>
        /// <returns>true if the vectors are approximately equal; otherwise, false.</returns>
        public static bool EqualsApprox(ref Vector2d left, ref Vector2d right, double tolerance)
        {
            return
                System.Math.Abs(left.X - right.X) <= tolerance &&
                System.Math.Abs(left.Y - right.Y) <= tolerance;
        }

        #endregion


        #region IComparer

        /// <summary>Compares two vectors and returns left value indicating whether one is less than, equal to, or greater than the other.</summary>
        public int Compare(Vector2d left, Vector2d right)
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

            return 0;
        }

        #endregion


        #region IComparable

        /// <summary>Compares the vector with another vector and returns left value indicating whether it is less than, equal to, or greater than the other vector.</summary>
        public int CompareTo(Vector2d vector) { return Compare(this, vector); }

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
                return X * X + Y * Y;
            }
        }

        /// <summary>Gets the approimate length of the vector.</summary>
        public double LengthApprox
        {
            get
            {
                return 1.0d / Functions.InverseSqrtFast(X * X + Y * Y);
            }
        }

        #endregion


        #region Distance

        /// <summary>Gets the distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the distance.</param>
        /// <returns>The distance from this vector to the given vector.</returns>
        public double DistanceTo(ref Vector2d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            return System.Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        /// <summary>Gets the squared distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the squared distance.</param>
        /// <returns>The squared distance from this vector to the given vector.</returns>
        public double DistanceSquaredTo(ref Vector2d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            return deltaX * deltaX + deltaY * deltaY;
        }

        /// <summary>Gets the approximate distance from this vector to the given vector.</summary>
        /// <param name="vector">The vector to which to find the approximate distance.</param>
        /// <returns>The approximate distance from this vector to the given vector.</returns>
        public double DistanceApproxTo(ref Vector2d vector)
        {
            double deltaX = vector.X - X;
            double deltaY = vector.Y - Y;
            return 1.0d / Functions.InverseSqrtFast(deltaX * deltaX + deltaY * deltaY);
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
            }
        }

        /// <summary>Get the normalized version of this vector.</summary>
        /// <param name="result">The resulting normalized vector.</param>
        public void Normalize(out Vector2d result)
        {
            double lengthSquared = LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = X;
                result.Y = Y;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = X / length;
                result.Y = Y / length;
            }
        }

        public static void Normalize(ref Vector2d vector, out Vector2d result)
        {
            double lengthSquared = vector.LengthSquared;

            if (lengthSquared == 1)
            {
                result.X = vector.X;
                result.Y = vector.Y;
            }
            else if (lengthSquared == 0)
            {
                result.X = 0;
                result.Y = 0;
            }
            else
            {
                double length = System.Math.Sqrt(lengthSquared);
                result.X = vector.X / length;
                result.Y = vector.Y / length;
            }
        }

        public void NormalizeApprox()
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y);
            X = X * inverseSquare;
            Y = Y * inverseSquare;
        }

        /// <summary>Gets left approximately normalized vector of the vector.</summary>
        public void NormalizedApprox(out Vector2d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(X * X + Y * Y);
            result.X = X * inverseSquare;
            result.Y = Y * inverseSquare;
        }

        public static void NormalizeApprox(ref Vector2d vector, out Vector2d result)
        {
            double inverseSquare = Functions.InverseSqrtFast(vector.X * vector.X + vector.Y * vector.Y);
            result.X = vector.X * inverseSquare;
            result.Y = vector.Y * inverseSquare;
        }

        #endregion


        /// <summary>Gets the dot product of two vectors.</summary>
        /// <param name="matrix">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        public static double DotProduct(ref Vector2d left, ref Vector2d right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

        #region Abs

        public void Abs()
        {
            X = System.Math.Abs(X);
            Y = System.Math.Abs(Y);
        }
        public void Abs(out Vector2d result)
        {
            result.X = System.Math.Abs(X);
            result.Y = System.Math.Abs(Y);
        }
        public static void Abs(ref Vector2d vector, out Vector2d result)
        {
            result.X = System.Math.Abs(vector.X);
            result.Y = System.Math.Abs(vector.Y);
        }

        #endregion


        #region Inverse

        public void Inverse()
        {
            X = -X;
            Y = -Y;
        }
        public void Inverse(out Vector2d result)
        {
            result.X = -X;
            result.Y = -Y;
        }
        public static void Inverse(ref Vector2d vector, out Vector2d result)
        {
            result.X = -vector.X;
            result.Y = -vector.Y;
        }

        #endregion


        #region Arithmatic

        public void Add(ref Vector2d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
        }
        public void Add(ref Vector2d vector, out Vector2d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
        }
        public static void Add(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
        }

        public void Add(double x, double y)
        {
            X = X + x;
            Y = Y + y;
        }
        public void Add(double x, double y, out Vector2d result)
        {
            result.X = X + x;
            result.Y = Y + y;
        }
        public static void Add(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
        }

        public void Subtract(ref Vector2d vector)
        {
            X = X - vector.X;
            Y = Y - vector.Y;
        }
        public void Subtract(ref Vector2d vector, out Vector2d result)
        {
            result.X = X - vector.X;
            result.Y = Y - vector.Y;
        }
        public static void Subtract(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X - right.X;
            result.Y = left.Y - right.Y;
        }

        public void Subtract(double x, double y)
        {
            X = X - x;
            Y = Y - y;
        }
        public void Subtract(double x, double y, out Vector2d result)
        {
            result.X = X - x;
            result.Y = Y - y;
        }
        public static void Subtract(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X - x;
            result.Y = vector.Y - y;
        }

        public void Multiply(double scalar)
        {
            X = X * scalar;
            Y = Y * scalar;
        }
        public void Multiply(double scalar, out Vector2d result)
        {
            result.X = X * scalar;
            result.Y = Y * scalar;
        }
        public static void Multiply(ref Vector2d vector, double scalar, out Vector2d result)
        {
            result.X = vector.X * scalar;
            result.Y = vector.Y * scalar;
        }

        public void Multiply(ref Vector2d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
        }
        public void Multiply(ref Vector2d vector, out Vector2d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
        }
        public static void Multiply(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
        }

        public void Multiply(double x, double y)
        {
            X = X * x;
            Y = Y * y;
        }
        public void Multiply(double x, double y, out Vector2d result)
        {
            result.X = X * x;
            result.Y = Y * y;
        }
        public static void Multiply(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
        }

        public void Divide(double scalar)
        {
            X = X / scalar;
            Y = Y / scalar;
        }
        public void Divide(double scalar, out Vector2d result)
        {
            result.X = X / scalar;
            result.Y = Y / scalar;
        }
        public static void Divide(ref Vector2d vector, double scalar, out Vector2d result)
        {
            result.X = vector.X / scalar;
            result.Y = vector.Y / scalar;
        }

        public void Divide(ref Vector2d vector)
        {
            X = X / vector.X;
            Y = Y / vector.Y;
        }
        public void Divide(ref Vector2d vector, out Vector2d result)
        {
            result.X = X / vector.X;
            result.Y = Y / vector.Y;
        }
        public static void Divide(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X / right.X;
            result.Y = left.Y / right.Y;
        }

        public void Divide(double x, double y)
        {
            X = X / x;
            Y = Y / y;
        }
        public void Divide(double x, double y, out Vector2d result)
        {
            result.X = X / x;
            result.Y = Y / y;
        }
        public static void Divide(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X / x;
            result.Y = vector.Y / y;
        }

        #endregion


        #region Transformations

        public void Transform(ref Matrix4d matrix)
        {
            double x = matrix.R0C0 * X + matrix.R0C1 * Y;
            Y = matrix.R1C0 * X + matrix.R1C1 * Y;
            X = x;
        }
        public void Transform(ref Matrix4d matrix, out Vector2d result)
        {
            result.X = matrix.R0C0 * X + matrix.R0C1 * Y;
            result.Y = matrix.R1C0 * X + matrix.R1C1 * Y;
        }
        public static void Transform(ref Vector2d vector, ref Matrix4d matrix, out Vector2d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y;
        }

        public void Translate(ref Vector2d vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
        }
        public void Translate(ref Vector2d vector, out Vector2d result)
        {
            result.X = X + vector.X;
            result.Y = Y + vector.Y;
        }
        public static void Translate(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
        }

        public void Translate(double x, double y)
        {
            X = X + x;
            Y = Y + y;
        }
        public void Translate(double x, double y, out Vector2d result)
        {
            result.X = X + x;
            result.Y = Y + y;
        }
        public static void Translate(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X + x;
            result.Y = vector.Y + y;
        }

        public void Scale(ref Vector2d vector)
        {
            X = X * vector.X;
            Y = Y * vector.Y;
        }
        public void Scale(ref Vector2d vector, out Vector2d result)
        {
            result.X = X * vector.X;
            result.Y = Y * vector.Y;
        }
        public static void Scale(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = left.X * right.X;
            result.Y = left.Y * right.Y;
        }

        public void Scale(double x, double y)
        {
            X = X * x;
            Y = Y * y;
        }
        public void Scale(double x, double y, out Vector2d result)
        {
            result.X = X * x;
            result.Y = Y * y;
        }
        public static void Scale(ref Vector2d vector, double x, double y, out Vector2d result)
        {
            result.X = vector.X * x;
            result.Y = vector.Y * y;
        }

        public void Rotate(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double x = cos * X + sin * Y;
            Y = cos * Y - sin * X;
            X = x;
        }
        public void Rotate(double angle, out Vector2d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * X + sin * Y;
            result.Y = cos * Y - sin * X;
        }
        public static void Rotate(ref Vector2d vector, double angle, out Vector2d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.X = cos * vector.X + sin * vector.Y;
            result.Y = cos * vector.Y - sin * vector.X;
        }

        #endregion


        #region Min & Max

        public void Min(ref Vector2d vector)
        {
            double lengthSquared = X * X + Y * Y;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y;

            if (vectorLengthSquared < lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
            }
        }
        public void Min(ref Vector2d vector, out Vector2d result)
        {
            double lengthSquared = X * X + Y * Y;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y;

            if (vectorLengthSquared < lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
            }
            else
            {
                result.X = X;
                result.Y = Y;
            }
        }
        public static void Min(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y;

            if (rightLengthSquared < leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
            }
        }

        public void Max(ref Vector2d vector)
        {
            double lengthSquared = X * X + Y * Y;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y;

            if (vectorLengthSquared > lengthSquared)
            {
                X = vector.X;
                Y = vector.Y;
            }
        }
        public void Max(ref Vector2d vector, out Vector2d result)
        {
            double lengthSquared = X * X + Y * Y;
            double vectorLengthSquared = vector.X * vector.X + vector.Y * vector.Y;

            if (vectorLengthSquared > lengthSquared)
            {
                result.X = vector.X;
                result.Y = vector.Y;
            }
            else
            {
                result.X = X;
                result.Y = Y;
            }
        }
        public static void Max(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            double leftLengthSquared = left.X * left.X + left.Y * left.Y;
            double rightLengthSquared = right.X * right.X + right.Y * right.Y;

            if (rightLengthSquared > leftLengthSquared)
            {
                result.X = right.X;
                result.Y = right.Y;
            }
            else
            {
                result.X = left.X;
                result.Y = left.Y;
            }
        }

        public void CoordinateMin(ref Vector2d vector)
        {
            X = System.Math.Min(X, vector.X);
            Y = System.Math.Min(Y, vector.Y);
        }
        public void CoordinateMin(ref Vector2d vector, out Vector2d result)
        {
            result.X = System.Math.Min(X, vector.X);
            result.Y = System.Math.Min(Y, vector.Y);
        }
        public static void CoordinateMin(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = System.Math.Min(left.X, right.X);
            result.Y = System.Math.Min(left.Y, right.Y);
        }

        public void CoordinateMax(ref Vector2d vector)
        {
            X = System.Math.Max(X, vector.X);
            Y = System.Math.Max(Y, vector.Y);
        }
        public void CoordinateMax(ref Vector2d vector, out Vector2d result)
        {
            result.X = System.Math.Max(X, vector.X);
            result.Y = System.Math.Max(Y, vector.Y);
        }
        public static void CoordinateMax(ref Vector2d left, ref Vector2d right, out Vector2d result)
        {
            result.X = System.Math.Max(left.X, right.X);
            result.Y = System.Math.Max(left.Y, right.Y);
        }

        public void Clamp(ref Vector2d min, ref Vector2d max)
        {
            X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
        }
        public void Clamp(ref Vector2d min, ref Vector2d max, out Vector2d result)
        {
            result.X = System.Math.Max(System.Math.Min(X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(Y, min.Y), max.Y);
        }
        public static void Clamp(ref Vector2d vector, ref Vector2d min, ref Vector2d max, out Vector2d result)
        {
            result.X = System.Math.Max(System.Math.Min(vector.X, min.X), max.X);
            result.Y = System.Math.Max(System.Math.Min(vector.Y, min.Y), max.Y);
        }

        #endregion


        #region Interpolation

        public void Lerp(ref Vector2d end, double blend)
        {
            X = X + (end.X - X) * blend;
            Y = Y + (end.Y - Y) * blend;
        }
        public void Lerp(ref Vector2d end, double blend, out Vector2d result)
        {
            result.X = X + (end.X - X) * blend;
            result.Y = Y + (end.Y - Y) * blend;
        }
        public static void Lerp(ref Vector2d start, ref Vector2d end, double blend, out Vector2d result)
        {
            result.X = start.X + (end.X - start.X) * blend;
            result.Y = start.Y + (end.Y - start.Y) * blend;
        }

        public void BaryCentric(ref Vector2d endU, ref Vector2d endV, double u, double v)
        {
            X = X + (endU.X - X) * u + (endV.X - X) * v;
            Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
        }
        public void BaryCentric(ref Vector2d endU, ref Vector2d endV, double u, double v, out Vector2d result)
        {
            result.X = X + (endU.X - X) * u + (endV.X - X) * v;
            result.Y = Y + (endU.Y - Y) * u + (endV.Y - Y) * v;
        }
        public static void BaryCentric(ref Vector2d start, ref Vector2d endU, ref Vector2d endV, double u, double v, out Vector2d result)
        {
            result.X = start.X + (endU.X - start.X) * u + (endV.X - start.X) * v;
            result.Y = start.Y + (endU.Y - start.Y) * u + (endV.Y - start.Y) * v;
        }

        #endregion


        #region String and Parse

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", X, Y);
        }

        /// <summary>Parse left string to convert it to left vector.</summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The vector represented by the string.</returns>
        public static void Parse(string str, out Vector2d result)
        {
            Match match = new Regex(@"(?<x>.*) (?<y>.*)", RegexOptions.None).Match(str);
            if (!match.Success) throw new Exception("Parse failed!");
            result.X = double.Parse(match.Result("${x}"));
            result.Y = double.Parse(match.Result("${y}"));
        }

        #endregion


        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        #endregion


        #region Constants

        /// <summary>A vector representing left zero vector.</summary>
        public static readonly Vector2d Zero = new Vector2d(0, 0);

        /// <summary>A vector with all coordinates set to one.</summary>
        public static readonly Vector2d One = new Vector2d(1, 1);

        #endregion
    }
}