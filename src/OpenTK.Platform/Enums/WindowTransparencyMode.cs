using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Represent possible transparency modes.
    /// </summary>
    /// <seealso cref="IWindowComponent.SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/>
    /// <seealso cref="IWindowComponent.GetTransparencyMode(WindowHandle)"/>
    public enum WindowTransparencyMode
    {
        /// <summary>
        /// The window is not transparent at all.
        /// This is the default.
        /// </summary>
        Opaque,

        /// <summary>
        /// Use framebuffer alpha to alpha composit this window per-pixel.
        /// Window border is unaffected.
        /// </summary>
        TransparentFramebuffer,

        /// <summary>
        /// Make the entire window transparent.
        /// Use <see cref="IWindowComponent.SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/> <c>opacity</c> argument to specify window opacity.
        /// </summary>
        TransparentWindow,
    }
}
