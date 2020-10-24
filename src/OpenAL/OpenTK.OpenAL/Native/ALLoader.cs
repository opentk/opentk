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

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Provides a base for ApiContext so that it can register dll intercepts.
    /// </summary>
    internal static class ALLoader
    {
        private static readonly OpenALLibraryNameContainer ALLibraryNameContainer = new OpenALLibraryNameContainer();

        private static bool RegisteredResolver = false;

        static ALLoader()
        {
            RegisterDllResolver();
        }

        internal static void RegisterDllResolver()
        {
            if (RegisteredResolver == false)
            {
                NativeLibrary.SetDllImportResolver(typeof(ALLoader).Assembly, ImportResolver);
                RegisteredResolver = true;
            }
        }

        private static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (libraryName == AL.Lib || libraryName == ALC.Lib)
            {
                string libName = ALLibraryNameContainer.GetLibraryName();

                if (NativeLibrary.TryLoad(libName, assembly, searchPath, out IntPtr libHandle) == false)
                {
                    throw new DllNotFoundException($"Could not load the dll '{libName}' (this load is intercepted, specified in DllImport as '{libraryName}').");
                }

                return libHandle;
            }
            else
            {
                return NativeLibrary.Load(libraryName, assembly, searchPath);
            }
        }
    }
}
