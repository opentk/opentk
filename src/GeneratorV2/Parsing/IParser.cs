using GeneratorV2.Data;

namespace GeneratorV2.Parsing
{
    public interface IParser<T>
    {
        void Parse(T input, Specification output);
    }
}
