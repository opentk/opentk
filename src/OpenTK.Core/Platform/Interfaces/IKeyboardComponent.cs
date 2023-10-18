using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;

namespace OpenTK.Core.Platform.Interfaces
{
#nullable enable

    /// <summary>
    /// PAL driver for global keyboard information.
    /// </summary>
    public interface IKeyboardComponent : IPalComponent
    {
        // FIXME: API for getting the current input language

        // FIXME: Separation for keyboard layout name and keyboard layout display name??

        /// <summary>
        /// True if the driver supports keyboard layout functions.
        /// </summary>
        bool SupportsLayouts { get; }

        /// <summary>
        /// True if the driver supports input method editor functions.
        /// </summary>
        bool SupportsIme { get; }

        /// <summary>
        /// Get the active keyboard layout.
        /// </summary>
        /// <param name="handle">(optional) Handle to a window to query the layout for. Ignored on systems where keyboard layout is global.</param>
        /// <returns>A string which describes the active keyboard layout.</returns>
        /// <exception cref="PalNotImplementedException">Driver cannot query active keyboard layout.</exception>
        string GetActiveKeyboardLayout(WindowHandle? handle);

        /// <summary>
        /// See list of possible keyboard layouts for this system.
        /// </summary>
        /// <returns>Array containing possible keyboard layouts.</returns>
        string[] GetAvailableKeyboardLayouts();

        /// <summary>
        /// Gets the <see cref="Scancode"/> associated with the specified <see cref="Key"/>.
        /// The Key to Scancode mapping is not 1 to 1, multiple scancodes can produce the same key.
        /// This function will return one of the scancodes that produce the key.
        /// This function uses the current keyboard layout to determine the mapping.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// The <see cref="Scancode"/> that produces the <see cref="Key"/>
        /// or <see cref="Scancode.Unknown"/> if no scancode produces the key.
        /// </returns>
        Scancode GetScancodeFromKey(Key key);

        /// <summary>
        /// Gets the <see cref="Key"/> associated with the specidied <see cref="Scancode"/>.
        /// This function uses the current keyboard layout to determine the mapping.
        /// </summary>
        /// <param name="scancode">The scancode.</param>
        /// <returns>
        /// The <see cref="Key"/> associated with the <see cref="Scancode"/>
        /// or <see cref="Key.Unknown"/> if the scancode can't be mapped to a key.
        /// </returns>
        Key GetKeyFromScancode(Scancode scancode);

        // FIXME: Probably want to rename BeginIme and EndIme to BeginTextEditing or StartTextEdit

        /// <summary>
        /// Invoke input method editor.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        void BeginIme(WindowHandle window);

        /// <summary>
        /// Set the rectangle to which the IME interface will appear relative to.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        /// <param name="x">X coordinate of the rectangle in desktop coordinates.</param>
        /// <param name="y">Y coordinate of the rectangle in desktop coordinates.</param>
        /// <param name="width">Width of the rectangle in desktop units.</param>
        /// <param name="height">Height of the rectangle in desktop units.</param>
        void SetImeRectangle(WindowHandle window, int x, int y, int width, int height);

        /// <summary>
        /// Finish input method editor.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        void EndIme(WindowHandle window);
    }
}
