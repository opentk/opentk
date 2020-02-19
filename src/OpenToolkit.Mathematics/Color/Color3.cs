using System;
using OpenToolkit.Mathematics;

namespace OpenToolkit
{
    /// <summary>
    /// Interface for ColorSpaces with 3 elements.
    /// </summary>
    public interface IColorSpace3
    {
    }

    /// <summary>
    /// Red, green, blue colorspace.
    /// </summary>
    public sealed class Rgb : IColorSpace3
    {
    }

    /// <summary>
    /// Hue, saturation, value colorspace.
    /// </summary>
    public sealed class Hsv : IColorSpace3
    {
    }

    /// <summary>
    /// Hue, saturation, light colorspace.
    /// </summary>
    public sealed class Hsl : IColorSpace3
    {
    }

    /// <summary>
    /// Hue, chroma, luma colorspace.
    /// </summary>
    public sealed class Hcy : IColorSpace3
    {
    }

    /// <summary>
    /// Implementation of a color3 colorspace.
    /// </summary>
    /// <typeparam name="T">The color space of the given color.</typeparam>
    public struct Color3<T>
        where T : IColorSpace3
    {
        /// <summary>
        /// The first element of this color. This corresponds to the first letter of the color type.
        /// </summary>
        public float X;

        /// <summary>
        /// The second element of this colour. This corresponds to the second letter of the colour type.
        /// </summary>
        public float Y;

        /// <summary>
        /// The third element of this color. This corresponds to the second letter of the colour type.
        /// </summary>
        public float Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Color3{T}"/> struct.
        /// </summary>
        /// <param name="x">The first element of the color.</param>
        /// <param name="y">The second element of the color.</param>
        /// <param name="z">The third element of the color.</param>
        public Color3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Gets or sets the nth element of this color.
        /// </summary>
        /// <param name="n">The nth element to get.</param>
        public float this[int n]
        {
            get
            {
                // the old-style switch compiles to slightly smaller IL than the newer one,
                // so is used here for performance.
                switch (n)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(n), n, null);
                }
            }

            set
            {
                switch (n)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(n), n, null);
                }
            }
        }

        /// <summary>
        /// Instantiates a new <see cref="Color3{T}"/> from the X, Y and Z components of a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vec">The vector which the instantiated color will use the X, Y and Z from, in that order.</param>
        /// <returns>The color that was instantiated.</returns>
        public static explicit operator Color3<T>(Vector3 vec) => new Color3<T>(vec.X, vec.Y, vec.Z);

        /// <summary>
        /// Instantiates a new <see cref="Vector3"/> from the X, Y and Z components of a <see cref="Color3{T}"/>.
        /// </summary>
        /// <param name="col">The color which the instantiated vector will use the X, Y and Z from, in that order.</param>
        /// <returns>The vector that was instantiated.</returns>
        public static explicit operator Vector3(Color3<T> col) => new Vector3(col.X, col.Y, col.Z);
    }

    /// <summary>
    /// Factory for conversion between color types.
    /// </summary>
    public static class Color3
    {
        private static Color3<Rgb> PartConvertHc(byte hi, float c)
        {
            float x = c * (1 - MathHelper.Abs((hi % 2) - 1));

            float r1 = 0, g1 = 0, b1 = 0;
            switch (hi)
            {
                case 1:
                    r1 = c;
                    g1 = x;
                    break;
                case 2:
                    r1 = x;
                    g1 = c;
                    break;
                case 3:
                    g1 = c;
                    b1 = x;
                    break;
                case 4:
                    g1 = x;
                    b1 = c;
                    break;
                case 5:
                    r1 = x;
                    b1 = c;
                    break;
                case 6:
                    r1 = c;
                    b1 = x;
                    break;
            }
            return new Color3<Rgb>(r1, g1, b1);
        }

        /// <summary>
        /// Converts a color into <see cref="Argb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="alpha">The alpha of the color.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Argb> ToArgb(this in Color3<Rgb> color, float alpha)
        {
            return new Color4<Argb>(alpha, color.X, color.Y, color.Z);
        }

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="alpha">The alpha of the color.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Rgba> ToRgba(this in Color3<Rgb> color, float alpha)
        {
            return new Color4<Rgba>(color.X, color.Y, color.Z, alpha);
        }

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Rgb> ToRgb(this in Color3<Hsl> color)
        {
            float h = color.X;
            float s = color.Y;
            float l = color.Z;

            byte hi = (byte)(h * 6f);
            float c = (1 - MathHelper.Abs((2 * l) - 1)) * s;

            Color3<Rgb> rgb = PartConvertHc(hi, c);

            float m = l - (c / 2);
            rgb.X += m;
            rgb.Y += m;
            rgb.Z += m;

            return rgb;
        }

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Rgb> ToRgb(this in Color3<Hsv> color)
        {
            float h = color.X;
            float s = color.Y;
            float v = color.Z;

            float c = v * s;
            byte hi = (byte)(h * 6);

            Color3<Rgb> rgb = PartConvertHc(hi, c);

            float m = v - c;
            rgb.X += m;
            rgb.Y += m;
            rgb.Z += m;

            return rgb;
        }

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Rgb> ToRgb(this in Color3<Hcy> color)
        {
            float h = color.X;
            float c = color.Y;
            float y = color.Z;

            byte hi = (byte)(h * 6);

            Color3<Rgb> rgb = PartConvertHc(hi, c);

            float m = y - (0.30f * rgb.X) + (0.59f * rgb.Y) + (0.11f * rgb.Z);
            rgb.X += m;
            rgb.Y += m;
            rgb.Z += m;

            return rgb;
        }

        /// <summary>
        /// Converts a color into <see cref="Hsva"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="alpha">The alpha of this color.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsva> ToHsva(this in Color3<Hsv> color, float alpha)
        {
            return new Color4<Hsva>(color.X, color.Y, color.Z, alpha);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsv"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsv> ToHsv(this in Color3<Hsl> color)
        {
            float hl = color.X;
            float sl = color.Y;
            float ll = color.Z;

            float hv = hl;
            float vv = ll + (sl * MathHelper.Min(ll, 1 - ll));
            float sv = (vv == 0) ? 0 : (2 * (1 - (ll / vv)));

            return new Color3<Hsv>(hv, sv, vv);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsv"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsv> ToHsv(this in Color3<Rgb> color)
        {
            float r = color.X;
            float g = color.Y;
            float b = color.Z;

            float v = Math.Max(r, Math.Max(g, b));
            float c = Math.Min(r, Math.Min(g, b));
            float l = v - (c / 2);

            float h = 0;
            if (c != 0)
            {
                if (v == r)
                {
                    h = 60 * (0 + ((g - b) / c));
                }
                else if (v == g)
                {
                    h = 60 * (2 + ((b - r) / c));
                }
                else if (v == b)
                {
                    h = 60 * (4 + ((r - g) / c));
                }
            }

            float s = (v == 0) ? 0 : (c / v);
            return new Color3<Hsv>(h / 360f, s, v);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsla"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="alpha">The alpha of this color.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsla> ToHsla(this in Color3<Hsl> color, float alpha)
        {
            return new Color4<Hsla>(color.X, color.Y, color.Z, alpha);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsl"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsl> ToHsl(this in Color3<Hsv> color)
        {
            float hv = color.X;
            float sv = color.Y;
            float vv = color.Z;

            float hl = hv;
            float ll = vv * (1 - (sv / 2));
            float sl = (ll == 0 || ll == 1) ? 0 : ((vv - ll) / MathHelper.Min(ll, 1 - ll));

            return new Color3<Hsl>(hl, sl, ll);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsl"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsl> ToHsl(this in Color3<Rgb> color)
        {
            float r = color.X;
            float g = color.Y;
            float b = color.Z;

            float v = Math.Max(r, Math.Max(g, b));
            float c = Math.Min(r, Math.Min(g, b));
            float l = v - (c / 2);

            float h = 0;
            if (c != 0)
            {
                if (v == r)
                {
                    h = 60 * (0 + ((g - b) / c));
                }
                else if (v == g)
                {
                    h = 60 * (2 + ((b - r) / c));
                }
                else if (v == b)
                {
                    h = 60 * (4 + ((r - g) / c));
                }
            }

            float s = (l == 0 || l == 1) ? 0 : ((v - l) / Math.Min(l, 1 - l));
            return new Color3<Hsl>(h / 360f, s, l);
        }
    }
}
