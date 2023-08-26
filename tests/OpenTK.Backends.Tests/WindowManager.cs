using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    class WindowManager
    {
        private readonly IWindowComponent WindowComponent;
        private readonly IOpenGLComponent OpenGLComponent;

        public readonly List<WindowData> Windows = new List<WindowData>();

        public WindowHandle RootWindow { get; }
        public OpenGLContextHandle? RootContext { get; }

        public WindowManager(
            IWindowComponent windowComponent,
            IOpenGLComponent openGLComponent,
            WindowHandle rootWindow,
            OpenGLContextHandle rootContext)
        {
            WindowComponent = windowComponent;
            OpenGLComponent = openGLComponent;
            RootWindow = rootWindow;
            RootContext = rootContext;
        }

        public void RenderChildWindows()
        {
            foreach (WindowData data in Windows)
            {
                data.Render(true);
            }

            OpenGLComponent.SetCurrentContext(RootContext);
        }

        public void AddWindow(WindowHandle window)
        {
            Windows.Add(new WindowData(this, window));
        }

        public void RemoveWindow(WindowHandle handle)
        {
            int i = Windows.FindIndex(x => x.Window == handle);

            if (i != -1)
            {
                Windows[i].Dispose();
                Windows.RemoveAt(i);
            }
        }

        public class WindowData : IDisposable
        {
            public WindowManager Manager { get; }
            public WindowHandle Window { get; }

            // FIXME: Lets not have complicated setters
            public OpenGLContextHandle? Context
            {
                get => context;
                set
                {
                    if (Application != null)
                    {
                        if (value == null)
                        {
                            Manager.OpenGLComponent.SetCurrentContext(context);
                            Application.Deinitialize();
                            Manager.OpenGLComponent.SetCurrentContext(Manager.RootContext);
                        }
                        else
                        {
                            Manager.OpenGLComponent.SetCurrentContext(value);
                            Application.Initialize(Window, value);
                            Manager.OpenGLComponent.SetCurrentContext(Manager.RootContext);
                        }
                    }

                    context = value;
                }
            }

            // FIXME: Lets not have complicated setters
            public ITestApp? Application
            {
                get => application;
                set
                {
                    if (Context == null)
                    {
                        application = value;
                        return;
                    }

                    Manager.OpenGLComponent.SetCurrentContext(Context);

                    if (application != null)
                    {
                        application.Deinitialize();
                    }

                    value?.Initialize(Window, Context);

                    Manager.OpenGLComponent.SetCurrentContext(Manager.RootContext);

                    application = value;
                }
            }

            private OpenGLContextHandle? context;
            private ITestApp? application;


            public WindowData(WindowManager manager, WindowHandle window)
            {
                Manager = manager;
                Window = window;
            }

            public void Render(bool noRestoreContext = false)
            {
                if (application == null) return;
                if (context == null) return;

                Manager.OpenGLComponent.SetCurrentContext(context);
                application.Render();

                if (!noRestoreContext)
                    Manager.OpenGLComponent.SetCurrentContext(Manager.RootContext);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            private bool isDisposed;
            void Dispose(bool isDisposing)
            {
                if (isDisposed) return;

                if (isDisposing)
                {
                    Manager.OpenGLComponent.SetCurrentContext(context);
                    Application?.Deinitialize();
                    Manager.OpenGLComponent.SetCurrentContext(Manager.RootContext);
                }

                isDisposed = true;
            }
        }
    }
}
