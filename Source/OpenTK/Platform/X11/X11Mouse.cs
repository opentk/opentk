#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    class X11Mouse : IMouseDriver
    {
        #region --- IMouseDriver Members ---

        public IList<Mouse> Mouse
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public int RegisterDevices()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
