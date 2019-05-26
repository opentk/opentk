//
// OverloadBaker.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.XML.Signatures.Functions;

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

            var functionsThatNeedOverloads = sigs.ToList();
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

            return uniqueOverloads.Where(x => functionsThatNeedOverloads.All(y => !y.HasSameSignatureAs(x.Item1))).ToList();
        }
    }
}
