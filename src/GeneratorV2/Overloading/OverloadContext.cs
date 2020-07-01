using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class OverloadContext
    {
        public Command Command { get; }

        public List<Parameter> Parameters { get; } = new List<Parameter>();
        public List<string> Arguments { get; } = new List<string>();

        public OverloadContext(Command command)
        {
            Command = command;

            foreach(var p in Method.Parameters)
            {
                Parameters.Add(p);
                Arguments.Add(p.Name);
            }
        }

        public Method Method => Command.Method;
    }
}
