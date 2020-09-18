using System;

namespace OpenTK.Mathematics.Rotors
{
    /// <summary>
    /// A four dimentional bi-vector i.e. a line.
    /// </summary>
    public struct BiVector4
    {
        public float XY;
        public float YZ;
        public float ZX;
        public float WX;
        public float WY;
        public float WZ;

        public BiVector4(float xy, float yz, float zx, float wx, float wy, float wz)
        {
            XY = xy;
            YZ = yz;
            ZX = zx;
            WX = wx;
            WY = wy;
            WZ = wz;
        }

        public Vector3 Tangent => new Vector3(WX, WY, WZ);

        public BiVector3d Moment => new BiVector3d(XY, YZ, ZX);

        public float MagnitudeSqr => (XY * XY) + (YZ * YZ) + (ZX * ZX) + (WX * WX) + (WY * WY) + (WZ * WZ);

        public float Magnitude => (float)Math.Sqrt(Magnitude);

        /// <summary>
        /// Creates a AntiVector4 (plane) from a BiVector4 (line) and a Vector4 (point).
        /// Assuming there is no linear dependancy between the line and the point.
        /// </summary>
        /// <param name="bv">The BiVector4 (line).</param>
        /// <param name="v">The Vector4 (point).</param>
        /// <param name="tv">The result AntiVector4 (plane).</param>
        public static void Wedge(in BiVector4 bv, in Vector4 v, out AntiVector4 tv)
        {
            tv.NotX = (bv.WY * v.Z) + (bv.YZ * v.W) - (bv.WZ * v.Y);
            tv.NotY = (bv.ZX * v.W) + (bv.WZ * v.X) - (bv.WX * v.Z);
            tv.NotZ = (bv.XY * v.W) + (bv.WX * v.Y) - (bv.WY * v.X);

            // Note the dubble minus
            tv.NotW = (bv.YZ * v.X) - (bv.XY * v.Z) - (bv.ZX * v.Y);
        }

        public static void AntiWedge(in BiVector4 bv1, in BiVector4 bv2, out float f)
        {
            float a = BiVector3d.AntiWedge(bv1.Tangent, bv2.Moment);
            float b = BiVector3d.AntiWedge(bv2.Tangent, bv1.Moment);
            f = a + b;
        }

        /// <summary>
        /// Calcualtes the signed minimum distance between two lines.
        /// </summary>
        /// <param name="bv1">The fist line.</param>
        /// <param name="bv2">The second line.</param>
        /// <returns>The signed distance between the lines.</returns>
        public static float SignedMinDist(in BiVector4 bv1, in BiVector4 bv2)
        {
            // TODO: Optimize
            AntiWedge(bv1, bv2, out float signedCrossingValue);
            Vector3.Wedge(bv1.Tangent, bv2.Tangent, out BiVector3d bi);
            return signedCrossingValue / bi.Magnitude;
        }

        /// <summary>
        /// Normalizes a BiVector4 so that the norm one.
        /// This does not normalize the "weight" of the represented line.
        /// </summary>
        /// <param name="bv">The BiVector to normalize.</param>
        public static void Normalize(ref BiVector4 bv) => Normalize(bv, out bv);

        public static void Normalize(in BiVector4 bv, out BiVector4 result)
        {
            float mag = bv.Magnitude;
            result.XY = bv.XY / mag;
            result.YZ = bv.YZ / mag;
            result.ZX = bv.ZX / mag;
            result.WX = bv.WX / mag;
            result.WY = bv.WY / mag;
            result.WZ = bv.WZ / mag;
        }

        /// <summary>
        /// Normalizes the tangent direction for this line while keeping it's position in space the same.
        /// </summary>
        /// <param name="bv">The BiVector4 to normalize the weight of.</param>
        public static void NormalizeWeight(ref BiVector4 bv) => NormalizeWeight(bv, out bv);

        /// <summary>
        /// Normalizes the tangent direction for this line while keeping it's position in space the same.
        /// </summary>
        /// <param name="bv">The BiVector4 to normalize the weight of.</param>
        /// <param name="result"'>The resulting BiVector4.</param>
        public static void NormalizeWeight(in BiVector4 bv, out BiVector4 result)
        {
            float mag = (float)Math.Sqrt((bv.WX * bv.WX) + (bv.WY * bv.WY) + (bv.WZ * bv.WZ));
            result.WX = bv.WX / mag;
            result.WY = bv.WY / mag;
            result.WZ = bv.WZ / mag;

            // TODO: Make sure this is correct
            result.XY = bv.XY * mag;
            result.YZ = bv.YZ * mag;
            result.ZX = bv.ZX * mag;
        }
    }
}
