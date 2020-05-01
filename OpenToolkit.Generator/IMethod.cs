using System;

namespace OpenToolkit.Generator
{
    public interface IMethod
    {
        public string Summary { get; }
        public Type ReturnType { get; }
        public string Name { get; }
        public Parameter[] Parameters { get; }
    }
}
