// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the version information of a GraphicsContext.
    /// </summary>
    public sealed class GraphicsContextVersion
    {
        #region Fields

        int minor, major;
        string vendor = String.Empty, renderer = String.Empty;

        #endregion

        #region Constructors

        internal GraphicsContextVersion(int minor, int major, string vendor, string renderer)
        {
            Minor = minor;
            Major = major;
            Vendor = vendor;
            Renderer = renderer;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Int32 indicating the minor version of a GraphicsContext instance.
        /// </summary>
        public int Minor { get { return minor; } private set { minor = value; } }

        /// <summary>
        /// Gets a System.Int32 indicating the major version of a GraphicsContext instance.
        /// </summary>
        public int Major { get { return major; } private set { major = value; } }

        /// <summary>
        /// Gets a System.String indicating the vendor of a GraphicsContext instance.
        /// </summary>
        public string Vendor { get { return vendor; } private set { vendor = value; } }

        /// <summary>
        /// Gets a System.String indicating the renderer of a GraphicsContext instance.
        /// </summary>
        public string Renderer { get { return renderer; } private set { renderer = value; } }

        #endregion
    }
}
