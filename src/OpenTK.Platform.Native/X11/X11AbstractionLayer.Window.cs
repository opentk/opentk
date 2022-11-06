using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using static OpenTK.Platform.Native.X11.GLX;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IWindowComponent
    {
        public bool CanSetIcon => false;
        public bool CanGetDisplay => false;
        public bool CanSetCursor => false;

        private static List<WindowStyle> s_emptyStyleList = new List<WindowStyle>();
        private static List<WindowMode> s_emptyModeList = new List<WindowMode>();

        public IReadOnlyList<PlatformEventType> SupportedEvents { get => throw new NotImplementedException(); }
        public IReadOnlyList<WindowStyle> SupportedStyles { get; private set; } = s_emptyStyleList;
        public IReadOnlyList<WindowMode> SupportedModes { get; private set; } = s_emptyModeList;

        /// <summary>
        /// When true, indicates the current window manager is Freedesktop compliant.
        /// </summary>
        public bool IsWindowManagerFreedesktop { get; private set; } = false;
        public string? FreedesktopWindowManagerName { get; private set; } = null;

        private void InitializeWindow()
        {
            // Check if the window manager is freedesktop compliant.
            // https://specifications.freedesktop.org/wm-spec/wm-spec-1.4.html
            // The Window Manager MUST set this property on the root window to be
            // the ID of a child window created by himself, to indicate that a
            // compliant window manager is active. The child window MUST also have
            // the _NET_SUPPORTING_WM_CHECK property set to the ID of the child window.
            // The child window MUST also have the _NET_WM_NAME property set to the
            // name of the Window Manager.

            XWindow wm_window;
            XAtom _net_supported = _atoms![KnownAtoms._NET_SUPPORTED];
            XAtom _net_supporting_wm_check = _atoms![KnownAtoms._NET_SUPPORTING_WM_CHECK];
            XAtom _net_wm_name = _atoms![KnownAtoms._NET_WM_NAME];
            XAtom atom = _atoms![KnownAtoms.ATOM];
            XAtom utf8_string = _atoms![KnownAtoms.UTF8_STRING];
            XAtom window = _atoms![KnownAtoms.WINDOW];
            IntPtr array;
            long count;

            XGetWindowProperty(Display, DefaultRootWindow, _net_supporting_wm_check, 0, 8, false, window, out _, out _, out count, out _, out array);

            if (count > 0)
            {
                wm_window = Marshal.PtrToStructure<XWindow>(array);
                XFree(array);

                XGetWindowProperty(Display, wm_window, _net_supporting_wm_check, 0, 8, false, window, out _, out _, out count, out _, out array);
                if (count > 0 && wm_window.Id == Marshal.PtrToStructure<XWindow>(array).Id)
                {
                    IsWindowManagerFreedesktop = true;
                    XFree(array);
                    XGetWindowProperty(
                        Display,
                        wm_window,
                        _net_wm_name,
                        0,
                        long.MaxValue,   // FIXME: Is this worth two rountrips to measure name size and then read?
                        false,
                        utf8_string,
                        out _,
                        out _,
                        out count,
                        out _,
                        out array);

                    if (count > 0)
                    {
                        FreedesktopWindowManagerName = Marshal.PtrToStringUTF8(array);
                    }

                    XFree(array);
                }
                else
                {
                    XFree(array);
                }
            }
            else
            {
                XFree(array);
            }

            Debug.WriteLineIf(IsWindowManagerFreedesktop, $"Found Freedesktop Compliant Window Manager {FreedesktopWindowManagerName}.", "PAL/Linux/X11/Window");

            if (IsWindowManagerFreedesktop)
            {
                // Find which window styles and modes are supported.
                HashSet<XAtom> supportedAtoms = new HashSet<XAtom>();

                XGetWindowProperty(Display, DefaultRootWindow, _net_supported, 0, long.MaxValue, false, atom, out _, out _, out count, out _, out array);
                for (int i = 0; i < count; i++)
                {
                    supportedAtoms.Add(Marshal.PtrToStructure<XAtom>(array + Unsafe.SizeOf<XAtom>()*i));
                }

                // TODO: Figure how to extract win32 like window types and modes from the supported atoms list.
            }
        }

        public WindowHandle Create(GraphicsApiHints hints)
        {
            XWindow window;
            GLXFBConfig? chosenConfig = null;
            XColorMap? map = null;

            if (hints.Api == GraphicsApi.OpenGL || hints.Api == GraphicsApi.OpenGLES)
            {
                // Ignoring ES for now.
                OpenGLGraphicsApiHints glhints = (hints as OpenGLGraphicsApiHints)!;

                byte depthBits;
                switch (glhints.DepthBits)
                {
                    case ContextDepthBits.Depth24: depthBits = 24; break;
                    case ContextDepthBits.Depth32: depthBits = 32; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.DepthBits), (int)glhints.DepthBits, glhints.DepthBits.GetType());
                }

                byte stencilBits;
                switch (glhints.StencilBits)
                {
                    case ContextStencilBits.Stencil1: stencilBits = 1; break;
                    case ContextStencilBits.Stencil8: stencilBits = 8; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.StencilBits), (int)glhints.StencilBits, glhints.StencilBits.GetType());
                }

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
                    GLX_DEPTH_SIZE, depthBits,
                    GLX_STENCIL_SIZE, stencilBits,
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
            string str;
            IntPtr name;

            if (IsWindowManagerFreedesktop)
            {
                XGetWindowProperty(
                    window.Display,
                    window.Window,
                    _atoms![KnownAtoms._NET_WM_NAME],
                    0,
                    long.MaxValue,
                    false,
                    _atoms![KnownAtoms.UTF8_STRING],
                    out _,
                    out _,
                    out long count,
                    out _,
                    out name);
                str = Marshal.PtrToStringUTF8(name) ?? string.Empty;
                XFree(name);
            }
            else
            {
                XFetchName(window.Display, window.Window, out name);
            }

            str = Marshal.PtrToStringAnsi(name) ?? string.Empty;
            XFree(name);

            return str;
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            var window = handle.As<XWindowHandle>(this);
            if (IsWindowManagerFreedesktop)
            {
                byte[] titleBytes = System.Text.Encoding.UTF8.GetBytes(title);

                unsafe
                {
                    fixed(byte *titlePtr = &titleBytes[0])
                    {
                        XChangeProperty(
                            window.Display,
                            window.Window,
                            _atoms![KnownAtoms._NET_WM_NAME],
                            _atoms![KnownAtoms.UTF8_STRING],
                            8,
                            XPropertyMode.Replace,
                            (IntPtr)titlePtr,
                            titleBytes.Length
                            );
                    }
                }
            }
            else
            {
                XStoreName(window.Display, window.Window, title);
            }
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        private void GetWindowExtents(
            WindowHandle handle,
            out int left,
            out int right,
            out int top,
            out int bottom)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowProperty(
                window.Display,
                window.Window,
                _atoms![KnownAtoms._NET_FRAME_EXTENTS],
                0,
                long.MaxValue,
                false,
                _atoms![KnownAtoms.CARDINAL],
                out _,
                out _,
                out long count,
                out _,
                out IntPtr array);

            if (count < 4)
            {
                // FIXME: You need to request frame extents for this to work...
                // This means that you have to wait for the window manager to
                // respond. I don't know if pumping the event loop is the solution here.

                left = right = top = bottom = 0;
            }
            else
            {
                left   = Marshal.PtrToStructure<int>(array);
                right  = Marshal.PtrToStructure<int>(array + 4);
                top    = Marshal.PtrToStructure<int>(array + 8);
                bottom = Marshal.PtrToStructure<int>(array + 12);
            }

            XFree(array);
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            GetClientPosition(handle, out x, out y);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out _, out int top, out _);
                x -= left;
                y -= top;
            }
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            GetClientSize(handle, out width, out height);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out int right, out int top, out int bottom);
                width += left + right;
                height += top + bottom;
            }
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
                DefaultRootWindow,
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

        public IEventQueue<PlatformEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}
