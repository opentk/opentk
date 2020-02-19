using System;
using OpenToolkit.Mathematics;

namespace OpenToolkit
{
    /// <summary>
    /// Interface for ColorSpaces with 4 elements.
    /// </summary>
    public interface IColorSpace4
    {
    }

    /// <summary>
    /// Red, green, blue, alpha colorspace.
    /// </summary>
    public sealed class Rgba : IColorSpace4
    {
    }

    /// <summary>
    /// Alpha, red, green, blue colorspace.
    /// </summary>
    public sealed class Argb : IColorSpace4
    {
    }

    /// <summary>
    /// Hue, saturation, value, alpha colorspace.
    /// </summary>
    public sealed class Hsva : IColorSpace4
    {
    }

    /// <summary>
    /// Hue, saturation, light, alpha colorspace.
    /// </summary>
    public sealed class Hsla : IColorSpace4
    {
    }

    /// <summary>
    /// Implementation of a color4 colorspace.
    /// </summary>
    /// <typeparam name="T">The color space of the given color.</typeparam>
    public struct Color4<T>
        where T : IColorSpace4
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
        /// The fourth element of this color. This corresponds to the second letter of the colour type.
        /// </summary>
        public float W;

        /// <summary>
        /// Initializes a new instance of the <see cref="Color4{T}"/> struct.
        /// </summary>
        /// <param name="x">The first element of the color.</param>
        /// <param name="y">The second element of the color.</param>
        /// <param name="z">The third element of the color.</param>
        /// <param name="w">The fourth element of the color.</param>
        public Color4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
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
                    case 3:
                        return W;
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
                    case 3:
                        W = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(n), n, null);
                }
            }
        }

        /// <summary>
        /// Instantiates a new <see cref="Color4{T}"/> from the X, Y, Z and W components of a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="vec">The vector which the instantiated color will use the X,Y,Z and W from, in that order.</param>
        /// <returns>The color that was instantiated.</returns>
        public static explicit operator Color4<T>(Vector4 vec) => new Color4<T>(vec.X, vec.Y, vec.Z, vec.W);

        /// <summary>
        /// Instantiates a new <see cref="Vector4"/> from the X, Y, Z and W components of a <see cref="Color4{T}"/>.
        /// </summary>
        /// <param name="col">The color which the instantiated vector will use the X,Y,Z and W from, in that order.</param>
        /// <returns>The vector that was instantiated.</returns>
        public static explicit operator Vector4(Color4<T> col) => new Vector4(col.X, col.Y, col.Z, col.W);
    }

    /// <summary>
    /// Factory for conversion between color types.
    /// </summary>
    public static class Color4
    {
        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Rgb> ToRgb(this in Color4<Argb> color) =>
            new Color3<Rgb>(color.Y, color.Z, color.W);

        /// <summary>
        /// Converts a color into <see cref="Argb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Argb> ToArgb(this in Color4<Rgba> color) =>
            new Color4<Argb>(color.W, color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Rgb> ToRgb(this in Color4<Rgba> color) =>
            new Color3<Rgb>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Rgba> ToRgba(this in Color4<Argb> color) =>
            new Color4<Rgba>(color.Y, color.Z, color.W, color.X);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Rgba> ToRgba(this in Color4<Hsva> color) =>
            color.ToHsv().ToRgb().ToRgba(color.W);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Rgba> ToRgba(this in Color4<Hsla> color) =>
            color.ToHsl().ToRgb().ToRgba(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsv"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsv> ToHsv(this in Color4<Hsva> color) =>
            new Color3<Hsv>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Hsva"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsva> ToHsva(this in Color4<Rgba> color) =>
            color.ToRgb().ToHsv().ToHsva(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsva"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsva> ToHsva(this in Color4<Hsla> color) =>
            color.ToHsl().ToHsv().ToHsva(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsl"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color3<Hsl> ToHsl(this in Color4<Hsla> color) =>
            new Color3<Hsl>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Hsla"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsla> ToHsla(this in Color4<Rgba> color) =>
            color.ToRgb().ToHsl().ToHsla(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsla"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static Color4<Hsla> ToHsla(this in Color4<Hsva> color) =>
            color.ToHsv().ToHsl().ToHsla(color.W);
    }
}
