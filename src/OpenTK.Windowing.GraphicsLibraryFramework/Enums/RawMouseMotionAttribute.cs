using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Attribute for setting toggling raw mouse motion.
    /// </summary>
    /// <seealso cref="GLFW.SetInputMode(Window*, RawMouseMotionAttribute, bool)"/>
    /// <seealso cref="GLFW.GetInputMode(Window*, RawMouseMotionAttribute)"/>
    public enum RawMouseMotionAttribute
    {
        /// <summary>
        /// Specify whether raw mouse motion should be used or not.
        /// </summary>
        RawMouseMotion = 0x00033005
    }
}
