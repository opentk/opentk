using System;
using System.Collections.Generic;
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
        public IEnumerable<FunctionSignature> CreateOverloads(FunctionSignature function)
        {
            var newReturnType = new TypeSignatureBuilder(function.ReturnType)
                .WithIndirectionLevel(0)
                .WithName(nameof(IntPtr))
                .Build();

            yield return new FunctionSignatureBuilder(function)
                .WithReturnType(newReturnType)
                .Build();
        }
    }
}
