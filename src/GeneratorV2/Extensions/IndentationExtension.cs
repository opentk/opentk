using System;
using System.CodeDom.Compiler;

namespace GeneratorV2.Extensions
{
    /*
    public static class IndentationExtension
    {
        public struct Scoping : IDisposable
        {
            private readonly IndentedTextWriter _textWriter;

            public Scoping(IndentedTextWriter textWriter)
            {
                _textWriter = textWriter;
                _textWriter.WriteLine('{');
                _textWriter.Indent++;
            }


            public void Dispose()
            {
                _textWriter.Indent--;

                _textWriter.WriteLine('}');
            }
        }
        public static Scoping Scope(this IndentedTextWriter writer)
        {
            return new Scoping(writer);
        }

        public struct Indent : IDisposable
        {
            private readonly IndentedTextWriter _textWriter;

            public Indent(IndentedTextWriter textWriter)
            {
                _textWriter = textWriter;
                _textWriter.Indent++;
            }


            public void Dispose()
            {
                _textWriter.Indent--;
            }
        }
        public static Indent Indentation(this IndentedTextWriter writer)
        {
            return new Indent(writer);
        }
    }*/
}
