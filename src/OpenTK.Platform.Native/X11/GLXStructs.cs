using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    internal struct GLXContext
    {
        public IntPtr Value { get; }

        public GLXContext(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXFBConfig
    {
        public IntPtr Value { get; }

        public GLXFBConfig(IntPtr value)
        {
            Value = value;
        }
    }
}
