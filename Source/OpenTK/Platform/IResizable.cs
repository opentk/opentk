using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    public interface IResizable
    {
        int Height { get; set; }
        int Width { get; set; }

        event ResizeEvent Resize;
    }

    public delegate void ResizeEvent(object sender, ResizeEventArgs e);
    
    public class ResizeEventArgs : EventArgs
    {
        public int Width, Height;

        public ResizeEventArgs()
        {
        }

        public ResizeEventArgs(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
