using System;
using System.Linq;
using Mono.Cecil;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// Provides convenience extension methods used in the Rewrite namespace.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Compares a member's full name and a type's full name and returns true iff the two are equal.
        /// </summary>
        /// <typeparam name="T">The type whose full name to compare against.</typeparam>
        /// <param name="member">The <see cref="MemberReference"/> whose full name to compare with.</param>
        /// <returns>Whether the two full names are equal.</returns>
        public static bool FullNameEquals<T>(this MemberReference member)
        {
            return member.FullNameEquals(typeof(T).FullName);
        }

        /// <summary>
        /// Compares a member's full name and a specified type's full name and returns true
        /// iff the two are equal.
        /// </summary>
        /// <param name="member">The <see cref="MemberReference"/> whose full name to compare with.</param>
        /// <param name="type">The <see cref="Type"/> whose full name to compare against.</param>
        /// <returns>Whether the two full names are equal.</returns>
        public static bool FullNameEquals(this MemberReference member, Type type)
        {
            return member.FullNameEquals(type.FullName);
        }

        /// <summary>
        /// Compares a member's full name and a specified type definition's full name and returns true
        /// iff the two are equal.
        /// </summary>
        /// <param name="member">The <see cref="MemberReference"/> whose full name to compare with.</param>
        /// <param name="type">The <see cref="TypeDefinition"/> whose full name to compare against.</param>
        /// <returns>Whether the two full names are equal.</returns>
        public static bool FullNameEquals(this MemberReference member, TypeDefinition type)
        {
            return member.FullNameEquals(type.FullName);
        }

        /// <summary>
        /// Compares a member's full name and a specified string and returns true iff the two are equal.
        /// </summary>
        /// <param name="member">The <see cref="MemberReference"/> whose full name to compare with.</param>
        /// <param name="fullName">The full name to compare against.</param>
        /// <returns>Whether the two full names are equal.</returns>
        public static bool FullNameEquals(this MemberReference member, string fullName)
        {
            return member.FullName == fullName;
        }

        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name and throws
        /// an <see cref="InvalidOperationException"/> if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider">The <see cref="ICustomAttributeProvider"/> to get the attribute from.</param>
        /// <param name="name">
        /// The name of the attribute. This is case-sensitive, and "Attribute" must be included in the name.
        /// </param>
        /// <returns>The first attribute with the provided name.</returns>
        public static CustomAttribute GetCustomAttribute(this ICustomAttributeProvider provider, string name)
        {
            return provider.GetCustomAttribute(name, true);
        }

        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name, and optionally either returns null or
        /// throws an <see cref="InvalidOperationException"/> if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider">The <see cref="ICustomAttributeProvider"/> to get the attribute from.</param>
        /// <param name="name">
        /// The name of the attribute. This is case-sensitive, and "Attribute" must be included in the name.
        /// </param>
        /// <param name="throwIfNoneFound">
        /// Whether to throw an <see cref="InvalidOperationException"/>
        /// if no attribute with the specified name is found.
        /// </param>
        /// <returns>
        /// If <paramref name="throwIfNoneFound"/> is true: The first attribute with the provided name.<para/>
        /// Otherwise: Either the first attribute with the given name, or null if none is found.
        /// </returns>
        public static CustomAttribute GetCustomAttribute
        (
            this ICustomAttributeProvider provider,
            string name,
            bool throwIfNoneFound
        )
        {
            if (throwIfNoneFound)
            {
                return provider.CustomAttributes.First(a => a.AttributeType.Name == name);
            }

            return provider.CustomAttributes.FirstOrDefault(a => a.AttributeType.Name == name);
        }

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
        public static ParameterDefinition GetParameter(this IMethodSignature signature, string name, bool throwIfNoneFound)
        {
            if (throwIfNoneFound)
            {
                return signature.Parameters.First(p => p.Name == name);
            }

            return signature.Parameters.FirstOrDefault(p => p.Name == name);
        }
    }
}
