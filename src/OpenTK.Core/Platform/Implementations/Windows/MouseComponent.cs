using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    /// <inheritdoc/>
    public class MouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32Mouse";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new Exception("OpenGLComponent can only initialize the OpenGL component.");
            }
        }

        /// <inheritdoc/>
        public bool IsMultiMouse => false;

        private const int MouseCount = 1;

        /// <inheritdoc/>
        public int GetMouseCount()
        {
            return MouseCount;
        }

        /// <inheritdoc/>
        public MouseHandle Create(int index)
        {
            if (index < 0 || index >= MouseCount)
            {
                throw new ArgumentOutOfRangeException($"{nameof(index)} is out of bounds [0, {MouseCount}]");
            }

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Destroy(MouseHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetPosition(MouseHandle handle, out int x, out int y)
        {
            // FIXME: Check the handle!

            bool success = Win32.GetCursorPos(out Win32.POINT lpPoint);
            if (success == false)
            {
                throw new Win32Exception("GetCursorPos failed.");
            }

            x = lpPoint.X;
            y = lpPoint.Y;
        }

        /// <inheritdoc/>
        public void SetPosition(MouseHandle handle, int x, int y)
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
