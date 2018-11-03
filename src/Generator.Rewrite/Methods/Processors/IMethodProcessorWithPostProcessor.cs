namespace OpenToolkit.Rewrite.Methods.Processors
{
    /// <summary>
    /// Provides functionality to rewrite a method definition for a managed wrapper method, with an additional
    /// post-processing step attached to it.
    /// </summary>
    public interface IMethodProcessorWithPostProcessor : IMethodProcessor
    {
        /// <summary>
        /// Gets a <see cref="IMethodProcessor"/> instance that is used for the post-processing step.
        /// </summary>
        IMethodProcessor PostProcessor { get; }
    }
}
