using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Options for open dialogs.
    /// </summary>
    /// <seealso cref="Toolkit.Dialog"/>
    /// <seealso cref="IDialogComponent.ShowOpenDialog(WindowHandle, string, string, DialogFileFilter[], OpenDialogOptions)"/>
    [Flags]
    public enum OpenDialogOptions
    {
        /// <summary>
        /// Allows multiple items to be selected.
        /// </summary>
        AllowMultiSelect = 1 << 0,

        /// <summary>
        /// Select directories instead of files. Should only be specified if <see cref="IDialogComponent.CanTargetFolders"/> is <see langword="true"/>.
        /// </summary>
        /// <seealso cref="IDialogComponent.CanTargetFolders"/>
        // FIXME: Make selecting folder it's own function...
        SelectDirectory = 1 << 1,
    }
}
