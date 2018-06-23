using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES10
{
    /// <summary>
    /// Provides access to OpenGL ES 1.0 methods.
    /// </summary>
    public sealed partial class GL : GraphicsBindingsBase
    {
        private const string Library = "libGLES.dll";

        private static readonly IntPtr[] EntryPoints;
        private static readonly byte[] EntryPointNames;
        private static readonly int[] EntryPointNameOffsets;

        private static readonly object InternalSyncRoot = new object();

        /// <summary>
        /// Gets a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot => InternalSyncRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="GL"/> class.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        /// <summary>
        /// Defines the signature of a debug callback for
        ///  <see cref="GL.DebugMessageCallback" />.
        /// </summary>
        /// <param name="source">The <see cref="DebugSource" /> for this debug message.</param>
        /// <param name="type">The <see cref="DebugType" /> for this debug message.</param>
        /// <param name="id">The id of this debug message.</param>
        /// <param name="severity">The <see cref="DebugSeverity" /> for this debug message.</param>
        /// <param name="length">The length of this debug message.</param>
        /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
        /// <param name="userParam">A pointer to a user-specified parameter.</param>
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void DebugProc
        (
            DebugSource source,
            DebugType type,
            int id,
            DebugSeverity severity,
            int length,
            IntPtr message,
            IntPtr userParam
        );

        /// <summary>
        /// Defines the signature of a debug callback for <see cref="GL.Khr.DebugMessageCallback" />.
        /// </summary>
        /// <param name="source">The <see cref="DebugSource" /> for this debug message.</param>
        /// <param name="type">The <see cref="DebugType" /> for this debug message.</param>
        /// <param name="id">The id of this debug message.</param>
        /// <param name="severity">The <see cref="DebugSeverity" /> for this debug message.</param>
        /// <param name="length">The length of this debug message.</param>
        /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
        /// <param name="userParam">A pointer to a user-specified parameter.</param>
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void DebugProcKhr
        (
            DebugSource source,
            DebugType type,
            int id,
            DebugSeverity severity,
            int length,
            IntPtr message,
            IntPtr userParam
        );
    }
}
