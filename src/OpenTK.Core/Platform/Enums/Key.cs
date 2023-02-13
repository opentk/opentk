using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
#pragma warning disable SA1514 // Element documentation header should be preceded by blank line
    public enum Key
    {
        /// <summary>
        /// An unknown key.
        /// This is likely an error.
        /// </summary>
        Unknown = 0,

        // FIXME: Fix the numerical values of these enums??

        /// <summary>
        /// The backspace key.
        /// </summary>
        Backspace,
        /// <summary>
        /// The tab key.
        /// </summary>
        Tab,
        /// <summary>
        /// The return/enter key.
        /// </summary>
        Return,
        /// <summary>
        /// The escape key.
        /// </summary>
        Escape,

        /// <summary>
        /// The space key.
        /// </summary>
        Space = ' ',

        D0 = '0',
        D1 = '1',
        D2 = '2',
        D3 = '3',
        D4 = '4',
        D5 = '5',
        D6 = '6',
        D7 = '7',
        D8 = '8',
        D9 = '9',

        A = 'A',
        B = 'B',
        C = 'C',
        D = 'D',
        E = 'E',
        F = 'F',
        G = 'G',
        H = 'H',
        I = 'I',
        J = 'J',
        K = 'K',
        L = 'L',
        M = 'M',
        N = 'N',
        O = 'O',
        P = 'P',
        Q = 'Q',
        R = 'R',
        S = 'S',
        T = 'T',
        U = 'U',
        V = 'V',
        W = 'W',
        X = 'X',
        Y = 'Y',
        Z = 'Z',

        /// <summary>
        /// The left shift key.
        /// </summary>
        LeftShift,
        /// <summary>
        /// The right shift key.
        /// </summary>
        RightShift,
        /// <summary>
        /// The left control key.
        /// </summary>
        LeftControl,
        /// <summary>
        /// The right control key.
        /// </summary>
        RightControl,
        /// <summary>
        /// The left alt key.
        /// </summary>
        LeftAlt,
        /// <summary>
        /// The right alt (alt-gr) key.
        /// </summary>
        RightAlt,
        /// <summary>
        /// The left "OS" key.
        /// On windows this is the left windows key.
        /// </summary>
        LeftGUI,
        /// <summary>
        /// The right "OS" key.
        /// On windows this is the right windows key.
        /// </summary>
        RightGUI,

        /// <summary>
        /// The caps lock key.
        /// </summary>
        CapsLock,

        /// <summary>
        /// The num lock key.
        /// </summary>
        NumLock,
        /// <summary>
        /// The keypad 0 key.
        /// </summary>
        Keypad0,
        /// <summary>
        /// The keypad 1 key.
        /// </summary>
        Keypad1,
        /// <summary>
        /// The keypad 2 key.
        /// </summary>
        Keypad2,
        /// <summary>
        /// The keypad 3 key.
        /// </summary>
        Keypad3,
        /// <summary>
        /// The keypad 4 key.
        /// </summary>
        Keypad4,
        /// <summary>
        /// The keypad 5 key.
        /// </summary>
        Keypad5,
        /// <summary>
        /// The keypad 6 key.
        /// </summary>
        Keypad6,
        /// <summary>
        /// The keypad 7 key.
        /// </summary>
        Keypad7,
        /// <summary>
        /// The keypad 8 key.
        /// </summary>
        Keypad8,
        /// <summary>
        /// The keypad 9 key.
        /// </summary>
        Keypad9,
        /// <summary>
        /// The keypad decimal point key.
        /// </summary>
        KeypadDecimal,
        /// <summary>
        /// The keypad divide key.
        /// </summary>
        KeypadDivide,
        /// <summary>
        /// The keypad multiply key.
        /// </summary>
        KeypadMultiply,
        /// <summary>
        /// The keypad subtract key.
        /// </summary>
        KeypadSubtract,
        /// <summary>
        /// The keypad add key.
        /// </summary>
        KeypadAdd,
        /// <summary>
        /// The keypad separator key.
        /// </summary>
        KeypadSeparator,
        /// <summary>
        /// The keypad enter key.
        /// </summary>
        KeypadEnter,
        /// <summary>
        /// The keypad equals key.
        /// </summary>
        KeypadEqual,

        /// <summary>
        /// The print screen key.
        /// </summary>
        PrintScreen,
        /// <summary>
        /// The scroll lock key.
        /// </summary>
        ScrollLock,
        /// <summary>
        /// The pause/break key.
        /// </summary>
        PauseBreak,

        /// <summary>
        /// The insert key.
        /// </summary>
        Insert,
        /// <summary>
        /// The delete key.
        /// </summary>
        Delete,
        /// <summary>
        /// The home key.
        /// </summary>
        Home,
        /// <summary>
        /// End key.
        /// </summary>
        End,
        /// <summary>
        /// Page Up key.
        /// </summary>
        PageUp,
        /// <summary>
        /// Page Down key.
        /// </summary>
        PageDown,

        /// <summary>
        /// The left arrow key.
        /// </summary>
        LeftArrow,
        /// <summary>
        /// The right arrow key.
        /// </summary>
        RightArrow,
        /// <summary>
        /// The up arrow key.
        /// </summary>
        UpArrow,
        /// <summary>
        /// The down arrow key.
        /// </summary>
        DownArrow,

        // FIXME: Explain what this key is for...
        Application,

        // FIXME: Is this windows only?
        Help,

        /// <summary>
        /// The 1st function key.
        /// </summary>
        F1,
        /// <summary>
        /// The 2nd function key.
        /// </summary>
        F2,
        /// <summary>
        /// The 3rd function key.
        /// </summary>
        F3,
        /// <summary>
        /// The 4th function key.
        /// </summary>
        F4,
        /// <summary>
        /// The 5th function key.
        /// </summary>
        F5,
        /// <summary>
        /// The 6th function key.
        /// </summary>
        F6,
        /// <summary>
        /// The 7th function key.
        /// </summary>
        F7,
        /// <summary>
        /// The 8th function key.
        /// </summary>
        F8,
        /// <summary>
        /// The 9th function key.
        /// </summary>
        F9,
        /// <summary>
        /// The 10th function key.
        /// </summary>
        F10,
        /// <summary>
        /// The 11th function key.
        /// </summary>
        F11,
        /// <summary>
        /// The 12th function key.
        /// </summary>
        F12,
        /// <summary>
        /// The 13th function key.
        /// </summary>
        F13,
        /// <summary>
        /// The 14th function key.
        /// </summary>
        F14,
        /// <summary>
        /// The 15th function key.
        /// </summary>
        F15,
        /// <summary>
        /// The 16th function key.
        /// </summary>
        F16,
        /// <summary>
        /// The 17th function key.
        /// </summary>
        F17,
        /// <summary>
        /// The 18th function key.
        /// </summary>
        F18,
        /// <summary>
        /// The 19th function key.
        /// </summary>
        F19,
        /// <summary>
        /// The 20th function key.
        /// </summary>
        F20,
        /// <summary>
        /// The 21st function key.
        /// </summary>
        F21,
        /// <summary>
        /// The 22nd function key.
        /// </summary>
        F22,
        /// <summary>
        /// The 23rd function key.
        /// </summary>
        F23,
        /// <summary>
        /// The 24th function key.
        /// </summary>
        F24,
        /// <summary>
        /// The 25th function key.
        /// </summary>
        F25,

        /// <summary>
        /// The computer sleep key.
        /// </summary>
        Sleep,

        /// <summary>
        /// The plus key.
        /// </summary>
        Plus,
        /// <summary>
        /// The comma key.
        /// </summary>
        Comma,
        /// <summary>
        /// The minus key.
        /// </summary>
        Minus,
        /// <summary>
        /// The period key.
        /// </summary>
        Period,

        // These will likely need to change with X11 and macos
        // - 2023-02-13

        // FIXME: We can't make alternate names for these
        // as ToString is not going to consistently pick the
        // name we want it to have.
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>;:</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>¨^~</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM1,
        /// <summary>
        /// <para>US layout <c>;:</c> key.</para>
        /// <inheritdoc cref="OEM1"/>
        /// See <see cref="OEM1"/>.
        /// </summary>
        //Semicolon = OEM1,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>/?</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>'*</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM2,
        /// <summary>
        /// <para>US layout <c>/?</c> key.</para>
        /// <inheritdoc cref="OEM2"/>
        /// See <see cref="OEM2"/>.
        /// </summary>
        //Slash = OEM2,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>`~</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>ÖØÆ</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM3,
        /// <summary>
        /// <para>US layout <c>`~</c> key.</para>
        /// <inheritdoc cref="OEM3"/>
        /// See <see cref="OEM3"/>.
        /// </summary>
        //Backtick = OEM3,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>[{</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>´`</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM4,
        /// <summary>
        /// <para>US layout <c>[{</c> key.</para>
        /// <inheritdoc cref="OEM4"/>
        /// See <see cref="OEM4"/>.
        /// </summary>
        //LeftBrace = OEM4,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>\|</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>§½</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM5,
        /// <summary>
        /// <para>US layout <c>\|</c> key.</para>
        /// <inheritdoc cref="OEM5"/>
        /// See <see cref="OEM5"/>.
        /// </summary>
        //Backslash = OEM5,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>]}</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>Å</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM6,
        /// <summary>
        /// <para>US layout <c>]}</c> key.</para>
        /// <inheritdoc cref="OEM6"/>
        /// See <see cref="OEM6"/>.
        /// </summary>
        //RightBrace = OEM6,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <list><description>In the US keyboard layout this is the <c>'"</c> key.</description></list>
        /// <list><description>In the nordic layout this is the <c>ÄÆØ</c> key.</description></list>
        /// </list>
        /// </summary>
        OEM7,
        /// <summary>
        /// <para>US layout <c>'"</c> key.</para>
        /// <inheritdoc cref="OEM7"/>
        /// See <see cref="OEM7"/>.
        /// </summary>
        //Quote = OEM7,
        /// <summary>
        /// Used for various characters, depends on keyboard.
        /// </summary>
        OEM8,

        // FIXME: What do we do here?
        // OEM3 = 192,
        // Tilde = 192,
        // Ö = 192,

        /// <summary>
        /// The &lt;&gt; keys on the US standard keyboard,
        /// or the \\| key on the non-US 102-key keyboard.
        /// </summary>
        OEM102,

        /// <summary>
        /// The media play/pause key.
        /// Used for playing and pausing music.
        /// </summary>
        PlayPause,
        /// <summary>
        /// The next track key.
        /// Used to go to the next media track.
        /// </summary>
        NextTrack,
        /// <summary>
        /// The previous track key.
        /// Used to go the previous media track.
        /// </summary>
        PreviousTrack,
        /// <summary>
        /// The media stop key.
        /// Used to stop any playing media.
        /// </summary>
        Stop,
        /// <summary>
        /// The mute key.
        /// </summary>
        Mute,
        /// <summary>
        /// The volume up key.
        /// </summary>
        VolumeUp,
        /// <summary>
        /// The media volume down key.
        /// </summary>
        VolumeDown,
    }
#pragma warning restore SA1514 // Element documentation header should be preceded by blank line
}
