using System;
using System.Text;

namespace OpenToolkit.Generator
{
    public enum ParameterModifer
    {
        None,
        Const,
        In,
        Out,
        Ref
    }

    public struct Parameter
    {
        public string Description { get; }
        public Attribute[] Attributes { get; }
        public ParameterModifer Modifier { get; }
        public Type Type { get; }
        public string Name { get; }

        public Parameter(Attribute[] attributes, ParameterModifer modifier, Type type, string name)
        {
            Description = "";
            Attributes = attributes;
            Modifier = modifier;
            Type = type;
            Name = name;
        }

        public override string ToString()
        {
            var attribute = new StringBuilder();
            foreach (var a in Attributes)
            {
                attribute.Append(a.ToString());
                attribute.Append(" ");
            }

            var modifier = Modifier == ParameterModifer.None || Modifier == ParameterModifer.Const ? "" : (Modifier + " ");

            return $"{attribute}{modifier}{Type?.Name} {Name}";
        }
    }
}
