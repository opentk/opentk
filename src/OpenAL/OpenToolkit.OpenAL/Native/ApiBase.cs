using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    public abstract class ApiBase
    {
        private static Dictionary<string, IPlatformLibraryNameContainer> DllIntercepts = new Dictionary<string, IPlatformLibraryNameContainer>();

        static ApiBase()
        {
            NativeLibrary.SetDllImportResolver(typeof(ApiBase).Assembly, ImportResolver);
        }

        protected static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            IntPtr libHandle = IntPtr.Zero;
            if (DllIntercepts.TryGetValue(libraryName, out var libraryNameContainer))
            {
                string libName = libraryNameContainer.GetLibraryName();

                // FIXME: Figure out the search path stuf
                NativeLibrary.TryLoad(libName, assembly, searchPath, out libHandle);
            }
            return libHandle;
        }

        protected static void AddDllIntercept(string dllName, Type containerType)
        {
            if (DllIntercepts.TryGetValue(dllName, out var existing))
            {
                if (existing.GetType() != containerType)
                {
                    throw new Exception("TODO: figure out message");
                }

                // We didn't need to do anything :)
            }
            else
            {
                DllIntercepts.Add(dllName, (IPlatformLibraryNameContainer)Activator.CreateInstance(containerType));
            }
        }
    }
}
