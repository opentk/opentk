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
        /// Gets the client area of the monitor (in the virtual screen-space).
        /// </summary>
        public Box2i ClientArea { get; private set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorInfo"/> class.
        /// </summary>
        /// <remarks>
        /// <paramref pref="handle"/> must be a valid pointer to a monitor.
        /// </remarks>
        /// <param name="handle">An opaque handle to a monitor.</param>
        internal MonitorInfo(MonitorHandle handle)
        {
            if (!GLFWProvider.IsOnMainThread)
            {
                throw new NotSupportedException("Only the GLFW thread can construct this object.");
            }

            if (handle.Pointer == IntPtr.Zero)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;

            GetClientArea();
            GetPhysicalSize();
            GetScale();

            // DO NOT call these methods before the above Get* methods.
            CalculateMonitorDpi();
            CalculateMonitorRawDpi();
        }

        /// <summary>
        /// Queries GLFW to get the client area of the monitor.
        /// </summary>
        private unsafe void GetClientArea()
        {
            GLFW.GetMonitorPos(HandleAsPtr, out int x, out int y);
            var videoMode = GLFW.GetVideoMode(HandleAsPtr);

            ClientArea = new Box2i(x, y, x + videoMode->Width, y + videoMode->Height);
        }

        /// <summary>
        /// Queries GLFW to get the physical size of the monitor.
        /// </summary>
        private void GetPhysicalSize()
        {
            GLFW.GetMonitorPhysicalSize(HandleAsPtr, out int width, out int height);

            PhysicalWidth = width;
            PhysicalHeight = height;
        }

        /// <summary>
        /// Queries GLFW to get monitor scale.
        /// </summary>
        private void GetScale()
        {
            GLFW.GetMonitorContentScale(HandleAsPtr, out float horizontalScale, out float verticalScale);

            HorizontalScale = horizontalScale;
            VerticalScale = verticalScale;
        }

        /// <summary>
        /// Calculates the monitor dpi from cached values.
        /// </summary>
        private void CalculateMonitorDpi()
        {
            float defaultDpi = Monitors.GetPlatformDefaultDpi();

            HorizontalDpi = defaultDpi * HorizontalScale;
            VerticalDpi = defaultDpi * VerticalScale;
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

        /// <summary>
        /// Calculates the raw dpi of the monitor from cached values.
        /// </summary>
        private void CalculateMonitorRawDpi()
        {
            HorizontalRawDpi = CalculateDpi(HorizontalResolution, PhysicalWidth);
            VerticalRawDpi = CalculateDpi(VerticalResolution, PhysicalHeight);
        }
    }
}
