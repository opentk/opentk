#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    class X11GraphicsMode : IGraphicsMode
    {
        internal X11GraphicsMode()
        {
        }

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum,
                                               int buffers, bool stereo)
        {
            GraphicsMode gfx;                               // The actual GraphicsMode that will be selected.
            List<int> visualAttributes = new List<int>();
            IntPtr visual;

            Debug.Print("Bits per pixel: {0}", color.BitsPerPixel);

            if (color.BitsPerPixel > 0)
            {
                if (!color.IsIndexed)
                    visualAttributes.Add((int)GLXAttribute.RGBA);
                visualAttributes.Add((int)GLXAttribute.RED_SIZE);
                visualAttributes.Add(color.Red);
                visualAttributes.Add((int)GLXAttribute.GREEN_SIZE);
                visualAttributes.Add(color.Green);
                visualAttributes.Add((int)GLXAttribute.BLUE_SIZE);
                visualAttributes.Add(color.Blue);
                visualAttributes.Add((int)GLXAttribute.ALPHA_SIZE);
                visualAttributes.Add(color.Alpha);
            }

            Debug.Print("Depth: {0}", depth);

            if (depth > 0)
            {
                visualAttributes.Add((int)GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add(depth);
            }

            if (buffers > 1)
                visualAttributes.Add((int)GLXAttribute.DOUBLEBUFFER);

            if (stencil > 1)
            {
                visualAttributes.Add((int)GLXAttribute.STENCIL_SIZE);
                visualAttributes.Add(stencil);
            }

            if (accum.BitsPerPixel > 0)
            {
                visualAttributes.Add((int)GLXAttribute.ACCUM_ALPHA_SIZE);
                visualAttributes.Add(accum.Alpha);
                visualAttributes.Add((int)GLXAttribute.ACCUM_BLUE_SIZE);
                visualAttributes.Add(accum.Blue);
                visualAttributes.Add((int)GLXAttribute.ACCUM_GREEN_SIZE);
                visualAttributes.Add(accum.Green);
                visualAttributes.Add((int)GLXAttribute.ACCUM_RED_SIZE);
                visualAttributes.Add(accum.Red);
            }

            if (stereo)
                visualAttributes.Add((int)GLXAttribute.STEREO);

            visualAttributes.Add((int)0);

            // Select a visual that matches the parameters set by the user.
            IntPtr display = API.DefaultDisplay; //Functions.XOpenDisplay(IntPtr.Zero);

            try
            {
                //Functions.XLockDisplay(display);

                int screen = Functions.XDefaultScreen(display);
                IntPtr root = Functions.XRootWindow(display, screen);
                Debug.Print("Display: {0}, Screen: {1}, RootWindow: {2}", display, screen, root);

                visual = Glx.ChooseVisual(display, screen, visualAttributes.ToArray());

                if (visual == IntPtr.Zero)
                    throw new GraphicsContextException("Requested GraphicsMode not available.");

                XVisualInfo info = (XVisualInfo)Marshal.PtrToStructure(visual, typeof(XVisualInfo));

                // See what we *really* got:
                int r, g, b, a;
                Glx.GetConfig(display, ref info, GLXAttribute.ALPHA_SIZE, out a);
                Glx.GetConfig(display, ref info, GLXAttribute.RED_SIZE, out r);
                Glx.GetConfig(display, ref info, GLXAttribute.GREEN_SIZE, out g);
                Glx.GetConfig(display, ref info, GLXAttribute.BLUE_SIZE, out b);
                int ar, ag, ab, aa;
                Glx.GetConfig(display, ref info, GLXAttribute.ACCUM_ALPHA_SIZE, out aa);
                Glx.GetConfig(display, ref info, GLXAttribute.ACCUM_RED_SIZE, out ar);
                Glx.GetConfig(display, ref info, GLXAttribute.ACCUM_GREEN_SIZE, out ag);
                Glx.GetConfig(display, ref info, GLXAttribute.ACCUM_BLUE_SIZE, out ab);
                Glx.GetConfig(display, ref info, GLXAttribute.DEPTH_SIZE, out depth);
                Glx.GetConfig(display, ref info, GLXAttribute.STENCIL_SIZE, out stencil);
                Glx.GetConfig(display, ref info, GLXAttribute.SAMPLES, out samples);
                Glx.GetConfig(display, ref info, GLXAttribute.DOUBLEBUFFER, out buffers);
                ++buffers;  // the above lines returns 0 - false and 1 - true.
                int st;
                Glx.GetConfig(display, ref info, GLXAttribute.STEREO, out st);
                stereo = st != 0;
                
                gfx = new GraphicsMode(info.visualid, new ColorFormat(r, g, b, a), depth, stencil, samples,
                                       new ColorFormat(ar, ag, ab, aa), buffers, stereo);
            }
            finally
            {
                //Functions.XUnlockDisplay(display);
            }

            // Prepare Windows.Forms for creating OpenGL drawables.
            //lock (API.Lock)
            //{
            //    Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            //    IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle",
            //        System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            //    IntPtr root = (IntPtr)xplatui.GetField("RootWindow",
            //        System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            //    int screen = (int)xplatui.GetField("ScreenNo",
            //        System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);


                //xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                //    .SetValue(null, visual);
                //xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                //    .SetValue(null, Functions.XCreateColormap(display, root, visual, 0));

            //}
            
            try
            {
                Functions.XLockDisplay(display);
                Functions.XFree(visual);
            }
            finally
            {
                Functions.XUnlockDisplay(display);
            }
            
            return gfx;
        }
    }
}
