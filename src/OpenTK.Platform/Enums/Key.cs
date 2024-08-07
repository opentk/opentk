using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
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

        /// <summary>
        /// The 0 key.
        /// </summary>
        D0 = '0',
        /// <summary>
        /// The 1 key.
        /// </summary>
        D1 = '1',
        /// <summary>
        /// The 2 key.
        /// </summary>
        D2 = '2',
        /// <summary>
        /// The 3 key.
        /// </summary>
        D3 = '3',
        /// <summary>
        /// The 4 key.
        /// </summary>
        D4 = '4',
        /// <summary>
        /// The 5 key.
        /// </summary>
        D5 = '5',
        /// <summary>
        /// The 6 key.
        /// </summary>
        D6 = '6',
        /// <summary>
        /// The 7 key.
        /// </summary>
        D7 = '7',
        /// <summary>
        /// The 8 key.
        /// </summary>
        D8 = '8',
        /// <summary>
        /// The 9 key.
        /// </summary>
        D9 = '9',

        /// <summary>
        /// The A key.
        /// </summary>
        A = 'A',
        /// <summary>
        /// The B key.
        /// </summary>
        B = 'B',
        /// <summary>
        /// The C key.
        /// </summary>
        C = 'C',
        /// <summary>
        /// The D key.
        /// </summary>
        D = 'D',
        /// <summary>
        /// The E key.
        /// </summary>
        E = 'E',
        /// <summary>
        /// The F key.
        /// </summary>
        F = 'F',
        /// <summary>
        /// The G key.
        /// </summary>
        G = 'G',
        /// <summary>
        /// The H key.
        /// </summary>
        H = 'H',
        /// <summary>
        /// The I key.
        /// </summary>
        I = 'I',
        /// <summary>
        /// The J key.
        /// </summary>
        J = 'J',
        /// <summary>
        /// The K key.
        /// </summary>
        K = 'K',
        /// <summary>
        /// The L key.
        /// </summary>
        L = 'L',
        /// <summary>
        /// The M key.
        /// </summary>
        M = 'M',
        /// <summary>
        /// The N key.
        /// </summary>
        N = 'N',
        /// <summary>
        /// The O key.
        /// </summary>
        O = 'O',
        /// <summary>
        /// The P key.
        /// </summary>
        P = 'P',
        /// <summary>
        /// The Q key.
        /// </summary>
        Q = 'Q',
        /// <summary>
        /// The R key.
        /// </summary>
        R = 'R',
        /// <summary>
        /// The S key.
        /// </summary>
        S = 'S',
        /// <summary>
        /// The T key.
        /// </summary>
        T = 'T',
        /// <summary>
        /// The U key.
        /// </summary>
        U = 'U',
        /// <summary>
        /// The V key.
        /// </summary>
        V = 'V',
        /// <summary>
        /// The W key.
        /// </summary>
        W = 'W',
        /// <summary>
        /// The X key.
        /// </summary>
        X = 'X',
        /// <summary>
        /// The Y key.
        /// </summary>
        Y = 'Y',
        /// <summary>
        /// The Z key.
        /// </summary>
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
        /// The left alt key (left Option on mac).
        /// </summary>
        LeftAlt,
        /// <summary>
        /// The right alt (alt-gr) key (right Option on mac).
        /// </summary>
        RightAlt,
        /// <summary>
        /// The left "OS" key.
        /// On windows this is the left windows key.
        /// On macOS this is the left Command key.
        /// </summary>
        LeftGUI,
        /// <summary>
        /// The right "OS" key.
        /// On windows this is the right windows key.
        /// On macOS this is the right Command key.
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

        /// <summary>
        /// The application key.
        /// This usually opens a context menu, in the same way that right click does.
        /// </summary>
        Application,

        // FIXME: Is this windows only?
        /// <summary>
        /// The help key.
        /// </summary>
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
        /// <item><description>In the US keyboard layout this is the <c>;:</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>¨^~</c> key. </description></item>
        /// </list>
        /// </summary>
        OEM1,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>/?</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>'*</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM2,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>`~</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>ÖØÆ</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM3,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>[{</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>´`</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM4,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>\|</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>§½</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM5,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>]}</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>Å</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM6,
        /// <summary>
        /// Used for various characters depending on keyboard layout.
        /// <list type="table">
        /// <item><description>In the US keyboard layout this is the <c>'"</c> key.</description></item>
        /// <item><description>In the nordic layout this is the <c>ÄÆØ</c> key.</description></item>
        /// </list>
        /// </summary>
        OEM7,
        /// <summary>
        /// Used for various characters, depends on keyboard.
        /// </summary>
        OEM8,

        /// <summary>
        /// The &lt;&gt; keys on the US standard keyboard,
        /// or the \\| key on the non-US 102-key keyboard.
        /// </summary>
        // FIXME: Make a layout table for this key.
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
