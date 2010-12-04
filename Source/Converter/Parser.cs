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

using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace CHeaderToXML
{
    // The base class for a parser.
    abstract class Parser
    {
        // Defines a prefix that should be removed from methods and tokens in the XML files, e.g. "gl", "cl", etc.
        public string Prefix { get; set; }
        
        // Defines the version of the spec files (optional).
        public string Version { get; set; }

        // Implements the parsing logic for a specific input file.
        public abstract IEnumerable<XElement> Parse(string[] lines);

        public IEnumerable<XElement> Parse(string path)
        {
            string[] contents = null;
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using (var wb = new WebClient())
                {
                    string filename = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                    wb.DownloadFile(path, filename);
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
    }
}
