using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Overload
    {
        public PType ReturnType { get; }
        public Parameter[] Parameters { get; }
        public Action<IndentedTextWriter> BodyWriter { get; }

        public Overload(PType returnType, Action<IndentedTextWriter> bodyWriter, params Parameter[] parameters)
        {
            ReturnType = returnType;
            Parameters = parameters;
            BodyWriter = bodyWriter;
        }
    }
}
