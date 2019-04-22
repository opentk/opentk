namespace Bind.XML.Overrides
{
    /// <summary>
    /// Indicates whether the name of an override refers to the native entrypoint or the public-facing API name.
    /// </summary>
    public enum OverrideNameType
    {
        /// <summary>
        /// Indicates that the name is an entry point.
        /// </summary>
        EntryPoint,

        /// <summary>
        /// Indicates that the name is a name.
        /// </summary>
        Name
    }
}
