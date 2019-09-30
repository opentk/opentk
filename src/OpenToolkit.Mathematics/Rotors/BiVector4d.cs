using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Mathematics.Rotors
{
    /// <summary>
    /// A four dimentional bi-vector i.e. a line.
    /// </summary>
    public struct BiVector4d
    {
        public float XY;
        public float YZ;
        public float ZX;
        public float WX;
        public float WY;
        public float WZ;

        public BiVector4d()
        {
            XY = YZ = ZX = WX = WY = WZ;
        }

        public BiVector4d(float xy, float yz, float zx, float wx, float wy, float wz)
        {
            XY = xy;
            YZ = yz;
            ZX = zx;
            WX = wx;
            WY = wy;
            WZ = wz;
        }

        /// <summary>
        /// 
        /// </summary>
        public Vector3 Tangent => new Vector3(WX, WY, WZ);

        /// <summary>
        /// 
        /// </summary>
        public Vector3 Moment => new Vector3(XY, YZ, ZX);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bv"></param>
        /// <param name="v"></param>
        /// <param name="tv"></param>
        public static Wedge(in BiVector4d bv, in Vector4 v, out AntiVector4d tv)
        {
            // FIXME: Implement this!!
            tv = default;
            throw new NotImplementedException();
        }
    }
}
