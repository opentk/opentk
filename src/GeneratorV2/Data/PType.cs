namespace GeneratorV2.Data
{
    public enum PModifier
    {
        None = 0,
        ReadOnlySpan = 1,
        In = 2,
    }
    public class PType
    {
        public string Name { get; }
        public string OriginalTypeName { get; }
        public PModifier Modifier { get; }
        public string? Group { get; }
        public IExpression? Length { get; set; }

        public PType(string name, string originalTypeName, PModifier modifier = PModifier.None, string? group = null, IExpression? length = null)
        {
            Name = name;
            OriginalTypeName = originalTypeName;
            Modifier = modifier;
            Group = group;
            Length = length;
        }
    }
}
