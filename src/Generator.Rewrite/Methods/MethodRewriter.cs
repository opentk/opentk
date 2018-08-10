using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Methods.Processors;

namespace OpenTK.Rewrite.Methods
{
    /// <summary>
    /// A class that provides functionality to rewrite the IL of an unfinished wrapper method to call a specified
    /// native function either via DllImport or a given entry point.<para/>
    /// This class uses multiple <see cref="IMethodProcessor"/> instances
    /// that define the actual method rewriting process.
    /// </summary>
    public sealed class MethodRewriter : IMethodRewriter
    {
        private readonly IMethodProcessor[] _processors;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodRewriter"/> class.
        /// </summary>
        /// <param name="methodProcessors">
        /// An array of <see cref="IMethodProcessor"/> instances that define the actual rewriting process.
        /// </param>
        public MethodRewriter(IMethodProcessor[] methodProcessors)
        {
            _processors = methodProcessors ?? throw new ArgumentNullException(nameof(methodProcessors));
        }

        /// <inheritdoc/>
        public MethodDefinition Rewrite(MethodDefinition wrapper, MethodDefinition native)
        {
            wrapper.Body.Instructions.Clear();
            var cilProcessor = wrapper.Body.GetILProcessor();

            foreach (var processor in _processors)
            {
                processor.Process(cilProcessor, wrapper, native);
            }

            // some processors here are coupled with an "epilogue" step.
            // if one of the processors has an epilogue associated, run it now
            foreach (var processor in _processors.Reverse())
            {
                if (processor is IMethodProcessorWithPostProcessor p)
                {
                    p.PostProcessor.Process(cilProcessor, wrapper, native);
                }
            }

            cilProcessor.Emit(OpCodes.Ret);

            if (wrapper.Body.Variables.Count > 0)
            {
                // Required for verifiable executables
                // (otherwise peverify complains bitterly)
                wrapper.Body.InitLocals = true;
            }

            wrapper.Body.OptimizeMacros();

            return wrapper;
        }
    }
}
