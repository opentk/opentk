//
// Copyright (C) 2009 the Open Toolkit (http://www.opentk.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace OpenTK.Convert
{
    /// <summary>
    /// The base class for a parser.
    /// </summary>
    internal abstract class XmlParser
    {
        /// <summary>
        /// Gets or sets a prefix that should be removed from methods and tokens in the XML files, e.g. "gl", "cl", etc.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets the prefix for enumerations.
        /// </summary>
        public string EnumPrefix => Prefix.ToUpper() + "_";

        /// <summary>
        /// Gets the prefix for functions.
        /// </summary>
        public string FuncPrefix => Prefix;

        /// <summary>
        /// Parses and formats an XML file.
        /// </summary>
        /// <param name="lines">The lines of the XML file to parse.</param>
        /// <returns>The formatted elements.</returns>
        public abstract IEnumerable<XElement> Parse(string[] lines);

        /// <summary>
        /// Parses and formats an XML file located at the given path.
        /// </summary>
        /// <param name="path">The path to the XML file.</param>
        /// <returns>The formatted elements.</returns>
        public IEnumerable<XElement> Parse(string path)
        {
            string[] contents = null;
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using (var wb = new WebClient())
                {
                    var filename = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

                    try
                    {
                        wb.DownloadFile(path, filename);
                    }
                    catch (WebException e)
                    {
                        if (e.Message == "The remote server returned an error: (401) Unauthorized.")
                        {
                            Console.WriteLine(e.Message);
                            Console.Write("Username: ");
                            var username = Console.ReadLine();
                            Console.Write("Password: ");
                            var password = Console.ReadLine();

                            wb.UseDefaultCredentials = true;
                            wb.Credentials = new NetworkCredential(username, password);
                            wb.DownloadFile(path, filename);
                        }
                    }

                    contents = File.ReadAllLines(filename);
                    File.Delete(filename);
                }
            }
            else
            {
                // The file is on disk, just read it directly
                contents = File.ReadAllLines(path);
            }

            return Parse(contents);
        }

        /// <summary>
        /// Trims prefixes from the given string.
        /// </summary>
        /// <param name="name">The string to trim.</param>
        /// <returns>The trimmed string.</returns>
        public string TrimName(string name)
        {
            if (name.StartsWith(EnumPrefix))
            {
                return name.Remove(0, EnumPrefix.Length);
            }

            if (name.StartsWith(FuncPrefix))
            {
                return name.Remove(0, FuncPrefix.Length);
            }

            return name;
        }
    }
}
