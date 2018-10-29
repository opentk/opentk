using System;
using JetBrains.Annotations;

namespace Bind.Versioning
{
    /// <summary>
    /// Represents a range of versions, with a minimum version and a maximum version.
    /// </summary>
    public class VersionRange : IComparable<Version>, IComparable<VersionRange>
    {
        /// <summary>
        /// Gets the minimum version, that is, the lower bound of the version range.
        /// </summary>
        public Version Minimum { get; }

        /// <summary>
        /// Gets the maximum version, that is, the upper bound of the version range.
        /// </summary>
        public Version Maximum { get; }

        /// <summary>
        /// Gets a value indicating whether the minimum version is inclusive. Defaults to true.
        /// </summary>
        public bool IsMinimumVersionInclusive { get; }

        /// <summary>
        /// Gets a value indicating whether the maximum version is inclusive. Defaults to true.
        /// </summary>
        public bool IsMaximumVersionInclusive { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionRange"/> class. This range encompasses all possible
        /// versions.
        /// </summary>
        public VersionRange()
            : this(new Version(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionRange"/> class. The lower bound will be unbound, that
        /// is, it will allow any version up to and including the given max version.
        /// </summary>
        /// <param name="maxVersion">The upper bound of the range.</param>
        public VersionRange(Version maxVersion)
        {
            Maximum = maxVersion;
            Minimum = new Version();

            IsMaximumVersionInclusive = true;
            IsMinimumVersionInclusive = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionRange"/> class. The lower bound will be unbound, that
        /// is, it will allow any version up to the given max version.
        /// </summary>
        /// <param name="maxVersion">The upper bound of the range.</param>
        /// <param name="maxInclusive">Whether or not the upper bound is inclusive.</param>
        public VersionRange(Version maxVersion, bool maxInclusive = true)
            : this(maxVersion)
        {
            IsMaximumVersionInclusive = maxInclusive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionRange"/> class. The given bounds will be considered as
        /// inclusive.
        /// </summary>
        /// <param name="minVersion">The lower bound of the range.</param>
        /// <param name="maxVersion">The upper bound of the range.</param>
        public VersionRange(Version minVersion, Version maxVersion)
            : this(maxVersion)
        {
            Minimum = minVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionRange"/> class.
        /// </summary>
        /// <param name="minVersion">The lower bound of the range.</param>
        /// <param name="maxVersion">The upper bound of the range.</param>
        /// <param name="minInclusive">Whether or not the lower bound is inclusive.</param>
        /// <param name="maxInclusive">Whether or not the upper bound is inclusive.</param>
        public VersionRange(Version minVersion, Version maxVersion, bool minInclusive = true, bool maxInclusive = true)
            : this(minVersion, maxVersion)
        {
            var eitherAreNonInclusive = !minInclusive | !maxInclusive;
            if (minVersion == maxVersion && eitherAreNonInclusive)
            {
                throw new ArgumentException
                (
                    "If Min and Max are the same, and any of them are non-inclusive, the resulting range is invalid."
                );
            }

            IsMaximumVersionInclusive = maxInclusive;
            IsMinimumVersionInclusive = minInclusive;
        }

        /// <summary>
        /// Determines whether or not the given version falls within the version range.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>true if the version falls inside of the range; Otherwise, false.</returns>
        public bool IsInRange(Version version)
        {
            if (version < Minimum)
            {
                return false;
            }

            if (version > Maximum)
            {
                return false;
            }

            if (!IsMinimumVersionInclusive && version == Minimum)
            {
                return false;
            }

            if (!IsMaximumVersionInclusive && version == Maximum)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Determines if <paramref name="a"/> is considered lesser than <paramref name="b"/>. In principle, this
        /// determines if a spans a range of versions that are less than the range of versions in b.
        /// </summary>
        /// <param name="a">The first range.</param>
        /// <param name="b">The second range.</param>
        /// <returns>true if a spans a lesser range of versions than b.</returns>
        public static bool operator <([NotNull] VersionRange a, [NotNull] VersionRange b)
        {
            return a.CompareTo(b) <= -1;
        }

        /// <summary>
        /// Determines if <paramref name="a"/> is considered greater than <paramref name="b"/>. In principle, this
        /// determines if a spans a range of versions that are greater than the range of versions in b.
        /// </summary>
        /// <param name="a">The first range.</param>
        /// <param name="b">The second range.</param>
        /// <returns>true if a spans a greater range of versions than b.</returns>
        public static bool operator >([NotNull] VersionRange a, [NotNull] VersionRange b)
        {
            return a.CompareTo(b) >= 1;
        }

        /// <inheritdoc/>
        public int CompareTo([NotNull] Version other)
        {
            if (IsInRange(other))
            {
                return 0;
            }

            if (other > Maximum)
            {
                return 1;
            }

            return -1;
        }

        /// <inheritdoc/>
        public int CompareTo([NotNull] VersionRange other)
        {
            if (other.Maximum > Maximum)
            {
                return -1;
            }

            if (other.Maximum < Maximum)
            {
                return 1;
            }

            if (other.Minimum > Minimum)
            {
                return -1;
            }

            if (other.Minimum < Minimum)
            {
                return 1;
            }

            return 0;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            if (Minimum == Maximum)
            {
                return Minimum.ToString();
            }

            return $"{Minimum} - {Maximum}";
        }
    }
}
