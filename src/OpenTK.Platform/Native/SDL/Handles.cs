using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    internal class SDLWindow : WindowHandle
    {
        public SDL_WindowPtr Window { get; internal set; }
        public uint WindowID { get; internal set; }

        public bool Destroyed { get; internal set; } = false;

        public HitTest? HitTest { get; internal set; } = null;

        public SDLIcon? Icon { get; internal set; } = null;

        public SDLWindow(SDL_WindowPtr window, uint windowID, GraphicsApiHints hints) : base(hints)
        {
            Window = window;
            WindowID = windowID;
        }
    }

    internal class SDLOpenGLContext : OpenGLContextHandle
    {
        public SDL_GLContext Context { get; internal set; }

        public SDLWindow Window { get; internal set; }

        public SDLOpenGLContext? SharedContext { get; internal set; }

        public SDLOpenGLContext(SDL_GLContext context, SDLWindow window, SDLOpenGLContext? sharedContext)
        {
            Context = context;
            Window = window;
            SharedContext = sharedContext;
        }
    }

    internal class SDLDisplay : DisplayHandle
    {
        // FIXME: Some way to identify monitors other than their index??
        public int Index { get; internal set; }

        public SDLDisplay(int index)
        {
            Index = index;
        }
    }

    internal unsafe class SDLIcon : IconHandle
    {
        public SDL_Surface* Surface { get; internal set; }

    }

    internal unsafe class SDLCursor : CursorHandle
    {
        public SDL_CursorPtr Cursor { get; internal set; }

        public CursorMode Mode { get; internal set; }

        public SDL_Surface* Surface { get; internal set; }

        public int Width { get; internal set; }

        public int Height { get; internal set; }

        public int HotX { get; internal set; }

        public int HotY { get; internal set; }

        internal enum CursorMode
        {
            Uninitialized,
            SystemCursor,
            DataCursor,
            SurfaceCursor,
        }
    }

    internal unsafe class SDLJoystick : JoystickHandle
    {
        public SDL_Joystick* Joystick { get; internal set; }
        public SDL_JoystickID InstanceID { get; internal set; }

        public SDLJoystick(SDL_Joystick* joystick, SDL_JoystickID instanceID)
        {
            Joystick = joystick;
            InstanceID = instanceID;
        }
    }
}
