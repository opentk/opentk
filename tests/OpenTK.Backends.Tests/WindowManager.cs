using System;
using System.Collections;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    class WindowManager : IList<WindowManager.WindowData>
    {
        private readonly IWindowComponent WindowComponent;
        private readonly IOpenGLComponent OpenGLComponent;
        private readonly List<WindowData> windows = new List<WindowData>();

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

            EventQueue.EventRaised += EventRaised;
        }

        public void RenderChildWindows()
        {
            foreach (WindowData data in this)
            {
                data.Render(true);
            }

            OpenGLComponent.SetCurrentContext(RootContext);
        }

        void EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (type == PlatformEventType.Close)
            {
                int i = windows.FindIndex(x => x.Window == handle);

                if (i != -1)
                    RemoveAt(i);
            }
        }

        #region IList<>

        public int Count => windows.Count;
        public bool IsReadOnly => false;
        public WindowData this[int index]
        {
            get => windows[index];
            set => throw new InvalidOperationException();
        }

        public int IndexOf(WindowData item) => windows.IndexOf(item);
        public void Insert(int index, WindowData item) => windows.Insert(index, item);

        public void RemoveAt(int index)
        {
            WindowData data = windows[index];
            windows.RemoveAt(index);
            data.Dispose();
        }

        public void Add(WindowData item) => windows.Add(item);
        public void Add(WindowHandle window)
        {
            Add(new WindowData(this, window));
        }

        public void Clear()
        {
            foreach (WindowData data in this)
            {
                data.Dispose();
            }
            windows.Clear();
        }

        public bool Contains(WindowData item) => windows.Contains(item);

        public void CopyTo(WindowData[] array, int arrayIndex) => windows.CopyTo(array, arrayIndex);

        public bool Remove(WindowData item)
        {
            if (windows.Remove(item))
            {
                item.Dispose();
                return true;
            }

            return false;
        }

        public IEnumerator<WindowData> GetEnumerator() => windows.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => windows.GetEnumerator();

        #endregion

        public class WindowData : IDisposable
        {
            public WindowManager Manager { get; }
            public WindowHandle Window { get; }

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
                            Application.Deinitialize(true);
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
                        application.Deinitialize(true);
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

            private bool isDisposed;
            public void Dispose() => Dispose(true);
            void Dispose(bool isDisposing)
            {
                if (isDisposed) return;

                if (isDisposing)
                {
                    GC.SuppressFinalize(this);
                }

                Application?.Deinitialize(false);

                if (Context != null)
                {
                    Program.OpenGLComp.DestroyContext(Context);
                }

                Program.WindowComp.Destroy(Window);

                isDisposed = true;
            }
        }
    }
}