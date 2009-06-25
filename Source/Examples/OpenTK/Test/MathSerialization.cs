#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

#if false

using System.Xml.Serialization;


namespace Examples.Tests
{
    [Example("Serialization", ExampleCategory.Test)]
    public class MathSerialization
    {
        public static void Main()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(typeof(Matrix4));

                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.NewLineHandling = NewLineHandling.Entitize;
                    settings.Indent = true;
                    XmlWriter xw = XmlTextWriter.Create(stream, settings);

                    xs.Serialize(xw, Matrix4.Identity);

                    xw.Close();
                }

                stream.Position = 0;
                byte[] text = new byte[stream.Length];
                int pos = 0;
                do
                {
                    pos += stream.Read(text, pos, (int)stream.Length);
                }
                while (pos != stream.Length);

                Console.WriteLine(System.Text.Encoding.Default.GetChars(text));

                stream.Position = 0;
                Matrix4 matrix = (Matrix4)xs.Deserialize(stream);

                if (Matrix4.Identity == matrix)
                    Console.WriteLine("Matrix deserialized correctly.");
                else
                    Console.WriteLine("Error deserializing matrix.");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(false);
            }
        }
    }
}

#endif