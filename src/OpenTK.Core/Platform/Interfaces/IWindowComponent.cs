using System;
using System.Collections.Generic;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for abstraction layer drivers which implement the window component.
    /// </summary>
    public interface IWindowComponent : IPalComponent
    {
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
        /// Read-only list of event types the driver supports.
        /// </summary>
        IReadOnlyList<WindowEventType> SupportedEvents { get; }

        /// <summary>
        /// Read-only list of window styles the driver supports.
        /// </summary>
        IReadOnlyList<WindowStyle> SupportedStyles { get; }

        /// <summary>
        /// Read-only list of window modes the driver supports.
        /// </summary>
        IReadOnlyList<WindowMode> SupportedModes { get; }

        /// <summary>
        /// Create a window object.
        /// </summary>
        /// <param name="hints">Graphics API hints to be passed to the operating system.</param>
        /// <returns>Handle to the new window object.</returns>
        WindowHandle Create(GraphicsApiHints hints = null);

        /// <summary>
        /// Destroy a window object.
        /// </summary>
        /// <param name="handle">Handle to a window object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(WindowHandle handle);

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
        IconHandle GetIcon(WindowHandle handle);

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
        void SetMode(WindowHandle handle, WindowMode mode);

        /// <summary>
        /// Get the border style of a window.
        /// </summary>
        /// <param name="handle">Handle to window.</param>
        /// <returns>The border style of the window.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        WindowStyle GetBorderStyle(WindowHandle handle);

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
        void SetBorderStyle(WindowHandle handle, WindowStyle style);

        /// <summary>
        /// Set the cursor object for a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="cursor">Handle to a cursor object, or null for hidden cursor.</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="handle"/> or <paramref name="cursor"/> is null.
        /// </exception>
        /// <exception cref="PalNotImplementedException">
        ///     Driver does not support setting the window mouse cursor. See <see cref="CanSetCursor"/>.
        /// </exception>
        void SetCursor(WindowHandle handle, CursorHandle cursor);

        /// <summary>
        /// Get the event queue object for a window.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <returns>Event queue for the window.</returns>
        IEventQueue<WindowEventType, WindowEventArgs> GetEventQueue(WindowHandle handle);
    }
}
