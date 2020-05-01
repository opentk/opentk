using System;

namespace OpenToolkit.Generator
{
    public struct Overload : IMethod
    {
        public string Summary { get; }
        public Type ReturnType { get; }
        public string Name { get; }
        public Parameter[] Parameters { get; }
        public string[] Body { get; }

        public Overload(string summary, Type returnType, string name, Parameter[] parameters, string[] body = null)
        {
            Summary = summary;
            ReturnType = returnType;
            Name = name;
            Parameters = parameters;
            Body = body ?? new string[]{"throw new System.NotImplementedException();"};
        }
    }
}
