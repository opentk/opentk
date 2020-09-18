using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Mathematics.Rotors
{
    public struct Rotor3 : IEquatable<Rotor3>
    {
        // FIXME: Better name!
        public float A;

        public float YZ;
        public float ZX;
        public float XY;

        public Rotor3(float a, float yz, float zx, float xy)
        {
            A = a;
            YZ = yz;
            ZX = zx;
            XY = xy;
        }

        public Rotor3(float a, in BiVector3d bv)
        {
            A = a;
            YZ = bv.NotX;
            ZX = bv.NotY;
            XY = bv.NotZ;
        }

        public Rotor3(Vector3 from, Vector3 to)
        {
            A = 1 + Vector3.Dot(to, from);
            BiVector3d bivec = Vector3.Wedge(to, from);
            YZ = bivec.NotX;
            ZX = bivec.NotY;
            XY = bivec.NotZ;
        }

        public float Length => (float)Math.Sqrt(LengthSquared);

        public float LengthSquared => (A * A) + (YZ * YZ) + (ZX * ZX) + (XY * XY);

        public BiVector3d BiVector => new BiVector3d(YZ, ZX, XY);

        public static Rotor3 Multiply(in Rotor3 a, in Rotor3 b)
        {
            Multiply(a, b, out Rotor3 res);
            return res;
        }

        public static void Multiply(in Rotor3 a, in Rotor3 b, out Rotor3 res)
        {
            res.A = (a.A * b.A) - (a.YZ * b.YZ) - (a.ZX * b.ZX) - (a.XY * b.XY);
            res.YZ = (a.YZ * b.A) + (a.A * b.YZ) + (a.XY * b.ZX) - (a.ZX * b.XY);
            res.ZX = (a.ZX * b.A) + (a.A * b.ZX) - (a.XY * b.YZ) + (a.YZ * b.XY);
            res.XY = (a.XY * b.A) + (a.A * b.XY) + (a.ZX * b.YZ) - (a.YZ * b.ZX);
        }

        public static Vector3 Rotate(in Rotor3 r, in Vector3 v)
        {
            Rotate(r, v, out Vector3 res);
            return res;
        }

        public static void Rotate(in Rotor3 r, in Vector3 v, out Vector3 res)
        {
            Vector3 q;
            q.X = (r.A * v.X) + (v.Z * r.ZX) + (v.Y * r.XY);
            q.Y = (r.A * v.Y) - (v.X * r.XY) + (v.Z * r.YZ);
            q.Z = (r.A * v.Z) - (v.Y * r.YZ) - (v.X * r.XY);

            float xyz = (v.X * r.XY) + (v.Y * r.ZX) + (v.Z * r.YZ);

            res.X = (r.A * q.X) + (q.Y * r.YZ) + (q.Z * r.ZX) - (xyz * r.XY);
            res.Y = (r.A * q.Y) - (q.X * r.YZ) + (xyz * r.ZX) + (v.Z * r.XY);
            res.Z = (r.A * q.Z) - (xyz * r.YZ) - (q.X * r.ZX) - (v.Y * r.XY);
        }

        public static Rotor3 Conjugate(in Rotor3 r)
        {
            Conjugate(r, out Rotor3 c);
            return c;
        }

        public static void Conjugate(in Rotor3 r, out Rotor3 c)
        {
            c = new Rotor3(r.A, -r.YZ, -r.ZX, -r.XY);
        }

        public static Rotor3 Normalize(in Rotor3 rot)
        {
            Normalize(rot, out Rotor3 res);
            return res;
        }

        public static void Normalize(in Rotor3 rot, out Rotor3 res)
        {
            float l = rot.Length;
            res.A = rot.A / l;
            res.YZ = rot.YZ / l;
            res.ZX = rot.ZX / l;
            res.XY = rot.XY / l;
        }

        public static Matrix3 ToMatrix3(in Rotor3 rot)
        {
            ToMatrix3(rot, out Matrix3 mat);
            return mat;
        }

        public static void ToMatrix3(in Rotor3 rot, out Matrix3 res)
        {
            // TODO: Optimize
            Rotate(rot, Vector3.UnitX, out Vector3 x);
            Rotate(rot, Vector3.UnitY, out Vector3 y);
            Rotate(rot, Vector3.UnitZ, out Vector3 z);
            res = new Matrix3(x.X, y.X, z.X, x.Y, y.Y, z.Y, x.Z, y.Z, z.Z);
        }

        /// <summary>
        /// Geometric product. This will create a rotor with double the angle from a to b.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns>The geometric product.</returns>
        public static Rotor3 Geo(in Vector3 a, in Vector3 b)
        {
            Geo(a, b, out Rotor3 res);
            return res;
        }

        /// <summary>
        /// Geometric product. This will create a rotor with double the angle from a to b.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <param name="res">The result rotor.</param>
        public static void Geo(in Vector3 a, in Vector3 b, out Rotor3 res)
        {
            res = new Rotor3(Vector3.Dot(a, b), (BiVector3d)Vector3.Cross(a, b));
        }

        /// <inheritdoc/>
        public bool Equals(Rotor3 other)
        {
            return A == other.A && BiVector == other.BiVector;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(A, YZ, ZX, XY);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        public override string ToString()
        {
            return $"YZ: {YZ}{ListSeparator} ZX: {ZX}{ListSeparator} XY: {XY}{ListSeparator} A: {A}";
        }

        public static bool operator ==(in Rotor3 a, in Rotor3 b) => a.Equals(b);

        public static bool operator !=(in Rotor3 a, in Rotor3 b) => !a.Equals(b);

        public static Rotor3 operator *(in Rotor3 a, in Rotor3 b)
        {
            Multiply(a, b, out Rotor3 res);
            return res;
        }

        public static Vector3 operator *(in Rotor3 rot, in Vector3 vec)
        {
            Rotate(rot, vec, out Vector3 res);
            return res;
        }
    }
}
