using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Method
    {
        public PType ReturnType { get; }
        public string Name { get; }
        public string EntryPoint { get; }
        public Parameter[] Parameters { get; }

        public Method(PType returnType, string name, string entryPoint, params Parameter[] parameters)
        {
            ReturnType = returnType;
            Name = name;
            EntryPoint = entryPoint;
            Parameters = parameters;
        }
    }
}
