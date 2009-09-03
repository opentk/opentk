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

namespace OpenTK
{
    /// <summary>
    /// Defines the arguments for frame events.
    /// A FrameEventArgs instance is only valid for the duration of the relevant event;
    /// do not store references to FrameEventArgs outside this event.
    /// </summary>
    public class FrameEventArgs : EventArgs
    {
        double elapsed;

        /// <summary>
        /// Constructs a new FrameEventArgs instance. 
        /// </summary>
        public FrameEventArgs()
        { }
        
        /// <summary>
        /// Constructs a new FrameEventArgs instance. 
        /// </summary>
        /// <param name="elapsed">The amount of time that has elapsed since the previous event, in seconds.</param>
        public FrameEventArgs(double elapsed)
        {
            Time = elapsed;
        }

        /// <summary>
        /// Gets a <see cref="System.Double"/> that indicates how many seconds of time elapsed since the previous event.
        /// </summary>
        public double Time 
        {
            get { return elapsed; }
            internal set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                elapsed = value;
            }
        }
    }
}
