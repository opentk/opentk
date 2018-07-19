using System;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Trimmers
{
    /// <summary>
    /// Trims OpenGL extension names from OpenGL functions.
    /// </summary>
    public class OpenGLFunctionExtensionTrimmer : ITrimmer<FunctionSignature>
    {
        /// <inheritdoc/>
        public bool IsRelevant(FunctionSignature trimmable)
        {
            return trimmable.Name.EndsWith(trimmable.Extension);
        }

        /// <inheritdoc/>
        public FunctionSignature Trim(FunctionSignature trimmable)
        {
            var extensionNameIndex = trimmable.Name.LastIndexOf(trimmable.Extension, StringComparison.Ordinal);
            var newName = trimmable.Name.Substring(extensionNameIndex);

            return new FunctionSignature
            (
                newName,
                trimmable.Category,
                trimmable.Extension,
                trimmable.IntroducedIn,
                trimmable.ReturnType,
                trimmable.Parameters,
                trimmable.DeprecatedIn,
                trimmable.DeprecationReason
            );
        }
    }
}
