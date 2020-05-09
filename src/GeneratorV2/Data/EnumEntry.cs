using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public enum EnumType
    {
        None,
        Bitmask
    }

    public class EnumEntry
    {
        public string Name {get;}
        public ulong Value {get;}

        public string[] Groups {get;}

        public EnumType Type { get; }

        public EnumEntry(string name, ulong value, string[] groups, EnumType type)
        {
            Name = name;
            Value = value;
            Groups = groups;
            Type = type;
        }
    }
}
