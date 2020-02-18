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

using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenToolkit.Mathematics;

namespace OpenToolkit
{
    /// <summary>
    /// Represents a color with 4 floating-point components (R, G, B, A).
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct OldColor4 : IEquatable<OldColor4>
    {
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

        /// <summary>
        /// Initializes a new instance of the <see cref="OldColor4"/> struct.
        /// </summary>
        /// <param name="r">The red component of the new Color4 structure.</param>
        /// <param name="g">The green component of the new Color4 structure.</param>
        /// <param name="b">The blue component of the new Color4 structure.</param>
        /// <param name="a">The alpha component of the new Color4 structure.</param>
        public OldColor4(float r, float g, float b, float a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OldColor4"/> struct.
        /// </summary>
        /// <param name="r">The red component of the new Color4 structure.</param>
        /// <param name="g">The green component of the new Color4 structure.</param>
        /// <param name="b">The blue component of the new Color4 structure.</param>
        /// <param name="a">The alpha component of the new Color4 structure.</param>
        public OldColor4(byte r, byte g, byte b, byte a)
        {
            R = r / (float)byte.MaxValue;
            G = g / (float)byte.MaxValue;
            B = b / (float)byte.MaxValue;
            A = a / (float)byte.MaxValue;
        }

        /// <summary>
        /// Converts this color to an integer representation with 8 bits per channel.
        /// </summary>
        /// <returns>A <see cref="int"/> that represents this instance.</returns>
        /// <remarks>
        /// This method is intended only for compatibility with System.Drawing. It compresses the color into 8 bits per
        /// channel, which means color information is lost.
        /// </remarks>
        public int ToArgb()
        {
            var value =
                ((uint)(A * byte.MaxValue) << 24) |
                ((uint)(R * byte.MaxValue) << 16) |
                ((uint)(G * byte.MaxValue) << 8) |
                (uint)(B * byte.MaxValue);

            return unchecked((int)value);
        }

        /// <summary>
        /// Compares the specified Color4 structures for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        [Pure]
        public static bool operator ==(OldColor4 left, OldColor4 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified Color4 structures for inequality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        [Pure]
        public static bool operator !=(OldColor4 left, OldColor4 right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts the specified System.Drawing.Color to a Color4 structure.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to convert.</param>
        /// <returns>A new Color4 structure containing the converted components.</returns>
        [Pure]
        public static implicit operator OldColor4(Color color)
        {
            return new OldColor4(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// Converts the specified Color4 to a System.Drawing.Color structure.
        /// </summary>
        /// <param name="color">The Color4 to convert.</param>
        /// <returns>A new System.Drawing.Color structure containing the converted components.</returns>
        [Pure]
        public static explicit operator Color(OldColor4 color)
        {
            return Color.FromArgb(
                (int)(color.A * byte.MaxValue),
                (int)(color.R * byte.MaxValue),
                (int)(color.G * byte.MaxValue),
                (int)(color.B * byte.MaxValue));
        }

        /// <summary>
        /// Returns this Color4 as a Vector4. The resulting struct will have XYZW mapped to RGBA, in that order.
        /// </summary>
        /// <param name="c">The Color4 to convert.</param>
        /// <returns>The Color4, converted into a Vector4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Pure]
        public static explicit operator Vector4(OldColor4 c)
        {
            return Unsafe.As<OldColor4, Vector4>(ref c);
        }

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified object.
        /// </summary>
        /// <param name="obj">An object to compare to.</param>
        /// <returns>True obj is a Color4 structure with the same components as this Color4; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            if (!(obj is OldColor4))
            {
                return false;
            }

            return Equals((OldColor4)obj);
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
            return $"{{(R, G, B, A) = ({R.ToString()}, {G.ToString()}, {B.ToString()}, {A.ToString()})}}";
        }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 0).
        /// </summary>
        public static OldColor4 Transparent => new OldColor4(255, 255, 255, 0);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 248, 255, 255).
        /// </summary>
        public static OldColor4 AliceBlue => new OldColor4(240, 248, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 235, 215, 255).
        /// </summary>
        public static OldColor4 AntiqueWhite => new OldColor4(250, 235, 215, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static OldColor4 Aqua => new OldColor4(0, 255, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 212, 255).
        /// </summary>
        public static OldColor4 Aquamarine => new OldColor4(127, 255, 212, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 255, 255).
        /// </summary>
        public static OldColor4 Azure => new OldColor4(240, 255, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 220, 255).
        /// </summary>
        public static OldColor4 Beige => new OldColor4(245, 245, 220, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 196, 255).
        /// </summary>
        public static OldColor4 Bisque => new OldColor4(255, 228, 196, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 0, 255).
        /// </summary>
        public static OldColor4 Black => new OldColor4(0, 0, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 235, 205, 255).
        /// </summary>
        public static OldColor4 BlanchedAlmond => new OldColor4(255, 235, 205, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 255, 255).
        /// </summary>
        public static OldColor4 Blue => new OldColor4(0, 0, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (138, 43, 226, 255).
        /// </summary>
        public static OldColor4 BlueViolet => new OldColor4(138, 43, 226, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (165, 42, 42, 255).
        /// </summary>
        public static OldColor4 Brown => new OldColor4(165, 42, 42, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (222, 184, 135, 255).
        /// </summary>
        public static OldColor4 BurlyWood => new OldColor4(222, 184, 135, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (95, 158, 160, 255).
        /// </summary>
        public static OldColor4 CadetBlue => new OldColor4(95, 158, 160, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 0, 255).
        /// </summary>
        public static OldColor4 Chartreuse => new OldColor4(127, 255, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 105, 30, 255).
        /// </summary>
        public static OldColor4 Chocolate => new OldColor4(210, 105, 30, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 127, 80, 255).
        /// </summary>
        public static OldColor4 Coral => new OldColor4(255, 127, 80, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (100, 149, 237, 255).
        /// </summary>
        public static OldColor4 CornflowerBlue => new OldColor4(100, 149, 237, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 248, 220, 255).
        /// </summary>
        public static OldColor4 Cornsilk => new OldColor4(255, 248, 220, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 20, 60, 255).
        /// </summary>
        public static OldColor4 Crimson => new OldColor4(220, 20, 60, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static OldColor4 Cyan => new OldColor4(0, 255, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 139, 255).
        /// </summary>
        public static OldColor4 DarkBlue => new OldColor4(0, 0, 139, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 139, 139, 255).
        /// </summary>
        public static OldColor4 DarkCyan => new OldColor4(0, 139, 139, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (184, 134, 11, 255).
        /// </summary>
        public static OldColor4 DarkGoldenrod => new OldColor4(184, 134, 11, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (169, 169, 169, 255).
        /// </summary>
        public static OldColor4 DarkGray => new OldColor4(169, 169, 169, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 100, 0, 255).
        /// </summary>
        public static OldColor4 DarkGreen => new OldColor4(0, 100, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (189, 183, 107, 255).
        /// </summary>
        public static OldColor4 DarkKhaki => new OldColor4(189, 183, 107, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 139, 255).
        /// </summary>
        public static OldColor4 DarkMagenta => new OldColor4(139, 0, 139, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (85, 107, 47, 255).
        /// </summary>
        public static OldColor4 DarkOliveGreen => new OldColor4(85, 107, 47, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 140, 0, 255).
        /// </summary>
        public static OldColor4 DarkOrange => new OldColor4(255, 140, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (153, 50, 204, 255).
        /// </summary>
        public static OldColor4 DarkOrchid => new OldColor4(153, 50, 204, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 0, 255).
        /// </summary>
        public static OldColor4 DarkRed => new OldColor4(139, 0, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (233, 150, 122, 255).
        /// </summary>
        public static OldColor4 DarkSalmon => new OldColor4(233, 150, 122, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (143, 188, 139, 255).
        /// </summary>
        public static OldColor4 DarkSeaGreen => new OldColor4(143, 188, 139, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 61, 139, 255).
        /// </summary>
        public static OldColor4 DarkSlateBlue => new OldColor4(72, 61, 139, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (47, 79, 79, 255).
        /// </summary>
        public static OldColor4 DarkSlateGray => new OldColor4(47, 79, 79, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 206, 209, 255).
        /// </summary>
        public static OldColor4 DarkTurquoise => new OldColor4(0, 206, 209, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (148, 0, 211, 255).
        /// </summary>
        public static OldColor4 DarkViolet => new OldColor4(148, 0, 211, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 20, 147, 255).
        /// </summary>
        public static OldColor4 DeepPink => new OldColor4(255, 20, 147, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 191, 255, 255).
        /// </summary>
        public static OldColor4 DeepSkyBlue => new OldColor4(0, 191, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (105, 105, 105, 255).
        /// </summary>
        public static OldColor4 DimGray => new OldColor4(105, 105, 105, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (30, 144, 255, 255).
        /// </summary>
        public static OldColor4 DodgerBlue => new OldColor4(30, 144, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (178, 34, 34, 255).
        /// </summary>
        public static OldColor4 Firebrick => new OldColor4(178, 34, 34, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 240, 255).
        /// </summary>
        public static OldColor4 FloralWhite => new OldColor4(255, 250, 240, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (34, 139, 34, 255).
        /// </summary>
        public static OldColor4 ForestGreen => new OldColor4(34, 139, 34, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static OldColor4 Fuchsia => new OldColor4(255, 0, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 220, 220, 255).
        /// </summary>
        public static OldColor4 Gainsboro => new OldColor4(220, 220, 220, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (248, 248, 255, 255).
        /// </summary>
        public static OldColor4 GhostWhite => new OldColor4(248, 248, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 215, 0, 255).
        /// </summary>
        public static OldColor4 Gold => new OldColor4(255, 215, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 165, 32, 255).
        /// </summary>
        public static OldColor4 Goldenrod => new OldColor4(218, 165, 32, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 128, 255).
        /// </summary>
        public static OldColor4 Gray => new OldColor4(128, 128, 128, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 0, 255).
        /// </summary>
        public static OldColor4 Green => new OldColor4(0, 128, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 255, 47, 255).
        /// </summary>
        public static OldColor4 GreenYellow => new OldColor4(173, 255, 47, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 240, 255).
        /// </summary>
        public static OldColor4 Honeydew => new OldColor4(240, 255, 240, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 105, 180, 255).
        /// </summary>
        public static OldColor4 HotPink => new OldColor4(255, 105, 180, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 92, 92, 255).
        /// </summary>
        public static OldColor4 IndianRed => new OldColor4(205, 92, 92, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (75, 0, 130, 255).
        /// </summary>
        public static OldColor4 Indigo => new OldColor4(75, 0, 130, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 240, 255).
        /// </summary>
        public static OldColor4 Ivory => new OldColor4(255, 255, 240, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 230, 140, 255).
        /// </summary>
        public static OldColor4 Khaki => new OldColor4(240, 230, 140, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (230, 230, 250, 255).
        /// </summary>
        public static OldColor4 Lavender => new OldColor4(230, 230, 250, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 240, 245, 255).
        /// </summary>
        public static OldColor4 LavenderBlush => new OldColor4(255, 240, 245, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (124, 252, 0, 255).
        /// </summary>
        public static OldColor4 LawnGreen => new OldColor4(124, 252, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 205, 255).
        /// </summary>
        public static OldColor4 LemonChiffon => new OldColor4(255, 250, 205, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 216, 230, 255).
        /// </summary>
        public static OldColor4 LightBlue => new OldColor4(173, 216, 230, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 128, 128, 255).
        /// </summary>
        public static OldColor4 LightCoral => new OldColor4(240, 128, 128, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (224, 255, 255, 255).
        /// </summary>
        public static OldColor4 LightCyan => new OldColor4(224, 255, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 250, 210, 255).
        /// </summary>
        public static OldColor4 LightGoldenrodYellow => new OldColor4(250, 250, 210, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (144, 238, 144, 255).
        /// </summary>
        public static OldColor4 LightGreen => new OldColor4(144, 238, 144, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (211, 211, 211, 255).
        /// </summary>
        public static OldColor4 LightGray => new OldColor4(211, 211, 211, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 182, 193, 255).
        /// </summary>
        public static OldColor4 LightPink => new OldColor4(255, 182, 193, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 160, 122, 255).
        /// </summary>
        public static OldColor4 LightSalmon => new OldColor4(255, 160, 122, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (32, 178, 170, 255).
        /// </summary>
        public static OldColor4 LightSeaGreen => new OldColor4(32, 178, 170, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 250, 255).
        /// </summary>
        public static OldColor4 LightSkyBlue => new OldColor4(135, 206, 250, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (119, 136, 153, 255).
        /// </summary>
        public static OldColor4 LightSlateGray => new OldColor4(119, 136, 153, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 196, 222, 255).
        /// </summary>
        public static OldColor4 LightSteelBlue => new OldColor4(176, 196, 222, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 224, 255).
        /// </summary>
        public static OldColor4 LightYellow => new OldColor4(255, 255, 224, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 0, 255).
        /// </summary>
        public static OldColor4 Lime => new OldColor4(0, 255, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (50, 205, 50, 255).
        /// </summary>
        public static OldColor4 LimeGreen => new OldColor4(50, 205, 50, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 240, 230, 255).
        /// </summary>
        public static OldColor4 Linen => new OldColor4(250, 240, 230, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static OldColor4 Magenta => new OldColor4(255, 0, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 0, 255).
        /// </summary>
        public static OldColor4 Maroon => new OldColor4(128, 0, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (102, 205, 170, 255).
        /// </summary>
        public static OldColor4 MediumAquamarine => new OldColor4(102, 205, 170, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 205, 255).
        /// </summary>
        public static OldColor4 MediumBlue => new OldColor4(0, 0, 205, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (186, 85, 211, 255).
        /// </summary>
        public static OldColor4 MediumOrchid => new OldColor4(186, 85, 211, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (147, 112, 219, 255).
        /// </summary>
        public static OldColor4 MediumPurple => new OldColor4(147, 112, 219, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (60, 179, 113, 255).
        /// </summary>
        public static OldColor4 MediumSeaGreen => new OldColor4(60, 179, 113, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (123, 104, 238, 255).
        /// </summary>
        public static OldColor4 MediumSlateBlue => new OldColor4(123, 104, 238, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 250, 154, 255).
        /// </summary>
        public static OldColor4 MediumSpringGreen => new OldColor4(0, 250, 154, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 209, 204, 255).
        /// </summary>
        public static OldColor4 MediumTurquoise => new OldColor4(72, 209, 204, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (199, 21, 133, 255).
        /// </summary>
        public static OldColor4 MediumVioletRed => new OldColor4(199, 21, 133, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (25, 25, 112, 255).
        /// </summary>
        public static OldColor4 MidnightBlue => new OldColor4(25, 25, 112, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 255, 250, 255).
        /// </summary>
        public static OldColor4 MintCream => new OldColor4(245, 255, 250, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 225, 255).
        /// </summary>
        public static OldColor4 MistyRose => new OldColor4(255, 228, 225, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 181, 255).
        /// </summary>
        public static OldColor4 Moccasin => new OldColor4(255, 228, 181, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 222, 173, 255).
        /// </summary>
        public static OldColor4 NavajoWhite => new OldColor4(255, 222, 173, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 128, 255).
        /// </summary>
        public static OldColor4 Navy => new OldColor4(0, 0, 128, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (253, 245, 230, 255).
        /// </summary>
        public static OldColor4 OldLace => new OldColor4(253, 245, 230, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 0, 255).
        /// </summary>
        public static OldColor4 Olive => new OldColor4(128, 128, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (107, 142, 35, 255).
        /// </summary>
        public static OldColor4 OliveDrab => new OldColor4(107, 142, 35, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 165, 0, 255).
        /// </summary>
        public static OldColor4 Orange => new OldColor4(255, 165, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 69, 0, 255).
        /// </summary>
        public static OldColor4 OrangeRed => new OldColor4(255, 69, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 112, 214, 255).
        /// </summary>
        public static OldColor4 Orchid => new OldColor4(218, 112, 214, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 232, 170, 255).
        /// </summary>
        public static OldColor4 PaleGoldenrod => new OldColor4(238, 232, 170, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (152, 251, 152, 255).
        /// </summary>
        public static OldColor4 PaleGreen => new OldColor4(152, 251, 152, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (175, 238, 238, 255).
        /// </summary>
        public static OldColor4 PaleTurquoise => new OldColor4(175, 238, 238, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (219, 112, 147, 255).
        /// </summary>
        public static OldColor4 PaleVioletRed => new OldColor4(219, 112, 147, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 239, 213, 255).
        /// </summary>
        public static OldColor4 PapayaWhip => new OldColor4(255, 239, 213, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 218, 185, 255).
        /// </summary>
        public static OldColor4 PeachPuff => new OldColor4(255, 218, 185, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 133, 63, 255).
        /// </summary>
        public static OldColor4 Peru => new OldColor4(205, 133, 63, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 192, 203, 255).
        /// </summary>
        public static OldColor4 Pink => new OldColor4(255, 192, 203, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (221, 160, 221, 255).
        /// </summary>
        public static OldColor4 Plum => new OldColor4(221, 160, 221, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 224, 230, 255).
        /// </summary>
        public static OldColor4 PowderBlue => new OldColor4(176, 224, 230, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 128, 255).
        /// </summary>
        public static OldColor4 Purple => new OldColor4(128, 0, 128, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 0, 255).
        /// </summary>
        public static OldColor4 Red => new OldColor4(255, 0, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (188, 143, 143, 255).
        /// </summary>
        public static OldColor4 RosyBrown => new OldColor4(188, 143, 143, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (65, 105, 225, 255).
        /// </summary>
        public static OldColor4 RoyalBlue => new OldColor4(65, 105, 225, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 69, 19, 255).
        /// </summary>
        public static OldColor4 SaddleBrown => new OldColor4(139, 69, 19, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 128, 114, 255).
        /// </summary>
        public static OldColor4 Salmon => new OldColor4(250, 128, 114, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (244, 164, 96, 255).
        /// </summary>
        public static OldColor4 SandyBrown => new OldColor4(244, 164, 96, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (46, 139, 87, 255).
        /// </summary>
        public static OldColor4 SeaGreen => new OldColor4(46, 139, 87, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 245, 238, 255).
        /// </summary>
        public static OldColor4 SeaShell => new OldColor4(255, 245, 238, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (160, 82, 45, 255).
        /// </summary>
        public static OldColor4 Sienna => new OldColor4(160, 82, 45, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (192, 192, 192, 255).
        /// </summary>
        public static OldColor4 Silver => new OldColor4(192, 192, 192, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 235, 255).
        /// </summary>
        public static OldColor4 SkyBlue => new OldColor4(135, 206, 235, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (106, 90, 205, 255).
        /// </summary>
        public static OldColor4 SlateBlue => new OldColor4(106, 90, 205, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (112, 128, 144, 255).
        /// </summary>
        public static OldColor4 SlateGray => new OldColor4(112, 128, 144, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 250, 255).
        /// </summary>
        public static OldColor4 Snow => new OldColor4(255, 250, 250, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 127, 255).
        /// </summary>
        public static OldColor4 SpringGreen => new OldColor4(0, 255, 127, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (70, 130, 180, 255).
        /// </summary>
        public static OldColor4 SteelBlue => new OldColor4(70, 130, 180, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 180, 140, 255).
        /// </summary>
        public static OldColor4 Tan => new OldColor4(210, 180, 140, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 128, 255).
        /// </summary>
        public static OldColor4 Teal => new OldColor4(0, 128, 128, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (216, 191, 216, 255).
        /// </summary>
        public static OldColor4 Thistle => new OldColor4(216, 191, 216, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 99, 71, 255).
        /// </summary>
        public static OldColor4 Tomato => new OldColor4(255, 99, 71, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (64, 224, 208, 255).
        /// </summary>
        public static OldColor4 Turquoise => new OldColor4(64, 224, 208, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 130, 238, 255).
        /// </summary>
        public static OldColor4 Violet => new OldColor4(238, 130, 238, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 222, 179, 255).
        /// </summary>
        public static OldColor4 Wheat => new OldColor4(245, 222, 179, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 255).
        /// </summary>
        public static OldColor4 White => new OldColor4(255, 255, 255, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 245, 255).
        /// </summary>
        public static OldColor4 WhiteSmoke => new OldColor4(245, 245, 245, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 0, 255).
        /// </summary>
        public static OldColor4 Yellow => new OldColor4(255, 255, 0, 255);

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (154, 205, 50, 255).
        /// </summary>
        public static OldColor4 YellowGreen => new OldColor4(154, 205, 50, 255);

        /// <summary>
        /// Converts sRGB color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="srgb">
        /// Color value to convert in sRGB.
        /// </param>
        [Pure]
        public static OldColor4 FromSrgb(OldColor4 srgb)
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

            return new OldColor4(r, g, b, srgb.A);
        }

        /// <summary>
        /// Converts RGB color values to sRGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        [Pure]
        public static OldColor4 ToSrgb(OldColor4 rgb)
        {
            float r, g, b;

            if (rgb.R <= 0.0031308)
            {
                r = 12.92f * rgb.R;
            }
            else
            {
                r = ((1.0f + 0.055f) * (float)Math.Pow(rgb.R, 1.0f / 2.4f)) - 0.055f;
            }

            if (rgb.G <= 0.0031308)
            {
                g = 12.92f * rgb.G;
            }
            else
            {
                g = ((1.0f + 0.055f) * (float)Math.Pow(rgb.G, 1.0f / 2.4f)) - 0.055f;
            }

            if (rgb.B <= 0.0031308)
            {
                b = 12.92f * rgb.B;
            }
            else
            {
                b = ((1.0f + 0.055f) * (float)Math.Pow(rgb.B, 1.0f / 2.4f)) - 0.055f;
            }

            return new OldColor4(r, g, b, rgb.A);
        }

        /// <summary>
        /// Converts HSL color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hsl">
        /// Color value to convert in hue, saturation, lightness (HSL).
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Lightness (L), and the W element is
        /// Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        [Pure]
        public static OldColor4 FromHsl(Vector4 hsl)
        {
            var hue = hsl.X * 360.0f;
            var saturation = hsl.Y;
            var lightness = hsl.Z;

            var c = (1.0f - Math.Abs((2.0f * lightness) - 1.0f)) * saturation;

            var h = hue / 60.0f;
            var x = c * (1.0f - Math.Abs((h % 2.0f) - 1.0f));

            float r, g, b;
            if (h >= 0.0f && h < 1.0f)
            {
                r = c;
                g = x;
                b = 0.0f;
            }
            else if (h >= 1.0f && h < 2.0f)
            {
                r = x;
                g = c;
                b = 0.0f;
            }
            else if (h >= 2.0f && h < 3.0f)
            {
                r = 0.0f;
                g = c;
                b = x;
            }
            else if (h >= 3.0f && h < 4.0f)
            {
                r = 0.0f;
                g = x;
                b = c;
            }
            else if (h >= 4.0f && h < 5.0f)
            {
                r = x;
                g = 0.0f;
                b = c;
            }
            else if (h >= 5.0f && h < 6.0f)
            {
                r = c;
                g = 0.0f;
                b = x;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = lightness - (c / 2.0f);
            if (m < 0)
            {
                m = 0;
            }
            return new OldColor4(r + m, g + m, b + m, hsl.W);
        }

        /// <summary>
        /// Converts RGB color values to HSL color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Lightness (L), and the W element is
        /// Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        [Pure]
        public static Vector4 ToHsl(OldColor4 rgb)
        {
            var max = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var min = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var diff = max - min;

            var h = 0.0f;
            if (diff == 0)
            {
                h = 0.0f;
            }
            else if (max == rgb.R)
            {
                h = ((rgb.G - rgb.B) / diff) % 6;
                if (h < 0)
                {
                    h += 6;
                }
            }
            else if (max == rgb.G)
            {
                h = ((rgb.B - rgb.R) / diff) + 2.0f;
            }
            else if (max == rgb.B)
            {
                h = ((rgb.R - rgb.G) / diff) + 4.0f;
            }

            var hue = h / 6.0f;
            if (hue < 0.0f)
            {
                hue += 1.0f;
            }

            var lightness = (max + min) / 2.0f;

            var saturation = 0.0f;
            if ((1.0f - Math.Abs((2.0f * lightness) - 1.0f)) != 0)
            {
                saturation = diff / (1.0f - Math.Abs((2.0f * lightness) - 1.0f));
            }

            return new Vector4(hue, saturation, lightness, rgb.A);
        }

        /// <summary>
        /// Converts HSV color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hsv">
        /// Color value to convert in hue, saturation, value (HSV).
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Value (V), and the W element is Alpha
        /// (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        [Pure]
        public static OldColor4 FromHsv(Vector4 hsv)
        {
            var hue = hsv.X * 360.0f;
            var saturation = hsv.Y;
            var value = hsv.Z;

            var c = value * saturation;

            var h = hue / 60.0f;
            var x = c * (1.0f - Math.Abs((h % 2.0f) - 1.0f));

            float r, g, b;
            if (h >= 0.0f && h < 1.0f)
            {
                r = c;
                g = x;
                b = 0.0f;
            }
            else if (h >= 1.0f && h < 2.0f)
            {
                r = x;
                g = c;
                b = 0.0f;
            }
            else if (h >= 2.0f && h < 3.0f)
            {
                r = 0.0f;
                g = c;
                b = x;
            }
            else if (h >= 3.0f && h < 4.0f)
            {
                r = 0.0f;
                g = x;
                b = c;
            }
            else if (h >= 4.0f && h < 5.0f)
            {
                r = x;
                g = 0.0f;
                b = c;
            }
            else if (h >= 5.0f && h < 6.0f)
            {
                r = c;
                g = 0.0f;
                b = x;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = value - c;
            return new OldColor4(r + m, g + m, b + m, hsv.W);
        }

        /// <summary>
        /// Converts RGB color values to HSV color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Saturation (S), the Z element is Value (V), and the W element is Alpha
        /// (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        [Pure]
        public static Vector4 ToHsv(OldColor4 rgb)
        {
            var max = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var min = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var diff = max - min;

            var h = 0.0f;
            if (diff == 0)
            {
                h = 0.0f;
            }
            else if (max == rgb.R)
            {
                h = ((rgb.G - rgb.B) / diff) % 6.0f;
                if (h < 0)
                {
                    h += 6f;
                }
            }
            else if (max == rgb.G)
            {
                h = ((rgb.B - rgb.R) / diff) + 2.0f;
            }
            else if (max == rgb.B)
            {
                h = ((rgb.R - rgb.G) / diff) + 4.0f;
            }

            var hue = h * 60.0f / 360.0f;

            var saturation = 0.0f;
            if (max != 0.0f)
            {
                saturation = diff / max;
            }

            return new Vector4(hue, saturation, max, rgb.A);
        }

        /// <summary>
        /// Converts XYZ color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="xyz">
        /// Color value to convert with the trisimulus values of X, Y, and Z in the corresponding element, and the W element
        /// with Alpha (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        /// <remarks>Uses the CIE XYZ colorspace.</remarks>
        [Pure]
        public static OldColor4 FromXyz(Vector4 xyz)
        {
            var r = (0.41847f * xyz.X) + (-0.15866f * xyz.Y) + (-0.082835f * xyz.Z);
            var g = (-0.091169f * xyz.X) + (0.25243f * xyz.Y) + (0.015708f * xyz.Z);
            var b = (0.00092090f * xyz.X) + (-0.0025498f * xyz.Y) + (0.17860f * xyz.Z);
            return new OldColor4(r, g, b, xyz.W);
        }

        /// <summary>
        /// Converts RGB color values to XYZ color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value with the trisimulus values of X, Y, and Z in the corresponding element, and the W
        /// element with Alpha (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        /// <remarks>Uses the CIE XYZ colorspace.</remarks>
        [Pure]
        public static Vector4 ToXyz(OldColor4 rgb)
        {
            var x = ((0.49f * rgb.R) + (0.31f * rgb.G) + (0.20f * rgb.B)) / 0.17697f;
            var y = ((0.17697f * rgb.R) + (0.81240f * rgb.G) + (0.01063f * rgb.B)) / 0.17697f;
            var z = ((0.00f * rgb.R) + (0.01f * rgb.G) + (0.99f * rgb.B)) / 0.17697f;
            return new Vector4(x, y, z, rgb.A);
        }

        /// <summary>
        /// Converts YCbCr color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="ycbcr">
        /// Color value to convert in Luma-Chrominance (YCbCr) aka YUV.
        /// The X element contains Luma (Y, 0.0 to 1.0), the Y element contains Blue-difference chroma (U, -0.5 to 0.5), the Z
        /// element contains the Red-difference chroma (V, -0.5 to 0.5), and the W element contains the Alpha (which is copied
        /// to the output's Alpha value).
        /// </param>
        /// <remarks>Converts using ITU-R BT.601/CCIR 601 W(r) = 0.299 W(b) = 0.114 U(max) = 0.436 V(max) = 0.615.</remarks>
        [Pure]
        public static OldColor4 FromYcbcr(Vector4 ycbcr)
        {
            var r = (1.0f * ycbcr.X) + (0.0f * ycbcr.Y) + (1.402f * ycbcr.Z);
            var g = (1.0f * ycbcr.X) + (-0.344136f * ycbcr.Y) + (-0.714136f * ycbcr.Z);
            var b = (1.0f * ycbcr.X) + (1.772f * ycbcr.Y) + (0.0f * ycbcr.Z);
            return new OldColor4(r, g, b, ycbcr.W);
        }

        /// <summary>
        /// Converts RGB color values to YUV color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value in Luma-Chrominance (YCbCr) aka YUV.
        /// The X element contains Luma (Y, 0.0 to 1.0), the Y element contains Blue-difference chroma (U, -0.5 to 0.5), the Z
        /// element contains the Red-difference chroma (V, -0.5 to 0.5), and the W element contains the Alpha (a copy of the
        /// input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        /// <remarks>Converts using ITU-R BT.601/CCIR 601 W(r) = 0.299 W(b) = 0.114 U(max) = 0.436 V(max) = 0.615.</remarks>
        [Pure]
        public static Vector4 ToYcbcr(OldColor4 rgb)
        {
            var y = (0.299f * rgb.R) + (0.587f * rgb.G) + (0.114f * rgb.B);
            var u = (-0.168736f * rgb.R) + (-0.331264f * rgb.G) + (0.5f * rgb.B);
            var v = (0.5f * rgb.R) + (-0.418688f * rgb.G) + (-0.081312f * rgb.B);
            return new Vector4(y, u, v, rgb.A);
        }

        /// <summary>
        /// Converts HCY color values to RGB color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// </returns>
        /// <param name="hcy">
        /// Color value to convert in hue, chroma, luminance (HCY).
        /// The X element is Hue (H), the Y element is Chroma (C), the Z element is luminance (Y), and the W element is Alpha
        /// (which is copied to the output's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </param>
        [Pure]
        public static OldColor4 FromHcy(Vector4 hcy)
        {
            var hue = hcy.X * 360.0f;
            var y = hcy.Y;
            var luminance = hcy.Z;

            var h = hue / 60.0f;
            var x = y * (1.0f - Math.Abs((h % 2.0f) - 1.0f));

            float r, g, b;
            if (h >= 0.0f && h < 1.0f)
            {
                r = y;
                g = x;
                b = 0.0f;
            }
            else if (h >= 1.0f && h < 2.0f)
            {
                r = x;
                g = y;
                b = 0.0f;
            }
            else if (h >= 2.0f && h < 3.0f)
            {
                r = 0.0f;
                g = y;
                b = x;
            }
            else if (h >= 3.0f && h < 4.0f)
            {
                r = 0.0f;
                g = x;
                b = y;
            }
            else if (h >= 4.0f && h < 5.0f)
            {
                r = x;
                g = 0.0f;
                b = y;
            }
            else if (h >= 5.0f && h < 6.0f)
            {
                r = y;
                g = 0.0f;
                b = x;
            }
            else
            {
                r = 0.0f;
                g = 0.0f;
                b = 0.0f;
            }

            var m = luminance - (0.30f * r) + (0.59f * g) + (0.11f * b);
            return new OldColor4(r + m, g + m, b + m, hcy.W);
        }

        /// <summary>
        /// Converts RGB color values to HCY color values.
        /// </summary>
        /// <returns>
        /// Returns the converted color value.
        /// The X element is Hue (H), the Y element is Chroma (C), the Z element is luminance (Y), and the W element is Alpha
        /// (a copy of the input's Alpha value).
        /// Each has a range of 0.0 to 1.0.
        /// </returns>
        /// <param name="rgb">Color value to convert.</param>
        [Pure]
        public static Vector4 ToHcy(OldColor4 rgb)
        {
            var max = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            var min = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));
            var diff = max - min;

            var h = 0.0f;
            if (max == rgb.R)
            {
                h = ((rgb.G - rgb.B) / diff) % 6.0f;
            }
            else if (max == rgb.G)
            {
                h = ((rgb.B - rgb.R) / diff) + 2.0f;
            }
            else if (max == rgb.B)
            {
                h = ((rgb.R - rgb.G) / diff) + 4.0f;
            }

            var hue = h * 60.0f / 360.0f;

            var luminance = (0.30f * rgb.R) + (0.59f * rgb.G) + (0.11f * rgb.B);

            return new Vector4(hue, diff, luminance, rgb.A);
        }

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified Color4.
        /// </summary>
        /// <param name="other">The Color4 structure to compare to.</param>
        /// <returns>True if both Color4 structures contain the same components; false otherwise.</returns>
        [Pure]
        public bool Equals(OldColor4 other)
        {
            return
                R == other.R &&
                G == other.G &&
                B == other.B &&
                A == other.A;
        }
    }
}
