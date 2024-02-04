using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native.X11.XI2;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.LibXkb;

namespace OpenTK.Platform.Native.X11
{
    public class X11KeyboardComponent : IKeyboardComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11KeyboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public unsafe void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            int major = 1;
            int minor = 0;
            if (XkbQueryExtension(X11.Display, out int opcode, out int @event, out int error, ref major, ref minor) == false)
            {
                // FIXME:
                throw new Exception("Xkb extension not available.");
            }

            //XkbGetMap(X11.Display, )
        }

        internal void UpdateKeymap()
        {
            XDisplayKeycodes(X11.Display, out int minKeycode, out int maxKeycode);

            Span<XKeySym> syms;
            unsafe
            {
                int keyCodeCount = maxKeycode - minKeycode;
                XKeySym* symsPtr = XGetKeyboardMapping(X11.Display, (byte)minKeycode, keyCodeCount, out int symsPerKeycode);
                syms = new Span<XKeySym>(symsPtr, keyCodeCount * symsPerKeycode);
            }
            
            


        }

        /// <inheritdoc/>
        public bool SupportsLayouts => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool SupportsIme => throw new NotImplementedException();

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle)
        {
            throw new NotImplementedException();
            
        }

        /// <inheritdoc/>
        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetKeyboardState(bool[] keyboardState)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public KeyModifier GetKeyboardModifiers()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetImeRectangle(WindowHandle window, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        private static readonly Scancode[] LinuxScancodes = new Scancode[/*256*/]
        {
            // 0x00 - 0x07

        };
    }
}
