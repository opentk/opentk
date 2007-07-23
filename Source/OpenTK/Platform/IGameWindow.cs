using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    interface IGameWindow : IDisposable
    {
        void Run();

        void RenderFrame();
        void UpdateFrame();

        event UpdateFrameEvent UpdateFrameNotify;
        event RenderFrameEvent RenderFrameNotify;
    }

    public delegate void UpdateFrameEvent(EventArgs e);
    public delegate void RenderFrameEvent(EventArgs e);
}
