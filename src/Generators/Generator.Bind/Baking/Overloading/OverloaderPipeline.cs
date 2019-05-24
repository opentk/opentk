//
// OverloaderPipeline.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.Builders;
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
        [NotNull]
        [ItemNotNull]
        private static IEnumerable<IFunctionOverloader> GetBaselineOverloaders()
        {
            yield return new VoidPointerParameterOverloader();
            yield return new VoidPointerReturnValueOverloader();
            yield return new ReturnTypeConvenienceOverloader();
            yield return new ArrayParameterConvenienceOverloader();
        }

        /// <summary>
        /// Consumes a set of signatures, passing them through the given pipeline.
        /// </summary>
        /// <param name="signatures">The signatures to process.</param>
        /// <param name="pipeline">A sorted list of generators, acting as the process pipeline.</param>
        /// <returns>The augmented overload list.</returns>
        public IEnumerable<(FunctionSignature, StringBuilder)> ConsumeSignatures(
            [NotNull] IEnumerable<FunctionSignature> signatures,
            [CanBeNull] IReadOnlyList<IFunctionOverloader> pipeline = null)
        {
            return signatures.SelectMany(
                x => (pipeline ?? _pipeline)
                    .Select(
                        y => y.CreateOverloads(x).Select(
                            z => (new FunctionSignatureBuilder(z.Item1).WithSource(y.GetType().Name).Build(), z.Item2))))
            .SelectMany(x => x);
        }
    }
}
