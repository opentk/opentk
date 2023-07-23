using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    class WindowManager
    {
        private readonly List<WindowHandle> windows = new List<WindowHandle>();
        private readonly List<OpenGLContextHandle?> contexts = new List<OpenGLContextHandle?>();
        private readonly List<ITestApp?> testApps = new List<ITestApp?>();

        public WindowHandle RootWindow { get; }
        public OpenGLContextHandle? RootContext { get; }

        public IReadOnlyList<WindowHandle> Windows => windows;
        public IReadOnlyList<OpenGLContextHandle?> Contexts => contexts;

        public int Count => Windows.Count;

        public (WindowHandle window, OpenGLContextHandle? context) this[int i]
        {
            get => (Windows[i], Contexts[i]);
        }

        public WindowManager(WindowHandle rootWindow, OpenGLContextHandle? rootContext)
        {
            RootWindow = rootWindow;
            RootContext = rootContext;

            windows.Add(rootWindow);
            contexts.Add(rootContext);
            testApps.Add(null);
        }

        public void SetOpenGLContext(int i, OpenGLContextHandle? context)
        {
            contexts[i] = context;
        }

        public void SetTestApp(int i, ITestApp? app)
        {
            if (contexts[i] == null)
            {
                return;
            }

            ITestApp? old = testApps[i];
            old?.Deinitialize(true);

            if (app != null)
            {
                OpenGLContextHandle context = contexts[i]!;
                Program.OpenGLComp.SetCurrentContext(context);
                app.Initialize(windows[i], context);
                Program.OpenGLComp.SetCurrentContext(RootContext);
            }

            testApps[i] = app;
        }

        public int AddWindow(WindowHandle window, OpenGLContextHandle? context)
        {
            int count = Count;

            windows.Add(window);
            contexts.Add(context);
            testApps.Add(null);

            return count;
        }

        public void RemoveWindow(int i)
        {
            if (i == 0) throw new Exception("You cannot free the first window.");
            var(window, context) = this[i];

            if (context != null) Program.OpenGLComp.DestroyContext(context);
            Program.WindowComp.Destroy(window);

            windows.RemoveAt(i);
            contexts.RemoveAt(i);
        }

        public void RenderChildWindows()
        {
            bool restoreContext = false;

            for (int i = 1; i < Count; i++)
            {
                ITestApp? app = testApps[i];
                if (app == null) continue;

                OpenGLContextHandle? context = contexts[i];
                if (context == null) continue;

                restoreContext = true;
                Program.OpenGLComp.SetCurrentContext(context);
                app.Render();

            }

            if (restoreContext) Program.OpenGLComp.SetCurrentContext(RootContext);
        }
    }
}