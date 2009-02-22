using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines available quality levels for text printing.
    /// </summary>
    public enum TextQuality
    {
        /// <summary>Use the default quality, as specified by the operating system.</summary>
        Default = 0,
        /// <summary>Use fast, low quality text (typically non-antialiased) .</summary>
        Low,
        /// <summary>Use medium quality text (typically grayscale antialiased).</summary>
        Medium,
        /// <summary>Use slow, high quality text (typically subpixel antialiased).</summary>
        High
    }
}
