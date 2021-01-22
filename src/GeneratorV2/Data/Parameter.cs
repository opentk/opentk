namespace GeneratorV2.Data
{
    // TODO: Think about name
    // Previous name: Parameter
    public class GLParameter
    {
        public readonly PType Type;
        public readonly string Name;
        public readonly IExpression? Length;

        public GLParameter(PType type, string name, IExpression? length)
        {
            Type = type;
            Name = name;
            Length = length;
        }
    }
}
