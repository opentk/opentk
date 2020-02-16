using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OpenToolkit.Native
{
    public abstract class ApiContainer
    {
        public static MethodInfo GetOrLoadMethod = typeof(ApiContainer).GetMethod(
            nameof(GetOrLoad),
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance,
            null,
            new[] { typeof(int), typeof(string) },
            null);

        protected NativeLibrary Lib;
        protected IntPtr[] Procs;

        public ApiContainer()
        {
            // We need to figure out the library
            // We want to figure out how many entry points we need
        }

        protected IntPtr GetOrLoad(int slot, string name)
        {
            var ptr = Procs[slot];
            if (ptr != IntPtr.Zero)
            {
                // We had already loaded this proc
                return ptr;
            }

            // Here we want to load the proc as it had not already been loaded
            ptr = Lib.LoadFunction(name);
            if (ptr == IntPtr.Zero)
            {
                throw new EntryPointNotFoundException($"Could not find symbol '{name}' in {Lib.PlatformName.GetLibraryName()} (slot {slot})");
            }

            Procs[slot] = ptr;
            return ptr;
        }
    }
}
