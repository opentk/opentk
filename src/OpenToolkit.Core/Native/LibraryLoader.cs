using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0
using System.Reflection;
using NETCoreNativeLibrary = System.Runtime.InteropServices.NativeLibrary;
#else
using System.Runtime.InteropServices;
#endif

namespace OpenToolkit.Native
{
    public abstract class LibraryLoader
    {
        public abstract IntPtr Load(string name);

        public abstract void UnLoad(IntPtr handle);

        public abstract IntPtr GetProc(IntPtr handle, string name);

        /// <summary>
        /// Gets the default LibraryLoader for this platform.
        /// </summary>
        /// <returns>A LibraryLoader for this platform.</returns>
        public static LibraryLoader GetDefaultLoader()
        {
#if NETCOREAPP3_0
            return new NETCoreLoader();
#else
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return new WindowsLoader();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return new UnixLoader();
            }

            throw new PlatformNotSupportedException($"OpenTK does not provide a library loader for this platform yet! OS description: {RuntimeInformation.OSDescription}");
#endif
        }

#if NETCOREAPP3_0
        public class NETCoreLoader : LibraryLoader
        {
            public override IntPtr GetProc(IntPtr handle, string name)
            {
                return NETCoreNativeLibrary.GetExport(handle, name);
            }

            public override IntPtr Load(string name)
            {
                return NETCoreNativeLibrary.Load(name, Assembly.GetCallingAssembly(), null);
            }

            public override void UnLoad(IntPtr handle)
            {
                NETCoreNativeLibrary.Free(handle);
            }
        }
#else
        public class WindowsLoader : LibraryLoader
        {
            [DllImport("kernel32")]
            public static extern IntPtr LoadLibrary(string fileName);

            [DllImport("kernel32")]
            public static extern IntPtr GetProcAddress(IntPtr module, string procName);

            [DllImport("kernel32")]
            public static extern int FreeLibrary(IntPtr module);

            public override IntPtr Load(string name) => LoadLibrary(name);

            public override void UnLoad(IntPtr handle) => FreeLibrary(handle);

            public override IntPtr GetProc(IntPtr handle, string name) => GetProcAddress(handle, name);
        }

        public class UnixLoader : LibraryLoader
        {
            private const string LibName = "libdl";

            public const int RTLD_NOW = 0x002;

            [DllImport(LibName)]
            public static extern IntPtr dlopen(string fileName, int flags);

            [DllImport(LibName)]
            public static extern IntPtr dlsym(IntPtr handle, string name);

            [DllImport(LibName)]
            public static extern int dlclose(IntPtr handle);

            [DllImport(LibName)]
            public static extern string dlerror();

            public override IntPtr Load(string name) => dlopen(name, RTLD_NOW);

            public override void UnLoad(IntPtr handle) => dlclose(handle);

            public override IntPtr GetProc(IntPtr handle, string name) => dlsym(handle, name);
        }
#endif
    }
}
