using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for creating and interacting with modal dialogs.
    /// </summary>
    public interface IDialogComponent : IPalComponent
    {
        /// <summary>
        /// If the value of this property is true <see cref="OpenDialogOptions.SelectDirectory"/> and <see cref="OpenDialogOptions.SelectDirectory"/> will work.
        /// Otherwise these flags will be ignored.
        /// </summary>
        public bool CanTargetFolders { get; }

        /// <summary>
        /// Shows a modal message box.
        /// </summary>
        /// <param name="parent">The parent window for which this dialog is modal.</param>
        /// <param name="title">The title of the dialog box.</param>
        /// <param name="content">The content text of the dialog box.</param>
        /// <param name="messageBoxType">The type of message box. Determines button layout and default icon.</param>
        /// <param name="customIcon">An optional custom icon to use instead of the default one.</param>
        /// <returns>The pressed message box button.</returns>
        public MessageBoxButton ShowMessageBox(WindowHandle parent, string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null);

        // FIXME: Formalize the format for allowedExtensions so that we avoid being platform dependent.

        public unsafe List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options);

        // FIXME: Does a save dialog return multiple items?
        public unsafe string? ShowSaveDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options);
    }
}
