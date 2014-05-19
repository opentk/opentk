#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    /// \internal
    /// <summary>
    /// Describes a Carbon window.
    /// </summary>
    sealed class CarbonWindowInfo : IWindowInfo
    {
        IntPtr windowRef;
        bool ownHandle = false;
        bool disposed = false;
        bool isControl = true;
        bool goFullScreenHack = false;
        bool goWindowedHack = false;

        GetInt xOffset;
        GetInt yOffset;

        #region Constructors

        /// <summary>
        /// Constructs a new instance with the specified parameters.
        /// </summary>
        /// <param name="windowRef">A valid Carbon window reference.</param>
        /// <param name="ownHandle"></param>
        /// <param name="isControl"></param>
        public CarbonWindowInfo(IntPtr windowRef, bool ownHandle, bool isControl)
        {
            this.windowRef = windowRef;
            this.ownHandle = ownHandle;
            this.isControl = isControl;
        }

        public CarbonWindowInfo(IntPtr windowRef, bool ownHandle, bool isControl, GetInt getX, GetInt getY) : this(windowRef, ownHandle, isControl)
        {
            this.xOffset = getX;
            this.yOffset = getY;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the window reference for this instance.
        /// </summary>
        public IntPtr Handle
        {
            get { return this.windowRef; }
            set { this.windowRef = value; }
        }

        internal bool GoFullScreenHack
        {
            get { return goFullScreenHack; }
            set { goFullScreenHack = value; }
        }
        internal bool GoWindowedHack
        {
            get { return goWindowedHack; }
            set { goWindowedHack = value; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance refers to a System.Windows.Forms.Control.
        /// </summary>
        public bool IsControl
        {
            get { return isControl; }
        }

        /// <summary>Returns a System.String that represents the current window.</summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return String.Format("MacOS.CarbonWindowInfo: Handle {0}", this.Handle);
        }

        // For compatibility with whoever thought it would be
        // a good idea to access internal APIs through reflection
        // (e.g. MonoGame)
        public IntPtr WindowHandle { get { return Handle; } set { Handle = value; } }

        public GetInt XOffset
        {
            get { return xOffset; }
            set { xOffset = value; }
        }
        public GetInt YOffset
        {
            get { return yOffset; }
            set { yOffset = value; }
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
                
            }
            
            if (ownHandle)
            {
                windowRef = IntPtr.Zero;
            }
            
            disposed = true;
        }

        ~CarbonWindowInfo()
        {
            Dispose(false);
        }
        
        #endregion
    }
}
