#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides a platform independent mechanism to interact with System.Windows.Forms.Control,
    /// System.Windows.Forms.NativeWindow and OpenTK.GameWindow low-level implementation data.
    /// </summary>
    public interface IWindowInfo
    {
        IntPtr Handle { get; }
        IWindowInfo Parent { get; }
        IWindowInfo GetInfoFrom(System.Windows.Forms.Control control);
        IWindowInfo GetInfoFrom(System.Windows.Forms.NativeWindow window);
        IWindowInfo GetInfoFrom(OpenTK.GameWindow window);
        IWindowInfo GetInfoFrom(IWindowInfo info);
    }
}
