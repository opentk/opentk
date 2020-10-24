using System.Runtime.InteropServices;

namespace OpenTK.Graphics.GL
{
    /// <summary>
    /// Contains the library name of OpenGL.
    /// </summary>
    internal class LibraryNameContainer
    {
        /// <inheritdoc />
        public static string Linux => "libGL.so";

        /// <inheritdoc />
        public static string MacOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public static string Android => "libGL.so";

        /// <inheritdoc />
        public static string IOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public static string Windows => "opengl32.dll";

        public static string GetLibraryNameForCurrentPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return Linux;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return Windows;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return MacOS;
            else return "unknown platform";
        }
    }
}
