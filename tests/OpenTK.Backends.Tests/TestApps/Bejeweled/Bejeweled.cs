﻿using OpenTK.Platform;
using System;

namespace OpenTK.Backends.Tests.Bejeweled
{
    [TestApp]
    internal class Bejeweled : ITestApp
    {
        public static string Name => "Bejeweled";
        
        private global::Bejeweled.Bejeweled BejeweledGame = new global::Bejeweled.Bejeweled();

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            BejeweledGame.Initialize(window, context, useGLES, Program.Logger);
            BejeweledGame.TransitionToGame();
        }

        public void HandleEvent(EventArgs args)
        {
            //BejeweledGame.HandleEvent(args);
        }

        public bool Update(float deltaTime)
        {
            return BejeweledGame.Update(deltaTime);
        }

        public void Render()
        {
            BejeweledGame.Render();
        }

        public void Deinitialize()
        {
            BejeweledGame.Deinitialize();
        }
    }
}
