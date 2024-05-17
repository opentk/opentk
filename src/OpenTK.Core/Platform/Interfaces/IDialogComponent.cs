using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Core.Platform
{
    public interface IDialogComponent : IPalComponent
    {
        /// <summary>
        /// If the value of this property is true <see cref="OpenDialogOptions.SelectDirectory"/> and <see cref="OpenDialogOptions.SelectDirectory"/> will work.
        /// Otherwise these flags will be ignored.
        /// </summary>
        public bool CanTargetFolders { get; }

        // FIXME: Formalize the format for allowedExtensions so that we avoid being platform dependent.

        public unsafe List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, (string Name, string Ext)[]? allowedExtensions, OpenDialogOptions options);

        // FIXME: Does a save dialog return multiple items?
        public unsafe string? ShowSaveDialog(WindowHandle parent, string title, string directory, (string Name, string Ext)[]? allowedExtensions, SaveDialogOptions options);
    }
}
