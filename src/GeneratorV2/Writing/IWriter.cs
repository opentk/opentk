using GeneratorV2.Data;
using GeneratorV2.Parsing;
using System.CodeDom.Compiler;

namespace GeneratorV2.Writing
{
    public interface ISingleWriter<T> : ISubWriter<TIndentedTextWriter, T>
    {
    }

    public interface IWriter<T> : ISubWriter<Specification, T>
    { }

    public interface ISubWriter<T, U>
    {
        void Write(T input, U output);
    }
}
