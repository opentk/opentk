using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    internal class ModelView : ITestApp
    {
        public string Name => "Model Viewer";

        public WindowHandle Window;
        public OpenGLContextHandle Context;

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Window = window;
            Context = context;

            Debug.Assert(useGLES == false, "This app doesn't support GLES atm.");
        }

        public void HandleEvent(EventArgs args)
        {
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        public void Render()
        {
        }

        public void Deinitialize()
        {
        }
    }
}
