using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Base class for OpenTK window event arguments.
    /// </summary>
    public class WindowEventArgs : EventArgs
    {
    }

    public class KeyDownEventArgs : WindowEventArgs
    {
        // FIXME: These properties are for testing with the Win32 backend.

        public ulong VirtualKey { get; private set; }

        public bool WasDown { get; private set; }

        public bool Extended { get; private set; }

        public KeyDownEventArgs(ulong virtualKey, bool wasDown, bool extended)
        {
            VirtualKey = virtualKey;
            WasDown = wasDown;
            Extended = extended;
        }
    }
}
