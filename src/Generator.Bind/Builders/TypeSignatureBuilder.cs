using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Builders
{
    /// <summary>
    /// Acts as a builder for new instances of <see cref="TypeSignature"/>s, based on existing instances.
    /// </summary>
    public sealed class TypeSignatureBuilder
    {
        private string _newName;

        private int _newIndirectionLevel;

        private int _newArrayDimensions;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignatureBuilder"/> class.
        /// </summary>
        /// <param name="typeSignature">The signature.</param>
        public TypeSignatureBuilder([NotNull] TypeSignature typeSignature)
        {
            _newName = typeSignature.Name;
            _newIndirectionLevel = typeSignature.IndirectionLevel;
            _newArrayDimensions = typeSignature.ArrayDimensions;
        }

        /// <summary>
        /// Sets a new name for the type signature.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the name.</returns>
        [NotNull]
        public TypeSignatureBuilder WithName(string newName)
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
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public TypeSignature Build()
        {
            return new TypeSignature(_newName, _newIndirectionLevel, _newArrayDimensions);
        }
    }
}
