using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with the keyboard.
        /// </summary>
        public static class Keyboard
        {
            /// <summary>
            /// Retrieves the status of the specified virtual key. The status specifies whether the key is up, down,
            /// or toggled (on, off—alternating each time the key is pressed).
            /// </summary>
            /// <param name="key">The desired virtual key.</param>
            /// <returns>
            /// The return value specifies the status of the specified virtual key, as follows:<para/>
            /// If the high-order bit is 1, the key is down; otherwise, it is up.<para/>
            /// If the low-order bit is 1, the key is toggled. A key, such as the CAPS LOCK key, is toggled if it is
            /// turned on. The key is off and untoggled if the low-order bit is 0. A toggle key's indicator light
            /// (if any) on the keyboard will be on when the key is toggled, and off when the key is untoggled.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern short GetKeyState([In] VirtualKey key);

            /// <summary>
            /// Determines whether a key is up or down at the time the function is called,
            /// and whether the key was pressed after a previous call to GetAsyncKeyState.
            /// </summary>
            /// <param name="key">The desired virtual key.</param>
            /// <returns>
            /// If the function succeeds, the return value specifies whether the key was pressed since the last call
            /// to <see cref="GetAsyncKeyState(VirtualKey)"/>, and whether the key is currently up or down. If the
            /// most significant bit is set, the key is down, and if the least significant bit is set, the key was
            /// pressed after the previous call to GetAsyncKeyState. However, you should not rely on this last
            /// behavior; for more information, see the Remarks section in the official documentation.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern short GetAsyncKeyState([In] VirtualKey key);

            /// <summary>
            /// Retrieves the handle to the window that has the keyboard focus,
            /// if the window is attached to the calling thread's message queue.
            /// </summary>
            /// <returns>
            /// The return value is the handle to the window with the keyboard focus. If the calling thread's message
            /// queue does not have an associated window with the keyboard focus,
            /// the return value is <see cref="IntPtr.Zero"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr GetFocus();

            /// <summary>
            /// Sets the keyboard focus to the specified window.
            /// The window must be attached to the calling thread's message queue.
            /// </summary>
            /// <param name="window">A handle to the window that will receive the keyboard input.
            /// If this parameter is <see cref="IntPtr.Zero"/>, keystrokes are ignored.</param>
            /// <returns>
            /// If the function succeeds, the return value is the handle to the window that previously had the
            /// keyboard focus. If the <paramref name="window"/> parameter is invalid or the window is not attached
            /// to the calling thread's message queue, the return value is <see cref="IntPtr.Zero"/>.<para/>
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr SetFocus([In] [Optional] IntPtr window);

            /// <summary>
            /// Translates (maps) a virtual-key code into a scan code or character value,
            /// or translates a scan code into a virtual-key code.
            /// </summary>
            /// <param name="vkey">
            /// The virtual key code or scan code for a key.
            /// How this value is interpreted depends on the value of the <paramref name="mapType"/> parameter.
            /// </param>
            /// <param name="mapType">The translation to be performed.</param>
            /// <returns>
            /// The return value is either a scan code, a virtual-key code, or a character value, depending on
            /// the value of <paramref name="vkey"/> and <paramref name="mapType"/>.<para/>
            /// If there is no translation, the return value is zero.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern uint MapVirtualKey([In] VirtualKey vkey, [In] MapVirtualKeyType mapType);
        }
    }
}
