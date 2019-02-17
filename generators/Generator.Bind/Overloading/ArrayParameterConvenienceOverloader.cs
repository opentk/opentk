using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Common.Builders;
using Generator.Common.Functions;
using Humanizer;
using MoreLinq.Extensions;

namespace Generator.Bind.Overloading
{
       /// <summary>
    /// Creates array parameter convenience overloads for functions.
    /// </summary>
    public class ArrayParameterConvenienceOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(Function function)
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
                if (lastParameter.Count.StaticCount > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            var arrayParameter = function.Parameters.Last();
            var arrayParameterType = arrayParameter.Type;

            var newName = function.Name.Singularize(false);
            var newParameters = new List<Parameter>(function.Parameters).SkipLast(2).ToList();

            var newArrayParameterType = new TypeSignatureBuilder(arrayParameterType)
                .WithArrayDimensions(0)
                .WithIndirectionLevel(0)
                .Build();

            var newArrayParameter = new ParameterSignatureBuilder(arrayParameter)
                .WithType(newArrayParameterType)
                .Build();

            newParameters.Add(newArrayParameter);

            var sig = new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithParameters(newParameters)
                .Build();
            var sb = new StringBuilder();
            
            sb.AppendLine(function.Name+"(1, &"+newArrayParameter.Name+");");
            
            yield return new Overload(sig, sb, true);
        }
    }
}