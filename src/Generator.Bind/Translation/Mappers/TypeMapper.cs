using System.Collections.Generic;
using Bind.Builders;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps OpenGL types to C# language types.
    /// </summary>
    public class TypeMapper : IMapper<TypeSignature>
    {
        private readonly IReadOnlyDictionary<TypeSignature, TypeSignature> _typemap;
        private readonly bool _allowPassthrough;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        /// <param name="allowPassthrough">
        /// Whether or not type that do not have a mapping should just be passed through. Defaults to true.
        /// </param>
        public TypeMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap, bool allowPassthrough = true)
        {
            _typemap = typemap;
            _allowPassthrough = allowPassthrough;
        }

        /// <inheritdoc/>
        public bool HasMapping(TypeSignature input)
        {
            if (input.IsArray || input.IsPointer)
            {
                var baseType = new TypeSignatureBuilder(input)
                    .WithArrayDimensions(0)
                    .WithIndirectionLevel(0)
                    .Build();

                if (_typemap.TryGetValue(baseType, out _))
                {
                    return true;
                }
            }

            return _typemap.ContainsKey(input);
        }

        /// <inheritdoc/>
        public TypeSignature Map(TypeSignature input)
        {
            if (_typemap.TryGetValue(input, out var result))
            {
                return result;
            }

            if (input.IsArray || input.IsPointer)
            {
                var baseType = new TypeSignatureBuilder(input)
                    .WithArrayDimensions(0)
                    .WithIndirectionLevel(0)
                    .Build();

                if (_typemap.TryGetValue(baseType, out var baseMappedType))
                {
                    var newMappedType = new TypeSignatureBuilder(baseMappedType)
                        .WithArrayDimensions(baseMappedType.ArrayDimensions + input.ArrayDimensions)
                        .WithIndirectionLevel(baseMappedType.IndirectionLevel + input.IndirectionLevel)
                        .Build();

                    return newMappedType;
                }
            }

            if (!_allowPassthrough)
            {
                throw new KeyNotFoundException("Could not find a valid mapping for the given type.");
            }

            return input;
        }
    }
}
