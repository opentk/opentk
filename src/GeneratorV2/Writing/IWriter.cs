using GeneratorV2.Data;
using GeneratorV2.Parsing;
using System.CodeDom.Compiler;

namespace GeneratorV2.Writing
{
    public interface ISingleWriter<T> : ISubWriter<IndentedTextWriter, T>
    {
    }

    public interface IWriter<T> : ISubWriter<T, Specification>
    { }

    public interface ISubWriter<T, U>
    {
        void Write(T input, U output);
    }
}
