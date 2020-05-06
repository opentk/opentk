using System;
using System.Text;

namespace OpenToolkit.Generator
{
    public struct Method
    {
        public string Summary { get; set; }
        public Attribute[] Attributes { get; }
        public Type ReturnType { get; }
        public string Name { get; }
        public Parameter[] Parameters { get; }
        public string[] Body { get; }

        public Method(Attribute[] attributes, Type returnType, string name, Parameter[] parameters, string[] body = null)
        {
            Summary = "";
            Attributes = attributes;
            ReturnType = returnType;
            Name = name;
            Parameters = parameters;
            Body = body;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            //TODO: Write summary.
            foreach (var a in Attributes)
            {
                builder.AppendLine(a.ToString());
            }
            builder.Append($"public static extern {ReturnType} {Name} (");
            for (int i = 0; i < Parameters.Length; i++)
            {
                builder.Append(Parameters[i]);
                var spacing = i == Parameters.Length - 1 ? "" : ", ";
                builder.Append(spacing);
            }

            if (Body == null)
            {
                builder.AppendLine(");");
                return builder.ToString();
            }

            //TODO: Make body.
            return builder.ToString();
        }
    }
}
