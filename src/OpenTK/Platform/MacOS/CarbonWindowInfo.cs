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

namespace OpenTK.Platform.MacOS
{
    /// \internal
    /// <summary>
    /// Describes a Carbon window.
    /// </summary>
    internal sealed class CarbonWindowInfo : IWindowInfo
    {
        private bool ownHandle = false;
        private bool disposed = false;

        /// <summary>
        /// Constructs a new instance with the specified parameters.
        /// </summary>
        /// <param name="windowRef">A valid Carbon window reference.</param>
        /// <param name="ownHandle"></param>
        /// <param name="isControl"></param>
        public CarbonWindowInfo(IntPtr windowRef, bool ownHandle, bool isControl)
        {
            this.Handle = windowRef;
            this.ownHandle = ownHandle;
            this.IsControl = isControl;
        }

        public CarbonWindowInfo(IntPtr windowRef, bool ownHandle, bool isControl, GetInt getX, GetInt getY) : this(windowRef, ownHandle, isControl)
        {
            this.XOffset = getX;
            this.YOffset = getY;
        }

        /// <summary>
        /// Gets the window reference for this instance.
        /// </summary>
        public IntPtr Handle { get; set; }

        internal bool GoFullScreenHack { get; set; } = false;

        internal bool GoWindowedHack { get; set; } = false;

        /// <summary>
        /// Gets a value indicating whether this instance refers to a System.Windows.Forms.Control.
        /// </summary>
        public bool IsControl { get; } = true;

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

        public GetInt XOffset { get; set; }

        public GetInt YOffset { get; set; }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {

            }

            if (ownHandle)
            {
                Handle = IntPtr.Zero;
            }

            disposed = true;
        }

        ~CarbonWindowInfo()
        {
            Dispose(false);
        }

    }
}
