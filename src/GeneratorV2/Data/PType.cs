using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class PType
    {
        public readonly GLType Type;
        public readonly string? Group;
        
        public PType(GLType type, string? group)
        {
            Type = type;
            Group = group;
        }
    }
}
