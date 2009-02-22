using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines available alignments for text.
    /// </summary>
    public enum TextAlignment
    {
        /// <summary>The text is aligned to the near side (left for left-to-right text and right for right-to-left text).</summary>
        Near = 0,
        /// <summary>The text is aligned to the center.</summary>
        Center,
        /// <summary>The text is aligned to the far side (right for left-to-right text and left for right-to-left text).</summary>
        Far
    }
}
