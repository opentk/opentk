#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    interface IGameWindow : INativeGLWindow
    {
        void Run();

        void OnRenderFrame(RenderFrameEventArgs e);
        void OnUpdateFrame(UpdateFrameEventArgs e);
        void OnLoad(EventArgs e);
        void Exit();

        void SwapBuffers();

        event UpdateFrameEvent UpdateFrame;
        event RenderFrameEvent RenderFrame;
        event LoadEvent Load;

        bool IsExiting { get; }
        IList<OpenTK.Input.Keyboard> Keyboard { get; }
    }

    public delegate void UpdateFrameEvent(object sender, UpdateFrameEventArgs e);
    public delegate void RenderFrameEvent(object sender, RenderFrameEventArgs e);
    public delegate void LoadEvent(object sender, EventArgs e);
}
