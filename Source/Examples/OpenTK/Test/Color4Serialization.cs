// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

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
