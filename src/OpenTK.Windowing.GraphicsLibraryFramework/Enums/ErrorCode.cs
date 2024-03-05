//
// ErrorCode.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Error codes, used in the error callback.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Everything is running as intended. Yay!
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Called a function before calling <see cref="GLFW.Init"/>. Initialize GLFW and then try again.
        /// </summary>
        NotInitialized = 0x00010001,

        /// <summary>
        /// No OpenGL/OpenGL ES context on this thread.
        /// </summary>
        NoContext = 0x00010002,

        /// <summary>
        /// Used an invalid enum value on a function.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This should hopefully never happen in the bindings, due to the added type safety of C# enums VS. GLFW's native #defines
        /// </para>
        /// </remarks>
        InvalidEnum = 0x00010003,

        /// <summary>
        /// Called a function with an invalid argument.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This can happen if you request an OpenGL version that doesn't exist, like 2.7.
        /// </para>
        /// <para>
        /// If you request a version of OpenGL that exists, but isn't supported by this graphics card, it will return VersionUnavailable instead.
        /// </para>
        /// </remarks>
        InvalidValue = 0x00010004,

        /// <summary>
        /// A memory allocation failed on GLFW's end.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Report this to the GLFW issue tracker if encountered.
        /// </para>
        /// </remarks>
        OutOfMemory = 0x00010005,

        /// <summary>
        /// The requested API is not available on the system.
        /// </summary>
        ApiUnavailable = 0x00010006,

        /// <summary>
        /// The requested OpenGL version is not available on the system.
        /// </summary>
        VersionUnavailable = 0x00010007,

        /// <summary>
        /// A platform-specific error occurred that doesn't fit into any more specific category.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Report this to the GLFW issue tracker if encountered.
        /// </para>
        /// </remarks>
        PlatformError = 0x00010008,

        /// <summary>
        /// The requested format is unavailable.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If emitted during window creation, the requested pixel format isn't available.
        /// </para>
        /// <para>
        /// If emitted when using the clipboard, the contents of the clipboard couldn't be converted to the requested format.
        /// </para>
        /// </remarks>
        FormatUnavailable = 0x00010009,

        /// <summary>
        /// There is no OpenGL/OpenGL ES context attached to this window.
        /// </summary>
        NoWindowContext = 0x0001000A,

        /// <summary>
        /// The specified standard cursor shape is not available, either because the
        /// current platform cursor theme does not provide it or because it is not
        /// available on the platform.
        ///
        /// Platform or system settings limitation.
        /// Pick another <see cref="CursorShape"/> or create a custom cursor.
        /// </summary>
        CursorUnavailable = 0x0001000B,

        /// <summary>
        /// The requested feature is not provided by the platform, so GLFW is unable to
        /// implement it.  The documentation for each function notes if it could emit
        /// this error.
        ///
        /// Platform or platform version limitation.  The error can be ignored
        /// unless the feature is critical to the application.
        ///
        /// <para>
        /// A function call that emits this error has no effect other than the error and
        /// updating any existing out parameters.
        /// </para>
        /// </summary>
        FeatureUnavailable = 0x0001000C,

        /// <summary>
        /// The requested feature has not yet been implemented in GLFW for this platform.
        ///
        /// An incomplete implementation of GLFW for this platform, hopefully
        /// fixed in a future release.  The error can be ignored unless the feature is
        /// critical to the application.
        ///
        /// <para>
        /// A function call that emits this error has no effect other than the error and
        /// updating any existing out parameters.
        /// </para>
        /// </summary>
        FeatureUnimplemented = 0x0001000D,

        /// <summary>
        /// If emitted during initialization, no matching platform was found.  If the
        /// <see cref="InitHintPlatform.Platform"/> init hint was set to <see cref="Platform.Any"/>,
        /// GLFW could not detect any of the platforms supported by this library binary,
        /// except for the Null platform.
        /// If the init hint was set to a specific platform, it is either not supported by this library
        /// binary or GLFW was not able to detect it.
        ///
        /// If emitted by a native access function, GLFW was initialized for a different platform
        /// than the function is for.
        ///
        /// Failure to detect any platform usually only happens on non-macOS Unix
        /// systems, either when no window system is running or the program was run from
        /// a terminal that does not have the necessary environment variables.  Fall back to
        /// a different platform if possible or notify the user that no usable platform was
        /// detected.
        ///
        /// Failure to detect a specific platform may have the same cause as above or be because
        /// support for that platform was not compiled in.  Call <see cref="GLFW.PlatformSupported"/> to
        /// check whether a specific platform is supported by a library binary.
        /// </summary>
        PlatformUnavailable = 0x0001000E,
    }
}
