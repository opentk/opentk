using System;
using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.Extensions;
using Bind.XML.Signatures.Functions;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates generic type parameter overloads for functions taking a void pointer (of any depth).
    /// </summary>
    public class VoidPointerParameterOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            return function.Parameters.Any(p => p.Type.IsVoidPointer());
        }

        /// <inheritdoc/>
        public IEnumerable<FunctionSignature> CreateOverloads(FunctionSignature function)
        {
            var baseParameters = function.Parameters;

            var newIntPtrParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray1DParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray2DParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray3DParameters = new List<ParameterSignature>(baseParameters);
            var newGenericRefParameters = new List<ParameterSignature>(baseParameters);

            var newGenericTypeParameters = new List<GenericTypeParameterSignature>();
            for (int i = 0; i < baseParameters.Count; ++i)
            {
                var parameter = baseParameters[i];
                if (!parameter.Type.IsVoidPointer())
                {
                    continue;
                }

                string genericTypeParameterName;
                if (baseParameters.Count(p => p.Type.IsVoidPointer()) > 1)
                {
                    genericTypeParameterName = $"T{newGenericTypeParameters.Count + 1}";
                }
                else
                {
                    genericTypeParameterName = "T";
                }

                var genericTypeParameter = new GenericTypeParameterSignature(genericTypeParameterName);

                newGenericTypeParameters.Add(genericTypeParameter);

                var newIntPtrParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithName(nameof(IntPtr))
                    .Build();

                // TODO: Simplify and generalize this
                var newGenericArray1DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(1)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray2DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(2)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray3DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(3)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericRefParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithName(genericTypeParameterName)
                    .WithByRef(true)
                    .Build();

                newIntPtrParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newIntPtrParameterType)
                    .Build();

                newGenericArray1DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray1DParameterType)
                    .Build();

                newGenericArray2DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray2DParameterType)
                    .Build();

                newGenericArray3DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray3DParameterType)
                    .Build();

                newGenericRefParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericRefParameterType)
                    .Build();
            }

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(newIntPtrParameters)
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray1DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray2DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray3DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithParameters(newGenericRefParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build();
        }
    }
}
