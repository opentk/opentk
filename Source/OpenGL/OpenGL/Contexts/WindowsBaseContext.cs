using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.OpenGL;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL.Platform
{
    public class WindowsBaseContext : GLContext
    {
        protected const string _dll_name = "OPENGL32.DLL";
        protected int _dll_handle;
        protected int _device_context;
        protected int _render_context;
        protected IntPtr _window_handle;

        public override void SwapBuffers()
        {
            OpenTK.Platform.Windows.Api.SwapBuffers(_device_context);
        }

        public override Delegate GetAddress(string function_string, Type function_type)
        {
            IntPtr address = Wgl.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        public override void MakeCurrent()
        {
            Wgl.MakeCurrent(_device_context, _render_context);
        }

        public override void Dispose()
        {
            if (_render_context != 0)
                Wgl.DeleteContext(_render_context);

            if (_device_context != 0)
                OpenTK.Platform.Windows.Api.ReleaseDC(_window_handle.ToInt32(), _device_context);

            if (_dll_handle != 0)
                OpenTK.Platform.Windows.Api.FreeLibrary(_dll_handle);

            _render_context = 0;
            _device_context = 0;
            _dll_handle = 0;
        }
    }
}
