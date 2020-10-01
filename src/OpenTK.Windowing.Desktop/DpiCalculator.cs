//
// DpiCalculator.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    ///     This class contains methods used for calculating dpi.
    /// </summary>
    internal static class DpiCalculator
    {
        private static readonly bool _isHookSet = false;

        private static List<DpiInfo> _dpiInfos = new List<DpiInfo>();

        // I am not sure how well of an idea this is.
        private static Dictionary<IntPtr, int> _dpiIndexLookup = new Dictionary<IntPtr, int>();

        private static bool _isCacheBuilt;

        /// <summary>
        ///     Gets the current monitor scale.
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
            if (TryGetFromCache((IntPtr)monitor, out var info))
            {
                horizontalScale = info.HorizontalScale;
                verticalScale = info.VerticalScale;
                return true;
            }

            horizontalScale = 1f;
            verticalScale = 1f;
            return false;
        }

        /// <summary>
        ///     Gets the dpi of the monitor pointed to.
        /// </summary>
        /// <param name="monitor">The monitor in question.</param>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if the monitor's dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        ///     This methods approximates the dpi of the monitor by multiplying
        ///     the monitor scale received from <see cref="TryGetMonitorScale(Monitor*, out float, out float)" />
        ///     by each platforms respective default dpi (72 for macOS and 96 for other systems).
        /// </remarks>
        public static unsafe bool TryGetMonitorDpi(Monitor* monitor, out float horizontalDpi, out float verticalDpi)
        {
            if (TryGetFromCache((IntPtr)monitor, out var info))
            {
                horizontalDpi = info.HorizontalDpi;
                verticalDpi = info.VerticalDpi;
                return true;
            }

            horizontalDpi = verticalDpi = GetPlatformDefaultDpi();
            return false;
        }

        /// <summary>
        ///     Gets the raw dpi of the monitor pointed to.
        /// </summary>
        /// <param name="monitor">The monitor in question.</param>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if monitor's raw dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        ///     This method calculates dpi by retrieving monitor dimensions and resolution.
        ///     However on certain platforms (such as Windows) these values may not
        ///     be scaled correctly.
        /// </remarks>
        public static unsafe bool TryGetMonitorDpiRaw(Monitor* monitor, out float horizontalDpi, out float verticalDpi)
        {
            if (TryGetFromCache((IntPtr)monitor, out var info))
            {
                horizontalDpi = info.HorizontalRawDpi;
                verticalDpi = info.VerticalRawDpi;
                return true;
            }

            horizontalDpi = verticalDpi = GetPlatformDefaultDpi();
            return false;
        }

        /// <summary>
        ///     Gets the default dpi for platforms.
        /// </summary>
        /// <returns>The platform default dpi.</returns>
        /// <remarks>
        ///     For historical reasons macOS has a default dpi of 72, and other
        ///     platforms have a default dpi of 96.
        /// </remarks>
        public static float GetPlatformDefaultDpi()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return 72f;
            }

            return 96f;
        }

        private static int GetRectangleIntersectionArea(Rectangle a, Rectangle b)
        {
            var area = Rectangle.Intersect(a, b);
            return area.Width * area.Height;
        }

        /// <summary>
        ///     Returns the monitor a window intersects with the most.
        /// </summary>
        /// <param name="window">The window calculate the monitor for.</param>
        /// <returns>The monitor which the window intersects with the most.</returns>
        public static unsafe Monitor* GetMonitorFromWindow(Window* window)
        {
            if (!CheckCache())
            {
                throw new Exception("This method can only be called from the main GLFW thread.");
            }

            Rectangle windowArea;
            {
                int windowX, windowY, windowWidth, windowHeight;
                GLFW.GetWindowPos(window, out windowX, out windowY);
                GLFW.GetWindowSize(window, out windowWidth, out windowHeight);
                windowArea = new Rectangle(windowX, windowY, windowWidth, windowHeight);
            }

            var selectedIndex = 0;
            for (var i = 0; i < _dpiInfos.Count; i++)
            {
                if (
                    GetRectangleIntersectionArea(_dpiInfos[i].ClientArea, windowArea) >
                    GetRectangleIntersectionArea(_dpiInfos[selectedIndex].ClientArea, windowArea)
                )
                {
                    selectedIndex = i;
                }
            }

            return _dpiInfos[selectedIndex].Handle;
        }

        /// <summary>
        ///     Checks wheter the cache has been built or builds it if it can.
        /// </summary>
        /// <returns>Wether the current cache is valid or not.</returns>
        public static unsafe bool CheckCache()
        {
            if (!_isCacheBuilt && GLFWProvider.IsOnMainThread)
            {
                BuildMonitorCache();
            }

            if (!_isHookSet && GLFWProvider.IsOnMainThread)
            {
                GLFW.SetMonitorCallback(DpiMonitorCallback);
            }

            return _isCacheBuilt;
        }

        /// <summary>
        ///     Tries to get a <see cref="DpiInfo" /> object from the prebuilt cache.
        /// </summary>
        /// <param name="index">The monitor index of the object.</param>
        /// <param name="info">The cached object.</param>
        /// <returns>True when the object was retrieved from cache successfully.</returns>
        public static bool TryGetFromCache(int index, out DpiInfo info)
        {
            if (CheckCache())
            {
                info = _dpiInfos.ElementAtOrDefault(index);
            }
            else
            {
                info = null;
            }

            return info != null;
        }

        /// <summary>
        ///     Tries to get a <see cref="DpiInfo" /> object from the prebuilt cache.
        /// </summary>
        /// <param name="monitor">An opaque handle to the monitor.</param>
        /// <param name="info">The cached object.</param>
        /// <returns>True when the object was retrieved from cache successfully.</returns>
        public static bool TryGetFromCache(IntPtr monitor, out DpiInfo info)
        {
            if (_dpiIndexLookup.TryGetValue(monitor, out var index))
            {
                return TryGetFromCache(index, out info);
            }

            info = null;
            return false;
        }

        /// <summary>
        ///     Builds the monitor cache (again if called before).
        /// </summary>
        public static unsafe void BuildMonitorCache()
        {
            if (!GLFWProvider.IsOnMainThread)
            {
                throw new InvalidOperationException("Only GLFW main thread can build the monitor cache.");
            }

            var newInfos = new List<DpiInfo>();
            var newIndexLookup = new Dictionary<IntPtr, int>();

            var monitors = GLFW.GetMonitorsRaw(out var monitorCount);

            for (var i = 0; i < monitorCount; i++)
            {
                var monitor = *(monitors + i);

                newInfos.Add(new DpiInfo(monitor));
                newIndexLookup.Add((IntPtr)monitor, i);
            }

            _dpiInfos = newInfos;
            _dpiIndexLookup = newIndexLookup;

            _isCacheBuilt = true;
        }

        private static unsafe void DpiMonitorCallback(Monitor* monitor, ConnectedState state)
        {
            // Normally, adding or removing from the cache would be nice, but this breaks
            // getting the info from an index, thus the cache must be built from scratch.
            BuildMonitorCache();
        }
    }
}
