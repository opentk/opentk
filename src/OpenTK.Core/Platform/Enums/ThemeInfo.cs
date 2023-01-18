using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Enum representing a theme setting.
    /// </summary>
    public enum AppTheme
    {
        NoPreference,
        Light,
        Dark,
    }

    public struct ThemeInfo : IEquatable<ThemeInfo>
    {
        public AppTheme Theme;
        public bool HighContrast;

        public override bool Equals(object obj)
        {
            return obj is ThemeInfo info && Equals(info);
        }

        public bool Equals(ThemeInfo other)
        {
            return Theme == other.Theme &&
                   HighContrast == other.HighContrast;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Theme, HighContrast);
        }

        public override string ToString()
        {
            return $"{(HighContrast ? "High contrast " : "")}{Theme}";
        }

        public static bool operator ==(ThemeInfo left, ThemeInfo right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ThemeInfo left, ThemeInfo right)
        {
            return !(left == right);
        }
    }
}
