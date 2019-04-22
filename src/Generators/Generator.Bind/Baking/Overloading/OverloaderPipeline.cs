using System.Collections.Generic;
using System.Linq;
using Bind.Overloaders;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Baking.Overloading
{
    /// <summary>
    /// Represents a pipeline of function overloaders that can generate new overloads for injection into a profile.
    /// </summary>
    public class OverloaderPipeline
    {
        /// <summary>
        /// Gets the base pipeline of overloaders.
        /// </summary>
        private readonly IReadOnlyList<IFunctionOverloader> _pipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="OverloaderPipeline"/> class.
        /// </summary>
        public OverloaderPipeline()
        {
            _pipeline = GetBaselineOverloaders().ToList();
        }

        /// <summary>
        /// Gets the baseline set of function overloaders.
        /// </summary>
        /// <returns>The baseline set.</returns>
        [NotNull, ItemNotNull]
        private IEnumerable<IFunctionOverloader> GetBaselineOverloaders()
        {
            yield return new VoidPointerParameterOverloader();
            yield return new VoidPointerReturnValueOverloader();
            yield return new PointerParameterPermutationOverloader();
            yield return new ReturnTypeConvenienceOverloader();
            yield return new ArrayParameterConvenienceOverloader();
            yield return new StaticCountParameterConvenienceOverloader();
        }

        /// <summary>
        /// Determines whether or not a given function signature has an applicable stage.
        /// </summary>
        /// <param name="signature">The signature.</param>
        /// <returns>True if the function has an applicable stage; otherwise, false.</returns>
        public bool HasApplicableStage(FunctionSignature signature)
        {
            return _pipeline.Any(s => s.IsApplicable(signature));
        }

        /// <summary>
        /// Consumes a set of signatures, passing them through the given pipeline. Each stage is guaranteed to run only
        /// once for any given branch of the input signatures. The generation process follows a recursive depth-first
        /// reductive algorithm.
        /// </summary>
        /// <param name="signatures">The signatures to process.</param>
        /// <param name="pipeline">A sorted list of generators, acting as the process pipeline.</param>
        /// <returns>The augmented function list.</returns>
        public IEnumerable<FunctionSignature> ConsumeSignatures
        (
            [NotNull] IEnumerable<FunctionSignature> signatures,
            [CanBeNull] IReadOnlyList<IFunctionOverloader> pipeline = null
        )
        {
            pipeline = pipeline ?? _pipeline;

            var definitionQueue = new Queue<FunctionSignature>(signatures);

            while (definitionQueue.Any())
            {
                var signature = definitionQueue.Dequeue();

                // Find the entry stage of the pipeline
                var stage = pipeline.FirstOrDefault(s => s.IsApplicable(signature));
                if (stage is null)
                {
                    continue;
                }

                // Push the signatures through the stage
                var generatedDefinitions = stage.CreateOverloads(signature).ToList();

                // Yield the results
                foreach (var generatedOverload in generatedDefinitions)
                {
                    yield return generatedOverload;
                }

                if (!generatedDefinitions.Any())
                {
                    continue;
                }

                // Ensure that the current signature is passed through again, so that goes through all applicable
                // stages.
                var passthroughSignatures = new List<FunctionSignature>(generatedDefinitions) { signature };

                // Run the new signatures through the remaining stages of the pipeline
                var deeperDefinitions = ConsumeSignatures(passthroughSignatures, pipeline.Except(new[] { stage }).ToList());
                foreach (var deeperDefinition in deeperDefinitions)
                {
                    yield return deeperDefinition;
                }
            }
        }
    }
}
