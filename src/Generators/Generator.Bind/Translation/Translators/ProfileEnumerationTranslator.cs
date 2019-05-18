using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Overrides;
using Bind.XML.Overrides.Enumerations;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Translates the OpenGL enumeration signatures in a profile into their language-appropriate variants.
    /// </summary>
    public class ProfileEnumerationTranslator : ITranslator<ApiProfile>, ITranslator<ApiProfileOverride>
    {
        /// <inheritdoc/>
        public ApiProfile Translate(ApiProfile profile)
        {
            var enumerations = profile.Enumerations;

            var identifierTranslator = new NativeIdentifierTranslator();

            var newEnumerations = new List<EnumerationSignature>();
            var newEnumerationNames = new Dictionary<string, string>();
            foreach (var enumeration in enumerations)
            {
                var newEnumerationName = identifierTranslator.Translate(enumeration.Name);

                var newTokens = new List<TokenSignature>();
                foreach (var token in enumeration.Tokens)
                {
                    var newTokenName = identifierTranslator.Translate(token.Name);

                    newTokens.Add(new TokenSignature(newTokenName, token.Value, token.DeprecatedIn, token.Remarks));
                }

                newEnumerationNames.Add(enumeration.Name, newEnumerationName);
                newEnumerations.Add(new EnumerationSignature(newEnumerationName, newTokens));
            }

            var newNativeSignatures = profile.NativeSignatures.Select
            (
                signature => new FunctionSignatureBuilder(signature).WithParameters
                (
                    signature.Parameters.Select
                    (
                        x => newEnumerationNames.ContainsKey(x.Type.Name)
                            ? new ParameterSignatureBuilder(x).WithType
                                (
                                    new TypeSignatureBuilder(x.Type).WithName(newEnumerationNames[x.Type.Name])
                                        .Build()
                                )
                              .Build()
                            : x
                    )
                    .ToList()
                )
                .Build()
            )
            .ToList();

            return new ApiProfileBuilder(profile)
                .WithEnumerations(newEnumerations)
                .WithNativeSignatures(newNativeSignatures)
                .Build();
        }

        /// <inheritdoc/>
        public ApiProfileOverride Translate(ApiProfileOverride overrides)
        {
            var enumerations = overrides.AddedEnumerations;

            var identifierTranslator = new NativeIdentifierTranslator();

            var newEnumerations = new List<EnumerationOverride>();
            foreach (var enumeration in enumerations)
            {
                var newEnumerationName = identifierTranslator.Translate(enumeration.Name);

                var newTokens = new List<TokenSignature>();
                foreach (var token in enumeration.DirectTokens)
                {
                    var newTokenName = identifierTranslator.Translate(token.Name);

                    newTokens.Add(new TokenSignature(newTokenName, token.Value, token.DeprecatedIn, token.Remarks));
                }

                newEnumerations.Add(new EnumerationOverride(newEnumerationName, newTokens));
            }

            return new ApiProfileOverride
            (
                overrides.Name,
                overrides.Versions,
                newEnumerations,
                overrides.ReplacedFunctions,
                overrides.RemovedFunctions
            );
        }
    }
}
