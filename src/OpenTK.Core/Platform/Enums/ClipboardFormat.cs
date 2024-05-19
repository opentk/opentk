using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Represents a clipboard data format.
    /// </summary>
    public enum ClipboardFormat
    {
        /// <summary>
        /// Unknown format, or the clipboard is empty.
        /// </summary>
        None = 0,

        /// <summary>
        /// Unicode text.
        /// </summary>
        Text = 1,

        /// <summary>
        /// Audio data. See <see cref="OpenTK.Core.Platform.AudioData"/>.
        /// </summary>
        Audio = 2,

        /// <summary>
        /// A bitmap. See <see cref="OpenTK.Core.Platform.Bitmap"/>.
        /// </summary>
        Bitmap = 3,

        /// <summary>
        /// HTML data.
        /// If the clipboard contains this format,
        /// it is also possible to get the unformated string using <see cref="IClipboardComponent.GetClipboardText"/>.
        /// </summary>
        HTML = 4,

        /// <summary>
        /// A list of files and directories.
        /// </summary>
        Files = 5,
    }
}
