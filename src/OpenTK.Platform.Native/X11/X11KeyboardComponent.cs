using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native.X11
{
    public class X11KeyboardComponent : IKeyboardComponent
    {
        public string Name => nameof(X11KeyboardComponent);

        public PalComponents Provides => PalComponents.KeyboardInput;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }
        }

        public bool SupportsLayouts => throw new NotImplementedException();

        public bool SupportsIme => throw new NotImplementedException();

        public string GetActiveKeyboardLayout(WindowHandle? handle)
        {
            throw new NotImplementedException();
            
        }

        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotImplementedException();
        }
        public Scancode GetScancodeFromKey(Key key)
        {
            throw new NotImplementedException();
        }

        public Key GetKeyFromScancode(Scancode scancode)
        {
            throw new NotImplementedException();
        }

        public void BeginIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        public void SetImeRectangle(WindowHandle window, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void EndIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }
    }
}
