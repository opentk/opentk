using System;
using System.Text;
using Bind.XML;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Translation.Trimmers
{
    /// <summary>
    /// Trims OpenGL extension names from OpenGL functions.
    /// </summary>
    public class OpenGLFunctionExtensionTrimmer : ITrimmer<FunctionSignature>, ITrimmer<string>
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

        /// <inheritdoc/>
        public bool IsRelevant(string trimmable)
        {
            var uppercaseCount = 0;
            for (var i = trimmable.Length - 1; i >= 0; --i)
            {
                if (char.IsUpper(trimmable, i))
                {
                    uppercaseCount++;
                    continue;
                }

                break;
            }

            if (uppercaseCount > 1)
            {
                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public string Trim(string trimmable)
        {
            var sb = new StringBuilder();

            var isTrimming = true;
            for (var i = trimmable.Length - 1; i >= 0; --i)
            {
                if (isTrimming && char.IsUpper(trimmable, i))
                {
                    continue;
                }

                isTrimming = false;
                sb.Insert(0, trimmable[i]);
            }

            return sb.ToString();
        }
    }
}
