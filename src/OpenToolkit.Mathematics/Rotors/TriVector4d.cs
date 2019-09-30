using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Mathematics.Rotors
{
    /// <summary>
    /// A four dimentional anti-vector i.e a plane.
    /// </summary>
    /// <remarks>Should maybe be called AntiVector4d.</remarks>
    public struct AntiVector4d
    {
        public float NotX;
        public float NotY;
        public float NotZ;
        public float NotW;

        /// <summary>
        /// 
        /// </summary>
        public AntiVector4d()
        {
            NotX = NotY = NotZ = NotW;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notX"></param>
        /// <param name="notY"></param>
        /// <param name="notZ"></param>
        /// <param name="notW"></param>
        public AntiVector4d(float notX, float notY, float notZ, float notW)
        {
            NotX = notX;
            NotY = notY;
            NotZ = notZ;
            NotW = notW;
        }
    }
}
