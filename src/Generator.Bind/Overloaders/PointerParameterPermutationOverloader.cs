using System;
using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates pointer parameter convenience overloads for functions.
    /// </summary>
    public class PointerParameterPermutationOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            var pointerParameters = function.Parameters.Where(p => p.Type.IsPointer).ToList();
            return pointerParameters.Any();
        }

        /// <inheritdoc/>
        public IEnumerable<FunctionSignature> CreateOverloads(FunctionSignature function)
        {
            var baseParameters = function.Parameters;

            var refParameterPermutation = new List<ParameterSignature>(baseParameters);
            var arrayParameterPermutation = new List<ParameterSignature>(baseParameters);
            for (int i = 0; i < baseParameters.Count; ++i)
            {
                var baseParameter = baseParameters[i];
                var baseType = baseParameter.Type;

                if (!baseType.IsPointer || baseType.IndirectionLevel > 1)
                {
                    continue;
                }

                if (baseType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
                {
                    // Skip void pointers
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

                refParameterPermutation[i] = refParameter;

                if (!(baseParameter.Count is null) && baseParameter.Count.IsStatic && baseParameter.Count.Count == 1)
                {
                    // Single-element count pointers don't need array overloads
                    continue;
                }

                var arrayType = new TypeSignatureBuilder(baseType)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(1)
                    .Build();

                var arrayParameter = new ParameterSignatureBuilder(baseParameter)
                    .WithType(arrayType)
                    .Build();

                arrayParameterPermutation[i] = arrayParameter;
            }

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(refParameterPermutation)
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(arrayParameterPermutation)
                .Build();
        }
    }
}
