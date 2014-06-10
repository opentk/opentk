using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using OpenTK;
using OpenTK.Graphics.ES11;

namespace ES11
{

    public class Application
    {
        // This is the main entry point of the application.
        [Export("_SDL_main")]
        static void Main(string[] args)
        {
            using (Toolkit.Init())
            using (var gw = new GameWindow())
            {
                gw.RenderFrame += (sender, e) =>
                {
                    GL.ClearColor(0.0f, 0.0f, 0.5f, 0.0f);
                    GL.Clear(ClearBufferMask.ColorBufferBit);

                    gw.SwapBuffers();
                };
                gw.Run(60);
            }

            /*
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            */
        }
    }
}
