//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    /// \internal
    /// <summary>
    /// Describes an X11 window.
    /// </summary>
    internal sealed class X11WindowInfo : IWindowInfo
    {
        private readonly XVisualInfo visualInfo;

        /// <summary>
        /// Constructs a new X11WindowInfo class.
        /// </summary>
        public X11WindowInfo()
        {
        }

        /// <summary>
        /// Constructs a new X11WindowInfo class from the specified window handle and parent.
        /// </summary>
        /// <param name="handle">The handle of the window.</param>
        /// <param name="parent">The parent of the window.</param>
        public X11WindowInfo(IntPtr handle, X11WindowInfo parent)
        {
            Handle = handle;
            Parent = parent;
            if (parent != null)
            {
                RootWindow = parent.RootWindow;
                Display = parent.Display;
                Screen = parent.Screen;
                visualInfo = parent.visualInfo;
            }
        }

        /// <summary>
        /// Gets or sets the parent of the window.
        /// </summary>
        public X11WindowInfo Parent { get; set; }

        /// <summary>
        /// Gets or sets the X11 root window.
        /// </summary>
        public IntPtr RootWindow { get; set; }

        /// <summary>
        /// Gets or sets the connection to the X11 display.
        /// </summary>
        public IntPtr Display { get; set; }

        /// <summary>
        /// Gets or sets the X11 screen.
        /// </summary>
        public int Screen { get; set; }

        /// <summary>
        /// Gets or sets the X11 VisualInfo.
        /// </summary>
        public XVisualInfo VisualInfo
        {
            get
            {
                if (Visual != IntPtr.Zero)
                {
                    return (XVisualInfo)Marshal.PtrToStructure(Visual, typeof(XVisualInfo));
                }

                return default(XVisualInfo);
            }
        }

        /// <summary>
        /// Gets or sets the X11 EventMask.
        /// </summary>
        public EventMask EventMask { get; set; }

        // For compatibility with whoever thought it would be
        // a good idea to access internal APIs through reflection
        // (e.g. MonoGame)
        public IntPtr WindowHandle
        {
            get => Handle;
            set => Handle = value;
        }

        public IntPtr Visual { get; set; }
        public IntPtr FBConfig { get; set; }
        public GraphicsMode GraphicsMode { get; set; }

        /// <summary>
        /// Gets or sets the handle of the window.
        /// </summary>
        public IntPtr Handle { get; set; }

        /// <summary>
        /// Disposes of this X11WindowInfo instance.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Returns a System.String that represents the current window.
        /// </summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return
                $"X11.WindowInfo: Display {Display}, Screen {Screen}, Handle {Handle}, Parent: ({(Parent != null ? Parent.ToString() : "null")})";
        }

        /// <summary>
        /// Checks if <c>this</c> and <c>obj</c> reference the same win32 window.
        /// </summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>True if <c>this</c> and <c>obj</c> reference the same win32 window; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var info = (X11WindowInfo)obj;

            if (info == null)
            {
                return false;
            }

            // TODO: Assumes windows will have unique handles per X11 display.
            return Equals(Display, info.Display) &&
                   Handle.Equals(info.Handle);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <c>X11WindowInfo</c>.</returns>
        public override int GetHashCode()
        {
            return Handle.GetHashCode() ^ Display.GetHashCode();
        }
    }
}
