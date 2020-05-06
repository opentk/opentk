using System.Text;

namespace OpenToolkit.Generator
{

    public struct Attribute
    {
        public string Name { get; }
        public (string, object)[] Parameters { get; }

        public Attribute(string name, (string, object)[] parameters)
        {
            Name = name;
            Parameters = parameters;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append($"[{Name}(");
            for (int i = 0; i < Parameters.Length; i++)
            {
                var value = Parameters[i].Item2.ToString();
                if (Parameters[i].Item2 is string)
                {
                    value = $"\"{value}\"";
                }

                if (Parameters[i].Item1 == null)
                {
                    builder.Append(value);
                }
                else
                {
                    builder.Append($"{Parameters[i].Item1} = {value}");
                }

                var spacing = i == Parameters.Length - 1 ? "" : ", ";
                builder.Append(spacing);
            }
            builder.Append(")]");

            return builder.ToString();
        }
    }
}
