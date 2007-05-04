#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Stephen Apostolopoulos and Erik Ylvisaker.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Platform.X;

namespace OpenTK.OpenGL.Platform
{
    public partial class X11Context : OpenTK.OpenGL.GLContext
    {
        private IntPtr glxVisualInfo;
        private IntPtr x11context;
        private IntPtr display;
        private IntPtr rootWindow;
        private Type xplatui;
        private int screenNo;
        private Size fullScreenSize;

        private IntPtr desktopResolution = IntPtr.Zero;

        private int depthBits;
        private int stencilBits;

        //const string _dll_name = "libGL.so.1";
        
        public X11Context(Control c, ColorDepth color, int depth, int stencil)
            : base(c)
        {
            this.depthBits = depth;
            this.stencilBits = stencil;

            Console.WriteLine("Creating X11Context.");
    
            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui != null)
            {
                Console.WriteLine("Got XplatUIX11 type.");

                display = (IntPtr)xplatui.GetField("DisplayHandle", 
                    System.Reflection.BindingFlags.Static | 
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                rootWindow = (IntPtr)xplatui.GetField("RootWindow", 
                    System.Reflection.BindingFlags.Static | 
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                screenNo = (int)xplatui.GetField("ScreenNo", 
                    System.Reflection.BindingFlags.Static | 
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                Console.WriteLine("DisplayHandle: {0}  RootWindow: {1}   ScreenNo: {2}",
                    display, rootWindow, screenNo);
                
                int[] dblBuf = new int[]
                { 
                    5, 
                    (int)Glx.Enums.GLXAttribute.RGBA,
                    (int)Glx.Enums.GLXAttribute.RED_SIZE, color.Red,
                    (int)Glx.Enums.GLXAttribute.GREEN_SIZE, color.Green,
                    (int)Glx.Enums.GLXAttribute.BLUE_SIZE, color.Blue,
                    (int)Glx.Enums.GLXAttribute.DEPTH_SIZE, depth,
                    0
                };

                IntPtr glxVisualInfo = Glx.ChooseVisual(display, screenNo, dblBuf);
                Console.WriteLine("GLXVisualInfo: {0}", glxVisualInfo);

                X11Api.VisualInfo xVisualInfo = (X11Api.VisualInfo)
                    Marshal.PtrToStructure(glxVisualInfo, typeof(X11Api.VisualInfo));
                
                IntPtr visual = xVisualInfo.visual;
                IntPtr colormap = X11Api.CreateColormap(display, rootWindow, visual, 0/*AllocNone*/);

                xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | 
                    System.Reflection.BindingFlags.NonPublic).SetValue(null, visual);

                xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | 
                    System.Reflection.BindingFlags.NonPublic).SetValue(null, colormap);

                Console.WriteLine("colormap: {0}", colormap);

                x11context = Glx.CreateContext(display, glxVisualInfo, IntPtr.Zero, true);
                Console.WriteLine("x11context: {0}", x11context);

                X11Api.XMapRaised(display, Control.TopLevelControl.Handle);

                MakeCurrent();

                X11Api.Free(glxVisualInfo);
            }

            //c.MouseDown += new MouseEventHandler(c_MouseDown);
            //c.MouseLeave += new EventHandler(c_MouseLeave);
            //c.MouseUp += new MouseEventHandler(c_MouseUp);
        }

        void c_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsFullscreen)
                GrabPointer();
        }

        void c_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0}", Cursor.Position);

            if (Cursor.Position.X > fullScreenSize.Width)
                Cursor.Position = new Point(fullScreenSize.Width, Cursor.Position.Y);
            if (Cursor.Position.Y > fullScreenSize.Height)
                Cursor.Position = new Point(Cursor.Position.X, fullScreenSize.Height);

            ResetViewport();
        }

        void c_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsFullscreen)
                GrabPointer();
        }

        void c_MouseLeave(object sender, EventArgs e)
        {
            if (IsFullscreen)
                GrabPointer();
        }

        public override void MakeCurrent()
        {
            bool result = Glx.MakeCurrent(display, this.Control.Handle, x11context);

            if (!result)
            {
                Console.WriteLine("Failed to make context {0} current.", x11context);
                // probably need to recreate context here.
            }
        }
        public override void SwapBuffers()
        {
            Glx.SwapBuffers(display, this.Control.Handle);
        }

        protected override void Dispose(bool disposing)
        {
            SetWindowed();

            Glx.DestroyContext(display, x11context);
        }

        protected override Delegate GetAddress(string function_string, Type function_type)
        {
            IntPtr address = Glx.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        public override void SetWindowed()
        {
            if (desktopResolution != IntPtr.Zero)
            {
                // set the resolution back to the desktop mode.
                X11Api.XUngrabPointer(display, 0);
                X11Api.XUngrabKeyboard(display, 0);

                X11Api.XF86VidModeSwitchToMode(display, 0, desktopResolution);

                Marshal.FreeHGlobal(desktopResolution);
                desktopResolution = IntPtr.Zero;

                IsFullscreen = false;
            }
        }

        public override void SetFullScreen(int width, int height, ColorDepth color)
        {
            CheckAnyFullScreen();

            // query and output the version of the video mode extension.
            int majorVersion, minorVersion;
            X11Api.XF86VidModeQueryVersion(display, out majorVersion, out minorVersion);
            Console.WriteLine("XFree86 Video Mode Extension version {0}.{1}", majorVersion, minorVersion);

            // get the list of display modes
            X11Api.XF86VidModeModeInfo[] modeList = GetXDisplayModeList();

            int selectedMode = 0;

            for (int i = 0; i < modeList.Length; i++)
            {
                Console.Write("  ");

                if (selectedMode == 0 &&
                    modeList[i].hdisplay == width && modeList[i].vdisplay == height)
                {
                    selectedMode = i;
                    Console.Write("*");
                }
                else
                    Console.Write(" ");

                Console.Write("Mode #{0}: {1}x{2}", i,
                    modeList[i].hdisplay, modeList[i].vdisplay);

                if (i % 3 == 0 && i > 0)
                    Console.WriteLine();
            }

            // store the resolution of the desktop.
            desktopResolution = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(X11Api.XF86VidModeModeInfo)));
            Marshal.StructureToPtr(modeList[0], desktopResolution, true);

            Console.WriteLine("Attempting to set resolutions to {0}x{1}", width, height);
            if (selectedMode == 0) 
                Console.WriteLine("--- Failed to find an appropriate mode.");
            
            fullScreenSize = new Size(width, height);
            SwitchDisplayMode(modeList[selectedMode]);

            GrabPointer();
            BindColorMap(color, depthBits, stencilBits);

            this.IsFullscreen = true;
        }

        private void BindColorMap(ColorDepth color, int depth, int stencil)
        {
            int[] dblBuf = new int[]
                { 
                    5, 
                    (int)Glx.Enums.GLXAttribute.RGBA,
                    (int)Glx.Enums.GLXAttribute.RED_SIZE, color.Red,
                    (int)Glx.Enums.GLXAttribute.GREEN_SIZE, color.Green,
                    (int)Glx.Enums.GLXAttribute.BLUE_SIZE, color.Blue,
                    (int)Glx.Enums.GLXAttribute.DEPTH_SIZE, depth,
                    0
                };

            glxVisualInfo = Glx.ChooseVisual(display, screenNo, dblBuf);

            X11Api.VisualInfo xVisualInfo = (X11Api.VisualInfo)Marshal.PtrToStructure
                (glxVisualInfo, typeof(X11Api.VisualInfo));

            IntPtr visual = xVisualInfo.visual;
            IntPtr colormap = X11Api.CreateColormap(display, rootWindow, visual, 0/*AllocNone*/);

            xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.NonPublic).SetValue(null, visual);
            xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.NonPublic).SetValue(null, colormap);


            X11Api.Free(glxVisualInfo);
        }

        private void GrabPointer()
        {
            Console.Write("Grabbing pointer... ");
            X11Api.ErrorCodes retval = X11Api.XGrabPointer(display, this.Control.Handle, true, 0,
                X11Api.GrabMode.Async, X11Api.GrabMode.Async,
                this.Control.Handle, IntPtr.Zero, 0);

            Console.WriteLine(retval.ToString());

            Console.Write("Grabbing keyboard... ");
            retval = X11Api.XGrabKeyboard(display, this.Control.Handle, true,
                X11Api.GrabMode.Async, X11Api.GrabMode.Async, 0);

            Console.WriteLine(retval.ToString());

            ResetViewport();
        }

        private void SwitchDisplayMode(X11Api.XF86VidModeModeInfo mode)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(mode));
            Marshal.StructureToPtr(mode, ptr, true);

            X11Api.XF86VidModeSwitchToMode(display, screenNo, ptr);

            Marshal.FreeHGlobal(ptr);

            ResetViewport();
        }

        /// <summary>
        /// Resets the viewport for full screen modes.
        /// X does this thing where if your screen resolution is smaller than your desktop resolution,
        /// you can scroll around.  This resets the part of the desktop you're looking at to the
        /// upper left.
        /// </summary>
        private void ResetViewport()
        {
            X11Api.XF86VidModeSetViewPort(display, screenNo, 0, 0);
        }

        public override DisplayMode[] EnumDisplayModes()
        {
            List<DisplayMode> modes = new List<DisplayMode>();

            X11Api.XF86VidModeModeInfo[] list= GetXDisplayModeList();

            for (int i = 0; i < list.Length; i++)
            {
                modes.Add(new DisplayMode(list[i].hdisplay, list[i].vdisplay));
                
            }

            return modes.ToArray();
        }


        private X11Api.XF86VidModeModeInfo[] GetXDisplayModeList()
        {

            // get a list of all the video modes.
            int modeCount;
            IntPtr modesInfoPtr;
            X11Api.XF86VidModeGetAllModeLines(display, screenNo, out modeCount, out modesInfoPtr);
            Console.WriteLine("Video mode query returned {0} available modes.", modeCount);

            // modesInfo now contains a pointer to an array of pointers to XF86VidModeModeInfo structures.
            // first, we need to copy these pointers to an array of intptr's, then we can copy the
            // structures pointed to.
            IntPtr[] modesInfo = new IntPtr[modeCount];

            // Marshal.Copy does not work correctly with Mono 1.1.18.
            //Marshal.Copy(modesInfoPtr, (IntPtr[])modesInfo, 0, modeCount);
            unsafe
            {
                IntPtr* ptr = (IntPtr*)modesInfoPtr;
                for (int i = 0; i < modeCount; i++)
                    modesInfo[i] = ptr[i];
            }

            X11Api.XF86VidModeModeInfo[] modeList = new X11Api.XF86VidModeModeInfo[modeCount];


            for (int i = 0; i < modeCount; i++)
            {
                modeList[i] = (X11Api.XF86VidModeModeInfo)
                        Marshal.PtrToStructure(modesInfo[i], typeof(X11Api.XF86VidModeModeInfo));
            }

            X11Api.Free(modesInfoPtr);
            return modeList;
        }

    }

}
