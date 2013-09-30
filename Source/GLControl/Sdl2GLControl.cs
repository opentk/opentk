#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    class Sdl2GLControl : IGLControl
    {
        IWindowInfo window_info;
        GraphicsMode mode;

        public Sdl2GLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            window_info = Utilities.CreateSdl2WindowInfo(control.Handle);
            
            // On windows, we must set the SDL_WINDOW_OPENGL flag
            // otherwise context creation will fail.
            if (Configuration.RunningOnWindows)
            {
                // Set SDL_WINDOW_OPENGL in the SDL_Window->flags field
                int flags_offset = 52; // 2 * IntPtr.Size + 9 * sizeof(int);
                uint flags = (uint)Marshal.ReadInt32(window_info.Handle, 20);
                flags |= 2;
                Marshal.WriteInt32(window_info.Handle, flags_offset, (int)flags);
            }
        }

        public Graphics.IGraphicsContext CreateContext(int major, int minor, Graphics.GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, window_info, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return NativeMethods.SDL_HasEvents(0, 0xffff); }
        }

        public Platform.IWindowInfo WindowInfo
        {
            get { return window_info; }
        }

        static class NativeMethods
        {
            [DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool SDL_HasEvents(int minType, int maxType);
        }
    }
}
