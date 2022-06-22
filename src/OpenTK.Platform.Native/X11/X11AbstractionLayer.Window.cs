using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.GLX;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IWindowComponent
    {
        public bool CanSetIcon => false;
        public bool CanGetDisplay => false;
        public bool CanSetCursor => false;
        public IReadOnlyList<WindowEventType> SupportedEvents { get; }
        public IReadOnlyList<WindowStyle> SupportedStyles { get; }
        public IReadOnlyList<WindowMode> SupportedModes { get; }

        public WindowHandle Create(GraphicsApiHints hints)
        {
            XWindow window;
            GLXFBConfig? chosenConfig = null;
            XColorMap? map = null;

            if (hints.Api == GraphicsApi.OpenGL || hints.Api == GraphicsApi.OpenGLES)
            {
                // Ignoring ES for now.
                OpenGLGraphicsApiHints glhints = hints as OpenGLGraphicsApiHints;

                Span<int> visualAttribs = stackalloc int[]
                {
                    GLX_X_RENDERABLE, 1,
                    GLX_DRAWABLE_TYPE, GLX_WINDOW_BIT,
                    GLX_RENDER_TYPE, GLX_RGBA_BIT,
                    GLX_X_VISUAL_TYPE, GLX_TRUE_COLOR,
                    GLX_RED_SIZE, glhints.RedColorBits,
                    GLX_GREEN_SIZE, glhints.GreenColorBits,
                    GLX_BLUE_SIZE, glhints.BlueColorBits,
                    GLX_ALPHA_SIZE, glhints.AlphaColorBits,
                    GLX_DEPTH_SIZE, glhints.DepthBits,
                    GLX_STENCIL_SIZE, glhints.StencilBits,
                    GLX_DOUBLEBUFFER, glhints.DoubleBuffer ? 1 : 0,
                    GLX_SAMPLE_BUFFERS, glhints.Multisamples == 0 ? 0 : 1,
                    GLX_SAMPLES, glhints.Multisamples,
                    /* fin */ 0
                };

                int items = visualAttribs.Length;
                unsafe
                {
                    GLXFBConfig *configs = glXChooseFBConfig(Display, DefaultScreen, ref visualAttribs[0], ref items);
                    chosenConfig = *configs;
                    XFree((IntPtr)configs);
                }

                XSetWindowAttributes windowAttributes = new XSetWindowAttributes();
                unsafe
                {
                    XVisualInfo* vi = glXGetVisualFromFBConfig(Display, chosenConfig.Value);
                    map = XCreateColormap(Display, XDefaultRootWindow(Display), ref *vi->VisualPtr, 0);

                    windowAttributes.ColorMap = map.Value;
                    windowAttributes.BackgroundPixmap = XPixMap.None;
                    windowAttributes.BorderPixel = 0;
                    windowAttributes.EventMask = XEventMask.StructureNotify | XEventMask.SubstructureNotify;

                    window = XCreateWindow(
                        Display,
                        XDefaultRootWindow(Display),
                        0,
                        0,
                        800,
                        600,
                        0,
                        vi->Depth,
                        1,
                        ref *vi->VisualPtr,
                        XWindowAttributeValueMask.BackPixmap | XWindowAttributeValueMask.Colormap | XWindowAttributeValueMask.BorderPixel | XWindowAttributeValueMask.EventMask,
                        ref windowAttributes);

                    XFree((IntPtr)vi);
                }
            }
            else
            {
                ulong black = XBlackPixel(Display, DefaultScreen);
                ulong white = XWhitePixel(Display, DefaultScreen);
                window = XCreateSimpleWindow(
                    Display,
                    XDefaultRootWindow(Display),
                    0, 0, 800, 600,
                    0,
                    black);
            }

            XSetStandardProperties(
                Display,
                window,
                "OpenTK Window [Native:X11]",
                "ICO_OPENTK",
                XPixMap.None,
                null,
                0,
                ref Unsafe.NullRef<XSizeHints>());

            return new XWindowHandle(Display, window, hints, chosenConfig, map);
        }

        public void Destroy(WindowHandle handle)
        {
            var xhandle = handle.As<XWindowHandle>(this);
            XDestroyWindow(xhandle.Display, xhandle.Window);
            if (xhandle.ColorMap.HasValue)
            {
                XFreeColormap(xhandle.Display, xhandle.ColorMap.Value);
            }
        }

        public string GetTitle(WindowHandle handle)
        {
            var window = handle.As<XWindowHandle>(this);
            string str = string.Empty;
            unsafe
            {
                XFetchName(window.Display, window.Window, out byte* name);
                str = Marshal.PtrToStringAnsi((IntPtr)name) ?? string.Empty;
                XFree((IntPtr)name);
            }

            return str;
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            var window = handle.As<XWindowHandle>(this);
            XStoreName(window.Display, window.Window, title);
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);
            XTranslateCoordinates(
                window.Display,
                window.Window,
                XDefaultRootWindow(window.Display),
                attributes.X,
                attributes.Y,
                out x,
                out y,
                out _);
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);
            width = attributes.Width;
            height = attributes.Height;
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            throw new NotImplementedException();
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            throw new NotImplementedException();
        }

        public WindowStyle GetBorderStyle(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetBorderStyle(WindowHandle handle, WindowStyle style)
        {
            throw new NotImplementedException();
        }

        public void SetCursor(WindowHandle handle, CursorHandle cursor)
        {
            throw new NotImplementedException();
        }

        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public IEventQueue<WindowEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}
