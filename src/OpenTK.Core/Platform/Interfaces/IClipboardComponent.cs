﻿#nullable enable

using System.Collections.Generic;
using OpenTK.Core.Platform.Enums;

namespace OpenTK.Core.Platform.Interfaces
{
    /// <summary>
    /// Interface for drivers which provide the clipboard component of the platform abstraction layer.
    /// </summary>
    // GOAL: We want to support unicode text, rich text and images.
    public interface IClipboardComponent : IPalComponent
    {
        /// <summary>
        /// A list of formats that this clipboard component supports.
        /// </summary>
        IReadOnlyList<ClipboardFormat> SupportedFormats { get; }

        /// <summary>
        /// Gets the format of the data currently in the clipboard.
        /// </summary>
        /// <returns>The format of the data currently in the clipboard.</returns>
        ClipboardFormat GetClipboardFormat();

        /// <summary>
        /// Sets the string currently in the clipboard.
        /// </summary>
        /// <param name="text">The text to put on the clipboard.</param>
        void SetClipboardText(string text);

        /// <summary>
        /// Returns the string currently in the clipboard.
        /// This function returns null if the current clipboard data doesn't have the <see cref="ClipboardFormat.Text"/> format.
        /// </summary>
        /// <returns>The string currently in the clipboard, or null.</returns>
        string? GetClipboardText();

        /// <summary>
        /// Gets the audio data currently in the clipboard.
        /// This function returns null if the current clipboard data doesn't have the <see cref="ClipboardFormat.Audio"/> format.
        /// </summary>
        /// <returns>The audio data currently in the clipboard.</returns>
        AudioData? GetClipboardAudio();

        /// <summary>
        /// Gets the bitmap currently in the clipboard.
        /// This function returns null if the current clipboard data doesn't have the <see cref="ClipboardFormat.Bitmap"/> format.
        /// </summary>
        /// <returns>The bitmap currently in the clipboard.</returns>
        // FIXME: What is the orientation of this image? Is it bottom up or top down?
        Bitmap? GetClipboardBitmap();

        /// <summary>
        /// Gets the HTML string currently in the clipboard.
        /// This function returns null if the current clipboard data doesn't have the <see cref="ClipboardFormat.HTML"/> format.
        /// </summary>
        /// <returns>The HTML string currently in the clipboard.</returns>
        // FIXME: Make more formal what the expected result of this is
        string? GetClipboardHTML();

        /// <summary>
        /// Gets a list of files and directories currently in the clipboard.
        /// This function returns null if the current clipboard data doesn't have the <see cref="ClipboardFormat.Files"/> format.
        /// </summary>
        /// <returns>The list of files and directories currently in the clipboard.</returns>
        List<string>? GetClipboardFiles();
    }
}
