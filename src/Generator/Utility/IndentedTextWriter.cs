using System;
using System.IO;

namespace Generator.Utility
{
    public class IndentedTextWriter : IDisposable
    {
        // PR
        public TextWriter Writer;
        public int CurrentIndentation = 0;
        public int IndentationWidth = 4;

        public IndentedTextWriter(string filePath)
        {
            Writer = new StreamWriter(File.OpenWrite(filePath));
        }

        public IndentedTextWriter(TextWriter writer)
        {
            Writer = writer;
        }

        public void WriteIndentation()
        {
            int indents = CurrentIndentation * IndentationWidth;
            for (int i = 0; i < indents; i++)
            {
                Writer.Write(' ');
            }
        }

        // FIXME
        public void Write(string str) => Writer.Write(str);

        public void WriteLine() => Writer.WriteLine();

        public void WriteLine(string str)
        {
            WriteIndentation();
            Writer.WriteLine(str);
        }

        public void Flush() => Writer.Flush();

        public Indentation Indent()
        {
            CurrentIndentation++;
            return new Indentation(this);
        }

        // Utility method for creating a cs scope "{}".
        public CsScope CsScope()
        {
            WriteLine("{");
            return new CsScope(Indent());
        }

        public void Dispose()
        {
            Writer.Flush();
            Writer.Dispose();
            GC.SuppressFinalize(this);
        }
    }

    public struct CsScope : IDisposable
    {
        public Indentation Indentation;

        public CsScope(Indentation indentation)
        {
            Indentation = indentation;
        }

        public void Dispose()
        {
            Indentation.Dispose();
            Indentation.Writer.WriteLine("}");
        }
    }

    public struct Indentation : IDisposable
    {
        public readonly IndentedTextWriter Writer;

        public Indentation(IndentedTextWriter writer)
        {
            Writer = writer;
        }

        public void Dispose()
        {
            Writer.CurrentIndentation--;
        }
    }
}
