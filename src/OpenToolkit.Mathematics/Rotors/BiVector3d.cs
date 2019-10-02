using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Mathematics.Rotors
{
    // This will not ensure type safety :'(
    using AntiScalar3d = float;

    /// <summary>
    /// 
    /// </summary>
    public struct BiVector3d
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly BiVector3d UnitYZ = new BiVector3d(1, 0, 0);

        /// <summary>
        /// 
        /// </summary>
        public static readonly BiVector3d UnitZX = new BiVector3d(0, 1, 0);

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public BiVector3d()
        {
            NotX = NotY = NotZ = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nx"></param>
        /// <param name="ny"></param>
        /// <param name="nz"></param>
        public BiVector3d(float nx, float ny, float nz)
        {
            NotX = nx;
            NotY = ny;
            NotZ = nz;
        }

        /// <summary>
        /// 
        /// </summary>
        public float MagnitudeSquared => (NotX * NotX) + (NotY * NotY) + (NotZ * NotZ);

        /// <summary>
        /// 
        /// </summary>
        public float Magnitude => (float)Math.Sqrt(MagnitudeSquared);

        /// <summary>
        /// Functionally the same as dot product in more 'conventional' algebra.
        /// </summary>
        /// <param name="bv"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        /// <remarks>Returns a AntiScalar3D which is a one component vector (i.e a float) that flips sign when reflected.</remarks>
        public static AntiScalar3d Wedge(BiVector3d bv, Vector3 v)
        {
            return (bv.NotX * v.X) + (bv.NotY * v.Y) + (bv.NotZ * v.Z);
        }

        /// <summary>
        /// Functionally the same as dot product in more 'conventional' algebra.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="bv"></param>
        /// <returns></returns>
        /// <remarks>Returns a scalar which is a one component vector (i.e a float) that retains sign on reflection.</remarks>
        public static float AntiWedge(in Vector3 v, in BiVector3d bv)
        {
            return (v.X * bv.NotX) + (v.Y * bv.NotY) + (v.Z * bv.NotZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bv"></param>
        public static void Normalize(ref BiVector3d bv) => Normalize(bv, out bv);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bv"></param>
        /// <param name="result"></param>
        public static void Normalize(in BiVector3d bv, out BiVector3d result)
        {
            float mag = bv.Magnitude;
            result.NotX = bv.NotX / mag;
            result.NotY = bv.NotY / mag;
            result.NotZ = bv.NotZ / mag;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Normalize() => Normalize(ref this);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public BiVector3d Normalized()
        {
            Normalize(this, out BiVector3d bv);
            return bv;
        }
    }
}
