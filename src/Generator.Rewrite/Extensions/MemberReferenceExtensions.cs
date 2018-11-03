using System;
using Mono.Cecil;

namespace OpenToolkit.Rewrite.Extensions
{
    /// <summary>
    /// Provides convenience extension methods for <see cref="MemberReference"/>
    /// instances that are used in the OpenToolkit.Rewrite namespace.
    /// </summary>
    public static class MemberReferenceExtensions
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
    }
}
