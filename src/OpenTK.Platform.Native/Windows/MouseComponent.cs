using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    public class MouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32Mouse";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new Exception("OpenGLComponent can only initialize the OpenGL component.");
            }
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            // FIXME: Check the handle!

            // FIXME: When hibernating (or going out of hibernate) this function fails with 0x5 Access denied.
            bool success = Win32.GetCursorPos(out Win32.POINT lpPoint);
            if (success == false)
            {
                //throw new Win32Exception();
            }

            x = lpPoint.X;
            y = lpPoint.Y;
        }

        /// <inheritdoc/>
        public void SetPosition(int x, int y)
        {
            // FIXME: Check the handle!

            bool success = Win32.SetCursorPos(x, y);
            if (success == false)
            {
                throw new Win32Exception("SetCursorPos failed.");
            }
        }
    }
}
