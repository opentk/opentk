using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates fixed-size element parameter overloads for functions with static count parameters.
    /// </summary>
    public class StaticCountParameterConvenienceOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            return function.Parameters.Any(HasStaticCount);
        }

        /// <summary>
        /// Determines whether or not the given parameter has a static count set.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns>True if the parameter has a static count; otherwise, false.</returns>
        private bool HasStaticCount([NotNull] ParameterSignature parameter)
        {
            return !(parameter.Count is null) && parameter.Count.IsStatic;
        }

        /// <inheritdoc/>
        public IEnumerable<FunctionSignature> CreateOverloads(FunctionSignature function)
        {
            var baseParameters = function.Parameters;

            var staticCountPermutation = new List<ParameterSignature>(baseParameters);
            for (int i = 0; i < baseParameters.Count; ++i)
            {
                var baseParameter = baseParameters[i];
                var baseType = baseParameter.Type;

                if (!HasStaticCount(baseParameter))
                {
                    continue;
                }

                // ReSharper disable once PossibleNullReferenceException
                var count = baseParameter.Count.Count;

                if (count > 1)
                {
                    // TODO: Support higher-ranked types
                    continue;
                }

                if (!baseType.IsPointer || baseType.IndirectionLevel > 1)
                {
                    continue;
                }

                var refTypeBuilder = new TypeSignatureBuilder(baseType)
                    .WithIndirectionLevel(0)
                    .WithByRef(true);

                if (baseParameter.Flow == FlowDirection.Out)
                {
                    refTypeBuilder = refTypeBuilder.WithIsOut(true);
                }

                var refType = refTypeBuilder.Build();

                var refParameter = new ParameterSignatureBuilder(baseParameter)
                    .WithType(refType)
                    .Build();

                staticCountPermutation[i] = refParameter;
            }

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(staticCountPermutation)
                .Build();
        }
    }
}
