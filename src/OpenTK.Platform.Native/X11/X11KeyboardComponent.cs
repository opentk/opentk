using System;
using OpenTK.Core;
using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;

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
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
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
    }
}
