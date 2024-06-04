using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLCursorComponent : ICursorComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(SDLCursorComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MouseCursor;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public bool CanLoadSystemCursors => true;

        /// <inheritdoc/>
        public bool CanInspectSystemCursors => false;

        /// <inheritdoc/>
        public CursorHandle Create(SystemCursorType systemCursor)
        {
            SDLCursor cursor = new SDLCursor();

            SDL_SystemCursor sdlCursor;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_ARROW;
                    break;
                case SystemCursorType.Loading:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_WAIT;
                    break;
                case SystemCursorType.Wait:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_WAIT;
                    break;
                case SystemCursorType.Cross:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_CROSSHAIR;
                    break;
                case SystemCursorType.Hand:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_HAND;
                    break;
                case SystemCursorType.Help:
                    // FIXME!! 
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_ARROW;
                    break;
                case SystemCursorType.TextBeam:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_IBEAM;
                    break;
                case SystemCursorType.Forbidden:
                    // FIXME!
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_WAIT;
                    break;
                case SystemCursorType.ArrowFourway:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENWSE;
                    break;
                case SystemCursorType.ArrowN:
                case SystemCursorType.ArrowS:
                case SystemCursorType.ArrowNS:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENS;
                    break;
                case SystemCursorType.ArrowE:
                case SystemCursorType.ArrowW:
                case SystemCursorType.ArrowEW:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZEWE;
                    break;
                case SystemCursorType.ArrowNE:
                case SystemCursorType.ArrowSW:
                case SystemCursorType.ArrowNESW:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENESW;
                    break;
                case SystemCursorType.ArrowNW:
                case SystemCursorType.ArrowSE:
                case SystemCursorType.ArrowNWSE:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENWSE;
                    break;
                case SystemCursorType.ArrowUp:
                    // FIXME!
                    Logger?.LogWarning($"SDL doesn't support system cursor {SystemCursorType.ArrowUp}");
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_ARROW;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            cursor.Cursor = SDL_CreateSystemCursor(sdlCursor);

            cursor.Width = -1;
            cursor.Height = -1;
            cursor.HotX = -1;
            cursor.HotY = -1;

            cursor.Mode = SDLCursor.CursorMode.SystemCursor;

            return cursor;
        }

        /// <inheritdoc/>
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            SDLCursor cursor = new SDLCursor();

            SDL_Surface* surface = SDL_CreateRGBSurfaceWithFormat(0, width, height, 32, SDL_PixelFormatEnum.SDL_PIXELFORMAT_ABGR8888);

            SDL_LockSurface(surface);

            fixed (byte* ptr = image)
            {
                Buffer.MemoryCopy(ptr, surface->pixels, surface->pitch * height, image.Length);
            }

            SDL_UnlockSurface(surface);

            cursor.Surface = surface;

            cursor.Cursor = SDL_CreateColorCursor(cursor.Surface, hotspotX, hotspotY);
            cursor.HotX = hotspotX;
            cursor.HotY = hotspotY;
            cursor.Mode = SDLCursor.CursorMode.SurfaceCursor;

            return cursor;
        }

        /// <inheritdoc/>
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            SDLCursor cursor = new SDLCursor();

            if (width % 8 != 0)
            {
                Logger?.LogError("SDL cursor width must be a multiple of 8.");
                //return null;
            }

            fixed (byte* color = colorData)
            fixed (byte* mask = maskData)
            {
                // FXIME: Convert this into a color cursor!
                // FIXME: We might always be creating color cursors?? Or should we convert the color to bw?
                cursor.Cursor = SDL_CreateCursor(color, mask, width, height, hotspotX, hotspotY);
            }

            cursor.HotX = hotspotX;
            cursor.HotY = hotspotY;

            cursor.Mode = SDLCursor.CursorMode.DataCursor;

            return cursor;
        }

        /// <inheritdoc/>
        public void Destroy(CursorHandle handle)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            switch (cursor.Mode)
            {
                case SDLCursor.CursorMode.Uninitialized:
                    break;
                case SDLCursor.CursorMode.SystemCursor:
                    SDL_FreeCursor(cursor.Cursor);
                    cursor.Cursor = SDL_CursorPtr.Null;
                    break;
                case SDLCursor.CursorMode.DataCursor:
                    SDL_FreeCursor(cursor.Cursor);
                    cursor.Cursor = SDL_CursorPtr.Null;
                    break;
                case SDLCursor.CursorMode.SurfaceCursor:
                    SDL_FreeCursor(cursor.Cursor);
                    cursor.Cursor = SDL_CursorPtr.Null;
                    unsafe
                    {
                        SDL_FreeSurface(cursor.Surface);
                        cursor.Surface = null;
                    }
                    throw new NotImplementedException();
                default:
                    throw new InvalidOperationException($"Unknown cursor mode: {cursor.Mode}");
            }
        }

        /// <inheritdoc/>
        public bool IsSystemCursor(CursorHandle handle)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);
            return cursor.Mode == SDLCursor.CursorMode.SystemCursor;
        }

        /// <inheritdoc/>
        public void GetSize(CursorHandle handle, out int width, out int height)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            if (cursor.Mode == SDLCursor.CursorMode.SystemCursor)
            {
                throw new InvalidOperationException("SDL backend cannot get the size of a system cursor.");
            }

            width = cursor.Width;
            height = cursor.Height;
        }

        /// <inheritdoc/>
        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            if (cursor.Mode == SDLCursor.CursorMode.SystemCursor)
            {
                throw new InvalidOperationException("SDL backend cannot get the hotspot of a system cursor.");
            }

            x = cursor.HotX;
            y = cursor.HotY;
        }
    }
}
