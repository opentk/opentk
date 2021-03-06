using System;
using System.Diagnostics.Contracts;
using OpenTK.Mathematics;

#pragma warning disable SA1649
namespace OpenTK.Mathematics
{
    /// <summary>
    /// Interface for ColorSpace phantom types with 4 elements.
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
    /// To provide type-safety between different color spaces and allow extension by users to include additional and future color spaces, colors are marked with a special _phantom_ type parameter that indicates their color space.<br/>
    /// Typically these are four-letter abbreviations that indicate the components of the colors, such as <see cref="Rgba"/> or <see cref="Hsva"/>.<br/><br/>
    ///
    /// In any of these cases, letters in the color space correspond to the order of the components in the color vector. For example, color Rgba maps as follows:<br/>
    /// X -> R
    /// Y -> G
    /// Z -> B
    /// W -> A.
    /// </summary>
    /// <typeparam name="T">The color space of the given color.</typeparam>
    public struct Color4<T> : IEquatable<Color4<T>>
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
        [Pure]
        public static explicit operator Color4<T>(in Vector4 vec) => new Color4<T>(vec.X, vec.Y, vec.Z, vec.W);

        /// <summary>
        /// Instantiates a new <see cref="Vector4"/> from the X, Y, Z and W components of a <see cref="Color4{T}"/>.
        /// </summary>
        /// <param name="col">The color which the instantiated vector will use the X,Y,Z and W from, in that order.</param>
        /// <returns>The vector that was instantiated.</returns>
        [Pure]
        public static explicit operator Vector4(in Color4<T> col) => new Vector4(col.X, col.Y, col.Z, col.W);

        /// <summary>
        /// Deconstructs this color4 and turns it into a tuple containing 4 floats.
        /// </summary>
        /// <param name="x">The x component of this color, defined by the color space.</param>
        /// <param name="y">The y component of this color, defined by the color space.</param>
        /// <param name="z">The z component of this color, defined by the color space.</param>
        /// <param name="w">The w component of this color, defined by the color space.</param>
        [Pure]
        public void Deconstruct(out float x, out float y, out float z, out float w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }

        /// <summary>
        /// Compares the specified Color4 structures for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        [Pure]
        public static bool operator ==(in Color4<T> left, in Color4<T> right)
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
        public static bool operator !=(in Color4<T> left, in Color4<T> right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified Color4.
        /// </summary>
        /// <param name="other">The Color4 structure to compare to.</param>
        /// <returns>True if both Color4 structures contain the same components; false otherwise.</returns>
        [Pure]
        public bool Equals(Color4<T> other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z) && W.Equals(other.W);
        }

        /// <summary>
        /// Creates a <see cref="string"/> that describes this Color4 structure.
        /// </summary>
        /// <returns>A <see cref="string"/> that describes this Color4 structure.</returns>
        [Pure]
        public override string ToString()
        {
            return $"({X}, {Y}, {Z}, {W})";
        }

        /// <summary>
        /// Compares whether this Color4 structure is equal to the specified object.
        /// </summary>
        /// <param name="obj">An object to compare to.</param>
        /// <returns>True obj is a Color4 structure with the same components as this Color4; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            return obj is Color4<T> other && Equals(other);
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
                hashCode = (hashCode * 397) ^ W.GetHashCode();
                return hashCode;
            }
        }
    }

    /// <summary>
    /// Companion type for conversion between color types.
    /// </summary>
    public static class Color4
    {
        /// <summary>
        /// Adds all the elements of left to all the elements of right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by adding the two colors together.</returns>
        public static Color4<Rgba> Add(this in Color4<Rgba> left, in Color4<Rgba> right) =>
            new Color4<Rgba>(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);

        /// <summary>
        /// Subtracts all the elements of right from all the elements of left.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by subtracting all elements of right with all elements from left.</returns>
        public static Color4<Rgba> Subtract(this in Color4<Rgba> left, in Color4<Rgba> right) =>
            new Color4<Rgba>(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);

        /// <summary>
        /// Multiplies all the elements of left with all the elements of right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by multiplying the two colors together.</returns>
        public static Color4<Rgba> Multiply(this in Color4<Rgba> left, in Color4<Rgba> right) =>
            new Color4<Rgba>(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);

        /// <summary>
        /// Multiplies all the elements of left with right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by multiplying all elements of left with right.</returns>
        public static Color4<Rgba> Multiply(this in Color4<Rgba> left, in float right) =>
            new Color4<Rgba>(left.X * right, left.Y * right, left.Z * right, left.W * right);

        /// <summary>
        /// Divides all the elements of left with right.
        /// </summary>
        /// <param name="left">The left hand operand.</param>
        /// <param name="right">The right hand operand.</param>
        /// <returns>The element generated by dividing all elements of left with right.</returns>
        public static Color4<Rgba> Divide(this in Color4<Rgba> left, in float right) =>
            new Color4<Rgba>(left.X / right, left.Y / right, left.Z / right, left.W / right);

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color3<Rgb> ToRgb(this in Color4<Argb> color) =>
            new Color3<Rgb>(color.Y, color.Z, color.W);

        /// <summary>
        /// Converts a color into <see cref="Argb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Argb> ToArgb(this in Color4<Rgba> color) =>
            new Color4<Argb>(color.W, color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Rgb"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color3<Rgb> ToRgb(this in Color4<Rgba> color) =>
            new Color3<Rgb>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Rgba> ToRgba(this in Color4<Argb> color) =>
            new Color4<Rgba>(color.Y, color.Z, color.W, color.X);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Rgba> ToRgba(this in Color4<Hsva> color) =>
            color.ToHsv().ToRgb().ToRgba(color.W);

        /// <summary>
        /// Converts a color into <see cref="Rgba"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Rgba> ToRgba(this in Color4<Hsla> color) =>
            color.ToHsl().ToRgb().ToRgba(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsv"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color3<Hsv> ToHsv(this in Color4<Hsva> color) =>
            new Color3<Hsv>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Hsva"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Hsva> ToHsva(this in Color4<Rgba> color) =>
            color.ToRgb().ToHsv().ToHsva(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsva"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Hsva> ToHsva(this in Color4<Hsla> color) =>
            color.ToHsl().ToHsv().ToHsva(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsl"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color3<Hsl> ToHsl(this in Color4<Hsla> color) =>
            new Color3<Hsl>(color.X, color.Y, color.Z);

        /// <summary>
        /// Converts a color into <see cref="Hsla"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Hsla> ToHsla(this in Color4<Rgba> color) =>
            color.ToRgb().ToHsl().ToHsla(color.W);

        /// <summary>
        /// Converts a color into <see cref="Hsla"/> color space.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        [Pure]
        public static Color4<Hsla> ToHsla(this in Color4<Hsva> color) =>
            color.ToHsv().ToHsl().ToHsla(color.W);

        /// <summary>
        /// Gets system color aliceblue corresponding to 240 248 255 255 (0.9411765, 0.972549, 1, 1).
        /// </summary>
        public static Color4<Rgba> Aliceblue => new Color4<Rgba>(0.9411765f, 0.972549f, 1f, 1f);

        /// <summary>
        /// Gets system color antiquewhite corresponding to 250 235 215 255 (0.98039216, 0.92156863, 0.84313726, 1).
        /// </summary>
        public static Color4<Rgba> Antiquewhite => new Color4<Rgba>(0.98039216f, 0.92156863f, 0.84313726f, 1f);

        /// <summary>
        /// Gets system color aqua corresponding to 0 255 255 255 (0, 1, 1, 1).
        /// </summary>
        public static Color4<Rgba> Aqua => new Color4<Rgba>(0f, 1f, 1f, 1f);

        /// <summary>
        /// Gets system color aquamarine corresponding to 127 255 212 255 (0.49803922, 1, 0.83137256, 1).
        /// </summary>
        public static Color4<Rgba> Aquamarine => new Color4<Rgba>(0.49803922f, 1f, 0.83137256f, 1f);

        /// <summary>
        /// Gets system color azure corresponding to 240 255 255 255 (0.9411765, 1, 1, 1).
        /// </summary>
        public static Color4<Rgba> Azure => new Color4<Rgba>(0.9411765f, 1f, 1f, 1f);

        /// <summary>
        /// Gets system color beige corresponding to 245 245 220 255 (0.9607843, 0.9607843, 0.8627451, 1).
        /// </summary>
        public static Color4<Rgba> Beige => new Color4<Rgba>(0.9607843f, 0.9607843f, 0.8627451f, 1f);

        /// <summary>
        /// Gets system color bisque corresponding to 255 228 196 255 (1, 0.89411765, 0.76862746, 1).
        /// </summary>
        public static Color4<Rgba> Bisque => new Color4<Rgba>(1f, 0.89411765f, 0.76862746f, 1f);

        /// <summary>
        /// Gets system color black corresponding to 0 0 0 255 (0, 0, 0, 1).
        /// </summary>
        public static Color4<Rgba> Black => new Color4<Rgba>(0f, 0f, 0f, 1f);

        /// <summary>
        /// Gets system color blanchedalmond corresponding to 255 235 205 255 (1, 0.92156863, 0.8039216, 1).
        /// </summary>
        public static Color4<Rgba> Blanchedalmond => new Color4<Rgba>(1f, 0.92156863f, 0.8039216f, 1f);

        /// <summary>
        /// Gets system color blue corresponding to 0 0 255 255 (0, 0, 1, 1).
        /// </summary>
        public static Color4<Rgba> Blue => new Color4<Rgba>(0f, 0f, 1f, 1f);

        /// <summary>
        /// Gets system color blueviolet corresponding to 138 43 226 255 (0.5411765, 0.16862746, 0.8862745, 1).
        /// </summary>
        public static Color4<Rgba> Blueviolet => new Color4<Rgba>(0.5411765f, 0.16862746f, 0.8862745f, 1f);

        /// <summary>
        /// Gets system color brown corresponding to 165 42 42 255 (0.64705884, 0.16470589, 0.16470589, 1).
        /// </summary>
        public static Color4<Rgba> Brown => new Color4<Rgba>(0.64705884f, 0.16470589f, 0.16470589f, 1f);

        /// <summary>
        /// Gets system color burlywood corresponding to 222 184 135 255 (0.87058824, 0.72156864, 0.5294118, 1).
        /// </summary>
        public static Color4<Rgba> Burlywood => new Color4<Rgba>(0.87058824f, 0.72156864f, 0.5294118f, 1f);

        /// <summary>
        /// Gets system color cadetblue corresponding to 95 158 160 255 (0.37254903, 0.61960787, 0.627451, 1).
        /// </summary>
        public static Color4<Rgba> Cadetblue => new Color4<Rgba>(0.37254903f, 0.61960787f, 0.627451f, 1f);

        /// <summary>
        /// Gets system color chartreuse corresponding to 127 255 0 255 (0.49803922, 1, 0, 1).
        /// </summary>
        public static Color4<Rgba> Chartreuse => new Color4<Rgba>(0.49803922f, 1f, 0f, 1f);

        /// <summary>
        /// Gets system color chocolate corresponding to 210 105 30 255 (0.8235294, 0.4117647, 0.11764706, 1).
        /// </summary>
        public static Color4<Rgba> Chocolate => new Color4<Rgba>(0.8235294f, 0.4117647f, 0.11764706f, 1f);

        /// <summary>
        /// Gets system color coral corresponding to 255 127 80 255 (1, 0.49803922, 0.3137255, 1).
        /// </summary>
        public static Color4<Rgba> Coral => new Color4<Rgba>(1f, 0.49803922f, 0.3137255f, 1f);

        /// <summary>
        /// Gets system color cornflowerblue corresponding to 100 149 237 255 (0.39215687, 0.58431375, 0.92941177, 1).
        /// </summary>
        public static Color4<Rgba> Cornflowerblue => new Color4<Rgba>(0.39215687f, 0.58431375f, 0.92941177f, 1f);

        /// <summary>
        /// Gets system color cornsilk corresponding to 255 248 220 255 (1, 0.972549, 0.8627451, 1).
        /// </summary>
        public static Color4<Rgba> Cornsilk => new Color4<Rgba>(1f, 0.972549f, 0.8627451f, 1f);

        /// <summary>
        /// Gets system color crimson corresponding to 220 20 60 255 (0.8627451, 0.078431375, 0.23529412, 1).
        /// </summary>
        public static Color4<Rgba> Crimson => new Color4<Rgba>(0.8627451f, 0.078431375f, 0.23529412f, 1f);

        /// <summary>
        /// Gets system color cyan corresponding to 0 255 255 255 (0, 1, 1, 1).
        /// </summary>
        public static Color4<Rgba> Cyan => new Color4<Rgba>(0f, 1f, 1f, 1f);

        /// <summary>
        /// Gets system color darkblue corresponding to 0 0 139 255 (0, 0, 0.54509807, 1).
        /// </summary>
        public static Color4<Rgba> Darkblue => new Color4<Rgba>(0f, 0f, 0.54509807f, 1f);

        /// <summary>
        /// Gets system color darkcyan corresponding to 0 139 139 255 (0, 0.54509807, 0.54509807, 1).
        /// </summary>
        public static Color4<Rgba> Darkcyan => new Color4<Rgba>(0f, 0.54509807f, 0.54509807f, 1f);

        /// <summary>
        /// Gets system color darkgoldenrod corresponding to 184 134 11 255 (0.72156864, 0.5254902, 0.043137256, 1).
        /// </summary>
        public static Color4<Rgba> Darkgoldenrod => new Color4<Rgba>(0.72156864f, 0.5254902f, 0.043137256f, 1f);

        /// <summary>
        /// Gets system color darkgray corresponding to 169 169 169 255 (0.6627451, 0.6627451, 0.6627451, 1).
        /// </summary>
        public static Color4<Rgba> Darkgray => new Color4<Rgba>(0.6627451f, 0.6627451f, 0.6627451f, 1f);

        /// <summary>
        /// Gets system color darkgreen corresponding to 0 100 0 255 (0, 0.39215687, 0, 1).
        /// </summary>
        public static Color4<Rgba> Darkgreen => new Color4<Rgba>(0f, 0.39215687f, 0f, 1f);

        /// <summary>
        /// Gets system color darkkhaki corresponding to 189 183 107 255 (0.7411765, 0.7176471, 0.41960785, 1).
        /// </summary>
        public static Color4<Rgba> Darkkhaki => new Color4<Rgba>(0.7411765f, 0.7176471f, 0.41960785f, 1f);

        /// <summary>
        /// Gets system color darkmagenta corresponding to 139 0 139 255 (0.54509807, 0, 0.54509807, 1).
        /// </summary>
        public static Color4<Rgba> Darkmagenta => new Color4<Rgba>(0.54509807f, 0f, 0.54509807f, 1f);

        /// <summary>
        /// Gets system color darkolivegreen corresponding to 85 107 47 255 (0.33333334, 0.41960785, 0.18431373, 1).
        /// </summary>
        public static Color4<Rgba> Darkolivegreen => new Color4<Rgba>(0.33333334f, 0.41960785f, 0.18431373f, 1f);

        /// <summary>
        /// Gets system color darkorange corresponding to 255 140 0 255 (1, 0.54901963, 0, 1).
        /// </summary>
        public static Color4<Rgba> Darkorange => new Color4<Rgba>(1f, 0.54901963f, 0f, 1f);

        /// <summary>
        /// Gets system color darkorchid corresponding to 153 50 204 255 (0.6, 0.19607843, 0.8, 1).
        /// </summary>
        public static Color4<Rgba> Darkorchid => new Color4<Rgba>(0.6f, 0.19607843f, 0.8f, 1f);

        /// <summary>
        /// Gets system color darkred corresponding to 139 0 0 255 (0.54509807, 0, 0, 1).
        /// </summary>
        public static Color4<Rgba> Darkred => new Color4<Rgba>(0.54509807f, 0f, 0f, 1f);

        /// <summary>
        /// Gets system color darksalmon corresponding to 233 150 122 255 (0.9137255, 0.5882353, 0.47843137, 1).
        /// </summary>
        public static Color4<Rgba> Darksalmon => new Color4<Rgba>(0.9137255f, 0.5882353f, 0.47843137f, 1f);

        /// <summary>
        /// Gets system color darkseagreen corresponding to 143 188 139 255 (0.56078434, 0.7372549, 0.54509807, 1).
        /// </summary>
        public static Color4<Rgba> Darkseagreen => new Color4<Rgba>(0.56078434f, 0.7372549f, 0.54509807f, 1f);

        /// <summary>
        /// Gets system color darkslateblue corresponding to 72 61 139 255 (0.28235295, 0.23921569, 0.54509807, 1).
        /// </summary>
        public static Color4<Rgba> Darkslateblue => new Color4<Rgba>(0.28235295f, 0.23921569f, 0.54509807f, 1f);

        /// <summary>
        /// Gets system color darkslategray corresponding to 47 79 79 255 (0.18431373, 0.30980393, 0.30980393, 1).
        /// </summary>
        public static Color4<Rgba> Darkslategray => new Color4<Rgba>(0.18431373f, 0.30980393f, 0.30980393f, 1f);

        /// <summary>
        /// Gets system color darkturquoise corresponding to 0 206 209 255 (0, 0.80784315, 0.81960785, 1).
        /// </summary>
        public static Color4<Rgba> Darkturquoise => new Color4<Rgba>(0f, 0.80784315f, 0.81960785f, 1f);

        /// <summary>
        /// Gets system color darkviolet corresponding to 148 0 211 255 (0.5803922, 0, 0.827451, 1).
        /// </summary>
        public static Color4<Rgba> Darkviolet => new Color4<Rgba>(0.5803922f, 0f, 0.827451f, 1f);

        /// <summary>
        /// Gets system color deeppink corresponding to 255 20 147 255 (1, 0.078431375, 0.5764706, 1).
        /// </summary>
        public static Color4<Rgba> Deeppink => new Color4<Rgba>(1f, 0.078431375f, 0.5764706f, 1f);

        /// <summary>
        /// Gets system color deepskyblue corresponding to 0 191 255 255 (0, 0.7490196, 1, 1).
        /// </summary>
        public static Color4<Rgba> Deepskyblue => new Color4<Rgba>(0f, 0.7490196f, 1f, 1f);

        /// <summary>
        /// Gets system color dimgray corresponding to 105 105 105 255 (0.4117647, 0.4117647, 0.4117647, 1).
        /// </summary>
        public static Color4<Rgba> Dimgray => new Color4<Rgba>(0.4117647f, 0.4117647f, 0.4117647f, 1f);

        /// <summary>
        /// Gets system color dodgerblue corresponding to 30 144 255 255 (0.11764706, 0.5647059, 1, 1).
        /// </summary>
        public static Color4<Rgba> Dodgerblue => new Color4<Rgba>(0.11764706f, 0.5647059f, 1f, 1f);

        /// <summary>
        /// Gets system color firebrick corresponding to 178 34 34 255 (0.69803923, 0.13333334, 0.13333334, 1).
        /// </summary>
        public static Color4<Rgba> Firebrick => new Color4<Rgba>(0.69803923f, 0.13333334f, 0.13333334f, 1f);

        /// <summary>
        /// Gets system color floralwhite corresponding to 255 250 240 255 (1, 0.98039216, 0.9411765, 1).
        /// </summary>
        public static Color4<Rgba> Floralwhite => new Color4<Rgba>(1f, 0.98039216f, 0.9411765f, 1f);

        /// <summary>
        /// Gets system color forestgreen corresponding to 34 139 34 255 (0.13333334, 0.54509807, 0.13333334, 1).
        /// </summary>
        public static Color4<Rgba> Forestgreen => new Color4<Rgba>(0.13333334f, 0.54509807f, 0.13333334f, 1f);

        /// <summary>
        /// Gets system color fuchsia corresponding to 255 0 255 255 (1, 0, 1, 1).
        /// </summary>
        public static Color4<Rgba> Fuchsia => new Color4<Rgba>(1f, 0f, 1f, 1f);

        /// <summary>
        /// Gets system color gainsboro corresponding to 220 220 220 255 (0.8627451, 0.8627451, 0.8627451, 1).
        /// </summary>
        public static Color4<Rgba> Gainsboro => new Color4<Rgba>(0.8627451f, 0.8627451f, 0.8627451f, 1f);

        /// <summary>
        /// Gets system color ghostwhite corresponding to 248 248 255 255 (0.972549, 0.972549, 1, 1).
        /// </summary>
        public static Color4<Rgba> Ghostwhite => new Color4<Rgba>(0.972549f, 0.972549f, 1f, 1f);

        /// <summary>
        /// Gets system color gold corresponding to 255 215 0 255 (1, 0.84313726, 0, 1).
        /// </summary>
        public static Color4<Rgba> Gold => new Color4<Rgba>(1f, 0.84313726f, 0f, 1f);

        /// <summary>
        /// Gets system color goldenrod corresponding to 218 165 32 255 (0.85490197, 0.64705884, 0.1254902, 1).
        /// </summary>
        public static Color4<Rgba> Goldenrod => new Color4<Rgba>(0.85490197f, 0.64705884f, 0.1254902f, 1f);

        /// <summary>
        /// Gets system color gray corresponding to 128 128 128 255 (0.5019608, 0.5019608, 0.5019608, 1).
        /// </summary>
        public static Color4<Rgba> Gray => new Color4<Rgba>(0.5019608f, 0.5019608f, 0.5019608f, 1f);

        /// <summary>
        /// Gets system color green corresponding to 0 128 0 255 (0, 0.5019608, 0, 1).
        /// </summary>
        public static Color4<Rgba> Green => new Color4<Rgba>(0f, 0.5019608f, 0f, 1f);

        /// <summary>
        /// Gets system color greenyellow corresponding to 173 255 47 255 (0.6784314, 1, 0.18431373, 1).
        /// </summary>
        public static Color4<Rgba> Greenyellow => new Color4<Rgba>(0.6784314f, 1f, 0.18431373f, 1f);

        /// <summary>
        /// Gets system color honeydew corresponding to 240 255 240 255 (0.9411765, 1, 0.9411765, 1).
        /// </summary>
        public static Color4<Rgba> Honeydew => new Color4<Rgba>(0.9411765f, 1f, 0.9411765f, 1f);

        /// <summary>
        /// Gets system color hotpink corresponding to 255 105 180 255 (1, 0.4117647, 0.7058824, 1).
        /// </summary>
        public static Color4<Rgba> Hotpink => new Color4<Rgba>(1f, 0.4117647f, 0.7058824f, 1f);

        /// <summary>
        /// Gets system color indianred corresponding to 205 92 92 255 (0.8039216, 0.36078432, 0.36078432, 1).
        /// </summary>
        public static Color4<Rgba> Indianred => new Color4<Rgba>(0.8039216f, 0.36078432f, 0.36078432f, 1f);

        /// <summary>
        /// Gets system color indigo corresponding to 75 0 130 255 (0.29411766, 0, 0.50980395, 1).
        /// </summary>
        public static Color4<Rgba> Indigo => new Color4<Rgba>(0.29411766f, 0f, 0.50980395f, 1f);

        /// <summary>
        /// Gets system color ivory corresponding to 255 255 240 255 (1, 1, 0.9411765, 1).
        /// </summary>
        public static Color4<Rgba> Ivory => new Color4<Rgba>(1f, 1f, 0.9411765f, 1f);

        /// <summary>
        /// Gets system color khaki corresponding to 240 230 140 255 (0.9411765, 0.9019608, 0.54901963, 1).
        /// </summary>
        public static Color4<Rgba> Khaki => new Color4<Rgba>(0.9411765f, 0.9019608f, 0.54901963f, 1f);

        /// <summary>
        /// Gets system color lavender corresponding to 230 230 250 255 (0.9019608, 0.9019608, 0.98039216, 1).
        /// </summary>
        public static Color4<Rgba> Lavender => new Color4<Rgba>(0.9019608f, 0.9019608f, 0.98039216f, 1f);

        /// <summary>
        /// Gets system color lavenderblush corresponding to 255 240 245 255 (1, 0.9411765, 0.9607843, 1).
        /// </summary>
        public static Color4<Rgba> Lavenderblush => new Color4<Rgba>(1f, 0.9411765f, 0.9607843f, 1f);

        /// <summary>
        /// Gets system color lawngreen corresponding to 124 252 0 255 (0.4862745, 0.9882353, 0, 1).
        /// </summary>
        public static Color4<Rgba> Lawngreen => new Color4<Rgba>(0.4862745f, 0.9882353f, 0f, 1f);

        /// <summary>
        /// Gets system color lemonchiffon corresponding to 255 250 205 255 (1, 0.98039216, 0.8039216, 1).
        /// </summary>
        public static Color4<Rgba> Lemonchiffon => new Color4<Rgba>(1f, 0.98039216f, 0.8039216f, 1f);

        /// <summary>
        /// Gets system color lightblue corresponding to 173 216 230 255 (0.6784314, 0.84705883, 0.9019608, 1).
        /// </summary>
        public static Color4<Rgba> Lightblue => new Color4<Rgba>(0.6784314f, 0.84705883f, 0.9019608f, 1f);

        /// <summary>
        /// Gets system color lightcoral corresponding to 240 128 128 255 (0.9411765, 0.5019608, 0.5019608, 1).
        /// </summary>
        public static Color4<Rgba> Lightcoral => new Color4<Rgba>(0.9411765f, 0.5019608f, 0.5019608f, 1f);

        /// <summary>
        /// Gets system color lightcyan corresponding to 224 255 255 255 (0.8784314, 1, 1, 1).
        /// </summary>
        public static Color4<Rgba> Lightcyan => new Color4<Rgba>(0.8784314f, 1f, 1f, 1f);

        /// <summary>
        /// Gets system color lightgoldenrodyellow corresponding to 250 250 210 255 (0.98039216, 0.98039216, 0.8235294, 1).
        /// </summary>
        public static Color4<Rgba> Lightgoldenrodyellow => new Color4<Rgba>(0.98039216f, 0.98039216f, 0.8235294f, 1f);

        /// <summary>
        /// Gets system color lightgray corresponding to 211 211 211 255 (0.827451, 0.827451, 0.827451, 1).
        /// </summary>
        public static Color4<Rgba> Lightgray => new Color4<Rgba>(0.827451f, 0.827451f, 0.827451f, 1f);

        /// <summary>
        /// Gets system color lightgreen corresponding to 144 238 144 255 (0.5647059, 0.93333334, 0.5647059, 1).
        /// </summary>
        public static Color4<Rgba> Lightgreen => new Color4<Rgba>(0.5647059f, 0.93333334f, 0.5647059f, 1f);

        /// <summary>
        /// Gets system color lightpink corresponding to 255 182 193 255 (1, 0.7137255, 0.75686276, 1).
        /// </summary>
        public static Color4<Rgba> Lightpink => new Color4<Rgba>(1f, 0.7137255f, 0.75686276f, 1f);

        /// <summary>
        /// Gets system color lightsalmon corresponding to 255 160 122 255 (1, 0.627451, 0.47843137, 1).
        /// </summary>
        public static Color4<Rgba> Lightsalmon => new Color4<Rgba>(1f, 0.627451f, 0.47843137f, 1f);

        /// <summary>
        /// Gets system color lightseagreen corresponding to 32 178 170 255 (0.1254902, 0.69803923, 0.6666667, 1).
        /// </summary>
        public static Color4<Rgba> Lightseagreen => new Color4<Rgba>(0.1254902f, 0.69803923f, 0.6666667f, 1f);

        /// <summary>
        /// Gets system color lightskyblue corresponding to 135 206 250 255 (0.5294118, 0.80784315, 0.98039216, 1).
        /// </summary>
        public static Color4<Rgba> Lightskyblue => new Color4<Rgba>(0.5294118f, 0.80784315f, 0.98039216f, 1f);

        /// <summary>
        /// Gets system color lightslategray corresponding to 119 136 153 255 (0.46666667, 0.53333336, 0.6, 1).
        /// </summary>
        public static Color4<Rgba> Lightslategray => new Color4<Rgba>(0.46666667f, 0.53333336f, 0.6f, 1f);

        /// <summary>
        /// Gets system color lightsteelblue corresponding to 176 196 222 255 (0.6901961, 0.76862746, 0.87058824, 1).
        /// </summary>
        public static Color4<Rgba> Lightsteelblue => new Color4<Rgba>(0.6901961f, 0.76862746f, 0.87058824f, 1f);

        /// <summary>
        /// Gets system color lightyellow corresponding to 255 255 224 255 (1, 1, 0.8784314, 1).
        /// </summary>
        public static Color4<Rgba> Lightyellow => new Color4<Rgba>(1f, 1f, 0.8784314f, 1f);

        /// <summary>
        /// Gets system color lime corresponding to 0 255 0 255 (0, 1, 0, 1).
        /// </summary>
        public static Color4<Rgba> Lime => new Color4<Rgba>(0f, 1f, 0f, 1f);

        /// <summary>
        /// Gets system color limegreen corresponding to 50 205 50 255 (0.19607843, 0.8039216, 0.19607843, 1).
        /// </summary>
        public static Color4<Rgba> Limegreen => new Color4<Rgba>(0.19607843f, 0.8039216f, 0.19607843f, 1f);

        /// <summary>
        /// Gets system color linen corresponding to 250 240 230 255 (0.98039216, 0.9411765, 0.9019608, 1).
        /// </summary>
        public static Color4<Rgba> Linen => new Color4<Rgba>(0.98039216f, 0.9411765f, 0.9019608f, 1f);

        /// <summary>
        /// Gets system color magenta corresponding to 255 0 255 255 (1, 0, 1, 1).
        /// </summary>
        public static Color4<Rgba> Magenta => new Color4<Rgba>(1f, 0f, 1f, 1f);

        /// <summary>
        /// Gets system color maroon corresponding to 128 0 0 255 (0.5019608, 0, 0, 1).
        /// </summary>
        public static Color4<Rgba> Maroon => new Color4<Rgba>(0.5019608f, 0f, 0f, 1f);

        /// <summary>
        /// Gets system color mediumaquamarine corresponding to 102 205 170 255 (0.4, 0.8039216, 0.6666667, 1).
        /// </summary>
        public static Color4<Rgba> Mediumaquamarine => new Color4<Rgba>(0.4f, 0.8039216f, 0.6666667f, 1f);

        /// <summary>
        /// Gets system color mediumblue corresponding to 0 0 205 255 (0, 0, 0.8039216, 1).
        /// </summary>
        public static Color4<Rgba> Mediumblue => new Color4<Rgba>(0f, 0f, 0.8039216f, 1f);

        /// <summary>
        /// Gets system color mediumorchid corresponding to 186 85 211 255 (0.7294118, 0.33333334, 0.827451, 1).
        /// </summary>
        public static Color4<Rgba> Mediumorchid => new Color4<Rgba>(0.7294118f, 0.33333334f, 0.827451f, 1f);

        /// <summary>
        /// Gets system color mediumpurple corresponding to 147 112 219 255 (0.5764706, 0.4392157, 0.85882354, 1).
        /// </summary>
        public static Color4<Rgba> Mediumpurple => new Color4<Rgba>(0.5764706f, 0.4392157f, 0.85882354f, 1f);

        /// <summary>
        /// Gets system color mediumseagreen corresponding to 60 179 113 255 (0.23529412, 0.7019608, 0.44313726, 1).
        /// </summary>
        public static Color4<Rgba> Mediumseagreen => new Color4<Rgba>(0.23529412f, 0.7019608f, 0.44313726f, 1f);

        /// <summary>
        /// Gets system color mediumslateblue corresponding to 123 104 238 255 (0.48235294, 0.40784314, 0.93333334, 1).
        /// </summary>
        public static Color4<Rgba> Mediumslateblue => new Color4<Rgba>(0.48235294f, 0.40784314f, 0.93333334f, 1f);

        /// <summary>
        /// Gets system color mediumspringgreen corresponding to 0 250 154 255 (0, 0.98039216, 0.6039216, 1).
        /// </summary>
        public static Color4<Rgba> Mediumspringgreen => new Color4<Rgba>(0f, 0.98039216f, 0.6039216f, 1f);

        /// <summary>
        /// Gets system color mediumturquoise corresponding to 72 209 204 255 (0.28235295, 0.81960785, 0.8, 1).
        /// </summary>
        public static Color4<Rgba> Mediumturquoise => new Color4<Rgba>(0.28235295f, 0.81960785f, 0.8f, 1f);

        /// <summary>
        /// Gets system color mediumvioletred corresponding to 199 21 133 255 (0.78039217, 0.08235294, 0.52156866, 1).
        /// </summary>
        public static Color4<Rgba> Mediumvioletred => new Color4<Rgba>(0.78039217f, 0.08235294f, 0.52156866f, 1f);

        /// <summary>
        /// Gets system color midnightblue corresponding to 25 25 112 255 (0.09803922, 0.09803922, 0.4392157, 1).
        /// </summary>
        public static Color4<Rgba> Midnightblue => new Color4<Rgba>(0.09803922f, 0.09803922f, 0.4392157f, 1f);

        /// <summary>
        /// Gets system color mintcream corresponding to 245 255 250 255 (0.9607843, 1, 0.98039216, 1).
        /// </summary>
        public static Color4<Rgba> Mintcream => new Color4<Rgba>(0.9607843f, 1f, 0.98039216f, 1f);

        /// <summary>
        /// Gets system color mistyrose corresponding to 255 228 225 255 (1, 0.89411765, 0.88235295, 1).
        /// </summary>
        public static Color4<Rgba> Mistyrose => new Color4<Rgba>(1f, 0.89411765f, 0.88235295f, 1f);

        /// <summary>
        /// Gets system color moccasin corresponding to 255 228 181 255 (1, 0.89411765, 0.70980394, 1).
        /// </summary>
        public static Color4<Rgba> Moccasin => new Color4<Rgba>(1f, 0.89411765f, 0.70980394f, 1f);

        /// <summary>
        /// Gets system color navajowhite corresponding to 255 222 173 255 (1, 0.87058824, 0.6784314, 1).
        /// </summary>
        public static Color4<Rgba> Navajowhite => new Color4<Rgba>(1f, 0.87058824f, 0.6784314f, 1f);

        /// <summary>
        /// Gets system color navy corresponding to 0 0 128 255 (0, 0, 0.5019608, 1).
        /// </summary>
        public static Color4<Rgba> Navy => new Color4<Rgba>(0f, 0f, 0.5019608f, 1f);

        /// <summary>
        /// Gets system color oldlace corresponding to 253 245 230 255 (0.99215686, 0.9607843, 0.9019608, 1).
        /// </summary>
        public static Color4<Rgba> Oldlace => new Color4<Rgba>(0.99215686f, 0.9607843f, 0.9019608f, 1f);

        /// <summary>
        /// Gets system color olive corresponding to 128 128 0 255 (0.5019608, 0.5019608, 0, 1).
        /// </summary>
        public static Color4<Rgba> Olive => new Color4<Rgba>(0.5019608f, 0.5019608f, 0f, 1f);

        /// <summary>
        /// Gets system color olivedrab corresponding to 107 142 35 255 (0.41960785, 0.5568628, 0.13725491, 1).
        /// </summary>
        public static Color4<Rgba> Olivedrab => new Color4<Rgba>(0.41960785f, 0.5568628f, 0.13725491f, 1f);

        /// <summary>
        /// Gets system color orange corresponding to 255 165 0 255 (1, 0.64705884, 0, 1).
        /// </summary>
        public static Color4<Rgba> Orange => new Color4<Rgba>(1f, 0.64705884f, 0f, 1f);

        /// <summary>
        /// Gets system color orangered corresponding to 255 69 0 255 (1, 0.27058825, 0, 1).
        /// </summary>
        public static Color4<Rgba> Orangered => new Color4<Rgba>(1f, 0.27058825f, 0f, 1f);

        /// <summary>
        /// Gets system color orchid corresponding to 218 112 214 255 (0.85490197, 0.4392157, 0.8392157, 1).
        /// </summary>
        public static Color4<Rgba> Orchid => new Color4<Rgba>(0.85490197f, 0.4392157f, 0.8392157f, 1f);

        /// <summary>
        /// Gets system color palegoldenrod corresponding to 238 232 170 255 (0.93333334, 0.9098039, 0.6666667, 1).
        /// </summary>
        public static Color4<Rgba> Palegoldenrod => new Color4<Rgba>(0.93333334f, 0.9098039f, 0.6666667f, 1f);

        /// <summary>
        /// Gets system color palegreen corresponding to 152 251 152 255 (0.59607846, 0.9843137, 0.59607846, 1).
        /// </summary>
        public static Color4<Rgba> Palegreen => new Color4<Rgba>(0.59607846f, 0.9843137f, 0.59607846f, 1f);

        /// <summary>
        /// Gets system color paleturquoise corresponding to 175 238 238 255 (0.6862745, 0.93333334, 0.93333334, 1).
        /// </summary>
        public static Color4<Rgba> Paleturquoise => new Color4<Rgba>(0.6862745f, 0.93333334f, 0.93333334f, 1f);

        /// <summary>
        /// Gets system color palevioletred corresponding to 219 112 147 255 (0.85882354, 0.4392157, 0.5764706, 1).
        /// </summary>
        public static Color4<Rgba> Palevioletred => new Color4<Rgba>(0.85882354f, 0.4392157f, 0.5764706f, 1f);

        /// <summary>
        /// Gets system color papayawhip corresponding to 255 239 213 255 (1, 0.9372549, 0.8352941, 1).
        /// </summary>
        public static Color4<Rgba> Papayawhip => new Color4<Rgba>(1f, 0.9372549f, 0.8352941f, 1f);

        /// <summary>
        /// Gets system color peachpuff corresponding to 255 218 185 255 (1, 0.85490197, 0.7254902, 1).
        /// </summary>
        public static Color4<Rgba> Peachpuff => new Color4<Rgba>(1f, 0.85490197f, 0.7254902f, 1f);

        /// <summary>
        /// Gets system color peru corresponding to 205 133 63 255 (0.8039216, 0.52156866, 0.24705882, 1).
        /// </summary>
        public static Color4<Rgba> Peru => new Color4<Rgba>(0.8039216f, 0.52156866f, 0.24705882f, 1f);

        /// <summary>
        /// Gets system color pink corresponding to 255 192 203 255 (1, 0.7529412, 0.79607844, 1).
        /// </summary>
        public static Color4<Rgba> Pink => new Color4<Rgba>(1f, 0.7529412f, 0.79607844f, 1f);

        /// <summary>
        /// Gets system color plum corresponding to 221 160 221 255 (0.8666667, 0.627451, 0.8666667, 1).
        /// </summary>
        public static Color4<Rgba> Plum => new Color4<Rgba>(0.8666667f, 0.627451f, 0.8666667f, 1f);

        /// <summary>
        /// Gets system color powderblue corresponding to 176 224 230 255 (0.6901961, 0.8784314, 0.9019608, 1).
        /// </summary>
        public static Color4<Rgba> Powderblue => new Color4<Rgba>(0.6901961f, 0.8784314f, 0.9019608f, 1f);

        /// <summary>
        /// Gets system color purple corresponding to 128 0 128 255 (0.5019608, 0, 0.5019608, 1).
        /// </summary>
        public static Color4<Rgba> Purple => new Color4<Rgba>(0.5019608f, 0f, 0.5019608f, 1f);

        /// <summary>
        /// Gets system color red corresponding to 255 0 0 255 (1, 0, 0, 1).
        /// </summary>
        public static Color4<Rgba> Red => new Color4<Rgba>(1f, 0f, 0f, 1f);

        /// <summary>
        /// Gets system color rosybrown corresponding to 188 143 143 255 (0.7372549, 0.56078434, 0.56078434, 1).
        /// </summary>
        public static Color4<Rgba> Rosybrown => new Color4<Rgba>(0.7372549f, 0.56078434f, 0.56078434f, 1f);

        /// <summary>
        /// Gets system color royalblue corresponding to 65 105 225 255 (0.25490198, 0.4117647, 0.88235295, 1).
        /// </summary>
        public static Color4<Rgba> Royalblue => new Color4<Rgba>(0.25490198f, 0.4117647f, 0.88235295f, 1f);

        /// <summary>
        /// Gets system color saddlebrown corresponding to 139 69 19 255 (0.54509807, 0.27058825, 0.07450981, 1).
        /// </summary>
        public static Color4<Rgba> Saddlebrown => new Color4<Rgba>(0.54509807f, 0.27058825f, 0.07450981f, 1f);

        /// <summary>
        /// Gets system color salmon corresponding to 250 128 114 255 (0.98039216, 0.5019608, 0.44705883, 1).
        /// </summary>
        public static Color4<Rgba> Salmon => new Color4<Rgba>(0.98039216f, 0.5019608f, 0.44705883f, 1f);

        /// <summary>
        /// Gets system color sandybrown corresponding to 244 164 96 255 (0.95686275, 0.6431373, 0.3764706, 1).
        /// </summary>
        public static Color4<Rgba> Sandybrown => new Color4<Rgba>(0.95686275f, 0.6431373f, 0.3764706f, 1f);

        /// <summary>
        /// Gets system color seagreen corresponding to 46 139 87 255 (0.18039216, 0.54509807, 0.34117648, 1).
        /// </summary>
        public static Color4<Rgba> Seagreen => new Color4<Rgba>(0.18039216f, 0.54509807f, 0.34117648f, 1f);

        /// <summary>
        /// Gets system color seashell corresponding to 255 245 238 255 (1, 0.9607843, 0.93333334, 1).
        /// </summary>
        public static Color4<Rgba> Seashell => new Color4<Rgba>(1f, 0.9607843f, 0.93333334f, 1f);

        /// <summary>
        /// Gets system color sienna corresponding to 160 82 45 255 (0.627451, 0.32156864, 0.1764706, 1).
        /// </summary>
        public static Color4<Rgba> Sienna => new Color4<Rgba>(0.627451f, 0.32156864f, 0.1764706f, 1f);

        /// <summary>
        /// Gets system color silver corresponding to 192 192 192 255 (0.7529412, 0.7529412, 0.7529412, 1).
        /// </summary>
        public static Color4<Rgba> Silver => new Color4<Rgba>(0.7529412f, 0.7529412f, 0.7529412f, 1f);

        /// <summary>
        /// Gets system color skyblue corresponding to 135 206 235 255 (0.5294118, 0.80784315, 0.92156863, 1).
        /// </summary>
        public static Color4<Rgba> Skyblue => new Color4<Rgba>(0.5294118f, 0.80784315f, 0.92156863f, 1f);

        /// <summary>
        /// Gets system color slateblue corresponding to 106 90 205 255 (0.41568628, 0.3529412, 0.8039216, 1).
        /// </summary>
        public static Color4<Rgba> Slateblue => new Color4<Rgba>(0.41568628f, 0.3529412f, 0.8039216f, 1f);

        /// <summary>
        /// Gets system color slategray corresponding to 112 128 144 255 (0.4392157, 0.5019608, 0.5647059, 1).
        /// </summary>
        public static Color4<Rgba> Slategray => new Color4<Rgba>(0.4392157f, 0.5019608f, 0.5647059f, 1f);

        /// <summary>
        /// Gets system color snow corresponding to 255 250 250 255 (1, 0.98039216, 0.98039216, 1).
        /// </summary>
        public static Color4<Rgba> Snow => new Color4<Rgba>(1f, 0.98039216f, 0.98039216f, 1f);

        /// <summary>
        /// Gets system color springgreen corresponding to 0 255 127 255 (0, 1, 0.49803922, 1).
        /// </summary>
        public static Color4<Rgba> Springgreen => new Color4<Rgba>(0f, 1f, 0.49803922f, 1f);

        /// <summary>
        /// Gets system color steelblue corresponding to 70 130 180 255 (0.27450982, 0.50980395, 0.7058824, 1).
        /// </summary>
        public static Color4<Rgba> Steelblue => new Color4<Rgba>(0.27450982f, 0.50980395f, 0.7058824f, 1f);

        /// <summary>
        /// Gets system color tan corresponding to 210 180 140 255 (0.8235294, 0.7058824, 0.54901963, 1).
        /// </summary>
        public static Color4<Rgba> Tan => new Color4<Rgba>(0.8235294f, 0.7058824f, 0.54901963f, 1f);

        /// <summary>
        /// Gets system color teal corresponding to 0 128 128 255 (0, 0.5019608, 0.5019608, 1).
        /// </summary>
        public static Color4<Rgba> Teal => new Color4<Rgba>(0f, 0.5019608f, 0.5019608f, 1f);

        /// <summary>
        /// Gets system color thistle corresponding to 216 191 216 255 (0.84705883, 0.7490196, 0.84705883, 1).
        /// </summary>
        public static Color4<Rgba> Thistle => new Color4<Rgba>(0.84705883f, 0.7490196f, 0.84705883f, 1f);

        /// <summary>
        /// Gets system color tomato corresponding to 255 99 71 255 (1, 0.3882353, 0.2784314, 1).
        /// </summary>
        public static Color4<Rgba> Tomato => new Color4<Rgba>(1f, 0.3882353f, 0.2784314f, 1f);

        /// <summary>
        /// Gets system color turquoise corresponding to 64 224 208 255 (0.2509804, 0.8784314, 0.8156863, 1).
        /// </summary>
        public static Color4<Rgba> Turquoise => new Color4<Rgba>(0.2509804f, 0.8784314f, 0.8156863f, 1f);

        /// <summary>
        /// Gets system color violet corresponding to 238 130 238 255 (0.93333334, 0.50980395, 0.93333334, 1).
        /// </summary>
        public static Color4<Rgba> Violet => new Color4<Rgba>(0.93333334f, 0.50980395f, 0.93333334f, 1f);

        /// <summary>
        /// Gets system color wheat corresponding to 245 222 179 255 (0.9607843, 0.87058824, 0.7019608, 1).
        /// </summary>
        public static Color4<Rgba> Wheat => new Color4<Rgba>(0.9607843f, 0.87058824f, 0.7019608f, 1f);

        /// <summary>
        /// Gets system color white corresponding to 255 255 255 255 (1, 1, 1, 1).
        /// </summary>
        public static Color4<Rgba> White => new Color4<Rgba>(1f, 1f, 1f, 1f);

        /// <summary>
        /// Gets system color whitesmoke corresponding to 245 245 245 255 (0.9607843, 0.9607843, 0.9607843, 1).
        /// </summary>
        public static Color4<Rgba> Whitesmoke => new Color4<Rgba>(0.9607843f, 0.9607843f, 0.9607843f, 1f);

        /// <summary>
        /// Gets system color yellow corresponding to 255 255 0 255 (1, 1, 0, 1).
        /// </summary>
        public static Color4<Rgba> Yellow => new Color4<Rgba>(1f, 1f, 0f, 1f);

        /// <summary>
        /// Gets system color yellowgreen corresponding to 154 205 50 255 (0.6039216, 0.8039216, 0.19607843, 1).
        /// </summary>
        public static Color4<Rgba> Yellowgreen => new Color4<Rgba>(0.6039216f, 0.8039216f, 0.19607843f, 1f);
    }
}
#pragma warning restore SA1649
