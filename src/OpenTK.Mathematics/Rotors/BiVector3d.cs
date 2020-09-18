using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Mathematics.Rotors
{
    /// <summary>
    /// A three dimentional bivector i.e. a plane at origin.
    /// Could also be thought of as the normal to a plane.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct BiVector3d : IEquatable<BiVector3d>
    {
        public static readonly BiVector3d UnitYZ = new BiVector3d(1, 0, 0);

        public static readonly BiVector3d UnitZX = new BiVector3d(0, 1, 0);

        public static readonly BiVector3d UnitXY = new BiVector3d(0, 0, 1);

        /// <summary>
        /// The not-X basis.
        /// </summary>
        public float NotX;

        /// <summary>
        /// The not-Y basis.
        /// </summary>
        public float NotY;

        /// <summary>
        /// The not-Z basis.
        /// </summary>
        public float NotZ;

        public BiVector3d(Vector3 v)
        {
            NotX = v.X;
            NotY = v.Y;
            NotZ = v.Z;
        }

        public BiVector3d(float nx, float ny, float nz)
        {
            NotX = nx;
            NotY = ny;
            NotZ = nz;
        }

        public BiVector3d(AntiFloat nx, AntiFloat ny, AntiFloat nz)
        {
            NotX = (float)nx;
            NotY = (float)ny;
            NotZ = (float)nz;
        }

        /// <summary>
        /// Gets the square magnitude (length) of this bivector.
        /// </summary>
        public float MagnitudeSquared => (NotX * NotX) + (NotY * NotY) + (NotZ * NotZ);

        /// <summary>
        /// Gets the magnitude (length) of this bivector.
        /// </summary>
        public float Magnitude => (float)Math.Sqrt(MagnitudeSquared);

        /// <summary>
        /// Functionally the same as dot product in more 'conventional' algebra.
        /// </summary>
        /// <param name="bv">Antivector.</param>
        /// <param name="v">Vector.</param>
        /// <returns>An anti-scalar that is the result of the wedge product (dot product in this case) of the two vectors.</returns>
        /// <remarks>Returns a AntiFloat which is a one component vector (i.e a float) that flips sign when reflected.</remarks>
        public static AntiFloat Wedge(BiVector3d bv, Vector3 v)
        {
            return (AntiFloat)((bv.NotX * v.X) + (bv.NotY * v.Y) + (bv.NotZ * v.Z));
        }

        /// <summary>
        /// Functionally the same as dot product in more 'conventional' algebra.
        /// </summary>
        /// <param name="v">Vector.</param>
        /// <param name="bv">Antivector.</param>
        /// <returns>An scalar that is the result of the wedge product (dot product in this case) of the two vectors.</returns>
        /// <remarks>Returns a scalar which is a one component vector (i.e a float) that retains sign on reflection.</remarks>
        public static float AntiWedge(in Vector3 v, in BiVector3d bv)
        {
            return (v.X * bv.NotX) + (v.Y * bv.NotY) + (v.Z * bv.NotZ);
        }

        public static void Normalize(ref BiVector3d bv) => Normalize(bv, out bv);

        public static void Normalize(in BiVector3d bv, out BiVector3d result)
        {
            float mag = bv.Magnitude;
            result.NotX = bv.NotX / mag;
            result.NotY = bv.NotY / mag;
            result.NotZ = bv.NotZ / mag;
        }

        public void Normalize() => Normalize(ref this);

        public BiVector3d Normalized()
        {
            Normalize(this, out BiVector3d bv);
            return bv;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(BiVector3d left, BiVector3d right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BiVector3d left, BiVector3d right)
        {
            return !(left == right);
        }

        public static BiVector3d operator +(BiVector3d left, BiVector3d right)
        {
            BiVector3d res;
            res.NotX = left.NotX + right.NotX;
            res.NotY = left.NotY + right.NotY;
            res.NotZ = left.NotZ + right.NotZ;
            return res;
        }

        public static BiVector3d operator -(BiVector3d left, BiVector3d right)
        {
            BiVector3d res;
            res.NotX = left.NotX - right.NotX;
            res.NotY = left.NotY - right.NotY;
            res.NotZ = left.NotZ - right.NotZ;
            return res;
        }

        public static BiVector3d operator *(BiVector3d left, float scalar)
        {
            BiVector3d res;
            res.NotX = left.NotX * scalar;
            res.NotY = left.NotY * scalar;
            res.NotZ = left.NotZ * scalar;
            return res;
        }

        public static BiVector3d operator *(float scalar, BiVector3d right)
        {
            BiVector3d res;
            res.NotX = right.NotX * scalar;
            res.NotY = right.NotY * scalar;
            res.NotZ = right.NotZ * scalar;
            return res;
        }

        public static Vector3 operator *(BiVector3d left, AntiFloat antiscalar)
        {
            Vector3 res;
            res.X = -left.NotX * antiscalar.Value;
            res.Y = -left.NotY * antiscalar.Value;
            res.Z = -left.NotZ * antiscalar.Value;
            return res;
        }

        public static Vector3 operator *(AntiFloat antiscalar, BiVector3d right)
        {
            Vector3 res;
            res.X = -right.NotX * antiscalar.Value;
            res.Y = -right.NotY * antiscalar.Value;
            res.Z = -right.NotZ * antiscalar.Value;
            return res;
        }

        public static BiVector3d operator /(BiVector3d left, float scalar)
        {
            BiVector3d res;
            res.NotX = left.NotX / scalar;
            res.NotY = left.NotY / scalar;
            res.NotZ = left.NotZ / scalar;
            return res;
        }

        public static BiVector3d operator /(float scalar, BiVector3d right)
        {
            BiVector3d res;
            res.NotX = right.NotX / scalar;
            res.NotY = right.NotY / scalar;
            res.NotZ = right.NotZ / scalar;
            return res;
        }

        public static Vector3 operator /(BiVector3d left, AntiFloat antiscalar)
        {
            Vector3 res;
            res.X = -left.NotX / antiscalar.Value;
            res.Y = -left.NotY / antiscalar.Value;
            res.Z = -left.NotZ / antiscalar.Value;
            return res;
        }

        public static Vector3 operator /(AntiFloat antiscalar, BiVector3d right)
        {
            Vector3 res;
            res.X = -right.NotX / antiscalar.Value;
            res.Y = -right.NotY / antiscalar.Value;
            res.Z = -right.NotZ / antiscalar.Value;
            return res;
        }

        [Pure]
        public static explicit operator BiVector3d(in Vector3 v) => new BiVector3d(v.X, v.Y, v.Z);

        [Pure]
        public static explicit operator Vector3(in BiVector3d bv) => new Vector3(bv.NotX, bv.NotY, bv.NotZ);

        public override bool Equals(object obj)
        {
            return obj is BiVector3d d && Equals(d);
        }

        public bool Equals(BiVector3d other)
        {
            return NotX == other.NotX &&
                   NotY == other.NotY &&
                   NotZ == other.NotZ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NotX, NotY, NotZ);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
