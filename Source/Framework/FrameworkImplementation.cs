using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Frameworks
{
    public partial class Framework
    {
        internal abstract class FrameworkImplementation
        {
            abstract public void OnHandleCreated(object sender, EventArgs args);
            abstract public bool IsIdle();
            abstract public void Setup();
            //abstract public void CloseWindow();
            abstract public bool ToggleFullscreen(bool fullscreen);
        }
    }
}
