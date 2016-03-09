// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

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