using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Bind.Builders;
using Bind.Translation.Translators;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Maps the type signatures of functions in a profile to their language equivalents.
    /// </summary>
    public class ProfileMapper : IMapper<ApiProfile>
    {
        private readonly FunctionMapper _glFunctionMapper;
        private readonly NativeIdentifierTranslator _identifierTranslator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileMapper"/> class.
        /// </summary>
        /// <param name="typemap">The typemap to use.</param>
        public ProfileMapper(IReadOnlyDictionary<TypeSignature, TypeSignature> typemap)
        {
            _glFunctionMapper = new FunctionMapper(typemap);
            _identifierTranslator = new NativeIdentifierTranslator();
        }

        /// <inheritdoc/>
        public bool HasMapping(ApiProfile profile)
        {
            return profile.NativeSignatures.Any(f => _glFunctionMapper.HasMapping(f));
        }

        /// <inheritdoc/>
        public ApiProfile Map(ApiProfile profile)
        {
            var functionsThatDoNotNeedMapping = profile.NativeSignatures
                .Where(f => !_glFunctionMapper.HasMapping(f))
                .ToList();

            var mappedFunctions = profile.NativeSignatures
                .Where(f => _glFunctionMapper.HasMapping(f))
                .Select(_glFunctionMapper.Map)
                .ToList();

            var allFunctions = functionsThatDoNotNeedMapping.Concat(mappedFunctions).ToList();

            var functionsThatDoNotHaveGenericEnums = allFunctions
                .Where(f => !HasGenericEnumParameters(f))
                .ToList();

            var functionsWithGenericEnums = allFunctions
                .Where(HasGenericEnumParameters)
                .ToList();

            var resolvedFunctionsWithGenericEnums = MapGenericEnumFunctions(profile, functionsWithGenericEnums);

            allFunctions = functionsThatDoNotHaveGenericEnums.Concat(resolvedFunctionsWithGenericEnums).ToList();

            return new ApiProfileBuilder(profile)
                .WithNativeSignatures(allFunctions)
                .Build();
        }

        /// <summary>
        /// Determines whether or not the given function has any generic enum parameters, including the return
        /// parameter.
        /// </summary>
        /// <param name="f">The function.</param>
        /// <returns>true if the function has generic enum parameters; otherwise, false.</returns>
        private bool HasGenericEnumParameters([NotNull] FunctionSignature f)
        {
            return f.Parameters.Any(p => p.Type.Name == "GLenum") || f.ReturnType.Name == "GLenum";
        }

        /// <summary>
        /// Maps the functions in a given profile that contain generic enum definitions to better-matching types.
        /// </summary>
        /// <param name="profile">The profile to map functions in.</param>
        /// <param name="genericEnumFunctions">The functions with generic enum parameters.</param>
        /// <returns>The mapped generic functions.</returns>
        [NotNull, ItemNotNull]
        private IEnumerable<FunctionSignature> MapGenericEnumFunctions
        (
            [NotNull] ApiProfile profile,
            [NotNull, ItemNotNull] IReadOnlyList<FunctionSignature> genericEnumFunctions
        )
        {
            var mappedGenericEnumFunctions = new List<FunctionSignature>();
            foreach (var functionWithGenericEnum in genericEnumFunctions)
            {
                var newParameters = new List<ParameterSignature>(functionWithGenericEnum.Parameters);
                for (int i = 0; i < newParameters.Count; ++i)
                {
                    var parameter = newParameters[i];
                    var parameterType = parameter.Type;

                    if (parameterType.Name != "GLenum")
                    {
                        continue;
                    }

                    var newParameterType = MapGenericEnumerationType(profile, functionWithGenericEnum, parameterType);
                    var newParameter = new ParameterSignatureBuilder(parameter).WithType(newParameterType).Build();

                    newParameters[i] = newParameter;
                }

                var newReturnType = functionWithGenericEnum.ReturnType;
                if (newReturnType.Name == "GLenum")
                {
                    newReturnType = MapGenericEnumerationType(profile, functionWithGenericEnum, newReturnType);
                }

                var newFunction = new FunctionSignatureBuilder(functionWithGenericEnum)
                    .WithParameters(newParameters)
                    .WithReturnType(newReturnType)
                    .Build();

                mappedGenericEnumFunctions.Add(newFunction);

                Debug.WriteLine
                (
                    $"Mapped parameters in \"{functionWithGenericEnum.Name}\" to generic enum types. Consider adding" +
                    $" an override to a more specialized enum."
                );
            }

            return mappedGenericEnumFunctions;
        }

        /// <summary>
        /// Maps generic enumeration types (that is, GLenum) to a best-match equivalent. Typically, this maps to the
        /// catch-all enumeration for the extension the function is in. If there is none, it maps to an unsigned
        /// integer.
        /// </summary>
        /// <param name="profile">The profile that contains the function.</param>
        /// <param name="containingFunction">The function that contains the generic enumeration.</param>
        /// <param name="baseParameterType">The type of the base parameter.</param>
        /// <returns>The mapped type.</returns>
        [NotNull]
        private TypeSignature MapGenericEnumerationType
        (
            [NotNull] ApiProfile profile,
            [NotNull] FunctionSignature containingFunction,
            [NotNull] TypeSignature baseParameterType
        )
        {
            foreach (var categoryName in containingFunction.Categories)
            {
                var translatedName = _identifierTranslator.Translate(categoryName);

                var genericEnumeration = profile.Enumerations.FirstOrDefault(e => e.Name == translatedName);
                if (!(genericEnumeration is null))
                {
                    return new TypeSignatureBuilder(baseParameterType).WithName(genericEnumeration.Name).Build();
                }
            }

            // No enumeration found, falling back to a simple integer
            return new TypeSignatureBuilder(baseParameterType).WithName("uint").Build();
        }
    }
}
