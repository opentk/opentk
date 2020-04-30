using System;

namespace OpenToolkit.Generator
{
    public struct Method
    {
        public string Summary { get; }
        public Type ReturnType { get; }
        public string Name { get; }
        public Parameter[] Parameters { get; }
        public string[] Body { get; }

        public Method(string summary, Type returnType, string name, Parameter[] parameters, string[] body)
        {
            Summary = summary;
            ReturnType = returnType;
            Name = name;
            Parameters = parameters;
            Body = body;
        }
    }
}
