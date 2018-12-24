namespace Generator.Bind.Generators
{
    /// <summary>
    /// Represents configuration for the writers.
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Gets the name of this generator.
        /// </summary>
        string Name { get; }
    }
}
