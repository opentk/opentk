using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using OpenTK.Mathematics;

#nullable enable

namespace OpenTK.Platform
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
    /// <seealso cref="IWindowComponent.SetHitTestCallback(WindowHandle, HitTest?)"/>
    public delegate HitType HitTest(WindowHandle handle, Vector2 position);

    /// <summary>
    /// Interface for abstraction layer drivers which implement the window component.
    /// </summary>
    /// <seealso cref="Toolkit.Window"/>
    public interface IWindowComponent : IPalComponent
    {
        // FIXME: Make most Get* functions return their value instead of going through out parameters.

        /// <summary>
        /// <see langword="true"/> when the driver supports setting and getting the window icon using <see cref="SetIcon(WindowHandle, IconHandle)"/> and <see cref="GetIcon(WindowHandle)"/>.
        /// </summary>
        /// <seealso cref="SetIcon(WindowHandle, IconHandle)"/>
        /// <seealso cref="GetIcon(WindowHandle)"/>
        // FIXME: Maybe we can remove this as all backends currently return true.
        // - Noggin_bops 2024-08-01
        bool CanSetIcon { get; }

        /// <summary>
        /// <see langword="true"/> when the driver can provide the display the window is in using <see cref="GetDisplay(WindowHandle)"/>.
        /// </summary>
        /// <seealso cref="GetDisplay(WindowHandle)"/>
        // FIXME: Maybe we can remove this as this is currently possible on all our supported backends.
        // - Noggin_bops 2024-08-01
        bool CanGetDisplay { get; }

        /// <summary>
        /// <see langword="true"/> when the driver supports setting the cursor of the window using <see cref="SetCursor(WindowHandle, CursorHandle?)"/>.
        /// </summary>
        /// <seealso cref="SetCursor(WindowHandle, CursorHandle?)"/>
        // FIXME: Maybe we can remove this as all backends currently return true.
        // - Noggin_bops 2024-08-01
        bool CanSetCursor { get; }

        /// <summary>
        /// <see langword="true"/> when the driver supports capturing the cursor in a window using <see cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/>.
        /// </summary>
        /// <seealso cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/>
        // FIXME: This returns true on all currently supported platforms, maybe we can remove this.
        // - Noggin_bops 2024-08-01
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
        void ProcessEvents(bool waitForEvents);

        /// <summary>
        /// Posts a user defined event to the event queue.
        /// This is mostly useful when using the <see cref="ProcessEvents(bool)"/> with <see langword="true"/> to wait for events.
        /// Then this method can be used to manually post an event and wake up the main thread.
        /// Sending events through this function has overhead so unnecessary calls to this function should be avoided.
        /// </summary>
        /// <remarks>
        /// This function is allowed to be called from any thread.
        /// </remarks>
        /// <param name="event"></param>
        void PostUserEvent(EventArgs @event);

        /// <summary>
        /// Create a window object.
        /// </summary>
        /// <param name="hints">Graphics API hints to be passed to the operating system.</param>
        /// <returns>Handle to the new window object.</returns>
        /// <seealso cref="Destroy(WindowHandle)"/>
        // FIXME: Possibly rethink how to do GraphicsApiHints.
        // FIXME: API for getting the GraphicsApiHints
        WindowHandle Create(GraphicsApiHints hints);

        /// <summary>
        /// Destroy a window object. After a window has been destroyed the handle should no longer be used in any function other than <see cref="IsWindowDestroyed(WindowHandle)"/>.
        /// </summary>
        /// <param name="handle">Handle to a window object.</param>
        /// <seealso cref="Create(GraphicsApiHints)"/>
        /// <seealso cref="IsWindowDestroyed(WindowHandle)"/>
        void Destroy(WindowHandle handle);

        /// <summary>
        /// Checks if <see cref="Destroy(WindowHandle)"/> has been called on this handle.
        /// </summary>
        /// <param name="handle">The window handle to check if it's destroyed or not.</param>
        /// <returns>If <see cref="Destroy(WindowHandle)"/> was called with the window handle.</returns>
        /// <seealso cref="Create(GraphicsApiHints)"/>
        /// <seealso cref="Destroy(WindowHandle)"/>
        public bool IsWindowDestroyed(WindowHandle handle);

        /// <summary>
        /// Get the title of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The title of the window.</returns>
        /// <seealso cref="SetTitle(WindowHandle, string)"/>
        string GetTitle(WindowHandle handle);

        /// <summary>
        /// Set the title of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="title">New window title string.</param>
        /// <seealso cref="GetTitle(WindowHandle)"/>
        void SetTitle(WindowHandle handle, string title);

        /// <summary>
        /// Get a handle to the window icon object.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>Handle to the windows icon object, or null if none is set.</returns>
        /// <exception cref="PlatformNotSupportedException">Backend does not support getting the window icon. See <see cref="CanSetIcon"/>.</exception>
        /// <seealso cref="CanSetIcon"/>
        /// <seealso cref="SetIcon(WindowHandle, IconHandle)"/>
        IconHandle? GetIcon(WindowHandle handle);

        /// <summary>
        /// Set window icon object handle.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="icon">Handle to an icon object.</param>
        /// <exception cref="PlatformNotSupportedException">Backend does not support setting the window icon. See <see cref="CanSetIcon"/>.</exception>
        /// <seealso cref="CanSetIcon"/>
        /// <seealso cref="GetIcon(WindowHandle)"/>
        void SetIcon(WindowHandle handle, IconHandle icon);

        /// <summary>
        /// Get the window position in display coordinates (top left origin).
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="position">Coordinate of the window in screen coordinates.</param>
        /// <seealso cref="SetPosition(WindowHandle, Vector2i)"/>
        void GetPosition(WindowHandle handle, out Vector2i position);

        /// <summary>
        /// Set the window position in display coordinates (top left origin).
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="newPosition">New position of the window in screen coordinates.</param>
        void SetPosition(WindowHandle handle, Vector2i newPosition);

        /// <summary>
        /// Get the size of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="size">Size of the window in screen coordinates.</param>
        void GetSize(WindowHandle handle, out Vector2i size);

        /// <summary>
        /// Set the size of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="newSize">New size of the window in screen coordinates.</param>
        void SetSize(WindowHandle handle, Vector2i newSize);

        /// <summary>
        /// Get the bounds of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">X coordinate of the window.</param>
        /// <param name="y">Y coordinate of the window.</param>
        /// <param name="width">Width of the window in screen coordinates.</param>
        /// <param name="height">Height of the window in screen coordinates.</param>
        void GetBounds(WindowHandle handle, out int x, out int y, out int width, out int height);

        /// <summary>
        /// Set the bounds of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="x">New X coordinate of the window.</param>
        /// <param name="y">New Y coordinate of the window.</param>
        /// <param name="width">New width of the window in screen coordinates.</param>
        /// <param name="height">New height of the window in screen coordinates.</param>
        void SetBounds(WindowHandle handle, int x, int y, int width, int height);

        /// <summary>
        /// Get the position of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="clientPosition">The coordinate of the client area in screen coordinates.</param>
        void GetClientPosition(WindowHandle handle, out Vector2i clientPosition);

        /// <summary>
        /// Set the position of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="newClientPosition">New coordinate of the client area in screen coordinates.</param>
        void SetClientPosition(WindowHandle handle, Vector2i newClientPosition);

        /// <summary>
        /// Get the size of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="clientSize">Size of the client area in screen coordinates.</param>
        void GetClientSize(WindowHandle handle, out Vector2i clientSize);

        /// <summary>
        /// Set the size of the client area (drawing area) of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="newClientSize">New size of the client area in screen coordinates.</param>
        void SetClientSize(WindowHandle handle, Vector2i newClientSize);

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
        /// <param name="framebufferSize">Size in pixels of the window framebuffer.</param>
        void GetFramebufferSize(WindowHandle handle, out Vector2i framebufferSize);

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
        /// <exception cref="PalNotImplementedException">Backend does not support finding the window display. <see cref="CanGetDisplay"/>.</exception>
        /// <seealso cref="CanGetDisplay"/>
        DisplayHandle GetDisplay(WindowHandle handle);

        /// <summary>
        /// Get the mode of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The mode of the window.</returns>
        WindowMode GetMode(WindowHandle handle);

        /// <summary>
        /// Set the mode of a window.
        /// </summary>
        /// <remarks>
        /// Setting <see cref="WindowMode.WindowedFullscreen"/> or <see cref="WindowMode.ExclusiveFullscreen"/>
        /// will make the window fullscreen in the nearest monitor to the window location.
        /// Use <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/> or
        /// <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/> to explicitly set the monitor.
        /// </remarks>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="mode">The new mode of the window.</param>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"><paramref name="mode"/> is an invalid value.</exception>
        /// <exception cref="PlatformNotSupportedException">Backend does not support the value set by <paramref name="mode"/>. See <see cref="SupportedModes"/>. </exception>
        /// <seealso cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/>
        /// <seealso cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/>
        void SetMode(WindowHandle handle, WindowMode mode);

        /// <summary>
        /// Put a window into 'windowed fullscreen' on a specified display or the display the window is displayed on.
        /// If <paramref name="display"/> is <c>null</c> then the window will be made fullscreen on the 'nearest' display.
        /// </summary>
        /// <remarks>
        /// To make an 'exclusive fullscreen' window see <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/>.
        /// </remarks>
        /// <param name="handle">The window to make fullscreen.</param>
        /// <param name="display">The display to make the window fullscreen on.</param>
        /// <seealso cref="SetMode(WindowHandle, WindowMode)"/>
        void SetFullscreenDisplay(WindowHandle handle, DisplayHandle? display);

        /// <summary>
        /// Put a window into 'exclusive fullscreen' on a specified display and change the video mode to the specified video mode.
        /// Only video modes accuired using <see cref="IDisplayComponent.GetSupportedVideoModes(DisplayHandle)"/>
        /// are expected to work.
        /// </summary>
        /// <remarks>
        /// To make a 'windowed fullscreen' window see <see cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/>.
        /// </remarks>
        /// <param name="handle">The window to make fullscreen.</param>
        /// <param name="display">The display to make the window fullscreen on.</param>
        /// <param name="videoMode">The video mode to use when making the window fullscreen.</param>
        /// <seealso cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/>
        /// <seealso cref="SetMode(WindowHandle, WindowMode)"/>
        void SetFullscreenDisplay(WindowHandle handle, DisplayHandle display, VideoMode videoMode);

        /// <summary>
        /// Gets the display that the specified window is fullscreen on, if the window is fullscreen.
        /// </summary>
        /// <param name="handle">The window handle.</param>
        /// <param name="display">The display where the window is fullscreen or null if the window is not fullscreen.</param>
        /// <returns><see langword="true"/> if the window was fullscreen, <see langword="false"/> otherwise.</returns>
        /// <seealso cref="SetMode(WindowHandle, WindowMode)"/>
        /// <seealso cref="SetFullscreenDisplay(WindowHandle, DisplayHandle?)"/>
        /// <seealso cref="SetFullscreenDisplay(WindowHandle, DisplayHandle, VideoMode)"/>
        bool GetFullscreenDisplay(WindowHandle handle, [NotNullWhen(true)] out DisplayHandle? display);

        /// <summary>
        /// Get the border style of a window.
        /// </summary>
        /// <param name="handle">Handle to window.</param>
        /// <returns>The border style of the window.</returns>
        /// <seealso cref="SetBorderStyle(WindowHandle, WindowBorderStyle)"/>
        WindowBorderStyle GetBorderStyle(WindowHandle handle);

        /// <summary>
        /// Set the border style of a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="style">The new border style of the window.</param>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"><paramref name="style"/> is an invalid value.</exception>
        /// <exception cref="PlatformNotSupportedException">Backend does not support the value set by <paramref name="style"/>. See <see cref="SupportedStyles"/>.</exception>
        void SetBorderStyle(WindowHandle handle, WindowBorderStyle style);

        /// <summary>
        /// Returns true if <see cref="WindowTransparencyMode.TransparentFramebuffer"/> is supported for this window.
        /// <list type="table">
        /// <item>
        ///     <term>Win32</term>
        ///     <description>Always returns <see langword="true"/>.</description>
        /// </item>
        /// <item>
        ///     <term>macOS</term>
        ///     <description>Always returns <see langword="true"/>.</description>
        /// </item>
        /// <item>
        ///     <term>Linux/X11</term>
        ///     <description>Returns <see langword="true"/> if the selected <see cref="ContextValues"/> had <see cref="ContextValues.SupportsFramebufferTransparency"/> <see langword="true"/>.</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="handle">The window to query framebuffer transparency support for.</param>
        /// <returns>If <see cref="SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/> with <see cref="WindowTransparencyMode.TransparentFramebuffer"/> would work.</returns>
        /// <seealso cref="SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/>
        /// <seealso cref="OpenGLGraphicsApiHints.SupportTransparentFramebufferX11"/>
        /// <seealso cref="ContextValues.SupportsFramebufferTransparency"/>
        /// <seealso cref="WindowTransparencyMode"/>
        bool SupportsFramebufferTransparency(WindowHandle handle);

        /// <summary>
        /// Sets the transparency mode of the specified window.
        /// </summary>
        /// <param name="handle">The window to set the transparency mode of.</param>
        /// <param name="transparencyMode">The transparency mode to apply to the window.</param>
        /// <param name="opacity">The whole window opacity. Ignored if <paramref name="transparencyMode"/> is not <see cref="WindowTransparencyMode.TransparentWindow"/>.</param>
        /// <seealso cref="WindowTransparencyMode"/>
        /// <seealso cref="SupportsFramebufferTransparency(WindowHandle)"/>
        /// <seealso cref="GetTransparencyMode(WindowHandle, out float)"/>
        public void SetTransparencyMode(WindowHandle handle, WindowTransparencyMode transparencyMode, float opacity = 0.5f);

        /// <summary>
        /// Gets the transparency mode of the specified window.
        /// </summary>
        /// <param name="handle">The window to query the transparency mode of.</param>
        /// <param name="opacity">The window opacity if the transparency mode was <see cref="WindowTransparencyMode.TransparentWindow"/>, 0 otherwise.</param>
        /// <returns>The transparency mode of the specified window.</returns>
        /// <seealso cref="WindowTransparencyMode"/>
        /// <seealso cref="SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/>
        /// <seealso cref="SupportsFramebufferTransparency(WindowHandle)"/>
        public WindowTransparencyMode GetTransparencyMode(WindowHandle handle, out float opacity);

        /// <summary>
        /// Set if the window is an always on top window or not.
        /// </summary>
        /// <param name="handle">A handle to the window to make always on top.</param>
        /// <param name="floating">Whether the window should be always on top or not.</param>
        /// <seealso cref="IsAlwaysOnTop(WindowHandle)"/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating);

        /// <summary>
        /// Gets if the current window is always on top or not.
        /// </summary>
        /// <param name="handle">A handle to the window to get whether or not is always on top.</param>
        /// <returns>Whether the window is always on top or not.</returns>
        /// <seealso cref="SetAlwaysOnTop(WindowHandle, bool)"/>
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
        /// <seealso cref="HitTest"/>
        /// <seealso cref="HitType"/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test);

        /// <summary>
        /// Set the cursor object for a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="cursor">Handle to a cursor object, or null for hidden cursor.</param>
        /// <exception cref="PlatformNotSupportedException">Backend does not support setting the window mouse cursor. See <see cref="CanSetCursor"/>.</exception>
        /// <seealso cref="CanSetCursor"/>
        void SetCursor(WindowHandle handle, CursorHandle? cursor);

        /// <summary>
        /// Gets the current cursor capture mode. See <see cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/> for more details.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>The current cursor capture mode.</returns>
        /// <seealso cref="CanCaptureCursor"/>
        /// <seealso cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/>
        CursorCaptureMode GetCursorCaptureMode(WindowHandle handle);

        /// <summary>
        /// Sets the cursor capture mode of the window.
        /// A cursor can be confined to the bounds of the window, or locked to the center of the window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="mode">The cursor capture mode.</param>
        /// <seealso cref="CanCaptureCursor"/>
        /// <seealso cref="SetCursorCaptureMode(WindowHandle, CursorCaptureMode)"/>
        void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode);

        /// <summary>
        /// Returns true if the given window has input focus.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>If the window has input focus.</returns>
        /// <seealso cref="FocusWindow(WindowHandle)"/>
        /// <seealso cref="RequestAttention(WindowHandle)"/>
        bool IsFocused(WindowHandle handle);

        /// <summary>
        /// Gives the window input focus.
        /// </summary>
        /// <param name="handle">Handle to the window to focus.</param>
        /// <seealso cref="IsFocused(WindowHandle)"/>
        /// <seealso cref="RequestAttention(WindowHandle)"/>
        void FocusWindow(WindowHandle handle);

        /// <summary>
        /// Requests that the user pay attention to the window.
        /// Usually by flashing the window icon.
        /// </summary>
        /// <param name="handle">A handle to the window that requests attention.</param>
        /// <seealso cref="FocusWindow(WindowHandle)"/>
        void RequestAttention(WindowHandle handle);

        /// <summary>
        /// Converts screen coordinates to window relative coordinates.
        /// </summary>
        /// <remarks>
        /// On platforms that support non-integer screen and client space coordinates (macOS) this function will return full precision results,
        /// on integer based platforms (win32 and X11) the input coordinates will (if necessary) be truncated to ints before conversion.
        /// </remarks>
        /// <param name="handle">The window handle.</param>
        /// <param name="screen">The screen coordinate.</param>
        /// <param name="client">The client coordinate.</param>
        /// <seealso cref="ClientToScreen(WindowHandle, Vector2, out Vector2)"/>
        /// <seealso cref="ClientToFramebuffer(WindowHandle, Vector2, out Vector2)"/>
        void ScreenToClient(WindowHandle handle, Vector2 screen, out Vector2 client);

        /// <summary>
        /// Converts window relative coordinates to screen coordinates.
        /// </summary>
        /// <remarks>
        /// On platforms that support non-integer screen and client space coordinates (macOS) this function will return full precision results,
        /// on integer based platforms (win32 and X11) the input coordinates will (if necessary) be truncated to ints before conversion.
        /// </remarks>
        /// <param name="handle">The window handle.</param>
        /// <param name="client">The client coordinate.</param>
        /// <param name="screen">The screen coordinate.</param>
        /// <seealso cref="ScreenToClient(WindowHandle, Vector2, out Vector2)"/>
        /// <seealso cref="ClientToFramebuffer(WindowHandle, Vector2, out Vector2)"/>
        void ClientToScreen(WindowHandle handle, Vector2 client, out Vector2 screen);

        /// <summary>
        /// Converts window relative coordinates to framebuffer coordinates.
        /// </summary>
        /// <remarks>
        /// On platforms that support non-integer screen and client space coordinates (macOS) this function will return full precision results,
        /// on integer based platforms (win32 and X11) the input coordinates will (if necessary) be truncated to ints before conversion.
        /// </remarks>
        /// <param name="handle">Handle of the window whose coordinate system to use.</param>
        /// <param name="client">The client coordinate.</param>
        /// <param name="framebuffer">The framebuffer coordinate.</param>
        /// <seealso cref="FramebufferToClient(WindowHandle, Vector2, out Vector2)"/>
        /// <seealso cref="ClientToScreen(WindowHandle, Vector2, out Vector2)"/>
        void ClientToFramebuffer(WindowHandle handle, Vector2 client, out Vector2 framebuffer);

        /// <summary>
        /// Converts framebuffer coordinates to framebuffer coordinates.
        /// </summary>
        /// <remarks>
        /// On platforms that support non-integer screen and client space coordinates (macOS) this function will return full precision results,
        /// on integer based platforms (win32 and X11) the input coordinates will (if necessary) be truncated to ints before conversion.
        /// </remarks>
        /// <param name="handle">Handle of the window whose coordinate system to use.</param>
        /// <param name="framebuffer">The framebuffer coordinate.</param>
        /// <param name="client">The client coordinate.</param>
        /// <seealso cref="ClientToFramebuffer(WindowHandle, Vector2, out Vector2)"/>
        /// <seealso cref="ClientToScreen(WindowHandle, Vector2, out Vector2)"/>
        void FramebufferToClient(WindowHandle handle, Vector2 framebuffer, out Vector2 client);

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
