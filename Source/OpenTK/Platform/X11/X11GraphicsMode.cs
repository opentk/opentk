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
        // Todo: Add custom visual selection algorithm, instead of ChooseFBConfig/ChooseVisual.
        // It seems the Choose* methods do not take multisampling into account (at least on some
        // drivers).
        
        #region Constructors

        public X11GraphicsMode()
        {
        }

        #endregion

        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum,
                                               int buffers, bool stereo)
        {
            GraphicsMode gfx;                               // The actual GraphicsMode that will be selected.
            IntPtr visual = IntPtr.Zero;
            IntPtr display = API.DefaultDisplay;

            // Try to select a visual using Glx.ChooseFBConfig and Glx.GetVisualFromFBConfig.
            // This is only supported on GLX 1.3 - if it fails, fall back to Glx.ChooseVisual.
            visual = SelectVisualUsingFBConfig(color, depth, stencil, samples, accum, buffers, stereo);
            
            if (visual == IntPtr.Zero)
                visual = SelectVisualUsingChooseVisual(color, depth, stencil, samples, accum, buffers, stereo);

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
            
            gfx = new GraphicsMode(info.VisualID, new ColorFormat(r, g, b, a), depth, stencil, samples,
                                   new ColorFormat(ar, ag, ab, aa), buffers, stereo);

            Functions.XFree(visual);
            
            return gfx;
        }

        #endregion

        #region Private Members

        // See http://publib.boulder.ibm.com/infocenter/systems/index.jsp?topic=/com.ibm.aix.opengl/doc/openglrf/glXChooseFBConfig.htm
        // for the attribute declarations. Note that the attributes are different than those used in Glx.ChooseVisual.
        IntPtr SelectVisualUsingFBConfig(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum,
                                               int buffers, bool stereo)
        {
            List<int> visualAttributes = new List<int>();
            IntPtr visual = IntPtr.Zero;

            Debug.Print("Bits per pixel: {0}", color.BitsPerPixel);

            if (color.BitsPerPixel > 0)
            {
                if (!color.IsIndexed)
                {
                    visualAttributes.Add((int)GLXAttribute.RGBA);
                    visualAttributes.Add(1);
                }
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
            {
                visualAttributes.Add((int)GLXAttribute.DOUBLEBUFFER);
                visualAttributes.Add(1);
            }

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
            
            if (samples > 0)
            {
                visualAttributes.Add((int)GLXAttribute.SAMPLE_BUFFERS);
                visualAttributes.Add(1);
                visualAttributes.Add((int)GLXAttribute.SAMPLES);
                visualAttributes.Add(samples);
            }

            if (stereo)
            {
                visualAttributes.Add((int)GLXAttribute.STEREO);
                visualAttributes.Add(1);
            }

            visualAttributes.Add(0);

            // Select a visual that matches the parameters set by the user.
            IntPtr display = API.DefaultDisplay;
            try
            {
                Functions.XLockDisplay(display);
    
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
                        visual = Glx.GetVisualFromFBConfig(display, *fbconfigs);
                        Functions.XFree((IntPtr)fbconfigs);
                    }
                }
            }
            catch (EntryPointNotFoundException)
            {
                Debug.Print("Function glXChooseFBConfig not supported.");
                return IntPtr.Zero;
            }
            finally
            {
                Functions.XUnlockDisplay(display);
            }

            return visual;
        }

        // See http://publib.boulder.ibm.com/infocenter/systems/index.jsp?topic=/com.ibm.aix.opengl/doc/openglrf/glXChooseVisual.htm
        IntPtr SelectVisualUsingChooseVisual(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum,
                                                  int buffers, bool stereo)
        {
            List<int> visualAttributes = new List<int>();

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
            
            if (samples > 0)
            {
                visualAttributes.Add((int)GLXAttribute.SAMPLE_BUFFERS);
                visualAttributes.Add(1);
                visualAttributes.Add((int)GLXAttribute.SAMPLES);
                visualAttributes.Add(samples);
            }

            if (stereo)
                visualAttributes.Add((int)GLXAttribute.STEREO);

            visualAttributes.Add(0);

            Debug.Print("Falling back to glXChooseVisual.");
            IntPtr display = API.DefaultDisplay;
            try
            {
                Functions.XLockDisplay(display);
                return Glx.ChooseVisual(display, Functions.XDefaultScreen(display), visualAttributes.ToArray());
            }
            finally
            {
                Functions.XUnlockDisplay(display);
            }
        }

        #endregion
    }
}
