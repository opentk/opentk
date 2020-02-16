using System;
using System.Runtime.InteropServices;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Native
{
    public class NativeLibrary : IDisposable
    {
        private static readonly LibraryLoader DefaultLoader = LibraryLoader.GetDefaultLoader();

        public IPlatformLibraryNameContainer PlatformName { get; protected set; }

        public LibraryLoader Loader { get; protected set; }

        public IntPtr Handle { get; protected set; }

        public NativeLibrary(LibraryLoader loader, IPlatformLibraryNameContainer platformName)
        {
            PlatformName = platformName;
            Loader = loader;
            Handle = Loader.Load(platformName.GetLibraryName());
        }

        public NativeLibrary(IPlatformLibraryNameContainer platformName)
            : this(DefaultLoader, platformName)
        {
        }

        public T LoadFunction<T>(string name) where T : Delegate
        {
            return (T)Marshal.GetDelegateForFunctionPointer(LoadFunction(name), typeof(T));
        }

        public IntPtr LoadFunction(string name)
        {
            return DefaultLoader.GetProc(Handle, name);
        }

        public void Dispose()
        {
            DefaultLoader.UnLoad(Handle);
        }
    }
}
