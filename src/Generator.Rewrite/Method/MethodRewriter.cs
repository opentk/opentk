using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Method.Processors;

namespace OpenTK.Rewrite.Method
{
    public class MethodRewriter
    {
        private readonly IMethodProcessor[] _processors;

        public MethodRewriter(IMethodProcessor[] methodProcessors)
        {
            _processors = methodProcessors ?? throw new ArgumentNullException(nameof(methodProcessors));
        }

        public MethodDefinition ProcessWrapper(MethodDefinition native, MethodDefinition wrapper)
        {
            wrapper.Body.Instructions.Clear();
            var ilProcessor = wrapper.Body.GetILProcessor();

            foreach (var processor in _processors)
            {
                processor.Process(ilProcessor, wrapper, native);
            }

            // some processors here are coupled with an "epilogue" step.
            // if one of the processors has an epilogue associated, run that now
            foreach (var processor in _processors.Reverse())
            {
                if (processor is IMethodProcessorWithEpilogue p)
                {
                    p.EpilogueProcessor.Process(ilProcessor, wrapper, native);
                }
            }

            ilProcessor.Emit(OpCodes.Ret);

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
