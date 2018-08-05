using System;
using Bind.XML;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

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
            return IsRelevant(trimmable as INamedExtensionScopedEntity);
        }

        /// <inheritdoc/>
        public FunctionSignature Trim(FunctionSignature trimmable)
        {
            var newName = Trim(trimmable as INamedExtensionScopedEntity);

            return new FunctionSignature
            (
                newName,
                trimmable.NativeEntrypoint,
                trimmable.Categories,
                trimmable.Extension,
                trimmable.IntroducedIn,
                trimmable.ReturnType,
                trimmable.Parameters,
                trimmable.DeprecatedIn,
                trimmable.DeprecationReason
            );
        }

        /// <summary>
        /// Determines if the name trimmer is relevant for the given type.
        /// </summary>
        /// <param name="trimmable">The type to check.</param>
        /// <returns>true if the name trimmer is relevant; otherwise, false.</returns>
        public bool IsRelevant([NotNull] INamedExtensionScopedEntity trimmable)
        {
            if (trimmable.Extension is null)
            {
                return false;
            }

            return trimmable.Name.EndsWith(trimmable.Extension);
        }

        /// <summary>
        /// Trims the name of the given <see cref="INamedExtensionScopedEntity"/> without modifying the underlying
        /// object.
        /// </summary>
        /// <param name="trimmable">The trimmable object.</param>
        /// <returns>The trimmed name.</returns>
        [NotNull, Pure]
        public string Trim([NotNull] INamedExtensionScopedEntity trimmable)
        {
            if (trimmable.Extension is null)
            {
                throw new ArgumentException("Cannot trim a null extension.", nameof(trimmable.Extension));
            }

            var extensionNameIndex = trimmable.Name.LastIndexOf(trimmable.Extension, StringComparison.Ordinal);
            return trimmable.Name.Remove(extensionNameIndex);
        }
    }
}
