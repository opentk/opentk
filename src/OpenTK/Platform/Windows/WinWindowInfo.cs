﻿//
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

using OpenTK.NT.Native;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Describes a win32 window.
    /// </summary>
    internal sealed class WinWindowInfo : IWindowInfo
    {
        private IntPtr dc;
        private bool disposed;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WinWindowInfo()
        {
        }

        /// <summary>
        /// Constructs a new instance with the specified window handle and paren.t
        /// </summary>
        /// <param name="handle">The window handle for this instance.</param>
        /// <param name="parent">The parent window of this instance (may be null).</param>
        public WinWindowInfo(IntPtr handle, WinWindowInfo parent)
        {
            Handle = handle;
            Parent = parent;
        }

        /// <summary>
        /// Gets or sets the Parent of the window (may be null).
        /// </summary>
        public WinWindowInfo Parent { get; set; }

        /// <summary>
        /// Gets the device context for this window instance.
        /// </summary>
        public IntPtr DeviceContext
        {
            get
            {
                if (dc == IntPtr.Zero)
                {
                    dc = User32.DeviceContext.GetDC(Handle);
                }

                return dc;
            }
        }

        // For compatibility with whoever thought it would be
        // a good idea to access internal APIs through reflection
        // (e.g. MonoGame)
        public IntPtr WindowHandle
        {
            get => Handle;
            set => Handle = value;
        }

        /// <summary>
        /// Gets or sets the handle of the window.
        /// </summary>
        public IntPtr Handle { get; set; }

        /// <summary>
        /// Releases the unmanaged resources consumed by this instance.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns a System.String that represents the current window.
        /// </summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return $"Windows.WindowInfo: Handle {Handle}, Parent ({(Parent != null ? Parent.ToString() : "null")})";
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

            var info = (WinWindowInfo)obj;

            if (info == null)
            {
                return false;
            }

            // TODO: Assumes windows will always have unique handles.
            return Handle.Equals(info.Handle);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <c>WinWindowInfo</c>.</returns>
        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (dc != IntPtr.Zero)
                {
                    if (!User32.DeviceContext.ReleaseDC(Handle, dc))
                    {
                        Debug.Print("[Warning] Failed to release device context {0}. Windows error: {1}.", dc,
                            Marshal.GetLastWin32Error());
                    }
                }

                if (manual)
                {
                    if (Parent != null)
                    {
                        Parent.Dispose();
                    }
                }

                disposed = true;
            }
        }

        ~WinWindowInfo()
        {
            Dispose(false);
        }
    }
}
