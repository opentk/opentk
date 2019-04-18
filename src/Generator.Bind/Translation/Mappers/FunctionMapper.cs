using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the type signatures of an OpenGL function to their C# language equivalents.
    /// </summary>
    public class FunctionMapper : IMapper<FunctionSignature>
    {
        private readonly TypeMapper _glTypeMapper;
        private readonly ParameterMapper _glParameterMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public FunctionMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glTypeMapper = new TypeMapper(typemap);
            _glParameterMapper = new ParameterMapper(typemap);
        }

        /// <inheritdoc/>
        public bool HasMapping(FunctionSignature input)
        {
            if (_glTypeMapper.HasMapping(input.ReturnType))
            {
                return true;
            }

            return input.Parameters.Any(p => _glParameterMapper.HasMapping(p));
        }

        /// <inheritdoc/>
        public FunctionSignature Map(FunctionSignature input)
        {
            var newReturnType = _glTypeMapper.Map(input.ReturnType);
            var newParameters = input.Parameters.Select(_glParameterMapper.Map).ToList();

            return new FunctionSignatureBuilder(input)
                .WithReturnType(newReturnType)
                .WithParameters(newParameters)
                .Build();
        }
    }
}
