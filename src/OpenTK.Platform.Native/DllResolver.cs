using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native
{
    internal class DllResolver
    {
        static DllResolver()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), DllImportResolver);
        }

        /// <summary>
        /// Called to trigger the static constructor.
        /// </summary>
        public static void InitLoader() { }

        public static IntPtr DllImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (OperatingSystem.IsLinux() && libraryName == "GL")
            {
                // On linux we want to try libGL.so and libGL.so.1
                IntPtr lib;
                if (NativeLibrary.TryLoad("libGL.so", assembly, searchPath, out lib))
                    return lib;

                if (NativeLibrary.TryLoad("libGL.so.1", assembly, searchPath, out lib))
                    return lib;
            }

            return IntPtr.Zero;
        }
    }
}
