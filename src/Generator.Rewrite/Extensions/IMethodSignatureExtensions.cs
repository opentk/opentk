using System;
using System.Linq;
using Mono.Cecil;

namespace OpenToolkit.Rewrite.Extensions
{
    /// <summary>
    /// Provides convenience extension methods for <see cref="IMethodSignature"/>
    /// instances that are used in the OpenToolkit.Rewrite namespace.
    /// </summary>
    public static class IMethodSignatureExtensions
    {
        /// <summary>
        /// Gets a <see cref="ParameterDefinition"/> by name and throws
        /// an <see cref="InvalidOperationException"/> if no parameter definition with the specified name is found.
        /// </summary>
        /// <param name="signature">The <see cref="IMethodSignature"/> to get the parameter definition from.</param>
        /// <param name="name">The name of the parameter. This is case-sensitive.</param>
        /// <returns>The first parameter definition with the provided name.</returns>
        public static ParameterDefinition GetParameter(this IMethodSignature signature, string name)
        {
            return signature.GetParameter(name, true);
        }

        /// <summary>
        /// Gets a <see cref="ParameterDefinition"/> by name and optionally either returns null or throws
        /// an <see cref="InvalidOperationException"/> if no method definition with the specified name is found.
        /// </summary>
        /// <param name="signature">The <see cref="IMethodSignature"/> to get the parameter definition from.</param>
        /// <param name="name">The name of the parameter. This is case-sensitive.</param>
        /// <param name="throwIfNoneFound">
        /// Whether to throw an <see cref="InvalidOperationException"/>
        /// if no parameter definition with the specified name is found.
        /// </param>
        /// <returns>
        /// If <paramref name="throwIfNoneFound"/> is true: The first parameter definition with the provided name.
        /// <para/>
        /// Otherwise: Either the first parameter definition with the given name, or null if none is found.
        /// </returns>
        public static ParameterDefinition GetParameter
        (
            this IMethodSignature signature,
            string name,
            bool throwIfNoneFound
        )
        {
            if (throwIfNoneFound)
            {
                return signature.Parameters.First(p => p.Name == name);
            }

            return signature.Parameters.FirstOrDefault(p => p.Name == name);
        }
    }
}
