#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Provides methods to create and control an opengl context on X11.
    /// </summary>
    public sealed class X11GLContext : OpenTK.Platform.IGLContext
    {
        private IntPtr context;
        private DisplayMode mode;// = new DisplayMode();
        internal WindowInfo windowInfo;

        //private IntPtr desktopResolution = IntPtr.Zero;

        //private int depthBits;
        //private int stencilBits;

        // These have to be used by the X11GLControl.
        private IntPtr visual;

        private bool disposed;

        #region --- Public Constructor ---

        internal X11GLContext()
            : this(new DisplayMode())
        {
        }

        internal X11GLContext(DisplayMode mode)
        {
            this.windowInfo = new WindowInfo();
            this.mode = mode;
        }

        #endregion

        #region internal DisplayMode Mode

        internal DisplayMode Mode
        {
            get { return mode; }
            set
            {
                if (context == IntPtr.Zero)
                {
                    mode = value;
                }
                else
                {
                    Debug.Print("Cannot change DisplayMode of an existing context.");
                }
            }
        }

        #endregion

        #region internal void PrepareContext(X11.WindowInfo info)

        internal void PrepareContext(X11.WindowInfo info)
        {
            this.windowInfo = new WindowInfo(info);

            Debug.Print("Preparing visual for DisplayMode: {0}", mode.ToString());

            /*
int[] attrib =
    {
        (int)Glx.Enums.GLXAttribute.RGBA,
        (int)Glx.Enums.GLXAttribute.RED_SIZE, 1,
        (int)Glx.Enums.GLXAttribute.GREEN_SIZE, 1,
        (int)Glx.Enums.GLXAttribute.BLUE_SIZE, 1,
        (int)Glx.Enums.GLXAttribute.DEPTH_SIZE, 1,
        (int)Glx.Enums.GLXAttribute.DOUBLEBUFFER,
        0
    };
visual = Glx.ChooseVisual(windowInfo.Display, windowInfo.Screen, attrib);
*/

            List<int> visualAttributes = new List<int>();
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            visualAttributes.Add((int)mode.Color.Red);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            visualAttributes.Add((int)mode.Color.Green);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            visualAttributes.Add((int)mode.Color.Blue);
            //visualAttributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            //visualAttributes.Add((int)mode.Color.Alpha);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            visualAttributes.Add((int)mode.DepthBits);
            visualAttributes.Add((int)1);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)0);

            //try
            //{
            visual = Glx.ChooseVisual(windowInfo.Display, windowInfo.Screen, visualAttributes.ToArray());
            if (visual == IntPtr.Zero)
            {
                throw new ApplicationException(String.Format("Requested DisplayMode not available ({0}).", mode.ToString()));
            }
            else
            {
                windowInfo.VisualInfo = (VisualInfo)Marshal.PtrToStructure(visual, typeof(VisualInfo));
                Debug.Print("Prepared visual: {0}", windowInfo.VisualInfo.ToString());
            }
            //}
            //catch (Exception e)
            //{
            //    Debug.Print(e.ToString());
            //    throw;
            //}
        }

        #endregion

        #region internal void CreateContext(X11GLContext shareContext, bool direct)

        internal void CreateContext(X11GLContext shareContext, bool direct)
        {
            Debug.WriteLine("Creating opengl context.");
            Debug.Indent();

            IntPtr shareHandle = shareContext != null ? shareContext.windowInfo.Handle : IntPtr.Zero;
            Debug.WriteLine(shareHandle == IntPtr.Zero ? "Context is not shared." :
                String.Format("Context is shared with context: {0}", shareHandle));

            Debug.WriteLine(direct ? "Context is direct." : "Context is indirect.");

            context = Glx.CreateContext(windowInfo.Display, visual, shareHandle, direct);
            if (context != IntPtr.Zero)
            {
                Debug.WriteLine(String.Format("New opengl context created. (id: {0})", context));
                Debug.Unindent();
            }
            else
            {
                throw new ApplicationException("Glx.CreateContext call failed (returned 0).");
            }
        }

        #endregion

        #region --- IGLContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Debug.Print("Swapping buffers");
            Glx.SwapBuffers(windowInfo.Display, windowInfo.Handle);
        }

        #endregion

        #region public void MakeCurrent()

        bool result;
        public void MakeCurrent()
        {
            Debug.Write(String.Format("Making context {0} current on thread {1} (Display: {2}, Screen: {3}, Window: {4})... ",
                    context, System.Threading.Thread.CurrentThread.ManagedThreadId, windowInfo.Display, windowInfo.Screen, windowInfo.Handle));

            if (windowInfo.Display != IntPtr.Zero && windowInfo.Handle != IntPtr.Zero && context != IntPtr.Zero)
            {
                result = Glx.MakeCurrent(windowInfo.Display, windowInfo.Handle, context);
                
                if (!result)
                {
                    Debug.WriteLine("failed.");
                    // probably need to recreate context here.
                    //throw new ApplicationException(String.Format("Failed to make context {0} current on thread {1}.",
                    //    context, System.Threading.Thread.CurrentThread.ManagedThreadId));
                }
                else
                {
                    Debug.WriteLine("done!");
                }
            }
        }

        #endregion

        public bool IsCurrent()
        {
            throw new NotImplementedException();
        }

        #region public IntPtr GetAddress(string function)

        public IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        #endregion

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                // Clean unmanaged resources:
                Glx.MakeCurrent(windowInfo.Display, IntPtr.Zero, IntPtr.Zero);
                Glx.DestroyContext(windowInfo.Display, context);
                API.Free(visual);

                if (manuallyCalled)
                {
                    // Safe to clean managed resources, too
                }
            }
            disposed = true;
        }

        ~X11GLContext()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
