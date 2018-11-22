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
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace OpenToolkit.Windowing.Interfaces
{
    /// <summary>
    /// Defines the interface for a GameWindow.
    /// </summary>
    public interface IGameWindow: IWindowProperties, IWindowEvents, IWindowInput, IDisposable
    {
        /// <summary>
        /// Closes this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Processes pending window events.
        /// </summary>
        void ProcessEvents();

        /// <summary>
        /// Enters the game loop of the GameWindow using the maximum update rate.
        /// </summary>
        /// <seealso cref="Run(double)" />
        void Run();

        /// <summary>
        /// Enters the game loop of the GameWindow using the specified update rate.
        /// </summary>
        void Run(double updateRate);

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();
    }
}
