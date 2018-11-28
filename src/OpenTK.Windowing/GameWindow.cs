//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Interfaces;

namespace OpenToolkit.Windowing
{
    public class GameWindow: NativeWindow, IGameWindow
    {
        public GameWindow()
            : base()
        {
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ProcessEvents()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Run(double updateRate)
        {
            throw new NotImplementedException();
        }

        public void MakeCurrent()
        {
            throw new NotImplementedException();
        }

        public void SwapBuffers()
        {
            throw new NotImplementedException();
        }
    }
}
