using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public class X11MouseComponent : IMouseComponent
    {
        public string Name => nameof(X11MouseComponent);

        public PalComponents Provides => PalComponents.MiceInput;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }
        }

        public bool IsMultiMouse => throw new NotImplementedException();

        public int GetMouseCount()
        {
            throw new NotImplementedException();
        }

        public MouseHandle Create(int index)
        {
            throw new NotImplementedException();
        }

        public void Destroy(MouseHandle handle)
        {
            throw new NotImplementedException();
        }

        public void GetPosition(MouseHandle handle, out int x, out int y)
        {
            byte ret = XQueryPointer(X11.Display, X11.DefaultRootWindow, out XWindow root, out XWindow child, out int root_x, out int root_y, out int win_x, out int win_y, out _);

            x = root_x;
            y = root_y;
        }

        public void SetPosition(MouseHandle handle, int x, int y)
        {
            XWarpPointer(X11.Display, XWindow.None, X11.DefaultRootWindow, 0, 0, 0, 0, x, y);
        }
    }
}
