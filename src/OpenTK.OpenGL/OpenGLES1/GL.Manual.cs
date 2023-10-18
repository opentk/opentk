using System;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.Graphics.OpenGLES1
{
    /// <summary>
    /// OpenGL ES 1
    /// </summary>
    public static unsafe partial class GL
    {
        // Right now this is the only method that actually takes a color besides a few FFP methods.
        // So currently its not worth it creating an overloader for these.
        // I also doubt there will ever be created new methods that take in a color.
        // 30-05-2021 FrederikJA
        /// <inheritdoc cref="ClearColor(float, float, float, float)"/>
        public static void ClearColor(Color4<Rgba> clearColor)
        {
            GL.ClearColor(clearColor.X, clearColor.Y, clearColor.Z, clearColor.W);
        }
    }
}
