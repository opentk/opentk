namespace OpenTK.Rewrite.Methods.Processors
{
    public interface IMethodProcessorWithEpilogue : IMethodProcessor
    {
        IMethodProcessor EpilogueProcessor { get; }
    }
}
