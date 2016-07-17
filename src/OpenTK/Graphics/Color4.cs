#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;
using System.Xml.Serialization;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents a color with 4 floating-point components (R, G, B, A).
    /// </summary>
    [Serializable]
    public struct Color4 : IEquatable<Color4>
    {
        #region Fields

        /// <summary>
        /// The red component of this Color4 structure.
        /// </summary>
        public float R;
        
        /// <summary>
        /// The green component of this Color4 structure.
        /// </summary>
        public float G;
        
        /// <summary>
        /// The blue component of this Color4 structure.
        /// </summary>
        public float B;
        
        /// <summary>
        /// The alpha component of this Color4 structure.
        /// </summary>
        public float A;

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
        /// Constructs a new Color4 structure from the specified components.
        /// </summary>
        /// <param name="r">The red component of the new Color4 structure.</param>
        /// <param name="g">The green component of the new Color4 structure.</param>
        /// <param name="b">The blue component of the new Color4 structure.</param>
        /// <param name="a">The alpha component of the new Color4 structure.</param>
        public Color4(byte r, byte g, byte b, byte a)
        {
            R = r / (float)Byte.MaxValue;
            G = g / (float)Byte.MaxValue;
            B = b / (float)Byte.MaxValue;
            A = a / (float)Byte.MaxValue;
        }

        /// <summary>
        /// Constructs a new Color4 structure from the specified System.Drawing.Color.
        /// </summary>
        /// <param name="color">The System.Drawing.Color containing the component values.</param>
        [Obsolete("Use new Color4(r, g, b, a) instead.")]
        public Color4(Color color)
            : this(color.R, color.G, color.B, color.A)
        { }

        #endregion

        #region Public Members

        /// <summary>
        /// Converts this color to an integer representation with 8 bits per channel.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents this instance.</returns>
        /// <remarks>This method is intended only for compatibility with System.Drawing. It compresses the color into 8 bits per channel, which means color information is lost.</remarks>
        public int ToArgb()
        {
            uint value =
                (uint)(A * Byte.MaxValue) << 24 |
                (uint)(R * Byte.MaxValue) << 16 |
                (uint)(G * Byte.MaxValue) << 8 |
                (uint)(B * Byte.MaxValue);

            return unchecked((int)value);
        }

        /// <summary>
        /// Compares the specified Color4 structures for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        public static bool operator ==(Color4 left, Color4 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified Color4 structures for inequality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(Color4 left, Color4 right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts the specified System.Drawing.Color to a Color4 structure.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to convert.</param>
        /// <returns>A new Color4 structure containing the converted components.</returns>
        public static implicit operator Color4(Color color)
        {
            return new Color4(color.R, color.G, color.B, color.A);
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
            return ToArgb();
        }

        /// <summary>
        /// Creates a System.String that describes this Color4 structure.
        /// </summary>
        /// <returns>A System.String that describes this Color4 structure.</returns>
        public override string ToString()
        {
            return String.Format("{{(R, G, B, A) = ({0}, {1}, {2}, {3})}}", R.ToString(), G.ToString(), B.ToString(), A.ToString());
        }

        #region System colors

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 0).
        /// </summary>
        public static Color4 Transparent { get { return new Color4(255, 255, 255, 0); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 248, 255, 255).
        /// </summary>
        public static Color4 AliceBlue { get { return new Color4(240, 248, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 235, 215, 255).
        /// </summary>
        public static Color4 AntiqueWhite { get { return new Color4(250, 235, 215, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static Color4 Aqua { get { return new Color4(0, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 212, 255).
        /// </summary>
        public static Color4 Aquamarine { get { return new Color4(127, 255, 212, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 255, 255).
        /// </summary>
        public static Color4 Azure { get { return new Color4(240, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 220, 255).
        /// </summary>
        public static Color4 Beige { get { return new Color4(245, 245, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 196, 255).
        /// </summary>
        public static Color4 Bisque { get { return new Color4(255, 228, 196, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 0, 255).
        /// </summary>
        public static Color4 Black { get { return new Color4(0, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 235, 205, 255).
        /// </summary>
        public static Color4 BlanchedAlmond { get { return new Color4(255, 235, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 255, 255).
        /// </summary>
        public static Color4 Blue { get { return new Color4(0, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (138, 43, 226, 255).
        /// </summary>
        public static Color4 BlueViolet { get { return new Color4(138, 43, 226, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (165, 42, 42, 255).
        /// </summary>
        public static Color4 Brown { get { return new Color4(165, 42, 42, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (222, 184, 135, 255).
        /// </summary>
        public static Color4 BurlyWood { get { return new Color4(222, 184, 135, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (95, 158, 160, 255).
        /// </summary>
        public static Color4 CadetBlue { get { return new Color4(95, 158, 160, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 0, 255).
        /// </summary>
        public static Color4 Chartreuse { get { return new Color4(127, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 105, 30, 255).
        /// </summary>
        public static Color4 Chocolate { get { return new Color4(210, 105, 30, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 127, 80, 255).
        /// </summary>
        public static Color4 Coral { get { return new Color4(255, 127, 80, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (100, 149, 237, 255).
        /// </summary>
        public static Color4 CornflowerBlue { get { return new Color4(100, 149, 237, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 248, 220, 255).
        /// </summary>
        public static Color4 Cornsilk { get { return new Color4(255, 248, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 20, 60, 255).
        /// </summary>
        public static Color4 Crimson { get { return new Color4(220, 20, 60, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static Color4 Cyan { get { return new Color4(0, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 139, 255).
        /// </summary>
        public static Color4 DarkBlue { get { return new Color4(0, 0, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 139, 139, 255).
        /// </summary>
        public static Color4 DarkCyan { get { return new Color4(0, 139, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (184, 134, 11, 255).
        /// </summary>
        public static Color4 DarkGoldenrod { get { return new Color4(184, 134, 11, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (169, 169, 169, 255).
        /// </summary>
        public static Color4 DarkGray { get { return new Color4(169, 169, 169, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 100, 0, 255).
        /// </summary>
        public static Color4 DarkGreen { get { return new Color4(0, 100, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (189, 183, 107, 255).
        /// </summary>
        public static Color4 DarkKhaki { get { return new Color4(189, 183, 107, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 139, 255).
        /// </summary>
        public static Color4 DarkMagenta { get { return new Color4(139, 0, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (85, 107, 47, 255).
        /// </summary>
        public static Color4 DarkOliveGreen { get { return new Color4(85, 107, 47, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 140, 0, 255).
        /// </summary>
        public static Color4 DarkOrange { get { return new Color4(255, 140, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (153, 50, 204, 255).
        /// </summary>
        public static Color4 DarkOrchid { get { return new Color4(153, 50, 204, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 0, 255).
        /// </summary>
        public static Color4 DarkRed { get { return new Color4(139, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (233, 150, 122, 255).
        /// </summary>
        public static Color4 DarkSalmon { get { return new Color4(233, 150, 122, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (143, 188, 139, 255).
        /// </summary>
        public static Color4 DarkSeaGreen { get { return new Color4(143, 188, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 61, 139, 255).
        /// </summary>
        public static Color4 DarkSlateBlue { get { return new Color4(72, 61, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (47, 79, 79, 255).
        /// </summary>
        public static Color4 DarkSlateGray { get { return new Color4(47, 79, 79, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 206, 209, 255).
        /// </summary>
        public static Color4 DarkTurquoise { get { return new Color4(0, 206, 209, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (148, 0, 211, 255).
        /// </summary>
        public static Color4 DarkViolet { get { return new Color4(148, 0, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 20, 147, 255).
        /// </summary>
        public static Color4 DeepPink { get { return new Color4(255, 20, 147, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 191, 255, 255).
        /// </summary>
        public static Color4 DeepSkyBlue { get { return new Color4(0, 191, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (105, 105, 105, 255).
        /// </summary>
        public static Color4 DimGray { get { return new Color4(105, 105, 105, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (30, 144, 255, 255).
        /// </summary>
        public static Color4 DodgerBlue { get { return new Color4(30, 144, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (178, 34, 34, 255).
        /// </summary>
        public static Color4 Firebrick { get { return new Color4(178, 34, 34, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 240, 255).
        /// </summary>
        public static Color4 FloralWhite { get { return new Color4(255, 250, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (34, 139, 34, 255).
        /// </summary>
        public static Color4 ForestGreen { get { return new Color4(34, 139, 34, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static Color4 Fuchsia { get { return new Color4(255, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 220, 220, 255).
        /// </summary>
        public static Color4 Gainsboro { get { return new Color4(220, 220, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (248, 248, 255, 255).
        /// </summary>
        public static Color4 GhostWhite { get { return new Color4(248, 248, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 215, 0, 255).
        /// </summary>
        public static Color4 Gold { get { return new Color4(255, 215, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 165, 32, 255).
        /// </summary>
        public static Color4 Goldenrod { get { return new Color4(218, 165, 32, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 128, 255).
        /// </summary>
        public static Color4 Gray { get { return new Color4(128, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 0, 255).
        /// </summary>
        public static Color4 Green { get { return new Color4(0, 128, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 255, 47, 255).
        /// </summary>
        public static Color4 GreenYellow { get { return new Color4(173, 255, 47, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 240, 255).
        /// </summary>
        public static Color4 Honeydew { get { return new Color4(240, 255, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 105, 180, 255).
        /// </summary>
        public static Color4 HotPink { get { return new Color4(255, 105, 180, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 92, 92, 255).
        /// </summary>
        public static Color4 IndianRed { get { return new Color4(205, 92, 92, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (75, 0, 130, 255).
        /// </summary>
        public static Color4 Indigo { get { return new Color4(75, 0, 130, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 240, 255).
        /// </summary>
        public static Color4 Ivory { get { return new Color4(255, 255, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 230, 140, 255).
        /// </summary>
        public static Color4 Khaki { get { return new Color4(240, 230, 140, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (230, 230, 250, 255).
        /// </summary>
        public static Color4 Lavender { get { return new Color4(230, 230, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 240, 245, 255).
        /// </summary>
        public static Color4 LavenderBlush { get { return new Color4(255, 240, 245, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (124, 252, 0, 255).
        /// </summary>
        public static Color4 LawnGreen { get { return new Color4(124, 252, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 205, 255).
        /// </summary>
        public static Color4 LemonChiffon { get { return new Color4(255, 250, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 216, 230, 255).
        /// </summary>
        public static Color4 LightBlue { get { return new Color4(173, 216, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 128, 128, 255).
        /// </summary>
        public static Color4 LightCoral { get { return new Color4(240, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (224, 255, 255, 255).
        /// </summary>
        public static Color4 LightCyan { get { return new Color4(224, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 250, 210, 255).
        /// </summary>
        public static Color4 LightGoldenrodYellow { get { return new Color4(250, 250, 210, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (144, 238, 144, 255).
        /// </summary>
        public static Color4 LightGreen { get { return new Color4(144, 238, 144, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (211, 211, 211, 255).
        /// </summary>
        public static Color4 LightGray { get { return new Color4(211, 211, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 182, 193, 255).
        /// </summary>
        public static Color4 LightPink { get { return new Color4(255, 182, 193, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 160, 122, 255).
        /// </summary>
        public static Color4 LightSalmon { get { return new Color4(255, 160, 122, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (32, 178, 170, 255).
        /// </summary>
        public static Color4 LightSeaGreen { get { return new Color4(32, 178, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 250, 255).
        /// </summary>
        public static Color4 LightSkyBlue { get { return new Color4(135, 206, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (119, 136, 153, 255).
        /// </summary>
        public static Color4 LightSlateGray { get { return new Color4(119, 136, 153, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 196, 222, 255).
        /// </summary>
        public static Color4 LightSteelBlue { get { return new Color4(176, 196, 222, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 224, 255).
        /// </summary>
        public static Color4 LightYellow { get { return new Color4(255, 255, 224, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 0, 255).
        /// </summary>
        public static Color4 Lime { get { return new Color4(0, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (50, 205, 50, 255).
        /// </summary>
        public static Color4 LimeGreen { get { return new Color4(50, 205, 50, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 240, 230, 255).
        /// </summary>
        public static Color4 Linen { get { return new Color4(250, 240, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static Color4 Magenta { get { return new Color4(255, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 0, 255).
        /// </summary>
        public static Color4 Maroon { get { return new Color4(128, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (102, 205, 170, 255).
        /// </summary>
        public static Color4 MediumAquamarine { get { return new Color4(102, 205, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 205, 255).
        /// </summary>
        public static Color4 MediumBlue { get { return new Color4(0, 0, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (186, 85, 211, 255).
        /// </summary>
        public static Color4 MediumOrchid { get { return new Color4(186, 85, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (147, 112, 219, 255).
        /// </summary>
        public static Color4 MediumPurple { get { return new Color4(147, 112, 219, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (60, 179, 113, 255).
        /// </summary>
        public static Color4 MediumSeaGreen { get { return new Color4(60, 179, 113, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (123, 104, 238, 255).
        /// </summary>
        public static Color4 MediumSlateBlue { get { return new Color4(123, 104, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 250, 154, 255).
        /// </summary>
        public static Color4 MediumSpringGreen { get { return new Color4(0, 250, 154, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 209, 204, 255).
        /// </summary>
        public static Color4 MediumTurquoise { get { return new Color4(72, 209, 204, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (199, 21, 133, 255).
        /// </summary>
        public static Color4 MediumVioletRed { get { return new Color4(199, 21, 133, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (25, 25, 112, 255).
        /// </summary>
        public static Color4 MidnightBlue { get { return new Color4(25, 25, 112, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 255, 250, 255).
        /// </summary>
        public static Color4 MintCream { get { return new Color4(245, 255, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 225, 255).
        /// </summary>
        public static Color4 MistyRose { get { return new Color4(255, 228, 225, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 181, 255).
        /// </summary>
        public static Color4 Moccasin { get { return new Color4(255, 228, 181, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 222, 173, 255).
        /// </summary>
        public static Color4 NavajoWhite { get { return new Color4(255, 222, 173, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 128, 255).
        /// </summary>
        public static Color4 Navy { get { return new Color4(0, 0, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (253, 245, 230, 255).
        /// </summary>
        public static Color4 OldLace { get { return new Color4(253, 245, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 0, 255).
        /// </summary>
        public static Color4 Olive { get { return new Color4(128, 128, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (107, 142, 35, 255).
        /// </summary>
        public static Color4 OliveDrab { get { return new Color4(107, 142, 35, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 165, 0, 255).
        /// </summary>
        public static Color4 Orange { get { return new Color4(255, 165, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 69, 0, 255).
        /// </summary>
        public static Color4 OrangeRed { get { return new Color4(255, 69, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 112, 214, 255).
        /// </summary>
        public static Color4 Orchid { get { return new Color4(218, 112, 214, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 232, 170, 255).
        /// </summary>
        public static Color4 PaleGoldenrod { get { return new Color4(238, 232, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (152, 251, 152, 255).
        /// </summary>
        public static Color4 PaleGreen { get { return new Color4(152, 251, 152, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (175, 238, 238, 255).
        /// </summary>
        public static Color4 PaleTurquoise { get { return new Color4(175, 238, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (219, 112, 147, 255).
        /// </summary>
        public static Color4 PaleVioletRed { get { return new Color4(219, 112, 147, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 239, 213, 255).
        /// </summary>
        public static Color4 PapayaWhip { get { return new Color4(255, 239, 213, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 218, 185, 255).
        /// </summary>
        public static Color4 PeachPuff { get { return new Color4(255, 218, 185, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 133, 63, 255).
        /// </summary>
        public static Color4 Peru { get { return new Color4(205, 133, 63, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 192, 203, 255).
        /// </summary>
        public static Color4 Pink { get { return new Color4(255, 192, 203, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (221, 160, 221, 255).
        /// </summary>
        public static Color4 Plum { get { return new Color4(221, 160, 221, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 224, 230, 255).
        /// </summary>
        public static Color4 PowderBlue { get { return new Color4(176, 224, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 128, 255).
        /// </summary>
        public static Color4 Purple { get { return new Color4(128, 0, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 0, 255).
        /// </summary>
        public static Color4 Red { get { return new Color4(255, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (188, 143, 143, 255).
        /// </summary>
        public static Color4 RosyBrown { get { return new Color4(188, 143, 143, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (65, 105, 225, 255).
        /// </summary>
        public static Color4 RoyalBlue { get { return new Color4(65, 105, 225, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 69, 19, 255).
        /// </summary>
        public static Color4 SaddleBrown { get { return new Color4(139, 69, 19, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 128, 114, 255).
        /// </summary>
        public static Color4 Salmon { get { return new Color4(250, 128, 114, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (244, 164, 96, 255).
        /// </summary>
        public static Color4 SandyBrown { get { return new Color4(244, 164, 96, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (46, 139, 87, 255).
        /// </summary>
        public static Color4 SeaGreen { get { return new Color4(46, 139, 87, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 245, 238, 255).
        /// </summary>
        public static Color4 SeaShell { get { return new Color4(255, 245, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (160, 82, 45, 255).
        /// </summary>
        public static Color4 Sienna { get { return new Color4(160, 82, 45, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (192, 192, 192, 255).
        /// </summary>
        public static Color4 Silver { get { return new Color4(192, 192, 192, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 235, 255).
        /// </summary>
        public static Color4 SkyBlue { get { return new Color4(135, 206, 235, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (106, 90, 205, 255).
        /// </summary>
        public static Color4 SlateBlue { get { return new Color4(106, 90, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (112, 128, 144, 255).
        /// </summary>
        public static Color4 SlateGray { get { return new Color4(112, 128, 144, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 250, 255).
        /// </summary>
        public static Color4 Snow { get { return new Color4(255, 250, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 127, 255).
        /// </summary>
        public static Color4 SpringGreen { get { return new Color4(0, 255, 127, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (70, 130, 180, 255).
        /// </summary>
        public static Color4 SteelBlue { get { return new Color4(70, 130, 180, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 180, 140, 255).
        /// </summary>
        public static Color4 Tan { get { return new Color4(210, 180, 140, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 128, 255).
        /// </summary>
        public static Color4 Teal { get { return new Color4(0, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (216, 191, 216, 255).
        /// </summary>
        public static Color4 Thistle { get { return new Color4(216, 191, 216, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 99, 71, 255).
        /// </summary>
        public static Color4 Tomato { get { return new Color4(255, 99, 71, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (64, 224, 208, 255).
        /// </summary>
        public static Color4 Turquoise { get { return new Color4(64, 224, 208, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 130, 238, 255).
        /// </summary>
        public static Color4 Violet { get { return new Color4(238, 130, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 222, 179, 255).
        /// </summary>
        public static Color4 Wheat { get { return new Color4(245, 222, 179, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 255).
        /// </summary>
        public static Color4 White { get { return new Color4(255, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 245, 255).
        /// </summary>
        public static Color4 WhiteSmoke { get { return new Color4(245, 245, 245, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 0, 255).
        /// </summary>
        public static Color4 Yellow { get { return new Color4(255, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (154, 205, 50, 255).
        /// </summary>
        public static Color4 YellowGreen { get { return new Color4(154, 205, 50, 255); } }

        #endregion

        #endregion

        #region Color conversions

        #region sRGB

        /// <summary>
        /// Converts sRGB color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="srgb">
        /// Color value to convert in sRGB.
        /// </param>
        public static Color4 FromSrgb(Color4 srgb)
        {
            float r, g, b;

            if (srgb.R <= 0.04045f)
            {
                r = srgb.R / 12.92f;
            }
            else
            {
                r = (float)Math.Pow((srgb.R + 0.055f) / (1.0f + 0.055f), 2.4f);
            }

            if (srgb.G <= 0.04045f)
            {
                g = srgb.G / 12.92f;
            }
            else
            {
                g = (float)Math.Pow((srgb.G + 0.055f) / (1.0f + 0.055f), 2.4f);
            }

            if (srgb.B <= 0.04045f)
            {
                b = srgb.B / 12.92f;
            }
            else
            {
                b = (float)Math.Pow((srgb.B + 0.055f) / (1.0f + 0.055f), 2.4f);
            }

            return new Color4(r, g, b, srgb.A);
        }

        /// <summary>
        /// Converts RGB color values to sRGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        public static Color4 ToSrgb(Color4 rgb)
        {
            float r, g, b;

            if (rgb.R <= 0.0031308)
            {
                r = 12.92f * rgb.R;
            }
            else
            {
                r = (1.0f + 0.055f) * (float)Math.Pow(rgb.R, 1.0f / 2.4f) - 0.055f;
            }

            if (rgb.G <= 0.0031308)
            {
                g = 12.92f * rgb.G;
            }
            else
            {
                g = (1.0f + 0.055f) * (float)Math.Pow(rgb.G, 1.0f / 2.4f) - 0.055f;
            }

            if (rgb.B <= 0.0031308)
            {
                b = 12.92f * rgb.B;
            }
            else
            {
                b = (1.0f + 0.055f) * (float)Math.Pow(rgb.B, 1.0f / 2.4f) - 0.055f;
            }

            return new Color4(r, g, b, rgb.A);
        }

        #endregion

        #region HSL

        /// <summary>
        /// Converts HSL color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hsl">
        /// Color value to convert in hue, saturation, lightness (HSL).
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Lightness (L), and the W element is Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        public static Color4 FromHsl(Vector4 hsl)
        {
            var hue = hsl.X * 360.0f;
            var saturation = hsl.Y;
            var lightness = hsl.Z;

            var C = (1.0f - Math.Abs(2.0f * lightness - 1.0f)) * saturation;

            var h = hue / 60.0f;
            var X = C * (1.0f - Math.Abs(h % 2.0f - 1.0f));

            float r, g, b;
            if (0.0f <= h && h < 1.0f)
            {
                r = C;
                g = X;
                b = 0.0f;
            }
            else if (1.0f <= h && h < 2.0f)
            {
                r = X;
                g = C;
                b = 0.0f;
            }
            else if (2.0f <= h && h < 3.0f)
            {
                r = 0.0f;
                g = C;
                b = X;
            }
            else if (3.0f <= h && h < 4.0f)
            {
                r = 0.0f;
                g = X;
                b = C;
            }
            else if (4.0f <= h && h < 5.0f)
            {
                r = X;
                g = 0.0f;
                b = C;
            }
            else if (5.0f <= h && h < 6.0f)
            {
                r = C;
                g = 0.0f;
                b = X;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = lightness - (C / 2.0f);
            return new Color4(r + m, g + m, b + m, hsl.W);
        }

        /// <summary>
        /// Converts RGB color values to HSL color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Lightness (L), and the W element is Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        public static Vector4 ToHsl(Color4 rgb)
        {
            var M = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var m = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var C = M - m;

            float h = 0.0f;
            if (M == rgb.R)
            {
                h = ((rgb.G - rgb.B) / C);
            }
            else if (M == rgb.G)
            {
                h = ((rgb.B - rgb.R) / C) + 2.0f;
            }
            else if (M == rgb.B)
            {
                h = ((rgb.R - rgb.G) / C) + 4.0f;
            }

            var hue = h / 6.0f;
            if (hue < 0.0f)
            {
                hue += 1.0f;
            }

            var lightness = (M + m) / 2.0f;

            var saturation = 0.0f;
            if (0.0f != lightness && lightness != 1.0f)
            {
                saturation = C / (1.0f - Math.Abs(2.0f * lightness - 1.0f));
            }

            return new Vector4(hue, saturation, lightness, rgb.A);
        }

        #endregion

        #region HSV

        /// <summary>
        /// Converts HSV color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hsv">
        /// Color value to convert in hue, saturation, value (HSV).
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Value (V), and the W element is Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        public static Color4 FromHsv(Vector4 hsv)
        {
            var hue = hsv.X * 360.0f;
            var saturation = hsv.Y;
            var value = hsv.Z;

            var C = value * saturation;

            var h = hue / 60.0f;
            var X = C * (1.0f - Math.Abs(h % 2.0f - 1.0f));

            float r, g, b;
            if (0.0f <= h && h < 1.0f)
            {
                r = C;
                g = X;
                b = 0.0f;
            }
            else if (1.0f <= h && h < 2.0f)
            {
                r = X;
                g = C;
                b = 0.0f;
            }
            else if (2.0f <= h && h < 3.0f)
            {
                r = 0.0f;
                g = C;
                b = X;
            }
            else if (3.0f <= h && h < 4.0f)
            {
                r = 0.0f;
                g = X;
                b = C;
            }
            else if (4.0f <= h && h < 5.0f)
            {
                r = X;
                g = 0.0f;
                b = C;
            }
            else if (5.0f <= h && h < 6.0f)
            {
                r = C;
                g = 0.0f;
                b = X;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = value - C;
            return new Color4(r + m, g + m, b + m, hsv.W);
        }

        /// <summary>
        /// Converts RGB color values to HSV color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Value (V), and the W element is Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        public static Vector4 ToHsv(Color4 rgb)
        {
            var M = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var m = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var C = M - m;

            float h = 0.0f;
            if (M == rgb.R)
            {
                h = ((rgb.G - rgb.B) / C) % 6.0f;
            }
            else if (M == rgb.G)
            {
                h = ((rgb.B - rgb.R) / C) + 2.0f;
            }
            else if (M == rgb.B)
            {
                h = ((rgb.R - rgb.G) / C) + 4.0f;
            }

            var hue = (h * 60.0f) / 360.0f;

            var saturation = 0.0f;
            if (0.0f != M)
            {
                saturation = C / M;
            }

            return new Vector4(hue, saturation, M, rgb.A);
        }

        #endregion

        #region XYZ

        /// <summary>
        /// Converts XYZ color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="xyz">
        /// Color value to convert with the trisimulus values of X, Y, and Z in the corresponding element, and the W element with Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        /// <remarks>Uses the CIE XYZ colorspace.</remarks>
        public static Color4 FromXyz(Vector4 xyz)
        {
            var r = 0.41847f * xyz.X + -0.15866f * xyz.Y + -0.082835f * xyz.Z;
            var g = -0.091169f * xyz.X + 0.25243f * xyz.Y + 0.015708f * xyz.Z;
            var b = 0.00092090f * xyz.X + -0.0025498f * xyz.Y + 0.17860f * xyz.Z;
            return new Color4(r, g, b, xyz.W);
        }

        /// <summary>
        /// Converts RGB color values to XYZ color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value with the trisimulus values of X, Y, and Z in the corresponding element, and the W element with Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        /// <remarks>Uses the CIE XYZ colorspace.</remarks>
        public static Vector4 ToXyz(Color4 rgb)
        {
            var x = (0.49f * rgb.R + 0.31f * rgb.G + 0.20f * rgb.B) / 0.17697f;
            var y = (0.17697f * rgb.R + 0.81240f * rgb.G + 0.01063f * rgb.B) / 0.17697f;
            var z = (0.00f * rgb.R + 0.01f * rgb.G + 0.99f * rgb.B) / 0.17697f;
            return new Vector4(x, y, z, rgb.A);
        }

        #endregion        

        #region YUV

        /// <summary>
        /// Converts YCbCr color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="ycbcr">
        /// Color value to convert in Luma-Chrominance (YCbCr) aka YUV.
        /// The X element contains Luma (Y, 0.0 to 1.0), the Y element contains Blue-difference chroma (U, -0.5 to 0.5), the Z element contains the Red-difference chroma (V, -0.5 to 0.5), and the W element contains the Alpha (which is copied to the output's Alpha value).
        /// </param>
        /// <remarks>Converts using ITU-R BT.601/CCIR 601 W(r) = 0.299 W(b) = 0.114 U(max) = 0.436 V(max) = 0.615.</remarks>
        public static Color4 FromYcbcr(Vector4 ycbcr)
        {
            var r = 1.0f * ycbcr.X + 0.0f * ycbcr.Y + 1.402f * ycbcr.Z;
            var g = 1.0f * ycbcr.X + -0.344136f * ycbcr.Y + -0.714136f * ycbcr.Z;
            var b = 1.0f * ycbcr.X + 1.772f * ycbcr.Y + 0.0f * ycbcr.Z;
            return new Color4(r, g, b, ycbcr.W);
        }

        /// <summary>
        /// Converts RGB color values to YUV color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value in Luma-Chrominance (YCbCr) aka YUV.
        /// The X element contains Luma (Y, 0.0 to 1.0), the Y element contains Blue-difference chroma (U, -0.5 to 0.5), the Z element contains the Red-difference chroma (V, -0.5 to 0.5), and the W element contains the Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        /// <remarks>Converts using ITU-R BT.601/CCIR 601 W(r) = 0.299 W(b) = 0.114 U(max) = 0.436 V(max) = 0.615.</remarks>
        public static Vector4 ToYcbcr(Color4 rgb)
        {
            var y = 0.299f * rgb.R + 0.587f * rgb.G + 0.114f * rgb.B;
            var u = -0.168736f * rgb.R + -0.331264f * rgb.G + 0.5f * rgb.B;
            var v = 0.5f * rgb.R + -0.418688f * rgb.G + -0.081312f * rgb.B;
            return new Vector4(y, u, v, rgb.A);
        }

        #endregion

        #region HCY

        /// <summary>
        /// Converts HCY color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hcy">
        /// Color value to convert in hue, chroma, luminance (HCY).
        /// The X element is Hue (H), the Y element is Chroma (C), the Z element is luminance (Y), and the W element is Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        public static Color4 FromHcy(Vector4 hcy)
        {
            var hue = hcy.X * 360.0f;
            var C = hcy.Y;
            var luminance = hcy.Z;

            var h = hue / 60.0f;
            var X = C * (1.0f - Math.Abs(h % 2.0f - 1.0f));

            float r, g, b;
            if (0.0f <= h && h < 1.0f)
            {
                r = C;
                g = X;
                b = 0.0f;
            }
            else if (1.0f <= h && h < 2.0f)
            {
                r = X;
                g = C;
                b = 0.0f;
            }
            else if (2.0f <= h && h < 3.0f)
            {
                r = 0.0f;
                g = C;
                b = X;
            }
            else if (3.0f <= h && h < 4.0f)
            {
                r = 0.0f;
                g = X;
                b = C;
            }
            else if (4.0f <= h && h < 5.0f)
            {
                r = X;
                g = 0.0f;
                b = C;
            }
            else if (5.0f <= h && h < 6.0f)
            {
                r = C;
                g = 0.0f;
                b = X;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = luminance - (0.30f * r + 0.59f * g + 0.11f * b);
            return new Color4(r + m, g + m, b + m, hcy.W);
        }

        /// <summary>
        /// Converts RGB color values to HCY color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Chroma (C), the Z element is luminance (Y), and the W element is Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        public static Vector4 ToHcy(Color4 rgb)
        {
            var M = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var m = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var C = M - m;

            float h = 0.0f;
            if (M == rgb.R)
            {
                h = ((rgb.G - rgb.B) / C) % 6.0f;
            }
            else if (M == rgb.G)
            {
                h = ((rgb.B - rgb.R) / C) + 2.0f;
            }
            else if (M == rgb.B)
            {
                h = ((rgb.R - rgb.G) / C) + 4.0f;
            }

            var hue = (h * 60.0f) / 360.0f;

            var luminance = 0.30f * rgb.R + 0.59f * rgb.G + 0.11f * rgb.B;

            return new Vector4(hue, C, luminance, rgb.A);
        }

        #endregion

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
    }
}
