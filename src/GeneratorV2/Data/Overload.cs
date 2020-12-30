using System;
using System.CodeDom.Compiler;

namespace GeneratorV2.Data
{
    public class OverloadOld
    {
        public PType ReturnType { get; }
        public Parameter[] Parameters { get; }
        //public Action<IndentedTextWriter, string> BodyWriter { get; }
        public int TypeParameterCount { get; }

        public OverloadOld(PType returnType, Action<IndentedTextWriter, string> bodyWriter,int typeParameters, params Parameter[] parameters)
        {
            ReturnType = returnType;
            Parameters = parameters;
            //BodyWriter = bodyWriter;
            TypeParameterCount = typeParameters;
        }
    }
}
