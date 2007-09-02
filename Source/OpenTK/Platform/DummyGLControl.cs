using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// A dummy GLControl to be used inside the Visual Studio designer.
    /// </summary>
    internal class DummyGLControl : IGLControl
    {
        bool fullscreen;
        IGLContext glContext = new DummyGLContext();

        #region --- IGLControl Members ---

        public bool IsIdle
        {
            get
            {
                return false;
            }
        }

        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                fullscreen = value;
            }
        }

        public IGLContext Context
        {
            get
            {
                return glContext;
            }
        }

        #endregion
    }
}
