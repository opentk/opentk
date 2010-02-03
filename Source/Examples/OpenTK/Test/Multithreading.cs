#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
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
using System.Text;
using System.Threading;

namespace Examples.Tests
{
    [Example("Multithreading Test", ExampleCategory.OpenTK, "Test")]
    class Multithreading
    {
        public static void Main()
        {
            const int ThreadCount = 2;
            List<Thread> threads = new List<Thread>();

            // launch threads
            for (int i = 0; i < ThreadCount; i++)
            {
                Thread t = new Thread(RunGame);
                t.IsBackground = true;
                t.Priority = ThreadPriority.BelowNormal;
                t.Start();
                threads.Add(t);
            }

            // wait for exit
            foreach (Thread t in threads)
            {
                t.Join();
            }
        }

        static void RunGame()
        {
            using (Tutorial.T03_Immediate_Mode_Cube game = new Examples.Tutorial.T03_Immediate_Mode_Cube())
            {
                Utilities.SetWindowTitle(game);
                game.Keyboard.KeyUp += delegate(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
                {
                    if (e.Key == OpenTK.Input.Key.F11)
                    {
                        if  (game.WindowState == OpenTK.WindowState.Fullscreen)
                            game.WindowState = OpenTK.WindowState.Normal;
                        else
                            game.WindowState = OpenTK.WindowState.Fullscreen;
                    }
                };
                game.Run(30.0);
            }
        }
    }
}
