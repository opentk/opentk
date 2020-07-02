using System;
using System.CodeDom.Compiler;

namespace GeneratorV2.Data
{
    public class Overload
    {
        public PType ReturnType { get; }
        public Parameter[] Parameters { get; }
        public Action<IndentedTextWriter, string> BodyWriter { get; }
        public int TypeParameterCount { get; }

        public Overload(PType returnType, Action<IndentedTextWriter, string> bodyWriter,int typeParameters, params Parameter[] parameters)
        {
            ReturnType = returnType;
            Parameters = parameters;
            BodyWriter = bodyWriter;
            TypeParameterCount = typeParameters;
        }
    }
}
