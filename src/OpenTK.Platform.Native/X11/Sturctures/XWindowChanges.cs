using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public struct XWindowChanges
    {
        public int X, Y;
        public int Width, Height;
        public int BorderWidth;
        public XWindow Sibling;
        public int StackMode; // FIXME: Enum
    }
}
