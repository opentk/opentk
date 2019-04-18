using System.Collections.Generic;
using Bind.Builders;
using Bind.Translation.Trimmers;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Translates the OpenGL function signatures in a profile into their language-appropriate variants.
    /// </summary>
    public class ProfileFunctionTranslator : ITranslator<ApiProfile>
    {
        /// <inheritdoc/>
        public ApiProfile Translate(ApiProfile profile)
        {
            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var newFunctions = new List<FunctionSignature>();
            foreach (var function in profile.NativeSignatures)
            {
                var processingFunction = function;
                if (extensionTrimmer.IsRelevant(processingFunction))
                {
                    processingFunction = extensionTrimmer.Trim(processingFunction);
                }

                if (dataTypeTrimmer.IsRelevant(processingFunction))
                {
                    processingFunction = dataTypeTrimmer.Trim(processingFunction);
                }

                newFunctions.Add(processingFunction);
            }

            return new ApiProfileBuilder(profile)
                .WithNativeSignatures(newFunctions)
                .Build();
        }
    }
}
