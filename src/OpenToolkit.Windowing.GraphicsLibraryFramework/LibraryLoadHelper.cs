using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Helper class for library loading.
    /// </summary>
    public static class LibraryLoadHelper
    {
#if NETCOREAPP
        /// <summary>
        /// Tries to load and resolve versioned libraries by library file name.
        /// </summary>
        /// <param name="libraryName">The base library name.</param>
        /// <param name="version">The version of the library to load.</param>
        /// <param name="assembly">The assembly loading the native library.</param>
        /// <param name="searchPath">The search path.</param>
        /// <returns>The handle for the loaded library.</returns>
        public static IntPtr LoadLibrary(string libraryName, Version version, Assembly assembly, DllImportSearchPath? searchPath)
        {
            IEnumerable<string> GetNextVersion()
            {
                for (var i = 2; i >= 0; i--)
                {
                    yield return version.ToString(i);
                }
            }

            Func<string, string, string> libNameFormatter = null;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                libNameFormatter = (libName, ver) =>
                    libName + ".so" + (string.IsNullOrEmpty(ver) ? string.Empty : "." + ver);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                libNameFormatter = (libName, ver) =>
                    libName + (string.IsNullOrEmpty(ver) ? string.Empty : "." + ver) + ".dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                libNameFormatter = (libName, ver) =>
                    libName + (string.IsNullOrEmpty(ver) ? string.Empty : ver) + ".dll";
            }
            else
            {
                return IntPtr.Zero;
            }

            foreach (var ver in GetNextVersion())
            {
                if (NativeLibrary.TryLoad(libNameFormatter(libraryName, ver), assembly, searchPath, out var handle))
                {
                    return handle;
                }
            }
            return NativeLibrary.Load(libraryName, assembly, searchPath);
        }
#endif
    }
}
