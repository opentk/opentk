using System;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>

    public sealed partial class GL : GraphicsBindingsBase
    {
#if IPHONE
        const string Library = "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";
#else
        private const string Library = "GLESv1_CM";
#endif
        private static readonly object sync_root = new object();

        private static IntPtr[] EntryPoints;
        private static byte[] EntryPointNames;
        private static int[] EntryPointNameOffsets;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

    }
}
