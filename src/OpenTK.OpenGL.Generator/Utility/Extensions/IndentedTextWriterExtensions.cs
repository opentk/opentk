using System;
using System.CodeDom.Compiler;

namespace OpenTK.OpenGL.Generator.Utility.Extensions
{
    internal static class IndentedTextWriterExtension
    {
        internal static Indentation Indent(this IndentedTextWriter writer)
        {
            return new Indentation(writer);
        }

        // Utility method for creating a cs scope "{}".
        internal static CsScope CsScope(this IndentedTextWriter writer)
        {
            return new CsScope(writer);
        }
    }

    internal readonly struct Indentation : IDisposable
    {
        internal readonly IndentedTextWriter Writer;

        internal Indentation(IndentedTextWriter writer)
        {
            Writer = writer;
            Writer.Indent++;
        }

        public void Dispose()
        {
            Writer.Indent--;
        }
    }

    internal readonly struct CsScope : IDisposable
    {
        internal readonly IndentedTextWriter Writer;

        internal CsScope(IndentedTextWriter writer)
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
