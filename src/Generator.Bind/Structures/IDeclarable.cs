namespace Bind.Structures
{
    /// <summary>
    /// Represents a type that can declare itself in source code.
    /// </summary>
    public interface IDeclarable
    {
        /// <summary>
        /// Converts the object into a valid declaration string.
        /// </summary>
        /// <returns>The declaration string.</returns>
        string GetDeclarationString();
    }
}
