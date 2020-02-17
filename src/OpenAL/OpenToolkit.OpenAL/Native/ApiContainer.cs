using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
#pragma warning disable SA1649 // File name should match first type name
    public abstract class ApiBase
#pragma warning restore SA1649 // File name should match first type name
    {
#pragma warning disable SA1401 // Fields should be private
        private static Dictionary<string, IPlatformLibraryNameContainer> DllIntercepts = new Dictionary<string, IPlatformLibraryNameContainer>();
#pragma warning restore SA1401 // Fields should be private

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

#pragma warning disable SA1402 // File may only contain a single type
    public abstract class ApiContainer<T> : ApiBase where T : ApiContainer<T>
#pragma warning restore SA1402 // File may only contain a single type
    {
        public static readonly Type StaticConstructorTrigger = typeof(T);

        static ApiContainer()
        {
            var apiAttr = typeof(T).GetCustomAttribute<ApiAttribute>();
            AddDllIntercept(apiAttr.DllName, apiAttr.PlatformNameContainerType);
        }
    }
}
