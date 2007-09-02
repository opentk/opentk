#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;
using OpenTK.OpenGL;

namespace Examples.Tutorial
{
    class T04_Lit_Cube : GameWindow//, IExample
    {
        public T04_Lit_Cube()
        {
            CreateWindow(new DisplayMode(800, 600));
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            //GL.ARB.
        }

        #region IExample Members

        public void Launch()
        {
            this.Run();
        }

        #endregion
    }
}
