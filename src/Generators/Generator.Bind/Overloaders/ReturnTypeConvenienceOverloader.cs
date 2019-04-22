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
    /// Creates return type convenience overloads for functions.
    /// </summary>
    public class ReturnTypeConvenienceOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            // function has 1 - 2 parameters
            var parameterCount = function.Parameters.Count;
            if (parameterCount == 0 || parameterCount > 2)
            {
                return false;
            }

            // function's name starts with Get, Gen, or New
            var hasCorrectPrefix = function.Name.StartsWith("Get") ||
                                   function.Name.StartsWith("Gen") ||
                                   function.Name.StartsWith("New");
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

            // the final parameter's flow is out
            if (lastParameter.Flow != FlowDirection.Out)
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
            var lastParameterType = function.Parameters.Last().Type;
            var newReturnType = new TypeSignatureBuilder(lastParameterType)
                .WithIndirectionLevel(lastParameterType.IndirectionLevel - 1)
                .WithArrayDimensions(0)
                .Build();

            var newParameters = SkipLastExtension.SkipLast(function.Parameters, 1).ToList();
            var newName = function.Name.Singularize(false);

            var functionBuilder = new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithReturnType(newReturnType);

            if (!newParameters.Any())
            {
                yield return functionBuilder
                    .WithParameters(newParameters)
                    .Build();

                yield break;
            }

            // TODO: check if this has anything to do with CLS compliance
            var sizeParameterType = newParameters.Last().Type;
            if (!sizeParameterType.Name.StartsWith("int", StringComparison.OrdinalIgnoreCase) || sizeParameterType.IsPointer)
            {
                yield return functionBuilder
                    .WithParameters(newParameters)
                    .Build();

                yield break;
            }

            newParameters = SkipLastExtension.SkipLast(newParameters, 1).ToList();
            yield return functionBuilder
                    .WithParameters(newParameters)
                    .Build();
        }
    }
}
