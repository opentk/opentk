// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
n.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>Describes an OS window.</summary>
    public interface IWindowInfo : IDisposable
    {
        /// <summary>
        /// Retrieves a platform-specific handle to this window.
        /// </summary>
        IntPtr Handle { get; }
    }
}
