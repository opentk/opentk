﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a 3D vector using three single-precision floating-point numbers.
    /// </summary>
    /// <remarks>
    /// The Vector3 structure is suitable for interoperation with unmanaged code requiring three consecutive floats.
    /// </remarks>
    [Obsolete("OpenTK.Math functions have been moved to the root OpenTK namespace (reason: XNA compatibility")]
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3 : IEquatable<Vector3>
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public float Z;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Vector3.
        /// </summary>
        /// <param name="x">The x component of the Vector3.</param>
        /// <param name="y">The y component of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector2.
        /// </summary>
        /// <param name="v">The Vector2 to copy components from.</param>
        public Vector3(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector3.
        /// </summary>
        /// <param name="v">The Vector3 to copy components from.</param>
        public Vector3(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector4.
        /// </summary>
        /// <param name="v">The Vector4 to copy components from.</param>
        public Vector3(Vector4 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        #endregion

        #region Public Members

        #region Instance

        #region public void Add()

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        public void Add(Vector3 right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
        }

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        public void Add(ref Vector3 right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
        }

        #endregion public void Add()

        #region public void Sub()

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        public void Sub(Vector3 right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
        }

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        public void Sub(ref Vector3 right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
        }

        #endregion public void Sub()

        #region public void Mult()

        /// <summary>Multiply this instance by a scalar.</summary>
        /// <param name="f">Scalar operand.</param>
        public void Mult(float f)
        {
            this.X *= f;
            this.Y *= f;
            this.Z *= f;
        }

        #endregion public void Mult()

        #region public void Div()

        /// <summary>Divide this instance by a scalar.</summary>
        /// <param name="f">Scalar operand.</param>
        public void Div(float f)
        {
            float mult = 1.0f / f;
            this.X *= mult;
            this.Y *= mult;
            this.Z *= mult;
        }

        #endregion public void Div()

        #region public float Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        #endregion

        #region public float LengthFast

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude, with
        /// an upper error bound of 0.001.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public float LengthFast
        {
            get
            {
                return 1.0f / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
            }
        }

        #endregion

        #region public float LengthSquared

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthFast"/>
        public float LengthSquared
        {
            get
            {
                return X * X + Y * Y + Z * Z;
            }
        }

        #endregion

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector3 to unit length.
        /// </summary>
        public void Normalize()
        {
            float scale = 1.0f / this.Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
        }

        #endregion

        #region public void NormalizeFast()

        /// <summary>
        /// Scales the Vector3 to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            float scale = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            X *= scale;
            Y *= scale;
            Z *= scale;
        }

        #endregion

        #region public void Scale()

        /// <summary>
        /// Scales the current Vector3 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        public void Scale(float sx, float sy, float sz)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            this.Z = Z * sz;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        public void Scale(Vector3 scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [CLSCompliant(false)]
        public void Scale(ref Vector3 scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
        }

        #endregion public void Scale()

        #endregion

        #region Static

        #region Fields

        /// <summary>
        /// Defines a unit-length Vector3 that points towards the X-axis.
        /// </summary>
        public static readonly Vector3 UnitX = new Vector3(1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector3 that points towards the Y-axis.
        /// </summary>
        public static readonly Vector3 UnitY = new Vector3(0, 1, 0);

        /// <summary>
        /// /// Defines a unit-length Vector3 that points towards the Z-axis.
        /// </summary>
        public static readonly Vector3 UnitZ = new Vector3(0, 0, 1);

        /// <summary>
        /// Defines a zero-length Vector3.
        /// </summary>
        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3 One = new Vector3(1, 1, 1);

        /// <summary>
        /// Defines the size of the Vector3 struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector3());

        #endregion

        #region Add

        /// <summary>
        /// Add two Vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of addition</returns>
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
        }

        /// <summary>
        /// Add two Vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of addition</param>
        public static void Add(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;
        }

        #endregion

        #region Sub

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        public static Vector3 Sub(Vector3 a, Vector3 b)
        {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of subtraction</param>
        public static void Sub(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
        }

        #endregion

        #region Mult

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <returns>Result of the multiplication</returns>
        public static Vector3 Mult(Vector3 a, float f)
        {
            a.X *= f;
            a.Y *= f;
            a.Z *= f;
            return a;
        }

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <param name="result">Result of the multiplication</param>
        public static void Mult(ref Vector3 a, float f, out Vector3 result)
        {
            result.X = a.X * f;
            result.Y = a.Y * f;
            result.Z = a.Z * f;
        }

        #endregion

        #region Div

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <returns>Result of the division</returns>
        public static Vector3 Div(Vector3 a, float f)
        {
            float mult = 1.0f / f;
            a.X *= mult;
            a.Y *= mult;
            a.Z *= mult;
            return a;
        }

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <param name="result">Result of the division</param>
        public static void Div(ref Vector3 a, float f, out Vector3 result)
        {
            float mult = 1.0f / f;
            result.X = a.X * mult;
            result.Y = a.Y * mult;
            result.Z = a.Z * mult;
        }

        #endregion

        #region ComponentMin

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector3 ComponentMin(Vector3 a, Vector3 b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise minimum</param>
        public static void ComponentMin(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
        }

        #endregion

        #region ComponentMax

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise maximum</returns>
        public static Vector3 ComponentMax(Vector3 a, Vector3 b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise maximum</param>
        public static void ComponentMax(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
        }

        #endregion

        #region Min

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3 Min(Vector3 left, Vector3 right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        #endregion

        #region Max

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3 Max(Vector3 left, Vector3 right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        #endregion

        #region Clamp

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <returns>The clamped vector</returns>
        public static Vector3 Clamp(Vector3 vec, Vector3 min, Vector3 max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector3 vec, ref Vector3 min, ref Vector3 max, out Vector3 result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector3 Normalize(Vector3 vec)
        {
            float scale = 1.0f / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector3 vec, out Vector3 result)
        {
            float scale = 1.0f / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        #endregion

        #region NormalizeFast

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector3 NormalizeFast(Vector3 vec)
        {
            float scale = Functions.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref Vector3 vec, out Vector3 result)
        {
            float scale = Functions.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The dot product of the two inputs</returns>
        public static float Dot(Vector3 left, Vector3 right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <param name="result">The dot product of the two inputs</param>
        public static void Dot(ref Vector3 left, ref Vector3 right, out float result)
        {
            result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        #endregion

        #region Cross

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            return new Vector3(left.Y * right.Z - left.Z * right.Y,
                               left.Z * right.X - left.X * right.Z,
                               left.X * right.Y - left.Y * right.X);
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        /// <param name="result">The cross product of the two inputs</param>
        public static void Cross(ref Vector3 left, ref Vector3 right, out Vector3 result)
        {
            result.X = left.Y * right.Z - left.Z * right.Y;
            result.Y = left.Z * right.X - left.X * right.Z;
            result.Z = left.X * right.Y - left.Y * right.X;
        }

        #endregion

        #region Lerp

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise</returns>
        public static Vector3 Lerp(Vector3 a, Vector3 b, float blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
            a.Z = blend * (b.Z - a.Z) + a.Z;
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector3 a, ref Vector3 b, float blend, out Vector3 result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
            result.Z = blend * (b.Z - a.Z) + a.Z;
        }

        #endregion

        #region Barycentric

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates
        /// </summary>
        /// <param name="a">First input Vector</param>
        /// <param name="b">Second input Vector</param>
        /// <param name="c">Third input Vector</param>
        /// <param name="u">First Barycentric Coordinate</param>
        /// <param name="v">Second Barycentric Coordinate</param>
        /// <returns>a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</returns>
        public static Vector3 BaryCentric(Vector3 a, Vector3 b, Vector3 c, float u, float v)
        {
            return a + u * (b - a) + v * (c - a);
        }

        /// <summary>Interpolate 3 Vectors using Barycentric coordinates</summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <param name="result">Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</param>
        public static void BaryCentric(ref Vector3 a, ref Vector3 b, ref Vector3 c, float u, float v, out Vector3 result)
        {
            result = a; // copy

            Vector3 temp = b; // copy
            temp.Sub(ref a);
            temp.Mult(u);
            result.Add(ref temp);

            temp = c; // copy
            temp.Sub(ref a);
            temp.Mult(v);
            result.Add(ref temp);
        }

        #endregion

        #region Transform

        /// <summary>Transform a direction vector by the given Matrix
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed vector</returns>
        public static Vector3 TransformVector(Vector3 vec, Matrix4 mat)
        {
            Vector3 v;
            v.X = Vector3.Dot(vec, new Vector3(mat.Column0));
            v.Y = Vector3.Dot(vec, new Vector3(mat.Column1));
            v.Z = Vector3.Dot(vec, new Vector3(mat.Column2));
            return v;
        }

        /// <summary>Transform a direction vector by the given Matrix
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed vector</param>
        public static void TransformVector(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
        {
            result.X = vec.X * mat.Row0.X +
                       vec.Y * mat.Row1.X +
                       vec.Z * mat.Row2.X;

            result.Y = vec.X * mat.Row0.Y +
                       vec.Y * mat.Row1.Y +
                       vec.Z * mat.Row2.Y;

            result.Z = vec.X * mat.Row0.Z +
                       vec.Y * mat.Row1.Z +
                       vec.Z * mat.Row2.Z;
        }

        /// <summary>Transform a Normal by the given Matrix</summary>
        /// <remarks>
        /// This calculates the inverse of the given matrix, use TransformNormalInverse if you
        /// already have the inverse to avoid this extra calculation
        /// </remarks>
        /// <param name="norm">The normal to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed normal</returns>
        public static Vector3 TransformNormal(Vector3 norm, Matrix4 mat)
        {
            mat.Invert();
            return TransformNormalInverse(norm, mat);
        }

        /// <summary>Transform a Normal by the given Matrix</summary>
        /// <remarks>
        /// This calculates the inverse of the given matrix, use TransformNormalInverse if you
        /// already have the inverse to avoid this extra calculation
        /// </remarks>
        /// <param name="norm">The normal to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed normal</param>
        public static void TransformNormal(ref Vector3 norm, ref Matrix4 mat, out Vector3 result)
        {
            Matrix4 Inverse = Matrix4.Invert(mat);
            Vector3.TransformNormalInverse(ref norm, ref Inverse, out result);
        }

        /// <summary>Transform a Normal by the (transpose of the) given Matrix</summary>
        /// <remarks>
        /// This version doesn't calculate the inverse matrix.
        /// Use this version if you already have the inverse of the desired transform to hand
        /// </remarks>
        /// <param name="norm">The normal to transform</param>
        /// <param name="invMat">The inverse of the desired transformation</param>
        /// <returns>The transformed normal</returns>
        public static Vector3 TransformNormalInverse(Vector3 norm, Matrix4 invMat)
        {
            Vector3 n;
            n.X = Vector3.Dot(norm, new Vector3(invMat.Row0));
            n.Y = Vector3.Dot(norm, new Vector3(invMat.Row1));
            n.Z = Vector3.Dot(norm, new Vector3(invMat.Row2));
            return n;
        }

        /// <summary>Transform a Normal by the (transpose of the) given Matrix</summary>
        /// <remarks>
        /// This version doesn't calculate the inverse matrix.
        /// Use this version if you already have the inverse of the desired transform to hand
        /// </remarks>
        /// <param name="norm">The normal to transform</param>
        /// <param name="invMat">The inverse of the desired transformation</param>
        /// <param name="result">The transformed normal</param>
        public static void TransformNormalInverse(ref Vector3 norm, ref Matrix4 invMat, out Vector3 result)
        {
            result.X = norm.X * invMat.Row0.X +
                       norm.Y * invMat.Row0.Y +
                       norm.Z * invMat.Row0.Z;

            result.Y = norm.X * invMat.Row1.X +
                       norm.Y * invMat.Row1.Y +
                       norm.Z * invMat.Row1.Z;

            result.Z = norm.X * invMat.Row2.X +
                       norm.Y * invMat.Row2.Y +
                       norm.Z * invMat.Row2.Z;
        }

        /// <summary>Transform a Position by the given Matrix</summary>
        /// <param name="pos">The position to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed position</returns>
        public static Vector3 TransformPosition(Vector3 pos, Matrix4 mat)
        {
            Vector3 p;
            p.X = Vector3.Dot(pos, new Vector3(mat.Column0)) + mat.Row3.X;
            p.Y = Vector3.Dot(pos, new Vector3(mat.Column1)) + mat.Row3.Y;
            p.Z = Vector3.Dot(pos, new Vector3(mat.Column2)) + mat.Row3.Z;
            return p;
        }

        /// <summary>Transform a Position by the given Matrix</summary>
        /// <param name="pos">The position to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed position</param>
        public static void TransformPosition(ref Vector3 pos, ref Matrix4 mat, out Vector3 result)
        {
            result.X = pos.X * mat.Row0.X +
                       pos.Y * mat.Row1.X +
                       pos.Z * mat.Row2.X +
                       mat.Row3.X;

            result.Y = pos.X * mat.Row0.Y +
                       pos.Y * mat.Row1.Y +
                       pos.Z * mat.Row2.Y +
                       mat.Row3.Y;

            result.Z = pos.X * mat.Row0.Z +
                       pos.Y * mat.Row1.Z +
                       pos.Z * mat.Row2.Z +
                       mat.Row3.Z;
        }

        /// <summary>Transform a Vector by the given Matrix</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed vector</returns>
        public static Vector4 Transform(Vector3 vec, Matrix4 mat)
        {
            Vector4 v4 = new Vector4(vec.X, vec.Y, vec.Z, 1.0f);
            Vector4 result;
            result.X = Vector4.Dot(v4, mat.Column0);
            result.Y = Vector4.Dot(v4, mat.Column1);
            result.Z = Vector4.Dot(v4, mat.Column2);
            result.W = Vector4.Dot(v4, mat.Column3);
            return result;
        }

        /// <summary>Transform a Vector by the given Matrix</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed vector</param>
        public static void Transform(ref Vector3 vec, ref Matrix4 mat, out Vector4 result)
        {
            Vector4 v4 = new Vector4(vec.X, vec.Y, vec.Z, 1.0f);
            Vector4.Transform(ref v4, ref mat, out result);
        }

        /// <summary>Transform a Vector3 by the given Matrix, and project the resulting Vector4 back to a Vector3</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed vector</returns>
        public static Vector3 TransformPerspective(Vector3 vec, Matrix4 mat)
        {
            Vector4 h = Transform(vec, mat);
            return new Vector3(h.X / h.W, h.Y / h.W, h.Z / h.W);
        }

        /// <summary>Transform a Vector3 by the given Matrix, and project the resulting Vector4 back to a Vector3</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed vector</param>
        public static void TransformPerspective(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
        {
            Vector4 h;
            Vector3.Transform(ref vec, ref mat, out h);
            result.X = h.X / h.W;
            result.Y = h.Y / h.W;
            result.Z = h.Z / h.W;
        }

        #endregion

        #region CalculateAngle

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static float CalculateAngle(Vector3 first, Vector3 second)
        {
            return (float)System.Math.Acos((Vector3.Dot(first, second)) / (first.Length * second.Length));
        }

        /// <summary>Calculates the angle (in radians) between two vectors.</summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(ref Vector3 first, ref Vector3 second, out float result)
        {
            float temp;
            Vector3.Dot(ref first, ref second, out temp);
            result = (float)System.Math.Acos(temp / (first.Length * second.Length));
        }

        #endregion

        #endregion

        #region Swizzle

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Xy { get { return new Vector2(X, Y); } set { X = value.X; Y = value.Y; } }

        #endregion

        #region Operators

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            return left;
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            return left;
        }

        public static Vector3 operator -(Vector3 vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            return vec;
        }

        public static Vector3 operator *(Vector3 vec, float f)
        {
            vec.X *= f;
            vec.Y *= f;
            vec.Z *= f;
            return vec;
        }

        public static Vector3 operator *(float f, Vector3 vec)
        {
            vec.X *= f;
            vec.Y *= f;
            vec.Z *= f;
            return vec;
        }

        public static Vector3 operator /(Vector3 vec, float f)
        {
            float mult = 1.0f / f;
            vec.X *= mult;
            vec.Y *= mult;
            vec.Z *= mult;
            return vec;
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Vector3.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        #endregion

        #region public override bool Equals(object obj)

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Vector3))
                return false;

            return this.Equals((Vector3)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Vector3> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector3 other)
        {
            return
                X == other.X &&
                Y == other.Y &&
                Z == other.Z;
        }

        #endregion
    }
}
