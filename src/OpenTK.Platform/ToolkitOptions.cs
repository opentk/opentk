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
        }

        /// <summary>
        /// X11 backend specific options.
        /// </summary>
        public sealed class X11Options
        {
            /// <summary>
            /// VSCode leaks a bunch of envrionment variables that mess with dynamic library resolution.
            /// If the environment variable <c>SNAP_NAME</c> is set to <c>code</c> and this variable is set to true,
            /// we will remove a bunch of environment variables that vscode leaks into the C# process.
            /// This means that if you want to set these variables yourself while running if VSCode 
            /// for whatever reason then you need to disable this.
            /// Defaults to <see langword="true"/>.
            /// </summary>
            /// <remarks>
            /// Specifically all variables that have a <c>_VSCODE_SNAP_ORIG</c> version will be reset to their original values.
            /// But additionally the following environment variables will be removed:
            /// <list type="bullet">
            /// <item><c>GTK_PATH</c></item>
            /// <item><c>GIO_MODULE_DIR</c></item>
            /// <item><c>GTK_EXE_PREFIX</c></item>
            /// <item><c>GIO_LAUNCHED_DESKTOP_FILE</c></item>
            /// <item><c>GIO_LAUNCHED_DESKTOP_FILE_PID</c></item>
            /// <item><c>GTK_IM_MODULE_FILE</c></item>
            /// <item><c>GDK_PIXBUF_MODULEDIR</c></item>
            /// <item><c>GDK_PIXBUF_MODULE_FILE</c></item>
            /// <item><c>GSETTINGS_SCHEMA_DIR</c></item>
            /// <item><c>XDG_DATA_HOME</c></item>
            /// </list>
            /// After <see cref="Toolkit.Uninit"/> these environment variables will be reset to their original values.
            /// <para>
            /// If this setting ever bites you, I'm sorry.
            /// </para>
            /// </remarks>
            public bool DealWithVSCodeEnvironmentVariablePollution { get; set; } = true;

            /// <summary>
            /// If this option is set to true, the custom dll resolver used to load native dependencies
            /// will print out to the <see cref="ToolkitOptions.Logger"/> debug information about exact
            /// paths for loaded <c>.so</c> files. Can be useful when debugging library resolution issues.
            /// </summary>
            public bool PrintLibraryPathResolutionDebug { get; set; } = false;
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
