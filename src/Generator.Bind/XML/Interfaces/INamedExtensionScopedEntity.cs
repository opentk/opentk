using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Interface for a named entity that can exist within an API extension.
    /// </summary>
    public interface INamedExtensionScopedEntity
    {
        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        [NotNull]
        string Name { get; }

        /// <summary>
        /// Gets the extension the entity belongs to.
        /// </summary>
        [CanBeNull]
        string Extension { get; }
    }
}
