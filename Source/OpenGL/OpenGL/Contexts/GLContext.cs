#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Stephen Apostolopoulos and Erik Ylvisaker.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL.Platform;

namespace OpenTK.OpenGL
{
    public abstract partial class GLContext : IDisposable
    {
        #region --- Private Variables ---

        private Control control;
        private bool isDisposed = false;
        private bool isFullScreen = false;
        private GLContext fullScreenContext = null;

        #endregion

        #region --- Creation / Destruction ---

        /// <summary>
        /// Constructs a GLContext abstract base class.  
        /// </summary>
        /// <param name="control"></param>
        protected GLContext(Control control)
        {
            this.control = control;
        }

        /// <summary>
        /// Finalizes the GLContext object.
        /// </summary>
        ~GLContext()
        {
            if (isDisposed == false)
                Dispose(false);
        }

        /// <summary>
        /// Disposes of the GLContext object.  If called on a full-screen context, this
        /// will return the display resolution to the desktop settings.
        /// </summary>
        public void Dispose()
        {
            if (isDisposed == false)
            {
                Dispose(true);

                isDisposed = true;

                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Override to provide platform-specific destruction methods.
        /// </summary>
        /// <param name="disposing"></param>
        protected abstract void Dispose(bool disposing);

        /// <summary>
        /// Creates an object driving from GLContext which handles the necessary
        /// details for interacting with the operating system the application is run on.
        /// </summary>
        /// <param name="c">The control to which the GLContext is bound.  OpenGL rendering
        /// will occur within this control.</param>
        /// <param name="color">A structure indicating the color depth the application is requesting.</param>
        /// <param name="depth">The number of bits the depth buffer should contain.</param>
        /// <param name="stencil">The number of bits the stencil buffer should contain.</param>
        /// <returns>A GLContext object.</returns>
        public static GLContext Create(Control c, ColorDepth color, int depth, int stencil)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                return new WindowsContext(c, color, depth, stencil);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                return new X11Context(c, color, depth, stencil);
            }
            else
            {
                throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
            }
        }

        #endregion

        #region --- Public Properties ---

        /// <summary>
        /// Returns the AspectRatio of the control this GLContext object
        /// renders to.  This is usually used in a call to Glu.Perspective.
        /// </summary>
        public double AspectRatio
        {
            get
            {
                return control.Width / (double)control.Height;
            }
        }

        /// <summary>
        /// Gets the width of the render target control in pixels.
        /// </summary>
        public int Width
        {
            get { return control.Width; }
        }
        
        /// <summary>
        /// Gets the height of the render target control in pixels.
        /// </summary>
        public int Height
        {
            get { return control.Height; }
        }
        
        /// <summary>
        /// Gets the size of the render target control.
        /// </summary>
        public Size Size
        {
            get { return control.Size; }
        }

        /// <summary>
        /// Returns true if this context is managing a full-screen environment.
        /// Only one context can manage a full-screen environment at a time.
        /// </summary>
        public bool IsFullscreen
        {
            get { return isFullScreen; }
            protected set
            {
                CheckAnyFullScreen();

                if (value)
                    fullScreenContext = this;
                else if (fullScreenContext == this)
                    fullScreenContext = null;

                isFullScreen = value;
            }
        }

        /// <summary>
        /// The WinForms Control that this GLContext is bound to.
        /// </summary>
        public Control Control
        {
            get { return control; }
        }

        /// <summary>
        /// Returns true if this object has had its Dispose method called.
        /// If IsDisposed is true, no calls should be made on the context object.
        /// </summary>
        public bool IsDisposed
        {
            get { return isDisposed; }
            set { isDisposed = value; }
        }

        #endregion

        #region --- Protected Helper Methods ---

        /// <summary>
        /// This method checks to see if any context other than the current one is a full-screen 
        /// context, and throws an exception if it is.  This is meant to be called from inside
        /// an overriden SetFullScreen function.
        /// </summary>
        protected void CheckAnyFullScreen()
        {
            if (fullScreenContext == null || fullScreenContext == this)
                return;

            throw new Exception("Already have a full screen context!");
        }

        #endregion

        #region --- Public Context Management Methods ---

        /// <summary>
        /// Swaps buffers on a context.  This presents the rendered scene to the user.
        /// </summary>
        public abstract void SwapBuffers();

        /// <summary>
        /// Makes this context the current rendering target.
        /// </summary>
        public abstract void MakeCurrent();
        
        /// <summary>
        /// Requests that the GLContext object set the screen to a particular resolution and color
        /// depth.  Only one context can be set to be a full screen context at a time.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="color"></param>
        public abstract void SetFullScreen(int width, int height, OpenTK.OpenGL.ColorDepth color);
        
        /// <summary>
        /// Restores the desktop resolution after a call to SetFullScreen.
        /// </summary>
        public abstract void SetWindowed();
        
        #endregion
        
        #region --- Display Mode Methods ---

        public abstract DisplayMode[] EnumDisplayModes();

        #endregion

        /// <summary>
        /// Gets the address of an OpenGL extension function.
        /// </summary>
        /// <param name="function_string">The name of the OpenGL function (e.g. "glGetString")</param>
        /// <param name="function_type">The function signature.</param>
        /// <returns>A Delegate that can be used to call this function, or null if the function is not supported by the drivers.</returns>
        protected abstract System.Delegate GetAddress(string function_string, Type function_type);
    }
}
