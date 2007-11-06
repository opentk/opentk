using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Fonts
{
    public class TextHandle
    {
        internal TextHandle(int handle)
        {
            Handle = handle;
        }

        public readonly int Handle;
        internal TextureFont font;

        public override string ToString()
        {
            return String.Format("TextHandle: {0}", Handle);
        }
    }
}
