namespace GeneratorV2.Data
{
    public class Parameter
    {
        public PType Type { get; }
        public string Name { get; }

        public Parameter (PType type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    // TODO: Think about name
    public class GLParameter
    {
        public readonly PType2 Type;
        public readonly string Name;
        public readonly IExpression? Length;

        public GLParameter(PType2 type, string name, IExpression? length)
        {
            Type = type;
            Name = name;
            Length = length;
        }
    }
}
