using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLDisplayComponent : IDisplayComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(SDLDisplayComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Display;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        /// <inheritdoc/>
        public bool CanSetVideoMode => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanGetVirtualPosition => true;

        private void CalculateDisplayDPI(int index, out float dpi, out float scale)
        {
            // FIXME: Should the default dpi be 96?
            dpi = 96;

            int result = SDL_GetDisplayDPI(index, out float ddpi, out float hdpi, out float vdpi);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL2 could not get display DPI for display {index}: '{error}'");
            }
            else
            {
                // FIXME: What should we "really" do here?
                dpi = Math.Max(hdpi, vdpi);
            }

            scale = dpi / 96;
        }

        /// <inheritdoc/>
        public int GetDisplayCount()
        {
            return SDL_GetNumVideoDisplays();
        }

        /// <inheritdoc/>
        public DisplayHandle Open(int index)
        {
            int displayCount = GetDisplayCount();

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), index, $"Display index cannot be negative.");
            if (index >= displayCount)
                throw new ArgumentOutOfRangeException(nameof(index), index, $"Display index cannot be larger or equal to the number of displays ({displayCount}).");

            return new SDLDisplay(index);
        }

        /// <inheritdoc/>
        public DisplayHandle OpenPrimary()
        {
            // FIXME: Will 0 always be the primary display?
            return new SDLDisplay(0);
        }

        /// <inheritdoc/>
        public void Close(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

        }

        /// <inheritdoc/>
        public bool IsPrimary(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            // FIXME: Is this the right way to check for this??
            return display.Index == 0;
        }

        /// <inheritdoc/>
        public string GetName(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            string? name = SDL_GetDisplayName(display.Index);
            if (name == null)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL couldn't get display name: {error}");
            }

            return name;
        }

        /// <inheritdoc/>
        public VideoMode GetVideoMode(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int result = SDL_GetCurrentDisplayMode(display.Index, out SDL_DisplayMode sdlMode);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL2 could not get current display mode: {error}");
            }

            int bpp = (int)SDL_BITSPERPIXEL(sdlMode.format);

            return new VideoMode(sdlMode.w, sdlMode.h, sdlMode.refresh_rate, bpp);
        }

        /// <inheritdoc/>
        public VideoMode[] GetSupportedVideoModes(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int numModes = SDL_GetNumDisplayModes(display.Index);
            VideoMode[] modes = new VideoMode[numModes];
            for (int i = 0; i < numModes; i++)
            {
                int result = SDL_GetDisplayMode(display.Index, i, out SDL_DisplayMode sdlMode);
                if (result != 0)
                {
                    string error = SDL_GetError();
                    throw new PalException(this, $"SDL 2 could not get the display mode: {error}");
                }

                int bpp = (int)SDL_BITSPERPIXEL(sdlMode.format);
                modes[i] = new VideoMode(sdlMode.w, sdlMode.h, sdlMode.refresh_rate, bpp);
            }

            return modes;
        }

        /// <inheritdoc/>
        public Vector2i GetVirtualPosition(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int result = SDL_GetDisplayBounds(display.Index, out SDL_Rect rect);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL 2 could not get the display bounds: {error}");
            }

            return new Vector2i(rect.x, rect.y);
        }

        /// <inheritdoc/>
        public Vector2i GetResolution(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int result = SDL_GetDisplayBounds(display.Index, out SDL_Rect rect);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL 2 could not get the display bounds: {error}");
            }

            return new Vector2i(rect.w, rect.h);
        }

        /// <inheritdoc/>
        public Box2i GetWorkArea(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int result = SDL_GetDisplayUsableBounds(display.Index, out SDL_Rect rect);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL 2 could not get the display bounds: {error}");
            }

            return new Box2i(rect.x, rect.y, rect.w, rect.h);
        }

        /// <inheritdoc/>
        public float GetRefreshRate(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            int result = SDL_GetCurrentDisplayMode(display.Index, out SDL_DisplayMode sdlMode);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL2 could not get current display mode: {error}");
            }

            return sdlMode.refresh_rate;
        }

        /// <inheritdoc/>
        public Vector2 GetDisplayScale(DisplayHandle handle)
        {
            SDLDisplay display = handle.As<SDLDisplay>(this);

            // FIXME: Should the default dpi be 96?
            float dpiX = 96.0f;
            float dpiY = 96.0f;

            int result = SDL_GetDisplayDPI(display.Index, out float ddpi, out float hdpi, out float vdpi);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL2 could not get display DPI for display {display.Index}: '{error}'");
            }
            else
            {
                // FIXME: What should we "really" do here?
                dpiX = hdpi;
                dpiY = vdpi;
            }

            return new Vector2(dpiX / 96.0f, dpiY / 96.0f);
        }

        /// <inheritdoc />
        //public bool GetHDRInfo(DisplayHandle handle, out HdrInfo hdrInfo)
        //{
        //    hdrInfo = default;
        //    return false;
        //}
    }
}
