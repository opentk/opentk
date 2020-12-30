using GeneratorV2.Writing2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    /*
    public class OverloadContext
    {
        public Command Command { get; }
        public int TypeParameterCount { get; set; } = 0;

        public Parameter?[] Parameters { get; }

        public PType ReturnType { get; set; }

        public OverloadContext(Command command)
        {
            Command = command;
            ReturnType = command.Method.ReturnType;

            var parameters = Command.Method.Parameters;
            Parameters = new Parameter?[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                var p = parameters[i];
                Parameters[i] = p;
            }
        }

        public Method Method => Command.Method;
    }*/

    public class OverloadContext2
    {
        public readonly NativeFunction Function;
        public readonly Parameter?[] Parameters;
        public readonly ICSType ReturnType;

        public OverloadContext2(NativeFunction function)
        {
            Function = function;

            Parameters = function.Parameters.ToArray();
            ReturnType = function.ReturnType;
        }
    }
}
