using System;

namespace OpenTK.Core.Platform
{
    public struct DialogFileFilter : IEquatable<DialogFileFilter>
    {
        public string Name;
        public string Filter;

        public DialogFileFilter(string name, string filter)
        {
            Name = name;
            Filter = filter;
        }

        public override bool Equals(object obj)
        {
            return obj is DialogFileFilter filter && Equals(filter);
        }

        public bool Equals(DialogFileFilter other)
        {
            return Name == other.Name &&
                   Filter == other.Filter;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Filter);
        }

        public static bool operator ==(DialogFileFilter left, DialogFileFilter right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DialogFileFilter left, DialogFileFilter right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{Name} - {Filter}";
        }
    }
}

