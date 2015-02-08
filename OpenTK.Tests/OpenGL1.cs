using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Tests
{
    [TestFixture]
    public class OpenGL1
    {
        [Test]
        public void ClearColor()
        {
            GameWindow window = new GameWindow(10, 10);

            OpenTK.Graphics.OpenGL.GL.ClearColor(OpenTK.Graphics.Color4.Red);
            OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit);

            OpenTK.Graphics.Color4[] pixels = new Graphics.Color4[10 * 10];
            OpenTK.Graphics.OpenGL.GL.ReadPixels(0, 0, 10, 10, 
                Graphics.OpenGL.PixelFormat.Rgba, Graphics.OpenGL.PixelType.Float, pixels);

            foreach (var pixel in pixels)
            {
                Assert.AreEqual(OpenTK.Graphics.Color4.Red, pixel);
            }
        }
    }
}
