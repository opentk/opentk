#region License
//
// CocoaWindowInfo.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    /// \internal
    /// <summary>
    /// Describes a Cocoa window.
    /// </summary>
    sealed class CocoaWindowInfo : IWindowInfo
    {
        static readonly IntPtr selContentView = Selector.Get("contentView");

        IntPtr nsWindowRef;
        IntPtr nsViewRef;

        bool disposed = false;

        #region Constructors

        /// <summary>
        /// Constructs a new instance with the specified parameters.
        /// </summary>
        /// <remarks>This constructor assumes that the NSWindow's contentView is the NSView we want to attach to our context.</remarks>
        /// <param name="nsWindowRef">A valid NSWindow reference.</param>
        public CocoaWindowInfo(IntPtr nsWindowRef) : this(nsWindowRef, Cocoa.SendIntPtr(nsWindowRef, selContentView))
        {

        }

        /// <summary>
        /// Constructs a new instance with the specified parameters.
        /// </summary>
        /// <param name="nsWindowRef">A valid NSWindow reference.</param>
        /// <param name="nsViewRef">A valid NSView reference.</param>
        public CocoaWindowInfo(IntPtr nsWindowRef, IntPtr nsViewRef)
        {
            this.nsWindowRef = nsWindowRef;
            this.nsViewRef = nsViewRef;
            Cocoa.SendVoid(nsWindowRef, Selector.Retain);
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the window reference for this instance.
        /// </summary>
        public IntPtr Handle { get { return nsWindowRef; } }

        /// <summary>
        /// Gets the view reference for this instance.
        /// </summary>
        public IntPtr ViewHandle { get { return nsViewRef; } }

        /// <summary>Returns a System.String that represents the current window.</summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return String.Format("MacOS.CocoaWindowInfo: NSWindow {0}, NSView {1}", nsWindowRef, nsViewRef);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
        }

        void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Cocoa.SendVoid(nsWindowRef, Selector.Release);
            }
            else
            {
                Debug.Print("CocoaWindowInfo:{0} leaked, did you forget to call Dispose()?", nsWindowRef);
            }

            disposed = true;
        }

        #if DEBUG
        ~CocoaWindowInfo()
        {
            Dispose(false);
        }
        #endif

        #endregion
    }
}