using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLClipboardComponent : IClipboardComponent
    {
        public string Name => nameof(SDLClipboardComponent);

        public PalComponents Provides => PalComponents.Clipboard;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Clipboard)
            {
                throw new PalException(this, "SDLClipboardComponent can only initialize the Clipboard component.");
            }
        }

        private ClipboardFormat[] _supportedFormats = {
            ClipboardFormat.Text
        };

        public IReadOnlyList<ClipboardFormat> SupportedFormats => _supportedFormats;

        public ClipboardFormat GetClipboardFormat()
        {
            if (SDL_HasClipboardText() == 1) return ClipboardFormat.Text;
            else return ClipboardFormat.None;
        }

        public void SetClipboardText(string text)
        {
            int result = SDL_SetClipboardText(text);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL2 could not set the clipboard text: {error}");
            }
        }

        public string? GetClipboardText()
        {
            if (GetClipboardFormat() == ClipboardFormat.Text)
            {
                string? text = SDL_GetClipboardText();
                if (text == "")
                {
                    string error = SDL_GetError();
                    Logger?.LogError($"SDL2 could not get clipboard text: {error}");
                    text = null;
                }

                return text;
            }
            else
            {
                return null;
            }
        }

        public AudioData? GetClipboardAudio()
        {
            throw new NotSupportedException();
        }

        public Bitmap? GetClipboardBitmap()
        {
            throw new NotSupportedException();
        }

        public string? GetClipboardHTML()
        {
            throw new NotSupportedException();
        }

        public List<string>? GetClipboardFiles()
        {
            throw new NotSupportedException();
        }
    }
}
