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
        static unsafe Monitors()
        {
            GLFWProvider.EnsureInitialized();

            _monitorCallback = MonitorCallback;
            GLFW.SetMonitorCallback(_monitorCallback);
        }

        private static readonly GLFWCallbacks.MonitorCallback _monitorCallback;

        /// <summary>
        /// Occurs when a <see cref="MonitorHandle"/> is connected or disconnected.
        /// </summary>
        public static event Action<MonitorEventArgs> OnMonitorConnected;

        /// <summary>
        /// The number of monitors available.
        /// </summary>
        [Obsolete("Use GetMonitors() instead.", true)]
        public static unsafe int Count => throw new Exception("This property is Obsolete, use GetMonitors() instead.");

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
        /// Get the primary monitor. This is usually the monitor where elements like the task bar or global menu bar are located.
        /// </summary>
        /// <returns>The primary monitor.</returns>
        public static unsafe MonitorInfo GetPrimaryMonitor()
        {
            MonitorHandle monitor = new MonitorHandle((IntPtr)GLFW.GetPrimaryMonitor());
            return new MonitorInfo(monitor);
        }

        /// <summary>
        /// Retrives a list of connected monitors.
        /// </summary>
        /// <returns>A list of connected monitors.</returns>
        public static unsafe List<MonitorInfo> GetMonitors()
        {
            Monitor** monitorsRaw = GLFW.GetMonitorsRaw(out int count);

            List<MonitorInfo> monitors = new List<MonitorInfo>(count);

            for (int i = 0; i < count; i++)
            {
                monitors.Add(new MonitorInfo(new MonitorHandle((IntPtr)monitorsRaw[i])));
            }

            return monitors;
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
        public static unsafe MonitorInfo GetMonitorFromWindow(Window* window)
        {
            /*
             * According to the GLFW documentation, glfwGetWindowMonitor will return a value only
             * when the window is fullscreen.
             *
             * If the window is not fullscreen, find the monitor manually.
             */
            MonitorHandle value = new MonitorHandle((IntPtr)GLFW.GetWindowMonitor(window));
            if (value.Pointer != IntPtr.Zero)
            {
                // We where in fullscreen so just return the monitor.
                return new MonitorInfo(value);
            }

            /*
             * Here we compare the instersection area of the window with the monitors client area
             * and choose the monitor which has the largest overlapping area.
             *
             * This might not always be the *best* thing to look for.
             * Operating systems like Windows limits the max size of a window
             * to the size of the monitor which contains the top left corner of the window.
            */

            Box2i windowArea;
            {
                GLFW.GetWindowPos(window, out int windowX, out int windowY);
                GLFW.GetWindowSize(window, out int windowWidth, out int windowHeight);
                windowArea = new Box2i(windowX, windowY, windowX + windowWidth, windowY + windowHeight);
            }

            List<MonitorInfo> monitors = GetMonitors();

            int selectedIndex = 0;
            for (int i = 0; i < monitors.Count; i++)
            {
                if (
                    GetRectangleIntersectionArea(monitors[i].ClientArea, windowArea) >
                    GetRectangleIntersectionArea(monitors[selectedIndex].ClientArea, windowArea)
                )
                {
                    selectedIndex = i;
                }
            }

            return monitors[selectedIndex];
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
        public static unsafe MonitorInfo GetMonitorFromWindow(NativeWindow window) => GetMonitorFromWindow(window.WindowPtr);

        private static unsafe void MonitorCallback(Monitor* monitor, ConnectedState state)
        {
            OnMonitorConnected?.Invoke(new MonitorEventArgs(new MonitorHandle((IntPtr)monitor), state == ConnectedState.Connected));
        }

        /// <summary>
        /// Try to get information about a monitor.
        /// </summary>
        /// <param name="index">The index of the monitor.</param>
        /// <param name="info">Monitor information.</param>
        /// <returns>True when the object was retrieved from cache, or built successfully.</returns>
        [Obsolete("Use GetMonitors() instead.", true)]
        public static bool TryGetMonitorInfo(int index, out MonitorInfo info) => throw new Exception("This function is Obsolete, use GetMonitors() instead.");

        /// <summary>
        /// Try to get information about a monitor.
        /// </summary>
        /// <param name="monitor">The window handle.</param>
        /// <param name="info">Monitor information.</param>
        /// <returns>True when the object was retrieved from cache, or built successfully.</returns>
        [Obsolete("Use GetMonitors() instead.", true)]
        public static bool TryGetMonitorInfo(MonitorHandle monitor, out MonitorInfo info) => throw new Exception("This function is Obsolete, use GetMonitors() instead.");

        /// <summary>
        /// Checks wheter the cache has been built or builds it if it can.
        /// </summary>
        /// <returns>Wether the current cache is valid or not.</returns>
        [Obsolete("There is no cache anymore", true)]
        public static unsafe bool CheckCache() => throw new Exception("There is no cache anymore, don't call this function.");

        /// <summary>
        /// Builds the monitor cache (again if previously called).
        /// </summary>
        [Obsolete("There is no cache anymore", true)]
        public static unsafe void BuildMonitorCache() => throw new Exception("There is no cache anymore, don't call this function.");
    }
}
