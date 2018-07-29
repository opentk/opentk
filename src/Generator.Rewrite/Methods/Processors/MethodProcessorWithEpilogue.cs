using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    public abstract class MethodProcessorWithEpilogue<T> : IMethodProcessorWithPostProcessor
    {
        /// <inheritdoc/>
        public IMethodProcessor PostProcessor { get; }

        protected EpilogueProcessor<T> EpilogueProcessor => (EpilogueProcessor<T>)PostProcessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodProcessorWithEpilogue{T}"/> class with a
        /// <see cref="EpilogueProcessor{T}"/> instance that will be used for epilogue processing.
        /// </summary>
        /// <param name="epilogueProcessor"></param>
        public MethodProcessorWithEpilogue(EpilogueProcessor<T> epilogueProcessor)
        {
            PostProcessor = epilogueProcessor;
        }

        /// <inheritdoc/>
        public abstract void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native);
    }
}
