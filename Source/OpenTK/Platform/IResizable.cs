#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    public interface IResizable
    {
        int Height { get; set; }
        int Width { get; set; }
        /*
        int Top { get; }
        int Bottom { get; }
        int Left { get; }
        int Right { get; }
        */
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

        public override string ToString()
        {
            return String.Format("New size: {0}x{1}", Width, Height);
        }
    }
}
