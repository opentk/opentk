//
// ApiBase.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    /// <summary>
    /// Provides a base for ApiContext so that it can register dll intercepts.
    /// </summary>
    public abstract class ApiBase
    {
        private static readonly Dictionary<string, IPlatformLibraryNameContainer> DllIntercepts = new Dictionary<string, IPlatformLibraryNameContainer>();

        static ApiBase()
        {
            NativeLibrary.SetDllImportResolver(typeof(ApiBase).Assembly, ImportResolver);
        }

        private static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            IntPtr libHandle = IntPtr.Zero;
            if (DllIntercepts.TryGetValue(libraryName, out var libraryNameContainer))
            {
                string libName = libraryNameContainer.GetLibraryName();

                if (NativeLibrary.TryLoad(libName, assembly, searchPath, out libHandle) == false)
                {
                    throw new DllNotFoundException($"Could not load the dll '{libName}' (this load is intercepted, specified in DllImport as '{libraryName}').");
                }
            }
            return libHandle;
        }

        /// <summary>
        /// Correlates a dllName string with a IPlatformLibraryNameContainer so that when a dll is loaded with the dllName it gets resolved using the name container.
        /// </summary>
        /// <param name="dllName">The dll name to intercept.</param>
        /// <param name="nameContainer">The platform name provider to use for the intercept.</param>
        protected static void AddDllIntercept(string dllName, IPlatformLibraryNameContainer nameContainer)
        {
            if (DllIntercepts.TryGetValue(dllName, out var existing))
            {
                if (existing.GetType() != nameContainer.GetType())
                {
                    throw new InvalidOperationException($"There is already a dll intercept with this name using the platform name provider '{existing.GetType()}'. (Passed '{nameContainer.GetType()}')");
                }

                // If we get here there was no conflict in the intercept, so we don't have to do anything
            }
            else
            {
                DllIntercepts.Add(dllName, nameContainer);
            }
        }
    }
}
