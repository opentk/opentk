//
// VoidPointerParameterOverloader.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IEnumerable<(FunctionSignature, StringBuilder)> CreateOverloads(FunctionSignature function)
        {
            if (!function.Parameters.Any(p => p.Type.IsVoidPointer()))
            {
                yield break;
            }

            var baseParameters = function.Parameters;

            var newIntPtrParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray1DParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray2DParameters = new List<ParameterSignature>(baseParameters);
            var newGenericArray3DParameters = new List<ParameterSignature>(baseParameters);

            var newGenericTypeParameters = new List<GenericTypeParameterSignature>();
            for (var i = 0; i < baseParameters.Count; ++i)
            {
                var parameter = baseParameters[i];
                if (!parameter.Type.IsVoidPointer())
                {
                    continue;
                }

                var genericTypeParameterName = baseParameters.Count(p => p.Type.IsVoidPointer()) > 1
                    ? $"T{newGenericTypeParameters.Count + 1}" : "T";

                var genericTypeParameter = new GenericTypeParameterSignature(
                    genericTypeParameterName,
                    new[] { "unmanaged" });

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
            }

            yield return ToPointer
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newIntPtrParameters)
                    .Build(),
                function
            );

            yield return Fixed
            (    
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray1DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return Fixed
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray2DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return Fixed
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray3DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );
        }

        private static (FunctionSignature, StringBuilder) ToPointer(FunctionSignature function, FunctionSignature old)
        {
            var sb = new StringBuilder();
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.Append(function.Name + "(");
            var list = new List<string>();
            foreach (var param in old.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? "@" + param.Name : param.Name;
                if (param.Type.IsVoidPointer())
                {
                    list.Add(nm + ".ToPointer()");
                }
                else
                {
                    list.Add(nm);
                }
            }

            sb.Append(string.Join(", ", list));
            sb.AppendLine(");");
            return (function, sb);
        }

        private static (FunctionSignature, StringBuilder) Fixed(FunctionSignature function)
        {
            var sb = new StringBuilder();
            var parameters = new List<string>();
            var ind = string.Empty;
            foreach (var param in function.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? "@" + param.Name : param.Name;
                if (function.GenericTypeParameters.Any(x => x.Name == param.Type.Name))
                {
                    sb.AppendLine(ind + "fixed (" + param.Type.Name + "* " + param.Name + "Ptr = " + nm + ")");
                    sb.AppendLine(ind + "{");
                    ind += "    ";
                    parameters.Add(param.Name + "Ptr");
                }
                else
                {
                    parameters.Add(nm);
                }
            }

            sb.AppendLine(ind + function.Name + "(" + string.Join(", ", parameters) + ");");

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine(ind + "}");
            }

            return (function, sb);
        }
    }
}
