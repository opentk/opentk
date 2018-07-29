using System;
using System.Collections.Concurrent;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    public abstract class EpilogueProcessor<T> : IMethodProcessor
    {
        /// <summary>
        /// Gets a dictionary of variables from the prologue processing step that can be used in the epilogue
        /// <see cref="ProcessEpilogue(ILProcessor, MethodDefinition, MethodDefinition, T)"/>.
        /// </summary>
        public ConcurrentDictionary<MethodDefinition, T> RewriteVariables { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EpilogueProcessor{T}"/> class.
        /// </summary>
        public EpilogueProcessor()
        {
            RewriteVariables = new ConcurrentDictionary<MethodDefinition, T>();
        }

        /// <inheritdoc/>
        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (!RewriteVariables.TryRemove(wrapper, out T variable))
            {
                throw new InvalidOperationException();
            }

            ProcessEpilogue(ilProcessor, wrapper, native, variable);
        }

        protected abstract void ProcessEpilogue
        (
            ILProcessor ilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native,
            T argument
        );
    }
}
