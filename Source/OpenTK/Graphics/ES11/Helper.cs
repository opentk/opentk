// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>

    public sealed partial class GL : GraphicsBindingsBase
    {
        const string Library = "GLESv1_CM";
        static readonly object sync_root = new object();

        static IntPtr[] EntryPoints;
        static byte[] EntryPointNames;
        static int[] EntryPointNameOffsets;

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        #endregion

    }
}
