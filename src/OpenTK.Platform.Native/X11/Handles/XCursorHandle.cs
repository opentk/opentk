using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public class XCursorHandle : CursorHandle
    {
        public XCursor Cursor { get; set; }

        public XCursorHandle()
        {
        }
    }
}
