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

using glfw = OpenTK.Windowing.GraphicsLibraryFramework;
using otk = OpenTK.Windowing.Common;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// This class contains methods used for calculating dpi.
    /// </summary>
    public static class Monitors
    {
        private static List<MonitorInfo> _monitorInfos = new List<MonitorInfo>();

        // I am not sure how well of an idea this is.
        private static Dictionary<IntPtr, int> _monitorIndexLookup = new Dictionary<IntPtr, int>();

        private static bool _isCacheBuilt = false;
        private static bool _isHookSet = false;

        /// <summary>
        /// The number of monitors available.
        /// </summary>
        public static int Count
        {
            get
            {
                if (CheckCache())
                {
                    return _monitorInfos.Count;
                }
                else
                {
                    throw new GLFWException("This information is not cached and cannot be queried outside of the GLFW main thread");
                }
            }
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

        private static int GetRectangleIntersectionArea(Rectangle a, Rectangle b)
        {
            var area = Rectangle.Intersect(a, b);
            return area.Width * area.Height;
        }

        /// <summary>
        /// Returns the monitor a window intersects with the most.
        /// </summary>
        /// <param name="window">The window calculate the monitor for.</param>
        /// <returns>The monitor which the window intersects with the most.</returns>
        public static unsafe otk::Monitor GetMonitorFromWindow(Window* window)
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

            int selectedIndex = 0;
            for (int i = 0; i < _monitorInfos.Count; i++)
            {
                if (
                    GetRectangleIntersectionArea(_monitorInfos[i].ClientArea, windowArea) >
                    GetRectangleIntersectionArea(_monitorInfos[selectedIndex].ClientArea, windowArea)
                )
                {
                    selectedIndex = i;
                }
            }

            return _monitorInfos[selectedIndex].Handle;
        }

        /// <summary>
        /// Returns the monitor a window intersects with the most.
        /// </summary>
        /// <param name="window">The window calculate the monitor for.</param>
        /// <returns>The monitor which the window intersects with the most.</returns>
        public static unsafe otk::Monitor GetMonitorFromWindow(NativeWindow window) => GetMonitorFromWindow(window.WindowPtr);

        /// <summary>
        /// Checks wheter the cache has been built or builds it if it can.
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
        /// Tries to get a <see cref="MonitorInfo"/> object from the prebuilt cache.
        /// </summary>
        /// <param name="index">The monitor index of the object.</param>
        /// <param name="info">The cached object.</param>
        /// <returns>True when the object was retrieved from cache successfully.</returns>
        public static bool TryGetMonitorInfo(int index, out MonitorInfo info)
        {
            if (CheckCache())
            {
                info = _monitorInfos.ElementAtOrDefault(index);
            }
            else
            {
                info = null;
            }

            return info != null;
        }

        /// <summary>
        /// Tries to get a <see cref="MonitorInfo"/> object from the prebuilt cache.
        /// </summary>
        /// <param name="monitor">An opaque handle to the monitor.</param>
        /// <param name="info">The cached object.</param>
        /// <returns>True when the object was retrieved from cache successfully.</returns>
        public static bool TryGetMonitorInfo(otk::Monitor monitor, out MonitorInfo info)
        {
            if (_monitorIndexLookup.TryGetValue(monitor.Pointer, out int index))
            {
                return TryGetMonitorInfo(index, out info);
            }

            info = null;
            return false;
        }

        /// <summary>
        /// Builds the monitor cache (again if called before).
        /// </summary>
        public static unsafe void BuildMonitorCache()
        {
            if (!GLFWProvider.IsOnMainThread)
            {
                throw new InvalidOperationException("Only GLFW main thread can build the monitor cache.");
            }

            var newInfos = new List<MonitorInfo>();
            var newIndexLookup = new Dictionary<IntPtr, int>();

            var monitors = GLFW.GetMonitorsRaw(out int monitorCount);

            for (int i = 0; i < monitorCount; i++)
            {
                var monitor = *(monitors + i);

                newInfos.Add(new MonitorInfo(new otk::Monitor((IntPtr)monitor)));
                newIndexLookup.Add((IntPtr)monitor, i);
            }

            _monitorInfos = newInfos;
            _monitorIndexLookup = newIndexLookup;

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
