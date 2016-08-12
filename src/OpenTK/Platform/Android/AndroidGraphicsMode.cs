using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Android
{
    [Obsolete("Kept for Xamarin compatibility, use GraphicsMode instead")]
    public class AndroidGraphicsMode : GraphicsMode
    {
        /// <summary>
        /// Creates an AndroidGraphicsMode instance with the defined settings.
        /// Defaults to EGL 1.x. To use EGL 2.0, call the
        /// <see cref="M:OpenTK.Platform.Android.AndroidGraphicsMode(Javax.Microedition.Khronos.Egl.EGLDisplay,int,OpenTK.Graphics.GraphicsMode)" />
        /// or
        /// <see cref="M:OpenTK.Platform.Android.AndroidGraphicsMode(Javax.Microedition.Khronos.Egl.EGLDisplay,int,OpenTK.Graphics.ColorFormat,int,int,int,int,bool)" />
        /// constructors (pass null to the display parameter for lazy initialization)
        /// </summary>
        public AndroidGraphicsMode(ColorFormat color, int depth, int stencil, int samples, int buffers, bool stereo) :
            this(null, 1, color, depth, stencil, samples, buffers, stereo)
        {
        }

        /// <summary>
        /// Creates an AndroidGraphicsMode instance, copying the values set in the mode parameter.
        /// Passing null to the display parameter for lazy initialization is recommended.
        /// </summary>
        /// <param name="display">
        /// A <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" /> with the display to use for creating the
        /// <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" /> that represents this graphics configuration in
        /// the OpenGL space. Pass null for lazy initialization.
        /// </param>
        /// <param name="majorVersion">Requested OpenGL version (1 or 2)</param>
        /// <param name="mode">GraphicsMode to copy values from.</param>
        public AndroidGraphicsMode(object display_ignored, int majorVersion, GraphicsMode mode) :
            this(display_ignored, majorVersion, mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples, mode.Buffers, mode.Stereo)
        {
        }

        /// <summary>
        /// Creates an AndroidGraphicsMode instance with the required settings.
        /// Passing null to the display parameter for lazy initialization is recommended.
        /// </summary>
        /// <param name="display">
        /// A <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" /> with the display to use for creating the
        /// <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" /> that represents this graphics configuration in
        /// the OpenGL space. Pass null for lazy initialization.
        /// </param>
        /// <param name="majorVersion">Requested OpenGL version (1 or 2)</param>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="stereo">Set to true for a GraphicsMode with stereographic capabilities.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        public AndroidGraphicsMode(object display_ignored, int majorVersion, ColorFormat color, int depth, int stencil, int samples, int buffers, bool stereo)
            : base(color, depth, stencil, samples, 0, buffers, stereo)
        {
        }
    }
}