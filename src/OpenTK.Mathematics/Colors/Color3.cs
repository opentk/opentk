using System;
using System.Diagnostics.Contracts;
using OpenTK.Mathematics;

#pragma warning disable SA1649
namespace OpenTK
{
    /// <summary>
    /// Interface for ColorSpace phantom types with 3 elements.
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
    /// To provide type-safety between different color spaces and allow extension by users to include additional and future color spaces, colors are marked with a special _phantom_ type parameter that indicates their color space.
    /// Typically these are four-letter abbreviations that indicate the components of the colors, such as <see cref="Rgb"/> or <see cref="Hsv"/>.
    ///
    /// In any of these cases, letters in the color space correspond to the order of the components in the color vector. For example, color<RGB> maps as follows:</br>
    /// X -> R
    /// Y -> G
    /// Z -> B.
    /// </summary>
    /// <typeparam name="T">The color space of the given color.</typeparam>
    public struct Color3<T> : IEquatable<Color3<T>>
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
        [Pure]
        public static explicit operator Color3<T>(in Vector3 vec) => new Color3<T>(vec.X, vec.Y, vec.Z);

        /// <summary>
        /// Instantiates a new <see cref="Vector3"/> from the X, Y and Z components of a <see cref="Color3{T}"/>.
        /// </summary>
        /// <param name="col">The color which the instantiated vector will use the X, Y and Z from, in that order.</param>
        /// <returns>The vector that was instantiated.</returns>
        [Pure]
        public static explicit operator Vector3(in Color3<T> col) => new Vector3(col.X, col.Y, col.Z);

        /// <summary>
        /// Deconstructs this color3 and turns it into a tuple containing 3 floats.
        /// </summary>
        /// <param name="x">The x component of this color, defined by the color space.</param>
        /// <param name="y">The y component of this color, defined by the color space.</param>
        /// <param name="z">The z component of this color, defined by the color space.</param>
        [Pure]
        public void Deconstruct(out float x, out float y, out float z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        /// <summary>
        /// Compares the specified Color3 structures for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        [Pure]
        public static bool operator ==(in Color3<T> left, in Color3<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified Color3 structures for inequality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        [Pure]
        public static bool operator !=(in Color3<T> left, in Color3<T> right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares whether this Color3 structure is equal to the specified Color4.
        /// </summary>
        /// <param name="other">The Color3 structure to compare to.</param>
        /// <returns>True if both Color3 structures contain the same components; false otherwise.</returns>
        [Pure]
        public bool Equals(Color3<T> other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        /// <summary>
        /// Creates a <see cref="string"/> that describes this Color4 structure.
        /// </summary>
        /// <returns>A <see cref="string"/> that describes this Color4 structure.</returns>
        [Pure]
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified object.
        /// </summary>
        /// <param name="obj">An object to compare to.</param>
        /// <returns>True obj is a Color4 structure with the same components as this Color4; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            return obj is Color3<T> other && Equals(other);
        }

        /// <summary>
        /// Calculates the hash code for this Color4 structure.
        /// </summary>
        /// <returns>A System.Int32 containing the hashcode of this Color4 structure.</returns>
        [Pure]
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }
    }

    /// <summary>
    /// Companion type for conversion between color types.
    /// </summary>
    public static class Color3
    {
        /// <summary>
        /// Adds all the elements of left to all the elements of right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by adding the two colors together.</returns>
        public static Color3<Rgb> Add(this in Color3<Rgb> left, in Color3<Rgb> right) =>
            new Color3<Rgb>(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

        /// <summary>
        /// Subtracts all the elements of right from all the elements of left.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by subtracting all elements of right with all elements from left.</returns>
        public static Color3<Rgb> Subtract(this in Color3<Rgb> left, in Color3<Rgb> right) =>
            new Color3<Rgb>(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

        /// <summary>
        /// Multiplies all the elements of left with all the elements of right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by multiplying the two colors together.</returns>
        public static Color3<Rgb> Multiply(this in Color3<Rgb> left, in Color3<Rgb> right) =>
            new Color3<Rgb>(left.X * right.X, left.Y * right.Y, left.Z * right.Z);

        /// <summary>
        /// Multiplies all the elements of left with right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by multiplying all elements of left with right.</returns>
        public static Color3<Rgb> Multiply(this in Color3<Rgb> left, in float right) =>
            new Color3<Rgb>(left.X * right, left.Y * right, left.Z * right);

        /// <summary>
        /// Divides all the elements of left with right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by dividing all elements of left with right.</returns>
        public static Color3<Rgb> Divide(this in Color3<Rgb> left, in float right) =>
            new Color3<Rgb>(left.X / right, left.Y / right, left.Z / right);

        /// <summary>
        /// Converts a color into <see cref="Argb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="alpha">The alpha of the color.</param>
        /// <returns>The converted color.</returns>
        [Pure]
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
        [Pure]
        public static Color4<Rgba> ToRgba(this in Color3<Rgb> color, float alpha)
        {
            return new Color4<Rgba>(color.X, color.Y, color.Z, alpha);
        }

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color3<Rgb> ToRgb(this in Color3<Hsl> color)
        {
            float h = color.X;
            float s = color.Y;
            float l = color.Z;

            float hi = h * 6f;
            float c = (1 - MathHelper.Abs((2 * l) - 1)) * s;
            float x = c * (1 - MathHelper.Abs((hi % 2) - 1));

            Color3<Rgb> rgb = new Color3<Rgb>(0, 0, 0);
            switch (hi)
            {
                case 0:
                    rgb.X = c;
                    rgb.Y = x;
                    break;
                case 1:
                    rgb.X = x;
                    rgb.Y = c;
                    break;
                case 2:
                    rgb.Y = c;
                    rgb.Z = x;
                    break;
                case 3:
                    rgb.Y = x;
                    rgb.Z = c;
                    break;
                case 4:
                    rgb.X = x;
                    rgb.Z = c;
                    break;
                case 5:
                    rgb.X = c;
                    rgb.Z = x;
                    break;
            }

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
        [Pure]
        public static Color3<Rgb> ToRgb(this in Color3<Hsv> color)
        {
            float h = color.X;
            float s = color.Y;
            float v = color.Z;

            float c = v * s;
            byte hi = (byte)(h * 6);
            float x = c * (1 - MathHelper.Abs((hi % 2) - 1));

            Color3<Rgb> rgb = new Color3<Rgb>(0, 0, 0);
            switch (hi)
            {
                case 1:
                    rgb.X = c;
                    rgb.Y = x;
                    break;
                case 2:
                    rgb.X = x;
                    rgb.Y = c;
                    break;
                case 3:
                    rgb.Y = c;
                    rgb.Z = x;
                    break;
                case 4:
                    rgb.Y = x;
                    rgb.Z = c;
                    break;
                case 5:
                    rgb.X = x;
                    rgb.Z = c;
                    break;
                case 6:
                    rgb.X = c;
                    rgb.Z = x;
                    break;
            }

            float m = v - c;
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
        [Pure]
        public static Color4<Hsva> ToHsva(this in Color3<Hsv> color, float alpha)
        {
            return new Color4<Hsva>(color.X, color.Y, color.Z, alpha);
        }

        /// <summary>
        /// Converts a color into <see cref="Hsv"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
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
        [Pure]
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
        [Pure]
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
        [Pure]
        public static Color3<Hsl> ToHsl(this in Color3<Rgb> color)
        {
            float r = color.X;
            float g = color.Y;
            float b = color.Z;

            float xMax = Math.Max(r, Math.Max(g, b));
            float xMin = Math.Min(r, Math.Min(g, b));
            float v = xMax;
            float c = xMax - Math.Min(r, Math.Min(g, b));
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

        /// <summary>
        /// Gets system color aliceblue corresponding to 240 248 255 (0.9411765, 0.972549, 1).
        /// </summary>
        public static Color3<Rgb> Aliceblue => new Color3<Rgb>(0.9411765f, 0.972549f, 1f);

        /// <summary>
        /// Gets system color antiquewhite corresponding to 250 235 215 (0.98039216, 0.92156863, 0.84313726).
        /// </summary>
        public static Color3<Rgb> Antiquewhite => new Color3<Rgb>(0.98039216f, 0.92156863f, 0.84313726f);

        /// <summary>
        /// Gets system color aqua corresponding to 0 255 255 (0, 1, 1).
        /// </summary>
        public static Color3<Rgb> Aqua => new Color3<Rgb>(0f, 1f, 1f);

        /// <summary>
        /// Gets system color aquamarine corresponding to 127 255 212 (0.49803922, 1, 0.83137256).
        /// </summary>
        public static Color3<Rgb> Aquamarine => new Color3<Rgb>(0.49803922f, 1f, 0.83137256f);

        /// <summary>
        /// Gets system color azure corresponding to 240 255 255 (0.9411765, 1, 1).
        /// </summary>
        public static Color3<Rgb> Azure => new Color3<Rgb>(0.9411765f, 1f, 1f);

        /// <summary>
        /// Gets system color beige corresponding to 245 245 220 (0.9607843, 0.9607843, 0.8627451).
        /// </summary>
        public static Color3<Rgb> Beige => new Color3<Rgb>(0.9607843f, 0.9607843f, 0.8627451f);

        /// <summary>
        /// Gets system color bisque corresponding to 255 228 196 (1, 0.89411765, 0.76862746).
        /// </summary>
        public static Color3<Rgb> Bisque => new Color3<Rgb>(1f, 0.89411765f, 0.76862746f);

        /// <summary>
        /// Gets system color black corresponding to 0 0 0 (0, 0, 0).
        /// </summary>
        public static Color3<Rgb> Black => new Color3<Rgb>(0f, 0f, 0f);

        /// <summary>
        /// Gets system color blanchedalmond corresponding to 255 235 205 (1, 0.92156863, 0.8039216).
        /// </summary>
        public static Color3<Rgb> Blanchedalmond => new Color3<Rgb>(1f, 0.92156863f, 0.8039216f);

        /// <summary>
        /// Gets system color blue corresponding to 0 0 255 (0, 0, 1).
        /// </summary>
        public static Color3<Rgb> Blue => new Color3<Rgb>(0f, 0f, 1f);

        /// <summary>
        /// Gets system color blueviolet corresponding to 138 43 226 (0.5411765, 0.16862746, 0.8862745).
        /// </summary>
        public static Color3<Rgb> Blueviolet => new Color3<Rgb>(0.5411765f, 0.16862746f, 0.8862745f);

        /// <summary>
        /// Gets system color brown corresponding to 165 42 42 (0.64705884, 0.16470589, 0.16470589).
        /// </summary>
        public static Color3<Rgb> Brown => new Color3<Rgb>(0.64705884f, 0.16470589f, 0.16470589f);

        /// <summary>
        /// Gets system color burlywood corresponding to 222 184 135 (0.87058824, 0.72156864, 0.5294118).
        /// </summary>
        public static Color3<Rgb> Burlywood => new Color3<Rgb>(0.87058824f, 0.72156864f, 0.5294118f);

        /// <summary>
        /// Gets system color cadetblue corresponding to 95 158 160 (0.37254903, 0.61960787, 0.627451).
        /// </summary>
        public static Color3<Rgb> Cadetblue => new Color3<Rgb>(0.37254903f, 0.61960787f, 0.627451f);

        /// <summary>
        /// Gets system color chartreuse corresponding to 127 255 0 (0.49803922, 1, 0).
        /// </summary>
        public static Color3<Rgb> Chartreuse => new Color3<Rgb>(0.49803922f, 1f, 0f);

        /// <summary>
        /// Gets system color chocolate corresponding to 210 105 30 (0.8235294, 0.4117647, 0.11764706).
        /// </summary>
        public static Color3<Rgb> Chocolate => new Color3<Rgb>(0.8235294f, 0.4117647f, 0.11764706f);

        /// <summary>
        /// Gets system color coral corresponding to 255 127 80 (1, 0.49803922, 0.3137255).
        /// </summary>
        public static Color3<Rgb> Coral => new Color3<Rgb>(1f, 0.49803922f, 0.3137255f);

        /// <summary>
        /// Gets system color cornflowerblue corresponding to 100 149 237 (0.39215687, 0.58431375, 0.92941177).
        /// </summary>
        public static Color3<Rgb> Cornflowerblue => new Color3<Rgb>(0.39215687f, 0.58431375f, 0.92941177f);

        /// <summary>
        /// Gets system color cornsilk corresponding to 255 248 220 (1, 0.972549, 0.8627451).
        /// </summary>
        public static Color3<Rgb> Cornsilk => new Color3<Rgb>(1f, 0.972549f, 0.8627451f);

        /// <summary>
        /// Gets system color crimson corresponding to 220 20 60 (0.8627451, 0.078431375, 0.23529412).
        /// </summary>
        public static Color3<Rgb> Crimson => new Color3<Rgb>(0.8627451f, 0.078431375f, 0.23529412f);

        /// <summary>
        /// Gets system color cyan corresponding to 0 255 255 (0, 1, 1).
        /// </summary>
        public static Color3<Rgb> Cyan => new Color3<Rgb>(0f, 1f, 1f);

        /// <summary>
        /// Gets system color darkblue corresponding to 0 0 139 (0, 0, 0.54509807).
        /// </summary>
        public static Color3<Rgb> Darkblue => new Color3<Rgb>(0f, 0f, 0.54509807f);

        /// <summary>
        /// Gets system color darkcyan corresponding to 0 139 139 (0, 0.54509807, 0.54509807).
        /// </summary>
        public static Color3<Rgb> Darkcyan => new Color3<Rgb>(0f, 0.54509807f, 0.54509807f);

        /// <summary>
        /// Gets system color darkgoldenrod corresponding to 184 134 11 (0.72156864, 0.5254902, 0.043137256).
        /// </summary>
        public static Color3<Rgb> Darkgoldenrod => new Color3<Rgb>(0.72156864f, 0.5254902f, 0.043137256f);

        /// <summary>
        /// Gets system color darkgray corresponding to 169 169 169 (0.6627451, 0.6627451, 0.6627451).
        /// </summary>
        public static Color3<Rgb> Darkgray => new Color3<Rgb>(0.6627451f, 0.6627451f, 0.6627451f);

        /// <summary>
        /// Gets system color darkgreen corresponding to 0 100 0 (0, 0.39215687, 0).
        /// </summary>
        public static Color3<Rgb> Darkgreen => new Color3<Rgb>(0f, 0.39215687f, 0f);

        /// <summary>
        /// Gets system color darkkhaki corresponding to 189 183 107 (0.7411765, 0.7176471, 0.41960785).
        /// </summary>
        public static Color3<Rgb> Darkkhaki => new Color3<Rgb>(0.7411765f, 0.7176471f, 0.41960785f);

        /// <summary>
        /// Gets system color darkmagenta corresponding to 139 0 139 (0.54509807, 0, 0.54509807).
        /// </summary>
        public static Color3<Rgb> Darkmagenta => new Color3<Rgb>(0.54509807f, 0f, 0.54509807f);

        /// <summary>
        /// Gets system color darkolivegreen corresponding to 85 107 47 (0.33333334, 0.41960785, 0.18431373).
        /// </summary>
        public static Color3<Rgb> Darkolivegreen => new Color3<Rgb>(0.33333334f, 0.41960785f, 0.18431373f);

        /// <summary>
        /// Gets system color darkorange corresponding to 255 140 0 (1, 0.54901963, 0).
        /// </summary>
        public static Color3<Rgb> Darkorange => new Color3<Rgb>(1f, 0.54901963f, 0f);

        /// <summary>
        /// Gets system color darkorchid corresponding to 153 50 204 (0.6, 0.19607843, 0.8).
        /// </summary>
        public static Color3<Rgb> Darkorchid => new Color3<Rgb>(0.6f, 0.19607843f, 0.8f);

        /// <summary>
        /// Gets system color darkred corresponding to 139 0 0 (0.54509807, 0, 0).
        /// </summary>
        public static Color3<Rgb> Darkred => new Color3<Rgb>(0.54509807f, 0f, 0f);

        /// <summary>
        /// Gets system color darksalmon corresponding to 233 150 122 (0.9137255, 0.5882353, 0.47843137).
        /// </summary>
        public static Color3<Rgb> Darksalmon => new Color3<Rgb>(0.9137255f, 0.5882353f, 0.47843137f);

        /// <summary>
        /// Gets system color darkseagreen corresponding to 143 188 139 (0.56078434, 0.7372549, 0.54509807).
        /// </summary>
        public static Color3<Rgb> Darkseagreen => new Color3<Rgb>(0.56078434f, 0.7372549f, 0.54509807f);

        /// <summary>
        /// Gets system color darkslateblue corresponding to 72 61 139 (0.28235295, 0.23921569, 0.54509807).
        /// </summary>
        public static Color3<Rgb> Darkslateblue => new Color3<Rgb>(0.28235295f, 0.23921569f, 0.54509807f);

        /// <summary>
        /// Gets system color darkslategray corresponding to 47 79 79 (0.18431373, 0.30980393, 0.30980393).
        /// </summary>
        public static Color3<Rgb> Darkslategray => new Color3<Rgb>(0.18431373f, 0.30980393f, 0.30980393f);

        /// <summary>
        /// Gets system color darkturquoise corresponding to 0 206 209 (0, 0.80784315, 0.81960785).
        /// </summary>
        public static Color3<Rgb> Darkturquoise => new Color3<Rgb>(0f, 0.80784315f, 0.81960785f);

        /// <summary>
        /// Gets system color darkviolet corresponding to 148 0 211 (0.5803922, 0, 0.827451).
        /// </summary>
        public static Color3<Rgb> Darkviolet => new Color3<Rgb>(0.5803922f, 0f, 0.827451f);

        /// <summary>
        /// Gets system color deeppink corresponding to 255 20 147 (1, 0.078431375, 0.5764706).
        /// </summary>
        public static Color3<Rgb> Deeppink => new Color3<Rgb>(1f, 0.078431375f, 0.5764706f);

        /// <summary>
        /// Gets system color deepskyblue corresponding to 0 191 255 (0, 0.7490196, 1).
        /// </summary>
        public static Color3<Rgb> Deepskyblue => new Color3<Rgb>(0f, 0.7490196f, 1f);

        /// <summary>
        /// Gets system color dimgray corresponding to 105 105 105 (0.4117647, 0.4117647, 0.4117647).
        /// </summary>
        public static Color3<Rgb> Dimgray => new Color3<Rgb>(0.4117647f, 0.4117647f, 0.4117647f);

        /// <summary>
        /// Gets system color dodgerblue corresponding to 30 144 255 (0.11764706, 0.5647059, 1).
        /// </summary>
        public static Color3<Rgb> Dodgerblue => new Color3<Rgb>(0.11764706f, 0.5647059f, 1f);

        /// <summary>
        /// Gets system color firebrick corresponding to 178 34 34 (0.69803923, 0.13333334, 0.13333334).
        /// </summary>
        public static Color3<Rgb> Firebrick => new Color3<Rgb>(0.69803923f, 0.13333334f, 0.13333334f);

        /// <summary>
        /// Gets system color floralwhite corresponding to 255 250 240 (1, 0.98039216, 0.9411765).
        /// </summary>
        public static Color3<Rgb> Floralwhite => new Color3<Rgb>(1f, 0.98039216f, 0.9411765f);

        /// <summary>
        /// Gets system color forestgreen corresponding to 34 139 34 (0.13333334, 0.54509807, 0.13333334).
        /// </summary>
        public static Color3<Rgb> Forestgreen => new Color3<Rgb>(0.13333334f, 0.54509807f, 0.13333334f);

        /// <summary>
        /// Gets system color fuchsia corresponding to 255 0 255 (1, 0, 1).
        /// </summary>
        public static Color3<Rgb> Fuchsia => new Color3<Rgb>(1f, 0f, 1f);

        /// <summary>
        /// Gets system color gainsboro corresponding to 220 220 220 (0.8627451, 0.8627451, 0.8627451).
        /// </summary>
        public static Color3<Rgb> Gainsboro => new Color3<Rgb>(0.8627451f, 0.8627451f, 0.8627451f);

        /// <summary>
        /// Gets system color ghostwhite corresponding to 248 248 255 (0.972549, 0.972549, 1).
        /// </summary>
        public static Color3<Rgb> Ghostwhite => new Color3<Rgb>(0.972549f, 0.972549f, 1f);

        /// <summary>
        /// Gets system color gold corresponding to 255 215 0 (1, 0.84313726, 0).
        /// </summary>
        public static Color3<Rgb> Gold => new Color3<Rgb>(1f, 0.84313726f, 0f);

        /// <summary>
        /// Gets system color goldenrod corresponding to 218 165 32 (0.85490197, 0.64705884, 0.1254902).
        /// </summary>
        public static Color3<Rgb> Goldenrod => new Color3<Rgb>(0.85490197f, 0.64705884f, 0.1254902f);

        /// <summary>
        /// Gets system color gray corresponding to 128 128 128 (0.5019608, 0.5019608, 0.5019608).
        /// </summary>
        public static Color3<Rgb> Gray => new Color3<Rgb>(0.5019608f, 0.5019608f, 0.5019608f);

        /// <summary>
        /// Gets system color green corresponding to 0 128 0 (0, 0.5019608, 0).
        /// </summary>
        public static Color3<Rgb> Green => new Color3<Rgb>(0f, 0.5019608f, 0f);

        /// <summary>
        /// Gets system color greenyellow corresponding to 173 255 47 (0.6784314, 1, 0.18431373).
        /// </summary>
        public static Color3<Rgb> Greenyellow => new Color3<Rgb>(0.6784314f, 1f, 0.18431373f);

        /// <summary>
        /// Gets system color honeydew corresponding to 240 255 240 (0.9411765, 1, 0.9411765).
        /// </summary>
        public static Color3<Rgb> Honeydew => new Color3<Rgb>(0.9411765f, 1f, 0.9411765f);

        /// <summary>
        /// Gets system color hotpink corresponding to 255 105 180 (1, 0.4117647, 0.7058824).
        /// </summary>
        public static Color3<Rgb> Hotpink => new Color3<Rgb>(1f, 0.4117647f, 0.7058824f);

        /// <summary>
        /// Gets system color indianred corresponding to 205 92 92 (0.8039216, 0.36078432, 0.36078432).
        /// </summary>
        public static Color3<Rgb> Indianred => new Color3<Rgb>(0.8039216f, 0.36078432f, 0.36078432f);

        /// <summary>
        /// Gets system color indigo corresponding to 75 0 130 (0.29411766, 0, 0.50980395).
        /// </summary>
        public static Color3<Rgb> Indigo => new Color3<Rgb>(0.29411766f, 0f, 0.50980395f);

        /// <summary>
        /// Gets system color ivory corresponding to 255 255 240 (1, 1, 0.9411765).
        /// </summary>
        public static Color3<Rgb> Ivory => new Color3<Rgb>(1f, 1f, 0.9411765f);

        /// <summary>
        /// Gets system color khaki corresponding to 240 230 140 (0.9411765, 0.9019608, 0.54901963).
        /// </summary>
        public static Color3<Rgb> Khaki => new Color3<Rgb>(0.9411765f, 0.9019608f, 0.54901963f);

        /// <summary>
        /// Gets system color lavender corresponding to 230 230 250 (0.9019608, 0.9019608, 0.98039216).
        /// </summary>
        public static Color3<Rgb> Lavender => new Color3<Rgb>(0.9019608f, 0.9019608f, 0.98039216f);

        /// <summary>
        /// Gets system color lavenderblush corresponding to 255 240 245 (1, 0.9411765, 0.9607843).
        /// </summary>
        public static Color3<Rgb> Lavenderblush => new Color3<Rgb>(1f, 0.9411765f, 0.9607843f);

        /// <summary>
        /// Gets system color lawngreen corresponding to 124 252 0 (0.4862745, 0.9882353, 0).
        /// </summary>
        public static Color3<Rgb> Lawngreen => new Color3<Rgb>(0.4862745f, 0.9882353f, 0f);

        /// <summary>
        /// Gets system color lemonchiffon corresponding to 255 250 205 (1, 0.98039216, 0.8039216).
        /// </summary>
        public static Color3<Rgb> Lemonchiffon => new Color3<Rgb>(1f, 0.98039216f, 0.8039216f);

        /// <summary>
        /// Gets system color lightblue corresponding to 173 216 230 (0.6784314, 0.84705883, 0.9019608).
        /// </summary>
        public static Color3<Rgb> Lightblue => new Color3<Rgb>(0.6784314f, 0.84705883f, 0.9019608f);

        /// <summary>
        /// Gets system color lightcoral corresponding to 240 128 128 (0.9411765, 0.5019608, 0.5019608).
        /// </summary>
        public static Color3<Rgb> Lightcoral => new Color3<Rgb>(0.9411765f, 0.5019608f, 0.5019608f);

        /// <summary>
        /// Gets system color lightcyan corresponding to 224 255 255 (0.8784314, 1, 1).
        /// </summary>
        public static Color3<Rgb> Lightcyan => new Color3<Rgb>(0.8784314f, 1f, 1f);

        /// <summary>
        /// Gets system color lightgoldenrodyellow corresponding to 250 250 210 (0.98039216, 0.98039216, 0.8235294).
        /// </summary>
        public static Color3<Rgb> Lightgoldenrodyellow => new Color3<Rgb>(0.98039216f, 0.98039216f, 0.8235294f);

        /// <summary>
        /// Gets system color lightgray corresponding to 211 211 211 (0.827451, 0.827451, 0.827451).
        /// </summary>
        public static Color3<Rgb> Lightgray => new Color3<Rgb>(0.827451f, 0.827451f, 0.827451f);

        /// <summary>
        /// Gets system color lightgreen corresponding to 144 238 144 (0.5647059, 0.93333334, 0.5647059).
        /// </summary>
        public static Color3<Rgb> Lightgreen => new Color3<Rgb>(0.5647059f, 0.93333334f, 0.5647059f);

        /// <summary>
        /// Gets system color lightpink corresponding to 255 182 193 (1, 0.7137255, 0.75686276).
        /// </summary>
        public static Color3<Rgb> Lightpink => new Color3<Rgb>(1f, 0.7137255f, 0.75686276f);

        /// <summary>
        /// Gets system color lightsalmon corresponding to 255 160 122 (1, 0.627451, 0.47843137).
        /// </summary>
        public static Color3<Rgb> Lightsalmon => new Color3<Rgb>(1f, 0.627451f, 0.47843137f);

        /// <summary>
        /// Gets system color lightseagreen corresponding to 32 178 170 (0.1254902, 0.69803923, 0.6666667).
        /// </summary>
        public static Color3<Rgb> Lightseagreen => new Color3<Rgb>(0.1254902f, 0.69803923f, 0.6666667f);

        /// <summary>
        /// Gets system color lightskyblue corresponding to 135 206 250 (0.5294118, 0.80784315, 0.98039216).
        /// </summary>
        public static Color3<Rgb> Lightskyblue => new Color3<Rgb>(0.5294118f, 0.80784315f, 0.98039216f);

        /// <summary>
        /// Gets system color lightslategray corresponding to 119 136 153 (0.46666667, 0.53333336, 0.6).
        /// </summary>
        public static Color3<Rgb> Lightslategray => new Color3<Rgb>(0.46666667f, 0.53333336f, 0.6f);

        /// <summary>
        /// Gets system color lightsteelblue corresponding to 176 196 222 (0.6901961, 0.76862746, 0.87058824).
        /// </summary>
        public static Color3<Rgb> Lightsteelblue => new Color3<Rgb>(0.6901961f, 0.76862746f, 0.87058824f);

        /// <summary>
        /// Gets system color lightyellow corresponding to 255 255 224 (1, 1, 0.8784314).
        /// </summary>
        public static Color3<Rgb> Lightyellow => new Color3<Rgb>(1f, 1f, 0.8784314f);

        /// <summary>
        /// Gets system color lime corresponding to 0 255 0 (0, 1, 0).
        /// </summary>
        public static Color3<Rgb> Lime => new Color3<Rgb>(0f, 1f, 0f);

        /// <summary>
        /// Gets system color limegreen corresponding to 50 205 50 (0.19607843, 0.8039216, 0.19607843).
        /// </summary>
        public static Color3<Rgb> Limegreen => new Color3<Rgb>(0.19607843f, 0.8039216f, 0.19607843f);

        /// <summary>
        /// Gets system color linen corresponding to 250 240 230 (0.98039216, 0.9411765, 0.9019608).
        /// </summary>
        public static Color3<Rgb> Linen => new Color3<Rgb>(0.98039216f, 0.9411765f, 0.9019608f);

        /// <summary>
        /// Gets system color magenta corresponding to 255 0 255 (1, 0, 1).
        /// </summary>
        public static Color3<Rgb> Magenta => new Color3<Rgb>(1f, 0f, 1f);

        /// <summary>
        /// Gets system color maroon corresponding to 128 0 0 (0.5019608, 0, 0).
        /// </summary>
        public static Color3<Rgb> Maroon => new Color3<Rgb>(0.5019608f, 0f, 0f);

        /// <summary>
        /// Gets system color mediumaquamarine corresponding to 102 205 170 (0.4, 0.8039216, 0.6666667).
        /// </summary>
        public static Color3<Rgb> Mediumaquamarine => new Color3<Rgb>(0.4f, 0.8039216f, 0.6666667f);

        /// <summary>
        /// Gets system color mediumblue corresponding to 0 0 205 (0, 0, 0.8039216).
        /// </summary>
        public static Color3<Rgb> Mediumblue => new Color3<Rgb>(0f, 0f, 0.8039216f);

        /// <summary>
        /// Gets system color mediumorchid corresponding to 186 85 211 (0.7294118, 0.33333334, 0.827451).
        /// </summary>
        public static Color3<Rgb> Mediumorchid => new Color3<Rgb>(0.7294118f, 0.33333334f, 0.827451f);

        /// <summary>
        /// Gets system color mediumpurple corresponding to 147 112 219 (0.5764706, 0.4392157, 0.85882354).
        /// </summary>
        public static Color3<Rgb> Mediumpurple => new Color3<Rgb>(0.5764706f, 0.4392157f, 0.85882354f);

        /// <summary>
        /// Gets system color mediumseagreen corresponding to 60 179 113 (0.23529412, 0.7019608, 0.44313726).
        /// </summary>
        public static Color3<Rgb> Mediumseagreen => new Color3<Rgb>(0.23529412f, 0.7019608f, 0.44313726f);

        /// <summary>
        /// Gets system color mediumslateblue corresponding to 123 104 238 (0.48235294, 0.40784314, 0.93333334).
        /// </summary>
        public static Color3<Rgb> Mediumslateblue => new Color3<Rgb>(0.48235294f, 0.40784314f, 0.93333334f);

        /// <summary>
        /// Gets system color mediumspringgreen corresponding to 0 250 154 (0, 0.98039216, 0.6039216).
        /// </summary>
        public static Color3<Rgb> Mediumspringgreen => new Color3<Rgb>(0f, 0.98039216f, 0.6039216f);

        /// <summary>
        /// Gets system color mediumturquoise corresponding to 72 209 204 (0.28235295, 0.81960785, 0.8).
        /// </summary>
        public static Color3<Rgb> Mediumturquoise => new Color3<Rgb>(0.28235295f, 0.81960785f, 0.8f);

        /// <summary>
        /// Gets system color mediumvioletred corresponding to 199 21 133 (0.78039217, 0.08235294, 0.52156866).
        /// </summary>
        public static Color3<Rgb> Mediumvioletred => new Color3<Rgb>(0.78039217f, 0.08235294f, 0.52156866f);

        /// <summary>
        /// Gets system color midnightblue corresponding to 25 25 112 (0.09803922, 0.09803922, 0.4392157).
        /// </summary>
        public static Color3<Rgb> Midnightblue => new Color3<Rgb>(0.09803922f, 0.09803922f, 0.4392157f);

        /// <summary>
        /// Gets system color mintcream corresponding to 245 255 250 (0.9607843, 1, 0.98039216).
        /// </summary>
        public static Color3<Rgb> Mintcream => new Color3<Rgb>(0.9607843f, 1f, 0.98039216f);

        /// <summary>
        /// Gets system color mistyrose corresponding to 255 228 225 (1, 0.89411765, 0.88235295).
        /// </summary>
        public static Color3<Rgb> Mistyrose => new Color3<Rgb>(1f, 0.89411765f, 0.88235295f);

        /// <summary>
        /// Gets system color moccasin corresponding to 255 228 181 (1, 0.89411765, 0.70980394).
        /// </summary>
        public static Color3<Rgb> Moccasin => new Color3<Rgb>(1f, 0.89411765f, 0.70980394f);

        /// <summary>
        /// Gets system color navajowhite corresponding to 255 222 173 (1, 0.87058824, 0.6784314).
        /// </summary>
        public static Color3<Rgb> Navajowhite => new Color3<Rgb>(1f, 0.87058824f, 0.6784314f);

        /// <summary>
        /// Gets system color navy corresponding to 0 0 128 (0, 0, 0.5019608).
        /// </summary>
        public static Color3<Rgb> Navy => new Color3<Rgb>(0f, 0f, 0.5019608f);

        /// <summary>
        /// Gets system color oldlace corresponding to 253 245 230 (0.99215686, 0.9607843, 0.9019608).
        /// </summary>
        public static Color3<Rgb> Oldlace => new Color3<Rgb>(0.99215686f, 0.9607843f, 0.9019608f);

        /// <summary>
        /// Gets system color olive corresponding to 128 128 0 (0.5019608, 0.5019608, 0).
        /// </summary>
        public static Color3<Rgb> Olive => new Color3<Rgb>(0.5019608f, 0.5019608f, 0f);

        /// <summary>
        /// Gets system color olivedrab corresponding to 107 142 35 (0.41960785, 0.5568628, 0.13725491).
        /// </summary>
        public static Color3<Rgb> Olivedrab => new Color3<Rgb>(0.41960785f, 0.5568628f, 0.13725491f);

        /// <summary>
        /// Gets system color orange corresponding to 255 165 0 (1, 0.64705884, 0).
        /// </summary>
        public static Color3<Rgb> Orange => new Color3<Rgb>(1f, 0.64705884f, 0f);

        /// <summary>
        /// Gets system color orangered corresponding to 255 69 0 (1, 0.27058825, 0).
        /// </summary>
        public static Color3<Rgb> Orangered => new Color3<Rgb>(1f, 0.27058825f, 0f);

        /// <summary>
        /// Gets system color orchid corresponding to 218 112 214 (0.85490197, 0.4392157, 0.8392157).
        /// </summary>
        public static Color3<Rgb> Orchid => new Color3<Rgb>(0.85490197f, 0.4392157f, 0.8392157f);

        /// <summary>
        /// Gets system color palegoldenrod corresponding to 238 232 170 (0.93333334, 0.9098039, 0.6666667).
        /// </summary>
        public static Color3<Rgb> Palegoldenrod => new Color3<Rgb>(0.93333334f, 0.9098039f, 0.6666667f);

        /// <summary>
        /// Gets system color palegreen corresponding to 152 251 152 (0.59607846, 0.9843137, 0.59607846).
        /// </summary>
        public static Color3<Rgb> Palegreen => new Color3<Rgb>(0.59607846f, 0.9843137f, 0.59607846f);

        /// <summary>
        /// Gets system color paleturquoise corresponding to 175 238 238 (0.6862745, 0.93333334, 0.93333334).
        /// </summary>
        public static Color3<Rgb> Paleturquoise => new Color3<Rgb>(0.6862745f, 0.93333334f, 0.93333334f);

        /// <summary>
        /// Gets system color palevioletred corresponding to 219 112 147 (0.85882354, 0.4392157, 0.5764706).
        /// </summary>
        public static Color3<Rgb> Palevioletred => new Color3<Rgb>(0.85882354f, 0.4392157f, 0.5764706f);

        /// <summary>
        /// Gets system color papayawhip corresponding to 255 239 213 (1, 0.9372549, 0.8352941).
        /// </summary>
        public static Color3<Rgb> Papayawhip => new Color3<Rgb>(1f, 0.9372549f, 0.8352941f);

        /// <summary>
        /// Gets system color peachpuff corresponding to 255 218 185 (1, 0.85490197, 0.7254902).
        /// </summary>
        public static Color3<Rgb> Peachpuff => new Color3<Rgb>(1f, 0.85490197f, 0.7254902f);

        /// <summary>
        /// Gets system color peru corresponding to 205 133 63 (0.8039216, 0.52156866, 0.24705882).
        /// </summary>
        public static Color3<Rgb> Peru => new Color3<Rgb>(0.8039216f, 0.52156866f, 0.24705882f);

        /// <summary>
        /// Gets system color pink corresponding to 255 192 203 (1, 0.7529412, 0.79607844).
        /// </summary>
        public static Color3<Rgb> Pink => new Color3<Rgb>(1f, 0.7529412f, 0.79607844f);

        /// <summary>
        /// Gets system color plum corresponding to 221 160 221 (0.8666667, 0.627451, 0.8666667).
        /// </summary>
        public static Color3<Rgb> Plum => new Color3<Rgb>(0.8666667f, 0.627451f, 0.8666667f);

        /// <summary>
        /// Gets system color powderblue corresponding to 176 224 230 (0.6901961, 0.8784314, 0.9019608).
        /// </summary>
        public static Color3<Rgb> Powderblue => new Color3<Rgb>(0.6901961f, 0.8784314f, 0.9019608f);

        /// <summary>
        /// Gets system color purple corresponding to 128 0 128 (0.5019608, 0, 0.5019608).
        /// </summary>
        public static Color3<Rgb> Purple => new Color3<Rgb>(0.5019608f, 0f, 0.5019608f);

        /// <summary>
        /// Gets system color red corresponding to 255 0 0 (1, 0, 0).
        /// </summary>
        public static Color3<Rgb> Red => new Color3<Rgb>(1f, 0f, 0f);

        /// <summary>
        /// Gets system color rosybrown corresponding to 188 143 143 (0.7372549, 0.56078434, 0.56078434).
        /// </summary>
        public static Color3<Rgb> Rosybrown => new Color3<Rgb>(0.7372549f, 0.56078434f, 0.56078434f);

        /// <summary>
        /// Gets system color royalblue corresponding to 65 105 225 (0.25490198, 0.4117647, 0.88235295).
        /// </summary>
        public static Color3<Rgb> Royalblue => new Color3<Rgb>(0.25490198f, 0.4117647f, 0.88235295f);

        /// <summary>
        /// Gets system color saddlebrown corresponding to 139 69 19 (0.54509807, 0.27058825, 0.07450981).
        /// </summary>
        public static Color3<Rgb> Saddlebrown => new Color3<Rgb>(0.54509807f, 0.27058825f, 0.07450981f);

        /// <summary>
        /// Gets system color salmon corresponding to 250 128 114 (0.98039216, 0.5019608, 0.44705883).
        /// </summary>
        public static Color3<Rgb> Salmon => new Color3<Rgb>(0.98039216f, 0.5019608f, 0.44705883f);

        /// <summary>
        /// Gets system color sandybrown corresponding to 244 164 96 (0.95686275, 0.6431373, 0.3764706).
        /// </summary>
        public static Color3<Rgb> Sandybrown => new Color3<Rgb>(0.95686275f, 0.6431373f, 0.3764706f);

        /// <summary>
        /// Gets system color seagreen corresponding to 46 139 87 (0.18039216, 0.54509807, 0.34117648).
        /// </summary>
        public static Color3<Rgb> Seagreen => new Color3<Rgb>(0.18039216f, 0.54509807f, 0.34117648f);

        /// <summary>
        /// Gets system color seashell corresponding to 255 245 238 (1, 0.9607843, 0.93333334).
        /// </summary>
        public static Color3<Rgb> Seashell => new Color3<Rgb>(1f, 0.9607843f, 0.93333334f);

        /// <summary>
        /// Gets system color sienna corresponding to 160 82 45 (0.627451, 0.32156864, 0.1764706).
        /// </summary>
        public static Color3<Rgb> Sienna => new Color3<Rgb>(0.627451f, 0.32156864f, 0.1764706f);

        /// <summary>
        /// Gets system color silver corresponding to 192 192 192 (0.7529412, 0.7529412, 0.7529412).
        /// </summary>
        public static Color3<Rgb> Silver => new Color3<Rgb>(0.7529412f, 0.7529412f, 0.7529412f);

        /// <summary>
        /// Gets system color skyblue corresponding to 135 206 235 (0.5294118, 0.80784315, 0.92156863).
        /// </summary>
        public static Color3<Rgb> Skyblue => new Color3<Rgb>(0.5294118f, 0.80784315f, 0.92156863f);

        /// <summary>
        /// Gets system color slateblue corresponding to 106 90 205 (0.41568628, 0.3529412, 0.8039216).
        /// </summary>
        public static Color3<Rgb> Slateblue => new Color3<Rgb>(0.41568628f, 0.3529412f, 0.8039216f);

        /// <summary>
        /// Gets system color slategray corresponding to 112 128 144 (0.4392157, 0.5019608, 0.5647059).
        /// </summary>
        public static Color3<Rgb> Slategray => new Color3<Rgb>(0.4392157f, 0.5019608f, 0.5647059f);

        /// <summary>
        /// Gets system color snow corresponding to 255 250 250 (1, 0.98039216, 0.98039216).
        /// </summary>
        public static Color3<Rgb> Snow => new Color3<Rgb>(1f, 0.98039216f, 0.98039216f);

        /// <summary>
        /// Gets system color springgreen corresponding to 0 255 127 (0, 1, 0.49803922).
        /// </summary>
        public static Color3<Rgb> Springgreen => new Color3<Rgb>(0f, 1f, 0.49803922f);

        /// <summary>
        /// Gets system color steelblue corresponding to 70 130 180 (0.27450982, 0.50980395, 0.7058824).
        /// </summary>
        public static Color3<Rgb> Steelblue => new Color3<Rgb>(0.27450982f, 0.50980395f, 0.7058824f);

        /// <summary>
        /// Gets system color tan corresponding to 210 180 140 (0.8235294, 0.7058824, 0.54901963).
        /// </summary>
        public static Color3<Rgb> Tan => new Color3<Rgb>(0.8235294f, 0.7058824f, 0.54901963f);

        /// <summary>
        /// Gets system color teal corresponding to 0 128 128 (0, 0.5019608, 0.5019608).
        /// </summary>
        public static Color3<Rgb> Teal => new Color3<Rgb>(0f, 0.5019608f, 0.5019608f);

        /// <summary>
        /// Gets system color thistle corresponding to 216 191 216 (0.84705883, 0.7490196, 0.84705883).
        /// </summary>
        public static Color3<Rgb> Thistle => new Color3<Rgb>(0.84705883f, 0.7490196f, 0.84705883f);

        /// <summary>
        /// Gets system color tomato corresponding to 255 99 71 (1, 0.3882353, 0.2784314).
        /// </summary>
        public static Color3<Rgb> Tomato => new Color3<Rgb>(1f, 0.3882353f, 0.2784314f);

        /// <summary>
        /// Gets system color turquoise corresponding to 64 224 208 (0.2509804, 0.8784314, 0.8156863).
        /// </summary>
        public static Color3<Rgb> Turquoise => new Color3<Rgb>(0.2509804f, 0.8784314f, 0.8156863f);

        /// <summary>
        /// Gets system color violet corresponding to 238 130 238 (0.93333334, 0.50980395, 0.93333334).
        /// </summary>
        public static Color3<Rgb> Violet => new Color3<Rgb>(0.93333334f, 0.50980395f, 0.93333334f);

        /// <summary>
        /// Gets system color wheat corresponding to 245 222 179 (0.9607843, 0.87058824, 0.7019608).
        /// </summary>
        public static Color3<Rgb> Wheat => new Color3<Rgb>(0.9607843f, 0.87058824f, 0.7019608f);

        /// <summary>
        /// Gets system color white corresponding to 255 255 255 (1, 1, 1).
        /// </summary>
        public static Color3<Rgb> White => new Color3<Rgb>(1f, 1f, 1f);

        /// <summary>
        /// Gets system color whitesmoke corresponding to 245 245 245 (0.9607843, 0.9607843, 0.9607843).
        /// </summary>
        public static Color3<Rgb> Whitesmoke => new Color3<Rgb>(0.9607843f, 0.9607843f, 0.9607843f);

        /// <summary>
        /// Gets system color yellow corresponding to 255 255 0 (1, 1, 0).
        /// </summary>
        public static Color3<Rgb> Yellow => new Color3<Rgb>(1f, 1f, 0f);

        /// <summary>
        /// Gets system color yellowgreen corresponding to 154 205 50 (0.6039216, 0.8039216, 0.19607843).
        /// </summary>
        public static Color3<Rgb> Yellowgreen => new Color3<Rgb>(0.6039216f, 0.8039216f, 0.19607843f);
    }
}
#pragma warning restore SA1649
