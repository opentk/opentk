using System;
using System.Linq;
using Mono.Cecil;

namespace OpenToolkit.Rewrite.Extensions
{
    /// <summary>
    /// Provides convenience extension methods for <see cref="TypeDefinition"/>
    /// instances that are used in the OpenToolkit.Rewrite namespace.
    /// </summary>
    public static class TypeDefinitionExtensions
    {
        /// <summary>
        /// Gets a <see cref="MethodDefinition"/> by name and throws
        /// an <see cref="InvalidOperationException"/> if no method definition with the specified name is found.
        /// </summary>
        /// <param name="typeDef">The <see cref="TypeDefinition"/> to get the method definition from.</param>
        /// <param name="name">The name of the method. This is case-sensitive.</param>
        /// <returns>The first method definition with the provided name.</returns>
        public static MethodDefinition GetMethod(this TypeDefinition typeDef, string name)
        {
            return typeDef.GetMethod(name, true);
        }

        /// <summary>
        /// Gets a <see cref="MethodDefinition"/> by name and optionally either returns null or throws
        /// an <see cref="InvalidOperationException"/> if no method definition with the specified name is found.
        /// </summary>
        /// <param name="typeDef">The <see cref="TypeDefinition"/> to get the method definition from.</param>
        /// <param name="name">The name of the method. This is case-sensitive.</param>
        /// <param name="throwIfNoneFound">
        /// Whether to throw an <see cref="InvalidOperationException"/>
        /// if no method definition with the specified name is found.
        /// </param>
        /// <returns>
        /// If <paramref name="throwIfNoneFound"/> is true: The first method definition with the provided name.<para/>
        /// Otherwise: Either the first method definition with the given name, or null if none is found.
        /// </returns>
        public static MethodDefinition GetMethod(this TypeDefinition typeDef, string name, bool throwIfNoneFound)
        {
            if (throwIfNoneFound)
            {
                return typeDef.Methods.First(m => m.Name == name);
            }

            return typeDef.Methods.FirstOrDefault(m => m.Name == name);
        }
    }
}
