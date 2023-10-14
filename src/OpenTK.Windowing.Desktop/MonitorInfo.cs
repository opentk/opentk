//
// DpiInfo.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// This class contains information about a monitor.
    /// </summary>
    public unsafe class MonitorInfo
    {
        /// <summary>
        /// The handle to the monitor.
        /// </summary>
        private readonly MonitorHandle _handle;

        private Monitor* HandleAsPtr => _handle.ToUnsafePtr<Monitor>();

        /// <summary>
        /// Gets the internal handle to the monitor.
        /// </summary>
        public MonitorHandle Handle => _handle;

        /// <summary>
        /// Human-readable name for this monitor. Not guaranteed to be unique among the connected monitors.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the client area of the monitor (in the virtual screen-space).
        /// </summary>
        public Box2i ClientArea { get; private set; }

        /// <summary>
        /// Get the work area of the monitor.
        /// The work area is defined as the area of the monitor not occluded by the operating system task bar where present.
        /// If no task bar exists then the work area is the monitor resolution in screen coordinates.
        /// </summary>
        public Box2i WorkArea { get; private set; }

        /// <summary>
        /// Gets the horizontal resolution of the monitor.
        /// </summary>
        public int HorizontalResolution => ClientArea.Size.X;

        /// <summary>
        /// Gets the vertical resolution of the monitor.
        /// </summary>
        public int VerticalResolution => ClientArea.Size.Y;

        /// <summary>
        /// Gets the scale of the monitor in the horizontal axis.
        /// </summary>
        public float HorizontalScale { get; private set; }

        /// <summary>
        /// Gets the scale of the monitor in the vertical axis.
        /// </summary>
        public float VerticalScale { get; private set; }

        /// <summary>
        /// Gets the approximate dpi of the monitor on the horizontal axis.
        /// </summary>
        public float HorizontalDpi { get; private set; }

        /// <summary>
        /// Gets the approximate dpi of the monitor on the vertical axis.
        /// </summary>
        public float VerticalDpi { get; private set; }

        /// <summary>
        /// Gets the physical width of the monitor in milimeters.
        /// </summary>
        public int PhysicalWidth { get; private set; }

        /// <summary>
        /// Gets the physical height of the monitor in milimeters.
        /// </summary>
        public int PhysicalHeight { get; private set; }

        /// <summary>
        /// Gets the raw, calculated dpi of the monitor in the horizontal axis.
        /// </summary>
        /// <remarks>
        /// This value may be incorrect. Use <see cref="HorizontalDpi"/> if possible.
        /// </remarks>
        public float HorizontalRawDpi { get; private set; }

        /// <summary>
        /// Gets the raw, calculated dpi of the monitor in the vertical axis.
        /// </summary>
        /// <remarks>
        /// This value may be incorrect. Use <see cref="HorizontalDpi"/> if possible.
        /// </remarks>
        public float VerticalRawDpi { get; private set; }

        private VideoMode[] _supportedVideoModes;

        /// <summary>
        /// A list of supported video modes for this monitor.
        /// </summary>
        public System.Collections.Generic.IReadOnlyList<VideoMode> SupportedVideoModes
        {
            get => _supportedVideoModes;
        }

        /// <summary>
        /// The current VideoMode used by this monitor.
        /// </summary>
        public VideoMode CurrentVideoMode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorInfo"/> class.
        /// </summary>
        /// <remarks>
        /// <paramref pref="handle"/> must be a valid pointer to a monitor.
        /// </remarks>
        /// <param name="handle">An opaque handle to a monitor.</param>
        internal MonitorInfo(MonitorHandle handle)
        {
            GLFWProvider.EnsureInitialized();

            if (handle.Pointer == IntPtr.Zero)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;

            Name = GLFW.GetMonitorName(HandleAsPtr);

            GLFW.GetMonitorPos(HandleAsPtr, out int x, out int y);
            var videoMode = GLFW.GetVideoMode(HandleAsPtr);
            ClientArea = new Box2i(x, y, x + videoMode->Width, y + videoMode->Height);

            GLFW.GetMonitorWorkarea(HandleAsPtr, out int workAreaX, out int workAreaY, out int workAreaWidth, out int workAreaHeight);
            WorkArea = new Box2i(workAreaX, workAreaY, workAreaX + workAreaWidth, workAreaY + workAreaHeight);

            GLFW.GetMonitorPhysicalSize(HandleAsPtr, out int width, out int height);
            PhysicalWidth = width;
            PhysicalHeight = height;

            GLFW.GetMonitorContentScale(HandleAsPtr, out float horizontalScale, out float verticalScale);
            HorizontalScale = horizontalScale;
            VerticalScale = verticalScale;

            float defaultDpi = Monitors.GetPlatformDefaultDpi();

            HorizontalDpi = defaultDpi * HorizontalScale;
            VerticalDpi = defaultDpi * VerticalScale;

            HorizontalRawDpi = CalculateDpi(HorizontalResolution, PhysicalWidth);
            VerticalRawDpi = CalculateDpi(VerticalResolution, PhysicalHeight);

            _supportedVideoModes = GLFW.GetVideoModes(HandleAsPtr);
            CurrentVideoMode = *GLFW.GetVideoMode(HandleAsPtr);
        }

        /// <summary>
        /// Calculates dpi from a pixel count and a length in mm.
        /// </summary>
        /// <remarks>
        /// How does this formula calculate dpi?
        ///
        /// 1. 1" = 25.4mm thus dInMm / 25.4 = dInInches
        /// 2. dpi = pixelCount/dInInches
        ///
        /// Ergo:
        ///     pixelCount / (dInMm / 25.4)
        ///   = (pixelCount / dInMm) * 25.4.
        /// </remarks>
        private float CalculateDpi(int pixels, int length) => ((float)pixels / (float)length) * 25.4f;
    }
}
