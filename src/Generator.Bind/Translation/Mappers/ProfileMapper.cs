using System;
using System.Collections.Generic;
using System.Linq;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the type signatures of functions in a profile to their language equivalents.
    /// </summary>
    public class ProfileMapper : IMapper<ApiProfile>
    {
        private readonly FunctionMapper _glFunctionMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public ProfileMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glFunctionMapper = new FunctionMapper(typemap);
        }

        /// <inheritdoc/>
        public bool HasMapping(ApiProfile profile)
        {
            return profile.Functions.Any(f => _glFunctionMapper.HasMapping(f));
        }

        /// <inheritdoc/>
        public ApiProfile Map(ApiProfile profile)
        {
            var mappedFunctions = profile.Functions
                .Where(f => _glFunctionMapper.HasMapping(f))
                .Select(_glFunctionMapper.Map)
                .ToList();

            return new ApiProfile(profile.Name, profile.Versions, mappedFunctions, profile.Enumerations);
        }
    }
}
