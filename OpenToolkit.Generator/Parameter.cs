using System;

namespace OpenToolkit.Generator
{
    public struct Parameter
    {
        public string Description { get; }
        public Type Type { get; }
        public string Name { get; }

        public Parameter(string description, Type type, string name)
        {
            Description = description;
            Type = type;
            Name = name;
        }
    }
}
