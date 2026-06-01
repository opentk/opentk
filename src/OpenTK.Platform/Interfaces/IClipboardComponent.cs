using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for drivers which provide the clipboard component of the platform abstraction layer.
    /// </summary>
    /// <seealso cref="Toolkit.Clipboard"/>
    public interface IClipboardComponent : IPalComponent
    {
        /// <summary>
        /// A list of formats that this clipboard component supports.
        /// </summary>
        /// <seealso cref="GetClipboardFormat"/>
        /// <seealso cref="ClipboardFormat"/>
        IReadOnlyList<ClipboardFormat> SupportedFormats { get; }

        /// <summary>
        /// Gets the format of the data currently in the clipboard.
        /// </summary>
        /// <returns>The format of the data currently in the clipboard.</returns>
        /// <seealso cref="ClipboardFormat"/>
        ClipboardFormat GetClipboardFormat();

        /// <summary>
        /// Sets the string currently in the clipboard.
        /// </summary>
        /// <param name="text">The text to write to the clipboard.</param>
        /// <seealso cref="GetClipboardFormat"/>
        void SetClipboardText(string text);

        /// <summary>
        /// Gets the string currently in the clipboard.
        /// This function returns <see langword="null"/> if the current clipboard data doesn't have the <see cref="ClipboardFormat.Text"/> format.
        /// </summary>
        /// <returns>The string currently in the clipboard, or <see langword="null"/>.</returns>
        /// <seealso cref="GetClipboardFormat"/>
        string? GetClipboardText();

        /// <summary>
        /// Gets the audio data currently in the clipboard.
        /// This function returns <see langword="null"/> if the current clipboard data doesn't have the <see cref="ClipboardFormat.Audio"/> format.
        /// </summary>
        /// <returns>The audio data currently in the clipboard, or <see langword="null"/>.</returns>
        /// <seealso cref="GetClipboardFormat"/>
        AudioData? GetClipboardAudio();

        /// <summary>
        /// Writes a bitmap to the clipboard.
        /// </summary>
        /// <remarks>
        /// On linux clipboard bitmaps are defacto transferred as PNG data, as such a PNG encoder/decoder is needed to read and write bitmaps from the clipboard.
        /// To enable this <see cref="Native.X11.X11ClipboardComponent.SetPngCodec(Native.X11.X11ClipboardComponent.IPngCodec?)"/> must be called with an object that implements the <see cref="Native.X11.X11ClipboardComponent.IPngCodec"/> interface.
        /// If this is not done, <see cref="SetClipboardBitmap(Bitmap)"/> and <see cref="GetClipboardBitmap"/> will both throw an exception.
        /// </remarks>
        /// <param name="bitmap">The bitmap to write to the clipboard.</param>
        /// <seealso cref="GetClipboardFormat"/>
        /// <seealso cref="Native.X11.X11ClipboardComponent.SetPngCodec(Native.X11.X11ClipboardComponent.IPngCodec?)"/>
        /// <seealso cref="Native.X11.X11ClipboardComponent.IPngCodec"/>
        // FIXME: What is the orientation of this image? Is it bottom up or top down?
        void SetClipboardBitmap(Bitmap bitmap);

        /// <summary>
        /// Gets the bitmap currently in the clipboard.
        /// This function returns <see langword="null"/> if the current clipboard data doesn't have the <see cref="ClipboardFormat.Bitmap"/> format.
        /// </summary>
        /// <remarks>
        /// On linux clipboard bitmaps are defacto transferred as PNG data, as such a PNG encoder/decoder is needed to read and write bitmaps from the clipboard.
        /// To enable this <see cref="Native.X11.X11ClipboardComponent.SetPngCodec(Native.X11.X11ClipboardComponent.IPngCodec?)"/> must be called with an object that implements the <see cref="Native.X11.X11ClipboardComponent.IPngCodec"/> interface.
        /// If this is not done, <see cref="SetClipboardBitmap(Bitmap)"/> and <see cref="GetClipboardBitmap"/> will both throw an exception.
        /// </remarks>
        /// <returns>The bitmap currently in the clipboard, or <see langword="null"/>.</returns>
        /// <seealso cref="GetClipboardFormat"/>
        /// <seealso cref="Native.X11.X11ClipboardComponent.SetPngCodec(Native.X11.X11ClipboardComponent.IPngCodec?)"/>
        /// <seealso cref="Native.X11.X11ClipboardComponent.IPngCodec"/>
        // FIXME: What is the orientation of this image? Is it bottom up or top down?
        Bitmap? GetClipboardBitmap();

        /// <summary>
        /// Gets a list of files and directories currently in the clipboard.
        /// This function returns <see langword="null"/> if the current clipboard data doesn't have the <see cref="ClipboardFormat.Files"/> format.
        /// </summary>
        /// <returns>The list of files and directories currently in the clipboard, or <see langword="null"/>.</returns>
        /// <seealso cref="GetClipboardFormat"/>
        List<string>? GetClipboardFiles();
    }
}
