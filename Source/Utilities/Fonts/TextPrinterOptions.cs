using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    [Flags]
    public enum TextPrinterOptions
    {
        Default = 0,
        NoCache = 1,
        RightToLeft = 2,
        Vertical = 4,
    }
}
