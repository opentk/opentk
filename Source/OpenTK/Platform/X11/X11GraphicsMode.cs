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
    class X11GraphicsMode
    {
        // Todo: Add custom visual selection algorithm, instead of ChooseFBConfig/ChooseVisual.
        // It seems the Choose* methods do not take multisampling into account (at least on some
        // drivers).
        
        #region Constructors

        public X11GraphicsMode()
        {
        }

        #endregion

        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(GraphicsMode desired_mode, out IntPtr visual, out IntPtr fbconfig)
        {
            GraphicsMode gfx;
            GraphicsMode mode = new GraphicsMode(desired_mode);
            visual = IntPtr.Zero;
            fbconfig = IntPtr.Zero;
            IntPtr display = API.DefaultDisplay;

            do
            {
                // Try to select a visual using Glx.ChooseFBConfig and Glx.GetVisualFromFBConfig.
                // This is only supported on GLX 1.3 - if it fails, fall back to Glx.ChooseVisual.
                fbconfig = SelectFBConfig(mode);
                if (fbconfig != IntPtr.Zero)
                    visual = Glx.GetVisualFromFBConfig(display, fbconfig);
                
                if (visual == IntPtr.Zero)
                    visual = SelectVisual(mode);
                
                if (visual == IntPtr.Zero)
                {
                    // Relax parameters and retry
                    if (!Utilities.RelaxGraphicsMode(ref mode))
                        throw new GraphicsModeException("Requested GraphicsMode not available.");
                }
            }
            while (visual == IntPtr.Zero);

            XVisualInfo info = (XVisualInfo)Marshal.PtrToStructure(visual, typeof(XVisualInfo));
            gfx = CreateGraphicsMode(display, ref info);
            return gfx;
        }

        #endregion

        #region Private Members

        static GraphicsMode CreateGraphicsMode(IntPtr display, ref XVisualInfo info)
        {
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
            int depth, stencil, samples, buffers;
            Glx.GetConfig(display, ref info, GLXAttribute.DEPTH_SIZE, out depth);
            Glx.GetConfig(display, ref info, GLXAttribute.STENCIL_SIZE, out stencil);
            Glx.GetConfig(display, ref info, GLXAttribute.SAMPLES, out samples);
            Glx.GetConfig(display, ref info, GLXAttribute.DOUBLEBUFFER, out buffers);
            int st;
            Glx.GetConfig(display, ref info, GLXAttribute.STEREO, out st);

            // Note: Glx.GetConfig return buffers = 0 (false) or 1 (true).
            // OpenTK expects buffers = 1 (single-) or 2 (double-buffering),
            // so increase the GLX value by one.
            return new GraphicsMode(info.VisualID, new ColorFormat(r, g, b, a), depth, stencil, samples,
                new ColorFormat(ar, ag, ab, aa), buffers + 1, st != 0);
        }

        IntPtr SelectFBConfig(GraphicsMode mode)
        {
            Debug.Print("Selecting FB config for {0}", mode);

            List<int> visualAttributes = new List<int>();

            if (mode.ColorFormat.BitsPerPixel > 0)
            {
                if (!mode.ColorFormat.IsIndexed)
                {
                    visualAttributes.Add((int)GLXAttribute.RENDER_TYPE);
                    visualAttributes.Add((int)GLXRenderTypeMask.RGBA_BIT);
                }
                visualAttributes.Add((int)GLXAttribute.RED_SIZE);
                visualAttributes.Add(mode.ColorFormat.Red);
                visualAttributes.Add((int)GLXAttribute.GREEN_SIZE);
                visualAttributes.Add(mode.ColorFormat.Green);
                visualAttributes.Add((int)GLXAttribute.BLUE_SIZE);
                visualAttributes.Add(mode.ColorFormat.Blue);
                visualAttributes.Add((int)GLXAttribute.ALPHA_SIZE);
                visualAttributes.Add(mode.ColorFormat.Alpha);
            }

            if (mode.Depth > 0)
            {
                visualAttributes.Add((int)GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add(mode.Depth);
            }

            if (mode.Buffers > 1)
            {
                visualAttributes.Add((int)GLXAttribute.DOUBLEBUFFER);
                visualAttributes.Add(1);
            }

            if (mode.Stereo)
            {
                visualAttributes.Add((int)GLXAttribute.STENCIL_SIZE);
                visualAttributes.Add(mode.Stereo ? 1 : 0);
            }

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                visualAttributes.Add((int)GLXAttribute.ACCUM_ALPHA_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Alpha);
                visualAttributes.Add((int)GLXAttribute.ACCUM_BLUE_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Blue);
                visualAttributes.Add((int)GLXAttribute.ACCUM_GREEN_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Green);
                visualAttributes.Add((int)GLXAttribute.ACCUM_RED_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Red);
            }

            if (mode.Samples > 0)
            {
                visualAttributes.Add((int)GLXAttribute.SAMPLE_BUFFERS);
                visualAttributes.Add(1);
                visualAttributes.Add((int)GLXAttribute.SAMPLES);
                visualAttributes.Add(mode.Samples);
            }

            if (mode.Stereo)
            {
                visualAttributes.Add((int)GLXAttribute.STEREO);
                visualAttributes.Add(1);
            }

            visualAttributes.Add(0);

            // Select a visual that matches the parameters set by the user.
            IntPtr display = API.DefaultDisplay;
            IntPtr result = IntPtr.Zero;
            using (new XLock(display))
            {
                try
                {
                    int screen = Functions.XDefaultScreen(display);
                    IntPtr root = Functions.XRootWindow(display, screen);
                    Debug.Print("Display: {0}, Screen: {1}, RootWindow: {2}", display, screen, root);

                    unsafe
                    {
                        Debug.Print("Getting FB config.");
                        int fbcount;
                        // Note that ChooseFBConfig returns an array of GLXFBConfig opaque structures (i.e. mapped to IntPtrs).
                        IntPtr* fbconfigs = Glx.ChooseFBConfig(display, screen, visualAttributes.ToArray(), out fbcount);
                        if (fbcount > 0 && fbconfigs != null)
                        {
                            // We want to use the first GLXFBConfig from the fbconfigs array (the first one is the best match).
                            Debug.Print("Selected FB config: {0}", *fbconfigs);
                            result = *fbconfigs;
                            Functions.XFree((IntPtr)fbconfigs);
                        }
                        else
                        {
                            Debug.Print("No matching FB config found.");
                        }
                    }
                }
                catch (EntryPointNotFoundException)
                {
                    Debug.Print("Function glXChooseFBConfig not supported.");
                }
            }

            return result;
        }

        IntPtr SelectVisual(GraphicsMode mode)
        {
            Debug.Print("Selecting FB config for {0}", mode);

            List<int> visualAttributes = new List<int>();

            if (mode.ColorFormat.BitsPerPixel > 0)
            {
                if (!mode.ColorFormat.IsIndexed)
                    visualAttributes.Add((int)GLXAttribute.RGBA);
                visualAttributes.Add((int)GLXAttribute.RED_SIZE);
                visualAttributes.Add(mode.ColorFormat.Red);
                visualAttributes.Add((int)GLXAttribute.GREEN_SIZE);
                visualAttributes.Add(mode.ColorFormat.Green);
                visualAttributes.Add((int)GLXAttribute.BLUE_SIZE);
                visualAttributes.Add(mode.ColorFormat.Blue);
                visualAttributes.Add((int)GLXAttribute.ALPHA_SIZE);
                visualAttributes.Add(mode.ColorFormat.Alpha);
            }


            if (mode.Depth > 0)
            {
                visualAttributes.Add((int)GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add(mode.Depth);
            }

            if (mode.Buffers > 1)
                visualAttributes.Add((int)GLXAttribute.DOUBLEBUFFER);

            if (mode.Stencil > 1)
            {
                visualAttributes.Add((int)GLXAttribute.STENCIL_SIZE);
                visualAttributes.Add(mode.Stencil);
            }

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                visualAttributes.Add((int)GLXAttribute.ACCUM_ALPHA_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Alpha);
                visualAttributes.Add((int)GLXAttribute.ACCUM_BLUE_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Blue);
                visualAttributes.Add((int)GLXAttribute.ACCUM_GREEN_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Green);
                visualAttributes.Add((int)GLXAttribute.ACCUM_RED_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Red);
            }

            if (mode.Samples > 0)
            {
                visualAttributes.Add((int)GLXAttribute.SAMPLE_BUFFERS);
                visualAttributes.Add(1);
                visualAttributes.Add((int)GLXAttribute.SAMPLES);
                visualAttributes.Add(mode.Samples);
            }

            if (mode.Stereo)
                visualAttributes.Add((int)GLXAttribute.STEREO);

            visualAttributes.Add(0);

            Debug.Print("Falling back to glXChooseVisual.");
            IntPtr display = API.DefaultDisplay;
            using (new XLock(display))
            {
                return Glx.ChooseVisual(display, Functions.XDefaultScreen(display), visualAttributes.ToArray());
            }
        }

        #endregion
    }
}
