#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    internal class X11XrandrDisplayDevice : IDisplayDeviceDriver
    {
        #region --- Constructors ---

        static X11XrandrDisplayDevice()
        {
            // Construct a default device for testing purposes.
            new DisplayDevice(new DisplayResolution(800, 600, 24, 0), true,
                new DisplayResolution[]
                {
                    new DisplayResolution(800, 600, 24, 0)
                });
        }

        public X11XrandrDisplayDevice()
        {
        }

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public void RestoreResolution(DisplayDevice device)
        {
            
        }

        #endregion
    }
}
