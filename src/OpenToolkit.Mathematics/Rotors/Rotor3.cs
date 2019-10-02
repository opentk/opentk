using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Mathematics.Rotors
{
    public struct Rotor3
    {
        // FIXME: Better name!
        public float A;

        public float YZ;
        public float ZX;
        public float XY;

        /// <summary>
        /// 
        /// </summary>
        public Rotor3()
        {
            A = YZ = ZX = XY = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="yz"></param>
        /// <param name="zx"></param>
        /// <param name="xy"></param>
        public Rotor3(float a, float yz, float zx, float xy)
        {
            A = a;
            YZ = yz;
            ZX = zx;
            XY = xy;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bv"></param>
        public Rotor3(float a, in BiVector3d bv)
        {
            A = a;
            YZ = bv.NotX;
            ZX = bv.NotY;
            XY = bv.NotZ;
        }


    }
}
