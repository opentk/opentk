//
// TypeSignatureBuilder.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Builders
{
    /// <summary>
    /// Acts as a builder for new instances of <see cref="TypeSignature"/>s, based on existing instances.
    /// </summary>
    public sealed class TypeSignatureBuilder
    {
        [NotNull]
        private string _newName;

        private int _newIndirectionLevel;

        private int _newArrayDimensions;

        private bool _newIsByRef;

        private bool _newIsOut;
        private bool _newIsIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignatureBuilder"/> class.
        /// </summary>
        /// <param name="typeSignature">The signature.</param>
        public TypeSignatureBuilder([NotNull] TypeSignature typeSignature)
        {
            _newName = typeSignature.Name;
            _newIndirectionLevel = typeSignature.IndirectionLevel;
            _newArrayDimensions = typeSignature.ArrayDimensions;
            _newIsIn = typeSignature.IsIn;
            _newIsOut = typeSignature.IsOut;
            _newIsByRef = typeSignature.IsByRef;
        }

        /// <summary>
        /// Sets a new name for the type signature.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the name.</returns>
        [NotNull]
        public TypeSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new indirection level for the type signature.
        /// </summary>
        /// <param name="newIndirectionLevel">The new indirection level.</param>
        /// <returns>The builder, with the level.</returns>
        [NotNull]
        public TypeSignatureBuilder WithIndirectionLevel(int newIndirectionLevel)
        {
            _newIndirectionLevel = newIndirectionLevel;
            return this;
        }

        /// <summary>
        /// Sets a new array dimension for the type signature.
        /// </summary>
        /// <param name="newArrayDimensions">The new array dimension.</param>
        /// <returns>The builder, with the name.</returns>
        [NotNull]
        public TypeSignatureBuilder WithArrayDimensions(int newArrayDimensions)
        {
            _newArrayDimensions = newArrayDimensions;
            return this;
        }

        /// <summary>
        /// Sets a new by-ref value for the type signature.
        /// </summary>
        /// <param name="isByRef">The new by-ref value.</param>
        /// <returns>The builder, with the by-ref value.</returns>
        [NotNull]
        public TypeSignatureBuilder WithByRef(bool isByRef)
        {
            _newIsByRef = isByRef;
            return this;
        }

        /// <summary>
        /// Sets a new is-out value for the type signature.
        /// </summary>
        /// <param name="isOut">The new is-out value.</param>
        /// <returns>The builder, with the is-out value.</returns>
        [NotNull]
        public TypeSignatureBuilder WithIsOut(bool isOut)
        {
            _newIsOut = isOut;
            return this;
        }

        /// <summary>
        /// Sets a new is-in value for the type signature.
        /// </summary>
        /// <param name="isIn">The new is-in value.</param>
        /// <returns>The builder, with the is-in value.</returns>
        [NotNull]
        public TypeSignatureBuilder WithIsIn(bool isIn)
        {
            _newIsIn = isIn;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public TypeSignature Build()
        {
            return new TypeSignature(_newName, _newIndirectionLevel, _newArrayDimensions, _newIsByRef, _newIsOut, _newIsIn);
        }
    }
}
