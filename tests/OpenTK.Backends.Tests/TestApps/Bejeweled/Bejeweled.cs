using glTFLoader;
using glTFLoader.Schema;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Audio.OpenAL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using StbVorbisSharp;
using System.Text;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Reflection.Metadata;

namespace OpenTK.Backends.Tests.Bejeweled
{
    [TestApp]
    internal class Bejeweled : ITestApp
    {
        public string Name => "Bejeweled";

        private global::Bejeweled.Bejeweled BejeweledGame = new global::Bejeweled.Bejeweled();

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            BejeweledGame.Initialize(window, context, useGLES, Program.Logger);
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
