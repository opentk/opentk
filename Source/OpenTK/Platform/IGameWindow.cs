using System;
using System.Collections.Generic;
using System.Text;


namespace OpenTK.Platform
{
    interface IGameWindow : INativeGLWindow
    {
        void Run();

        void OnRenderFrame();
        void OnUpdateFrame();

        event UpdateFrameEvent UpdateFrame;
        event RenderFrameEvent RenderFrame;

        bool IsExiting { get; }
        IList<OpenTK.Input.Keyboard> Keyboard { get; }
    }

    public delegate void UpdateFrameEvent(EventArgs e);
    public delegate void RenderFrameEvent(EventArgs e);
}
