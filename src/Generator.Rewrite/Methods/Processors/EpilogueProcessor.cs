using System;
using System.Collections.Concurrent;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Provides functionality for additional (epilogue) processing that is dependent
    /// on an earlier (prologue) rewriting step.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the variable that will be passed from the prologue to the epilogue rewriting step.
    /// </typeparam>
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
        public void Process(ILProcessor cilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (!RewriteVariables.TryRemove(wrapper, out T variable))
            {
                throw new InvalidOperationException();
            }

            ProcessEpilogue(cilProcessor, wrapper, native, variable);
        }

        /// <summary>
        /// Implements the actual epilogue rewriting step.
        /// </summary>
        /// <param name="cilProcessor">The IL processor for the wrapper method definition.</param>
        /// <param name="wrapper">The method definition for the managed wrapper method.</param>
        /// <param name="native">The method definition for the native function.</param>
        /// <param name="argument">Additional information that was created in the epilogue rewriting step.</param>
        protected abstract void ProcessEpilogue
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native,
            T argument
        );
    }
}
