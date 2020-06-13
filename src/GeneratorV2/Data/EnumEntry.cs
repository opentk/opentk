using System;
using System.Diagnostics.CodeAnalysis;

namespace GeneratorV2.Data
{
    public enum EnumType
    {
        None,
        Bitmask
    }

    public class EnumEntry : IEquatable<EnumEntry>
    {
        public string Name { get; }
        public string? Api { get; }
        public string MangledName { get; }
        public ulong Value {get;}

        public string[] Groups {get;}

        public EnumType Type { get; }

        public EnumEntry(string name, string? api, string mangledName, ulong value, string[] groups, EnumType type)
        {
            Name = name;
            Api = api;
            MangledName = mangledName;
            Value = value;
            Groups = groups;
            Type = type;
        }

        public bool Equals([AllowNull] EnumEntry other)
        {
            return Name == other?.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
