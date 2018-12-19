namespace OpenTK.BuildTools.Common
{
    public class Type
    {
        public bool IsPointer { get; set; }
        public bool IsArray { get; set; }
        public int IndirectionLevels { get; set; }
        public int ArrayDimensions { get; set; }
        public string Name { get; set; }
    }
}