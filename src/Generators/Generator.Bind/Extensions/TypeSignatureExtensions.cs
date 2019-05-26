//
// TypeSignatureExtensions.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Extensions
{
    /// <summary>
    /// Contains extension methods for the <see cref="TypeSignatureExtensions"/> class.
    /// </summary>
    public static class TypeSignatureExtensions
    {
        /// <summary>
        /// Determines whether the given type is a void pointer.
        /// </summary>
        /// <param name="typeSignature">The type signature.</param>
        /// <returns>true if the type is a void pointer; otherwise, false.</returns>
        public static bool IsVoidPointer([NotNull] this TypeSignature typeSignature)
        {
            return typeSignature.Name.Equals
                   (
                       typeof(void).Name.ToLowerInvariant(),
                       StringComparison.OrdinalIgnoreCase
                   )
                   && typeSignature.IndirectionLevel == 1;
        }
    }
}
