namespace OpenTK.Rewrite.Method.Processors
{
    public interface IMethodProcessorWithEpilogue : IMethodProcessor
    {
        IMethodProcessor EpilogueProcessor { get; }
    }
}
