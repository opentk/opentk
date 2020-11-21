using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class PType2
    {
        public readonly GLType Type;
        public readonly string? Group;
        public IExpression? Length;

        public PType2(GLType type, string? group, IExpression? length)
        {
            Type = type;
            Group = group;
            Length = length;
        }
    }
}
