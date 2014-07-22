// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

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
                game.KeyUp += delegate(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
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
