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
    [Obsolete("Use OpenTK.Platform.IWindowInfo instead.")]
    public interface IWindowInfoOld
    {
        IntPtr Handle { get; }
        IWindowInfoOld Parent { get; }
        IWindowInfoOld GetInfoFrom(System.Windows.Forms.Control control);
        IWindowInfoOld GetInfoFrom(System.Windows.Forms.NativeWindow window);
        IWindowInfoOld GetInfoFrom(OpenTK.GameWindow window);
        IWindowInfoOld GetInfoFrom(IWindowInfoOld info);
    }
}
