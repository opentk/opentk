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
using System.Linq;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// Information about monitors installed on the system.
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

        private static int GetRectangleIntersectionArea(Box2i a, Box2i b)
        {
            var area = Box2i.Intersect(a, b);
            return area.Size.X * area.Size.Y;
        }

        /// <summary>
        /// Find the monitor a window is in.
        /// </summary>
        /// <param name="window">The window to find.</param>
        /// <returns>The window the monitor was found in.</returns>
        /// <remarks>
        /// This function searches for the window by finding which monitor has the largest
        /// intersection area with the given monitor.
        /// </remarks>
        public static unsafe MonitorHandle GetMonitorFromWindow(Window* window)
        {
            if (!CheckCache())
            {
                throw new Exception("This method can only be called from the main GLFW thread.");
            }

            Box2i windowArea;
            {
                int windowX, windowY, windowWidth, windowHeight;
                GLFW.GetWindowPos(window, out windowX, out windowY);
                GLFW.GetWindowSize(window, out windowWidth, out windowHeight);
                windowArea = new Box2i(windowX, windowY, windowX + windowWidth, windowY + windowHeight);
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
        /// Find the monitor a window is in.
        /// </summary>
        /// <param name="window">The window to find.</param>
        /// <returns>The window the monitor was found in.</returns>
        /// <remarks>
        /// This function searches for the window by finding which monitor has the largest
        /// intersection area with the given monitor.
        /// </remarks>
        public static unsafe MonitorHandle GetMonitorFromWindow(NativeWindow window) => GetMonitorFromWindow(window.WindowPtr);

        /// <summary>
        /// Checks wheter the cache has been built or builds it if it can.
        /// </summary>
        /// <returns>Wether the current cache is valid or not.</returns>
        public static unsafe bool CheckCache()
        {
            GLFWProvider.EnsureInitialized();

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
        /// Try to get information about a monitor.
        /// </summary>
        /// <param name="index">The index of the monitor.</param>
        /// <param name="info">Monitor information.</param>
        /// <returns>True when the object was retrieved from cache, or built successfully.</returns>
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
        /// Try to get information about a monitor.
        /// </summary>
        /// <param name="monitor">The window handle.</param>
        /// <param name="info">Monitor information.</param>
        /// <returns>True when the object was retrieved from cache, or built successfully.</returns>
        public static bool TryGetMonitorInfo(MonitorHandle monitor, out MonitorInfo info)
        {
            if (_monitorIndexLookup.TryGetValue(monitor.Pointer, out int index))
            {
                return TryGetMonitorInfo(index, out info);
            }

            info = null;
            return false;
        }

        /// <summary>
        /// Builds the monitor cache (again if previously called).
        /// </summary>
        public static unsafe void BuildMonitorCache()
        {
            GLFWProvider.EnsureInitialized();

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

                newInfos.Add(new MonitorInfo(new MonitorHandle((IntPtr)monitor)));
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
