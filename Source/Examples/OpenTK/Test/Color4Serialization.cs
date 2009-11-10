#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using OpenTK.Graphics;

namespace Examples.Tests
{
    [Example("Color4 Serialization", ExampleCategory.OpenTK, "Test", Documentation="Color4Serialization")]
    public class Color4Serialization
    {
        public static void Main()
        {
            Color4 color = System.Drawing.Color.MidnightBlue;
            Color4 color2 = new Color4();

            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(typeof(Color4));
                xs.Serialize(stream, color);
                stream.Seek(0, SeekOrigin.Begin);
                color2 = (Color4)xs.Deserialize(stream);
                Trace.WriteLine(color);
                Trace.WriteLine(color2);
                Trace.WriteLine(color.Equals(color2));
            }
        }
    }
}
