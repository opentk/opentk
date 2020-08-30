using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>

    public sealed partial class GL : BindingsBase
    {
#if IPHONE
        private const string Library = "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";
#else
        private const string Library = "GLESv1_CM";
#endif

        private static IntPtr[] EntryPoints;
        private static string[] EntryPointNames;

        /// <summary>
        /// Loads all the available bindings for the current context.
        /// </summary>
        /// <param name="context">The context used to query the available bindings.</param>
        /// <remarks>
        /// Loads all available entry points for the current OpenGL context.
        /// </remarks>
        public static void LoadBindings(IBindingsContext context)
        {
            Debug.Print("Loading entry points for {0}", typeof(GL).FullName);

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            for (int i = 0; i < EntryPoints.Length; i++)
            {
                EntryPoints[i] = context.GetProcAddress(EntryPointNames[i]);
            }
        }
    }

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProc(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Khr.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcKhr(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);
}
