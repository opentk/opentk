using System;
using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.Structures;
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
            return pointerParameters.Any() &&
                   pointerParameters.All
                   (
                       p =>
                           !p.Type.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase)
                   );
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

                var refTypeBuilder = new TypeSignatureBuilder(baseType)
                    .WithIndirectionLevel(0)
                    .WithByRef(true);

                if (baseParameter.Flow == FlowDirection.Out)
                {
                    refTypeBuilder = refTypeBuilder.WithIsOut(true);
                }

                var refType = refTypeBuilder.Build();

                var arrayType = new TypeSignatureBuilder(baseType)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(1)
                    .Build();

                var refParameter = new ParameterSignatureBuilder(baseParameter)
                    .WithType(refType)
                    .Build();

                var arrayParameter = new ParameterSignatureBuilder(baseParameter)
                    .WithType(arrayType)
                    .Build();

                refParameterPermutation[i] = refParameter;
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
