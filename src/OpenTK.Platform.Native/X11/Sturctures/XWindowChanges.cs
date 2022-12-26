using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public struct XWindowChanges
    {
        public int x, y;
        public int width, height;
        public int border_width;
        public XWindow sibling;
        public int stack_mode;
    }
}
