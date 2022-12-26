using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public enum XWindowChangesMask
    {
        CWX = (1<<0),
        CWY = (1<<1),
        CWWidth = (1<<2),
        CWHeight = (1<<3),
        CWBorderWidth = (1<<4),
        CWSibling = (1<<5),
        CWStackMode = (1<<6),
    }
}
