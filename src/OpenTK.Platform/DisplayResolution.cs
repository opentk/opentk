using System;

namespace OpenTK.Platform
{
    /// <summary>
    /// Represents a display resolution.
    /// </summary>
    public readonly struct DisplayResolution : IEquatable<DisplayResolution>
    {
        /// <summary>
        /// The horizontal resolution in pixels.
        /// </summary>
        public readonly int ResolutionX;

        /// <summary>
        /// The vertical resolution in pixels.
        /// </summary>
        public readonly int ResolutionY;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayResolution"/> struct with the specified vertical and horizontal resolution.
        /// </summary>
        /// <param name="resolutionX">The horizontal resolution.</param>
        /// <param name="resolutionY">The vertical resolution.</param>
        public DisplayResolution(int resolutionX, int resolutionY)
        {
            ResolutionX = resolutionX;
            ResolutionY = resolutionY;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is DisplayResolution resolution && Equals(resolution);
        }

        /// <inheritdoc/>
        public bool Equals(DisplayResolution other)
        {
            return ResolutionX == other.ResolutionX &&
                   ResolutionY == other.ResolutionY;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(ResolutionX, ResolutionY);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{ResolutionX}x{ResolutionY}";
        }

        /// <inheritdoc/>
        public static bool operator ==(DisplayResolution left, DisplayResolution right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(DisplayResolution left, DisplayResolution right)
        {
            return !(left == right);
        }
    }
}
