using System;
using System.CodeDom.Compiler;

namespace GeneratorV2.Data
{
    public class Overload
    {
        public PType ReturnType { get; }
        public Parameter[] Parameters { get; }
        public Action<IndentedTextWriter, string> BodyWriter { get; }

        public Overload(PType returnType, Action<IndentedTextWriter, string> bodyWriter, params Parameter[] parameters)
        {
            ReturnType = returnType;
            Parameters = parameters;
            BodyWriter = bodyWriter;
        }
    }
}
