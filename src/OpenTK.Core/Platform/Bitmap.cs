using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    public class Bitmap
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public byte[] Data { get; private set; }

        public Bitmap(int width, int height, byte[] data)
        {
            Width = width;
            Height = height;
            Data = data;
        }
    }
}
