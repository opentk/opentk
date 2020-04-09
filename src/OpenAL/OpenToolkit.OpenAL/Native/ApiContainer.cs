//
// ApiContainer.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    /// <summary>
    /// This is a base class for APIs that are using DllImport and want to resolve different dll names on different platforms. When using this class the extending class must be annotated with an ApiAttribute.
    /// </summary>
    /// <typeparam name="T">The type containing the API.</typeparam>
    public abstract class ApiContainer<T> : ApiBase where T : ApiContainer<T>
    {
        /// <summary>
        /// This is here so that extending classes can trigger the static constructor of this class.
        /// </summary>
        public static readonly Type StaticConstructorTrigger = typeof(T);

        static ApiContainer()
        {
            var apiAttribute = typeof(T).GetCustomAttribute<ApiAttribute>();

            if (apiAttribute == null)
            {
                throw new InvalidOperationException($"An api container needs to be annotated with {typeof(ApiAttribute)}");
            }

            if (typeof(IPlatformLibraryNameContainer).IsAssignableFrom(apiAttribute.PlatformNameContainerType) == false)
            {
                throw new InvalidOperationException($"Platform name container type must be assignable from {typeof(IPlatformLibraryNameContainer)}!");
            }

            AddDllIntercept(apiAttribute.DllName, (IPlatformLibraryNameContainer)Activator.CreateInstance(apiAttribute.PlatformNameContainerType));
        }

        /// <summary>
        /// Calls alGetProcAddress and converts the resulting pointer into a delegate.
        /// </summary>
        /// <typeparam name="TDelegate">The delegate type to create.</typeparam>
        /// <param name="name">The name of the AL proc.</param>
        /// <returns>The created delegate.</returns>
        protected internal static TDelegate LoadDelegate<TDelegate>(string name) where TDelegate : Delegate
        {
            IntPtr ptr = AL.GetProcAddress(name);
            return Marshal.GetDelegateForFunctionPointer<TDelegate>(ptr);
        }
    }
}
