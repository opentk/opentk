using System;
using System.Text;

namespace OpenToolkit.Generator
{
    public struct Extern : IMethod
    {
        public string DllName { get; }
        public string EntryPoint { get; }
        public string Summary { get; }
        public Type ReturnType { get; }
        public string Name { get; }
        public Parameter[] Parameters { get; }

        public Extern(string dllName, string entryPoint, string summary, Type returnType, string name, Parameter[] parameters)
        {
            DllName = dllName;
            EntryPoint = entryPoint;
            Summary = summary;
            ReturnType = returnType;
            Name = name;
            Parameters = parameters;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"[DllImport(\"{DllName}\", EntryPoint = \"{EntryPoint}\")]");
            builder.Append($"public static extern {ReturnType} {Name} (");
            for (int i = 0; i < Parameters.Length; i++)
            {
                var spacing = i == Parameters.Length - 1 ? "" : ", ";
                builder.Append(Parameters[i]);
                builder.Append(spacing);
            }
            builder.AppendLine(");");
            return builder.ToString();
        }
    }
}
