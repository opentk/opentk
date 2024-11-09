using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for creating and interacting with modal dialogs.
    /// </summary>
    /// <seealso cref="Toolkit.Dialog"/>
    public interface IDialogComponent : IPalComponent
    {
        /// <summary>
        /// If the value of this property is true <see cref="OpenDialogOptions.SelectDirectory"/> will work.
        /// Otherwise this flag will be ignored.
        /// </summary>
        /// <seealso cref="Toolkit.Dialog"/>
        /// <seealso cref="OpenDialogOptions.SelectDirectory"/>
        /// <seealso cref="ShowOpenDialog(WindowHandle, string, string, DialogFileFilter[], OpenDialogOptions)"/>
        public bool CanTargetFolders { get; }

        /// <summary>
        /// Shows a modal message box.
        /// </summary>
        /// <remarks>
        /// This function runs a modal event loop and will only return once the dialog has been dissmissed by pressing any of it's buttons.
        /// </remarks>
        /// <param name="parent">The parent window for which this dialog is modal.</param>
        /// <param name="title">The title of the dialog box.</param>
        /// <param name="content">The content text of the dialog box. This is the prompt to the user, explain what they should do.</param>
        /// <param name="messageBoxType">The type of message box. Determines button layout and default icon.</param>
        /// <param name="customIcon">An optional custom icon to use instead of the default one.</param>
        /// <returns>The pressed message box button.</returns>
        /// <seealso cref="MessageBoxType"/>
        /// <seealso cref="MessageBoxButton"/>
        /// <seealso cref="Toolkit.Icon"/>
        /// <seealso cref="IIconComponent"/>
        public MessageBoxButton ShowMessageBox(WindowHandle parent, string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null);

        /// <summary>
        /// Shows a modal "open file/folder" dialog.
        /// </summary>
        /// <remarks>
        /// This function runs a modal event loop and will only return once the dialog has been dissmissed by pressing any of it's buttons.
        /// </remarks>
        /// <param name="parent">The parent window handle for which this dialog will be modal.</param>
        /// <param name="title">The title of the dialog.</param>
        /// <param name="directory">The start directory of the file dialog.</param>
        /// <param name="allowedExtensions">A list of file filters that filter valid files to open. See <see cref="DialogFileFilter"/> for more info.</param>
        /// <param name="options">Additional options for the file dialog (e.g. <see cref="OpenDialogOptions.AllowMultiSelect"/> for allowing multiple files to be selected.)</param>
        /// <returns>
        /// A list of selected files or <see langword="null"/> if no files where selected.
        /// If <see cref="OpenDialogOptions.AllowMultiSelect"/> is not specified the list will only contain a single element.
        /// </returns>
        /// <seealso cref="DialogFileFilter"/>
        /// <seealso cref="OpenDialogOptions"/>
        /// <seealso cref="ShowSaveDialog(WindowHandle, string, string, DialogFileFilter[], SaveDialogOptions)"/>
        /// <seealso cref="CanTargetFolders"/>
        public unsafe List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options);

        /// <summary>
        /// Shows a modal "save file" dialog.
        /// </summary>
        /// <remarks>
        /// This function runs a modal event loop and will only return once the dialog has been dissmissed by pressing any of it's buttons.
        /// </remarks>
        /// <param name="parent">The parent window handle for which this dialog will be modal.</param>
        /// <param name="title">The title of the dialog.</param>
        /// <param name="directory">The starting directory of the file dialog.</param>
        /// <param name="allowedExtensions">A list of file filters that filter valid file extensions to save as. See <see cref="DialogFileFilter"/> for more info.</param>
        /// <param name="options">Additional options for the file dialog.</param>
        /// <returns>The path to the selected save file, or <see langword="null"/> if no file was selected.</returns>
        /// <seealso cref="DialogFileFilter"/>
        /// <seealso cref="SaveDialogOptions"/>
        public unsafe string? ShowSaveDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options);
    }
}
