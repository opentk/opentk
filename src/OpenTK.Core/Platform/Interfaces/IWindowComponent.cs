using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using OpenTK.Mathematics;

#nullable enable

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// A delegate for hit testing.
    ///
    /// Hit testing is not always done in respone to the user clicking the mouse.
    /// The operating system can do hit testing for any reason and doesn't need to be in respose to some user action.
    /// It is recommended to keep this code efficient as it will be called often.
    /// </summary>
    /// <param name="handle">A handle to the window that hit testing is being done on.</param>
    /// <param name="position">The position of where the hit test is being done, not always the position of the mouse. In client relative coordinates.</param>
    /// <returns>The result of the hit test.</returns>
    public delegate HitType HitTest(WindowHandle handle, Vector2 position);

    /// <summary>
    /// Interface for abstraction layer drivers which implement the window component.
    /// </summary>
    public interface IWindowComponent : IPalComponent
    {
        // FIXME: Make most Get* functions return their value instead of going through out parameters.

        /// <summary>
        /// True when the driver supports setting the window icon.
        /// </summary>
        bool CanSetIcon { get; }

        /// <summary>
        /// True when the driver can provide the display the window is in.
        /// </summary>
        bool CanGetDisplay { get; }

        /// <summary>
        /// True when the driver supports setting the cursor of the window.
        /// </summary>
        bool CanSetCursor { get; }

        /// <summary>
        /// True when the driver supports capturing the cursor in a window.
        /// </summary>
        bool CanCaptureCursor { get; }

        /// <summary>
        /// Read-only list of event types the driver supports.
        /// </summary>
        IReadOnlyList<PlatformEventType> SupportedEvents { get; }

        /// <summary>
        /// Read-only list of window styles the driver supports.
        /// </summary>
        IReadOnlyList<WindowBorderStyle> SupportedStyles { get; }

        /// <summary>
        /// Read-only list of window modes the driver supports.
        /// </summary>
        IReadOnlyList<WindowMode> SupportedModes { get; }

        /// <summary>
        /// Processes platform events and sends them to the <see cref="EventQueue"/>.
        /// </summary>
        /// <param name="waitForEvents">Specifies if this function should wait for events or return immediately if there are no events.</param>
        void ProcessEvents(bool waitForEvents = false);

        /// <summary>
        /// Create a window object.
        /// </summary>
        /// <param name="hints">Graphics API hints to be passed to the operating system.</param>
        /// <returns>Handle to the new window object.</returns>
        // FIXME: Possibly rethink how to do GraphicsApiHints.
        // FIXME: API for getting the GraphicsApiHints
        WindowHandle Create(GraphicsApiHints hints);

        /// <summary>
        /// Destroy a window object.
        /// </summary>
        /// <param name="handle">Handle to a window object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(WindowHandle handle);

        /// <summary>
        /// Checks if <see cref="Destroy(WindowHandle)"/> has been called on this handle.
        /// </summary>
        /// <param name="handle">The window handle to check if it's destroyed or not.</param>
        /// <returns>If <see cref="Destroy(WindowHandle)"/> was called with the window handle.</returns>
        public bool IsWindowDestroyed(WindowHandle handle);

        /// <summary>
        /// Get the title of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The title of the window.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        string GetTitle(WindowHandle handle);

        /// <summary>
        /// Set the title of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="title">New window title string.</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="handle"/> or <paramref name="title"/> is null.
        /// </exception>
        void SetTitle(WindowHandle handle, string title);

        /// <summary>
        /// Get a handle to the window icon object.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>Handle to the windows icon object, or null if none is set.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support getting the window icon. See <see cref="CanSetIcon"/>.
        /// </exception>
        IconHandle? GetIcon(WindowHandle handle);

        /// <summary>
        /// Set window icon object handle.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="icon">Handle to an icon object, or null to revert to default.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> or <paramref name="icon"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support setting the window icon. See <see cref="CanSetIcon"/>.
        /// </exception>
        void SetIcon(WindowHandle handle, IconHandle icon);

        /// <summary>
        /// Get the window position in display coordinates (top left origin).
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">X coordinate of the window.</param>
        /// <param name="y">Y coordinate of the window.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetPosition(WindowHandle handle, out int x, out int y);

        /// <summary>
        /// Set the window position in display coordinates (top left origin).
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">New X coordinate of the window.</param>
        /// <param name="y">New Y coordinate of the window.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void SetPosition(WindowHandle handle, int x, int y);

        /// <summary>
        /// Get the size of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">Width of the window in pixels.</param>
        /// <param name="height">Height of the window in pixels.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetSize(WindowHandle handle, out int width, out int height);

        /// <summary>
        /// Set the size of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">New width of the window in pixels.</param>
        /// <param name="height">New height of the window in pixels.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void SetSize(WindowHandle handle, int width, int height);

        /// <summary>
        /// Get the bounds of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">X coordinate of the window.</param>
        /// <param name="y">Y coordinate of the window.</param>
        /// <param name="width">Width of the window in pixels.</param>
        /// <param name="height">Height of the window in pixels.</param>
        void GetBounds(WindowHandle handle, out int x, out int y, out int width, out int height);

        /// <summary>
        /// Set the bounds of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">New X coordinate of the window.</param>
        /// <param name="y">New Y coordinate of the window.</param>
        /// <param name="width">New width of the window in pixels.</param>
        /// <param name="height">New height of the window in pixels.</param>
        void SetBounds(WindowHandle handle, int x, int y, int width, int height);

        /// <summary>
        /// Get the position of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">X coordinate of the client area.</param>
        /// <param name="y">Y coordinate of the client area.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetClientPosition(WindowHandle handle, out int x, out int y);

        /// <summary>
        /// Set the position of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">New X coordinate of the client area.</param>
        /// <param name="y">New Y coordinate of the client area.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void SetClientPosition(WindowHandle handle, int x, int y);

        /// <summary>
        /// Get the size of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">Width of the client area in pixels.</param>
        /// <param name="height">Height of the client area in pixels.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetClientSize(WindowHandle handle, out int width, out int height);

        /// <summary>
        /// Set the size of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">New width of the client area in pixels.</param>
        /// <param name="height">New height of the client area in pixels.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void SetClientSize(WindowHandle handle, int width, int height);

        /// <summary>
        /// Get the client area bounds (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">X coordinate of the client area.</param>
        /// <param name="y">Y coordinate of the client area.</param>
        /// <param name="width">Width of the client area in pixels.</param>
        /// <param name="height">Height of the client area in pixels.</param>
        void GetClientBounds(WindowHandle handle, out int x, out int y, out int width, out int height);

        /// <summary>
        /// Set the client area bounds (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">New X coordinate of the client area.</param>
        /// <param name="y">New Y coordinate of the client area.</param>
        /// <param name="width">New width of the client area in pixels.</param>
        /// <param name="height">New height of the client area in pixels.</param>
        void SetClientBounds(WindowHandle handle, int x, int y, int width, int height);

        /// <summary>
        /// Get the size of the window framebuffer in pixels.
        /// Use this value when calls to graphics APIs that want pixels, e.g. GL.Viewport().
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">Width in pixels of the window framebuffer.</param>
        /// <param name="height">Height in pixels of the window framebuffer.</param>
        void GetFramebufferSize(WindowHandle handle, out int width, out int height);

        /// <summary>
        /// Gets the maximum size of the client area.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">The maximum width of the client area of the window, or null if no limit is set.</param>
        /// <param name="height">The maximum height of the client area of the window, or null if no limit is set.</param>
        void GetMaxClientSize(WindowHandle handle, out int? width, out int? height);

        /// <summary>
        /// Sets the maximum size of the client area.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">New maximum width of the client area of the window, or null to remove limit.</param>
        /// <param name="height">New maximum height of the client area of the window, or null to remove limit.</param>
        void SetMaxClientSize(WindowHandle handle, int? width, int? height);

        /// <summary>
        /// Gets the minimum size of the client area.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">The minimum width of the client area of the window, or null if no limit is set.</param>
        /// <param name="height">The minimum height of the client area of the window, or null if no limit is set.</param>
        void GetMinClientSize(WindowHandle handle, out int? width, out int? height);

        /// <summary>
        /// Sets the minimum size of the client area.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="width">New minimum width of the client area of the window, or null to remove limit.</param>
        /// <param name="height">New minimum height of the client area of the window, or null to remove limit.</param>
        void SetMinClientSize(WindowHandle handle, int? width, int? height);

        /// <summary>
        /// Get the display handle a window is in.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The display handle the window is in.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support finding the window display. <see cref="CanGetDisplay"/>.
        /// </exception>
        DisplayHandle GetDisplay(WindowHandle handle);

        /// <summary>
        /// Get the mode of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The mode of the window.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        WindowMode GetMode(WindowHandle handle);

        /// <summary>
        /// Set the mode of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="mode">The new mode of the window.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="mode"/> is an invalid value.</exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support the value set by <paramref name="mode"/>. See <see cref="SupportedModes"/>.
        /// </exception>
        /// <remarks>
        /// Setting <see cref="WindowMode.WindowedFullscreen"/> or <see cref="WindowMode.ExclusiveFullscreen"/>
        /// will make the window fullscreen in the nearest monitor to the window location.
        /// Use <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/> or
        /// <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/> to explicitly set the monitor.
        /// </remarks>
        void SetMode(WindowHandle handle, WindowMode mode);

        /// <summary>
        /// Put a window into 'windowed fullscreen' on a specified display or the display the window is displayed on.
        /// If <paramref name="display"/> is <c>null</c> then the window will be made fullscreen on the 'nearest' display.
        /// </summary>
        /// <param name="handle">The window to make fullscreen.</param>
        /// <param name="display">The display to make the window fullscreen on.</param>
        /// <remarks>
        /// To make an 'exclusive fullscreen' window see <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/>.
        /// </remarks>
        void SetFullscreenDisplay(WindowHandle handle, DisplayHandle? display);

        /// <summary>
        /// Put a window into 'exclusive fullscreen' on a specified display and change the video mode to the specified video mode.
        /// Only video modes accuired using <see cref="IDisplayComponent.GetSupportedVideoModes(DisplayHandle)"/>
        /// are expected to work.
        /// </summary>
        /// <param name="handle">The window to make fullscreen.</param>
        /// <param name="display">The display to make the window fullscreen on.</param>
        /// <param name="videoMode">The video mode to use when making the window fullscreen.</param>
        /// <remarks>
        /// To make an 'windowed fullscreen' window see <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/>.
        /// </remarks>
        void SetFullscreenDisplay(WindowHandle handle, DisplayHandle display, VideoMode videoMode);

        /// <summary>
        /// Gets the display that the specified window is fullscreen on, if the window is fullscreen.
        /// </summary>
        /// <param name="handle">The window handle.</param>
        /// <param name="display">The display where the window is fullscreen or null if the window is not fullscreen.</param>
        /// <returns><c>true</c> if the window was fullscreen, <c>false</c> otherwise.</returns>
        bool GetFullscreenDisplay(WindowHandle handle, [NotNullWhen(true)] out DisplayHandle? display);

        /// <summary>
        /// Get the border style of a window.
        /// </summary>
        /// <param name="handle">Handle to window.</param>
        /// <returns>The border style of the window.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        WindowBorderStyle GetBorderStyle(WindowHandle handle);

        /// <summary>
        /// Set the border style of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="style">The new border style of the window.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="style"/> is an invalid value.</exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support the value set by <paramref name="style"/>. See <see cref="SupportedStyles"/>.
        /// </exception>
        void SetBorderStyle(WindowHandle handle, WindowBorderStyle style);

        /// <summary>
        /// Set if the window is an always on top window or not.
        /// </summary>
        /// <param name="handle">A handle to the window to make always on top.</param>
        /// <param name="floating">Whether the window should be always on top or not.</param>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating);

        /// <summary>
        /// Gets if the current window is always on top or not.
        /// </summary>
        /// <param name="handle">A handle to the window to get whether or not is always on top.</param>
        /// <returns>Whether the window is always on top or not.</returns>
        public bool IsAlwaysOnTop(WindowHandle handle);

        /// <summary>
        /// Sets a delegate that is used for hit testing.
        /// Hit testing allows the user to specify if a click should start a drag or resize operation on the window.
        ///
        /// Hit testing is not always done in respone to the user clicking the mouse.
        /// The operating system can do hit testing for any reason and doesn't need to be in respose to some user action.
        /// It is recommended to keep this code efficient as it will be called often.
        /// </summary>
        /// <param name="handle">The window for which this hit test delegate should be used for.</param>
        /// <param name="test">The hit test delegate.</param>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test);

        /// <summary>
        /// Set the cursor object for a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="cursor">Handle to a cursor object, or null for hidden cursor.</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="handle"/> is null.
        /// </exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support setting the window mouse cursor. See <see cref="CanSetCursor"/>.
        /// </exception>
        void SetCursor(WindowHandle handle, CursorHandle? cursor);

        /// <summary>
        /// Gets the current cursor capture mode. See <see cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/> for more details.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The current cursor capture mode.</returns>
        CursorCaptureMode GetCursorCaptureMode(WindowHandle handle);

        /// <summary>
        /// Sets the cursor capture mode of the window.
        /// A cursor can be confined to the bounds of the window, or locked to the center of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="mode">The cursor capture mode.</param>
        void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode);

        // FIXME: Need a function to check if the window has input focus...

        /// <summary>
        /// Gives the window input focus.
        /// </summary>
        /// <param name="handle">Handle to the window to focus.</param>
        void FocusWindow(WindowHandle handle);

        /// <summary>
        /// Requests that the user pay attention to the window.
        /// </summary>
        /// <param name="handle">A handle to the window that requests attention.</param>
        void RequestAttention(WindowHandle handle);

        /// <summary>
        /// Converts screen coordinates to window relative coordinates.
        /// </summary>
        /// <param name="handle">The window handle.</param>
        /// <param name="x">The screen x coordinate.</param>
        /// <param name="y">The screen y coordinate.</param>
        /// <param name="clientX">The client x coordinate.</param>
        /// <param name="clientY">The client y coordinate.</param>
        /// FIXME: Change to use Vector2i instead of x and y variables.
        void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY);

        /// <summary>
        /// Converts window relative coordinates to screen coordinates.
        /// </summary>
        /// <param name="handle">The window handle.</param>
        /// <param name="clientX">The client x coordinate.</param>
        /// <param name="clientY">The client y coordinate.</param>
        /// <param name="x">The screen x coordinate.</param>
        /// <param name="y">The screen y coordinate.</param>
        /// FIXME: Change to use Vector2i instead of x and y variables.
        void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y);

        /// <summary>
        /// Returns the current scale factor of this window.
        /// </summary>
        /// <param name="handle">The window handle.</param>
        /// <param name="scaleX">The x scale factor of the window.</param>
        /// <param name="scaleY">The y scale factor of the window.</param>
        /// <seealso cref="WindowScaleChangeEventArgs"/>
        void GetScaleFactor(WindowHandle handle, out float scaleX, out float scaleY);
    }
}
