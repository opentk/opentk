using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    class X11GdiPlusInternals : IGdiPlusInternals
    {
        #region IGdiPlusInternals Members

        public IntPtr GetNativeGraphics(System.Drawing.Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public IntPtr GetNativeFont(System.Drawing.Font font)
        {
            throw new NotImplementedException();
        }

        public IntPtr GetNativeStringFormat(System.Drawing.StringFormat format)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
