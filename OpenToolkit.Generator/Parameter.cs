using System;

namespace OpenToolkit.Generator
{
    public enum ParameterModifer
    {
        None,
        In,
        Out,
        Ref
    }

    public struct Parameter
    {
        public string Description { get; }
        public ParameterModifer Modifier { get; }
        public Type Type { get; }
        public string Name { get; }

        public Parameter(string description, ParameterModifer modifier, Type type, string name)
        {
            Description = description;
            Modifier = modifier;
            Type = type;
            Name = name;
        }

        public override string ToString()
        {
            if (Modifier != ParameterModifer.None)
            {
                return $"{Modifier} {Type} {Name}";
            }
            return $"{Type} {Name}";
        }
    }
}
