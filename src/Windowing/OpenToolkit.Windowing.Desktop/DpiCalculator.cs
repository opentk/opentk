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
        /// Gets the current monitor scale.
        /// </summary>
        /// <param name="monitor">The monitor in question.</param>
        /// <param name="horizontalScale">Horizontal scale.</param>
        /// <param name="verticalScale">Vertical scale.</param>
        /// <returns><c>true</c>, if current monitor scale was gotten correctly, <c>false</c> otherwise.</returns>
        public static unsafe bool TryGetMonitorScale(
            Monitor* monitor,
            out float horizontalScale,
            out float verticalScale
        )
        {
            if (monitor != null)
            {
                GLFWProvider.GLFW.Value.GetMonitorContentScale(
                    monitor,
                    out horizontalScale,
                    out verticalScale
                );

                return true;
            }
            else
            {
                horizontalScale = 1f;
                verticalScale = 1f;
                return false;
            }
        }

        /// <summary>
        /// Gets the dpi of the monitor pointed to.
        /// </summary>
        /// <param name="monitor">The monitor in question.</param>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if the monitor's dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This methods approximates the dpi of the monitor by multiplying
        /// the monitor scale received from <see cref="TryGetMonitorScale(Monitor*, out float, out float)"/>
        /// by each platforms respective default dpi (72 for macOS and 96 for other systems).
        /// </remarks>
        public static unsafe bool TryGetMonitorDpi(Monitor* monitor, out float horizontalDpi, out float verticalDpi)
        {
            float defaultDpi = DpiCalculator.GetPlatformDefaultDpi();
            bool success = TryGetMonitorScale(monitor, out float horizontalScale, out float verticalScale);

            horizontalDpi = defaultDpi * horizontalScale;
            verticalDpi = defaultDpi * verticalScale;
            return success;
        }

        /// <summary>
        /// Gets the raw dpi of the monitor pointed to.
        /// </summary>
        /// <param name="monitor">The monitor in question.</param>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if monitor's raw dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This method calculates dpi by retrieving monitor dimensions and resolution.
        /// However on certain platforms (such as Windows) these values may not
        /// be scaled correctly.
        /// </remarks>
        public static unsafe bool TryGetMonitorDpiRaw(Monitor* monitor, out float horizontalDpi, out float verticalDpi)
        {
            horizontalDpi = verticalDpi = GetPlatformDefaultDpi();

            if (monitor == null)
            {
                return false;
            }

            int widthInMm, heightInMm;
            int widthInPixels, heightInPixels;

            // According to GLFW documentation, physical dimensions are reported in millimeters.
            GLFWProvider.GLFW.Value.GetMonitorPhysicalSize(monitor, out widthInMm, out heightInMm);

            var videoMode = GLFWProvider.GLFW.Value.GetVideoMode(monitor);

            if (videoMode == null)
            {
                return false;
            }

            widthInPixels = videoMode->Width;
            heightInPixels = videoMode->Height;

            if (widthInMm <= 0 || heightInMm <= 0 || widthInPixels <= 0 || heightInPixels <= 0)
            {
                return false;
            }

            /*
             * How does this formula calculate dpi?
             *
             * 1. 1" = 25.4mm thus dInMm / 25.4 = dInInches
             * 2. dpi = pixelCount/dInInches
             *
             * Ergo:
             *     pixelCount / (dInMm / 25.4)
             *   = (pixelCount / dInMm) * 25.4
             */

            horizontalDpi = ((float)widthInPixels / (float)widthInMm) * 25.4f;
            verticalDpi = ((float)heightInPixels / (float)heightInMm) * 25.4f;
            return true;
        }

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
