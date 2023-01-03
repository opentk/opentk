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
            if (OperatingSystem.IsLinux() && LinuxLibraryList.TryGetValue(libraryName, out IReadOnlyCollection<string>? names))
            {
                foreach(string name in names)
                {
                    if (NativeLibrary.TryLoad(name, assembly, searchPath, out IntPtr lib))
                        return lib;
                }
            }

            return IntPtr.Zero;
        }

        /// <summary>
        /// A dictionary of a priority list of library search names for the
        /// Linux family of operating systems.
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> LinuxLibraryList =
        new Dictionary<string, IReadOnlyCollection<string>>
        {
            ["GL"] = new string[]
            {
                "libGL.so",
                "libGL.so.1",
                "libGL.so.0"
            },

            // FIXME: By default let the OS decide, if that fails use vendor. Add other vendor GLX versions.
            ["GLX"] = new string[]
            {
                "libGLX.so",
                "libGLX.so.0",
                "libGLX_nvidia.so.1",
                "libGLX_nvidia.so.0",
                "libGLX_mesa.so.0"
            },

            ["X11"] = new string[]
            {
                "libX11.so",
                "libX11.so.6",
                "libX11.so.5",
                "libX11.so.4",
                "libX11.so.3",
                "libX11.so.2",
                "libX11.so.1",
                "libX11.so.0"
            }
        };
    }
}
