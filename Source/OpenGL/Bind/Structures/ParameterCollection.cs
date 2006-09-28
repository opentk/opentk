/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    public class ParameterCollection : List<Parameter>
    {
        #region Constructors

        public ParameterCollection()
        {
        }

        #endregion

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            if (this.Count > 0)
            {
                foreach (Parameter p in this)
                {
                    sb.Append(p.ToString());
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
                sb.Append(")");

            return sb.ToString();
        }

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.Type == type)
                    return true;
            return false;
        }
    }
}
