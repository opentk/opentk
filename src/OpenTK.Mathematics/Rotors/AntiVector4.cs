using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Mathematics.Rotors
{
    /// <summary>
    /// A four dimentional anti-vector i.e a plane.
    /// </summary>
    public struct AntiVector4
    {
        public float NotX;
        public float NotY;
        public float NotZ;
        public float NotW;

        public AntiVector4(float notX, float notY, float notZ, float notW)
        {
            NotX = notX;
            NotY = notY;
            NotZ = notZ;
            NotW = notW;
        }

        public float MagnitudeSqr => (NotX * NotX) + (NotY * NotY) + (NotZ * NotZ) + (NotW + NotW);

        public float Magnitude => (float)Math.Sqrt(Magnitude);

        public static void Normalize(ref AntiVector4 av)
        {
            Normalize(av, out av);
        }

        public static void Normalize(in AntiVector4 av, out AntiVector4 result)
        {
            float mag = av.Magnitude;
            result.NotX = av.NotX / mag;
            result.NotY = av.NotY / mag;
            result.NotZ = av.NotZ / mag;
            result.NotW = av.NotW / mag;
        }

        /// <summary>
        /// Keep the plane in it's current position and orientation,
        /// but normalize the orientation so that the NotW represents the distance the plane is from the origin.
        /// </summary>
        /// <param name="av">The antivector to normalize the weight of.</param>
        public static void NormalizeWeight(ref AntiVector4 av) => NormalizeWeight(av, out av);

        /// <summary>
        /// Keep the plane in it's current position and orientation,
        /// but normalize the orientation so that the NotW represents the distance the plane is from the origin.
        /// </summary>
        /// <param name="av">The antivector to normalize the weight of.</param>
        /// <param name="result">The normalized antivector.</param>
        public static void NormalizeWeight(in AntiVector4 av, out AntiVector4 result)
        {
            float mag = (float)Math.Sqrt((av.NotX * av.NotX) + (av.NotY * av.NotY) + (av.NotZ * av.NotZ));
            result.NotX = av.NotX / mag;
            result.NotY = av.NotY / mag;
            result.NotZ = av.NotZ / mag;
            result.NotW = av.NotW * mag;
        }
    }
}
