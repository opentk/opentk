//
// NativeWindowSettings.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Common.Input;
using OpenTK.Windowing.GraphicsLibraryFramework;
using Monitor = OpenTK.Windowing.Common.Monitor;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    ///     <see cref="NativeWindow" /> related settings.
    /// </summary>
    public class NativeWindowSettings
    {
        /// <summary>
        ///     Gets the default settings for a <see cref="NativeWindow" />.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();

        /// <summary>
        ///     Initializes a new instance of the <see cref="NativeWindowSettings" /> class.
        /// </summary>
        public NativeWindowSettings()
        {
            unsafe
            {
                GLFWProvider.EnsureInitialized();
                CurrentMonitor = new Monitor((IntPtr)GLFW.GetPrimaryMonitor());
            }
        }

        /// <summary>
        ///     Gets or sets the context to share.
        /// </summary>
        public IGLFWGraphicsContext SharedContext { get; set; }

        /// <summary>
        ///     Gets or sets the current <see cref="WindowIcon" /> for this window.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This does nothing on macOS; on that platform, the icon is determined by the application bundle.
        ///     </para>
        /// </remarks>
        public WindowIcon Icon { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether or not this window is event-driven.
        ///     An event-driven window will wait for events before updating/rendering. It is useful for non-game applications,
        ///     where the program only needs to do any processing after the user inputs something.
        /// </summary>
        public bool IsEventDriven { get; set; } = false;

        /// <summary>
        ///     Gets or sets a value representing the current graphics API.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         If this is changed, you'll have to modify the API version as well, as the versioning of OpenGL and OpenGL ES
        ///         do not match.
        ///     </para>
        /// </remarks>
        public ContextAPI API { get; set; } = ContextAPI.OpenGL;

        /// <summary>
        ///     Gets or sets a value representing the current graphics API profile.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         This only has an effect on OpenGL 3.2 and higher. On older versions, this setting does nothing.
        ///     </para>
        /// </remarks>
        public ContextProfile Profile { get; set; } = ContextProfile.Core;

        /// <summary>
        ///     Gets or sets a value representing the current graphics profile flags.
        /// </summary>
        public ContextFlags Flags { get; set; } = ContextFlags.Default;

        /// <summary>
        ///     Gets or sets a value indicating whether or not OpenGL bindings should be automatically loaded
        ///     when the window is created.
        /// </summary>
        public bool AutoLoadBindings { get; set; } = true;

        /// <summary>
        ///     Gets or sets a value representing the current version of the graphics API.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         OpenGL 3.3 is selected by default, and runs on almost any hardware made within the last ten years.
        ///         This will run on Windows, Mac OS, and Linux.
        ///     </para>
        ///     <para>
        ///         OpenGL 4.1 is suggested for modern apps meant to run on more modern hardware.
        ///         This will run on Windows, Mac OS, and Linux.
        ///     </para>
        ///     <para>
        ///         OpenGL 4.6 is suggested for modern apps that only intend to run on Windows and Linux;
        ///         Mac OS doesn't support it.
        ///     </para>
        ///     <para>
        ///         Note that if you choose an API other than base OpenGL, this will need to be updated accordingly,
        ///         as the versioning of OpenGL and OpenGL ES do not match.
        ///     </para>
        /// </remarks>
        public Version APIVersion { get; set; } = new Version(3, 3);

        /// <summary>
        ///     Gets or sets the monitor to open the new window on.
        /// </summary>
        public Monitor CurrentMonitor { get; set; }

        /// <summary>
        ///     Gets or sets the title of the new window.
        /// </summary>
        public string Title { get; set; } = "OpenTK Window";

        /// <summary>
        ///     Gets or sets a value indicating whether this window should start with focus when created.
        /// </summary>
        public bool StartFocused { get; set; } = true;

        /// <summary>
        ///     Gets or sets a value indicating whether the new window should start visible.
        /// </summary>
        public bool StartVisible { get; set; } = true;

        /// <summary>
        ///     Gets or sets the initial value for <see cref="INativeWindow.WindowState" /> on the new window.
        /// </summary>
        public WindowState WindowState { get; set; } = WindowState.Normal;

        /// <summary>
        ///     Gets or sets the initial value for <see cref="INativeWindow.WindowBorder" /> on the new window.
        /// </summary>
        public WindowBorder WindowBorder { get; set; } = WindowBorder.Resizable;

        /// <summary>
        ///     Gets or sets the location to open the new window on.
        /// </summary>
        /// <remarks>
        ///     If null, the window will be placed by the OS.
        /// </remarks>
        public Vector2i? Location { get; set; }

        /// <summary>
        ///     Gets or sets the initial size of the contents of the window.
        /// </summary>
        public Vector2i Size { get; set; } = new Vector2i(640, 360);

        /// <summary>
        ///     Gets or sets a value indicating whether the window should start fullscreen.
        /// </summary>
        public bool IsFullscreen { get; set; } = false;

        /// <summary>
        ///     Gets or sets a value indicating the number of samples that should be used.
        /// </summary>
        /// <remarks>
        ///     <c>0</c> indicates that no multisampling should be used;
        ///     otherwise multisampling is used if available. The actual number of samples is the closest matching the given number that is supported.
        /// </remarks>
        public int NumberOfSamples { get; set; }
    }
}
