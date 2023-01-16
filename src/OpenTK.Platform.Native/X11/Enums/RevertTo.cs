using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public enum RevertTo : int
    {
        RevertToNone = 0,
        RevertToPointerRoot = 1,
        RevertToParent = 2,
    }
}
