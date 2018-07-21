using System.Collections.Generic;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps OpenGL types to C# language types.
    /// </summary>
    public class OpenGLTypeMapper : IMapper<TypeSignature>
    {
        private readonly IReadOnlyDictionary<TypeSignature, TypeSignature> _typemap;
        private readonly bool _allowPassthrough;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLTypeMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        /// <param name="allowPassthrough">
        /// Whether or not type that do not have a mapping should just be passed through. Defaults to true.
        /// </param>
        public OpenGLTypeMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap, bool allowPassthrough = true)
        {
            _typemap = typemap;
            _allowPassthrough = allowPassthrough;
        }

        /// <inheritdoc/>
        public bool HasMapping(TypeSignature input)
        {
            return _typemap.ContainsKey(input);
        }

        /// <inheritdoc/>
        public TypeSignature Map(TypeSignature input)
        {
            if (_typemap.TryGetValue(input, out var result))
            {
                return result;
            }

            if (!_allowPassthrough)
            {
                throw new KeyNotFoundException("Could not find a valid mapping for the given type.");
            }

            return input;
        }
    }
}
