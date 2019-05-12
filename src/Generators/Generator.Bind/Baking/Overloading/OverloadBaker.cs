using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Baking.Overloading
{
    /// <summary>
    /// Bakes overloads (for convenience, API flexibility, etc) into a given profile.
    /// </summary>
    public static class OverloadBaker
    {
        /// <summary>
        /// Gets the overloads for the given signatures.
        /// </summary>
        /// <param name="sigs">The signatures to overload.</param>
        /// <returns>The overloads.</returns>
        public static IEnumerable<(FunctionSignature, StringBuilder)> GetOverloads(IEnumerable<FunctionSignature> sigs)
        {
            var pipeline = new OverloaderPipeline();

            var functionsThatNeedOverloads = sigs.Where(f => pipeline.HasApplicableStage(f));
            var newOverloads = pipeline.ConsumeSignatures(functionsThatNeedOverloads).ToList();

            // Discard duplicate overloads
            var uniqueOverloads = new List<(FunctionSignature, StringBuilder)>();
            foreach (var function in newOverloads)
            {
                if (uniqueOverloads.Any(f => f.Item1.HasSameSignatureAs(function.Item1)))
                {
                    continue;
                }

                uniqueOverloads.Add(function);
            }

            return uniqueOverloads.Where(x => sigs.All(y => !y.HasSameSignatureAs(x.Item1))).ToList();
        }
    }
}
