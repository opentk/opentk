using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class Argument
    {
        public string Type { get; }
        public string Name { get; }

        public Argument(Parameter parameter) : this(parameter.Type.Name, parameter.Name)
        {
        }

        public Argument(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public Argument Clone(string type, string name) => new Argument(type, name);
        public Argument CloneWithType(string type) => new Argument(type, Name);

        public Argument CloneWithName(string name) => new Argument(Type, name);

    }
}
