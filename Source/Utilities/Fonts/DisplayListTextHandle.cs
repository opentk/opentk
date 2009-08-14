#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics.OpenGL;

namespace OpenTK.Graphics
{
    [Obsolete()]
    class DisplayListTextHandle : TextHandle
    {
        public DisplayListTextHandle(int handle) : base(handle) { }

        public override string ToString()
        {
            return String.Format("TextHandle (display list): {0}", Handle);
        }

        protected override void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    GL.DeleteLists(Handle, 1);
                }
                disposed = true;
            }
        }
    }
}
