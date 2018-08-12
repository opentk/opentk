using System;
using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using Humanizer;
using MoreLinq.Extensions;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates array parameter convenience overloads for functions.
    /// </summary>
    public class ArrayParameterConvenienceOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            // function has exactly two parameters
            var parameterCount = function.Parameters.Count;
            if (parameterCount != 2)
            {
                return false;
            }

            // function's name starts with Get, Gen, or New
            var hasCorrectPrefix = function.Name.StartsWith("Delete");
            if (!hasCorrectPrefix)
            {
                return false;
            }

            var returnType = function.ReturnType;
            if (!returnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (returnType.IsPointer)
            {
                return false;
            }

            var lastParameter = function.Parameters.Last();

            if (!lastParameter.Type.IsPointer)
            {
                return false;
            }

            // the final parameter's flow is not out
            if (lastParameter.Flow == FlowDirection.Out)
            {
                return false;
            }

            // the last parameter does not have a specific count set
            if (!(lastParameter.Count is null) && lastParameter.Count.IsStatic)
            {
                if (lastParameter.Count.Count > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public IEnumerable<FunctionSignature> CreateOverloads(FunctionSignature function)
        {
            var arrayParameter = function.Parameters.Last();
            var arrayParameterType = arrayParameter.Type;

            var newName = function.Name.Singularize(false);
            var newParameters = SkipLastExtension.SkipLast(new List<ParameterSignature>(function.Parameters), 2).ToList();

            var newArrayParameterType = new TypeSignatureBuilder(arrayParameterType)
                .WithArrayDimensions(0)
                .WithIndirectionLevel(0)
                .Build();

            var newArrayParameter = new ParameterSignatureBuilder(arrayParameter)
                .WithType(newArrayParameterType)
                .Build();

            newParameters.Add(newArrayParameter);

            yield return new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithParameters(newParameters)
                .Build();
        }
    }
}
