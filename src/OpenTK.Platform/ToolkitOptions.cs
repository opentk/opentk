using OpenTK.Core.Utility;
using System;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Flags for optional features.
    /// </summary>
    [Flags]
    public enum ToolkitFlags
    {
        /// <summary>
        /// No flags are enabled.
        /// </summary>
        None = 0,

        /// <summary>
        /// If <see cref="Toolkit.OpenGL"/> should be initialized.
        /// Without this flag accessing <see cref="Toolkit.OpenGL"/> will result in an error.
        /// </summary>
        EnableOpenGL = 1 << 0,

        /// <summary>
        /// If <see cref="Toolkit.Vulkan"/> should be initialized.
        /// Without this flag accessing <see cref="Toolkit.Vulkan"/> will result in an error.
        /// </summary>
        EnableVulkan = 1 << 1,

        /// <summary>
        /// If <see cref="Toolkit.OpenGL"/> should perfer the ANGLE EGL component implementation <see cref="Native.ANGLE.ANGLEOpenGLComponent"/>.
        /// This allows for the creation of OpenGL ES contexts.
        /// </summary>
        /// <seealso cref="Native.ANGLE.ANGLEOpenGLComponent"/>
        PreferANGLE = 1 << 2,
    }

    /// <summary>
    /// Options used to initialize OpenTK with.
    /// </summary>
    /// <see cref="Toolkit.Init(ToolkitOptions)"/>
    public sealed class ToolkitOptions
    {
        /// <summary>
        /// The application name.
        /// </summary>
        public string ApplicationName { get; set; } = "OpenTK Application";

        /// <summary>
        /// The logger to send diagnostic messages (including warnings and errors) to.
        /// Log info can be useful to understand what might be going wrong if something isn't working.
        /// It's also useful to debug OpenTK.
        /// </summary>
        public ILogger? Logger { get; set; } = new ConsoleLogger();

        /// <summary>
        /// The optional features to enable.
        /// Most notably this includes <see cref="ToolkitFlags.EnableOpenGL"/> and <see cref="ToolkitFlags.EnableVulkan"/> for enabling OpenGL and Vulkan respectively.
        /// </summary>
        public ToolkitFlags FeatureFlags = ToolkitFlags.EnableOpenGL | ToolkitFlags.EnableVulkan;

        // FIXME: Add additional settings such as PreferSDL and PreferANGLE here...

        /// <summary>
        /// Windows backend specific options.
        /// </summary>
        public WindowsOptions Windows { get; set; } = new WindowsOptions();

        /// <summary>
        /// X11 backend specific options.
        /// </summary>
        public X11Options X11 { get; set; } = new X11Options();

        /// <summary>
        /// macOS backend specific options.
        /// </summary>
        public MacOSOptions MacOS { get; set; } = new MacOSOptions();

        /// <summary>
        /// Windows backend specific options.
        /// </summary>
        public sealed class WindowsOptions
        {
            /// <summary>
            /// If visual styles should be enabled or not.
            /// OpenTK requires visual styles to be enabled for <see cref="IDialogComponent.ShowMessageBox(WindowHandle, string, string, MessageBoxType, IconHandle?)"/> to work on windows.
            /// Visual styles can either be enabled by OpenTK by leaving this propery as <see langword="true"/> alternatively
            /// it can be enabled using a manifest that declares a depedency on Microsoft.Windows.Common-Controls (6.0.0.0).
            /// This property is set to <see langword="true"/> by default, but can be disabled through this option.
            /// </summary>
            public bool EnableVisualStyles { get; set; } = true;

            /// <summary>
            /// Whether OpenTK should mark the process as "DPI aware".
            /// Defaults to <see langword="true"/>.
            /// </summary>
            public bool IsDPIAware { get; set; } = true;

            /// <summary>
            /// The maximum number of raw input messages to process per call to <see cref="IWindowComponent.ProcessEvents(bool)"/>.
            /// Negative values remove this limit.
            /// Defaults to 5.
            /// </summary>
            public int MaxRawInputsPerFrame { get; set; } = 5;
        }

        /// <summary>
        /// X11 backend specific options.
        /// </summary>
        public sealed class X11Options
        {
        }

        /// <summary>
        /// macOS backend specific options.
        /// </summary>
        public sealed class MacOSOptions
        {
            /// <summary>
            /// Makes this app active when calling <see cref="Toolkit.Init(ToolkitOptions)"/>.
            /// This removes focus from other applications which might be what you want for games
            /// but for applications with only hidden windows, or tools this is not the expected behaviour.
            /// Defaults to <see langword="true"/>.
            /// </summary> 
            public bool ActiveAppOnStart { get; set; } = true;
        }
    }
}
