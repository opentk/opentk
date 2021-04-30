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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// This is a base class for OpenAL APIs that are using DllImport and want to resolve different dll names on different platforms.
    /// </summary>
    public abstract class ALBase
    {
        /// <summary>
        /// This needs to be called before trying to use any OpenAL functions.
        /// This should be done in the static constructor of any class that DllImports OpenAL functions.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void RegisterOpenALResolver()
        {
            ALLoader.RegisterDllResolver();
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
