using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    interface INativeWindow : IResizable, IDisposable
    {
        void ProcessEvents();

        event CreateEvent Create;

        bool IsIdle { get; }
        bool Quit { get; set; }
        bool Fullscreen { get; set; }
        IGLContext Context { get; }
    }
}
