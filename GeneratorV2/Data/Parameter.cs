using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Parameter
    {
        public string Type { get; }
        public string Name { get; }
        public string? Group { get; }
        public string? Length { get; }

        public Parameter (string type, string name, string? group = null, string? length = null)
        {
            Type = type;
            Name = name;
            Group = group;
            Length = length;
        }
    }
}
