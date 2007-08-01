#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    #region class Enum

    public class Enum
    {
        public Enum()
        { }

        public Enum(string name)
        {
            Name = name;
        }

        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        System.Collections.Hashtable _constant_collection = new System.Collections.Hashtable();

        public System.Collections.Hashtable ConstantCollection
        {
            get { return _constant_collection; }
            set { _constant_collection = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public enum " + Name);
            sb.AppendLine("{");
            foreach (Constant c in ConstantCollection.Values)
            {
                sb.Append("    ");
                sb.Append(c.ToString());
                sb.AppendLine(",");
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    #endregion

    #region class EnumCollection

    class EnumCollection : Dictionary<string, Enum>
    {
        /*
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Bind.Structures.Enum e in this.Values)
            {
                sb.AppendLine(e.ToString());
            }

            return sb.ToString();
        }
        */
    }

    #endregion
}
