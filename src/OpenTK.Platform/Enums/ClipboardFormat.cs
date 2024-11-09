using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Represents a clipboard data format.
    /// </summary>
    /// <seealso cref="IClipboardComponent.GetClipboardFormat"/>
    public enum ClipboardFormat
    {
        /// <summary>
        /// Unknown format, or the clipboard is empty.
        /// </summary>
        None = 0,

        /// <summary>
        /// Unicode text.
        /// </summary>
        /// <seealso cref="IClipboardComponent.GetClipboardText"/>
        /// <seealso cref="IClipboardComponent.SetClipboardText"/>
        Text = 1,

        /// <summary>
        /// Audio data. See <see cref="OpenTK.Platform.AudioData"/>.
        /// </summary>
        /// <seealso cref="IClipboardComponent.GetClipboardAudio"/>
        Audio = 2,

        /// <summary>
        /// A bitmap. See <see cref="OpenTK.Platform.Bitmap"/>.
        /// </summary>
        /// <seealso cref="IClipboardComponent.GetClipboardBitmap"/>
        /// <seealso cref="IClipboardComponent.SetClipboardBitmap"/>
        Bitmap = 3,

        /// <summary>
        /// A list of files and directories.
        /// </summary>
        /// <seealso cref="IClipboardComponent.GetClipboardFiles"/>
        Files = 5,
    }
}
