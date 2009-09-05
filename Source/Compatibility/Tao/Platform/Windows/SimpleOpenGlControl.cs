#region License
/*
MIT License
Copyright ©2003-2006 Tao Framework Team
http://www.taoframework.com
Copyright ©2009 the Open Toolkit library
http://www.opentk.com
 
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;

namespace Tao.Platform.Windows
{
    /// <summary>
    ///     Provides a simple OpenGL control allowing quick development of Windows.Forms-based
    ///     OpenGL applications. Relies on OpenTK.GLControl for cross-platform compatibility.
    /// </summary>
    [Obsolete("Use OpenTK.GLControl instead.")]
    public partial class SimpleOpenGlControl : OpenTK.GLControl
    {
        #region Fields

        private bool autoCheckErrors = false;                               // Should we provide glGetError()?
        private bool autoFinish = false;                                    // Should we provide a glFinish()?
        private bool autoMakeCurrent = true;                                // Should we automatically make the rendering context current?
        private bool autoSwapBuffers = true;                                // Should we automatically swap buffers?
        private byte accumBits = 0;                                         // Accumulation buffer bits
        private byte colorBits = 32;                                        // Color buffer bits
        private byte depthBits = 16;                                        // Depth buffer bits
        private byte stencilBits = 0;                                       // Stencil buffer bits
        private ErrorCode errorCode = ErrorCode.NoError;                             // The GL error code

        private int logScaleX = 96;                                         // DPI Resolution in X dir
        private int logScaleY = 96;                                         // DPI Resolution in Y dir

        #endregion

        #region Constructors

        #region SimpleOpenGlControl()
        /// <summary>
        ///     Constructor.  Creates contexts and sets properties.
        /// </summary>
        public SimpleOpenGlControl()
        {
            InitializeStyles();
            InitializeComponent();
            InitializeBackground();
        }
        #endregion SimpleOpenGlControl()

        #endregion

        #region Public Members

        #region DestroyContexts()
        /// <summary>
        /// 
        /// </summary>
        public void DestroyContexts()
        {
            Context.Dispose();
        }
        #endregion DestroyContexts()

        #region Draw()
        /// <summary>
        ///     Sends an see cref="UserControl.Invalidate"  command to this control, thus
        ///     forcing a redraw to occur.
        /// </summary>
        public void Draw()
        {
            this.Invalidate();
        }
        #endregion Draw()

        #region InitializeContexts()
        /// <summary>
        ///     Creates the OpenGL contexts.
        /// </summary>
        public void InitializeContexts()
        {
            // No need to do anything, handled by the GLControl.
        }
        #endregion InitializeContexts()

        #region LogScaleX

        /// <summary>
        /// Gets the number of logical pixels or dots per inch (dpi) in X-direction
        /// </summary>
        [Category("OpenGL Properties"), Description("Logical pixels per inch in X-direction.")]
        public int LogScaleX
        {
            get
            {
                return logScaleX;
            }
        }

        #endregion

        #region LogScaleY

        /// <summary>
        /// Gets the number of logical pixels or dots per inch (dpi) in Y-direction
        /// </summary>
        [Category("OpenGL Properties"), Description("Logical pixels per inch in Y-direction.")]
        public int LogScaleY
        {
            get
            {
                return logScaleY;
            }
        }

        #endregion

        #region AccumBits

        /// <summary>
        ///     Gets and sets the OpenGL control's accumulation buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Accumulation buffer depth in bits.")]
        public byte AccumBits
        {
            get
            {
                return accumBits;
            }
            set
            {
                accumBits = value;
            }
        }

        #endregion

        #region ColorBits

        /// <summary>
        ///     Gets and sets the OpenGL control's color buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Color buffer depth in bits.")]
        public byte ColorBits
        {
            get
            {
                return colorBits;
            }
            set
            {
                colorBits = value;
            }
        }

        #endregion

        #region DepthBits

        /// <summary>
        ///     Gets and sets the OpenGL control's depth buffer (Z-buffer) depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Depth buffer (Z-buffer) depth in bits.")]
        public byte DepthBits
        {
            get
            {
                return depthBits;
            }
            set
            {
                depthBits = value;
            }
        }

        #endregion

        #region StencilBits

        /// <summary>
        ///     Gets and sets the OpenGL control's stencil buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Stencil buffer depth in bits.")]
        public byte StencilBits
        {
            get
            {
                return stencilBits;
            }
            set
            {
                stencilBits = value;
            }
        }

        #endregion

        #region AutoCheckErrors

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a glGetError command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a glGetError command after drawing?")]
        public bool AutoCheckErrors
        {
            get
            {
                return autoCheckErrors;
            }
            set
            {
                autoCheckErrors = value;
            }
        }

        #endregion

        #region AutoFinish

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a glFinish command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a glFinish command after drawing?")]
        public bool AutoFinish
        {
            get
            {
                return autoFinish;
            }
            set
            {
                autoFinish = value;
            }
        }

        #endregion

        #region AutoMakeCurrent

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic forcing of the rendering context to
        ///     be current before drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically make the rendering context current before drawing?")]
        public bool AutoMakeCurrent
        {
            get
            {
                return autoMakeCurrent;
            }
            set
            {
                autoMakeCurrent = value;
            }
        }

        #endregion

        #region AutoSwapBuffers

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a SwapBuffers command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a SwapBuffers command after drawing?")]
        public bool AutoSwapBuffers
        {
            get
            {
                return autoSwapBuffers;
            }
            set
            {
                autoSwapBuffers = value;
            }
        }

        #endregion

        #endregion

        #region Protected Members

        #region OnPaint

        /// <summary>
        ///     Paints the control.
        /// </summary>
        /// <param name="e">The paint event arguments.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                e.Graphics.Clear(this.BackColor);
                if (this.BackgroundImage != null)
                    e.Graphics.DrawImage(this.BackgroundImage, this.ClientRectangle, 0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height, GraphicsUnit.Pixel);
                e.Graphics.Flush();
                return;
            }

            if (autoMakeCurrent)
            {
                MakeCurrent();
            }

            base.OnPaint(e);

            if (autoFinish)
            {
                GL.Finish();
            }

            if (autoCheckErrors)
            {
                errorCode = GL.GetError();
                if (errorCode != ErrorCode.NoError)
                {
                    switch (errorCode)
                    {
                        case ErrorCode.InvalidEnum:
                            MessageBox.Show("GL_INVALID_ENUM - An unacceptable value has been specified for an enumerated argument.  The offending function has been ignored.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case ErrorCode.InvalidValue:
                            MessageBox.Show("GL_INVALID_VALUE - A numeric argument is out of range.  The offending function has been ignored.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case ErrorCode.InvalidOperation:
                            MessageBox.Show("GL_INVALID_OPERATION - The specified operation is not allowed in the current state.  The offending function has been ignored.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case ErrorCode.StackOverflow:
                            MessageBox.Show("GL_STACK_OVERFLOW - This function would cause a stack overflow.  The offending function has been ignored.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case ErrorCode.StackUnderflow:
                            MessageBox.Show("GL_STACK_UNDERFLOW - This function would cause a stack underflow.  The offending function has been ignored.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case ErrorCode.OutOfMemory:
                            MessageBox.Show("GL_OUT_OF_MEMORY - There is not enough memory left to execute the function.  The state of OpenGL has been left undefined.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        default:
                            MessageBox.Show("Unknown GL error.  This should never happen.", "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
            }

            if (autoSwapBuffers)
            {
                SwapBuffers();
            }
        }

        #endregion

        #region CreateParams

        /// <summary>
        ///     Overrides the control's class style parameters.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                Int32 CS_VREDRAW = 0x1;
                Int32 CS_HREDRAW = 0x2;
                Int32 CS_OWNDC = 0x20;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_VREDRAW | CS_HREDRAW | CS_OWNDC;
                return cp;
            }
        }

        #endregion

        #endregion

        #region Private Members

        #region InitializeBackground

        /// <summary>
        ///     Loads the bitmap from the assembly's manifest resource.
        /// </summary>
        private void InitializeBackground()
        {
            try
            {
                this.BackgroundImage = OpenTK.Compatibility.Properties.Resources.TaoButton;
            }
            catch (Exception)
            {
                this.BackgroundImage = null;
            }
        }

        #endregion

        #region InitializeStyles

        /// <summary>
        ///     Initializes the control's styles.
        /// </summary>
        private void InitializeStyles()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, false);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        #endregion

        #endregion
    }
}