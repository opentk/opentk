using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents a color with 4 floating-point components (R, G, B, A).
    /// </summary>
    public struct Color4 : IEquatable<Color4>
    {
        #region Fields

        /// <summary>
        /// The red component of this Color4 structure.
        /// </summary>
        public readonly float R;
        
        /// <summary>
        /// The green component of this Color4 structure.
        /// </summary>
        public readonly float G;
        
        /// <summary>
        /// The blue component of this Color4 structure.
        /// </summary>
        public readonly float B;
        
        /// <summary>
        /// The alpha component of this Color4 structure.
        /// </summary>
        public readonly float A;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Color4 structure from the specified components.
        /// </summary>
        /// <param name="r">The red component of the new Color4 structure.</param>
        /// <param name="g">The green component of the new Color4 structure.</param>
        /// <param name="b">The blue component of the new Color4 structure.</param>
        /// <param name="a">The alpha component of the new Color4 structure.</param>
        public Color4(float r, float g, float b, float a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        /// <summary>
        /// Constructs a new Color4 structure from the specified System.Drawing.Color.
        /// </summary>
        /// <param name="color">The System.Drawing.Color containing the component values.</param>
        public Color4(Color color)
        {
            R = color.R / (float)Byte.MaxValue;
            G = color.G / (float)Byte.MaxValue;
            B = color.B / (float)Byte.MaxValue;
            A = color.A / (float)Byte.MaxValue;
        }

        #endregion

        #region Conversions

        /// <summary>
        /// Converts the specified System.Drawing.Color to a Color4 structure.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to convert.</param>
        /// <returns>A new Color4 structure containing the converted components.</returns>
        public static implicit operator Color4(Color color)
        {
            return new Color4(color);
        }

        /// <summary>
        /// Converts the specified Color4 to a System.Drawing.Color structure.
        /// </summary>
        /// <param name="color">The Color4 to convert.</param>
        /// <returns>A new System.Drawing.Color structure containing the converted components.</returns>
        public static explicit operator Color(Color4 color)
        {
            return Color.FromArgb(
                (int)(color.A * Byte.MaxValue),
                (int)(color.R * Byte.MaxValue),
                (int)(color.G * Byte.MaxValue),
                (int)(color.B * Byte.MaxValue));
        }

        #endregion

        #region IEquatable<Color4> Members

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified Color4.
        /// </summary>
        /// <param name="other">The Color4 structure to compare to.</param>
        /// <returns>True if both Color4 structures contain the same components; false otherwise.</returns>
        public bool Equals(Color4 other)
        {
            return
                this.R == other.R &&
                this.G == other.G &&
                this.B == other.B &&
                this.A == other.A;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified object.
        /// </summary>
        /// <param name="obj">An object to compare to.</param>
        /// <returns>True obj is a Color4 structure with the same components as this Color4; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Color4))
                return false;

            return Equals((Color4)obj);
        }

        /// <summary>
        /// Calculates the hash code for this Color4 structure.
        /// </summary>
        /// <returns>A System.Int32 containing the hashcode of this Color4 structure.</returns>
        public override int GetHashCode()
        {
            return ((Color)this).GetHashCode();
        }

        /// <summary>
        /// Creates a System.String that describes this Color4 structure.
        /// </summary>
        /// <returns>A System.String that describes this Color4 structure.</returns>
        public override string ToString()
        {
            return String.Format("{{R, G, B, A = {0}, {1}, {2}, {3}}}", R.ToString(), G.ToString(), B.ToString(), A.ToString());
        }

        #endregion
    }
}
