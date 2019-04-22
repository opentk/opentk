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
    /// Creates <see cref="IntPtr"/> return value overloads for functions returning a void pointer (of any depth).
    /// </summary>
    public class VoidPointerReturnValueOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(FunctionSignature function)
        {
            return function.ReturnType.IsVoidPointer();
        }

        /// <inheritdoc/>
        public IEnumerable<(FunctionSignature, StringBuilder)> CreateOverloads(FunctionSignature function)
        {
            var newReturnType = new TypeSignatureBuilder(function.ReturnType)
                .WithIndirectionLevel(0)
                .WithName(nameof(IntPtr))
                .Build();

            yield return Cast(new FunctionSignatureBuilder(function)
                .WithReturnType(newReturnType)
                .Build());
        }

        private (FunctionSignature, StringBuilder) Cast(FunctionSignature function)
        {
            var sb = new StringBuilder();
            sb.Append("return (IntPtr) " + function.Name + "(");
            sb.Append(string.Join(", ", function.Parameters.Select(x => x.Name)));
            sb.AppendLine(");");
            return (function, sb);
        }
    }
}
