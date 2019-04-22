//
// EnumTokenComparer.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace OpenTK.Convert
{
    /// <summary>
    /// Compares enumeration tokens in Khronos XML files.
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
