using Bind.Versioning;
using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Interface abstracting over an API profile.
    /// </summary>
    public interface IApiProfile
    {
        /// <summary>
        /// Gets the name of the profile.
        /// </summary>
        [NotNull]
        string Name { get; }

        /// <summary>
        /// Gets the version range of the profile, that is, which versions it encompasses.
        /// </summary>
        [NotNull]
        VersionRange Versions { get; }
    }
}
