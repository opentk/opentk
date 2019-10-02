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
            NotX = NotY = NotZ = NotW = 0;
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

        public float MagnitudeSqr => (NotX * NotX) + (NotY * NotY) + (NotZ * NotZ) + (NotW + NotW);

        public float Magnitude => (float)Math.Sqrt(Magnitude);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="av"></param>
        public static void Normalize(ref AntiVector4d av)
        {
            Normalize(av, out av);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="av"></param>
        /// <param name="result"></param>
        public static void Normalize(in AntiVector4d av, out AntiVector4d result)
        {
            float mag = av.Magnitude;
            result.NotX = av.NotX / mag;
            result.NotX = av.NotY / mag;
            result.NotX = av.NotZ / mag;
            result.NotX = av.NotW / mag;
        }

        /// <summary>
        /// Keep the plane in it's current position and orientation,
        /// but normalize the orientation so that the NotW represents the distance the plane is from the origin.
        /// </summary>
        /// <param name="av"></param>
        public static void NormalizeWeight(ref AntiVector4d av) => NormalizeWeight(av, out av);

        /// <summary>
        /// Keep the plane in it's current position and orientation,
        /// but normalize the orientation so that the NotW represents the distance the plane is from the origin.
        /// </summary>
        /// <param name="av"></param>
        /// <param name="result"></param>
        public static void NormalizeWeight(in AntiVector4d av, out AntiVector4d result)
        {
            float mag = (float)Math.Sqrt((av.NotX * av.NotX) + (av.NotY * av.NotY) + (av.NotZ * av.NotZ));
            result.NotX = av.NotX / mag;
            result.NotY = av.NotY / mag;
            result.NotZ = av.NotZ / mag;
            result.NotW = av.NotW * mag;
        }
    }
}
