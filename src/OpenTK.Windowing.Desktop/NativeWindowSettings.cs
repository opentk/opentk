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

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// <see cref="NativeWindow"/> related settings.
    /// </summary>
    public class NativeWindowSettings
    {
        /// <summary>
        /// Gets the default settings for a <see cref="NativeWindow"/>.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeWindowSettings"/> class.
        /// </summary>
        public NativeWindowSettings()
        {
            unsafe
            {
                GLFWProvider.EnsureInitialized();
                CurrentMonitor = new MonitorHandle((IntPtr)GLFW.GetPrimaryMonitor());
            }
        }

        /// <summary>
        /// Gets or sets the context to share.
        /// </summary>
        public IGLFWGraphicsContext SharedContext { get; set; }

        /// <summary>
        /// Gets or sets the current <see cref="WindowIcon" /> for this window.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This does nothing on macOS; on that platform, the icon is determined by the application bundle.
        /// </para>
        /// </remarks>
        public WindowIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this window is event-driven.
        /// An event-driven window will wait for events before updating/rendering. It is useful for non-game applications,
        /// where the program only needs to do any processing after the user inputs something.
        /// </summary>
        public bool IsEventDriven { get; set; } = false;

        /// <summary>
        /// Gets or sets a value representing the current graphics API.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If this is changed, you'll have to modify the API version as well, as the versioning of OpenGL and OpenGL ES
        /// do not match.
        /// </para>
        /// </remarks>
        public ContextAPI API { get; set; } = ContextAPI.OpenGL;

        /// <summary>
        /// Gets or sets a value representing the current graphics API profile.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This only has an effect on OpenGL 3.2 and higher. On older versions, this setting does nothing.
        /// </para>
        /// </remarks>
        public ContextProfile Profile { get; set; } = ContextProfile.Core;

        /// <summary>
        /// Gets or sets a value representing the current graphics profile flags.
        /// Default value is <see cref="ContextFlags.ForwardCompatible"/> to work out of the box on macos.
        /// </summary>
        public ContextFlags Flags { get; set; } = ContextFlags.ForwardCompatible;

        /// <summary>
        /// Gets or sets a value indicating whether or not OpenGL bindings should be automatically loaded
        /// when the window is created.
        /// </summary>
        public bool AutoLoadBindings { get; set; } = true;

        /// <summary>
        /// Gets or sets a value representing the current version of the graphics API.
        /// </summary>
        /// <remarks>
        /// <para>
        /// OpenGL 3.3 is selected by default, and runs on almost any hardware made within the last ten years.
        /// This will run on Windows, Mac OS, and Linux.
        /// </para>
        /// <para>
        /// OpenGL 4.1 is suggested for modern apps meant to run on more modern hardware.
        /// This will run on Windows, Mac OS, and Linux.
        /// </para>
        /// <para>
        /// OpenGL 4.6 is suggested for modern apps that only intend to run on Windows and Linux;
        /// Mac OS doesn't support it.
        /// </para>
        /// <para>
        /// Note that if you choose an API other than base OpenGL, this will need to be updated accordingly,
        /// as the versioning of OpenGL and OpenGL ES do not match.
        /// </para>
        /// </remarks>
        public Version APIVersion { get; set; } = new Version(3, 3);

        /// <summary>
        /// Gets or sets the monitor to open the new window on.
        /// </summary>
        public MonitorHandle CurrentMonitor { get; set; }

        /// <summary>
        /// Gets or sets the title of the new window.
        /// </summary>
        public string Title { get; set; } = "OpenTK Window";

        /// <summary>
        /// Gets or sets a value indicating whether this window should start with focus when created.
        /// </summary>
        public bool StartFocused { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the new window should start visible.
        /// </summary>
        public bool StartVisible { get; set; } = true;

        /// <summary>
        ///     Gets or sets the initial value for <see cref="NativeWindow.WindowState"/> on the new window.
        ///     This setting is ignored if <c><see cref="StartVisible"/> = false</c>.
        /// </summary>
        public WindowState WindowState { get; set; } = WindowState.Normal;

        /// <summary>
        ///     Gets or sets the initial value for <see cref="NativeWindow.WindowBorder"/> on the new window.
        /// </summary>
        public WindowBorder WindowBorder { get; set; } = WindowBorder.Resizable;

        /// <summary>
        /// Gets or sets the location to open the new window on.
        /// </summary>
        /// <remarks>
        /// If null, the window will be placed by the OS.
        /// </remarks>
        public Vector2i? Location { get; set; }

        /// <summary>
        ///     Gets or sets the initial size of the contents of the window.
        /// </summary>
        public Vector2i ClientSize { get; set; } = new Vector2i(640, 360);

        /// <summary>
        ///     Gets or sets the minimum size of the contents of the window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the minimum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        public Vector2i? MinimumClientSize { get; set; } = null;

        /// <summary>
        ///     Gets or sets the maximum size of the contents of the window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the minimum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        public Vector2i? MaximumClientSize { get; set; } = null;

        /// <summary>
        ///     Gets or sets the initial size of the contents of the window.
        /// </summary>
        [Obsolete("Use the " + nameof(ClientSize) + " property to get or set the initial size of the contents of the window.")]
        public Vector2i Size
        {
            get => ClientSize;
            set { ClientSize = value; }
        }

        /// <summary>
        ///     Gets or sets the minimum size of the contents of the window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the minimum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        [Obsolete("Use the " + nameof(MinimumClientSize) + " property to get or set the minimum size of the contents of the window.")]
        public Vector2i? MinimumSize
        {
            get => MinimumClientSize;
            set { MinimumClientSize = value; }
        }

        /// <summary>
        ///     Gets or sets the maximum size of the contents of the window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the minimum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        [Obsolete("Use the " + nameof(MaximumClientSize) + " property to get or set the minimum size of the contents of the window.")]
        public Vector2i? MaximumSize
        {
            get => MaximumClientSize;
            set { MaximumClientSize = value; }
        }

        /// <summary>
        /// Gets or sets the aspect ratio the window is locked to until changed.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to disable aspect ratio locking.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        public (int numerator, int denominator)? AspectRatio { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether the window should start fullscreen.
        /// </summary>
        [Obsolete("Use WindowState instead.", true)]
        public bool IsFullscreen { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating the number of samples that should be used.
        /// </summary>
        /// <remarks>
        /// <c>0</c> indicates that no multisampling should be used;
        /// otherwise multisampling is used if available. The actual number of samples is the closest matching the given number that is supported.
        /// </remarks>
        public int NumberOfSamples { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of stencil bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 8.
        /// </remarks>
        public int? StencilBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of depth bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 24.
        /// </remarks>
        public int? DepthBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of red bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 8.
        /// </remarks>
        public int? RedBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of green bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 8.
        /// </remarks>
        public int? GreenBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of blue bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 8.
        /// </remarks>
        public int? BlueBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of alpha bits used for OpenGL context creation.
        /// </summary>
        /// <remarks>
        /// Default value is 8.
        /// </remarks>
        public int? AlphaBits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the backbuffer should be sRGB capable.
        /// </summary>
        public bool SrgbCapable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the framebuffer should be transparent or not.
        /// <c>null</c> and <c>false</c> does not result in a transparent framebuffer while <c>true</c> will result in a transparent framebuffer.
        /// </summary>
        public bool? TransparentFramebuffer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the vsync mode to use.
        /// A pure NativeWindow supports <see cref="VSyncMode.Off"/> and <see cref="VSyncMode.On"/>.
        /// <see cref="GameWindow"/> adds support for <see cref="VSyncMode.Adaptive"/>,
        /// if you are not using <see cref="GameWindow"/> you will have to handle adaptive vsync yourself.
        /// </summary>
        public VSyncMode Vsync { get; set; } = VSyncMode.Off;

        /// <summary>
        /// Gets or sets a value indicating whether the application window will be minimized if the
        /// focus changes while the window is in fullscreen mode. The default value is <c>true</c>.
        /// </summary>
        public bool AutoIconify { get; set; } = true;
    }
}
