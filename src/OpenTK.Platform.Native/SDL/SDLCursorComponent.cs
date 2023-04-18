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
    internal class SDLCursorComponent : ICursorComponent
    {
        public string Name => nameof(SDLCursorComponent);

        public PalComponents Provides => PalComponents.MouseCursor;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new PalException(this, "SDLCursorComponent can only initialize the MouseCursor component.");
            }
        }

        public bool CanLoadSystemCursor => true;

        public bool CanScaleCursor => false;

        public bool CanSupportAnimatedCursor => false;

        public CursorHandle Create()
        {
            return new SDLCursor();
        }

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
                    cursor.ColorData = null;
                    cursor.MaskData = null;
                    break;
                case SDLCursor.CursorMode.SurfaceCursor:
                    throw new NotImplementedException();
                default:
                    throw new InvalidOperationException($"Unknown cursor mode: {cursor.Mode}");
            }
        }

        public void GetSize(CursorHandle handle, out int width, out int height)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            width = cursor.Width;
            height = cursor.Height;
        }

        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            x = cursor.HotX;
            y = cursor.HotY;
        }

        public void GetImage(CursorHandle handle, Span<byte> image)
        {
            throw new NotImplementedException();
        }

        public void GetScale(CursorHandle handle, out float horizontal, out float vertical)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            horizontal = 1;
            vertical = 1;
        }

        public void Load(CursorHandle handle, SystemCursorType systemCursor)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            Destroy(cursor);

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
                case SystemCursorType.ArrowNS:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENS;
                    break;
                case SystemCursorType.ArrowEW:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZEWE;
                    break;
                case SystemCursorType.ArrowNESW:
                    sdlCursor = SDL_SystemCursor.SDL_SYSTEM_CURSOR_SIZENESW;
                    break;
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

            // FIXME: Get hotspot and size information!
            cursor.Width = -1;
            cursor.Height = -1;
            cursor.HotX = -1;
            cursor.HotY = -1;

            cursor.Mode = SDLCursor.CursorMode.SystemCursor;
        }

        public unsafe void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            // FIXME: Should we destroy icons internally like this?
            Destroy(cursor);

            SDL_Surface* surface = SDL_CreateRGBSurfaceWithFormat(0, width, height, 32, SDL_PixelFormatEnum.SDL_PIXELFORMAT_ABGR8888);

            SDL_LockSurface(surface);

            fixed (byte* ptr = image)
            {
                Buffer.MemoryCopy(ptr, surface->pixels, surface->pitch * height, image.Length);
            }

            SDL_UnlockSurface(surface);

            cursor.Surface = surface;

            cursor.Cursor = SDL_CreateColorCursor(cursor.Surface, cursor.HotX, cursor.HotY);
            cursor.Mode = SDLCursor.CursorMode.SurfaceCursor;
        }

        public unsafe void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            if (width % 8 != 0)
            {
                Logger?.LogError("SDL cursor width must be a multiple of 8.");
                return;
            }

            Destroy(cursor);

            fixed(byte* color = colorData)
            fixed (byte* mask = maskData)
            {
                // FIXME: We might always be creating color cursors?? Or should we convert the color to bw?
                cursor.Cursor = SDL_CreateCursor(color, mask, width, height, cursor.HotX, cursor.HotY);
            }

            cursor.ColorData = colorData.ToArray();
            cursor.MaskData = maskData.ToArray();

            cursor.Mode = SDLCursor.CursorMode.DataCursor;
        }

        public void SetHotspot(CursorHandle handle, int x, int y)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            switch (cursor.Mode)
            {
                case SDLCursor.CursorMode.Uninitialized:
                    {
                        cursor.HotX = x;
                        cursor.HotY = y;
                        break;
                    }
                case SDLCursor.CursorMode.SystemCursor:
                    throw new InvalidOperationException("SDL cannot set the hotspot of system cursors.");
                case SDLCursor.CursorMode.DataCursor:
                    {
                        cursor.HotX = x;
                        cursor.HotY = y;

                        // FIXME: Do we want to call Load like this, or "inline" it?
                        Load(cursor, cursor.Width, cursor.Height, cursor.ColorData, cursor.MaskData);
                        break;
                    }
                case SDLCursor.CursorMode.SurfaceCursor:
                    {
                        cursor.HotX = x;
                        cursor.HotY = y;

                        SDL_FreeCursor(cursor.Cursor);

                        unsafe
                        {
                            cursor.Cursor = SDL_CreateColorCursor(cursor.Surface, x, y);
                        }
                        
                        break;
                    }
                    throw new NotImplementedException();
                default:
                    throw new PalException(this, $"Unknown cursor mode: {cursor.Mode}");
            }
        }

        public void SetScale(CursorHandle handle, float horizontal, float vertical)
        {
            SDLCursor cursor = handle.As<SDLCursor>(this);

            throw new NotSupportedException("SDL cannot scale cursors.");
        }
    }
}
