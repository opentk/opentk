using System;
using System.Collections.Generic;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the types of OpenGL parameters to their language equivalents.
    /// </summary>
    public class ParameterMapper : IMapper<ParameterSignature>
    {
        private readonly TypeMapper _glTypeMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public ParameterMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glTypeMapper = new TypeMapper(typemap);
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

            if (newType.Name.Equals("string", StringComparison.OrdinalIgnoreCase))
            {
                if (input.Flow == FlowDirection.Out)
                {
                    newType = new TypeSignatureBuilder(newType)
                        .WithByRef(true)
                        .WithIsOut(true)
                        .Build();
                }
            }

            return new ParameterSignatureBuilder(input)
                .WithType(newType)
                .Build();
        }
    }
}
