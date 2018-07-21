using System.Collections.Generic;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the types of OpenGL parameters to their language equivalents.
    /// </summary>
    public class OpenGLParameterMapper : IMapper<ParameterSignature>
    {
        private readonly OpenGLTypeMapper _glTypeMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLParameterMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public OpenGLParameterMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glTypeMapper = new OpenGLTypeMapper(typemap);
        }

        /// <inheritdoc/>
        public bool HasMapping(ParameterSignature input)
        {
            return _glTypeMapper.HasMapping(input.Type);
        }

        /// <inheritdoc/>
        public ParameterSignature Map(ParameterSignature input)
        {
            var newType = _glTypeMapper.Map(input.Type);

            return new ParameterSignature
            (
                input.Name,
                newType,
                input.Flow,
                input.Count
            );
        }
    }
}
