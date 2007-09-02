#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind.Structures
{
    #region class Enum

    public class Enum
    {
        internal static EnumCollection GLEnums;
        internal static EnumCollection AuxEnums;

        private static bool enumsLoaded;

        internal static void Initialize(string enumFile, string enumextFile, string auxFile)
        {
            Initialize(enumFile, enumextFile);

            using (System.IO.StreamReader sr = new System.IO.StreamReader(Path.Combine(Settings.InputPath, "GL2\\enum.spec")))
            {
                AuxEnums = Bind.MainClass.Generator.ReadEnums(sr);
            }
        }

        internal static void Initialize(string enumFile, string enumextFile)
        {
            if (!enumsLoaded)
            {
                if (!String.IsNullOrEmpty(enumFile))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, enumFile))
                    {
                        GLEnums = Bind.MainClass.Generator.ReadEnums(sr);
                    }
                }

                if (!String.IsNullOrEmpty(enumextFile))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, enumextFile))
                    {
                        foreach (Bind.Structures.Enum e in Bind.MainClass.Generator.ReadEnums(sr).Values)
                        {
                            //enums.Add(e.Name, e);
                            Utilities.Merge(GLEnums, e);
                        }
                    }
                }
                enumsLoaded = true;
            }
        }
          

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
        internal void AddRange(EnumCollection enums)
        {
            foreach (Enum e in enums.Values)
            {
                Utilities.Merge(this, e);
            }
        }

        internal void Translate()
        {
            foreach (Enum e in this.Values)
            {
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    // There are cases when a value is an aliased constant, with no enum specified.
                    // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
                    // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                    if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
                    {
                        foreach (Enum @enum in this.Values)
                        {
                            // Skip generic GLenum
                            if (@enum.Name == "GLenum")
                                continue;

                            if (@enum.ConstantCollection.ContainsKey(c.Value))
                            {
                                c.Reference = @enum.Name;
                            }
                        }
                    }
                }
            }
        }
    }

    #endregion
}
