using System.Runtime.InteropServices;
using OpenToolkit.GraphicsLibraryFramework;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// This class contains methods used for calculating dpi.
    /// </summary>
    internal static class DpiCalculator
    {
        /// <summary>
        /// Gets the default dpi for platforms.
        /// </summary>
        /// <returns>The platform default dpi.</returns>
        /// <remarks>
        /// For historical reasons macOS has a default dpi of 72, and other
        /// platforms have a default dpi of 96.
        /// </remarks>
        public static float GetPlatformDefaultDpi()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return 72f;
            }
            else
            {
                return 96f;
            }
        }
    }
}
