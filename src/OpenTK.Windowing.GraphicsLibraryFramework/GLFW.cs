//
// GLFW.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;
using static OpenTK.Core.MarshalUtility;
using static OpenTK.Windowing.GraphicsLibraryFramework.GLFWNative;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Provides access to the GLFW API.
    /// </summary>
    public static class GLFW
    {
        // XML-documentation is from https://www.glfw.org/docs/latest/
        // Still missing in documentation

        /// <summary>
        ///     Gets an integer equal to GLFW_DONT_CARE. This can be used for several window hints to use the platform default.
        /// </summary>
        public const int DontCare = -1;

        /// <summary>
        ///     <para>
        ///         This function initializes the GLFW library. Before most GLFW functions can be used,
        ///         GLFW must be initialized, and before an application terminates GLFW should be terminated in order to
        ///         free any resources allocated during or after initialization.
        ///     </para>
        ///     <para>
        ///         If this function fails, it calls <see cref="Terminate" /> before returning.
        ///     </para>
        ///     <para>
        ///         If it succeeds, you should call <see cref="Terminate" /> before the application exits.
        ///     </para>
        ///     <para>
        ///         Additional calls to this function after successful initialization
        ///         but before termination will return <c>true</c> immediately.
        ///     </para>
        /// </summary>
        /// <returns><c>true</c> if successful, or <c>false</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         OS X: This function will change the current directory of the application
        ///         to the Contents/Resources subdirectory of the application's bundle, if present.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static bool Init() => glfwInit() == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function destroys all remaining windows and cursors, restores any modified gamma ramps
        ///         and frees any other allocated resources. Once this function is called,
        ///         you must again call <see cref="Init" /> successfully before you will be able to use most GLFW functions.
        ///     </para>
        ///     <para>
        ///         If GLFW has been successfully initialized, this function should be called before the application exits.
        ///     </para>
        ///     <para>
        ///         If initialization fails, there is no need to call this function,
        ///         as it is called by <see cref="Init" /> before it returns failure.
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         The contexts of any remaining windows must not be current on any other thread when this function is called.
        ///     </para>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static void Terminate() => glfwTerminate();

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next initialization of GLFW.
        ///     </para>
        ///     <para>
        ///         The values you set hints to are never reset by GLFW, but they only take effect during initialization.
        ///     </para>
        ///     <para>
        ///         Once GLFW has been initialized,
        ///         any values you set will be ignored until the library is terminated and initialized again.
        ///     </para>
        ///     <para>
        ///         Some hints are platform specific.
        ///         These may be set on any platform but they will only affect their specific platform.
        ///         Other platforms will ignore them. Setting these hints requires no platform specific headers or functions.
        ///     </para>
        /// </summary>
        /// <param name="hintBool">The <see cref="InitHintBool" /> to set.</param>
        /// <param name="value">The new value of the <see cref="InitHintBool" />.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        /// </remarks>
        public static void InitHint(InitHintBool hintBool, bool value) =>
            glfwInitHint((int)hintBool, value ? GLFW_TRUE : GLFW_FALSE);

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next initialization of GLFW.
        ///     </para>
        ///     <para>
        ///         The values you set hints to are never reset by GLFW, but they only take effect during initialization.
        ///     </para>
        ///     <para>
        ///         Once GLFW has been initialized,
        ///         any values you set will be ignored until the library is terminated and initialized again.
        ///     </para>
        ///     <para>
        ///         Some hints are platform specific.
        ///         These may be set on any platform but they will only affect their specific platform.
        ///         Other platforms will ignore them. Setting these hints requires no platform specific headers or functions.
        ///     </para>
        /// </summary>
        /// <param name="hintInt">The <see cref="InitHintInt" /> to set.</param>
        /// <param name="value">The new value of the <see cref="InitHintBool" />.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        /// </remarks>
        public static void InitHint(InitHintInt hintInt, int value) => glfwInitHint((int)hintInt, value);

        /// <summary>
        ///     <para>
        ///         This function retrieves the major, minor and revision numbers of the GLFW library.
        ///         It is intended for when you are using GLFW
        ///         as a shared library and want to ensure that you are using the minimum required version.
        ///     </para>
        ///     <para>
        ///         Any or all of the version arguments may be <c>out _</c>.
        ///     </para>
        /// </summary>
        /// <param name="major">Where to store the major version number, or <c>out _</c>.</param>
        /// <param name="minor">Where to store the minor version number, or <c>out _</c>.</param>
        /// <param name="revision">Where to store the revision number, or <c>out _</c>.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        public static unsafe void GetVersion(out int major, out int minor, out int revision)
        {
            int localMajor, localMinor, localRevision;
            glfwGetVersion(&localMajor, &localMinor, &localRevision);
            major = localMajor;
            minor = localMinor;
            revision = localRevision;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the compile-time generated version string of the GLFW library binary.
        ///         It describes the version, platform, compiler and any platform-specific compile-time options.
        ///         It should not be confused with the OpenGL or OpenGL ES version string, queried with <c>glGetString</c>.
        ///     </para>
        ///     <para>
        ///         Do not use the version string to parse the GLFW library version.
        ///         The <see cref="GetVersion" /> function provides the version of the running library binary in numerical format.
        ///     </para>
        /// </summary>
        /// <returns>The ASCII-encoded GLFW version string.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         The returned string is static and compile-time generated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVersion" />
        public static unsafe string GetVersionString() => PtrToStringUTF8(glfwGetVersionString());

        /// <summary>
        ///     <para>
        ///         This function returns the compile-time generated version string of the GLFW library binary.
        ///         It describes the version, platform, compiler and any platform-specific compile-time options.
        ///         It should not be confused with the OpenGL or OpenGL ES version string, queried with <c>glGetString</c>.
        ///     </para>
        ///     <para>
        ///         Do not use the version string to parse the GLFW library version.
        ///         The <see cref="GetVersion" /> function provides the version of the running library binary in numerical format.
        ///     </para>
        /// </summary>
        /// <returns>The ASCII-encoded GLFW version string.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         The returned string is static and compile-time generated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVersion" />
        public static unsafe byte* GetVersionStringRaw() => glfwGetVersionString();

        /// <summary>
        ///     <para>
        ///         This function returns and clears the error code of the last error that occurred on the calling thread,
        ///         and optionally a UTF-8 encoded human-readable description of it.
        ///     </para>
        ///     <para>
        ///         If no error has occurred since the last call,
        ///         it returns <see cref="ErrorCode.NoError" /> (zero) and the description pointer is set to <c>null</c>.
        ///     </para>
        /// </summary>
        /// <param name="description">Where to store the error description pointer, or <c>out _</c>"/>.</param>
        /// <returns>The last error code for the calling thread, or <see cref="ErrorCode.NoError" /> (zero).</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is only guaranteed to be valid until the next error occurs or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetErrorCallback" />
        public static unsafe ErrorCode GetError(out string description)
        {
            byte* desc;
            var code = glfwGetError(&desc);
            description = PtrToStringUTF8(desc);
            return code;
        }

        /// <summary>
        ///     <para>
        ///         This function returns and clears the error code of the last error that occurred on the calling thread,
        ///         and optionally a UTF-8 encoded human-readable description of it.
        ///     </para>
        ///     <para>
        ///         If no error has occurred since the last call,
        ///         it returns <see cref="ErrorCode.NoError" /> (zero) and the description pointer is set to <c>null</c>.
        ///     </para>
        /// </summary>
        /// <param name="description">Where to store the error description pointer, or <c>out _</c>"/>.</param>
        /// <returns>The last error code for the calling thread, or <see cref="ErrorCode.NoError" /> (zero).</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is only guaranteed to be valid until the next error occurs or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetErrorCallback" />
        public static unsafe ErrorCode GetErrorRaw(out byte* description)
        {
            byte* desc;
            var code = glfwGetError(&desc);
            description = desc;
            return code;
        }

        /// <summary>
        ///     <para>
        ///         This function returns an array of handles for all currently connected monitors.
        ///         The primary monitor is always first in the returned array.
        ///     </para>
        ///     <para>
        ///         If no monitors were found, this function returns <c>null</c>.
        ///     </para>
        /// </summary>
        /// <param name="count">
        ///     Where to store the number of monitors in the returned array. This is set to zero if an error occurred.
        /// </param>
        /// <returns>
        ///     An array of monitor handles, or <c>null</c> if no monitors were found or if an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is only guaranteed to be valid until the monitor configuration changes or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetPrimaryMonitor" />
        public static unsafe Monitor** GetMonitorsRaw(out int count)
        {
            fixed (int* ptr = &count)
            {
                return glfwGetMonitors(ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function returns an array of handles for all currently connected monitors.
        ///         The primary monitor is always first in the returned array.
        ///     </para>
        ///     <para>
        ///         If no monitors were found, this function returns <c>null</c>.
        ///     </para>
        /// </summary>
        /// <param name="count">
        ///     Where to store the number of monitors in the returned array. This is set to zero if an error occurred.
        /// </param>
        /// <returns>
        ///     An array of monitor handles, or <c>null</c> if no monitors were found or if an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is only guaranteed to be valid until the monitor configuration changes or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetPrimaryMonitor" />
        public static unsafe Monitor** GetMonitorsRaw(int* count) => glfwGetMonitors(count);

        /// <summary>
        ///     <para>
        ///         This function returns an array of handles for all currently connected monitors.
        ///         The primary monitor is always first in the returned array.
        ///     </para>
        ///     <para>
        ///         If no monitors were found, this function returns <c>null</c>.
        ///     </para>
        /// </summary>
        /// <returns>
        ///     An array of monitor handles, or <c>null</c> if no monitors were found or if an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is only guaranteed to be valid until the monitor configuration changes or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetPrimaryMonitor" />
        public static unsafe Monitor*[] GetMonitors()
        {
            var ptr = GetMonitorsRaw(out var count);

            if (ptr == null)
            {
                return null;
            }

            var array = new Monitor*[count];

            for (var i = 0; i < count; i++)
            {
                array[i] = ptr[i];
            }

            return array;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the position, in screen coordinates, of the upper-left corner of the specified monitor.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="x">Where to store the monitor x-coordinate, or <c>out _</c>.</param>
        /// <param name="y">Where to store the monitor y-coordinate, or <c>out _</c>.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetMonitorPos(Monitor* monitor, out int x, out int y)
        {
            int localX, localY;

            glfwGetMonitorPos(monitor, &localX, &localY);

            x = localX;
            y = localY;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the position, in screen coordinates, of the upper-left corner of the specified monitor.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="x">Where to store the monitor x-coordinate.</param>
        /// <param name="y">Where to store the monitor y-coordinate.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetMonitorPos(Monitor* monitor, int* x, int* y)
        {
            glfwGetMonitorPos(monitor, x, y);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the size, in millimetres, of the display area of the specified monitor.
        ///     </para>
        ///     <para>
        ///         Some systems do not provide accurate monitor size information,
        ///         either because the monitor EDID(Extended Display Identification Data) data is incorrect
        ///         or because the driver does not report it accurately.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="width">
        ///     Where to store the width, in millimetres, of the monitor's display area, or <c>out _</c>.
        /// </param>
        /// <param name="height">
        ///     Where to store the height, in millimetres, of the monitor's display area, or <c>out _</c>.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         Windows: calculates the returned physical size from the current resolution
        ///         and system DPI instead of querying the monitor EDID data.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetMonitorPhysicalSize(Monitor* monitor, out int width, out int height)
        {
            int localWidth, localHeight;

            glfwGetMonitorPhysicalSize(monitor, &localWidth, &localHeight);

            width = localWidth;
            height = localHeight;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the content scale for the specified monitor.
        ///     </para>
        ///     <para>
        ///         The content scale is the ratio between the current DPI and the platform's default DPI.
        ///     </para>
        ///     <para>
        ///         If you scale all pixel dimensions by this scale then your content should appear at an appropriate size.
        ///         This is especially important for text and any UI elements.
        ///     </para>
        ///     <para>
        ///         The content scale may depend on both the monitor resolution and pixel density and on user settings.
        ///         It may be very different from the raw DPI calculated from the physical size and current resolution.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="xScale">Where to store the x-axis content scale, or <c>out _</c>.</param>
        /// <param name="yScale">Where to store the y-axis content scale, or <c>out _</c>.</param>
        public static unsafe void GetMonitorContentScale(Monitor* monitor, out float xScale, out float yScale)
        {
            float localX, localY;

            glfwGetMonitorContentScale(monitor, &localX, &localY);

            xScale = localX;
            yScale = localY;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the content scale for the specified monitor.
        ///     </para>
        ///     <para>
        ///         The content scale is the ratio between the current DPI and the platform's default DPI.
        ///     </para>
        ///     <para>
        ///         If you scale all pixel dimensions by this scale then your content should appear at an appropriate size.
        ///         This is especially important for text and any UI elements.
        ///     </para>
        ///     <para>
        ///         The content scale may depend on both the monitor resolution and pixel density and on user settings.
        ///         It may be very different from the raw DPI calculated from the physical size and current resolution.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="xScale">Where to store the x-axis content scale, or <c>out _</c>.</param>
        /// <param name="yScale">Where to store the y-axis content scale, or <c>out _</c>.</param>
        public static unsafe void GetMonitorContentScaleRaw(Monitor* monitor, float* xScale, float* yScale)
        {
            glfwGetMonitorContentScale(monitor, xScale, yScale);
        }

        /// <summary>
        ///     <para>
        ///         This function returns a human-readable name, encoded as UTF-8, of the specified monitor.
        ///         The name typically reflects the make and model of the monitor
        ///         and is not guaranteed to be unique among the connected monitors.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <returns>The UTF-8 encoded name of the monitor, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe string GetMonitorName(Monitor* monitor) => PtrToStringUTF8(glfwGetMonitorName(monitor));

        /// <summary>
        ///     <para>
        ///         This function returns a human-readable name, encoded as UTF-8, of the specified monitor.
        ///         The name typically reflects the make and model of the monitor
        ///         and is not guaranteed to be unique among the connected monitors.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <returns>The UTF-8 encoded name of the monitor, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe byte* GetMonitorNameRaw(Monitor* monitor) => glfwGetMonitorName(monitor);

        /// <summary>
        ///     <para>
        ///         This function sets the user-defined pointer of the specified monitor.
        ///         The current value is retained until the monitor is disconnected.
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from the monitor callback, even for a monitor that is being disconnected.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor whose pointer to set.</param>
        /// <param name="pointer">The new value.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetMonitorUserPointer(Monitor* monitor, void* pointer)
        {
            glfwSetMonitorUserPointer(monitor, pointer);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the current value of the user-defined pointer of the specified monitor.
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from the monitor callback, even for a monitor that is being disconnected.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor whose pointer to return.</param>
        /// <returns>The user-defined pointer of the given <paramref name="monitor" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void* GetMonitorUserPointer(Monitor* monitor) => glfwGetMonitorUserPointer(monitor);

        /// <summary>
        ///     <para>
        ///         This function returns an array of all video modes supported by the specified monitor.
        ///         The returned array is sorted in ascending order, first by color bit depth (the sum of all channel depths)
        ///         and then by resolution area (the product of width and height).
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="count">
        ///     Where to store the number of video modes in the returned array.
        ///     This is set to zero if an error occurred.
        /// </param>
        /// <returns>An array of video modes, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected,
        ///         this function is called again for that monitor, or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVideoMode" />
        public static unsafe VideoMode* GetVideoModesRaw(Monitor* monitor, out int count)
        {
            fixed (int* ptr = &count)
            {
                return glfwGetVideoModes(monitor, ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function returns an array of all video modes supported by the specified monitor.
        ///         The returned array is sorted in ascending order, first by color bit depth (the sum of all channel depths)
        ///         and then by resolution area (the product of width and height).
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="count">
        ///     Where to store the number of video modes in the returned array.
        ///     This is set to zero if an error occurred.
        /// </param>
        /// <returns>An array of video modes, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected,
        ///         this function is called again for that monitor, or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVideoMode" />
        public static unsafe VideoMode* GetVideoModesRaw(Monitor* monitor, int* count) => glfwGetVideoModes(monitor, count);

        /// <summary>
        ///     <para>
        ///         This function returns an array of all video modes supported by the specified monitor.
        ///         The returned array is sorted in ascending order, first by color bit depth (the sum of all channel depths)
        ///         and then by resolution area (the product of width and height).
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <returns>An array of video modes, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected,
        ///         this function is called again for that monitor, or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVideoMode" />
        public static unsafe VideoMode[] GetVideoModes(Monitor* monitor)
        {
            var ptr = GetVideoModesRaw(monitor, out var count);

            if (ptr == null)
            {
                return null;
            }

            var array = new VideoMode[count];
            for (var i = 0; i < count; i++)
            {
                array[i] = ptr[i];
            }

            return array;
        }

        /// <summary>
        ///     <para>
        ///         This function generates a 256-element gamma ramp from the specified exponent and then calls
        ///         <see cref="SetGamma" /> with it. The value must be a finite number greater than zero.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor whose gamma ramp to set.</param>
        /// <param name="gamma">The desired exponent.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetGamma(Monitor* monitor, float gamma)
        {
            glfwSetGamma(monitor, gamma);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the current gamma ramp of the specified monitor.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query.</param>
        /// <returns>The current gamma ramp, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned structure and its arrays are allocated and freed by GLFW.
        ///         You should not free them yourself. They are valid until the specified monitor is disconnected,
        ///         this function is called again for that monitor or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe GammaRamp* GetGammaRamp(Monitor* monitor) => glfwGetGammaRamp(monitor);

        /// <summary>
        ///     <para>
        ///         This function sets the current gamma ramp for the specified monitor.
        ///     </para>
        ///     <para>
        ///         The original gamma ramp for that monitor
        ///         is saved by GLFW the first time this function is called and is restored by <see cref="Terminate" />.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor whose gamma ramp to set.</param>
        /// <param name="ramp">The gamma ramp to use.</param>
        /// <remarks>
        ///     <para>
        ///         Gamma ramp sizes other than 256 are not supported by all platforms or graphics hardware.
        ///     </para>
        ///     <para>
        ///         Windows: The gamma ramp size must be 256.
        ///     </para>
        ///     <para>
        ///         The specified gamma ramp is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetGammaRamp(Monitor* monitor, GammaRamp* ramp)
        {
            glfwSetGammaRamp(monitor, ramp);
        }

        /// <summary>
        ///     <para>
        ///         This function resets all window hints to their default values.
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static void DefaultWindowHints() => glfwDefaultWindowHints();

        /// <summary>
        ///     <para>
        ///         Sets the specified window hint to the desired value.
        ///     </para>
        ///     <para>
        ///         This function sets hints for the next call to @ref glfwCreateWindow.  The
        ///         hints, once set, retain their values until changed by a call to this
        ///         function or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported by the next
        ///         call to <see cref="CreateWindow" />.
        ///     </para>
        ///     <para>
        ///         Some hints are platform specific.  These may be set on any platform but they
        ///         will only affect their specific platform.  Other platforms will ignore them.
        ///         Setting these hints requires no platform specific headers or functions.
        ///     </para>
        /// </summary>
        /// <param name="hint">The window hint to set.</param>
        /// <param name="value">The new value of the set hint.</param>
        /// <remarks>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        ///     <para>
        ///         The string is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static unsafe void WindowHint(WindowHintString hint, string value)
        {
            var ptr = StringToCoTaskMemUTF8(value);

            try
            {
                glfwWindowHintString((int)hint, (byte*)ptr);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         Sets the specified window hint to the desired value.
        ///     </para>
        ///     <para>
        ///         This function sets hints for the next call to @ref glfwCreateWindow.  The
        ///         hints, once set, retain their values until changed by a call to this
        ///         function or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported by the next
        ///         call to <see cref="CreateWindow" />.
        ///     </para>
        ///     <para>
        ///         Some hints are platform specific.  These may be set on any platform but they
        ///         will only affect their specific platform.  Other platforms will ignore them.
        ///         Setting these hints requires no platform specific headers or functions.
        ///     </para>
        /// </summary>
        /// <param name="hint">The window hint to set.</param>
        /// <param name="value">The new value of the set hint.</param>
        /// <remarks>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        ///     <para>
        ///         The string is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static unsafe void WindowHintRaw(WindowHintString hint, byte* value)
        {
            glfwWindowHintString((int)hint, value);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the size limits of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         If the window is full screen, the size limits only take effect once it is made windowed.
        ///     </para>
        ///     <para>
        ///         If the window is not resizable, this function does nothing.
        ///     </para>
        ///     <para>
        ///         The size limits are applied immediately to a windowed mode window and may cause it to be resized.
        ///     </para>
        ///     <para>
        ///         The maximum dimensions must be greater than or equal to the minimum dimensions
        ///         and all must be greater than or equal to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to set limits for.</param>
        /// <param name="minWidth">
        ///     The minimum width, in screen coordinates, of the client area, or <see cref="GLFW.DontCare" />.
        /// </param>
        /// <param name="minHeight">
        ///     The minimum height, in screen coordinates, of the client area, or <see cref="GLFW.DontCare" />.
        /// </param>
        /// <param name="maxWidth">
        ///     The maximum width, in screen coordinates, of the client area, or <see cref="GLFW.DontCare" />.
        /// </param>
        /// <param name="maxHeight">
        ///     The maximum height, in screen coordinates, of the client area, or <see cref="GLFW.DontCare" />.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         If you set size limits and an aspect ratio that conflict, the results are undefined.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowSizeLimits(
            Window* window,
            int minWidth,
            int minHeight,
            int maxWidth,
            int maxHeight)
        {
            glfwSetWindowSizeLimits(window, minWidth, minHeight, maxWidth, maxHeight);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the required aspect ratio of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         If the window is full screen, the aspect ratio only takes effect once it is made windowed.
        ///     </para>
        ///     <para>
        ///         If the window is not resizable, this function does nothing.
        ///     </para>
        ///     <para>
        ///         The aspect ratio is specified as a numerator and a denominator and both values must be greater than zero.
        ///         For example, the common 16:9 aspect ratio is specified as 16 and 9, respectively.
        ///     </para>
        ///     <para>
        ///         If the numerator and denominator is set to <see cref="GLFW.DontCare" /> then the aspect ratio limit is disabled.
        ///     </para>
        ///     <para>
        ///         The aspect ratio is applied immediately to a windowed mode window and may cause it to be resized.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to set limits for.</param>
        /// <param name="numer">The numerator of the desired aspect ratio, or <see cref="GLFW.DontCare" />.</param>
        /// <param name="denom">The denominator of the desired aspect ratio, or <see cref="GLFW.DontCare" />.</param>
        /// <remarks>
        ///     <para>
        ///         If you set size limits and an aspect ratio that conflict, the results are undefined.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowAspectRatio(Window* window, int numer, int denom)
        {
            glfwSetWindowAspectRatio(window, numer, denom);
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the size, in screen coordinates, of each edge of the frame of the specified window.
        ///     </para>
        ///     <para>
        ///         This size includes the title bar, if the window has one.
        ///         The size of the frame may vary depending on the window-related hints used to create it.
        ///     </para>
        ///     <para>
        ///         Because this function retrieves the size of each window frame edge
        ///         and not the offset along a particular coordinate axis, the retrieved values will always be zero or positive.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose frame size to query.</param>
        /// <param name="left">
        ///     Where to store the size, in screen coordinates, of the left edge of the window frame, or <c>out _</c>.
        /// </param>
        /// <param name="top">
        ///     Where to store the size, in screen coordinates, of the top edge of the window frame, or <c>out _</c>.
        /// </param>
        /// <param name="right">
        ///     Where to store the size, in screen coordinates, of the right edge of the window frame, or <c>out _</c>.
        /// </param>
        /// <param name="bottom">
        ///     Where to store the size, in screen coordinates, of the bottom edge of the window frame, or <c>out _</c>.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetWindowFrameSize(
            Window* window,
            out int left,
            out int top,
            out int right,
            out int bottom)
        {
            int l, t, r, b;
            glfwGetWindowFrameSize(window, &l, &t, &r, &b);
            left = l;
            top = t;
            right = r;
            bottom = b;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the content scale for the specified window.
        ///     </para>
        ///     <para>
        ///         The content scale is the ratio between the current DPI and the platform's default DPI.
        ///         This is especially important for text and any UI elements.
        ///         If the pixel dimensions of your UI scaled by this look appropriate on your machine then it should
        ///         appear at a reasonable size on other machines regardless of their DPI and scaling settings.
        ///         This relies on the system DPI and scaling settings being somewhat correct.
        ///     </para>
        ///     <para>
        ///         On systems where each monitors can have its own content scale,
        ///         the window content scale will depend on which monitor the system considers the window to be on.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="xScale">Where to store the x-axis content scale, or <c>out _</c>.</param>
        /// <param name="yScale">Where to store the y-axis content scale, or <c>out _</c>.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetWindowContentScale(
            Window* window,
            out float xScale,
            out float yScale)
        {
            float x, y;
            glfwGetWindowContentScale(window, &x, &y);
            xScale = x;
            yScale = y;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the opacity of the window, including any decorations.
        ///     </para>
        ///     <para>
        ///         The opacity (or alpha) value is a positive finite number between zero and one,
        ///         where zero is fully transparent and one is fully opaque.
        ///     </para>
        ///     <para>
        ///         If the system does not support whole window transparency, this function always returns one.
        ///     </para>
        ///     <para>
        ///         The initial opacity value for newly created windows is one.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The opacity value of the specified window.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowOpacity" />
        public static unsafe float GetWindowOpacity(Window* window) => glfwGetWindowOpacity(window);

        /// <summary>
        ///     <para>
        ///         This function sets the opacity of the window, including any decorations.
        ///     </para>
        ///     <para>
        ///         The opacity (or alpha) value is a positive finite number between zero and one,
        ///         where zero is fully transparent and one is fully opaque.
        ///     </para>
        ///     <para>
        ///         The initial opacity value for newly created windows is one.
        ///     </para>
        ///     <para>
        ///         A window created with framebuffer transparency may not use whole window transparency.
        ///         The results of doing this are undefined.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to set the opacity for.</param>
        /// <param name="opacity">The desired opacity of the specified window.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetWindowOpacity" />
        public static unsafe void SetWindowOpacity(Window* window, float opacity)
        {
            glfwSetWindowOpacity(window, opacity);
        }

        /// <summary>
        ///     <para>
        ///         This function requests user attention to the specified window.
        ///         On platforms where this is not supported, attention is requested to the application as a whole.
        ///     </para>
        ///     <para>
        ///         Once the user has given attention, usually by focusing the window or application,
        ///         the system will end the request automatically.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to request attention to.</param>
        /// <remarks>
        ///     <para>
        ///         macOS: Attention is requested to the application as a whole, not the specific window.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void RequestWindowAttention(Window* window) => glfwRequestWindowAttention(window);

        /// <summary>
        ///     <para>
        ///         This function sets the value of an attribute of the specified window.
        ///     </para>
        ///     <para>
        ///         The supported attributes are <see cref="WindowAttribute.Decorated" />,
        ///         <see cref="WindowAttribute.Resizable" />, <see cref="WindowAttribute.Floating" />,
        ///         <see cref="WindowAttribute.AutoIconify" /> and <see cref="WindowAttribute.FocusOnShow" />.
        ///     </para>
        ///     <para>
        ///         Some of these attributes are ignored for full screen windows.
        ///         The new value will take effect if the window is later made windowed.
        ///     </para>
        ///     <para>
        ///         Some of these attributes are ignored for windowed mode windows.
        ///         The new value will take effect if the window is later made full screen.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to set the attribute for.</param>
        /// <param name="attribute">A supported window attribute.</param>
        /// <param name="value"><c>true</c> or <c>false</c>.</param>
        /// <remarks>
        ///     <para>
        ///         Calling <see cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" /> will always return the latest value,
        ///         even if that value is ignored by the current mode of the window.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowAttrib(Window* window, WindowAttribute attribute, bool value)
        {
            glfwSetWindowAttrib(window, attribute, value ? GLFW_TRUE : GLFW_FALSE);
        }

        /// <summary>
        ///     <para>
        ///         This function returns whether raw mouse motion is supported on the current system.
        ///         This status does not change after GLFW has been initialized so you only need to check this once.
        ///         If you attempt to enable raw motion on a system that does not support it,
        ///         <see cref="ErrorCode.PlatformError" /> will be emitted.
        ///     </para>
        ///     <para>
        ///         Raw mouse motion is closer to the actual motion of the mouse across a surface.
        ///         It is not affected by the scaling and acceleration applied to the motion of the desktop cursor.
        ///         That processing is suitable for a cursor while raw motion is better for controlling for example a 3D camera.
        ///         Because of this, raw mouse motion is only provided when the cursor is disabled.
        ///     </para>
        /// </summary>
        /// <returns>
        ///     <c>true</c> if raw mouse motion is supported on the current machine, or <c>false</c> otherwise.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static bool RawMouseMotionSupported() => glfwRawMouseMotionSupported() == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the name of the specified printable key, encoded as UTF-8.
        ///         This is typically the character that key would produce without any modifier keys,
        ///         intended for displaying key bindings to the user.
        ///     </para>
        ///     <para>
        ///         For dead keys, it is typically the diacritic it would add to a character.
        ///     </para>
        ///     <para>
        ///         Do not use this function for text input.
        ///         You will break text input for many languages even if it happens to work for yours.
        ///     </para>
        ///     <para>
        ///         If the key is <see cref="Keys.Unknown" />, the scancode is used to identify the key, otherwise the scancode is ignored.
        ///         If you specify a non-printable key, or <see cref="Keys.Unknown" /> and a scancode that maps to a non-printable key,
        ///         this function returns <c>null</c> but does not emit an error.
        ///     </para>
        ///     <para>
        ///         This behavior allows you to always pass in the arguments in the key callback without modification.
        ///     </para>
        ///     <para>
        ///         The printable keys are:
        ///         <list type="">
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Apostrophe" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Comma" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Minus" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Period" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Slash" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Semicolon" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Equal" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.LeftBracket" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.RightBracket" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Backslash" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.D0" /> to <see cref="Keys.D9" /></term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.A" /> to <see cref="Keys.Z" /></term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.KeyPad0" /> to <see cref="Keys.KeyPad9" /></term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadDecimal" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadDivide" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadMultiply" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadSubtract" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadAdd" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadEqual" />
        ///                 </term>
        ///             </item>
        ///         </list>
        ///     </para>
        ///     <para>
        ///         Names for printable keys depend on keyboard layout,
        ///         while names for non-printable keys are the same across layouts but depend on the application language
        ///         and should be localized along with other user interface text.
        ///     </para>
        /// </summary>
        /// <param name="key">The key to query, or <see cref="Keys.Unknown" />.</param>
        /// <param name="scanCode">The scancode of the key to query.</param>
        /// <returns>The UTF-8 encoded, layout-specific name of the key, or <c>null</c>.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the next call to <see cref="GetKeyName" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe string GetKeyName(Keys key, int scanCode) => PtrToStringUTF8(glfwGetKeyName(key, scanCode));

        /// <summary>
        ///     <para>
        ///         This function returns the name of the specified printable key, encoded as UTF-8.
        ///         This is typically the character that key would produce without any modifier keys,
        ///         intended for displaying key bindings to the user.
        ///     </para>
        ///     <para>
        ///         For dead keys, it is typically the diacritic it would add to a character.
        ///     </para>
        ///     <para>
        ///         Do not use this function for text input.
        ///         You will break text input for many languages even if it happens to work for yours.
        ///     </para>
        ///     <para>
        ///         If the key is <see cref="Keys.Unknown" />, the scancode is used to identify the key, otherwise the scancode is ignored.
        ///         If you specify a non-printable key, or <see cref="Keys.Unknown" /> and a scancode that maps to a non-printable key,
        ///         this function returns <c>null</c> but does not emit an error.
        ///     </para>
        ///     <para>
        ///         This behavior allows you to always pass in the arguments in the key callback without modification.
        ///     </para>
        ///     <para>
        ///         The printable keys are:
        ///         <list type="">
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Apostrophe" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Comma" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Minus" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Period" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Slash" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Semicolon" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Equal" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.LeftBracket" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.RightBracket" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.Backslash" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.D0" /> to <see cref="Keys.D9" /></term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.A" /> to <see cref="Keys.Z" /></term>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="Keys.KeyPad0" /> to <see cref="Keys.KeyPad9" /></term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadDecimal" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadDivide" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadMultiply" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadSubtract" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadAdd" />
        ///                 </term>
        ///             </item>
        ///             <item>
        ///                 <term>
        ///                     <see cref="Keys.KeyPadEqual" />
        ///                 </term>
        ///             </item>
        ///         </list>
        ///     </para>
        ///     <para>
        ///         Names for printable keys depend on keyboard layout,
        ///         while names for non-printable keys are the same across layouts but depend on the application language
        ///         and should be localized along with other user interface text.
        ///     </para>
        /// </summary>
        /// <param name="key">The key to query, or <see cref="Keys.Unknown" />.</param>
        /// <param name="scancode">The scancode of the key to query.</param>
        /// <returns>The UTF-8 encoded, layout-specific name of the key, or <c>null</c>.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the next call to <see cref="GetKeyName" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe byte* GetKeyNameRaw(Keys key, int scancode) => glfwGetKeyName(key, scancode);

        /// <summary>
        ///     <para>
        ///         This function returns the platform-specific scancode of the specified key.
        ///     </para>
        ///     <para>
        ///         If the key is <see cref="Keys.Unknown" /> or does not exist on the keyboard this method will return -1.
        ///     </para>
        /// </summary>
        /// <param name="key">Any named key.</param>
        /// <returns>The platform-specific scancode for the key, or -1 if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static int GetKeyScancode(Keys key) => glfwGetKeyScancode(key);

        /// <summary>
        ///     <para>
        ///         This function returns the last state reported for the specified key to the specified window.
        ///         The returned state is one of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
        ///         The higher-level action <see cref="InputAction.Repeat" /> is only reported to the key callback.
        ///     </para>
        ///     <para>
        ///         If the <see cref="StickyAttributes.StickyKeys" /> input mode is enabled, this function returns
        ///         <see cref="InputAction.Press" /> the first time you call it for a key that was pressed,
        ///         even if that key has already been released.
        ///     </para>
        ///     <para>
        ///         The key functions deal with physical keys,
        ///         with key tokens named after their use on the standard US keyboard layout.
        ///         If you want to input text, use the Unicode character callback instead.
        ///     </para>
        ///     <para>
        ///         The modifier key bit masks are not key tokens and cannot be used with this function.
        ///     </para>
        ///     <para>
        ///         Do not use this function to implement text input.
        ///     </para>
        /// </summary>
        /// <param name="window">The desired window.</param>
        /// <param name="key">
        ///     The desired keyboard key. <see cref="Keys.Unknown" /> is not a valid key for this function.
        /// </param>
        /// <returns>One of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        public static unsafe InputAction GetKey(Window* window, Keys key) => glfwGetKey(window, key);

        /// <summary>
        ///     <para>
        ///         This function returns the last state reported for the specified mouse button to the specified window.
        ///         The returned state is one of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
        ///     </para>
        ///     <para>
        ///         If the <see cref="StickyAttributes.StickyMouseButtons" /> input mode is enabled, this function returns
        ///         <see cref="InputAction.Press" /> the first time you call it for a mouse button that was pressed,
        ///         even if that mouse button has already been released.
        ///     </para>
        /// </summary>
        /// <param name="window">The desired window.</param>
        /// <param name="button">The desired mouse button.</param>
        /// <returns>One of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        public static unsafe InputAction GetMouseButton(Window* window, MouseButton button) => glfwGetMouseButton(window, button);

        /// <summary>
        ///     <para>
        ///         This function returns the position of the cursor,
        ///         in screen coordinates, relative to the upper-left corner of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         If the cursor is disabled (with <see cref="CursorModeValue.CursorDisabled" />) then the cursor position
        ///         is unbounded and limited only by the minimum and maximum values of a double.
        ///     </para>
        ///     <para>
        ///         The coordinate can be converted to their integer equivalents with the floor function.
        ///         Casting directly to an integer type works for positive coordinates, but fails for negative ones.
        ///     </para>
        ///     <para>
        ///         Any or all of the position arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> position arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The desired window.</param>
        /// <param name="xPos">
        ///     Where to store the cursor x-coordinate, relative to the left edge of the client area, or <c>out _</c>.
        /// </param>
        /// <param name="yPos">
        ///     Where to store the cursor y-coordinate, relative to the to top edge of the client area, or <c>out _</c>.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetCursorPos(Window* window, out double xPos, out double yPos)
        {
            double x, y;
            glfwGetCursorPos(window, &x, &y);
            xPos = x;
            yPos = y;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the position of the cursor,
        ///         in screen coordinates, relative to the upper-left corner of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         If the cursor is disabled (with <see cref="CursorModeValue.CursorDisabled" />) then the cursor position
        ///         is unbounded and limited only by the minimum and maximum values of a double.
        ///     </para>
        ///     <para>
        ///         The coordinate can be converted to their integer equivalents with the floor function.
        ///         Casting directly to an integer type works for positive coordinates, but fails for negative ones.
        ///     </para>
        ///     <para>
        ///         Any or all of the position arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> position arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The desired window.</param>
        /// <param name="xPos">
        ///     Where to store the cursor x-coordinate, relative to the left edge of the client area, or <c>out _</c>.
        /// </param>
        /// <param name="yPos">
        ///     Where to store the cursor y-coordinate, relative to the to top edge of the client area, or <c>out _</c>.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetCursorPosRaw(Window* window, double* xPos, double* yPos)
        {
            glfwGetCursorPos(window, xPos, yPos);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the position, in screen coordinates,
        ///         of the cursor relative to the upper-left corner of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         The window must have input focus.
        ///         If the window does not have input focus when this function is called, it fails silently.
        ///     </para>
        ///     <para>
        ///         Do not use this function to implement things like camera controls.
        ///         GLFW already provides the <see cref="CursorModeValue.CursorDisabled" /> cursor mode that hides the cursor,
        ///         transparently re-centers it and provides unconstrained cursor motion.
        ///         See <see cref="SetInputMode(Window*,CursorStateAttribute,CursorModeValue)" /> for more information.
        ///     </para>
        ///     <para>
        ///         If the cursor mode is <see cref="CursorModeValue.CursorDisabled" /> then the cursor position is unconstrained
        ///         and limited only by the minimum and maximum values of a double.
        ///     </para>
        /// </summary>
        /// <param name="window">The desired window.</param>
        /// <param name="xPos">The desired x-coordinate, relative to the left edge of the client area.</param>
        /// <param name="yPos">The desired y-coordinate, relative to the top edge of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         Wayland: This function will only work when the cursor mode is <see cref="CursorModeValue.CursorDisabled" />,
        ///         otherwise it will do nothing.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetCursorPos(Window* window, double xPos, double yPos)
        {
            glfwSetCursorPos(window, xPos, yPos);
        }

        /// <summary>
        ///     <para>
        ///         Creates a new custom cursor image that can be set for a window with <see cref="SetCursor" />.
        ///     </para>
        ///     <para>
        ///         The cursor can be destroyed with <see cref="DestroyCursor" />.
        ///         Any remaining cursors are destroyed by <see cref="Terminate" />.
        ///     </para>
        ///     <para>
        ///         The pixels are 32-bit, little-endian, non-premultiplied RGBA,
        ///         i.e. eight bits per channel with the red channel first.
        ///         They are arranged canonically as packed sequential rows, starting from the top-left corner.
        ///     </para>
        ///     <para>
        ///         The cursor hotspot is specified in pixels, relative to the upper-left corner of the cursor image.
        ///         Like all other coordinate systems in GLFW, the X-axis points to the right and the Y-axis points down.
        ///     </para>
        /// </summary>
        /// <param name="image">The desired cursor image.</param>
        /// <param name="xHot">The desired x-coordinate, in pixels, of the cursor hotspot.</param>
        /// <param name="yHot">The desired y-coordinate, in pixels, of the cursor hotspot.</param>
        /// <returns>The handle of the created cursor, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The specified image data is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Cursor* CreateCursor(in Image image, int xHot, int yHot)
        {
            fixed (Image* ptr = &image)
            {
                return CreateCursorRaw(ptr, xHot, yHot);
            }
        }

        /// <summary>
        ///     <para>
        ///         Creates a new custom cursor image that can be set for a window with <see cref="SetCursor" />.
        ///     </para>
        ///     <para>
        ///         The cursor can be destroyed with <see cref="DestroyCursor" />.
        ///         Any remaining cursors are destroyed by <see cref="Terminate" />.
        ///     </para>
        ///     <para>
        ///         The pixels are 32-bit, little-endian, non-premultiplied RGBA,
        ///         i.e. eight bits per channel with the red channel first.
        ///         They are arranged canonically as packed sequential rows, starting from the top-left corner.
        ///     </para>
        ///     <para>
        ///         The cursor hotspot is specified in pixels, relative to the upper-left corner of the cursor image.
        ///         Like all other coordinate systems in GLFW, the X-axis points to the right and the Y-axis points down.
        ///     </para>
        /// </summary>
        /// <param name="image">The desired cursor image.</param>
        /// <param name="xHot">The desired x-coordinate, in pixels, of the cursor hotspot.</param>
        /// <param name="yHot">The desired y-coordinate, in pixels, of the cursor hotspot.</param>
        /// <returns>The handle of the created cursor, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The specified image data is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Cursor* CreateCursorRaw(Image* image, int xHot, int yHot) => glfwCreateCursor(image, xHot, yHot);

        /// <summary>
        ///     <para>
        ///         Returns a cursor with a standard shape, that can be set for a window with <see cref="SetCursor" />.
        ///     </para>
        /// </summary>
        /// <param name="shape">One of the standard shapes.</param>
        /// <returns>A new cursor ready to use or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Cursor* CreateStandardCursor(CursorShape shape) => glfwCreateStandardCursor(shape);

        /// <summary>
        ///     <para>
        ///         This function destroys a cursor previously created with <see cref="CreateCursor" />.
        ///         Any remaining cursors will be destroyed by <see cref="Terminate" />.
        ///     </para>
        ///     <para>
        ///         If the specified cursor is current for any window, that window will be reverted to the default cursor.
        ///         This does not affect the cursor mode.
        ///     </para>
        /// </summary>
        /// <param name="cursor">The cursor object to destroy.</param>
        /// <remarks>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void DestroyCursor(Cursor* cursor) => glfwDestroyCursor(cursor);

        /// <summary>
        ///     <para>
        ///         This function sets the cursor image to be used when the cursor is over the client area
        ///         of the specified window.
        ///     </para>
        ///     <para>
        ///         The set cursor will only be visible
        ///         when the cursor mode of the window is <see cref="CursorModeValue.CursorNormal" />.
        ///     </para>
        ///     <para>
        ///         On some platforms, the set cursor may not be visible unless the window also has input focus.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to set the cursor for.</param>
        /// <param name="cursor">The cursor to set, or <c>null</c> to switch back to the default arrow cursor.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetCursor(Window* window, Cursor* cursor)
        {
            glfwSetCursor(window, cursor);
        }

        /// <summary>
        ///     <para>
        ///         This function returns whether the specified joystick is present.
        ///     </para>
        ///     <para>
        ///         There is no need to call this function before other functions that accept a joystick ID,
        ///         as they all check for presence before performing any other work.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns><c>true</c> if the joystick is present, or <c>false</c> otherwise.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static bool JoystickPresent(int jid) => glfwJoystickPresent(jid) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the values of all axes of the specified joystick.
        ///         Each element in the array is a value between -1.0 and 1.0.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present
        ///         this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     An array of axis values, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW.
        ///         You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Span<float> GetJoystickAxes(int jid)
        {
            return new Span<float>(GetJoystickAxesRaw(jid, out var count), count);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the values of all axes of the specified joystick.
        ///         Each element in the array is a value between -1.0 and 1.0.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present
        ///         this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of axis values in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of axis values, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW.
        ///         You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe float* GetJoystickAxesRaw(int jid, out int count)
        {
            fixed (int* ptr = &count)
            {
                return GetJoystickAxesRaw(jid, ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function returns the values of all axes of the specified joystick.
        ///         Each element in the array is a value between -1.0 and 1.0.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present
        ///         this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of axis values in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of axis values, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW.
        ///         You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe float* GetJoystickAxesRaw(int jid, int* count) => glfwGetJoystickAxes(jid, count);

        /// <summary>
        ///     <para>
        ///         This function returns the state of all buttons of the specified joystick.
        ///         Each element in the array is either <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
        ///     </para>
        ///     <para>
        ///         For backward compatibility with earlier versions that did not have <see cref="GetJoystickHats" />,
        ///         the button array also includes all hats, each represented as four buttons.
        ///     </para>
        ///     <para>
        ///         The hats are in the same order as returned by <see cref="GetJoystickHats" /> and are in the order
        ///         up, right, down and left.
        ///     </para>
        ///     <para>
        ///         To disable these extra buttons, set the <see cref="InitHintBool.JoystickHatButtons" />
        ///         init hint before initialization.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     An array of button states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickInputAction[] GetJoystickButtons(int jid)
        {
            var ptr = GetJoystickButtonsRaw(jid, out var count);

            if (ptr == null)
            {
                return null;
            }

            var array = new JoystickInputAction[count];
            for (var i = 0; i < count; i++)
            {
                array[i] = ptr[i];
            }

            return array;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the state of all buttons of the specified joystick.
        ///         Each element in the array is either <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
        ///     </para>
        ///     <para>
        ///         For backward compatibility with earlier versions that did not have <see cref="GetJoystickHats" />,
        ///         the button array also includes all hats, each represented as four buttons.
        ///     </para>
        ///     <para>
        ///         The hats are in the same order as returned by <see cref="GetJoystickHats" /> and are in the order
        ///         up, right, down and left.
        ///     </para>
        ///     <para>
        ///         To disable these extra buttons, set the <see cref="InitHintBool.JoystickHatButtons" />
        ///         init hint before initialization.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of button states in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of button states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickInputAction* GetJoystickButtonsRaw(int jid, out int count)
        {
            fixed (int* ptr = &count)
            {
                return GetJoystickButtonsRaw(jid, ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function returns the state of all buttons of the specified joystick.
        ///         Each element in the array is either <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
        ///     </para>
        ///     <para>
        ///         For backward compatibility with earlier versions that did not have <see cref="GetJoystickHats" />,
        ///         the button array also includes all hats, each represented as four buttons.
        ///     </para>
        ///     <para>
        ///         The hats are in the same order as returned by <see cref="GetJoystickHats" /> and are in the order
        ///         up, right, down and left.
        ///     </para>
        ///     <para>
        ///         To disable these extra buttons, set the <see cref="InitHintBool.JoystickHatButtons" />
        ///         init hint before initialization.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of button states in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of button states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickInputAction* GetJoystickButtonsRaw(int jid, int* count) => glfwGetJoystickButtons(jid, count);

        /// <summary>
        ///     <para>
        ///         This function returns the state of all hats of the specified joystick.
        ///         Each element in the array is one of the <see cref="JoystickHats" />.
        ///     </para>
        ///     <para>
        ///         The diagonal directions are bitwise combinations of the primary (up, right, down and left) directions
        ///         and you can test for these individually by ANDing it with the corresponding direction.
        ///         <code>
        /// if (hats[2].HasFlag(JoystickHats.Right))
        /// {
        ///    // State of hat 2 could be right-up, right or right-down
        /// }
        /// </code>
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present, this function will return NULL but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     An array of hat states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself
        ///         It is valid until the specified joystick is disconnected,
        ///         this function is called again for that joystick or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickHats[] GetJoystickHats(int jid)
        {
            var ptr = GetJoystickHatsRaw(jid, out var count);

            if (ptr == null)
            {
                return null;
            }

            var array = new JoystickHats[count];
            for (var i = 0; i < count; i++)
            {
                array[i] = ptr[i];
            }

            return array;
        }

        /// <summary>
        ///     <para>
        ///         This function returns the state of all hats of the specified joystick.
        ///         Each element in the array is one of the <see cref="JoystickHats" />.
        ///     </para>
        ///     <para>
        ///         The diagonal directions are bitwise combinations of the primary (up, right, down and left) directions
        ///         and you can test for these individually by ANDing it with the corresponding direction.
        ///         <code>
        /// if (hats[2].HasFlag(JoystickHats.Right))
        /// {
        ///    // State of hat 2 could be right-up, right or right-down
        /// }
        /// </code>
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present, this function will return NULL but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of hat states in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of hat states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself
        ///         It is valid until the specified joystick is disconnected,
        ///         this function is called again for that joystick or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickHats* GetJoystickHatsRaw(int jid, out int count)
        {
            fixed (int* ptr = &count)
            {
                return glfwGetJoystickHats(jid, ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function returns the state of all hats of the specified joystick.
        ///         Each element in the array is one of the <see cref="JoystickHats" />.
        ///     </para>
        ///     <para>
        ///         The diagonal directions are bitwise combinations of the primary (up, right, down and left) directions
        ///         and you can test for these individually by ANDing it with the corresponding direction.
        ///         <code>
        /// if (hats[2].HasFlag(JoystickHats.Right))
        /// {
        ///    // State of hat 2 could be right-up, right or right-down
        /// }
        /// </code>
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present, this function will return NULL but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="count">
        ///     Where to store the number of hat states in the returned array.
        ///     This is set to zero if the joystick is not present or an error occurred.
        /// </param>
        /// <returns>
        ///     An array of hat states, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself
        ///         It is valid until the specified joystick is disconnected,
        ///         this function is called again for that joystick or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe JoystickHats* GetJoystickHatsRaw(int jid, int* count) => glfwGetJoystickHats(jid, count);

        /// <summary>
        ///     <para>
        ///         This function returns the name, encoded as UTF-8, of the specified joystick.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded name of the joystick, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe string GetJoystickName(int jid) => PtrToStringUTF8(glfwGetJoystickName(jid));

        /// <summary>
        ///     <para>
        ///         This function returns the name, encoded as UTF-8, of the specified joystick.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded name of the joystick, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe byte* GetJoystickNameRaw(int jid) => glfwGetJoystickName(jid);

        /// <summary>
        ///     <para>
        ///         This function returns the SDL compatible GUID, as a UTF-8 encoded hexadecimal string,
        ///         of the specified joystick.
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///     </para>
        ///     <para>
        ///         The GUID is what connects a joystick to a gamepad mapping.
        ///         A connected joystick will always have a GUID even if there is no gamepad mapping assigned to it.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        ///     <para>
        ///         The GUID uses the format introduced in SDL 2.0.5.
        ///         This GUID tries to uniquely identify the make and model of a joystick but does not identify a specific unit,
        ///         e.g. all wired Xbox 360 controllers will have the same GUID on that platform.
        ///         The GUID for a unit may vary between platforms
        ///         depending on what hardware information the platform specific APIs provide.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded GUID of the joystick, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe string GetJoystickGUID(int jid) => PtrToStringUTF8(glfwGetJoystickGUID(jid));

        /// <summary>
        ///     <para>
        ///         This function returns the SDL compatible GUID, as a UTF-8 encoded hexadecimal string,
        ///         of the specified joystick.
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///     </para>
        ///     <para>
        ///         The GUID is what connects a joystick to a gamepad mapping.
        ///         A connected joystick will always have a GUID even if there is no gamepad mapping assigned to it.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present this function will return <c>null</c> but will not generate an error.
        ///         This can be used instead of first calling <see cref="JoystickPresent" />.
        ///     </para>
        ///     <para>
        ///         The GUID uses the format introduced in SDL 2.0.5.
        ///         This GUID tries to uniquely identify the make and model of a joystick but does not identify a specific unit,
        ///         e.g. all wired Xbox 360 controllers will have the same GUID on that platform.
        ///         The GUID for a unit may vary between platforms
        ///         depending on what hardware information the platform specific APIs provide.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded GUID of the joystick, or <c>null</c> if the joystick is not present or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe byte* GetJoystickGUIDRaw(int jid) => glfwGetJoystickGUID(jid);

        /// <summary>
        ///     <para>
        ///         This function sets the user-defined pointer of the specified joystick.
        ///         The current value is retained until the joystick is disconnected.
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from the joystick callback, even for a joystick that is being disconnected.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick whose pointer to set.</param>
        /// <param name="ptr">The new value.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetJoystickUserPointer(int jid, void* ptr)
        {
            glfwSetJoystickUserPointer(jid, ptr);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the current value of the user-defined pointer of the specified joystick.
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from the joystick callback, even for a joystick that is being disconnected.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick whose pointer to return.</param>
        /// <returns>The user-defined pointer of the given <paramref name="jid" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void* GetJoystickUserPointer(int jid) => glfwGetJoystickUserPointer(jid);

        /// <summary>
        ///     <para>
        ///         This function returns whether the specified joystick is both present and has a gamepad mapping.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is present but does not have a gamepad mapping
        ///         this function will return <c>false</c> but will not generate an error.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     <c>true</c> if a joystick is both present and has a gamepad mapping, or <c>false</c> otherwise.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         Call <see cref="JoystickPresent" /> to check if a joystick is present regardless of whether it has a mapping.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetGamepadState" />
        public static bool JoystickIsGamepad(int jid) => glfwJoystickIsGamepad(jid) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function parses the specified ASCII encoded string
        ///         and updates the internal list with any gamepad mappings it finds.
        ///     </para>
        ///     <para>
        ///         This string may contain either a single gamepad mapping or many mappings separated by newlines.
        ///     </para>
        ///     <para>
        ///         The parser supports the full format of the gamecontrollerdb.txt source file
        ///         including empty lines and comments.
        ///     </para>
        ///     <para>
        ///         See <a href="https://www.glfw.org/docs/3.3/input_guide.html#gamepad_mapping">Gamepad mappings</a>
        ///         for a description of the format.
        ///     </para>
        ///     <para>
        ///         If there is already a gamepad mapping for a given GUID in the internal list, it will be replaced by the one passed to this function. If the library is terminated and re-initialized the internal list will revert to the built-in default.
        ///     </para>
        /// </summary>
        /// <param name="newMapping">The string containing the gamepad mappings.</param>
        /// <returns><c>true</c> if successful, or <c>false</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool UpdateGamepadMappings(string newMapping)
        {
            var ptr = StringToCoTaskMemUTF8(newMapping);
            try
            {
                return glfwUpdateGamepadMappings((byte*)ptr) == GLFW_TRUE;
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function parses the specified ASCII encoded string
        ///         and updates the internal list with any gamepad mappings it finds.
        ///     </para>
        ///     <para>
        ///         This string may contain either a single gamepad mapping or many mappings separated by newlines.
        ///     </para>
        ///     <para>
        ///         The parser supports the full format of the gamecontrollerdb.txt source file
        ///         including empty lines and comments.
        ///     </para>
        ///     <para>
        ///         See <a href="https://www.glfw.org/docs/3.3/input_guide.html#gamepad_mapping">Gamepad mappings</a>
        ///         for a description of the format.
        ///     </para>
        ///     <para>
        ///         If there is already a gamepad mapping for a given GUID in the internal list, it will be replaced by the one passed to this function. If the library is terminated and re-initialized the internal list will revert to the built-in default.
        ///     </para>
        /// </summary>
        /// <param name="newMapping">The string containing the gamepad mappings.</param>
        /// <returns><c>true</c> if successful, or <c>false</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool UpdateGamepadMappingsRaw(byte* newMapping) => glfwUpdateGamepadMappings(newMapping) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the human-readable name of the gamepad
        ///         from the gamepad mapping assigned to the specified joystick.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present or does not have a gamepad mapping
        ///         this function will return <c>null</c> but will not generate an error.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded name of the gamepad, or <c>null</c> if the joystick is not present,
        ///     does not have a mapping or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         Call <see cref="JoystickPresent" /> to check whether it is present regardless of whether it has a mapping.
        ///     </para>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected,
        ///         the gamepad mappings are updated or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static unsafe string GetGamepadName(int jid) => PtrToStringUTF8(glfwGetGamepadName(jid));

        /// <summary>
        ///     <para>
        ///         This function returns the human-readable name of the gamepad
        ///         from the gamepad mapping assigned to the specified joystick.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present or does not have a gamepad mapping
        ///         this function will return <c>null</c> but will not generate an error.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <returns>
        ///     The UTF-8 encoded name of the gamepad, or <c>null</c> if the joystick is not present,
        ///     does not have a mapping or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         Call <see cref="JoystickPresent" /> to check whether it is present regardless of whether it has a mapping.
        ///     </para>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         It is valid until the specified joystick is disconnected,
        ///         the gamepad mappings are updated or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static unsafe byte* GetGamepadNameRaw(int jid) => glfwGetGamepadName(jid);

        /// <summary>
        ///     <para>
        ///         This function retrieves the state of the specified joystick remapped to an Xbox-like gamepad.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present or does not have a gamepad mapping
        ///         this function will return <c>false</c> but will not generate an error.
        ///         Call <see cref="JoystickPresent" /> to check whether it is present regardless of whether it has a mapping.
        ///     </para>
        ///     <para>
        ///         The Guide button may not be available for input as it is often hooked by the system or the Steam client.
        ///     </para>
        ///     <para>
        ///         Not all devices have all the buttons or axes provided by <see cref="GamepadState" />.
        ///         Unavailable buttons and axes will always report <see cref="InputAction.Release" /> and 0.0 respectively.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="state">The gamepad input state of the joystick.</param>
        /// <returns>
        ///     <c>true</c> if successful, or <c>false</c> if no joystick is connected,
        ///     it has no gamepad mapping or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool GetGamepadState(int jid, out GamepadState state)
        {
            fixed (GamepadState* ptr = &state)
            {
                return glfwGetGamepadState(jid, ptr) == GLFW_TRUE;
            }
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the state of the specified joystick remapped to an Xbox-like gamepad.
        ///     </para>
        ///     <para>
        ///         If the specified joystick is not present or does not have a gamepad mapping
        ///         this function will return <c>false</c> but will not generate an error.
        ///         Call <see cref="JoystickPresent" /> to check whether it is present regardless of whether it has a mapping.
        ///     </para>
        ///     <para>
        ///         The Guide button may not be available for input as it is often hooked by the system or the Steam client.
        ///     </para>
        ///     <para>
        ///         Not all devices have all the buttons or axes provided by <see cref="GamepadState" />.
        ///         Unavailable buttons and axes will always report <see cref="InputAction.Release" /> and 0.0 respectively.
        ///     </para>
        /// </summary>
        /// <param name="jid">The joystick to query.</param>
        /// <param name="state">The gamepad input state of the joystick.</param>
        /// <returns>
        ///     <c>true</c> if successful, or <c>false</c> if no joystick is connected,
        ///     it has no gamepad mapping or an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool GetGamepadStateRaw(int jid, GamepadState* state) => glfwGetGamepadState(jid, state) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the value of the GLFW timer.
        ///     </para>
        ///     <para>
        ///         Unless the timer has been set using <see cref="SetTime" />,
        ///         the timer measures time elapsed since GLFW was initialized.
        ///     </para>
        ///     <para>
        ///         The resolution of the timer is system dependent, but is usually on the order of a few micro- or nanoseconds.
        ///         It uses the highest-resolution monotonic time source on each supported platform.
        ///     </para>
        /// </summary>
        /// <returns>The current value, in seconds, or zero if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Reading and writing of the internal timer offset is not atomic,
        ///         so it needs to be externally synchronized with calls to <see cref="SetTime" />.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static double GetTime() => glfwGetTime();

        /// <summary>
        ///     <para>
        ///         This function sets the value of the GLFW timer. It then continues to count up from that value.
        ///         The value must be a positive finite number less than or equal to 18446744073.0,
        ///         which is approximately 584.5 years.
        ///     </para>
        /// </summary>
        /// <param name="time">The new value, in seconds.</param>
        /// <remarks>
        ///     <para>
        ///         The upper limit of the timer is calculated as floor((2^64 - 1) / 109) and is due to implementations
        ///         storing nanoseconds in 64 bits. The limit may be increased in the future.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///         Reading and writing of the internal timer offset is not atomic,
        ///         so it needs to be externally synchronized with calls to <see cref="GetTime" />.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        /// </remarks>
        public static void SetTime(double time) => glfwSetTime(time);

        /// <summary>
        ///     <para>
        ///         This function returns the current value of the raw timer, measured in 1 / frequency seconds.
        ///         To get the frequency, call <see cref="GetTimerFrequency" />.
        ///     </para>
        /// </summary>
        /// <returns>The value of the timer, or zero if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static long GetTimerValue() => glfwGetTimerValue();

        /// <summary>
        ///     <para>
        ///         This function returns the frequency, in Hz, of the raw timer.
        ///     </para>
        /// </summary>
        /// <returns>he frequency of the timer, in Hz, or zero if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static long GetTimerFrequency() => glfwGetTimerFrequency();

        /// <summary>
        ///     <para>
        ///         This function returns the window whose OpenGL or OpenGL ES context is current on the calling thread.
        ///     </para>
        /// </summary>
        /// <returns>The window whose context is current, or <c>null</c> if no window's context is current.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe Window* GetCurrentContext() => glfwGetCurrentContext();

        /// <summary>
        ///     <para>
        ///         This function swaps the front and back buffers of the specified window
        ///         when rendering with OpenGL or OpenGL ES.
        ///     </para>
        ///     <para>
        ///         If the swap interval is greater than zero,
        ///         the GPU driver waits the specified number of screen updates before swapping the buffers.
        ///     </para>
        ///     <para>
        ///         The specified window must have an OpenGL or OpenGL ES context.
        ///         Specifying a window without a context will generate a <see cref="ErrorCode.NoWindowContext" /> error.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose buffers to swap.</param>
        /// <remarks>
        ///     <para>
        ///         EGL: The context of the specified window must be current on the calling thread.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoWindowContext" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SwapBuffers(Window* window) => glfwSwapBuffers(window);

        /// <summary>
        ///     <para>
        ///         This function returns whether the specified API extension is supported
        ///         by the current OpenGL or OpenGL ES context.
        ///         It searches both for client API extension and context creation API extensions.
        ///     </para>
        ///     <para>
        ///         A context must be current on the calling thread.
        ///         Calling this function without a current context will cause a <see cref="ErrorCode.NoWindowContext" /> error.
        ///     </para>
        ///     <para>
        ///         As this functions retrieves and searches one or more extension strings each call,
        ///         it is recommended that you cache its results if it is going to be used frequently.
        ///         The extension strings will not change during the lifetime of a context, so there is no danger in doing this.
        ///     </para>
        /// </summary>
        /// <param name="extensionName">The ASCII encoded name of the extension.</param>
        /// <returns><c>true</c> if the extension is available, or <c>false</c> otherwise.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool ExtensionSupported(string extensionName)
        {
            var ptr = StringToCoTaskMemUTF8(extensionName);

            try
            {
                return glfwExtensionSupported((byte*)ptr) == GLFW_TRUE;
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     This function returns the address of the specified OpenGL or OpenGL ES core or extension function, if it is supported by the current context.
        ///     A context must be current on the calling thread. Calling this function without a current context will cause a <see cref="ErrorCode.NoContext" /> error.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function does not apply to Vulkan. If you are rendering with Vulkan, see <see cref="GetInstanceProcAddress" />, <c>vkGetInstanceProcAddr</c> and <c>vkGetDeviceProcAddr</c> instead.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        ///     <para>
        ///         The address of a given function is not guaranteed to be the same between contexts.
        ///         This function may return a non-<c>null</c> address despite the associated version or extension not being available. Always check the context version or extension string first.
        ///     </para>
        ///     <para>
        ///         The returned function pointer is valid until the context is destroyed or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <param name="procName">The name of the function.</param>
        /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
        /// <seealso cref="ExtensionSupported" />
        public static IntPtr GetProcAddress(string procName) => glfwGetProcAddress(procName);

        /// <summary>
        ///     This function returns the address of the specified OpenGL or OpenGL ES core or extension function, if it is supported by the current context.
        ///     A context must be current on the calling thread. Calling this function without a current context will cause a <see cref="ErrorCode.NoContext" /> error.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function does not apply to Vulkan. If you are rendering with Vulkan, see <see cref="GetInstanceProcAddress" />, <c>vkGetInstanceProcAddr</c> and <c>vkGetDeviceProcAddr</c> instead.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        ///     <para>
        ///         The address of a given function is not guaranteed to be the same between contexts.
        ///         This function may return a non-<c>null</c> address despite the associated version or extension not being available. Always check the context version or extension string first.
        ///     </para>
        ///     <para>
        ///         The returned function pointer is valid until the context is destroyed or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <param name="procName">The ASCII-encoded name of the function.</param>
        /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
        /// <seealso cref="ExtensionSupported" />
        public static unsafe IntPtr GetProcAddressRaw(byte* procName) => glfwGetProcAddress(procName);

        /// <summary>
        ///     <para>
        ///         This function returns whether the specified API extension is supported
        ///         by the current OpenGL or OpenGL ES context.
        ///         It searches both for client API extension and context creation API extensions.
        ///     </para>
        ///     <para>
        ///         A context must be current on the calling thread.
        ///         Calling this function without a current context will cause a <see cref="ErrorCode.NoWindowContext" /> error.
        ///     </para>
        ///     <para>
        ///         As this functions retrieves and searches one or more extension strings each call,
        ///         it is recommended that you cache its results if it is going to be used frequently.
        ///         The extension strings will not change during the lifetime of a context, so there is no danger in doing this.
        ///     </para>
        /// </summary>
        /// <param name="extensionName">The ASCII encoded name of the extension.</param>
        /// <returns><c>true</c> if the extension is available, or <c>false</c> otherwise.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" />, <see cref="ErrorCode.InvalidValue" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool ExtensionSupportedRaw(byte* extensionName) => glfwExtensionSupported(extensionName) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function creates a window and its associated OpenGL or OpenGL ES context.
        ///         Most of the options controlling how the window and its context should be created
        ///         are specified with window hints.
        ///     </para>
        ///     <para>
        ///         Successful creation does not change which context is current.
        ///         Before you can use the newly created context, you need to make it current.
        ///         For information about the share parameter, see
        ///         <a href="">Context object sharing</a>.
        ///     </para>
        ///     <para>
        ///         The created window, framebuffer and context may differ from what you requested,
        ///         as not all parameters and hints are
        ///         <a href="https://www.glfw.org/docs/latest/window_guide.html#window_hints_hard">hard constraints</a>.
        ///         This includes the size of the window, especially for full screen windows.
        ///         To query the actual attributes of the created window, framebuffer and context,
        ///         see <see cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />, <see cref="GetWindowSize" /> and <see cref="GetFramebufferSize" />.
        ///     </para>
        ///     <para>
        ///         To create a full screen window, you need to specify the monitor the window will cover.
        ///         If no monitor is specified, the window will be windowed mode.
        ///         Unless you have a way for the user to choose a specific monitor,
        ///         it is recommended that you pick the primary monitor.
        ///         For more information on how to query connected monitors, see
        ///         <a href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_monitors">Retrieving monitors</a>.
        ///     </para>
        ///     <para>
        ///         For full screen windows, the specified size becomes the resolution of the window's desired video mode.
        ///         As long as a full screen window is not iconified,
        ///         the supported video mode most closely matching the desired video mode is set for the specified monitor.
        ///         For more information about full screen windows, including the creation of so called windowed full screen
        ///         or borderless full screen windows, see
        ///         <a href="https://www.glfw.org/docs/latest/window_guide.html#window_windowed_full_screen">
        ///             "Windowed full screen" windows
        ///         </a>
        ///         .
        ///     </para>
        ///     <para>
        ///         Once you have created the window, you can switch it between windowed and full screen mode
        ///         with <see cref="SetWindowMonitor" />. If the window has an OpenGL or OpenGL ES context, it will be unaffected.
        ///     </para>
        ///     <para>
        ///         By default, newly created windows use the placement recommended by the window system.
        ///         To create the window at a specific position,
        ///         make it initially invisible using the <see cref="WindowHintBool.Visible" /> window hint,
        ///         set its position(see <see cref="SetWindowPos" />) and then show it
        ///         (see <see cref="ShowWindow" />).
        ///     </para>
        ///     <para>
        ///         As long as at least one full screen window is not iconified, the screensaver is prohibited from starting.
        ///     </para>
        ///     <para>
        ///         Window systems put limits on window sizes.
        ///         Very large or very small window dimensions may be overridden by the window system on creation.
        ///         Check the actual size after creation(see <see cref="GetWindowSize" /> or <see cref="SetWindowSizeCallback" />.
        ///     </para>
        ///     <para>
        ///         The <a href="https://www.glfw.org/docs/latest/window_guide.html#buffer_swap">swap interval</a>
        ///         is not set during window creation and the initial value may vary
        ///         depending on driver settings and defaults.
        ///     </para>
        /// </summary>
        /// <param name="width">
        ///     The desired width, in screen coordinates, of the window. This must be greater than zero.
        /// </param>
        /// <param name="height">
        ///     The desired height, in screen coordinates, of the window. This must be greater than zero.
        /// </param>
        /// <param name="title">The initial, UTF-8 encoded window title.</param>
        /// <param name="monitor">The monitor to use for full screen mode, or <c>null</c> for windowed mode.</param>
        /// <param name="share">
        ///     The window whose context to share resources with, or <c>null</c> to not share resources.
        /// </param>
        /// <returns>The handle of the created window, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         Windows: Window creation will fail if the Microsoft GDI software OpenGL implementation is the only one available.
        ///     </para>
        ///     <para>
        ///         Windows: If the executable has an icon resource named GLFW_ICON, it will be set as the initial icon for the window.
        ///         If no such icon is present, the IDI_WINLOGO icon will be used instead. To set a different icon, see <see cref="SetWindowIcon" />.
        ///     </para>
        ///     <para>
        ///         Windows: The context to share resources with must not be current on any other thread.
        ///     </para>
        ///     <para>
        ///         OS X: The GLFW window has no icon, as it is not a document window, but the dock icon will be the same as the application bundle's icon.
        ///         For more information on bundles, see the Bundle Programming Guide in the Mac Developer Library.
        ///     </para>
        ///     <para>
        ///         OS X: The first time a window is created the menu bar is populated with common commands like Hide, Quit and About.
        ///         The About entry opens a minimal about dialog with information from the application's bundle.
        ///         The menu bar can be disabled with a compile-time option.
        ///     </para>
        ///     <para>
        ///         OS X: On OS X 10.10 and later the window frame will not be rendered at full resolution on Retina displays
        ///         unless the NSHighResolutionCapable key is enabled in the application bundle's Info.plist.
        ///         For more information, see High Resolution Guidelines for OS X in the Mac Developer Library.
        ///         The GLFW test and example programs use a custom Info.plist template for this, which can be found as CMake/MacOSXBundleInfo.plist.in in the source tree.
        ///     </para>
        ///     <para>
        ///         X11: Some window managers will not respect the placement of initially hidden windows.
        ///         X11: Due to the asynchronous nature of X11, it may take a moment for a window to reach its requested state.
        ///         This means you may not be able to query the final size, position or other attributes directly after window creation.
        ///     </para>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" />, <see cref="ErrorCode.InvalidValue" />, <see cref="ErrorCode.ApiUnavailable" />,
        ///         <see cref="ErrorCode.VersionUnavailable" />, <see cref="ErrorCode.FormatUnavailable" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share)
        {
            var ptr = StringToCoTaskMemUTF8(title);

            try
            {
                return glfwCreateWindow(width, height, (byte*)ptr, monitor, share);
            }
            finally
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(ptr);
                }
            }
        }

        /// <summary>
        ///     <para>
        ///         This function creates a window and its associated OpenGL or OpenGL ES context.
        ///         Most of the options controlling how the window and its context should be created
        ///         are specified with window hints.
        ///     </para>
        ///     <para>
        ///         Successful creation does not change which context is current.
        ///         Before you can use the newly created context, you need to make it current.
        ///         For information about the share parameter, see
        ///         <a href="">Context object sharing</a>.
        ///     </para>
        ///     <para>
        ///         The created window, framebuffer and context may differ from what you requested,
        ///         as not all parameters and hints are
        ///         <a href="https://www.glfw.org/docs/latest/window_guide.html#window_hints_hard">hard constraints</a>.
        ///         This includes the size of the window, especially for full screen windows.
        ///         To query the actual attributes of the created window, framebuffer and context,
        ///         see <see cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />, <see cref="GetWindowSize" /> and <see cref="GetFramebufferSize" />.
        ///     </para>
        ///     <para>
        ///         To create a full screen window, you need to specify the monitor the window will cover.
        ///         If no monitor is specified, the window will be windowed mode.
        ///         Unless you have a way for the user to choose a specific monitor,
        ///         it is recommended that you pick the primary monitor.
        ///         For more information on how to query connected monitors, see
        ///         <a href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_monitors">Retrieving monitors</a>.
        ///     </para>
        ///     <para>
        ///         For full screen windows, the specified size becomes the resolution of the window's desired video mode.
        ///         As long as a full screen window is not iconified,
        ///         the supported video mode most closely matching the desired video mode is set for the specified monitor.
        ///         For more information about full screen windows, including the creation of so called windowed full screen
        ///         or borderless full screen windows, see
        ///         <a href="https://www.glfw.org/docs/latest/window_guide.html#window_windowed_full_screen">
        ///             "Windowed full screen" windows
        ///         </a>
        ///         .
        ///     </para>
        ///     <para>
        ///         Once you have created the window, you can switch it between windowed and full screen mode
        ///         with <see cref="SetWindowMonitor" />. If the window has an OpenGL or OpenGL ES context, it will be unaffected.
        ///     </para>
        ///     <para>
        ///         By default, newly created windows use the placement recommended by the window system.
        ///         To create the window at a specific position,
        ///         make it initially invisible using the <see cref="WindowHintBool.Visible" /> window hint,
        ///         set its position(see <see cref="SetWindowPos" />) and then show it
        ///         (see <see cref="ShowWindow" />).
        ///     </para>
        ///     <para>
        ///         As long as at least one full screen window is not iconified, the screensaver is prohibited from starting.
        ///     </para>
        ///     <para>
        ///         Window systems put limits on window sizes.
        ///         Very large or very small window dimensions may be overridden by the window system on creation.
        ///         Check the actual size after creation(see <see cref="GetWindowSize" /> or <see cref="SetWindowSizeCallback" />.
        ///     </para>
        ///     <para>
        ///         The <a href="https://www.glfw.org/docs/latest/window_guide.html#buffer_swap">swap interval</a>
        ///         is not set during window creation and the initial value may vary
        ///         depending on driver settings and defaults.
        ///     </para>
        /// </summary>
        /// <param name="width">
        ///     The desired width, in screen coordinates, of the window. This must be greater than zero.
        /// </param>
        /// <param name="height">
        ///     The desired height, in screen coordinates, of the window. This must be greater than zero.
        /// </param>
        /// <param name="title">The initial, UTF-8 encoded window title.</param>
        /// <param name="monitor">The monitor to use for full screen mode, or <c>null</c> for windowed mode.</param>
        /// <param name="share">
        ///     The window whose context to share resources with, or <c>null</c> to not share resources.
        /// </param>
        /// <returns>The handle of the created window, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         Windows: Window creation will fail if the Microsoft GDI software OpenGL implementation is the only one available.
        ///     </para>
        ///     <para>
        ///         Windows: If the executable has an icon resource named GLFW_ICON, it will be set as the initial icon for the window.
        ///         If no such icon is present, the IDI_WINLOGO icon will be used instead. To set a different icon, see <see cref="SetWindowIcon" />.
        ///     </para>
        ///     <para>
        ///         Windows: The context to share resources with must not be current on any other thread.
        ///     </para>
        ///     <para>
        ///         OS X: The GLFW window has no icon, as it is not a document window, but the dock icon will be the same as the application bundle's icon.
        ///         For more information on bundles, see the Bundle Programming Guide in the Mac Developer Library.
        ///     </para>
        ///     <para>
        ///         OS X: The first time a window is created the menu bar is populated with common commands like Hide, Quit and About.
        ///         The About entry opens a minimal about dialog with information from the application's bundle.
        ///         The menu bar can be disabled with a compile-time option.
        ///     </para>
        ///     <para>
        ///         OS X: On OS X 10.10 and later the window frame will not be rendered at full resolution on Retina displays
        ///         unless the NSHighResolutionCapable key is enabled in the application bundle's Info.plist.
        ///         For more information, see High Resolution Guidelines for OS X in the Mac Developer Library.
        ///         The GLFW test and example programs use a custom Info.plist template for this, which can be found as CMake/MacOSXBundleInfo.plist.in in the source tree.
        ///     </para>
        ///     <para>
        ///         X11: Some window managers will not respect the placement of initially hidden windows.
        ///         X11: Due to the asynchronous nature of X11, it may take a moment for a window to reach its requested state.
        ///         This means you may not be able to query the final size, position or other attributes directly after window creation.
        ///     </para>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" />, <see cref="ErrorCode.InvalidValue" />, <see cref="ErrorCode.ApiUnavailable" />,
        ///         <see cref="ErrorCode.VersionUnavailable" />, <see cref="ErrorCode.FormatUnavailable" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe Window* CreateWindowRaw(
            int width,
            int height,
            byte* title,
            Monitor* monitor,
            Window* share) =>
            glfwCreateWindow(width, height, title, monitor, share);

        /// <summary>
        ///     <para>
        ///         This function destroys the specified window and its context. On calling this function,
        ///         no further callbacks will be called for that window.
        ///     </para>
        ///     <para>
        ///         If the context of the specified window is current on the main thread, it is detached before being destroyed.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to destroy.</param>
        /// <remarks>
        ///     <para>
        ///         The context of the specified window must not be current on any other thread when this function is called.
        ///     </para>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="CreateWindow" />
        public static unsafe void DestroyWindow(Window* window) => glfwDestroyWindow(window);

        /// <summary>
        ///     <para>
        ///         This function brings the specified window to front and sets input focus.
        ///         The window should already be visible and not iconified.
        ///     </para>
        ///     <para>
        ///         By default, both windowed and full screen mode windows are focused when initially created.
        ///         Set the <see cref="WindowHintBool.Focused" /> to disable this behavior.
        ///     </para>
        ///     <para>
        ///         Do not use this function to steal focus from other applications unless you are certain
        ///         that is what the user wants.
        ///         Focus stealing can be extremely disruptive.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to give input focus.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void FocusWindow(Window* window) => glfwFocusWindow(window);

        /// <summary>
        ///     <para>
        ///         This function returns the contents of the system clipboard,
        ///         if it contains or is convertible to a UTF-8 encoded string.
        ///     </para>
        /// </summary>
        /// <param name="window">The window that will request the clipboard contents.</param>
        /// <returns>
        ///     The contents of the clipboard as a UTF-8 encoded string, or <c>null</c> if an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function may only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         The returned string is valid only until the next call to <see cref="GetClipboardString" /> or
        ///         <see cref="SetClipboardString" />.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetClipboardString" />
        public static unsafe string GetClipboardString(Window* window) => PtrToStringUTF8(glfwGetClipboardString(window));

        /// <summary>
        ///     <para>
        ///         This function returns the contents of the system clipboard,
        ///         if it contains or is convertible to a UTF-8 encoded string.
        ///     </para>
        /// </summary>
        /// <param name="window">The window that will request the clipboard contents.</param>
        /// <returns>
        ///     The contents of the clipboard as a UTF-8 encoded string, or <c>null</c> if an error occurred.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function may only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         The returned string is allocated and freed by GLFW. You should not free it yourself.
        ///         The returned string is valid only until the next call to <see cref="GetClipboardString" /> or
        ///         <see cref="SetClipboardString" />.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetClipboardString" />
        public static unsafe byte* GetClipboardStringRaw(Window* window) => glfwGetClipboardString(window);

        /// <summary>
        ///     <para>
        ///         This function retrieves the size, in pixels, of the framebuffer of the specified window.
        ///         If you wish to retrieve the size of the window in screen coordinates, see <see cref="GetWindowSize" />.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose framebuffer to query.</param>
        /// <param name="width">Where to store the width, in pixels, of the framebuffer.</param>
        /// <param name="height">Where to store the height, in pixels, of the framebuffer.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetFramebufferSize(Window* window, out int width, out int height)
        {
            int w, h;
            glfwGetFramebufferSize(window, &w, &h);
            width = w;
            height = h;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the size, in pixels, of the framebuffer of the specified window.
        ///         If you wish to retrieve the size of the window in screen coordinates, see <see cref="GetWindowSize" />.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose framebuffer to query.</param>
        /// <param name="width">Where to store the width, in pixels, of the framebuffer.</param>
        /// <param name="height">Where to store the height, in pixels, of the framebuffer.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void GetFramebufferSizeRaw(Window* window, int* width, int* height)
        {
            glfwGetFramebufferSize(window, width, height);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the value of an input option for the specified window.
        ///         The mode must be <see cref="StickyAttributes.StickyKeys" /> or <see cref="StickyAttributes.StickyMouseButtons" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="mode">
        ///     Either <see cref="StickyAttributes.StickyKeys" /> or <see cref="StickyAttributes.StickyMouseButtons" />.
        /// </param>
        /// <returns>TODO: return value is either InputModeValue or bool dependant on <paramref name="mode" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetInputMode(Window*, StickyAttributes, bool)" />
        public static unsafe bool GetInputMode(Window* window, StickyAttributes mode) => glfwGetInputMode(window, mode) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the value of an input option for the specified window.
        ///         The mode must be <see cref="CursorStateAttribute.Cursor" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="mode">
        ///     <see cref="CursorStateAttribute.Cursor" />.
        /// </param>
        /// <returns>TODO: return value is either InputModeValue or bool dependant on <paramref name="mode" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetInputMode(Window*,CursorStateAttribute, CursorModeValue)" />
        public static unsafe CursorModeValue GetInputMode(Window* window, CursorStateAttribute mode) => glfwGetInputMode(window, mode);

        /// <summary>
        ///     <para>
        ///         This function returns the value of an input option for the specified window.
        ///         The mode must be <see cref="LockKeyModAttribute.LockKeyMods" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="mode">
        ///     <see cref="LockKeyModAttribute.LockKeyMods" />.
        /// </param>
        /// <returns>TODO: return value is either InputModeValue or bool dependant on <paramref name="mode" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetInputMode(Window*, LockKeyModAttribute, bool)" />
        public static unsafe bool GetInputMode(Window* window, LockKeyModAttribute mode) => glfwGetInputMode(window, mode) == GLFW_TRUE;

        /// <summary>
        ///     <para>
        ///         This function returns the primary monitor.
        ///     </para>
        ///     <para>
        ///         This is usually the monitor where elements like the task bar or global menu bar are located.
        ///     </para>
        /// </summary>
        /// <returns>The primary monitor, or <c>null</c> if no monitors were found or if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         The primary monitor is always first in the array returned by <see cref="GetMonitors" />.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe Monitor* GetPrimaryMonitor() => glfwGetPrimaryMonitor();

        /// <summary>
        ///     <para>
        ///         This function returns the current video mode of the specified monitor.
        ///     </para>
        ///     <para>
        ///         If you have created a full screen window for that monitor,
        ///         the return value will depend on whether that window is iconified.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The monitor to query. </param>
        /// <returns>The current mode of the monitor, or <c>null</c> if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW
        ///         You should not free it yourself.
        ///         It is valid until the specified monitor is disconnected or the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetVideoModes" />
        public static unsafe VideoMode* GetVideoMode(Monitor* monitor) => glfwGetVideoMode(monitor);

        /// <summary>
        ///     <para>
        ///         This function returns the value of an attribute of the specified window or its OpenGL or OpenGL ES context.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="attribute">The window attribute whose value to return.</param>
        /// <returns>The value of the attribute, or zero if an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         Framebuffer-related hints are not window attributes. See
        ///         <a href="https://www.glfw.org/docs/3.3/window_guide.html#window_hints_fb">
        ///             Framebuffer related attributes
        ///         </a>
        ///         for more information.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool GetWindowAttrib(Window* window, WindowAttributeGetBool attribute) => glfwGetWindowAttrib(window, attribute) == GLFW_TRUE;

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe int GetWindowAttrib(Window* window, WindowAttributeGetInt attribute) => glfwGetWindowAttrib(window, attribute);

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe ClientApi GetWindowAttrib(Window* window, WindowAttributeGetClientApi attribute) => glfwGetWindowAttrib(window, attribute);

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe ContextApi GetWindowAttrib(Window* window, WindowAttributeGetContextApi attribute) => glfwGetWindowAttrib(window, attribute);

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe OpenGlProfile GetWindowAttrib(Window* window, WindowAttributeGetOpenGlProfile attribute) => glfwGetWindowAttrib(window, attribute);

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe ReleaseBehavior GetWindowAttrib(Window* window, WindowAttributeGetReleaseBehavior attribute) => glfwGetWindowAttrib(window, attribute);

        /// <inheritdoc cref="GetWindowAttrib(Window*, WindowAttributeGetBool)" />
        public static unsafe Robustness GetWindowAttrib(Window* window, WindowAttributeGetRobustness attribute) => glfwGetWindowAttrib(window, attribute);

        /// <summary>
        ///     <para>
        ///         This function sets the user-defined pointer of the specified window.
        ///     </para>
        ///     <para>
        ///         The current value is retained until the window is destroyed.
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose pointer to set.</param>
        /// <param name="pointer">The new value.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowUserPointer(Window* window, void* pointer)
        {
            glfwSetWindowUserPointer(window, pointer);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the current value of the user-defined pointer of the specified window.
        ///     </para>
        ///     <para>
        ///         The initial value is <see cref="IntPtr.Zero" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose pointer to return.</param>
        /// <returns>The user-defined pointer of the given <paramref name="window" />.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void* GetWindowUserPointer(Window* window) => glfwGetWindowUserPointer(window);

        /// <summary>
        ///     <para>
        ///         This function retrieves the size, in screen coordinates, of the client area of the specified window.
        ///         If you wish to retrieve the size of the framebuffer of the window in pixels, see <see cref="GetFramebufferSize" />.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose size to retrieve.</param>
        /// <param name="width">Where to store the width, in screen coordinates, of the client area.</param>
        /// <param name="height">Where to store the height, in screen coordinates, of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowSize" />
        public static unsafe void GetWindowSize(Window* window, out int width, out int height)
        {
            int w, h;
            glfwGetWindowSize(window, &w, &h);
            width = w;
            height = h;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the size, in screen coordinates, of the client area of the specified window.
        ///         If you wish to retrieve the size of the framebuffer of the window in pixels, see <see cref="GetFramebufferSize" />.
        ///     </para>
        ///     <para>
        ///         Any or all of the size arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> size arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose size to retrieve.</param>
        /// <param name="width">Where to store the width, in screen coordinates, of the client area.</param>
        /// <param name="height">Where to store the height, in screen coordinates, of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowSize" />
        public static unsafe void GetWindowSizeRaw(Window* window, int* width, int* height)
        {
            glfwGetWindowSize(window, width, height);
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the position, in screen coordinates,
        ///         of the upper-left corner of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         Any or all of the position arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> position arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="x">Where to store the x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">Where to store the y-coordinate of the upper-left corner of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowPos" />
        public static unsafe void GetWindowPos(Window* window, out int x, out int y)
        {
            int lX, lY;
            glfwGetWindowPos(window, &lX, &lY);
            x = lX;
            y = lY;
        }

        /// <summary>
        ///     <para>
        ///         This function retrieves the position, in screen coordinates,
        ///         of the upper-left corner of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         Any or all of the position arguments may be <c>out _</c>.
        ///         If an error occurs, all non-<c>out _</c> position arguments will be set to zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="x">Where to store the x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">Where to store the y-coordinate of the upper-left corner of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowPos" />
        public static unsafe void GetWindowPosRaw(Window* window, int* x, int* y)
        {
            glfwGetWindowPos(window, x, y);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the handle of the monitor that the specified window is in full screen on.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The monitor, or <c>null</c> if the window is in windowed mode or an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SetWindowMonitor" />
        public static unsafe Monitor* GetWindowMonitor(Window* window) => glfwGetWindowMonitor(window);

        /// <summary>
        ///     <para>
        ///         This function hides the specified window if it was previously visible.
        ///         If the window is already hidden or is in full screen mode, this function does nothing.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to hide.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void HideWindow(Window* window) => glfwHideWindow(window);

        /// <summary>
        ///     <para>
        ///         This function iconifies (minimizes) the specified window if it was previously restored.
        ///         If the window is already iconified, this function does nothing.
        ///     </para>
        ///     <para>
        ///         If the specified window is a full screen window,
        ///         the original monitor resolution is restored until the window is restored.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to iconify.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void IconifyWindow(Window* window) => glfwIconifyWindow(window);

        /// <summary>
        ///     <para>
        ///         This function makes the OpenGL or OpenGL ES context of the specified window current on the calling thread.
        ///     </para>
        ///     <para>
        ///         A context can only be made current on a single thread at a time
        ///         and each thread can have only a single current context at a time.
        ///     </para>
        ///     <para>
        ///         By default, making a context non-current implicitly forces a pipeline flush.
        ///     </para>
        ///     <para>
        ///         On machines that support <c>GL_KHR_context_flush_control</c>,
        ///         you can control whether a context performs this flush
        ///         by setting the <see cref="WindowHintReleaseBehavior.ContextReleaseBehavior" /> window hint.
        ///     </para>
        ///     <para>
        ///         The specified window must have an OpenGL or OpenGL ES context.
        ///         Specifying a window without a context will generate a <see cref="ErrorCode.NoWindowContext" /> error.
        ///     </para>
        /// </summary>
        /// <param name="window">
        ///     The window whose context to make current, or <c>null</c> to detach the current context.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoWindowContext" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetCurrentContext" />
        public static unsafe void MakeContextCurrent(Window* window) => glfwMakeContextCurrent(window);

        /// <summary>
        ///     <para>
        ///         This function maximizes the specified window if it was previously not maximized.
        ///         If the window is already maximized, this function does nothing.
        ///     </para>
        ///     <para>
        ///         If the specified window is a full screen window, this function does nothing.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to maximize.</param>
        /// <remarks>
        ///     <para>
        ///         This function may only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void MaximizeWindow(Window* window) => glfwMaximizeWindow(window);

        /// <summary>
        ///     This function returns the Windows specific window handle (HWND).
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The Windows specific window handle (HWND).</returns>
        public static unsafe IntPtr GetWin32Window(Window* window) => glfwGetWin32Window(window);

        /// <summary>
        ///     This function returns the macos specific window handle (NSWindow).
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The macos specific window handle (NSWindow).</returns>
        public static unsafe IntPtr GetCocoaWindow(Window* window) => glfwGetCocoaWindow(window);

        /// <summary>
        ///     This function returns the x11 specific window handle (Window).
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The x11 specific window handle (Window).</returns>
        public static unsafe uint GetX11Window(Window* window) => glfwGetX11Window(window);

        /// <summary>
        ///     This function returns the glx specific window handle (Window).
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The glx specific window handle (Window).</returns>
        public static unsafe uint GetGLXWindow(Window* window) => glfwGetGLXWindow(window);

        /// <summary>
        ///     This function returns the wayland specific window handle (struct wl_surface*).
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The wayland specific window handle (struct wl_surface*).</returns>
        public static unsafe IntPtr GetWaylandWindow(Window* window) => glfwGetWaylandWindow(window);

        /// <summary>
        ///     <para>
        ///         This function sets the maximization callback of the specified window,
        ///         which is called when the window is maximized or restored.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function may only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="MaximizeWindow" />
        public static unsafe IntPtr SetWindowMaximizeCallback(
            Window* window,
            GLFWCallbacks.WindowMaximizeCallback callback) =>
            glfwSetWindowMaximizeCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the framebuffer resize callback of the specified window,
        ///         which is called when the framebuffer of the specified window is resized.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose content scale changed.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetFramebufferSize" />
        public static unsafe IntPtr SetFramebufferSizeCallback(
            Window* window,
            GLFWCallbacks.FramebufferSizeCallback callback) =>
            glfwSetFramebufferSizeCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the window content scale callback of the specified window,
        ///         which is called when the content scale of the specified window changes.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose content scale changed.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetWindowContentScale" />
        public static unsafe IntPtr SetWindowContentScaleCallback(
            Window* window,
            GLFWCallbacks.WindowContentScaleCallback callback) =>
            glfwSetWindowContentScaleCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function processes only those events that are already in the event queue and then returns immediately.
        ///         Processing events will cause the window and input callbacks associated with those events to be called.
        ///     </para>
        ///     <para>
        ///         On some platforms, a window move, resize or menu operation will cause event processing to block.
        ///         This is due to how event processing is designed on those platforms.
        ///         You can use the
        ///         <a href="https://www.glfw.org/docs/latest/window_guide.html#window_refresh">window refresh callback</a>
        ///         to redraw the contents of your window when necessary during such operations.
        ///     </para>
        ///     <para>
        ///         On some platforms, certain events are sent directly to the application without going through the event queue,
        ///         causing callbacks to be called outside of a call to one of the event processing functions.
        ///     </para>
        ///     <para>
        ///         Event processing is not required for joystick input to work.
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static void PollEvents() => glfwPollEvents();

        /// <summary>
        ///     <para>
        ///         This function posts an empty event from the current thread to the event queue,
        ///         causing <see cref="WaitEvents" /> or <see cref="WaitEventsTimeout" /> to return.
        ///     </para>
        ///     <para>
        ///         If no windows exist, this function returns immediately.
        ///         For synchronization of threads in applications that do not create windows, use your threading library of choice.
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static void PostEmptyEvent() => glfwPostEmptyEvent();

        /// <summary>
        ///     <para>
        ///         This function restores the specified window if it was previously iconified (minimized) or maximized.
        ///         If the window is already restored, this function does nothing.
        ///     </para>
        ///     <para>
        ///         If the specified window is a full screen window, the resolution chosen for the window is restored on the selected monitor.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to restore.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void RestoreWindow(Window* window) => glfwRestoreWindow(window);

        /// <summary>
        ///     <para>
        ///         This function sets the character callback of the specified window, which is called when a Unicode character is input.
        ///     </para>
        ///     <para>
        ///         The character callback is intended for Unicode text input. As it deals with characters,
        ///         it is keyboard layout dependent, whereas the key callback is not. Characters do not map 1:1 to physical keys
        ///         as a key may produce zero, one, or more characters.
        ///     </para>
        ///     <para>
        ///         If you want to know whether a specific physical key was pressed or released, see the key callback instead.
        ///     </para>
        ///     <para>
        ///         The character callback behaves as system text input normally does
        ///         and will not be called if modifier keys are held down that would prevent normal text input on that platform,
        ///         for example a Super (Command) key on OS X or Alt key on Windows.
        ///     </para>
        ///     <para>
        ///         There is a character with modifiers callback(<see cref="SetCharModsCallback" />) that receives these events.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetCharCallback(
            Window* window,
            GLFWCallbacks.CharCallback callback) =>
            glfwSetCharCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the character with modifiers callback of the specified window,
        ///         which is called when a Unicode character is input regardless of what modifier keys are used.
        ///     </para>
        ///     <para>
        ///         The character with modifiers callback is intended for implementing custom Unicode character input.
        ///         For regular Unicode text input, see the character callback.
        ///     </para>
        ///     <para>
        ///         Like the character callback(<see cref="SetCharCallback" />),
        ///         the character with modifiers callback deals with characters and is keyboard layout dependent.
        ///         Characters do not map 1:1 to physical keys, as a key may produce zero, one, or more characters.
        ///     </para>
        ///     <para>
        ///         If you want to know whether a specific physical key was pressed or released,
        ///         see the key callback(<see cref="SetKeyCallback" />) instead.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>The previously set callback, or <c>null</c> if no callback was set or an error occurred.</returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetCharModsCallback(
            Window* window,
            GLFWCallbacks.CharModsCallback callback) =>
            glfwSetCharModsCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the system clipboard to the specified, UTF-8 encoded string.
        ///     </para>
        /// </summary>
        /// <param name="window">The window that will own the clipboard contents. </param>
        /// <param name="data">A UTF-8 encoded string.</param>
        /// <remarks>
        ///     <para>
        ///         The specified string is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetClipboardString" />
        public static unsafe void SetClipboardString(Window* window, string data)
        {
            var ptr = StringToCoTaskMemUTF8(data);

            try
            {
                glfwSetClipboardString(window, (byte*)ptr);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function sets the system clipboard to the specified, UTF-8 encoded string.
        ///     </para>
        /// </summary>
        /// <param name="window">The window that will own the clipboard contents. </param>
        /// <param name="data">A UTF-8 encoded string.</param>
        /// <remarks>
        ///     <para>
        ///         The specified string is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetClipboardString" />
        public static unsafe void SetClipboardStringRaw(Window* window, byte* data)
        {
            glfwSetClipboardString(window, data);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the cursor boundary crossing callback of the specified window
        ///         which is called when the cursor enters or leaves the client area of the window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetCursorEnterCallback(
            Window* window,
            GLFWCallbacks.CursorEnterCallback callback) =>
            glfwSetCursorEnterCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the cursor position callback of the specified window,
        ///         which is called when the cursor is moved.
        ///     </para>
        ///     <para>
        ///         The callback is provided with the position, in screen coordinates,
        ///         relative to the upper-left corner of the client area of the window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetCursorPosCallback(
            Window* window,
            GLFWCallbacks.CursorPosCallback callback) =>
            glfwSetCursorPosCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the file drop callback of the specified window,
        ///         which is called when one or more dragged files are dropped on the window.
        ///     </para>
        ///     <para>
        ///         Because the path array and its strings may have been generated specifically for that event,
        ///         they are not guaranteed to be valid after the callback has returned.
        ///         If you wish to use them after the callback returns, you need to make a deep copy.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new file drop callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetDropCallback(
            Window* window,
            GLFWCallbacks.DropCallback callback) =>
            glfwSetDropCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the error callback, which is called with an error code
        ///         and a human-readable description each time a GLFW error occurs.
        ///     </para>
        ///     <para>
        ///         The error callback is called on the thread where the error occurred.
        ///         If you are using GLFW from multiple threads, your error callback needs to be written accordingly.
        ///     </para>
        ///     <para>
        ///         Because the description string may have been generated specifically for that error,
        ///         it is not guaranteed to be valid after the callback has returned.
        ///         If you wish to use it after the callback returns, you need to make a deep copy.
        ///     </para>
        ///     <para>
        ///         Once set, the error callback remains set even after the library has been terminated.
        ///     </para>
        /// </summary>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>The previously set callback, or <c>null</c> if no callback was set.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called before <see cref="Init" />.
        ///     </para>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        /// </remarks>
        public static IntPtr SetErrorCallback(GLFWCallbacks.ErrorCallback callback) => glfwSetErrorCallback(callback);

        /// <summary>
        ///     <para>
        ///         This function sets an input mode option for the specified window.
        ///         The mode must be <see cref="CursorStateAttribute.Cursor" />.
        ///     </para>
        ///     <para>
        ///         If the mode is <see cref="CursorStateAttribute.Cursor" />, the value must be one of the following cursor modes:
        ///         - <see cref="CursorModeValue.CursorNormal" /> makes the cursor visible and behaving normally.
        ///         - <see cref="CursorModeValue.CursorHidden" /> makes the cursor invisible when it is over the client area of
        ///         the window but does not restrict the cursor from leaving.
        ///         - <see cref="CursorModeValue.CursorDisabled" /> hides and grabs the cursor, providing virtual
        ///         and unlimited cursor movement. This is useful for implementing for example 3D camera controls.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose input mode to set.</param>
        /// <param name="mode"><see cref="CursorStateAttribute.Cursor" />.</param>
        /// <param name="value">The new value of the specified input mode.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetInputMode(Window* window, CursorStateAttribute mode, CursorModeValue value)
        {
            glfwSetInputMode(window, mode, value);
        }

        /// <summary>
        ///     <para>
        ///         This function sets an input mode option for the specified window.
        ///         The mode must be <see cref="StickyAttributes.StickyKeys" />
        ///         or <see cref="StickyAttributes.StickyMouseButtons" />.
        ///     </para>
        ///     <para>
        ///         If the mode is <see cref="StickyAttributes.StickyKeys" />, the value must be either <c>true</c>
        ///         to enable sticky keys, or <c>false</c> to disable it.
        ///     </para>
        ///     <para>
        ///         If sticky keys are enabled, a key press will ensure that
        ///         <see cref="GetKey" /> returns <see cref="InputAction.Press" /> the next time it is called even if the key had been released before the call.
        ///         This is useful when you are only interested in whether keys have been pressed but not when or in which order.
        ///     </para>
        ///     <para>
        ///         If the mode is <see cref="StickyAttributes.StickyMouseButtons" />, the value must be either <c>true</c>
        ///         to enable sticky mouse buttons, or <c>false</c> to disable it.
        ///         If sticky mouse buttons are enabled, a mouse button press will ensure that
        ///         <see cref="GetMouseButton" /> returns <see cref="InputAction.Press" /> the next time it is called even if the mouse button had been released before the call.
        ///         This is useful when you are only interested in whether mouse buttons have been pressed but not when or in which order.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose input mode to set.</param>
        /// <param name="mode">
        ///     Either <see cref="StickyAttributes.StickyKeys" /> or <see cref="StickyAttributes.StickyMouseButtons" />.
        /// </param>
        /// <param name="value">The new value of the specified input mode.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetInputMode(Window* window, StickyAttributes mode, bool value)
        {
            glfwSetInputMode(window, mode, value ? GLFW_TRUE : GLFW_FALSE);
        }

        /// <summary>
        ///     <para>
        ///         This function sets an input mode option for the specified window.
        ///         The mode must be <see cref="LockKeyModAttribute.LockKeyMods" />.
        ///     </para>
        ///     <para>
        ///         If the mode is <see cref="LockKeyModAttribute.LockKeyMods" />, the value must be either true to enable lock key modifier bits,
        ///         or false to disable them. If enabled, callbacks that receive modifier bits will also have the
        ///         caps lock modifier bit set when the event was generated with Caps Lock on, and the
        ///         num lock modifier  bit when Num Lock was on.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose input mode to set.</param>
        /// <param name="mode">
        ///     The value <see cref="LockKeyModAttribute.LockKeyMods" />.
        /// </param>
        /// <param name="value">The new value of the specified input mode.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.InvalidEnum" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetInputMode(Window* window, LockKeyModAttribute mode, bool value)
        {
            glfwSetInputMode(window, mode, value ? GLFW_TRUE : GLFW_FALSE);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the joystick configuration callback, or removes the currently set callback.
        ///         This is called when a joystick is connected to or disconnected from the system.
        ///     </para>
        /// </summary>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static IntPtr SetJoystickCallback(GLFWCallbacks.JoystickCallback callback) => glfwSetJoystickCallback(callback);

        /// <summary>
        ///     <para>
        ///         This function sets the key callback of the specified window, which is called when a key is pressed, repeated or released.
        ///     </para>
        ///     <para>
        ///         The key functions deal with physical keys, with layout independent
        ///         key tokens(<see cref="Keys" />) named after their values in the standard US keyboard layout.
        ///         If you want to input text, use the character callback(<see cref="SetCharCallback" />) instead.
        ///     </para>
        ///     <para>
        ///         When a window loses input focus, it will generate synthetic key release events for all pressed keys.
        ///         You can tell these events from user-generated events by the fact that the synthetic ones are generated
        ///         after the focus loss event has been processed,
        ///         i.e. after the window focus callback(<see cref="SetWindowFocusCallback" />) has been called.
        ///     </para>
        ///     <para>
        ///         The scancode of a key is specific to that platform or sometimes even to that machine.
        ///         Scancodes are intended to allow users to bind keys that don't have a GLFW key token.
        ///         Such keys have key set to <see cref="Keys.Unknown" />, their state is not saved
        ///         and so it cannot be queried with <see cref="GetKey" />.
        ///     </para>
        ///     <para>
        ///         Sometimes GLFW needs to generate synthetic key events, in which case the scancode may be zero.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new key callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetKeyCallback(
            Window* window,
            GLFWCallbacks.KeyCallback callback) =>
            glfwSetKeyCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the scroll callback of the specified window,
        ///         which is called when a scrolling device is used, such as a mouse wheel or scrolling area of a touchpad.
        ///     </para>
        ///     <para>
        ///         The scroll callback receives all scrolling input, like that from a mouse wheel or a touchpad scrolling area.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new scroll callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetScrollCallback(
            Window* window,
            GLFWCallbacks.ScrollCallback callback) =>
            glfwSetScrollCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the monitor configuration callback, or removes the currently set callback.
        ///         This is called when a monitor is connected to or disconnected from the system.
        ///     </para>
        /// </summary>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static IntPtr SetMonitorCallback(GLFWCallbacks.MonitorCallback callback) => glfwSetMonitorCallback(callback);

        /// <summary>
        ///     <para>
        ///         This function sets the mouse button callback of the specified window,
        ///         which is called when a mouse button is pressed or released.
        ///     </para>
        ///     <para>
        ///         When a window loses input focus,
        ///         it will generate synthetic mouse button release events for all pressed mouse buttons.
        ///         You can tell these events from user-generated events by the fact that the synthetic ones are generated after
        ///         the focus loss event has been processed,
        ///         i.e. after the window focus callback(<see cref="SetWindowFocusCallback" />) has been called.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetMouseButtonCallback(
            Window* window,
            GLFWCallbacks.MouseButtonCallback callback) =>
            glfwSetMouseButtonCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the close callback of the specified window,
        ///         which is called when the user attempts to close the window,
        ///         for example by clicking the close widget in the title bar.
        ///     </para>
        ///     <para>
        ///         The close flag is set before this callback is called,
        ///         but you can modify it at any time with <see cref="SetWindowShouldClose" />.
        ///     </para>
        ///     <para>
        ///         The close callback is not triggered by <see cref="DestroyWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         OS X: Selecting Quit from the application menu will trigger the close callback for all windows.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowCloseCallback(
            Window* window,
            GLFWCallbacks.WindowCloseCallback callback) =>
            glfwSetWindowCloseCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the focus callback of the specified window,
        ///         which is called when the window gains or loses input focus.
        ///     </para>
        ///     <para>
        ///         After the focus callback is called for a window that lost input focus,
        ///         synthetic key and mouse button release events will be generated for all such that had been pressed.
        ///         For more information, see <see cref="SetKeyCallback" /> and <see cref="SetMouseButtonCallback" />.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowFocusCallback(
            Window* window,
            GLFWCallbacks.WindowFocusCallback callback) =>
            glfwSetWindowFocusCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the icon of the specified window.
        ///     </para>
        ///     <para>
        ///         If passed an array of candidate images, those of or closest to the sizes desired by the system are selected.
        ///     </para>
        ///     <para>
        ///         If no images are specified, the window reverts to its default icon.
        ///     </para>
        ///     <para>
        ///         The desired image sizes varies depending on platform and system settings.
        ///         The selected images will be rescaled as needed. Good sizes include 16x16, 32x32 and 48x48.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose icon to set.</param>
        /// <param name="images">The images to create the icon from. If zero images are passed, the window is reset to the default icon.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         The specified image data is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         OS X: The GLFW window has no icon, as it is not a document window, so this function does nothing.
        ///         The dock icon will be the same as the application bundle's icon. For more information on bundles,
        ///         see the Bundle Programming Guide in the Mac Developer Library.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowIcon(Window* window, ReadOnlySpan<Image> images)
        {
            fixed (Image* ptr = images)
            {
                glfwSetWindowIcon(window, images.Length, ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function sets the icon of the specified window.
        ///     </para>
        ///     <para>
        ///         If passed an array of candidate images, those of or closest to the sizes desired by the system are selected.
        ///     </para>
        ///     <para>
        ///         If no images are specified, the window reverts to its default icon.
        ///     </para>
        ///     <para>
        ///         The desired image sizes varies depending on platform and system settings.
        ///         The selected images will be rescaled as needed. Good sizes include 16x16, 32x32 and 48x48.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose icon to set.</param>
        /// <param name="count">The number of images in the specified array, or zero to revert to the default window icon.</param>
        /// <param name="images">The images to create the icon from. This is ignored if count is zero.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         The specified image data is copied before this function returns.
        ///     </para>
        ///     <para>
        ///         OS X: The GLFW window has no icon, as it is not a document window, so this function does nothing.
        ///         The dock icon will be the same as the application bundle's icon. For more information on bundles,
        ///         see the Bundle Programming Guide in the Mac Developer Library.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowIconRaw(Window* window, int count, Image* images)
        {
            glfwSetWindowIcon(window, count, images);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the iconification callback of the specified window,
        ///         which is called when the window is iconified or restored.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowIconifyCallback(
            Window* window,
            GLFWCallbacks.WindowIconifyCallback callback) =>
            glfwSetWindowIconifyCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the monitor that the window uses for full screen mode or,
        ///         if the monitor is <c>null</c>, makes it windowed mode.
        ///     </para>
        ///     <para>
        ///         When setting a monitor, this function updates the width, height and refresh rate
        ///         of the desired video mode and switches to the video mode closest to it.
        ///     </para>
        ///     <para>
        ///         The window position is ignored when setting a monitor.
        ///     </para>
        ///     <para>
        ///         When the monitor is <c>null</c>, the position, width and height are used to place the window client area.
        ///         The refresh rate is ignored when no monitor is specified.
        ///     </para>
        ///     <para>
        ///         If you only wish to update the resolution of a full screen window or the size of a windowed mode window,
        ///         see <see cref="SetWindowSize" />.
        ///     </para>
        ///     <para>
        ///         When a window transitions from full screen to windowed mode,
        ///         this function restores any previous window settings such as whether it is decorated,
        ///         floating, resizable, has size or aspect ratio limits, etc..
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose monitor, size or video mode to set.</param>
        /// <param name="monitor">The desired monitor, or <c>null</c> to set windowed mode.</param>
        /// <param name="x">The desired x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">The desired y-coordinate of the upper-left corner of the client area.</param>
        /// <param name="width">The desired with, in screen coordinates, of the client area or video mode.</param>
        /// <param name="height">The desired height, in screen coordinates, of the client area or video mode.</param>
        /// <param name="refreshRate">The desired refresh rate, in Hz, of the video mode, or <see cref="GLFW.DontCare" />.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetWindowMonitor" />
        /// <seealso cref="SetWindowSize" />
        public static unsafe void SetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int x,
            int y,
            int width,
            int height,
            int refreshRate)
        {
            glfwSetWindowMonitor(window, monitor, x, y, width, height, refreshRate);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the position, in screen coordinates,
        ///         of the upper-left corner of the client area of the specified windowed mode window.
        ///     </para>
        ///     <para>
        ///         If the window is a full screen window, this function does nothing.
        ///     </para>
        ///     <para>
        ///         Do not use this function to move an already visible window
        ///         unless you have very good reasons for doing so, as it will confuse and annoy the user.
        ///     </para>
        ///     <para>
        ///         The window manager may put limits on what positions are allowed.
        ///         GLFW cannot and should not override these limits.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="x">The x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">The y-coordinate of the upper-left corner of the client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetWindowPos" />
        public static unsafe void SetWindowPos(Window* window, int x, int y)
        {
            glfwSetWindowPos(window, x, y);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the position callback of the specified window, which is called when the window is moved.
        ///     </para>
        ///     <para>
        ///         The callback is provided with the screen position of the upper-left corner of the client area of the window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowPosCallback(
            Window* window,
            GLFWCallbacks.WindowPosCallback callback) =>
            glfwSetWindowPosCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         Sets the refresh callback for the specified window.
        ///     </para>
        ///     <para>
        ///         This function sets the refresh callback of the specified window, which is
        ///         called when the content area of the window needs to be redrawn, for example
        ///         if the window has been exposed after having been covered by another window.
        ///     </para>
        ///     <para>
        ///         On compositing window systems such as Aero, Compiz, Aqua or Wayland, where
        ///         the window contents are saved off-screen, this callback may be called only
        ///         very infrequently or never at all.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowRefreshCallback(
            Window* window,
            GLFWCallbacks.WindowRefreshCallback callback) =>
            glfwSetWindowRefreshCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the size, in screen coordinates, of the client area of the specified window.
        ///     </para>
        ///     <para>
        ///         For full screen windows, this function updates the resolution of its desired video mode
        ///         and switches to the video mode closest to it, without affecting the window's context.
        ///     </para>
        ///     <para>
        ///         As the context is unaffected, the bit depths of the framebuffer remain unchanged.
        ///     </para>
        ///     <para>
        ///         If you wish to update the refresh rate of the desired video mode in addition to its resolution,
        ///         see <see cref="SetWindowMonitor" />.
        ///     </para>
        ///     <para>
        ///         The window manager may put limits on what sizes are allowed.
        ///         GLFW cannot and should not override these limits.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to resize.</param>
        /// <param name="width">The desired width, in screen coordinates, of the window client area.</param>
        /// <param name="height">The desired height, in screen coordinates, of the window client area.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="GetWindowSize" />
        /// <seealso cref="SetWindowMonitor" />
        public static unsafe void SetWindowSize(Window* window, int width, int height)
        {
            glfwSetWindowSize(window, width, height);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the size callback of the specified window, which is called when the window is resized.
        ///     </para>
        ///     <para>
        ///         The callback is provided with the size, in screen coordinates, of the client area of the window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        ///     The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe IntPtr SetWindowSizeCallback(
            Window* window,
            GLFWCallbacks.WindowSizeCallback callback) =>
            glfwSetWindowSizeCallback(window, callback);

        /// <summary>
        ///     <para>
        ///         This function sets the value of the close flag of the specified window.
        ///     </para>
        ///     <para>
        ///         This can be used to override the user's attempt to close the window, or to signal that it should be closed.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose flag to change.</param>
        /// <param name="value">The new value.</param>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowShouldClose(Window* window, bool value)
        {
            glfwSetWindowShouldClose(window, value ? GLFW_TRUE : GLFW_FALSE);
        }

        /// <summary>
        ///     <para>
        ///         This function sets the window title, encoded as UTF-8, of the specified window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose title to change.</param>
        /// <param name="title">The UTF-8 encoded window title.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         OS X: The window title will not be updated until the next time you process events.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowTitle(Window* window, string title)
        {
            var ptr = StringToCoTaskMemUTF8(title);

            try
            {
                glfwSetWindowTitle(window, (byte*)ptr);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     <para>
        ///         This function sets the window title, encoded as UTF-8, of the specified window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window whose title to change.</param>
        /// <param name="title">The UTF-8 encoded window title.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         OS X: The window title will not be updated until the next time you process events.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        public static unsafe void SetWindowTitleRaw(Window* window, byte* title)
        {
            glfwSetWindowTitle(window, title);
        }

        /// <summary>
        ///     <para>
        ///         This function makes the specified window visible if it was previously hidden.
        ///     </para>
        ///     <para>
        ///         If the window is already visible or is in full screen mode, this function does nothing.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to make visible.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="HideWindow" />
        public static unsafe void ShowWindow(Window* window) => glfwShowWindow(window);

        /// <summary>
        ///     <para>
        ///         This function sets the swap interval for the current OpenGL or OpenGL ES context,
        ///         i.e. the number of screen updates to wait from the time <see cref="SwapBuffers" /> was called
        ///         before swapping the buffers and returning.
        ///         This is sometimes called vertical synchronization, vertical retrace synchronization or just vsync.
        ///     </para>
        ///     <para>
        ///         A context that supports either of the <c>WGL_EXT_swap_control_tear</c>
        ///         and <c>GLX_EXT_swap_control_tear</c> extensions also accepts negative swap intervals,
        ///         which allows the driver to swap immediately even if a frame arrives a little bit late.
        ///         You can check for these extensions with <see cref="ExtensionSupported" />.
        ///     </para>
        ///     <para>
        ///         A context must be current on the calling thread.
        ///         Calling this function without a current context will cause a <see cref="ErrorCode.NoContext" /> error.
        ///     </para>
        /// </summary>
        /// <param name="interval">
        ///     The minimum number of screen updates to wait for until the buffers are swapped by <see cref="SwapBuffers" />.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This function is not called during context creation,
        ///         leaving the swap interval set to whatever is the default on that platform.
        ///         This is done because some swap interval extensions used by GLFW
        ///         do not allow the swap interval to be reset to zero once it has been set to a non-zero value.
        ///     </para>
        ///     <para>
        ///         Some GPU drivers do not honor the requested swap interval,
        ///         either because of a user setting that overrides the application's request or due to bugs in the driver.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" /> and <see cref="ErrorCode.PlatformError" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="SwapBuffers" />
        public static void SwapInterval(int interval) => glfwSwapInterval(interval);

        /// <summary>
        ///     <para>
        ///         This function puts the calling thread to sleep until at least one event is available in the event queue.
        ///     </para>
        ///     <para>
        ///         Once one or more events are available, it behaves exactly like <see cref="PollEvents" />,
        ///         i.e. the events in the queue are processed and the function then returns immediately.
        ///     </para>
        ///     <para>
        ///         Processing events will cause the window and input callbacks associated with those events to be called.
        ///     </para>
        ///     <para>
        ///         Since not all events are associated with callbacks,
        ///         this function may return without a callback having been called even if you are monitoring all callbacks.
        ///     </para>
        ///     <para>
        ///         On some platforms, a window move, resize or menu operation will cause event processing to block.
        ///         This is due to how event processing is designed on those platforms.
        ///         You can use the window refresh callback (<see cref="SetWindowRefreshCallback" />)
        ///         to redraw the contents of your window when necessary during such operations.
        ///     </para>
        ///     <para>
        ///         On some platforms,
        ///         certain callbacks may be called outside of a call to one of the event processing functions.
        ///     </para>
        ///     <para>
        ///         If no windows exist, this function returns immediately.
        ///         For synchronization of threads in applications that do not create windows,
        ///         use your threading library of choice.
        ///     </para>
        ///     <para>
        ///         Event processing is not required for joystick input to work.
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     This function must only be called from the main thread.
        ///     This function must not be called from a callback.
        ///     Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        /// </remarks>
        /// <seealso cref="PollEvents" />
        /// <seealso cref="WaitEventsTimeout" />
        public static void WaitEvents() => glfwWaitEvents();

        /// <summary>
        ///     <para>
        ///         This function puts the calling thread to sleep until at least one event is available in the event queue,
        ///         or until the specified timeout is reached.
        ///     </para>
        ///     <para>
        ///         If one or more events are available, it behaves exactly like <see cref="PollEvents" />,
        ///         i.e. the events in the queue are processed and the function then returns immediately.
        ///     </para>
        ///     <para>
        ///         Processing events will cause the window and input callbacks associated with those events to be called.
        ///     </para>
        ///     <para>
        ///         The timeout value must be a positive finite number.
        ///     </para>
        ///     <para>
        ///         Since not all events are associated with callbacks,
        ///         this function may return without a callback having been called even if you are monitoring all callbacks.
        ///     </para>
        ///     <para>
        ///         On some platforms, a window move, resize or menu operation will cause event processing to block.
        ///         This is due to how event processing is designed on those platforms.
        ///     </para>
        ///     <para>
        ///         You can use the window refresh callback (<see cref="SetWindowRefreshCallback" />)
        ///         to redraw the contents of your window when necessary during such operations.
        ///     </para>
        ///     <para>
        ///         On some platforms,
        ///         certain callbacks may be called outside of a call to one of the event processing functions.
        ///     </para>
        ///     <para>
        ///         If no windows exist, this function returns immediately.
        ///     </para>
        ///     <para>
        ///         For synchronization of threads in applications that do not create windows,
        ///         use your threading library of choice.
        ///     </para>
        ///     <para>
        ///         Event processing is not required for joystick input to work.
        ///     </para>
        /// </summary>
        /// <param name="timeout">The maximum amount of time, in seconds, to wait.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         This function must not be called from a callback.
        ///     </para>
        /// </remarks>
        /// <seealso cref="PollEvents" />
        /// <seealso cref="WaitEvents" />
        public static void WaitEventsTimeout(double timeout) => glfwWaitEventsTimeout(timeout);

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintInt,int)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint">The <see cref="WindowHintInt" /> to set.</param>
        /// <param name="value">The new value of the framebuffer attribute hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintInt hint, int value) => glfwWindowHint(hint, value);

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintBool,bool)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint">The <see cref="WindowHintInt" /> to set.</param>
        /// <param name="value">The new value of the framebuffer attribute hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintBool hint, bool value)
        {
            glfwWindowHint(hint, value ? GLFW_TRUE : GLFW_FALSE);
        }

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintClientApi,ClientApi)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint"><see cref="WindowHintClientApi.ClientApi" />.</param>
        /// <param name="value">The new value of the window hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintClientApi hint, ClientApi value) => glfwWindowHint(hint, value);

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintReleaseBehavior,ReleaseBehavior)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint"><see cref="WindowHintReleaseBehavior.ContextReleaseBehavior" />.</param>
        /// <param name="value">The new value of the window hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintReleaseBehavior hint, ReleaseBehavior value)
        {
            glfwWindowHint(hint, value);
        }

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintContextApi,ContextApi)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint"><see cref="WindowHintContextApi.ContextCreationApi" />.</param>
        /// <param name="value">The new value of the window hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintContextApi hint, ContextApi value)
        {
            glfwWindowHint(hint, value);
        }

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintRobustness,Robustness)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint"><see cref="WindowHintRobustness.ContextRobustness" />.</param>
        /// <param name="value">The new value of the window hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintRobustness hint, Robustness value)
        {
            glfwWindowHint(hint, value);
        }

        /// <summary>
        ///     <para>
        ///         This function sets hints for the next call to <see cref="CreateWindow" />.
        ///         The hints, once set, retain their values
        ///         until changed by a call to <see cref="WindowHint(WindowHintOpenGlProfile,OpenGlProfile)" />
        ///         or <see cref="DefaultWindowHints" />, or until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function does not check whether the specified hint values are valid.
        ///         If you set hints to invalid values this will instead be reported
        ///         by the next call to <see cref="CreateWindow" />.
        ///     </para>
        /// </summary>
        /// <param name="hint"><see cref="WindowHintOpenGlProfile.OpenGlProfile" />.</param>
        /// <param name="value">The new value of the window hint.</param>
        /// <remarks>
        ///     <para>
        ///         This function must only be called from the main thread.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.InvalidEnum" />.
        ///     </para>
        /// </remarks>
        /// <seealso cref="DefaultWindowHints" />
        public static void WindowHint(WindowHintOpenGlProfile hint, OpenGlProfile value)
        {
            glfwWindowHint(hint, value);
        }

        /// <summary>
        ///     <para>
        ///         This function returns the value of the close flag of the specified window.
        ///     </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>The value of the close flag.</returns>
        /// <remarks>
        ///     <para>
        ///         This function may be called from any thread. Access is not synchronized.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        /// </remarks>
        public static unsafe bool WindowShouldClose(Window* window) => glfwWindowShouldClose(window) == GLFW_TRUE;

        /// <summary>
        ///     Returns whether the Vulkan loader and an ICD have been found.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns whether the Vulkan loader and any minimally functional ICD have been found.
        ///     </para>
        ///     <para>
        ///         The availability of a Vulkan loader and even an ICD does not by itself
        ///         guarantee that surface creation or even instance creation is possible.
        ///         For example, on Fermi systems Nvidia will install an ICD that provides no actual Vulkan support.
        ///         Call <see cref="GetRequiredInstanceExtensions" /> to check whether the extensions necessary
        ///         for Vulkan surface creation are available and <see cref="GetPhysicalDevicePresentationSupport" />
        ///         to check whether a queue family of a physical device supports image presentation.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <returns>
        ///     <c>true</c> if Vulkan is minimally available, or <c>false</c> otherwise.
        /// </returns>
        public static bool VulkanSupported() => glfwVulkanSupported() == GLFW_TRUE;

        /// <summary>
        ///     Returns the Vulkan instance extensions required by GLFW.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns an array of names of Vulkan instance extensions required by GLFW for
        ///         creating Vulkan surfaces for GLFW windows. If successful, the list will always contains
        ///         <c>VK_KHR_surface</c>, so if you don't require any additional extensions you can
        ///         pass this list directly to the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        ///         a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        ///         whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         If Vulkan is available but no set of extensions allowing window surface creation was found,
        ///         this function returns <c>null</c>. You may still use Vulkan for off-screen rendering and compute work.
        ///     </para>
        ///     <para>
        ///         Additional extensions may be required by future versions of GLFW.
        ///         You should check if any extensions you wish to enable are already in the returned array,
        ///         as it is an error to specify an extension more than once in the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is guaranteed to be valid only until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <param name="count">
        ///     Where to store the number of extensions in the returned array.
        ///     This is set to zero if an error occurred.
        /// </param>
        /// <returns>
        ///     An array of ASCII encoded extension names, or <c>null</c> if an error occurred.
        /// </returns>
        public static unsafe byte** GetRequiredInstanceExtensionsRaw(out uint count)
        {
            fixed (uint* ptr = &count)
            {
                return glfwGetRequiredInstanceExtensions(ptr);
            }
        }

        /// <summary>
        ///     Returns the Vulkan instance extensions required by GLFW.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns an array of names of Vulkan instance extensions required by GLFW for
        ///         creating Vulkan surfaces for GLFW windows. If successful, the list will always contains
        ///         <c>VK_KHR_surface</c>, so if you don't require any additional extensions you can
        ///         pass this list directly to the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        ///         a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        ///         whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         If Vulkan is available but no set of extensions allowing window surface creation was found,
        ///         this function returns <c>null</c>. You may still use Vulkan for off-screen rendering and compute work.
        ///     </para>
        ///     <para>
        ///         Additional extensions may be required by future versions of GLFW.
        ///         You should check if any extensions you wish to enable are already in the returned array,
        ///         as it is an error to specify an extension more than once in the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is guaranteed to be valid only until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <param name="count">
        ///     Where to store the number of extensions in the returned array.
        ///     This is set to zero if an error occurred.
        /// </param>
        /// <returns>
        ///     An array of ASCII encoded extension names, or <c>null</c> if an error occurred.
        /// </returns>
        public static unsafe byte** GetRequiredInstanceExtensionsRaw(uint* count) => glfwGetRequiredInstanceExtensions(count);

        /// <summary>
        ///     Returns the Vulkan instance extensions required by GLFW.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns an array of names of Vulkan instance extensions required by GLFW for
        ///         creating Vulkan surfaces for GLFW windows. If successful, the list will always contains
        ///         <c>VK_KHR_surface</c>, so if you don't require any additional extensions you can
        ///         pass this list directly to the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        ///         a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        ///         whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         If Vulkan is available but no set of extensions allowing window surface creation was found,
        ///         this function returns <c>null</c>. You may still use Vulkan for off-screen rendering and compute work.
        ///     </para>
        ///     <para>
        ///         Additional extensions may be required by future versions of GLFW.
        ///         You should check if any extensions you wish to enable are already in the returned array,
        ///         as it is an error to specify an extension more than once in the <c>VkInstanceCreateInfo</c> struct.
        ///     </para>
        ///     <para>
        ///         macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         The returned array is allocated and freed by GLFW. You should not free it yourself.
        ///         It is guaranteed to be valid only until the library is terminated.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///     </para>
        /// </remarks>
        /// <returns>
        ///     An array of ASCII encoded extension names, or <c>null</c> if an error occurred.
        /// </returns>
        public static unsafe string[] GetRequiredInstanceExtensions()
        {
            var ptr = GetRequiredInstanceExtensionsRaw(out var count);

            var array = new string[count];
            for (var i = 0; i < count; i++)
            {
                array[i] = PtrToStringUTF8(ptr[i]);
            }

            return array;
        }

        /// <summary>
        ///     Returns the address of the specified Vulkan instance function.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns the address of the specified Vulkan core or extension function for
        ///         the specified instance. If instance is set to <c>null</c> it can return any function exported
        ///         from the Vulkan loader, including at least the following functions:
        ///     </para>
        ///     <list type="bullet">
        ///         <item>
        ///             <description>
        ///                 <c>vkEnumerateInstanceExtensionProperties</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkEnumerateInstanceLayerProperties</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkCreateInstance</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkGetInstanceProcAddr</c>
        ///             </description>
        ///         </item>
        ///     </list>
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        ///         a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        ///         whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         This function is equivalent to calling <c>vkGetInstanceProcAddr</c> with a platform-specific
        ///         query of the Vulkan loader as a fallback.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         The returned function pointer is valid until the library is terminated.
        ///     </para>
        /// </remarks>
        /// <param name="instance">
        ///     The Vulkan instance to query, or <c>null</c> to retrieve functions related to instance creation.
        /// </param>
        /// <param name="procName">The ASCII encoded name of the function.</param>
        /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
        public static unsafe IntPtr GetInstanceProcAddress(VkHandle instance, string procName)
        {
            var ptr = StringToCoTaskMemUTF8(procName);

            try
            {
                return glfwGetInstanceProcAddress(instance, (byte*)ptr);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        /// <summary>
        ///     Returns the address of the specified Vulkan instance function.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns the address of the specified Vulkan core or extension function for
        ///         the specified instance. If instance is set to <c>null</c> it can return any function exported
        ///         from the Vulkan loader, including at least the following functions:
        ///     </para>
        ///     <list type="bullet">
        ///         <item>
        ///             <description>
        ///                 <c>vkEnumerateInstanceExtensionProperties</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkEnumerateInstanceLayerProperties</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkCreateInstance</c>
        ///             </description>
        ///             <description>
        ///                 <c>vkGetInstanceProcAddr</c>
        ///             </description>
        ///         </item>
        ///     </list>
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        ///         a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        ///         whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         This function is equivalent to calling <c>vkGetInstanceProcAddr</c> with a platform-specific
        ///         query of the Vulkan loader as a fallback.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         The returned function pointer is valid until the library is terminated.
        ///     </para>
        /// </remarks>
        /// <param name="instance">
        ///     The Vulkan instance to query, or <c>null</c> to retrieve functions related to instance creation.
        /// </param>
        /// <param name="procName">The ASCII encoded name of the function.</param>
        /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
        public static unsafe IntPtr GetInstanceProcAddressRaw(VkHandle instance, byte* procName) => glfwGetInstanceProcAddress(instance, procName);

        /// <summary>
        ///     Returns whether the specified queue family can present images.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function returns whether the specified queue family of the specified physical device
        ///         supports presentation to the platform GLFW was built for.
        ///     </para>
        ///     <para>
        ///         If Vulkan or the required window surface creation instance extensions are not available
        ///         on the machine, or if the specified instance was not created with the required extensions,
        ///         this function returns <c>false</c> and generates a <see cref="ErrorCode.ApiUnavailable" /> error.
        ///         Call <see cref="VulkanSupported" /> to check whether Vulkan is at least minimally available and
        ///         <see cref="GetRequiredInstanceExtensions" /> to check what instance extensions are required.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        ///     </para>
        ///     <para>
        ///         macOS: This function currently always returns <c>true</c>, as the <c>VK_MVK_macos_surface</c>
        ///         extension does not provide a <c>vkGetPhysicalDevice*PresentationSupport</c> type function.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///         For synchronization details of Vulkan objects, see the Vulkan specification.
        ///     </para>
        /// </remarks>
        /// <param name="instance">The instance that the physical device belongs to.</param>
        /// <param name="device">The physical device that the queue family belongs to.</param>
        /// <param name="queueFamily">The index of the queue family to query.</param>
        /// <returns><c>true</c> if the queue family supports presentation, or <c>false</c> otherwise.</returns>
        public static bool GetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily) => glfwGetPhysicalDevicePresentationSupport(instance, device, queueFamily) == GLFW_TRUE;

        /// <summary>
        ///     Creates a Vulkan surface for the specified window.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This function creates a Vulkan surface for the specified window.
        ///     </para>
        ///     <para>
        ///         If the Vulkan loader or at least one minimally functional ICD were not found,
        ///         this function returns <c>VK_ERROR_INITIALIZATION_FAILED</c> and generates a
        ///         <see cref="ErrorCode.ApiUnavailable" /> error.
        ///         Call <see cref="VulkanSupported" /> to check whether Vulkan is at least minimally available.
        ///     </para>
        ///     <para>
        ///         If the required window surface creation instance extensions are not available or
        ///         if the specified instance was not created with these extensions enabled,
        ///         this function returns <c>VK_ERROR_EXTENSION_NOT_PRESENT</c> and generates a
        ///         <see cref="ErrorCode.ApiUnavailable" /> error.
        ///         Call <see cref="GetRequiredInstanceExtensions" /> to check what instance extensions are required.
        ///     </para>
        ///     <para>
        ///         The window surface cannot be shared with another API so the window must have been created with
        ///         the client api hint set to <see cref="ClientApi.NoApi" /> otherwise it generates a
        ///         <see cref="ErrorCode.InvalidValue" /> error and returns <c>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</c>.
        ///     </para>
        ///     <para>
        ///         The window surface must be destroyed before the specified Vulkan instance.
        ///         It is the responsibility of the caller to destroy the window surface.
        ///         GLFW does not destroy it for you. Call <c>vkDestroySurfaceKHR</c> to destroy the surface.
        ///     </para>
        ///     <para>
        ///         Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.ApiUnavailable" />,
        ///         <see cref="ErrorCode.PlatformError" /> and <see cref="ErrorCode.InvalidValue" />.
        ///     </para>
        ///     <para>
        ///         If an error occurs before the creation call is made, GLFW returns the Vulkan error code most
        ///         appropriate for the error. Appropriate use of <see cref="VulkanSupported" /> and
        ///         <see cref="GetRequiredInstanceExtensions" /> should eliminate almost all occurrences of these errors.
        ///     </para>
        ///     <para>
        ///         macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        ///     </para>
        ///     <para>
        ///         macOS: This function creates and sets a <c>CAMetalLayer</c> instance for the window content view,
        ///         which is required for MoltenVK to function.
        ///     </para>
        ///     <para>
        ///         This function may be called from any thread.
        ///         For synchronization details of Vulkan objects, see the Vulkan specification.
        ///     </para>
        /// </remarks>
        /// <param name="instance">The Vulkan instance to create the surface in.</param>
        /// <param name="window">The window to create the surface for.</param>
        /// <param name="allocator">The allocator to use, or <c>null</c> to use the default allocator.</param>
        /// <param name="surface">
        ///     Where to store the handle of the surface.
        ///     This is set to <c>VK_NULL_HANDLE</c> if an error occurred.
        /// </param>
        /// <returns>
        ///     <c>VK_SUCCESS</c> if successful, or a Vulkan error code if an error occurred.
        /// </returns>
        public static unsafe int CreateWindowSurface(
            VkHandle instance,
            Window* window,
            void* allocator,
            out VkHandle surface) =>
            glfwCreateWindowSurface(instance, window, allocator, out surface);
    }
}
