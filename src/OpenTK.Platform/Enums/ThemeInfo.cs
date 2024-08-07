using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Enum representing a theme setting.
    /// </summary>
    public enum AppTheme
    {
        /// <summary>
        /// No preference for theme.
        /// </summary>
        NoPreference,

        /// <summary>
        /// A light theme is preferred.
        /// </summary>
        Light,

        /// <summary>
        /// A dark theme is preferred.
        /// </summary>
        Dark,
    }

    /// <summary>
    /// Represents theme info.
    /// </summary>
    public struct ThemeInfo : IEquatable<ThemeInfo>
    {
        /// <summary>
        /// The current preferred theme.
        /// </summary>
        public AppTheme Theme;

        /// <summary>
        /// If a high contrast theme is preferred.
        /// </summary>
        public bool HighContrast;

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is ThemeInfo info && Equals(info);
        }

        /// <inheritdoc/>
        public bool Equals(ThemeInfo other)
        {
            return Theme == other.Theme &&
                   HighContrast == other.HighContrast;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Theme, HighContrast);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{(HighContrast ? "High contrast " : "")}{Theme}";
        }

        /// <summary>
        /// Checks if two <see cref="ThemeInfo"/> structs are equal.
        /// </summary>
        /// <param name="left">The first <see cref="ThemeInfo"/> struct.</param>
        /// <param name="right">The second <see cref="ThemeInfo"/> struct.</param>
        /// <returns>If the two <see cref="ThemeInfo"/> structs where equal.</returns>
        public static bool operator ==(ThemeInfo left, ThemeInfo right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks if two <see cref="ThemeInfo"/> structs are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="ThemeInfo"/> struct.</param>
        /// <param name="right">The second <see cref="ThemeInfo"/> struct.</param>
        /// <returns>If the two <see cref="ThemeInfo"/> structs where not equal.</returns>
        public static bool operator !=(ThemeInfo left, ThemeInfo right)
        {
            return !(left == right);
        }
    }
}
