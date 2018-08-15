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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using CommandLine;

namespace OpenTK.Convert
{
    /// <summary>
    /// Class to compare Enum tokens.
    /// </summary>
    internal class EnumTokenComparer : IEqualityComparer<XNode>
    {
        /// <inheritdoc />
        public bool Equals(XNode a, XNode b)
        {
            var a_attr = ((XElement)a).Attribute("name") ?? ((XElement)a).Attribute("token");
            var b_attr = ((XElement)b).Attribute("name") ?? ((XElement)b).Attribute("token");
            return a_attr.Value == b_attr.Value;
        }

        /// <inheritdoc />
        public int GetHashCode(XNode a)
        {
            var e = (XElement)a;
            if (e.Name == "enum" || e.Name == "token" || e.Name == "function")
            {
                return ((XElement)a).Attribute("name").Value.GetHashCode() ^ e.Name.LocalName.GetHashCode();
            }

            if (e.Name == "use")
            {
                return ((XElement)a).Attribute("token").Value.GetHashCode();
            }

            throw new InvalidOperationException($"Unknown element type: {e}");
        }
    }
}
