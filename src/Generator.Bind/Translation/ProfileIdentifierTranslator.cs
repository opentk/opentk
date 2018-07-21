using System;
using System.Collections.Generic;
using Bind.Translation.Trimmers;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation
{
    /// <summary>
    /// Handles translation of identifier names in a profile, converting them into a more language-appropriate format.
    /// </summary>
    public class ProfileIdentifierTranslator
    {
        /// <summary>
        /// Translates the identifiers in the given profile.
        /// </summary>
        /// <param name="profile">The profile to translate.</param>
        /// <returns>The new profile.</returns>
        public ApiProfile TranslateProfile(ApiProfile profile)
        {
            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var newFunctions = new List<FunctionSignature>();
            foreach (var function in profile.Functions)
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

            throw new NotImplementedException();
        }
    }
}
