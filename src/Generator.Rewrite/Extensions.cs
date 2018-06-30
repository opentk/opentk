using Mono.Cecil;
using System;
using System.Linq;

namespace OpenTK.Rewrite
{
    public static class Extensions
    {
        public static bool FullNameEquals<T>(this MemberReference member)
        {
            return member.FullNameEquals(typeof(T).FullName);
        }

        public static bool FullNameEquals(this MemberReference member, Type type)
        {
            return member.FullNameEquals(type.FullName);
        }

        public static bool FullNameEquals(this MemberReference member, TypeDefinition type)
        {
            return member.FullNameEquals(type.FullName);
        }

        public static bool FullNameEquals(this MemberReference member, string fullName)
        {
            return member.FullName == fullName;
        }

        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name and throws an exception if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CustomAttribute GetCustomAttribute(this ICustomAttributeProvider provider, string name)
        {
            return provider.GetCustomAttribute(name, true);
        }

        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name, and optionally either returns null or throws an <see cref="InvalidOperationException"/> if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <param name="throwIfNoneFound"></param>
        /// <returns></returns>
        public static CustomAttribute GetCustomAttribute(this ICustomAttributeProvider provider, string name, bool throwIfNoneFound)
        {
            if (throwIfNoneFound)
            {
                return provider.CustomAttributes.First(a => a.AttributeType.Name == name);
            }

            return provider.CustomAttributes.FirstOrDefault(a => a.AttributeType.Name == name);
        }

        /// <summary>
        /// Gets a <see cref="MethodDefinition"/> by name and throws an exception if no method definition with the specified name is found.
        /// </summary>
        /// <param name="typeDef"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static MethodDefinition GetMethod(this TypeDefinition typeDef, string name)
        {
            return typeDef.GetMethod(name, true);
        }

        /// <summary>
        /// Gets a <see cref="MethodDefinition"/> by name, and optionally either returns null or throws an <see cref="InvalidOperationException"/> if no method with the specified name is found.
        /// </summary>
        /// <param name="typeDef"></param>
        /// <param name="name"></param>
        /// <param name="throwIfNoneFound"></param>
        /// <returns></returns>
        public static MethodDefinition GetMethod(this TypeDefinition typeDef, string name, bool throwIfNoneFound)
        {
            if (throwIfNoneFound)
            {
                return typeDef.Methods.First(m => m.Name == name);
            }

            return typeDef.Methods.FirstOrDefault(m => m.Name == name);
        }

        public static ParameterDefinition GetParameter(this IMethodSignature signature, string name)
        {
            return signature.GetParameter(name, true);
        }

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
