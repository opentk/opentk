using System;
using System.CodeDom.Compiler;

namespace VkGenerator.Utility.Extensions
{
    public static class IndentedTextWriterExtension
    {
        public static Indentation Indent(this IndentedTextWriter writer)
        {
            return new Indentation(writer);
        }

        // Utility method for creating a cs scope "{}".
        public static CsScope CsScope(this IndentedTextWriter writer)
        {
            return new CsScope(writer);
        }
    }

    public readonly struct Indentation : IDisposable
    {
        public readonly IndentedTextWriter Writer;

        public Indentation(IndentedTextWriter writer)
        {
            Writer = writer;
            Writer.Indent++;
        }

        public void Dispose()
        {
            Writer.Indent--;
        }
    }

    public readonly struct CsScope : IDisposable
    {
        public readonly IndentedTextWriter Writer;

        public CsScope(IndentedTextWriter writer)
        {
            Writer = writer;
            Writer.WriteLine("{");
            Writer.Indent++;
        }

        public void Dispose()
        {
            Writer.Indent--;
            Writer.WriteLine("}");
        }
    }
}
