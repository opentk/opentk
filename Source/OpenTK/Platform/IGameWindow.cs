using System;
using System.Collections.Generic;
using System.Text;


namespace OpenTK.Platform
{
    interface IGameWindow : INativeWindow
    {
        void Run();

        void OnRenderFrame();
        void OnUpdateFrame();

        event UpdateFrameEvent UpdateFrame;
        event RenderFrameEvent RenderFrame;
    }

    public delegate void UpdateFrameEvent(EventArgs e);
    public delegate void RenderFrameEvent(EventArgs e);
}
