//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.GraphicsLibraryFramework;
using OpenToolkit.Windowing.Interfaces;

namespace OpenToolkit.Windowing
{
    public class GameWindow
    {
        private static GLFW glfw = null;
        private readonly unsafe Window* windowPtr = null;


        public GameWindow(int width = 640, int height = 480, string title = "", bool windowedFullscreen = false)
        {
            if (glfw == null)
            {
                glfw = GLFW.GetAPI();
                glfw.Init();
            }


            unsafe
            {
                var monitor = glfw.GetPrimaryMonitor();
                if (windowedFullscreen)
                {
                    var modePtr = glfw.GetVideoMode(monitor);
                    glfw.WindowHint(WindowHint.GLFW_RED_BITS, modePtr->redBits);
                    glfw.WindowHint(WindowHint.GLFW_GREEN_BITS, modePtr->greenBits);
                    glfw.WindowHint(WindowHint.GLFW_BLUE_BITS, modePtr->blueBits);
                    glfw.WindowHint(WindowHint.GLFW_REFRESH_RATE, modePtr->refreshRate);
                    windowPtr = glfw.CreateWindow(modePtr->width, modePtr->height, title, monitor, null);
                }
                else
                {
                    windowPtr = glfw.CreateWindow(width, height, title, null, null);
                }
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Free managed resources
                }

                // Free unmanaged resources
                unsafe {
                    if(windowPtr != null)
                    {
                        glfw.DestroyWindow(windowPtr);
                    }
                }
                glfw.Terminate();

                disposedValue = true;
            }
        }

        ~GameWindow()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
