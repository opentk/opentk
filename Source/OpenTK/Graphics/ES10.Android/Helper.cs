// Copyright 2013 Xamarin Inc

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.ES10
{
    /// <summary>
    /// Provides access to OpenGL ES 1.0 methods.
    /// </summary>
    public sealed partial class GL : GraphicsBindingsBase
    {
        public const string Library = "libGLESv1_CM.dll";
        static readonly object sync_root = new object();

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
