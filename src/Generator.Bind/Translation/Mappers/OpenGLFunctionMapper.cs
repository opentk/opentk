using System.Collections.Generic;
using System.Linq;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the type signatures of an OpenGL function to their C# language equivalents.
    /// </summary>
    public class OpenGLFunctionMapper : IMapper<FunctionSignature>
    {
        private readonly OpenGLTypeMapper _glTypeMapper;
        private readonly OpenGLParameterMapper _glParameterMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLFunctionMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public OpenGLFunctionMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glTypeMapper = new OpenGLTypeMapper(typemap);
            _glParameterMapper = new OpenGLParameterMapper(typemap);
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

            return new FunctionSignature
            (
                input.Name,
                input.NativeEntrypoint,
                input.Category,
                input.Extension,
                input.IntroducedIn,
                newReturnType,
                newParameters,
                input.DeprecatedIn,
                input.DeprecationReason
            );
        }
    }
}
